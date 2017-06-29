using System.Collections.Generic;

namespace FizzBuzzChallenge
{
    public interface IFizzBuzzCommandRetriever
    {
        IEnumerable<IFizzBuzzHandler> GetHandlers();
    }
}