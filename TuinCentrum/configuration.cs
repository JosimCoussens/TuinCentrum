﻿//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;
//using Microsoft.Extensions.Logging;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.InteropServices.JavaScript;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using TuinCentrum.Windows;
//using Windows.UI.Core;
//using ZendeskApi_v2.Requests.HelpCenter;

//namespace TuinCentrum {
//    internal class Configuration {
//        public string _connectionString { get; private set; }

//        public Configuration() {
//            var host = new HostBuilder()
//                .ConfigureAppConfiguration((context, configurationBuilder) => {
//                    configurationBuilder.SetBasePath(context.HostingEnvironment.ContentRootPath);
//                    configurationBuilder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
//                    configurationBuilder.AddEnvironmentVariables();
//                })
//                .Build();

//            // Retrieve the connection string from the configuration
//            _connectionString = host.Services.GetRequiredService<IConfiguration>().GetConnectionString("TuinCentrumDbConnectionString");
//        }
//    }

//    internal class Program {
//        private static void Main(string[] args) {
//            var config = new Configuration();
//            string connectionString = config._connectionString;
//            // Maak en toon dashboard window
//            Application.Current.Dispatcher.Invoke(() => {
//                var dashboard = new dashboard();
//                dashboard.Show();
//            });
//        }
//    }
//}