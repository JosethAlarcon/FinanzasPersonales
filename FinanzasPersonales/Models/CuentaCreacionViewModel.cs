using Microsoft.AspNetCore.Mvc.Rendering;

namespace FinanzasPersonales.Models
{
	public class CuentaCreacionViewModel: Cuenta
	{
        public IEnumerable<SelectListItem> TiposCuentas { get; set; }
    }
}
