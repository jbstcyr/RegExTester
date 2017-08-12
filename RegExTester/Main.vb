Imports System.ComponentModel
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Math
Imports MyHelpers





Public Class Main
	Private IgnoreTextChange As Boolean = False
	Private ParseError As Boolean = False
	Private EvenColor As Color = Color.Aqua
	Private OddColor As Color = Color.Chartreuse

	Private _loading As Boolean = True

	Dim rslt As New StringBuilder

	Dim psltpos As Integer = 0
	Dim psltlen As Integer = 0
	Dim prtf As String = String.Empty

	Dim csltpos As Integer = 0
	Dim csltlen As Integer = 0

	Dim WithinInput As Boolean = False

	Private Sub pattern_TextChanged(sender As Object, e As EventArgs) Handles Pattern.TextChanged
		Input.SuspendLayout()
		If Not IgnoreTextChange Then
			My.Settings.Pattern = Pattern.Text
			Errors.Text = ""
			ParseError = False
			performMatching()
			Pattern.Focus()
		End If
		Input.ResumeLayout()
		'Debug.Print("Pattern_TextChanged IgnoreTextChanged = {0} ParseError = {1}", IgnoreTextChange, ParseError)
	End Sub

	Private Sub Input_TextChanged(sender As Object, e As EventArgs)
		If Not IgnoreTextChange Then
			My.Settings.Input = Input.Text
			performMatching()
			Input.Focus()
		End If
		'Debug.Print("Input_TextChanged IgnoreTextChanged = {0} ParseError = {1}", IgnoreTextChange, ParseError)
	End Sub

	Private Sub ClearFormatting(rtb As RichTextBox)
		IgnoreTextChange = True
		rtb.SuspendLayout()

		With rtb
			'			.Focus()
			Dim bstart = .SelectionStart
			Dim blen = .SelectionLength
			.SelectionStart = 0
			.SelectionLength = Len(.Text)
			.SelectionColor = Color.FromArgb(0, 0, 0)
			.SelectionBackColor = Color.White
			.SelectionStart = bstart
			.SelectionLength = blen
			'			.Refresh()
		End With
		IgnoreTextChange = False
		rtb.ResumeLayout()
		'Debug.Print("ClearFormatting IgnoreTextChanged = {0} ParseError = {1}", IgnoreTextChange, ParseError)
	End Sub


	'Private Sub Pattern_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Pattern.KeyPress
	'	If e.KeyChar = Convert.ToChar(1) Then
	'		DirectCast(sender, TextBox).SelectAll()
	'		e.Handled = True
	'	End If

	'End Sub

	'Private Sub Input_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Input.KeyPress
	'	If e.KeyChar = Convert.ToChar(1) Then
	'		DirectCast(sender, TextBox).SelectAll()
	'		e.Handled = True
	'	End If

	'End Sub

	Private Sub performMatching()
		Dim slines() As String

		If cbSeparateLines.Checked Then
			slines = Split(Input.Text, vbLf)
		Else
			ReDim slines(0)
			slines(0) = Input.Text
		End If

		ClearFormatting(Input)
		Results.Clear()

		rslt.Clear()
		For i = 0 To slines.Count - 1
			rslt.AppendLine("++++++++++++++++++++++++++++++++++++++++++++")
			MatchLine(i, slines(i))
			rslt.AppendLine("--------------------------------------------")
		Next
		Results.Text = rslt.ToString


	End Sub


	Private Sub MatchLine(lineno As Integer, reinput As String)
		Dim re As Regex
		Dim reoptions As RegexOptions

		reoptions = RegexOptions.None
		reoptions = reoptions Or If(cbIgnoreCase.Checked, RegexOptions.IgnoreCase, RegexOptions.None)
		reoptions = reoptions Or If(cbIgnoreWhitespace.Checked, RegexOptions.IgnorePatternWhitespace, RegexOptions.None)
		reoptions = reoptions Or If(cbExplicitCapture.Checked, RegexOptions.ExplicitCapture, RegexOptions.None)
		reoptions = reoptions Or If(cbCultureInvariant.Checked, RegexOptions.CultureInvariant, RegexOptions.None)
		reoptions = reoptions Or If(cbSingleline.Checked, RegexOptions.Singleline, RegexOptions.None)
		reoptions = reoptions Or If(cbMultiline.Checked, RegexOptions.Multiline, RegexOptions.None)
		reoptions = reoptions Or If(cbRightToLeft.Checked, RegexOptions.RightToLeft, RegexOptions.None)
		reoptions = reoptions Or If(cbECMAScript.Checked, RegexOptions.ECMAScript, RegexOptions.None)

		re = New Regex(Pattern.Text, reoptions)
		MatchCount.Text = re.Matches(reinput).Count
		Dim matches As MatchCollection = re.Matches(reinput)
		For i = 0 To matches.Count - 1
			rslt.AppendFormat("[i] = {0} [Match] = {1} [Success] = {2} [Index] = {3} [Length] = {4} [Capture Count] = {5}", i, matches(i).ToString, matches(i).Success, matches(i).Index, matches(i).Length, matches(i).Captures.Count).AppendLine()
			For j = 1 To matches(i).Groups.Count - 1
				rslt.AppendFormat("   [i] = {0} [j] = {1} [Group] = {2} [Group Name] = {3} [Success] = {4} [Index] = {5} [Length] = {6} [Capture Count] = {7}", i, j, matches(i).Groups(j).ToString, re.GroupNameFromNumber(j), matches(i).Groups(j).Success, matches(i).Groups(j).Index, matches(i).Groups(j).Length, matches(i).Groups(j).Captures.Count).AppendLine()
				For k = 0 To matches(i).Groups(j).Captures.Count - 1
					rslt.AppendFormat("       [i] = {0} [j] = {1} [k] = {2} [Capture] = {3} [Index] = {4} [Length] = {5}", i, j, k, matches(i).Groups(j).Captures(k).ToString, matches(i).Groups(j).Captures(k).Index, matches(i).Groups(j).Captures(k).Length).AppendLine()
					Input.Select(Input.GetFirstCharIndexFromLine(lineno) + matches(i).Groups(j).Captures(k).Index, matches(i).Groups(j).Captures(k).Length)
					Select Case re.GroupNameFromNumber(j)
						Case "fullname"
							Input.SelectionBackColor = Color.Red
						Case "nickname"
							Input.SelectionBackColor = Color.Teal
					End Select
				Next
			Next
		Next

	End Sub

	Private Sub cbIgnoreCase_CheckedChanged(sender As Object, e As EventArgs) Handles cbIgnoreCase.CheckedChanged
		My.Settings.IgnoreCase = cbIgnoreCase.Checked
		performMatching()
	End Sub

	Private Sub cbRightToLeft_CheckedChanged(sender As Object, e As EventArgs) Handles cbRightToLeft.CheckedChanged
		My.Settings.RightToLeft = cbRightToLeft.Checked
		performMatching()
	End Sub

	Private Sub cbMultiline_CheckedChanged(sender As Object, e As EventArgs) Handles cbMultiline.CheckedChanged
		My.Settings.MultilLine = cbMultiline.Checked
		performMatching()
	End Sub

	Private Sub cbSingleline_CheckedChanged(sender As Object, e As EventArgs) Handles cbSingleline.CheckedChanged
		My.Settings.SingleLine = cbSingleline.Checked
		performMatching()
	End Sub

	Private Sub cbCultureInvariant_CheckedChanged(sender As Object, e As EventArgs) Handles cbCultureInvariant.CheckedChanged
		My.Settings.CultureInvariant = cbCultureInvariant.Checked
		performMatching()
	End Sub

	Private Sub cbExplicitCapture_CheckedChanged(sender As Object, e As EventArgs) Handles cbExplicitCapture.CheckedChanged
		My.Settings.ExplcitCapture = cbExplicitCapture.Checked
		performMatching()
	End Sub

	Private Sub cbIgnoreWhitespace_CheckedChanged(sender As Object, e As EventArgs) Handles cbIgnoreWhitespace.CheckedChanged
		My.Settings.IgnoreWhiteSpace = cbIgnoreWhitespace.Checked
		performMatching()
	End Sub

	Private Sub cbECMAScript_CheckedChanged(sender As Object, e As EventArgs) Handles cbECMAScript.CheckedChanged
		My.Settings.ECMAScript = cbECMAScript.Checked
		performMatching()
	End Sub

	Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
		_loading = True
		Me.WindowState = My.Settings.FormState

		Pattern.Text = My.Settings.Pattern
		Input.Text = My.Settings.Input
		cbIgnoreCase.Checked = My.Settings.IgnoreCase
		cbIgnoreWhitespace.Checked = My.Settings.IgnoreWhiteSpace
		cbExplicitCapture.Checked = My.Settings.ExplcitCapture
		cbCultureInvariant.Checked = My.Settings.CultureInvariant
		cbSingleline.Checked = My.Settings.SingleLine
		cbMultiline.Checked = My.Settings.MultilLine
		cbRightToLeft.Checked = My.Settings.RightToLeft
		cbECMAScript.Checked = My.Settings.ECMAScript
		cbSeparateLines.Checked = My.Settings.SeparateLines

		Me.Size = My.Settings.FormSize
		SplitContainer1.SplitterDistance = My.Settings.Panel1Size
		SplitContainer2.SplitterDistance = My.Settings.Panel2Size
		SplitContainer3.SplitterDistance = My.Settings.Panel3Size

		Input.Font = New Font(Input.Font.FontFamily, 14)

		Results.Font = New Font(Results.Font.FontFamily, 14)

		_loading = False
	End Sub

	Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
		ClearFormatting(Input)
	End Sub

	Private Sub SeparateLines_CheckedChanged(sender As Object, e As EventArgs) Handles cbSeparateLines.CheckedChanged
		My.Settings.SeparateLines = cbSeparateLines.Checked
		performMatching()
	End Sub

	Private Sub Main_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		My.Settings.FormSize = Me.Size
		My.Settings.FormState = Me.WindowState
	End Sub

	Private Sub SplitContainer1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer1.SplitterMoved
		SplitterSizes()
	End Sub

	Private Sub SplitContainer2_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer2.SplitterMoved
		SplitterSizes()
	End Sub

	Private Sub SplitContainer3_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer3.SplitterMoved
		SplitterSizes()
	End Sub

	Private Sub SplitterSizes()
		If Not _loading Then
			My.Settings.Panel1Size = SplitContainer1.SplitterDistance
			My.Settings.Panel2Size = SplitContainer2.SplitterDistance
			My.Settings.Panel3Size = SplitContainer3.SplitterDistance
		End If
	End Sub

	Private Sub Results_MouseHover(sender As Object, e As EventArgs) Handles Results.MouseHover
		Hovering.Text = Cursor.Position.ToString
	End Sub

	Private Sub Input_MouseMove(sender As Object, e As MouseEventArgs) Handles Input.MouseMove
		MouseMoving.Text = Cursor.Position.ToString
	End Sub

	Private Sub Input_MyMouseHover(sender As Object, e As EventArgs) Handles Input.MyMouseHover
		If WithinInput Then
			Hovering.Text = "*" & Cursor.Position.ToString
			If Hovering.BackColor = Color.Chartreuse Then
				Hovering.BackColor = Color.Red
			Else
				Hovering.BackColor = Color.Chartreuse
			End If

			Dim ppos = Input.PointToClient(Cursor.Position)

			Dim cpos = Input.GetCharIndexFromPosition(ppos)

			Dim lpos = Input.GetLineFromCharIndex(cpos)

			Dim fpos = cpos - Input.GetFirstCharIndexFromLine(lpos)

			Dim xsltpos = Input.SelectionStart
			Dim xsltlen = Input.SelectionLength

			If prtf <> String.Empty Then
				Input.Select(psltpos, psltlen)
				Input.SelectedRtf = prtf
			End If

			csltpos = FindWhiteSpaceRev(Input, cpos)
			csltlen = FindWhiteSpace(Input, csltpos) - csltpos + 1

			Input.Select(csltpos, csltlen)

			prtf = Input.SelectedRtf

			Input.SelectionBackColor = Color.DarkGoldenrod
			psltpos = csltpos
			psltlen = csltlen

			Input.Select(xsltpos, xsltlen)

			inputlen.Text = Input.Text.Length
			tspcsltlen.Text = csltlen
			tspcsltpos.Text = csltpos

			Hovering.Text = "**" & lpos & " - " & fpos
		End If
	End Sub

	Private Sub Input_MouseEnter(sender As Object, e As EventArgs) Handles Input.MouseEnter
		WithinInput = True
	End Sub

	Private Sub Input_MouseLeave(sender As Object, e As EventArgs) Handles Input.MouseLeave
		WithinInput = False
	End Sub
End Class
