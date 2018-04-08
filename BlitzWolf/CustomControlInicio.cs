using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace BlitzWolf
{
    public partial class CustomControlInicio : UserControl
    {
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Variables Globales ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        bool InstanciasCargadasEnGrid = false;


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
            MostrarInformacionDataSet();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.GuardarArchivo(Global.DataSet_File);
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.GuardarArchivoComo();
        }

        private void buscarYReemplazartoolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Comprueba que haya un DataSet abierto:
            if (Global.DataSet_NumberOfAttributes > 0)
            {
                // Abre popUp:
                PopUpConjuntoDeDatos popUp = new PopUpConjuntoDeDatos();
                popUp.ShowDialog();
                // Verifica si se hizo el reemplazo:
                if(Global.ValoresReemplazados == true)
                {
                    CargarInstanciasEnGrid();
                    Global.ValoresReemplazados = false;

                    // Muestra detalles actualizados:
                    MostrarInformacionDataSet();
                }
            }
        }

        // ++++++++++++++++++++++++++++++++++++++++ DataGrid ++++++++++++++++++++++++++++++++++++++++

        private void dataGridView_Instancias_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {           
            // Ubica la posicion de la celda modificada:
            int posicionX = dataGridView_Instancias.CurrentCell.RowIndex;
            int posicionY = dataGridView_Instancias.CurrentCell.ColumnIndex;

            //Console.WriteLine("posicionX = " + posicionX);
            //Console.WriteLine("posicionY = " + posicionY);

            // Intenta guardar cambios en memoria:
            try
            {
                // Llena celda vacia:
                if (dataGridView_Instancias.CurrentCell.Value == null)
                    dataGridView_Instancias.CurrentCell.Value = "";

                // Modifica valor en la misma posicion en el DataSet_Data:
                Global.DataSet_Data[posicionX][posicionY] = dataGridView_Instancias.CurrentCell.Value.ToString();

                // Especififca que se ha modificado:
                Global.ArchivoModificado = true;
            }
            catch
            {                               
                Console.WriteLine("Error al guardar cambios en instancia...");
            }

            // Valida el nuevo valor con expresion regular del atributo:
            bool cumpleConExpresion = Global.ValidarExpresionRegular(posicionX, posicionY);

            if(cumpleConExpresion == true)
            {
                // Define color de la celda:
                dataGridView_Instancias.CurrentCell.Style.BackColor = Color.FromName("WindowFrame");
            }
            else
            {
                // Define color de la celda:
                dataGridView_Instancias.CurrentCell.Style.BackColor = Color.Red;
            }

            // Muestra detalles actualizados:
            MostrarInformacionDataSet();
        }


        private void dataGridView_Instancias_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (InstanciasCargadasEnGrid == true)
            {
                // Agrega nueva instancia al DataSet:
                string[] nuevaInstancia = new string[Global.DataSet_Attributes.Count];
                Global.AgregarInstancia(nuevaInstancia);

                // Muestra detalles actualizados:
                MostrarInformacionDataSet();
            }
        }


        private void dataGridView_Instancias_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Busca atributo:
            Global.Attribute attribute = Global.BuscarAtributo(dataGridView_Instancias.CurrentCell.OwningColumn.Name);


            Console.WriteLine("******************************** BuscarAtributo ********************************");
            Console.WriteLine(dataGridView_Instancias.CurrentCell.OwningColumn.Name);
            Console.WriteLine("\tAtributo: " + attribute.name + ", Tipo: " + attribute.type + ", Expresion regular: " + attribute.regularExpression);


            if (attribute.name != null)
            {
                // Abre PopUp:
                PopUpAtributo popUp = new PopUpAtributo(attribute, "Modificar");
                popUp.ShowDialog();

                // Si se modifico el atributo, comprueba que sus instancias cumplan con su expresion regular:
                if (Global.AtributoModificado == true)
                {
                    // Valida todas las instancias con todas las expresiones regulares:
                    Global.ValidarExpresionesRegulares();
                    // Vuelve a cargar todo el Grid:
                    CargarInstanciasEnGrid();

                    // Muestra detalles actualizados:
                    MostrarInformacionDataSet();
                }
            }
        }


        private void button_AgregarInstancia_Click(object sender, EventArgs e)
        {
            // Verifica que haya datos cargados:
            if (InstanciasCargadasEnGrid == true)
            {
                dataGridView_Instancias.Rows.Add();
            }
        }


        private void button_EliminarInstancia_Click(object sender, EventArgs e)
        {
            // Verifica que haya datos cargados:
            if (InstanciasCargadasEnGrid == true && Global.DataSet_Data.Count > 0)
            {
                // Elimina instancias del DataSet:
                foreach (DataGridViewCell cell in dataGridView_Instancias.SelectedCells)
                {
                    int posicionInstancia = cell.RowIndex;

                    //int posicionY = cell.ColumnIndex;
                    //Console.WriteLine("indice de instancia a eliminar = " + posicionX);
                    //Global.DataSet_Data.RemoveAt(posicionX);

                    Global.EliminarInstancia(posicionInstancia);
                }

                // Elimina filas del DataGrid:
                foreach (DataGridViewCell cell in dataGridView_Instancias.SelectedCells)
                {
                    int posicionX = cell.RowIndex;
                    dataGridView_Instancias.Rows.RemoveAt(posicionX);
                }

                // Muestra detalles actualizados:                
                MostrarInformacionDataSet();
            }
        }


        private void button_AgregarAtributo_Click(object sender, EventArgs e)
        {
            // Verifica que haya datos cargados:
            if (InstanciasCargadasEnGrid == true)
            {
                // Crea atributo vacio:
                Regex regex = new Regex("");
                Global.Attribute attribute = new Global.Attribute("", "", regex);

                // Abre PopUp:
                PopUpAtributo popUp = new PopUpAtributo(attribute, "Agregar");
                popUp.ShowDialog();

                // Si se agrego un atributo, se vuelven a cargar las instancias en el Grid:
                if (Global.AtributoModificado == true)
                {
                    //Console.WriteLine("******************************** ATRIBUTO AGREGADO ********************************");
                    // Vuelve a cargar todo el Grid:
                    CargarInstanciasEnGrid();

                    // Muestra detalles actualizados:
                    MostrarInformacionDataSet();
                }
            }
        }


        private void button__EliminarAtributo_Click(object sender, EventArgs e)
        {
            // Verifica que haya datos cargados y sólo una celda seleccionada:
            if (InstanciasCargadasEnGrid == true && dataGridView_Instancias.SelectedCells.Count == 1)
            {
                // Identifica columna de la celda:
                int indiceColumna = dataGridView_Instancias.CurrentCell.ColumnIndex;
                string nombreColumna = dataGridView_Instancias.CurrentCell.OwningColumn.HeaderText;

                // Confirmacion de eliminar:
                DialogResult messageBoxResult = MessageBox.Show("¿Está seguro de que desea eliminar el atributo \" " + nombreColumna + "\"?", "Eliminar atributo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                // Maneja respuesta:
                if (messageBoxResult == DialogResult.Yes)
                {
                    // Elimina atributo:
                    Global.EliminarAtributo(nombreColumna);
                    // Elimina columna del Grid:
                    dataGridView_Instancias.Columns.RemoveAt(indiceColumna);
                }

                // Muestra detalles actualizados:
                MostrarInformacionDataSet();
            }
        }






        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Funciones ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void CargarInstanciasEnGrid()
        {
            // Previene errores con evento RowAdded:
            InstanciasCargadasEnGrid = false;            

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
                foreach (int[] posicionAtributo in Global.listaValoresErroneos)
                {
                    dataGridView_Instancias.Rows[posicionAtributo[0]].Cells[posicionAtributo[1]].Style.BackColor = Color.Red;
                }

                // Confirma que todo se cargo:
                InstanciasCargadasEnGrid = true;
            }
            else
            {
                // El DataSet no cuenta con los valores necesarios para ser mostrado:
                MessageBox.Show("El conjunto de datos no cuenta con los valores necesarios para ser mostrado en el Grid.", "Error: No puede mostrarse el conjunto de datos.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                InstanciasCargadasEnGrid = false;
            }
        }


        private void MostrarInformacionDataSet()
        {
            this.label_DataSet_File.Text = Global.DataSet_File;
            this.label_DataSet_Name.Text = Global.DataSet_Name;
            this.label_DataSet_MissingValue.Text = Global.DataSet_MissingValue;
            this.label_DataSet_NumberOfAttributes.Text = Global.DataSet_NumberOfAttributes.ToString();
            this.label_DataSet_NumberOfInstances.Text = Global.DataSet_Data.Count.ToString();
            this.label_DataSet_ValoresErroneos.Text = Global.listaValoresErroneos.Count.ToString();
        }
    }
}
