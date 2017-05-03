using System.Threading;

namespace FinalProject
{
    /// <summary>
    /// This is the top level class to run threads that will meet reqs.
    /// </summary>
    public class StudentThreading
    {
        ThreadStart threadStart = delegate { new ThreadTest().runThread(); };
        Thread newThread;

        public StudentThreading()
        {
            newThread = new Thread(threadStart);
        }
    }
}