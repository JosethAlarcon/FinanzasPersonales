using AutoMapper;
using FinanzasPersonales.Models;

namespace FinanzasPersonales.Servicios
{
	public class AutoMapperProfile: Profile
	{
		public AutoMapperProfile() 
		{
			CreateMap<Cuenta, CuentaCreacionViewModel>();
		}
	}
}
