using MGG.ExcelHelper;
using Sharp.Domain.Models;

namespace Sharp.UI.ViewModels
{
    public class ManagerExcel
    {
        public void Reader(string Way)
        {
            var manger = new ManagerExcel<Excel>(@Way);

            var data = manger.ReadExcel();
        }        
    }
}
