using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WCBIZTECHApp.Models
{
    [MetadataType(typeof(SoftwareServiceRequest.Metadata))]

    public partial class SoftwareServiceRequest
    {
        sealed class Metadata
        {
            public System.Guid RequestId { get; set; }

            [Required]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [Display(Name = "Your Company Name")]
            public string YourCompany { get; set; }

            [Display(Name = "Your Title")]
            public string YourTitle { get; set; }

            public string City { get; set; }

            public string State { get; set; }

            public string Country { get; set; }

            public string Telephone { get; set; }

            public string Email { get; set; }

            [Display(Name = "Service Requested")]
            public string ServiceRequested { get; set; }

            [DataType(DataType.MultilineText)]
            public string Message { get; set; }
        }
    }
}
