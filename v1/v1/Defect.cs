using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v1
{
    public class Status
    {
        public string _oid { get; set; }
        public string Name { get; set; }
    }

    public class Priority
    {
        public string _oid { get; set; }
        public string Name { get; set; }
    }

    public class Custom_Foundinbranches
    {
        public string _oid { get; set; }
        public string Name { get; set; }
    }

    public class Verifiedby
    {
        public string _oid { get; set; }
        public string Name { get; set; }
    }

    public class Owner
    {
        public string _oid { get; set; }
        public string Name { get; set; }
    }

    public class Defect
    {
        public string _oid { get; set; }
        public string Name { get; set; }
        public DateTime ChangeDate { get; set; }
        public object ClosedDate { get; set; }
        public DateTime CreateDate { get; set; }
        public Status[] Status { get; set; }
        public Priority[] Priority { get; set; }
        public Custom_Foundinbranches[] Custom_FoundInBranches { get; set; }
        public object[] Custom_FixedInBranches { get; set; }
        public Verifiedby[] VerifiedBy { get; set; }
        public object[] Custom_Tag2 { get; set; }
        public Owner[] Owners { get; set; }
    }
}
