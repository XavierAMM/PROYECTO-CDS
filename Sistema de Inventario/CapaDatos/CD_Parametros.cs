using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    /// <summary>
    /// Esta clase servirá para indicarle a los stored procedures en el SqlServer qué parámetros 
    /// y con qué valores usará.
    /// </summary>
    public class CD_Parametros
    {
        public string parameterName { get; set; }  // "@usuario_id"
		public object value { get; set; } // "12", "3"

		/// <summary>
		/// Constructor de CD_Parametros. Esta clase servirá para indicarle a los stored procedures en el SqlServer qué parámetros y con qué valores usará.
		/// </summary>
		/// <param name="parameterName">Nombre del parámetro encontrado en el procedimiento almacenado. Ej: "@usuario_id"</param>
		/// <param name="value">Valor a enviar a dicho parámetro al procedimiento almacenado. Ej: 123</param>
		public CD_Parametros(string parameterName, object value)
        {
            this.parameterName = parameterName;
            this.value = value;
        }

    }
}
