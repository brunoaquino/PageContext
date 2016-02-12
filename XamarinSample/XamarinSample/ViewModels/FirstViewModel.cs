
using System;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinSample.Pages.Context.Interfaces;
using XamarinSample.Pages.Interfaces;
using XamarinSample.ViewModels.Base;
using XamarinSample.ViewModels.Interfaces;

namespace XamarinSample.ViewModels
{
    public class FirstViewModel : ViewModelBase, IFirstViewModel
    {
        #region Fields

        private Command _goToSecondPageCommand;

        #endregion

        #region Constructor

        public FirstViewModel(IPageContext context)
            : base(context)
        { }

        #endregion

        #region IFistViewModel members

        /// <summary>
        /// Commando responsável por navegar para a segunda página.
        /// </summary>
        public ICommand GoToSecondPageCommand
        {
            get
            {
                return _goToSecondPageCommand ??
                      (_goToSecondPageCommand = new Command(async() => 
                        await Context.NavigateTo<ISecondPage, ISecondViewModel>()));
            }
        } 

        #endregion
    }
}
