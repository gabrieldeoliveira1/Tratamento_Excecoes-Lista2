using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace Tratamento_Excecoes_Lista2
{
    //classre
    public class Ex2_Classe
    {
        public int Numero;
        //declara e inicializa
        public int v1;
        public int v2;
        public float resultado;

        public string Info;
        public string calus1;
        //construtor inicializa a classe
        public Ex2_Classe()
        {
            resultado = 0;      
        }
        public enum calus
        {

            soma = 1,
            sub = 2,
            multi = 3,
            div = 4
        }

        public float Calc(int Numero)
        {
            try
            {


                calus cal = calus.soma;
                switch (Numero)
                {
                    case 1:
                        resultado = v1 + v2;
                        cal = calus.soma; break;
                    case 2:
                        resultado = v1 - v2;
                        cal = calus.sub; break;
                    case 3:
                        resultado = v1 * v2;
                        cal = calus.multi; break;
                    case 4:
                        resultado = v1 / v2;
                        cal = calus.div; break;

                }
                Info = cal.ToString();
              
            }
            catch (Exception ex)
            {

                MessageBox.Show("Valor indivisível!\n\n" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
             return resultado;
            
        }

    }
}
