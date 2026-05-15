
namespace ArcadeMaker.IDE
{
    partial class GSColorPicker
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
            this.display1Pnl = new System.Windows.Forms.Panel();
            this.display2Pnl = new System.Windows.Forms.FlowLayoutPanel();
            this.selectPnl = new System.Windows.Forms.Panel();
            this.leftLbl = new System.Windows.Forms.Label();
            this.rightLbl = new System.Windows.Forms.Label();
            this.alphaTrack = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alphaTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // display1Pnl
            // 
            this.display1Pnl.BackColor = System.Drawing.Color.Black;
            this.display1Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.display1Pnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.display1Pnl.Location = new System.Drawing.Point(3, 23);
            this.display1Pnl.Name = "display1Pnl";
            this.display1Pnl.Size = new System.Drawing.Size(42, 36);
            this.display1Pnl.TabIndex = 0;
            this.display1Pnl.Click += new System.EventHandler(this.display1Pnl_Click);
            // 
            // display2Pnl
            // 
            this.display2Pnl.BackColor = System.Drawing.Color.White;
            this.display2Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.display2Pnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.display2Pnl.Location = new System.Drawing.Point(51, 23);
            this.display2Pnl.Name = "display2Pnl";
            this.display2Pnl.Size = new System.Drawing.Size(42, 36);
            this.display2Pnl.TabIndex = 1;
            this.display2Pnl.Click += new System.EventHandler(this.display2Pnl_Click);
            // 
            // selectPnl
            // 
            this.selectPnl.BackColor = System.Drawing.Color.Fuchsia;
            this.selectPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.selectPnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectPnl.Location = new System.Drawing.Point(3, 65);
            this.selectPnl.Name = "selectPnl";
            this.selectPnl.Size = new System.Drawing.Size(90, 174);
            this.selectPnl.TabIndex = 2;
            this.selectPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.selectPnl_Paint);
            this.selectPnl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.selectPnl_MouseClick);
            // 
            // leftLbl
            // 
            this.leftLbl.AutoSize = true;
            this.leftLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.leftLbl.Location = new System.Drawing.Point(3, 5);
            this.leftLbl.Name = "leftLbl";
            this.leftLbl.Size = new System.Drawing.Size(21, 12);
            this.leftLbl.TabIndex = 3;
            this.leftLbl.Text = "Left";
            // 
            // rightLbl
            // 
            this.rightLbl.AutoSize = true;
            this.rightLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rightLbl.Location = new System.Drawing.Point(48, 5);
            this.rightLbl.Name = "rightLbl";
            this.rightLbl.Size = new System.Drawing.Size(27, 12);
            this.rightLbl.TabIndex = 4;
            this.rightLbl.Text = "Right";
            // 
            // alphaTrack
            // 
            this.alphaTrack.Location = new System.Drawing.Point(5, 257);
            this.alphaTrack.Maximum = 255;
            this.alphaTrack.Name = "alphaTrack";
            this.alphaTrack.Size = new System.Drawing.Size(88, 45);
            this.alphaTrack.TabIndex = 5;
            this.alphaTrack.Value = 255;
            this.alphaTrack.Scroll += new System.EventHandler(this.alphaTrack_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Opacity";
            // 
            // GSColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alphaTrack);
            this.Controls.Add(this.rightLbl);
            this.Controls.Add(this.leftLbl);
            this.Controls.Add(this.selectPnl);
            this.Controls.Add(this.display2Pnl);
            this.Controls.Add(this.display1Pnl);
            this.Name = "GSColorPicker";
            this.Size = new System.Drawing.Size(97, 305);
            this.Load += new System.EventHandler(this.GSColorPicker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alphaTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel display1Pnl;
        private System.Windows.Forms.FlowLayoutPanel display2Pnl;
        private System.Windows.Forms.Panel selectPnl;
        private System.Windows.Forms.Label leftLbl;
        private System.Windows.Forms.Label rightLbl;
        private System.Windows.Forms.TrackBar alphaTrack;
        private System.Windows.Forms.Label label1;
    }
}
