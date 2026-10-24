namespace PR5;

public class PressureConverter
{
    private const double PascalsInBar = 100000.0;
    private const double PascalsInAtmosphere = 101325.0;

    public double PascalsToBars(double pascals)
    {
        return pascals / PascalsInBar;
    }

    public double BarsToPascals(double bars)
    {
        return bars * PascalsInBar;
    }

    public double AtmospheresToPascals(double atmospheres)
    {
        return atmospheres * PascalsInAtmosphere;
    }

    public double PascalsToAtmospheres(double pascals)
    {
        return pascals / PascalsInAtmosphere;
    }

    public double BarsToAtmospheres(double bars)
    {
        return PascalsToAtmospheres(BarsToPascals(bars));
    }

    public double AtmospheresToBars(double atmospheres)
    {
        return PascalsToBars(AtmospheresToPascals(atmospheres));
    }
}
