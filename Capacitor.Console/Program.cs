using CalcCapacitor.Lib;
using ValueService.Lib;


ValueServices _vs = new ValueServices();
decimal r = 100; string rpostfactor = "k";
decimal v = 12;
decimal c = 470; string cpostfactor = "n";
r = _vs.Pow10PostFactor(r, rpostfactor);
c = _vs.Pow10PostFactor(c, cpostfactor);

decimal time = Capacitor.LoadTime(r, c);
decimal tau = time / 5;
_vs.GetDisplayValue(Capacitor.ChargingCurrent(v, r), 2);


Console.WriteLine("Loadtime: " + _vs.GetDisplayValue(Capacitor.LoadTime(r, c), 2));
Console.WriteLine("Charging current: " +_vs.GetDisplayValue(Capacitor.ChargingCurrent(v, r), 2));
Console.WriteLine("Time constant: " + _vs.GetDisplayValue(tau, 2));
Console.WriteLine("Capacity: " +_vs.GetDisplayValue(Capacitor.Capacity(tau ,r), 2));