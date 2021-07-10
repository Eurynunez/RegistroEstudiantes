using DataBase.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class SingletonEstudiante
    {
        public static SingletonEstudiante Instancia { get; } = new SingletonEstudiante();

        public Estudiante EstudianteFiltrado { get; set; }

        private SingletonEstudiante()
        {

        }
    }
}
