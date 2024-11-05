using GrpcServer.Services;

var builder = WebApplication.CreateBuilder(args);

// ������������ gRPC
builder.Services.AddGrpc();

var app = builder.Build();

app.MapGrpcService<MatrixServiceImpl>(); // ��������� MatrixServiceImpl
app.MapGet("/", () => "Matrix multiplication gRPC service is running.");

app.Run();

