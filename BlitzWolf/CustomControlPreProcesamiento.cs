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
    public partial class CustomControlPreProcesamiento : UserControl
    {
        public CustomControlPreProcesamiento()
        {
            InitializeComponent();

            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Inicializacion de elementos visuales:

            // Mueve paneles a posiciones iniciales:
            this.panel_AnalisisUnivariable.Location = new Point(0, 40);
            this.panel_AnalisisBivariable.Location = new Point(-1100, 40);


            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Inicialización de controles:

            // Inicializa comboBox:
            foreach (Global.Attribute attribute in Global.DataSet_Attributes)
            {
                this.comboBox_Atributos.Items.Add(attribute.name);
            }


            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Inicialización de variables:



        }









        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Movimiento de Paneles ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ 

        private int panelCentrado = 0;
        private bool panelEnMovimiento = false;
        private bool panelesListos = true;


        private void timerMoverPaneles_Tick(object sender, EventArgs e)
        {
            if (panelCentrado == 0) // Analisis Univariable
            {
                // Especifica que los paneles se estan moviendo:
                panelesListos = false;
                // Oculta los demas paneles:
                this.panel_AnalisisBivariable.Visible = false;

                if (panelEnMovimiento == true)
                {
                    // Mueve al panel solo en el eje X:
                    panel_AnalisisUnivariable.Location = new Point(panel_AnalisisUnivariable.Location.X + 50, panel_AnalisisUnivariable.Location.Y);
                    // Comprueba que se haya pasado del punto x = 50:
                    if (panel_AnalisisUnivariable.Location.X >= 50)
                    {
                        panelEnMovimiento = false;
                    }
                }
                else
                {
                    // Se pasa del punto x = 0 y se regresa mas despacio:
                    if (panel_AnalisisUnivariable.Location.X > 0 && panel_AnalisisUnivariable.Location.X <= 50)
                    {
                        panel_AnalisisUnivariable.Location = new Point(panel_AnalisisUnivariable.Location.X - 3, panel_AnalisisUnivariable.Location.Y);
                    }
                    else// Detiene el panel al llegar al punto x = 0:
                    {
                        // Regresa a los demas paneles a la posicion original y los hace visibles:
                        this.panel_AnalisisBivariable.Location = new Point(-1100, panel_AnalisisBivariable.Location.Y);
                        this.panel_AnalisisBivariable.Visible = true;
                        // Paneles terminaron de moverse:
                        panelesListos = true;

                        timerMoverPaneles.Stop();
                    }
                }
            }
            else if (panelCentrado == 1) // Analisis Bivariable
            {
                // Especifica que los paneles se estan moviendo:
                panelesListos = false;
                // Oculta los demas paneles:
                this.panel_AnalisisUnivariable.Visible = false;

                if (panelEnMovimiento == true)
                {
                    // Mueve al panel solo en el eje X:
                    panel_AnalisisBivariable.Location = new Point(panel_AnalisisBivariable.Location.X + 50, panel_AnalisisBivariable.Location.Y);
                    // Comprueba que se haya pasado del punto x = 50:
                    if (panel_AnalisisBivariable.Location.X >= 50)
                    {
                        panelEnMovimiento = false;
                    }
                }
                else
                {
                    // Se pasa del punto x = 0 y se regresa mas despacio:
                    if (panel_AnalisisBivariable.Location.X > 0 && panel_AnalisisBivariable.Location.X <= 50)
                    {
                        panel_AnalisisBivariable.Location = new Point(panel_AnalisisBivariable.Location.X - 3, panel_AnalisisBivariable.Location.Y);
                    }
                    else// Detiene el panel al llegar al punto x = 0:
                    {
                        // Regresa a los demas paneles a la posicion original y los hace visibles:
                        this.panel_AnalisisUnivariable.Location = new Point(-1100, panel_AnalisisUnivariable.Location.Y);
                        this.panel_AnalisisUnivariable.Visible = true;
                        // Paneles terminaron de moverse:
                        panelesListos = true;

                        timerMoverPaneles.Stop();
                    }
                }
            }
        }


        private void MoverPaneles(int panelAMover)
        {
            // Comprueba que el panel a mover no este ya en el centro de la vista:
            if (panelAMover != panelCentrado && panelesListos == true)
            {
                // Mueve panel seleccionado al centro:
                panelCentrado = panelAMover;
                panelEnMovimiento = true;
                timerMoverPaneles.Start();
            }
        }





        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Eventos ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void button_AnalisisUnivariable_Click(object sender, EventArgs e)
        {
            // Cambia color de los botones:
            this.button_AnalisisUnivariable.Image = BlitzWolf.Properties.Resources.univariable_A;
            this.button_AnalisisUnivariable.ForeColor = Color.FromArgb(255, 104, 11);
            this.button_AnalisisBivariable.Image = BlitzWolf.Properties.Resources.bivariable;
            this.button_AnalisisBivariable.ForeColor = Color.White;

            // Mueve panel de seleccion:
            this.panel_Seleccion.Left = this.button_AnalisisUnivariable.Left - 10;

            // Mueve el panel al centro:
            MoverPaneles(0);
        }

        private void button_AnalisisBivariable_Click(object sender, EventArgs e)
        {
            // Cambia color de los botones:
            this.button_AnalisisBivariable.Image = BlitzWolf.Properties.Resources.bivariable_A;
            this.button_AnalisisBivariable.ForeColor = Color.FromArgb(255, 104, 11);
            this.button_AnalisisUnivariable.Image = BlitzWolf.Properties.Resources.univariable;
            this.button_AnalisisUnivariable.ForeColor = Color.White;

            // Mueve panel de seleccion:
            this.panel_Seleccion.Left = this.button_AnalisisBivariable.Left - 10;

            // Mueve el panel al centro:
            MoverPaneles(1);
        }

        private void CustomControlPreProcesamiento_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_Atributos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }





        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Funciones ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void CargarDetallesAtributo(Global.Attribute attribute)
        {
            if(attribute.type == "nominal")
            {
                // 
                // Contabiliza instancias del atributo en Data:
                foreach(string[] instancia in Global.DataSet_Data)
                {

                }
            }
            else if(attribute.type == "numeric")
            {

            }            
        }




    }
}
