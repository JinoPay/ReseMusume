using Prism.Mvvm;

namespace ReseMusume.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "ReseMusume";
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public MainWindowViewModel()
        {

        }
    }
}
