using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Models
{
    /// <summary>
    /// Class IndividualButtonPartial represent a button using
    /// bootstrap 4 as well as several properties for personalization
    /// </summary>
    public class IndividualButtonPartial
    {
        /// <summary>
        /// Gets or sets the type of the button.
        /// </summary>
        /// <value>The type of the button.</value>
        public string ButtonType { get; set; }
        /// <summary>
        /// Gets or sets the action.
        /// </summary>
        /// <value>The action.</value>
        public string Action { get; set; }
        /// <summary>
        /// Gets or sets the glyph.
        /// </summary>
        /// <value>The glyph.</value>
        public string Glyph { get; set; }
        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>The text.</value>
        public string Text { get; set; }
        /// <summary>
        /// Gets or sets the service identifier.
        /// </summary>
        /// <value>The service identifier.</value>
        public int? ServiceId { get; set; }
        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        /// <value>The customer identifier.</value>
        public string CustomerId { get; set; }
        /// <summary>
        /// Gets or sets the car identifier.
        /// </summary>
        /// <value>The car identifier.</value>
        public int? CarId { get; set; }
        /// <summary>
        /// Gets the action parameters.
        /// </summary>
        /// <value>The action parameters.</value>
        public string ActionParameters
        {
            get
            {
                var param = new StringBuilder(@"/");

                if (this.ServiceId != 0 && this.ServiceId != null)
                {
                    param.Append($"{ServiceId}");
                }

                if (!string.IsNullOrEmpty(this.CustomerId))
                {
                    param.Append($"{CustomerId}");
                }

                if (this.CarId != 0 && this.CarId != null)
                {
                    param.Append($"{CarId}");
                }

                return param.ToString();
            }
        }
    }
}
