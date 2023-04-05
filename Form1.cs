using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storprogam
{

    public partial class Form1 : Form
    {
        string query = "SELECT * FROM ginfo";
        string sidb = "SELECT SUM(`gprize`) FROM ginoder;";
        MySqlConnection conn = new MySqlConnection(@"Data Source = localhost;port=3306;Initial Catalog=goods; User Id=root;password=''");
        
        public Form1()
        {
            //string query = "SELECT * FROM ginfo";
            //string sidb = "SELECT SUM(`gtrack`) FROM ginoder;";
            //MySqlConnection conn = new MySqlConnection(@"Data Source = localhost;port=3306;Initial Catalog=goods; User Id=root;password=''");
            //MySqlCommand rulut = new MySqlCommand(sidb, conn);
            MySqlCommand cmdb = new MySqlCommand(query, conn);
            MySqlCommand delttt = new MySqlCommand();
           // MySqlCommand rustt = new MySqlCommand(sidb,conn);
            //MySqlCommand sumdb = new MySqlCommand(sidb, conn);
            
            int ndbpri;

            MySqlDataReader reader2;
            MySqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmdb.ExecuteReader();
                reader.Close();

                //reader2 = sumdb.ExecuteReader();
                //string UI = reader2;
                //MySqlDataAdapter suansw = new MySqlDataAdapter(sidb, conn);

                //  label1.Text = "รวม"+sutb.Rows[0][0].ToString();

                //label1.Text = suansw.ToString();

                // label1.Text = reader2.GetValue(0);

                // MySqlDataReader rsutsum = rustt.ExecuteReader();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();






            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string toy;

            string delorder = "DELETE FROM `ginoder` WHERE 1";
            MySqlCommand deltablee = new MySqlCommand(delorder,conn);
            MySqlDataReader reader3;
            conn.Open();
            reader3 = deltablee.ExecuteReader();
            reader3.Close();
            conn.Close();
            Form2 celebinate = new Form2();
            this.panel1.Controls.Clear();
            celebinate.TopLevel = false;
            celebinate.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(celebinate);
            celebinate.Show();
            //reader2 = sumdb.ExecuteReader();
            //string UI = reader2;
            //            DataTable sutb = new DataTable();
            // label1.Text = "รวมทั้งหมด" + sutb.Rows[0][0].ToString();
            //    int io = textBox1.Text.Length;
            //      string ioi;
            //        ioi = Convert.ToString(io);
            //          label1.Text = ioi;
            MySqlDataAdapter suansw = new MySqlDataAdapter(sidb, conn);
            DataTable sutb = new DataTable();

            suansw.Fill(sutb);


            suansw.Fill(sutb);

            label1.Text = sutb.Rows[0][0].ToString();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 10)
            {

                string senum = textBox1.Text;
                Convert.ToSingle(senum);
                string serotrack = "SELECT * FROM `ginfo` WHERE `gtrack` = '" + senum + "'";
                MySqlDataAdapter sertstock = new MySqlDataAdapter(serotrack, conn);
                DataTable sert = new DataTable();
                sertstock.Fill(sert);
                if (sert.Rows.Count > 0)
                {
                    conn.Open();
                    //label1.Text = sert.Rows[0][0].ToString() + sert.Rows[0][1].ToString() + sert.Rows[0][2].ToString() + sert.Rows[0][3].ToString();
                    string inoder = "INSERT INTO `ginoder` (`gname`, `gid`, `gtrack`, `gprize`) VALUES ('" + sert.Rows[0][1].ToString() + "', '" + sert.Rows[0][0].ToString() + "', '" + sert.Rows[0][6].ToString() + "', '" + sert.Rows[0][7].ToString() + "');";
                    MySqlCommand insser = new MySqlCommand(inoder, conn);
                    MySqlDataReader reader6;
                    reader6 = insser.ExecuteReader();
                    reader6.Close();
                    //  string inoder = "INSERT INTO `ginoder` (`gname`, `gid`, `gtrack`, `gprize`) VALUES ('"++"', '"++"', '"++"', '"++"');";
                    Form2 celebinate = new Form2();
                    this.panel1.Controls.Clear();
                    celebinate.TopLevel = false;
                    celebinate.Dock = DockStyle.Fill;
                    this.panel1.Controls.Add(celebinate);
                    celebinate.Show();
                    MySqlDataReader reader5;
                    MySqlDataAdapter instgio = new MySqlDataAdapter();
                    textBox1.Text = "";

                    MySqlDataAdapter suansw = new MySqlDataAdapter(sidb, conn);
                    DataTable sutb = new DataTable();

                    suansw.Fill(sutb);


                    suansw.Fill(sutb);

                    label1.Text = sutb.Rows[0][0].ToString();
                    conn.Close();
                    

                }
                else
                {
                    MessageBox.Show("ไม่พบรหัสสินค้ากรุณาลองใหม่ หรือ แจ้งเพนักงาน");
                    textBox1.Text = "";
                    conn.Close();
                }
            }
            else
            {

                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            Form2 celebinate = new Form2();
            this.panel1.Controls.Clear();
            celebinate.TopLevel = false;
            celebinate.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(celebinate);
            celebinate.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
