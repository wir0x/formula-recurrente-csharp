using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulaMat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Matematica mat = new Matematica();
            
            try
            {
                int n = Convert.ToInt32(txbN.Text);
                mat.set_n(n);
                
                if ( txbN.Text != ToString() && mat.n_valido(n)) {
                    
                    lblN.Text = txbN.Text;
                    lbl2.Text = txbN.Text;
                    lbla.Text = txbN.Text;
                    lbln_1.Text = txbN.Text + " - 1";
                    lblRes.Text = mat.ecuacion_recurrente().ToString();

                }
            }

            catch(Exception exc)
            {
                MessageBox.Show("error " + exc.ToString());
            }
           
        }
    }
}
