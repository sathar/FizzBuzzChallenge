using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzChallenge
{
    public class MultiplesOfFiveFizzBuzzHandler : IFizzBuzzHandler
    {
        public bool CanHandle(int target)
        {
            return target % 5 == 0;
        }

        public void Handle(int target)
        {
            Console.WriteLine("Buzz");
        }
    }
}
