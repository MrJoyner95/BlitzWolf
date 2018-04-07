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
        static public List<string> DataSet_Classes = new List<string>();

        // Variables del archivo:
        static public List<string> ComentariosArchivo = new List<string>();
        static public List<int[]> listaAtributosErroneos = new List<int[]>();
        static public bool ArchivoModificado = false;

        // Variables de modificacion:
        static public bool AtributoModificado = false;
        static public Attribute AtributoActualizado = new Attribute();





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
            ComentariosArchivo.Clear();

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
                        else if (linea[0] == '%')
                        {
                            // Agrega comentarios del archivo (siempre van antes de la relacion:
                            ComentariosArchivo.Add(linea);
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
            ArchivoModificado = false;
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

            // Define las clases del conjunto de datos:
            DataSet_Classes.Clear();

            foreach (Attribute atributo in DataSet_Attributes)
            {
                if (atributo.type == "nominal" || atributo.type == "ordinal")
                {
                    DataSet_Classes.Add(atributo.name);
                }
            }
        }


        static public void GuardarArchivo(string archivo)
        {
            // Comprueba que haya un archivo abierto:
            if (archivo.Length == 0)
                return;

            // Escribe todos los datos complementarios e instancias del conjunto de datos en la ruta especificada:
            try
            {
                // Escribe en el archivo (parametro false es "append = false" para que el archivo se sobreescriba), se guarda en un archivo temporal:
                using (StreamWriter escritor = new StreamWriter(archivo + "_TEMPORAL", false))
                {
                    // Escribe comentarios del archivo:
                    foreach (string linea in ComentariosArchivo)
                    {
                        escritor.WriteLine(linea);
                    }
                    escritor.WriteLine();

                    // Escribe nombre del DataSet:
                    escritor.WriteLine("@relation " + DataSet_Name);

                    // Escribe atributos del DataSet:
                    foreach (Attribute atributo in DataSet_Attributes)
                    {
                        escritor.WriteLine("@attribute " + atributo.name + " " + atributo.type + " " + atributo.regularExpression.ToString());
                    }

                    // Escribe simbolo del valor faltante:
                    escritor.WriteLine("@missingValue " + DataSet_MissingValue);
                    escritor.WriteLine();

                    // Escribe instancias del DataSet:
                    escritor.WriteLine("@data");
                    foreach (string[] instancia in DataSet_Data)
                    {
                        for (int x = 0; x < DataSet_Attributes.Count; x++)
                        {
                            if (x == DataSet_Attributes.Count - 1)
                            {
                                // Es el ultimo atributo de la instancia, no se escribe coma al final y se da un salto de linea:
                                escritor.Write(instancia[x]);
                                escritor.WriteLine();
                            }
                            else
                            {
                                // Se agrega una coma como separador:
                                escritor.Write(instancia[x] + ",");
                            }
                        }
                    }
                }

                // Cambios guardados, el archivo no tiene modificaciones por guardar:
                ArchivoModificado = false;
            }
            catch
            {
                MessageBox.Show("Por favor, verifique que la ruta específicada sea válida y que cuente con los permisos para guardar en la misma.", "Error: No se ha podido guardar el archivo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Si todo se escribió bien, reemplaza archivo original con el archivo temporal creado:
            File.Delete(archivo);
            File.Move(archivo + "_TEMPORAL", archivo);
        }


        static public void GuardarArchivoComo()
        {
            // Crea SaveFileDialog:
            SaveFileDialog saveFile = new SaveFileDialog();
            // Modifica saveFile:
            saveFile.Title = "Guardar como...";
            // Especifica tipos de archivos validos:
            saveFile.Filter = "Archivo de texto|*.txt|Archivo CSV|*.csv";
            // Muestra saveFile:
            DialogResult saveFileResult = saveFile.ShowDialog();
            // Interpreta respuesta de saveFile:
            if (saveFileResult == DialogResult.OK)
            {
                GuardarArchivo(saveFile.FileName);
            }
        }


        static public Attribute BuscarAtributo(string nombreAtributo)
        {
            Attribute atributoEncontrado = DataSet_Attributes.Find(x => x.name == nombreAtributo);


            Console.WriteLine("******************************** BuscarAtributo ********************************");
            Console.WriteLine("\tAtributo: " + atributoEncontrado.name + ", Tipo: " + atributoEncontrado.type + ", Expresion regular: " + atributoEncontrado.regularExpression);


            if (atributoEncontrado.name != null) // Encontro el atributo:
            {
                // Regresa el objeto atributo:
                return atributoEncontrado;
            }
            else // Atributo no encotrado:
            {
                // Crea un nuevo atributo vacio:
                //Regex regex = new Regex(" ");
                Attribute atributoVacio = new Attribute(null, null, null);
                return atributoVacio;
            }
        }


        static public bool ActualizarAtributo(string nombreAtributo, Attribute atributoNuevo)
        {
            Attribute atributoActual = DataSet_Attributes.Find(x => x.name == nombreAtributo);
            Console.WriteLine("******************************** ActualizarAtributo ********************************");
            Console.WriteLine("******************************** atributoActual");
            Console.WriteLine("\tAtributo: " + atributoActual.name + ", Tipo: " + atributoActual.type + ", Expresion regular: " + atributoActual.regularExpression);
            Console.WriteLine("******************************** atributoNuevo");
            Console.WriteLine("\tAtributo: " + atributoNuevo.name + ", Tipo: " + atributoNuevo.type + ", Expresion regular: " + atributoNuevo.regularExpression);

            // Encontro el atributo:
            if (atributoActual.name != null)
            {
                // Actualiza atributo con valores del nuevo atrinuto:
                // Encuentra indice del atributo:
                int indiceAtributoActual = DataSet_Attributes.IndexOf(atributoActual);
                // Agrega atributo nuevo a la lista:
                DataSet_Attributes.Insert(indiceAtributoActual, atributoNuevo);
                // Elimina atributo original:
                DataSet_Attributes.RemoveAt(indiceAtributoActual + 1);

                // Actualizacion exitosa:
                ArchivoModificado = true;
                AtributoModificado = true;
                AtributoActualizado = atributoNuevo;
                return true;
            }
            else
            {
                // Atributo no encotrado:
                AtributoModificado = false;
                return false;
            }
        }


        static public void ValidarExpresionesRegulares()
        {
            // Limpia lista de erroneos:
            listaAtributosErroneos.Clear();

            // Recorre lista de atributos y compara su expresion regular con todas sus instancias:
            for(int x = 0; x < DataSet_Attributes.Count; x++)
            {
                // Recorre lista de instancias:
                for(int y = 0; y < DataSet_Data.Count; y++)
                {
                    // Comprueba que el atributo cumpla con la expresion regular:
                    if (!DataSet_Attributes[x].regularExpression.Match(DataSet_Data[y][x]).Success)
                    {
                        // Agrega la posicion de la instancia y el atributo a la lista porque no cumple con la expresion regular:
                        listaAtributosErroneos.Add(new int[] { y, x });
                    }
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

            // Muestra clases:
            Console.WriteLine("\n******** CLASES ********\n");
            foreach (string clase in DataSet_Classes)
            {
                Console.WriteLine(clase);
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
