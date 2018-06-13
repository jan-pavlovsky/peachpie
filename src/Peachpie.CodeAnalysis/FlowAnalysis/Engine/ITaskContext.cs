using System;
using System.Collections.Generic;
using System.Text;

namespace Peachpie.CodeAnalysis.FlowAnalysis.Engine
{
    interface ITaskContext
    {
        IEnumerable<IRoutineState> Routines { get; }

        void DelayDueToDependencies(IPausedAnalysis progress = null);
    }
}
