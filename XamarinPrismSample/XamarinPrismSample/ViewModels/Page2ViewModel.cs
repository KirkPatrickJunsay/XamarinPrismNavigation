using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XamarinPrismSample.ViewModels
{
    public class Page2ViewModel : BindableBase
    {
        INavigationService _navigationService;
        public DelegateCommand NavigateBack { get; private set; }

        public Page2ViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateBack = new DelegateCommand(NavigatePreviousPage);
        }

        public void NavigatePreviousPage()
        {
            _navigationService.GoBackAsync();
        }
    }
}
