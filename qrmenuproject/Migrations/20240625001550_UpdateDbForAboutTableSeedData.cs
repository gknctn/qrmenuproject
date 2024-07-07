using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace qrmenuproject.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDbForAboutTableSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "AboutId", "AboutDescription", "AboutFacebookAddress", "AboutInstagramAddress", "AboutMission", "AboutVision", "AboutWpAddress" },
                values: new object[] { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed et neque porta, auctor elit sit amet, luctus augue. Suspendisse aliquet at justo quis aliquet. Morbi interdum augue sed mauris pulvinar, at efficitur libero efficitur. Sed eget ullamcorper ex. Nam erat tortor, auctor ut ipsum at, feugiat bibendum neque. Ut pellentesque ultrices dolor, ac consequat mauris. Aliquam eget mollis mauris. Phasellus sed velit finibus, tristique libero vitae, volutpat odio. Ut volutpat, metus vitae tempus blandit, ante lacus bibendum ligula, et vulputate eros augue nec augue. Pellentesque velit tellus, scelerisque ut sem sit amet, faucibus condimentum nunc. In eu accumsan mi, at efficitur felis. Sed ligula mi, sagittis ut augue eget, dignissim dictum augue.", null, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed et neque porta, auctor elit sit amet, luctus augue. Suspendisse aliquet at justo quis aliquet. Morbi interdum augue sed mauris pulvinar, at efficitur libero efficitur. Sed eget ullamcorper ex. Nam erat tortor, auctor ut ipsum at, feugiat bibendum neque. Ut pellentesque ultrices dolor, ac consequat mauris. Aliquam eget mollis mauris. Phasellus sed velit finibus, tristique libero vitae, volutpat odio. Ut volutpat, metus vitae tempus blandit, ante lacus bibendum ligula, et vulputate eros augue nec augue. Pellentesque velit tellus, scelerisque ut sem sit amet, faucibus condimentum nunc. In eu accumsan mi, at efficitur felis. Sed ligula mi, sagittis ut augue eget, dignissim dictum augue.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed et neque porta, auctor elit sit amet, luctus augue. Suspendisse aliquet at justo quis aliquet. Morbi interdum augue sed mauris pulvinar, at efficitur libero efficitur. Sed eget ullamcorper ex. Nam erat tortor, auctor ut ipsum at, feugiat bibendum neque. Ut pellentesque ultrices dolor, ac consequat mauris. Aliquam eget mollis mauris. Phasellus sed velit finibus, tristique libero vitae, volutpat odio. Ut volutpat, metus vitae tempus blandit, ante lacus bibendum ligula, et vulputate eros augue nec augue. Pellentesque velit tellus, scelerisque ut sem sit amet, faucibus condimentum nunc. In eu accumsan mi, at efficitur felis. Sed ligula mi, sagittis ut augue eget, dignissim dictum augue.", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Abouts",
                keyColumn: "AboutId",
                keyValue: 1);
        }
    }
}
