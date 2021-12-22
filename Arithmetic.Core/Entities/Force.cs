using Arithmetic.Core.Interfaces;

namespace Arithmetic.Core.Entities;

public class Force : IForce
{
    public string Location { get; set; }
    public double F1 { get; set; }
    public double F2 { get; set; }
    public double F3 { get; set; }
    public double M1 { get; set; }
    public double M2 { get; set; }
    public double M3 { get; set; }

    public Force()
    {
    }

    public Force(string Location, double F1, double F2, double F3, double M1, double M2, double M3)
    {
        this.Location = Location;
        this.F1 = F1;
        this.F2 = F2;
        this.F3 = F3;
        this.M1 = M1;
        this.M2 = M2;
        this.M3 = M3;
    }

    public Force(double F1, double F2, double F3, double M1, double M2, double M3)
        : this(null, F1, F2, F3, M1, M2, M3)
    {
    }
}
