using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using Chinook.data.Entities;
using ChinookSystem.DAL;
using System.ComponentModel;
using Chinook.data.POCOs;
#endregion

namespace ChinookSystem.BLL
{
    public class ArtistController
    {
        //dump al instances of the entity
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<Artist> Artist_ListAll()
        {
            using (var context = new ChinookContext())
            {
                //this is not using linq
                //this is using entity framework
                return context.Artists.ToList();
            }
        }
        //dump a particular instance of the entity via primary key
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Artist Artist_Get(int artistid)
        {
            using (var context = new ChinookContext())
            {
                //this is not using linq
                //this is using entity framework
                return context.Artists.Find(artistid);
            }
        }
    }
}
