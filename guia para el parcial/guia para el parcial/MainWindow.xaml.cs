using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace TuProyecto
{
    public partial class MainWindow : Window
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataAdapter adaptador;
        private DataTable tabla;

        public MainWindow()
        {
            InitializeComponent();

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\leslie\source\repos\WpfApp25\WpfApp25\Database1.mdf;Integrated Security=True";
            conexion = new SqlConnection(connectionString);
            comando = new SqlCommand();
            comando.Connection = conexion;
        }

        private void BtnCargar_Click(object sender, RoutedEventArgs e)
        {
            CargarDatos();
        }

        private void BtnInsertar_Click(object sender, RoutedEventArgs e)
        {
            InsertarRegistro();
        }

        private void BtnActualizar_Click(object sender, RoutedEventArgs e)
        {
            ActualizarRegistro();
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            EliminarRegistro();
        }

        private void CargarDatos()
        {
            string consulta = "SELECT * FROM Tabla";
            adaptador = new SqlDataAdapter(consulta, conexion);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            dataGrid.ItemsSource = tabla.DefaultView;
        }

        private void InsertarRegistro()
        {
            string nombre = txtNombre.Text;
            int edad;

            if (!int.TryParse(txtEdad.Text, out edad))
            {
                MessageBox.Show("La edad debe ser un valor numérico.");
                return;
            }

            string consulta = "INSERT INTO Tabla (Nombre, Edad) VALUES (@Nombre, @Edad)";
            comando.CommandText = consulta;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Edad", edad);

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro insertado correctamente.");
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el registro: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void ActualizarRegistro()
        {
            DataRowView filaSeleccionada = dataGrid.SelectedItem as DataRowView;

            if (filaSeleccionada != null)
            {
                int id = (int)filaSeleccionada["Id"];
                string nombre = txtNombre.Text;
                int edad;

                if (!int.TryParse(txtEdad.Text, out edad))
                {
                    MessageBox.Show("La edad debe ser un valor numérico.");
                    return;
                }

                string consulta = "UPDATE Tabla SET Nombre = @Nombre, Edad = @Edad WHERE Id = @Id";
                comando.CommandText = consulta;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Edad", edad);
                comando.Parameters.AddWithValue("@Id", id);

                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro actualizado correctamente.");
                    CargarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el registro: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro para actualizar.");
            }
        }

        private void EliminarRegistro()
        {
            DataRowView filaSeleccionada = dataGrid.SelectedItem as DataRowView;

            if (filaSeleccionada != null)
            {
                int id = (int)filaSeleccionada["Id"];



            }
        }
    }
}

