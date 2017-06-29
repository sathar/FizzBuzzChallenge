using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FizzBuzzChallenge
{
    internal class FizzBuzzCommandRetriever : IFizzBuzzCommandRetriever
    {
        public IEnumerable<IFizzBuzzHandler> GetHandlers()
        {
            var handlers =
                Assembly.GetExecutingAssembly().GetExportedTypes().Where(
                    t => typeof(IFizzBuzzHandler).IsAssignableFrom(t) && t.IsClass)
                    .Select(Activator.CreateInstance)
                    .Cast<IFizzBuzzHandler>();

            return handlers;
        }
    }
}