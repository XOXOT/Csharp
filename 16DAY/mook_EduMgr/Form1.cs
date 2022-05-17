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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string Constr = "Server=(local);database=ADOTest;" +
        "Integrated Security=true"; //SQL 연결문자열

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtClear()
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(Constr);
            Con.Open();

            SqlCommand Comm = new SqlCommand("Select userpwd from t_login where userid = '" + this.textBox1.Text + "'", Con);
            SqlDataReader reader = Comm.ExecuteReader();
            if (reader.Read())
            {
                string strpwd = reader["userpwd"].ToString();
                if (strpwd == this.textBox2.Text)
                {
                    reader.Close();
                    Con.Close();
                    Form3 frm3 = new Form3();
                    frm3.UserId = this.textBox1.Text;
                    frm3.Show();
                    this.Hide();
                }
                else
                {
                    this.label3.Text = "결과: 로그인 실패";
                    txtClear();
                }
            }
            else
            {
                this.label3.Text = "결과: 로그인 실패";
                txtClear();
            }
            reader.Close();
            Con.Close();
        }
    }
}
