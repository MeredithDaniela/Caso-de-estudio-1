namespace Caso_de_estudio_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new Label();
            textBoxnombre = new TextBox();
            actividades = new GroupBox();
            checkBoxLec = new CheckBox();
            checkBoxPro = new CheckBox();
            checkBoxArt = new CheckBox();
            checkBoxMus = new CheckBox();
            checkBoxDep = new CheckBox();
            Modalidad = new GroupBox();
            radioButtonLin = new RadioButton();
            radioButtonHib = new RadioButton();
            radioButtonpre = new RadioButton();
            btnResumen = new Button();
            btnLimpiar = new Button();
            labelResumen = new Label();
            textBox2 = new TextBox();
            actividades.SuspendLayout();
            Modalidad.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.AutoSize = true;
            txtNombre.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(26, 44);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(146, 19);
            txtNombre.TabIndex = 0;
            txtNombre.Text = "Nombre del alumno:";
            // 
            // textBoxnombre
            // 
            textBoxnombre.Location = new Point(193, 42);
            textBoxnombre.Name = "textBoxnombre";
            textBoxnombre.Size = new Size(245, 23);
            textBoxnombre.TabIndex = 1;
            // 
            // actividades
            // 
            actividades.Controls.Add(checkBoxLec);
            actividades.Controls.Add(checkBoxPro);
            actividades.Controls.Add(checkBoxArt);
            actividades.Controls.Add(checkBoxMus);
            actividades.Controls.Add(checkBoxDep);
            actividades.Location = new Point(12, 89);
            actividades.Name = "actividades";
            actividades.Size = new Size(253, 178);
            actividades.TabIndex = 2;
            actividades.TabStop = false;
            actividades.Text = "Actividades favoritas";
            // 
            // checkBoxLec
            // 
            checkBoxLec.AutoSize = true;
            checkBoxLec.Location = new Point(25, 134);
            checkBoxLec.Name = "checkBoxLec";
            checkBoxLec.Size = new Size(65, 19);
            checkBoxLec.TabIndex = 4;
            checkBoxLec.Text = "Lectura";
            checkBoxLec.UseVisualStyleBackColor = true;
            // 
            // checkBoxPro
            // 
            checkBoxPro.AutoSize = true;
            checkBoxPro.Location = new Point(25, 109);
            checkBoxPro.Name = "checkBoxPro";
            checkBoxPro.Size = new Size(101, 19);
            checkBoxPro.TabIndex = 3;
            checkBoxPro.Text = "Programacion";
            checkBoxPro.UseVisualStyleBackColor = true;
            // 
            // checkBoxArt
            // 
            checkBoxArt.AutoSize = true;
            checkBoxArt.Location = new Point(25, 84);
            checkBoxArt.Name = "checkBoxArt";
            checkBoxArt.Size = new Size(48, 19);
            checkBoxArt.TabIndex = 2;
            checkBoxArt.Text = "Arte";
            checkBoxArt.UseVisualStyleBackColor = true;
            // 
            // checkBoxMus
            // 
            checkBoxMus.AutoSize = true;
            checkBoxMus.Location = new Point(25, 59);
            checkBoxMus.Name = "checkBoxMus";
            checkBoxMus.Size = new Size(64, 19);
            checkBoxMus.TabIndex = 1;
            checkBoxMus.Text = "Musica";
            checkBoxMus.UseVisualStyleBackColor = true;
            // 
            // checkBoxDep
            // 
            checkBoxDep.AutoSize = true;
            checkBoxDep.Location = new Point(25, 34);
            checkBoxDep.Name = "checkBoxDep";
            checkBoxDep.Size = new Size(73, 19);
            checkBoxDep.TabIndex = 0;
            checkBoxDep.Text = "Deportes";
            checkBoxDep.UseVisualStyleBackColor = true;
            // 
            // Modalidad
            // 
            Modalidad.Controls.Add(radioButtonLin);
            Modalidad.Controls.Add(radioButtonHib);
            Modalidad.Controls.Add(radioButtonpre);
            Modalidad.Location = new Point(278, 89);
            Modalidad.Name = "Modalidad";
            Modalidad.Size = new Size(198, 178);
            Modalidad.TabIndex = 3;
            Modalidad.TabStop = false;
            Modalidad.Text = "Modalidad preferida";
            // 
            // radioButtonLin
            // 
            radioButtonLin.AutoSize = true;
            radioButtonLin.Location = new Point(28, 133);
            radioButtonLin.Name = "radioButtonLin";
            radioButtonLin.Size = new Size(66, 19);
            radioButtonLin.TabIndex = 2;
            radioButtonLin.TabStop = true;
            radioButtonLin.Text = "En linea";
            radioButtonLin.UseVisualStyleBackColor = true;
            // 
            // radioButtonHib
            // 
            radioButtonHib.AutoSize = true;
            radioButtonHib.Location = new Point(28, 84);
            radioButtonHib.Name = "radioButtonHib";
            radioButtonHib.Size = new Size(64, 19);
            radioButtonHib.TabIndex = 1;
            radioButtonHib.TabStop = true;
            radioButtonHib.Text = "Hibrida";
            radioButtonHib.UseVisualStyleBackColor = true;
            // 
            // radioButtonpre
            // 
            radioButtonpre.AutoSize = true;
            radioButtonpre.Location = new Point(28, 34);
            radioButtonpre.Name = "radioButtonpre";
            radioButtonpre.Size = new Size(78, 19);
            radioButtonpre.TabIndex = 0;
            radioButtonpre.TabStop = true;
            radioButtonpre.Text = "Presencial";
            radioButtonpre.UseVisualStyleBackColor = true;
            radioButtonpre.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // btnResumen
            // 
            btnResumen.Location = new Point(125, 292);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(140, 29);
            btnResumen.TabIndex = 4;
            btnResumen.Text = "Mostrar Resumen";
            btnResumen.UseVisualStyleBackColor = true;
            btnResumen.Click += btnResumen_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(278, 292);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(83, 29);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // labelResumen
            // 
            labelResumen.AutoSize = true;
            labelResumen.Location = new Point(26, 347);
            labelResumen.Name = "labelResumen";
            labelResumen.Size = new Size(59, 15);
            labelResumen.TabIndex = 6;
            labelResumen.Text = "Resumen:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(26, 365);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(434, 128);
            textBox2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 527);
            Controls.Add(textBox2);
            Controls.Add(labelResumen);
            Controls.Add(btnLimpiar);
            Controls.Add(btnResumen);
            Controls.Add(Modalidad);
            Controls.Add(actividades);
            Controls.Add(textBoxnombre);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Preferencias de actividades";
            actividades.ResumeLayout(false);
            actividades.PerformLayout();
            Modalidad.ResumeLayout(false);
            Modalidad.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtNombre;
        private TextBox textBoxnombre;
        private GroupBox actividades;
        private CheckBox checkBoxLec;
        private CheckBox checkBoxPro;
        private CheckBox checkBoxArt;
        private CheckBox checkBoxMus;
        private CheckBox checkBoxDep;
        private GroupBox Modalidad;
        private RadioButton radioButtonLin;
        private RadioButton radioButtonHib;
        private RadioButton radioButtonpre;
        private Button btnResumen;
        private Button btnLimpiar;
        private Label labelResumen;
        private TextBox textBox2;
    }
}
