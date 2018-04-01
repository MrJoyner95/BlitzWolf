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
            this.panelBarraEstado = new System.Windows.Forms.Panel();
            this.button_Minimizar = new System.Windows.Forms.Button();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.MenuLateral = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Seleccion = new System.Windows.Forms.Panel();
            this.button_MenuLateral = new System.Windows.Forms.Button();
            this.button_PreProcesamiento = new System.Windows.Forms.Button();
            this.button_Archivo = new System.Windows.Forms.Button();
            this.button_Inicio = new System.Windows.Forms.Button();
            this.timerMenuLateral = new System.Windows.Forms.Timer(this.components);
            this.timerMinimizarVentana = new System.Windows.Forms.Timer(this.components);
            this.panelBarraEstado.SuspendLayout();
            this.MenuLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarraEstado
            // 
            this.panelBarraEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
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
            // button_Minimizar
            // 
            this.button_Minimizar.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Minimizar.FlatAppearance.BorderSize = 0;
            this.button_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Minimizar.Image = global::BlitzWolf.Properties.Resources.minimizar2;
            this.button_Minimizar.Location = new System.Drawing.Point(1004, 0);
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
            this.button_Cerrar.Location = new System.Drawing.Point(1050, 0);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(100, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Icono y nombre";
            // 
            // panel_Seleccion
            // 
            this.panel_Seleccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.panel_Seleccion.Location = new System.Drawing.Point(5, 200);
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
            this.button_PreProcesamiento.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PreProcesamiento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_PreProcesamiento.Image = global::BlitzWolf.Properties.Resources.pre_procesamiento;
            this.button_PreProcesamiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_PreProcesamiento.Location = new System.Drawing.Point(15, 292);
            this.button_PreProcesamiento.Name = "button_PreProcesamiento";
            this.button_PreProcesamiento.Size = new System.Drawing.Size(340, 40);
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
            this.button_Archivo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Archivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Archivo.Image = global::BlitzWolf.Properties.Resources.archivo;
            this.button_Archivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Archivo.Location = new System.Drawing.Point(15, 246);
            this.button_Archivo.Name = "button_Archivo";
            this.button_Archivo.Size = new System.Drawing.Size(340, 40);
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
            this.button_Inicio.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Inicio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Inicio.Image = global::BlitzWolf.Properties.Resources.inicio;
            this.button_Inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Inicio.Location = new System.Drawing.Point(15, 200);
            this.button_Inicio.Name = "button_Inicio";
            this.button_Inicio.Size = new System.Drawing.Size(340, 40);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.ControlBox = false;
            this.Controls.Add(this.MenuLateral);
            this.Controls.Add(this.panelBarraEstado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelBarraEstado.ResumeLayout(false);
            this.MenuLateral.ResumeLayout(false);
            this.MenuLateral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraEstado;
        private System.Windows.Forms.Panel MenuLateral;
        private System.Windows.Forms.Button button_PreProcesamiento;
        private System.Windows.Forms.Button button_Archivo;
        private System.Windows.Forms.Button button_Inicio;
        private System.Windows.Forms.Button button_MenuLateral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Seleccion;
        private System.Windows.Forms.Timer timerMenuLateral;
        private System.Windows.Forms.Button button_Minimizar;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.Timer timerMinimizarVentana;
    }
}

