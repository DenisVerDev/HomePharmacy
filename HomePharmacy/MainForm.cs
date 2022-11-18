namespace HomePharmacy
{

    public delegate void PageChangeEvent(FormTabs tab, object? data);

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

        private void PageChange(FormTabs tab, object? data)
        {
            this.tab_main.SelectTab(Convert.ToInt32(tab));
            this.tab_main.SelectedTab.Tag = data;
        }
    }
}