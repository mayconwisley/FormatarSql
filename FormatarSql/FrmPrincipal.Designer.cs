namespace FormatarSql
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            RTxtSql = new RichTextBox();
            RTxtSqlFormatado = new RichTextBox();
            BtnFormatarSql = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // RTxtSql
            // 
            RTxtSql.Dock = DockStyle.Fill;
            RTxtSql.Location = new Point(3, 19);
            RTxtSql.Name = "RTxtSql";
            RTxtSql.Size = new Size(881, 250);
            RTxtSql.TabIndex = 0;
            RTxtSql.Text = "";
            RTxtSql.TextChanged += RTxtSql_TextChanged;
            // 
            // RTxtSqlFormatado
            // 
            RTxtSqlFormatado.Dock = DockStyle.Fill;
            RTxtSqlFormatado.Location = new Point(3, 19);
            RTxtSqlFormatado.Name = "RTxtSqlFormatado";
            RTxtSqlFormatado.ReadOnly = true;
            RTxtSqlFormatado.Size = new Size(878, 237);
            RTxtSqlFormatado.TabIndex = 0;
            RTxtSqlFormatado.Text = "";
            // 
            // BtnFormatarSql
            // 
            BtnFormatarSql.Enabled = false;
            BtnFormatarSql.FlatAppearance.BorderColor = Color.Teal;
            BtnFormatarSql.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 64);
            BtnFormatarSql.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
            BtnFormatarSql.FlatStyle = FlatStyle.Flat;
            BtnFormatarSql.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            BtnFormatarSql.Location = new Point(666, 289);
            BtnFormatarSql.Name = "BtnFormatarSql";
            BtnFormatarSql.Size = new Size(233, 45);
            BtnFormatarSql.TabIndex = 1;
            BtnFormatarSql.Text = "Formatar SQL";
            BtnFormatarSql.UseVisualStyleBackColor = true;
            BtnFormatarSql.Click += BtnFormatarSql_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RTxtSql);
            groupBox1.Location = new Point(12, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(887, 272);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "SQL";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(RTxtSqlFormatado);
            groupBox2.Location = new Point(12, 340);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(884, 259);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "SQL Formatado";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 605);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(397, 23);
            textBox1.TabIndex = 4;
            textBox1.Text = "API Utilizada do site: https://sqlformat.org/api/";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 638);
            Controls.Add(textBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(BtnFormatarSql);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formatar SQL";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox RTxtSql;
        private RichTextBox RTxtSqlFormatado;
        private Button BtnFormatarSql;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox1;
    }
}