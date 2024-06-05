using System.Windows;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using CommunityToolkit.Mvvm;

namespace MVVM_Toolkit_DependencyInjection
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);

			this.Configure();
			IMessageBoxService messageBoxService = Ioc.Default.GetService<IMessageBoxService>();
			
			ViewModel viewModel = new ViewModel(messageBoxService);
			MainWindow mainWindow = new MainWindow();
			mainWindow.DataContext = viewModel;
		}

		public void Configure()
		{
			Ioc.Default.ConfigureServices(BuildServiceProvider());
		}

		/// <summary>
		/// Configures the services for the application.
		/// </summary>
		private static IServiceProvider BuildServiceProvider()
		{
			ServiceCollection services = new();
			services.AddSingleton<IMessageBoxService, MessageBoxService>();

			return services.BuildServiceProvider();
		}

	}

}
