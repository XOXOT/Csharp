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

namespace TEST
{
    public partial class Form1 : Form
    {
        //private SqlConnection Con;
        //private SqlDataAdapter Adpt;

        public int id { get; set; }

        private string Constr = "Server=(local);database=ADOTest;" + "Integrated Security=true"; //SQL 연결문자열

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            listView1.View = View.Details;           //컬럼형식으로 변경

            listView1.FullRowSelect = true;          //Row 전체 선택

            listView1.Columns.Add("번 호", 70);        //컬럼추가
            listView1.Columns.Add("이 름", 80);
            listView1.Columns.Add("년 식", 70);
            listView1.Columns.Add("가 격", 100);
            listView1.Columns.Add("도 어", 100);

            DataLoad();

        }

        private void btn_wholeSearch_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void btn_condsearch_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            var Conn = new SqlConnection(Constr);
            Conn.Open();

            string Sql = "Select * From TB_CAR_INFO "
                        + "where carName = @carName or carYear = @carYear "
                        + "or carPrice = @carPrice or carDoor = @carDoor ";

            var Comm = new SqlCommand(Sql, Conn);

            Comm.Parameters.Add("@carName", SqlDbType.NVarChar, 30);
            Comm.Parameters.Add("@carYear", SqlDbType.VarChar, 4);
            Comm.Parameters.Add("@carPrice", SqlDbType.Int);
            Comm.Parameters.Add("@carDoor", SqlDbType.Int);

            Comm.Parameters["@carName"].Value = this.txt_name.Text;
            Comm.Parameters["@carYear"].Value = this.txt_year.Text;
            Comm.Parameters["@carPrice"].Value =
                Convert.ToInt32((this.txt_price.Text == "") ? 0 : Convert.ToInt32(this.txt_price.Text));
            Comm.Parameters["@carDoor"].Value =
                Convert.ToInt32((this.txt_door.Text == "") ? 0 : Convert.ToInt32(this.txt_door.Text));

            var myRead = Comm.ExecuteReader();

            while (myRead.Read())
            {
                var strArray = new String[] { myRead["id"].ToString(),
                    myRead["carName"].ToString(), myRead["carYear"].ToString(),
                    myRead["carPrice"].ToString(), myRead["carDoor"].ToString() };
                var lvt = new ListViewItem(strArray);
                this.listView1.Items.Add(lvt);
            }
            myRead.Close();
            Conn.Close();
        }

        private void DataLoad()
        {
            listView1.Items.Clear(); //초기화
            var Conn = new SqlConnection(Constr);
            Conn.Open();

            var Comm01 = new SqlCommand("SELECT * FROM TB_CAR_INFO", Conn);
            var myRead02 = Comm01.ExecuteReader();
            while (myRead02.Read())
            {
                ListViewItem item = new ListViewItem(myRead02["id"].ToString());
                item.SubItems.Add(myRead02["carName"].ToString());
                item.SubItems.Add(myRead02["carYear"].ToString());
                item.SubItems.Add(myRead02["carPrice"].ToString());
                item.SubItems.Add(myRead02["carDoor"].ToString());
                listView1.Items.Add(item);
            }
            myRead02.Close();
            Conn.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e) //저장
        {
            //if (!textBox_DataChk())
            //{
            //    return;
            //}

            var Conn = new SqlConnection(Constr);
            Conn.Open();

            string Sql = "insert into TB_CAR_INFO(carName, carYear, carPrice, carDoor) "
                            + "values( @carName, @carYear, @carPrice, @carDoor )";
            var Comm = new SqlCommand(Sql, Conn);
            Comm.Parameters.Add("@carName", SqlDbType.NVarChar, 30);
            Comm.Parameters.Add("@carYear", SqlDbType.VarChar, 4);
            Comm.Parameters.Add("@carPrice", SqlDbType.Int);
            Comm.Parameters.Add("@carDoor", SqlDbType.Int);

            Comm.Parameters["@carName"].Value = this.txt_name.Text;
            Comm.Parameters["@carYear"].Value = this.txt_year.Text;
            Comm.Parameters["@carPrice"].Value = Convert.ToInt32(this.txt_price.Text);
            Comm.Parameters["@carDoor"].Value = Convert.ToInt32(this.txt_door.Text);

            int i = Comm.ExecuteNonQuery();
            Conn.Close();
            if (i == 1)
            {
                MessageBox.Show("정상적으로 데이터가 저장되었습니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txt_name.Clear();
                this.txt_year.Clear();
                this.txt_price.Clear();
                this.txt_door.Clear();
                DataLoad();
            }
            else
            {
                MessageBox.Show("정상적으로 데이터가 저장되지 않았습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count > 0)
            {
                DialogResult dlr = MessageBox.Show("데이터를 삭제할까요?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    var Conn = new SqlConnection(Constr);
                    Conn.Open();

                    string Sql = "delete from TB_CAR_INFO "
                        + "where id = @id ";

                    var Comm = new SqlCommand(Sql, Conn);

                    Comm.Parameters.Add("@id", SqlDbType.Int);

                    Comm.Parameters["@id"].Value =
                        Convert.ToInt32(this.listView1.SelectedItems[0].SubItems[0].Text);

                    int i = Comm.ExecuteNonQuery();
                    if (i == 1)
                        MessageBox.Show("데이터가 정상적으로 삭제되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("데이터를 삭제하지 못하였습니다..", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txt_name.Clear();
                    this.txt_year.Clear();
                    this.txt_price.Clear();
                    this.txt_door.Clear();
                    DataLoad();
                }
            }
            else
                MessageBox.Show("삭제할 행을 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }




        public static void MakeToListViewColumn(DataTable dt, ListView lstView)
        {
            lstView.Columns.Clear();

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                lstView.Columns.Add(dt.Columns[i].ColumnName);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_modi_Click(object sender, EventArgs e)
        {
            var Conn = new SqlConnection(Constr);
            Conn.Open();
            var strSQL = "update t_userinfo set carName = '" + this.txt_name.Text + "', carYear = '" + this.txt_year.Text + "', carPrice = '" + this.txt_price.Text + "', carDoor = '" + this.txt_door.Text + "' where id = " + id + "";
            var myCom = new SqlCommand(strSQL, Conn);
            int i = myCom.ExecuteNonQuery();
            Conn.Close();
            if (i == 1) DialogResult = DialogResult.OK;
        }

        private void lvList_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count > 0)
            {
                this.txt_name.Text = this.listView1.SelectedItems[0].SubItems[1].Text;
                this.txt_year.Text = this.listView1.SelectedItems[0].SubItems[2].Text;
                this.txt_price.Text = this.listView1.SelectedItems[0].SubItems[3].Text;
                this.txt_door.Text = this.listView1.SelectedItems[0].SubItems[4].Text;
            }
        }

    }

}
