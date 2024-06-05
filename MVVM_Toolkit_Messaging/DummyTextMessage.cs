using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace MVVM_Toolkit_Messaging
{
	public class DummyTextMessage : ValueChangedMessage<string>
	{
		public DummyTextMessage(string text) : base(text)
		{
		}
	}
}
