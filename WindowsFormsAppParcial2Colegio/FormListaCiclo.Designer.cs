namespace WindowsFormsAppParcial2Colegio
{
    partial class FormListaCiclo
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
            this.dataGridViewCiclo = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCiclo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonVerCursosAsign);
            this.groupBox1.Controls.Add(this.dataGridViewCiclo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 427);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ciclos ingresados al sistema:";
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
            this.buttonVerCursosAsign.Text = "Ver lista de cursos";
            this.buttonVerCursosAsign.UseVisualStyleBackColor = false;
            this.buttonVerCursosAsign.Click += new System.EventHandler(this.buttonVerCursosAsign_Click);
            // 
            // dataGridViewCiclo
            // 
            this.dataGridViewCiclo.AllowUserToAddRows = false;
            this.dataGridViewCiclo.AllowUserToDeleteRows = false;
            this.dataGridViewCiclo.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewCiclo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCiclo.Location = new System.Drawing.Point(6, 20);
            this.dataGridViewCiclo.Name = "dataGridViewCiclo";
            this.dataGridViewCiclo.ReadOnly = true;
            this.dataGridViewCiclo.Size = new System.Drawing.Size(556, 347);
            this.dataGridViewCiclo.TabIndex = 0;
            this.dataGridViewCiclo.Click += new System.EventHandler(this.dataGridViewCiclo_Click);
            // 
            // FormListaCiclo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(592, 451);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormListaCiclo";
            this.Text = "Lista de Ciclos";
            this.Load += new System.EventHandler(this.FormListaCiclo_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCiclo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonVerCursosAsign;
        private System.Windows.Forms.DataGridView dataGridViewCiclo;
    }
}