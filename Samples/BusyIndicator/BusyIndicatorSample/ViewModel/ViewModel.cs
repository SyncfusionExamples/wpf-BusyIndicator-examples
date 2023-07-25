using Syncfusion.Windows.Controls.Notification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace BusyIndicatorSample
{

    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool isBusy;
        private AnimationTypes _animationType =AnimationTypes.Flower;
        private double _width = 50;
        private double _height = 50;
        private string title = "Loading..";

        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;

                OnPropertyChanged("IsBusy");
            }

        }

        public AnimationTypes AnimationType
        {
            get { return _animationType; }
            set
            {
                _animationType = value;

                OnPropertyChanged("AnimationType");
            }

        }

        public double ViewBoxWidth
        {
            get { return _width; }
            set
            {
                _width = value;

                OnPropertyChanged("ViewBoxWidth");
            }

        }
        public double ViewBoxHeight
        {
            get { return _height; }
            set
            {
                _height = value;

                OnPropertyChanged("ViewBoxHeight");
            }

        }

        private ICommand _clickCommand;
        public ICommand LoadCommand
        {
            get
            {
                return _clickCommand ?? (_clickCommand = new CommandHandler(async () => await Loading(), () => CanExecute));
            }
        }

        public bool CanExecute
        {
            get
            {
                return true;
            }
        }

        public ViewModel()
        {
        }
        public async Task Loading()
        {
            IsBusy = true;
            await Task.Delay(3000);
            IsBusy = false;
        }

        public string Title
        {
            get { return title; }
            set
            {
                title = value;

                OnPropertyChanged("Title");
            }

        }
    }

    public class CommandHandler : ICommand
    {
        private Action _action;
        private Func<bool> _canExecute;

        /// <summary>
        /// Creates instance of the command handler
        /// </summary>
        /// <param name="action">Action to be executed by the command</param>
        /// <param name="canExecute">A bolean property to containing current permissions to execute the command</param>
        public CommandHandler(Action action, Func<bool> canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }

        /// <summary>
        /// Wires CanExecuteChanged event 
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Forcess checking if execute is allowed
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return _canExecute.Invoke();
        }

        public void Execute(object parameter)
        {
            _action();
        }
    }

}
