using SchoolProject.DataProvider;
using SchoolProject.Models;
using SchoolProject.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SchoolProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        
        public MainPage()
        {
            InitializeComponent();
            APIHelper.InitilizeClient();
        }
        public void FocusEvent(object sender, RoutedEventArgs e)
        {
            SearchBar.Text = string.Empty;
            SearchBar.GotFocus -= FocusEvent;
        }
        private async void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            var ValueFromButtonClick = SearchBar.Text;


            if (ValueFromButtonClick.Length < 10 && ValueFromButtonClick.Length >= 8  )
            {
                if (await Session.PlayerInfo(ValueFromButtonClick))
                {
                    Frame.Navigate(typeof(PlayerPage),Session.EmployeeData);                
                }

            }

            if (ValueFromButtonClick.Length == 10)
            {
                if (await Session.MatchInfo(ValueFromButtonClick))
                {

                    Frame.Navigate(typeof(MatchPage),Session.Matchinfon);
                }

            }
            else
            {
                string text = "You need to read the information regarding how to properly enter your ID";
                ShowInfo.Text = text;
                TextInfo.Text = "";
            }
            
        }

        private void Header_click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void EnterClick(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == VirtualKey.Enter)
            {
                SearchBtn_Click(sender, e);
            }
        }
    }
}
