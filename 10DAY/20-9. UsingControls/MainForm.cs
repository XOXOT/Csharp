using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UsingControls
{
    public partial class MainForm : Form
    {
        Random random = new Random(37);

        public MainForm()
        {
            InitializeComponent();

            lvDummy.Columns.Add("Name");
            lvDummy.Columns.Add("Depth");
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families; //운영체제에 설치되어 있는 폰트 목록 검색
            foreach (FontFamily font in Fonts) //cboFont 컨트롤에 각 폰트 이름 추가
                cboFont.Items.Add(font.Name);
        }

        void ChangeFont()
        {
            if (cboFont.SelectedIndex < 0) //cboFont에서 선택한 항목이 없으면 메소드 종료
                return;

            FontStyle style = FontStyle.Regular; //FontStyle 객체를 초기화

            if (chkBold.Checked) //"굵게" 체크 박스가 선택되어 있으면 bold 논리합 수행
                style |= FontStyle.Bold; 

            if (chkItalic.Checked) //"이탤릭" 체크 박스가 선택되어 있으면 Italic 논리합 수행
                style |= FontStyle.Italic;

            txtSampleText.Font = //txtSampleText의 Font 프로퍼티를 앞에서 만든 style로 수정
                new Font((string)cboFont.SelectedItem, 10,
                    style);
        }

        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void tbDummy_Scroll(object sender, EventArgs e)
        {
            pgDummy.Value = tbDummy.Value; //슬라이더의 위치에 따라 프로그레스바의 내용도 변경
        }

        private void btnModal_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modal Form";
            frm.Width = 300;
            frm.Height = 100;
            frm.BackColor = Color.Red;
            frm.ShowDialog(); //modal 창을 띄움
        }

        private void btnModaless_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modaless Form";
            frm.Width = 300;
            frm.Height = 300;
            frm.BackColor = Color.Green;
            frm.Show(); //Modaless창을 띄움
        }

        private void btnMsgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtSampleText.Text,
                "MessageBox Test", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        void TreeToList()
        {
            lvDummy.Items.Clear();
            foreach (TreeNode node in tvDummy.Nodes)
                TreeToList(node);
        }

        void TreeToList(TreeNode Node)
        {
            lvDummy.Items.Add(
                    new ListViewItem(
                        new string[] { Node.Text, 
                            Node.FullPath.Count(f => f == '\\').ToString() }));

            foreach (TreeNode node in Node.Nodes)
            {
                TreeToList(node);
            }
        }

        private void btnAddRoot_Click(object sender, EventArgs e)
        {
            tvDummy.Nodes.Add(random.Next().ToString());
            TreeToList();
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            if (tvDummy.SelectedNode == null)
            {
                MessageBox.Show("선택된 노드가 없습니다.",
                    "TreeView Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tvDummy.SelectedNode.Nodes.Add(random.Next().ToString());
            tvDummy.SelectedNode.Expand();
            TreeToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
