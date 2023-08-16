using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
	/// <summary>
	/// Esta clase realiza la conexión con la base de datos SQL Server inciando el db_server 
	/// y el db_name
	/// </summary>
	internal class CD_Connection
	{
		//private string db_server = "DESKTOP-4D9G9QL";
        private string db_server = "DESKTOP-OTMEVL6\\MSSQLSERVER01";
        private string db_name = "PROYECTO_CDS";
		private SqlConnection DB_Connection;

		/// <summary>
		/// Constructor de la clase. Se inicializa la sentencia de conexión con el db_server 
		/// y el db_name.
		/// </summary>
		public CD_Connection() { 
			DB_Connection = new SqlConnection("Server=" + db_server+ ";Database="+ db_name +";Integrated Security=true");
		}

		/// <summary>
		/// Método para abrir la conexión a la base de datos. Recordar siempre cerrarla 
		/// cuando se finalice.
		/// </summary>
		/// <returns>Un SqlConnection con State abierto (Open).</returns>
		public SqlConnection openConnection()
		{
			if (DB_Connection.State == ConnectionState.Closed)
				DB_Connection.Open();	
			return DB_Connection;
		}

		/// <summary>
		/// Método para cerrar la conexión a la base de datos después de haber sido abierta.
		/// </summary>
		/// <returns>Un SqlConnection con State Cerrado (Closed).</returns>
		public SqlConnection closeConnection()
		{
			if (DB_Connection.State == ConnectionState.Open)
				DB_Connection.Close();
			return DB_Connection;
		}


	}
}
