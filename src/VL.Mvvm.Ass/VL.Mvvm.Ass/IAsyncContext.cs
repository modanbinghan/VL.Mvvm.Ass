using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace VL.Mvvm.Ass
{
    public interface IAsyncContext
    {
        /// 
        /// Get the context of the creator thread
        /// 
        SynchronizationContext AsynchronizationContext { get; }

        /// 
        /// Test if the current executing thread is the creator thread
        /// 
        bool IsAsyncCreatorThread { get; }

        /// 
        /// Post a call to the specified method on the creator thread
        /// 
        /// Method that is to be called
        /// Method parameter/state
        void AsyncPost(SendOrPostCallback callback, object state);
    }
}
