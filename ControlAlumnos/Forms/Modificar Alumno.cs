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
    public partial class Modificar_Alumno : Form
    {
        public Modificar_Alumno()
        {
            InitializeComponent();

            var TiposDNI = new List<string>();
            TiposDNI.Add(""); TiposDNI.Add("DNI"); TiposDNI.Add("PAS"); TiposDNI.Add("CEXT"); TiposDNI.Add("RUC");
            comboBox1.DataSource = TiposDNI;

            var TiposU = new List<string>();
            TiposU.Add("Seleccione el tipo de Universidad"); TiposU.Add("Privada"); TiposU.Add("Estatal");
            comboBox6.DataSource = TiposU;

            var Texto = new List<string>();
            Texto.Add("Seleccione el tipo primero");
            comboBox7.DataSource = Texto;

            var Provincias = new List<string>();
            Provincias.Add("Seleccione Provincia"); Provincias.Add("Santa Fe"); Provincias.Add("Buenos Aires"); Provincias.Add("Cordoba");
            comboBox4.DataSource = Provincias;
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            var NombresP = new List<string>();
            NombresP.Add("Seleccione su universidad"); NombresP.Add("Universidad Catolica"); NombresP.Add("Universidad Austral"); NombresP.Add("Universidad Abierta");

            var NombresE = new List<string>();
            NombresE.Add("Seleccione su universidad"); NombresE.Add("Universidad Nacional"); NombresE.Add("Universidad Tecnologica"); NombresE.Add("Instituto Universitario");

            if (comboBox6.Text == "Privada")
            {
                comboBox7.DataSource = NombresP;
            }
            else
            {
                if (comboBox6.Text == "Estatal")
                {
                    comboBox7.DataSource = NombresE;
                }
            }
        }
    }
}
