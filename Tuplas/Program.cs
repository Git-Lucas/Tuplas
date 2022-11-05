////Uma tupla é um tipo de dado do C# que pode armazenar múltiplos tipos que pode evitar a criação de classes (ViewModels), apenas para transporte de dados
////Formas distintas de declarar e atribuir valor a uma tupla
//var tupla1 = new Tuple<string, int>("texto", 1);
//var tupla2 = Tuple.Create<string, int>("texto", 2);
//var tupla3 = ("texto", 4);

////Exemplo mais complexo de declaração e atribuição de tupla (recomendado), com definição dos nomes dos atributos dessa variável (seguindo o padrão do C#, o tipo vem antes do nome)
//(string Tipo, List<Tarefa> Tarefas) tupla4 = ("Tarefas Pessoais", new List<Tarefa>());
//tupla4.Tarefas.Add(new Tarefa
//{
//    Titulo = "Academia"
//});
//tupla4.Tarefas.Add(new Tarefa
//{
//    Titulo = "Estudo"
//});

//Console.WriteLine(tupla4.Tipo);
//foreach (var item in tupla4.Tarefas)
//    Console.WriteLine($"Título: {item.Titulo} | Feito: {item.Feito}"); 
        //Tarefas Pessoais Título: Academia | Feito: False Título: Estudo | Feito: False

////Na chamada do método, são necessários ambos os parênteses: o método possui um argumento "nome", que por si é uma tupla de 2 strings
//ImprimeNome(("Lucas", "Oliveira")); //Lucas Oliveira

//Variável que será inferida como tupla pelo fato do "AjuntaNomeComDataDeModificacao", retornar uma tupla com "string, string, DateTime"
var nomeSeparado = AjuntaNomeComDataDeModificacao("Lucas Oliveira");
//A partir de uma variável, é possível acessar seus próprios atributos com nomes editáveis
Console.WriteLine($"Nome: {nomeSeparado.Nome} | " +
                  $"Sobrenome: {nomeSeparado.Sobrenome} | " +
                  $"Data e hora da manipulação do objeto: {nomeSeparado.FeitoEm.ToString("dd/MM/yyyy HH:mm")}h"); 
                        //Nome: Lucas | Sobrenome: Oliveira | Data e hora da manipulação do objeto: 04/11/2022 23:59h

////Exemplo de tupla como variável que é argumento para uma função
//void ImprimeNome((string Nome, string Sobrenome) nome)
//{
//    Console.WriteLine($"{nome.Nome} {nome.Sobrenome}");
//}

//Exemplo de retorno de tupla a partir do um argumento "nome"
(string Nome, string Sobrenome, DateTime FeitoEm) AjuntaNomeComDataDeModificacao(string nomeCompleto)
{
    var nome = nomeCompleto.Split(" ");
    return (nome[0], nome[1], DateTime.Now);
}

public class Tarefa
{
    public string Titulo { get; set; }
    public bool Feito { get; set; }
}