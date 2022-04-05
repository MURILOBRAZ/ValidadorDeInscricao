using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP10_202873
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region LIXO
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region FECHAR
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Deseja Sair?", "Encerrando o TRE_OFICIAL",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;

        }
        #endregion

        #region CARACTERES
        private void KeyPressF(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || (e.KeyChar <= 57 && e.KeyChar >= 48))
            {
                e.KeyChar = e.KeyChar;
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }
        #endregion

        #region VALIDARINSCRICAO

        private void Validar(object sender, EventArgs e)
        {
            try
            {
                if (TRE_APP.Class1.TRE(Tbx_Ninscricao.Text) == true)
                {
                    lbl_CertoErrado.ForeColor = Color.Black;
                    lbl_CertoErrado.Text = "Válido!!";
                    lbl_CertoErrado.ForeColor = Color.Green;
                }
                else
                {
                    lbl_CertoErrado.ForeColor = Color.Black;
                    lbl_CertoErrado.Text = "Inválido!!";
                    lbl_CertoErrado.ForeColor = Color.Red;
                }
            }
            catch
            {

                if (MessageBox.Show("Erro!!", "ERROR", MessageBoxButtons.OK,
                MessageBoxIcon.Error) == DialogResult.OK);

                Tbx_Ninscricao.Text = "";
                lbl_CertoErrado.Text = "";

            }

        }

        #endregion
    }
}
