
using ArcadeMaker.IDE.CustomControls;

namespace ArcadeMaker.IDE
{
    partial class GSScriptBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fontBtn = new Button();
            textBox = new TextEditor();
            searchBtn = new Button();
            SuspendLayout();
            // 
            // fontBtn
            // 
            fontBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            fontBtn.Location = new Point(4, 377);
            fontBtn.Margin = new Padding(4, 3, 4, 3);
            fontBtn.Name = "fontBtn";
            fontBtn.Size = new Size(88, 27);
            fontBtn.TabIndex = 1;
            fontBtn.Text = "Select Font";
            fontBtn.UseVisualStyleBackColor = true;
            fontBtn.Click += fontBtn_Click;
            // 
            // textBox
            // 
            textBox.AcceptsTab = true;
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox.BackColor = Color.FromArgb(42, 42, 42);
            textBox.Font = new Font("Consolas", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox.Location = new Point(4, 3);
            textBox.Margin = new Padding(4, 3, 4, 3);
            textBox.Name = "textBox";
            textBox.NumberAlignment = StringAlignment.Center;
            textBox.NumberBackground1 = SystemColors.ControlLight;
            textBox.NumberBackground2 = SystemColors.Window;
            textBox.NumberBorder = SystemColors.ControlDark;
            textBox.NumberBorderThickness = 1F;
            textBox.NumberColor = Color.DarkGray;
            textBox.NumberFont = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox.NumberLeadingZeroes = false;
            textBox.NumberLineCounting = RichTextBoxEx.LineCounting.CRLF;
            textBox.NumberPadding = 2;
            textBox.ShowLineNumbers = false;
            textBox.Size = new Size(464, 366);
            textBox.TabIndex = 4;
            textBox.Text = "";
            textBox.TextChanged += textBox_TextChanged;
            textBox.KeyUp += textBox_KeyUp;
            // 
            // searchBtn
            // 
            searchBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            searchBtn.Location = new Point(98, 377);
            searchBtn.Margin = new Padding(4, 3, 4, 3);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(88, 27);
            searchBtn.TabIndex = 5;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // GSScriptBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(searchBtn);
            Controls.Add(textBox);
            Controls.Add(fontBtn);
            DoubleBuffered = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "GSScriptBox";
            Size = new Size(471, 413);
            Load += GSScriptBox_Load;
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button fontBtn;
        private TextEditor textBox;
        private System.Windows.Forms.Button searchBtn;
    }
}
