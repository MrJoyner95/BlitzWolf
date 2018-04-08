namespace BlitzWolf
{
    partial class CustomControlInicio
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_Instancias = new System.Windows.Forms.DataGridView();
            this.panel_DatosGenerales = new System.Windows.Forms.Panel();
            this.panel_Detalles = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStripInicio = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarYReemplazartoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Administracion = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_EliminarAtributo = new System.Windows.Forms.Button();
            this.button_AgregarAtributo = new System.Windows.Forms.Button();
            this.button_EliminarInstancia = new System.Windows.Forms.Button();
            this.button_AgregarInstancia = new System.Windows.Forms.Button();
            this.label_DataSet_File = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_DataSet_Name = new System.Windows.Forms.Label();
            this.label_DataSet_MissingValue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label_DataSet_NumberOfAttributes = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label_DataSet_NumberOfInstances = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label_DataSet_ValoresErroneos = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Instancias)).BeginInit();
            this.panel_DatosGenerales.SuspendLayout();
            this.panel_Detalles.SuspendLayout();
            this.menuStripInicio.SuspendLayout();
            this.panel_Administracion.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Instancias
            // 
            this.dataGridView_Instancias.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Instancias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Instancias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Instancias.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Instancias.EnableHeadersVisualStyles = false;
            this.dataGridView_Instancias.Location = new System.Drawing.Point(10, 60);
            this.dataGridView_Instancias.Name = "dataGridView_Instancias";
            this.dataGridView_Instancias.Size = new System.Drawing.Size(760, 590);
            this.dataGridView_Instancias.TabIndex = 1;
            this.dataGridView_Instancias.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Instancias_CellValueChanged);
            this.dataGridView_Instancias.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Instancias_ColumnHeaderMouseDoubleClick);
            this.dataGridView_Instancias.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_Instancias_RowsAdded);
            // 
            // panel_DatosGenerales
            // 
            this.panel_DatosGenerales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel_DatosGenerales.Controls.Add(this.label2);
            this.panel_DatosGenerales.Controls.Add(this.label_DataSet_File);
            this.panel_DatosGenerales.Location = new System.Drawing.Point(10, 35);
            this.panel_DatosGenerales.Name = "panel_DatosGenerales";
            this.panel_DatosGenerales.Size = new System.Drawing.Size(760, 25);
            this.panel_DatosGenerales.TabIndex = 2;
            // 
            // panel_Detalles
            // 
            this.panel_Detalles.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_Detalles.Controls.Add(this.label_DataSet_ValoresErroneos);
            this.panel_Detalles.Controls.Add(this.label15);
            this.panel_Detalles.Controls.Add(this.panel9);
            this.panel_Detalles.Controls.Add(this.label_DataSet_NumberOfInstances);
            this.panel_Detalles.Controls.Add(this.label13);
            this.panel_Detalles.Controls.Add(this.panel8);
            this.panel_Detalles.Controls.Add(this.label_DataSet_NumberOfAttributes);
            this.panel_Detalles.Controls.Add(this.label11);
            this.panel_Detalles.Controls.Add(this.panel7);
            this.panel_Detalles.Controls.Add(this.label_DataSet_MissingValue);
            this.panel_Detalles.Controls.Add(this.label9);
            this.panel_Detalles.Controls.Add(this.panel6);
            this.panel_Detalles.Controls.Add(this.label_DataSet_Name);
            this.panel_Detalles.Controls.Add(this.label4);
            this.panel_Detalles.Controls.Add(this.panel5);
            this.panel_Detalles.Controls.Add(this.panel3);
            this.panel_Detalles.Location = new System.Drawing.Point(780, 35);
            this.panel_Detalles.Name = "panel_Detalles";
            this.panel_Detalles.Size = new System.Drawing.Size(250, 300);
            this.panel_Detalles.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(11)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Detalles del conjunto";
            // 
            // menuStripInicio
            // 
            this.menuStripInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.menuStripInicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStripInicio.Location = new System.Drawing.Point(0, 0);
            this.menuStripInicio.Name = "menuStripInicio";
            this.menuStripInicio.Size = new System.Drawing.Size(1040, 25);
            this.menuStripInicio.TabIndex = 4;
            this.menuStripInicio.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.archivoToolStripMenuItem.Image = global::BlitzWolf.Properties.Resources.archivo;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.abrirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.guardarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.guardarComoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar como...";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarYReemplazartoolStripMenuItem});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Image = global::BlitzWolf.Properties.Resources.dataSet;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(159, 21);
            this.toolStripMenuItem1.Text = "Conjunto de datos";
            // 
            // buscarYReemplazartoolStripMenuItem
            // 
            this.buscarYReemplazartoolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.buscarYReemplazartoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.buscarYReemplazartoolStripMenuItem.Name = "buscarYReemplazartoolStripMenuItem";
            this.buscarYReemplazartoolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.buscarYReemplazartoolStripMenuItem.Text = "Buscar y reemplazar";
            this.buscarYReemplazartoolStripMenuItem.Click += new System.EventHandler(this.buscarYReemplazartoolStripMenuItem_Click);
            // 
            // panel_Administracion
            // 
            this.panel_Administracion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_Administracion.Controls.Add(this.panel4);
            this.panel_Administracion.Controls.Add(this.label6);
            this.panel_Administracion.Controls.Add(this.panel2);
            this.panel_Administracion.Controls.Add(this.label5);
            this.panel_Administracion.Controls.Add(this.panel1);
            this.panel_Administracion.Controls.Add(this.button_EliminarAtributo);
            this.panel_Administracion.Controls.Add(this.button_AgregarAtributo);
            this.panel_Administracion.Controls.Add(this.button_EliminarInstancia);
            this.panel_Administracion.Controls.Add(this.button_AgregarInstancia);
            this.panel_Administracion.Location = new System.Drawing.Point(780, 345);
            this.panel_Administracion.Name = "panel_Administracion";
            this.panel_Administracion.Size = new System.Drawing.Size(250, 305);
            this.panel_Administracion.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(30, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Instancias";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(11)))));
            this.panel2.Location = new System.Drawing.Point(20, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 22);
            this.panel2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(30, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Atributos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(11)))));
            this.panel1.Location = new System.Drawing.Point(20, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 22);
            this.panel1.TabIndex = 8;
            // 
            // button_EliminarAtributo
            // 
            this.button_EliminarAtributo.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_EliminarAtributo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EliminarAtributo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_EliminarAtributo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_EliminarAtributo.Image = global::BlitzWolf.Properties.Resources.eliminarColumna;
            this.button_EliminarAtributo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_EliminarAtributo.Location = new System.Drawing.Point(20, 246);
            this.button_EliminarAtributo.Name = "button_EliminarAtributo";
            this.button_EliminarAtributo.Size = new System.Drawing.Size(210, 40);
            this.button_EliminarAtributo.TabIndex = 5;
            this.button_EliminarAtributo.Text = " Eliminar atributo";
            this.button_EliminarAtributo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_EliminarAtributo.UseVisualStyleBackColor = true;
            this.button_EliminarAtributo.Click += new System.EventHandler(this.button__EliminarAtributo_Click);
            // 
            // button_AgregarAtributo
            // 
            this.button_AgregarAtributo.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_AgregarAtributo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AgregarAtributo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AgregarAtributo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_AgregarAtributo.Image = global::BlitzWolf.Properties.Resources.agregarColumna;
            this.button_AgregarAtributo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_AgregarAtributo.Location = new System.Drawing.Point(20, 200);
            this.button_AgregarAtributo.Name = "button_AgregarAtributo";
            this.button_AgregarAtributo.Size = new System.Drawing.Size(210, 40);
            this.button_AgregarAtributo.TabIndex = 4;
            this.button_AgregarAtributo.Text = " Agregar atributo";
            this.button_AgregarAtributo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_AgregarAtributo.UseVisualStyleBackColor = true;
            this.button_AgregarAtributo.Click += new System.EventHandler(this.button_AgregarAtributo_Click);
            // 
            // button_EliminarInstancia
            // 
            this.button_EliminarInstancia.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_EliminarInstancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EliminarInstancia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_EliminarInstancia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_EliminarInstancia.Image = global::BlitzWolf.Properties.Resources.eliminarFila;
            this.button_EliminarInstancia.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_EliminarInstancia.Location = new System.Drawing.Point(20, 116);
            this.button_EliminarInstancia.Name = "button_EliminarInstancia";
            this.button_EliminarInstancia.Size = new System.Drawing.Size(210, 40);
            this.button_EliminarInstancia.TabIndex = 3;
            this.button_EliminarInstancia.Text = " Eliminar instancia";
            this.button_EliminarInstancia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_EliminarInstancia.UseVisualStyleBackColor = true;
            this.button_EliminarInstancia.Click += new System.EventHandler(this.button_EliminarInstancia_Click);
            // 
            // button_AgregarInstancia
            // 
            this.button_AgregarInstancia.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_AgregarInstancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AgregarInstancia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AgregarInstancia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_AgregarInstancia.Image = global::BlitzWolf.Properties.Resources.agregarFila;
            this.button_AgregarInstancia.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_AgregarInstancia.Location = new System.Drawing.Point(20, 70);
            this.button_AgregarInstancia.Name = "button_AgregarInstancia";
            this.button_AgregarInstancia.Size = new System.Drawing.Size(210, 40);
            this.button_AgregarInstancia.TabIndex = 2;
            this.button_AgregarInstancia.Text = " Agregar instancia";
            this.button_AgregarInstancia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_AgregarInstancia.UseVisualStyleBackColor = true;
            this.button_AgregarInstancia.Click += new System.EventHandler(this.button_AgregarInstancia_Click);
            // 
            // label_DataSet_File
            // 
            this.label_DataSet_File.AutoSize = true;
            this.label_DataSet_File.BackColor = System.Drawing.Color.Transparent;
            this.label_DataSet_File.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DataSet_File.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_DataSet_File.Location = new System.Drawing.Point(56, 5);
            this.label_DataSet_File.Name = "label_DataSet_File";
            this.label_DataSet_File.Size = new System.Drawing.Size(20, 17);
            this.label_DataSet_File.TabIndex = 5;
            this.label_DataSet_File.Text = "...";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 25);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 25);
            this.panel4.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(11)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Administración";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(11)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ruta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(15, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nombre del conjunto:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(11)))));
            this.panel5.Location = new System.Drawing.Point(5, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 22);
            this.panel5.TabIndex = 12;
            // 
            // label_DataSet_Name
            // 
            this.label_DataSet_Name.AutoSize = true;
            this.label_DataSet_Name.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_DataSet_Name.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label_DataSet_Name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_DataSet_Name.Location = new System.Drawing.Point(15, 61);
            this.label_DataSet_Name.Name = "label_DataSet_Name";
            this.label_DataSet_Name.Size = new System.Drawing.Size(21, 19);
            this.label_DataSet_Name.TabIndex = 14;
            this.label_DataSet_Name.Text = "...";
            // 
            // label_DataSet_MissingValue
            // 
            this.label_DataSet_MissingValue.AutoSize = true;
            this.label_DataSet_MissingValue.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_DataSet_MissingValue.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label_DataSet_MissingValue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_DataSet_MissingValue.Location = new System.Drawing.Point(15, 111);
            this.label_DataSet_MissingValue.Name = "label_DataSet_MissingValue";
            this.label_DataSet_MissingValue.Size = new System.Drawing.Size(21, 19);
            this.label_DataSet_MissingValue.TabIndex = 17;
            this.label_DataSet_MissingValue.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(15, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Valor faltante:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(11)))));
            this.panel6.Location = new System.Drawing.Point(5, 90);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 22);
            this.panel6.TabIndex = 15;
            // 
            // label_DataSet_NumberOfAttributes
            // 
            this.label_DataSet_NumberOfAttributes.AutoSize = true;
            this.label_DataSet_NumberOfAttributes.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_DataSet_NumberOfAttributes.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label_DataSet_NumberOfAttributes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_DataSet_NumberOfAttributes.Location = new System.Drawing.Point(15, 161);
            this.label_DataSet_NumberOfAttributes.Name = "label_DataSet_NumberOfAttributes";
            this.label_DataSet_NumberOfAttributes.Size = new System.Drawing.Size(21, 19);
            this.label_DataSet_NumberOfAttributes.TabIndex = 20;
            this.label_DataSet_NumberOfAttributes.Text = "...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(15, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "No. de atributos:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(11)))));
            this.panel7.Location = new System.Drawing.Point(5, 140);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 22);
            this.panel7.TabIndex = 18;
            // 
            // label_DataSet_NumberOfInstances
            // 
            this.label_DataSet_NumberOfInstances.AutoSize = true;
            this.label_DataSet_NumberOfInstances.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_DataSet_NumberOfInstances.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label_DataSet_NumberOfInstances.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_DataSet_NumberOfInstances.Location = new System.Drawing.Point(15, 211);
            this.label_DataSet_NumberOfInstances.Name = "label_DataSet_NumberOfInstances";
            this.label_DataSet_NumberOfInstances.Size = new System.Drawing.Size(21, 19);
            this.label_DataSet_NumberOfInstances.TabIndex = 23;
            this.label_DataSet_NumberOfInstances.Text = "...";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(15, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 21);
            this.label13.TabIndex = 22;
            this.label13.Text = "No. de instancias:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(11)))));
            this.panel8.Location = new System.Drawing.Point(5, 190);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 22);
            this.panel8.TabIndex = 21;
            // 
            // label_DataSet_ValoresErroneos
            // 
            this.label_DataSet_ValoresErroneos.AutoSize = true;
            this.label_DataSet_ValoresErroneos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_DataSet_ValoresErroneos.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label_DataSet_ValoresErroneos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_DataSet_ValoresErroneos.Location = new System.Drawing.Point(15, 261);
            this.label_DataSet_ValoresErroneos.Name = "label_DataSet_ValoresErroneos";
            this.label_DataSet_ValoresErroneos.Size = new System.Drawing.Size(21, 19);
            this.label_DataSet_ValoresErroneos.TabIndex = 26;
            this.label_DataSet_ValoresErroneos.Text = "...";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(15, 240);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(194, 21);
            this.label15.TabIndex = 25;
            this.label15.Text = "No. de valores erroneos:";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(11)))));
            this.panel9.Location = new System.Drawing.Point(5, 240);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 22);
            this.panel9.TabIndex = 24;
            // 
            // CustomControlInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel_Administracion);
            this.Controls.Add(this.panel_Detalles);
            this.Controls.Add(this.panel_DatosGenerales);
            this.Controls.Add(this.dataGridView_Instancias);
            this.Controls.Add(this.menuStripInicio);
            this.Name = "CustomControlInicio";
            this.Size = new System.Drawing.Size(1040, 660);
            this.Load += new System.EventHandler(this.CustomControlInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Instancias)).EndInit();
            this.panel_DatosGenerales.ResumeLayout(false);
            this.panel_DatosGenerales.PerformLayout();
            this.panel_Detalles.ResumeLayout(false);
            this.panel_Detalles.PerformLayout();
            this.menuStripInicio.ResumeLayout(false);
            this.menuStripInicio.PerformLayout();
            this.panel_Administracion.ResumeLayout(false);
            this.panel_Administracion.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_Instancias;
        private System.Windows.Forms.Panel panel_DatosGenerales;
        private System.Windows.Forms.Panel panel_Detalles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStripInicio;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.Panel panel_Administracion;
        private System.Windows.Forms.Button button_EliminarAtributo;
        private System.Windows.Forms.Button button_AgregarAtributo;
        private System.Windows.Forms.Button button_EliminarInstancia;
        private System.Windows.Forms.Button button_AgregarInstancia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarYReemplazartoolStripMenuItem;
        private System.Windows.Forms.Label label_DataSet_File;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label_DataSet_MissingValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label_DataSet_Name;
        private System.Windows.Forms.Label label_DataSet_NumberOfInstances;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label_DataSet_NumberOfAttributes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label_DataSet_ValoresErroneos;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel9;
    }
}
