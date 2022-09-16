using Microsoft.Win32;
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
using System.Windows.Threading;

namespace DragDrop_Image
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void timer_tick(object sender, EventArgs e)
        {
            listBox.SelectedIndex++;
            var image = listBox.Items[IndexItem] as ImageFrame;
            imageBrush.ImageSource = image.imgUC.Source;
        }

        public object MyItem { get; set; }

        public int IndexItem { get; set; }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            if (open.ShowDialog() == true)
            {
                var file = open.FileName;

                if (file.EndsWith(".jpg") || file.EndsWith(".png"))
                {
                    ImageFrame uc = new ImageFrame();
                    uc.ImageSource = file;
                    uc.FileName = open.FileName;
                    listBox.Items.Add(uc);
                }
                else
                {
                    MessageBox.Show("Picture in wrong format - .jpg or .png", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }

        }

        private void WrapPanel_Drop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(typeof(ListBox)) as ListBox;
            var image = data.Items[IndexItem] as ImageFrame;


            imageBrush.ImageSource = image.imgUC.Source;
        }

        private void listBox_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragDrop.DoDragDrop(listBox, listBox, DragDropEffects.Move);
            }
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MyItem = listBox.SelectedItem;
            IndexItem = listBox.SelectedIndex;
        }

        private void rightBtn_Click(object sender, RoutedEventArgs e)
        {
            listBox.SelectedIndex++;
            var image = listBox.Items[IndexItem] as ImageFrame;
            imageBrush.ImageSource = image.imgUC.Source;
        }

        private void leftBtn_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedIndex > 0)
            {
                listBox.SelectedIndex--;
                var image = listBox.Items[IndexItem] as ImageFrame;
                imageBrush.ImageSource = image.imgUC.Source;
            }
        }

        DispatcherTimer timer = new DispatcherTimer();
        private void playBtn_Click(object sender, RoutedEventArgs e)
        {
            timer.Interval = TimeSpan.FromSeconds(3);
            timer.Tick += timer_tick;
            timer.Start();
        }

        private void pauseBtn_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }
    }
}
