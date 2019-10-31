using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class AltaUniversidades : Form
    {
        public AltaUniversidades()
        {
            InitializeComponent();
        }

        private void button_Confirmar_Click(object sender, EventArgs e)
        {
            if (this.textBox_CodigoUniversidad.Text != "" && this.textBox_Año.Text != "" && this.textBox_Nombre.Text != "" && this.textBox_Siglo.Text != "" && this.textBox_TipoUniversidad.Text != "")
            {
                
            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }
        }
    }
}