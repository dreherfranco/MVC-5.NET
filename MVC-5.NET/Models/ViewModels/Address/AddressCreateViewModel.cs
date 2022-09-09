using AddressViewModelResources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_5.NET.Models.ViewModels.Address
{
    public class AddressCreateViewModel
    {
        [Required]
        [Display(ResourceType = typeof(AddressCreateResource), Name = "StreetName")]
        public string StreetName { get; set; }
        [Required]
        [Display(ResourceType = typeof(AddressCreateResource), Name = "PostalCode")]
        public int PostalCode { get; set; }
    }
}