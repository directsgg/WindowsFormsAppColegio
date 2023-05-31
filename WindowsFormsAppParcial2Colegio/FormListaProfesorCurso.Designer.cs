namespace WindowsFormsAppParcial2Colegio
{
    partial class FormListaProfesorCurso
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
            this.buttonVerAlumnosAsign = new System.Windows.Forms.Button();
            this.dataGridViewProfesorCurso = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfesorCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.groupBox2.Controls.Add(this.buttonVerAlumnosAsign);
            this.groupBox2.Controls.Add(this.dataGridViewProfesorCurso);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.Location = new System.Drawing.Point(14, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(701, 451);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de cursos  ";
            // 
            // buttonVerAlumnosAsign
            // 
            this.buttonVerAlumnosAsign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonVerAlumnosAsign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVerAlumnosAsign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonVerAlumnosAsign.Location = new System.Drawing.Point(5, 396);
            this.buttonVerAlumnosAsign.Name = "buttonVerAlumnosAsign";
            this.buttonVerAlumnosAsign.Size = new System.Drawing.Size(106, 47);
            this.buttonVerAlumnosAsign.TabIndex = 9;
            this.buttonVerAlumnosAsign.Text = "Ver alumnos asignados";
            this.buttonVerAlumnosAsign.UseVisualStyleBackColor = false;
            this.buttonVerAlumnosAsign.Click += new System.EventHandler(this.buttonVerAlumnosAsign_Click);
            // 
            // dataGridViewProfesorCurso
            // 
            this.dataGridViewProfesorCurso.AllowUserToAddRows = false;
            this.dataGridViewProfesorCurso.AllowUserToDeleteRows = false;
            this.dataGridViewProfesorCurso.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewProfesorCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfesorCurso.Location = new System.Drawing.Point(5, 19);
            this.dataGridViewProfesorCurso.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewProfesorCurso.Name = "dataGridViewProfesorCurso";
            this.dataGridViewProfesorCurso.ReadOnly = true;
            this.dataGridViewProfesorCurso.Size = new System.Drawing.Size(691, 369);
            this.dataGridViewProfesorCurso.TabIndex = 8;
            this.dataGridViewProfesorCurso.Click += new System.EventHandler(this.dataGridViewProfesorCurso_Click);
            // 
            // FormListaProfesorCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(732, 481);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormListaProfesorCurso";
            this.Text = "Lista de cursos";
            this.Load += new System.EventHandler(this.FormListaProfesorCurso_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfesorCurso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewProfesorCurso;
        private System.Windows.Forms.Button buttonVerAlumnosAsign;
    }
}