using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Estudiatil_Uni
{
    public partial class AgregarEstudiante : Form
    {
        public Estudiante Estudiante { get; private set; }

        public AgregarEstudiante()
        {
            InitializeComponent();
            CargarGrados();
        }
        public AgregarEstudiante(Estudiante estudiante) : this()
        {
            txtNombre.Text = estudiante.Nombre;
            numericUpDown1.Value = estudiante.Edad;
            comboBox1.SelectedItem = estudiante.Grado;
            if (estudiante.Estado == EstadoEstudiante.Becado)
                radioButton1.Checked = true;
            else
                radioButton1.Checked = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Estudiante = new Estudiante
                {
                    Nombre = txtNombre.Text,
                    Edad = (int)numericUpDown1.Value,
                    Grado = comboBox1.SelectedItem.ToString(),
                    Estado = radioButton1.Checked ? EstadoEstudiante.Becado : EstadoEstudiante.Regular
                };
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return false;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un grado.");
                return false;
            }

            if (numericUpDown1.Value < 6 || numericUpDown1.Value > 15)
            {
                MessageBox.Show("La edad debe estar entre 6 y 30 años.");
                return false;
            }

            return true;
        }

        private void CargarGrados()
        {
            comboBox1.Items.AddRange(new string[] { "Primero", "Segundo", "Tercero", "Cuarto", "Quinto", "Sexto" });
        }

    }
}
