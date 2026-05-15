
namespace ArcadeMaker.IDE
{
    partial class SpriteDesigner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.okBtn = new System.Windows.Forms.Button();
            this.zoomOutBtn = new System.Windows.Forms.Button();
            this.zoomInBtn = new System.Windows.Forms.Button();
            this.penBtn = new System.Windows.Forms.Button();
            this.lineBtn = new System.Windows.Forms.Button();
            this.fillBtn = new System.Windows.Forms.Button();
            this.rectBtn = new System.Windows.Forms.Button();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.shapeDrawBtn = new System.Windows.Forms.Button();
            this.shapeDrawFillBtn = new System.Windows.Forms.Button();
            this.shapeFillBtn = new System.Windows.Forms.Button();
            this.ellipseBtn = new System.Windows.Forms.Button();
            this.pickColBtn = new System.Windows.Forms.Button();
            this.drawFillGroupBox = new System.Windows.Forms.GroupBox();
            this.widthGroupBox = new System.Windows.Forms.GroupBox();
            this.width6Btn = new System.Windows.Forms.Button();
            this.width5Btn = new System.Windows.Forms.Button();
            this.width4Btn = new System.Windows.Forms.Button();
            this.width3Btn = new System.Windows.Forms.Button();
            this.width2Btn = new System.Windows.Forms.Button();
            this.width1Btn = new System.Windows.Forms.Button();
            this.toleranceBox = new System.Windows.Forms.TrackBar();
            this.toleranceGroupBox = new System.Windows.Forms.GroupBox();
            this.toleranceNumericBox = new System.Windows.Forms.NumericUpDown();
            this.toolBox = new System.Windows.Forms.GroupBox();
            this.colorPicker = new ArcadeMaker.IDE.GSColorPicker();
            this.showGridBtn = new System.Windows.Forms.Button();
            this.poffsetBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.imagePanel.SuspendLayout();
            this.drawFillGroupBox.SuspendLayout();
            this.widthGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toleranceBox)).BeginInit();
            this.toleranceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toleranceNumericBox)).BeginInit();
            this.toolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poffsetBox)).BeginInit();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okBtn.Location = new System.Drawing.Point(12, 463);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // zoomOutBtn
            // 
            this.zoomOutBtn.Location = new System.Drawing.Point(150, 17);
            this.zoomOutBtn.Name = "zoomOutBtn";
            this.zoomOutBtn.Size = new System.Drawing.Size(26, 23);
            this.zoomOutBtn.TabIndex = 3;
            this.zoomOutBtn.Text = "-";
            this.zoomOutBtn.UseVisualStyleBackColor = true;
            this.zoomOutBtn.Click += new System.EventHandler(this.zoomOutBtn_Click);
            // 
            // zoomInBtn
            // 
            this.zoomInBtn.Location = new System.Drawing.Point(182, 17);
            this.zoomInBtn.Name = "zoomInBtn";
            this.zoomInBtn.Size = new System.Drawing.Size(26, 23);
            this.zoomInBtn.TabIndex = 4;
            this.zoomInBtn.Text = "+";
            this.zoomInBtn.UseVisualStyleBackColor = true;
            this.zoomInBtn.Click += new System.EventHandler(this.zoomInBtn_Click);
            // 
            // penBtn
            // 
            this.penBtn.Location = new System.Drawing.Point(12, 19);
            this.penBtn.Name = "penBtn";
            this.penBtn.Size = new System.Drawing.Size(26, 23);
            this.penBtn.TabIndex = 5;
            this.penBtn.Text = "✎";
            this.penBtn.UseVisualStyleBackColor = true;
            this.penBtn.Click += new System.EventHandler(this.penBtn_Click);
            // 
            // lineBtn
            // 
            this.lineBtn.Location = new System.Drawing.Point(12, 48);
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(26, 23);
            this.lineBtn.TabIndex = 6;
            this.lineBtn.Text = "\\";
            this.lineBtn.UseVisualStyleBackColor = true;
            this.lineBtn.Click += new System.EventHandler(this.lineBtn_Click);
            // 
            // fillBtn
            // 
            this.fillBtn.Location = new System.Drawing.Point(12, 77);
            this.fillBtn.Name = "fillBtn";
            this.fillBtn.Size = new System.Drawing.Size(26, 23);
            this.fillBtn.TabIndex = 7;
            this.fillBtn.Text = "+";
            this.fillBtn.UseVisualStyleBackColor = true;
            this.fillBtn.Click += new System.EventHandler(this.fillBtn_Click);
            // 
            // rectBtn
            // 
            this.rectBtn.Location = new System.Drawing.Point(44, 48);
            this.rectBtn.Name = "rectBtn";
            this.rectBtn.Size = new System.Drawing.Size(26, 23);
            this.rectBtn.TabIndex = 8;
            this.rectBtn.Text = "▯";
            this.rectBtn.UseVisualStyleBackColor = true;
            this.rectBtn.Click += new System.EventHandler(this.rectBtn_Click);
            // 
            // imageBox
            // 
            this.imageBox.BackColor = System.Drawing.Color.Transparent;
            this.imageBox.Location = new System.Drawing.Point(3, 3);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(143, 123);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 0;
            this.imageBox.TabStop = false;
            this.imageBox.Click += new System.EventHandler(this.imageBox_Click);
            this.imageBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseDown);
            this.imageBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseMove);
            this.imageBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseUp);
            // 
            // imagePanel
            // 
            this.imagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagePanel.AutoScroll = true;
            this.imagePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imagePanel.Controls.Add(this.imageBox);
            this.imagePanel.Location = new System.Drawing.Point(151, 46);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(428, 440);
            this.imagePanel.TabIndex = 10;
            // 
            // shapeDrawBtn
            // 
            this.shapeDrawBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.shapeDrawBtn.Location = new System.Drawing.Point(6, 19);
            this.shapeDrawBtn.Name = "shapeDrawBtn";
            this.shapeDrawBtn.Size = new System.Drawing.Size(69, 23);
            this.shapeDrawBtn.TabIndex = 11;
            this.shapeDrawBtn.Text = "Border";
            this.shapeDrawBtn.UseVisualStyleBackColor = true;
            this.shapeDrawBtn.Click += new System.EventHandler(this.shapeDrawBtn_Click);
            // 
            // shapeDrawFillBtn
            // 
            this.shapeDrawFillBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.shapeDrawFillBtn.Location = new System.Drawing.Point(6, 48);
            this.shapeDrawFillBtn.Name = "shapeDrawFillBtn";
            this.shapeDrawFillBtn.Size = new System.Drawing.Size(69, 23);
            this.shapeDrawFillBtn.TabIndex = 12;
            this.shapeDrawFillBtn.Text = "Border  Fill";
            this.shapeDrawFillBtn.UseVisualStyleBackColor = true;
            this.shapeDrawFillBtn.Click += new System.EventHandler(this.shapeDrawFillBtn_Click);
            // 
            // shapeFillBtn
            // 
            this.shapeFillBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.shapeFillBtn.Location = new System.Drawing.Point(6, 77);
            this.shapeFillBtn.Name = "shapeFillBtn";
            this.shapeFillBtn.Size = new System.Drawing.Size(69, 23);
            this.shapeFillBtn.TabIndex = 13;
            this.shapeFillBtn.Text = "Fill";
            this.shapeFillBtn.UseVisualStyleBackColor = true;
            this.shapeFillBtn.Click += new System.EventHandler(this.shapeFillBtn_Click);
            // 
            // ellipseBtn
            // 
            this.ellipseBtn.Location = new System.Drawing.Point(44, 77);
            this.ellipseBtn.Name = "ellipseBtn";
            this.ellipseBtn.Size = new System.Drawing.Size(26, 23);
            this.ellipseBtn.TabIndex = 14;
            this.ellipseBtn.Text = "◯";
            this.ellipseBtn.UseVisualStyleBackColor = true;
            this.ellipseBtn.Click += new System.EventHandler(this.ellipseBtn_Click);
            // 
            // pickColBtn
            // 
            this.pickColBtn.Location = new System.Drawing.Point(44, 19);
            this.pickColBtn.Name = "pickColBtn";
            this.pickColBtn.Size = new System.Drawing.Size(26, 23);
            this.pickColBtn.TabIndex = 15;
            this.pickColBtn.Text = "P";
            this.pickColBtn.UseVisualStyleBackColor = true;
            this.pickColBtn.Click += new System.EventHandler(this.pickColBtn_Click);
            // 
            // drawFillGroupBox
            // 
            this.drawFillGroupBox.Controls.Add(this.shapeDrawBtn);
            this.drawFillGroupBox.Controls.Add(this.shapeDrawFillBtn);
            this.drawFillGroupBox.Controls.Add(this.shapeFillBtn);
            this.drawFillGroupBox.Location = new System.Drawing.Point(12, 237);
            this.drawFillGroupBox.Name = "drawFillGroupBox";
            this.drawFillGroupBox.Size = new System.Drawing.Size(116, 114);
            this.drawFillGroupBox.TabIndex = 16;
            this.drawFillGroupBox.TabStop = false;
            this.drawFillGroupBox.Text = "Shape";
            // 
            // widthGroupBox
            // 
            this.widthGroupBox.Controls.Add(this.width6Btn);
            this.widthGroupBox.Controls.Add(this.width5Btn);
            this.widthGroupBox.Controls.Add(this.width4Btn);
            this.widthGroupBox.Controls.Add(this.width3Btn);
            this.widthGroupBox.Controls.Add(this.width2Btn);
            this.widthGroupBox.Controls.Add(this.width1Btn);
            this.widthGroupBox.Location = new System.Drawing.Point(12, 131);
            this.widthGroupBox.Name = "widthGroupBox";
            this.widthGroupBox.Size = new System.Drawing.Size(116, 100);
            this.widthGroupBox.TabIndex = 17;
            this.widthGroupBox.TabStop = false;
            this.widthGroupBox.Text = "Width";
            // 
            // width6Btn
            // 
            this.width6Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.width6Btn.Location = new System.Drawing.Point(76, 64);
            this.width6Btn.Name = "width6Btn";
            this.width6Btn.Size = new System.Drawing.Size(29, 30);
            this.width6Btn.TabIndex = 5;
            this.width6Btn.Text = "⬤";
            this.width6Btn.UseVisualStyleBackColor = true;
            this.width6Btn.Click += new System.EventHandler(this.width6Btn_Click);
            // 
            // width5Btn
            // 
            this.width5Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.width5Btn.Location = new System.Drawing.Point(41, 64);
            this.width5Btn.Name = "width5Btn";
            this.width5Btn.Size = new System.Drawing.Size(29, 30);
            this.width5Btn.TabIndex = 4;
            this.width5Btn.Text = "⬤";
            this.width5Btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.width5Btn.UseVisualStyleBackColor = true;
            this.width5Btn.Click += new System.EventHandler(this.width5Btn_Click);
            // 
            // width4Btn
            // 
            this.width4Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.width4Btn.Location = new System.Drawing.Point(6, 64);
            this.width4Btn.Name = "width4Btn";
            this.width4Btn.Size = new System.Drawing.Size(29, 30);
            this.width4Btn.TabIndex = 3;
            this.width4Btn.Text = "⬤";
            this.width4Btn.UseVisualStyleBackColor = true;
            this.width4Btn.Click += new System.EventHandler(this.width4Btn_Click);
            // 
            // width3Btn
            // 
            this.width3Btn.Location = new System.Drawing.Point(76, 19);
            this.width3Btn.Name = "width3Btn";
            this.width3Btn.Size = new System.Drawing.Size(29, 28);
            this.width3Btn.TabIndex = 2;
            this.width3Btn.Text = "⬤";
            this.width3Btn.UseVisualStyleBackColor = true;
            this.width3Btn.Click += new System.EventHandler(this.width3Btn_Click);
            // 
            // width2Btn
            // 
            this.width2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.width2Btn.Location = new System.Drawing.Point(41, 19);
            this.width2Btn.Name = "width2Btn";
            this.width2Btn.Size = new System.Drawing.Size(29, 28);
            this.width2Btn.TabIndex = 1;
            this.width2Btn.Text = "⬤";
            this.width2Btn.UseVisualStyleBackColor = true;
            this.width2Btn.Click += new System.EventHandler(this.width2Btn_Click);
            // 
            // width1Btn
            // 
            this.width1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.width1Btn.Location = new System.Drawing.Point(6, 19);
            this.width1Btn.Name = "width1Btn";
            this.width1Btn.Size = new System.Drawing.Size(29, 28);
            this.width1Btn.TabIndex = 0;
            this.width1Btn.Text = "⬤";
            this.width1Btn.UseVisualStyleBackColor = true;
            this.width1Btn.Click += new System.EventHandler(this.width1Btn_Click);
            // 
            // toleranceBox
            // 
            this.toleranceBox.Location = new System.Drawing.Point(6, 49);
            this.toleranceBox.Maximum = 441;
            this.toleranceBox.Name = "toleranceBox";
            this.toleranceBox.Size = new System.Drawing.Size(104, 45);
            this.toleranceBox.TabIndex = 18;
            this.toleranceBox.Scroll += new System.EventHandler(this.toleranceBox_Scroll);
            // 
            // toleranceGroupBox
            // 
            this.toleranceGroupBox.Controls.Add(this.toleranceNumericBox);
            this.toleranceGroupBox.Controls.Add(this.toleranceBox);
            this.toleranceGroupBox.Location = new System.Drawing.Point(12, 357);
            this.toleranceGroupBox.Name = "toleranceGroupBox";
            this.toleranceGroupBox.Size = new System.Drawing.Size(116, 100);
            this.toleranceGroupBox.TabIndex = 19;
            this.toleranceGroupBox.TabStop = false;
            this.toleranceGroupBox.Text = "Tolerance";
            this.toleranceGroupBox.Visible = false;
            // 
            // toleranceNumericBox
            // 
            this.toleranceNumericBox.Location = new System.Drawing.Point(13, 23);
            this.toleranceNumericBox.Maximum = new decimal(new int[] {
            441,
            0,
            0,
            0});
            this.toleranceNumericBox.Name = "toleranceNumericBox";
            this.toleranceNumericBox.Size = new System.Drawing.Size(97, 20);
            this.toleranceNumericBox.TabIndex = 19;
            this.toleranceNumericBox.ValueChanged += new System.EventHandler(this.toleranceNumericBox_ValueChanged);
            // 
            // toolBox
            // 
            this.toolBox.Controls.Add(this.pickColBtn);
            this.toolBox.Controls.Add(this.penBtn);
            this.toolBox.Controls.Add(this.lineBtn);
            this.toolBox.Controls.Add(this.fillBtn);
            this.toolBox.Controls.Add(this.rectBtn);
            this.toolBox.Controls.Add(this.ellipseBtn);
            this.toolBox.Location = new System.Drawing.Point(15, 10);
            this.toolBox.Name = "toolBox";
            this.toolBox.Size = new System.Drawing.Size(113, 115);
            this.toolBox.TabIndex = 20;
            this.toolBox.TabStop = false;
            this.toolBox.Text = "Tools";
            // 
            // colorPicker
            // 
            this.colorPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPicker.Color1 = System.Drawing.Color.Black;
            this.colorPicker.Color2 = System.Drawing.Color.White;
            this.colorPicker.Location = new System.Drawing.Point(585, 26);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(91, 363);
            this.colorPicker.TabIndex = 9;
            // 
            // showGridBtn
            // 
            this.showGridBtn.Location = new System.Drawing.Point(273, 17);
            this.showGridBtn.Name = "showGridBtn";
            this.showGridBtn.Size = new System.Drawing.Size(26, 23);
            this.showGridBtn.TabIndex = 21;
            this.showGridBtn.Text = "#";
            this.showGridBtn.UseVisualStyleBackColor = true;
            this.showGridBtn.Click += new System.EventHandler(this.showGridBtn_Click);
            // 
            // poffsetBox
            // 
            this.poffsetBox.DecimalPlaces = 3;
            this.poffsetBox.Location = new System.Drawing.Point(349, 20);
            this.poffsetBox.Name = "poffsetBox";
            this.poffsetBox.Size = new System.Drawing.Size(120, 20);
            this.poffsetBox.TabIndex = 22;
            this.poffsetBox.ValueChanged += new System.EventHandler(this.poffsetBox_ValueChanged);
            // 
            // SpriteDesigner
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(682, 496);
            this.Controls.Add(this.poffsetBox);
            this.Controls.Add(this.showGridBtn);
            this.Controls.Add(this.toolBox);
            this.Controls.Add(this.toleranceGroupBox);
            this.Controls.Add(this.widthGroupBox);
            this.Controls.Add(this.drawFillGroupBox);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.colorPicker);
            this.Controls.Add(this.zoomInBtn);
            this.Controls.Add(this.zoomOutBtn);
            this.Controls.Add(this.okBtn);
            this.Name = "SpriteDesigner";
            this.Text = "Sprite Designer";
            this.Load += new System.EventHandler(this.SpriteDesigner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.imagePanel.ResumeLayout(false);
            this.drawFillGroupBox.ResumeLayout(false);
            this.widthGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toleranceBox)).EndInit();
            this.toleranceGroupBox.ResumeLayout(false);
            this.toleranceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toleranceNumericBox)).EndInit();
            this.toolBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.poffsetBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button zoomOutBtn;
        private System.Windows.Forms.Button zoomInBtn;
        private System.Windows.Forms.Button penBtn;
        private System.Windows.Forms.Button lineBtn;
        private System.Windows.Forms.Button fillBtn;
        private System.Windows.Forms.Button rectBtn;
        private GSColorPicker colorPicker;
        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.Button shapeDrawBtn;
        private System.Windows.Forms.Button shapeDrawFillBtn;
        private System.Windows.Forms.Button shapeFillBtn;
        private System.Windows.Forms.Button ellipseBtn;
        private System.Windows.Forms.Button pickColBtn;
        private System.Windows.Forms.GroupBox drawFillGroupBox;
        private System.Windows.Forms.GroupBox widthGroupBox;
        private System.Windows.Forms.Button width6Btn;
        private System.Windows.Forms.Button width5Btn;
        private System.Windows.Forms.Button width4Btn;
        private System.Windows.Forms.Button width3Btn;
        private System.Windows.Forms.Button width2Btn;
        private System.Windows.Forms.Button width1Btn;
        private System.Windows.Forms.TrackBar toleranceBox;
        private System.Windows.Forms.GroupBox toleranceGroupBox;
        private System.Windows.Forms.NumericUpDown toleranceNumericBox;
        private System.Windows.Forms.GroupBox toolBox;
        private System.Windows.Forms.Button showGridBtn;
        private System.Windows.Forms.NumericUpDown poffsetBox;
    }
}