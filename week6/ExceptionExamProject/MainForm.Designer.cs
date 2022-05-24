
namespace asdfa
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
            this.lblInput1 = new System.Windows.Forms.Label();
            this.txtIn1 = new System.Windows.Forms.TextBox();
            this.lblInput2 = new System.Windows.Forms.Label();
            this.txtIn2 = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInput1
            // 
            this.lblInput1.AutoSize = true;
            this.lblInput1.Location = new System.Drawing.Point(57, 93);
            this.lblInput1.Name = "lblInput1";
            this.lblInput1.Size = new System.Drawing.Size(51, 12);
            this.lblInput1.TabIndex = 0;
            this.lblInput1.Text = "입력값1:";
            // 
            // txtIn1
            // 
            this.txtIn1.Location = new System.Drawing.Point(135, 84);
            this.txtIn1.Name = "txtIn1";
            this.txtIn1.Size = new System.Drawing.Size(100, 21);
            this.txtIn1.TabIndex = 1;
            // 
            // lblInput2
            // 
            this.lblInput2.AutoSize = true;
            this.lblInput2.Location = new System.Drawing.Point(57, 158);
            this.lblInput2.Name = "lblInput2";
            this.lblInput2.Size = new System.Drawing.Size(51, 12);
            this.lblInput2.TabIndex = 0;
            this.lblInput2.Text = "입력값2:";
            // 
            // txtIn2
            // 
            this.txtIn2.Location = new System.Drawing.Point(135, 149);
            this.txtIn2.Name = "txtIn2";
            this.txtIn2.Size = new System.Drawing.Size(100, 21);
            this.txtIn2.TabIndex = 1;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(57, 275);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(45, 12);
            this.lblOutput.TabIndex = 0;
            this.lblOutput.Text = "나눈값:";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(135, 266);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(100, 21);
            this.txtOutput.TabIndex = 1;
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblInfo.Location = new System.Drawing.Point(57, 299);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(256, 80);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "입력값 1을 입력값2로 나누어 출력하는 프로그램으로 입력한 값 2가 0일 경우 나타나는 예외를 처리해 DIV/0 문자로 출력하시오 ";
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(135, 211);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.Text = "나누기";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 446);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtIn2);
            this.Controls.Add(this.lblInput2);
            this.Controls.Add(this.txtIn1);
            this.Controls.Add(this.lblInput1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "예외처리 프로그램";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput1;
        private System.Windows.Forms.TextBox txtIn1;
        private System.Windows.Forms.Label lblInput2;
        private System.Windows.Forms.TextBox txtIn2;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnDivide;
    }
}

