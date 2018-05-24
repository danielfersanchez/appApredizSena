using appApredizSena.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace appApredizSena.Model
{
    public class Aprendiz: ViewModel.Notificable
    {
        private string nombre;
        private string apellido;
        private string programa;
        private double ficha;
        private double promedio;

        

        public double Promedio
        {

            get { return promedio; }
            set { if (promedio == value)
                {
                    return;
                }
                promedio = value;
                OnPropertyChanged();
            }

        }
        public double Ficha
        {
            get { return ficha;}
            set { if (ficha== value)
                {
                    return;
                }
                ficha = value;
                OnPropertyChanged();
        }

        }
         public string Programa
        {
            get { return programa; }
            set { if (programa == value)
                {
                    return;
                }  programa = value;
                OnPropertyChanged();
            }
        }

        public string Apellido
        {
            get { return Apellido; }
            set
            {
                if (Apellido == value)
                {
                    return;
                }
                Apellido = value;
                OnPropertyChanged();
            }
        }

        public string Nombre
        {
            get { return Nombre; }
            set
            {
                if (Nombre == value)
                {
                    return;
                }
                Nombre = value;
                OnPropertyChanged();
            }
        }
    }
}
