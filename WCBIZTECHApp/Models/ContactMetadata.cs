using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WCBIZTECHApp.Models
{
    [MetadataType(typeof(Contact.Metadata))]

    public partial class Contact
    {

        sealed class Metadata
        {
            public System.Guid PersonId { get; set; }
            public string Title { get; set; }

            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Display(Name = "First Name")]
            public string FirstName { get; set; }
            public string Email { get; set; }
            public string Telephone { get; set; }
            public string City { get; set; }

            [Display(Name = "State/Province/District")]
            public string State { get; set; }

            [DataType(DataType.MultilineText)]
            public string Message { get; set; }
        }
    }
}
