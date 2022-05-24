
namespace AdControl
{
    partial class ACForm1
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
            this.progress = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbValue = new System.Windows.Forms.TrackBar();
            this.nupdown = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdown)).BeginInit();
            this.SuspendLayout();
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(38, 113);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(502, 23);
            this.progress.Step = 1;
            this.progress.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(38, 162);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbValue
            // 
            this.tbValue.LargeChange = 20;
            this.tbValue.Location = new System.Drawing.Point(235, 42);
            this.tbValue.Maximum = 100;
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(305, 45);
            this.tbValue.SmallChange = 5;
            this.tbValue.TabIndex = 2;
            this.tbValue.Scroll += new System.EventHandler(this.tbValue_Scroll);
            // 
            // nupdown
            // 
            this.nupdown.Location = new System.Drawing.Point(38, 42);
            this.nupdown.Name = "nupdown";
            this.nupdown.Size = new System.Drawing.Size(178, 21);
            this.nupdown.TabIndex = 3;
            this.nupdown.ValueChanged += new System.EventHandler(this.nupdown_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ACForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 208);
            this.Controls.Add(this.nupdown);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.progress);
            this.Name = "ACForm1";
            this.Text = "ADcontrolAPP";
            ((System.ComponentModel.ISupportInitialize)(this.tbValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TrackBar tbValue;
        private System.Windows.Forms.NumericUpDown nupdown;
        private System.Windows.Forms.Timer timer1;
    }
}

