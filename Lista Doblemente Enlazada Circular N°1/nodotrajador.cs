using Lista_Doblemente_Enlazada_Circular_N_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace multilisata
{
    class nodotrabajador :TNodo
    {
        public int ID;
        public string nombre;
        public string Oficio;

        public nodotrabajador(int iden, string nomb,string oficio)
        {
            ID = iden;
            nombre = nomb;
            Oficio = oficio;


        }

        public int getID()
        {
            return ID;
        }public string getnombre()
        {

            return nombre;
        }
        public  string getOficio()
        {
            return Oficio;
        }

    }
} 