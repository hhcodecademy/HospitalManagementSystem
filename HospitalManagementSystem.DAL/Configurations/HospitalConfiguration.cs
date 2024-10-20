using HospitalManagementSystem.DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DAL.Configurations
{
    internal class HospitalConfiguration : IEntityTypeConfiguration<Hospital>
    {
        public void Configure(EntityTypeBuilder<Hospital> builder)
        {
            builder.Property(h => h.Name).IsRequired().HasMaxLength(250);
            builder.Property(h => h.Email).IsRequired().HasMaxLength(50);
            builder.Property(h => h.Phone).IsRequired().HasMaxLength(50);
        }
    }
}
