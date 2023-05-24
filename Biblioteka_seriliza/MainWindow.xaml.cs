using Newtonsoft.Json;
using System.Windows;
using SerilazaLib;
using System;

namespace Biblioteka_seriliza
{
    public partial class MainWindow : Window
    {
         Class1 class1 = new Class1();
        public MainWindow()
        {
            var s =  class1.DeSerilaz();
            InitializeComponent();
            vigruzka.Text = s;
        }

        private void serilizator_Click(object sender, RoutedEventArgs e)
        {
            string txt= vvod.Text;
            class1.Serilaz(txt);
            Close();
        }
    }
}
