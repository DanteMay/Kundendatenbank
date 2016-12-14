using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kundendatenbank
{
    public partial class newcustomer : Form
    {
        public newcustomer()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult cancel = MessageBox.Show("Wollen Sie wirklich abbrechen?", "Achtung!", MessageBoxButtons.YesNo);
            if (cancel==DialogResult.Yes)
            {
                this.Close(); 
            }
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                // int kundennummer = Convert.ToInt16(tbnummer.Text);
                int kundennummer = int.Parse(tbnummer.Text);
                string nachname = tbnachname.Text;
                string vorname = tbvorname.Text;

                loutput.Text = kundennummer + vorname + nachname;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Raabe\Desktop\C# test\Kundendatenbank\Kundendatenbank\Kundendatenbank.accdb;";
           
        }
    }
}
