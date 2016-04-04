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

namespace WpfAssignment {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {
    public Model Model { get; set; } = new Model();
    // public Employee Kurt { get; set; } = new Employee("Kurt", "Hansen");

    public MainWindow() {
      InitializeComponent();
      DataContext = Model;
      }

    private void HurrayButton_Click(object sender, RoutedEventArgs e) {
      Model.Kurt.HaveBirthDay();
      }
    }
  }
