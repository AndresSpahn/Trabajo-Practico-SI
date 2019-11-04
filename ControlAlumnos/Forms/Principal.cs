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
        
        private void AltaUniversidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alta_Alumno alta_Alumno = new Alta_Alumno()
            { Owner = this };
            alta_Alumno.Show();
        }

        private void listaUniversidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar_Alumno modificar_Alumno = new Modificar_Alumno()
            { Owner = this };
            modificar_Alumno.Show();
        }

        private void consultaDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vision_Usuario vision_Usuario = new Vision_Usuario()
            { Owner = this };
            vision_Usuario.Show();
        }
    }
}