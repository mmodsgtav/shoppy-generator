using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppyGenerator_by_mmodsgtav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox4.Text = "# \r\n.\r\n* Replace ()\r\n* Vehículo ELS\r\n* \r\n\r\n[¿Tienes dudas o problemas técnicos? Consulta aquí las preguntas frecuentes.](https://mmodsgtav.es/faq)\r\n\r\nImportante: este producto está sujeto a los [términos de uso](https://mmds.ml/tos), que se entienden como leídos y aceptados una vez comprado el producto.\r\n\r\nImágenes:\r\n";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            updateText();
        }

        private void updateText()
        {
            String titulo = textBox1.Text;
            String replace = listBox1.Text;
            String description = textBox2.Text;
            String images = "\n";
            for (int i = 1; i <= numericUpDown1.Value; i++)
            {
                images += $"![](https://mmodsgtav.es/cdn/img/capturas-mods/{textBox3.Text}-{i}.png)\r\n\r\n";
            }
            textBox4.Text = $"# {titulo}\r\n{description}\r\n* Replace ({replace})\r\n* Vehículo ELS\r\n* \r\n\r\n[¿Tienes dudas o problemas técnicos? Consulta aquí las preguntas frecuentes.](https://mmodsgtav.es/faq)\r\n\r\nImportante: este producto está sujeto a los [términos de uso](https://mmds.ml/tos), que se entienden como leídos y aceptados una vez comprado el producto.\r\n\r\nImágenes:\r{images}";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateText();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            updateText();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            updateText();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            updateText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(textBox4.Text);
            button1.Text = "¡COPIADO!";
            
        }
    }
}
