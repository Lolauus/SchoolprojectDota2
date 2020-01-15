using SchoolProject.DataProvider;
using SchoolProject.Models;
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
            APIHelper.InitilizeClient();
        }
        private void Playerinfo()
        {
            Player qdp = new Player();
            PlayerUserName.Text = qdp.UserName;
            PlayerMatchesPlayed.Text = qdp.MatchesPlayed.ToString();
            PlayerRank.Text = qdp.rank;
            PlayerRecord.Text = qdp.Record;

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }

}
