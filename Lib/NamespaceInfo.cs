using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class NamespaceInfo : ContainerInfo
    {
        public NamespaceInfo() : base()
        {
        }

        public override MemberType GetContainerType => MemberType.Namespace;
    }
}
