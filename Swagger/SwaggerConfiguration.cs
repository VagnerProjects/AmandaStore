using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Swagger
{
    public class SwaggerConfiguration
    {
        public static void Configure(IServiceCollection services)
        {
 
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Title = "Amanda Store REST API",
                    Description = "Esta API faz parte dos sistemas desenvolvidos por Vagner",
                    Contact = new OpenApiContact() { Name = "Vagner Developer", Email = "sinxberserker@gmail.com" },
                    License = new OpenApiLicense() { Name = "Vagner", Url = new Uri("https://github.com/VagnerProjects") }
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] {}
                    }
                });

            });
        }
    }
}
