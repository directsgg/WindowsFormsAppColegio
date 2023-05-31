namespace WindowsFormsAppParcial2Colegio
{
    partial class FormModalProfesorCurso
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
            this.dataGridViewProfesorCurso = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfesorCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewProfesorCurso);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 355);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de profesores";
            // 
            // dataGridViewProfesorCurso
            // 
            this.dataGridViewProfesorCurso.AllowUserToAddRows = false;
            this.dataGridViewProfesorCurso.AllowUserToDeleteRows = false;
            this.dataGridViewProfesorCurso.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewProfesorCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfesorCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProfesorCurso.Location = new System.Drawing.Point(3, 17);
            this.dataGridViewProfesorCurso.Name = "dataGridViewProfesorCurso";
            this.dataGridViewProfesorCurso.ReadOnly = true;
            this.dataGridViewProfesorCurso.Size = new System.Drawing.Size(603, 335);
            this.dataGridViewProfesorCurso.TabIndex = 0;
            this.dataGridViewProfesorCurso.DoubleClick += new System.EventHandler(this.dataGridViewProfesorCurso_DoubleClick);
            // 
            // FormModalProfesorCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(647, 390);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormModalProfesorCurso";
            this.Text = "Seleccion de profesor y curso";
            this.Load += new System.EventHandler(this.FormModalProfesorCurso_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfesorCurso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewProfesorCurso;
    }
}