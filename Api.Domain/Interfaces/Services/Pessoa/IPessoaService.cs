using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services
{
    public interface IPessoaService
    {
        Task<PessoaEntity> Get(Guid id);
        Task<IEnumerable<PessoaEntity>> GetAll();
        Task<PessoaEntity> Post(PessoaEntity user);
        Task<PessoaEntity> Put(PessoaEntity user);
        Task<bool> Delete(Guid id);

    }
}
