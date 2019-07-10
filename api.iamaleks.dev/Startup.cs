namespace Api
{
    using Api.Infrastructure;

    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc.ApplicationModels;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.OpenApi.Models;

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers()
                    .AddNewtonsoftJson();

            services.AddRouting(options => options.LowercaseUrls = true);
            services.AddMvc(options => options.Conventions.Add(new RouteTokenTransformerConvention(new SlugifyParameterTransformer())));

            services.AddSwaggerGen(options => options.SwaggerDoc("v1",
                                                                 new OpenApiInfo
                                                                 {
                                                                     Title = "iamaleks.dev API",
                                                                     Version = "v1"
                                                                 }));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseSwagger();
                app.UseSwaggerUI(options => options.SwaggerEndpoint("/swagger/v1/swagger.json", "iamaleks.dev API V1"));
            }

            app.UseRouting();
            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}