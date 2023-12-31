﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;

namespace Office {
    /// <summary>
    /// Interaction logic for MainWindow.xaml 홍길동
    /// </summary>
    /// 

    public partial class MainWindow : Window {

        

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            List<Room> Rooms = new List<Room>();

            Rooms.Add(new Room("사무실1", Office1));
            Rooms.Add(new Room("사무실2", Office2)));
            Rooms.Add(new Room("사무실3", Office3)));

            OfficeList.ItemsSource = Rooms;
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e) {
            
        }
    }

    public class Room {
        public string Name { get; set; }
        public double Width {
            get; set; 
        }
        public double Height {
            get; set;
        }
        public double Area { get; set; }
        public int Tiles { get; set; }

        public Rectangle myRectangle;

        public Room(string name, Rectangle rect) {
            rect.SizeChanged += (s, e) => {
                Height = myRectangle.ActualHeight;
                Width = myRectangle.ActualWidth;
            };
        }
    }
}
