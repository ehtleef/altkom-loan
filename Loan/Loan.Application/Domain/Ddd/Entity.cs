namespace Loan.Application.Domain.Ddd
{
    public abstract class Entity<T>
    {
        public T Id { get; protected set; }
    }
}