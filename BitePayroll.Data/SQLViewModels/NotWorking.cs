using System.ComponentModel.DataAnnotations.Schema;

namespace BitePayroll.Data
{
    
    public class Not_Working
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Working { get; set; }
        public double Week1 { get; set; }
        public double Week2 { get; set; }
        public double Week3 { get; set; }
        public double Week4 { get; set; }
        public double Week5 { get; set; }
        public int? Month { get; set; }
    }
}