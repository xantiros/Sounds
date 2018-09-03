using System;
using System.IO;
using System.Media;
using System.Reflection;
using System.Windows;
using System.Windows.Media;

namespace Sounds
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();           
        }

        string path = Path.Combine(@"C: \Users\bklima\source\repos\Sounds\Sounds", "Resources", "dzwiek.wav");

        private void Button_Click(object sender, RoutedEventArgs e)
        {           
            SoundPlayer sound = new SoundPlayer(path);
            sound.Load();
            sound.Play();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(path);
            sound.Load();
            sound.Play();
        }
    }
}
