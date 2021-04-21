using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifyAppBase.ViewModel
{
    public class MainViewModel : ViewModelBase
    {

        public MainViewModel()
        {
            ClickCommand = new RelayCommand(ClickMethod);
            DoubleClickCommand = new RelayCommand(DoubleClickMethod);
            ClickWidthParamCommand = new RelayCommand<string>(ClickWidthParamMethod);
        }


        private string _NotifyString;

        public string NotifyString { get => _NotifyString; set => Set(ref _NotifyString, value); }

        private string _TextBoxInputString;

        public string TextBoxInputString { get => _TextBoxInputString; set => Set(ref _TextBoxInputString, value); }


        public RelayCommand ClickCommand { get; set; }
        public RelayCommand DoubleClickCommand { get; set; }
        public RelayCommand<string> ClickWidthParamCommand { get; set; }


        private void ClickWidthParamMethod(string obj)
        {
            //do something
            NotifyString = $"you click button & send param [{obj}]";
        }

        private void DoubleClickMethod()
        {
            //do something
            NotifyString = "you double click button";
        }

        private void ClickMethod()
        {
            //do something
            NotifyString = "you click button";
        }



    }
}
