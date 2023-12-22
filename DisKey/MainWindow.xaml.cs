using System.Windows;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using WindowsInput;
using Windows.UI.Core;


// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace DisKey
{
    //11
    public partial class MainWindow : Window
    {
        private bool isKeyboardEnabled = true;
        public MainWindow()
        {
            this.InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (isKeyboardEnabled)
            {
                DisableKeyboard();
            }
            else
            {
                EnableKeyboard();
            }

            // Toggle the state
            isKeyboardEnabled = !isKeyboardEnabled;
        }
        private void DisableKeyboard()
        {
            // Disable the entire keyboard
            Window.Current.CoreWindow.KeyDown -= CoreWindow_KeyDown;
            Window.Current.CoreWindow.KeyUp -= CoreWindow_KeyUp;
        }
        private void EnableKeyboard()
        {
            // Enable the entire keyboard
            Window.Current.CoreWindow.KeyDown += CoreWindow_KeyDown;
            Window.Current.CoreWindow.KeyUp += CoreWindow_KeyUp;
        }
        private void CoreWindow_KeyDown(CoreWindow sender, KeyEventArgs args)
        {
            // Handle key down events if needed 
            args.Handled = true;
        }
        private void CoreWindow_KeyUp(CoreWindow sender, KeyEventArgs args)
        {
            // Handle key up events if needed
            args.Handled = true;
        }
    }
}