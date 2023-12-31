﻿using Chronos.Avaliacao.Entidade.Cadastros;

namespace Chronos.Avaliacao.Negocio.Interface.Cadastros
{
    public interface IExercicioNegocio
    {
        void SalvarExercicio(ExercicioEntidade exercicio);
        bool ExcluirExercicio(int exercicioId);
        void EditarExercicio(ExercicioEntidade exercicio);
        IEnumerable<ExercicioEntidade> BuscarTodosOsExercicios();
        ExercicioEntidade BuscaExercicioPorId(int id);
    }
}
