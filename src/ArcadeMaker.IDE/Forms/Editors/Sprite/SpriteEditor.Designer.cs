
namespace ArcadeMaker.IDE
{
    partial class SpriteEditor
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
            label1 = new Label();
            nameBox = new TextBox();
            importBtn = new Button();
            openFileDialog = new OpenFileDialog();
            imageBox = new PictureBox();
            okBtn = new Button();
            editBtn = new Button();
            groupBox1 = new GroupBox();
            centerOriginBtn = new Button();
            originYBox = new NumericUpDown();
            label3 = new Label();
            originXBox = new NumericUpDown();
            label2 = new Label();
            detailsLbl = new Label();
            maskGroupBox = new GroupBox();
            modifiedLbl = new Label();
            separateMasksBox = new CheckBox();
            preciseMaskBtn = new CheckBox();
            modifyMaskBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)imageBox).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)originYBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)originXBox).BeginInit();
            maskGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Sprite Name";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(97, 7);
            nameBox.Margin = new Padding(4, 3, 4, 3);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(171, 23);
            nameBox.TabIndex = 1;
            nameBox.TextChanged += nameBox_TextChanged;
            // 
            // importBtn
            // 
            importBtn.Location = new Point(18, 51);
            importBtn.Margin = new Padding(4, 3, 4, 3);
            importBtn.Name = "importBtn";
            importBtn.Size = new Size(251, 27);
            importBtn.TabIndex = 2;
            importBtn.Text = "Import";
            importBtn.UseVisualStyleBackColor = true;
            importBtn.Click += importBtn_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.Multiselect = true;
            // 
            // imageBox
            // 
            imageBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            imageBox.Location = new Point(505, 14);
            imageBox.Margin = new Padding(4, 3, 4, 3);
            imageBox.Name = "imageBox";
            imageBox.Size = new Size(268, 430);
            imageBox.TabIndex = 3;
            imageBox.TabStop = false;
            imageBox.Paint += imageBox_Paint;
            imageBox.MouseClick += imageBox_MouseClick;
            // 
            // okBtn
            // 
            okBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            okBtn.Location = new Point(14, 418);
            okBtn.Margin = new Padding(4, 3, 4, 3);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(88, 27);
            okBtn.TabIndex = 4;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(18, 84);
            editBtn.Margin = new Padding(4, 3, 4, 3);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(251, 27);
            editBtn.TabIndex = 5;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(centerOriginBtn);
            groupBox1.Controls.Add(originYBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(originXBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(36, 310);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(216, 85);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Origin";
            // 
            // centerOriginBtn
            // 
            centerOriginBtn.Location = new Point(79, 51);
            centerOriginBtn.Margin = new Padding(4, 3, 4, 3);
            centerOriginBtn.Name = "centerOriginBtn";
            centerOriginBtn.Size = new Size(88, 23);
            centerOriginBtn.TabIndex = 4;
            centerOriginBtn.Text = "Center";
            centerOriginBtn.TextAlign = ContentAlignment.TopCenter;
            centerOriginBtn.UseVisualStyleBackColor = true;
            centerOriginBtn.Click += CenterOriginBtn_Click;
            // 
            // originYBox
            // 
            originYBox.Location = new Point(145, 21);
            originYBox.Margin = new Padding(4, 3, 4, 3);
            originYBox.Name = "originYBox";
            originYBox.Size = new Size(52, 23);
            originYBox.TabIndex = 3;
            originYBox.ValueChanged += originYBox_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 23);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 2;
            label3.Text = "Y";
            // 
            // originXBox
            // 
            originXBox.Location = new Point(49, 21);
            originXBox.Margin = new Padding(4, 3, 4, 3);
            originXBox.Name = "originXBox";
            originXBox.Size = new Size(52, 23);
            originXBox.TabIndex = 1;
            originXBox.ValueChanged += originXBox_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 23);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 0;
            label2.Text = "X";
            // 
            // detailsLbl
            // 
            detailsLbl.AutoSize = true;
            detailsLbl.Location = new Point(62, 137);
            detailsLbl.Margin = new Padding(4, 0, 4, 0);
            detailsLbl.Name = "detailsLbl";
            detailsLbl.Size = new Size(137, 30);
            detailsLbl.TabIndex = 7;
            detailsLbl.Text = "Width: 0   Height: 0\r\nNumber of subimages: 0";
            // 
            // maskGroupBox
            // 
            maskGroupBox.Controls.Add(modifiedLbl);
            maskGroupBox.Controls.Add(separateMasksBox);
            maskGroupBox.Controls.Add(preciseMaskBtn);
            maskGroupBox.Controls.Add(modifyMaskBtn);
            maskGroupBox.Location = new Point(275, 7);
            maskGroupBox.Margin = new Padding(4, 3, 4, 3);
            maskGroupBox.Name = "maskGroupBox";
            maskGroupBox.Padding = new Padding(4, 3, 4, 3);
            maskGroupBox.Size = new Size(223, 168);
            maskGroupBox.TabIndex = 8;
            maskGroupBox.TabStop = false;
            maskGroupBox.Text = "Collision Checking";
            // 
            // modifiedLbl
            // 
            modifiedLbl.AutoSize = true;
            modifiedLbl.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 177);
            modifiedLbl.ForeColor = Color.Maroon;
            modifiedLbl.Location = new Point(130, 77);
            modifiedLbl.Margin = new Padding(4, 0, 4, 0);
            modifiedLbl.Name = "modifiedLbl";
            modifiedLbl.Size = new Size(55, 13);
            modifiedLbl.TabIndex = 3;
            modifiedLbl.Text = "Modified";
            modifiedLbl.Visible = false;
            // 
            // separateMasksBox
            // 
            separateMasksBox.AutoSize = true;
            separateMasksBox.Location = new Point(23, 51);
            separateMasksBox.Margin = new Padding(4, 3, 4, 3);
            separateMasksBox.Name = "separateMasksBox";
            separateMasksBox.Size = new Size(154, 19);
            separateMasksBox.TabIndex = 2;
            separateMasksBox.Text = "Seperate collision masks";
            separateMasksBox.UseVisualStyleBackColor = true;
            separateMasksBox.CheckedChanged += separateMasksBox_CheckedChanged;
            // 
            // preciseMaskBtn
            // 
            preciseMaskBtn.AutoSize = true;
            preciseMaskBtn.Enabled = false;
            preciseMaskBtn.Location = new Point(23, 22);
            preciseMaskBtn.Margin = new Padding(4, 3, 4, 3);
            preciseMaskBtn.Name = "preciseMaskBtn";
            preciseMaskBtn.Size = new Size(161, 19);
            preciseMaskBtn.TabIndex = 1;
            preciseMaskBtn.Text = "Precise collision checking";
            preciseMaskBtn.UseVisualStyleBackColor = true;
            preciseMaskBtn.CheckedChanged += preciseMaskBtn_CheckedChanged;
            // 
            // modifyMaskBtn
            // 
            modifyMaskBtn.Location = new Point(23, 126);
            modifyMaskBtn.Margin = new Padding(4, 3, 4, 3);
            modifyMaskBtn.Name = "modifyMaskBtn";
            modifyMaskBtn.Size = new Size(177, 27);
            modifyMaskBtn.TabIndex = 0;
            modifyMaskBtn.Text = "Modify Mask";
            modifyMaskBtn.UseVisualStyleBackColor = true;
            modifyMaskBtn.Click += modifyMaskBtn_Click;
            // 
            // SpriteEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 458);
            Controls.Add(maskGroupBox);
            Controls.Add(detailsLbl);
            Controls.Add(groupBox1);
            Controls.Add(editBtn);
            Controls.Add(okBtn);
            Controls.Add(imageBox);
            Controls.Add(importBtn);
            Controls.Add(nameBox);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SpriteEditor";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sprite Editor";
            Load += SpriteEditor_Load;
            ((System.ComponentModel.ISupportInitialize)imageBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)originYBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)originXBox).EndInit();
            maskGroupBox.ResumeLayout(false);
            maskGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button centerOriginBtn;
        private System.Windows.Forms.NumericUpDown originYBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown originXBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label detailsLbl;
        private System.Windows.Forms.GroupBox maskGroupBox;
        private System.Windows.Forms.CheckBox separateMasksBox;
        private System.Windows.Forms.CheckBox preciseMaskBtn;
        private System.Windows.Forms.Button modifyMaskBtn;
        private System.Windows.Forms.Label modifiedLbl;
    }
}