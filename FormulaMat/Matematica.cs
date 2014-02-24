using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulaMat
{
    class Matematica
    {
        private double a_n;
        private double a_n_1;
        private int n;

        public Matematica()
        {
            this.n = 1;
            this.a_n = 1;
        }

        public bool n_valido(int n)
        {
            return n >= this.n;
        }

        public void set_n(int n)
        {
            if ( n_valido(n))
                this.n = n;
            else
                MessageBox.Show("'n' tiene que ser >= 1", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public double ecuacion_recurrente()
        {
            for (int i = 1; i <= n; i++)
            {
                a_n_1 = a_n;
                double dos_n = Math.Pow(Convert.ToDouble(2), Convert.ToDouble(i));
                a_n = a_n_1 + dos_n;
            }
            return a_n;
        }

    }
}
