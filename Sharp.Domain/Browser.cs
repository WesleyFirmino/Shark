using Sharp.Infra.Models;
using WatiN.Core;
using WatiN.Core.Native.Windows;

namespace Sharp.Domain
{
    public abstract class Browser
    {
        protected static UserList UserData;

        protected static IE iBrowser;
        
        public void IniciarIE(string site)
        {
            iBrowser = new IE(site);
            iBrowser.ShowWindow(NativeMethods.WindowShowStyle.Maximize);
            iBrowser.WaitForComplete();
        }
    }
}
