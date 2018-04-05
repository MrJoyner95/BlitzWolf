using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BlitzWolf
{
    static public class Global
    {
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Variables Globales ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++        

        // Variables del conjunto de datos:
        static public string DataSet_File = "";
        static public string DataSet_Name = "";
        static public string DataSet_MissingValue = "?";
        static public int DataSet_NumberOfAttributes = 0;
        static public int DataSet_NumberOfInstances = 0;
        static public List<string[]> DataSet_Data = new List<string[]>();
        public struct Attribute
        {
            public string name;
            public string type;
            public Regex regularExpression;

            public Attribute(string name, string type, Regex regularExpression)
            {
                this.name = name;
                this.type = type;
                this.regularExpression = regularExpression;
            }
        }
        static public List<Attribute> DataSet_Attributes = new List<Attribute>();

        static public List<int[]> listaAtributosErroneos = new List<int[]>();





        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Funciones Globales ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        static public void AbrirArchivo()
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


                bool validado = ValidarArchivo(DataSet_File);
                if (validado == true)
                {
                    Console.WriteLine("Archivo VALIDO");
                    CargarArchivo(DataSet_File);
                }
                else
                {
                    Console.WriteLine("Archivo NO valido");
                }
            }
        }


        static public bool ValidarArchivo(string archivo)
        {
            // Reinicia variables globales:
            DataSet_MissingValue = "?";
            DataSet_NumberOfAttributes = 0;
            DataSet_Attributes.Clear();

            // Variables locales:

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
                                    Regex expresionRegular = new Regex(@dato[3]);
                                    DataSet_Attributes.Add(new Attribute(dato[1], dato[2], expresionRegular));
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
                if (valor == false)
                {
                    MessageBox.Show("No se han econtrado todos los valores necesarios del conjunto de datos en el archivo. Por favor, verifique que el archivo cuente con los siguientes valores: \n @relation \n @attribute \n @data", "Error: Formato incorrecto.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            // Todos los valores han sido validados:
            return true;
        }


        static public void CargarArchivo(string archivo)
        {
            // Reinicia variables globales:
            DataSet_Data.Clear();
            listaAtributosErroneos.Clear();

            // Variable para saber cuando se encontro la etiqueta @data:
            bool dataEncontrada = false;
            int lineaActual = 0;
            int numeroInstancia = 0;

            using (var lector = new StreamReader(archivo))
            {
                while (!lector.EndOfStream)
                {
                    var linea = lector.ReadLine();

                    // Valida que no sea una linea vacia y que se haya encontrado la etiqueta data:
                    if (linea.Length > 0 && dataEncontrada == true)
                    {
                        string[] instancia = linea.Split(',');

                        // Comprueba que la instancia tenga el numero correcto de atributos:
                        if (instancia.Length >= DataSet_NumberOfAttributes)
                        {
                            // Valida cada atributo de la instancia:
                            for (int x = 0; x < DataSet_NumberOfAttributes; x++)
                            {
                                // Reemplaza valores nulos en la instancia:
                                if (instancia[x] == "" || instancia[x] == " ")
                                {
                                    instancia[x] = DataSet_MissingValue;
                                }
                                else
                                {
                                    // Comprueba que el atributo cumpla con la expresion regular:
                                    if (!DataSet_Attributes[x].regularExpression.Match(instancia[x]).Success)
                                    {
                                        // Agrega la posicion de la instancia y el atributo a la lista porque no cumple con la expresion regular:
                                        listaAtributosErroneos.Add(new int[] { numeroInstancia, x });
                                    }
                                }
                            }

                            // Agrega instancia a lista:
                            DataSet_Data.Add(instancia);
                        }
                        else
                        {
                            // La instancia no tiene el numero de atributos correcto:
                            DataSet_Data.Clear();
                            MessageBox.Show("Se han encontrado instancias que no cuentan con el número de atributos especificados. Por favor, abra el archivo y compruebe que la instancia de la siguiente línea: \n" + lineaActual, "Error: Instancias no válidas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }

                        // Aumenta numero de instancia:
                        numeroInstancia++;
                    }
                    else if (linea == "@data")
                    {
                        // Se ha encontrado la etiqueta:
                        dataEncontrada = true;
                    }

                    // Mantiene control de lineas leidas:
                    lineaActual++;
                }
            }
        }



        static public void MostrarDetalles()
        {
            // Muestra datos del conjunto de datos:
            Console.WriteLine("\n******** DATOS DEL DATASET ********\n");
            Console.WriteLine("DataSet_File =               " + DataSet_File);
            Console.WriteLine("DataSet_Name =               " + DataSet_Name);
            Console.WriteLine("DataSet_MissingValue =       " + DataSet_MissingValue);
            Console.WriteLine("DataSet_NumberOfAttributes = " + DataSet_NumberOfAttributes);
            Console.WriteLine("DataSet_Attributes:");
            foreach (BlitzWolf.Global.Attribute atributo in DataSet_Attributes)
            {
                Console.WriteLine("\tAtributo: " + atributo.name + ", Tipo: " + atributo.type + ", Expresion regular: " + atributo.regularExpression);
            }

            // Muestra instancias:
            Console.WriteLine("\n******** INSTANCIAS DEL DATASET ********\n");
            Console.WriteLine("DataSet_Data:");
            foreach (string[] instancia in DataSet_Data)
            {
                for (int x = 0; x < DataSet_NumberOfAttributes; x++)
                {
                    Console.Write(instancia[x] + "|");
                }
                Console.WriteLine();
            }

            // Muestra posiciones de atributos erroneos:
            Console.WriteLine("\n******** ATRIBUTOS ERRONEOS ********\n");
            foreach (int[] posicionAtributo in listaAtributosErroneos)
            {
                Console.WriteLine(posicionAtributo[0] + "," + posicionAtributo[1]);
            }
        }



    }
}
