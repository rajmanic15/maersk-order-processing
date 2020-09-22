using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing
{
    public class BasicMembership : MembershipMaster
    {
        public bool IsActivated { get; set; }
        public BasicMembership()
        { }
    }
}
