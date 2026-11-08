namespace Ejercicio4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.lst2 = new System.Windows.Forms.ListBox();
            this.btnAniadir = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnTraspasar = new System.Windows.Forms.Button();
            this.txt_texto = new System.Windows.Forms.TextBox();
            this.lblTotales = new System.Windows.Forms.Label();
            this.lblSeleccionados = new System.Windows.Forms.Label();
            this.rbElim1 = new System.Windows.Forms.RadioButton();
            this.rbElim2 = new System.Windows.Forms.RadioButton();
            this.rbTras1 = new System.Windows.Forms.RadioButton();
            this.rbTras2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Location = new System.Drawing.Point(138, 12);
            this.lst1.Name = "lst1";
            this.lst1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst1.Size = new System.Drawing.Size(164, 108);
            this.lst1.TabIndex = 0;
            this.lst1.SelectedIndexChanged += new System.EventHandler(this.lst1_SelectedIndexChanged);
            // 
            // lst2
            // 
            this.lst2.FormattingEnabled = true;
            this.lst2.Location = new System.Drawing.Point(308, 12);
            this.lst2.Name = "lst2";
            this.lst2.Size = new System.Drawing.Size(164, 108);
            this.lst2.TabIndex = 1;
            // 
            // btnAniadir
            // 
            this.btnAniadir.Location = new System.Drawing.Point(12, 38);
            this.btnAniadir.Name = "btnAniadir";
            this.btnAniadir.Size = new System.Drawing.Size(120, 23);
            this.btnAniadir.TabIndex = 2;
            this.btnAniadir.Text = "Añadir";
            this.btnAniadir.UseVisualStyleBackColor = true;
            this.btnAniadir.Click += new System.EventHandler(this.btnAniadir_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(12, 67);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(120, 23);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "Elimina de 1";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnTraspasar
            // 
            this.btnTraspasar.Location = new System.Drawing.Point(12, 96);
            this.btnTraspasar.Name = "btnTraspasar";
            this.btnTraspasar.Size = new System.Drawing.Size(120, 23);
            this.btnTraspasar.TabIndex = 4;
            this.btnTraspasar.Text = "Traspaso 1 -> 2";
            this.btnTraspasar.UseVisualStyleBackColor = true;
            this.btnTraspasar.Click += new System.EventHandler(this.btnTraspasar_Click);
            // 
            // txt_texto
            // 
            this.txt_texto.Location = new System.Drawing.Point(12, 12);
            this.txt_texto.Name = "txt_texto";
            this.txt_texto.Size = new System.Drawing.Size(120, 20);
            this.txt_texto.TabIndex = 5;
            this.txt_texto.Enter += new System.EventHandler(this.txt_texto_Enter);
            // 
            // lblTotales
            // 
            this.lblTotales.AutoSize = true;
            this.lblTotales.Location = new System.Drawing.Point(478, 48);
            this.lblTotales.Name = "lblTotales";
            this.lblTotales.Size = new System.Drawing.Size(35, 13);
            this.lblTotales.TabIndex = 6;
            this.lblTotales.Text = "label1";
            // 
            // lblSeleccionados
            // 
            this.lblSeleccionados.AutoSize = true;
            this.lblSeleccionados.Location = new System.Drawing.Point(478, 61);
            this.lblSeleccionados.Name = "lblSeleccionados";
            this.lblSeleccionados.Size = new System.Drawing.Size(35, 13);
            this.lblSeleccionados.TabIndex = 7;
            this.lblSeleccionados.Text = "label2";
            // 
            // rbElim1
            // 
            this.rbElim1.AutoSize = true;
            this.rbElim1.Checked = true;
            this.rbElim1.Location = new System.Drawing.Point(6, 19);
            this.rbElim1.Name = "rbElim1";
            this.rbElim1.Size = new System.Drawing.Size(56, 17);
            this.rbElim1.TabIndex = 8;
            this.rbElim1.TabStop = true;
            this.rbElim1.Text = "Lista 1";
            this.rbElim1.UseVisualStyleBackColor = true;
            this.rbElim1.CheckedChanged += new System.EventHandler(this.rbElim1_CheckedChanged);
            // 
            // rbElim2
            // 
            this.rbElim2.AutoSize = true;
            this.rbElim2.Location = new System.Drawing.Point(6, 43);
            this.rbElim2.Name = "rbElim2";
            this.rbElim2.Size = new System.Drawing.Size(56, 17);
            this.rbElim2.TabIndex = 9;
            this.rbElim2.Text = "Lista 2";
            this.rbElim2.UseVisualStyleBackColor = true;
            // 
            // rbTras1
            // 
            this.rbTras1.AutoSize = true;
            this.rbTras1.Checked = true;
            this.rbTras1.Location = new System.Drawing.Point(6, 19);
            this.rbTras1.Name = "rbTras1";
            this.rbTras1.Size = new System.Drawing.Size(102, 17);
            this.rbTras1.TabIndex = 10;
            this.rbTras1.TabStop = true;
            this.rbTras1.Text = "Lista 1 -> Lista 2";
            this.rbTras1.UseVisualStyleBackColor = true;
            this.rbTras1.CheckedChanged += new System.EventHandler(this.rbTras1_CheckedChanged);
            // 
            // rbTras2
            // 
            this.rbTras2.AutoSize = true;
            this.rbTras2.Location = new System.Drawing.Point(6, 43);
            this.rbTras2.Name = "rbTras2";
            this.rbTras2.Size = new System.Drawing.Size(102, 17);
            this.rbTras2.TabIndex = 11;
            this.rbTras2.Text = "Lista 2 -> Lista 1";
            this.rbTras2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbElim1);
            this.groupBox1.Controls.Add(this.rbElim2);
            this.groupBox1.Location = new System.Drawing.Point(152, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 70);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbTras1);
            this.groupBox2.Controls.Add(this.rbTras2);
            this.groupBox2.Location = new System.Drawing.Point(308, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 70);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Traspasar";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 213);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSeleccionados);
            this.Controls.Add(this.lblTotales);
            this.Controls.Add(this.txt_texto);
            this.Controls.Add(this.btnTraspasar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAniadir);
            this.Controls.Add(this.lst2);
            this.Controls.Add(this.lst1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.ListBox lst2;
        private System.Windows.Forms.Button btnAniadir;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnTraspasar;
        private System.Windows.Forms.TextBox txt_texto;
        private System.Windows.Forms.Label lblTotales;
        private System.Windows.Forms.Label lblSeleccionados;
        private System.Windows.Forms.RadioButton rbElim1;
        private System.Windows.Forms.RadioButton rbElim2;
        private System.Windows.Forms.RadioButton rbTras1;
        private System.Windows.Forms.RadioButton rbTras2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

