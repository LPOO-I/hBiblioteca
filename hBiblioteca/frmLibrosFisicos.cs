using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hBiblioteca
{
    public partial class frmLibrosFisicos : Form
    {
        public frmLibrosFisicos()
        {
            InitializeComponent();
            #region[Agregar encabezados al DataGridView]
            // Agregar encabezados al DataGridView de libros solo si no existen
            dgvLibrosFisicos.Columns.Add("Titulo", "Título");
            dgvLibrosFisicos.Columns[0].Width = 200;
            dgvLibrosFisicos.Columns.Add("Autor", "Autor");
            dgvLibrosFisicos.Columns[1].Width = 150;
            dgvLibrosFisicos.Columns.Add("ISBN", "ISBN");
            dgvLibrosFisicos.Columns[2].Width = 150;
            dgvLibrosFisicos.Columns.Add("Editorial", "Editorial");
            dgvLibrosFisicos.Columns[3].Width = 150;
            dgvLibrosFisicos.Columns.Add("Clasificacion", "Clasificación");
            dgvLibrosFisicos.Columns[4].Width = 150;
            dgvLibrosFisicos.Columns.Add("Valor", "Valor");
            dgvLibrosFisicos.Columns[5].Width = 90;
            dgvLibrosFisicos.Columns.Add("Estado", "Estado");
            dgvLibrosFisicos.Columns[6].Width = 90;
            dgvLibrosFisicos.Columns.Add("Vendidos", "Vendidos");
            dgvLibrosFisicos.Columns[7].Width = 90;
            #endregion
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            #region[Agregado de datos al DataGridView]
            // Validar los datos ingresados en los controles
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                string.IsNullOrWhiteSpace(txtAutor.Text) ||
                string.IsNullOrWhiteSpace(txtISBN.Text) ||
                string.IsNullOrWhiteSpace(txtEditorial.Text) ||
                string.IsNullOrWhiteSpace(txtClasificacion.Text) ||
                string.IsNullOrWhiteSpace(txtValor.Text) ||
                string.IsNullOrWhiteSpace(txtEstado.Text) ||
                string.IsNullOrWhiteSpace(txtVendidos.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            //convertir el valor a decimal
            if (!double.TryParse(txtValor.Text, out double valor))
            {
                MessageBox.Show("Por favor, ingrese un valor válido.");
                return;
            }

            //convertir los vendidos a entero
            if (!int.TryParse(txtVendidos.Text, out int vendidos))
            {
                MessageBox.Show("Por favor, ingrese un número válido de libros vendidos.");
                return;
            }

            // Crear una nueva instancia de clsLibroFisico
            clsLibroFisico libroFisico = new clsLibroFisico(txtTitulo.Text, txtAutor.Text, txtISBN.Text, txtEditorial.Text, txtClasificacion.Text, valor, txtEstado.Text);

            // Agregar los datos del libro al DataGridView
            dgvLibrosFisicos.Rows.Add(libroFisico.Titulo, libroFisico.Autor, libroFisico.ISBN, libroFisico.Editorial, libroFisico.Clasificacion, libroFisico.Valor.ToString("0.00"), libroFisico.Estado, vendidos);

            // Limpiar los TextBoxes después de agregar la fila
            txtTitulo.Clear();
            txtAutor.Clear();
            txtISBN.Clear();
            txtEditorial.Clear();
            txtClasificacion.Clear();
            txtValor.Clear();
            txtEstado.Clear();
            txtVendidos.Clear();
            #endregion
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            #region[Carga de datos desde un archivo plano]
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader file = new StreamReader(openFileDialog.FileName))
                    {
                        string line;
                        while ((line = file.ReadLine()) != null)
                        {
                            string[] valores = line.Split(';');
                            if (valores.Length == 8)
                            {
                                dgvLibrosFisicos.Rows.Add(valores[0], valores[1], valores[2], valores[3], valores[4], valores[5], valores[6], valores[7]);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer el archivo: " + ex.Message);
                }
            }
            #endregion
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvLibrosFisicos.Rows.Clear();
        }
    }
}
