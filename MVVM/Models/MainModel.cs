using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Models
{
    public class MainModel
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        decimal rate;
        public decimal Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        decimal amount;
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
    }
}
