namespace Dialog
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
            this.PreviewTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ModelessButton = new System.Windows.Forms.Button();
            this.ModalButton = new System.Windows.Forms.Button();
            this.FDialog = new System.Windows.Forms.FontDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ShowColorCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowApplyCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowFontDialogButton = new System.Windows.Forms.Button();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreviewTextBox
            // 
            this.PreviewTextBox.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviewTextBox.Location = new System.Drawing.Point(6, 26);
            this.PreviewTextBox.Name = "PreviewTextBox";
            this.PreviewTextBox.Size = new System.Drawing.Size(518, 52);
            this.PreviewTextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PreviewTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 89);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text Preview";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ExitButton);
            this.groupBox2.Controls.Add(this.ModelessButton);
            this.groupBox2.Controls.Add(this.ModalButton);
            this.groupBox2.Location = new System.Drawing.Point(320, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 103);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Open Form";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(6, 63);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(210, 31);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ModelessButton
            // 
            this.ModelessButton.Location = new System.Drawing.Point(114, 26);
            this.ModelessButton.Name = "ModelessButton";
            this.ModelessButton.Size = new System.Drawing.Size(102, 31);
            this.ModelessButton.TabIndex = 1;
            this.ModelessButton.Text = "Modeless";
            this.ModelessButton.UseVisualStyleBackColor = true;
            this.ModelessButton.Click += new System.EventHandler(this.ModelessButton_Click);
            // 
            // ModalButton
            // 
            this.ModalButton.Location = new System.Drawing.Point(6, 26);
            this.ModalButton.Name = "ModalButton";
            this.ModalButton.Size = new System.Drawing.Size(102, 31);
            this.ModalButton.TabIndex = 0;
            this.ModalButton.Text = "Modal";
            this.ModalButton.UseVisualStyleBackColor = true;
            this.ModalButton.Click += new System.EventHandler(this.ModalButton_Click);
            // 
            // FDialog
            // 
            this.FDialog.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ShowColorCheckBox);
            this.groupBox3.Controls.Add(this.ShowApplyCheckBox);
            this.groupBox3.Controls.Add(this.ShowFontDialogButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 103);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Font Dialog";
            // 
            // ShowColorCheckBox
            // 
            this.ShowColorCheckBox.AutoSize = true;
            this.ShowColorCheckBox.Location = new System.Drawing.Point(7, 68);
            this.ShowColorCheckBox.Name = "ShowColorCheckBox";
            this.ShowColorCheckBox.Size = new System.Drawing.Size(118, 22);
            this.ShowColorCheckBox.TabIndex = 2;
            this.ShowColorCheckBox.Text = "Show Color";
            this.ShowColorCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShowApplyCheckBox
            // 
            this.ShowApplyCheckBox.AutoSize = true;
            this.ShowApplyCheckBox.Location = new System.Drawing.Point(7, 27);
            this.ShowApplyCheckBox.Name = "ShowApplyCheckBox";
            this.ShowApplyCheckBox.Size = new System.Drawing.Size(121, 22);
            this.ShowApplyCheckBox.TabIndex = 1;
            this.ShowApplyCheckBox.Text = "Show Apply";
            this.ShowApplyCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShowFontDialogButton
            // 
            this.ShowFontDialogButton.Location = new System.Drawing.Point(131, 27);
            this.ShowFontDialogButton.Name = "ShowFontDialogButton";
            this.ShowFontDialogButton.Size = new System.Drawing.Size(165, 67);
            this.ShowFontDialogButton.TabIndex = 0;
            this.ShowFontDialogButton.Text = "Show Font Dialog";
            this.ShowFontDialogButton.UseVisualStyleBackColor = true;
            this.ShowFontDialogButton.Click += new System.EventHandler(this.ShowFontDialogButton_Click);
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(555, 24);
            this.MainMenuStrip.TabIndex = 4;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.FileToolStripMenuItem.Text = "File(&F)";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveToolStripMenuItem.Text = "Save";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 236);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MainMenuStrip);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.MainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Main";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PreviewTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ModalButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ModelessButton;
        private System.Windows.Forms.FontDialog FDialog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ShowFontDialogButton;
        private System.Windows.Forms.CheckBox ShowColorCheckBox;
        private System.Windows.Forms.CheckBox ShowApplyCheckBox;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
    }
}

