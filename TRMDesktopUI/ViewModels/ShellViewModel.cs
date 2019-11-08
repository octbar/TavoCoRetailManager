using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using TRMDesktopUI.EventsModels;

namespace TRMDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>, IHandle<LogOnEvent>
    {
        private IEventAggregator _events;
        private SalesViewModel _saleVM;
        private SimpleContainer _container;
        public ShellViewModel(IEventAggregator events, SalesViewModel salesVM, SimpleContainer container)
        {
            _events = events;
            _saleVM = salesVM;
            _container = container;
            
            _events.Subscribe(this);
           
            ActivateItem(_container.GetInstance<LoginViewModel>());
        }

        void IHandle<LogOnEvent>.Handle(LogOnEvent message)
        {
            ActivateItem(_saleVM);
        }
    }
}
