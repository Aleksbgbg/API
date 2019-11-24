namespace Api
{
    using Api.Areas.WingmanTool.Services;
    using Api.Infrastructure;

    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc.ApplicationModels;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.OpenApi.Models;

    public class Startup
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public Startup(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers()
                    .AddNewtonsoftJson();

            services.AddTransient<IProjectQueryProvider, ProjectQueryProvider>();
            services.AddTransient<IWebRootFileProvider>(_ => new WebRootFileProvider(new TemplateFileProvider(_webHostEnvironment.WebRootPath)));
            services.AddTransient<IProjectTemplateProducer, ProjectTemplateProducer>();
            services.AddTransient<IGitFileProvider, GitFileProvider>();

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
            }

            app.UseRouting();
            app.UseEndpoints(endpoints => endpoints.MapControllers());

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "iamaleks.dev API V1");
                options.RoutePrefix = "";
            });
        }
    }
}