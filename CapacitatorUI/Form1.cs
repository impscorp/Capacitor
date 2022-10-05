using ValueService.Lib;

namespace CapacitatorUI
{
    public partial class Form1 : Form
    {
        ValueServices _vs = new ValueServices();
        public Form1()
        {
            InitializeComponent();
            rPostFactor.DataSource = _vs.PostFactors.Select(x => x.Text += " Ω").ToList();
            cPostFactor.DataSource = _vs.PostFactors.Select(x => x.Text += " F").ToList();
            vPostFactor.DataSource = _vs.PostFactors.Select(x => x.Text += " V").ToList();
            iPostFactor.DataSource = _vs.PostFactors.Select(x => x.Text += " A").ToList();
            tPostFactor.DataSource = _vs.PostFactors.Select(x => x.Text += " s").ToList();
            tauPostFactor.DataSource = _vs.PostFactors.Select(x => x.Text += " s").ToList();       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal r = Convert.ToDecimal(R.Text); string rpostfactor = rPostFactor.Text;
            decimal v = Convert.ToDecimal(V.Text); string vpostfactor = vPostFactor.Text;
            decimal c = Convert.ToDecimal(C.Text); string cpostfactor = cPostFactor.Text;
            decimal i = Convert.ToDecimal(I.Text); string ipostfactor = iPostFactor.Text;
            decimal t = Convert.ToDecimal(Tau.Text); string tpostfactor = tPostFactor.Text;
            decimal tau = Convert.ToDecimal(Time.Text); string taupostfactor = tauPostFactor.Text;
            
            
            r = _vs.Pow10PostFactor(r, rpostfactor);
            c = _vs.Pow10PostFactor(c, cpostfactor);
            v = _vs.Pow10PostFactor(v, vpostfactor);

        }
    }
}