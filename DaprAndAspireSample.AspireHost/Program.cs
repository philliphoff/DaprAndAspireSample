var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.DaprAndAspireSample_Actors>("actors");

builder.AddProject<Projects.DaprAndAspireSample_WebApi>("webapi");

builder.Build().Run();
