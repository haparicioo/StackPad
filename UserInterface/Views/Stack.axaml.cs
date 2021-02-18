using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace UserInterface.Views
{
    public class Stack : UserControl
    {
        public Stack()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
