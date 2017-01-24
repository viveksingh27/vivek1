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
    [DataObject]
    public class AlbumController
    {
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<AlbumArtist> ListAlbumsbyArtist()
        {
            using (var context = new ChinookContext())
            {
                var results = from x in context.Albums
                              orderby x.Artist.Name
                              select new AlbumArtist
                              {
                                  Artist = x.Artist.Name,
                                  Title = x.Title,
                                  ReleaseYear = x.ReleaseYear,
                                  ReleaseLabel = x.ReleaseLabel
                              };
                return results.ToList();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<Album> Albums_GetForArtistbyName(string name)
        {
            using (var context = new ChinookContext())
            {
                //this is using Linq
                //this is using the method syntax of the query
                var results = context.Albums
                    .Where(x => x.Artist.Name.Contains(name))
                    .OrderByDescending(x => x.ReleaseYear);
                //remember you have used .Dump() in linqpad to view
                //your contents of the query, .Dump() is a linqpad method
                //it is Not C#
                return results.ToList();
            }
        }
    }
}
