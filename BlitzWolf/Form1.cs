using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;


namespace BlitzWolf
{
    public partial class Form1 : Form
    {
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Variables Globales ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Variables del menu lateral:
        int menuLateralMaxWidth;
        bool menuLateralAbierto;

        // Variables del conjunto de datos:
        public string DataSet_File = "";
        public string DataSet_Name = "";
        public string DataSet_MissingValue = "?";
        public int DataSet_NumberOfAttributes = 0;
        public struct Atribute
        {
            public string name;
            public string type;
            public Regex regularExpression;

            public Atribute(string name, string type, Regex regularExpression)
            {
                this.name = name;
                this.type = type;
                this.regularExpression = regularExpression;
            }
        }
        List<Atribute> DataSet_Attributes = new List<Atribute>();



        public Form1()
        {
            InitializeComponent();

            // Inicializa variables del menu lateral:
            menuLateralMaxWidth = 260;
            menuLateralAbierto = false;

        }





        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Barra de Estado ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // ++++++++++++++++++++++++++++++++++++++++ Mover ventana ++++++++++++++++++++++++++++++++++++++++
        bool moviendoVentana = false;
        int posicionMouseEnPanelX;
        int posicionMouseEnPanelY;


        private void panelBarraEstado_MouseDown(object sender, MouseEventArgs e)
        {
            // Toma los valores en X y Y del puntero en el panel de barra de estado:
            moviendoVentana = true;
            posicionMouseEnPanelX = panelBarraEstado.PointToClient(Cursor.Position).X;
            posicionMouseEnPanelY = panelBarraEstado.PointToClient(Cursor.Position).Y;
        }

        private void panelBarraEstado_MouseMove(object sender, MouseEventArgs e)
        {
            if (moviendoVentana == true)
            {
                // Resta la posicion del puntero en X y Y para que la posicion sea la esquina de la ventana:
                this.Location = new Point(Cursor.Position.X - posicionMouseEnPanelX, Cursor.Position.Y - posicionMouseEnPanelY);
            }
        }

        private void panelBarraEstado_MouseUp(object sender, MouseEventArgs e)
        {
            // La ventana ya no se esta moviendo:
            moviendoVentana = false;
        }



        // ++++++++++++++++++++++++++++++++++++++++ Minimizar ventana ++++++++++++++++++++++++++++++++++++++++
        Point posicionOriginalVentana = new Point();

        public bool IsOnScreen(Form form)
        {
            Screen[] screens = Screen.AllScreens;
            foreach (Screen screen in screens)
            {
                Point formTopLeft = new Point(form.Left, form.Top);

                if (screen.WorkingArea.Contains(formTopLeft))
                {
                    return true;
                }
            }

            return false;
        }

        private void timerMinimizarVentana_Tick(object sender, EventArgs e)
        {
            if (IsOnScreen(this) == true)
            {
                this.Top += 10;
                this.Opacity -= .1;
                // La ventana es invisible
                if (this.Opacity == 0)
                {
                    this.WindowState = FormWindowState.Minimized;
                    this.Location = posicionOriginalVentana;
                    this.Opacity = 98;
                    timerMinimizarVentana.Stop();
                }
            }
        }



        // ++++++++++++++++++++++++++++++++++++++++ Manejar ventana ++++++++++++++++++++++++++++++++++++++++
        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Minimizar_Click(object sender, EventArgs e)
        {
            // Guarda posicion original de la ventana:
            posicionOriginalVentana = this.Location;
            // Inicia timer:
            timerMinimizarVentana.Start();
        }

        private void button_Cerrar_MouseEnter(object sender, EventArgs e)
        {
            this.button_Cerrar.Image = BlitzWolf.Properties.Resources.apagar_A;
        }

        private void button_Cerrar_MouseLeave(object sender, EventArgs e)
        {
            this.button_Cerrar.Image = BlitzWolf.Properties.Resources.apagar;
        }

        private void button_Minimizar_MouseEnter(object sender, EventArgs e)
        {
            this.button_Minimizar.Image = BlitzWolf.Properties.Resources.minimizar_A;
        }

        private void button_Minimizar_MouseLeave(object sender, EventArgs e)
        {
            this.button_Minimizar.Image = BlitzWolf.Properties.Resources.minimizar2;
        }





        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Menu Lateral ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void button_MenuLateral_Click(object sender, EventArgs e)
        {
            timerMenuLateral.Start();
        }

        private void timerMenuLateral_Tick(object sender, EventArgs e)
        {
            if (menuLateralAbierto == false) // Abre menu lateral
            {
                MenuLateral.Width = MenuLateral.Width + 20;
                if (MenuLateral.Width >= menuLateralMaxWidth)
                {
                    timerMenuLateral.Stop();
                    menuLateralAbierto = true;
                    button_MenuLateral.Image = BlitzWolf.Properties.Resources.menuCerrar;
                }
            }
            else // Cierra menu lateral
            {
                MenuLateral.Width = MenuLateral.Width - 20;
                if (MenuLateral.Width <= 60)
                {
                    timerMenuLateral.Stop();
                    menuLateralAbierto = false;
                    button_MenuLateral.Image = BlitzWolf.Properties.Resources.menuAbrir;
                }
            }
        }

        private void EsconderMenuLateral()
        {
            if (menuLateralAbierto == true)
            {
                timerMenuLateral.Start();
            }
        }





        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Cambio de Vista ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void button_Inicio_Click(object sender, EventArgs e)
        {
            // Mueve panel de seleccion:
            this.panel_Seleccion.Top = this.button_Inicio.Top;
            // Mueve CustomControl al frente:
            this.customControlInicio1.BringToFront();
        }

        private void button_Archivo_Click(object sender, EventArgs e)
        {
            // Mueve panel de seleccion:
            this.panel_Seleccion.Top = this.button_Archivo.Top;
            // Mueve CustomControl al frente:
            this.customControlArchivo1.BringToFront();
        }

        private void button_PreProcesamiento_Click(object sender, EventArgs e)
        {
            // Mueve panel de seleccion:
            this.panel_Seleccion.Top = this.button_PreProcesamiento.Top;
            // Mueve CustomControl al frente:
            this.customControlPreProcesamiento1.BringToFront();
        }





        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Funciones Globales ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void AbrirArchivo()
        {
            // Crea OpenFileDialog:
            OpenFileDialog openFile = new OpenFileDialog();
            // Modifica openFile:
            openFile.Title = "Seleccione el conjunto de datos";
            // Especifica tipos de archivos validos:
            openFile.Filter = "Archivos de texto|*.txt|Archivos CSV|*.csv";

            // Ubica archivo y comprueba que se haya abierto:
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                DataSet_File = openFile.FileName;
                Console.WriteLine("Archivo abierto: " + DataSet_File);

                /*
                // Comrueba formato del archivo:
                if (ValidarArchivo(DataSet_File) == false) // Formato no valido
                {
                    return;
                }
                */

                bool validado = ValidarArchivo(DataSet_File);

                if (validado == true)
                {
                    Console.WriteLine("Archivo VALIDO");
                }
                else
                {
                    Console.WriteLine("Archivo NO valido");
                }

            }
        }


        public bool ValidarArchivo(string archivo)
        {
            // Reinicia variables globales:
            DataSet_MissingValue = "?";
            DataSet_NumberOfAttributes = 0;
            DataSet_Attributes.Clear();

            // Variable para comprobar que el archivo contenga todos los datos necesarios:
            bool[] checkListDatos = new bool[3];

            
            // Valida formato del archivo:
            using (var lector = new StreamReader(archivo))
            {
                while (!lector.EndOfStream)
                {
                    var linea = lector.ReadLine();

                    // Valida que no sea una linea vacia:
                    if (linea.Length > 0)
                    {
                        // Ubica datos del DataSet:
                        if (linea[0] == '@')
                        {
                            string[] dato = linea.Split(' ');

                            // Valida y asigna datos del DataSet:
                            if (dato[0] == "@relation")
                            {
                                try
                                {
                                    DataSet_Name = dato[1];
                                    // Confirma validez en check list:
                                    checkListDatos[0] = true;
                                }
                                catch
                                {
                                    MessageBox.Show("No se ha encontrado el nombre del conjunto de datos. Por favor, revise el archivo e inténte abrirlo de nuevo.", "Error: El nombre de la relación no existe.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    // Validacion no concretada:
                                    return false;
                                }
                            }
                            else if (dato[0] == "@attribute")
                            {
                                try
                                {
                                    // Valida expresion regular del atributo y agrega atributo  a la lista:
                                    Regex expresionRegular = new Regex(dato[3]);
                                    DataSet_Attributes.Add(new Atribute(dato[1], dato[2], expresionRegular));
                                    DataSet_NumberOfAttributes++;
                                    checkListDatos[1] = true;
                                }
                                catch
                                {
                                    // La espresion regular no es valida:
                                    MessageBox.Show("Por favor, revise que la expresión regular tenga el formato correcto en el siguiente atributo: \n" + dato[1], "Error: Expresión regular no válida.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                                }
                            }
                            else if (dato[0] == "@missingValue")
                            {
                                try
                                {
                                    DataSet_MissingValue = dato[1];
                                }
                                catch
                                {
                                    MessageBox.Show("Se ha encontrado el dato @missingValue, sin embargo este no tiene un valor. Por favor, agregue un valor al dato o elimínelo del archivo.", "Error: Valor faltante no encontrado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                                }
                            }
                            else if (dato[0] == "@data")
                            {
                                checkListDatos[2] = true;
                            }
                        }
                    }
                }
            }

            
            // Comprueba que todas las validaciones se hayan completado con exito:            
            foreach (bool valor in checkListDatos)
            {
                if(valor == false)
                {
                    MessageBox.Show("No se han econtrado todos los valores necesarios del conjunto de datos en el archivo. Por favor, verifique que el archivo cuente con los siguientes valores: \n @relation \n @attribute \n @data", "Error: Formato incorrecto.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            // Todos los valores han sido validados:
            return true;
        }






        private void button1_Click(object sender, EventArgs e)
        {
            AbrirArchivo();

            // Muestra datos del conjunto de datos:
            Console.WriteLine("\n******** DATOS DEL DATASET ********\n");
            Console.WriteLine("DataSet_File =               " + DataSet_File);
            Console.WriteLine("DataSet_Name =               " + DataSet_Name);
            Console.WriteLine("DataSet_MissingValue =       " + DataSet_MissingValue);
            Console.WriteLine("DataSet_NumberOfAttributes = " + DataSet_NumberOfAttributes);
            Console.WriteLine("DataSet_Attributes:");
            foreach(BlitzWolf.Form1.Atribute atributo in DataSet_Attributes)
            {
                Console.WriteLine("\tAtributo: " + atributo.name + ", Tipo: " + atributo.type + ", Expresion regular: " + atributo.regularExpression);
            }

        }
    }
}
