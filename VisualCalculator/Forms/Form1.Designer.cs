namespace VisualCalculator.Forms
{
    partial class CalcForm
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
            this.ButtonsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Num0Button = new System.Windows.Forms.Button();
            this.Num1Button = new System.Windows.Forms.Button();
            this.Num2Button = new System.Windows.Forms.Button();
            this.Num3Button = new System.Windows.Forms.Button();
            this.Num4Button = new System.Windows.Forms.Button();
            this.Num5Button = new System.Windows.Forms.Button();
            this.Num6Button = new System.Windows.Forms.Button();
            this.Num7Button = new System.Windows.Forms.Button();
            this.Num8Button = new System.Windows.Forms.Button();
            this.Num9Button = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.OpPlusButton = new System.Windows.Forms.Button();
            this.OpMinusButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.OpMulButton = new System.Windows.Forms.Button();
            this.OpDivButton = new System.Windows.Forms.Button();
            this.OpRootButton = new System.Windows.Forms.Button();
            this.OpModButton = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.AcRmButton = new System.Windows.Forms.Button();
            this.AcCEButton = new System.Windows.Forms.Button();
            this.AcCButton = new System.Windows.Forms.Button();
            this.ButtonsTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonsTableLayout
            // 
            this.ButtonsTableLayout.ColumnCount = 5;
            this.ButtonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsTableLayout.Controls.Add(this.AcCButton, 2, 0);
            this.ButtonsTableLayout.Controls.Add(this.AcCEButton, 1, 0);
            this.ButtonsTableLayout.Controls.Add(this.Num0Button, 0, 4);
            this.ButtonsTableLayout.Controls.Add(this.Num1Button, 0, 3);
            this.ButtonsTableLayout.Controls.Add(this.Num2Button, 1, 3);
            this.ButtonsTableLayout.Controls.Add(this.Num3Button, 2, 3);
            this.ButtonsTableLayout.Controls.Add(this.Num4Button, 0, 2);
            this.ButtonsTableLayout.Controls.Add(this.Num5Button, 1, 2);
            this.ButtonsTableLayout.Controls.Add(this.Num6Button, 2, 2);
            this.ButtonsTableLayout.Controls.Add(this.Num7Button, 0, 1);
            this.ButtonsTableLayout.Controls.Add(this.Num9Button, 2, 1);
            this.ButtonsTableLayout.Controls.Add(this.DotButton, 2, 4);
            this.ButtonsTableLayout.Controls.Add(this.OpPlusButton, 3, 4);
            this.ButtonsTableLayout.Controls.Add(this.OpMinusButton, 3, 3);
            this.ButtonsTableLayout.Controls.Add(this.OpMulButton, 3, 2);
            this.ButtonsTableLayout.Controls.Add(this.OpDivButton, 3, 1);
            this.ButtonsTableLayout.Controls.Add(this.OpRootButton, 4, 1);
            this.ButtonsTableLayout.Controls.Add(this.OpModButton, 4, 2);
            this.ButtonsTableLayout.Controls.Add(this.EqualButton, 4, 3);
            this.ButtonsTableLayout.Controls.Add(this.Num8Button, 1, 1);
            this.ButtonsTableLayout.Controls.Add(this.AcRmButton, 0, 0);
            this.ButtonsTableLayout.Location = new System.Drawing.Point(15, 82);
            this.ButtonsTableLayout.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonsTableLayout.Name = "ButtonsTableLayout";
            this.ButtonsTableLayout.RowCount = 5;
            this.ButtonsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonsTableLayout.Size = new System.Drawing.Size(300, 300);
            this.ButtonsTableLayout.TabIndex = 0;
            this.ButtonsTableLayout.TabStop = true;
            this.ButtonsTableLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonsTableLayout_Paint);
            // 
            // Num0Button
            // 
            this.ButtonsTableLayout.SetColumnSpan(this.Num0Button, 2);
            this.Num0Button.Location = new System.Drawing.Point(3, 243);
            this.Num0Button.Name = "Num0Button";
            this.Num0Button.Size = new System.Drawing.Size(114, 54);
            this.Num0Button.TabIndex = 1;
            this.Num0Button.Text = "0";
            this.Num0Button.UseVisualStyleBackColor = true;
            // 
            // Num1Button
            // 
            this.Num1Button.Location = new System.Drawing.Point(3, 183);
            this.Num1Button.Name = "Num1Button";
            this.Num1Button.Size = new System.Drawing.Size(54, 54);
            this.Num1Button.TabIndex = 2;
            this.Num1Button.Text = "1";
            this.Num1Button.UseVisualStyleBackColor = true;
            // 
            // Num2Button
            // 
            this.Num2Button.Location = new System.Drawing.Point(63, 183);
            this.Num2Button.Name = "Num2Button";
            this.Num2Button.Size = new System.Drawing.Size(54, 54);
            this.Num2Button.TabIndex = 3;
            this.Num2Button.Text = "2";
            this.Num2Button.UseVisualStyleBackColor = true;
            // 
            // Num3Button
            // 
            this.Num3Button.Location = new System.Drawing.Point(123, 183);
            this.Num3Button.Name = "Num3Button";
            this.Num3Button.Size = new System.Drawing.Size(54, 54);
            this.Num3Button.TabIndex = 4;
            this.Num3Button.Text = "3";
            this.Num3Button.UseVisualStyleBackColor = true;
            // 
            // Num4Button
            // 
            this.Num4Button.Location = new System.Drawing.Point(3, 123);
            this.Num4Button.Name = "Num4Button";
            this.Num4Button.Size = new System.Drawing.Size(54, 54);
            this.Num4Button.TabIndex = 5;
            this.Num4Button.Text = "4";
            this.Num4Button.UseVisualStyleBackColor = true;
            // 
            // Num5Button
            // 
            this.Num5Button.Location = new System.Drawing.Point(63, 123);
            this.Num5Button.Name = "Num5Button";
            this.Num5Button.Size = new System.Drawing.Size(54, 54);
            this.Num5Button.TabIndex = 6;
            this.Num5Button.Text = "5";
            this.Num5Button.UseVisualStyleBackColor = true;
            // 
            // Num6Button
            // 
            this.Num6Button.Location = new System.Drawing.Point(123, 123);
            this.Num6Button.Name = "Num6Button";
            this.Num6Button.Size = new System.Drawing.Size(54, 54);
            this.Num6Button.TabIndex = 7;
            this.Num6Button.Text = "6";
            this.Num6Button.UseVisualStyleBackColor = true;
            // 
            // Num7Button
            // 
            this.Num7Button.Location = new System.Drawing.Point(3, 63);
            this.Num7Button.Name = "Num7Button";
            this.Num7Button.Size = new System.Drawing.Size(54, 54);
            this.Num7Button.TabIndex = 8;
            this.Num7Button.Text = "7";
            this.Num7Button.UseVisualStyleBackColor = true;
            // 
            // Num8Button
            // 
            this.Num8Button.Location = new System.Drawing.Point(63, 63);
            this.Num8Button.Name = "Num8Button";
            this.Num8Button.Size = new System.Drawing.Size(54, 54);
            this.Num8Button.TabIndex = 9;
            this.Num8Button.Text = "8";
            this.Num8Button.UseVisualStyleBackColor = true;
            // 
            // Num9Button
            // 
            this.Num9Button.Location = new System.Drawing.Point(123, 63);
            this.Num9Button.Name = "Num9Button";
            this.Num9Button.Size = new System.Drawing.Size(54, 54);
            this.Num9Button.TabIndex = 10;
            this.Num9Button.Text = "9";
            this.Num9Button.UseVisualStyleBackColor = true;
            this.Num9Button.Click += new System.EventHandler(this.Num9Button_Click);
            // 
            // DotButton
            // 
            this.DotButton.Location = new System.Drawing.Point(123, 243);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(54, 54);
            this.DotButton.TabIndex = 11;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = true;
            // 
            // OpPlusButton
            // 
            this.OpPlusButton.Location = new System.Drawing.Point(183, 243);
            this.OpPlusButton.Name = "OpPlusButton";
            this.OpPlusButton.Size = new System.Drawing.Size(54, 54);
            this.OpPlusButton.TabIndex = 12;
            this.OpPlusButton.Text = "+";
            this.OpPlusButton.UseVisualStyleBackColor = true;
            // 
            // OpMinusButton
            // 
            this.OpMinusButton.Location = new System.Drawing.Point(183, 183);
            this.OpMinusButton.Name = "OpMinusButton";
            this.OpMinusButton.Size = new System.Drawing.Size(54, 54);
            this.OpMinusButton.TabIndex = 13;
            this.OpMinusButton.Text = "-";
            this.OpMinusButton.UseVisualStyleBackColor = true;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextBox.Location = new System.Drawing.Point(13, 18);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(302, 52);
            this.ResultTextBox.TabIndex = 1;
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // OpMulButton
            // 
            this.OpMulButton.Location = new System.Drawing.Point(183, 123);
            this.OpMulButton.Name = "OpMulButton";
            this.OpMulButton.Size = new System.Drawing.Size(54, 54);
            this.OpMulButton.TabIndex = 14;
            this.OpMulButton.Text = "*";
            this.OpMulButton.UseVisualStyleBackColor = true;
            // 
            // OpDivButton
            // 
            this.OpDivButton.Location = new System.Drawing.Point(183, 63);
            this.OpDivButton.Name = "OpDivButton";
            this.OpDivButton.Size = new System.Drawing.Size(54, 54);
            this.OpDivButton.TabIndex = 15;
            this.OpDivButton.Text = "/";
            this.OpDivButton.UseVisualStyleBackColor = true;
            // 
            // OpRootButton
            // 
            this.OpRootButton.Location = new System.Drawing.Point(243, 63);
            this.OpRootButton.Name = "OpRootButton";
            this.OpRootButton.Size = new System.Drawing.Size(54, 54);
            this.OpRootButton.TabIndex = 16;
            this.OpRootButton.Text = "√";
            this.OpRootButton.UseVisualStyleBackColor = true;
            // 
            // OpModButton
            // 
            this.OpModButton.Location = new System.Drawing.Point(243, 123);
            this.OpModButton.Name = "OpModButton";
            this.OpModButton.Size = new System.Drawing.Size(54, 54);
            this.OpModButton.TabIndex = 17;
            this.OpModButton.Text = "%";
            this.OpModButton.UseVisualStyleBackColor = true;
            // 
            // EqualButton
            // 
            this.EqualButton.Location = new System.Drawing.Point(243, 183);
            this.EqualButton.Name = "EqualButton";
            this.ButtonsTableLayout.SetRowSpan(this.EqualButton, 2);
            this.EqualButton.Size = new System.Drawing.Size(54, 114);
            this.EqualButton.TabIndex = 18;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = true;
            // 
            // AcRmButton
            // 
            this.AcRmButton.Location = new System.Drawing.Point(3, 3);
            this.AcRmButton.Name = "AcRmButton";
            this.AcRmButton.Size = new System.Drawing.Size(54, 54);
            this.AcRmButton.TabIndex = 19;
            this.AcRmButton.Text = "<-";
            this.AcRmButton.UseVisualStyleBackColor = true;
            // 
            // AcCEButton
            // 
            this.AcCEButton.Location = new System.Drawing.Point(63, 3);
            this.AcCEButton.Name = "AcCEButton";
            this.AcCEButton.Size = new System.Drawing.Size(54, 54);
            this.AcCEButton.TabIndex = 20;
            this.AcCEButton.Text = "CE";
            this.AcCEButton.UseVisualStyleBackColor = true;
            // 
            // AcCButton
            // 
            this.AcCButton.Location = new System.Drawing.Point(123, 3);
            this.AcCButton.Name = "AcCButton";
            this.AcCButton.Size = new System.Drawing.Size(54, 54);
            this.AcCButton.TabIndex = 21;
            this.AcCButton.Text = "C";
            this.AcCButton.UseVisualStyleBackColor = true;
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 398);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.ButtonsTableLayout);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CalcForm";
            this.Text = "Form1";
            this.ButtonsTableLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayout;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button Num0Button;
        private System.Windows.Forms.Button Num1Button;
        private System.Windows.Forms.Button Num2Button;
        private System.Windows.Forms.Button Num3Button;
        private System.Windows.Forms.Button Num4Button;
        private System.Windows.Forms.Button Num5Button;
        private System.Windows.Forms.Button Num6Button;
        private System.Windows.Forms.Button Num7Button;
        private System.Windows.Forms.Button Num8Button;
        private System.Windows.Forms.Button Num9Button;
        private System.Windows.Forms.Button DotButton;
        private System.Windows.Forms.Button OpPlusButton;
        private System.Windows.Forms.Button OpMinusButton;
        private System.Windows.Forms.Button OpMulButton;
        private System.Windows.Forms.Button OpDivButton;
        private System.Windows.Forms.Button OpRootButton;
        private System.Windows.Forms.Button OpModButton;
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.Button AcCButton;
        private System.Windows.Forms.Button AcCEButton;
        private System.Windows.Forms.Button AcRmButton;
    }
}

