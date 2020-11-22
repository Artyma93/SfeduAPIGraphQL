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
using Microsoft.AspNetCore.Authentication.JwtBearer;
using WebApplicationCore3GraphQL.Utils;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.TokenCacheProviders.InMemory;
using Microsoft.Graph;


namespace WebApplicationCore3GraphQL
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // services.AddMicrosoftIdentityWebApiAuthentication(Configuration);
            // services.AddMicrosoftIdentityWebApiAuthentication(Configuration, "AzureAd");

            // services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //     .AddMicrosoftIdentityWebApi(Configuration);

            
////////////////////////

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, config =>
                {
                    config.TokenValidationParameters.RoleClaimType = "groups";
                });

            // services.AddAuthorization(options =>
            // {
            //     options.AddPolicy(AuthorizationPolicies.AssignmentToGroupAdminGroupRequired, policy => policy.RequireRole(Configuration["Groups:GroupAdmin"]));
            //     options.AddPolicy(AuthorizationPolicies.AssignmentToGroupMemberGroupRequired, policy => policy.RequireRole(Configuration["Groups:GroupMember"]));
            // });
/////////////////////////////
            ////todo code start
            //// Setting configuration for protected web api
            ////services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            ////    .AddProtectedWebApi(Configuration);

            //services.AddProtectedWebApi(Configuration)
            //        .AddProtectedWebApiCallsProtectedWebApi(Configuration)
            //        .AddInMemoryTokenCaches();

            //// The following lines code instruct the asp.net core middleware to use the data in the "groups" claim in the Authorize attribute
            //services.Configure<JwtBearerOptions>(JwtBearerDefaults.AuthenticationScheme, options =>
            //{
            //    // The claim in the Jwt token where groups are available.
            //    options.TokenValidationParameters.RoleClaimType = "groups";
            //});

            //// Adding authorization policies that enforce authorization using Azure AD roles.
            //services.AddAuthorization(options =>
            //{
            //   options.AddPolicy(AuthorizationPolicies.AssignmentToGroupAdminGroupRequired, policy => policy.RequireRole(Configuration["Groups:GroupAdmin"]));
            //   options.AddPolicy(AuthorizationPolicies.AssignmentToGroupMemberGroupRequired, policy => policy.RequireRole(Configuration["Groups:GroupMember"]));
            //});

            ////todo code end

            services.AddDbContext<SfeduMsSqlContext>();

            //// �������� ������ ����������� �� ����� ������������
            //string connection = Configuration.GetConnectionString("DefaultConnection");
            //// ��������� �������� MobileContext � �������� ������� � ����������
            //services.AddDbContext<SfeduMsSqlContext>(options =>
            //    options.UseSqlServer(connection));

            services.AddTransient<IAcademy1CBGURepository, Academy1CBGURepository>();
            services.AddTransient<IAcademyIncome1CBGURepository, AcademyIncome1CBGURepository>();


            // services.AddProtectedWebApi(Configuration)
            //         .AddProtectedWebApiCallsProtectedWebApi(Configuration)
            //         .AddInMemoryTokenCaches();
            // The following lines code instruct the asp.net core middleware to use the data in the "groups" claim in the Authorize attribute
            // services.Configure<JwtBearerOptions>(JwtBearerDefaults.AuthenticationScheme, options =>
            // {
            //    // The claim in the Jwt token where groups are available.
            //    options.TokenValidationParameters.RoleClaimType = "groups";
            // });

            // Adding authorization policies that enforce authorization using Azure AD roles.
            // services.AddAuthorization(options =>
            // {
            //    options.AddPolicy(AuthorizationPolicies.AssignmentToGroupAdminGroupRequired, policy => policy.RequireRole(Configuration["Groups:GroupAdmin"]));
            //    options.AddPolicy(AuthorizationPolicies.AssignmentToGroupMemberGroupRequired, policy => policy.RequireRole(Configuration["Groups:GroupMember"]));
            // });

            // services.AddAuthentication();
            // services.AddAuthorization();


            services.AddCors();

            // v1
            //services.AddDataLoaderRegistry();

            // v2
            services.AddSingleton<IDataLoaderRegistry, DataLoaderRegistry>();
            services.AddDataLoaderRegistry();

            services.AddGraphQL(sp => SchemaBuilder.New()
            .AddServices(sp)
            .AddQueryType<QueryType>()
            .AddAuthorizeDirectiveType()
            .Create());

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseCors(c =>
            {
                c.AllowAnyHeader();
                c.AllowAnyMethod();
                c.AllowAnyOrigin();
            });
            // app.UseAuthentication();
            app.UseAuthorization();
            //app.UseGraphQL();
            app.UseGraphQL("/graphql");
            app.UsePlayground("/graphql", "/graphql/playground");
            //app.UseGraphQL("/graphql")
            //   .UseGraphiQL("/graphql");
            //app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!!!");
            //    });
            //});

            //app.UseRouting();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGraphQL();

            //    //endpoints
            //    //  .MapGraphQL("/graphql")
            //    //  .RequireAuthorization();
            //});

        }
    }

    //    public class Query
    //    {
    //        public string Hello() => "world";
    //    }
}
