using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Toolkit_DependencyInjection
{
    public interface IMessageBoxService
    {
        void Show(string message);
    }
}
