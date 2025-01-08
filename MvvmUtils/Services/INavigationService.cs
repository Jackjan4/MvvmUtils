namespace Roslan.MvvmUtils.Services {



    public interface INavigationService
    {

        void Navigate(string name, bool modal = false);
    }
}
