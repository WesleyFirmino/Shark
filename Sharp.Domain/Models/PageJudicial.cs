using System;
using System.Threading;
using WatiN.Core;

namespace Sharp.Domain.Models
{
    public class PageJudicial
    {
        public void Judicial(IE iBrowser, IE iJudicial, string NumeroDossie)
        {
            try
            {
                var frameMain = iBrowser.Frame(Find.ByName("menu"));

                frameMain.Table(Find.ByIndex(0)).TableCell(Find.ById("nivel00")).Click();

                Thread.Sleep(2000);

                iJudicial
                .Div(Find.ById("menuHorizontal")).Span(Find.ById("ctl00_horizontalMenu")).Link(Find.ByText("Dossiês")).Click();

                Thread.Sleep(2000);

                var divMain = iJudicial.Div(Find.ById("ctl00_Main_WIDGETID_635929640475007316"));

                var divSelect = iJudicial.Div(Find.ById("ContentPanel"));

                divSelect.SelectList(Find.ById("ctl00_Main_WIDGETID_635929640475007316_FilterDropDown")).SelectByValue("");

                Thread.Sleep(2000);

                divMain.TextField(Find.ByName("ctl00$Main$WIDGETID_635929640475007316$SearchField")).Value = NumeroDossie;

                Thread.Sleep(2000);

                divMain.Link(Find.ById("ctl00_Main_WIDGETID_635929640475007316_SearchButton")).Click();

                Thread.Sleep(2000);

                foreach (var item in divMain.Table(Find.ById("ctl00_Main_WIDGETID_635929640475007316_SimpleGrid")).TableRows)
                {
                    if (item.Index == 0)
                        continue;

                    //Testar com casos que o amberto esteja em segundo
                    if (item.OwnTableCells[7].OuterText == "Em andamento")
                    {
                        item.OwnTableCells[5].Link(Find.First()).Click();
                        break;
                    }

                }

                Thread.Sleep(2000);

                var divEvent = iJudicial.Div(Find.ById("ctl00_Main_ANDAMENTOS_GRID")).Div(Find.ById("ctl00_Main_ANDAMENTOS_GRID_ctl04"));

                divEvent.Link(Find.ByText("Novo")).Click();

                Thread.Sleep(2000);

            }
            catch (Exception e)
            {

            }
        }
    }
}
