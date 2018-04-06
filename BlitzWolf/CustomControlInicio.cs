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

        // ++++++++++++++++++++++++++++++++++++++++ Menustrip ++++++++++++++++++++++++++++++++++++++++

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.AbrirArchivo();
            Global.MostrarDetalles();
            CargarInstanciasEnGrid();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.GuardarArchivo(Global.DataSet_File);
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.GuardarArchivoComo();
        }

        // ++++++++++++++++++++++++++++++++++++++++ DataGrid ++++++++++++++++++++++++++++++++++++++++

        private void dataGridView_Instancias_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            

            // Ubica la posicion de la celda modificada:
            int posicionX = dataGridView_Instancias.CurrentCell.RowIndex;
            int posicionY = dataGridView_Instancias.CurrentCell.ColumnIndex;

            Console.WriteLine("posicionX = " + posicionX);
            Console.WriteLine("posicionY = " + posicionY);

            // Intenta guardar cambios en memoria:
            try
            {
                // Modifica valor en la misma posicion en el DataSet_Data:
                Global.DataSet_Data[posicionX][posicionY] = dataGridView_Instancias.CurrentCell.Value.ToString();

                // Especififca que se ha modificado:
                Global.ArchivoModificado = true;
            }
            catch
            {                               
                Console.WriteLine("Error al guardar cambios en instancia...");
            }
            
            
            // Valida expresion regular del atributo con el nuevo valor:
            if (Global.DataSet_Attributes[posicionY].regularExpression.Match(Global.DataSet_Data[posicionX][posicionY]).Success)
            {
                // ++++++++++++++++ Valor nuevo cumple con la expresion regular: ++++++++++++++++
                // Define color de la celda:
                dataGridView_Instancias.CurrentCell.Style.BackColor = Color.FromName("WindowFrame");
                
                // Busca instancia de lista erroneos:
                int posicionAtributoErroneo = 0;
                bool atributoErroneoEnLista = false;

                foreach(int[] atributoErroneo in Global.listaAtributosErroneos)
                {
                    if(atributoErroneo[0] == posicionX && atributoErroneo[1] == posicionY)
                    {
                        atributoErroneoEnLista = true;
                        break;
                    }
                    posicionAtributoErroneo++;
                }

                // Si el atributo se encuentra en la lista de erroneos lo elimina:
                if(atributoErroneoEnLista == true)
                {
                    Global.listaAtributosErroneos.RemoveAt(posicionAtributoErroneo);
                }
                
                /*
                // Comprobacion
                Console.WriteLine("\n******** ATRIBUTOS ERRONEOS ********\n");
                foreach (int[] posicionAtributo in Global.listaAtributosErroneos)
                {
                    Console.WriteLine(posicionAtributo[0] + "," + posicionAtributo[1]);
                }
                */
            }
            else
            {
                // ++++++++++++++++ Valor nuevo NO cumple con la expresion regular: ++++++++++++++++
                // Define color de la celda:
                dataGridView_Instancias.CurrentCell.Style.BackColor = Color.Red;

                // Busca instancia de lista erroneos:
                int posicionAtributoErroneo = 0;
                bool atributoErroneoEnLista = false;

                foreach (int[] atributoErroneo in Global.listaAtributosErroneos)
                {
                    if (atributoErroneo[0] == posicionX && atributoErroneo[1] == posicionY)
                    {
                        atributoErroneoEnLista = true;
                        break;
                    }
                    posicionAtributoErroneo++;
                }

                // Si el atributo NO se encuentra en la lista de erroneos, lo agrega:
                if (atributoErroneoEnLista == false)
                {
                    int[] nuevoAtributo = new int[] { posicionX, posicionY };
                    Global.listaAtributosErroneos.Add(nuevoAtributo);
                }                
            }                
        }







        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Funciones ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void CargarInstanciasEnGrid()
        {
            // Define estilo del Grid:
            dataGridView_Instancias.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 55, 55);
            dataGridView_Instancias.RowHeadersVisible = false;

            // Reinicia el Grid:
            dataGridView_Instancias.Columns.Clear();
            dataGridView_Instancias.Rows.Clear();

            // Comprueba que hayan valores para los datos del DataSet:
            if (Global.DataSet_Attributes.Count > 0 && Global.DataSet_Data.Count > 0)
            {
                // Agrega columnas al Grid:
                foreach (Global.Attribute atributo in Global.DataSet_Attributes)
                {
                    // Parametros: (name, header)
                    dataGridView_Instancias.Columns.Add(atributo.name, atributo.name);
                }

                // Agrega instancias al Grid:
                foreach (string[] instancia in Global.DataSet_Data)
                {
                    dataGridView_Instancias.Rows.Add(instancia);
                }

                // Marca atributos que no cumplen con su expresion regular:
                foreach (int[] posicionAtributo in Global.listaAtributosErroneos)
                {
                    dataGridView_Instancias.Rows[posicionAtributo[0]].Cells[posicionAtributo[1]].Style.BackColor = Color.Red;
                }
            }
            else
            {
                // El DataSet no cuenta con los valores necesarios para ser mostrado:
                MessageBox.Show("El conjunto de datos no cuenta con los valores necesarios para ser mostrado en el Grid.", "Error: No puede mostrarse el conjunto de datos.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        
    }
}
