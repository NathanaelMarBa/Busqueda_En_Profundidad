using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_En_Profundidad
{
    internal class CEstado
    {

        public String Nombre;
        public int Valor;
        public List<CEstado> estadoSiguiente = new List<CEstado>();

        public CEstado(String Nombre, int Valor)
        {
            this.Valor = Valor;
            this.Nombre = Nombre;
        }


        public void agregarEstado(CEstado estado)
        {
            estadoSiguiente.Add(estado);
        }

    }
}
