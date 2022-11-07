namespace System_Application
{
    public partial class Contas : UserControl
    {
        readonly Form DefaulForm;
        public Contas(Form DefaulForm)
        {
            InitializeComponent();
            this.DefaulForm = DefaulForm;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Form register = new Cadastro();
            register.ShowDialog(DefaulForm);
        }

        private void BtnTools_Click(object sender, EventArgs e)
        {
            Form Tools = new Ferramentas();
            Tools.ShowDialog(DefaulForm);
        }
    }
}
