using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;

namespace MVVM_Toolkit_Messaging
{
	public class ReceiverViewModel : ObservableRecipient, IRecipient<DummyTextMessage>
	{
		public ReceiverViewModel()
		{
			this.Messenger.Register(this);
		}

		public string ReceivedMessage { get; private set; }

		/// <summary>
		/// Handles the received message
		/// </summary>
		/// <param name="message"></param>
		public void Receive(DummyTextMessage message)
		{
			this.ReceivedMessage = message.Value;
		}
	}
}
