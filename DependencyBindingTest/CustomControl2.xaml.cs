using System.Windows;
using System.Windows.Controls;

namespace DependencyBindingTest
{
    /// <summary>
    /// Interaction logic for CustomControl2.xaml
    /// </summary>
    public partial class CustomControl2 : UserControl
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
           typeof(CustomControl2),
           new PropertyMetadata(null, OnDescriptionChanged));

        public CustomControl2()
        {
            InitializeComponent();
        }

        private static void OnDescriptionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            
        }
    }
}
