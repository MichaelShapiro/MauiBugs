using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace SnackbarBug
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            string msg = 
                $"FIRST LINE\n\n\n" +

                $"1111111\n\n\n" +
                $"2222222\n\n\n" +
                $"3333333\n\n\n" +
                $"4444444\n\n\n" +
                $"5555555\n\n\n" +
                $"6666666\n\n\n" +
                $"7777777\n\n\n" +
                $"8888888\n\n\n" +
                $"7777777\n\n\n" +
                $"8888888\n\n\n" +
                $"9999999\n\n\n" +


                $"LAST LINE";

            ISnackbar snackBar = Snackbar.Make(msg, null, "OK", TimeSpan.FromSeconds(10), null, snackbarAnchor);
            snackBar.Show();
        }
    }

}
