

using System;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinSample.Pages.Context.Interfaces;
using XamarinSample.ViewModels.Base;
using XamarinSample.ViewModels.Interfaces;

namespace XamarinSample.ViewModels
{
    public class ThirdViewModel : ViewModelBase, IThirdViewModel
    {
        #region Fields

        private Command _showCustomMessageCommand;

        #endregion

        #region Constructor

        public ThirdViewModel(IPageContext context)
            : base(context)
        { }

        #endregion

        #region IThirdViewModel members

        /// <summary>
        /// Commando responsável por exibir mensagem.
        /// </summary>
        public ICommand ShowCustomMessageCommand
        {
            get
            {
                return _showCustomMessageCommand ??
                      (_showCustomMessageCommand = new Command(async() =>
                      {
                          await Context.ShowMessage("Mensagem", "PageContext com mensagem.", "Ok");
                      }));
            }
        }

        #endregion
    }
}
