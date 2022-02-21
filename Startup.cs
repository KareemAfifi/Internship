using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using UniAPI.Interfaces;
using UniAPI.Models;
using UniAPI.Services;

namespace UniAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //ADDED connection string
            services.AddDbContext<TrainingContext>(Options => Options.UseSqlServer(Configuration.GetConnectionString("DBConnection")));
            //Dependency Injection 

            services.AddScoped<ICourseInterface,CoursesClass>();
            services.AddScoped<IDepartmentsInterface, DepartmentsClass>();
            services.AddScoped<IStudentsInterface, StudentsClass>();
            services.AddScoped<IEnrollsInterface, EnrollsClass>();
            services.AddScoped<IInstructorsInterface, InstructorsClass>();
            services.AddScoped<IInstrcutorteachescourseInterface, InstructorteachescourseClass>();


            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //Added Here for Configuration to Angular
            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            ////

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
