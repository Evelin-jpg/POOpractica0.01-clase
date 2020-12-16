using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOpractica0._01_clase_
{
    class Telefono
    {
        //Variables

        public string Marca;
        public string Color;
        public string Tipo;
        private int myVar;

        //Propiedades
        public string GetMarca
        {
            get
            {
                return Marca;

            }
               
                
            set 
            {
                
                Marca = value;
            
            }
        }

        public string GetColor
        {
            get
            {
                return Color;

            }


            set
            {

                Color = value;

            }
        }

        public string GetTipo
        {
            get
            {
                return Tipo;

            }


            set
            {

                Tipo = value;

            }
        }

        //Constructores

        public Telefono()
        {
            Marca = "";
            Color = "";
            Tipo = "";

        }
        public Telefono(string Marca, string Color, string Tipo)
        {
            this.Marca = "";
            this.Color = "";
            this.Tipo = "";

        }


        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        //Metodo
        public void Llamar ()
        {

            System.Windows.Forms.MessageBox.Show("Hola a todos!");

        }

          public void MandarMensaje()
        {

        }
    }






}
