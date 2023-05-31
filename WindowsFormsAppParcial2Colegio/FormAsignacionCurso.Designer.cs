namespace WindowsFormsAppParcial2Colegio
{
    partial class FormAsignacionCurso
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxDelegado = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFAsign = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProfesorCurso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAlumno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignacion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.groupBox2.Controls.Add(this.dataGridViewAsignacion);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.Location = new System.Drawing.Point(405, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(701, 451);
            this.groupBox2.TabIndex = 73;
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
            this.dataGridViewAsignacion.DoubleClick += new System.EventHandler(this.dataGridViewAsignacion_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEliminar);
            this.groupBox1.Controls.Add(this.buttonEditar);
            this.groupBox1.Controls.Add(this.comboBoxDelegado);
            this.groupBox1.Controls.Add(this.dateTimePickerFAsign);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonGuardar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxProfesorCurso);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxAlumno);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonCancelar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(381, 451);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignacion de curso";
            // 
            // comboBoxDelegado
            // 
            this.comboBoxDelegado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDelegado.FormattingEnabled = true;
            this.comboBoxDelegado.Location = new System.Drawing.Point(24, 288);
            this.comboBoxDelegado.Name = "comboBoxDelegado";
            this.comboBoxDelegado.Size = new System.Drawing.Size(160, 23);
            this.comboBoxDelegado.TabIndex = 3;
            // 
            // dateTimePickerFAsign
            // 
            this.dateTimePickerFAsign.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFAsign.Location = new System.Drawing.Point(24, 65);
            this.dateTimePickerFAsign.Name = "dateTimePickerFAsign";
            this.dateTimePickerFAsign.Size = new System.Drawing.Size(160, 21);
            this.dateTimePickerFAsign.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 58;
            this.label1.Text = "Fecha asignacion:";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGuardar.Image = global::WindowsFormsAppParcial2Colegio.Properties.Resources.diskette;
            this.buttonGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGuardar.Location = new System.Drawing.Point(10, 353);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonGuardar.Size = new System.Drawing.Size(84, 69);
            this.buttonGuardar.TabIndex = 4;
            this.buttonGuardar.Text = "GUARDAR";
            this.buttonGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 59;
            this.label2.Text = "Profesor y curso:";
            // 
            // textBoxProfesorCurso
            // 
            this.textBoxProfesorCurso.Location = new System.Drawing.Point(26, 207);
            this.textBoxProfesorCurso.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxProfesorCurso.Multiline = true;
            this.textBoxProfesorCurso.Name = "textBoxProfesorCurso";
            this.textBoxProfesorCurso.Size = new System.Drawing.Size(308, 26);
            this.textBoxProfesorCurso.TabIndex = 2;
            this.textBoxProfesorCurso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProfesorCurso_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 61;
            this.label4.Text = "Alumno:";
            // 
            // textBoxAlumno
            // 
            this.textBoxAlumno.Location = new System.Drawing.Point(26, 141);
            this.textBoxAlumno.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxAlumno.Name = "textBoxAlumno";
            this.textBoxAlumno.Size = new System.Drawing.Size(308, 21);
            this.textBoxAlumno.TabIndex = 1;
            this.textBoxAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAlumno_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 270);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 62;
            this.label5.Text = "Estado delegado:";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCancelar.Image = global::WindowsFormsAppParcial2Colegio.Properties.Resources.cancel32;
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCancelar.Location = new System.Drawing.Point(292, 353);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonCancelar.Size = new System.Drawing.Size(84, 69);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEditar.Enabled = false;
            this.buttonEditar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEditar.Image = global::WindowsFormsAppParcial2Colegio.Properties.Resources.edit32;
            this.buttonEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEditar.Location = new System.Drawing.Point(104, 353);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(5);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonEditar.Size = new System.Drawing.Size(84, 69);
            this.buttonEditar.TabIndex = 5;
            this.buttonEditar.Text = "EDITAR";
            this.buttonEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEliminar.Enabled = false;
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEliminar.Image = global::WindowsFormsAppParcial2Colegio.Properties.Resources.delete32;
            this.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEliminar.Location = new System.Drawing.Point(198, 353);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(5);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonEliminar.Size = new System.Drawing.Size(84, 69);
            this.buttonEliminar.TabIndex = 6;
            this.buttonEliminar.Text = "BORRAR";
            this.buttonEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // FormAsignacionCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(1083, 487);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAsignacionCurso";
            this.Text = "Asignacion de Curso";
            this.Load += new System.EventHandler(this.FormAsignacionCurso_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignacion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewAsignacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFAsign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProfesorCurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAlumno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.ComboBox comboBoxDelegado;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
    }
}