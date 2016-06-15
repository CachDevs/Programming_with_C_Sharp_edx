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

namespace Mod_9_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        int index = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string city = txtCity.Text;

            students.Add(new Student(firstName, lastName, city));

            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();

            index = students.Count;
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            index++;
            if (index >= students.Count)
            {
                index = students.Count;
                txtFirstName.Clear();
                txtLastName.Clear();
                txtCity.Clear();
                btnCreateStudent.IsEnabled = true;
            }
            else
            {
                Student s = students[index];
                txtFirstName.Text = s.FirstName;
                txtLastName.Text = s.LastName;
                txtCity.Text = s.City;
            }
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {

            if (index == 0)
            {
                MessageBox.Show("It's the beginning of the list");
            }
            else
            {
                index--;
                Student s = students[index];
                txtFirstName.Text = s.FirstName;
                txtLastName.Text = s.LastName;
                txtCity.Text = s.City;
                btnCreateStudent.IsEnabled = false;
            }
        }
    }
}
