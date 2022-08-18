
using CargadePerosnas.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargadePerosnas
{
   
    public partial class Form1 : Form
    {
        public Persona[] personas { get; set; } = new Persona[3];
        public int pos = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();    
            persona.name = txtNombre.Text;
            pos = pos + 1;
            personas[pos] = persona; 
            

        }

        private void btMostar_Click(object sender, EventArgs e)
        {
            lblLista.Text = "Listas: \r\n";
            foreach (Persona item in personas)
            {
                lblLista.Text = lblLista.Text + item.name + "\r\n";
            }
        }
    }

   
}
