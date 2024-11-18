using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Roslan.MvvmUtils.Services;



namespace Mvvmutils.Blazor.Services;



public class BlazorNavigationService : INavigationService {



    #region "Services"
    private readonly NavigationManager _navigationManager;
    #endregion



    /// <summary>
    /// 
    /// </summary>
    /// <param name="navigationManager"></param>
    public BlazorNavigationService(NavigationManager navigationManager) {
        _navigationManager = navigationManager;
    }



    public void NavigateTo(string pageName) {
        _navigationManager.NavigateTo(pageName);
    }

}