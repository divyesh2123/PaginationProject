//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PaginationProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int UserId { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email_Address { get; set; }
        public string Description { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public Nullable<int> RoleId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public Nullable<int> Company { get; set; }
        public string Image_Path { get; set; }
        public Nullable<bool> Is_Locked { get; set; }
        public Nullable<bool> Is_Active { get; set; }
        public Nullable<System.DateTime> Edit_Date { get; set; }
    }
}
