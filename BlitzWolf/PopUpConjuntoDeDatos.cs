using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlitzWolf
{
    public partial class PopUpConjuntoDeDatos : Form
    {
        public PopUpConjuntoDeDatos()
        {
            InitializeComponent();

            // Inicializa comboBox:
            foreach(Global.Attribute attribute in Global.DataSet_Attributes)
            {
                this.comboBox_Atributos.Items.Add(attribute.name);
            }
        }

        private void PopUpConjuntoDeDatos_Load(object sender, EventArgs e)
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
            // Ejecuta reemplazo:
            bool reemplazoExitoso = Global.BuscarYReemplazar(comboBox_Atributos.SelectedIndex, textBox_ValorABuscar.Text, textBox_ValorNuevo.Text);
            // Interpreta respuesta:
            if(reemplazoExitoso == true)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("No se ha podido modificar el valor del atributo. Por favor, verifique el valor exista en el atributo ingresada e intente de nuevo.", "Error: Valor no modificado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }






    }
}
