using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks
{
    internal class Tarefa
    {
        public int Id;
        public string Descricao;
        public EstadoAtual EstadoAtual;
        public DateTime DataPrevistaInicio;
        public DateTime DataPrevistaFim;
        public DateTime? DataRealInicio;
        public DateTime? DataRealFim;
        public int Ordem;
        public int ProgramadorId;
        public Utilizador Programador;
        public int GestorId;
        public Utilizador Gestor;
        public int TipoTarefaId;
        public TipoTarefa TipoTarefa;
    }
}
