using System.Collections.Generic;
using System.Linq;

namespace Loan.Application.Domain.Ddd
{
    public abstract class ValueObject<T> where T : ValueObject<T>
    {
        protected abstract IEnumerable<object> GetAttributesToIncludeInEqualityCheck();

        public override bool Equals(object other)
        {
            return Equals(other as T);
        }

        protected virtual bool Equals(T other) =>
            other is { } && 
            GetAttributesToIncludeInEqualityCheck().SequenceEqual(other.GetAttributesToIncludeInEqualityCheck());
        
        public static bool operator ==(ValueObject<T> left, ValueObject<T> right) => Equals(left, right);

        public static bool operator !=(ValueObject<T> left, ValueObject<T> right) => !(left == right);
        

        public override int GetHashCode() =>
            GetAttributesToIncludeInEqualityCheck()
                .Aggregate(17, (current, obj) => 
                    current * 31 + (obj == null ? 0 : obj.GetHashCode()));
    }
}