using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace BlitzWolf
{
    public partial class PopUpModificarAtributo : Form
    {
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Variables Globales ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        Global.Attribute AtributoOriginal;





        public PopUpModificarAtributo(Global.Attribute attribute)
        {
            InitializeComponent();

            // Guarda el atributo original:
            AtributoOriginal = attribute;

            // Inicializa valores del atributo:
            try
            {
                // Muestra valores del atributo en textBoxes:
                textBox_name.Text = attribute.name;
                textBox_type.Text = attribute.type;
                textBox_regularExpression.Text = attribute.regularExpression.ToString();
            }
            catch
            {
                // Crea un nuevo atributo vacio (espacios en lugar de nulls para que no truene el programa):
                Regex regex = new Regex(" ");
                Global.Attribute atributoVacio = new Global.Attribute(" ", " ", regex);
                // Muestra valores del atributo en textBoxes:
                textBox_name.Text = attribute.name;
                textBox_type.Text = attribute.type;
                textBox_regularExpression.Text = attribute.regularExpression.ToString();
            }
        }

        private void PopUpModificarAtributo_Load(object sender, EventArgs e)
        {

        }





        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Eventos ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // ++++++++++++++++++++++++++++++++++++++++ Mover ventana ++++++++++++++++++++++++++++++++++++++++
        bool moviendoVentana = false;
        int posicionMouseEnPanelX;
        int posicionMouseEnPanelY;


        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            // Toma los valores en X y Y del puntero en el panel de barra de estado:
            moviendoVentana = true;
            posicionMouseEnPanelX = panelSuperior.PointToClient(Cursor.Position).X;
            posicionMouseEnPanelY = panelSuperior.PointToClient(Cursor.Position).Y;
        }

        private void panelSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (moviendoVentana == true)
            {
                // Resta la posicion del puntero en X y Y para que la posicion sea la esquina de la ventana:
                this.Location = new Point(Cursor.Position.X - posicionMouseEnPanelX, Cursor.Position.Y - posicionMouseEnPanelY);
            }
        }

        private void panelSuperior_MouseUp(object sender, MouseEventArgs e)
        {
            // La ventana ya no se esta moviendo:
            moviendoVentana = false;
        }



        // ++++++++++++++++++++++++++++++++++++++++ Animaciones de botones ++++++++++++++++++++++++++++++++++++++++
        private void button_Guardar_MouseEnter(object sender, EventArgs e)
        {
            button_Guardar.Image = BlitzWolf.Properties.Resources.ok_A;
            button_Guardar.ForeColor = Color.FromArgb(255, 104, 11);
        }

        private void button_Guardar_MouseLeave(object sender, EventArgs e)
        {
            button_Guardar.Image = BlitzWolf.Properties.Resources.ok;
            button_Guardar.ForeColor = Color.FromName("ControlLightLight");            
        }

        private void button_Cancelar_MouseEnter(object sender, EventArgs e)
        {
            button_Cancelar.Image = BlitzWolf.Properties.Resources.no_A;
            button_Cancelar.ForeColor = Color.FromArgb(255, 104, 11);
        }

        private void button_Cancelar_MouseLeave(object sender, EventArgs e)
        {
            button_Cancelar.Image = BlitzWolf.Properties.Resources.no;
            button_Cancelar.ForeColor = Color.FromName("ControlLightLight");
        }

        // ++++++++++++++++++++++++++++++++++++++++ Acciones de botones ++++++++++++++++++++++++++++++++++++++++

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            // Crea atributo con valores de la ventana:
            Regex regex = new Regex(textBox_regularExpression.Text);
            Global.Attribute attribute = new Global.Attribute(textBox_name.Text, textBox_type.Text, regex);

            // Actualiza atributo:
            bool atributoActualizado = Global.ActualizarAtributo(AtributoOriginal.name, attribute);

            // Interpreta resultado:
            if(atributoActualizado == true)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("No se han podido guardar los nuevos valores del atributo. Por favor, verifique la información ingresada e intente de nuevo.", "Error: Atributo no modificado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            // Atributo Modificado se queda como el original:
            Global.AtributoModificado = false;
            Global.AtributoActualizado = AtributoOriginal;
            this.Close();
        }

        








        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Funciones ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++






    }
}
