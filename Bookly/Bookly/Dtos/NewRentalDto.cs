using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookly.Dtos
{
    public class NewRentalDto
    {
        public int CustomerID { get; set; }
        public List<int> BookIds { get; set; }
    }
}