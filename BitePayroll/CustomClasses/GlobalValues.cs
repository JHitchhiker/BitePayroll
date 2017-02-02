using System;
using System.Windows.Forms;

namespace BitePayroll
{
    public class GlobalValues
    {
        private static GlobalValues instance;
        public int CurrentMonth { get; set; }
        public int CurrentVatRate { get; set; }
        public int CurrentContractor { get; set; }

        public static GlobalValues Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GlobalValues();
                }
                return instance;
            }
        }
        private GlobalValues() { }

        public bool numeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            return !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete && e.KeyChar != Char.Parse(".");
        }
    }
}
