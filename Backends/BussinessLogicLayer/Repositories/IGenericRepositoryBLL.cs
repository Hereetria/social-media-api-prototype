

namespace BussinessLogicLayer.Repositories
{
        public interface IGenericRepositoryBLL<TEntity, TResultDto, TResultById, TCreateDto, TUpdateDto, TKey>
        where TEntity : class
        where TResultDto : class
        where TResultById : class
        where TCreateDto : class
        where TUpdateDto : class
    {
        Task CreateAsync(TCreateDto createDto);

        Task UpdateAsync(TUpdateDto updateDto);

        Task DeleteAsync(TKey id);

        Task<List<TResultDto>> GetAllAsync();

        Task<TResultById> GetByIdAsync(TKey id);
    }
}