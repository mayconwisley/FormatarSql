using System.Text;

namespace FormatarSql
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private async void BtnFormatarSql_Click(object sender, EventArgs e)
        {
            StringBuilder sbSQL = new();
            sbSQL.Append(RTxtSql.Text);

            try
            {
                ResultadoApi resultadoApi = await ApiFormatarSql.FormatarSql(sbSQL);
                RTxtSqlFormatado.Text = resultadoApi.Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RTxtSql_TextChanged(object sender, EventArgs e)
        {
            if (RTxtSql.TextLength > 0)
            {
                BtnFormatarSql.Enabled = true;
            }
            else
            {
                BtnFormatarSql.Enabled = false;
            }
        }
    }
}