using Escola.API.Model;
using System.Collections.Generic;

namespace Escola.API.Interfaces.Repositories
{
    public interface IAlunoRepository : IBaseRepository<Aluno,int>
    {
        public bool EmailJaCadastrado(string email);
    }
}
