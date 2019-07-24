using ProgramcaoVisual.InfraEstrutura;

namespace ProgramacaoVisual.InfraEstrutura
{
    public static class InstanciaDB
    {
        private static Repositorio Repositorio;

        public static Repositorio Instancia()
        {
            if (Repositorio == null)
            {
                Repositorio = new Repositorio();
            }

            return Repositorio;
        }
    }
}
