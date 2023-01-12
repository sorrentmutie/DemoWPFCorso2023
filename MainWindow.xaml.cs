using DemoWPF.Librar;
using DemoWPF.Library;
using System.Collections.Generic;
using System.Windows;

namespace DemoWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IDataAccess dataAccess;

        public MainWindow(IDataAccess dataAccess)
        {
            InitializeComponent();
            this.dataAccess = dataAccess;
            //var myData = new MyData { ColorName = "Blue", IsVisible = true, TemperatureC = 100 };
            //myStackPanel.DataContext = myData;
            DataContext = new EmployeeData();

            employeeForm.DataContext = new Employee
            {
                Id = 10,
                Name = "Maria",
                Surname = "Orange"
            };


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           // myLabel.Content = dataAccess.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var data = (EmployeeData) DataContext;
            data.Employees.Add(new Employee { Id = 4 });

            var emp = (Employee)employeeForm.DataContext;
            emp.Name = "zzzzz";
        }

        private void StartEdit(object sender, RoutedEventArgs e)
        {
            var emp = (Employee)employeeForm.DataContext;
            emp.BeginEdit();
        }

        private void CancelEdit(object sender, RoutedEventArgs e)
        {
            var emp = (Employee)employeeForm.DataContext;
            emp.CancelEdit();
        }

        private void StopEdit(object sender, RoutedEventArgs e)
        {
            var emp = (Employee)employeeForm.DataContext;
            emp.EndEdit();
        }

    }
}
