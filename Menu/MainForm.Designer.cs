namespace Menu
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FileNameListBox = new System.Windows.Forms.ListBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MBImageTestButton = new System.Windows.Forms.Button();
            this.MBButtonTypeTest = new System.Windows.Forms.Button();
            this.MBFocusTestButton = new System.Windows.Forms.Button();
            this.MenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileNameListBox
            // 
            this.FileNameListBox.FormattingEnabled = true;
            this.FileNameListBox.ItemHeight = 23;
            this.FileNameListBox.Location = new System.Drawing.Point(6, 30);
            this.FileNameListBox.Name = "FileNameListBox";
            this.FileNameListBox.Size = new System.Drawing.Size(360, 188);
            this.FileNameListBox.TabIndex = 0;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(6, 224);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(360, 49);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddFileToolStripMenuItem,
            this.ChangeFontToolStripMenuItem});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(144, 48);
            // 
            // AddFileToolStripMenuItem
            // 
            this.AddFileToolStripMenuItem.Name = "AddFileToolStripMenuItem";
            this.AddFileToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.AddFileToolStripMenuItem.Text = "Add File";
            this.AddFileToolStripMenuItem.Click += new System.EventHandler(this.AddFileToolStripMenuItem_Click);
            // 
            // ChangeFontToolStripMenuItem
            // 
            this.ChangeFontToolStripMenuItem.Name = "ChangeFontToolStripMenuItem";
            this.ChangeFontToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.ChangeFontToolStripMenuItem.Text = "Change Font";
            this.ChangeFontToolStripMenuItem.Click += new System.EventHandler(this.ChangeFontToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FileNameListBox);
            this.groupBox1.Controls.Add(this.ClearButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 287);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Name List Box";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MBFocusTestButton);
            this.groupBox2.Controls.Add(this.MBImageTestButton);
            this.groupBox2.Controls.Add(this.MBButtonTypeTest);
            this.groupBox2.Location = new System.Drawing.Point(13, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 252);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MessageBox";
            // 
            // MBImageTestButton
            // 
            this.MBImageTestButton.Location = new System.Drawing.Point(7, 102);
            this.MBImageTestButton.Name = "MBImageTestButton";
            this.MBImageTestButton.Size = new System.Drawing.Size(360, 65);
            this.MBImageTestButton.TabIndex = 1;
            this.MBImageTestButton.Text = "Image Test";
            this.MBImageTestButton.UseVisualStyleBackColor = true;
            this.MBImageTestButton.Click += new System.EventHandler(this.MBImageTestButton_Click);
            // 
            // MBButtonTypeTest
            // 
            this.MBButtonTypeTest.Location = new System.Drawing.Point(7, 31);
            this.MBButtonTypeTest.Name = "MBButtonTypeTest";
            this.MBButtonTypeTest.Size = new System.Drawing.Size(360, 65);
            this.MBButtonTypeTest.TabIndex = 0;
            this.MBButtonTypeTest.Text = "Button Type Test";
            this.MBButtonTypeTest.UseVisualStyleBackColor = true;
            this.MBButtonTypeTest.Click += new System.EventHandler(this.MBButtonTypeTest_Click);
            // 
            // MBFocusTestButton
            // 
            this.MBFocusTestButton.Location = new System.Drawing.Point(7, 174);
            this.MBFocusTestButton.Name = "MBFocusTestButton";
            this.MBFocusTestButton.Size = new System.Drawing.Size(360, 65);
            this.MBFocusTestButton.TabIndex = 2;
            this.MBFocusTestButton.Text = "Focus Test";
            this.MBFocusTestButton.UseVisualStyleBackColor = true;
            this.MBFocusTestButton.Click += new System.EventHandler(this.MBFocusTestButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 569);
            this.ContextMenuStrip = this.MenuStrip;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.MenuStrip.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox FileNameListBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeFontToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button MBButtonTypeTest;
        private System.Windows.Forms.Button MBImageTestButton;
        private System.Windows.Forms.Button MBFocusTestButton;
    }
}

