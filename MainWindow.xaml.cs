using Syncfusion.SfSkinManager;
using System.Windows;

namespace SyncFusion_Schedulars;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        SfSkinManager.SetTheme(this, new Theme("Windows11Dark"));
    }
}