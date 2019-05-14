using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PsWPFXamlFundaDataBinding.Annotations;

namespace PsWPFXamlFundaDataBinding
{
    public class Person : INotifyPropertyChanged
    {

        private string _nameValue;
        public string Name
        {
            get { return _nameValue; }
            set { _nameValue = value; }
        }

        private double ageValue;
        public double Age
        {
            get { return ageValue; }
            set
            {
                if (value != ageValue)
                {
                    ageValue = value;
                   OnPropertyChanged("Age"); 
                }
                
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
