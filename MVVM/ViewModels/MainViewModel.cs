﻿using MVVM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MVVM.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        Models.MainModel mainModel;

        public MainViewModel()
        {
            mainModel = new Models.MainModel();
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
                    RaisePropertyChanged("Name");
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
                    RaisePropertyChanged("Rate");
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
                    RaisePropertyChanged("Amount");
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
                    RaisePropertyChanged("Title");
                }
            }
        }

        private void Convert()
        {
            decimal convertAmount = Amount * Rate;
            Title = string.Format("Amount in {0}", convertAmount);
        }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
