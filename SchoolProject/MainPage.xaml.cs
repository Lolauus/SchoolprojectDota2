using SchoolProject.DataProvider;
using SchoolProject.View;
using System;
using System.Linq;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

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
            Dota2DataProvider qdp = new Dota2DataProvider();
            
            //Inget playerID är under 10.
           
            if (ValueFromButtonClick.Count() < 10 && ValueFromButtonClick != "")
            {

                var input = await qdp.GetPlayerInfo(ValueFromButtonClick);
                Frame.Navigate(typeof(PlayerPage), input);                
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

        private void EnterClick(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == VirtualKey.Enter)
            {
                SearchBtn_Click(sender, e);
            }
        }
    }
}
