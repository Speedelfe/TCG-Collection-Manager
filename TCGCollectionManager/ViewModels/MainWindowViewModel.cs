using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

using TCGCollectionManager.Model;

namespace TCGCollectionManager.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Hello World!";

        private IReactiveList<Card> cards;
        public IReactiveList<Card> Cards
        {
            get => this.cards;
            private set { this.RaiseAndSetIfChanged(ref this.cards, value); }
        }

        public MainWindowViewModel()
        {
            this.Cards = new ReactiveList<Card>(new Card[] { new Card("Glumanda") });
        }
    }
}
