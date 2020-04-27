using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T109_11_POO_Ej1
{

  

    public class Carrera
    {
     private   List<Catedra> _LCatedras = new List<Catedra>();

        public List<Catedra> LCatedras
        {
            get
            {
                return _LCatedras;
            }

        }

        public int NumeroCarrera
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int Nombre
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void agregaCatedra(Catedra Ca)
        {
            _LCatedras.Add(Ca);
        }
    }
}