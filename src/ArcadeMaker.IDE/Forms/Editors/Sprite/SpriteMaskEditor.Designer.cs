
namespace ArcadeMaker.IDE
{
    partial class SpriteMaskEditor
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
            groupBox1 = new GroupBox();
            indexPrevBtn = new Button();
            showCollisionMaskBox = new CheckBox();
            zoomInBtn = new Button();
            resetZoomBtn = new Button();
            zoomOutBtn = new Button();
            indexNextBtn = new Button();
            imageIndexLbl = new Label();
            detailsLbl = new Label();
            groupBox2 = new GroupBox();
            boundingBottomBox = new NumericUpDown();
            boundingRightBox = new NumericUpDown();
            boundingTopBox = new NumericUpDown();
            boundingLeftBox = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            boundingManualOpt = new RadioButton();
            boundingFullOpt = new RadioButton();
            boundingAutoOpt = new RadioButton();
            groupBox3 = new GroupBox();
            alphaToleranceBox = new NumericUpDown();
            label6 = new Label();
            alphaToleranceBar = new TrackBar();
            separateMasksBox = new CheckBox();
            okBtn = new Button();
            previewBox = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)boundingBottomBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boundingRightBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boundingTopBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boundingLeftBox).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)alphaToleranceBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alphaToleranceBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)previewBox).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(indexPrevBtn);
            groupBox1.Controls.Add(showCollisionMaskBox);
            groupBox1.Controls.Add(zoomInBtn);
            groupBox1.Controls.Add(resetZoomBtn);
            groupBox1.Controls.Add(zoomOutBtn);
            groupBox1.Controls.Add(indexNextBtn);
            groupBox1.Controls.Add(imageIndexLbl);
            groupBox1.Controls.Add(detailsLbl);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(169, 164);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Image";
            // 
            // indexPrevBtn
            // 
            indexPrevBtn.Location = new Point(42, 66);
            indexPrevBtn.Name = "indexPrevBtn";
            indexPrevBtn.Size = new Size(24, 19);
            indexPrevBtn.TabIndex = 7;
            indexPrevBtn.Text = "<";
            indexPrevBtn.UseVisualStyleBackColor = true;
            indexPrevBtn.Visible = false;
            indexPrevBtn.Click += indexPrevBtn_Click;
            // 
            // showCollisionMaskBox
            // 
            showCollisionMaskBox.AutoSize = true;
            showCollisionMaskBox.Checked = true;
            showCollisionMaskBox.CheckState = CheckState.Checked;
            showCollisionMaskBox.Location = new Point(7, 98);
            showCollisionMaskBox.Name = "showCollisionMaskBox";
            showCollisionMaskBox.Size = new Size(133, 19);
            showCollisionMaskBox.TabIndex = 6;
            showCollisionMaskBox.Text = "Show collision mask";
            showCollisionMaskBox.UseVisualStyleBackColor = true;
            showCollisionMaskBox.CheckedChanged += showCollisionMaskBox_CheckedChanged;
            // 
            // zoomInBtn
            // 
            zoomInBtn.Location = new Point(79, 121);
            zoomInBtn.Name = "zoomInBtn";
            zoomInBtn.Size = new Size(30, 23);
            zoomInBtn.TabIndex = 5;
            zoomInBtn.Text = "🔎";
            zoomInBtn.UseVisualStyleBackColor = true;
            // 
            // resetZoomBtn
            // 
            resetZoomBtn.Location = new Point(43, 121);
            resetZoomBtn.Name = "resetZoomBtn";
            resetZoomBtn.Size = new Size(30, 23);
            resetZoomBtn.TabIndex = 4;
            resetZoomBtn.Text = "🔎";
            resetZoomBtn.UseVisualStyleBackColor = true;
            // 
            // zoomOutBtn
            // 
            zoomOutBtn.Location = new Point(7, 121);
            zoomOutBtn.Name = "zoomOutBtn";
            zoomOutBtn.Size = new Size(30, 23);
            zoomOutBtn.TabIndex = 3;
            zoomOutBtn.Text = "🔎";
            zoomOutBtn.UseVisualStyleBackColor = true;
            // 
            // indexNextBtn
            // 
            indexNextBtn.Location = new Point(96, 66);
            indexNextBtn.Name = "indexNextBtn";
            indexNextBtn.Size = new Size(24, 19);
            indexNextBtn.TabIndex = 2;
            indexNextBtn.Text = ">";
            indexNextBtn.UseVisualStyleBackColor = true;
            indexNextBtn.Click += indexNextBtn_Click;
            // 
            // imageIndexLbl
            // 
            imageIndexLbl.AutoSize = true;
            imageIndexLbl.BorderStyle = BorderStyle.Fixed3D;
            imageIndexLbl.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 177);
            imageIndexLbl.Location = new Point(72, 66);
            imageIndexLbl.Name = "imageIndexLbl";
            imageIndexLbl.Size = new Size(18, 19);
            imageIndexLbl.TabIndex = 1;
            imageIndexLbl.Text = "0";
            // 
            // detailsLbl
            // 
            detailsLbl.AutoSize = true;
            detailsLbl.Location = new Point(7, 20);
            detailsLbl.Name = "detailsLbl";
            detailsLbl.Size = new Size(143, 75);
            detailsLbl.TabIndex = 0;
            detailsLbl.Text = "Width: 32   Height: 32\r\n\r\nNumber of subimages: 32\r\n\r\nShow:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(boundingBottomBox);
            groupBox2.Controls.Add(boundingRightBox);
            groupBox2.Controls.Add(boundingTopBox);
            groupBox2.Controls.Add(boundingLeftBox);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(boundingManualOpt);
            groupBox2.Controls.Add(boundingFullOpt);
            groupBox2.Controls.Add(boundingAutoOpt);
            groupBox2.Location = new Point(187, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(186, 146);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bounding Box";
            // 
            // boundingBottomBox
            // 
            boundingBottomBox.Enabled = false;
            boundingBottomBox.Location = new Point(138, 115);
            boundingBottomBox.Name = "boundingBottomBox";
            boundingBottomBox.Size = new Size(44, 23);
            boundingBottomBox.TabIndex = 13;
            boundingBottomBox.ValueChanged += boundingBottomBox_ValueChanged;
            // 
            // boundingRightBox
            // 
            boundingRightBox.Enabled = false;
            boundingRightBox.Location = new Point(138, 86);
            boundingRightBox.Name = "boundingRightBox";
            boundingRightBox.Size = new Size(44, 23);
            boundingRightBox.TabIndex = 12;
            boundingRightBox.ValueChanged += boundingRightBox_ValueChanged;
            // 
            // boundingTopBox
            // 
            boundingTopBox.Enabled = false;
            boundingTopBox.Location = new Point(37, 116);
            boundingTopBox.Name = "boundingTopBox";
            boundingTopBox.Size = new Size(42, 23);
            boundingTopBox.TabIndex = 11;
            boundingTopBox.ValueChanged += boundingTopBox_ValueChanged;
            // 
            // boundingLeftBox
            // 
            boundingLeftBox.Enabled = false;
            boundingLeftBox.Location = new Point(37, 88);
            boundingLeftBox.Name = "boundingLeftBox";
            boundingLeftBox.Size = new Size(42, 23);
            boundingLeftBox.TabIndex = 10;
            boundingLeftBox.ValueChanged += boundingLeftBox_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 118);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 9;
            label5.Text = "Bottom";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 118);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 7;
            label4.Text = "Top";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 90);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 5;
            label3.Text = "Right";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 90);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 3;
            label2.Text = "Left";
            // 
            // boundingManualOpt
            // 
            boundingManualOpt.AutoSize = true;
            boundingManualOpt.Location = new Point(6, 65);
            boundingManualOpt.Name = "boundingManualOpt";
            boundingManualOpt.Size = new Size(65, 19);
            boundingManualOpt.TabIndex = 2;
            boundingManualOpt.Text = "Manual";
            boundingManualOpt.UseVisualStyleBackColor = true;
            boundingManualOpt.CheckedChanged += boundingManualOpt_CheckedChanged;
            // 
            // boundingFullOpt
            // 
            boundingFullOpt.AutoSize = true;
            boundingFullOpt.Location = new Point(6, 42);
            boundingFullOpt.Name = "boundingFullOpt";
            boundingFullOpt.Size = new Size(80, 19);
            boundingFullOpt.TabIndex = 1;
            boundingFullOpt.Text = "Full Image";
            boundingFullOpt.UseVisualStyleBackColor = true;
            boundingFullOpt.CheckedChanged += boundingFullOpt_CheckedChanged;
            // 
            // boundingAutoOpt
            // 
            boundingAutoOpt.AutoSize = true;
            boundingAutoOpt.Checked = true;
            boundingAutoOpt.Location = new Point(6, 19);
            boundingAutoOpt.Name = "boundingAutoOpt";
            boundingAutoOpt.Size = new Size(81, 19);
            boundingAutoOpt.TabIndex = 0;
            boundingAutoOpt.TabStop = true;
            boundingAutoOpt.Text = "Automatic";
            boundingAutoOpt.UseVisualStyleBackColor = true;
            boundingAutoOpt.CheckedChanged += boundingAutoOpt_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(alphaToleranceBox);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(alphaToleranceBar);
            groupBox3.Controls.Add(separateMasksBox);
            groupBox3.Location = new Point(12, 182);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(169, 98);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "General";
            // 
            // alphaToleranceBox
            // 
            alphaToleranceBox.Location = new Point(116, 60);
            alphaToleranceBox.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            alphaToleranceBox.Name = "alphaToleranceBox";
            alphaToleranceBox.Size = new Size(42, 23);
            alphaToleranceBox.TabIndex = 14;
            alphaToleranceBox.ValueChanged += alphaToleranceBox_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 44);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 2;
            label6.Text = "Alpha Tolerance:";
            // 
            // alphaToleranceBar
            // 
            alphaToleranceBar.AccessibleDescription = "";
            alphaToleranceBar.Location = new Point(6, 60);
            alphaToleranceBar.Maximum = 255;
            alphaToleranceBar.Name = "alphaToleranceBar";
            alphaToleranceBar.Size = new Size(104, 45);
            alphaToleranceBar.TabIndex = 1;
            alphaToleranceBar.Scroll += alphaToleranceBar_Scroll;
            // 
            // separateMasksBox
            // 
            separateMasksBox.AutoSize = true;
            separateMasksBox.Location = new Point(10, 20);
            separateMasksBox.Name = "separateMasksBox";
            separateMasksBox.Size = new Size(154, 19);
            separateMasksBox.TabIndex = 0;
            separateMasksBox.Text = "Separate collision masks";
            separateMasksBox.UseVisualStyleBackColor = true;
            separateMasksBox.CheckedChanged += separateMasksBox_CheckedChanged;
            // 
            // okBtn
            // 
            okBtn.Location = new Point(145, 286);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(75, 23);
            okBtn.TabIndex = 3;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // previewBox
            // 
            previewBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            previewBox.BorderStyle = BorderStyle.Fixed3D;
            previewBox.Location = new Point(379, 13);
            previewBox.Name = "previewBox";
            previewBox.Size = new Size(222, 296);
            previewBox.TabIndex = 4;
            previewBox.TabStop = false;
            previewBox.Paint += previewBox_Paint;
            previewBox.MouseDown += previewBox_MouseDown;
            previewBox.MouseMove += previewBox_MouseMove;
            previewBox.MouseUp += previewBox_MouseUp;
            // 
            // SpriteMaskEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 321);
            Controls.Add(previewBox);
            Controls.Add(okBtn);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "SpriteMaskEditor";
            Text = "Mask Properties";
            Load += SpriteMaskEditor_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)boundingBottomBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)boundingRightBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)boundingTopBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)boundingLeftBox).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)alphaToleranceBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)alphaToleranceBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)previewBox).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label detailsLbl;
        private System.Windows.Forms.CheckBox showCollisionMaskBox;
        private System.Windows.Forms.Button zoomInBtn;
        private System.Windows.Forms.Button resetZoomBtn;
        private System.Windows.Forms.Button zoomOutBtn;
        private System.Windows.Forms.Button indexNextBtn;
        private System.Windows.Forms.Label imageIndexLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton boundingManualOpt;
        private System.Windows.Forms.RadioButton boundingFullOpt;
        private System.Windows.Forms.RadioButton boundingAutoOpt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar alphaToleranceBar;
        private System.Windows.Forms.CheckBox separateMasksBox;
        private System.Windows.Forms.NumericUpDown boundingBottomBox;
        private System.Windows.Forms.NumericUpDown boundingRightBox;
        private System.Windows.Forms.NumericUpDown boundingTopBox;
        private System.Windows.Forms.NumericUpDown boundingLeftBox;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.PictureBox previewBox;
        private System.Windows.Forms.Button indexPrevBtn;
        private System.Windows.Forms.NumericUpDown alphaToleranceBox;
    }
}