
namespace LocationAndFormApp
{
    partial class MainForm1
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
            this.btnBig = new System.Windows.Forms.Button();
            this.btnSmall = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnLU = new System.Windows.Forms.Button();
            this.btnRU = new System.Windows.Forms.Button();
            this.btnRD = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnLD = new System.Windows.Forms.Button();
            this.btnOrigin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHorse
            // 
            this.lblHorse.AutoSize = true;
            this.lblHorse.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblHorse.Font = new System.Drawing.Font("휴먼모음T", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblHorse.Location = new System.Drawing.Point(249, 53);
            this.lblHorse.Name = "lblHorse";
            this.lblHorse.Size = new System.Drawing.Size(70, 13);
            this.lblHorse.TabIndex = 0;
            this.lblHorse.Text = "움직이는 말";
            this.lblHorse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBig
            // 
            this.btnBig.Location = new System.Drawing.Point(511, 43);
            this.btnBig.Name = "btnBig";
            this.btnBig.Size = new System.Drawing.Size(75, 23);
            this.btnBig.TabIndex = 2;
            this.btnBig.Text = "크게";
            this.btnBig.UseVisualStyleBackColor = true;
            this.btnBig.Click += new System.EventHandler(this.btnBig_Click);
            // 
            // btnSmall
            // 
            this.btnSmall.Location = new System.Drawing.Point(511, 72);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(75, 23);
            this.btnSmall.TabIndex = 2;
            this.btnSmall.Text = "작게";
            this.btnSmall.UseVisualStyleBackColor = true;
            this.btnSmall.Click += new System.EventHandler(this.btnSmall_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(244, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnL
            // 
            this.btnL.Location = new System.Drawing.Point(152, 227);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(75, 23);
            this.btnL.TabIndex = 2;
            this.btnL.Text = "왼쪽";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(339, 227);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "button1";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(339, 227);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(75, 23);
            this.btnR.TabIndex = 2;
            this.btnR.Text = "오른쪽";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(244, 266);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(75, 23);
            this.btnD.TabIndex = 2;
            this.btnD.Text = "아래";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnLU
            // 
            this.btnLU.Location = new System.Drawing.Point(152, 193);
            this.btnLU.Name = "btnLU";
            this.btnLU.Size = new System.Drawing.Size(75, 23);
            this.btnLU.TabIndex = 2;
            this.btnLU.Text = "왼쪽위";
            this.btnLU.UseVisualStyleBackColor = true;
            this.btnLU.Click += new System.EventHandler(this.btnLU_Click);
            // 
            // btnRU
            // 
            this.btnRU.Location = new System.Drawing.Point(339, 193);
            this.btnRU.Name = "btnRU";
            this.btnRU.Size = new System.Drawing.Size(75, 23);
            this.btnRU.TabIndex = 2;
            this.btnRU.Text = "오른쪽위";
            this.btnRU.UseVisualStyleBackColor = true;
            this.btnRU.Click += new System.EventHandler(this.btnRU_Click);
            // 
            // btnRD
            // 
            this.btnRD.Location = new System.Drawing.Point(339, 266);
            this.btnRD.Name = "btnRD";
            this.btnRD.Size = new System.Drawing.Size(79, 23);
            this.btnRD.TabIndex = 2;
            this.btnRD.Text = "오른쪽 아래";
            this.btnRD.UseVisualStyleBackColor = true;
            this.btnRD.Click += new System.EventHandler(this.btnRD_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(152, 266);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 2;
            this.button10.Text = "button1";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // btnU
            // 
            this.btnU.Location = new System.Drawing.Point(244, 193);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(75, 23);
            this.btnU.TabIndex = 2;
            this.btnU.Text = "위";
            this.btnU.UseVisualStyleBackColor = true;
            this.btnU.Click += new System.EventHandler(this.btnU_Click);
            // 
            // btnLD
            // 
            this.btnLD.Location = new System.Drawing.Point(152, 266);
            this.btnLD.Name = "btnLD";
            this.btnLD.Size = new System.Drawing.Size(75, 23);
            this.btnLD.TabIndex = 2;
            this.btnLD.Text = "왼쪽 아래";
            this.btnLD.UseVisualStyleBackColor = true;
            this.btnLD.Click += new System.EventHandler(this.btnLD_Click);
            // 
            // btnOrigin
            // 
            this.btnOrigin.Location = new System.Drawing.Point(244, 227);
            this.btnOrigin.Name = "btnOrigin";
            this.btnOrigin.Size = new System.Drawing.Size(75, 23);
            this.btnOrigin.TabIndex = 2;
            this.btnOrigin.Text = "처음위치";
            this.btnOrigin.UseVisualStyleBackColor = true;
            this.btnOrigin.Click += new System.EventHandler(this.btnOrigin_Click);
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.btnOrigin);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnLD);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btnRD);
            this.Controls.Add(this.btnRU);
            this.Controls.Add(this.btnLU);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSmall);
            this.Controls.Add(this.btnBig);
            this.Controls.Add(this.lblHorse);
            this.Name = "MainForm1";
            this.Text = "움직이는 말";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHorse;
        private System.Windows.Forms.Button btnBig;
        private System.Windows.Forms.Button btnSmall;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnLU;
        private System.Windows.Forms.Button btnRU;
        private System.Windows.Forms.Button btnRD;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnLD;
        private System.Windows.Forms.Button btnOrigin;
    }
}

