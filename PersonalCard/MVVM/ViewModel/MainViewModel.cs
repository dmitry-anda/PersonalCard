using System;
using PersonalCard.Core;

namespace PersonalCard.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        private object _currentView;

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand FeutereViewCommand { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public FeutereViewModel FeutereVM { get; set; }
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
            FeutereVM = new FeutereViewModel();
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            FeutereViewCommand = new RelayCommand(o =>
            {
                CurrentView = FeutereVM;
            });
        }


    }
}
