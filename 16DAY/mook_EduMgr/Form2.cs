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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int EudNum { get; set; }

        private string Constr = "Server=(local);database=ADOTest;" + "Integrated Security=true"; //SQL 연결문자열

        private void button1_Click(object sender, EventArgs e)
        {
            var Con = new SqlConnection(Constr);
            Con.Open();
            var strSQL = "update t_userinfo set birth = '" + this.label3.Text + "',email ='" + this.label6.Text + "',phone ='" + this.label5.Text + "',where edunum ='" + EudNum + "";
            var myCom = new SqlCommand(strSQL, Con);
            int i = myCom.ExecuteNonQuery();
            Con.Close();
            if (i == 1) DialogResult = DialogResult.OK;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var con = new SqlConnection(Constr);
            con.Open();

            var Comm = new SqlCommand("Select name, edunum, birth, email, phone from t_userinfo where edunum = " + EudNum + "", con);
            var myRead = Comm.ExecuteReader();
            if(myRead.Read())
            {
                this.textBox1.Text = myRead[0].ToString();
                this.textBox2.Text = myRead[1].ToString();
                this.textBox3.Text = myRead[2].ToString();
                this.textBox4.Text = myRead[3].ToString();
                this.textBox5.Text = myRead[4].ToString();
            }
            myRead.Close();
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
