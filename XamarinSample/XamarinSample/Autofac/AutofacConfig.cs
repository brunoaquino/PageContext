
using Autofac;
using XamarinSample.Pages;
using XamarinSample.Pages.Context;
using XamarinSample.Pages.Context.Interfaces;
using XamarinSample.Pages.Interfaces;
using XamarinSample.ViewModels;
using XamarinSample.ViewModels.Interfaces;

namespace XamarinSample.Autofac
{

    public class AutofacConfig
    {

        #region Fields

        private static IContainer _container;

        #endregion

        #region Properties

        /// <summary>
        /// Recupera uma page do contâiner.
        /// </summary>
        public static TPage GetPage<TService, TPage>()
            where TService : IPage
            where TPage : class
        {
            if (_container == null || !_container.IsRegistered<TService>())
                return default(TPage);

            var pageContext = _container.Resolve<IPageContext>();
            return (TPage)pageContext.CurrentPage;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Responsável por registras em dependências ( Autofac ).
        /// </summary>
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            //Pages
            builder.Register(c => new FirstPage()).As<IFirstPage>()
                .OnActivated(e => e.Instance.BindingContext = e.Context.Resolve<IFirstViewModel>());
            builder.RegisterType<SecondPage>().As<ISecondPage>();
            builder.RegisterType<ThirdPage>().As<IThirdPage>();

            //Viewmodels
            builder.RegisterType<FirstViewModel>().As<IFirstViewModel>();
            builder.RegisterType<SecondViewModel>().As<ISecondViewModel>();
            builder.RegisterType<ThirdViewModel>().As<IThirdViewModel>();

            //PageContext
            builder.Register((c, p) => new PageContext(c.Resolve<IComponentContext>(), c.Resolve<IFirstPage>()))
                .As<IPageContext>()
                .SingleInstance();

            _container = builder.Build();
        }

        #endregion
    }
}
