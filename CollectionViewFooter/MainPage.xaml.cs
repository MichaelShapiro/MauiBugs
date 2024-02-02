namespace CollectionViewFooter;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
}

public class VM 
{
    public List<DataGroup> GroupedList { get; set; }

    public VM() 
    {
        GroupedList = new List<DataGroup>();

        for (int i = 1; i <= 25; i++)
            GroupedList.Add(new DataGroup($"Group #{i}", ["CollectionView", "footer", "bug"]));
    }
}

public class DataGroup : List<string> 
{
    public string Name { get; private set; }

    public DataGroup(string name, List<string> records) : base(records)
    {
        Name = name;
    } 
}
