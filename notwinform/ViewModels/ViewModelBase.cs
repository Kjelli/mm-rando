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
                System.Console.WriteLine("ACTIVATE: This never logs man");
                Disposable
                    .Create(() => { /* handle deactivation */ })
                    .DisposeWith(disposables);
            });

        }
    }
}
