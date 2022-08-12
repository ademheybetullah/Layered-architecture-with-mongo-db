using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class NewLink
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
