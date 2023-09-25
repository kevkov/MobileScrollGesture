using Avalonia.Controls;
using Avalonia.Controls.Primitives;
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
        if (e != null && e.AddedItems != null
            && e?.AddedItems?.Count > 0 && e.AddedItems[0] != null)
        {
            Top.Text = (sender as TabStrip)?.SelectedIndex.ToString();
        }
    }
}