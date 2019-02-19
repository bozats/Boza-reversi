using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfAero2.ModelGM
{
    public class MainModelGM : INotifyPropertyChanged
    {
        private string PropertyVisualState { get => PropertyVisualState; set => PropertyVisualState = value; }
        public string PropertyName { get => PropertyName; set => PropertyName = value; }

        public void GetVisualState(string value)
        {
            if (PropertyVisualState != value)
            {
                PropertyVisualState = value;
                RaisePropertyChanged("PropertyVisulaState");
                RaisePropertyChanged("PropertyName");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            MessageBox.Show("SCd");

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        
    }
}
