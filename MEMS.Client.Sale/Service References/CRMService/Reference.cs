﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18063
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MEMS.Client.Sale.CRMService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CRMService.ICRMService")]
    internal interface ICRMService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/getCustomerList", ReplyAction="http://tempuri.org/ICRMService/getCustomerListResponse")]
        System.Collections.Generic.List<MEMS.DB.Models.T_Customer> getCustomerList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/getCustomerListbyP", ReplyAction="http://tempuri.org/ICRMService/getCustomerListbyPResponse")]
        System.Collections.Generic.List<MEMS.DB.Models.T_Customer> getCustomerListbyP(string cno, string cname, string csname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/getCustomerbyid", ReplyAction="http://tempuri.org/ICRMService/getCustomerbyidResponse")]
        MEMS.DB.Models.T_Customer getCustomerbyid(int customerid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/AddNewCustomer", ReplyAction="http://tempuri.org/ICRMService/AddNewCustomerResponse")]
        void AddNewCustomer(MEMS.DB.Models.T_Customer newcustomer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/EditCustomer", ReplyAction="http://tempuri.org/ICRMService/EditCustomerResponse")]
        void EditCustomer(MEMS.DB.Models.T_Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/DeleteCustomer", ReplyAction="http://tempuri.org/ICRMService/DeleteCustomerResponse")]
        void DeleteCustomer(MEMS.DB.Models.T_Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/getCpytypeList", ReplyAction="http://tempuri.org/ICRMService/getCpytypeListResponse")]
        System.Collections.Generic.List<MEMS.DB.Models.T_Base_companytype> getCpytypeList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/getCtmtypeList", ReplyAction="http://tempuri.org/ICRMService/getCtmtypeListResponse")]
        System.Collections.Generic.List<MEMS.DB.Models.T_Base_customertype> getCtmtypeList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/getProfList", ReplyAction="http://tempuri.org/ICRMService/getProfListResponse")]
        System.Collections.Generic.List<MEMS.DB.Models.T_Base_profession> getProfList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/getCustomerContactList", ReplyAction="http://tempuri.org/ICRMService/getCustomerContactListResponse")]
        System.Collections.Generic.List<MEMS.DB.Models.T_Customer_contacts> getCustomerContactList(int customerid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/getCustomerAddressList", ReplyAction="http://tempuri.org/ICRMService/getCustomerAddressListResponse")]
        System.Collections.Generic.List<MEMS.DB.Models.T_Customer_address> getCustomerAddressList(int customerid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/DelCustomerAddress", ReplyAction="http://tempuri.org/ICRMService/DelCustomerAddressResponse")]
        void DelCustomerAddress(MEMS.DB.Models.T_Customer_address address);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/DelCustomerContact", ReplyAction="http://tempuri.org/ICRMService/DelCustomerContactResponse")]
        void DelCustomerContact(MEMS.DB.Models.T_Customer_contacts contacts);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/AddCustomerAddress", ReplyAction="http://tempuri.org/ICRMService/AddCustomerAddressResponse")]
        void AddCustomerAddress(MEMS.DB.Models.T_Customer_address address);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/AddCustomerContact", ReplyAction="http://tempuri.org/ICRMService/AddCustomerContactResponse")]
        void AddCustomerContact(MEMS.DB.Models.T_Customer_contacts contacts);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/UpdCustomerAddress", ReplyAction="http://tempuri.org/ICRMService/UpdCustomerAddressResponse")]
        void UpdCustomerAddress(MEMS.DB.Models.T_Customer_address address);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/UpdCustomerContact", ReplyAction="http://tempuri.org/ICRMService/UpdCustomerContactResponse")]
        void UpdCustomerContact(MEMS.DB.Models.T_Customer_contacts contacts);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/getAllSupplier", ReplyAction="http://tempuri.org/ICRMService/getAllSupplierResponse")]
        System.Collections.Generic.List<MEMS.DB.Models.T_Suppliers> getAllSupplier();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/getSupplierList", ReplyAction="http://tempuri.org/ICRMService/getSupplierListResponse")]
        System.Collections.Generic.List<MEMS.DB.Models.T_Suppliers> getSupplierList(string spno, string spname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/getSupplierbyId", ReplyAction="http://tempuri.org/ICRMService/getSupplierbyIdResponse")]
        MEMS.DB.Models.T_Suppliers getSupplierbyId(int sid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/addNewSupplier", ReplyAction="http://tempuri.org/ICRMService/addNewSupplierResponse")]
        void addNewSupplier(MEMS.DB.Models.T_Suppliers newsupplier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/EditSupplier", ReplyAction="http://tempuri.org/ICRMService/EditSupplierResponse")]
        void EditSupplier(MEMS.DB.Models.T_Suppliers supplier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/DeleteSupplier", ReplyAction="http://tempuri.org/ICRMService/DeleteSupplierResponse")]
        void DeleteSupplier(MEMS.DB.Models.T_Suppliers supplier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/getSuptypeLst", ReplyAction="http://tempuri.org/ICRMService/getSuptypeLstResponse")]
        System.Collections.Generic.List<MEMS.DB.Models.T_Base_suppliertype> getSuptypeLst();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/getSupplierContacts", ReplyAction="http://tempuri.org/ICRMService/getSupplierContactsResponse")]
        System.Collections.Generic.List<MEMS.DB.Models.T_Suppliers_contacts> getSupplierContacts(int supplierid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/AddSupplierContacts", ReplyAction="http://tempuri.org/ICRMService/AddSupplierContactsResponse")]
        void AddSupplierContacts(MEMS.DB.Models.T_Suppliers_contacts contact);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/EditSupplierContacts", ReplyAction="http://tempuri.org/ICRMService/EditSupplierContactsResponse")]
        void EditSupplierContacts(MEMS.DB.Models.T_Suppliers_contacts contact);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/DelSupplierContacts", ReplyAction="http://tempuri.org/ICRMService/DelSupplierContactsResponse")]
        void DelSupplierContacts(MEMS.DB.Models.T_Suppliers_contacts contact);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/getProductList", ReplyAction="http://tempuri.org/ICRMService/getProductListResponse")]
        System.Collections.Generic.List<MEMS.DB.ExtModels.ProductList> getProductList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/getProductListbyCid", ReplyAction="http://tempuri.org/ICRMService/getProductListbyCidResponse")]
        System.Collections.Generic.List<MEMS.DB.Models.T_Product> getProductListbyCid(int cid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/getProductListbycdt", ReplyAction="http://tempuri.org/ICRMService/getProductListbycdtResponse")]
        System.Collections.Generic.List<MEMS.DB.ExtModels.ProductList> getProductListbycdt(string pcode, string pname, System.Collections.Generic.List<int> cid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/getProductTypeList", ReplyAction="http://tempuri.org/ICRMService/getProductTypeListResponse")]
        System.Collections.Generic.List<MEMS.DB.Models.T_ProductType> getProductTypeList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/getProductbyId", ReplyAction="http://tempuri.org/ICRMService/getProductbyIdResponse")]
        MEMS.DB.Models.T_Product getProductbyId(int pid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/AddNewProduct", ReplyAction="http://tempuri.org/ICRMService/AddNewProductResponse")]
        bool AddNewProduct(MEMS.DB.Models.T_Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/UpdateProduct", ReplyAction="http://tempuri.org/ICRMService/UpdateProductResponse")]
        bool UpdateProduct(MEMS.DB.Models.T_Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/getProductCraft", ReplyAction="http://tempuri.org/ICRMService/getProductCraftResponse")]
        System.Collections.Generic.List<MEMS.DB.Models.T_Crafts> getProductCraft(int pid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/AddNewCraft", ReplyAction="http://tempuri.org/ICRMService/AddNewCraftResponse")]
        bool AddNewCraft(MEMS.DB.Models.T_Crafts craft);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/UpdateCraft", ReplyAction="http://tempuri.org/ICRMService/UpdateCraftResponse")]
        bool UpdateCraft(MEMS.DB.Models.T_Crafts craft);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/DeleteCraft", ReplyAction="http://tempuri.org/ICRMService/DeleteCraftResponse")]
        bool DeleteCraft(MEMS.DB.Models.T_Crafts craft);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/getProductDrawList", ReplyAction="http://tempuri.org/ICRMService/getProductDrawListResponse")]
        System.Collections.Generic.List<MEMS.DB.Models.T_ProductDraw> getProductDrawList(int productid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/getProductPriceList", ReplyAction="http://tempuri.org/ICRMService/getProductPriceListResponse")]
        System.Collections.Generic.List<MEMS.DB.Models.T_ProductbasicPrice> getProductPriceList(int productid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/AddNewProductPrice", ReplyAction="http://tempuri.org/ICRMService/AddNewProductPriceResponse")]
        bool AddNewProductPrice(MEMS.DB.Models.T_ProductbasicPrice price, System.Collections.Generic.List<MEMS.DB.Models.T_CraftsPrice> newcplist);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/getCraftPriceList", ReplyAction="http://tempuri.org/ICRMService/getCraftPriceListResponse")]
        System.Collections.Generic.List<MEMS.DB.Models.T_CraftsPrice> getCraftPriceList(int productid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/getPriceVersion", ReplyAction="http://tempuri.org/ICRMService/getPriceVersionResponse")]
        string getPriceVersion(int pid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/getQuotationList", ReplyAction="http://tempuri.org/ICRMService/getQuotationListResponse")]
        System.Collections.Generic.List<MEMS.DB.Models.T_quotation> getQuotationList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/getQuotationListbyP", ReplyAction="http://tempuri.org/ICRMService/getQuotationListbyPResponse")]
        System.Collections.Generic.List<MEMS.DB.Models.T_quotation> getQuotationListbyP(string quno, int customerid, System.DateTime aftdate, System.DateTime bfedate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/getQuotationbyId", ReplyAction="http://tempuri.org/ICRMService/getQuotationbyIdResponse")]
        MEMS.DB.Models.T_quotation getQuotationbyId(int qid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/AddNewQuotation", ReplyAction="http://tempuri.org/ICRMService/AddNewQuotationResponse")]
        bool AddNewQuotation(MEMS.DB.Models.T_quotation newqt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/AddNewQtAndQtprice", ReplyAction="http://tempuri.org/ICRMService/AddNewQtAndQtpriceResponse")]
        bool AddNewQtAndQtprice(MEMS.DB.Models.T_quotation newqt, System.Collections.Generic.List<MEMS.DB.ExtModels.QtProduct> qtpricelst);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/UpdateQuotation", ReplyAction="http://tempuri.org/ICRMService/UpdateQuotationResponse")]
        bool UpdateQuotation(MEMS.DB.Models.T_quotation qt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/DeleteQuotation", ReplyAction="http://tempuri.org/ICRMService/DeleteQuotationResponse")]
        bool DeleteQuotation(MEMS.DB.Models.T_quotation qt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/getQtProduct", ReplyAction="http://tempuri.org/ICRMService/getQtProductResponse")]
        System.Collections.Generic.List<MEMS.DB.ExtModels.QtProduct> getQtProduct(int Qtid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/AddNewQtPrice", ReplyAction="http://tempuri.org/ICRMService/AddNewQtPriceResponse")]
        bool AddNewQtPrice(MEMS.DB.ExtModels.QtProduct qtprice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/AddNewQtPriceList", ReplyAction="http://tempuri.org/ICRMService/AddNewQtPriceListResponse")]
        bool AddNewQtPriceList(System.Collections.Generic.List<MEMS.DB.ExtModels.QtProduct> qtpricelst);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal interface ICRMServiceChannel : MEMS.Client.Sale.CRMService.ICRMService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal partial class CRMServiceClient : System.ServiceModel.ClientBase<MEMS.Client.Sale.CRMService.ICRMService>, MEMS.Client.Sale.CRMService.ICRMService {
        
        public CRMServiceClient() {
        }
        
        public CRMServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CRMServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CRMServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CRMServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<MEMS.DB.Models.T_Customer> getCustomerList() {
            return base.Channel.getCustomerList();
        }
        
        public System.Collections.Generic.List<MEMS.DB.Models.T_Customer> getCustomerListbyP(string cno, string cname, string csname) {
            return base.Channel.getCustomerListbyP(cno, cname, csname);
        }
        
        public MEMS.DB.Models.T_Customer getCustomerbyid(int customerid) {
            return base.Channel.getCustomerbyid(customerid);
        }
        
        public void AddNewCustomer(MEMS.DB.Models.T_Customer newcustomer) {
            base.Channel.AddNewCustomer(newcustomer);
        }
        
        public void EditCustomer(MEMS.DB.Models.T_Customer customer) {
            base.Channel.EditCustomer(customer);
        }
        
        public void DeleteCustomer(MEMS.DB.Models.T_Customer customer) {
            base.Channel.DeleteCustomer(customer);
        }
        
        public System.Collections.Generic.List<MEMS.DB.Models.T_Base_companytype> getCpytypeList() {
            return base.Channel.getCpytypeList();
        }
        
        public System.Collections.Generic.List<MEMS.DB.Models.T_Base_customertype> getCtmtypeList() {
            return base.Channel.getCtmtypeList();
        }
        
        public System.Collections.Generic.List<MEMS.DB.Models.T_Base_profession> getProfList() {
            return base.Channel.getProfList();
        }
        
        public System.Collections.Generic.List<MEMS.DB.Models.T_Customer_contacts> getCustomerContactList(int customerid) {
            return base.Channel.getCustomerContactList(customerid);
        }
        
        public System.Collections.Generic.List<MEMS.DB.Models.T_Customer_address> getCustomerAddressList(int customerid) {
            return base.Channel.getCustomerAddressList(customerid);
        }
        
        public void DelCustomerAddress(MEMS.DB.Models.T_Customer_address address) {
            base.Channel.DelCustomerAddress(address);
        }
        
        public void DelCustomerContact(MEMS.DB.Models.T_Customer_contacts contacts) {
            base.Channel.DelCustomerContact(contacts);
        }
        
        public void AddCustomerAddress(MEMS.DB.Models.T_Customer_address address) {
            base.Channel.AddCustomerAddress(address);
        }
        
        public void AddCustomerContact(MEMS.DB.Models.T_Customer_contacts contacts) {
            base.Channel.AddCustomerContact(contacts);
        }
        
        public void UpdCustomerAddress(MEMS.DB.Models.T_Customer_address address) {
            base.Channel.UpdCustomerAddress(address);
        }
        
        public void UpdCustomerContact(MEMS.DB.Models.T_Customer_contacts contacts) {
            base.Channel.UpdCustomerContact(contacts);
        }
        
        public System.Collections.Generic.List<MEMS.DB.Models.T_Suppliers> getAllSupplier() {
            return base.Channel.getAllSupplier();
        }
        
        public System.Collections.Generic.List<MEMS.DB.Models.T_Suppliers> getSupplierList(string spno, string spname) {
            return base.Channel.getSupplierList(spno, spname);
        }
        
        public MEMS.DB.Models.T_Suppliers getSupplierbyId(int sid) {
            return base.Channel.getSupplierbyId(sid);
        }
        
        public void addNewSupplier(MEMS.DB.Models.T_Suppliers newsupplier) {
            base.Channel.addNewSupplier(newsupplier);
        }
        
        public void EditSupplier(MEMS.DB.Models.T_Suppliers supplier) {
            base.Channel.EditSupplier(supplier);
        }
        
        public void DeleteSupplier(MEMS.DB.Models.T_Suppliers supplier) {
            base.Channel.DeleteSupplier(supplier);
        }
        
        public System.Collections.Generic.List<MEMS.DB.Models.T_Base_suppliertype> getSuptypeLst() {
            return base.Channel.getSuptypeLst();
        }
        
        public System.Collections.Generic.List<MEMS.DB.Models.T_Suppliers_contacts> getSupplierContacts(int supplierid) {
            return base.Channel.getSupplierContacts(supplierid);
        }
        
        public void AddSupplierContacts(MEMS.DB.Models.T_Suppliers_contacts contact) {
            base.Channel.AddSupplierContacts(contact);
        }
        
        public void EditSupplierContacts(MEMS.DB.Models.T_Suppliers_contacts contact) {
            base.Channel.EditSupplierContacts(contact);
        }
        
        public void DelSupplierContacts(MEMS.DB.Models.T_Suppliers_contacts contact) {
            base.Channel.DelSupplierContacts(contact);
        }
        
        public System.Collections.Generic.List<MEMS.DB.ExtModels.ProductList> getProductList() {
            return base.Channel.getProductList();
        }
        
        public System.Collections.Generic.List<MEMS.DB.Models.T_Product> getProductListbyCid(int cid) {
            return base.Channel.getProductListbyCid(cid);
        }
        
        public System.Collections.Generic.List<MEMS.DB.ExtModels.ProductList> getProductListbycdt(string pcode, string pname, System.Collections.Generic.List<int> cid) {
            return base.Channel.getProductListbycdt(pcode, pname, cid);
        }
        
        public System.Collections.Generic.List<MEMS.DB.Models.T_ProductType> getProductTypeList() {
            return base.Channel.getProductTypeList();
        }
        
        public MEMS.DB.Models.T_Product getProductbyId(int pid) {
            return base.Channel.getProductbyId(pid);
        }
        
        public bool AddNewProduct(MEMS.DB.Models.T_Product product) {
            return base.Channel.AddNewProduct(product);
        }
        
        public bool UpdateProduct(MEMS.DB.Models.T_Product product) {
            return base.Channel.UpdateProduct(product);
        }
        
        public System.Collections.Generic.List<MEMS.DB.Models.T_Crafts> getProductCraft(int pid) {
            return base.Channel.getProductCraft(pid);
        }
        
        public bool AddNewCraft(MEMS.DB.Models.T_Crafts craft) {
            return base.Channel.AddNewCraft(craft);
        }
        
        public bool UpdateCraft(MEMS.DB.Models.T_Crafts craft) {
            return base.Channel.UpdateCraft(craft);
        }
        
        public bool DeleteCraft(MEMS.DB.Models.T_Crafts craft) {
            return base.Channel.DeleteCraft(craft);
        }
        
        public System.Collections.Generic.List<MEMS.DB.Models.T_ProductDraw> getProductDrawList(int productid) {
            return base.Channel.getProductDrawList(productid);
        }
        
        public System.Collections.Generic.List<MEMS.DB.Models.T_ProductbasicPrice> getProductPriceList(int productid) {
            return base.Channel.getProductPriceList(productid);
        }
        
        public bool AddNewProductPrice(MEMS.DB.Models.T_ProductbasicPrice price, System.Collections.Generic.List<MEMS.DB.Models.T_CraftsPrice> newcplist) {
            return base.Channel.AddNewProductPrice(price, newcplist);
        }
        
        public System.Collections.Generic.List<MEMS.DB.Models.T_CraftsPrice> getCraftPriceList(int productid) {
            return base.Channel.getCraftPriceList(productid);
        }
        
        public string getPriceVersion(int pid) {
            return base.Channel.getPriceVersion(pid);
        }
        
        public System.Collections.Generic.List<MEMS.DB.Models.T_quotation> getQuotationList() {
            return base.Channel.getQuotationList();
        }
        
        public System.Collections.Generic.List<MEMS.DB.Models.T_quotation> getQuotationListbyP(string quno, int customerid, System.DateTime aftdate, System.DateTime bfedate) {
            return base.Channel.getQuotationListbyP(quno, customerid, aftdate, bfedate);
        }
        
        public MEMS.DB.Models.T_quotation getQuotationbyId(int qid) {
            return base.Channel.getQuotationbyId(qid);
        }
        
        public bool AddNewQuotation(MEMS.DB.Models.T_quotation newqt) {
            return base.Channel.AddNewQuotation(newqt);
        }
        
        public bool AddNewQtAndQtprice(MEMS.DB.Models.T_quotation newqt, System.Collections.Generic.List<MEMS.DB.ExtModels.QtProduct> qtpricelst) {
            return base.Channel.AddNewQtAndQtprice(newqt, qtpricelst);
        }
        
        public bool UpdateQuotation(MEMS.DB.Models.T_quotation qt) {
            return base.Channel.UpdateQuotation(qt);
        }
        
        public bool DeleteQuotation(MEMS.DB.Models.T_quotation qt) {
            return base.Channel.DeleteQuotation(qt);
        }
        
        public System.Collections.Generic.List<MEMS.DB.ExtModels.QtProduct> getQtProduct(int Qtid) {
            return base.Channel.getQtProduct(Qtid);
        }
        
        public bool AddNewQtPrice(MEMS.DB.ExtModels.QtProduct qtprice) {
            return base.Channel.AddNewQtPrice(qtprice);
        }
        
        public bool AddNewQtPriceList(System.Collections.Generic.List<MEMS.DB.ExtModels.QtProduct> qtpricelst) {
            return base.Channel.AddNewQtPriceList(qtpricelst);
        }
    }
}