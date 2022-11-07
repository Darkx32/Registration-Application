namespace System_Application
{
    public partial class Ferramentas : Form
    {
        public Ferramentas()
        {
            InitializeComponent();
            Search.Text = "Insira o nome de uma pessoa";
            Search.ForeColor = Color.Gray;
        }

        private void Ferramentas_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            ManagementXML.RestartIDs();
            dataView.Rows.Clear();

            List<User> users = ManagementXML.GetAllUsers();

            foreach (User user in users)
            {
                string[] values = { user.id, user.name, user.email, user.number, user.age, user.cpf };

                dataView.Rows.Add(values);
            }
        }

        private void dataView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dataView.Rows[e.RowIndex];
            ManagementXML.ChangeValueFromType(int.Parse(row.Cells[0].Value.ToString()) - 1,
                row.Cells[e.ColumnIndex].Value.ToString(), (ManagementXML.Values)e.ColumnIndex);
        }

        private void Search_Enter(object sender, EventArgs e)
        {
            Search.Text = string.Empty;
            Search.ForeColor = Color.Black;
        }

        private void Search_Leave(object sender, EventArgs e)
        {
            Search.Text = "Insira o nome de uma pessoa";
            Search.ForeColor = Color.Gray;
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (Search.Text == "Insira o nome de uma pessoa") return;

            for(int i = 0; i < dataView.Rows.Count ; i++)
            {
                if (dataView.Rows[i].Cells[(int)ManagementXML.Values.name].Value.ToString().Contains(Search.Text))
                {
                    dataView.Rows[i].Visible = true;
                } else
                {
                    dataView.Rows[i].Visible = false;
                }
            }
        }
    }
}
