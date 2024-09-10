using System.Reflection;
using Microsoft.Toolkit.Mvvm.Input;

namespace Roslan.MvvmUtils {



    public interface IAsyncInitializableViewModel {

        IAsyncRelayCommand AsyncInitCommand { get; set; }
    }
}
