﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contouring_App.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Devs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateOnly>(type: "date", nullable: false),
                    Techstack = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contract_Length = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Divisions",
                columns: table => new
                {
                    Division_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Division_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Num_employees = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisions", x => x.Division_id);
                });

            migrationBuilder.CreateTable(
                name: "Manager",
                columns: table => new
                {
                    Employee_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Division_id = table.Column<int>(type: "int", nullable: false),
                    Tenure_year = table.Column<int>(type: "int", nullable: false),
                    DOB = table.Column<DateOnly>(type: "date", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manager", x => x.Employee_Id);
                });

            migrationBuilder.CreateTable(
                name: "Trainee",
                columns: table => new
                {
                    Employee_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Division_id = table.Column<int>(type: "int", nullable: false),
                    Tenure_year = table.Column<int>(type: "int", nullable: false),
                    DOB = table.Column<DateOnly>(type: "date", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainee", x => x.Employee_Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAuthenticated = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Devs");

            migrationBuilder.DropTable(
                name: "Divisions");

            migrationBuilder.DropTable(
                name: "Manager");

            migrationBuilder.DropTable(
                name: "Trainee");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
