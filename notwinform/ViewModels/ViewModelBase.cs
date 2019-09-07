using ReactiveUI;
using System.Reactive.Disposables;

namespace NotWinForm.ViewModels
{
    public class ViewModelBase : ReactiveObject, ISupportsActivation
    {
        public ViewModelActivator Activator { get; }
        public ViewModelBase()
        {
            Activator = new ViewModelActivator();

            this.WhenActivated((CompositeDisposable disposables) =>
            {
                /* handle activation */
                Disposable
                    .Create(() => { /* handle deactivation */ })
                    .DisposeWith(disposables);
            });
        }

    }
}
