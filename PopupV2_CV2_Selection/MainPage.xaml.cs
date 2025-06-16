using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Extensions;

namespace PopupV2_MultipleBugs
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnClicked_CV2_SelectionBug(object? sender, EventArgs e)
        {
            await this.ShowPopupAsync( 
                view:new PopupV2_CV2(),
                options: new PopupOptions
                {
                    CanBeDismissedByTappingOutsideOfPopup = false,
                    PageOverlayColor = Colors.Black.WithAlpha(0.5f)
                }
                );
        }

        private async void OnClicked_DismissBug(object? sender, EventArgs e)
        {
            await this.ShowPopupAsync(
                view: new PopupV2_Dismiss(),
                options: new PopupOptions
                {
                    CanBeDismissedByTappingOutsideOfPopup = true,
                    PageOverlayColor = Colors.Black.WithAlpha(0.5f)
                }
                );
        }

    }
}
