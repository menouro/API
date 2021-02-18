using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services;

namespace Api.Service.Services
{
    public class PessoaService : IPessoaService
    {
        private IRepository<PessoaEntity> _repository;

        public PessoaService(IRepository<PessoaEntity> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<PessoaEntity> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<PessoaEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<PessoaEntity> Post(PessoaEntity user)
        {
            return await _repository.InsertAsync(user);
        }

        public async Task<PessoaEntity> Put(PessoaEntity user)
        {
            return await _repository.UpdateAsync(user);
        }
    }
}


