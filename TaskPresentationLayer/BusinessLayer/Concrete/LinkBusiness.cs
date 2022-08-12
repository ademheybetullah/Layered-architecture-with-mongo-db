using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class LinkBusiness
    {
        GenericRepository<NewLink> repo = new GenericRepository<NewLink>();
        public List<NewLink> GetLink(string name)
        {
            return repo.GetItemByName(x => x.Name == name);
        }
    }
}
