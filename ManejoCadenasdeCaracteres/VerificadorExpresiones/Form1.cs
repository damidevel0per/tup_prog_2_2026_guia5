using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VerificadorExpresiones.Models;

namespace VerificadorExpresiones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> telefonos = new List<string>() { "2324-2456556", "343-4817427", "2324-245a556", "343–-4817427", "343–-4817427-34", "2324-a-2456556" };

            listBox1.Items.Add($"Validación de telefonos con char");

            for (int i = 0; i < telefonos.Count; i++)
            {
                TelefonoCharValidador telefonoValidador = new TelefonoCharValidador(telefonos[i]);
                listBox1.Items.Add($"{telefonos[i]}, resultado: {telefonoValidador.VerMensaje().ToUpper()}");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> telefonos = new List<string>() { "2324-2456556", "343-4817427", "2324-245a556", "343–-4817427", "343–-4817427-34", "2324-a-2456556" };

            listBox2.Items.Add($"Validación de telefonos con REGEX");

            for (int i = 0; i < telefonos.Count; i++)
            {
                TelefonoRegexValidador telefonoValidador = new TelefonoRegexValidador(telefonos[i]);
                listBox2.Items.Add($"{telefonos[i]}, resultado: {telefonoValidador.VerMensaje().ToUpper()}");
            }
        }
    }
}
