namespace Domain.Core.Contracts
{
    public interface IValidatorRepository<T> : IRepository<T> where T : class
    {
        Task<bool> ValidateIfExist(int id);
    }
}
