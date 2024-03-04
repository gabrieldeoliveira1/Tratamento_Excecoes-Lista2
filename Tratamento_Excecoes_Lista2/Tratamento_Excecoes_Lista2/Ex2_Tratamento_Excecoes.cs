using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tratamento_Excecoes_Lista2
{
    public partial class Ex2_Tratamento_Excecoes : Form
    {
        public Ex2_Tratamento_Excecoes()
        {
            InitializeComponent();
        }

        private void Ex2_Tratamento_Excecoes_Load(object sender, EventArgs e)
        {

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
                Ex2_Classe ex2 = new Ex2_Classe();
                ex2.v1 = 7;
                ex2.v2=8;

            MessageBox.Show("O resultado do cálculo é: \n\n" + ex2.Calc(2));

        }
    }
}
