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
            sbSQL.Append(RTxtSql.Text
                        .Replace("\\", "")
                        .Replace("\"", "")
                        .Replace(";", ""));

            try
            {
                LblFormatando.Text = "Formatação em andamento...";
                ResultadoApi resultadoApi = await ApiFormatarSql.FormatarSql(sbSQL);
                RTxtSqlFormatado.Text = resultadoApi.Result;
                LblFormatando.Text = "Formatação concluida...";
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

        private void BtnCopiarSQLFormatado_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(RTxtSqlFormatado.Text))
            {
                Clipboard.SetText(RTxtSqlFormatado.Text);
            }
        }

        private void RTxtSqlFormatado_TextChanged(object sender, EventArgs e)
        {
            if (RTxtSqlFormatado.TextLength > 0)
            {
                BtnCopiarSQLFormatado.Enabled = true;
            }
            else
            {
                BtnCopiarSQLFormatado.Enabled = false;
            }
        }
    }
}