using FinanzasPersonales.Validaciones;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FinanzasPersonales.Models
{
	public class TipoCuenta //: IValidatableObject
	{
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [PrimeraLetraMayuscula]
        [Remote(action: "VerificarExisteTipoCuenta", controller: "TiposCuentas")]
        //[StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "La longitud del campo {0} debe estar entre {2} y {1}")]
        //[Display(Name = "Nombre del tipo cuenta")]
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
        public int Orden { get; set; }

		//public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		//{
		//	if (Nombre != null && Nombre.Length > 0)
  //          {
  //              var primeraLetra = Nombre[0].ToString();

  //              if(primeraLetra != primeraLetra.ToUpper())
  //              {
  //                  yield return new ValidationResult("La primera letra debe ser mayuscula");
  //              }
  //          }
		//}
	}
}
