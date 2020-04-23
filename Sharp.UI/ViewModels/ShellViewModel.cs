using Caliburn.Micro;
using Microsoft.Win32;
using Sharp.Domain.Task;

namespace Sharp.UI.ViewModels
{
    public class ShellViewModel : Screen
    {
        private string _way;

        public string Way
        {
            get
            {
                return _way;
            }
            set
            {
                _way = value;
                NotifyOfPropertyChange(() => Way);
            }
        }


        public void OpenExcel()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Title = "Procurar arquivos no computador";

            fileDialog.Filter = "Arquivos texto (*.xlsx)|*.xlsx|Todos os arquivos (*.*)|*.*";

            fileDialog.ShowDialog();

            Way = fileDialog.FileName;

            ManagerExcel excel = new ManagerExcel();

            excel.Reader(Way);
        }

        public void BeginTask()
        {
            Executor exec = new Executor();

            exec.StartTask();
        }       

    }
}
