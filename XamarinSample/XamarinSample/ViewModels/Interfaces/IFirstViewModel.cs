
using System.Windows.Input;

namespace XamarinSample.ViewModels.Interfaces
{
    public interface IFirstViewModel
    {
        /// <summary>
        /// Commando responsável por navegar para a segunda página.
        /// </summary>
        ICommand GoToSecondPageCommand { get; }
    }
}
