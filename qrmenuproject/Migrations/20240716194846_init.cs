﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace qrmenuproject.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AboutDescription = table.Column<string>(type: "TEXT", nullable: false),
                    AboutVision = table.Column<string>(type: "TEXT", nullable: false),
                    AboutMission = table.Column<string>(type: "TEXT", nullable: false),
                    AboutWpAddress = table.Column<string>(type: "TEXT", nullable: false),
                    AboutInstagramAddress = table.Column<string>(type: "TEXT", nullable: false),
                    AboutFacebookAddress = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CafeContactInfos",
                columns: table => new
                {
                    CafeContactInfoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CafeContactInfoMail = table.Column<string>(type: "TEXT", nullable: false),
                    CafeContactInfoAddress = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CafeContactInfos", x => x.CafeContactInfoId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ContactName = table.Column<string>(type: "TEXT", nullable: false),
                    ContactSurname = table.Column<string>(type: "TEXT", nullable: false),
                    ContactMail = table.Column<string>(type: "TEXT", nullable: false),
                    ContactPhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    ContactMessage = table.Column<string>(type: "TEXT", nullable: false),
                    ContactDateCreated = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductName = table.Column<string>(type: "TEXT", nullable: true),
                    ProductDescription = table.Column<string>(type: "TEXT", nullable: true),
                    ProductPrice = table.Column<decimal>(type: "TEXT", nullable: true),
                    ProductImage = table.Column<string>(type: "TEXT", nullable: true),
                    ProductDateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ProductShowcase = table.Column<bool>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "AboutId", "AboutDescription", "AboutFacebookAddress", "AboutInstagramAddress", "AboutMission", "AboutVision", "AboutWpAddress" },
                values: new object[] { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed et neque porta, auctor elit sit amet, luctus augue. Suspendisse aliquet at justo quis aliquet. Morbi interdum augue sed mauris pulvinar, at efficitur libero efficitur. Sed eget ullamcorper ex. Nam erat tortor, auctor ut ipsum at, feugiat bibendum neque. Ut pellentesque ultrices dolor, ac consequat mauris. Aliquam eget mollis mauris. Phasellus sed velit finibus, tristique libero vitae, volutpat odio. Ut volutpat, metus vitae tempus blandit, ante lacus bibendum ligula, et vulputate eros augue nec augue. Pellentesque velit tellus, scelerisque ut sem sit amet, faucibus condimentum nunc. In eu accumsan mi, at efficitur felis. Sed ligula mi, sagittis ut augue eget, dignissim dictum augue.", "F", "I", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed et neque porta, auctor elit sit amet, luctus augue. Suspendisse aliquet at justo quis aliquet. Morbi interdum augue sed mauris pulvinar, at efficitur libero efficitur. Sed eget ullamcorper ex. Nam erat tortor, auctor ut ipsum at, feugiat bibendum neque. Ut pellentesque ultrices dolor, ac consequat mauris. Aliquam eget mollis mauris. Phasellus sed velit finibus, tristique libero vitae, volutpat odio. Ut volutpat, metus vitae tempus blandit, ante lacus bibendum ligula, et vulputate eros augue nec augue. Pellentesque velit tellus, scelerisque ut sem sit amet, faucibus condimentum nunc. In eu accumsan mi, at efficitur felis. Sed ligula mi, sagittis ut augue eget, dignissim dictum augue.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed et neque porta, auctor elit sit amet, luctus augue. Suspendisse aliquet at justo quis aliquet. Morbi interdum augue sed mauris pulvinar, at efficitur libero efficitur. Sed eget ullamcorper ex. Nam erat tortor, auctor ut ipsum at, feugiat bibendum neque. Ut pellentesque ultrices dolor, ac consequat mauris. Aliquam eget mollis mauris. Phasellus sed velit finibus, tristique libero vitae, volutpat odio. Ut volutpat, metus vitae tempus blandit, ante lacus bibendum ligula, et vulputate eros augue nec augue. Pellentesque velit tellus, scelerisque ut sem sit amet, faucibus condimentum nunc. In eu accumsan mi, at efficitur felis. Sed ligula mi, sagittis ut augue eget, dignissim dictum augue.", "W" });

            migrationBuilder.InsertData(
                table: "CafeContactInfos",
                columns: new[] { "CafeContactInfoId", "CafeContactInfoAddress", "CafeContactInfoMail" },
                values: new object[] { 1, "menuCafe@gmail.com", "adresimiz" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Soğuk Kahveler" },
                    { 2, "Sıcak Kahveler" },
                    { 3, "Soğuk Içecekler" },
                    { 4, "Sıcak Içecekler" },
                    { 5, "Kutu Icecekler" },
                    { 6, "Pastalar" },
                    { 7, "Tatlılar" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ProductDateCreated", "ProductDescription", "ProductImage", "ProductName", "ProductPrice", "ProductShowcase" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soguk latte kahvesi.", "/MenuProductImageFiles/IceCoffe1.jpg", "Ice Latte", 85m, true },
                    { 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soguk americano kahvesi.", "/MenuProductImageFiles/IceCoffe1.jpg", "Ice Americano", 70m, true },
                    { 3, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soguk Nane ve lime aromali icecek.", "/MenuProductImageFiles/IceCoffe1.jpg", "Cool Lime", 100m, true },
                    { 4, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soguk mocha kahvesi.", "/MenuProductImageFiles/IceCoffe1.jpg", "Ice Mocha", 85m, true },
                    { 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soguk bogurtlenli ve limonlu icecek.", "/MenuProductImageFiles/IceCoffe1.jpg", "Berry Lime", 100m, true },
                    { 6, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Çikolatalı yumusak kek.", "/MenuProductImageFiles/IceCoffe1.jpg", "Brownie", 70m, true },
                    { 7, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bal kabağı aromalı latte kahvesi.", "/MenuProductImageFiles/IceCoffe1.jpg", "Pumpkin Spice Latte", 70m, true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CafeContactInfos");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
