namespace Hasan.badr_harjoitus4
{
    public partial class Ik‰Form : Form
    {
        public Ik‰Form()
        {
            InitializeComponent();
        }

        private void LakelkaBT_Click(object sender, EventArgs e)
        {
            DateTime synttari = SyntymaAikaDT.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Round((nyt - synttari).TotalDays);
            VuosinaLB.Text = Math.Ceiling(erotus / 365.25) + "Vuotta";
            KuukausinaLB.Text = Math.Ceiling(erotus * 12 / 365.25) + "kuukautta";
            p‰ivin‰LB.Text = erotus + "p‰iv‰‰";
            TunteinaLB.Text = erotus * 24 + "tuntia";
            MinuutteinaLB.Text = erotus * 24 * 60 + "minuuttia";
            SekunteinaLB.Text = erotus * 24 * 3600 + "sekuntia";
            VuosinaLB.Visible = true;
            KuukausinaLB.Visible = true;
            p‰ivin‰LB.Visible = true;
            TunteinaLB.Visible = true;
            MinuutteinaLB.Visible = true;
            SekunteinaLB.Visible = true;
        }
    }
}