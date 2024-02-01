namespace Domain.Entities.Interfaces;

public interface IUnitOfWork
{
    Task<int> SaveChanges();
}