using DataBase;
using DataBase.Modelo;
using DataBase.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeEstudiantes
{
    public partial class FrmRegistro : Form
    {
        RepositorioEstudiante repositorioEstudiante;
        Estudiante EstudianteSeleccionado;
        public FrmRegistro()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection connection = new SqlConnection(ConnectionString);
            repositorioEstudiante = new RepositorioEstudiante(connection);
            InitializeComponent();
        }

        #region Comportamiento de GroupBox
        private void GbFiltrado_Enter(object sender, EventArgs e)
        {
            GbFiltrado.ForeColor = Color.DarkCyan;
        }

        private void GbFiltrado_Leave(object sender, EventArgs e)
        {
            GbFiltrado.ForeColor = Color.Black;
        }
        #endregion

        #region Comportamiento de los Botones
        private void BtnModificar_MouseEnter(object sender, EventArgs e)
        {
            BtnModificar.ForeColor = Color.DarkCyan;
        }

        private void BtnModificar_MouseLeave(object sender, EventArgs e)
        {
            BtnModificar.ForeColor = Color.Black;
        }

        private void BtnEliminar_MouseEnter(object sender, EventArgs e)
        {
            BtnEliminar.ForeColor = Color.DarkCyan;
        }

        private void BtnEliminar_MouseLeave(object sender, EventArgs e)
        {
            BtnEliminar.ForeColor = Color.Black;
        }

        private void BtnAgregar_MouseEnter(object sender, EventArgs e)
        {
            BtnAgregar.ForeColor = Color.DarkCyan;
        }

        private void BtnAgregar_MouseLeave(object sender, EventArgs e)
        {
            BtnAgregar.ForeColor = Color.Black;
        }

        private void BtnDeseleccionar_MouseEnter(object sender, EventArgs e)
        {
            BtnDeseleccionar.ForeColor = Color.DarkCyan;
        }

        private void BtnDeseleccionar_MouseLeave(object sender, EventArgs e)
        {
            BtnDeseleccionar.ForeColor = Color.Black;
        }
        #endregion

        #region Eventos
        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            ListarEstudiantes();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEstudiante();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EliminarEstudiante();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            EditarEstudiante();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarEstudiante();
        }

        private void BtnDeseleccionar_Click(object sender, EventArgs e)
        {
            Deseleccionar();
        }

        private void DgvEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                EstudianteSeleccionado = new Estudiante
                {
                    Codigo = DgvEstudiantes.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    Nombre = DgvEstudiantes.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Apellido = DgvEstudiantes.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Direccion = DgvEstudiantes.Rows[e.RowIndex].Cells[3].Value.ToString(),
                };

                BtnDeseleccionar.Visible = true;
                BtnEliminar.Enabled = true;
                BtnModificar.Enabled = true;
                CargarDatosEditar();
            }
        }
        #endregion

        #region Metodos

        private void ListarEstudiantes()
        {
            DgvEstudiantes.DataSource = repositorioEstudiante.ListarEstudiantes();
            DgvEstudiantes.ClearSelection();
        }

        private void AgregarEstudiante()
        {
            if (TxtCodigo.Text == "" || TxtNombre.Text == "" || TxtApellido.Text == "" || TxtDireccion.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos que se piden", "Notificación");
            }
            else
            {
                Estudiante estudiante = new Estudiante
                {
                    Codigo = TxtCodigo.Text,
                    Nombre = TxtNombre.Text,
                    Apellido = TxtApellido.Text,
                    Direccion = TxtDireccion.Text,
                };

                bool respuesta = repositorioEstudiante.AgregarEstudiante(estudiante);

                if (respuesta == true)
                {
                    MessageBox.Show($"El estudiante {estudiante.Nombre} {estudiante.Apellido} ha sido agregado correctamente", "Notificación");
                    LimpiarCampos();
                    ListarEstudiantes();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error", "Error");
                    LimpiarCampos();
                }
            }
        }

        private void EliminarEstudiante()
        {
                DialogResult result = MessageBox.Show($"¿Esta seguro que desea eliminar el estudiante {EstudianteSeleccionado.Nombre} {EstudianteSeleccionado.Apellido}?", "Advertencia", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    bool respuesta = repositorioEstudiante.EliminarEstudiante(EstudianteSeleccionado.Codigo);

                    if (respuesta == true)
                    {
                        MessageBox.Show($"El estudiante {EstudianteSeleccionado.Nombre} {EstudianteSeleccionado.Apellido} ha sido eliminado correctamente", "Notificación");
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error", "Error");
                    }
                }
            ListarEstudiantes();
            Deseleccionar();
        }

        private void EditarEstudiante()
        {
            if (TxtCodigo.Text == "" || TxtNombre.Text == "" || TxtApellido.Text == "" || TxtDireccion.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos que se piden", "Notificación");
            }
            else
            {
                Estudiante estudiante = new Estudiante
                {
                    Codigo = TxtCodigo.Text,
                    Nombre = TxtNombre.Text,
                    Apellido = TxtApellido.Text,
                    Direccion = TxtDireccion.Text,
                };

                bool respuesta = repositorioEstudiante.ModificarEstudiante(estudiante);

                if (respuesta == true)
                {
                    MessageBox.Show($"El estudiante {estudiante.Nombre} {estudiante.Apellido} ha sido modificado correctamente", "Notificación");
                    LimpiarCampos();
                    ListarEstudiantes();
                    Deseleccionar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error", "Error");
                    LimpiarCampos();
                }
            }
        }

        private void FiltrarEstudiante()
        {
            Estudiante estudiante = new Estudiante
            {
                Codigo = TxtFiltradoEstudiante.Text
            };

            repositorioEstudiante.FiltrarEstudiante(estudiante);

            TxtCodigo.Text = SingletonEstudiante.Instancia.EstudianteFiltrado.Codigo;
            TxtNombre.Text = SingletonEstudiante.Instancia.EstudianteFiltrado.Nombre;
            TxtApellido.Text = SingletonEstudiante.Instancia.EstudianteFiltrado.Apellido;
            TxtDireccion.Text = SingletonEstudiante.Instancia.EstudianteFiltrado.Direccion;

            EstudianteSeleccionado = new Estudiante
            {
                Codigo = TxtCodigo.Text,
                Nombre = TxtNombre.Text,
                Apellido = TxtApellido.Text,
                Direccion = TxtDireccion.Text
            };

            BtnDeseleccionar.Visible = true;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;
        }

        private void LimpiarCampos()
        {
            TxtCodigo.Clear();
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtDireccion.Clear();
            TxtFiltradoEstudiante.Clear();
        }

        private void Deseleccionar()
        {
            LimpiarCampos();
            DgvEstudiantes.ClearSelection();
            BtnDeseleccionar.Visible = false;
            BtnEliminar.Enabled = false;
            BtnModificar.Enabled = false;
            EstudianteSeleccionado = new Estudiante
            {
                Codigo = "",
                Nombre = "",
                Apellido = "",
                Direccion = "",
            };
        }
        #endregion

        #region Comportamiento de TextBox
        private void TxtCodigo_Enter(object sender, EventArgs e)
        {
            LblCodigo.ForeColor = Color.DarkCyan;
        }

        private void TxtCodigo_Leave(object sender, EventArgs e)
        {
            LblCodigo.ForeColor = Color.Black;
        }

        private void TxtNombre_Enter(object sender, EventArgs e)
        {
            LblNombre.ForeColor = Color.DarkCyan;
        }

        private void TxtNombre_Leave(object sender, EventArgs e)
        {
            LblNombre.ForeColor = Color.Black;
        }

        private void TxtApellido_Enter(object sender, EventArgs e)
        {
            LblApellido.ForeColor = Color.DarkCyan;
        }

        private void TxtApellido_Leave(object sender, EventArgs e)
        {
            LblApellido.ForeColor = Color.Black;
        }

        private void TxtDireccion_Enter(object sender, EventArgs e)
        {
            LblDireccion.ForeColor = Color.DarkCyan;
        }

        private void TxtDireccion_Leave(object sender, EventArgs e)
        {
            LblDireccion.ForeColor = Color.Black;
        }

        #endregion


        private void CargarDatosEditar()
        {
            TxtCodigo.Text = EstudianteSeleccionado.Codigo;
            TxtNombre.Text = EstudianteSeleccionado.Nombre;
            TxtApellido.Text = EstudianteSeleccionado.Apellido;
            TxtDireccion.Text = EstudianteSeleccionado.Direccion;
        }
    }
}
