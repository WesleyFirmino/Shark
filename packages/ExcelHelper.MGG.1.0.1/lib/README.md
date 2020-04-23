<h2>Excel Helper</h2>

<h4><b>Adicione as duas DLLs(EPPlus.dll e MGG.ExcelHelper.dll) ao seu projeto</b><h4

<h2>1. Ler Excel</h2>
É necessário ter a planilha com o cabeçalho em uma linha.
<p>Exemplo: </p>

![Excel](https://i.ibb.co/VgGKQcw/excel.png)


É necessário mapear o cabeçalho da planilha em uma model. Pode ser usado o DataAnnotations <b>[DisplayName("")]</b> para associar o nome da coluna da planilha com o nome do atributo.
<p>Exemplo:</p>

```csharp
    public class Excel
    {
        [DisplayName("Número Contrato")]
        public string NumeroContrato { get; set; }

        public string Tipo { get; set; }

        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        public string Status { get; set; }
    }
```
    
Após, é necessário instânciar a classe <b>ManagerExcel</b>, passando como atributo a Model e o Caminho do Excel.
<p>Exemplo:</p>

 ```csharp
 var managerExcel = new ManagerExcel<Excel>(@"C:\ExcelTeste.xlsx");
 ```
 
 Feito isso, apenas é necessário chamar o método <b>ReadExcel()</b>. 
 <p>Exemplo:</p>
 
  ```csharp
  var dataExcel = managerExcel.ReadExcel();
  ```
  
 <b>Resultado</b>
 <p>1</p>
 
 ![Result1](https://i.ibb.co/y0qsdzk/result-1.png)
 
 <p>2</p>
 
 ![Result2](https://i.ibb.co/tHJ5rmp/result-2.png)
 
 
 <h2>2. Criar Excel</h2>
 
 <p>É necessário ter uma lista de itens.</p>
 <p>Vamos partir do exemplo anterior.</p>
 
 ![Result1](https://i.ibb.co/y0qsdzk/result-1.png)
 
 <p>Precisamos criar uma nova instância de <b>ManagerExcel</b> passando como parâmetro o tipo de dados e o caminho para ser criado o novo excel</p>
 
 ![instanciacreate](https://i.ibb.co/NpSftq5/create-excel.png)
 
 <p>Após precisamos chamar o método <b>CreateExcel</b> passando por parâmetro a lista de itens.</p>
 
 ![passandolist](https://i.ibb.co/w0GxJqn/createexcelmetodo.png)
 
 <p>Veremos como retorno uma mensagem de sucesso.</p>
 
 ![sucesso](https://i.ibb.co/jTHJkyR/retorno-excelcriado.png)
 
  <b>Resultado</b>
 
 ![Result3](https://i.ibb.co/xqdW3T3/excelcriado.png)
 
