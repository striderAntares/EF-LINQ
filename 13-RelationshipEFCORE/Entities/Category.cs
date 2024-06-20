﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_RelationshipEFCORE.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public virtual List<Product> Products { get; set; } = new List<Product>();//referans tipli bir propertyye atama yapamayacağımızdan newledik burayı.
    }
}
