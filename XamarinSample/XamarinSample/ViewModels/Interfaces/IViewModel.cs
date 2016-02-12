

using System.ComponentModel;
using XamarinSample.Pages.Context.Interfaces;

namespace XamarinSample.ViewModels.Interfaces
{
    public interface IViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Contexto de navegação e mensagens pop-up.
        /// </summary>
        IPageContext Context { get; }
    }
}
