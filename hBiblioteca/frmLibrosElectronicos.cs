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
    public partial class frmLibrosElectronicos : Form
    {
        public frmLibrosElectronicos()
        {
            InitializeComponent();
            #region[Agregar encabezados al DataGridView]
            // Agregar encabezados al DataGridView de libros
            dgvLibrosElectronicos.Columns.Add("Titulo", "Título");
            dgvLibrosElectronicos.Columns[0].Width = 200;
            dgvLibrosElectronicos.Columns.Add("Autor", "Autor");
            dgvLibrosElectronicos.Columns[1].Width = 150;
            dgvLibrosElectronicos.Columns.Add("ISBN", "ISBN");
            dgvLibrosElectronicos.Columns[2].Width = 150;
            dgvLibrosElectronicos.Columns.Add("Editorial", "Editorial");
            dgvLibrosElectronicos.Columns[3].Width = 150;
            dgvLibrosElectronicos.Columns.Add("Clasificacion", "Clasificación");
            dgvLibrosElectronicos.Columns[4].Width = 150;
            dgvLibrosElectronicos.Columns.Add("Valor", "Valor");
            dgvLibrosElectronicos.Columns[5].Width = 90;
            dgvLibrosElectronicos.Columns.Add("Estado", "Estado");
            dgvLibrosElectronicos.Columns[6].Width = 90;
            dgvLibrosElectronicos.Columns.Add("Descargas", "Descargas");
            dgvLibrosElectronicos.Columns[7].Width = 90;
            #endregion
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            #region[Agregado de datos al DataGridView]
            //Si los campos están vacíos muestra un mensaje de erorr
            if (string.IsNullOrWhiteSpace(txtTituloE.Text)||
                string.IsNullOrWhiteSpace(txtAutorE.Text)||
                string.IsNullOrWhiteSpace(txtISBNE.Text)||
                string.IsNullOrWhiteSpace(txtClasificacionE.Text)||
                string.IsNullOrWhiteSpace(txtEditorialE.Text)||
                string.IsNullOrWhiteSpace(txtEstadoE.Text)||
                string.IsNullOrWhiteSpace(txtValorE.Text)||
                string.IsNullOrWhiteSpace(txtDescargasE.Text)
                )
            {
                MessageBox.Show("Por favor, llene todos los campos."); 
                return;
            }

            //Convertir el valor a decimal 
            if (!double.TryParse(txtValorE.Text, out double valor))
            {
                MessageBox.Show("Por favor ingrese un valor válido."); 
                return;
            }

            //Convertir las descargas a entero
            if (!int.TryParse(txtDescargasE.Text, out int descargas))
            {
                MessageBox.Show("Por favor, ingrese un numero válido de libros descargados"); 
                return;
            }

            // Crear una instancia clsLibroElectronico
            int numeroDescargas = int.Parse(txtDescargasE.Text);
            clsLibroElectronico LibroElectronico = new clsLibroElectronico(txtTituloE.Text, txtAutorE.Text, txtISBNE.Text, txtEditorialE.Text, txtClasificacionE.Text, Convert.ToDouble(valor), txtEstadoE.Text, numeroDescargas);

            dgvLibrosElectronicos.Rows.Add(LibroElectronico.Titulo, LibroElectronico.Autor, LibroElectronico.ISBN, LibroElectronico.Editorial, LibroElectronico.Clasificacion, LibroElectronico.Valor.ToString("0.00"), LibroElectronico.Estado, LibroElectronico.NumeroDescargas);

            //Limpiar campos
            txtAutorE.Clear();
            txtClasificacionE.Clear();
            txtEstadoE.Clear();
            txtValorE.Clear();
            txtDescargasE.Clear();
            txtEditorialE.Clear();
            txtTituloE.Clear();
            txtISBNE.Clear();
            #endregion
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            #region [Cargar datos desde un archivo plano]
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
                                dgvLibrosElectronicos.Rows.Add(valores[0], valores[1], valores[2], valores[3], valores[4], valores[5], valores[6], valores[7]);
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
            dgvLibrosElectronicos.Rows.Clear();
        }
    }
}
