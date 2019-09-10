﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

#endregion
namespace ChinookSystem.Data.Entities
{
    [Table("Artists")]

    public class Artist
    {
        // If compound key = [Key, Column(Order = n)]
        //[Key, Column(Order = 1)]
        //[Key, Column(Order = 2)]
        //[Key, DatabaseGenerated(DatabaseGeneratedOption.None] = This is for keys without identity Saying "You have to provide the value, or don't create table"
        [Key]
        public int ArtistId { get; set; }

        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    _Name = null;
                }
                else
                {
                    _Name = value;
                }//eoloop
            }//eos
        }//eop

        public virtual ICollection<Album> Albums { get; set; }
        
    }//eoc
}//eon
