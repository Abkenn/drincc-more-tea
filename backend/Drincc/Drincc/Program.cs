using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Identity.Web;

namespace Drincc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // CORS policy name
            const string allowedOrigins = "_myAllowSpecificOrigins";

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
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

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