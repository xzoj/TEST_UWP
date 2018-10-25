using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BaiTapCuoiMon.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Add : Page
    {
        public Add()
        {
            this.InitializeComponent();
        }

        private void Save_file(object sender, RoutedEventArgs e)
        {
            string path = @File_name.Text;

            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                string createText = Content_text.Text + Environment.NewLine;
                File.WriteAllText(path, createText);
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            string appendText = Content_text.Text + Environment.NewLine;
            File.AppendAllText(path, appendText);
        }
        
        
    }
}
