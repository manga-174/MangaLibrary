using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MangaLibrary.Models
{
    [MetadataType(typeof(bookMetaData))]
    public partial class book
    {
        public class bookMetaData
        {

            [DisplayName("Book Name")]
            public string bname { get; set; }
            [DisplayName("Category Id")]
            public Nullable<int> cat_id { get; set; }
            [DisplayName("Author Id")]
            public Nullable<int> a_id { get; set; }
            [DisplayName("Publisher Id")]
            public Nullable<int> p_id { get; set; }
            [DisplayName("Contents")]
            public string contents { get; set; }
            [DisplayName("Pages")]
            public Nullable<int> pages { get; set; }
            [DisplayName("Quantity")]
            public string edition { get; set; }

         
        }
    }
}