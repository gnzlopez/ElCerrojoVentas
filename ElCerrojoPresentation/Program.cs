using AutoMapper;
using ElCerrojoPresentation.Forms;
using ElCerrojoPresentation.Utils;
using ElCerrojoRepository.DB;
using ElCerrojoRepository.Interfaces;
using ElCerrojoRepository.Repositories;
using ElCerrojoServices.Implementation;
using ElCerrojoServices.Interfaces;
using ElCerrojoServices.Logging;
using ElCerrojoServices.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ElCerrojoPresentation
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Fuente global
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            Application.SetDefaultFont(UiTheme.GetAppFont());

            ApplicationConfiguration.Initialize();

            // Creamos el Host
            var host = CreateHostBuilder().Build();

            // Ejecuta automáticamente las migraciones (el usuario no toca nada)
            using (var scope = host.Services.CreateScope())
            {
                //var mapper = scope.ServiceProvider.GetRequiredService<IMapper>();
                //mapper.ConfigurationProvider.AssertConfigurationIsValid();
                var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                db.Database.EnsureCreated();
                db.Dispose();
            }

            // Lanzamos el formulario
            var formService = host.Services.GetRequiredService<frmLayout>();

            Application.Run(formService);
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Logger.LogError(e.Exception);

            MessageBox.Show(
                "Ocurrió un error inesperado.\nPor favor contacte al administrador.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = e.ExceptionObject as Exception;
            Logger.LogError(ex);
        }

        static IHostBuilder CreateHostBuilder() => Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((context, config) =>
            {
                config.SetBasePath(AppContext.BaseDirectory);
                config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            })
            .ConfigureServices((context, services) =>
            {
                string basePath = Path.Combine(
                                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                                        "ElCerrojoVentas",
                                        "Data"
                                    );


                Directory.CreateDirectory(basePath);

                // Obtenemos el connection string del appsettings.json
                var fileName = context.Configuration["Database:FileName"];
                
                if (fileName == null)
                {
                    throw new Exception("El nombre de la base de datos no puede ser null");
                }

                if (!fileName.EndsWith(".db"))
                {
                    throw new Exception($"El nombre del archivo de Database debe finalizar con .db ({fileName})");
                }

                string dbPath = Path.Combine(basePath, fileName);
                string connectionString = $"Data Source={dbPath}";

                // Registrar DbContext con SQLite
                services.AddDbContext<AppDbContext>(options =>
                {
                    options.UseSqlite(connectionString);
                });

                // Registrar repositorios
                services.AddScoped<IProductRepository, ProductRepository>();
                services.AddScoped<IBrandRepository, BrandRepository>();
                services.AddScoped<ISaleRepository, SaleRepository>();
                services.AddScoped<ICategoryRepository, CategoryRepository>();
                services.AddScoped<ISupplierRepository, SupplierRepository>();

                // Registrar servicios
                services.AddScoped<IProductService, ProductService>();
                services.AddScoped<IBrandService, BrandService>();
                services.AddScoped<ISaleService, SaleService>();
                services.AddScoped<ICategoryService, CategoryService>();
                services.AddScoped<ICommonService, CommonService>();
                services.AddScoped<ISupplierService, SupplierService>();

                // Registrar formularios
                services.AddTransient<frmProducto>();
                services.AddTransient<frmVenta>();
                services.AddTransient<frmCategoria>();
                services.AddTransient<frmBuscarProducto>();
                services.AddTransient<frmHistorialVenta>();
                services.AddTransient<frmDetalleVenta>();
                services.AddTransient<frmReporteVenta>();
                services.AddTransient<frmConfiguracion>();
                services.AddTransient<frmGestion>();
                services.AddTransient<frmLayout>();

                // Registrar AutoMapper
                services.AddAutoMapper(typeof(ProductProfile).Assembly);
            });
    }
}