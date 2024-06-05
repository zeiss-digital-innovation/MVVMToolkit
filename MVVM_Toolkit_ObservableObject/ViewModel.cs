using CommunityToolkit.Mvvm.ComponentModel;

namespace Observable_Object
{
	internal partial class ViewModel : ObservableObject
	{
		[ObservableProperty]
		[NotifyPropertyChangedFor(nameof(FullName))]
		private string? firstName;

		[ObservableProperty]
		[NotifyPropertyChangedFor(nameof(FullName))]
		private string? lastName;

		public string FullName => $"{FirstName} {LastName}";
	}
}
