using Sharp.Domain.Controllers;
using Sharp.Domain.Models;
using System.Collections.Generic;

namespace Sharp.Domain.Task
{
    public class Executor : Navigator
    {
        public void StartTask(List<Excel> List)
        {
            IniciarIE("https://www.santandernegocios.com.br/F6_framework_portal/html/F6_santander.htm");

            Login logon = new Login();
            JudicalGateway judical = new JudicalGateway();

            logon.MakeLogin();

            foreach (var excel in List)
            {
                judical.PortalJudicial(excel.NumeroDossie);
            }
        }
    }
}
