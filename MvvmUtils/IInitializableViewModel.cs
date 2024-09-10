using System.Reflection;
using Microsoft.Toolkit.Mvvm.Input;

namespace Roslan.MvvmUtils {



    public interface IInitializableViewModel {

        IRelayCommand InitCommand { get; }
    }
}
