using System;

namespace DIO.Bank.Application.Dto
{
    public abstract class BaseDto<T, TEntity>
    {

        public Guid Id { get; protected set; }
        public virtual T Map(TEntity entity)
        {
            return default(T);
        } 

        public virtual TEntity Map(T source)
        {
            return default(TEntity);
        }
    }
}