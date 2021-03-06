﻿using Detached.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Detached.EntityFramework.Tests
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey(nameof(OwnedReference))]
        public int? OwnedReferenceId { get; set; }

        //[Owned] -> Defined using Fluent, see TestDbContext.OnModelCreate.
        public OwnedReference OwnedReference { get; set; }

        [ForeignKey(nameof(AssociatedReference))]
        public int? AssociatedReferenceId { get; set; }

        [Associated]
        public AssociatedReference AssociatedReference { get; set; }

        [Owned]
        public IList<OwnedListItem> OwnedList { get; set; }

        [Associated]
        public IList<AssociatedListItem> AssociatedList { get; set; }
    }
}
