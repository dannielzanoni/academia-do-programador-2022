namespace GeradorDeTestes
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnGerarPDF = new System.Windows.Forms.Button();
            this.btnTestes = new System.Windows.Forms.Button();
            this.btnQuestoes = new System.Windows.Forms.Button();
            this.btnMaterias = new System.Windows.Forms.Button();
            this.btnDisciplinas = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRegistros
            // 
            this.panelRegistros.Location = new System.Drawing.Point(206, 106);
            this.panelRegistros.Name = "panelRegistros";
            this.panelRegistros.Size = new System.Drawing.Size(655, 403);
            this.panelRegistros.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelMenu.Controls.Add(this.btnGerarPDF);
            this.panelMenu.Controls.Add(this.btnTestes);
            this.panelMenu.Controls.Add(this.btnQuestoes);
            this.panelMenu.Controls.Add(this.btnMaterias);
            this.panelMenu.Controls.Add(this.btnDisciplinas);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 521);
            this.panelMenu.TabIndex = 1;
            // 
            // btnGerarPDF
            // 
            this.btnGerarPDF.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnGerarPDF.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGerarPDF.FlatAppearance.BorderSize = 0;
            this.btnGerarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarPDF.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGerarPDF.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGerarPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnGerarPDF.Image")));
            this.btnGerarPDF.Location = new System.Drawing.Point(0, 340);
            this.btnGerarPDF.Name = "btnGerarPDF";
            this.btnGerarPDF.Size = new System.Drawing.Size(200, 60);
            this.btnGerarPDF.TabIndex = 5;
            this.btnGerarPDF.Text = "Gerar PDF";
            this.btnGerarPDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerarPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGerarPDF.UseVisualStyleBackColor = false;
            // 
            // btnTestes
            // 
            this.btnTestes.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnTestes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTestes.FlatAppearance.BorderSize = 0;
            this.btnTestes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestes.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTestes.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTestes.Image = ((System.Drawing.Image)(resources.GetObject("btnTestes.Image")));
            this.btnTestes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestes.Location = new System.Drawing.Point(0, 280);
            this.btnTestes.Name = "btnTestes";
            this.btnTestes.Size = new System.Drawing.Size(200, 60);
            this.btnTestes.TabIndex = 4;
            this.btnTestes.Text = "Testes";
            this.btnTestes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTestes.UseVisualStyleBackColor = false;
            // 
            // btnQuestoes
            // 
            this.btnQuestoes.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnQuestoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuestoes.FlatAppearance.BorderSize = 0;
            this.btnQuestoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestoes.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuestoes.ForeColor = System.Drawing.SystemColors.Window;
            this.btnQuestoes.Image = ((System.Drawing.Image)(resources.GetObject("btnQuestoes.Image")));
            this.btnQuestoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuestoes.Location = new System.Drawing.Point(0, 220);
            this.btnQuestoes.Name = "btnQuestoes";
            this.btnQuestoes.Size = new System.Drawing.Size(200, 60);
            this.btnQuestoes.TabIndex = 3;
            this.btnQuestoes.Text = "Questões";
            this.btnQuestoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuestoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuestoes.UseVisualStyleBackColor = false;
            // 
            // btnMaterias
            // 
            this.btnMaterias.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnMaterias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaterias.FlatAppearance.BorderSize = 0;
            this.btnMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterias.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMaterias.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMaterias.Image = ((System.Drawing.Image)(resources.GetObject("btnMaterias.Image")));
            this.btnMaterias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterias.Location = new System.Drawing.Point(0, 160);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Size = new System.Drawing.Size(200, 60);
            this.btnMaterias.TabIndex = 2;
            this.btnMaterias.Text = "Matérias";
            this.btnMaterias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaterias.UseVisualStyleBackColor = false;
            this.btnMaterias.Click += new System.EventHandler(this.btnMaterias_Click);
            // 
            // btnDisciplinas
            // 
            this.btnDisciplinas.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDisciplinas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDisciplinas.FlatAppearance.BorderSize = 0;
            this.btnDisciplinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisciplinas.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisciplinas.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDisciplinas.Image = ((System.Drawing.Image)(resources.GetObject("btnDisciplinas.Image")));
            this.btnDisciplinas.Location = new System.Drawing.Point(0, 100);
            this.btnDisciplinas.Name = "btnDisciplinas";
            this.btnDisciplinas.Size = new System.Drawing.Size(200, 60);
            this.btnDisciplinas.TabIndex = 1;
            this.btnDisciplinas.Text = "Disciplinas";
            this.btnDisciplinas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisciplinas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDisciplinas.UseVisualStyleBackColor = false;
            this.btnDisciplinas.Click += new System.EventHandler(this.btnDisciplinas_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.SlateBlue;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnInserir.FlatAppearance.BorderSize = 0;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.Location = new System.Drawing.Point(0, 0);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(67, 100);
            this.btnInserir.TabIndex = 2;
            this.btnInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(73, 0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(65, 100);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(144, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(67, 97);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel4.Controls.Add(this.btnExcluir);
            this.panel4.Controls.Add(this.btnInserir);
            this.panel4.Controls.Add(this.btnEditar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(200, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(673, 100);
            this.panel4.TabIndex = 5;
            // 
            // TelaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 521);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelRegistros);
            this.MaximizeBox = false;
            this.Name = "TelaPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Testes";
            this.panelMenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRegistros;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnGerarPDF;
        private System.Windows.Forms.Button btnTestes;
        private System.Windows.Forms.Button btnQuestoes;
        private System.Windows.Forms.Button btnMaterias;
        private System.Windows.Forms.Button btnDisciplinas;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel panel4;
    }
}
