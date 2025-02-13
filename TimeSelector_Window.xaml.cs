using Syncfusion.SfSkinManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SyncFusion_Schedulars
{
    /// <summary>
    /// Interaction logic for TimeSelector_Window.xaml
    /// </summary>
    public partial class TimeSelector_Window : Window
    {
        public TimeSelector_Window()
        {
            InitializeComponent();
        }

        private void ThemeCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedTheme = (ThemeCombo.SelectedItem as ComboBoxItem)?.Content.ToString();

            if (!string.IsNullOrEmpty(selectedTheme))
            {
                SfSkinManager.SetTheme(this, new Theme(selectedTheme));
            }
        }
    }
}
