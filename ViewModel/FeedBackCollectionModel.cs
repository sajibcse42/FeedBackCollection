using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedBackCollection.ViewModel
{
    public class FeedBackCollectionModel
    {
        public string Post { get; set; }
        public string User { get; set; }
        public string Comment { get; set; }
        public DateTimeOffset Date { get; set; }
        public int Like { get; set; }
        public int DisLike { get; set; }
    }
}
