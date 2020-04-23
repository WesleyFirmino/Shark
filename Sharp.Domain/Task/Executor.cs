using Sharp.Domain.Controllers;
using Sharp.Domain.Models;

namespace Sharp.Domain.Task
{
    public class Executor : Browser
    {
        public void StartTask()
        {
            IniciarIE("https://www.santandernegocios.com.br/F6_framework_portal/html/F6_santander.htm");

            Login.MakeLogin();
        }        
    }
}
