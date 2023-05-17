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

namespace WPF_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> list = new List<int>();
        List<string> animal = new List<string> { "dog", "cat", "Ayam", "baboy" };
        public MainWindow()
        {
            InitializeComponent();
            for(int i = 1; i < 10; i ++) list.Add(i);
           
        }







        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            while(animal.Count - 1 >= 4)
            {
                MessageBox.Show(animal.Count.ToString());
                break;
            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            for(int i = 0;i < animal.Count; i++ ) 
            {
                if(i == 3) animal.Add("Pangka");
                MessageBox.Show(animal[i].ToString());
                if (i == 5) break;
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int age = 1;
            do
            {
                MessageBox.Show(age.ToString());
                age++;
            }
            while (age <= 25);
        
                    
            
            
        }
    }
}
