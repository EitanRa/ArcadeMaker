
namespace ArcadeMaker.IDE
{
    partial class SpriteManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpriteManager));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newSpriteBtn = new System.Windows.Forms.ToolStripButton();
            this.importSpriteBtn = new System.Windows.Forms.ToolStripButton();
            this.saveSpriteBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutSpriteBtn = new System.Windows.Forms.ToolStripButton();
            this.copySpriteBtn = new System.Windows.Forms.ToolStripButton();
            this.pasteSpriteBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.moveLeftBtn = new System.Windows.Forms.ToolStripButton();
            this.moveRightBtn = new System.Windows.Forms.ToolStripButton();
            this.imageListView = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.okBtn = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSpriteBtn,
            this.importSpriteBtn,
            this.saveSpriteBtn,
            this.toolStripSeparator,
            this.cutSpriteBtn,
            this.copySpriteBtn,
            this.pasteSpriteBtn,
            this.toolStripSeparator1,
            this.moveLeftBtn,
            this.moveRightBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newSpriteBtn
            // 
            this.newSpriteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newSpriteBtn.Image = ((System.Drawing.Image)(resources.GetObject("newSpriteBtn.Image")));
            this.newSpriteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newSpriteBtn.Name = "newSpriteBtn";
            this.newSpriteBtn.Size = new System.Drawing.Size(23, 22);
            this.newSpriteBtn.Text = "&New";
            this.newSpriteBtn.Click += new System.EventHandler(this.newSpriteBtn_Click);
            // 
            // importSpriteBtn
            // 
            this.importSpriteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.importSpriteBtn.Image = ((System.Drawing.Image)(resources.GetObject("importSpriteBtn.Image")));
            this.importSpriteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.importSpriteBtn.Name = "importSpriteBtn";
            this.importSpriteBtn.Size = new System.Drawing.Size(23, 22);
            this.importSpriteBtn.Text = "&Open";
            this.importSpriteBtn.Click += new System.EventHandler(this.importSpriteBtn_Click);
            // 
            // saveSpriteBtn
            // 
            this.saveSpriteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveSpriteBtn.Enabled = false;
            this.saveSpriteBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveSpriteBtn.Image")));
            this.saveSpriteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveSpriteBtn.Name = "saveSpriteBtn";
            this.saveSpriteBtn.Size = new System.Drawing.Size(23, 22);
            this.saveSpriteBtn.Text = "&Save";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // cutSpriteBtn
            // 
            this.cutSpriteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutSpriteBtn.Image = ((System.Drawing.Image)(resources.GetObject("cutSpriteBtn.Image")));
            this.cutSpriteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutSpriteBtn.Name = "cutSpriteBtn";
            this.cutSpriteBtn.Size = new System.Drawing.Size(23, 22);
            this.cutSpriteBtn.Text = "C&ut";
            // 
            // copySpriteBtn
            // 
            this.copySpriteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copySpriteBtn.Image = ((System.Drawing.Image)(resources.GetObject("copySpriteBtn.Image")));
            this.copySpriteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copySpriteBtn.Name = "copySpriteBtn";
            this.copySpriteBtn.Size = new System.Drawing.Size(23, 22);
            this.copySpriteBtn.Text = "&Copy";
            // 
            // pasteSpriteBtn
            // 
            this.pasteSpriteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteSpriteBtn.Image = ((System.Drawing.Image)(resources.GetObject("pasteSpriteBtn.Image")));
            this.pasteSpriteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteSpriteBtn.Name = "pasteSpriteBtn";
            this.pasteSpriteBtn.Size = new System.Drawing.Size(23, 22);
            this.pasteSpriteBtn.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // moveLeftBtn
            // 
            this.moveLeftBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.moveLeftBtn.Enabled = false;
            this.moveLeftBtn.Image = ((System.Drawing.Image)(resources.GetObject("moveLeftBtn.Image")));
            this.moveLeftBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.moveLeftBtn.Name = "moveLeftBtn";
            this.moveLeftBtn.Size = new System.Drawing.Size(23, 22);
            this.moveLeftBtn.Text = "<";
            this.moveLeftBtn.Click += new System.EventHandler(this.moveLeftBtn_Click);
            // 
            // moveRightBtn
            // 
            this.moveRightBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.moveRightBtn.Enabled = false;
            this.moveRightBtn.Image = ((System.Drawing.Image)(resources.GetObject("moveRightBtn.Image")));
            this.moveRightBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.moveRightBtn.Name = "moveRightBtn";
            this.moveRightBtn.Size = new System.Drawing.Size(23, 22);
            this.moveRightBtn.Text = ">";
            this.moveRightBtn.Click += new System.EventHandler(this.moveRightBtn_Click);
            // 
            // imageListView
            // 
            this.imageListView.HideSelection = false;
            this.imageListView.Location = new System.Drawing.Point(157, 28);
            this.imageListView.MultiSelect = false;
            this.imageListView.Name = "imageListView";
            this.imageListView.Size = new System.Drawing.Size(631, 375);
            this.imageListView.TabIndex = 1;
            this.imageListView.UseCompatibleStateImageBehavior = false;
            this.imageListView.SelectedIndexChanged += new System.EventHandler(this.imageListView_SelectedIndexChanged);
            this.imageListView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.imageListView_KeyUp);
            this.imageListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.imageListView_MouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 117);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Image Files|*.jpeg;*.jpg;*.png";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(12, 385);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 3;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // SpriteManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imageListView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SpriteManager";
            this.Text = "Sprite Manager";
            this.Load += new System.EventHandler(this.SpriteManager_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newSpriteBtn;
        private System.Windows.Forms.ToolStripButton importSpriteBtn;
        private System.Windows.Forms.ToolStripButton saveSpriteBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutSpriteBtn;
        private System.Windows.Forms.ToolStripButton copySpriteBtn;
        private System.Windows.Forms.ToolStripButton pasteSpriteBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ListView imageListView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripButton moveLeftBtn;
        private System.Windows.Forms.ToolStripButton moveRightBtn;
        private System.Windows.Forms.Button okBtn;
    }
}