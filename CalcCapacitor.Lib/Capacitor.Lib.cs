using ValueService.Lib;

namespace CalcCapacitor.Lib;

public class Capacitor
{

    #region Properties

    #endregion

    #region Constructors
    public Capacitor()
    {

    }


    #endregion

    #region Methods
    /// <summary>
    /// Calculates the Charging current of a capacitor
    /// </summary>
    /// <param name="v">volt</param>
    /// <param name="r">ohm</param>
    /// <returns></returns>
    public static decimal ChargingCurrent(decimal v, decimal r) => v / r;

    /// <summary>
    /// Calculates the load time of a capacitor
    /// </summary>
    /// <param name="r">ohm</param>
    /// <param name="c">farad</param>
    /// <returns></returns>
    public static decimal LoadTime(decimal r, decimal c) => r * c * 5;
    
    /// <summary>
    /// Calculates the Capacity of a capacitor
    /// </summary>
    /// <param name="tau">LoadTime / 5</param>
    /// <param name="r">ohm</param>
    /// <returns></returns>
    public static decimal Capacity(decimal tau, decimal r) => tau / r;

    public static decimal Resistance(decimal v, decimal i) => v / i;

    public static decimal Voltage(decimal i, decimal r) => i * r;

    public static decimal TimeConstant(decimal r, decimal c) => r * c;

    public decimal Pow10PostFactor(decimal number, string PostFactor)
    {
        double.TryParse(Convert.ToString(GetPotenz(PostFactor)), out double dblpotenz);
        return number * (decimal)Math.Pow(10.00d, dblpotenz);
    }

    public int? GetPotenz(string value)
    {
        ValueServices _vs = new ValueServices();
        if (value == "") return 0;
        return _vs.PostFactors.FirstOrDefault(element => element.TextShort == value)?.Potenz;
    }

    #endregion
}