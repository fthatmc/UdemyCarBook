using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Services
{
    //mediatr ile gelen özellik sürekli program.cs de registration yapmamak için
    //builder.Services.AddApplicationService(builder.Configuration); program.cs tarafı
    public static class ServiceRegistiration
	{
		public static void AddApplicationService(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ServiceRegistiration).Assembly));
		}
	}
}
