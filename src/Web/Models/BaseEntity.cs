using System;
using System.ComponentModel.DataAnnotations;

namespace YbHackathon.Solutioneers.Web.Models
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
