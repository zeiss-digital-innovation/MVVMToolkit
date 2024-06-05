using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Observable_Properties
{
	internal partial class User : ObservableObject
	{
		[ObservableProperty]
		[NotifyPropertyChangedFor(nameof(FullName))]
		[NotifyCanExecuteChangedFor(nameof(GreetUserCommand))]
		private string? firstName;

		[ObservableProperty]
		[NotifyPropertyChangedFor(nameof(FullName))]
		[NotifyCanExecuteChangedFor(nameof(GreetUserCommand))]
		private string? lastName;

		[ObservableProperty]
		private string name;

		public string? FullName => $"{FirstName} {LastName}";

		[RelayCommand]
		private void GreetUser(User user)
		{
			Console.WriteLine($"Hello {user.FullName}!");
		}
	}
}
