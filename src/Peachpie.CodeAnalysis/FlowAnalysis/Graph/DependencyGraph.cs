using System;
using System.Collections.Generic;
using System.Text;

namespace Peachpie.CodeAnalysis.FlowAnalysis.Graph
{
    class DependencyGraph
    {
        public DependencyGraph(int itemCount)
        {
            throw new NotImplementedException();
        }

        public void AddDependency(int from, int on)
        {
            throw new NotImplementedException();
        }

        public bool IsHidden(int item)
        {
            throw new NotImplementedException();
        }

        public void SetHidden(int item, bool value)
        {
            throw new NotImplementedException();
        }

        public void TraverseAcyclicComponents(Action<ArraySegment<int>> callback)
        {
            throw new NotImplementedException();
        }
    }
}
