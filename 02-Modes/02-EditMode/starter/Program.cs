// TODO: Use Edit Mode to:
// 1. Refactor all files for async/await
// 2. Add dependency injection for services
// 3. Add XML documentation throughout
// 4. Fix naming conventions (camelCase → PascalCase)
// 5. Return proper IActionResult with status codes

var builder = WebApplicationBuilder.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
