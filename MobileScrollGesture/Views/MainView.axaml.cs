using Avalonia.Controls;
using ReactiveUI;

namespace MobileScrollGesture.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

    private void OnSelectedIndexChanged(object? sender, SelectionChangedEventArgs e)
    {
        if (e?.AddedItems?.Count > 0) {
            Top.Text = e.AddedItems[0]?.ToString();
        }
    }
}