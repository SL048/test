using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketAPI
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddAuthentication("Bearer")
				.AddIdentityServerAuthentication(options =>
				{
					options.Authority = "https://localhost:44343/";
					options.ApiName = "ApiOne";
				});

			services.AddAuthorization();

			services.AddCors(confg =>
				confg.AddPolicy("AllowAll",
					p => p.AllowAnyOrigin()
						.AllowAnyMethod()
						.AllowAnyHeader()));

			services.AddControllers();
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseCors("AllowAll");

			app.UseRouting();

			app.UseAuthentication();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}