using System;
using PersonalCard.Core;

namespace PersonalCard.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        private object _currentView;

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand FutureViewCommand { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public FutureViewModel FutureVM { get; set; }
        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            FutureVM = new FutureViewModel();
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            FutureViewCommand = new RelayCommand(o =>
            {
                CurrentView = FutureVM;
            });
        }
    }
}
