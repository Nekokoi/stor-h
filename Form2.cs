using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Diagnostics.Eventing.Reader;




namespace storprogam
{
    public partial class Form2 : Form
    {
        MySqlConnection conn = new MySqlConnection(@"Data Source = localhost;port=3306;Initial Catalog=goods; User Id=root;password=''");
        string query = "SELECT * FROM ginfo";
        string dataqu = "SELECT `gname` AS รายการ, `gid` AS รหัสสินค้า, `gtrack` AS เลขชุดที่ส่ง, `gprize`AS ราคา FROM `ginoder` WHERE 1;";
        string dataqu2 = "SELECT * FROM `ginoder` WHERE 1;";
        string seletfosm = "SELECT * FROM `ginoder` WHERE (`gid`,`gname`,`gtrack`) VALUES ('@gid','@gname','@gtrack') ";


        public Form2()
        {
            
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;

            MySqlCommand cmdb = new MySqlCommand(query, conn);
            //MySqlCommand dataqcm = new MySqlCommand(dataqu, conn);

            MySqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmdb.ExecuteReader();
                reader.Close();
                //   reader1 = dataqcm.ExecuteReader();
                MySqlDataAdapter qurydho = new MySqlDataAdapter(dataqu, conn); //เปิดตัวแปล ในc# เป็น qurydho ให้ใช้งานรว่มกับ SQL ได้โดยให้ไปเอาข้อมูลในฐานข้อมูล ตามคำสั่ง dataqu conn เป็นตัวแปรเปิดฐานข้อมูล จากนั้นให้ยัดข้อมูลลงไป ใน qurydho 

                DataTable Dg1 = new DataTable();  //ยัดข้อมูลจาก qurydho มาใส่ใน  DataTable ที่อยู่ใน c#
                qurydho.Fill(Dg1); // เอาข้อมูลใน qurydho ยัดใส่ Dg1
                //label1.Text = "รวมทั้งหมด" + Dg1.Rows[1][1].ToString();//เอาข้อมูลจาก Datatable ที่ชื่อ Dg1 มาใส่ใน label โดยเอาแค่ อันที่ 0
                //Convert.ToString(Dg1.Rows[0]);
                dataGridView1.DataSource = Dg1; // 
                dataGridView1.Update();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();
        }
    }
}
