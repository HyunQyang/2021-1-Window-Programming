
namespace WindowFormApp
{
    partial class subForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.builtandclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // builtandclose
            // 
            this.builtandclose.Location = new System.Drawing.Point(70, 53);
            this.builtandclose.Name = "builtandclose";
            this.builtandclose.Size = new System.Drawing.Size(98, 34);
            this.builtandclose.TabIndex = 0;
            this.builtandclose.Text = "Close Window";
            this.builtandclose.UseVisualStyleBackColor = true;
            this.builtandclose.Click += new System.EventHandler(this.builtandclose_Click);
            // 
            // subForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 144);
            this.Controls.Add(this.builtandclose);
            this.Name = "subForm";
            this.Text = "subForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button builtandclose;
    }
}