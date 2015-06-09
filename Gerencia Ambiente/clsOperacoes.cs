﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerencia_Ambiente
{
    public class clsOperacoes
    {
        private int valorMaximoProgress = 80;
        public static int valorProgress = 0;
        ProgressBar ProgresBar;
        public TextBox txtDiretorio;
        Label lblProcesso;
        bool versao12;

        public clsOperacoes(ProgressBar progressBar, Label lblProcesso, bool versao12)
        {
            this.ProgresBar = progressBar;
            this.lblProcesso = lblProcesso;
            this.versao12 = versao12;
        }


        public void moverProgressBar(int cout)
        {
            Application.DoEvents();
            ProgresBar.Maximum = valorMaximoProgress;

            ProgresBar.Value = cout;

        }

        public void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs, bool alterouDiretorio)
        {
            try
            {

                int cout = 0;
                string diretorio = "";
                if (alterouDiretorio == false)
                {
                    diretorio = destDirName;
                    diretorio = @"C:\totvs\" + destDirName;
                }

                else
                {
                    diretorio = destDirName;
                }
                var dir = new DirectoryInfo(sourceDirName);
                var dirs = dir.GetDirectories();

                // If the source directory does not exist, throw an exception.
                if (!dir.Exists)
                {
                    throw new DirectoryNotFoundException(
                        "Source directory does not exist or could not be found: "
                        + sourceDirName);
                }

                // If the destination directory does not exist, create it.
                if (!Directory.Exists(diretorio))
                {
                    Directory.CreateDirectory(diretorio);
                }


                // Get the file contents of the directory to copy.
                var files = dir.GetFiles();

                int total = files.Length;

                valorMaximoProgress = total;
                Application.DoEvents();
                lblProcesso.Update();
                lblProcesso.Text = diretorio;
                lblProcesso.Update();

                // txtDiretorio.Text = diretorio;
                foreach (var file in files)
                {

                    cout++;
                    // Create the path to the new copy of the file.
                    var temppath = Path.Combine(diretorio, file.Name);

                    moverProgressBar(cout);

                    // Copy the file.
                    file.CopyTo(temppath, true);
                }
                //    label2.Text = file.ToString();


                // If copySubDirs is true, copy the subdirectori+es.
                if (!copySubDirs) return;

                foreach (var subdir in dirs)
                {
                    // Create the subdirectory.
                    var temppath = Path.Combine(diretorio, subdir.Name);

                    // Copy the subdirectories.
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs, true);
                }
            }

            catch (Exception ex)
            {
                throw new System.ArgumentException(ex.Message);
            }
        }


        public void copiarArquivos(string nomeAmbiente, bool labore)
        {


            try
            {
                var dir = new DirectoryInfo(@"C:\totvs\CorporeRM\RM.Net");
                if (labore == true)
                {
                    dir = new DirectoryInfo(@"C:\totvs\CorporeRM\RMLabore");
                }
                else
                {
                    dir = new DirectoryInfo(@"C:\totvs\CorporeRM\RM.Net");
                }
                string tipoArquivo = ".config";
                var files = dir.GetFiles();
                string caminho = "";
                var temppath = "";
                foreach (var file in files)
                {

                    if (file.Extension == tipoArquivo)
                    {

                        if (labore == true)
                        {
                            temppath = Path.Combine(string.Format(@"C:\totvs\{0}\RMLabore", nomeAmbiente), file.Name);
                        }
                        else
                        {
                            temppath = Path.Combine(string.Format(@"C:\totvs\{0}\RM.Net", nomeAmbiente), file.Name);
                        }
                        caminho = dir + @"\" + file.ToString();

                        file.CopyTo(temppath, true);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new System.ArgumentException(ex.Message + "\n \n" + ex.StackTrace);
            }
        }



        public void deletarDiretorio(string path, bool recursive)
        {
            try
            {
                // Apagar sub-pastas e ficheiros?
                if (recursive)
                {
                    // Sim... Então vamos a isso
                    var subfolders = Directory.GetDirectories(path);
                    foreach (var s in subfolders)
                    {
                        deletarDiretorio(s, recursive);
                    }
                }

                // Obtém todos os ficheiros da pasta
                var files = Directory.GetFiles(path);
                foreach (var f in files)
                {
                    // Obtém os atributos do ficheiro
                    var attr = File.GetAttributes(f);

                    // O ficheiro é 'read-only'?
                    if ((attr & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                    {
                        // Sim... Remove o atributo 'read-only' do ficheiro
                        File.SetAttributes(f, attr ^ FileAttributes.ReadOnly);
                    }

                    // Apaga o ficheiro
                    File.Delete(f);
                }

                // Ao chegar aqui, todos os ficheiros da pasta
                // foram apagados... É só apagar a pasta vazia
                Directory.Delete(path);
            }

            catch (Exception ex)
            {
                throw new System.ArgumentException(ex.Message);
            }
        }


        public bool alterarConfig(string nomeAmbiente, bool labore)
        {
            bool alterou = false;
            try
            {
                var dir = new DirectoryInfo(@"C:\totvs\{0}\RM.Net");
                if (labore == true)
                {
                    dir = new DirectoryInfo(string.Format(@"C:\totvs\{0}\RMLabore", nomeAmbiente));
                }

                else
                {
                    dir = new DirectoryInfo(string.Format(@"C:\totvs\{0}\RM.Net", nomeAmbiente));
                }

                string tipoArquivo = ".config";
                var files = dir.GetFiles();
                string caminho = "";
                foreach (var file in files)
                {

                    if (file.Extension == tipoArquivo)
                    {
                        caminho = dir + @"\" + file.ToString();
                        string texto = File.ReadAllText(caminho);
                        string textoModificado = texto.Replace("CorporeRM", nomeAmbiente);
                        File.WriteAllText(string.Format(caminho), textoModificado);
                        alterou = true;


                    }
                }



                return alterou;
            }

            catch (Exception ex)
            {
                return alterou = false;
                throw new ArgumentException(ex.Message);

            }
        }

        public void extrairInstalador(string caminho, string destino)
        {
            Util.clsUtil util = new Util.clsUtil();
            try
            {

                if (!Directory.Exists(destino))
                {
                    Directory.CreateDirectory(destino);
                }
                Process myProcess;
                //  string fileName = "\"\\\\tecnologiabh\\instalar\\CorporeRM\\Utilitarios\\Innounp\\innounp.exe\"";
               // string fileName = @"C:\Users\Gustavo Giori\Desktop\Innounp\innounp.exe\";
               string fileName = @"C:\Gerencia Ambiente\Ambiente\innounp.exe\"; 
                string arguments = string.Concat(new string[]

                           {

                                  " -x -d\"",

                                  destino,

                                  "\" -a -y \"",

                                 caminho,

                                  "\""

                           });
                string argumento = string.Format(@"/a ""{0}""TARGETDIR=""{1}"" /qb""", caminho, destino);

                string extension = Path.GetExtension(caminho);

                if (extension == ".exe" || extension == ".EXE")
                {

                    //  MessageBox.Show("A extração será realizada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    myProcess = Process.Start(fileName, arguments);
                    myProcess.WaitForExit();

                }

                else
                {

                    if (extension == ".msi" || extension == ".MSI")
                    {

                        util.mensagemAviso("Será aberta a tela de extração , aguarde até o fim do processo ! ");


                        myProcess = Process.Start("msiexec", argumento);
                        // myProcess.WaitForInputIdle();
                        myProcess.WaitForExit();

                    }

                }

            }

            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

        }
    }
}
