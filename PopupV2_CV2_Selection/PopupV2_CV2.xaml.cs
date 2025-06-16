using CommunityToolkit.Maui.Extensions;

namespace PopupV2_MultipleBugs;

public partial class PopupV2_CV2 : ContentView
{
	public PopupV2_CV2()
	{
		InitializeComponent();
	}

    private void OnClicked_ClosePopup(object sender, EventArgs e)
    {
		Shell.Current.ClosePopupAsync(this);
    }

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        selectionCount.Text = e.CurrentSelection.Count.ToString();
    }
}