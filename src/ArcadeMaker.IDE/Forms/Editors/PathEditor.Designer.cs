
namespace ArcadeMaker.IDE
{
    partial class PathEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.roomBox = new System.Windows.Forms.ComboBox();
            this.closeCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pointSpeedBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.pointYBox = new System.Windows.Forms.NumericUpDown();
            this.pointXBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.pointsListBox = new System.Windows.Forms.ListBox();
            this.snapXBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.snapYBox = new System.Windows.Forms.NumericUpDown();
            this.scrollLeftBtn = new System.Windows.Forms.Button();
            this.scrollRightBtn = new System.Windows.Forms.Button();
            this.scrollUpBtn = new System.Windows.Forms.Button();
            this.scrollDownBtn = new System.Windows.Forms.Button();
            this.panelDataLbl = new System.Windows.Forms.Label();
            this.centerBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointSpeedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointYBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointXBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapXBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapYBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(78, 6);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(129, 20);
            this.nameBox.TabIndex = 1;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okBtn.Location = new System.Drawing.Point(15, 435);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.DarkGray;
            this.panel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel.Location = new System.Drawing.Point(212, 33);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(681, 397);
            this.panel.TabIndex = 3;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_MouseClick);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Room View";
            // 
            // roomBox
            // 
            this.roomBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomBox.FormattingEnabled = true;
            this.roomBox.Location = new System.Drawing.Point(304, 6);
            this.roomBox.Name = "roomBox";
            this.roomBox.Size = new System.Drawing.Size(147, 21);
            this.roomBox.TabIndex = 5;
            this.roomBox.SelectedIndexChanged += new System.EventHandler(this.roomBox_SelectedIndexChanged);
            // 
            // closeCheckBox
            // 
            this.closeCheckBox.AutoSize = true;
            this.closeCheckBox.Location = new System.Drawing.Point(13, 19);
            this.closeCheckBox.Name = "closeCheckBox";
            this.closeCheckBox.Size = new System.Drawing.Size(52, 17);
            this.closeCheckBox.TabIndex = 6;
            this.closeCheckBox.Text = "Close";
            this.closeCheckBox.UseVisualStyleBackColor = true;
            this.closeCheckBox.CheckedChanged += new System.EventHandler(this.closeCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pointSpeedBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pointYBox);
            this.groupBox1.Controls.Add(this.pointXBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.insertBtn);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.pointsListBox);
            this.groupBox1.Controls.Add(this.closeCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(7, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 363);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // pointSpeedBox
            // 
            this.pointSpeedBox.Location = new System.Drawing.Point(23, 281);
            this.pointSpeedBox.Name = "pointSpeedBox";
            this.pointSpeedBox.Size = new System.Drawing.Size(89, 20);
            this.pointSpeedBox.TabIndex = 16;
            this.pointSpeedBox.ValueChanged += new System.EventHandler(this.pointSpeedBox_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "SP";
            // 
            // pointYBox
            // 
            this.pointYBox.Location = new System.Drawing.Point(23, 255);
            this.pointYBox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.pointYBox.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.pointYBox.Name = "pointYBox";
            this.pointYBox.Size = new System.Drawing.Size(89, 20);
            this.pointYBox.TabIndex = 14;
            this.pointYBox.ValueChanged += new System.EventHandler(this.pointYBox_ValueChanged);
            // 
            // pointXBox
            // 
            this.pointXBox.Location = new System.Drawing.Point(23, 226);
            this.pointXBox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.pointXBox.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.pointXBox.Name = "pointXBox";
            this.pointXBox.Size = new System.Drawing.Size(89, 20);
            this.pointXBox.TabIndex = 13;
            this.pointXBox.ValueChanged += new System.EventHandler(this.pointXBox_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "X";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(118, 281);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 10;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(118, 252);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(75, 23);
            this.insertBtn.TabIndex = 9;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(118, 223);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // pointsListBox
            // 
            this.pointsListBox.FormattingEnabled = true;
            this.pointsListBox.Location = new System.Drawing.Point(6, 71);
            this.pointsListBox.Name = "pointsListBox";
            this.pointsListBox.Size = new System.Drawing.Size(187, 134);
            this.pointsListBox.TabIndex = 7;
            this.pointsListBox.SelectedIndexChanged += new System.EventHandler(this.pointsListBox_SelectedIndexChanged);
            // 
            // snapXBox
            // 
            this.snapXBox.Location = new System.Drawing.Point(522, 6);
            this.snapXBox.Name = "snapXBox";
            this.snapXBox.Size = new System.Drawing.Size(55, 20);
            this.snapXBox.TabIndex = 8;
            this.snapXBox.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.snapXBox.ValueChanged += new System.EventHandler(this.snapXBox_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(474, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Snap X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(592, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Snap Y";
            // 
            // snapYBox
            // 
            this.snapYBox.Location = new System.Drawing.Point(640, 6);
            this.snapYBox.Name = "snapYBox";
            this.snapYBox.Size = new System.Drawing.Size(55, 20);
            this.snapYBox.TabIndex = 10;
            this.snapYBox.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.snapYBox.ValueChanged += new System.EventHandler(this.snapYBox_ValueChanged);
            // 
            // scrollLeftBtn
            // 
            this.scrollLeftBtn.Location = new System.Drawing.Point(723, 3);
            this.scrollLeftBtn.Name = "scrollLeftBtn";
            this.scrollLeftBtn.Size = new System.Drawing.Size(25, 23);
            this.scrollLeftBtn.TabIndex = 17;
            this.scrollLeftBtn.Text = "<";
            this.scrollLeftBtn.UseVisualStyleBackColor = true;
            this.scrollLeftBtn.Click += new System.EventHandler(this.scrollLeftBtn_Click);
            // 
            // scrollRightBtn
            // 
            this.scrollRightBtn.Location = new System.Drawing.Point(754, 3);
            this.scrollRightBtn.Name = "scrollRightBtn";
            this.scrollRightBtn.Size = new System.Drawing.Size(25, 23);
            this.scrollRightBtn.TabIndex = 18;
            this.scrollRightBtn.Text = ">";
            this.scrollRightBtn.UseVisualStyleBackColor = true;
            this.scrollRightBtn.Click += new System.EventHandler(this.scrollRightBtn_Click);
            // 
            // scrollUpBtn
            // 
            this.scrollUpBtn.Location = new System.Drawing.Point(785, 3);
            this.scrollUpBtn.Name = "scrollUpBtn";
            this.scrollUpBtn.Size = new System.Drawing.Size(25, 23);
            this.scrollUpBtn.TabIndex = 19;
            this.scrollUpBtn.Text = "˄";
            this.scrollUpBtn.UseVisualStyleBackColor = true;
            this.scrollUpBtn.Click += new System.EventHandler(this.scrollUpBtn_Click);
            // 
            // scrollDownBtn
            // 
            this.scrollDownBtn.Location = new System.Drawing.Point(816, 3);
            this.scrollDownBtn.Name = "scrollDownBtn";
            this.scrollDownBtn.Size = new System.Drawing.Size(25, 23);
            this.scrollDownBtn.TabIndex = 20;
            this.scrollDownBtn.Text = "˅";
            this.scrollDownBtn.UseVisualStyleBackColor = true;
            this.scrollDownBtn.Click += new System.EventHandler(this.scrollDownBtn_Click);
            // 
            // panelDataLbl
            // 
            this.panelDataLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelDataLbl.AutoSize = true;
            this.panelDataLbl.Location = new System.Drawing.Point(209, 440);
            this.panelDataLbl.Name = "panelDataLbl";
            this.panelDataLbl.Size = new System.Drawing.Size(178, 13);
            this.panelDataLbl.TabIndex = 21;
            this.panelDataLbl.Text = "X: 0   Y: 0   Area: (0, 0) -> (100, 100)";
            // 
            // centerBtn
            // 
            this.centerBtn.Location = new System.Drawing.Point(847, 3);
            this.centerBtn.Name = "centerBtn";
            this.centerBtn.Size = new System.Drawing.Size(25, 23);
            this.centerBtn.TabIndex = 22;
            this.centerBtn.Text = "+";
            this.centerBtn.UseVisualStyleBackColor = true;
            this.centerBtn.Click += new System.EventHandler(this.centerBtn_Click);
            // 
            // PathEditor
            // 
            //this.Icon = Properties.Resources.ArcadeMaker_icon;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 470);
            this.Controls.Add(this.centerBtn);
            this.Controls.Add(this.panelDataLbl);
            this.Controls.Add(this.scrollDownBtn);
            this.Controls.Add(this.scrollUpBtn);
            this.Controls.Add(this.scrollRightBtn);
            this.Controls.Add(this.scrollLeftBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.snapYBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.snapXBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.roomBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Name = "PathEditor";
            this.Text = "Path Editor";
            this.Load += new System.EventHandler(this.PathEditor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointSpeedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointYBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointXBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapXBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapYBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox roomBox;
        private System.Windows.Forms.CheckBox closeCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox pointsListBox;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.NumericUpDown pointSpeedBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown pointYBox;
        private System.Windows.Forms.NumericUpDown pointXBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown snapXBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown snapYBox;
        private System.Windows.Forms.Button scrollLeftBtn;
        private System.Windows.Forms.Button scrollRightBtn;
        private System.Windows.Forms.Button scrollUpBtn;
        private System.Windows.Forms.Button scrollDownBtn;
        private System.Windows.Forms.Label panelDataLbl;
        private System.Windows.Forms.Button centerBtn;
    }
}