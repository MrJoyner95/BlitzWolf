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
            }
        }

        private void panel_AnalisisBivariable_Paint(object sender, PaintEventArgs e)
        {
            cargaAtributos();
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.button_AgregarInstancia.Enabled = false;
        }

        public void cargaAtributos()
        {
            this.listBox1.Items.Clear();
            if (Global.DataSet_Attributes.Count > 0 && Global.DataSet_Data.Count > 0)
            {
                foreach (Global.Attribute atributo in Global.DataSet_Attributes)
                {
                    this.listBox1.Items.Add(atributo.name);
                }
            }
        }

        int numberOfItem;
        bool InstanciasCargadasEnGrid = false;

        private void listBox1Cargar()
        { 
            try
            {
                string curItem = listBox1.SelectedItem.ToString();
                numberOfItem = listBox1.FindString(curItem);
                foreach (Global.Attribute atributo in Global.DataSet_Attributes)
                {
                    if (curItem == atributo.name)
                    {
                        this.label1.Text = atributo.name;
                        this.label6.Text = atributo.type;
                        if (atributo.type != "numeric")
                        {
                            dataGridView_Instancias.Rows.Clear();
                            this.dataGridView_Instancias.Visible = true;
                            this.GetInstanciasByAtributo(numberOfItem);
                        }
                        else
                        {
                            dataGridView_Instancias.Rows.Clear();
                            this.dataGridView_Instancias.Visible = true;
                            this.GetInstanciasByAtributo(numberOfItem);
                        }
                    }
                }
            }
            catch { }
        }

        private void GetInstanciasByAtributo(int numberColum)
        {
            InstanciasCargadasEnGrid = false;
            List<string> myTem = new List<string>();

            if (Global.DataSet_Attributes.Count > 0 && Global.DataSet_Data.Count > 0)
            {

                dataGridView_Instancias.ColumnCount = 2;
                dataGridView_Instancias.Columns[0].Name = "Etiqueta";

                foreach (string[] instancia in Global.DataSet_Data)
                {
                    myTem.Add(instancia[numberColum]);
                }

                foreach (var grp in myTem.GroupBy(i => i))
                {
                    Console.WriteLine("{0} : {1}", grp.Key, grp.Count());

                    dataGridView_Instancias.Rows.Add(grp.Key, grp.Count());
                }
            }
            else
            {
                MessageBox.Show("El conjunto de datos no cuenta con los valores necesarios para ser mostrado en el Grid.", "Error: No puede mostrarse el conjunto de datos.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                InstanciasCargadasEnGrid = false;
            }
        }


        string type_1, type_2;
        int tipo_1, tipo_2;
        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                string curItem = listBox1.SelectedItem.ToString();
                numberOfItem = listBox1.FindString(curItem);
                listBox1.DoDragDrop(listBox1.SelectedItem.ToString(), DragDropEffects.Copy);
                this.listBox1Cargar();
            }
            catch { }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listBox1Cargar();
        }

        private void Comparar(string TXT_1, string TXT_2)
        {
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Columns.Clear();
            this.ClearALL();

            foreach (Global.Attribute atributo in Global.DataSet_Attributes)
            {
                if (TXT_1 == atributo.name)
                {
                    type_1 = atributo.type;
                }
                if (TXT_2 == atributo.name)
                {
                    type_2 = atributo.type;
                }
            }

            if (type_1 == type_2 && TXT_1 != TXT_2)
            {
                CrearGRID(textBox1.Text, textBox2.Text);
            }
            else
            {
                MessageBox.Show("Los tipos de atributos no coinciden o es el mismo atributo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.ClearALL();
            }
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                textBox1.Clear();
                e.Effect = DragDropEffects.All;
                textBox1.Text = e.Data.GetData(DataFormats.Text).ToString();
                tipo_1 = numberOfItem;
                
            }
            catch { }
        }

        private void textBox2_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                textBox2.Clear();
                e.Effect = DragDropEffects.All;
                textBox2.Text = e.Data.GetData(DataFormats.Text).ToString();
                tipo_2 = numberOfItem;
            }
            catch { }
        }


        int x, y, xy;
        double Sumvarianza_x, desviación_x, varianza_x, media_x;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                this.button_AgregarInstancia.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                this.button_AgregarInstancia.Enabled = true;
            }
        }

        double Sumvarianza_y, desviación_y, varianza_y, media_y;
        double covarienza;
        double perason;
        int numElemento = 0;

        private void CrearGRID(string atri_1, string atri_2)
        {

            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = atri_1 + "  (X)";
            dataGridView1.Columns[1].Name = atri_2 + "  (Y)";
            dataGridView1.Columns[2].Name = "(X^2)(F)";
            dataGridView1.Columns[3].Name = "(Y^2)(F)";
            dataGridView1.Columns[4].Name = "(X)(Y)(F)";

            try
            {

                foreach (string[] instancia in Global.DataSet_Data)
                {

                    x = Int32.Parse(instancia[tipo_1]) * Int32.Parse(instancia[tipo_1]);
                    y = Int32.Parse(instancia[tipo_2]) * Int32.Parse(instancia[tipo_2]);
                    xy = Int32.Parse(instancia[tipo_1]) * Int32.Parse(instancia[tipo_2]);
                    numElemento++;
                    dataGridView1.Rows.Add(instancia[tipo_1], instancia[tipo_2], x, y, xy);
                }
            }
            catch
            {
                this.ClearALL();
                this.dataGridView1.Rows.Clear();
                this.dataGridView1.Columns.Clear();
                MessageBox.Show("Parece que algunos datos no respetan la expresión regular", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
        


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                media_x       += Convert.ToInt32(row.Cells[atri_1 + "  (X)"].Value);
                Sumvarianza_x += Convert.ToInt32(row.Cells["(X^2)(F)"].Value);
                media_y       += Convert.ToInt32(row.Cells[atri_2 + "  (Y)"].Value);
                Sumvarianza_y += Convert.ToInt32(row.Cells["(Y^2)(F)"].Value);
                covarienza    += Convert.ToInt32(row.Cells["(X)(Y)(F)"].Value);
            }

            media_x      = media_x / numElemento;
            label19.Text = Convert.ToString(media_x);
            varianza_x   = (Sumvarianza_x / numElemento) - (Math.Pow(media_x, 2));
            label26.Text = Convert.ToString(varianza_x);
            desviación_x = Math.Sqrt(varianza_x);
            label35.Text = Convert.ToString(desviación_x);

            media_y      = media_y / numElemento;
            label30.Text = Convert.ToString(media_y);
            varianza_y   = (Sumvarianza_y / numElemento) - (Math.Pow(media_y, 2));
            label33.Text = Convert.ToString(varianza_y);
            desviación_y = Math.Sqrt(varianza_y);
            label37.Text = Convert.ToString(desviación_y);

            covarienza   = (covarienza / numElemento) - (media_x) * (media_y);
            label39.Text = Convert.ToString(covarienza);

            perason      = (covarienza) / ((desviación_x) * (desviación_y));
            label41.Text = Convert.ToString(perason);
        }

        private void button_AgregarInstancia_Click_1(object sender, EventArgs e)
        {
            
                this.Comparar(textBox1.Text, textBox2.Text);
        }

        private void ClearALL()
        {
            Sumvarianza_x = 0;
            desviación_x = 0;
            varianza_x = 0;
            media_x = 0;

            Sumvarianza_y = 0;
            desviación_y = 0;
            varianza_y = 0;
            media_y = 0;

            covarienza = 0;
            perason = 0;

            numElemento = 0;

            label19.Text = "...";
            label26.Text = "...";
            label35.Text = "...";
            label30.Text = "...";
            label33.Text = "...";
            label37.Text = "...";
            label39.Text = "...";
            label41.Text = "...";

        }
    }
}
