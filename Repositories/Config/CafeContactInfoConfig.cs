using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Config
{
    public class CafeContactInfoConfig : IEntityTypeConfiguration<CafeContactInfo>
    {
        public void Configure(EntityTypeBuilder<CafeContactInfo> builder)
        {
            builder.HasData(
                new CafeContactInfo { CafeContactInfoId = 1, CafeContactInfoAddress = "menuCafe@gmail.com", CafeContactInfoMail = "adresimiz" }
                );
        }
    }
}
