using PR5;

var converter = new PressureConverter();

Console.WriteLine("1 bar = " + converter.BarsToPascals(1) + " Pa");
Console.WriteLine("101325 Pa = " + converter.PascalsToAtmospheres(101325) + " atm");
Console.WriteLine("1 atm = " + converter.AtmospheresToPascals(1) + " Pa");
Console.WriteLine("100000 Pa = " + converter.PascalsToBars(100000) + " bar");
Console.WriteLine("1 bar = " + converter.BarsToAtmospheres(1) + " atm");
Console.WriteLine("1 atm = " + converter.AtmospheresToBars(1) + " bar");
