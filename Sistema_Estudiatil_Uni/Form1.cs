namespace Sistema_Estudiatil_Uni
{
    public partial class Form1 : Form
    {
        private List<Estudiante> listaEstudiantes = new List<Estudiante>();
        public Form1()
        {
            InitializeComponent();
            CargarDatosIniciales();
            ActualizarTabla();
        }
        private void CargarDatosIniciales()
        {
            listaEstudiantes.Add(new Estudiante { Nombre = "Andrea Lucia", Edad = 15, Grado = "Primero", Estado = EstadoEstudiante.Regular });
            listaEstudiantes.Add(new Estudiante { Nombre = "Martha Barrantes", Edad = 17, Grado = "Segundo", Estado = EstadoEstudiante.Becado });
        }
        private void ActualizarTabla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaEstudiantes;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var formularioSecundario = new AgregarEstudiante();
            if (formularioSecundario.ShowDialog() == DialogResult.OK)
            {
                listaEstudiantes.Add(formularioSecundario.Estudiante);
                ActualizarTabla();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int indice = dataGridView1.SelectedRows[0].Index;
                var estudianteSeleccionado = listaEstudiantes[indice];

                var formularioSecundario = new AgregarEstudiante(estudianteSeleccionado);
                if (formularioSecundario.ShowDialog() == DialogResult.OK)
                {
                    listaEstudiantes[indice] = formularioSecundario.Estudiante;
                    ActualizarTabla();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
                {
                    listaEstudiantes.RemoveAt(fila.Index);
                }
                ActualizarTabla();
            }
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            var promedioEdad = listaEstudiantes.Average(e => e.Edad);
            var totalPorGrado = listaEstudiantes.GroupBy(e => e.Grado).ToDictionary(g => g.Key, g => g.Count());
            var porcentajeBecados = (double)listaEstudiantes.Count(e => e.Estado == EstadoEstudiante.Becado) / listaEstudiantes.Count * 100;

            MessageBox.Show($"Promedio de edad: {promedioEdad:F2}\n" +
                            $"Total por grado: {string.Join(", ", totalPorGrado.Select(kv => kv.Key + ": " + kv.Value))}\n" +
                            $"Porcentaje de becados: {porcentajeBecados:F2}%");
        }
    }
}
