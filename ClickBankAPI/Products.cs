using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickBankAPI {

    // Main Product Data Class
    public class ProductData {
        public int? Id { get; set; }
        public ActiveStatus? Status { get; set; }
        public bool Digital { get; set; }
        public bool Physical { get; set; }
        public bool DigitalRecurring { get; set; }
        public bool PhysicalRecurring { get; set; }
        public string? Site { get; set; }
        public string? Created { get; set; }
        public string? Updated { get; set; }
        public ProductApprovalStatus? ApprovalStatus { get; set; }
        public string? Language { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? PostPurchaseDescription { get; set; }
        public ImageBean? Image { get; set; }
        public ThankYouPages? ThankYouPages { get; set; }
        public PitchPages? PitchPages { get; set; }
        public ProductCommission? Commission { get; set; }
        public List<Pricing>? Pricings { get; set; }
        public List<ContractBean>? Contracts { get; set; }
        public List<ProductCategory>? Categories { get; set; }
        public bool? DisableGeoCurrency { get; set; }
        public bool? AllowCurrencyChange { get; set; }
        public bool? UsTaxExempt { get; set; }
        public RevRec? RevenueRecognition { get; set; }
        public bool? ReducedUpsellMarkup { get; set; }
        public bool? SkipConfirmationPage { get; set; }
        public string? AdminDownloadUrl { get; set; }
        public string? AdminMobileDownloadUrl { get; set; }
        public bool NoCommission { get; set; }
        public int? SaleRefundDaysLimit { get; set; }
        public int? RebillRefundDaysLimit { get; set; }
        public bool? AdminRestrictFlexibleRefund { get; set; }
        public bool CommissionTierOverride { get; set; }
        public string? DeliveryMethod { get; set; }
        public string? DeliverySpeed { get; set; }
        public int? MaxQuantity { get; set; }
        public bool IsPartOfOrderBump { get; set; }
        public bool IsInitialOfOrderBump { get; set; }
        public bool IsProductOfOrderBump { get; set; }
        public string? Sku { get; set; }
    }

    // Related Classes and Enumerations
    public class ProductApprovalStatus {
        public int? TicketId { get; set; }
        public Status? Status { get; set; }
        public Role? LastActionPerformedBy { get; set; }
    }

    public class ImageBean {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public ImageType? Type { get; set; }
        public bool? Approved { get; set; }
        public string? Path { get; set; }
    }

    public class ThankYouPages {
        public string? Desktop { get; set; }
        public string? Mobile { get; set; }
    }

    public class PitchPages {
        public string? Desktop { get; set; }
        public string? Mobile { get; set; }
    }

    public class ProductCommission {
        public decimal? Purchase { get; set; }
        public decimal? Rebill { get; set; }
        public bool NoRebillCommission { get; set; }
        public bool CommissionTierOverride { get; set; }
    }

    public class Pricing {
        public StandardPricing? Standard { get; set; }
        public RecurringPricing? Recurring { get; set; }
        public PhysicalPricing? Physical { get; set; }
        public string? Currency { get; set; }
    }

    public class StandardPricing {
        public Price? Price { get; set; }
    }

    public class Price {
        public decimal? NativePrice { get; set; }
        public decimal? Usd { get; set; }
        public decimal? UsdWithFees { get; set; }
    }

    public class RecurringPricing {
        public Price? Price { get; set; }
        public RecurringFrequency? Frequency { get; set; }
        public int? Duration { get; set; }
        public int? TrialDays { get; set; }
        public bool PreRebillOverride { get; set; }
        public int? PreRebillLeadTime { get; set; }
        public string? RecurringTitle { get; set; }
        public string? RecurringDescription { get; set; }
        public int FrequencyValue { get; set; }
    }

    public class PhysicalPricing {
        public string? ShippingProfile { get; set; }
    }

    public class ContractBean {
        public int? ProductId { get; set; }
        public string? Name { get; set; }
        public string? Owner { get; set; }
        public string? Partner { get; set; }
        public int? Id { get; set; }
        public ContractStatus? Status { get; set; }
    }

    // Enumerations
    public enum ActiveStatus {
        ACTIVE,
        INACTIVE
    }

    public enum Status {
        APPROVAL_REQUIRED,
        PENDING_APPROVAL,
        UNDER_REVIEW,
        ACTION_REQUIRED,
        APPROVED,
        DISAPPROVED,
        INACTIVE
    }

    public enum Role {
        VENDOR,
        CUSTOMER,
        CBCSR,
        CBSYSTEM,
        USER
    }

    public enum ImageType {
        PRODUCT,
        BANNER,
        BANNER_CLASSIC,
        BANNER_NEW,
        BANNER_BG,
        CUSTOM_BANNER,
        CUSTOM_BANNER_BG,
        CUSTOM_ORDERFORM
    }

    public enum RecurringFrequency {
        WEEKLY,
        BI_WEEKLY,
        MONTHLY,
        QUARTERLY,
        HALF_YEARLY,
        YEARLY,
        MONTHS,
        WEEKS,
        DAYS
    }

    public enum ContractStatus {
        PENDING_START,
        PENDING_APPROVAL,
        ACTIVE,
        TERMINATED,
        TERMINATION_REQUESTED,
        EXPIRED
    }

    public enum ProductCategory {
        EBOOK,
        SOFTWARE,
        GAMES,
        AUDIO,
        VIDEO,
        MEMBER_SITE
    }

    public enum RevRec {
        LD,
        VD,
        LM,
        LMA,
        LMID,
        VM,
        I
    }

    public class PutProductProductRequest {
        public bool? Digital { get; set; }
        public bool? Physical { get; set; }
        public bool? DigitalRecurring { get; set; }
        public bool? PhysicalRecurring { get; set; }

        /// <summary>
        /// The categories for digital products.
        /// Required if the product has a digital component.
        /// </summary>
        public List<ProductCategory>? Categories { get; set; }

        /// <summary>
        /// Whether or not to skip confirmation page (role restricted).
        /// </summary>
        public bool? SkipConfirmationPage { get; set; }

        /// <summary>
        /// The site owning the product. Required.
        /// </summary>
        public string Site { get; set; } = string.Empty;

        /// <summary>
        /// Thank you page for desktops. Either this or MobileThankYouPage is required.
        /// </summary>
        public string? ThankYouPage { get; set; }

        /// <summary>
        /// Thank you page for mobile devices. Either this or ThankYouPage is required.
        /// </summary>
        public string? MobileThankYouPage { get; set; }

        /// <summary>
        /// Currency the product is sold in. Required.
        /// </summary>
        public string Currency { get; set; } = string.Empty;

        /// <summary>
        /// The price of the product. Required.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// The rebill price for RECURRING or RECURRING_PHYSICAL products.
        /// </summary>
        public decimal? RebillPrice { get; set; }

        /// <summary>
        /// The rebill commission for RECURRING or RECURRING_PHYSICAL products.
        /// </summary>
        public decimal? RebillCommission { get; set; }

        /// <summary>
        /// Trial period for RECURRING or RECURRING_PHYSICAL products (0 or 3-31 days).
        /// </summary>
        public int? TrialPeriod { get; set; }

        /// <summary>
        /// Rebill frequency for RECURRING or RECURRING_PHYSICAL products.
        /// </summary>
        public RecurringFrequency? Frequency { get; set; }

        /// <summary>
        /// Rebill duration for RECURRING or RECURRING_PHYSICAL products.
        /// </summary>
        public int? Duration { get; set; }

        /// <summary>
        /// Shipping profile for PHYSICAL or RECURRING_PHYSICAL products.
        /// </summary>
        public string? ShippingProfile { get; set; }

        /// <summary>
        /// Commission rate for the product. Defaults to site's commission rate if unspecified.
        /// </summary>
        public decimal? PurchaseCommission { get; set; }

        /// <summary>
        /// Language of the product. Required.
        /// Must be DE, EN, ES, FR, IT, or PT.
        /// </summary>
        public string Language { get; set; } = string.Empty;

        /// <summary>
        /// Title of the product. Required.
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Description of the product (required for PHYSICAL or RECURRING_PHYSICAL products).
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// ID of the image associated with the product.
        /// </summary>
        public int? Image { get; set; }

        /// <summary>
        /// URL where the product is pitched. Either this or MobilePitchPage is required.
        /// </summary>
        public string? PitchPage { get; set; }

        /// <summary>
        /// URL for mobile devices where the product is pitched.
        /// </summary>
        public string? MobilePitchPage { get; set; }

        /// <summary>
        /// Number of days within which a sale can be refunded.
        /// </summary>
        public int? SaleRefundDaysLimit { get; set; }

        /// <summary>
        /// Number of days within which a rebill can be refunded.
        /// </summary>
        public int? RebillRefundDaysLimit { get; set; }

        /// <summary>
        /// Method of delivery.
        /// </summary>
        public string? DeliveryMethod { get; set; }

        /// <summary>
        /// Speed of delivery.
        /// </summary>
        public string? DeliverySpeed { get; set; }

        /// <summary>
        /// Override Pre-rebill notifications when frequency is greater than the required cycle.
        /// </summary>
        public bool? PreRebillNotificationOverride { get; set; }

        /// <summary>
        /// Number of days before the rebill notification is sent.
        /// </summary>
        public int? PreRebillNotificationLeadTime { get; set; }
    }

    public class Products {

        public ProductData GetProduct(string sku, string site) {
            return new ProductData { Sku = sku, Site = site };
        }

        public string PutProduct(PutProductProductRequest request) {
            return string.Empty;
        }

        public void DeleteProduct(string sku, string? site) { }

        public List<ProductData>? ListProducts(string site, string? productType = "") {
            return new List<ProductData>();
        }
    }
}
