using System;
using UnitTestExample.Abstractions;

namespace UnitTestExample1
{
    internal class Mock<T>
    {
        private object strict;

        public Mock(object strict)
        {
            this.strict = strict;
        }

        public IAccountManager Object { get; internal set; }

        internal object Setup(Func<object, object> p)
        {
            throw new NotImplementedException();
        }

        internal void Verify(Func<object, object> p, object once)
        {
            throw new NotImplementedException();
        }
    }
}