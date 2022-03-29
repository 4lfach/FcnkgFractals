using FckngFractals.Commands;
using FckngFractals.Models;
using FckngFractals.ViewModels;
using System.ComponentModel;
using System.Windows.Input;

namespace FckngFractals.State
{
    public class Navigator :ObservableObject, INavigator
    {
        private ViewModelBase _currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                _currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }

        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);
    }
}
