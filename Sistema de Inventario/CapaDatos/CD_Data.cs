using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
	/// <summary>
	/// En esta clase se crean los métodos necesarios para llamar a los procedimientos 
	/// (stored procedures) del SQL Server. Va muy relacionado con la clase 
	/// CapaNegocio.CN_Validacion.
	/// </summary>
    public class CD_Data
	{
		private CD_Connection db_Connection = new CD_Connection();
		private SqlDataAdapter dataAdapter;
		private SqlCommand sqlCommand = new SqlCommand();

		/// <summary>
		/// Este método me permite acceder a un stored procedure cuyo dato de retorno 
		/// @result sea un entero. Cabe recalcar que en SQL Server el valor de retorno 
		/// output siempre debe llamarse "@result".
		/// </summary>
		/// <param name="procedureName">Nombre exacto del procedimiento almacenado en SQL Server.</param>
		/// <param name="parametros">Arreglo de parámetros del stored procedure.</param>
		/// <returns>El valor entero obtenido de la variable @result del Sql Server.</returns>
		public int CD_ValidacionDatos(string procedureName, CD_Parametros[] parametros)
		{			
			SqlCommand command = new SqlCommand();			
			command = commandStoredProcedure(procedureName);
			foreach(CD_Parametros i in parametros)			
				command.Parameters.AddWithValue(i.parameterName, i.value);
			SqlParameter paramResult = getParamResult("@result", command, SqlDbType.Int);			
			db_Connection.closeConnection();
			return (int)paramResult.Value;
		}

		/// <summary>
		/// Este método permite acceder a un stored procedure cuyo proceso haga un SELECT
		/// a una tabla teniendo un parámetro. Por ejemplo: Un procedimiento que me devuelva
		/// un select de usuarios cuyos perfil_id sean 1.
		/// </summary>
		/// <param name="procedureName">Nombre exacto del procedimiento almacenado en SQL Server.</param>
		/// <param name="parametros">Arreglo de parámetros del stored procedure.</param>
		/// <returns>La tabla obtenida con la sentencia SELECT que cumpla con la condición a
		/// partir de sus parámetros.</returns>
		public DataTable CD_ObtenerTabla(string procedureName, CD_Parametros[] parametros)
		{
			SqlCommand command = new SqlCommand();			
			command = commandStoredProcedure(procedureName);
			foreach (CD_Parametros i in parametros)
				command.Parameters.AddWithValue(i.parameterName, i.value);
			DataTable dataTable = dataReaderforDataTable(command);
			db_Connection.closeConnection();
			return dataTable;
		}

		/// <summary>
		/// Este método permite acceder a un stored procedure cuyo proceso haga algún cambio 
		/// a una tabla. Esto puede ser actualizar, añadir o eliminar filas a partir de 
		/// unos parámetros.
		/// </summary>
		/// <param name="procedureName">Nombre exacto del procedimiento almacenado en SQL Server.</param>
		/// <param name="parametros">Arreglo de parámetros del stored procedure.</param>		
		public void modificarDatosTabla(string procedureName, CD_Parametros[] parametros)
		{
			SqlCommand command = new SqlCommand();
			command = commandStoredProcedure(procedureName);
            foreach (CD_Parametros i in parametros)
                command.Parameters.AddWithValue(i.parameterName, i.value);
			command.ExecuteNonQuery();
			db_Connection.closeConnection();
        }

		/// <summary>
		/// Este método permite acceder a un stored procedure cuyo proceso haga un SELECT 
		/// a una tabla. (Sin parámetros).		
		/// </summary>
		/// <param name="procedureName">Nombre exacto del procedimiento almacenado en 
		/// SQL Server.</param>		
		/// <returns>La vista de una tabla obtenida con la sentencia SELECT.</returns>
		public DataTable obtenerVistaTabla(string procedureName)
		{
			SqlCommand command = new SqlCommand();
			command = commandStoredProcedure(procedureName);
			DataTable dataTable = dataReaderforDataTable(command);
			db_Connection.closeConnection();
			return dataTable;
		}

		// ----- Clases Privadas ---- //

		/// <summary>
		/// Este método ejecuta el comando SQL que almacene una tabla a un elemento DataTable.		
		/// </summary>
		/// <param name="command">Objeto SqlCommand con la conexión abierta.</param>		
		/// <returns>La tabla obtenida por el comando SqlCommand.</returns>
		private DataTable dataReaderforDataTable(SqlCommand command)
		{
			SqlDataReader reader = command.ExecuteReader();
			DataTable dataTable = new DataTable();
			dataTable.Load(reader);
			return dataTable;
		}

		/// <summary>
		/// Este método añade la variable resultado "@result" (parameterName) al 
		/// procedimiento almacenado para después ejecutarlo.
		/// </summary>
		/// <param name="parameterName">El nombre del parámetro en el procedimiento 
		/// almacenado (@result).</param>		
		/// <param name="command">Objeto SqlCommand con la conexión abierta.</param>
		/// <param name="type">El tipo de dato que va a retornar @result (será entero).</param>
		/// <returns>El resultado del parámetro @result después de ejecutar el stored procedure.</returns>
		private SqlParameter getParamResult(string parameterName, SqlCommand command, SqlDbType type)
		{			
			SqlParameter paramResult = new SqlParameter(parameterName, type);
			paramResult.Direction = ParameterDirection.Output;
			command.Parameters.Add(paramResult);
			command.ExecuteNonQuery();
			return paramResult;
		}

		/// <summary>
		/// Este método ejecuta el procedimiento almacenado indicado y continúa la cadena de conexión.
		/// </summary>
		/// <param name="procedureName">El nombre del procedimiento almacenado a ejecutar.</param>				
		/// <returns>El comando SqlCommand después de indicarle que ejecutará un stored 
		/// procedure con el nombre del parámetro procedureName.</returns>
		private SqlCommand commandStoredProcedure(string procedureName)
		{			
			SqlCommand command = new SqlCommand();
			command.Connection = db_Connection.openConnection();
			command.CommandText = procedureName;
			command.CommandType = CommandType.StoredProcedure;
			return command;
		}

	}

}
