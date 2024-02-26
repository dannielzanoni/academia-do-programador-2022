namespace TestesPDF.WinApp
{
    partial class TelaPrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
            this.panelRegistros = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questaoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbox = new System.Windows.Forms.ToolStrip();
            this.btnInserir = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdicionarQuestoes = new System.Windows.Forms.ToolStripButton();
            this.btnAtualizarQuestoes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGerarPDF = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.labelTipoCadastro = new System.Windows.Forms.ToolStripLabel();
            this.labelRodape = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.toolbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRegistros
            // 
            this.panelRegistros.Location = new System.Drawing.Point(0, 96);
            this.panelRegistros.Name = "panelRegistros";
            this.panelRegistros.Size = new System.Drawing.Size(836, 390);
            this.panelRegistros.TabIndex = 0;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(836, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disciplinasMenuItem,
            this.materiasMenuItem,
            this.questaoMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // disciplinasMenuItem
            // 
            this.disciplinasMenuItem.Name = "disciplinasMenuItem";
            this.disciplinasMenuItem.Size = new System.Drawing.Size(180, 22);
            this.disciplinasMenuItem.Text = "Disciplinas";
            this.disciplinasMenuItem.Click += new System.EventHandler(this.disciplinasMenuItem_Click);
            // 
            // materiasMenuItem
            // 
            this.materiasMenuItem.Name = "materiasMenuItem";
            this.materiasMenuItem.Size = new System.Drawing.Size(180, 22);
            this.materiasMenuItem.Text = "Materias";
            this.materiasMenuItem.Click += new System.EventHandler(this.materiasMenuItem_Click);
            // 
            // questaoMenuItem
            // 
            this.questaoMenuItem.Name = "questaoMenuItem";
            this.questaoMenuItem.Size = new System.Drawing.Size(180, 22);
            this.questaoMenuItem.Text = "Questoes";
            this.questaoMenuItem.Click += new System.EventHandler(this.questaoMenuItem_Click);
            // 
            // toolbox
            // 
            this.toolbox.Enabled = false;
            this.toolbox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInserir,
            this.btnEditar,
            this.btnExcluir,
            this.toolStripSeparator2,
            this.btnAdicionarQuestoes,
            this.btnAtualizarQuestoes,
            this.toolStripSeparator1,
            this.btnGerarPDF,
            this.toolStripSeparator3,
            this.labelTipoCadastro});
            this.toolbox.Location = new System.Drawing.Point(0, 24);
            this.toolbox.Name = "toolbox";
            this.toolbox.Size = new System.Drawing.Size(836, 41);
            this.toolbox.TabIndex = 2;
            this.toolbox.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            this.btnInserir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInserir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Padding = new System.Windows.Forms.Padding(5);
            this.btnInserir.Size = new System.Drawing.Size(38, 38);
            this.btnInserir.Text = "Inserir";
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(5);
            this.btnEditar.Size = new System.Drawing.Size(38, 38);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = global::TestesPDF.WinApp.Properties.Resources.outline_delete_black_24dp;
            this.btnExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Padding = new System.Windows.Forms.Padding(5);
            this.btnExcluir.Size = new System.Drawing.Size(38, 38);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 41);
            // 
            // btnAdicionarQuestoes
            // 
            this.btnAdicionarQuestoes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdicionarQuestoes.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarQuestoes.Image")));
            this.btnAdicionarQuestoes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdicionarQuestoes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdicionarQuestoes.Name = "btnAdicionarQuestoes";
            this.btnAdicionarQuestoes.Padding = new System.Windows.Forms.Padding(5);
            this.btnAdicionarQuestoes.Size = new System.Drawing.Size(38, 38);
            // 
            // btnAtualizarQuestoes
            // 
            this.btnAtualizarQuestoes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAtualizarQuestoes.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizarQuestoes.Image")));
            this.btnAtualizarQuestoes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAtualizarQuestoes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtualizarQuestoes.Name = "btnAtualizarQuestoes";
            this.btnAtualizarQuestoes.Padding = new System.Windows.Forms.Padding(5);
            this.btnAtualizarQuestoes.Size = new System.Drawing.Size(38, 38);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 41);
            // 
            // btnGerarPDF
            // 
            this.btnGerarPDF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGerarPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnGerarPDF.Image")));
            this.btnGerarPDF.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGerarPDF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGerarPDF.Name = "btnGerarPDF";
            this.btnGerarPDF.Padding = new System.Windows.Forms.Padding(5);
            this.btnGerarPDF.Size = new System.Drawing.Size(38, 38);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 41);
            // 
            // labelTipoCadastro
            // 
            this.labelTipoCadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelTipoCadastro.Name = "labelTipoCadastro";
            this.labelTipoCadastro.Size = new System.Drawing.Size(90, 38);
            this.labelTipoCadastro.Text = "[tipoCadastro]";
            // 
            // labelRodape
            // 
            this.labelRodape.AutoSize = true;
            this.labelRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelRodape.Location = new System.Drawing.Point(0, 497);
            this.labelRodape.Name = "labelRodape";
            this.labelRodape.Size = new System.Drawing.Size(52, 15);
            this.labelRodape.TabIndex = 3;
            this.labelRodape.Text = "[rodapé]";
            // 
            // TelaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 512);
            this.Controls.Add(this.labelRodape);
            this.Controls.Add(this.toolbox);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.panelRegistros);
            this.MaximizeBox = false;
            this.Name = "TelaPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Testes";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.toolbox.ResumeLayout(false);
            this.toolbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelRegistros;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disciplinasMenuItem;
        private System.Windows.Forms.ToolStrip toolbox;
        private System.Windows.Forms.ToolStripButton btnInserir;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnAdicionarQuestoes;
        private System.Windows.Forms.ToolStripButton btnAtualizarQuestoes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnGerarPDF;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel labelTipoCadastro;
        private System.Windows.Forms.Label labelRodape;
        private System.Windows.Forms.ToolStripMenuItem materiasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questaoMenuItem;
    }
}
