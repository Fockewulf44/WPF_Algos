using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_Algos.Algorithms;

namespace WPF_Algos
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //new Two_Sum().Run();
            //new Palindrome().Run();
            //new AddTwoNumbers().Run();
            //new PlusMinus().Run();
            //new SwapNodesInPairs().Run();
            //new SmallestSubstring().Run();
            //new MinimumWindowSubstring().Run();
            //new ClimbingStairs().Run();
            //new Sqrtx().Run();
            //new BinarySearch().Run();
            //new MergeSort().Run();
            //new SortColors().Run();
            //new LongestSubstring().Run();
            //new LongestPalindromicSubstring().Run();
            //new NumberOfIslands().Run();
            new ValidAnagram().Run();

        }
    }
}