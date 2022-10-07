using ValueService.Lib;

namespace CapacitatorUI
{
    public partial class Form1 : Form
    {
        ValueServices _vs = new ValueServices();
        CalcCapacitor.Lib.Capacitor _cap = new CalcCapacitor.Lib.Capacitor();
        public Form1()
        {
            InitializeComponent();            
            rPostFactor.DataSource = _vs.PostFactors.Select(x => x.TextShort += " Ω").ToList();
            cPostFactor.DataSource = _vs.PostFactors.Select(x => x.TextShort.Replace(" Ω", " F")).ToList();
            vPostFactor.DataSource = _vs.PostFactors.Select(x => x.TextShort.Replace(" Ω", " V")).ToList();
            iPostFactor.DataSource = _vs.PostFactors.Select(x => x.TextShort.Replace(" Ω", " A")).ToList();
            tPostFactor.DataSource = _vs.PostFactors.Select(x => x.TextShort.Replace(" Ω", " s")).ToList();
            tauPostFactor.DataSource = _vs.PostFactors.Select(x => x.TextShort.Replace(" Ω", " s")).ToList();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //converts the user input to decimal
            decimal r = string.IsNullOrWhiteSpace(R.Text) ? 0 : Convert.ToDecimal(R.Text); string rpostfactor = rPostFactor.SelectedItem.ToString().Replace("Ω", "").Trim();
            decimal c = string.IsNullOrWhiteSpace(C.Text) ? 0 : Convert.ToDecimal(C.Text); string vpostfactor = vPostFactor.SelectedItem.ToString().Replace(" V", "").Trim();
            decimal v = string.IsNullOrWhiteSpace(V.Text) ? 0 : Convert.ToDecimal(V.Text); string cpostfactor = cPostFactor.SelectedItem.ToString().Replace(" F", "").Trim();
            decimal i = string.IsNullOrWhiteSpace(I.Text) ? 0 : Convert.ToDecimal(I.Text); string ipostfactor = iPostFactor.SelectedItem.ToString().Replace(" A", "").Trim();
            decimal t = string.IsNullOrWhiteSpace(Time.Text) ? 0 : Convert.ToDecimal(Time.Text); string tpostfactor = tPostFactor.SelectedItem.ToString().Replace(" s", "").Trim();
            decimal tau = string.IsNullOrWhiteSpace(Tau.Text) ? 0 : Convert.ToDecimal(Tau.Text); string taupostfactor = tauPostFactor.SelectedItem.ToString().Replace(" s", "").Trim();

            //scales the user input to the base value
            r = _cap.Pow10PostFactor(r, rpostfactor);
            c = _cap.Pow10PostFactor(c, cpostfactor);
            v = _cap.Pow10PostFactor(v, vpostfactor);
            i = _cap.Pow10PostFactor(i, ipostfactor);
            t = _cap.Pow10PostFactor(t, tpostfactor);
            tau = _cap.Pow10PostFactor(tau, taupostfactor);
            
            //calculates the non empty values
            if (r == 0) R.Text = Convert.ToString(CalcCapacitor.Lib.Capacitor.Resistance(v, i));
            if (c == 0) C.Text = Convert.ToString(CalcCapacitor.Lib.Capacitor.Capacity(tau, r));
            if (v == 0) V.Text = Convert.ToString(CalcCapacitor.Lib.Capacitor.Voltage(r, i));
            if (i == 0) I.Text = Convert.ToString(CalcCapacitor.Lib.Capacitor.ChargingCurrent(v, r));
            if (t == 0) Time.Text = Convert.ToString(CalcCapacitor.Lib.Capacitor.LoadTime(r, c));
            if (tau == 0) Tau.Text = Convert.ToString(CalcCapacitor.Lib.Capacitor.TimeConstant(r, c));
        }
    }
}