using CommunityToolkit.Mvvm.Input;

namespace Roslan.MvvmUtils {



    public interface IAsyncInitializableViewModel {

        IAsyncRelayCommand AsyncInitCommand { get; }

        bool IsInitialized { get; }
    }
}
