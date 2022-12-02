namespace System_Application.src.CustonsWindows
{
    public partial class MessageBoxCustom : Form
    {
        public MessageBoxCustom()
        {
            InitializeComponent();
        }

        public DialogResult result { get; private set; }

        public static DialogResult Show(string text, string caption)
        {
            MessageBoxCustom msgBox = new();
            msgBox.Text = caption;
            msgBox.LbText.Text = text;
            msgBox.ShowDialog();
            return msgBox.result;
        }

        public static DialogResult Show(string text, string caption, Form parent)
        {
            MessageBoxCustom msgBox = new();
            msgBox.Text = caption;
            msgBox.LbText.Text = text;
            msgBox.StartPosition = FormStartPosition.CenterParent;
            msgBox.ShowDialog(parent);
            return msgBox.result;
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel;
            Close();
        }
    }
}
