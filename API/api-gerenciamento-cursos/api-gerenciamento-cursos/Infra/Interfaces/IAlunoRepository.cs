﻿using api_gerenciamento_cursos.Domain;
using api_gerenciamento_cursos.Dto;

namespace api_gerenciamento_cursos.Infra.Interfaces
{
    public interface IAlunoRepository
    {
        Task<IEnumerable<AlunoComCurso>> RecuperaTodosAlunosAsync();
        Task<RetornoPaginado<Aluno>> BuscarAlunoPorPaginaAsync(int pagina, int quantidade);
        Task<AlunoComCurso> BuscaAlunoPorIdAsync(int id);
        Task<bool> AdicionaAlunoAsync(Aluno aluno);
        Task<bool> AtualizarAlunoAsync(Aluno aluno);
        Task<bool> DeletarAlunoAsync(int id);
    }
}
