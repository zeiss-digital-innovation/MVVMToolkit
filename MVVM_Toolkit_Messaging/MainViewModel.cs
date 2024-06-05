using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging.Messages;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Toolkit_Messaging
{
	public partial class MainViewModel : ObservableObject
	{
		private readonly ReceiverViewModel receiver;
		private readonly SenderViewModel sender;

		public MainViewModel()
		{
			this.sender = new SenderViewModel();
			this.receiver = new ReceiverViewModel();
		}

		[ObservableProperty]
		private string currentDate;

		[RelayCommand]
		public void ShowCurrentDate()
		{
			this.sender.SendMessage();
			this.CurrentDate = this.receiver.ReceivedMessage;
		}
	}
}
