using Bucles.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucles.Negocio
{
    public class ClsEstudiante
    {
        List<Estudiante> Est = new List<Estudiante>();

        public void AgregarEstudiante(Estudiante estu) 
        {
            Est.Add(estu);
        }

        public List<Estudiante> ListarEstudiante()
        {
            return Est;
        }
    }
}
