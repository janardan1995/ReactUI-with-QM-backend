﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Startup.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace QuantityMeasurementBackEnd
{    
    using Manager.LengthManager;
    using Manager.TemperatureManager;
    using Manager.WeightManager;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;    
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;    
    using Microsoft.OpenApi.Models;
    using Repository.LengthRepository;
    using Repository.TemperatureRepository;
    using Repository.WeightRepository;

    /// <summary>
    /// startUp class
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    builder =>
                    {
                        builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials();
                    });
            });
            services.AddTransient<ITemperatureManager, TemperatureManager>();
            services.AddTransient<ICelsiusVsFahrenheith, CelsiusVsFahrenheith>();
            services.AddTransient<IWeightManager, WeightManager>();
            services.AddTransient<IKilogramVsGram, KilogramVsGram>();
            services.AddTransient<ILengthManager, LengthManager>();
            services.AddTransient<IFeetVsInchesVsYard, FeetVsInchesVsYard>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "myapi v1"); });
            }
            else
            {
                app.UseHsts();
            }

            app.UseCors("AllowAll");
            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}