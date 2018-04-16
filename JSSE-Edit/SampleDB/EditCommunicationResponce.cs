using System;
using System.Collections.Generic;

namespace SampleDB
{
    
    public class EntBehavior
    {
        public int Behavior_ID { get; set; }
        public string Behavior { get; set; }
        public string BehaviorDesc { get; set; }
        public int BehaviorType_ID { get; set; }
        public string BehaviorType { get; set; }
        public object Org_ID { get; set; }
        public bool BehviorChecked { get; set; }
        public bool IsActive { get; set; }
        public int? Category_ID { get; set; }
        public int? Rating_ID { get; set; }
        public string Rating { get; set; }
        public object Comments { get; set; }
        public int SortOrder { get; set; }
    }

    public class OrgBehavior
    {
        public int Behavior_ID { get; set; }
        public string Behavior { get; set; }
        public string BehaviorDesc { get; set; }
        public int BehaviorType_ID { get; set; }
        public string BehaviorType { get; set; }
        public object Org_ID { get; set; }
        public bool BehviorChecked { get; set; }
        public bool IsActive { get; set; }
        public int? Category_ID { get; set; }
        public int? Rating_ID { get; set; }
        public string Rating { get; set; }
        public object Comments { get; set; }
        public int SortOrder { get; set; }
    }

    public class Ratings
    {
        public int Rating_ID { get; set; }
        public string Rating { get; set; }
        public bool RatingChecked { get; set; }
        public bool Selected { get; set; }
    }

    public class Category
    {
        public int Category_ID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDesc { get; set; }
        public int SortOrder { get; set; }
        public List<EntBehavior> EntBehaviors { get; set; }
        public List<OrgBehavior> OrgBehaviors { get; set; }
        public List<Ratings> Ratings { get; set; }
        public string Comments { get; set; }
        public string RatingID { get; set; }
        public bool IsActive { get; set; }
        public bool IsRequired { get; set; }
        public int JSSE_ID { get; set; }
        public object AllOrgBehaviors { get; set; }
    }

    public class Observer
    {
        public object CompanyId { get; set; }
        public string UserRole { get; set; }
        public int Emp_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public object UserTitle { get; set; }
        public object Email { get; set; }
        public string User_ID { get; set; }
        public string FullName { get; set; }
        public string MajorGroup_Id { get; set; }
        public string Org_Id { get; set; }
        public string Dept_Id { get; set; }
        public string Section_Id { get; set; }
        public int SecurityUserID { get; set; }
    }

    public class Observee
    {
        public object CompanyId { get; set; }
        public object UserRole { get; set; }
        public int Emp_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public object UserTitle { get; set; }
        public object Email { get; set; }
        public string User_ID { get; set; }
        public string FullName { get; set; }
        public string MajorGroup_Id { get; set; }
        public string Org_Id { get; set; }
        public string Dept_Id { get; set; }
        public string Section_Id { get; set; }
        public int SecurityUserID { get; set; }
    }

    public class EditCommunicationResponce
    {
        public int JSSE_ID { get; set; }
        public int Observer_ID { get; set; }
        public int Observee_ID { get; set; }
        public int Hierarchy_ID { get; set; }
        public int Region_ID { get; set; }
        public object Region { get; set; }
        public object JSSETitle { get; set; }
        public object JobName { get; set; }
        public object JobDescription { get; set; }
        public DateTime JSSEDate { get; set; }
        public List<Category> Categories { get; set; }
        public string JSSEStatus { get; set; }
        public bool IsAnonymous { get; set; }
        public bool IsOBSRAnonymous { get; set; }
        public int MajorGroup_Id { get; set; }
        public int Org_Id { get; set; }
        public int Dept_Id { get; set; }
        public int Section_Id { get; set; }
        public string JSSEEnteredBy { get; set; }
        public string JSSECreator { get; set; }
        public string Location { get; set; }
        public object Observer { get; set; }
        public List<Observer> Observers { get; set; }
        public int IsSupervsrOBSRSame { get; set; }
        public int HasContractor { get; set; }
        public List<object> Supervisors { get; set; }
        public List<Observee> Observees { get; set; }
        public string SelObservers { get; set; }
        public string SelObservees { get; set; }
        public string SelSupervisors { get; set; }
        public object IsExternal { get; set; }
        public object CreatedDate { get; set; }
        public List<object> Attachments { get; set; }
        public bool IsCreator { get; set; }
        public string Base64_JSSE_ID { get; set; }
        public object majorgroups { get; set; }
        public object organizations { get; set; }
        public object departments { get; set; }
        public object sections { get; set; }
        public object AttachmentCount { get; set; }
        public int ContractCompanyID { get; set; }
        public object Image { get; set; }
        public object ImageName { get; set; }
    }

}
