using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace DropDownMenuForeachRowInGridView
{
    public sealed partial class MyUserControl : UserControl
    {
        public ObservableCollection<RoomInfo> roominfo;

        public MyUserControl()
        {
            this.InitializeComponent();
            roominfo = new ObservableCollection<RoomInfo>();
            roominfo.Clear();
            roominfo.Add(new RoomInfo { RoomNo = "2NR12", host = "Available", Status = "Available", ellipseColor = "#FF008000", Date = "June 18,2016", TimeFrom = "02:00", TimeTo = "03:00" });
            roominfo.Add(new RoomInfo { RoomNo = "2NR12", host = "Ayman", Status = "Meeting", ellipseColor = "#FFFF0000", Date = "June 19,2016", TimeFrom = "11:00", TimeTo = "All Day" });
        }

        private void StackPanel_Tapped(object sender, TappedRoutedEventArgs e)
        {
            dropDown.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dropDown.Visibility = Visibility.Collapsed;
        }
    }
}