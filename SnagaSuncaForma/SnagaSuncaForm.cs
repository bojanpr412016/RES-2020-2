using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Komponente;

namespace SnagaSuncaForma
{
    public partial class SnagaSuncaForm : Form
    {
        
        public SnagaSuncaForm()
        {
            InitializeComponent();
        }
        string ime = "";

        private void buttonIzmeniClick_Click(object sender, EventArgs e)
        {
            ime = textBoxIme.Text;
        }
    }
}
