﻿namespace ProyectoPlantillaPersonal.Formularios.Administrador
{
    partial class VistasReportes_Visor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistasReportes_Visor));
            this.dgvVista = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNup = new System.Windows.Forms.TextBox();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRfc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdGenerarVista = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.nudAno = new System.Windows.Forms.NumericUpDown();
            this.radioHasta = new System.Windows.Forms.RadioButton();
            this.radioDesde = new System.Windows.Forms.RadioButton();
            this.comboPlantilla = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarVistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVista)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVista
            // 
            this.dgvVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVista.Location = new System.Drawing.Point(3, 127);
            this.dgvVista.Name = "dgvVista";
            this.dgvVista.Size = new System.Drawing.Size(595, 246);
            this.dgvVista.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Generar vista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NUP";
            // 
            // txtNup
            // 
            this.txtNup.Location = new System.Drawing.Point(40, 41);
            this.txtNup.Name = "txtNup";
            this.txtNup.Size = new System.Drawing.Size(252, 20);
            this.txtNup.TabIndex = 3;
            // 
            // txtCp
            // 
            this.txtCp.Location = new System.Drawing.Point(40, 93);
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(252, 20);
            this.txtCp.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cl. Pr.";
            // 
            // txtRfc
            // 
            this.txtRfc.Location = new System.Drawing.Point(40, 67);
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(252, 20);
            this.txtRfc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "RFC";
            // 
            // cmdGenerarVista
            // 
            this.cmdGenerarVista.Location = new System.Drawing.Point(486, 3);
            this.cmdGenerarVista.Name = "cmdGenerarVista";
            this.cmdGenerarVista.Size = new System.Drawing.Size(103, 23);
            this.cmdGenerarVista.TabIndex = 8;
            this.cmdGenerarVista.Text = "Generar vista";
            this.cmdGenerarVista.UseVisualStyleBackColor = true;
            this.cmdGenerarVista.Click += new System.EventHandler(this.cmdGenerarVista_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.nudAno);
            this.panel2.Controls.Add(this.radioHasta);
            this.panel2.Controls.Add(this.radioDesde);
            this.panel2.Controls.Add(this.comboPlantilla);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dgvVista);
            this.panel2.Controls.Add(this.cmdGenerarVista);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtRfc);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtCp);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtNup);
            this.panel2.Location = new System.Drawing.Point(512, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 378);
            this.panel2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Año";
            // 
            // nudAno
            // 
            this.nudAno.Location = new System.Drawing.Point(384, 40);
            this.nudAno.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudAno.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudAno.Name = "nudAno";
            this.nudAno.Size = new System.Drawing.Size(97, 20);
            this.nudAno.TabIndex = 18;
            this.nudAno.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // radioHasta
            // 
            this.radioHasta.AutoSize = true;
            this.radioHasta.Location = new System.Drawing.Point(313, 54);
            this.radioHasta.Name = "radioHasta";
            this.radioHasta.Size = new System.Drawing.Size(62, 17);
            this.radioHasta.TabIndex = 17;
            this.radioHasta.TabStop = true;
            this.radioHasta.Text = "Hasta...";
            this.radioHasta.UseVisualStyleBackColor = true;
            // 
            // radioDesde
            // 
            this.radioDesde.AutoSize = true;
            this.radioDesde.Location = new System.Drawing.Point(313, 31);
            this.radioDesde.Name = "radioDesde";
            this.radioDesde.Size = new System.Drawing.Size(65, 17);
            this.radioDesde.TabIndex = 16;
            this.radioDesde.TabStop = true;
            this.radioDesde.Text = "Desde...";
            this.radioDesde.UseVisualStyleBackColor = true;
            // 
            // comboPlantilla
            // 
            this.comboPlantilla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPlantilla.FormattingEnabled = true;
            this.comboPlantilla.Items.AddRange(new object[] {
            "Plantilla activa",
            "Plantilla historial"});
            this.comboPlantilla.Location = new System.Drawing.Point(447, 93);
            this.comboPlantilla.Name = "comboPlantilla";
            this.comboPlantilla.Size = new System.Drawing.Size(142, 21);
            this.comboPlantilla.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vistasToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1113, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vistasToolStripMenuItem
            // 
            this.vistasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarVistasToolStripMenuItem});
            this.vistasToolStripMenuItem.Name = "vistasToolStripMenuItem";
            this.vistasToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.vistasToolStripMenuItem.Text = "Vistas";
            // 
            // generarVistasToolStripMenuItem
            // 
            this.generarVistasToolStripMenuItem.Name = "generarVistasToolStripMenuItem";
            this.generarVistasToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.generarVistasToolStripMenuItem.Text = "Generar vistas...";
            this.generarVistasToolStripMenuItem.Click += new System.EventHandler(this.generarVistasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.manualDeUsuarioToolStripMenuItem});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.salirToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            this.manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            this.manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.manualDeUsuarioToolStripMenuItem.Text = "Manual de usuario...";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem1});
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.cerrarSesiónToolStripMenuItem.Text = "Salir";
            // 
            // cerrarSesiónToolStripMenuItem1
            // 
            this.cerrarSesiónToolStripMenuItem1.Name = "cerrarSesiónToolStripMenuItem1";
            this.cerrarSesiónToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.cerrarSesiónToolStripMenuItem1.Text = "Cerrar sesión...";
            this.cerrarSesiónToolStripMenuItem1.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 378);
            this.panel1.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(86, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(354, 32);
            this.label11.TabIndex = 2;
            this.label11.Text = "Benemérito de las Américas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(118, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(286, 32);
            this.label12.TabIndex = 1;
            this.label12.Text = "Ciudad Administrativa ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(201, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // VistasReportes_Visor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 400);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(800, 439);
            this.Name = "VistasReportes_Visor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar vistas/reportes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VistasReportes_FormClosed);
            this.Load += new System.EventHandler(this.VistasReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVista)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNup;
        private System.Windows.Forms.TextBox txtCp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRfc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdGenerarVista;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarVistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudAno;
        private System.Windows.Forms.RadioButton radioHasta;
        private System.Windows.Forms.RadioButton radioDesde;
        private System.Windows.Forms.ComboBox comboPlantilla;
    }
}