using Drincc.API.Contracts;
using Drincc.DAL.Data;
using Drincc.EF.Services;
using Drincc.Filters;
using Drincc.SwaggerFilters;
using Drincc.TransformerConventions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web;
using Newtonsoft.Json.Converters;

namespace Drincc
{
    public class Program
    {
        // CORS policy name
        private static readonly string allowedOrigins = "_myAllowSpecificOrigins";
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var services = builder.Services;
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

            services.AddCors(options =>
                options.AddPolicy(
                    name: allowedOrigins,
                    policy => policy.WithOrigins("http://localhost:3000/").AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
            ));

            services.AddRouting(options => options.LowercaseUrls = true);
            services
                .AddControllers(options =>
                {
                    options.Conventions.Add(new RouteTokenTransformerConvention(new SlugifyParameterTransformer()));
                    options.Filters.Add<ResultFilter>();
                })
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                    options.SerializerSettings.Converters.Add(new StringEnumConverter());
                });
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            // Dependencies
            services.AddScoped<ITeaService, TeaService>();

            services.AddEndpointsApiExplorer();

            services.AddSwaggerGenNewtonsoftSupport();
            services.AddSwaggerGen(options =>
            {
                options.SchemaFilter<EnumSchemaFilter>();
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseCors(allowedOrigins);

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}