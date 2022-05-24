
namespace LocationAndPoint
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
            this.lblHorse = new System.Windows.Forms.Label();
            this.btnBIg = new System.Windows.Forms.Button();
            this.btnSmall = new System.Windows.Forms.Button();
            this.btnLU = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnRU = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnOrigin = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnLD = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnRD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHorse
            // 
            this.lblHorse.AutoSize = true;
            this.lblHorse.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblHorse.Location = new System.Drawing.Point(317, 96);
            this.lblHorse.Name = "lblHorse";
            this.lblHorse.Size = new System.Drawing.Size(69, 12);
            this.lblHorse.TabIndex = 0;
            this.lblHorse.Text = "움직이는 말";
            // 
            // btnBIg
            // 
            this.btnBIg.Location = new System.Drawing.Point(657, 37);
            this.btnBIg.Name = "btnBIg";
            this.btnBIg.Size = new System.Drawing.Size(78, 29);
            this.btnBIg.TabIndex = 1;
            this.btnBIg.Text = "크게";
            this.btnBIg.UseVisualStyleBackColor = true;
            this.btnBIg.Click += new System.EventHandler(this.btnBIg_Click);
            // 
            // btnSmall
            // 
            this.btnSmall.Location = new System.Drawing.Point(657, 88);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(78, 29);
            this.btnSmall.TabIndex = 1;
            this.btnSmall.Text = "작게";
            this.btnSmall.UseVisualStyleBackColor = true;
            this.btnSmall.Click += new System.EventHandler(this.btnSmall_Click);
            // 
            // btnLU
            // 
            this.btnLU.Location = new System.Drawing.Point(190, 240);
            this.btnLU.Name = "btnLU";
            this.btnLU.Size = new System.Drawing.Size(78, 29);
            this.btnLU.TabIndex = 1;
            this.btnLU.Text = "왼쪽 위";
            this.btnLU.UseVisualStyleBackColor = true;
            this.btnLU.Click += new System.EventHandler(this.btnLU_Click);
            // 
            // btnU
            // 
            this.btnU.Location = new System.Drawing.Point(319, 240);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(78, 29);
            this.btnU.TabIndex = 1;
            this.btnU.Text = "위";
            this.btnU.UseVisualStyleBackColor = true;
            this.btnU.Click += new System.EventHandler(this.btnU_Click);
            // 
            // btnRU
            // 
            this.btnRU.Location = new System.Drawing.Point(439, 240);
            this.btnRU.Name = "btnRU";
            this.btnRU.Size = new System.Drawing.Size(78, 29);
            this.btnRU.TabIndex = 1;
            this.btnRU.Text = "오른쪽 위";
            this.btnRU.UseVisualStyleBackColor = true;
            this.btnRU.Click += new System.EventHandler(this.btnRU_Click);
            // 
            // btnL
            // 
            this.btnL.Location = new System.Drawing.Point(190, 294);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(78, 29);
            this.btnL.TabIndex = 1;
            this.btnL.Text = "왼쪽";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnOrigin
            // 
            this.btnOrigin.Location = new System.Drawing.Point(319, 294);
            this.btnOrigin.Name = "btnOrigin";
            this.btnOrigin.Size = new System.Drawing.Size(78, 29);
            this.btnOrigin.TabIndex = 1;
            this.btnOrigin.Text = "처음위치";
            this.btnOrigin.UseVisualStyleBackColor = true;
            this.btnOrigin.Click += new System.EventHandler(this.btnOrigin_Click);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(439, 294);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(78, 29);
            this.btnR.TabIndex = 1;
            this.btnR.Text = "오른쪽";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnLD
            // 
            this.btnLD.Location = new System.Drawing.Point(190, 362);
            this.btnLD.Name = "btnLD";
            this.btnLD.Size = new System.Drawing.Size(78, 29);
            this.btnLD.TabIndex = 1;
            this.btnLD.Text = "왼쪽 아래";
            this.btnLD.UseVisualStyleBackColor = true;
            this.btnLD.Click += new System.EventHandler(this.btnLD_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(319, 362);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(78, 29);
            this.btnD.TabIndex = 1;
            this.btnD.Text = "아래";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnRD
            // 
            this.btnRD.Location = new System.Drawing.Point(439, 362);
            this.btnRD.Name = "btnRD";
            this.btnRD.Size = new System.Drawing.Size(78, 29);
            this.btnRD.TabIndex = 1;
            this.btnRD.Text = "오른쪽 아래";
            this.btnRD.UseVisualStyleBackColor = true;
            this.btnRD.Click += new System.EventHandler(this.btnRD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRD);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnOrigin);
            this.Controls.Add(this.btnLD);
            this.Controls.Add(this.btnRU);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnLU);
            this.Controls.Add(this.btnSmall);
            this.Controls.Add(this.btnBIg);
            this.Controls.Add(this.lblHorse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHorse;
        private System.Windows.Forms.Button btnBIg;
        private System.Windows.Forms.Button btnSmall;
        private System.Windows.Forms.Button btnLU;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnRU;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnOrigin;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnLD;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnRD;
    }
}

