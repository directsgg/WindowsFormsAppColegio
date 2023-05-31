namespace WindowsFormsAppParcial2Colegio
{
    partial class FormListaProfesor
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
            this.buttonVerCursosAsign = new System.Windows.Forms.Button();
            this.dataGridViewProfesor = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfesor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonVerCursosAsign);
            this.groupBox1.Controls.Add(this.dataGridViewProfesor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de profesores:";
            // 
            // buttonVerCursosAsign
            // 
            this.buttonVerCursosAsign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonVerCursosAsign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVerCursosAsign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonVerCursosAsign.Location = new System.Drawing.Point(6, 373);
            this.buttonVerCursosAsign.Name = "buttonVerCursosAsign";
            this.buttonVerCursosAsign.Size = new System.Drawing.Size(106, 47);
            this.buttonVerCursosAsign.TabIndex = 3;
            this.buttonVerCursosAsign.Text = "Ver cursos asignados";
            this.buttonVerCursosAsign.UseVisualStyleBackColor = false;
            this.buttonVerCursosAsign.Click += new System.EventHandler(this.buttonVerCursosAsign_Click);
            // 
            // dataGridViewProfesor
            // 
            this.dataGridViewProfesor.AllowUserToAddRows = false;
            this.dataGridViewProfesor.AllowUserToDeleteRows = false;
            this.dataGridViewProfesor.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfesor.Location = new System.Drawing.Point(6, 20);
            this.dataGridViewProfesor.Name = "dataGridViewProfesor";
            this.dataGridViewProfesor.ReadOnly = true;
            this.dataGridViewProfesor.Size = new System.Drawing.Size(636, 347);
            this.dataGridViewProfesor.TabIndex = 0;
            this.dataGridViewProfesor.Click += new System.EventHandler(this.dataGridViewProfesor_Click);
            // 
            // FormListaProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormListaProfesor";
            this.Text = "Lista de Profesores";
            this.Load += new System.EventHandler(this.FormListaProfesor_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfesor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonVerCursosAsign;
        private System.Windows.Forms.DataGridView dataGridViewProfesor;
    }
}