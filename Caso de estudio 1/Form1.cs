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
                    MessageBoxIcon.Warning );
            }
        }
    }
}
