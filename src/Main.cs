using System_Application.src.CustonsWindows;

namespace System_Application
{
    public partial class Main : Form
    {
        readonly NavigationView navigationView;
        readonly NavigateButton navigateButton;

        public Main()
        {
            InitializeComponent();
            ManagementXML.Init();

            view.BringToFront();
            List<UserControl> userControls = new() { new PaginaInicial(), new Contas(this) };
            navigationView = new(userControls, view);

            List<Button> buttons = new() { BtnAccounts, btn_info };
            navigateButton = new(buttons, Color.FromArgb(32, 33, 36), Color.Gray);

            navigateButton.SelectButton(1);

            ManagementXML.RestartIDs();
        }

        private void BtnAccounts_Click(object sender, EventArgs e)
        {
            navigateButton.SelectButton(0);
            navigationView.Display(1);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            navigateButton.SelectButton(1);
            navigationView.Display(0);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (MessageBoxCustom.Show("Deseja cancelar mesmo?", "Cancelar", this)
                == DialogResult.Cancel);
        }
    }
}