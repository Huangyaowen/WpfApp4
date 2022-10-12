using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    
    public partial class MainWindow : Window
    {
        List<Drink> drinks = new List<Drink>();
        public MainWindow()
        {
            InitializeComponent();

            AddNewClass1(drinks);

            Displaydrinks(drinks);
        }

        private void Displaydrinks(List<Drink> drinks)
        {
            foreach (Drink d in drinks)
            { 
                StackPanel sp = new StackPanel();
                CheckBox cb = new CheckBox();
                //TextBox tb = new TextBox();
                Slider sl = new Slider();

                sp.Orientation = Orientation.Horizontal;

                cb.Content = d.Name + d.Size + d.Price;
                cb.Margin = new Thickness(0);
                cb.Width = 200;
                cb.Height = 25;

                sl.Value = 0;
                sl.Width = 100;
                sl.Minimum = 0;
                sl.Maximum = 10;
                sl.TickPlacement = TickPlacement.TopLeft;
                //tb.Width = 80;
                //tb.Height = 25;
                //tb.TextAlignment = TextAlignment.Right;

                sp.Children.Add(cb);
                sp.Children.Add(sl);

                StackPanel_DrinkMenu.Children.Add(sp);
            }
        }

        private void AddNewClass1(List<Drink> myClass)
        {
            myClass.Add(new Drink() { Name = "甘蔗檸檬青", Size = "大杯", Price = 60 });
            myClass.Add(new Drink() { Name = "甘蔗檸檬青", Size = "小杯", Price = 50 });
            myClass.Add(new Drink() { Name = "甘蔗牛奶", Size = "大杯", Price = 80 });
            myClass.Add(new Drink() { Name = "甘蔗牛奶", Size = "小杯", Price = 60 });
            myClass.Add(new Drink() { Name = "QQㄋㄟㄋㄟ好喝到靠杯咩噗茶", Size = "大杯", Price = 90 });
            myClass.Add(new Drink() { Name = "QQㄋㄟㄋㄟ好喝到靠杯咩噗茶", Size = "小杯", Price = 75 });
            myClass.Add(new Drink() { Name = "靠杯紅茶", Size = "大杯", Price = 25 });
            myClass.Add(new Drink() { Name = "靠杯青茶", Size = "大杯", Price = 25 });
            myClass.Add(new Drink() { Name = "靠杯綠茶", Size = "大杯", Price = 25 });

        }
    }
}
