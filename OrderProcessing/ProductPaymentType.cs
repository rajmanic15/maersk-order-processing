using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace OrderProcessing
{
   

    //public class Membership
    //{
    //    private int _membershipId;
    //    private string _memberShipName;

    //    private MembershipType _membershipType;
    //    private bool _isActivate=false ;
    //    public bool IsActivate { get { return _isActivate; } }
    //    public MembershipType MembershipType { get; }
    //    public string MemberShipName { get; }

    //    public Membership(string memberShipName, MembershipType membershipType)
    //    {
    //        _memberShipName = memberShipName;
    //        _membershipType = membershipType;
    //    }

    //    public Membership Activate(Membership memberShip)
    //    {
    //        Membership memberShipdDetails = new Membership(memberShip.MemberShipName, memberShip.MembershipType);
    //        memberShipdDetails.IsActivate = true;
    //    }

    //    public 
    //}
    
    //public class Action
    //{
    //    public int ActionId { get; set; }
    //    public string ActionName { get; set; }
    //}

    //public class RulesEngine
    //{
    //    public int RuleEngineId { get; set; }
    //    public Product Product{ get; set; }

    //    public List<Action> Actions { get; set; }
    //}

    //public enum MembershipType
    //{
    //    Basic,
    //    Premier
    //}
    public enum  ProductPaymentType
    {
        Physical,
        Book,
        BasicMemberShip,
        PremierMemberShip
    }


}
