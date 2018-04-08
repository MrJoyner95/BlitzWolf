namespace BlitzWolf
{
    partial class PopUpConjuntoDeDatos
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
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.label_TituloVentana = new System.Windows.Forms.Label();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.textBox_ValorNuevo = new System.Windows.Forms.TextBox();
            this.textBox_ValorABuscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox_Atributos = new System.Windows.Forms.ComboBox();
            this.panelSuperior.SuspendLayout();
            this.panelInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panelSuperior.Controls.Add(this.label_TituloVentana);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(450, 40);
            this.panelSuperior.TabIndex = 22;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            this.panelSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseMove);
            this.panelSuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseUp);
            // 
            // label_TituloVentana
            // 
            this.label_TituloVentana.AutoSize = true;
            this.label_TituloVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label_TituloVentana.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TituloVentana.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_TituloVentana.Location = new System.Drawing.Point(117, 8);
            this.label_TituloVentana.Name = "label_TituloVentana";
            this.label_TituloVentana.Size = new System.Drawing.Size(217, 24);
            this.label_TituloVentana.TabIndex = 9;
            this.label_TituloVentana.Text = "Buscar y reemplazar";
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panelInferior.Controls.Add(this.button_Cancelar);
            this.panelInferior.Controls.Add(this.button_Guardar);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 210);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(450, 40);
            this.panelInferior.TabIndex = 16;
            // 
            // textBox_ValorNuevo
            // 
            this.textBox_ValorNuevo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox_ValorNuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ValorNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_ValorNuevo.Location = new System.Drawing.Point(8, 173);
            this.textBox_ValorNuevo.Name = "textBox_ValorNuevo";
            this.textBox_ValorNuevo.Size = new System.Drawing.Size(298, 27);
            this.textBox_ValorNuevo.TabIndex = 2;
            // 
            // textBox_ValorABuscar
            // 
            this.textBox_ValorABuscar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox_ValorABuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ValorABuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_ValorABuscar.Location = new System.Drawing.Point(8, 121);
            this.textBox_ValorABuscar.Name = "textBox_ValorABuscar";
            this.textBox_ValorABuscar.Size = new System.Drawing.Size(298, 27);
            this.textBox_ValorABuscar.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(8, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Buscar en el atributo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(8, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Valor a buscar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(8, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Valor nuevo:";
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Cancelar.FlatAppearance.BorderSize = 0;
            this.button_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancelar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Cancelar.Image = global::BlitzWolf.Properties.Resources.no;
            this.button_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Cancelar.Location = new System.Drawing.Point(225, 0);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(225, 40);
            this.button_Cancelar.TabIndex = 5;
            this.button_Cancelar.Text = " Cancelar";
            this.button_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            this.button_Cancelar.MouseEnter += new System.EventHandler(this.button_Cancelar_MouseEnter);
            this.button_Cancelar.MouseLeave += new System.EventHandler(this.button_Cancelar_MouseLeave);
            // 
            // button_Guardar
            // 
            this.button_Guardar.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Guardar.FlatAppearance.BorderSize = 0;
            this.button_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Guardar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Guardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Guardar.Image = global::BlitzWolf.Properties.Resources.ok;
            this.button_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Guardar.Location = new System.Drawing.Point(0, 0);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(225, 40);
            this.button_Guardar.TabIndex = 3;
            this.button_Guardar.Text = " Guardar";
            this.button_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            this.button_Guardar.MouseEnter += new System.EventHandler(this.button_Guardar_MouseEnter);
            this.button_Guardar.MouseLeave += new System.EventHandler(this.button_Guardar_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BlitzWolf.Properties.Resources.logo4;
            this.pictureBox1.Location = new System.Drawing.Point(292, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox_Atributos
            // 
            this.comboBox_Atributos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBox_Atributos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Atributos.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.comboBox_Atributos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboBox_Atributos.FormattingEnabled = true;
            this.comboBox_Atributos.Location = new System.Drawing.Point(8, 70);
            this.comboBox_Atributos.Name = "comboBox_Atributos";
            this.comboBox_Atributos.Size = new System.Drawing.Size(298, 29);
            this.comboBox_Atributos.TabIndex = 0;
            // 
            // PopUpConjuntoDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.comboBox_Atributos);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.textBox_ValorNuevo);
            this.Controls.Add(this.textBox_ValorABuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopUpConjuntoDeDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopUpConjuntoDeDatos";
            this.Load += new System.EventHandler(this.PopUpConjuntoDeDatos_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label label_TituloVentana;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.TextBox textBox_ValorNuevo;
        private System.Windows.Forms.TextBox textBox_ValorABuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox_Atributos;
    }
}