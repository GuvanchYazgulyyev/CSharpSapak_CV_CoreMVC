using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Proyekt.Migrations
{
    /// <inheritdoc />
    public partial class WhatIdoUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "WhatIdos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IconsUrl",
                table: "WhatIdos",
                newName: "IconClass");

            migrationBuilder.AddColumn<string>(
                name: "ColorClass",
                table: "WhatIdos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Delay",
                table: "WhatIdos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ColorClass",
                table: "WhatIdos");

            migrationBuilder.DropColumn(
                name: "Delay",
                table: "WhatIdos");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "WhatIdos",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "IconClass",
                table: "WhatIdos",
                newName: "IconsUrl");
        }
    }
}
