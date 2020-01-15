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
            this.InitializeComponent();
            APIHelper.InitilizeClient();
        }
        public void FocusEvent(object sender, RoutedEventArgs e)
        {
            SearchBar.Text = string.Empty;
            SearchBar.GotFocus -= FocusEvent;
        }
        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            var ValueFromButtonClick = SearchBar.Text;
            string ValueFromEnterButton = SearchBar.Text.Replace(($"{SearchBar.Text}"),($"{sender}"));
            Dota2DataProvider qdp = new Dota2DataProvider();
   
           
            if (ValueFromButtonClick.Length == 8 || ValueFromEnterButton.Length == 8)
            {
                
                _ = qdp.GetPlayerInfo(ValueFromButtonClick);
                Frame.Navigate(typeof(PlayerPage));
            }
            if (ValueFromButtonClick.Length == 10 || ValueFromEnterButton.Length == 10)
            {
                _ = qdp.GetMatchInfo(ValueFromButtonClick);
                Frame.Navigate(typeof(PlayerPage));
            }
            else
            {
                string text = "You need to read the information regarding how to properly enter your ID";
                ShowInfo.Text = text;

            }


        }

        private void Header_click(object sender, RoutedEventArgs e)
        {

            this.Frame.Navigate(typeof(MainPage));
        }

        private static bool IsEnterKeyPressed()
        {
            var enterState = CoreWindow.GetForCurrentThread().GetKeyState(VirtualKey.Enter);
            return (enterState & CoreVirtualKeyStates.Down) == CoreVirtualKeyStates.Down;
        }
        private void SearchBarGrid_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (IsEnterKeyPressed())
            {
                MainPage test = new MainPage();
                string ValueFromEnterButton = SearchBar.Text;
                test.SearchBtn_Click(ValueFromEnterButton, e);
                
            }
            
        }
    }
}
