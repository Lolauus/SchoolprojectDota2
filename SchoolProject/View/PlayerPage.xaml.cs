using SchoolProject.DataProvider;
using SchoolProject.Models;
using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SchoolProject.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>

    public sealed partial class PlayerPage : Page
    {
        public ObservableCollection<Profile> items;

        public PlayerPage()
        {
            InitializeComponent();
            APIHelper.InitilizeClient();
            items = new ObservableCollection<Profile>();


        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
            {

                Rootobject rootobject = (Rootobject)e.Parameter;
                if (rootobject != null)
                {

                    Profile profile = new Profile();

                    profile.avatarmedium = rootobject.profile.avatarmedium;
                    profile.personaname = rootobject.profile.personaname;
                    profile.steamid = rootobject.profile.profileurl;
                    profile.account_id = rootobject.profile.account_id;
                    profile.loccountrycode = rootobject.competitive_rank.ToString();
                    profile.mmr = rootobject.solo_competitive_rank;
                    profile.last_login = rootobject.profile.last_login;


                    items.Add(profile);
                 PlayerInfo.ItemsSource = items;
                }
                else
                {
                    Frame.Navigate(typeof(MainPage));
                    

                }
            }


        private void Header_click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }

}
