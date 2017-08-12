Imports System.Math

Public Class MyRichTextBox

	Private mHoverPos As Point
	Private mHoverDone As Boolean

	Public Shadows Event MouseHover(sender As Object, e As EventArgs)

	Private Sub RichTextBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles RichTextBox1.MouseMove
		If mHoverDone Then Return

		If HoverTimer.Enabled Then
			If Abs(e.X - mHoverPos.X) < 4 And Abs(e.Y - mHoverPos.Y) < 4 Then Return
			HoverTimer.Enabled = False
		End If
		mHoverPos = e.Location
		HoverTimer.Enabled = True

	End Sub

	Private Sub MyRichTextBox_Load(sender As Object, e As EventArgs) Handles Me.Load
		HoverTimer.Interval = 2000
	End Sub

	Private Sub HoverTimer_Tick(sender As Object, e As EventArgs) Handles HoverTimer.Tick
		HoverTimer.Enabled = False
		mHoverDone = True
		RaiseEvent MouseHover(sender, e)
	End Sub
End Class
