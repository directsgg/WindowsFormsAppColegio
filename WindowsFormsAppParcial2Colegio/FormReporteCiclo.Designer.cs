namespace WindowsFormsAppParcial2Colegio
{
    partial class FormReporteCiclo
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
            this.dataGridViewProfesorCurso = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfesorCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.groupBox2.Controls.Add(this.dataGridViewProfesorCurso);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.Location = new System.Drawing.Point(14, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(552, 267);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de cursos asignados a profesores";
            // 
            // dataGridViewProfesorCurso
            // 
            this.dataGridViewProfesorCurso.AllowUserToAddRows = false;
            this.dataGridViewProfesorCurso.AllowUserToDeleteRows = false;
            this.dataGridViewProfesorCurso.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewProfesorCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfesorCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProfesorCurso.Location = new System.Drawing.Point(5, 19);
            this.dataGridViewProfesorCurso.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewProfesorCurso.Name = "dataGridViewProfesorCurso";
            this.dataGridViewProfesorCurso.ReadOnly = true;
            this.dataGridViewProfesorCurso.Size = new System.Drawing.Size(542, 243);
            this.dataGridViewProfesorCurso.TabIndex = 8;
            // 
            // FormReporteCiclo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(580, 297);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormReporteCiclo";
            this.Text = "FormReporteCiclo";
            this.Load += new System.EventHandler(this.FormReporteCiclo_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfesorCurso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewProfesorCurso;
    }
}