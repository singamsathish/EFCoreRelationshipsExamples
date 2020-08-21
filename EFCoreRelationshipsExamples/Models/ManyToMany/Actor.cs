﻿using System.Collections.Generic;

namespace EFCoreRelationshipsExamples.Models.ManyToMany
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /* EF Relations */
        public List<ActorMovie> ActorMovies { get; set; }
    }
}