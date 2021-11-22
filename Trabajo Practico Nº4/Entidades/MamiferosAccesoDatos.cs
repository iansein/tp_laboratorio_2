using Entidades.Clases_Derivadas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Mamifero;

namespace Entidades
{
    public static class MamiferosAcessoDatos
    {
        private static SqlConnection connection;
        private static SqlCommand command;
        private static string connectionString;
        
        /// <summary>
        /// Constructor que genera toda la informacion para conectarse a la base de datos.
        /// </summary>
        static MamiferosAcessoDatos()
        {
            command = new SqlCommand();
            connectionString = "Server = DESKTOP-QDLEB41; Database=TP4-IanSein-Mamiferos; Trusted_Connection=true";
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        /// <summary>
        /// Obtiene toda una lista de la tabla de mamiferos
        /// </summary>
        /// <returns> Lista de mamiferos </returns>
        public static MamiferosARescatar ObtenerTodos()
        {

            MamiferosARescatar mamiferos = new MamiferosARescatar();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM mamiferos";
                SqlDataReader sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    if(sqlDataReader["mamifero"].ToString() == "Delfin")
                    {
                        mamiferos.ListaMamiferos.Add(new Delfin(sqlDataReader["nombre"].ToString(),
                                                 (EUbicacion)Enum.Parse(typeof(EUbicacion), sqlDataReader["ubicacion"].ToString()),
                                                 int.Parse(sqlDataReader["id"].ToString()),
                                                 (ETamanio)Enum.Parse(typeof(ETamanio), sqlDataReader["tamaño"].ToString())));
                    }
                    else if(sqlDataReader["mamifero"].ToString() == "Leon")
                    {
                        mamiferos.ListaMamiferos.Add(new Leon(sqlDataReader["nombre"].ToString(),
                                                 (EUbicacion)Enum.Parse(typeof(EUbicacion), sqlDataReader["ubicacion"].ToString()),
                                                 int.Parse(sqlDataReader["id"].ToString()),
                                                 (ETamanio)Enum.Parse(typeof(ETamanio), sqlDataReader["tamaño"].ToString())));
                    }
                    else if(sqlDataReader["mamifero"].ToString() == "Hipopotamo")
                    {
                        mamiferos.ListaMamiferos.Add(new Hipopotamo(sqlDataReader["nombre"].ToString(),
                                                 (EUbicacion)Enum.Parse(typeof(EUbicacion), sqlDataReader["ubicacion"].ToString()),
                                                 int.Parse(sqlDataReader["id"].ToString()),
                                                 (ETamanio)Enum.Parse(typeof(ETamanio), sqlDataReader["tamaño"].ToString())));
                    }
                    else
                    {
                        mamiferos.ListaMamiferos.Add(new Elefante(sqlDataReader["nombre"].ToString(),
                                                 (EUbicacion)Enum.Parse(typeof(EUbicacion), sqlDataReader["ubicacion"].ToString()),
                                                 int.Parse(sqlDataReader["id"].ToString()),
                                                 (ETamanio)Enum.Parse(typeof(ETamanio), sqlDataReader["tamaño"].ToString())));
                    }
                    
                }

                sqlDataReader.Close();

            }
            catch (Exception ex)
            {
                ex = new Exception("Error al querer leer");
                throw ex;
            }
            finally
            {

                connection.Close();

            }

            return mamiferos;

        }


        /// <summary>
        /// Agrega un mamifero a la tabla de mamiferos
        /// </summary>
        /// <param name="mamifero"> Mamifero a agregar </param>
        /// <returns> True si se pudo, false si no </returns>
        public static bool Agregar(Mamifero mamifero)
        {
            bool validacion = false;

            try
            {
               

                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "INSERT INTO mamiferos (mamifero, nombre, ubicacion, tamaño, id) VALUES (@mamifero, @nombre, @ubicacion, @tamaño, @id)";

                command.Parameters.AddWithValue("@mamifero", mamifero.GetType().Name);
                command.Parameters.AddWithValue("@nombre", mamifero.Nombre);
                command.Parameters.AddWithValue("@ubicacion", mamifero.Ubicacion.ToString());
                command.Parameters.AddWithValue("@tamaño", mamifero.Tamanio.ToString());
                command.Parameters.AddWithValue("@id", mamifero.Id);

                command.ExecuteNonQuery();

                validacion = true;
            }
            catch (Exception ex)
            {
                ex = new Exception("Error al querer agregar");
                throw ex;

            }
            finally
            {
                connection.Close();
            }

            return validacion;

        }

        /// <summary>
        /// Elimina un mamifero de la tabla de mamiferos
        /// </summary>
        /// <param name="mamifero"> Mamifero a eliminar </param>
        /// <returns> True si se pudo o false si no </returns>
        public static bool Eliminar(Mamifero mamifero)
        {
            bool validacion = false;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE FROM mamiferos WHERE id = {mamifero.Id}";
                command.ExecuteNonQuery();

                validacion = true;
            }
            catch (Exception ex)
            {
                ex = new Exception("Error al querer eliminar");
                throw ex;
            }
            finally
            {

                connection.Close();
            }

            return validacion;
        }

        /// <summary>
        /// Modifica un mamifero de la tabla de mamiferos
        /// </summary>
        /// <param name="mamifero"> Mamifero a modificar </param>
        /// <returns> True si se pudo o false si no </returns>
        public static bool Modificar(Mamifero mamifero)
        {
            bool validacion = false;

            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE mamiferos SET mamifero = @mamifero, nombre= @nombre, " +
                                      $"ubicacion = @ubicacion, tamaño = @tamaño, id = @id WHERE id = {mamifero.Id}";
                command.Parameters.AddWithValue("@mamifero", mamifero.GetType().Name);
                command.Parameters.AddWithValue("@nombre", mamifero.Nombre);
                command.Parameters.AddWithValue("@ubicacion", mamifero.Ubicacion.ToString());
                command.Parameters.AddWithValue("@tamaño", mamifero.Tamanio.ToString());
                command.Parameters.AddWithValue("@id", mamifero.Id);

                command.ExecuteNonQuery();

                validacion = true;
            }
            catch (Exception ex)
            {
                ex = new Exception("Error al querer modificar");
                throw ex;
            }
            finally
            {

                connection.Close();

            }


            return validacion;

        }
    }
}
