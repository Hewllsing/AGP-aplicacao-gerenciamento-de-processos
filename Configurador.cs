using System;   
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;



namespace AGP.Forms 
{
    internal class Configurador
    {
        /// <summary>
        ///6 - criar a classe configurador 
        ///- criar o método configurarForm1
        ///- coloca AGP no titulo do form1
        ///- coloca o ícone no form1
        /// </summary>
        /// <param name="form"></param>

        // Configura o Form1 com título e nome específicos
        public void ConfigurarForm1(Form form) {
            form.Name = "MainForm";
            form.Text = "AGP";
        }

    }
}
