using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace DiscordChatExporter.Gui.Views.Dialogs;

public partial class DeleteSetupView : UserControl
{
    public DeleteSetupView()
    {
        InitializeComponent();
    }

    private void InitializeComponent() => AvaloniaXamlLoader.Load(this);

    private void UserControl_OnLoaded(object? sender, RoutedEventArgs args)
    {
        // Nothing to do on load for now
    }
}
