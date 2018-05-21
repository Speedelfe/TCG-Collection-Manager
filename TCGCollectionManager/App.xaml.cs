using Avalonia;
using Avalonia.Markup.Xaml;

namespace TCGCollectionManager
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
   }
}