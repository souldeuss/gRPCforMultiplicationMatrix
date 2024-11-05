using GrpcServer.Services;

var builder = WebApplication.CreateBuilder(args);

// Налаштування gRPC
builder.Services.AddGrpc();

var app = builder.Build();

app.MapGrpcService<MatrixServiceImpl>(); // Реєстрація MatrixServiceImpl
app.MapGet("/", () => "Matrix multiplication gRPC service is running.");

app.Run();

