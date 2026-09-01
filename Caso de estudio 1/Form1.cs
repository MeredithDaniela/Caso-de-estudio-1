namespace Caso_de_estudio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            //Validar nombre
            if (string.IsNullOrEmpty(textBoxnombre.Text))
            {
                MessageBox.Show(
                    "Por favor escribe tu nombre",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                textBoxnombre.Focus();
            }
            //2.- Obtener las actividades seleccionadas
            List<string> actividades = new List<string>();
            if (checkBoxDep.Checked)
            {
                actividades.Add("Deporte");
            }
            if (checkBoxMus.Checked)
            {
                actividades.Add("Musica");
            }
            if (checkBoxArt.Checked)
            {
                actividades.Add("Arte");
            }
            if (checkBoxPro.Checked)
            {
                actividades.Add("Programación");
            }
            if (checkBoxLec.Checked)
            {
                actividades.Add("Lectura");
            }
            //Almenos una actividad
            if (actividades.Count == 0)
            {
                MessageBox.Show(
                    "Por favor, selecciona al menos una acividad",
                    "validacion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            //==================================================
            //4.- Obtener la modalidad seleccionada
            //==================================================
            string modalidad = "";
            if (radioButtonpre.Checked)
            {
                modalidad = "Precencial";
            }
            else if (radioButtonHib.Checked)
            {
                modalidad = "Hibrida";
            }
            else if (radioButtonLin.Checked)
            {
                modalidad = "En linea";
            }
            else
            {
                MessageBox.Show(
                    "Selecciona una modalidad",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            string resumen =
                "RESUMEN DE PREFERENCIAS\r\n" +
                "--------------------------\r\n" +
                "Nombre: " + textBoxnombre.Text + "\r\n" +
                "Actividades: " + string.Join(",", actividades) + "\r\n" +
                "Modalidad: " + modalidad;
            textBoxResum.Text = resumen;

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Limpiar nombre
            textBoxnombre.Clear();//txtNombre="";
            //Desmarcamos el check box
            checkBoxDep.Checked = false;
            checkBoxMus.Checked = false;
            checkBoxArt.Checked = false;
            checkBoxPro.Checked = false;
            checkBoxLec.Checked = false;
            //desmarcar RADIOBUTTOM
            radioButtonLin.Checked = false;
            radioButtonHib.Checked = false;
            radioButtonpre.Checked = false;
            //Limpiar Resumen
            textBoxResum.Clear();
            //regresamos el culsor al nombre
            textBoxnombre.Focus();
        }
    }
}
