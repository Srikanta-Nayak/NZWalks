using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalksAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataforDifficultyandRegion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("14928567-2694-4d9a-9f1f-cdb70651d7d2"), "Hard" },
                    { new Guid("32897835-90c5-43de-b078-938eee1c4a99"), "Easy" },
                    { new Guid("375c2b1e-7370-4057-a8dd-0a70365f0d96"), "Medium" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("06719c97-b4e4-403e-9a86-7a30a5f29fc1"), "AKL", "Auckland", "Auckland-image.jpg" },
                    { new Guid("241de1cb-7924-4b1e-9ca5-a85735497b0d"), "WGN", "Wellington", "Wellington-image.jpg" },
                    { new Guid("2b40c899-6edf-4a33-a213-a3fb124cf22b"), "NSN", "Nelson", "Nelson-image.jpg" },
                    { new Guid("9c192bc5-7aaa-41e5-80c5-fa203d8f4c58"), "NTL", "Northland", null },
                    { new Guid("ae526b88-8e09-4b15-9231-3ea9fde3688a"), "STL", "Southland", null },
                    { new Guid("c328f00f-7ebd-44e5-80b0-90dd5349dccb"), "BOP", "Bay Of Plenty", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("14928567-2694-4d9a-9f1f-cdb70651d7d2"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("32897835-90c5-43de-b078-938eee1c4a99"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("375c2b1e-7370-4057-a8dd-0a70365f0d96"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("06719c97-b4e4-403e-9a86-7a30a5f29fc1"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("241de1cb-7924-4b1e-9ca5-a85735497b0d"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("2b40c899-6edf-4a33-a213-a3fb124cf22b"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("9c192bc5-7aaa-41e5-80c5-fa203d8f4c58"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("ae526b88-8e09-4b15-9231-3ea9fde3688a"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("c328f00f-7ebd-44e5-80b0-90dd5349dccb"));
        }
    }
}
