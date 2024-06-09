namespace Capitulo14
{
    partial class MainForm
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
            this.LblNome = new System.Windows.Forms.Label();
            this.LblDataNascimento = new System.Windows.Forms.Label();
            this.LblEstadoCivil = new System.Windows.Forms.Label();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.TextNome = new System.Windows.Forms.TextBox();
            this.DateTimePickerDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.ComboBoxEstadoCivil = new System.Windows.Forms.ComboBox();
            this.MaskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.CheckBoxCasaPropria = new System.Windows.Forms.CheckBox();
            this.CheckBoxVeiculoProprio = new System.Windows.Forms.CheckBox();
            this.GroupBoxSexo = new System.Windows.Forms.GroupBox();
            this.RadioButtonOutro = new System.Windows.Forms.RadioButton();
            this.RadioButtonFem = new System.Windows.Forms.RadioButton();
            this.RadioButtonMasc = new System.Windows.Forms.RadioButton();
            this.ListBoxResult = new System.Windows.Forms.ListBox();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.GroupBoxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblNome
            // 
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(23, 15);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(61, 18);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome";
            // 
            // LblDataNascimento
            // 
            this.LblDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.LblDataNascimento.Location = new System.Drawing.Point(23, 69);
            this.LblDataNascimento.Name = "LblDataNascimento";
            this.LblDataNascimento.Size = new System.Drawing.Size(155, 20);
            this.LblDataNascimento.TabIndex = 1;
            this.LblDataNascimento.Text = "Data de Nascimento";
            // 
            // LblEstadoCivil
            // 
            this.LblEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.LblEstadoCivil.Location = new System.Drawing.Point(21, 120);
            this.LblEstadoCivil.Name = "LblEstadoCivil";
            this.LblEstadoCivil.Size = new System.Drawing.Size(63, 23);
            this.LblEstadoCivil.TabIndex = 2;
            this.LblEstadoCivil.Text = "Estado Civil";
            // 
            // LblTelefone
            // 
            this.LblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.LblTelefone.Location = new System.Drawing.Point(20, 170);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.Size = new System.Drawing.Size(100, 23);
            this.LblTelefone.TabIndex = 3;
            this.LblTelefone.Text = "Telefone";
            // 
            // TextNome
            // 
            this.TextNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.TextNome.Location = new System.Drawing.Point(215, 12);
            this.TextNome.Name = "TextNome";
            this.TextNome.Size = new System.Drawing.Size(292, 23);
            this.TextNome.TabIndex = 4;
            // 
            // DateTimePickerDataNascimento
            // 
            this.DateTimePickerDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.DateTimePickerDataNascimento.Location = new System.Drawing.Point(215, 60);
            this.DateTimePickerDataNascimento.Name = "DateTimePickerDataNascimento";
            this.DateTimePickerDataNascimento.Size = new System.Drawing.Size(292, 23);
            this.DateTimePickerDataNascimento.TabIndex = 5;
            // 
            // ComboBoxEstadoCivil
            // 
            this.ComboBoxEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ComboBoxEstadoCivil.FormattingEnabled = true;
            this.ComboBoxEstadoCivil.Location = new System.Drawing.Point(215, 110);
            this.ComboBoxEstadoCivil.Name = "ComboBoxEstadoCivil";
            this.ComboBoxEstadoCivil.Size = new System.Drawing.Size(292, 25);
            this.ComboBoxEstadoCivil.TabIndex = 6;
            // 
            // MaskedTextBoxTelefone
            // 
            this.MaskedTextBoxTelefone.Font = new System.Drawing.Font("Microsoft YaHei Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.MaskedTextBoxTelefone.Location = new System.Drawing.Point(215, 162);
            this.MaskedTextBoxTelefone.Mask = "(00) 00000-0000";
            this.MaskedTextBoxTelefone.Name = "MaskedTextBoxTelefone";
            this.MaskedTextBoxTelefone.Size = new System.Drawing.Size(292, 26);
            this.MaskedTextBoxTelefone.TabIndex = 7;
            // 
            // CheckBoxCasaPropria
            // 
            this.CheckBoxCasaPropria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.CheckBoxCasaPropria.Location = new System.Drawing.Point(23, 223);
            this.CheckBoxCasaPropria.Name = "CheckBoxCasaPropria";
            this.CheckBoxCasaPropria.Size = new System.Drawing.Size(186, 24);
            this.CheckBoxCasaPropria.TabIndex = 8;
            this.CheckBoxCasaPropria.Text = "Possui Casa Própria ?";
            this.CheckBoxCasaPropria.UseVisualStyleBackColor = true;
            // 
            // CheckBoxVeiculoProprio
            // 
            this.CheckBoxVeiculoProprio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.CheckBoxVeiculoProprio.Location = new System.Drawing.Point(23, 253);
            this.CheckBoxVeiculoProprio.Name = "CheckBoxVeiculoProprio";
            this.CheckBoxVeiculoProprio.Size = new System.Drawing.Size(202, 24);
            this.CheckBoxVeiculoProprio.TabIndex = 9;
            this.CheckBoxVeiculoProprio.Text = "Possui Veículo Próprio ?";
            this.CheckBoxVeiculoProprio.UseVisualStyleBackColor = true;
            // 
            // GroupBoxSexo
            // 
            this.GroupBoxSexo.Controls.Add(this.RadioButtonOutro);
            this.GroupBoxSexo.Controls.Add(this.RadioButtonFem);
            this.GroupBoxSexo.Controls.Add(this.RadioButtonMasc);
            this.GroupBoxSexo.Location = new System.Drawing.Point(305, 213);
            this.GroupBoxSexo.Name = "GroupBoxSexo";
            this.GroupBoxSexo.Size = new System.Drawing.Size(202, 106);
            this.GroupBoxSexo.TabIndex = 10;
            this.GroupBoxSexo.TabStop = false;
            this.GroupBoxSexo.Text = "Sexo";
            // 
            // RadioButtonOutro
            // 
            this.RadioButtonOutro.Location = new System.Drawing.Point(20, 79);
            this.RadioButtonOutro.Name = "RadioButtonOutro";
            this.RadioButtonOutro.Size = new System.Drawing.Size(104, 24);
            this.RadioButtonOutro.TabIndex = 2;
            this.RadioButtonOutro.TabStop = true;
            this.RadioButtonOutro.Text = "Outro";
            this.RadioButtonOutro.UseVisualStyleBackColor = true;
            // 
            // RadioButtonFem
            // 
            this.RadioButtonFem.Location = new System.Drawing.Point(20, 49);
            this.RadioButtonFem.Name = "RadioButtonFem";
            this.RadioButtonFem.Size = new System.Drawing.Size(104, 24);
            this.RadioButtonFem.TabIndex = 1;
            this.RadioButtonFem.TabStop = true;
            this.RadioButtonFem.Text = "Feminino";
            this.RadioButtonFem.UseVisualStyleBackColor = true;
            // 
            // RadioButtonMasc
            // 
            this.RadioButtonMasc.Location = new System.Drawing.Point(20, 19);
            this.RadioButtonMasc.Name = "RadioButtonMasc";
            this.RadioButtonMasc.Size = new System.Drawing.Size(104, 24);
            this.RadioButtonMasc.TabIndex = 0;
            this.RadioButtonMasc.TabStop = true;
            this.RadioButtonMasc.Text = "Masculino";
            this.RadioButtonMasc.UseVisualStyleBackColor = true;
            // 
            // ListBoxResult
            // 
            this.ListBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ListBoxResult.FormattingEnabled = true;
            this.ListBoxResult.ItemHeight = 20;
            this.ListBoxResult.Location = new System.Drawing.Point(568, 12);
            this.ListBoxResult.Name = "ListBoxResult";
            this.ListBoxResult.Size = new System.Drawing.Size(220, 424);
            this.ListBoxResult.TabIndex = 11;
            this.ListBoxResult.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxResult_MouseDoubleClick);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.BtnCadastrar.Location = new System.Drawing.Point(389, 364);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(118, 33);
            this.BtnCadastrar.TabIndex = 12;
            this.BtnCadastrar.Text = "Cadastrar/Alterar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(225, 364);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(118, 33);
            this.BtnExcluir.TabIndex = 13;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.BtnLimpar.Location = new System.Drawing.Point(60, 364);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(118, 33);
            this.BtnLimpar.TabIndex = 14;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.ListBoxResult);
            this.Controls.Add(this.GroupBoxSexo);
            this.Controls.Add(this.CheckBoxVeiculoProprio);
            this.Controls.Add(this.CheckBoxCasaPropria);
            this.Controls.Add(this.MaskedTextBoxTelefone);
            this.Controls.Add(this.ComboBoxEstadoCivil);
            this.Controls.Add(this.DateTimePickerDataNascimento);
            this.Controls.Add(this.TextNome);
            this.Controls.Add(this.LblTelefone);
            this.Controls.Add(this.LblEstadoCivil);
            this.Controls.Add(this.LblDataNascimento);
            this.Controls.Add(this.LblNome);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.GroupBoxSexo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button BtnLimpar;

        private System.Windows.Forms.Button BtnExcluir;

        private System.Windows.Forms.Button BtnCadastrar;

        private System.Windows.Forms.ListBox ListBoxResult;

        private System.Windows.Forms.RadioButton RadioButtonMasc;
        private System.Windows.Forms.RadioButton RadioButtonFem;
        private System.Windows.Forms.RadioButton RadioButtonOutro;

        private System.Windows.Forms.GroupBox GroupBoxSexo;

        private System.Windows.Forms.CheckBox CheckBoxVeiculoProprio;

        private System.Windows.Forms.CheckBox CheckBoxCasaPropria;

        private System.Windows.Forms.ComboBox ComboBoxEstadoCivil;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxTelefone;

        private System.Windows.Forms.DateTimePicker DateTimePickerDataNascimento;

        private System.Windows.Forms.Label LblEstadoCivil;
        private System.Windows.Forms.Label LblTelefone;
        private System.Windows.Forms.TextBox TextNome;

        private System.Windows.Forms.Label LblDataNascimento;

        private System.Windows.Forms.Label LblNome;

        #endregion
    }
}