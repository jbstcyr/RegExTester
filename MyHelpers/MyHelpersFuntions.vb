Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports System.Math

Public Module MyHelpersFuntions
	Public Function FindWhiteSpace(input As RichTextBox, cpos As Integer) As Integer
		Dim finished As Boolean = False
		Dim re As New Regex("\s")
		Dim pos As Integer = cpos
		Dim rpos As Integer = 0

		While Not finished And pos < Len(input.Text)
			If re.IsMatch(input.Text.Substring(pos, 1)) Then
				finished = True
				rpos = pos - 1
			End If
			pos += 1
		End While
		If Not finished Then
			rpos = input.Text.Length
		End If
		Return rpos
	End Function

	Public Function FindWhiteSpaceRev(input As RichTextBox, cpos As Integer) As Integer
		Dim finished As Boolean = False
		Dim re As New Regex("\s")
		Dim pos As Integer = Min(cpos, input.Text.Length - 1)
		Dim rpos As Integer = 0

		While Not finished And pos > -1
			If re.IsMatch(input.Text.Substring(pos, 1)) Then
				finished = True
				rpos = pos + 1
			End If
			pos -= 1
		End While

		Return rpos
	End Function

End Module
