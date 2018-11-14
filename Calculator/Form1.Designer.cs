namespace Calculator
{
    partial class Form1
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
            this.LeftBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LeftTextBoxLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.RightBox = new System.Windows.Forms.TextBox();
            this.RightTextBoxLabel = new System.Windows.Forms.Label();
            this.CalcButton = new System.Windows.Forms.Button();
            this.OpComboBox = new System.Windows.Forms.ComboBox();
            this.InputGroupBox = new System.Windows.Forms.GroupBox();
            this.Oplabel = new System.Windows.Forms.Label();
            this.ResultGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.InputGroupBox.SuspendLayout();
            this.ResultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftBox
            // 
            this.LeftBox.Location = new System.Drawing.Point(3, 3);
            this.LeftBox.Name = "LeftBox";
            this.LeftBox.Size = new System.Drawing.Size(100, 26);
            this.LeftBox.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.LeftBox);
            this.flowLayoutPanel1.Controls.Add(this.LeftTextBoxLabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(105, 58);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // LeftTextBoxLabel
            // 
            this.LeftTextBoxLabel.AutoSize = true;
            this.LeftTextBoxLabel.Location = new System.Drawing.Point(32, 32);
            this.LeftTextBoxLabel.Margin = new System.Windows.Forms.Padding(32, 0, 3, 0);
            this.LeftTextBoxLabel.Name = "LeftTextBoxLabel";
            this.LeftTextBoxLabel.Size = new System.Drawing.Size(36, 18);
            this.LeftTextBoxLabel.TabIndex = 2;
            this.LeftTextBoxLabel.Text = "Left";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.RightBox);
            this.flowLayoutPanel2.Controls.Add(this.RightTextBoxLabel);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(130, 25);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(105, 58);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // RightBox
            // 
            this.RightBox.Location = new System.Drawing.Point(3, 3);
            this.RightBox.Name = "RightBox";
            this.RightBox.Size = new System.Drawing.Size(100, 26);
            this.RightBox.TabIndex = 1;
            // 
            // RightTextBoxLabel
            // 
            this.RightTextBoxLabel.AutoSize = true;
            this.RightTextBoxLabel.Location = new System.Drawing.Point(32, 32);
            this.RightTextBoxLabel.Margin = new System.Windows.Forms.Padding(32, 0, 3, 0);
            this.RightTextBoxLabel.Name = "RightTextBoxLabel";
            this.RightTextBoxLabel.Size = new System.Drawing.Size(45, 18);
            this.RightTextBoxLabel.TabIndex = 2;
            this.RightTextBoxLabel.Text = "Right";
            // 
            // CalcButton
            // 
            this.CalcButton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcButton.Location = new System.Drawing.Point(259, 20);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(168, 204);
            this.CalcButton.TabIndex = 4;
            this.CalcButton.Text = "CALCULATE";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // OpComboBox
            // 
            this.OpComboBox.FormattingEnabled = true;
            this.OpComboBox.Location = new System.Drawing.Point(93, 99);
            this.OpComboBox.Name = "OpComboBox";
            this.OpComboBox.Size = new System.Drawing.Size(142, 26);
            this.OpComboBox.TabIndex = 7;
            this.OpComboBox.SelectedIndexChanged += new System.EventHandler(this.OpComboBox_SelectedIndexChanged);
            // 
            // InputGroupBox
            // 
            this.InputGroupBox.Controls.Add(this.Oplabel);
            this.InputGroupBox.Controls.Add(this.flowLayoutPanel1);
            this.InputGroupBox.Controls.Add(this.OpComboBox);
            this.InputGroupBox.Controls.Add(this.flowLayoutPanel2);
            this.InputGroupBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputGroupBox.Location = new System.Drawing.Point(12, 12);
            this.InputGroupBox.Name = "InputGroupBox";
            this.InputGroupBox.Size = new System.Drawing.Size(241, 138);
            this.InputGroupBox.TabIndex = 8;
            this.InputGroupBox.TabStop = false;
            this.InputGroupBox.Text = "Input";
            // 
            // Oplabel
            // 
            this.Oplabel.AutoSize = true;
            this.Oplabel.Location = new System.Drawing.Point(6, 102);
            this.Oplabel.Margin = new System.Windows.Forms.Padding(32, 0, 3, 0);
            this.Oplabel.Name = "Oplabel";
            this.Oplabel.Size = new System.Drawing.Size(81, 18);
            this.Oplabel.TabIndex = 8;
            this.Oplabel.Text = "Operation";
            // 
            // ResultGroupBox
            // 
            this.ResultGroupBox.Controls.Add(this.ResultTextBox);
            this.ResultGroupBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultGroupBox.Location = new System.Drawing.Point(12, 156);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.Size = new System.Drawing.Size(241, 68);
            this.ResultGroupBox.TabIndex = 9;
            this.ResultGroupBox.TabStop = false;
            this.ResultGroupBox.Text = "Result";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextBox.Location = new System.Drawing.Point(7, 26);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(226, 31);
            this.ResultTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 235);
            this.Controls.Add(this.ResultGroupBox);
            this.Controls.Add(this.InputGroupBox);
            this.Controls.Add(this.CalcButton);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.InputGroupBox.ResumeLayout(false);
            this.InputGroupBox.PerformLayout();
            this.ResultGroupBox.ResumeLayout(false);
            this.ResultGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox LeftBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LeftTextBoxLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox RightBox;
        private System.Windows.Forms.Label RightTextBoxLabel;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.ComboBox OpComboBox;
        private System.Windows.Forms.GroupBox InputGroupBox;
        private System.Windows.Forms.Label Oplabel;
        private System.Windows.Forms.GroupBox ResultGroupBox;
        private System.Windows.Forms.TextBox ResultTextBox;
    }
}

