namespace Arithmetic.Concrete.Interfaces;

public interface IRebar
{
    double Area { get; set; }

    //RebarDesignation Designation { get; set; }
    double Diameter { get; set; }

    //string ID { get; set; }
    double GetDesignStress();
    double GetDesignForce();
    double GetStress(double Strain);
    double GetForce(double Strain);
    IRebarMaterial Material { get; set; }
    bool IsTensionOnly { get; set; }
}