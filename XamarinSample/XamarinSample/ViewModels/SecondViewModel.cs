

using System;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinSample.Pages.Context.Interfaces;
using XamarinSample.Pages.Interfaces;
using XamarinSample.ViewModels.Base;
using XamarinSample.ViewModels.Interfaces;

namespace XamarinSample.ViewModels
{
    public class SecondViewModel : ViewModelBase, ISecondViewModel
    {
        #region Fields

        private Command _goToThirdPageCommand;

        #endregion

        #region Constructor

        public SecondViewModel(IPageContext context)
            : base(context)
        { }

        #endregion

        #region ISecondViewModel members

        /// <summary>
        /// Commando responsável por navegar para a terceira página.
        /// </summary>
        public ICommand GoToThirdPageCommand
        {
            get
            {
                return _goToThirdPageCommand ??
                      (_goToThirdPageCommand = new Command(async() =>
                        await Context.NavigateTo<IThirdPage, IThirdViewModel>()));
            }
        }

        #endregion
    }
}
