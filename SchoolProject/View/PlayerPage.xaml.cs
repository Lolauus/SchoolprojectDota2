using SchoolProject.DataProvider;
using SchoolProject.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SchoolProject.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<Rootobject> semti;

        public MainPage()
        {
            this.InitializeComponent();
            APIHelper.InitilizeClient();
            semti = new ObservableCollection<Rootobject>();

        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Rootobject rootobject = (Rootobject)e.Parameter;
            Image img = new Image();
            img.Source = new BitmapImage(new Uri(rootobject.profile.avatarmedium));
            PlayerUserName.Text = rootobject.profile.personaname;
            PlayerSteamId.Text = ($"Steam Profile: {rootobject.profile.profileurl}");
            PlayerAccountId.Text = ($"Your Account ID: {rootobject.profile.account_id}");
            PlayerRank.Text = ($"Team MMR: {rootobject.competitive_rank}") + ($" Solo MMR: {rootobject.solo_competitive_rank}");
            PlayerMatchesPlayed.Text =   ($"Estimated Rating: {rootobject.mmr_estimate.estimate.ToString()}");
            PlayerAvatar.Source = img.Source;



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }

}
