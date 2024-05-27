namespace AgendaApp.API.Configurations
{
    public class CorsConfiguration
    {
        public static string PolicyName => "DefaultPolicy";

        public static void Configure(IServiceCollection services)
        {
            services.AddCors(cfg => cfg.AddPolicy(PolicyName,
                builder =>
                {
                    builder.WithOrigins("http://localhost:4200")
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                }));
        }
    }
}