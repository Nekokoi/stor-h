using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace storprogam
{
    public partial class login : Form
    {

        string query = "SELECT * FROM ginfo";
        string sidb = "SELECT SUM(`gtrack`) FROM ginoder;";
        MySqlConnection conn = new MySqlConnection(@"Data Source = localhost;port=3306;Initial Catalog=goods; User Id=root;password=''");
        
        
        
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader;
            MySqlDataReader reader2;
            string idccg = IDG.Text;
            string passccg = pass2.Text;
            string unicoddddddd = Uniquur.Text;
            string idc = "SELECT * FROM `s_taff` WHERE `Id` = '"+idccg+"'";
            string passc = "SELECT * FROM `s_taff` WHERE `pass` = '"+passccg+"'";
            string unpassc = "SELECT * FROM `s_taff` WHERE `uniqcod` = '"+unicoddddddd+"'";
            try
            {
                conn.Open();
                
                MySqlDataAdapter idtt = new MySqlDataAdapter(idc, conn);
                MySqlDataAdapter passt = new MySqlDataAdapter(passc, conn);
                MySqlDataAdapter unt = new MySqlDataAdapter(unpassc, conn);

                DataTable iddt = new DataTable();
                DataTable passtt = new DataTable();
                DataTable untttt = new DataTable();
                idtt.Fill(iddt);
                passt.Fill(passtt);
                unt.Fill(untttt);

                label1.Text = "รวมทั้งหมด" + iddt.Rows[0][0].ToString();
                label2.Text = passtt.Rows[0][0].ToString();
                label3.Text = untttt.Rows[0][0].ToString();

                Form1 paslogin = new Form1();
                this.panel1.Controls.Clear();
                paslogin.TopLevel = false;
                paslogin.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(paslogin);
                paslogin.Show();
                
            }
            catch (Exception ex){
                MessageBox.Show(" User password หรือ Uniqcode ไม่ถูก");
                conn.Close();


            } 

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
