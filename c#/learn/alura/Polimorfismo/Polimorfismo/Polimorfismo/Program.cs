using Polimorfismo.Tarefa;

namespace Polimorfismo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // TarefaAgendada -------------------------------

            List<TarefaAgendada> tarefas = new List<TarefaAgendada>()
            {
                new BackupTarefa(),
                new LimpezaTarefa(),
                new RelatorioTarefa()
            };

            foreach (var tarefa in tarefas)
            {
                tarefa.Executar();
            }
            
        }
    }
}