
using System.Windows.Input;

namespace XamarinSample.ViewModels.Interfaces
{
    public interface ISecondViewModel
    {
        /// <summary>
        /// Commando responsável por navegar para a terceira página.
        /// </summary>
        ICommand GoToThirdPageCommand { get; }
    }
}
