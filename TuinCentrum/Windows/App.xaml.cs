using System.Windows;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace TuinCentrum.Windows {

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {

        #region Properties

        private string _connectionString { get; set; }

        #endregion Properties

        #region Constructors

        public App() {
            var host = new HostBuilder()
                .ConfigureAppConfiguration((context, configurationBuilder) => {
                    configurationBuilder.SetBasePath(context.HostingEnvironment.ContentRootPath);
                    configurationBuilder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                    configurationBuilder.AddEnvironmentVariables();
                })
                .Build();

            // Retrieve the connection string from the configuration
            _connectionString = host.Services.GetRequiredService<IConfiguration>().GetConnectionString("TuinCentrumDbConnectionString");
        }

        #endregion Constructors

        #region Methods

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e) {
            e.Handled = true;
        }

        private async void OnStartup(object sender, StartupEventArgs e) {
            // Maak en toon dashboard window
            var dashboard = new dashboard();
            dashboard.Show();
        }

        private async void OnExit(object sender, ExitEventArgs e) {
        }

        #endregion Methods
    }
}