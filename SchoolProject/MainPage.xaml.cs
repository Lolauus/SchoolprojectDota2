using SchoolProject.DataProvider;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
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

        //private async void getMatches()
        //{
        //    int playerId = 0; 
        //    Dota2DataProvider qdp = new Dota2DataProvider();
        //    var categories = await qdp.GetPlayerInfo(playerId);
        //}

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            string inputValue = SearchBar.Text;
            Dota2DataProvider qdp = new Dota2DataProvider();

            if (inputValue.Length == 8)
            {
                 var PlayerInfo = qdp.GetPlayerInfo(inputValue);
               
            }
            if (inputValue.Length == 10)
            {
                var MatchInfo = qdp.GetMatchInfo(inputValue);
            }
            ShowInfo.Text = inputValue;
        }

    }
}
