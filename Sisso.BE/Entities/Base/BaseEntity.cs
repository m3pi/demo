using Sisso.BE.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sisso.BE.Entities
{
    public abstract class BaseEntity
    {
        private readonly BaseHelper _helper = new BaseHelper();

        protected BaseEntity()
        {
            Created = _helper.DateTimePst();
            Modified = _helper.DateTimePst();
        }

        public DateTime Created { get; set; }
        public DateTime? Deleted { get; set; }
        public DateTime Modified { get; set; }

        [Timestamp]
        public byte[] TimeStamp { get; set; }
    }
}
