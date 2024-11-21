using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickBankAPI {

    // Represents Ticket Data
    public class TicketData {
        public int? TicketId { get; set; }
        public string? Receipt { get; set; }
        public TicketStatus? Status { get; set; }
        public TicketType? Type { get; set; }
        public List<TicketCommentData>? Comments { get; set; }
        public DateTime? OpenedDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string? Description { get; set; }
        public RefundType? RefundType { get; set; }
        public decimal? RefundAmount { get; set; }
        public string? CustomerFirstName { get; set; }
        public string? CustomerLastName { get; set; }
        public string? Email { get; set; }
        public string? EmailAtOrderTime { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string? Locale { get; set; }
        public string? Note { get; set; }
        public string? ProductItemNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public TicketSource? Source { get; set; }
    }

    // Represents Ticket Comment Data
    public class TicketCommentData {
        public int? CommentId { get; set; }
        public DateTime? Date { get; set; }
        public string? Comment { get; set; }
        public TicketActionType? Action { get; set; }
        public Role? CommentRole { get; set; }
    }

    // Enumerations for Ticket Status
    public enum TicketStatus {
        OPEN,
        REOPENED,
        CLOSED
    }

    // Enumerations for Ticket Type
    public enum TicketType {
        TECH_SUPPORT,
        REFUND,
        CANCEL,
        PRODUCT_CHANGE,
        ORDER_LOOKUP,
        ESCALATED,
        APPROVAL_IMAGE,
        APPROVAL_UPSELL,
        APPROVAL_CATEGORY_CHANGE,
        APPROVAL_PRODUCT,
        APPROVAL_FUNNEL,
        APPROVAL_PRODUCT_V2,
        APPROVAL_ADVANCED_UPSELL,
        APPROVAL_CSS_ORDERFORM,
        APPROVAL_TEMPLATE_ORDERFORM,
        APPROVAL_TEMPLATE_EXITOFFER,
        APPROVAL_ORDER_BUMP_CUSTOM_TEXT,
        APPROVAL_EXIT_OFFER,
        APPROVAL_PHOTO_ID,
        ACCT_QUESTION_ACCOUNTS,
        ACCT_QUESTION_ACCOUNTING,
        SPAM,
        ACCOUNT_ABUSE,
        SECURITY_CONCERN
    }

    // Enumerations for Ticket Action Type
    public enum TicketActionType {
        ASSIGNED,
        COMMENTED,
        CHANGED,
        CLOSED,
        EXPIRED,
        REOPENED,
        OPENED,
        APPROVED,
        DISAPPROVED,
        ATTACHMENT,
        ADMIN_CHANGE,
        REFUND_ACKED,
        NEW_PHOTO_ID
    }


    // Enumerations for Refund Type
    public enum RefundType {
        FULL,
        PARTIAL_PERCENT,
        PARTIAL_AMOUNT,
        PARTIAL_QUANTITY,
        TAX
    }

    // Enumerations for Ticket Source
    public enum TicketSource {
        API,
        CUSTOMER_WAM,
        UNKNOWN,
        RNFDS_EMAIL,
        CNCLS_EMAIL,
        VENDOR_WAM,
        VENDOR_ADMIN,
        CSR_ADMIN,
        SECURITY,
        CSR_WAM,
        CONVERSION_PROCESS,
        BUSINESS_DEVELOPMENT_FORM,
        COMMUNICATIONS_EMAIL,
        ACCOUNTS_EMAIL,
        CBCS_EMAIL,
        ACCOUNTING_EMAIL,
        WAM_ACCT_QUESTION,
        WAM_WIREGROUP_DETAIL,
        MARKETING_EMAIL,
        PAYMENTECH_BATCH,
        PYPL_JPY_CANCELLER,
        ECUSTOMS,
        LASHBACK,
        SPAM_EMAIL,
        CLICKBANK_DATABASE_SCRIPT,
        API_VIRTUAL_SOURCE,
        KOUNT,
        PAYPAL_ADAPTIVE,
        CB_POWERED_PROGRAM,
        CLKBANK
    }

    public class Tickets {
    }
}
