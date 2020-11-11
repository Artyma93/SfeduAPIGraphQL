using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Context;
using HotChocolate;
using HotChocolate.AspNetCore;
using HotChocolate.DataLoader;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Persistance.Repositories;
using Persistance.Repositories.Interfaces;
using WebApplicationCore3GraphQL.GraphQL.Queries;

namespace WebApplicationCore3GraphQL
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SfeduMsSqlContext>();

            //// получаем строку подключения из файла конфигурации
            //string connection = Configuration.GetConnectionString("DefaultConnection");
            //// добавляем контекст MobileContext в качестве сервиса в приложение
            //services.AddDbContext<SfeduMsSqlContext>(options =>
            //    options.UseSqlServer(connection));

            services.AddTransient<IAcademy1CBGURepository, Academy1CBGURepository>();
            services.AddTransient<IAcademyIncome1CBGURepository, AcademyIncome1CBGURepository>();

            services.AddCors();

            // v1
            //services.AddDataLoaderRegistry();

            // v2
            services.AddSingleton<IDataLoaderRegistry, DataLoaderRegistry>();
            services.AddDataLoaderRegistry();

            services.AddGraphQL(sp => SchemaBuilder.New()
            .AddServices(sp)
            .AddQueryType<QueryType>()
            .Create());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(c =>
            {
                c.AllowAnyHeader();
                c.AllowAnyMethod();
                c.AllowAnyOrigin();
            });

            //app.UseGraphQL();
            app.UseGraphQL("/graphql");
            app.UsePlayground("/graphql", "/graphql/playground");
            //app.UseGraphQL("/graphql")
            //   .UseGraphiQL("/graphql");
            //app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!!!");
            //    });
            //});
        }
    }

    //    public class Query
    //    {
    //        public string Hello() => "world";
    //    }
}
