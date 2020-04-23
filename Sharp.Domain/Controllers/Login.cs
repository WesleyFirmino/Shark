using System;
using System.Threading;
using WatiN.Core;

namespace Sharp.Domain.Controllers
{
    public class Login : Browser
    {
        public static void MakeLogin()
        {
            try
            {
                var divMain = iBrowser.Frame(Find.ByName("principal"));

                var divFrame = iBrowser.Frame(Find.ByName("principal"));

                divMain.TextField(Find.ByName("txtUsuario")).Value = UserData.User;

                divMain.TextField(Find.ByName("pswSenha")).Value = UserData.Password;

                divFrame.Link(Find.First()).Click();

                Thread.Sleep(2000);
            }
            catch (Exception e)
            {

            }
        }
    }
}
