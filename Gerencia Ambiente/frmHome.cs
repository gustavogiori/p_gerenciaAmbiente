using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerencia_Ambiente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBiblioteca_CheckedChanged(object sender, EventArgs e)
        {
            clsRegraNegocio regra = new clsRegraNegocio();
            regra.verificarVisivel(txtBibliotecaCriar, btnBiblioteca, checkBiblioteca, lblBibliotecaCriar);
        }

        private void checkLabore_CheckedChanged(object sender, EventArgs e)
        {
            clsRegraNegocio regra = new clsRegraNegocio();
            regra.verificarVisivel(txtLaboreCriar, btnLabore, checkLabore, lblLaboreCriar);
        }

        private void checkPortal_CheckedChanged(object sender, EventArgs e)
        {
            clsRegraNegocio regra = new clsRegraNegocio();
            regra.verificarVisivel(txtPortalCriar, btnPortal, checkPortal, lblPortalCriar);
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            clsRegraNegocio regra = new clsRegraNegocio();
            Util.clsUtil util = new Util.clsUtil();
            List<Control> lst = new List<Control>();
            lst.Add(txtNome);
            if (util.verificarNulo(errorProvider1, lst))
            {

            }

            else
            {
                if (checkBiblioteca.Checked)
                {
                    if (regra.verificarAmbienteExiste("Biblioteca", txtNome.Text))
                    {

                    }
                    else
                    {
                        criarAmbiente("Biblioteca");
                        if (txtEspecificaBiblioteca.Visible == true)
                        {

                            if (txtEspecificaBiblioteca.Text != string.Empty)
                            {
                                atualizar(txtNome.Text, txtEspecificaBiblioteca.Text);
                            }


                        }
                    }
                }

                if (checkLabore.Checked)
                {

                    criarAmbiente("Labore");
                    if (txtEspecificaLabore.Visible == true)
                    {

                        if (txtEspecificaLabore.Text != string.Empty)
                        {
                            atualizar(txtNome.Text, txtEspecificaLabore.Text);

                        }

                    }

                }

                if (checkPortal.Checked)
                {

                    criarAmbiente("Portal");
                    if (txtEspecificaPortal.Visible == true)
                    {

                        if (txtEspecificaPortal.Text != string.Empty)
                        {
                            atualizar(txtNome.Text, txtEspecificaPortal.Text);

                        }

                    }

                }
            }
        }
        public void ambienteCriadoSucesso()
        {
            Util.clsUtil util = new Util.clsUtil();
            util.mensagemSucesso("Ambiente criado com sucesso!");
            progressBar1.Value = 0;
        }

        public void criarAmbiente(string produto)
        {
            clsOperacoes operacoes = new clsOperacoes(progressBar1, lblTeste, checkVersao12.Checked);
            clsConfiguracao config = new clsConfiguracao();

            try
            {
                if (produto == "Biblioteca")
                {
                    operacoes.extrairInstalador(txtBibliotecaCriar.Text, @"c:\extrair");
                    operacoes.DirectoryCopy(@"C:\extrair\WinRoot\totvs\CorporeRM", txtNome
                          .Text, true, false);

                    operacoes.deletarDiretorio(@"C:\extrair", true);
                    config.criarArquivoConfig(txtNome.Text, false, checkVersao12.Checked);
                    ambienteCriadoSucesso();
                    config.deletarBroker(txtNome.Text);
                }

                if (produto == "Labore")
                {
                    operacoes.extrairInstalador(txtLaboreCriar.Text, @"c:\extrair");

                    operacoes.DirectoryCopy(@"C:\extrair\WinRoot\totvs\CorporeRM", txtNome
                         .Text, true, false);

                    operacoes.deletarDiretorio(@"C:\extrair", true);

                    config.criarArquivoConfig(txtNome.Text, true, checkVersao12.Checked);

                    if (txtLaboreCriar.Text.Contains("11.82.38"))
                    {

                        File.Copy(@"C:\Gerencia Ambiente\Ambiente/RM.Lib.Interop.dll", string.Format(@"C:\totvs\{0}\RMLabore\RM.Lib.Interop.dll ", txtNome.Text), true);
                    }
                    ambienteCriadoSucesso();
                }

                if (produto == "Portal")
                {
                    operacoes.extrairInstalador(txtPortalCriar.Text, @"c:\extrair");
                    operacoes.DirectoryCopy(@"C:\extrair\WinRoot\totvs\CorporeRM", txtNome
                      .Text, true, false);

                    operacoes.deletarDiretorio(@"C:\extrair", true);
                    config.criarArquivoConfig(txtNome.Text, false, checkVersao12.Checked);
                    config.deletarBroker(txtNome.Text);
                    ambienteCriadoSucesso();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void atualizar(string nomeAmbiente, string caminhoArquivo)
        {
            Util.clsUtil util = new Util.clsUtil();
            try
            {
                clsOperacoes operacoes = new clsOperacoes(progressBar1, lblTeste, checkVersao12.Checked);
                clsConfiguracao config = new clsConfiguracao();

                util.mensagemAviso
                    ("Iniciando processo de atualização do patch");
                operacoes.extrairInstalador(caminhoArquivo, @"C:\extrair");
                operacoes.DirectoryCopy(@"C:\extrair\{app}", nomeAmbiente, true, false);
                operacoes.deletarDiretorio(@"C:\extrair", true);
                config.acertarRMVersion(nomeAmbiente);
                util.mensagemSucesso("Versão atualizada com sucesso!");
                progressBar1.Value = 0;
                lblTeste.Text = "";
                lblTeste.Update();
            }

            catch (Exception ex)
            {
                util.mensagemErro(ex.Message);
            }

        }

        private void cbUtilizaEspecifica_CheckedChanged(object sender, EventArgs e)
        {
            verificarEspecifica();

        }

        public void verificarEspecifica()
        {
            clsRegraNegocio regra = new clsRegraNegocio();

            List<Label> lbl = new List<Label>();
            List<TextBox> txts = new List<TextBox>();
            List<Button> bnts = new List<Button>();
            List<CheckBox> cheBox = new List<CheckBox>();
            lbl.Add(lblBibliotecaEspecifica);
            lbl.Add(lblLaboreEspecifica);
            lbl.Add(lblEspecificaPortal);

            txts.Add(txtEspecificaBiblioteca);
            txts.Add(txtEspecificaLabore);
            txts.Add(txtEspecificaPortal);
            bnts.Add(btnEspecificaBiblioteca);
            bnts.Add(btnEspecificaLabore);
            bnts.Add(btnEspecificaPortal);

            cheBox.Add(checkBiblioteca);
            cheBox.Add(checkLabore);
            cheBox.Add(checkPortal);

            regra.habilitarEspecifica(cbUtilizaEspecifica, lbl, txts, bnts, cheBox);
        }

        private void checkBiblioteca_Click(object sender, EventArgs e)
        {
            verificarEspecifica();
        }

        private void checkLabore_Click(object sender, EventArgs e)
        {
            verificarEspecifica();
        }

        private void checkPortal_Click(object sender, EventArgs e)
        {
            verificarEspecifica();
        }

        private void btnBiblioteca_Click(object sender, EventArgs e)
        {
            abrirMsi(txtBibliotecaCriar);
        }

        public void abrirMsi(TextBox txt)
        {
            Util.clsUtil util = new Util.clsUtil();
            txt.Text = util.abrirDialigoArquivo("Biblioteca|*.msi*", "Abrir");
        }
        private void btnLabore_Click(object sender, EventArgs e)
        {
            abrirMsi(txtLaboreCriar);
        }

        private void btnPortal_Click(object sender, EventArgs e)
        {
            abrirMsi(txtPortalCriar);
        }

        public void abrirExe(TextBox txt)
        {
            Util.clsUtil util = new Util.clsUtil();
            txt.Text = util.abrirDialigoArquivo("Arquivo Exe|*.exe*", "Abrir");

        }

        private void btnEspecificaBiblioteca_Click(object sender, EventArgs e)
        {
            abrirExe(txtEspecificaBiblioteca);
        }

        private void btnEspecificaLabore_Click(object sender, EventArgs e)
        {
            abrirExe(txtEspecificaLabore);
        }

        private void btnEspecificaPortal_Click(object sender, EventArgs e)
        {
            abrirExe(txtEspecificaPortal);
        }

        private void txtAmbienteAtualizar_Click(object sender, EventArgs e)
        {
            clsRegraNegocio regra = new clsRegraNegocio();
            regra.listarAmbiente(txtAmbienteAtualizar);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Util.clsUtil util = new Util.clsUtil();
            List<Control> controles = new List<Control>();
            controles.Add(txtAmbienteAtualizar);
            controles.Add(txtAtualizarExpefica);

            if (util.verificarNulo(errorProvider1, controles))
            {

            }

            else
            {
                string nomeAmbiente = txtAmbienteAtualizar.Text.Remove(0, 9);
                atualizar(nomeAmbiente, txtAtualizarExpefica.Text);
            }
        }

        private void btnAtualizarCaminho_Click(object sender, EventArgs e)
        {
            abrirExe(txtAtualizarExpefica);
        }
    }
}
