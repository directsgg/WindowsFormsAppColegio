namespace WindowsFormsAppParcial2Colegio
{
    partial class FormReporteAsignacion
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAsignacion = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignacion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.groupBox2.Controls.Add(this.dataGridViewAsignacion);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.Location = new System.Drawing.Point(14, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(701, 451);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de  asignaciones";
            // 
            // dataGridViewAsignacion
            // 
            this.dataGridViewAsignacion.AllowUserToAddRows = false;
            this.dataGridViewAsignacion.AllowUserToDeleteRows = false;
            this.dataGridViewAsignacion.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewAsignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAsignacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAsignacion.Location = new System.Drawing.Point(5, 19);
            this.dataGridViewAsignacion.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewAsignacion.Name = "dataGridViewAsignacion";
            this.dataGridViewAsignacion.ReadOnly = true;
            this.dataGridViewAsignacion.Size = new System.Drawing.Size(691, 427);
            this.dataGridViewAsignacion.TabIndex = 8;
            // 
            // FormReporteAsignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(733, 480);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormReporteAsignacion";
            this.Text = "Reporte de asignaciones";
            this.Load += new System.EventHandler(this.FormReporteAsignacion_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewAsignacion;
    }
}