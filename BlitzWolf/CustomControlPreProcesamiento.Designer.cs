namespace BlitzWolf
{
    partial class CustomControlPreProcesamiento
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
            this.components = new System.ComponentModel.Container();
            this.panel_AnalisisUnivariable = new System.Windows.Forms.Panel();
            this.panel_AnalisisBivariable = new System.Windows.Forms.Panel();
            this.timerMoverPaneles = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Seleccion = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_AnalisisBivariable = new System.Windows.Forms.Button();
            this.button_AnalisisUnivariable = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_AnalisisUnivariable.SuspendLayout();
            this.panel_AnalisisBivariable.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_AnalisisUnivariable
            // 
            this.panel_AnalisisUnivariable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_AnalisisUnivariable.Controls.Add(this.panel2);
            this.panel_AnalisisUnivariable.Location = new System.Drawing.Point(0, 40);
            this.panel_AnalisisUnivariable.Name = "panel_AnalisisUnivariable";
            this.panel_AnalisisUnivariable.Size = new System.Drawing.Size(1040, 620);
            this.panel_AnalisisUnivariable.TabIndex = 31;
            // 
            // panel_AnalisisBivariable
            // 
            this.panel_AnalisisBivariable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_AnalisisBivariable.Controls.Add(this.panel3);
            this.panel_AnalisisBivariable.Location = new System.Drawing.Point(40, 40);
            this.panel_AnalisisBivariable.Name = "panel_AnalisisBivariable";
            this.panel_AnalisisBivariable.Size = new System.Drawing.Size(1040, 620);
            this.panel_AnalisisBivariable.TabIndex = 32;
            // 
            // timerMoverPaneles
            // 
            this.timerMoverPaneles.Interval = 10;
            this.timerMoverPaneles.Tick += new System.EventHandler(this.timerMoverPaneles_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.button_AnalisisBivariable);
            this.panel1.Controls.Add(this.button_AnalisisUnivariable);
            this.panel1.Controls.Add(this.panel_Seleccion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 32);
            this.panel1.TabIndex = 33;
            // 
            // panel_Seleccion
            // 
            this.panel_Seleccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(11)))));
            this.panel_Seleccion.Location = new System.Drawing.Point(275, 0);
            this.panel_Seleccion.Name = "panel_Seleccion";
            this.panel_Seleccion.Size = new System.Drawing.Size(10, 32);
            this.panel_Seleccion.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(430, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Análisis Univariable";
            // 
            // button_AnalisisBivariable
            // 
            this.button_AnalisisBivariable.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_AnalisisBivariable.FlatAppearance.BorderSize = 0;
            this.button_AnalisisBivariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AnalisisBivariable.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AnalisisBivariable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_AnalisisBivariable.Image = global::BlitzWolf.Properties.Resources.bivariable;
            this.button_AnalisisBivariable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_AnalisisBivariable.Location = new System.Drawing.Point(525, 0);
            this.button_AnalisisBivariable.Name = "button_AnalisisBivariable";
            this.button_AnalisisBivariable.Size = new System.Drawing.Size(208, 30);
            this.button_AnalisisBivariable.TabIndex = 27;
            this.button_AnalisisBivariable.Text = " Análisis Bivariable";
            this.button_AnalisisBivariable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_AnalisisBivariable.UseVisualStyleBackColor = true;
            this.button_AnalisisBivariable.Click += new System.EventHandler(this.button_AnalisisBivariable_Click);
            // 
            // button_AnalisisUnivariable
            // 
            this.button_AnalisisUnivariable.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_AnalisisUnivariable.FlatAppearance.BorderSize = 0;
            this.button_AnalisisUnivariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AnalisisUnivariable.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AnalisisUnivariable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(11)))));
            this.button_AnalisisUnivariable.Image = global::BlitzWolf.Properties.Resources.univariable_A;
            this.button_AnalisisUnivariable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_AnalisisUnivariable.Location = new System.Drawing.Point(285, 0);
            this.button_AnalisisUnivariable.Name = "button_AnalisisUnivariable";
            this.button_AnalisisUnivariable.Size = new System.Drawing.Size(221, 30);
            this.button_AnalisisUnivariable.TabIndex = 26;
            this.button_AnalisisUnivariable.Text = " Análisis Univariable";
            this.button_AnalisisUnivariable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_AnalisisUnivariable.UseVisualStyleBackColor = true;
            this.button_AnalisisUnivariable.Click += new System.EventHandler(this.button_AnalisisUnivariable_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 32);
            this.panel2.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1040, 32);
            this.panel3.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(436, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Análisis Bivariable";
            // 
            // CustomControlPreProcesamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_AnalisisUnivariable);
            this.Controls.Add(this.panel_AnalisisBivariable);
            this.Name = "CustomControlPreProcesamiento";
            this.Size = new System.Drawing.Size(1040, 660);
            this.panel_AnalisisUnivariable.ResumeLayout(false);
            this.panel_AnalisisBivariable.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_AnalisisUnivariable;
        private System.Windows.Forms.Panel panel_AnalisisBivariable;
        private System.Windows.Forms.Timer timerMoverPaneles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Seleccion;
        private System.Windows.Forms.Button button_AnalisisBivariable;
        private System.Windows.Forms.Button button_AnalisisUnivariable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
    }
}
