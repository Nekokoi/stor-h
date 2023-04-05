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
    public partial class allform : Form
    {
        public allform()
        {
            InitializeComponent();
        }

        private void allform_Load(object sender, EventArgs e)
        {
            login celebinate = new login();
            this.panel1.Controls.Clear();
            celebinate.TopLevel = false;
            celebinate.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(celebinate);
            celebinate.Show();
        }
    }
}
