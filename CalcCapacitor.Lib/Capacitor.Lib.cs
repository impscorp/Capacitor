
namespace CalcCapacitor.Lib;

public class Capacitor
{

    #region Properties

    #endregion

    #region Constructors



    #endregion

    #region Methods
    /// <summary>
    /// Calculates the Charging current of a capacitor
    /// </summary>
    /// <param name="v">volt</param>
    /// <param name="r">ohm</param>
    /// <returns></returns>
    public static decimal ChargingCurrent(decimal v, decimal r)
    {
        return v / r;
    }

    /// <summary>
    /// Calculates the load time of a capacitor
    /// </summary>
    /// <param name="r">ohm</param>
    /// <param name="c">farad</param>
    /// <returns></returns>
    public static decimal LoadTime(decimal r, decimal c)
    {
        return r * c * 5;
    }
    
    /// <summary>
    /// Calculates the Capacity of a capacitor
    /// </summary>
    /// <param name="tau">LoadTime / 5</param>
    /// <param name="r">ohm</param>
    /// <returns></returns>
    public static decimal Capacity(decimal tau, decimal r)
    {
        return tau / r;
    }
    
    #endregion
}