using System;
using System.Collections.Generic;
using System.Text;
using Pchp.CodeAnalysis.Symbols;

namespace Peachpie.CodeAnalysis.FlowAnalysis.Engine
{
    enum RoutineAnalysisStatus
    {
        Waiting,
        Analysing,
        Completed
    }

    interface IRoutineState
    {
        SourceRoutineSymbol Routine { get; }

        IEnumerable<IAnalysisProvider> AnalysisQueue { get; }

        RoutineAnalysisStatus Status { get; }

        void AddDependency(IRoutineState other);
    }
}
