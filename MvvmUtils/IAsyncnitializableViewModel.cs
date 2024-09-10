using System.Reflection;
using Microsoft.Toolkit.Mvvm.Input;

namespace Roslan.MvvmUtils {



    public interface IAsyncnitializableViewModel {

        IAsyncRelayCommand AsyncInitCommand { get; set; }
    }
}
