﻿using System;
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
    public class ArtistController
    {
        //dump all instances of the entity
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Artist> Artist_ListAll()
        {
            using (var context = new ChinookContext())
            {
                //this is NOT using Linq
                //this is using EntityFramework
                return context.Artists.ToList();
            }
        }
        //dump a particular instance of the entity via the primary key
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Artist Artist_Get(int artistid)
        {
            using (var context = new ChinookContext())
            {
                //this is NOT using Linq
                //this is using EntityFramework
                return context.Artists.Find(artistid);
            }
        }
    }
}
