using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{


    public class OldExceptionProne
    {
        public void SoWeAreCrashing(int x)
        {
            try
            {
                throw new WeirdException(x);
            }
            catch (WeirdException e)
            {
                if (e.Topic >= 42)
                {
	                Console.WriteLine("Boom");
                }
                else
                    throw;
            }
        }
    }


    public class ExceptionProne
    {
        public void SoWeAreCrashing(int x)
        {
            try
            {
                throw new WeirdException(x);
            }
            catch (WeirdException e)  when (e.Topic>=42)
            {
	            Console.WriteLine("Boom");
            }
        }
    }


    



    [Serializable]
    public class WeirdException : Exception
    {
        public WeirdException() { }
        public WeirdException(string message) : base(message) { }
        public WeirdException(string message, Exception inner) : base(message, inner) { }
        protected WeirdException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }

        public int Topic { get; }
        public WeirdException(int topic) : this(topic,"") { }
        public WeirdException(int topic, string message) : this(topic,message,null) { }

        public WeirdException(int topic, string message,Exception inner) : base (message,inner)
        {
            Topic = topic;
        }

    }
}
