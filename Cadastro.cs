namespace System_Application
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
            number.ValidatingType = typeof(int);
            cpf.ValidatingType = typeof(int);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (name.Text == string.Empty)
            {
                MessageBox.Show("O nome não pode estar vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int id = ManagementXML.GetCount() + 1;
                ManagementXML.AddUser(id.ToString(), name.Text, email.Text, number.Text, age.Text, cpf.Text);
            }
            catch
            {
                MessageBox.Show("Erro ao cadastrar nova pessoa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Pessoa cadastrada com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Cadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (MessageBox.Show("Deseja cancelar mesmo?", "Cancelar", MessageBoxButtons.YesNo) 
                == DialogResult.No);
        }
    }
}
