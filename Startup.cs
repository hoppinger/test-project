using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NLog.Extensions.Logging;
using NLog.Web;
using SimpleModelsAndRelations.Data;
using SimpleModelsAndRelations.Models;

namespace SimpleModelsAndRelations
{

  static class StaticMailer {
    public static MailOptions _mailOptions = new MailOptions();
  }

  public class MailOptions
  {
    public MailOptions()
    {
    }
    public string MailApiToken { get; set; }
    public string MailFrom { get; set; }
  }

  public class ApiOptions
  {
    public ApiOptions()
    {
    }
    public string ApiToken { get; set; }
  }

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
      app.UseMvc(routes =>
      {
      }); 
    }
  }
}