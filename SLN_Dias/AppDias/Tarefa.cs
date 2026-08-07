namespace GestaoTarefas;

public class Tarefa
{
    public string Nome { get; set; } = string.Empty;
    public string NomeFuncionario { get; set; } = string.Empty; // RN1: Novo campo
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }

    public Tarefa(string nome, DateTime dataInicio, DateTime dataFim, string nomeFuncionario)
    {
        Nome = nome;
        NomeFuncionario = nomeFuncionario;
        DataInicio = dataInicio;
        DataFim = dataFim;
    }

    public int ObterQuantidadeDias()
    {
        return (DataFim - DataInicio).Days;
    }
}