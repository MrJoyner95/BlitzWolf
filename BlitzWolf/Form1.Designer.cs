namespace BlitzWolf
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelBarraEstado = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_Minimizar = new System.Windows.Forms.Button();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.MenuLateral = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Seleccion = new System.Windows.Forms.Panel();
            this.button_MenuLateral = new System.Windows.Forms.Button();
            this.button_PreProcesamiento = new System.Windows.Forms.Button();
            this.button_Archivo = new System.Windows.Forms.Button();
            this.button_Inicio = new System.Windows.Forms.Button();
            this.timerMenuLateral = new System.Windows.Forms.Timer(this.components);
            this.timerMinimizarVentana = new System.Windows.Forms.Timer(this.components);
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.customControlInicio1 = new BlitzWolf.CustomControlInicio();
            this.customControlArchivo1 = new BlitzWolf.CustomControlArchivo();
            this.customControlPreProcesamiento1 = new BlitzWolf.CustomControlPreProcesamiento();
            this.button1 = new System.Windows.Forms.Button();
            this.panelBarraEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.MenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarraEstado
            // 
            this.panelBarraEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelBarraEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBarraEstado.Controls.Add(this.button1);
            this.panelBarraEstado.Controls.Add(this.pictureBox2);
            this.panelBarraEstado.Controls.Add(this.button_Minimizar);
            this.panelBarraEstado.Controls.Add(this.button_Cerrar);
            this.panelBarraEstado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraEstado.Location = new System.Drawing.Point(0, 0);
            this.panelBarraEstado.Name = "panelBarraEstado";
            this.panelBarraEstado.Size = new System.Drawing.Size(1100, 40);
            this.panelBarraEstado.TabIndex = 0;
            this.panelBarraEstado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraEstado_MouseDown);
            this.panelBarraEstado.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraEstado_MouseMove);
            this.panelBarraEstado.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelBarraEstado_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BlitzWolf.Properties.Resources.logo4;
            this.pictureBox2.Location = new System.Drawing.Point(10, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // button_Minimizar
            // 
            this.button_Minimizar.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Minimizar.FlatAppearance.BorderSize = 0;
            this.button_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Minimizar.Image = global::BlitzWolf.Properties.Resources.minimizar2;
            this.button_Minimizar.Location = new System.Drawing.Point(1014, 0);
            this.button_Minimizar.Name = "button_Minimizar";
            this.button_Minimizar.Size = new System.Drawing.Size(40, 40);
            this.button_Minimizar.TabIndex = 1;
            this.button_Minimizar.UseVisualStyleBackColor = true;
            this.button_Minimizar.Click += new System.EventHandler(this.button_Minimizar_Click);
            this.button_Minimizar.MouseEnter += new System.EventHandler(this.button_Minimizar_MouseEnter);
            this.button_Minimizar.MouseLeave += new System.EventHandler(this.button_Minimizar_MouseLeave);
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Cerrar.FlatAppearance.BorderSize = 0;
            this.button_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cerrar.Image = global::BlitzWolf.Properties.Resources.apagar;
            this.button_Cerrar.Location = new System.Drawing.Point(1060, 0);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(40, 40);
            this.button_Cerrar.TabIndex = 0;
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            this.button_Cerrar.MouseEnter += new System.EventHandler(this.button_Cerrar_MouseEnter);
            this.button_Cerrar.MouseLeave += new System.EventHandler(this.button_Cerrar_MouseLeave);
            // 
            // MenuLateral
            // 
            this.MenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MenuLateral.Controls.Add(this.pictureBox1);
            this.MenuLateral.Controls.Add(this.label1);
            this.MenuLateral.Controls.Add(this.panel_Seleccion);
            this.MenuLateral.Controls.Add(this.button_MenuLateral);
            this.MenuLateral.Controls.Add(this.button_PreProcesamiento);
            this.MenuLateral.Controls.Add(this.button_Archivo);
            this.MenuLateral.Controls.Add(this.button_Inicio);
            this.MenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuLateral.Location = new System.Drawing.Point(0, 40);
            this.MenuLateral.Name = "MenuLateral";
            this.MenuLateral.Size = new System.Drawing.Size(60, 660);
            this.MenuLateral.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BlitzWolf.Properties.Resources.logo4;
            this.pictureBox1.Location = new System.Drawing.Point(55, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(11)))));
            this.label1.Location = new System.Drawing.Point(56, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Blitz Wolf";
            // 
            // panel_Seleccion
            // 
            this.panel_Seleccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(11)))));
            this.panel_Seleccion.Location = new System.Drawing.Point(5, 240);
            this.panel_Seleccion.Name = "panel_Seleccion";
            this.panel_Seleccion.Size = new System.Drawing.Size(10, 40);
            this.panel_Seleccion.TabIndex = 5;
            // 
            // button_MenuLateral
            // 
            this.button_MenuLateral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_MenuLateral.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_MenuLateral.FlatAppearance.BorderSize = 0;
            this.button_MenuLateral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MenuLateral.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MenuLateral.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_MenuLateral.Image = global::BlitzWolf.Properties.Resources.menuAbrir;
            this.button_MenuLateral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_MenuLateral.Location = new System.Drawing.Point(10, 10);
            this.button_MenuLateral.Name = "button_MenuLateral";
            this.button_MenuLateral.Size = new System.Drawing.Size(40, 40);
            this.button_MenuLateral.TabIndex = 4;
            this.button_MenuLateral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_MenuLateral.UseVisualStyleBackColor = true;
            this.button_MenuLateral.Click += new System.EventHandler(this.button_MenuLateral_Click);
            // 
            // button_PreProcesamiento
            // 
            this.button_PreProcesamiento.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_PreProcesamiento.FlatAppearance.BorderSize = 0;
            this.button_PreProcesamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PreProcesamiento.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PreProcesamiento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_PreProcesamiento.Image = global::BlitzWolf.Properties.Resources.pre_procesamiento;
            this.button_PreProcesamiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_PreProcesamiento.Location = new System.Drawing.Point(15, 332);
            this.button_PreProcesamiento.Name = "button_PreProcesamiento";
            this.button_PreProcesamiento.Size = new System.Drawing.Size(260, 40);
            this.button_PreProcesamiento.TabIndex = 3;
            this.button_PreProcesamiento.Text = "  Pre-procesamiento";
            this.button_PreProcesamiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_PreProcesamiento.UseVisualStyleBackColor = true;
            this.button_PreProcesamiento.Click += new System.EventHandler(this.button_PreProcesamiento_Click);
            // 
            // button_Archivo
            // 
            this.button_Archivo.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Archivo.FlatAppearance.BorderSize = 0;
            this.button_Archivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Archivo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Archivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Archivo.Image = global::BlitzWolf.Properties.Resources.archivo;
            this.button_Archivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Archivo.Location = new System.Drawing.Point(15, 286);
            this.button_Archivo.Name = "button_Archivo";
            this.button_Archivo.Size = new System.Drawing.Size(260, 40);
            this.button_Archivo.TabIndex = 2;
            this.button_Archivo.Text = "  Archivo";
            this.button_Archivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Archivo.UseVisualStyleBackColor = true;
            this.button_Archivo.Click += new System.EventHandler(this.button_Archivo_Click);
            // 
            // button_Inicio
            // 
            this.button_Inicio.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Inicio.FlatAppearance.BorderSize = 0;
            this.button_Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Inicio.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Inicio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Inicio.Image = global::BlitzWolf.Properties.Resources.inicio;
            this.button_Inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Inicio.Location = new System.Drawing.Point(15, 240);
            this.button_Inicio.Name = "button_Inicio";
            this.button_Inicio.Size = new System.Drawing.Size(260, 40);
            this.button_Inicio.TabIndex = 1;
            this.button_Inicio.Text = "  Inicio";
            this.button_Inicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Inicio.UseVisualStyleBackColor = true;
            this.button_Inicio.Click += new System.EventHandler(this.button_Inicio_Click);
            // 
            // timerMenuLateral
            // 
            this.timerMenuLateral.Interval = 10;
            this.timerMenuLateral.Tick += new System.EventHandler(this.timerMenuLateral_Tick);
            // 
            // timerMinimizarVentana
            // 
            this.timerMinimizarVentana.Interval = 10;
            this.timerMinimizarVentana.Tick += new System.EventHandler(this.timerMinimizarVentana_Tick);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelPrincipal.Controls.Add(this.customControlInicio1);
            this.panelPrincipal.Controls.Add(this.customControlArchivo1);
            this.panelPrincipal.Controls.Add(this.customControlPreProcesamiento1);
            this.panelPrincipal.Location = new System.Drawing.Point(60, 40);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1040, 660);
            this.panelPrincipal.TabIndex = 2;
            // 
            // customControlInicio1
            // 
            this.customControlInicio1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.customControlInicio1.Location = new System.Drawing.Point(0, 0);
            this.customControlInicio1.Name = "customControlInicio1";
            this.customControlInicio1.Size = new System.Drawing.Size(1040, 660);
            this.customControlInicio1.TabIndex = 0;
            // 
            // customControlArchivo1
            // 
            this.customControlArchivo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.customControlArchivo1.Location = new System.Drawing.Point(0, 0);
            this.customControlArchivo1.Name = "customControlArchivo1";
            this.customControlArchivo1.Size = new System.Drawing.Size(1040, 660);
            this.customControlArchivo1.TabIndex = 1;
            // 
            // customControlPreProcesamiento1
            // 
            this.customControlPreProcesamiento1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.customControlPreProcesamiento1.Location = new System.Drawing.Point(0, 0);
            this.customControlPreProcesamiento1.Name = "customControlPreProcesamiento1";
            this.customControlPreProcesamiento1.Size = new System.Drawing.Size(1040, 660);
            this.customControlPreProcesamiento1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Abrir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.ControlBox = false;
            this.Controls.Add(this.MenuLateral);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelBarraEstado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blitz Wolf";
            this.panelBarraEstado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.MenuLateral.ResumeLayout(false);
            this.MenuLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraEstado;
        private System.Windows.Forms.Panel MenuLateral;
        private System.Windows.Forms.Button button_PreProcesamiento;
        private System.Windows.Forms.Button button_Archivo;
        private System.Windows.Forms.Button button_Inicio;
        private System.Windows.Forms.Button button_MenuLateral;
        private System.Windows.Forms.Panel panel_Seleccion;
        private System.Windows.Forms.Timer timerMenuLateral;
        private System.Windows.Forms.Button button_Minimizar;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.Timer timerMinimizarVentana;
        private System.Windows.Forms.Panel panelPrincipal;
        private CustomControlInicio customControlInicio1;
        private CustomControlArchivo customControlArchivo1;
        private CustomControlPreProcesamiento customControlPreProcesamiento1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}

