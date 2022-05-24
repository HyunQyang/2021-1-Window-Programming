
namespace WindowsFormsApp1
{
    partial class UserDialogMainForm
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
            this.btnUserDialog1 = new System.Windows.Forms.Button();
            this.btnUserDialog2 = new System.Windows.Forms.Button();
            this.txtparam = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFont = new System.Windows.Forms.Button();
            this.btncolor = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.SuspendLayout();
            // 
            // btnUserDialog1
            // 
            this.btnUserDialog1.Location = new System.Drawing.Point(468, 176);
            this.btnUserDialog1.Name = "btnUserDialog1";
            this.btnUserDialog1.Size = new System.Drawing.Size(132, 50);
            this.btnUserDialog1.TabIndex = 0;
            this.btnUserDialog1.Text = "사용자 정의 1";
            this.btnUserDialog1.UseVisualStyleBackColor = true;
            this.btnUserDialog1.Click += new System.EventHandler(this.btnUserDialog1_Click);
            // 
            // btnUserDialog2
            // 
            this.btnUserDialog2.Location = new System.Drawing.Point(468, 350);
            this.btnUserDialog2.Name = "btnUserDialog2";
            this.btnUserDialog2.Size = new System.Drawing.Size(133, 48);
            this.btnUserDialog2.TabIndex = 0;
            this.btnUserDialog2.Text = "사용자 정의 2";
            this.btnUserDialog2.UseVisualStyleBackColor = true;
            this.btnUserDialog2.Click += new System.EventHandler(this.btnUserDialog2_Click);
            // 
            // txtparam
            // 
            this.txtparam.Location = new System.Drawing.Point(468, 299);
            this.txtparam.Name = "txtparam";
            this.txtparam.Size = new System.Drawing.Size(133, 21);
            this.txtparam.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(554, 21);
            this.textBox1.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(468, 97);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(132, 49);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print Dialog";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "parameter";
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(275, 176);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(132, 50);
            this.btnFont.TabIndex = 0;
            this.btnFont.Text = "Font Dialog";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btncolor
            // 
            this.btncolor.Location = new System.Drawing.Point(275, 97);
            this.btncolor.Name = "btncolor";
            this.btncolor.Size = new System.Drawing.Size(132, 49);
            this.btncolor.TabIndex = 3;
            this.btncolor.Text = "Color Dialog";
            this.btncolor.UseVisualStyleBackColor = true;
            this.btncolor.Click += new System.EventHandler(this.btncolor_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(47, 176);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(132, 50);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok/CANCEL";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(47, 97);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(132, 49);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "기본 대화상자";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(47, 350);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(132, 50);
            this.btnAbort.TabIndex = 0;
            this.btnAbort.Text = "Abort/Retry/Ignore";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(47, 271);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(132, 49);
            this.btnYes.TabIndex = 3;
            this.btnYes.Text = "Yes/No";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(275, 350);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(132, 50);
            this.btnFolder.TabIndex = 0;
            this.btnFolder.Text = "FolderBrowser";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(275, 271);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(132, 49);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "OpenFileDialog";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // UserDialogMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btncolor);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.txtparam);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnUserDialog2);
            this.Controls.Add(this.btnUserDialog1);
            this.Name = "UserDialogMainForm";
            this.Text = "대화상자";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUserDialog1;
        private System.Windows.Forms.Button btnUserDialog2;
        private System.Windows.Forms.TextBox txtparam;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btncolor;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}

