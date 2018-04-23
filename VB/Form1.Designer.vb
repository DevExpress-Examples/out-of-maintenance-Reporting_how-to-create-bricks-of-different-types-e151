Imports Microsoft.VisualBasic
Imports System
Namespace Bricks
	Partial Public Class Form1
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.btn_ChangeFormatFlags = New System.Windows.Forms.Button()
			Me.btn_ChangeAlignment = New System.Windows.Forms.Button()
			Me.btn_BrickStringFormat = New System.Windows.Forms.Button()
			Me.btn_BeginEndUnionRect = New System.Windows.Forms.Button()
			Me.btn_DrawRect = New System.Windows.Forms.Button()
			Me.btn_DrawPageInfo = New System.Windows.Forms.Button()
			Me.btn_DrawPageImage = New System.Windows.Forms.Button()
			Me.btn_DrawImage = New System.Windows.Forms.Button()
			Me.btn_DrawCheckBox = New System.Windows.Forms.Button()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
			Me.printingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
			CType(Me.printingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' btn_ChangeFormatFlags
			' 
			Me.btn_ChangeFormatFlags.Location = New System.Drawing.Point(177, 164)
			Me.btn_ChangeFormatFlags.Name = "btn_ChangeFormatFlags"
			Me.btn_ChangeFormatFlags.Size = New System.Drawing.Size(119, 34)
			Me.btn_ChangeFormatFlags.TabIndex = 26
			Me.btn_ChangeFormatFlags.Text = "ChangeFormatFlags"
			Me.btn_ChangeFormatFlags.UseVisualStyleBackColor = True
'			Me.btn_ChangeFormatFlags.Click += New System.EventHandler(Me.btn_ChangeFormatFlags_Click);
			' 
			' btn_ChangeAlignment
			' 
			Me.btn_ChangeAlignment.Location = New System.Drawing.Point(177, 121)
			Me.btn_ChangeAlignment.Name = "btn_ChangeAlignment"
			Me.btn_ChangeAlignment.Size = New System.Drawing.Size(119, 34)
			Me.btn_ChangeAlignment.TabIndex = 25
			Me.btn_ChangeAlignment.Text = "ChangeAlignment"
			Me.btn_ChangeAlignment.UseVisualStyleBackColor = True
'			Me.btn_ChangeAlignment.Click += New System.EventHandler(Me.btn_ChangeAlignment_Click);
			' 
			' btn_BrickStringFormat
			' 
			Me.btn_BrickStringFormat.Location = New System.Drawing.Point(177, 78)
			Me.btn_BrickStringFormat.Name = "btn_BrickStringFormat"
			Me.btn_BrickStringFormat.Size = New System.Drawing.Size(119, 34)
			Me.btn_BrickStringFormat.TabIndex = 24
			Me.btn_BrickStringFormat.Text = "BrickStringFormat"
			Me.btn_BrickStringFormat.UseVisualStyleBackColor = True
'			Me.btn_BrickStringFormat.Click += New System.EventHandler(Me.btn_BrickStringFormat_Click);
			' 
			' btn_BeginEndUnionRect
			' 
			Me.btn_BeginEndUnionRect.Location = New System.Drawing.Point(177, 35)
			Me.btn_BeginEndUnionRect.Name = "btn_BeginEndUnionRect"
			Me.btn_BeginEndUnionRect.Size = New System.Drawing.Size(119, 34)
			Me.btn_BeginEndUnionRect.TabIndex = 23
			Me.btn_BeginEndUnionRect.Text = "BeginEndUnionRect"
			Me.btn_BeginEndUnionRect.UseVisualStyleBackColor = True
'			Me.btn_BeginEndUnionRect.Click += New System.EventHandler(Me.btn_BeginEndUnionRect_Click);
			' 
			' btn_DrawRect
			' 
			Me.btn_DrawRect.Location = New System.Drawing.Point(31, 207)
			Me.btn_DrawRect.Name = "btn_DrawRect"
			Me.btn_DrawRect.Size = New System.Drawing.Size(114, 34)
			Me.btn_DrawRect.TabIndex = 22
			Me.btn_DrawRect.Text = "DrawRect"
			Me.btn_DrawRect.UseVisualStyleBackColor = True
'			Me.btn_DrawRect.Click += New System.EventHandler(Me.btn_DrawRect_Click);
			' 
			' btn_DrawPageInfo
			' 
			Me.btn_DrawPageInfo.Location = New System.Drawing.Point(31, 164)
			Me.btn_DrawPageInfo.Name = "btn_DrawPageInfo"
			Me.btn_DrawPageInfo.Size = New System.Drawing.Size(114, 34)
			Me.btn_DrawPageInfo.TabIndex = 21
			Me.btn_DrawPageInfo.Text = "DrawPageInfo"
			Me.btn_DrawPageInfo.UseVisualStyleBackColor = True
'			Me.btn_DrawPageInfo.Click += New System.EventHandler(Me.btn_DrawPageInfo_Click);
			' 
			' btn_DrawPageImage
			' 
			Me.btn_DrawPageImage.Location = New System.Drawing.Point(31, 121)
			Me.btn_DrawPageImage.Name = "btn_DrawPageImage"
			Me.btn_DrawPageImage.Size = New System.Drawing.Size(114, 34)
			Me.btn_DrawPageImage.TabIndex = 20
			Me.btn_DrawPageImage.Text = "DrawPageImage"
			Me.btn_DrawPageImage.UseVisualStyleBackColor = True
'			Me.btn_DrawPageImage.Click += New System.EventHandler(Me.btn_DrawPageImage_Click);
			' 
			' btn_DrawImage
			' 
			Me.btn_DrawImage.Location = New System.Drawing.Point(31, 78)
			Me.btn_DrawImage.Name = "btn_DrawImage"
			Me.btn_DrawImage.Size = New System.Drawing.Size(114, 34)
			Me.btn_DrawImage.TabIndex = 19
			Me.btn_DrawImage.Text = "DrawImage"
			Me.btn_DrawImage.UseVisualStyleBackColor = True
'			Me.btn_DrawImage.Click += New System.EventHandler(Me.btn_DrawImage_Click);
			' 
			' btn_DrawCheckBox
			' 
			Me.btn_DrawCheckBox.Location = New System.Drawing.Point(31, 35)
			Me.btn_DrawCheckBox.Name = "btn_DrawCheckBox"
			Me.btn_DrawCheckBox.Size = New System.Drawing.Size(114, 34)
			Me.btn_DrawCheckBox.TabIndex = 18
			Me.btn_DrawCheckBox.Text = "DrawCheckBox"
			Me.btn_DrawCheckBox.UseVisualStyleBackColor = True
'			Me.btn_DrawCheckBox.Click += New System.EventHandler(Me.btn_DrawCheckBox_Click);
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "")
			' 
			' imageList2
			' 
			Me.imageList2.ImageStream = (CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList2.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList2.Images.SetKeyName(0, "McCarran.png")
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(324, 268)
			Me.Controls.Add(Me.btn_ChangeFormatFlags)
			Me.Controls.Add(Me.btn_ChangeAlignment)
			Me.Controls.Add(Me.btn_BrickStringFormat)
			Me.Controls.Add(Me.btn_BeginEndUnionRect)
			Me.Controls.Add(Me.btn_DrawRect)
			Me.Controls.Add(Me.btn_DrawPageInfo)
			Me.Controls.Add(Me.btn_DrawPageImage)
			Me.Controls.Add(Me.btn_DrawImage)
			Me.Controls.Add(Me.btn_DrawCheckBox)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.printingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents btn_ChangeFormatFlags As System.Windows.Forms.Button
		Private WithEvents btn_ChangeAlignment As System.Windows.Forms.Button
		Private WithEvents btn_BrickStringFormat As System.Windows.Forms.Button
		Private WithEvents btn_BeginEndUnionRect As System.Windows.Forms.Button
		Private WithEvents btn_DrawRect As System.Windows.Forms.Button
		Private WithEvents btn_DrawPageInfo As System.Windows.Forms.Button
		Private WithEvents btn_DrawPageImage As System.Windows.Forms.Button
		Private WithEvents btn_DrawImage As System.Windows.Forms.Button
		Private WithEvents btn_DrawCheckBox As System.Windows.Forms.Button
		Private imageList1 As System.Windows.Forms.ImageList
		Private imageList2 As System.Windows.Forms.ImageList
		Private printingSystem1 As DevExpress.XtraPrinting.PrintingSystem
	End Class
End Namespace

