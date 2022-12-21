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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameStore1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string currentTheme = "night";
        public MainWindow()
        {
            InitializeComponent();
            Wpf.Ui.Appearance.Theme.Apply(
            Wpf.Ui.Appearance.ThemeType.Dark,
            Wpf.Ui.Appearance.BackgroundType.Acrylic,
            true 
            );
        }

        private void SwitchTheme(object sender, RoutedEventArgs e)
        {
            if (currentTheme == "night") {
                Wpf.Ui.Appearance.Theme.Apply(
                Wpf.Ui.Appearance.ThemeType.Light,
                Wpf.Ui.Appearance.BackgroundType.Acrylic,
                true
                );
                currentTheme = "light";
                var converter = new System.Windows.Media.BrushConverter();
                var Grid1_Color = (Brush)converter.ConvertFromString("#fbfbfb");
                var Grid0_Color = (Brush)converter.ConvertFromString("#f3f3f3");
                Grid1.Background = Grid1_Color;
                Grid0.Background = Grid0_Color;
                Grid_.Background = Grid0_Color;


            }
            else
            {
                Wpf.Ui.Appearance.Theme.Apply(
                Wpf.Ui.Appearance.ThemeType.Dark,
                Wpf.Ui.Appearance.BackgroundType.Mica,
                true
                );
                currentTheme = "night";
                var converter = new System.Windows.Media.BrushConverter();
                var Grid1_Color = (Brush)converter.ConvertFromString("#2d2d2d");
                var Grid0_Color = (Brush)converter.ConvertFromString("#202020");
                Grid1.Background = Grid1_Color;
                Grid0.Background = Grid0_Color;
                Grid_.Background = Grid0_Color;
            }
            
        }

        private void Dashboard_Click(object sender, RoutedEventArgs e)
        {
            if (!Dashboard.IsActive)
            {
                Dashboard.IsActive = true;
                Apps.IsActive = false;
                Games.IsActive = false;
                News.IsActive = false;
                Profile.IsActive = false;
            }
        }

        private void Apps_Click(object sender, RoutedEventArgs e)
        {
            if (!Apps.IsActive)
            {
                Dashboard.IsActive = false;
                Apps.IsActive = true;
                Games.IsActive = false;
                News.IsActive = false;
                Profile.IsActive = false;
            }
        }

        private void Games_Click(object sender, RoutedEventArgs e)
        {
            if (!Games.IsActive)
            {
                Dashboard.IsActive = false;
                Apps.IsActive = false;
                Games.IsActive = true;
                News.IsActive = false;
                Profile.IsActive = false;
            }
        }

        private void News_Click(object sender, RoutedEventArgs e)
        {
            if (!News.IsActive)
            {
                Dashboard.IsActive = false;
                Apps.IsActive = false;
                Games.IsActive = false;
                News.IsActive = true;
                Profile.IsActive = false;
            }
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            if (!Profile.IsActive)
            {
                Dashboard.IsActive = false;
                Apps.IsActive = false;
                Games.IsActive = false;
                News.IsActive = false;
                Profile.IsActive = true;
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }
        

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
