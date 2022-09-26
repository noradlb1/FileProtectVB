Namespace Encryptor
	Partial Public Class Encryptor
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Encryptor))
			Me.listBox1 = New System.Windows.Forms.ListBox()
			Me.listBox2 = New System.Windows.Forms.ListBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.label3 = New System.Windows.Forms.Label()
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.button3 = New System.Windows.Forms.Button()
			Me.button4 = New System.Windows.Forms.Button()
			Me.button5 = New System.Windows.Forms.Button()
			Me.button6 = New System.Windows.Forms.Button()
			Me.button7 = New System.Windows.Forms.Button()
			Me.button8 = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' listBox1
			' 
			Me.listBox1.AllowDrop = True
			Me.listBox1.FormattingEnabled = True
			Me.listBox1.HorizontalScrollbar = True
			Me.listBox1.ItemHeight = 16
			Me.listBox1.Location = New System.Drawing.Point(16, 36)
			Me.listBox1.Margin = New System.Windows.Forms.Padding(4)
			Me.listBox1.Name = "listBox1"
			Me.listBox1.Size = New System.Drawing.Size(417, 116)
			Me.listBox1.TabIndex = 0
			' 
			' listBox2
			' 
			Me.listBox2.AllowDrop = True
			Me.listBox2.FormattingEnabled = True
			Me.listBox2.ItemHeight = 16
			Me.listBox2.Location = New System.Drawing.Point(16, 176)
			Me.listBox2.Margin = New System.Windows.Forms.Padding(4)
			Me.listBox2.Name = "listBox2"
			Me.listBox2.Size = New System.Drawing.Size(417, 116)
			Me.listBox2.TabIndex = 1
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(12, 16)
			Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(36, 16)
			Me.label1.TabIndex = 2
			Me.label1.Text = "Files"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(12, 156)
			Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(53, 16)
			Me.label2.TabIndex = 3
			Me.label2.Text = "Folders"
			' 
			' textBox1
			' 
			Me.textBox1.Location = New System.Drawing.Point(16, 316)
			Me.textBox1.Margin = New System.Windows.Forms.Padding(4)
			Me.textBox1.MaxLength = 8
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(417, 22)
			Me.textBox1.TabIndex = 4
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(12, 297)
			Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(67, 16)
			Me.label3.TabIndex = 5
			Me.label3.Text = "Password"
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(443, 124)
			Me.button1.Margin = New System.Windows.Forms.Padding(4)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(108, 28)
			Me.button1.TabIndex = 6
			Me.button1.Text = "Remove"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' button2
			' 
			Me.button2.Location = New System.Drawing.Point(443, 89)
			Me.button2.Margin = New System.Windows.Forms.Padding(4)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(108, 28)
			Me.button2.TabIndex = 7
			Me.button2.Text = "Add"
			Me.button2.UseVisualStyleBackColor = True
'			Me.button2.Click += New System.EventHandler(Me.button2_Click)
			' 
			' button3
			' 
			Me.button3.Location = New System.Drawing.Point(443, 229)
			Me.button3.Margin = New System.Windows.Forms.Padding(4)
			Me.button3.Name = "button3"
			Me.button3.Size = New System.Drawing.Size(108, 28)
			Me.button3.TabIndex = 8
			Me.button3.Text = "Add"
			Me.button3.UseVisualStyleBackColor = True
'			Me.button3.Click += New System.EventHandler(Me.button3_Click)
			' 
			' button4
			' 
			Me.button4.Location = New System.Drawing.Point(443, 265)
			Me.button4.Margin = New System.Windows.Forms.Padding(4)
			Me.button4.Name = "button4"
			Me.button4.Size = New System.Drawing.Size(108, 28)
			Me.button4.TabIndex = 9
			Me.button4.Text = "Remove"
			Me.button4.UseVisualStyleBackColor = True
'			Me.button4.Click += New System.EventHandler(Me.button4_Click)
			' 
			' button5
			' 
			Me.button5.Location = New System.Drawing.Point(16, 386)
			Me.button5.Margin = New System.Windows.Forms.Padding(4)
			Me.button5.Name = "button5"
			Me.button5.Size = New System.Drawing.Size(183, 28)
			Me.button5.TabIndex = 10
			Me.button5.Text = "Encrypt"
			Me.button5.UseVisualStyleBackColor = True
'			Me.button5.Click += New System.EventHandler(Me.button5_Click)
			' 
			' button6
			' 
			Me.button6.Location = New System.Drawing.Point(207, 386)
			Me.button6.Margin = New System.Windows.Forms.Padding(4)
			Me.button6.Name = "button6"
			Me.button6.Size = New System.Drawing.Size(165, 28)
			Me.button6.TabIndex = 11
			Me.button6.Text = "Decrypt"
			Me.button6.UseVisualStyleBackColor = True
'			Me.button6.Click += New System.EventHandler(Me.button6_Click)
			' 
			' button7
			' 
			Me.button7.Location = New System.Drawing.Point(380, 386)
			Me.button7.Margin = New System.Windows.Forms.Padding(4)
			Me.button7.Name = "button7"
			Me.button7.Size = New System.Drawing.Size(165, 28)
			Me.button7.TabIndex = 12
			Me.button7.Text = "Clear All"
			Me.button7.UseVisualStyleBackColor = True
'			Me.button7.Click += New System.EventHandler(Me.button7_Click)
			' 
			' button8
			' 
			Me.button8.Location = New System.Drawing.Point(443, 316)
			Me.button8.Name = "button8"
			Me.button8.Size = New System.Drawing.Size(108, 23)
			Me.button8.TabIndex = 13
			Me.button8.Text = "Generate"
			Me.button8.UseVisualStyleBackColor = True
'			Me.button8.Click += New System.EventHandler(Me.button8_Click)
			' 
			' Encryptor
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(561, 430)
			Me.Controls.Add(Me.button8)
			Me.Controls.Add(Me.button7)
			Me.Controls.Add(Me.button6)
			Me.Controls.Add(Me.button5)
			Me.Controls.Add(Me.button4)
			Me.Controls.Add(Me.button3)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.textBox1)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.listBox2)
			Me.Controls.Add(Me.listBox1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = (DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Margin = New System.Windows.Forms.Padding(4)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Encryptor"
			Me.Text = "FileProtect™"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private listBox1 As System.Windows.Forms.ListBox
		Private listBox2 As System.Windows.Forms.ListBox
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private textBox1 As System.Windows.Forms.TextBox
		Private label3 As System.Windows.Forms.Label
		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
		Private WithEvents button3 As System.Windows.Forms.Button
		Private WithEvents button4 As System.Windows.Forms.Button
		Private WithEvents button5 As System.Windows.Forms.Button
		Private WithEvents button6 As System.Windows.Forms.Button
		Private WithEvents button7 As System.Windows.Forms.Button
		Private WithEvents button8 As System.Windows.Forms.Button
	End Class
End Namespace

