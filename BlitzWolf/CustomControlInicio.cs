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

        }





        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Funciones ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void AbrirArchivo()
        {
            // Crea OpenFileDialog:
            OpenFileDialog openFile = new OpenFileDialog();
            // Modifica openFile:
            openFile.Title = "Seleccione el conjunto de datos";
            // Especifica tipos de archivos validos:
            openFile.Filter = "Archivos de texto|*.txt|Archivos CSV|*.csv";            
            
            // Ubica archivo y comprueba que se haya abierto:
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                archivoAbierto = openFile.FileName;
                Console.WriteLine(archivoAbierto);

                // Comrueba formato del archivo:
                if(ValidarFormatoArchivo(archivoAbierto) == false) // Formato no valido
                {
                    return;
                }
                Console.WriteLine(archivoAbierto);
            }
            
        }


        private bool ValidarFormatoArchivo(string rutaArchivo)
        {
            // formato valido
            return true;
            // formato invalido
            //return false;
        }




    }
}
