using ProgramacaoVisual.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgramacaoVisual.InfraEstrutura
{
    public class AlunoNegocio
    {
        public List<Aluno> BuscaAlunos(string PesquisaPor)
        {
            var db = InstanciaDB.Instancia();
            return db.Aluno.Where(
                    w =>
                        w.Matricula.Equals(PesquisaPor)
                        || w.Nome.ToUpper().Contains(PesquisaPor.ToUpper())
                        || w.Celular.Replace(" ", "").Contains(PesquisaPor.Replace(" ", ""))
            ).OrderBy(o => o.Nome).ToList();
        }

        public string SalvarAluno(Aluno aluno)
        {
            var db = InstanciaDB.Instancia();
            // Verifica se já existe o aluno no banco de dados
            var obj = db.Aluno
                .Where(w => w.Matricula.Equals(aluno.Matricula))
                .FirstOrDefault();
            if (obj == null)
            {
                return "Matricula não cadastrada";
            }

            obj.Nome = aluno.Nome;
            obj.Nascimento = aluno.Nascimento;
            obj.Celular = aluno.Celular;

            try
            {
                db.SaveChanges();

                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string AdicionarAluno(Aluno aluno)
        {
            var db = InstanciaDB.Instancia();

            // Verifica se já existe o aluno no banco de dados
            var obj = db.Aluno
                .Where(w => w.Matricula.Equals(aluno.Matricula))
                .FirstOrDefault();
            if (obj != null)
            {
                return "Matricula já cadastrada";
            }

            try
            {
                db.Aluno.Add(aluno);
                db.SaveChanges();

                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
