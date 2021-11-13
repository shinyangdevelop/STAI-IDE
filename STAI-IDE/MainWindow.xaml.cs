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

namespace STAI_IDE
{
	/// <summary>
	/// MainWindow.xaml에 대한 상호 작용 논리
	/// </summary>
	public partial class MainWindow : Window
	{
		String path = "C:/users/user/desktop/coding/ide/STAI-IDE/test.txt";

		public MainWindow()
		{
			InitializeComponent();

			String value = System.IO.File.ReadAllText(path);

			textbox_main.Text = value;
		}

		private void save(String path, String value)
		{
			System.IO.File.WriteAllText(path, value);
		}

		private void button_save_Click(object sender, RoutedEventArgs e)
		{
			save(path, textbox_main.Text);
		}
	}
}
