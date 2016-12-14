using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kundendatenbank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kundendatenbankDataSet.Kunden' table. You can move, or remove it, as needed.
            this.kundenTableAdapter.Fill(this.kundendatenbankDataSet.Kunden);

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsuchen_Click(object sender, EventArgs e)
        {
            string search = tbsuchen.Text;

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            newcustomer neu = new newcustomer();
            neu.Show();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvmain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvmain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void btnedit_Click(object sender, EventArgs e)
        {

            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.kundenTableAdapter.FillBy(this.kundendatenbankDataSet.Kunden);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dgvmain_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            newcustomer neu = new newcustomer();
            neu.Show();
        }
    }
}
