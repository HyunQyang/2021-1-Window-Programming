
namespace WindowFormApp
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblOpacity = new System.Windows.Forms.Label();
            this.txtO = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblSIze = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtW = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoNone = new System.Windows.Forms.RadioButton();
            this.rdoSingle = new System.Windows.Forms.RadioButton();
            this.rdoWindow = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(30, 56);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(73, 12);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "WindowTitle";
            // 
            // lblOpacity
            // 
            this.lblOpacity.AutoSize = true;
            this.lblOpacity.Location = new System.Drawing.Point(30, 319);
            this.lblOpacity.Name = "lblOpacity";
            this.lblOpacity.Size = new System.Drawing.Size(48, 12);
            this.lblOpacity.TabIndex = 0;
            this.lblOpacity.Text = "Opacity";
            // 
            // txtO
            // 
            this.txtO.Location = new System.Drawing.Point(147, 316);
            this.txtO.Name = "txtO";
            this.txtO.Size = new System.Drawing.Size(106, 21);
            this.txtO.TabIndex = 1;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(30, 146);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(97, 12);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "WIndow location";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(147, 156);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(45, 21);
            this.txtX.TabIndex = 1;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(207, 156);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(46, 21);
            this.txtY.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Form Border Size";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(161, 141);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(13, 12);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(221, 141);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(13, 12);
            this.lblY.TabIndex = 0;
            this.lblY.Text = "Y";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(147, 47);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(361, 21);
            this.txtTitle.TabIndex = 1;
            // 
            // lblSIze
            // 
            this.lblSIze.AutoSize = true;
            this.lblSIze.Location = new System.Drawing.Point(355, 146);
            this.lblSIze.Name = "lblSIze";
            this.lblSIze.Size = new System.Drawing.Size(78, 12);
            this.lblSIze.TabIndex = 0;
            this.lblSIze.Text = "Window Size";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(485, 131);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 12);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "width";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(545, 131);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(39, 12);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "height";
            // 
            // txtW
            // 
            this.txtW.Location = new System.Drawing.Point(459, 146);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(70, 21);
            this.txtW.TabIndex = 1;
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(535, 146);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(75, 21);
            this.txtH.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(207, 365);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(301, 38);
            this.btn.TabIndex = 2;
            this.btn.Text = "Create Form";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoWindow);
            this.panel1.Controls.Add(this.rdoSingle);
            this.panel1.Controls.Add(this.rdoNone);
            this.panel1.Location = new System.Drawing.Point(163, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 76);
            this.panel1.TabIndex = 3;
            // 
            // rdoNone
            // 
            this.rdoNone.AutoSize = true;
            this.rdoNone.Location = new System.Drawing.Point(2, 3);
            this.rdoNone.Name = "rdoNone";
            this.rdoNone.Size = new System.Drawing.Size(53, 16);
            this.rdoNone.TabIndex = 4;
            this.rdoNone.TabStop = true;
            this.rdoNone.Text = "None";
            this.rdoNone.UseVisualStyleBackColor = true;
            // 
            // rdoSingle
            // 
            this.rdoSingle.AutoSize = true;
            this.rdoSingle.Location = new System.Drawing.Point(2, 25);
            this.rdoSingle.Name = "rdoSingle";
            this.rdoSingle.Size = new System.Drawing.Size(93, 16);
            this.rdoSingle.TabIndex = 4;
            this.rdoSingle.TabStop = true;
            this.rdoSingle.Text = "Fixed Single";
            this.rdoSingle.UseVisualStyleBackColor = true;
            // 
            // rdoWindow
            // 
            this.rdoWindow.AutoSize = true;
            this.rdoWindow.Location = new System.Drawing.Point(2, 47);
            this.rdoWindow.Name = "rdoWindow";
            this.rdoWindow.Size = new System.Drawing.Size(131, 16);
            this.rdoWindow.TabIndex = 4;
            this.rdoWindow.TabStop = true;
            this.rdoWindow.Text = "Fixed Tool WIndow";
            this.rdoWindow.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtO);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSIze);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblOpacity);
            this.Controls.Add(this.lblTitle);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblOpacity;
        private System.Windows.Forms.TextBox txtO;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblSIze;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoWindow;
        private System.Windows.Forms.RadioButton rdoSingle;
        private System.Windows.Forms.RadioButton rdoNone;
    }
}

