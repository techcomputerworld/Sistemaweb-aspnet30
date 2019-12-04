using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistemawebcf.Models
{
	public class Producto
	{
		public int idproducto { get; set; }
		//llave foranea de categoria
		public int idcategoria { get; set; }
		public string codigo { get; set; }
		public string nombre { get; set; }
		public decimal precio_venta { get; set; }
		public int stock { get; set; }
		public string descripcion { get; set; }
		public bool? estado { get; set; }

		//propiedad de ambito virtual
		public virtual Categoria categoria { get; set; }
	}
}
