using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MangaLibrary.Models
{
    [MetadataType(typeof(publisherMetadata))]
    public partial class publisher
    {
        public class publisherMetadata
        {
            [DisplayName("Publisher Name")]
            public string name { get; set; }
            [DisplayName("State")]
            public string address { get; set; }
            [DisplayName("Phone")]
            public string phone { get; set; }
        }
    }
}