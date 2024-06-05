using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace MVVM_Toolkit_DependencyInjection
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			ConfigureServices();

			IMessageBoxService? messageBoxService = Ioc.Default.GetService<IMessageBoxService>();
			ViewModel viewModel = new(messageBoxService);
			this.DataContext = viewModel;
		}

		private static void ConfigureServices()
		{
			IServiceProvider serviceProvider = BuildServiceProvider();
			Ioc.Default.ConfigureServices(serviceProvider);
		}

		/// <summary>
		/// Create a service provider using Microsoft.Extensions.DependencyInjection
		/// </summary>
		private static ServiceProvider BuildServiceProvider()
		{
			ServiceCollection services = new();
			services.AddSingleton<IMessageBoxService, MessageBoxService>();

			return services.BuildServiceProvider();
		}
	}
}