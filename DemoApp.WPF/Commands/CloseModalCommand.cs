using DemoApp.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.WPF.Commands
{
    class CloseModalCommand : CommandBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;
        public CloseModalCommand(ModalNavigationStore modalNavigationStore)
        {
            _modalNavigationStore = modalNavigationStore;
        }
        public override void Execute(object parameter)
        {
            _modalNavigationStore.Close();
        }
    }
}
