namespace Arithmetic.Core.Interfaces;

public interface IForce
{
    string Location { get; set; }
    double F1 { get; set; }
    double F2 { get; set; }
    double F3 { get; set; }
    double M1 { get; set; }
    double M2 { get; set; }
    double M3 { get; set; }
}