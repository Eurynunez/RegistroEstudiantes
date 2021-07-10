using DataBase.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Repositorios
{
    public class RepositorioEstudiante
    {
        private SqlConnection _connection;

        public RepositorioEstudiante(SqlConnection connection)
        {
            _connection = connection;
        }

        #region Manipulacion de datos

        public bool AgregarEstudiante(Estudiante item)
        {
            SqlCommand command = new SqlCommand("INSERT INTO ESTUDIANTE (CODIGO, NOMBRE, APELLIDO, DIRECCION) VALUES (@Codigo, @Nombre, @Apellido, @Direccion)", _connection);

            command.Parameters.AddWithValue("@Codigo", item.Codigo);
            command.Parameters.AddWithValue("@Nombre", item.Nombre);
            command.Parameters.AddWithValue("@Apellido", item.Apellido);
            command.Parameters.AddWithValue("@Direccion", item.Direccion);

            return ExecuteDML(command);
        }

        public bool ModificarEstudiante(Estudiante item)
        {
            SqlCommand command = new SqlCommand("UPDATE ESTUDIANTE SET CODIGO = @Codigo, NOMBRE = @Nombre, APELLIDO = @Apellido, @DIRECCION = @Direccion WHERE CODIGO = @Codigo",_connection);

            command.Parameters.AddWithValue("@Id", item.Id);
            command.Parameters.AddWithValue("@Codigo", item.Codigo);
            command.Parameters.AddWithValue("@Nombre", item.Nombre);
            command.Parameters.AddWithValue("@Apellido", item.Apellido);
            command.Parameters.AddWithValue("@Direccion", item.Direccion);

            return ExecuteDML(command);
        }

        public bool EliminarEstudiante(string Codigo)
        {
            SqlCommand command = new SqlCommand("DELETE ESTUDIANTE WHERE CODIGO = @Codigo", _connection);

            command.Parameters.AddWithValue("@Codigo", Codigo);

            return ExecuteDML(command);
        }

        public DataTable ListarEstudiantes()
        {
            SqlDataAdapter query = new SqlDataAdapter("SELECT CODIGO, NOMBRE, APELLIDO, DIRECCION FROM ESTUDIANTE", _connection);

            return CargarData(query);
        }

        public Estudiante FiltrarEstudiante(Estudiante item)
        {
            _connection.Open();

            SqlCommand command = new SqlCommand("SELECT CODIGO, NOMBRE, APELLIDO, DIRECCION FROM ESTUDIANTE WHERE CODIGO = @Codigo", _connection);

            command.Parameters.AddWithValue("@Codigo", item.Codigo);

            SqlDataReader reader = command.ExecuteReader();

            Estudiante estudiante = new Estudiante();

            while (reader.Read())
            {
                estudiante.Codigo = reader.IsDBNull(0) ? "" : reader.GetString(0);
                estudiante.Nombre = reader.IsDBNull(1) ? "" : reader.GetString(1);
                estudiante.Apellido = reader.IsDBNull(2) ? "" : reader.GetString(2);
                estudiante.Direccion = reader.IsDBNull(3) ? "" : reader.GetString(3);

                SingletonEstudiante.Instancia.EstudianteFiltrado = estudiante;
            }

            reader.Close();
            reader.Dispose();

            _connection.Close();

            return estudiante;
        }

        private bool ExecuteDML(SqlCommand command)
        {
            try
            {
                _connection.Open();

                command.ExecuteNonQuery();

                _connection.Close();

                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }

        private DataTable CargarData(SqlDataAdapter Query)
        {
            try
            {
                _connection.Open();

                DataTable data = new DataTable();

                Query.Fill(data);

                _connection.Close();

                return data;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        #endregion
    }
}
