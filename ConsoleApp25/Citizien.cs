using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp25
{
    internal class Citizien
    {
        public string Name;
        public string SurName;
        public static int _no = 1000;
        public Citizien()
        {
            _no++;
            _serialNo += "AZE" + _no;

        }
        private string _serialNo;
        public string SerialNo
        {
            get { return _serialNo; }




        }
    }
}
