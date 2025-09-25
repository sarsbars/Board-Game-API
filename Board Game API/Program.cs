using Board_Game_API.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Board_Game_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddAutoMapper(typeof(GameProfile));
            builder.Services.AddAutoMapper(typeof(CollectionGameProfile));
            builder.Services.AddAutoMapper(typeof(CollectionProfile));
            builder.Services.AddAutoMapper(typeof(GameSummaryProfile));
            builder.Services.AddAutoMapper(typeof(PlayParticipantProfile));
            builder.Services.AddAutoMapper(typeof(SessionProfile));
            builder.Services.AddAutoMapper(typeof(UserProfile));
            builder.Services.AddAutoMapper(typeof(UserSummaryProfile));

            // Add services to the container.

            builder.Services.AddControllers();

            // Register DbContext with correct connection string name
            builder.Services.AddDbContext<Models.BoardGameContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

