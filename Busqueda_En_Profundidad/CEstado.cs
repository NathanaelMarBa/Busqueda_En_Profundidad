using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_En_Profundidad
{
    internal class CEstado
    {

        public int Valor;
        public List<CEstado> estadoSiguiente = new List<CEstado>();

        public CEstado(int Valor)
        {
            this.Valor = Valor;
        }

        public void agregarEstado(CEstado estado)
        {
            estadoSiguiente.Add(estado);
        }

    }
}
