using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicalOprations.Infrastructure.Migrations
{
    public partial class initialMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalRecords_Patient_PatientId",
                table: "MedicalRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patient",
                schema: "dbo",
                table: "Patient");

            migrationBuilder.RenameTable(
                name: "Patient",
                schema: "dbo",
                newName: "Patients",
                newSchema: "dbo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patients",
                schema: "dbo",
                table: "Patients",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalRecords_Patients_PatientId",
                table: "MedicalRecords",
                column: "PatientId",
                principalSchema: "dbo",
                principalTable: "Patients",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalRecords_Patients_PatientId",
                table: "MedicalRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patients",
                schema: "dbo",
                table: "Patients");

            migrationBuilder.RenameTable(
                name: "Patients",
                schema: "dbo",
                newName: "Patient",
                newSchema: "dbo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patient",
                schema: "dbo",
                table: "Patient",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalRecords_Patient_PatientId",
                table: "MedicalRecords",
                column: "PatientId",
                principalSchema: "dbo",
                principalTable: "Patient",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
