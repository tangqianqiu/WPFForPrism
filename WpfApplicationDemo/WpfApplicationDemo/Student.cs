using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplicationDemo
{
    public class Student:INotifyPropertyChanged
    {
        private string _firstName = "";
        private string _secondName = "";

        public Student(string firstName, string secondName)
        {
            this._firstName = firstName;
            this._secondName = secondName;
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
      
        public string SecondName
        {
            get { return _secondName; }
            set { _secondName = value; }
        }

        void Notify(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
