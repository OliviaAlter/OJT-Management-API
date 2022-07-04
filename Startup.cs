using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ojt_management_api.Extensions;

namespace ojt_management_api;

public class Startup
{
    private readonly IConfiguration _configuration;

    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplicationServices(_configuration);
        services.AddControllers();
        //services.AddCors();
        services.AddSwaggerGen();
        services.AddIdentityServices(_configuration);
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Test api v1"));
        }

        app.UseHttpsRedirection();

        app.UseRouting();

        /*
        app.UseCors(policy =>
        {
            policy.AllowAnyHeader()
                .AllowAnyMethod()
                .WithOrigins("https://localhost:4200");
        });
        */

        app.UseAuthentication();

        app.UseAuthorization();

        app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
    }
}