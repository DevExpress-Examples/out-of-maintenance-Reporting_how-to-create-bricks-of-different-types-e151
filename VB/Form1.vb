Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports DevExpress.XtraPrinting
' ...

Namespace Bricks
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btn_DrawCheckBox_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_DrawCheckBox.Click

			Dim visBrick As VisualBrick
			Dim brickGraph As BrickGraphics = printingSystem1.Graph

			' Start the report generation.
			printingSystem1.Begin()

			' Create a rectangle.
			Dim rect As New RectangleF(New PointF(0, 0), New SizeF(60, 20))
			' Specify a page area.
			brickGraph.Modifier = BrickModifier.Detail
			' Add a checkbox brick to the report.
			visBrick = brickGraph.DrawCheckBox(rect, BorderSide.All, SystemColors.ControlLight, True)

			' Finish the report generation.
			printingSystem1.End()

			' Preview the report.
			printingSystem1.PreviewFormEx.Show()
		End Sub

		Private Sub btn_DrawImage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_DrawImage.Click

			Dim visBrick As VisualBrick
			Dim img As Image = imageList1.Images(0)
			Dim brickGraph As BrickGraphics = printingSystem1.Graph

			' Start the report generation.
			printingSystem1.Begin()

			' Create a rectangle.
			Dim rect As New RectangleF(New PointF(0, 0), New SizeF(96, 96))
			' Specify a page area.
			brickGraph.Modifier = BrickModifier.Detail
			' Add an image brick to the report.
			visBrick = brickGraph.DrawImage(img, rect, BorderSide.All, Color.White)

			' Finish the report generation.
			printingSystem1.End()

			' Preview the report.
			printingSystem1.PreviewFormEx.Show()
		End Sub

		Private Sub btn_DrawPageImage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_DrawPageImage.Click
			Dim pimBrick As PageImageBrick
			Dim img As Image = imageList2.Images(0)
			Dim brickGraph As BrickGraphics = printingSystem1.Graph

			' Start the report generation.
			printingSystem1.Begin()

			' Create a rectangle.
			Dim rect As New RectangleF(New PointF(0, 0), New SizeF(179, 34))
			' Specify a marginal page header area.
			brickGraph.Modifier = BrickModifier.MarginalHeader
			' Create a page image brick.
			pimBrick = brickGraph.DrawPageImage(img, rect, BorderSide.None, Color.White)
			' Specify a Detail area.
			brickGraph.Modifier = BrickModifier.Detail

			' Finish the report generation.
			printingSystem1.End()

			' Preview the report.
			printingSystem1.PreviewFormEx.Show()

		End Sub

		Private Sub btn_DrawPageInfo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_DrawPageInfo.Click
			Dim pinfoBrick As PageInfoBrick
			Dim brickGraph As BrickGraphics = printingSystem1.Graph

			' Start the report generation.
			printingSystem1.Begin()

			' Create a rectangle.
			Dim rect As New RectangleF(New PointF(0, 0), New SizeF(250, 20))
			' Specify the page header.
			brickGraph.Modifier = BrickModifier.MarginalHeader
			' Create page info brick to display time in full format.
			pinfoBrick = brickGraph.DrawPageInfo(PageInfo.DateTime, "{0:F}", Color.Black, rect, BorderSide.None)
			' Specify the page footer.
			brickGraph.Modifier = BrickModifier.MarginalFooter
			' Create a page info brick to display page number.
			pinfoBrick = brickGraph.DrawPageInfo(PageInfo.NumberOfTotal, "Page {0} of {1}", Color.Black, rect, BorderSide.None)

			' Finish the report generation.
			printingSystem1.End()

			' Preview the report.
			printingSystem1.PreviewFormEx.Show()
		End Sub

		Private Sub btn_DrawRect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_DrawRect.Click
			Dim visBrick As VisualBrick
			Dim brickGraph As BrickGraphics = printingSystem1.Graph

			' Start the report generation.
			printingSystem1.Begin()

			' Create a rectangle.
			Dim rect As New RectangleF(New PointF(0, 0), New SizeF(150, 50))
			' Specify a page area.
			brickGraph.Modifier = BrickModifier.Detail
			' Add a brick to the report.
			visBrick = brickGraph.DrawRect(rect, BorderSide.All, Color.Yellow, Color.Blue)

			' Finish the report generation.
			printingSystem1.End()

			' Preview the report.
			printingSystem1.PreviewFormEx.Show()
		End Sub

		Private Sub btn_BeginEndUnionRect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_BeginEndUnionRect.Click
			Dim brickGraph As BrickGraphics = printingSystem1.Graph
			Dim top As Integer = 0

			' Start the report generation.
			printingSystem1.Begin()

			' Specify a page area.
			brickGraph.Modifier = BrickModifier.Detail
			' Start drawing a brick group.
			brickGraph.BeginUnionRect()

			' Specify formatting.
			brickGraph.StringFormat = New BrickStringFormat(StringAlignment.Center, StringAlignment.Center)
			brickGraph.BackColor = Color.Khaki
			brickGraph.BorderColor = Color.MidnightBlue
			brickGraph.Font = New Font("Tahoma", 14, FontStyle.Bold Or FontStyle.Italic)

			' Draw bricks.
			brickGraph.DrawString("Developer Express", Color.MidnightBlue, New RectangleF(0, 0, 150, 50), BorderSide.All)
			top += 50
			brickGraph.DrawString("100% Native", Color.MidnightBlue, New RectangleF(0, top, 150, 50), BorderSide.All)
			top += 50
			brickGraph.DrawString(".NET Tecnologies", Color.MidnightBlue, New RectangleF(0, top, 150, 50), BorderSide.All)

			' Finish drawing a brick group.
			brickGraph.EndUnionRect()

			' Finish the report generation.
			printingSystem1.End()

			' Preview the report.
			printingSystem1.PreviewFormEx.Show()

		End Sub

		Private Sub btn_BrickStringFormat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_BrickStringFormat.Click
			Dim visBrick As VisualBrick
			Dim brickGraph As BrickGraphics = printingSystem1.Graph
			Dim s As String = "Developer Express Inc."

			' Specify the string format.
			Dim sFormat As New StringFormat(StringFormatFlags.DirectionVertical)
			sFormat.Alignment = StringAlignment.Center
			sFormat.LineAlignment = StringAlignment.Center

			' Create the BrickStringFormat object.
			Dim brickSFormat As New BrickStringFormat(sFormat)

			' Measure the string according to the specified format
			Dim sz As SizeF = brickGraph.MeasureString(s, 30, sFormat)


			' Start the report generation.
			printingSystem1.Begin()

			' Set the brick string format
			brickGraph.StringFormat = brickSFormat

			' Create a rectangle.
			Dim rect As New RectangleF(New PointF(0, 0), New SizeF(30, 150))
			' Specify a page area.
			brickGraph.Modifier = BrickModifier.Detail
			' Add a brick to the report.
			visBrick = brickGraph.DrawString(s, Color.MidnightBlue, rect, BorderSide.All)

			' Finish the report generation.
			printingSystem1.End()

			' Preview the report.
			printingSystem1.PreviewFormEx.Show()
		End Sub

		Private Sub btn_ChangeAlignment_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_ChangeAlignment.Click

			Dim visBrick As VisualBrick
			Dim brickGraph As BrickGraphics = printingSystem1.Graph
			Dim s As String = "Developer Express Inc."
			Dim brickSFormat As New BrickStringFormat()

			' Start the report generation.
			printingSystem1.Begin()

			' Specify a page area.
			brickGraph.Modifier = BrickModifier.Detail

			' Create a rectangle.
			Dim rect As New RectangleF(New PointF(0, 0), New SizeF(180, 50))
			' Add a brick to the report.
			visBrick = brickGraph.DrawString(s, Color.MidnightBlue, rect, BorderSide.All)

			' Change the text alignment within the brick
			brickSFormat = visBrick.Style.StringFormat.ChangeAlignment(StringAlignment.Far)
			brickSFormat = brickSFormat.ChangeLineAlignment(StringAlignment.Far)
			brickGraph.StringFormat = brickSFormat

			' Create a second rectangle.
			Dim rect1 As New RectangleF(New PointF(0, 50), New SizeF(180, 50))
			' Add the next brick to the report.
			visBrick = brickGraph.DrawString(s, Color.MidnightBlue, rect1, BorderSide.All)

			' Finish the report generation.
			printingSystem1.End()

			' Preview the report.
			printingSystem1.PreviewFormEx.Show()

		End Sub

		Private Sub btn_ChangeFormatFlags_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_ChangeFormatFlags.Click
			Dim visBrick As VisualBrick
			Dim brickGraph As BrickGraphics = printingSystem1.Graph
			Dim s As String = "Developer Express Inc."
			Dim brickSFormat As New BrickStringFormat()

			' Start the report generation.
			printingSystem1.Begin()

			' Specify a page area.
			brickGraph.Modifier = BrickModifier.Detail

			' Create a rectangle.
			Dim rect As New RectangleF(New PointF(0, 0), New SizeF(180, 75))
			' Add a brick to the report.
			visBrick = brickGraph.DrawString(s, Color.MidnightBlue, rect, BorderSide.All)

			' Change the text alignment within the brick
			brickSFormat = visBrick.Style.StringFormat.ChangeFormatFlags(StringFormatFlags.DirectionVertical Or StringFormatFlags.DirectionRightToLeft)
			brickGraph.StringFormat = brickSFormat

			' Create a second rectangle.
			Dim rect1 As New RectangleF(New PointF(0, 75), New SizeF(180, 75))
			' Add the next brick to the report.
			visBrick = brickGraph.DrawString(s, Color.MidnightBlue, rect1, BorderSide.All)

			' Finish the report generation.
			printingSystem1.End()

			' Preview the report.
			printingSystem1.PreviewFormEx.Show()
		End Sub

	End Class
End Namespace