

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SimpleModelsAndRelations
{
  public class Startup
  {
    public Startup(IHostingEnvironment env)
    {

    }

    public IConfigurationRoot Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {

    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure()
    { 
    }
  }
}