using Sharp.Domain.Models;

namespace Sharp.Domain.Controllers
{
    public class JudicalGateway : Navigator
    {
        public void PortalJudicial(string NumeroDossie)
        {
            PageJudicial pj = new PageJudicial();

            pj.Judicial(iBrowser, iJudicial, NumeroDossie);
        }
    }
}
