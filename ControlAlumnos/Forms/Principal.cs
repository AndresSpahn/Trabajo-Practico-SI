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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void públicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaUniversidades altaUniversidades = new AltaUniversidades()
            {
                Owner = this
            };
            altaUniversidades.Show();
        }

        private void privadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaUniversidades altaUniversidades = new AltaUniversidades()
            {
                Owner = this
            };
            altaUniversidades.Show();
        }

        private void listaUniversidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaUniversidades listaUniversidades = new ListaUniversidades()
            {
                Owner = this
            };
            listaUniversidades.Show();
        }

        private void consultaDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CantidadAlumnos cantidadAlumnos = new CantidadAlumnos()
            {
                Owner = this
            };
            cantidadAlumnos.Show();
        }
    }
}