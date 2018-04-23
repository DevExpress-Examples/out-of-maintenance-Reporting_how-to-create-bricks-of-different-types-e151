namespace Bricks {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_ChangeFormatFlags = new System.Windows.Forms.Button();
            this.btn_ChangeAlignment = new System.Windows.Forms.Button();
            this.btn_BrickStringFormat = new System.Windows.Forms.Button();
            this.btn_BeginEndUnionRect = new System.Windows.Forms.Button();
            this.btn_DrawRect = new System.Windows.Forms.Button();
            this.btn_DrawPageInfo = new System.Windows.Forms.Button();
            this.btn_DrawPageImage = new System.Windows.Forms.Button();
            this.btn_DrawImage = new System.Windows.Forms.Button();
            this.btn_DrawCheckBox = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ChangeFormatFlags
            // 
            this.btn_ChangeFormatFlags.Location = new System.Drawing.Point(177, 164);
            this.btn_ChangeFormatFlags.Name = "btn_ChangeFormatFlags";
            this.btn_ChangeFormatFlags.Size = new System.Drawing.Size(119, 34);
            this.btn_ChangeFormatFlags.TabIndex = 26;
            this.btn_ChangeFormatFlags.Text = "ChangeFormatFlags";
            this.btn_ChangeFormatFlags.UseVisualStyleBackColor = true;
            this.btn_ChangeFormatFlags.Click += new System.EventHandler(this.btn_ChangeFormatFlags_Click);
            // 
            // btn_ChangeAlignment
            // 
            this.btn_ChangeAlignment.Location = new System.Drawing.Point(177, 121);
            this.btn_ChangeAlignment.Name = "btn_ChangeAlignment";
            this.btn_ChangeAlignment.Size = new System.Drawing.Size(119, 34);
            this.btn_ChangeAlignment.TabIndex = 25;
            this.btn_ChangeAlignment.Text = "ChangeAlignment";
            this.btn_ChangeAlignment.UseVisualStyleBackColor = true;
            this.btn_ChangeAlignment.Click += new System.EventHandler(this.btn_ChangeAlignment_Click);
            // 
            // btn_BrickStringFormat
            // 
            this.btn_BrickStringFormat.Location = new System.Drawing.Point(177, 78);
            this.btn_BrickStringFormat.Name = "btn_BrickStringFormat";
            this.btn_BrickStringFormat.Size = new System.Drawing.Size(119, 34);
            this.btn_BrickStringFormat.TabIndex = 24;
            this.btn_BrickStringFormat.Text = "BrickStringFormat";
            this.btn_BrickStringFormat.UseVisualStyleBackColor = true;
            this.btn_BrickStringFormat.Click += new System.EventHandler(this.btn_BrickStringFormat_Click);
            // 
            // btn_BeginEndUnionRect
            // 
            this.btn_BeginEndUnionRect.Location = new System.Drawing.Point(177, 35);
            this.btn_BeginEndUnionRect.Name = "btn_BeginEndUnionRect";
            this.btn_BeginEndUnionRect.Size = new System.Drawing.Size(119, 34);
            this.btn_BeginEndUnionRect.TabIndex = 23;
            this.btn_BeginEndUnionRect.Text = "BeginEndUnionRect";
            this.btn_BeginEndUnionRect.UseVisualStyleBackColor = true;
            this.btn_BeginEndUnionRect.Click += new System.EventHandler(this.btn_BeginEndUnionRect_Click);
            // 
            // btn_DrawRect
            // 
            this.btn_DrawRect.Location = new System.Drawing.Point(31, 207);
            this.btn_DrawRect.Name = "btn_DrawRect";
            this.btn_DrawRect.Size = new System.Drawing.Size(114, 34);
            this.btn_DrawRect.TabIndex = 22;
            this.btn_DrawRect.Text = "DrawRect";
            this.btn_DrawRect.UseVisualStyleBackColor = true;
            this.btn_DrawRect.Click += new System.EventHandler(this.btn_DrawRect_Click);
            // 
            // btn_DrawPageInfo
            // 
            this.btn_DrawPageInfo.Location = new System.Drawing.Point(31, 164);
            this.btn_DrawPageInfo.Name = "btn_DrawPageInfo";
            this.btn_DrawPageInfo.Size = new System.Drawing.Size(114, 34);
            this.btn_DrawPageInfo.TabIndex = 21;
            this.btn_DrawPageInfo.Text = "DrawPageInfo";
            this.btn_DrawPageInfo.UseVisualStyleBackColor = true;
            this.btn_DrawPageInfo.Click += new System.EventHandler(this.btn_DrawPageInfo_Click);
            // 
            // btn_DrawPageImage
            // 
            this.btn_DrawPageImage.Location = new System.Drawing.Point(31, 121);
            this.btn_DrawPageImage.Name = "btn_DrawPageImage";
            this.btn_DrawPageImage.Size = new System.Drawing.Size(114, 34);
            this.btn_DrawPageImage.TabIndex = 20;
            this.btn_DrawPageImage.Text = "DrawPageImage";
            this.btn_DrawPageImage.UseVisualStyleBackColor = true;
            this.btn_DrawPageImage.Click += new System.EventHandler(this.btn_DrawPageImage_Click);
            // 
            // btn_DrawImage
            // 
            this.btn_DrawImage.Location = new System.Drawing.Point(31, 78);
            this.btn_DrawImage.Name = "btn_DrawImage";
            this.btn_DrawImage.Size = new System.Drawing.Size(114, 34);
            this.btn_DrawImage.TabIndex = 19;
            this.btn_DrawImage.Text = "DrawImage";
            this.btn_DrawImage.UseVisualStyleBackColor = true;
            this.btn_DrawImage.Click += new System.EventHandler(this.btn_DrawImage_Click);
            // 
            // btn_DrawCheckBox
            // 
            this.btn_DrawCheckBox.Location = new System.Drawing.Point(31, 35);
            this.btn_DrawCheckBox.Name = "btn_DrawCheckBox";
            this.btn_DrawCheckBox.Size = new System.Drawing.Size(114, 34);
            this.btn_DrawCheckBox.TabIndex = 18;
            this.btn_DrawCheckBox.Text = "DrawCheckBox";
            this.btn_DrawCheckBox.UseVisualStyleBackColor = true;
            this.btn_DrawCheckBox.Click += new System.EventHandler(this.btn_DrawCheckBox_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "McCarran.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 268);
            this.Controls.Add(this.btn_ChangeFormatFlags);
            this.Controls.Add(this.btn_ChangeAlignment);
            this.Controls.Add(this.btn_BrickStringFormat);
            this.Controls.Add(this.btn_BeginEndUnionRect);
            this.Controls.Add(this.btn_DrawRect);
            this.Controls.Add(this.btn_DrawPageInfo);
            this.Controls.Add(this.btn_DrawPageImage);
            this.Controls.Add(this.btn_DrawImage);
            this.Controls.Add(this.btn_DrawCheckBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ChangeFormatFlags;
        private System.Windows.Forms.Button btn_ChangeAlignment;
        private System.Windows.Forms.Button btn_BrickStringFormat;
        private System.Windows.Forms.Button btn_BeginEndUnionRect;
        private System.Windows.Forms.Button btn_DrawRect;
        private System.Windows.Forms.Button btn_DrawPageInfo;
        private System.Windows.Forms.Button btn_DrawPageImage;
        private System.Windows.Forms.Button btn_DrawImage;
        private System.Windows.Forms.Button btn_DrawCheckBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
    }
}

