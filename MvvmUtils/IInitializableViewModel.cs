using CommunityToolkit.Mvvm.Input;

namespace Roslan.MvvmUtils {



    public interface IInitializableViewModel {

        IRelayCommand InitCommand { get; }

        bool IsInitialized { get; }
    }
}
