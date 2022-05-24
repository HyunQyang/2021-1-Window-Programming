using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewcontrolApp
{
    public partial class TVForm1 : Form
    {
        public TVForm1()
        {
            InitializeComponent();
        }

        private void tvCos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tvCos.ExpandAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstCos.Items.Add(tvCos.SelectedNode.Text);
        }

        private void btnNodeRemove_Click(object sender, EventArgs e)
        {
            if (tvCos.SelectedNode.Nodes.Count == 0)
            {
                //tvCos.Nodes.RemoveAt(tvCos.SelectedNode.Index);
                tvCos.Nodes.Remove(tvCos.SelectedNode);
            }
            else
                MessageBox.Show("자식 노드가 있는 경우 삭제 불가");
        }

        private void btnlistremove_Click(object sender, EventArgs e)
        {
            if (lstCos.SelectedIndex != -1)
            {
                lstCos.Items.RemoveAt(lstCos.SelectedIndex);
            }
            else
                MessageBox.Show("삭제할 아이템 없음");
        }

        private void btnAddnode_Click(object sender, EventArgs e)
        {
            if(txtAddMove.Text != "")
                tvCos.SelectedNode.Nodes.Add(txtAddMove.Text,txtAddMove.Text);

            else
                MessageBox.Show("입력 노드명이 없다 이말이야");
        }

        private void btnfindnode_Click(object sender, EventArgs e)
        {
            string SearchText = this.txtAddMove.Text;
            if(SearchText == "")
            {
                return;
            }
            TreeNode SelectedNode = SearchNode(txtAddMove.Text, tvCos.Nodes[0]);
            if(SelectedNode != null)
            {
                this.tvCos.SelectedNode = SelectedNode;
                this.tvCos.SelectedNode.Expand();
                this.tvCos.Select();
            }
        }
        private TreeNode SearchNode(string SearchText,TreeNode StartNode)
        {
            TreeNode node = null;
            while(StartNode != null)
            {
                if (StartNode.Text.ToLower().Contains(SearchText.ToLower()))
                {
                    node = StartNode;
                    break;
                }
                if(StartNode.Nodes.Count != 0)
                {
                    node = SearchNode(SearchText, StartNode.Nodes[0]);
                    if(node != null)
                    {
                        break;
                    }
                }
                StartNode = StartNode.NextNode;
            }
            return node;
        }
    }
}
