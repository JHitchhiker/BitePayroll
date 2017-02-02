using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitePayroll
{
    public static class Extensions
    {
        public static double ToDouble(this TextBox textBox)
        {
            return textBox.Text != "" ? Convert.ToDouble(textBox.Text) : 0.00;
        }

        public static int ToInt(this TextBox textBox)
        {
            return textBox.Text != "" ? Convert.ToInt16(textBox.Text) : 0;
        }
    }
}
