using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Busqueda_En_Profundidad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProfundidad_Click(object sender, EventArgs e)
        {
            CEstado[] estado = new CEstado[17];
            estado[0] = new CEstado("0",7);
            estado[1] = new CEstado("1", 3);
            estado[2] = new CEstado("2", 5);
            estado[3] = new CEstado("3", 4);
            estado[4] = new CEstado("4", 2);
            estado[5] = new CEstado("5", 9);
            estado[6] = new CEstado("6", 17);
            estado[7] = new CEstado("7", 15);
            estado[8] = new CEstado("8", 6);
            estado[9] = new CEstado("9", 8);
            estado[10] = new CEstado("10", 21);
            estado[11] = new CEstado("11", 25);
            estado[12] = new CEstado("12", 14);
            estado[13] = new CEstado("13", 18);
            estado[14] = new CEstado("14", 20);
            estado[15] = new CEstado("15", 1);
            estado[16] = new CEstado("16", 11);

            estado[0].agregarEstado(estado[1]);
            estado[0].agregarEstado(estado[2]);
            estado[0].agregarEstado(estado[3]);
            estado[1].agregarEstado(estado[4]);
            estado[1].agregarEstado(estado[5]);
            estado[2].agregarEstado(estado[6]);
            estado[3].agregarEstado(estado[7]);
            estado[3].agregarEstado(estado[8]);
            estado[6].agregarEstado(estado[10]);
            estado[6].agregarEstado(estado[11]);
            estado[6].agregarEstado(estado[12]);
            estado[9].agregarEstado(estado[13]);
            estado[9].agregarEstado(estado[14]);
            estado[10].agregarEstado(estado[15]);
            estado[10].agregarEstado(estado[16]);
            
        }

        public bool BuscarEstado(CEstado estado)
        {
            int objetivo = int.Parse(txtNumeroaBuscar.Text);
            if (estado.estadoSiguiente.Count > 0)
            {
                foreach (CEstado siguiente in estado.estadoSiguiente)
                {
                    BuscarEstado(siguiente);
                    if(estado.Valor == objetivo)
                    MessageBox.Show("Valor encontrado en el estado: " + estado.Nombre);
                }

                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
