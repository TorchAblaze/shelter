// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.HttpsPolicy;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Logging;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using RestServer.Models;

namespace RestServer
{
  public class Startup
  {
    readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {

      services.AddControllers();
      services.AddDbContext<RestServerContext>(options => options
          .UseMySql(Configuration["ConnectionStrings:DefaultConnection"],
          ServerVersion.AutoDetect(Configuration["ConnectionStrings:DefaultConnection"])));
      services.AddCors(options =>
        {
          options.AddPolicy(name: MyAllowSpecificOrigins,
                builder =>
                {
                  builder.WithOrigins("http://localhost:3000/");
                });
        });
      services.AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "animal_shelter", Version = "v1" });
      });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "animal_shelter v1"));
      }

      app.UseCors(MyAllowSpecificOrigins);

      app.UseHttpsRedirection();

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
