using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_Info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txb_TextChanged(object sender, EventArgs e)
        {
            double temp = 0, ris = 0, cont = 0;
            string[] inp = txb.Text.Split(' ');
            for (int i = 0; i < inp.Length; i++)
            {
                if (double.TryParse(inp[i], out temp))
                {
                    double.TryParse(inp[i], out temp);
                    ris += temp;
                    cont++;
                }else if(inp[i] == "")
                {
                    return;
                }
                else
                {
                    MessageBox.Show("Errore il valore di input non è valido","Errore",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            ris = ris / cont;
            risult.Text = $"Risultato : {ris}";
        }
    }
}
