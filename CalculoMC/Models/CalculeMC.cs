
namespace CalculoMC.Models
{
    public class CalculeMC
    {
        public double Weight { get; set; } // peso
        public double Height { get; set; } // altura
        public double Waist { get; set; } // cintura
        public double Neck { get; set; } // cuello
        public double? Hip { get; set; } // cadera
        public char Sex { get; set; }
    }
    public class mTable
    {
        public string Color { get; set; }
        public string Text1 { get; set; }
        public string Text2 { get; set; }
    }
}