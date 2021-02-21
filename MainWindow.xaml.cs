using System;
using System.Collections;
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

namespace WpfApp1_HashTable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (txtBox_Key.Text == " " && txtBox_Value.Text == " ")
            {
                MessageBox.Show("Please input you Key");
            } else
            {
                hashtable.Add(txtBox_Key.Text, txtBox_Value.Text);
                MessageBox.Show("Save " + txtBox_Key.Text + " " + txtBox_Value.Text);
                txtBox_Key.Clear();
                txtBox_Value.Clear();
            }
            

        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            if (txtBox_Key.Text == " ")
            {
                MessageBox.Show("Please input your Key to remove here");
            } else
            {
                hashtable.Remove(txtBox_Key.Text);
                MessageBox.Show("Delete " + txtBox_Key.Text);
                txtBox_Key.Clear();
            }
        }

        private void showButton_Click(object sender, RoutedEventArgs e)
        {
            ICollection collection = hashtable.Keys;
            foreach (string key in collection)
            {
                MessageBox.Show(hashtable[key].ToString());
            }
        }
    }
}
