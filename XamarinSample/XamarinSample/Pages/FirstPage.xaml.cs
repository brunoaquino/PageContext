using Xamarin.Forms;
using XamarinSample.Pages.Interfaces;

namespace XamarinSample.Pages
{
    public partial class FirstPage : ContentPage, IFirstPage
    {
        #region Constructor

        public FirstPage()
        {
            InitializeComponent();
        }

        #endregion
    }
}
