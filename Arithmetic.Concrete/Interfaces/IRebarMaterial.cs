namespace Arithmetic.Concrete.Interfaces;

public interface IRebarMaterial
{
    string Name { get; }
    double YieldStress { get; }
    double YieldStrain { get; }
    double GetUltimateStrain(double Diameter);
    double GetStress(double Strain);
    double GetDesignStress();
}