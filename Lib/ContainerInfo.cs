using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public abstract class ContainerInfo : Member
    {
        public ContainerInfo()
        {
            Members = new List<Member>();
        }
        public List<Member> Members { get; set; }
        internal void AddMember(Member member)
        {
            Members.Add(member);
        }
    }
}
