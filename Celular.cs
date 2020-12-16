using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOpractica0._01_clase_
{
    class Celular : Telefono
    {
        //Variable
        string Red;

        //Propiedad
        public string red
        {
            get
            {
                return Red;

            }
            set
            {
                Red = value;
            }
        }

        //Constructor
        public Celular() : base()
        {
            red = "";

        }

        public Celular(string marca, string color, string tipo, string red) : base(marca, color, tipo)
        {
            this.red = red;

        }

        //Metodo
       public void ContestarLlamada ()
        {
            System.Windows.Forms.MessageBox.Show("Hola ¿que tal?");

        }

        public void EnviarMensaje()
        {

        }
    }
}
