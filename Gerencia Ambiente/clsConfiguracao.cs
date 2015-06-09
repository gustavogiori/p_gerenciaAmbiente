﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gerencia_Ambiente
{
    public class clsConfiguracao
    {

        public void acertarRMVersion(string nomeAmbiente)
        {

            if (File.Exists(string.Format(@"C:\totvs\{0}\RM.Net\RM.Version,1.dll", nomeAmbiente)))
            {
                File.Delete(string.Format(@"C:\totvs\{0}\RM.Net\RM.Version,1.dll", nomeAmbiente));
                File.Delete(string.Format(@"C:\totvs\{0}\RM.Net\RM.Version,2.dll", nomeAmbiente));
                File.Delete(string.Format(@"C:\totvs\{0}\RM.Net\RM.Version.dll", nomeAmbiente));
                File.Copy(string.Format(@"C:\totvs\{0}\RM.Net\RM.Version,3.dll", nomeAmbiente), string.Format(@"C:\totvs\{0}\RM.Net\RM.Version.dll", nomeAmbiente));
                File.Delete(string.Format(@"C:\totvs\{0}\RM.Net\RM.Version,3.dll", nomeAmbiente));
            }
        }

        public string retornarVersaoDLL(string nomeAmbiente)
        {


            Assembly assembly = Assembly.LoadFrom(string.Format(@"C:\totvs\{0}\RMLabore\RM.Lib.Interop.dll", nomeAmbiente));
            Version ver = assembly.GetName().Version;

            return ver.ToString();
        }
        public void deletarBroker(string nomeAmbiente)
        {
            File.Delete(string.Format(@"C:\totvs\{0}\RM.Net\_Broker.dat", nomeAmbiente));
        }

        public void criarArquivoConfig(string nomeAmbiente, bool labore, bool versao12)
        {
            try
            {

                if (labore == true)
                {
                    string nomeArquivoLabore = "RMLabore.exe";
                    string caminhoLabore = string.Format(@"C:\totvs\{0}\RMLabore\{1}.config ", nomeAmbiente, nomeArquivoLabore);
                    System.IO.FileStream fs = System.IO.File.OpenWrite(caminhoLabore);
                    fs.Close();
                    File.WriteAllText(caminhoLabore, retornarArquivoConfig(nomeAmbiente));

                }
                List<string> nomesArquivo = new List<string>();
                if (versao12 == true)
                {

                    nomesArquivo.Add("RM.AliasManager.exe");
                    nomesArquivo.Add("RM.exe");
                    nomesArquivo.Add("RM.Atualizador.exe.dll");
                    nomesArquivo.Add("RM.Host.exe");
                    nomesArquivo.Add("RM.Host.Service.exe");
                    nomesArquivo.Add("RM.Lib.Gerador.Execute.exe");
                    nomesArquivo.Add("RM.Script.Executor.exe");
                    nomesArquivo.Add("RM.TotvsSQLTools.exe");
                    nomesArquivo.Add("RM.Atualizador.LogViewer.exe");
                    nomesArquivo.Add("RMAgilis.exe");
                    nomesArquivo.Add("RMBiblios.exe");
                    nomesArquivo.Add("RMBis.exe");
                    nomesArquivo.Add("RMBonum.exe");
                    nomesArquivo.Add("RMChronus.exe");
                    nomesArquivo.Add("RMClass.exe");
                    nomesArquivo.Add("RMClassisF.exe");
                    nomesArquivo.Add("RMClassisNet.exe");
                    nomesArquivo.Add("RMFactor.exe");
                    nomesArquivo.Add("RMFluxus.exe");
                    nomesArquivo.Add("RMLabore.exe");
                    nomesArquivo.Add("RMLiber.exe");
                    nomesArquivo.Add("RMNucleus.exe");
                    nomesArquivo.Add("RMOfficina.exe");
                    nomesArquivo.Add("RMPortal.exe");
                    nomesArquivo.Add("RMSaldus.exe");
                    nomesArquivo.Add("RMSaude.exe");
                    nomesArquivo.Add("RMSGI.exe");
                    nomesArquivo.Add("RMSGI.exe");
                    nomesArquivo.Add("RMTestis.exe");
                    nomesArquivo.Add("RMVitae.exe");
                    nomesArquivo.Add("RMVitaeSMT.exe");


                    copiarArquivosV12(nomeAmbiente, "RM.Glb.PlanilhaNet.API.dll");
                    copiarArquivosV12(nomeAmbiente, "RM.TstExec.Executor.exe");
                }

                else
                {
                    nomesArquivo.Add("RM.AliasManager.exe");
                    nomesArquivo.Add("RM.exe");
                    nomesArquivo.Add("RM.Glb.PlanilhaNet.API.dll");
                    nomesArquivo.Add("RM.Host.exe");
                    nomesArquivo.Add("RM.Host.Service.exe");
                    nomesArquivo.Add("RM.Lib.Gerador.Execute.exe");
                    nomesArquivo.Add("RM.Script.Executor.exe");
                    nomesArquivo.Add("RM.TotvsSQLTools.exe");
                    nomesArquivo.Add("RM.TstExec.Executor.exe");

                }
                for (int i = 0; i < nomesArquivo.Count; i++)
                {

                    //fodas
                    string caminhoTotal = string.Format(@"C:\totvs\{0}\RM.Net\{1}.config ", nomeAmbiente, nomesArquivo[i]);
                    if (File.Exists(caminhoTotal))
                    {

                        File.WriteAllText(caminhoTotal, retornarArquivoConfig(nomeAmbiente));
                    }

                    else
                    {



                        File.Copy(@"C:\Gerencia Ambiente\Ambiente\RM.exe.config", caminhoTotal);
                       // File.Copy(@"\\BHD000000407\ambiente\RM.exe.config", caminhoTotal);

                        // File.Create(@"C:\Users\Gustavo Giori\Desktop\PA\teste.config");
                        // File.CreateText(@"C:\Users\Gustavo Giori\Desktop\PA\teste.config");
                        // System.IO.FileStream fs = System.IO.File.OpenWrite(caminhoTotal);
                        //fs.Close();
                        File.WriteAllText(caminhoTotal, retornarArquivoConfig(nomeAmbiente));

                    }
                }




            }
            catch (Exception ex)
            {
                throw new System.ArgumentException(ex.Message + "\n" + ex.InnerException);
            }
        }

        public void copiarArquivosV12(string nomeAmbiente, string arquivo)
        {
            File.Copy(string.Format(@"C:\Gerencia Ambiente\Ambiente\{0}.config", arquivo), string.Format(@"C:\totvs\{0}\RM.Net\{1}.config", nomeAmbiente, arquivo), true);


            string conteudo = File.ReadAllText(string.Format(@"C:\totvs\{0}\RM.Net\{1}.config", nomeAmbiente, arquivo));

            string retorno = conteudo.Replace("CorporeRM", nomeAmbiente);

            retorno = retorno.Replace(string.Format("<add key=\"Host\" value=\"{0}\" />", "BHD000000407"), string.Format("<add key=\"Host\" value=\"{0}\" />", GetPC()));

            File.WriteAllText(string.Format(@"C:\totvs\{0}\RM.Net\{1}.config", nomeAmbiente, arquivo), retorno);

        }

        public string GetPC()//Nome do computador
        {
            string PcName = System.Net.Dns.GetHostName();
            return PcName;
        }
        public string retornarArquivoConfig(string caminho)
        {

            try
            {
                string retorno = "";
                string nomeServidor = "";
                string conteudo = File.ReadAllText(@"C:\Gerencia Ambiente\Ambiente\RM.exe.config");
                //string conteudo = File.ReadAllText(@"\\BHD000000407\ambiente/RM.exe.config");

                retorno = conteudo.Replace("CorporeRM", caminho);

                retorno = retorno.Replace(string.Format("<add key=\"Host\" value=\"{0}\" />", "BHD000000407"), string.Format("<add key=\"Host\" value=\"{0}\" />", GetPC()));

                return retorno;
            }

            catch (Exception ex)
            {
                throw new System.ArgumentException(ex.Message + "\n \n" + ex.StackTrace);
            }

        }
    }
}
