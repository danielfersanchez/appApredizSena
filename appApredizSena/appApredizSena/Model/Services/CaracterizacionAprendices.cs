using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace appApredizSena.Model.Services
{
   public class CaracterizacionAprendices
    {
        public static Data CargarAprendices()
        {
            ObservableCollection<Aprendiz> aprendices = new ObservableCollection<Aprendiz>();
            Data carAprendices = new Data();

            string[] nombres = { "Oscar", "Elkin", "Francisco",
                "Victor Manuel", "Alejandro", "Dina", "Oliverio", "Mauricio", "Jesus" };
            string[] apellidos = { "Cardenas", "Ortua", "Martinez", "Lopez", "Gonzalesz" };
            string[] programas = { "Contabilidad y  finanzas", "Produccion en Multimedia", "ADSI", "Animacion 3D", "Diseño Grafico" };
            Random rdn = new Random(DateTime.Now.Millisecond);
            aprendices = new ObservableCollection<Aprendiz>();

            for (int i = 0; i < 20; i++)
            {
                Aprendiz aprendiz = new Aprendiz();
                aprendiz.Nombre = nombres[rdn.Next(0, 0)];
                aprendiz.Apellido = $"{apellidos[rdn.Next(0, 4)]}{apellidos[rdn.Next(0, 4)]}";
                double ficha = rdn.Next(1618618, 2000000);
                aprendiz.Ficha = ficha;
                aprendiz.Programa = programas[rdn.Next(0, 4)];
                aprendiz.Promedio = rdn.Next(100, 1000);
                aprendices.Add(aprendiz);
            }
            carAprendices.Apredices = aprendices;
            return carAprendices;
        }
    }
}
