using System;
using System.Windows.Forms;
using System.Drawing;
using DevExpress.XtraPrinting;
// ...

namespace Bricks {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btn_DrawCheckBox_Click(object sender, EventArgs e) {

            VisualBrick visBrick;
            BrickGraphics brickGraph = printingSystem1.Graph;

            // Start the report generation.
            printingSystem1.Begin();

            // Create a rectangle.
            RectangleF rect = new RectangleF(new PointF(0, 0), new SizeF(60, 20));
            // Specify a page area.
            brickGraph.Modifier = BrickModifier.Detail;
            // Add a checkbox brick to the report.
            visBrick = brickGraph.DrawCheckBox(rect, BorderSide.All, SystemColors.ControlLight, true);

            // Finish the report generation.
            printingSystem1.End();

            // Preview the report.
            printingSystem1.PreviewFormEx.Show();
        }

        private void btn_DrawImage_Click(object sender, EventArgs e) {

            VisualBrick visBrick;
            Image img = imageList1.Images[0];
            BrickGraphics brickGraph = printingSystem1.Graph;

            // Start the report generation.
            printingSystem1.Begin();

            // Create a rectangle.
            RectangleF rect = new RectangleF(new PointF(0, 0), new SizeF(96, 96));
            // Specify a page area.
            brickGraph.Modifier = BrickModifier.Detail;
            // Add an image brick to the report.
            visBrick = brickGraph.DrawImage(img, rect, BorderSide.All, Color.White);

            // Finish the report generation.
            printingSystem1.End();

            // Preview the report.
            printingSystem1.PreviewFormEx.Show();
        }

        private void btn_DrawPageImage_Click(object sender, EventArgs e) {
            PageImageBrick pimBrick;
            Image img = imageList2.Images[0];
            BrickGraphics brickGraph = printingSystem1.Graph;

            // Start the report generation.
            printingSystem1.Begin();

            // Create a rectangle.
            RectangleF rect = new RectangleF(new PointF(0, 0), new SizeF(179, 34));
            // Specify a marginal page header area.
            brickGraph.Modifier = BrickModifier.MarginalHeader;
            // Create a page image brick.
            pimBrick = brickGraph.DrawPageImage(img, rect, BorderSide.None, Color.White);
            // Specify a Detail area.
            brickGraph.Modifier = BrickModifier.Detail;

            // Finish the report generation.
            printingSystem1.End();

            // Preview the report.
            printingSystem1.PreviewFormEx.Show();

        }

        private void btn_DrawPageInfo_Click(object sender, EventArgs e) {
            PageInfoBrick pinfoBrick;
            BrickGraphics brickGraph = printingSystem1.Graph;

            // Start the report generation.
            printingSystem1.Begin();

            // Create a rectangle.
            RectangleF rect = new RectangleF(new PointF(0, 0), new SizeF(250, 20));
            // Specify the page header.
            brickGraph.Modifier = BrickModifier.MarginalHeader;
            // Create page info brick to display time in full format.
            pinfoBrick = brickGraph.DrawPageInfo(PageInfo.DateTime, "{0:F}", Color.Black, rect, BorderSide.None);
            // Specify the page footer.
            brickGraph.Modifier = BrickModifier.MarginalFooter;
            // Create a page info brick to display page number.
            pinfoBrick = brickGraph.DrawPageInfo(PageInfo.NumberOfTotal, "Page {0} of {1}", Color.Black, rect, BorderSide.None);

            // Finish the report generation.
            printingSystem1.End();

            // Preview the report.
            printingSystem1.PreviewFormEx.Show();
        }

        private void btn_DrawRect_Click(object sender, EventArgs e) {
            VisualBrick visBrick;
            BrickGraphics brickGraph = printingSystem1.Graph;

            // Start the report generation.
            printingSystem1.Begin();

            // Create a rectangle.
            RectangleF rect = new RectangleF(new PointF(0, 0), new SizeF(150, 50));
            // Specify a page area.
            brickGraph.Modifier = BrickModifier.Detail;
            // Add a brick to the report.
            visBrick = brickGraph.DrawRect(rect, BorderSide.All, Color.Yellow, Color.Blue);

            // Finish the report generation.
            printingSystem1.End();

            // Preview the report.
            printingSystem1.PreviewFormEx.Show();
        }

        private void btn_BeginEndUnionRect_Click(object sender, EventArgs e) {
            BrickGraphics brickGraph = printingSystem1.Graph;
            int top = 0;

            // Start the report generation.
            printingSystem1.Begin();

            // Specify a page area.
            brickGraph.Modifier = BrickModifier.Detail;
            // Start drawing a brick group.
            brickGraph.BeginUnionRect();

            // Specify formatting.
            brickGraph.StringFormat = new BrickStringFormat(StringAlignment.Center, StringAlignment.Center);
            brickGraph.BackColor = Color.Khaki;
            brickGraph.BorderColor = Color.MidnightBlue;
            brickGraph.Font = new Font("Tahoma", 14, FontStyle.Bold | FontStyle.Italic);

            // Draw bricks.
            brickGraph.DrawString("Developer Express", Color.MidnightBlue,
                new RectangleF(0, 0, 150, 50), BorderSide.All);
            top += 50;
            brickGraph.DrawString("100% Native", Color.MidnightBlue,
                new RectangleF(0, top, 150, 50), BorderSide.All);
            top += 50;
            brickGraph.DrawString(".NET Tecnologies", Color.MidnightBlue,
                new RectangleF(0, top, 150, 50), BorderSide.All);

            // Finish drawing a brick group.
            brickGraph.EndUnionRect();

            // Finish the report generation.
            printingSystem1.End();

            // Preview the report.
            printingSystem1.PreviewFormEx.Show();

        }

        private void btn_BrickStringFormat_Click(object sender, EventArgs e) {
            VisualBrick visBrick;
            BrickGraphics brickGraph = printingSystem1.Graph;
            string s = "Developer Express Inc.";

            // Specify the string format.
            StringFormat sFormat = new StringFormat(StringFormatFlags.DirectionVertical);
            sFormat.Alignment = StringAlignment.Center;
            sFormat.LineAlignment = StringAlignment.Center;

            // Create the BrickStringFormat object.
            BrickStringFormat brickSFormat = new BrickStringFormat(sFormat);

            // Measure the string according to the specified format
            SizeF sz = brickGraph.MeasureString(s, 30, sFormat);


            // Start the report generation.
            printingSystem1.Begin();

            // Set the brick string format
            brickGraph.StringFormat = brickSFormat;

            // Create a rectangle.
            RectangleF rect = new RectangleF(new PointF(0, 0), new SizeF(30, 150));
            // Specify a page area.
            brickGraph.Modifier = BrickModifier.Detail;
            // Add a brick to the report.
            visBrick = brickGraph.DrawString(s, Color.MidnightBlue, rect, BorderSide.All);

            // Finish the report generation.
            printingSystem1.End();

            // Preview the report.
            printingSystem1.PreviewFormEx.Show();
        }

        private void btn_ChangeAlignment_Click(object sender, EventArgs e) {

            VisualBrick visBrick;
            BrickGraphics brickGraph = printingSystem1.Graph;
            string s = "Developer Express Inc.";
            BrickStringFormat brickSFormat = new BrickStringFormat();

            // Start the report generation.
            printingSystem1.Begin();

            // Specify a page area.
            brickGraph.Modifier = BrickModifier.Detail;

            // Create a rectangle.
            RectangleF rect = new RectangleF(new PointF(0, 0), new SizeF(180, 50));
            // Add a brick to the report.
            visBrick = brickGraph.DrawString(s, Color.MidnightBlue, rect, BorderSide.All);

            // Change the text alignment within the brick
            brickSFormat = visBrick.Style.StringFormat.ChangeAlignment(StringAlignment.Far);
            brickSFormat = brickSFormat.ChangeLineAlignment(StringAlignment.Far);
            brickGraph.StringFormat = brickSFormat;

            // Create a second rectangle.
            RectangleF rect1 = new RectangleF(new PointF(0, 50), new SizeF(180, 50));
            // Add the next brick to the report.
            visBrick = brickGraph.DrawString(s, Color.MidnightBlue, rect1, BorderSide.All);

            // Finish the report generation.
            printingSystem1.End();

            // Preview the report.
            printingSystem1.PreviewFormEx.Show();

        }

        private void btn_ChangeFormatFlags_Click(object sender, EventArgs e) {
            VisualBrick visBrick;
            BrickGraphics brickGraph = printingSystem1.Graph;
            string s = "Developer Express Inc.";
            BrickStringFormat brickSFormat = new BrickStringFormat();

            // Start the report generation.
            printingSystem1.Begin();

            // Specify a page area.
            brickGraph.Modifier = BrickModifier.Detail;

            // Create a rectangle.
            RectangleF rect = new RectangleF(new PointF(0, 0), new SizeF(180, 75));
            // Add a brick to the report.
            visBrick = brickGraph.DrawString(s, Color.MidnightBlue, rect, BorderSide.All);

            // Change the text alignment within the brick
            brickSFormat = visBrick.Style.StringFormat.ChangeFormatFlags(StringFormatFlags.DirectionVertical
                | StringFormatFlags.DirectionRightToLeft);
            brickGraph.StringFormat = brickSFormat;

            // Create a second rectangle.
            RectangleF rect1 = new RectangleF(new PointF(0, 75), new SizeF(180, 75));
            // Add the next brick to the report.
            visBrick = brickGraph.DrawString(s, Color.MidnightBlue, rect1, BorderSide.All);

            // Finish the report generation.
            printingSystem1.End();

            // Preview the report.
            printingSystem1.PreviewFormEx.Show();
        }

    }
}