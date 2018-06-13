using System;
using System.Collections.Generic;
using System.Text;

namespace Peachpie.CodeAnalysis.FlowAnalysis.Engine
{
    interface IAnalysisProvider
    {
        void AnalyseRoutine(ITaskContext taskContext);
    }
}
