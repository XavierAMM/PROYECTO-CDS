using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
	/// <summary>
	/// Clase intermedia entre la CapaDatos.CD_Data y las vistas de la CapaPresentación. Aquí se realizarán las validaciones de los datos enviados antes de ejecutarlos en el SQL Server
	/// </summary>
    public class CN_Validacion
	{		
		private CD_Data objectCD = new CD_Data();
		
		/// <summary>
		/// Este método se utilizará cuando se quiera ejecutar un procedimiento almacenado cuyo dato de retorno es un entero. Puede ser un id, un valor 0 ó 1, un valor negativo, etc.
		/// </summary>
		/// <param name="procedureName">Nombre exacto del procedimiento almacenado de SQL Server</param>
		/// <param name="param">Arreglo de parámetros. Estos tienen que ser los mismos que en el procedimiento almacenado del SqlServer exceptuando aquellos valores output.</param>
		/// <returns>Valor entero del parámetro @result ejecutado en el procedimiento almacenado.</returns>
		/// <exception cref="Exception">Si uno de los parámetros es una cadena de texto y este se encuentra vacío.</exception>
		public int obtenerDatoEntero(string procedureName, CD_Parametros[] param)
		{
			foreach(CD_Parametros i in param)
			{
				if(i.value is string)
				{
					if(i.value == "") throw new Exception("Rellene todos los formularios.");
				}
			}
			return objectCD.CD_ValidacionDatos(procedureName, param);			
		}

		/// <summary>
		/// Este método se utilizará cuando se quiera ejecutar un procedimiento almacenado 
		/// cuyo dato de retorno sea una tabla y se tengan parámetros.
		/// </summary>
		/// <param name="procedureName">Nombre exacto del procedimiento almacenado de SQL Server</param>
		/// <param name="param">Arreglo de parámetros. Estos tienen que ser los mismos que en 
		/// el procedimiento almacenado del SqlServer.</param>
		/// <returns>Una tabla que cumpla con los parámetros requeridos.</returns>
		/// <exception cref="Exception">Si uno de los parámetros es una cadena de texto y 
		/// este se encuentra vacío.</exception>
		public DataTable obtenerTabla(string procedureName, CD_Parametros[] param)
		{
			foreach (CD_Parametros i in param)
			{
				if (i.value is string)
				{
					if (i.value == "") throw new Exception("Rellene todos los formularios.");
				}
			}
			return objectCD.CD_ObtenerTabla(procedureName, param);
		}

		/// <summary>
		/// Este método se utilizará cuando se quiera ejecutar un procedimiento almacenado cuyo proceso sea añadir, editar o eliminar una fila de una tabla.
		/// </summary>
		/// <param name="procedureName">Nombre exacto del procedimiento almacenado de SQL Server</param>
		/// <param name="param">Arreglo de parámetros. Estos tienen que ser los mismos que en el procedimiento almacenado del SqlServer.</param>		
		/// <exception cref="Exception">Si uno de los parámetros es una cadena de texto y este se encuentra vacío.</exception>
		public void actualizarTabla(string procedureName, CD_Parametros[] param)
		{
			foreach (CD_Parametros i in param)
			{
				if (i.value is string)
				{
					if (i.value == "") throw new Exception("Rellene todos los formularios.");
				}				
			}
			objectCD.modificarDatosTabla(procedureName, param);
		}

		/// <summary>
		/// Este método se utilizará cuando se quiera ejecutar un procedimiento almacenado cuyo dato de retorno sea una tabla (sin parámetros).
		/// </summary>		
		/// <returns>Una vista de una tabla.</returns>		
		public DataTable obtenerVistaTabla(string procedureName)
		{
			return objectCD.obtenerVistaTabla(procedureName);
		}
	}
}
