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

            // Mueve paneles de detalles (Univariable):
            this.panel_DetallesNominales.Location = new Point(10, 250);
            this.panel_DetallesNumericos.Location = new Point(10, 250);

            // Mueve charts (univariable):
            this.chart_boxPlot.Location = new Point(320, 0);
            this.chart_boxPlot.Size = new Size(710, 610);
            this.chart_nominalBarras.Location = new Point(320, 0);
            this.chart_nominalBarras.Size = new Size(710, 610);

            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Inicialización de variables:

        }

        private void CustomControlPreProcesamiento_Load(object sender, EventArgs e)
        {
            
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




        
        // ******************************************************************************** UNIVARIABLE ********************************************************************************

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

        

        private void comboBox_Atributos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ubica atributo en lista:
            var nombreAtributo = comboBox_Atributos.SelectedItem.ToString();
            Global.Attribute attribute = Global.DataSet_Attributes.Find(x => x.name == nombreAtributo);

            CargarDetallesAtributo(ref attribute);
        }





        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Funciones ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public void InicializarCustomControl()
        {
            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Inicialización de controles:
            // Inicializa comboBox:
            this.comboBox_Atributos.Items.Clear();

            foreach (Global.Attribute attribute in Global.DataSet_Attributes)
            {
                this.comboBox_Atributos.Items.Add(attribute.name);
            }
        }


        public struct nominalValue
        {
            public string value;
            public int count;
        }

        private void CargarDetallesAtributo(ref Global.Attribute attribute)
        {
            if (attribute.type == "nominal")
            {
                //++++++++++++++++++++++++++++++++++++++++++++++++ Nominales ++++++++++++++++++++++++++++++++++++++++++++++++
                this.panel_DetallesNominales.BringToFront();

                //++++++++++++++++++++++++++++++++++++++++ Variables locales:
                // Cantidad atributos erroneos:
                int totalWrongValues = 0;

                // Cantidad atributos faltantes:
                int totalMissingValues = 0;

                // Ubica indice del atributo en lista de atributos:
                int attributeIndex = Global.DataSet_Attributes.IndexOf(attribute);

                // Define lista de atributos:
                List<nominalValue> nominalValuesList = new List<nominalValue>();

                //++++++++++++++++++++++++++++++++++++++++ Conteo de posibles valores:
                // Ubica valores distintos en instancias del atributo en Data:
                foreach (string[] instancia in Global.DataSet_Data)
                {
                    // Inicializa valor:
                    nominalValue nomValue = new nominalValue();
                    nomValue.value = instancia[attributeIndex];
                    nomValue.count = 1;

                    // Comprueba que el valor exista en lista de valores:
                    if(nomValue.value == "" || nomValue.value == " ")
                    {
                        totalMissingValues++;
                    }
                    else if(Global.DataSet_Attributes[attributeIndex].regularExpression.Match(nomValue.value).Success)
                    {
                        // Encuentra valor en lista y su indice:
                        nominalValue nominalValue = nominalValuesList.Find(x => x.value == nomValue.value);

                        if(nominalValue.count >= 1)
                        {
                            // El valor ya existe en la lista, asi que se actualiza:
                            int nominalValueIndex = nominalValuesList.IndexOf(nominalValue);

                            // Obtiene numero contado del elemento original:
                            nomValue.count = nominalValue.count + 1;

                            // Reemplaza valor original:
                            nominalValuesList.Insert(nominalValueIndex, nomValue);
                            nominalValuesList.RemoveAt(nominalValueIndex + 1);
                        }
                        else
                        {
                            nominalValuesList.Add(nomValue);
                        }                                               
                    }                    
                    else
                    {
                        totalWrongValues++;
                    }
                }

                
                Console.WriteLine(("Valores faltantes: " + totalMissingValues));
                Console.WriteLine(("Valores erroneos: " + totalWrongValues));


                


                //++++++++++++++++++++++++++++++++++++++++ Muestra valores:
                this.label_tipo.Text = attribute.type;
                this.label_valoresFaltantes.Text = totalMissingValues.ToString();
                this.label_valoresErroneos.Text = totalWrongValues.ToString();

                this.listView_posiblesValores.Items.Clear();
                foreach (nominalValue nom in nominalValuesList)
                {
                    Console.WriteLine("valor: " + nom.value + ", total:" + nom.count);

                    // Crea y agrega objeto de listView:
                    ListViewItem listViewItem = new ListViewItem(new string[] { nom.value, nom.count.ToString() });
                    this.listView_posiblesValores.Items.Add(listViewItem);
                }

                // Muestra valores en grafica de barras:
                CargarGraficaDeBarras(nominalValuesList);

            }
            else if (attribute.type == "numeric")
            {
                //++++++++++++++++++++++++++++++++++++++++++++++++ Numericos ++++++++++++++++++++++++++++++++++++++++++++++++
                this.panel_DetallesNumericos.BringToFront();

                //++++++++++++++++++++++++++++++++++++++++ Variables locales:
                // Cantidad atributos erroneos:
                int totalWrongValues = 0;

                // Ubica indice del atributo en lista de atributos:
                int attributeIndex = Global.DataSet_Attributes.IndexOf(attribute);

                // Crea lista con valores del atributo en las intancias:
                List<int> attributeValues = new List<int>();

                foreach(string[] instancia in Global.DataSet_Data)
                {
                    try
                    {
                        if (Global.DataSet_Attributes[attributeIndex].regularExpression.Match(instancia[attributeIndex]).Success)
                        {
                            attributeValues.Add(int.Parse(instancia[attributeIndex]));
                        }
                        else
                        {
                            totalWrongValues++;
                        }
                    }
                    catch
                    {
                        totalWrongValues++;
                    }
                }


                foreach(int valor in attributeValues)
                {
                    Console.Write(valor + ",");
                }
                Console.WriteLine();


                int totalMissingValues = Global.DataSet_Data.Count() - attributeValues.Count() - totalWrongValues;
                Console.WriteLine(("Valores faltantes: " + totalMissingValues));
                Console.WriteLine(("Valores erroneos: " + totalWrongValues));

                //++++++++++++++++++++++++++++++++++++++++ Minimo:
                int minimo = attributeValues.Min();
                Console.WriteLine(("Minimo: " + minimo));

                //++++++++++++++++++++++++++++++++++++++++ Maximo:
                int maximo = attributeValues.Max();
                Console.WriteLine(("Maximo: " + maximo));

                //++++++++++++++++++++++++++++++++++++++++ Media:
                double media = attributeValues.Average();
                Console.WriteLine(("Media: " + media));

                //++++++++++++++++++++++++++++++++++++++++ Mediana:
                double mediana;
                int totalValues = attributeValues.Count();
                int halfIndex = attributeValues.Count() / 2;
                var sortedNumbers = attributeValues.OrderBy(n => n);
                
                if ((totalValues % 2) == 0)
                {
                    mediana = ((sortedNumbers.ElementAt(halfIndex) + sortedNumbers.ElementAt((halfIndex - 1))) / 2);
                }
                else
                {
                    mediana = sortedNumbers.ElementAt(halfIndex);
                }
                Console.WriteLine(("Mediana: " + mediana));

                //++++++++++++++++++++++++++++++++++++++++ Moda:
                var moda = attributeValues.GroupBy(n => n).OrderByDescending(g => g.Count()).Select(g => g.Key).FirstOrDefault();
                Console.WriteLine(("Moda: " + moda));

                //++++++++++++++++++++++++++++++++++++++++ Desviacion estandar:
                var desviacionEstandar = Math.Sqrt(attributeValues.Average(v => Math.Pow(v - media, 2)));
                Console.WriteLine(("Desviacion estandar: " + desviacionEstandar));


                //++++++++++++++++++++++++++++++++++++++++ Muestra valores:
                this.label_tipo.Text = attribute.type;
                this.label_valoresFaltantes.Text = totalMissingValues.ToString();
                this.label_valoresErroneos.Text = totalWrongValues.ToString();
                this.label_minimo.Text = minimo.ToString();
                this.label_maximo.Text = maximo.ToString();
                this.label_media.Text = media.ToString();
                this.label_mediana.Text = mediana.ToString();
                this.label_moda.Text = moda.ToString();
                this.label_desviacionEstandar.Text = desviacionEstandar.ToString();

                //++++++++++++++++++++++++++++++++++++++++ Muestra Box Plot:
                CargarBoxPlot(attributeValues, minimo, maximo, mediana);
            }
        }


        private void CargarBoxPlot(List<int> listaValores, int min, int max, double med)
        {
            // Limpia chart:
            this.chart_boxPlot.Series["attributeValues"].Points.Clear();

            // Mueve chart al frente:
            this.chart_boxPlot.BringToFront();

            // Obtiene cuartiles de la lista de valores:
            List<double> cuartiles = Quartiles(listaValores);

            Console.WriteLine("mediana = " + med);
            Console.WriteLine("Q2 = " + cuartiles[1]);

            // Agrega 5 valores principales al Box Plot:
            chart_boxPlot.Series["attributeValues"].Points.AddXY(0, min, max, cuartiles[0], cuartiles[2], med);

            // Agrega el resto de los valores como puntos:
            /*
            foreach (int valor in listaValores)
            {
                if(valor != min && valor != max && valor != cuartiles[0] && valor != cuartiles[2] && valor != med)
                {
                    chart_boxPlot.Series["attributeValues"].Points.AddY(valor);
                }
            }
            */

        }


        private List<double> Quartiles(List<int> afVal)
        {
            int iSize = afVal.Count;
            int iMid = iSize / 2; //this is the mid from a zero based index, eg mid of 7 = 3;

            double fQ1 = 0;
            double fQ2 = 0;
            double fQ3 = 0;

            if (iSize % 2 == 0)
            {
                //================ EVEN NUMBER OF POINTS: =====================
                //even between low and high point
                fQ2 = (afVal[iMid - 1] + afVal[iMid]) / 2;

                int iMidMid = iMid / 2;

                //easy split 
                if (iMid % 2 == 0)
                {
                    fQ1 = (afVal[iMidMid - 1] + afVal[iMidMid]) / 2;
                    fQ3 = (afVal[iMid + iMidMid - 1] + afVal[iMid + iMidMid]) / 2;
                }
                else
                {
                    fQ1 = afVal[iMidMid];
                    fQ3 = afVal[iMidMid + iMid];
                }
            }
            else if (iSize == 1)
            {
                //================= special case, sorry ================
                fQ1 = afVal[0];
                fQ2 = afVal[0];
                fQ3 = afVal[0];
            }
            else
            {
                //odd number so the median is just the midpoint in the array.
                fQ2 = afVal[iMid];

                if ((iSize - 1) % 4 == 0)
                {
                    //======================(4n-1) POINTS =========================
                    int n = (iSize - 1) / 4;
                    fQ1 = (afVal[n - 1] * .25) + (afVal[n] * .75);
                    fQ3 = (afVal[3 * n] * .75) + (afVal[3 * n + 1] * .25);
                }
                else if ((iSize - 3) % 4 == 0)
                {
                    //======================(4n-3) POINTS =========================
                    int n = (iSize - 3) / 4;

                    fQ1 = (afVal[n] * .75) + (afVal[n + 1] * .25);
                    fQ3 = (afVal[3 * n + 1] * .25) + (afVal[3 * n + 2] * .75);
                }
            }


            // Regresa lista:
            List<double> listaCuartiles = new List<double>();
            listaCuartiles.Add(fQ1);
            listaCuartiles.Add(fQ2);
            listaCuartiles.Add(fQ3);

            return listaCuartiles;
        }


        private void CargarGraficaDeBarras(List<nominalValue> valuesList)
        {
            // Limpia chart:
            this.chart_nominalBarras.Series.Clear();

            // Mueve chart al frente:
            this.chart_nominalBarras.BringToFront();

            /*
            // Crea una serie por cada valor nominal:
            for(int x = 0; x < valuesList.Count; x++)
            {
                this.chart_nominalBarras.Series.Add("s" + x.ToString());
                this.chart_nominalBarras.Legends.Add("l" + x.ToString());
            }

            // Muestra valores en series:
            for (int x = 0; x < valuesList.Count; x++)
            {
                this.chart_nominalBarras.Series["s" + x.ToString()].Points.AddXY(x, valuesList[x].count);
                this.chart_nominalBarras.Legends["l" + x.ToString()].Title = valuesList[x].value;
            }
            */

            // Crea una serie por cada valor nominal:
            foreach(nominalValue value in valuesList)
            {
                this.chart_nominalBarras.Series.Add(value.value);
                this.chart_nominalBarras.Legends.Add(value.value);
                // Modifica legend:
                this.chart_nominalBarras.Legends[value.value].BackColor = Color.FromName("ControlDarkDark");
                this.chart_nominalBarras.Legends[value.value].Font = new Font("Century Gothic", 10);
                this.chart_nominalBarras.Legends[value.value].ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            }

            // Muestra valores en series:
            int x = 0;
            foreach (nominalValue value in valuesList)
            {
                this.chart_nominalBarras.Series[value.value].Points.AddXY(x, value.count);
                this.chart_nominalBarras.Legends[value.value].Title = value.value;
                x++;
            }
        }


    }
}
