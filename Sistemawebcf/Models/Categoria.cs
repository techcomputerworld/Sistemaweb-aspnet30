using System.Collections.Generic;


namespace Sistemawebcf.Models
{
	public class Categoria
	{
		public int idcategoria { get; set; }
		public string nombre { get; set; }
		public string descripcion { get; set; }
		//? esto es para que no nos genere ninguna advertencia creo que permitia valores nulos ?
		public bool? estado { get; set; }
		//una categoria va a tener varios o muchos productos por tanto es 1 a muchos la relación 1:n categoria, productos.
		public virtual ICollection<Producto> Producto { get; set; }
		
	}
}
