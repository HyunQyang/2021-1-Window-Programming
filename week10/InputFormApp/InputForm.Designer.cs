
namespace InputFormApp
{
    partial class InputForm
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
            this.lblname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblbirth = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.grpfavor = new System.Windows.Forms.GroupBox();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rdoM = new System.Windows.Forms.RadioButton();
            this.rdoW = new System.Windows.Forms.RadioButton();
            this.chkF = new System.Windows.Forms.CheckBox();
            this.chkG = new System.Windows.Forms.CheckBox();
            this.chkS = new System.Windows.Forms.CheckBox();
            this.grpfavor.SuspendLayout();
            this.grpGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(12, 27);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(39, 12);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "label1";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(12, 84);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(27, 12);
            this.lblage.TabIndex = 0;
            this.lblage.Text = "Age";
            // 
            // lblbirth
            // 
            this.lblbirth.AutoSize = true;
            this.lblbirth.Location = new System.Drawing.Point(12, 227);
            this.lblbirth.Name = "lblbirth";
            this.lblbirth.Size = new System.Drawing.Size(38, 12);
            this.lblbirth.TabIndex = 0;
            this.lblbirth.Text = "label1";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(72, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(163, 21);
            this.txtName.TabIndex = 1;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(72, 75);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(163, 21);
            this.txtAge.TabIndex = 1;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(72, 218);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(54, 21);
            this.txtYear.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "/";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(149, 218);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(54, 21);
            this.txtMonth.TabIndex = 1;
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(227, 218);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(54, 21);
            this.txtDay.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(108, 363);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 2;
            this.btn.Text = "SEND";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // grpfavor
            // 
            this.grpfavor.Controls.Add(this.chkS);
            this.grpfavor.Controls.Add(this.chkG);
            this.grpfavor.Controls.Add(this.chkF);
            this.grpfavor.Location = new System.Drawing.Point(14, 267);
            this.grpfavor.Name = "grpfavor";
            this.grpfavor.Size = new System.Drawing.Size(267, 52);
            this.grpfavor.TabIndex = 3;
            this.grpfavor.TabStop = false;
            this.grpfavor.Text = "favorite";
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rdoW);
            this.grpGender.Controls.Add(this.rdoM);
            this.grpGender.Location = new System.Drawing.Point(14, 135);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(221, 52);
            this.grpGender.TabIndex = 3;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "gender";
            // 
            // rdoM
            // 
            this.rdoM.AutoSize = true;
            this.rdoM.Location = new System.Drawing.Point(6, 20);
            this.rdoM.Name = "rdoM";
            this.rdoM.Size = new System.Drawing.Size(48, 16);
            this.rdoM.TabIndex = 4;
            this.rdoM.TabStop = true;
            this.rdoM.Text = "man";
            this.rdoM.UseVisualStyleBackColor = true;
            // 
            // rdoW
            // 
            this.rdoW.AutoSize = true;
            this.rdoW.Location = new System.Drawing.Point(114, 20);
            this.rdoW.Name = "rdoW";
            this.rdoW.Size = new System.Drawing.Size(65, 16);
            this.rdoW.TabIndex = 4;
            this.rdoW.TabStop = true;
            this.rdoW.Text = "woman";
            this.rdoW.UseVisualStyleBackColor = true;
            // 
            // chkF
            // 
            this.chkF.AutoSize = true;
            this.chkF.Location = new System.Drawing.Point(6, 20);
            this.chkF.Name = "chkF";
            this.chkF.Size = new System.Drawing.Size(61, 16);
            this.chkF.TabIndex = 4;
            this.chkF.Text = "fishing";
            this.chkF.UseVisualStyleBackColor = true;
            // 
            // chkG
            // 
            this.chkG.AutoSize = true;
            this.chkG.Location = new System.Drawing.Point(93, 20);
            this.chkG.Name = "chkG";
            this.chkG.Size = new System.Drawing.Size(66, 16);
            this.chkG.TabIndex = 4;
            this.chkG.Text = "gaming";
            this.chkG.UseVisualStyleBackColor = true;
            // 
            // chkS
            // 
            this.chkS.AutoSize = true;
            this.chkS.Location = new System.Drawing.Point(181, 20);
            this.chkS.Name = "chkS";
            this.chkS.Size = new System.Drawing.Size(65, 16);
            this.chkS.TabIndex = 4;
            this.chkS.Text = "singing";
            this.chkS.UseVisualStyleBackColor = true;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 450);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.grpfavor);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblbirth);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblname);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.grpfavor.ResumeLayout(false);
            this.grpfavor.PerformLayout();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblbirth;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.GroupBox grpfavor;
        private System.Windows.Forms.CheckBox chkS;
        private System.Windows.Forms.CheckBox chkG;
        private System.Windows.Forms.CheckBox chkF;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rdoW;
        private System.Windows.Forms.RadioButton rdoM;
    }
}

