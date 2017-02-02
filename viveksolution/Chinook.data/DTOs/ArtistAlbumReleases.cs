using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using Chinook.data.POCOs;
#endregion

namespace Chinook.data.DTOs
{
   public class ArtistAlbumReleases
    {
        public string Artist { get; set; }
        public List<AlbumRelease> Albums { get; set; }
    }
}
