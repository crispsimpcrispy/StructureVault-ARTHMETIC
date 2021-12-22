namespace Arithmetic.Concrete.Interfaces;

public interface IConcreteMaterial
{
    double Density { get; set; }
    double ModulusOfElasticity { get; }
    double ModulusOfRupture { get; }
    double AverageSplittingTensileStrength { get; set; }
    double lambda { get; }
    double SpecifiedCompressiveStrength { get; set; }
    double Sqrt_f_c_prime { get; }
    double beta1 { get; }
    double UltimateCompressiveStrain { get; }
}