namespace MemoryLeak9;

public partial class MainPage
{
    public MainPage()
    {
        InitializeComponent();
        Appearing += OnAppearing;
    }

    private void OnAppearing(object? sender, EventArgs e)
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        var mem = (int)(GC.GetTotalMemory(false) / 1024d);
        BtnSecondPage.Text = mem.ToString();
    }

    private void OnSecondClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(SecondPage));
    }
}