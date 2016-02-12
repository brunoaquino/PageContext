
using System.Windows.Input;

namespace XamarinSample.ViewModels.Interfaces
{
    public interface IThirdViewModel
    {
        /// <summary>
        /// Commando responsável por exibir mensagem.
        /// </summary>
        ICommand ShowCustomMessageCommand { get; }
    }
}
