﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion

namespace Chinook.data.Entities
{
    [Table("Tracks")]
    public class Track
    {
        [Key]
        public int TrackId { get; set; }
        public string Name { get; set; }
        public int? AlbumId { get; set; }
        public int? GenreId { get; set; }
        public string Composer { get; set; }
        public int Milliseconds { get; set; }
        public int? Bytes { get; set; }
        public decimal UnitPrice { get; set; }

        //Navigation prperties

        public virtual Album Album { get; set; }
        public virtual MediaType MediaType {get; set;}
        //public virtual Genre Genre{get; set;}
        //public virtual ICollection<PlaylistTrack> PlaylistTracks{get; set;}
        //public virtual ICollection<InvoiceLine> InvoiceLines{get; set;}
    }
}
