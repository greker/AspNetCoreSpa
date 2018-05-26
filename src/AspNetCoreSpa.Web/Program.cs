﻿using System.IO;
using AspNetCoreSpa.Web.Server;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore;
using System.Net;
using System;

namespace AspNetCoreSpa
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>    
                   WebHost.CreateDefaultBuilder(args)
                       .UseStartup<Startup>();
    }
}