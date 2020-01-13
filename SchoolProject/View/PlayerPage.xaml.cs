using SchoolProject.DataProvider;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SchoolProject.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PlayerPage : Page
    {
        public PlayerPage()
        {
            this.InitializeComponent();
        }
        public void FocusEvent(object sender, RoutedEventArgs e)
        {
            SearchBar.Text = string.Empty;
            SearchBar.GotFocus -= FocusEvent;
        }

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
        }
    }
}
