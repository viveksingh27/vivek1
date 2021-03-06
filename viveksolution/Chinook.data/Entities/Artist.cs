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
    [Table("Artists")]
    public class Artist
    {
        [Key]
        public int ArtistId { get; set; }
        public string Name { get; set; }

        //navigational properties
        //virtual properties album point to all children of the parent instance
        public virtual ICollection<Album> Albums { get; set; }
    }
}
