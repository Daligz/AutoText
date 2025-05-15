using System;
using System.Windows.Forms;

namespace AutoText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.TopMost = true; // Mantiene la ventana siempre en la parte superior
            this.MaximizeBox = false; // Desactiva el bot�n de maximizar
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Texto que se enviar� a la ventana activa
            string texto = "Hola, esto es un texto autom�tico!";

            // Espera el tiempo especificado en segundos
            Task.Delay((int)numericUpDown1.Value * 1000).Wait();

            // Si el TextBox tiene texto, lo usa en lugar del texto predeterminado
            if (!string.IsNullOrEmpty(txtText.Text))
            {
                texto = txtText.Text;
            }

            if (chkEnter.Checked)
            {
                // Agrega un salto de l�nea al final del texto
                texto += "{ENTER}";
            }

            // Simula la escritura en la ventana activa
            SendKeys.SendWait(texto);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Oculta los caracteres en el TextBox
                txtText.UseSystemPasswordChar = true;
            }
            else
            {
                // Muestra los caracteres en el TextBox
                txtText.UseSystemPasswordChar = false;
            }
        }
    }
}