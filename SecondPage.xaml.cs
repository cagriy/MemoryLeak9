namespace MemoryLeak9;

public class Topic
{
    public string Name { get; set; } = "";
}
public partial class SecondPage : ContentPage
{
    public SecondPage()
    {
        InitializeComponent();
        Unloaded += (_, _) =>
        {
            MEVideo.Handler?.DisconnectHandler();
        };
    }
}