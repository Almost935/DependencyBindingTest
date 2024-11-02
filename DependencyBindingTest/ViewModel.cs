using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DependencyBindingTest
{
    public class ViewModel : INotifyPropertyChanged
    {
        private Random _random = new Random();

        private string _description = "asdf";

        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    OnPropertyChanged();
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public ViewModel()
        {
            Task.Run(RunUpdateDescription);
        }

        private async Task RunUpdateDescription()
        {
            while (true)
            {
                UpdateDescription();
                await Task.Delay(1000);
            }
        }
        private async void UpdateDescription()
        {
            Description = "";

            for (int i = 0; i < 10; i++)
            {
                int random = _random.Next(65, 123);
                Char c = (Char)random;
                Description += $"{c}";
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
