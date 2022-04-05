using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRE_APP
{
    public class Class1
    {
        public static Boolean TRE(string NI)
        {

            #region Variaveis

            int Soma1 = 0;
            int Soma2 = 0;

            int Resto1 = 0;
            int Resto2 = 0;

            #endregion

            #region VerificarTamanho

            if (NI.Length != 12)
            {
                for (int i = 0; i < 13 - NI.Length; i++)
                {

                    NI = NI.Insert(i, "0");

                }
            }

            #endregion

            #region CALCULO_N°INSCRICAO

            for (int i = 0; i < 8; i++)
            {

                Soma1 += (int.Parse(NI.Substring(i, 1)) * (i + 2));

            }

            Resto1 = Soma1 % 11;

            for (int i = 8; i < 11; i++)
            {

                Soma2 += (int.Parse(NI.Substring(i, 1)) * (i - 1));

            }

            Resto2 = Soma2 % 11;

            #endregion

            #region RETORNOTrue/False

            if(Resto1 == int.Parse(NI.Substring(10, 1)) && Resto2 == int.Parse(NI.Substring(11, 1)))
            {

                return true;

            }
            else
            {

                return false;

            }

            #endregion
        }
    }


}
