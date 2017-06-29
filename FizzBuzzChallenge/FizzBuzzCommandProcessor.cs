using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzChallenge
{
    public class FizzBuzzCommandProcessor : IFizzBuzzCommandProcessor
    {
        static readonly IEnumerable<IFizzBuzzHandler> HandlerCache;
        static readonly FizzBuzzCommandRetriever CommandRetriever;

        static FizzBuzzCommandProcessor()
        {
            CommandRetriever = new FizzBuzzCommandRetriever();
            HandlerCache = CommandRetriever.GetHandlers().ToList();
        }

        public void Process(int number)
        {
            var handlers = HandlerCache.Where(h => h.CanHandle(number));

            handlers.ToList().ForEach(h => h.Handle(number));
        }
    }
}