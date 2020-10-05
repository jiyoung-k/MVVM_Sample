using MVVM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml.Serialization;

namespace MVVM.ViewModels
{
    class MainViewModel : Notifier
    {

        Models.MainModel mainModel;

        public MainViewModel()
        {
            mainModel = new Models.MainModel();
        }

        private void WindowLoaded()
        {
            MessageBox.Show("Window Load !!!!");
        }

        private void WindowClosed()
        {
            MessageBox.Show("Window Closed !!!");
        }

        public Models.MainModel MainModel
        {
            get { return mainModel; }
            set { mainModel = value; }
        }

        public string Name
        {
            get { return MainModel.Name; }
            set
            {
                if (MainModel.Name != value)
                {
                    MainModel.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public decimal Rate
        {
            get { return MainModel.Rate; }
            set
            {
                if(mainModel.Rate != value)
                {
                    mainModel.Rate = value;
                    OnPropertyChanged("Rate");
                    Convert();
                }
            }
        }

        public decimal Amount
        {
            get { return MainModel.Amount; }
            set
            {
                if (mainModel.Amount != value)
                {
                    mainModel.Amount = value;
                    OnPropertyChanged("Amount");
                    Convert();
                }
            }
        }

        public string Title
        {
            get { return MainModel.Title; }
            set
            {
                if(mainModel.Title != value)
                {
                    mainModel.Title = value;
                    OnPropertyChanged("Title");
                }
            }
        }

        private void Convert()
        {
            decimal convertAmount = Amount * Rate;
            Title = string.Format("Amount in {0}", convertAmount);
        }
    }
}
