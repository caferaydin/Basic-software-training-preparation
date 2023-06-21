using Autofac;
using Autofac.Extensions.DependencyInjection;
using SmartPro.Business.DependencyResolvers;

var builder = WebApplication.CreateBuilder(args);

// Autofac .Net 6 IoC Configuration 
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(builder =>
    {
        builder.RegisterModule(new AutofacBusinessModule());
    });


// Add services to the container. .Net IoC

//builder.Services.AddPersistanceRegistration();





builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//var tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();

//builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//                .AddJwtBearer(options =>
//                {
//                    options.TokenValidationParameters = new TokenValidationParameters
//                    {
//                        ValidateIssuer = true,
//                        ValidateAudience = true,
//                        ValidateLifetime = true,
//                        ValidIssuer = tokenOptions.Issuer,
//                        ValidAudience = tokenOptions.Audience,
//                        ValidateIssuerSigningKey = true,
//                        IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)
//                    };
//                });

var app = builder.Build();

// Configure the HTTP request pipeline.  
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
} 

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
