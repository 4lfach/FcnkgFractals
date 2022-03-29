using FckngFractals.State;
using FckngFractals.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FckngFractals.Commands
{
    public class UpdateCurrentViewModelCommand :CommandBase
    {
        private INavigator _navigator;

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            _navigator = navigator;
        }

        public override void Execute(object? parameter)
        {
            if (parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;

                switch (viewType)
                {
                    case ViewType.BinaryTree:
                        _navigator.CurrentViewModel = new BinaryTreeViewModel();
                        break;
                    case ViewType.Snowflake:
                        _navigator.CurrentViewModel = new SnowflakeViewModel();
                        break;
                    case ViewType.Mandelbrodt:
                        break;
                    case ViewType.About:
                        break;
                    default: break;
                }
            }

            base.Execute(parameter);
        }
    }
}
