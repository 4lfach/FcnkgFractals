using FckngFractals.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FckngFractals.ViewModels
{
    public class MainViewModel :ViewModelBase
    {
        public INavigator Navigator { get; set; } = new Navigator();

    }
}
