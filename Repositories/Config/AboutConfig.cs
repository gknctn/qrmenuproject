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
    public class AboutConfig : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {
            builder.HasData(
                new About { AboutId = 1, AboutDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed et neque porta, auctor elit sit amet, luctus augue. Suspendisse aliquet at justo quis aliquet. Morbi interdum augue sed mauris pulvinar, at efficitur libero efficitur. Sed eget ullamcorper ex. Nam erat tortor, auctor ut ipsum at, feugiat bibendum neque. Ut pellentesque ultrices dolor, ac consequat mauris. Aliquam eget mollis mauris. Phasellus sed velit finibus, tristique libero vitae, volutpat odio. Ut volutpat, metus vitae tempus blandit, ante lacus bibendum ligula, et vulputate eros augue nec augue. Pellentesque velit tellus, scelerisque ut sem sit amet, faucibus condimentum nunc. In eu accumsan mi, at efficitur felis. Sed ligula mi, sagittis ut augue eget, dignissim dictum augue.", AboutMission = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed et neque porta, auctor elit sit amet, luctus augue. Suspendisse aliquet at justo quis aliquet. Morbi interdum augue sed mauris pulvinar, at efficitur libero efficitur. Sed eget ullamcorper ex. Nam erat tortor, auctor ut ipsum at, feugiat bibendum neque. Ut pellentesque ultrices dolor, ac consequat mauris. Aliquam eget mollis mauris. Phasellus sed velit finibus, tristique libero vitae, volutpat odio. Ut volutpat, metus vitae tempus blandit, ante lacus bibendum ligula, et vulputate eros augue nec augue. Pellentesque velit tellus, scelerisque ut sem sit amet, faucibus condimentum nunc. In eu accumsan mi, at efficitur felis. Sed ligula mi, sagittis ut augue eget, dignissim dictum augue.", AboutVision = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed et neque porta, auctor elit sit amet, luctus augue. Suspendisse aliquet at justo quis aliquet. Morbi interdum augue sed mauris pulvinar, at efficitur libero efficitur. Sed eget ullamcorper ex. Nam erat tortor, auctor ut ipsum at, feugiat bibendum neque. Ut pellentesque ultrices dolor, ac consequat mauris. Aliquam eget mollis mauris. Phasellus sed velit finibus, tristique libero vitae, volutpat odio. Ut volutpat, metus vitae tempus blandit, ante lacus bibendum ligula, et vulputate eros augue nec augue. Pellentesque velit tellus, scelerisque ut sem sit amet, faucibus condimentum nunc. In eu accumsan mi, at efficitur felis. Sed ligula mi, sagittis ut augue eget, dignissim dictum augue.", AboutFacebookAddress = "F", AboutInstagramAddress = "I", AboutWpAddress = "W" }
                );
        }
    }
}
