using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

namespace MVVM_Toolkit_Messaging
{
	public class SenderViewModel : ObservableRecipient
	{
		public void SendMessage()
		{
			DummyTextMessage message = CreateMessage();
			this.Messenger.Send(message);
		}

		private static DummyTextMessage CreateMessage()
		{
			string dateTime = DateTime.Now.ToString();
			DummyTextMessage message = new DummyTextMessage(dateTime);

			return message;
		}
	}
}
