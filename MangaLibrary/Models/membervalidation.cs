using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MangaLibrary.Models
{
    [MetadataType(typeof(memberMetaData))]
    public partial class member
    {
        public class memberMetaData { 
        [DisplayName("Member Name")]
        public string name { get; set; }
        [DisplayName("City")]
        public string address { get; set; }
        [DisplayName("Phone")]

        public string phone { get; set; }
        }
    }
}