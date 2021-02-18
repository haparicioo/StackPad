using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

using Core;

namespace UserInterface.Views
{
    public class MainWindow : Window
    {
        Core.StackPad pad = new Core.StackPad();
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
