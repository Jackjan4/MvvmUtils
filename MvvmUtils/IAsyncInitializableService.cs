using System.Threading.Tasks;

namespace Roslan.MvvmUtils {
    public interface IAsyncInitializableService {



        /// <summary>
        /// Determines whether the service has been initialized.
        /// </summary>
        bool IsInitialized { get; set; }



        Task InitializeAsync();



        Task DeInitializeAsync();
    }
}
