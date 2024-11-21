using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickBankAPI {

    public class OrderShipData {
        /// <summary>
        /// Receipt ID. Optional.
        /// </summary>
        public string? Receipt { get; set; }

        /// <summary>
        /// First name of the customer. Optional.
        /// </summary>
        public string? FirstName { get; set; }

        /// <summary>
        /// Last name of the customer. Optional.
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// Email of the customer. Optional.
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Primary address of the customer. Optional.
        /// </summary>
        public string? Address1 { get; set; }

        /// <summary>
        /// Secondary address of the customer. Optional.
        /// </summary>
        public string? Address2 { get; set; }

        /// <summary>
        /// City of the customer. Optional.
        /// </summary>
        public string? City { get; set; }

        /// <summary>
        /// State or region of the customer. Optional.
        /// </summary>
        public string? State { get; set; }

        /// <summary>
        /// Country of the customer. Optional.
        /// </summary>
        public string? Country { get; set; }

        /// <summary>
        /// Postal code of the customer. Optional.
        /// </summary>
        public string? PostalCode { get; set; }

        /// <summary>
        /// Time of the transaction. Optional.
        /// </summary>
        public DateTime? TransactionTime { get; set; }

        /// <summary>
        /// Indicates if the transaction is a test. Optional.
        /// </summary>
        public bool? IsTestTransaction { get; set; }

        /// <summary>
        /// Full name of the customer. Optional.
        /// </summary>
        public string? FullName { get; set; }

        /// <summary>
        /// Vendor name. Optional.
        /// </summary>
        public string? Vendor { get; set; }

        /// <summary>
        /// Vendor-specific variables. Optional.
        /// </summary>
        public List<VendorVariableElement>? VendorVariables { get; set; }

        /// <summary>
        /// Shipping details for individual line items. Optional, can have multiple entries.
        /// </summary>
        public List<OrderShipLineItemData>? LineItemShipData { get; set; }
    }

    public class VendorVariableElement {
        /// <summary>
        /// Name of the vendor variable. Optional.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Value of the vendor variable. Optional.
        /// </summary>
        public string? Value { get; set; }
    }

    public class OrderShipLineItemData {
        /// <summary>
        /// Item number. Optional.
        /// </summary>
        public string? ItemNo { get; set; }

        /// <summary>
        /// Product title. Optional.
        /// </summary>
        public string? ProductTitle { get; set; }

        /// <summary>
        /// Amount paid by the customer. Optional.
        /// </summary>
        public decimal? CustomerAmount { get; set; }

        /// <summary>
        /// Amount credited to the account. Optional.
        /// </summary>
        public decimal? AccountAmount { get; set; }

        /// <summary>
        /// Quantity of the item. Optional.
        /// </summary>
        public int? Quantity { get; set; }

        /// <summary>
        /// Shipping method used. Optional.
        /// </summary>
        public string? ShippingMethod { get; set; }

        /// <summary>
        /// Indicates if a refund is pending. Optional.
        /// </summary>
        public bool? IsRefundPending { get; set; }

        /// <summary>
        /// Indicates if the item has been refunded. Optional.
        /// </summary>
        public bool? HasBeenRefunded { get; set; }

        /// <summary>
        /// Indicates if the item has been chargebacked. Optional.
        /// </summary>
        public bool? HasBeenChargebacked { get; set; }
    }
 
    
    public class Shipping {
    }
}
