//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MEMSservice.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_quotation
    {
        public int id { get; set; }
        public string qutationno { get; set; }
        public string theme { get; set; }
        public Nullable<decimal> totalprice { get; set; }
        public Nullable<int> customerid { get; set; }
        public Nullable<System.DateTime> quotationdate { get; set; }
        public string productremark { get; set; }
        public string quremark { get; set; }
        public Nullable<int> quotationperson { get; set; }
        public string quotationtxt { get; set; }
    }
}
