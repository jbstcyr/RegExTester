Imports System.Drawing
Imports System.Math
Imports System.Windows.Forms


Public Interface IMyRichTextBoxInterface
	Event MouseMove As EventHandler
End Interface

Public Class MyRichTextBox
	Inherits RichTextBox
	Implements IMyRichTextBoxInterface

	Const HoverInterval As Integer = 1000

	'Private WithEvents HoverTimer As Timer


	Private components As System.ComponentModel.IContainer

	Private Event MouseMove1 As EventHandler Implements IMyRichTextBoxInterface.MouseMove

	Public Event MyMouseHover As EventHandler

	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.HoverTimer = New System.Windows.Forms.Timer(Me.components)
		Me.SuspendLayout()
		'
		'MyRichTextBox
		'
		Me.ResumeLayout(False)

	End Sub


	Private mHoverPos As Point
	Friend WithEvents HoverTimer As Timer
	Private mHoverDone As Boolean

	Public Sub New()
		InitializeComponent()
		HoverTimer = New Timer With {
			.Interval = HoverInterval
		}
	End Sub

	Private Sub MyMouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
		'Debug.Print("MyMouseMove " & sender.ToString & " " & e.ToString)

		If HoverTimer.Enabled Then
			If Abs(e.X - mHoverPos.X) < 4 And Abs(e.Y - mHoverPos.Y) < 4 Then Return
			HoverTimer.Enabled = False
		Else
			mHoverDone = False
		End If
		If mHoverDone Then Return

		mHoverPos = e.Location
		HoverTimer.Enabled = True
	End Sub



	Private Sub HoverTimer_Tick(sender As Object, e As EventArgs) Handles HoverTimer.Tick
		HoverTimer.Stop()
		HoverTimer.Start()
		mHoverDone = True

		'Debug.Print("Tick " & sender.ToString & " " & e.ToString)


		If HoverTimer.Enabled Then
			If Abs(Cursor.Position.X - mHoverPos.X) < 4 And Abs(Cursor.Position.Y - mHoverPos.Y) < 4 Then Return
			mHoverPos = Cursor.Position
			RaiseEvent MyMouseHover(sender, e)
		End If

	End Sub

	Public Sub HoverHiLight(hbegin As Integer, hend As Integer)

	End Sub

	Protected Overrides Sub OnMouseMove(E As MouseEventArgs)


	End Sub


End Class
