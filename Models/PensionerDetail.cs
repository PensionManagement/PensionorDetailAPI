﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PensionorDetailAPI.Models
{
    public partial class PensionerDetail
    {
        public PensionerDetail()
        {
            PensionTransactions = new HashSet<PensionTransaction>();
        }

        public string Name { get; set; }
        public DateTime? Dob { get; set; }
        public string Pan { get; set; }
        public string AadhaarNo { get; set; }
        public double? Salary { get; set; }
        public double? Allowance { get; set; }
        public int? BankType { get; set; }
        public string BankName { get; set; }
        public string BankAccountNo { get; set; }
        public int? PensionType { get; set; }
        public string Password { get; set; }

        public virtual ICollection<PensionTransaction> PensionTransactions { get; set; }
        public PensionerDetail(string aadhar, string name)
        {
            AadhaarNo = aadhar;
            Name = name;
        }
    }
}
