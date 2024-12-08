namespace MemoryLeak9;

public partial class MainPage : ContentPage
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
        CounterBtn.Text = mem.ToString();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(SecondPage));
    }
}