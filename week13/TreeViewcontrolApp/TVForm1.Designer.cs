
namespace TreeViewcontrolApp
{
    partial class TVForm1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("C 프로그래밍");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("윈도우 프로그래밍");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("자료구조");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("자바프로그래밍");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("컴퓨터 공학과", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("전자공학과");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("디지털콘텐츠학과");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("교과목", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            this.tvCos = new System.Windows.Forms.TreeView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNodeRemove = new System.Windows.Forms.Button();
            this.btnlistremove = new System.Windows.Forms.Button();
            this.btnAddnode = new System.Windows.Forms.Button();
            this.btnfindnode = new System.Windows.Forms.Button();
            this.lbladd = new System.Windows.Forms.Label();
            this.txtAddMove = new System.Windows.Forms.TextBox();
            this.lstCos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tvCos
            // 
            this.tvCos.Location = new System.Drawing.Point(12, 12);
            this.tvCos.Name = "tvCos";
            treeNode1.Name = "CP";
            treeNode1.Text = "C 프로그래밍";
            treeNode2.Name = "winp";
            treeNode2.Text = "윈도우 프로그래밍";
            treeNode3.Name = "jar";
            treeNode3.Text = "자료구조";
            treeNode4.Name = "java";
            treeNode4.Text = "자바프로그래밍";
            treeNode5.Name = "com";
            treeNode5.Text = "컴퓨터 공학과";
            treeNode5.ToolTipText = "컴공 이라네요";
            treeNode6.Name = "elec";
            treeNode6.Text = "전자공학과";
            treeNode6.ToolTipText = "하하";
            treeNode7.Name = "digital";
            treeNode7.Text = "디지털콘텐츠학과";
            treeNode8.Name = "root";
            treeNode8.Text = "교과목";
            this.tvCos.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.tvCos.Size = new System.Drawing.Size(218, 338);
            this.tvCos.TabIndex = 0;
            this.tvCos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvCos_AfterSelect);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(256, 169);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNodeRemove
            // 
            this.btnNodeRemove.Location = new System.Drawing.Point(14, 381);
            this.btnNodeRemove.Name = "btnNodeRemove";
            this.btnNodeRemove.Size = new System.Drawing.Size(116, 23);
            this.btnNodeRemove.TabIndex = 1;
            this.btnNodeRemove.Text = "선택 노드 삭제";
            this.btnNodeRemove.UseVisualStyleBackColor = true;
            this.btnNodeRemove.Click += new System.EventHandler(this.btnNodeRemove_Click);
            // 
            // btnlistremove
            // 
            this.btnlistremove.Location = new System.Drawing.Point(355, 381);
            this.btnlistremove.Name = "btnlistremove";
            this.btnlistremove.Size = new System.Drawing.Size(132, 23);
            this.btnlistremove.TabIndex = 1;
            this.btnlistremove.Text = "리스트 아이템 삭제";
            this.btnlistremove.UseVisualStyleBackColor = true;
            this.btnlistremove.Click += new System.EventHandler(this.btnlistremove_Click);
            // 
            // btnAddnode
            // 
            this.btnAddnode.Location = new System.Drawing.Point(12, 507);
            this.btnAddnode.Name = "btnAddnode";
            this.btnAddnode.Size = new System.Drawing.Size(75, 23);
            this.btnAddnode.TabIndex = 1;
            this.btnAddnode.Text = "노드 추가";
            this.btnAddnode.UseVisualStyleBackColor = true;
            this.btnAddnode.Click += new System.EventHandler(this.btnAddnode_Click);
            // 
            // btnfindnode
            // 
            this.btnfindnode.Location = new System.Drawing.Point(155, 507);
            this.btnfindnode.Name = "btnfindnode";
            this.btnfindnode.Size = new System.Drawing.Size(75, 23);
            this.btnfindnode.TabIndex = 1;
            this.btnfindnode.Text = "노드 검색";
            this.btnfindnode.UseVisualStyleBackColor = true;
            this.btnfindnode.Click += new System.EventHandler(this.btnfindnode_Click);
            // 
            // lbladd
            // 
            this.lbladd.AutoSize = true;
            this.lbladd.Location = new System.Drawing.Point(12, 434);
            this.lbladd.Name = "lbladd";
            this.lbladd.Size = new System.Drawing.Size(41, 12);
            this.lbladd.TabIndex = 2;
            this.lbladd.Text = "노드명";
            // 
            // txtAddMove
            // 
            this.txtAddMove.Location = new System.Drawing.Point(14, 468);
            this.txtAddMove.Name = "txtAddMove";
            this.txtAddMove.Size = new System.Drawing.Size(230, 21);
            this.txtAddMove.TabIndex = 3;
            // 
            // lstCos
            // 
            this.lstCos.FormattingEnabled = true;
            this.lstCos.ItemHeight = 12;
            this.lstCos.Location = new System.Drawing.Point(355, 20);
            this.lstCos.Name = "lstCos";
            this.lstCos.Size = new System.Drawing.Size(230, 328);
            this.lstCos.TabIndex = 4;
            // 
            // TVForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 555);
            this.Controls.Add(this.lstCos);
            this.Controls.Add(this.txtAddMove);
            this.Controls.Add(this.lbladd);
            this.Controls.Add(this.btnlistremove);
            this.Controls.Add(this.btnfindnode);
            this.Controls.Add(this.btnAddnode);
            this.Controls.Add(this.btnNodeRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tvCos);
            this.Name = "TVForm1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvCos;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNodeRemove;
        private System.Windows.Forms.Button btnlistremove;
        private System.Windows.Forms.Button btnAddnode;
        private System.Windows.Forms.Button btnfindnode;
        private System.Windows.Forms.Label lbladd;
        private System.Windows.Forms.TextBox txtAddMove;
        private System.Windows.Forms.ListBox lstCos;
    }
}

