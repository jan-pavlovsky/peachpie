using System;
using System.Collections.Generic;
using System.Text;

namespace Peachpie.CodeAnalysis.FlowAnalysis.Engine
{
    interface IPausedAnalysis
    {
        void Continue();

        void Cancel();
    }
}
