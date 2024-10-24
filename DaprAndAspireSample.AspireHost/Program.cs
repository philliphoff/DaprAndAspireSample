var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.DaprAndAspireSample_Actors>("actors")
       .WithDaprSidecar();

builder.AddProject<Projects.DaprAndAspireSample_WebApi>("webapi")
       .WithDaprSidecar();

builder.Build().Run();
