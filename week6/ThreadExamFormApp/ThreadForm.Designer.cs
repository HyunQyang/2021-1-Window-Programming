
namespace ThreadExamFormApp
{
    partial class ThreadForm
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
            this.btnRUn = new System.Windows.Forms.Button();
            this.txtPrintView1 = new System.Windows.Forms.TextBox();
            this.txtPrintView2 = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRUn
            // 
            this.btnRUn.Location = new System.Drawing.Point(176, 52);
            this.btnRUn.Name = "btnRUn";
            this.btnRUn.Size = new System.Drawing.Size(75, 23);
            this.btnRUn.TabIndex = 0;
            this.btnRUn.Text = "실행";
            this.btnRUn.UseVisualStyleBackColor = true;
            this.btnRUn.Click += new System.EventHandler(this.btnRUn_Click);
            // 
            // txtPrintView1
            // 
            this.txtPrintView1.Location = new System.Drawing.Point(26, 106);
            this.txtPrintView1.Multiline = true;
            this.txtPrintView1.Name = "txtPrintView1";
            this.txtPrintView1.Size = new System.Drawing.Size(153, 246);
            this.txtPrintView1.TabIndex = 1;
            // 
            // txtPrintView2
            // 
            this.txtPrintView2.Location = new System.Drawing.Point(293, 106);
            this.txtPrintView2.Multiline = true;
            this.txtPrintView2.Name = "txtPrintView2";
            this.txtPrintView2.Size = new System.Drawing.Size(153, 246);
            this.txtPrintView2.TabIndex = 1;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(176, 375);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "멈춰";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_click);
            // 
            // ThreadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.Controls.Add(this.txtPrintView2);
            this.Controls.Add(this.txtPrintView1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRUn);
            this.Name = "ThreadForm";
            this.Text = "스레드 프로그램";
            this.Load += new System.EventHandler(this.ThreadForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRUn;
        private System.Windows.Forms.TextBox txtPrintView1;
        private System.Windows.Forms.TextBox txtPrintView2;
        private System.Windows.Forms.Button btnStop;
    }
}

