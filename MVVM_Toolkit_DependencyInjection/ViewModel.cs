using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MVVM_Toolkit_DependencyInjection
{
    public partial class ViewModel : ObservableObject
    {
	    private readonly IMessageBoxService _messageBoxService;

	    public ViewModel(IMessageBoxService messageBoxService)
	    {
		    _messageBoxService = messageBoxService;
	    }

		[RelayCommand]
	    private void CallMessageBoxService()
	    {
			_messageBoxService.Show("Test message");
	    }
    }
}
