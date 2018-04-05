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
        

        


    }    
}
