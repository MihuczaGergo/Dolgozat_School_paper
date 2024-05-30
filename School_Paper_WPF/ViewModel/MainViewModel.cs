using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using School_Paper_WPF.View;
using School_Paper_WPF.Commands;

namespace School_Paper_WPF.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private object currentView;
        private Task1 task1;
        private Task2 task2;
        private Task3 task3;

        public RelayCommand Task1ViewCommand { get; set; }
        public RelayCommand Task2ViewCommand { get; set; }
        public RelayCommand Task3ViewCommand { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnProperty([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public object CurrentView
        {
            get { return currentView; }
            set { currentView = value; OnProperty(); }
        }
        public MainViewModel()
        {
            task1 = new Task1();
            task2 = new Task2();
            task3 = new Task3();
            

            Task1ViewCommand = new RelayCommand(x => CurrentView = task1);
            Task2ViewCommand = new RelayCommand(x => CurrentView = task2);
            Task3ViewCommand = new RelayCommand(x => CurrentView = task3);
        }
    }
}