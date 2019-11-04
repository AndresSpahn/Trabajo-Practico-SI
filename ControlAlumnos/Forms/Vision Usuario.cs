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
    public partial class Vision_Usuario : Form
    {
        public Vision_Usuario()
        {
            InitializeComponent();

            List<Cant> lista = new List<Cant>();
            Cant cantidad = new Cant
            {
                Universidad = "UTN",
                Sede = "Rafaela",
                CantidadAlumnos = 536
            };
            lista.Add(cantidad);
            Cant cantidad1 = new Cant
            {
                Universidad = "Instituto",
                Sede = "Rafaela",
                CantidadAlumnos = 268
            };
            lista.Add(cantidad);
            dataGridView1.DataSource = lista;

            textBox2.Text = "804";

            var Provincias = new List<string>();
            Provincias.Add("Seleccione Provincia"); Provincias.Add("Santa Fe"); Provincias.Add("Buenos Aires"); Provincias.Add("Cordoba");
            comboBox1.DataSource = Provincias;

            var Nombres = new List<string>();
            Nombres.Add("Selecciona la universidad"); Nombres.Add("Universidad Catolica"); Nombres.Add("Universidad Austral"); Nombres.Add("Universidad Abierta"); Nombres.Add("Universidad Nacional"); Nombres.Add("Universidad Tecnologica"); Nombres.Add("Instituto Universitario");
            comboBox2.DataSource = Nombres;

        }
    }
}
