namespace Bird
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MyImageList = new System.Windows.Forms.ImageList(this.components);
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            this.MainLabel = new System.Windows.Forms.Label();
            this.MyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MyTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.MyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // MyImageList
            // 
            this.MyImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MyImageList.ImageStream")));
            this.MyImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.MyImageList.Images.SetKeyName(0, "frame-1.png");
            this.MyImageList.Images.SetKeyName(1, "frame-2.png");
            this.MyImageList.Images.SetKeyName(2, "frame-3.png");
            this.MyImageList.Images.SetKeyName(3, "frame-4.png");
            this.MyImageList.Images.SetKeyName(4, "frame-5.png");
            this.MyImageList.Images.SetKeyName(5, "frame-6.png");
            this.MyImageList.Images.SetKeyName(6, "frame-7.png");
            this.MyImageList.Images.SetKeyName(7, "frame-8.png");
            // 
            // MyTimer
            // 
            this.MyTimer.Enabled = true;
            // 
            // MainLabel
            // 
            this.MainLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainLabel.Location = new System.Drawing.Point(0, 0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(274, 251);
            this.MainLabel.TabIndex = 0;
            // 
            // MyNumericUpDown
            // 
            this.MyNumericUpDown.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MyNumericUpDown.Location = new System.Drawing.Point(12, 270);
            this.MyNumericUpDown.Name = "MyNumericUpDown";
            this.MyNumericUpDown.Size = new System.Drawing.Size(120, 29);
            this.MyNumericUpDown.TabIndex = 1;
            this.MyNumericUpDown.ValueChanged += new System.EventHandler(this.MyNumericUpDown_ValueChanged);
            // 
            // MyTrackBar
            // 
            this.MyTrackBar.Location = new System.Drawing.Point(12, 318);
            this.MyTrackBar.Name = "MyTrackBar";
            this.MyTrackBar.Size = new System.Drawing.Size(247, 45);
            this.MyTrackBar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 413);
            this.Controls.Add(this.MyTrackBar);
            this.Controls.Add(this.MyNumericUpDown);
            this.Controls.Add(this.MainLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList MyImageList;
        private System.Windows.Forms.Timer MyTimer;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.NumericUpDown MyNumericUpDown;
        private System.Windows.Forms.TrackBar MyTrackBar;
    }
}

