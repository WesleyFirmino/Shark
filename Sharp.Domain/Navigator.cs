using Sharp.Infra.Models;
using System;
using System.Threading;
using WatiN.Core;
using WatiN.Core.Native.Windows;

namespace Sharp.Domain
{
    public abstract class Navigator
    {
        protected static UserList UserData;

        protected static IE iBrowser;

        protected static IE iJudicial;

        public void IniciarIE(string site)
        {
            iBrowser = new IE(site);
            iBrowser.ShowWindow(NativeMethods.WindowShowStyle.Maximize);
            iBrowser.WaitForComplete();
        }

        public void PageJudicial(IE iBrowser)
        {
            iJudicial = iBrowser;

            try
            {
                iJudicial = Browser.AttachTo<IE>(Find.ByUrl(x => x.Contains("https://gestaojudicial.santander.com.br/PCJ/jur/e/Dashboard/PcjOperacional.aspx?i=K9_DASHOBOARDPCJOPERACIONAL&m=MAIN")));

                iJudicial.ShowWindow(NativeMethods.WindowShowStyle.Maximize);
            }
            catch (Exception)
            {
                iJudicial = Browser.AttachTo<IE>(Find.ByTitle("nosession"));
                iJudicial.Close();
                Thread.Sleep(2000);
                iJudicial.Frame(Find.ByName("menu")).Table(Find.ByIndex(0)).TableCell(Find.ById("nivel00")).Click();
                Thread.Sleep(1000);
            }
        }
    }
}
