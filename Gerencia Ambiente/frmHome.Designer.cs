﻿namespace Gerencia_Ambiente
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tbInicial = new System.Windows.Forms.TabControl();
            this.tbCriarAmbiente = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEspecificaPortal = new System.Windows.Forms.Button();
            this.lblEspecificaPortal = new System.Windows.Forms.Label();
            this.txtEspecificaPortal = new System.Windows.Forms.TextBox();
            this.btnEspecificaLabore = new System.Windows.Forms.Button();
            this.lblLaboreEspecifica = new System.Windows.Forms.Label();
            this.txtEspecificaLabore = new System.Windows.Forms.TextBox();
            this.cbUtilizaEspecifica = new System.Windows.Forms.CheckBox();
            this.btnEspecificaBiblioteca = new System.Windows.Forms.Button();
            this.lblBibliotecaEspecifica = new System.Windows.Forms.Label();
            this.txtEspecificaBiblioteca = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPortalCriar = new System.Windows.Forms.TextBox();
            this.btnPortal = new System.Windows.Forms.Button();
            this.lblPortalCriar = new System.Windows.Forms.Label();
            this.txtLaboreCriar = new System.Windows.Forms.TextBox();
            this.btnLabore = new System.Windows.Forms.Button();
            this.lblLaboreCriar = new System.Windows.Forms.Label();
            this.txtBibliotecaCriar = new System.Windows.Forms.TextBox();
            this.btnBiblioteca = new System.Windows.Forms.Button();
            this.checkPortal = new System.Windows.Forms.CheckBox();
            this.lblBibliotecaCriar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkVersao12 = new System.Windows.Forms.CheckBox();
            this.checkLabore = new System.Windows.Forms.CheckBox();
            this.checkBiblioteca = new System.Windows.Forms.CheckBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblTeste = new System.Windows.Forms.Label();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.processo = new System.Windows.Forms.Label();
            this.tbEditar = new System.Windows.Forms.TabPage();
            this.txtAmbienteAtualizar = new System.Windows.Forms.ComboBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblProcess = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAtualizarCaminho = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAtualizarExpefica = new System.Windows.Forms.TextBox();
            this.lblProcessando = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbInicial.SuspendLayout();
            this.tbCriarAmbiente.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbInicial
            // 
            this.tbInicial.Controls.Add(this.tbCriarAmbiente);
            this.tbInicial.Controls.Add(this.tbEditar);
            this.tbInicial.Location = new System.Drawing.Point(12, 13);
            this.tbInicial.Name = "tbInicial";
            this.tbInicial.SelectedIndex = 0;
            this.tbInicial.Size = new System.Drawing.Size(761, 411);
            this.tbInicial.TabIndex = 10;
            // 
            // tbCriarAmbiente
            // 
            this.tbCriarAmbiente.Controls.Add(this.groupBox2);
            this.tbCriarAmbiente.Controls.Add(this.groupBox1);
            this.tbCriarAmbiente.Controls.Add(this.btnExecutar);
            this.tbCriarAmbiente.Controls.Add(this.processo);
            this.tbCriarAmbiente.Location = new System.Drawing.Point(4, 22);
            this.tbCriarAmbiente.Name = "tbCriarAmbiente";
            this.tbCriarAmbiente.Padding = new System.Windows.Forms.Padding(3);
            this.tbCriarAmbiente.Size = new System.Drawing.Size(753, 385);
            this.tbCriarAmbiente.TabIndex = 0;
            this.tbCriarAmbiente.Text = "Criar Ambiente";
            this.tbCriarAmbiente.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 475);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(741, 22);
            this.progressBar1.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEspecificaPortal);
            this.groupBox2.Controls.Add(this.lblEspecificaPortal);
            this.groupBox2.Controls.Add(this.txtEspecificaPortal);
            this.groupBox2.Controls.Add(this.btnEspecificaLabore);
            this.groupBox2.Controls.Add(this.lblLaboreEspecifica);
            this.groupBox2.Controls.Add(this.txtEspecificaLabore);
            this.groupBox2.Controls.Add(this.cbUtilizaEspecifica);
            this.groupBox2.Controls.Add(this.btnEspecificaBiblioteca);
            this.groupBox2.Controls.Add(this.lblBibliotecaEspecifica);
            this.groupBox2.Controls.Add(this.txtEspecificaBiblioteca);
            this.groupBox2.Location = new System.Drawing.Point(405, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 315);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Especifica";
            // 
            // btnEspecificaPortal
            // 
            this.btnEspecificaPortal.Location = new System.Drawing.Point(200, 185);
            this.btnEspecificaPortal.Name = "btnEspecificaPortal";
            this.btnEspecificaPortal.Size = new System.Drawing.Size(25, 23);
            this.btnEspecificaPortal.TabIndex = 18;
            this.btnEspecificaPortal.Text = "...";
            this.btnEspecificaPortal.UseVisualStyleBackColor = true;
            this.btnEspecificaPortal.Visible = false;
            this.btnEspecificaPortal.Click += new System.EventHandler(this.btnEspecificaPortal_Click);
            // 
            // lblEspecificaPortal
            // 
            this.lblEspecificaPortal.AutoSize = true;
            this.lblEspecificaPortal.Location = new System.Drawing.Point(28, 163);
            this.lblEspecificaPortal.Name = "lblEspecificaPortal";
            this.lblEspecificaPortal.Size = new System.Drawing.Size(166, 13);
            this.lblEspecificaPortal.TabIndex = 17;
            this.lblEspecificaPortal.Text = "Caminho do portal especifica .exe";
            this.lblEspecificaPortal.Visible = false;
            // 
            // txtEspecificaPortal
            // 
            this.txtEspecificaPortal.Location = new System.Drawing.Point(31, 187);
            this.txtEspecificaPortal.Name = "txtEspecificaPortal";
            this.txtEspecificaPortal.Size = new System.Drawing.Size(154, 20);
            this.txtEspecificaPortal.TabIndex = 16;
            this.txtEspecificaPortal.Visible = false;
            // 
            // btnEspecificaLabore
            // 
            this.btnEspecificaLabore.Location = new System.Drawing.Point(200, 136);
            this.btnEspecificaLabore.Name = "btnEspecificaLabore";
            this.btnEspecificaLabore.Size = new System.Drawing.Size(25, 23);
            this.btnEspecificaLabore.TabIndex = 15;
            this.btnEspecificaLabore.Text = "...";
            this.btnEspecificaLabore.UseVisualStyleBackColor = true;
            this.btnEspecificaLabore.Visible = false;
            this.btnEspecificaLabore.Click += new System.EventHandler(this.btnEspecificaLabore_Click);
            // 
            // lblLaboreEspecifica
            // 
            this.lblLaboreEspecifica.AutoSize = true;
            this.lblLaboreEspecifica.Location = new System.Drawing.Point(28, 114);
            this.lblLaboreEspecifica.Name = "lblLaboreEspecifica";
            this.lblLaboreEspecifica.Size = new System.Drawing.Size(173, 13);
            this.lblLaboreEspecifica.TabIndex = 14;
            this.lblLaboreEspecifica.Text = "Caminho do Labore especifica .exe";
            this.lblLaboreEspecifica.Visible = false;
            // 
            // txtEspecificaLabore
            // 
            this.txtEspecificaLabore.Location = new System.Drawing.Point(31, 138);
            this.txtEspecificaLabore.Name = "txtEspecificaLabore";
            this.txtEspecificaLabore.Size = new System.Drawing.Size(154, 20);
            this.txtEspecificaLabore.TabIndex = 13;
            this.txtEspecificaLabore.Visible = false;
            // 
            // cbUtilizaEspecifica
            // 
            this.cbUtilizaEspecifica.AutoSize = true;
            this.cbUtilizaEspecifica.Location = new System.Drawing.Point(31, 19);
            this.cbUtilizaEspecifica.Name = "cbUtilizaEspecifica";
            this.cbUtilizaEspecifica.Size = new System.Drawing.Size(109, 17);
            this.cbUtilizaEspecifica.TabIndex = 10;
            this.cbUtilizaEspecifica.Text = "Utilizar Especifica";
            this.cbUtilizaEspecifica.UseVisualStyleBackColor = true;
            this.cbUtilizaEspecifica.CheckedChanged += new System.EventHandler(this.cbUtilizaEspecifica_CheckedChanged);
            // 
            // btnEspecificaBiblioteca
            // 
            this.btnEspecificaBiblioteca.Location = new System.Drawing.Point(200, 87);
            this.btnEspecificaBiblioteca.Name = "btnEspecificaBiblioteca";
            this.btnEspecificaBiblioteca.Size = new System.Drawing.Size(25, 23);
            this.btnEspecificaBiblioteca.TabIndex = 12;
            this.btnEspecificaBiblioteca.Text = "...";
            this.btnEspecificaBiblioteca.UseVisualStyleBackColor = true;
            this.btnEspecificaBiblioteca.Visible = false;
            this.btnEspecificaBiblioteca.Click += new System.EventHandler(this.btnEspecificaBiblioteca_Click);
            // 
            // lblBibliotecaEspecifica
            // 
            this.lblBibliotecaEspecifica.AutoSize = true;
            this.lblBibliotecaEspecifica.Location = new System.Drawing.Point(28, 65);
            this.lblBibliotecaEspecifica.Name = "lblBibliotecaEspecifica";
            this.lblBibliotecaEspecifica.Size = new System.Drawing.Size(185, 13);
            this.lblBibliotecaEspecifica.TabIndex = 11;
            this.lblBibliotecaEspecifica.Text = "Caminho da biblioteca especifica .exe";
            this.lblBibliotecaEspecifica.Visible = false;
            // 
            // txtEspecificaBiblioteca
            // 
            this.txtEspecificaBiblioteca.Location = new System.Drawing.Point(31, 89);
            this.txtEspecificaBiblioteca.Name = "txtEspecificaBiblioteca";
            this.txtEspecificaBiblioteca.Size = new System.Drawing.Size(154, 20);
            this.txtEspecificaBiblioteca.TabIndex = 2;
            this.txtEspecificaBiblioteca.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPortalCriar);
            this.groupBox1.Controls.Add(this.btnPortal);
            this.groupBox1.Controls.Add(this.lblPortalCriar);
            this.groupBox1.Controls.Add(this.txtLaboreCriar);
            this.groupBox1.Controls.Add(this.btnLabore);
            this.groupBox1.Controls.Add(this.lblLaboreCriar);
            this.groupBox1.Controls.Add(this.txtBibliotecaCriar);
            this.groupBox1.Controls.Add(this.btnBiblioteca);
            this.groupBox1.Controls.Add(this.checkPortal);
            this.groupBox1.Controls.Add(this.lblBibliotecaCriar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkVersao12);
            this.groupBox1.Controls.Add(this.checkLabore);
            this.groupBox1.Controls.Add(this.checkBiblioteca);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Location = new System.Drawing.Point(20, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 315);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Ambiente";
            // 
            // txtPortalCriar
            // 
            this.txtPortalCriar.Location = new System.Drawing.Point(158, 186);
            this.txtPortalCriar.Name = "txtPortalCriar";
            this.txtPortalCriar.Size = new System.Drawing.Size(154, 20);
            this.txtPortalCriar.TabIndex = 24;
            this.txtPortalCriar.Visible = false;
            // 
            // btnPortal
            // 
            this.btnPortal.Location = new System.Drawing.Point(327, 184);
            this.btnPortal.Name = "btnPortal";
            this.btnPortal.Size = new System.Drawing.Size(25, 23);
            this.btnPortal.TabIndex = 25;
            this.btnPortal.Text = "...";
            this.btnPortal.UseVisualStyleBackColor = true;
            this.btnPortal.Visible = false;
            this.btnPortal.Click += new System.EventHandler(this.btnPortal_Click);
            // 
            // lblPortalCriar
            // 
            this.lblPortalCriar.AutoSize = true;
            this.lblPortalCriar.Location = new System.Drawing.Point(170, 170);
            this.lblPortalCriar.Name = "lblPortalCriar";
            this.lblPortalCriar.Size = new System.Drawing.Size(117, 13);
            this.lblPortalCriar.TabIndex = 26;
            this.lblPortalCriar.Text = "Caminho do Portal  .msi";
            this.lblPortalCriar.Visible = false;
            // 
            // txtLaboreCriar
            // 
            this.txtLaboreCriar.Location = new System.Drawing.Point(158, 140);
            this.txtLaboreCriar.Name = "txtLaboreCriar";
            this.txtLaboreCriar.Size = new System.Drawing.Size(154, 20);
            this.txtLaboreCriar.TabIndex = 21;
            this.txtLaboreCriar.Visible = false;
            // 
            // btnLabore
            // 
            this.btnLabore.Location = new System.Drawing.Point(327, 138);
            this.btnLabore.Name = "btnLabore";
            this.btnLabore.Size = new System.Drawing.Size(25, 23);
            this.btnLabore.TabIndex = 22;
            this.btnLabore.Text = "...";
            this.btnLabore.UseVisualStyleBackColor = true;
            this.btnLabore.Visible = false;
            this.btnLabore.Click += new System.EventHandler(this.btnLabore_Click);
            // 
            // lblLaboreCriar
            // 
            this.lblLaboreCriar.AutoSize = true;
            this.lblLaboreCriar.Location = new System.Drawing.Point(170, 124);
            this.lblLaboreCriar.Name = "lblLaboreCriar";
            this.lblLaboreCriar.Size = new System.Drawing.Size(108, 13);
            this.lblLaboreCriar.TabIndex = 23;
            this.lblLaboreCriar.Text = "Caminho Labore  .msi";
            this.lblLaboreCriar.Visible = false;
            // 
            // txtBibliotecaCriar
            // 
            this.txtBibliotecaCriar.Location = new System.Drawing.Point(158, 91);
            this.txtBibliotecaCriar.Name = "txtBibliotecaCriar";
            this.txtBibliotecaCriar.Size = new System.Drawing.Size(154, 20);
            this.txtBibliotecaCriar.TabIndex = 18;
            this.txtBibliotecaCriar.Visible = false;
            // 
            // btnBiblioteca
            // 
            this.btnBiblioteca.Location = new System.Drawing.Point(327, 89);
            this.btnBiblioteca.Name = "btnBiblioteca";
            this.btnBiblioteca.Size = new System.Drawing.Size(25, 23);
            this.btnBiblioteca.TabIndex = 19;
            this.btnBiblioteca.Text = "...";
            this.btnBiblioteca.UseVisualStyleBackColor = true;
            this.btnBiblioteca.Visible = false;
            this.btnBiblioteca.Click += new System.EventHandler(this.btnBiblioteca_Click);
            // 
            // checkPortal
            // 
            this.checkPortal.AutoSize = true;
            this.checkPortal.Location = new System.Drawing.Point(24, 186);
            this.checkPortal.Name = "checkPortal";
            this.checkPortal.Size = new System.Drawing.Size(53, 17);
            this.checkPortal.TabIndex = 18;
            this.checkPortal.Text = "Portal";
            this.checkPortal.UseVisualStyleBackColor = true;
            this.checkPortal.CheckedChanged += new System.EventHandler(this.checkPortal_CheckedChanged);
            this.checkPortal.Click += new System.EventHandler(this.checkPortal_Click);
            // 
            // lblBibliotecaCriar
            // 
            this.lblBibliotecaCriar.AutoSize = true;
            this.lblBibliotecaCriar.Location = new System.Drawing.Point(170, 74);
            this.lblBibliotecaCriar.Name = "lblBibliotecaCriar";
            this.lblBibliotecaCriar.Size = new System.Drawing.Size(135, 13);
            this.lblBibliotecaCriar.TabIndex = 20;
            this.lblBibliotecaCriar.Text = "Caminho da bilbioteca  .msi";
            this.lblBibliotecaCriar.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome do ambiente";
            // 
            // checkVersao12
            // 
            this.checkVersao12.AutoSize = true;
            this.checkVersao12.Location = new System.Drawing.Point(24, 235);
            this.checkVersao12.Name = "checkVersao12";
            this.checkVersao12.Size = new System.Drawing.Size(74, 17);
            this.checkVersao12.TabIndex = 18;
            this.checkVersao12.Text = "Versão 12";
            this.checkVersao12.UseVisualStyleBackColor = true;
            // 
            // checkLabore
            // 
            this.checkLabore.AutoSize = true;
            this.checkLabore.Location = new System.Drawing.Point(26, 140);
            this.checkLabore.Name = "checkLabore";
            this.checkLabore.Size = new System.Drawing.Size(59, 17);
            this.checkLabore.TabIndex = 17;
            this.checkLabore.Text = "Labore";
            this.checkLabore.UseVisualStyleBackColor = true;
            this.checkLabore.CheckedChanged += new System.EventHandler(this.checkLabore_CheckedChanged);
            this.checkLabore.Click += new System.EventHandler(this.checkLabore_Click);
            // 
            // checkBiblioteca
            // 
            this.checkBiblioteca.AutoSize = true;
            this.checkBiblioteca.Location = new System.Drawing.Point(26, 94);
            this.checkBiblioteca.Name = "checkBiblioteca";
            this.checkBiblioteca.Size = new System.Drawing.Size(72, 17);
            this.checkBiblioteca.TabIndex = 16;
            this.checkBiblioteca.Text = "Biblioteca";
            this.checkBiblioteca.UseVisualStyleBackColor = true;
            this.checkBiblioteca.CheckedChanged += new System.EventHandler(this.checkBiblioteca_CheckedChanged);
            this.checkBiblioteca.Click += new System.EventHandler(this.checkBiblioteca_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(158, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(154, 20);
            this.txtNome.TabIndex = 5;
            // 
            // lblTeste
            // 
            this.lblTeste.AutoSize = true;
            this.lblTeste.Location = new System.Drawing.Point(33, 455);
            this.lblTeste.Name = "lblTeste";
            this.lblTeste.Size = new System.Drawing.Size(118, 13);
            this.lblTeste.TabIndex = 15;
            this.lblTeste.Text = "Processando caminho :";
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(367, 341);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(75, 23);
            this.btnExecutar.TabIndex = 1;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // processo
            // 
            this.processo.AutoSize = true;
            this.processo.Location = new System.Drawing.Point(213, 232);
            this.processo.Name = "processo";
            this.processo.Size = new System.Drawing.Size(0, 13);
            this.processo.TabIndex = 9;
            // 
            // tbEditar
            // 
            this.tbEditar.Controls.Add(this.txtAmbienteAtualizar);
            this.tbEditar.Controls.Add(this.btnAtualizar);
            this.tbEditar.Controls.Add(this.lblProcess);
            this.tbEditar.Controls.Add(this.label5);
            this.tbEditar.Controls.Add(this.btnAtualizarCaminho);
            this.tbEditar.Controls.Add(this.label4);
            this.tbEditar.Controls.Add(this.txtAtualizarExpefica);
            this.tbEditar.Location = new System.Drawing.Point(4, 22);
            this.tbEditar.Name = "tbEditar";
            this.tbEditar.Padding = new System.Windows.Forms.Padding(3);
            this.tbEditar.Size = new System.Drawing.Size(753, 385);
            this.tbEditar.TabIndex = 1;
            this.tbEditar.Text = "Atualizar Ambiente";
            this.tbEditar.UseVisualStyleBackColor = true;
            // 
            // txtAmbienteAtualizar
            // 
            this.txtAmbienteAtualizar.FormattingEnabled = true;
            this.txtAmbienteAtualizar.Location = new System.Drawing.Point(22, 118);
            this.txtAmbienteAtualizar.Name = "txtAmbienteAtualizar";
            this.txtAmbienteAtualizar.Size = new System.Drawing.Size(204, 21);
            this.txtAmbienteAtualizar.TabIndex = 20;
            this.txtAmbienteAtualizar.Click += new System.EventHandler(this.txtAmbienteAtualizar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(322, 264);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 19;
            this.btnAtualizar.Text = "Executar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Location = new System.Drawing.Point(57, 187);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(0, 13);
            this.lblProcess.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nome do ambiente a ser atualizado";
            // 
            // btnAtualizarCaminho
            // 
            this.btnAtualizarCaminho.Location = new System.Drawing.Point(191, 46);
            this.btnAtualizarCaminho.Name = "btnAtualizarCaminho";
            this.btnAtualizarCaminho.Size = new System.Drawing.Size(25, 23);
            this.btnAtualizarCaminho.TabIndex = 15;
            this.btnAtualizarCaminho.Text = "...";
            this.btnAtualizarCaminho.UseVisualStyleBackColor = true;
            this.btnAtualizarCaminho.Click += new System.EventHandler(this.btnAtualizarCaminho_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Caminho do arquivo especifico .exe";
            // 
            // txtAtualizarExpefica
            // 
            this.txtAtualizarExpefica.Location = new System.Drawing.Point(22, 48);
            this.txtAtualizarExpefica.Name = "txtAtualizarExpefica";
            this.txtAtualizarExpefica.Size = new System.Drawing.Size(154, 20);
            this.txtAtualizarExpefica.TabIndex = 13;
            // 
            // lblProcessando
            // 
            this.lblProcessando.AutoSize = true;
            this.lblProcessando.Location = new System.Drawing.Point(380, 500);
            this.lblProcessando.Name = "lblProcessando";
            this.lblProcessando.Size = new System.Drawing.Size(0, 13);
            this.lblProcessando.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 511);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tbInicial);
            this.Controls.Add(this.lblTeste);
            this.Controls.Add(this.lblProcessando);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbInicial.ResumeLayout(false);
            this.tbCriarAmbiente.ResumeLayout(false);
            this.tbCriarAmbiente.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbEditar.ResumeLayout(false);
            this.tbEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbInicial;
        private System.Windows.Forms.TabPage tbCriarAmbiente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPortalCriar;
        private System.Windows.Forms.Button btnPortal;
        private System.Windows.Forms.Label lblPortalCriar;
        private System.Windows.Forms.TextBox txtLaboreCriar;
        private System.Windows.Forms.Button btnLabore;
        private System.Windows.Forms.Label lblLaboreCriar;
        private System.Windows.Forms.TextBox txtBibliotecaCriar;
        private System.Windows.Forms.Button btnBiblioteca;
        private System.Windows.Forms.CheckBox checkPortal;
        private System.Windows.Forms.Label lblBibliotecaCriar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkVersao12;
        private System.Windows.Forms.CheckBox checkLabore;
        private System.Windows.Forms.CheckBox checkBiblioteca;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Label processo;
        private System.Windows.Forms.TabPage tbEditar;
        private System.Windows.Forms.ComboBox txtAmbienteAtualizar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAtualizarCaminho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAtualizarExpefica;
        private System.Windows.Forms.Label lblTeste;
        private System.Windows.Forms.Label lblProcessando;
        private System.Windows.Forms.Button btnEspecificaBiblioteca;
        private System.Windows.Forms.Label lblBibliotecaEspecifica;
        private System.Windows.Forms.CheckBox cbUtilizaEspecifica;
        private System.Windows.Forms.TextBox txtEspecificaBiblioteca;
        private System.Windows.Forms.Button btnEspecificaPortal;
        private System.Windows.Forms.Label lblEspecificaPortal;
        private System.Windows.Forms.TextBox txtEspecificaPortal;
        private System.Windows.Forms.Button btnEspecificaLabore;
        private System.Windows.Forms.Label lblLaboreEspecifica;
        private System.Windows.Forms.TextBox txtEspecificaLabore;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

