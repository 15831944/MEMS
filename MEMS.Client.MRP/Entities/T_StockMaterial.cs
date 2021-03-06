//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MEMS.Client.MRP.Entities
{
    using System;
    using System.Collections.Generic;

    public partial class T_StockMaterial : T_StandardMaterial
    {
        /// <summary>
        /// 采购单号
        /// </summary>
        public string PONo { get; set; }
        /// <summary>
        /// 采购单明细Id
        /// </summary>
        public string PODetailId { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// 库位号
        /// </summary>
        public string StockCode { get; set; }
        /// <summary>
        /// 库位描述
        /// </summary>
        public string StockDesc{ get; set; }
        /// <summary>
        /// 库位数量
        /// </summary>
        public decimal Quantity { get; set; }
        /// <summary>
        /// 可用数量(注：不在数据库生成)
        /// </summary>
        public decimal AvailableQuantity { get; set; }
    }
}
