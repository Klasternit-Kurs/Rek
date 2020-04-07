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

namespace Rek
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

		private void TestRek(object sender, RoutedEventArgs e)
		{
			//A(4);
			
			MessageBox.Show(Rekurzija(3).ToString());
		}

		private int Rekurzija(int x)
		{
			if (x > 0)
			{
				Rekurzija(--x);
			}
			return x;
		}

		private void A(int x)
		{
			B(x *= 2);
			MessageBox.Show("A gotov");
		}

		private void B(int zklj)
		{
			if (zklj > 5)
				C(zklj);
			MessageBox.Show("B gotov");
		}

		private void C(int neZnam)
		{
			B(--neZnam);
			MessageBox.Show("C gotov");
		}
	}
}
