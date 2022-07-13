using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Joy.TS.DAL.Migrations
{
    public partial class Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Client_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    Create_Date = table.Column<string>(nullable: true),
                    Modified_Date = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Client_Id);
                });

            migrationBuilder.CreateTable(
                name: "Designations",
                columns: table => new
                {
                    Designation_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    Modified_Date = table.Column<string>(nullable: true),
                    Create_Date = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designations", x => x.Designation_Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee_Projects",
                columns: table => new
                {
                    Employee_ProjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employee_Id = table.Column<int>(nullable: false),
                    Project_Id = table.Column<int>(nullable: false),
                    Start_Date = table.Column<string>(nullable: true),
                    End_Date = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Create_Date = table.Column<string>(nullable: true),
                    Modified_Date = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Projects", x => x.Employee_ProjectId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Employee_type_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employee_Name = table.Column<string>(nullable: true),
                    Employee_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Employee_type_Id);
                });

            migrationBuilder.CreateTable(
                name: "Employes",
                columns: table => new
                {
                    Employee_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    EmployeeNo = table.Column<int>(nullable: false),
                    Reporting_Manager1 = table.Column<string>(nullable: true),
                    Reportinng_Manager2 = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Role_Id = table.Column<int>(nullable: false),
                    Designations_Id = table.Column<int>(nullable: false),
                    Joining_Date = table.Column<string>(nullable: true),
                    Contact_No = table.Column<int>(nullable: false),
                    Isactive = table.Column<bool>(nullable: false),
                    Create_Date = table.Column<DateTime>(nullable: false),
                    Modified_Date = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employes", x => x.Employee_Id);
                });

            migrationBuilder.CreateTable(
                name: "Projectss",
                columns: table => new
                {
                    Project_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    Code = table.Column<int>(nullable: false),
                    Client_id = table.Column<int>(nullable: false),
                    Isactive = table.Column<bool>(nullable: false),
                    Start_Date = table.Column<string>(nullable: true),
                    End_Date = table.Column<string>(nullable: true),
                    Modified_Date = table.Column<string>(nullable: true),
                    Create_Date = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projectss", x => x.Project_id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Role_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    Create_Date = table.Column<string>(nullable: true),
                    Modified_Date = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Role_Id);
                });

            migrationBuilder.CreateTable(
                name: "Timesheet_Summarys",
                columns: table => new
                {
                    Timesheet_SummaryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employee_Id = table.Column<int>(nullable: false),
                    Month_Year = table.Column<string>(nullable: true),
                    NoOfdays_Worked = table.Column<double>(nullable: false),
                    NoOfLeave_Taken = table.Column<double>(nullable: false),
                    Total_Working_Hours = table.Column<double>(nullable: false),
                    status = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Modified_Date = table.Column<string>(nullable: true),
                    Created_Date = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timesheet_Summarys", x => x.Timesheet_SummaryId);
                });

            migrationBuilder.CreateTable(
                name: "TimeSheets",
                columns: table => new
                {
                    TimeSheet_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employee_Id = table.Column<int>(nullable: false),
                    Day = table.Column<string>(nullable: true),
                    Leave = table.Column<bool>(nullable: false),
                    Date_Time = table.Column<string>(nullable: true),
                    Project_Id = table.Column<int>(nullable: false),
                    TimesheetSummary_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSheets", x => x.TimeSheet_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Designations");

            migrationBuilder.DropTable(
                name: "Employee_Projects");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Employes");

            migrationBuilder.DropTable(
                name: "Projectss");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Timesheet_Summarys");

            migrationBuilder.DropTable(
                name: "TimeSheets");
        }
    }
}
