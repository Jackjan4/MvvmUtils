namespace Roslan.MvvmUtils {
    public interface IInitializableService {



        /// <summary>
        /// Determines whether the service has been initialized.
        /// </summary>
        bool IsInitialized { get; }



        void Initialize();



        void Deinitialize();
    }
}
