using System;
using System.Collections.Generic;

namespace SampleDB
{

    //public class Observer
    //{
    //    public object CompanyId { get; set; }
    //    public object UserRole { get; set; }
    //    public int Emp_Id { get; set; }
    //    public object FirstName { get; set; }
    //    public object LastName { get; set; }
    //    public object UserTitle { get; set; }
    //    public object Email { get; set; }
    //    public string User_ID { get; set; }
    //    public string FullName { get; set; }
    //    public object MajorGroup_Id { get; set; }
    //    public object Org_Id { get; set; }
    //    public object Dept_Id { get; set; }
    //    public object Section_Id { get; set; }
    //    public int SecurityUserID { get; set; }
    //}

    //public class Observee
    //{
    //    public object CompanyId { get; set; }
    //    public object UserRole { get; set; }
    //    public int Emp_Id { get; set; }
    //    public object FirstName { get; set; }
    //    public object LastName { get; set; }
    //    public object UserTitle { get; set; }
    //    public object Email { get; set; }
    //    public object User_ID { get; set; }
    //    public string FullName { get; set; }
    //    public object MajorGroup_Id { get; set; }
    //    public object Org_Id { get; set; }
    //    public object Dept_Id { get; set; }
    //    public object Section_Id { get; set; }
    //    public int SecurityUserID { get; set; }
    //}

    public class EditUserListModel
    {
        public int JSSE_ID { get; set; }
        public int Observer_ID { get; set; }
        public int Observee_ID { get; set; }
        public int Hierarchy_ID { get; set; }
        public int Region_ID { get; set; }
        public string Region { get; set; }
        public object JSSETitle { get; set; }
        public string JobName { get; set; }
        public string JobDescription { get; set; }
        public DateTime JSSEDate { get; set; }
        public object Categories { get; set; }
        public string JSSEStatus { get; set; }
        public bool IsAnonymous { get; set; }
        public object IsOBSRAnonymous { get; set; }
        public int MajorGroup_Id { get; set; }
        public int Org_Id { get; set; }
        public object Dept_Id { get; set; }
        public object Section_Id { get; set; }
        public string JSSEEnteredBy { get; set; }
        public object JSSECreator { get; set; }
        public string Location { get; set; }
        public Observer Observer { get; set; }
        public object Observers { get; set; }
        public int IsSupervsrOBSRSame { get; set; }
        public object HasContractor { get; set; }
        public object Supervisors { get; set; }
        public List<Observee> Observees { get; set; }
        public object SelObservers { get; set; }
        public object SelObservees { get; set; }
        public object SelSupervisors { get; set; }
        public bool IsExternal { get; set; }
        public DateTime CreatedDate { get; set; }
        public object Attachments { get; set; }
        public bool IsCreator { get; set; }
        public string Base64_JSSE_ID { get; set; }
        public object majorgroups { get; set; }
        public object organizations { get; set; }
        public object departments { get; set; }
        public object sections { get; set; }
        public int AttachmentCount { get; set; }
        public object ContractCompanyID { get; set; }
        public object Image { get; set; }
        public object ImageName { get; set; }
    }
}
