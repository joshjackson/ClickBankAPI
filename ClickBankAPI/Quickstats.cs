using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickBankAPI {

    public class AccountData {
        /// <summary>
        /// Nickname associated with the account. Optional.
        /// </summary>
        public string? NickName { get; set; }

        /// <summary>
        /// Collection of quick stats data. Optional, can have multiple entries.
        /// </summary>
        public List<QuickStatsData>? QuickStats { get; set; }
    }

    public class QuickStatsData {
        /// <summary>
        /// The date of the quick stat. Optional.
        /// </summary>
        public DateTime? QuickStatDate { get; set; }

        /// <summary>
        /// Total sales value. Optional.
        /// </summary>
        public decimal? Sale { get; set; }

        /// <summary>
        /// Total refund value. Optional.
        /// </summary>
        public decimal? Refund { get; set; }

        /// <summary>
        /// Total chargeback value. Optional.
        /// </summary>
        public decimal? Chargeback { get; set; }
    }

    public class Quickstats {

        public List<QuickStatsData>? GetCount(DateTime? startDate, DateTime? endDate, string account) {
            return null;
        }

        public List<string>? GetAccounts() { return null; }

        public List<QuickStatsData>? GetList(DateTime? startDate, DateTime? endDate, string account) {
            return null;
        }

    }
}
