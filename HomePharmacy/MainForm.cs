namespace HomePharmacy
{

    public enum FormTabs
    {
        Login,
        Registration,
        CabinetSelection,
        CreateFamily,
        Main
    }

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void PageChange(object? sender, FormTabs tab)
        {
            this.tab_main.SelectTab(Convert.ToInt32(tab));
        }
    }
}