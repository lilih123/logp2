using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pag39_ex13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrinde_Click(object sender, EventArgs e)
        {
            int quantl;
           
            quantl = int.Parse(txtLitros.Text);

            if (quantl <= 10) 
            { txtBrinde.Text = "Seu brinde é um chaveiro!!"; }

            if (quantl > 10 && quantl <= 30)
            { txtBrinde.Text = "Você ganhou uma ducha no carro!"; }

            if (quantl > 30 && quantl <= 40)
            { txtBrinde.Text = "Parabéns, poderá trocar de óleo!"; }

            if (quantl > 40)
            { txtBrinde.Text = "Brinde: Ducha e troca de óleo =)"; }

          


        }
    }
}
