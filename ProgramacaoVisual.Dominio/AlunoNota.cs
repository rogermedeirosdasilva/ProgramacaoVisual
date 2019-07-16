namespace ProgramacaoVisual.Dominio
{
    public class AlunoNota : IData
    {
        public int Codigo { get; set; }
        public string Matricula { get; set; }
        public int CodigoDisciplina { get; set; }
        public decimal Avaliacao { get; set; }

        public virtual Aluno Aluno { get; set; }
    }
}