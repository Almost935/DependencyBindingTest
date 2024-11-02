using System.Windows;
using System.Windows.Controls;

namespace DependencyBindingTest
{
    /// <summary>
    /// Interaction logic for CustomControl.xaml
    /// </summary>
    public partial class CustomControl : UserControl
    {
        public string Description
        {
            get { return (string)GetValue(DescriptionProperty); }
            set { SetValue(DescriptionProperty, value); }
        }

        public static readonly DependencyProperty DescriptionProperty =
       DependencyProperty.Register(
           nameof(Description),
           typeof(string),
           typeof(CustomControl),
           new PropertyMetadata(null, OnDescriptionChanged));

        public CustomControl()
        {
            InitializeComponent();
        }

        private static void OnDescriptionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var oldValue = e.OldValue as string;
            var newValue = e.NewValue as string;
            int x = 0;
        }
    }
}
