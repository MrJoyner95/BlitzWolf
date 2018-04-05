using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlitzWolf
{
    public partial class CustomControlInicio : UserControl
    {
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Variables Globales ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        string archivoAbierto = "";


        public CustomControlInicio()
        {
            InitializeComponent();
        }





        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Eventos ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void CustomControlInicio_Load(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.AbrirArchivo();
            Global.MostrarDetalles();

            CargarInstanciasEnGrid();
        }





        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Funciones ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void CargarInstanciasEnGrid()
        {
            // Reinicia el Grid:
            dataGridView_Instancias.Columns.Clear();
            dataGridView_Instancias.Rows.Clear();

            // Agrega columnas al Grid:
            foreach(Global.Attribute atributo in Global.DataSet_Attributes)
            {
                // Parametros: (name, header)
                dataGridView_Instancias.Columns.Add(atributo.name, atributo.name);
            }

            // Agrega instancias al Grid:
            foreach(string[] instancia in Global.DataSet_Data)
            {
                dataGridView_Instancias.Rows.Add(instancia);
            }

            // Marca atributos que no cumplen con su expresion regular:
            foreach (int[] posicionAtributo in Global.listaAtributosErroneos)
            {
                dataGridView_Instancias.Rows[posicionAtributo[0]].Cells[posicionAtributo[1]].Style.BackColor = Color.Red;
            }
        }









    }
}
