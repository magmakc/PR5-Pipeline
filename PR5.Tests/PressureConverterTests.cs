using PR5;

namespace PR5.Tests;

public class PressureConverterTests
{
    [Fact]
    public void BarsToPascals_OneBar_Returns100000()
    {
        var converter = new PressureConverter();
        Assert.Equal(100000.0, converter.BarsToPascals(1));
    }

    [Fact]
    public void PascalsToBars_100000_Returns1()
    {
        var converter = new PressureConverter();
        Assert.Equal(1.0, converter.PascalsToBars(100000));
    }

    [Fact]
    public void AtmospheresToPascals_OneAtm_Returns101325()
    {
        var converter = new PressureConverter();
        Assert.Equal(101325.0, converter.AtmospheresToPascals(1));
    }

    [Fact]
    public void PascalsToAtmospheres_101325_Returns1()
    {
        var converter = new PressureConverter();
        Assert.Equal(1.0, converter.PascalsToAtmospheres(101325));
    }

    [Fact]
    public void BarsToAtmospheres_OneBar_ReturnsApprox0Point986923()
    {
        var converter = new PressureConverter();
        Assert.Equal(0.986923, converter.BarsToAtmospheres(1), 6);
    }

    [Fact]
    public void AtmospheresToBars_OneAtm_Returns1Point01325()
    {
        var converter = new PressureConverter();
        Assert.Equal(1.01325, converter.AtmospheresToBars(1), 5);
    }
}
