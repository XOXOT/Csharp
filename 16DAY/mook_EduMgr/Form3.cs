using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace mook_EduMgr
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public string UserId { get; set; }
        public int EudNum = 0;
        List<string> subtmp = new List<string>();

        private string Constr = "Server=(local);database=ADOTest;" + "Integrated Security=true"; //SQL 연결문자열

        private void Form3_Load(object sender, EventArgs e)
        {
            DataLoad();
            SubjectLoad();
        }

        private void DataLoad()
        {
            var con = new SqlConnection(Constr);
            con.Open();

            var comm01 = new SqlCommand("Select name, edunum, birth, email, phone from t_userinfo where userid = '" + UserId + "'", con);
            var myRead01 = comm01.ExecuteReader();
            if(myRead01.Read())
            {
                this.label3.Text = "이름 : " + myRead01[0].ToString();
                this.label4.Text = "학번 : " + myRead01[1].ToString();
                EudNum = Convert.ToInt32(myRead01[1].ToString());
                this.label5.Text = "생년월일 : " + myRead01[2].ToString();
                this.label6.Text = "이메일 : " + myRead01[3].ToString();
                this.label7.Text = "핸드폰 : " + myRead01[4].ToString();
            }
            myRead01.Close();

            subtmp.Clear();
            var Comm02 = new SqlCommand("Select subject from t_user_subject where edunum = " + EudNum + "", con);
            var myRead02 = Comm02.ExecuteReader();
            while (myRead02.Read())
            {
                subtmp.Add(myRead02[0].ToString());
            }
            myRead02.Close();
            con.Close();
        }

        private void SubjectLoad()
        {

            var Conn = new SqlConnection(Constr);
            Conn.Open();

            var Comm = new SqlCommand("Select subject from t_subject", Conn);
            var myRead = Comm.ExecuteReader();
            while (myRead.Read())
            {
                if (!subtmp.Contains(myRead[0].ToString()))
                    this.listBox1.Items.Add(myRead[0].ToString());
            }
            myRead.Close();
            Conn.Close();
            foreach (string s in subtmp)
                this.listBox2.Items.Add(s);
        }

        private void button1_Click(object sender, EventArgs e) //수정
        {
            Form2 form2 = new Form2();
            form2.EudNum = EudNum;
            if(form2.ShowDialog()==DialogResult.OK)
            {
                DataLoad();
                form2.Close();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e) //add
        {
            subtmp.Clear();
            foreach (string s in listBox1.SelectedItems)
            {
                this.listBox2.Items.Add(s);
                subtmp.Add(s);
            }
            foreach (string s in subtmp)
            {
                this.listBox1.Items.Remove(s);
            }
        }

        private void button3_Click(object sender, EventArgs e) //del
        {
            subtmp.Clear();
            foreach (string s in listBox2.SelectedItems)
            {
                this.listBox1.Items.Add(s);
                subtmp.Add(s);
            }
            foreach (string s in subtmp)
            {
                this.listBox2.Items.Remove(s);
            }
        }

        private void button4_Click(object sender, EventArgs e) //save
        {
            try
            {
                var Conn = new SqlConnection(Constr);
                Conn.Open();

                var myCom01 = new SqlCommand("delete from t_user_subject where edunum = " + EudNum + "", Conn);
                myCom01.ExecuteNonQuery();

                foreach (string sub in this.listBox2.Items)
                {
                    var strSQL = "insert into t_user_subject(edunum, subject) values(" + EudNum + ", '" + sub + "')";
                    var myCom02 = new SqlCommand(strSQL, Conn);
                    myCom02.ExecuteNonQuery();
                }
                Conn.Close();

                MessageBox.Show("데이터가 저장 되었습니다.", "알람", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("데이터가 저장 되지 않았습니다.", "알람", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
