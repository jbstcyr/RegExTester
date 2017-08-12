<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.cbSeparateLines = New System.Windows.Forms.CheckBox()
		Me.Clear = New System.Windows.Forms.Button()
		Me.Errors = New System.Windows.Forms.RichTextBox()
		Me.cbECMAScript = New System.Windows.Forms.CheckBox()
		Me.cbRightToLeft = New System.Windows.Forms.CheckBox()
		Me.cbMultiline = New System.Windows.Forms.CheckBox()
		Me.cbSingleline = New System.Windows.Forms.CheckBox()
		Me.cbCultureInvariant = New System.Windows.Forms.CheckBox()
		Me.cbExplicitCapture = New System.Windows.Forms.CheckBox()
		Me.cbIgnoreWhitespace = New System.Windows.Forms.CheckBox()
		Me.cbIgnoreCase = New System.Windows.Forms.CheckBox()
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.Pattern = New System.Windows.Forms.TextBox()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel5 = New System.Windows.Forms.Panel()
		Me.Input = New MyRTB.MyRichTextBox()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
		Me.Results = New MyRTB.MyRichTextBox()
		Me.Panel6 = New System.Windows.Forms.Panel()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
		Me.Panel7 = New System.Windows.Forms.Panel()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.MatchCount = New System.Windows.Forms.ToolStripStatusLabel()
		Me.Hovering = New System.Windows.Forms.ToolStripStatusLabel()
		Me.MouseMoving = New System.Windows.Forms.ToolStripStatusLabel()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.tspcsltlen = New System.Windows.Forms.ToolStripStatusLabel()
		Me.tspcsltpos = New System.Windows.Forms.ToolStripStatusLabel()
		Me.inputlen = New System.Windows.Forms.ToolStripStatusLabel()
		Me.Panel1.SuspendLayout()
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer2.Panel1.SuspendLayout()
		Me.SplitContainer2.Panel2.SuspendLayout()
		Me.SplitContainer2.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.Panel5.SuspendLayout()
		Me.Panel4.SuspendLayout()
		CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer3.Panel1.SuspendLayout()
		Me.SplitContainer3.Panel2.SuspendLayout()
		Me.SplitContainer3.SuspendLayout()
		Me.Panel6.SuspendLayout()
		Me.Panel7.SuspendLayout()
		Me.StatusStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.cbSeparateLines)
		Me.Panel1.Controls.Add(Me.Clear)
		Me.Panel1.Controls.Add(Me.Errors)
		Me.Panel1.Controls.Add(Me.cbECMAScript)
		Me.Panel1.Controls.Add(Me.cbRightToLeft)
		Me.Panel1.Controls.Add(Me.cbMultiline)
		Me.Panel1.Controls.Add(Me.cbSingleline)
		Me.Panel1.Controls.Add(Me.cbCultureInvariant)
		Me.Panel1.Controls.Add(Me.cbExplicitCapture)
		Me.Panel1.Controls.Add(Me.cbIgnoreWhitespace)
		Me.Panel1.Controls.Add(Me.cbIgnoreCase)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
		Me.Panel1.Location = New System.Drawing.Point(715, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(169, 366)
		Me.Panel1.TabIndex = 0
		'
		'cbSeparateLines
		'
		Me.cbSeparateLines.AutoSize = True
		Me.cbSeparateLines.Location = New System.Drawing.Point(21, 12)
		Me.cbSeparateLines.Name = "cbSeparateLines"
		Me.cbSeparateLines.Size = New System.Drawing.Size(120, 17)
		Me.cbSeparateLines.TabIndex = 10
		Me.cbSeparateLines.Text = "Each Line Separate"
		Me.cbSeparateLines.UseVisualStyleBackColor = True
		'
		'Clear
		'
		Me.Clear.Location = New System.Drawing.Point(41, 219)
		Me.Clear.Name = "Clear"
		Me.Clear.Size = New System.Drawing.Size(96, 24)
		Me.Clear.TabIndex = 9
		Me.Clear.Text = "Clear"
		Me.Clear.UseVisualStyleBackColor = True
		'
		'Errors
		'
		Me.Errors.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Errors.Location = New System.Drawing.Point(11, 249)
		Me.Errors.Name = "Errors"
		Me.Errors.Size = New System.Drawing.Size(143, 105)
		Me.Errors.TabIndex = 8
		Me.Errors.Text = ""
		'
		'cbECMAScript
		'
		Me.cbECMAScript.AutoSize = True
		Me.cbECMAScript.Location = New System.Drawing.Point(21, 196)
		Me.cbECMAScript.Name = "cbECMAScript"
		Me.cbECMAScript.Size = New System.Drawing.Size(86, 17)
		Me.cbECMAScript.TabIndex = 7
		Me.cbECMAScript.Text = "ECMA Script"
		Me.cbECMAScript.UseVisualStyleBackColor = True
		'
		'cbRightToLeft
		'
		Me.cbRightToLeft.AutoSize = True
		Me.cbRightToLeft.Location = New System.Drawing.Point(21, 173)
		Me.cbRightToLeft.Name = "cbRightToLeft"
		Me.cbRightToLeft.Size = New System.Drawing.Size(88, 17)
		Me.cbRightToLeft.TabIndex = 6
		Me.cbRightToLeft.Text = "Right To Left"
		Me.cbRightToLeft.UseVisualStyleBackColor = True
		'
		'cbMultiline
		'
		Me.cbMultiline.AutoSize = True
		Me.cbMultiline.Location = New System.Drawing.Point(21, 150)
		Me.cbMultiline.Name = "cbMultiline"
		Me.cbMultiline.Size = New System.Drawing.Size(64, 17)
		Me.cbMultiline.TabIndex = 5
		Me.cbMultiline.Text = "Multiline"
		Me.cbMultiline.UseVisualStyleBackColor = True
		'
		'cbSingleline
		'
		Me.cbSingleline.AutoSize = True
		Me.cbSingleline.Location = New System.Drawing.Point(21, 127)
		Me.cbSingleline.Name = "cbSingleline"
		Me.cbSingleline.Size = New System.Drawing.Size(71, 17)
		Me.cbSingleline.TabIndex = 4
		Me.cbSingleline.Text = "Singleline"
		Me.cbSingleline.UseVisualStyleBackColor = True
		'
		'cbCultureInvariant
		'
		Me.cbCultureInvariant.AutoSize = True
		Me.cbCultureInvariant.Location = New System.Drawing.Point(21, 104)
		Me.cbCultureInvariant.Name = "cbCultureInvariant"
		Me.cbCultureInvariant.Size = New System.Drawing.Size(103, 17)
		Me.cbCultureInvariant.TabIndex = 3
		Me.cbCultureInvariant.Text = "Culture Invariant"
		Me.cbCultureInvariant.UseVisualStyleBackColor = True
		'
		'cbExplicitCapture
		'
		Me.cbExplicitCapture.AutoSize = True
		Me.cbExplicitCapture.Location = New System.Drawing.Point(21, 81)
		Me.cbExplicitCapture.Name = "cbExplicitCapture"
		Me.cbExplicitCapture.Size = New System.Drawing.Size(99, 17)
		Me.cbExplicitCapture.TabIndex = 2
		Me.cbExplicitCapture.Text = "Explicit Capture"
		Me.cbExplicitCapture.UseVisualStyleBackColor = True
		'
		'cbIgnoreWhitespace
		'
		Me.cbIgnoreWhitespace.AutoSize = True
		Me.cbIgnoreWhitespace.Location = New System.Drawing.Point(21, 58)
		Me.cbIgnoreWhitespace.Name = "cbIgnoreWhitespace"
		Me.cbIgnoreWhitespace.Size = New System.Drawing.Size(116, 17)
		Me.cbIgnoreWhitespace.TabIndex = 1
		Me.cbIgnoreWhitespace.Text = "Ignore Whitespace"
		Me.cbIgnoreWhitespace.UseVisualStyleBackColor = True
		'
		'cbIgnoreCase
		'
		Me.cbIgnoreCase.AutoSize = True
		Me.cbIgnoreCase.Location = New System.Drawing.Point(21, 35)
		Me.cbIgnoreCase.Name = "cbIgnoreCase"
		Me.cbIgnoreCase.Size = New System.Drawing.Size(83, 17)
		Me.cbIgnoreCase.TabIndex = 0
		Me.cbIgnoreCase.Text = "Ignore Case"
		Me.cbIgnoreCase.UseVisualStyleBackColor = True
		'
		'SplitContainer1
		'
		Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainer1.Name = "SplitContainer1"
		Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
		'
		'SplitContainer1.Panel1
		'
		Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
		Me.SplitContainer1.Size = New System.Drawing.Size(715, 366)
		Me.SplitContainer1.SplitterDistance = 172
		Me.SplitContainer1.TabIndex = 1
		'
		'SplitContainer2
		'
		Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainer2.Name = "SplitContainer2"
		Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
		'
		'SplitContainer2.Panel1
		'
		Me.SplitContainer2.Panel1.Controls.Add(Me.Panel3)
		Me.SplitContainer2.Panel1.Controls.Add(Me.Panel2)
		'
		'SplitContainer2.Panel2
		'
		Me.SplitContainer2.Panel2.Controls.Add(Me.Panel5)
		Me.SplitContainer2.Panel2.Controls.Add(Me.Panel4)
		Me.SplitContainer2.Size = New System.Drawing.Size(715, 172)
		Me.SplitContainer2.SplitterDistance = 79
		Me.SplitContainer2.TabIndex = 0
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.Lime
		Me.Panel3.Controls.Add(Me.Pattern)
		Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel3.Location = New System.Drawing.Point(0, 24)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(715, 55)
		Me.Panel3.TabIndex = 2
		'
		'Pattern
		'
		Me.Pattern.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Pattern.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Pattern.Location = New System.Drawing.Point(0, 0)
		Me.Pattern.Multiline = True
		Me.Pattern.Name = "Pattern"
		Me.Pattern.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.Pattern.Size = New System.Drawing.Size(715, 55)
		Me.Pattern.TabIndex = 0
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.Panel2.Controls.Add(Me.Label1)
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel2.Location = New System.Drawing.Point(0, 0)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(715, 24)
		Me.Panel2.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(0, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(715, 24)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Pattern"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Panel5
		'
		Me.Panel5.Controls.Add(Me.Input)
		Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel5.Location = New System.Drawing.Point(0, 24)
		Me.Panel5.Name = "Panel5"
		Me.Panel5.Size = New System.Drawing.Size(715, 65)
		Me.Panel5.TabIndex = 1
		'
		'Input
		'
		Me.Input.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Input.Location = New System.Drawing.Point(0, 0)
		Me.Input.Name = "Input"
		Me.Input.Size = New System.Drawing.Size(715, 65)
		Me.Input.TabIndex = 0
		Me.Input.Text = ""
		'
		'Panel4
		'
		Me.Panel4.Controls.Add(Me.Label2)
		Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel4.Location = New System.Drawing.Point(0, 0)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(715, 24)
		Me.Panel4.TabIndex = 0
		'
		'Label2
		'
		Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(0, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(715, 24)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "Input"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'SplitContainer3
		'
		Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainer3.Name = "SplitContainer3"
		Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
		'
		'SplitContainer3.Panel1
		'
		Me.SplitContainer3.Panel1.Controls.Add(Me.Results)
		Me.SplitContainer3.Panel1.Controls.Add(Me.Panel6)
		'
		'SplitContainer3.Panel2
		'
		Me.SplitContainer3.Panel2.Controls.Add(Me.RichTextBox3)
		Me.SplitContainer3.Panel2.Controls.Add(Me.Panel7)
		Me.SplitContainer3.Size = New System.Drawing.Size(715, 190)
		Me.SplitContainer3.SplitterDistance = 86
		Me.SplitContainer3.TabIndex = 0
		'
		'Results
		'
		Me.Results.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Results.Location = New System.Drawing.Point(0, 24)
		Me.Results.Name = "Results"
		Me.Results.Size = New System.Drawing.Size(715, 62)
		Me.Results.TabIndex = 3
		Me.Results.Text = ""
		'
		'Panel6
		'
		Me.Panel6.Controls.Add(Me.Label3)
		Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel6.Location = New System.Drawing.Point(0, 0)
		Me.Panel6.Name = "Panel6"
		Me.Panel6.Size = New System.Drawing.Size(715, 24)
		Me.Panel6.TabIndex = 2
		'
		'Label3
		'
		Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(0, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(715, 24)
		Me.Label3.TabIndex = 0
		Me.Label3.Text = "Results"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'RichTextBox3
		'
		Me.RichTextBox3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.RichTextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RichTextBox3.Location = New System.Drawing.Point(0, 24)
		Me.RichTextBox3.Name = "RichTextBox3"
		Me.RichTextBox3.Size = New System.Drawing.Size(715, 76)
		Me.RichTextBox3.TabIndex = 1
		Me.RichTextBox3.Text = ""
		'
		'Panel7
		'
		Me.Panel7.Controls.Add(Me.Label4)
		Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel7.Location = New System.Drawing.Point(0, 0)
		Me.Panel7.Name = "Panel7"
		Me.Panel7.Size = New System.Drawing.Size(715, 24)
		Me.Panel7.TabIndex = 2
		'
		'Label4
		'
		Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(0, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(715, 24)
		Me.Label4.TabIndex = 0
		Me.Label4.Text = "Input"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MatchCount, Me.Hovering, Me.MouseMoving, Me.inputlen, Me.tspcsltpos, Me.tspcsltlen})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 344)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(715, 22)
		Me.StatusStrip1.TabIndex = 2
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'MatchCount
		'
		Me.MatchCount.AutoSize = False
		Me.MatchCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.MatchCount.Name = "MatchCount"
		Me.MatchCount.Size = New System.Drawing.Size(100, 17)
		'
		'Hovering
		'
		Me.Hovering.AutoSize = False
		Me.Hovering.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.Hovering.Name = "Hovering"
		Me.Hovering.Size = New System.Drawing.Size(100, 17)
		'
		'MouseMoving
		'
		Me.MouseMoving.AutoSize = False
		Me.MouseMoving.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.MouseMoving.Name = "MouseMoving"
		Me.MouseMoving.Size = New System.Drawing.Size(100, 17)
		'
		'tspcsltlen
		'
		Me.tspcsltlen.AutoSize = False
		Me.tspcsltlen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.tspcsltlen.Name = "tspcsltlen"
		Me.tspcsltlen.Size = New System.Drawing.Size(100, 17)
		'
		'tspcsltpos
		'
		Me.tspcsltpos.AutoSize = False
		Me.tspcsltpos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.tspcsltpos.Name = "tspcsltpos"
		Me.tspcsltpos.Size = New System.Drawing.Size(100, 17)
		'
		'inputlen
		'
		Me.inputlen.AutoSize = False
		Me.inputlen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.inputlen.Name = "inputlen"
		Me.inputlen.Size = New System.Drawing.Size(100, 17)
		'
		'Main
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(884, 366)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.SplitContainer1)
		Me.Controls.Add(Me.Panel1)
		Me.Name = "Main"
		Me.Text = "Form1"
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer1.ResumeLayout(False)
		Me.SplitContainer2.Panel1.ResumeLayout(False)
		Me.SplitContainer2.Panel2.ResumeLayout(False)
		CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer2.ResumeLayout(False)
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		Me.Panel5.ResumeLayout(False)
		Me.Panel4.ResumeLayout(False)
		Me.SplitContainer3.Panel1.ResumeLayout(False)
		Me.SplitContainer3.Panel2.ResumeLayout(False)
		CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer3.ResumeLayout(False)
		Me.Panel6.ResumeLayout(False)
		Me.Panel7.ResumeLayout(False)
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Panel1 As Panel
	Friend WithEvents SplitContainer1 As SplitContainer
	Friend WithEvents SplitContainer2 As SplitContainer
	Friend WithEvents SplitContainer3 As SplitContainer
	Friend WithEvents cbECMAScript As CheckBox
	Friend WithEvents cbRightToLeft As CheckBox
	Friend WithEvents cbMultiline As CheckBox
	Friend WithEvents cbSingleline As CheckBox
	Friend WithEvents cbCultureInvariant As CheckBox
	Friend WithEvents cbExplicitCapture As CheckBox
	Friend WithEvents cbIgnoreWhitespace As CheckBox
	Friend WithEvents cbIgnoreCase As CheckBox
	Friend WithEvents Panel2 As Panel
	Friend WithEvents Label1 As Label
	Friend WithEvents Panel3 As Panel
	Friend WithEvents Pattern As TextBox
	Friend WithEvents Panel5 As Panel
	Friend WithEvents Panel4 As Panel
	Friend WithEvents Label2 As Label
	Friend WithEvents Panel6 As Panel
	Friend WithEvents Label3 As Label
	Friend WithEvents RichTextBox3 As RichTextBox
	Friend WithEvents Panel7 As Panel
	Friend WithEvents Label4 As Label
	Friend WithEvents Errors As RichTextBox
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents MatchCount As ToolStripStatusLabel
	Friend WithEvents Clear As Button
	Friend WithEvents cbSeparateLines As CheckBox
	Friend WithEvents ToolTip1 As ToolTip
	Friend WithEvents Results As MyRTB.MyRichTextBox
	Friend WithEvents Input As MyRTB.MyRichTextBox
	Friend WithEvents Hovering As ToolStripStatusLabel
	Friend WithEvents MouseMoving As ToolStripStatusLabel
	Friend WithEvents inputlen As ToolStripStatusLabel
	Friend WithEvents tspcsltpos As ToolStripStatusLabel
	Friend WithEvents tspcsltlen As ToolStripStatusLabel
End Class
