namespace MemoryLeak9;

public partial class SecondPage : ContentPage
{
    public SecondPage()
    {
        InitializeComponent();
        Appearing += (_, _) =>
        {
            var mem = (int)(GC.GetTotalMemory(false) / 1024d);
            Title = mem.ToString();
            L1.Text = mem.ToString();
            L1.IsVisible = false;
        };
    }

    private void ImageButton_Clicked(object? sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}