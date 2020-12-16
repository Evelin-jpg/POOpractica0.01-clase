using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOpractica0._01_clase_
{
    public partial class Form1 : Form
    {
        Telefono Movistar = new Telefono(); // Se crea el objeto 

        public Form1()
        {
            InitializeComponent();
        }

        //Evento y Metodo
        private void button1_Click(object sender, EventArgs e)
        {
            Movistar.Llamar();
        }


        Celular Telcel = new Celular(); // Se crea el objeto

        //Evento y Metodo
        private void btn_ContestarLlamada_Click(object sender, EventArgs e)
        {
            Telcel.ContestarLlamada();

        }
    }


}
