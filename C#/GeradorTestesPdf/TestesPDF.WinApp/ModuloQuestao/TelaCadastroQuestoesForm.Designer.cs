namespace TestesPDF.WinApp.ModuloQuestao
{
    partial class TelaCadastroQuestoesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.cmbDisciplinas = new System.Windows.Forms.ComboBox();
            this.cmbMaterias = new System.Windows.Forms.ComboBox();
            this.txtRichEnunciado = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listAlternativaas = new System.Windows.Forms.ListBox();
            this.checkAlternativaCorreta = new System.Windows.Forms.CheckBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Disciplina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Matéria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enunciado:";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(93, 29);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(36, 23);
            this.txtNumero.TabIndex = 4;
            // 
            // cmbDisciplinas
            // 
            this.cmbDisciplinas.DisplayMember = "Nome";
            this.cmbDisciplinas.FormattingEnabled = true;
            this.cmbDisciplinas.Location = new System.Drawing.Point(93, 73);
            this.cmbDisciplinas.Name = "cmbDisciplinas";
            this.cmbDisciplinas.Size = new System.Drawing.Size(121, 23);
            this.cmbDisciplinas.TabIndex = 5;
            // 
            // cmbMaterias
            // 
            this.cmbMaterias.DisplayMember = "Nome";
            this.cmbMaterias.FormattingEnabled = true;
            this.cmbMaterias.Location = new System.Drawing.Point(93, 120);
            this.cmbMaterias.Name = "cmbMaterias";
            this.cmbMaterias.Size = new System.Drawing.Size(121, 23);
            this.cmbMaterias.TabIndex = 6;
            // 
            // txtRichEnunciado
            // 
            this.txtRichEnunciado.Location = new System.Drawing.Point(93, 168);
            this.txtRichEnunciado.Name = "txtRichEnunciado";
            this.txtRichEnunciado.Size = new System.Drawing.Size(334, 101);
            this.txtRichEnunciado.TabIndex = 8;
            this.txtRichEnunciado.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.listAlternativaas);
            this.panel1.Controls.Add(this.checkAlternativaCorreta);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(21, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 265);
            this.panel1.TabIndex = 9;
            // 
            // listAlternativaas
            // 
            this.listAlternativaas.FormattingEnabled = true;
            this.listAlternativaas.ItemHeight = 15;
            this.listAlternativaas.Location = new System.Drawing.Point(16, 103);
            this.listAlternativaas.Name = "listAlternativaas";
            this.listAlternativaas.Size = new System.Drawing.Size(350, 139);
            this.listAlternativaas.TabIndex = 5;
            // 
            // checkAlternativaCorreta
            // 
            this.checkAlternativaCorreta.AutoSize = true;
            this.checkAlternativaCorreta.Location = new System.Drawing.Point(72, 67);
            this.checkAlternativaCorreta.Name = "checkAlternativaCorreta";
            this.checkAlternativaCorreta.Size = new System.Drawing.Size(125, 19);
            this.checkAlternativaCorreta.TabIndex = 4;
            this.checkAlternativaCorreta.Text = "Alternativa Correta";
            this.checkAlternativaCorreta.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(298, 38);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(90, 23);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(74, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 23);
            this.textBox2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Reposta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Alternativas";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(252, 596);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(86, 38);
            this.btnGravar.TabIndex = 10;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 596);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TelaCadastroQuestoesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 650);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRichEnunciado);
            this.Controls.Add(this.cmbMaterias);
            this.Controls.Add(this.cmbDisciplinas);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadastroQuestoesForm";
            this.Text = "Cadastro de Questões";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ComboBox cmbDisciplinas;
        private System.Windows.Forms.ComboBox cmbMaterias;
        private System.Windows.Forms.RichTextBox txtRichEnunciado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkAlternativaCorreta;
        private System.Windows.Forms.ListBox listAlternativaas;
    }
}