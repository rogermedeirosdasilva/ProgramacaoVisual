namespace ProgramacaoVisual.Dominio
{
    using System;
    using System.Collections.Generic;

    public class Aluno : IData
    {
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public string Celular { get; set; }
        public DateTime Nascimento { get; set; }

        public virtual ICollection<AlunoNota> Notas { get; set; }
    }
}