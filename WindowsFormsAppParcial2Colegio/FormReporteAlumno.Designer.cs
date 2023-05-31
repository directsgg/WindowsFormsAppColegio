namespace WindowsFormsAppParcial2Colegio
{
    partial class FormReporteAlumno
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAsignacion = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignacion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewAsignacion);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 306);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cursos asignados a alumno";
            // 
            // dataGridViewAsignacion
            // 
            this.dataGridViewAsignacion.AllowUserToAddRows = false;
            this.dataGridViewAsignacion.AllowUserToDeleteRows = false;
            this.dataGridViewAsignacion.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewAsignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAsignacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAsignacion.Location = new System.Drawing.Point(3, 17);
            this.dataGridViewAsignacion.Name = "dataGridViewAsignacion";
            this.dataGridViewAsignacion.ReadOnly = true;
            this.dataGridViewAsignacion.Size = new System.Drawing.Size(628, 286);
            this.dataGridViewAsignacion.TabIndex = 0;
            // 
            // FormReporteAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(659, 332);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormReporteAlumno";
            this.Text = "Reporte Alumno";
            this.Load += new System.EventHandler(this.FormReporteAlumno_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewAsignacion;
    }
}