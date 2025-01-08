using Roslan.MvvmUtils.Services;



namespace Roslan.MvvmUtils.WinForms.Services;



public class NavigationService : INavigationService {



    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    /// <param name="modal"></param>
    public void Navigate(string name, bool modal = false) {

        var type = Type.GetType(name);

        if (type == null) {
            throw new ArgumentException($"Type {name} not found");
        }

        if (Activator.CreateInstance(type) is not Form form) {
            throw new ArgumentException($"Type {name} is not a Form");
        }

        if (modal) {
            form.ShowDialog();
        } else {
            form.Show();
        }

    }
}