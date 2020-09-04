using LoginSystem.Domain;
using LoginSystem.Domain.Models;
using LoginSystem.Domain.Services.AuthenticationServices;
using LoginSystem.Persistence;
using LoginSystem.Persistence.Services;
using LoginSystem.WPF.State.Accounts;
using LoginSystem.WPF.State.Authenticators;
using LoginSystem.WPF.State.Navigators;
using LoginSystem.WPF.ViewModels;
using LoginSystem.WPF.ViewModels.Factories;
using Microsoft.AspNet.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace LoginSystem.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IHost _host;

        public App()
        {
            _host = CreateHostBuilder().Build();
        }

        public static IHostBuilder CreateHostBuilder(string[] args = null)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(c =>
                {
                    c.AddJsonFile(@"C:\Users\yatha\source\repos\LoginSystem\LoginSystem.WPF\appsettings.json");
                    c.AddEnvironmentVariables();
                })
                .ConfigureServices((context, services) =>
                {
                    

                    string connectionString = context.Configuration.GetConnectionString("default");
                    services.AddDbContext<LoginDbContext>(o => o.UseSqlServer(connectionString));
                    services.AddSingleton<IAuthenticationService, AuthenticationService>();
                    services.AddSingleton<IDataService<Account>, AccountDataService>();
                    services.AddSingleton<IAccountService, AccountDataService>();

                    services.AddSingleton<IPasswordHasher, PasswordHasher>();

                    services.AddSingleton<IViewModelFactory, ViewModelFactory>();
                    services.AddSingleton<ViewModelDelegateReNavigator<LoginViewModel>>();
                    services.AddSingleton<CreateViewModel<HomeViewModel>>(s =>
                    {
                        return () => new HomeViewModel(
                            s.GetRequiredService<IAuthenticator>(),
                            s.GetRequiredService<ViewModelDelegateReNavigator<LoginViewModel>>());
                    });

                    services.AddSingleton<ViewModelDelegateReNavigator<HomeViewModel>>();
                    services.AddSingleton<CreateViewModel<LoginViewModel>>(s =>
                    {
                        return () => new LoginViewModel(
                            s.GetRequiredService<IAuthenticator>(),
                            s.GetRequiredService<ViewModelDelegateReNavigator<HomeViewModel>>());
                    });

                    services.AddSingleton<INavigator, Navigator>();
                    services.AddSingleton<IAuthenticator, Authenticator>();
                    services.AddSingleton<IAccountStore, AccountStore>();
                    services.AddScoped<MainViewModel>();

                    services.AddScoped<MainWindow>(s => new MainWindow(s.GetRequiredService<MainViewModel>()));
                });
        }

        protected override void OnStartup(StartupEventArgs e)
        {

            _host.Start();

            Window window = _host.Services.GetRequiredService<MainWindow>();
            window.Show();
            //var ser = _host.Services.GetRequiredService<IAuthenticationService>();
            //var res = ser.Register("ysant77@gmail.com", "yatharth", "yatharth", "yatharth");
            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await _host.StopAsync();
            _host.Dispose();

            base.OnExit(e);
        }
    }
}
