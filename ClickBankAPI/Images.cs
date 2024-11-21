using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickBankAPI {
    public class ImageData {
        /// <summary>
        /// Unique identifier for the image.
        /// </summary>
        public int? ImageId { get; set; }

        /// <summary>
        /// Title of the image.
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Type of the image (e.g., PRODUCT, BANNER).
        /// </summary>
        public ImageType? Type { get; set; }

        /// <summary>
        /// Approval status of the image.
        /// </summary>
        public bool? Approved { get; set; }
    }

    public class Images {

        public List<ImageData>? ImageList { get; set; } = null;
    }
}
