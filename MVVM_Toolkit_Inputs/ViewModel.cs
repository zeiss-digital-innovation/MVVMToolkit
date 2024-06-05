using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Inputs
{
	internal partial class ViewModel : ObservableObject
	{
		[NotifyPropertyChangedFor(nameof(CalculationResult))]
		[NotifyCanExecuteChangedFor(nameof(AddNumbersCommand))]
		[ObservableProperty]
		private string? firstNumber;

		[NotifyPropertyChangedFor(nameof(CalculationResult))]
		[NotifyCanExecuteChangedFor(nameof(AddNumbersCommand))]
		[ObservableProperty]
		private string? secondNumber;

		[ObservableProperty] private string? calculationResult;

		[ObservableProperty] private string? currentDate;

		private bool CanExecuteAdd => !string.IsNullOrWhiteSpace(this.FirstNumber) &&
		                              !string.IsNullOrWhiteSpace(this.SecondNumber);

		[RelayCommand(CanExecute=nameof(CanExecuteAdd))]
		private void AddNumbers()
		{
			if (FirstNumber != null && SecondNumber != null)
			{
				this.CalculationResult = (int.Parse(FirstNumber) + int.Parse(SecondNumber)).ToString();
			}
			else
			{
				this.CalculationResult = string.Empty;
			}
		}

		[RelayCommand]
		private void ShowCurrentDate()
		{
			this.CurrentDate = DateTime.Now.ToShortDateString();
		}
	}
}
