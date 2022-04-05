namespace TP10_202873
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Tbx_Ninscricao = new System.Windows.Forms.TextBox();
            this.btn_Verificar = new System.Windows.Forms.Button();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.lbl_CertoErrado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tbx_Ninscricao
            // 
            this.Tbx_Ninscricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Ninscricao.Location = new System.Drawing.Point(98, 267);
            this.Tbx_Ninscricao.MaxLength = 12;
            this.Tbx_Ninscricao.Name = "Tbx_Ninscricao";
            this.Tbx_Ninscricao.Size = new System.Drawing.Size(216, 38);
            this.Tbx_Ninscricao.TabIndex = 0;
            // 
            // btn_Verificar
            // 
            this.btn_Verificar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Verificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Verificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Verificar.ForeColor = System.Drawing.Color.Lime;
            this.btn_Verificar.Location = new System.Drawing.Point(113, 334);
            this.btn_Verificar.Name = "btn_Verificar";
            this.btn_Verificar.Size = new System.Drawing.Size(179, 55);
            this.btn_Verificar.TabIndex = 1;
            this.btn_Verificar.Text = "Verificar";
            this.btn_Verificar.UseVisualStyleBackColor = false;
            this.btn_Verificar.Click += new System.EventHandler(this.Validar);
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado.Location = new System.Drawing.Point(70, 427);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(147, 29);
            this.lbl_Resultado.TabIndex = 2;
            this.lbl_Resultado.Text = "N° Inscrição ";
            // 
            // lbl_CertoErrado
            // 
            this.lbl_CertoErrado.AutoSize = true;
            this.lbl_CertoErrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CertoErrado.Location = new System.Drawing.Point(242, 427);
            this.lbl_CertoErrado.Name = "lbl_CertoErrado";
            this.lbl_CertoErrado.Size = new System.Drawing.Size(19, 29);
            this.lbl_CertoErrado.TabIndex = 3;
            this.lbl_CertoErrado.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP10_202873.Properties.Resources.BannerTSR;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(424, 724);
            this.Controls.Add(this.lbl_CertoErrado);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.btn_Verificar);
            this.Controls.Add(this.Tbx_Ninscricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRE_OFICIAL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressF);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tbx_Ninscricao;
        private System.Windows.Forms.Button btn_Verificar;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Label lbl_CertoErrado;
    }
}

