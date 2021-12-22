namespace Arithmetic.Concrete.CS455.Ch02_AssessmentProcess;

public abstract class ConditionFactor
{
    private double _conditionFactor;
    
    public double ConditionFactorValue
    {
        get => _conditionFactor;
        set
        {
            if (value <= 1.0)
            {
                _conditionFactor = ConditionFactorValue;
            }
            
        }
    }
}