using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TetPee.Repository.Migrations
{
    /// <inheritdoc />
    public partial class checkdatadb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("3acd11e3-69ff-4d3c-ac73-29cd9f7f839c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66bf31d6-9284-422d-8024-361b45585b76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3438161a-836d-4e51-9168-e27611183d2d"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ParentId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần", null, null },
                    { new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "FirstName", "HashedPassword", "ImageUrl", "IsDeleted", "IsVerify", "LastName", "PhoneNumber", "Role", "UpdatedAt", "VerifyCode" },
                values: new object[,]
                {
                    { new Guid("000c82ed-f12e-4386-b567-cf4fa6ca9ee9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan14@gmail.com", "Tan14", "hashed_password_14", null, false, false, "Tran14", null, "user", null, 0 },
                    { new Guid("000e6dae-cdbe-4e79-b3dc-5060f7954ef1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan992@gmail.com", "Tan992", "hashed_password_992", null, false, false, "Tran992", null, "user", null, 0 },
                    { new Guid("003b5e90-2a5d-4795-a257-059bd3ecc875"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan641@gmail.com", "Tan641", "hashed_password_641", null, false, false, "Tran641", null, "user", null, 0 },
                    { new Guid("005104a2-c83c-4900-ba0a-a782e16e02b8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan619@gmail.com", "Tan619", "hashed_password_619", null, false, false, "Tran619", null, "user", null, 0 },
                    { new Guid("005d7d2d-9ca8-4ee8-aac1-09c19387e2eb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan569@gmail.com", "Tan569", "hashed_password_569", null, false, false, "Tran569", null, "user", null, 0 },
                    { new Guid("006ac1cf-c905-4911-838b-099c5d7227c6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan196@gmail.com", "Tan196", "hashed_password_196", null, false, false, "Tran196", null, "user", null, 0 },
                    { new Guid("007efc54-64d4-4f7f-85dc-694db1282d2f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan743@gmail.com", "Tan743", "hashed_password_743", null, false, false, "Tran743", null, "user", null, 0 },
                    { new Guid("00efb09f-9c2f-42f1-94f8-c6ca143bac2c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan41@gmail.com", "Tan41", "hashed_password_41", null, false, false, "Tran41", null, "user", null, 0 },
                    { new Guid("016b1f1c-e215-427d-90de-e5184a11ea6a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan467@gmail.com", "Tan467", "hashed_password_467", null, false, false, "Tran467", null, "user", null, 0 },
                    { new Guid("01890211-dca2-4658-89c6-66a9b9f2f668"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan821@gmail.com", "Tan821", "hashed_password_821", null, false, false, "Tran821", null, "user", null, 0 },
                    { new Guid("01f82cf1-be81-4d6e-b08c-6636172532f0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan953@gmail.com", "Tan953", "hashed_password_953", null, false, false, "Tran953", null, "user", null, 0 },
                    { new Guid("026e936d-a31d-4d21-b174-7aed498a8767"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan798@gmail.com", "Tan798", "hashed_password_798", null, false, false, "Tran798", null, "user", null, 0 },
                    { new Guid("0280b861-f8ac-404c-b269-19e67b37514a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan765@gmail.com", "Tan765", "hashed_password_765", null, false, false, "Tran765", null, "user", null, 0 },
                    { new Guid("037d89f7-3240-4aa5-bd99-e298b72a2b63"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan835@gmail.com", "Tan835", "hashed_password_835", null, false, false, "Tran835", null, "user", null, 0 },
                    { new Guid("0384db44-b41d-4234-8e69-7ecade758620"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan805@gmail.com", "Tan805", "hashed_password_805", null, false, false, "Tran805", null, "user", null, 0 },
                    { new Guid("03a3f6e7-079a-4178-b8e5-ec546fed0208"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan829@gmail.com", "Tan829", "hashed_password_829", null, false, false, "Tran829", null, "user", null, 0 },
                    { new Guid("040a350e-b922-4873-94c6-c843d8960059"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan304@gmail.com", "Tan304", "hashed_password_304", null, false, false, "Tran304", null, "user", null, 0 },
                    { new Guid("04107e3f-2b27-46df-a458-1c71d0c022d5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan188@gmail.com", "Tan188", "hashed_password_188", null, false, false, "Tran188", null, "user", null, 0 },
                    { new Guid("04490845-7303-48ec-b833-5a1d87a65065"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan991@gmail.com", "Tan991", "hashed_password_991", null, false, false, "Tran991", null, "user", null, 0 },
                    { new Guid("046c1d03-2cf8-44f1-a815-a77d5a89afeb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan260@gmail.com", "Tan260", "hashed_password_260", null, false, false, "Tran260", null, "user", null, 0 },
                    { new Guid("046c515a-fa18-4e57-8fee-8283461fe412"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan364@gmail.com", "Tan364", "hashed_password_364", null, false, false, "Tran364", null, "user", null, 0 },
                    { new Guid("0503be6d-a47d-476c-8b04-00269c24ac8d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan363@gmail.com", "Tan363", "hashed_password_363", null, false, false, "Tran363", null, "user", null, 0 },
                    { new Guid("05b31a42-b844-4dff-97b8-d0828ee2fa4c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan298@gmail.com", "Tan298", "hashed_password_298", null, false, false, "Tran298", null, "user", null, 0 },
                    { new Guid("065439c9-fbca-47e3-9d3a-f775a4d3f9dd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan182@gmail.com", "Tan182", "hashed_password_182", null, false, false, "Tran182", null, "user", null, 0 },
                    { new Guid("07494704-817c-473b-b70b-f7c03a577a12"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan291@gmail.com", "Tan291", "hashed_password_291", null, false, false, "Tran291", null, "user", null, 0 },
                    { new Guid("074e69c8-9a40-4a8b-af17-7279e3b4826b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan242@gmail.com", "Tan242", "hashed_password_242", null, false, false, "Tran242", null, "user", null, 0 },
                    { new Guid("07569347-e1f4-49f8-ad40-8d8fb1428a59"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan174@gmail.com", "Tan174", "hashed_password_174", null, false, false, "Tran174", null, "user", null, 0 },
                    { new Guid("07d0667d-cfe8-49ac-a81e-b6c52742fc07"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan297@gmail.com", "Tan297", "hashed_password_297", null, false, false, "Tran297", null, "user", null, 0 },
                    { new Guid("07dae015-259f-4782-a736-e26173747cd6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan673@gmail.com", "Tan673", "hashed_password_673", null, false, false, "Tran673", null, "user", null, 0 },
                    { new Guid("07e60d1e-f81c-44c7-85fd-28f16ec31270"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan420@gmail.com", "Tan420", "hashed_password_420", null, false, false, "Tran420", null, "user", null, 0 },
                    { new Guid("07eb0968-17f0-4167-84d4-cef3409c99d3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan275@gmail.com", "Tan275", "hashed_password_275", null, false, false, "Tran275", null, "user", null, 0 },
                    { new Guid("081b987b-0a3d-490f-b399-ff25bbf9829c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan131@gmail.com", "Tan131", "hashed_password_131", null, false, false, "Tran131", null, "user", null, 0 },
                    { new Guid("087457bc-ad38-48da-ab4c-1ff0cfec0893"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan632@gmail.com", "Tan632", "hashed_password_632", null, false, false, "Tran632", null, "user", null, 0 },
                    { new Guid("08b07cda-6b6c-4010-a845-3b005c4ed70e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan985@gmail.com", "Tan985", "hashed_password_985", null, false, false, "Tran985", null, "user", null, 0 },
                    { new Guid("08efa311-32e3-46b0-b2cd-1d00681a60a2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan223@gmail.com", "Tan223", "hashed_password_223", null, false, false, "Tran223", null, "user", null, 0 },
                    { new Guid("090a1829-afff-4ee6-881c-6c93e091f4c4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan421@gmail.com", "Tan421", "hashed_password_421", null, false, false, "Tran421", null, "user", null, 0 },
                    { new Guid("091afdd6-4a5d-4892-afe4-1889b1a5abdd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan544@gmail.com", "Tan544", "hashed_password_544", null, false, false, "Tran544", null, "user", null, 0 },
                    { new Guid("093a5480-b74b-479b-bd38-d145a0637d7b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan438@gmail.com", "Tan438", "hashed_password_438", null, false, false, "Tran438", null, "user", null, 0 },
                    { new Guid("098ae222-c72f-4001-b3d3-ec0bb2bf0c3a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan28@gmail.com", "Tan28", "hashed_password_28", null, false, false, "Tran28", null, "user", null, 0 },
                    { new Guid("09902f88-c534-424c-afbb-13b0fcf12ff5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan221@gmail.com", "Tan221", "hashed_password_221", null, false, false, "Tran221", null, "user", null, 0 },
                    { new Guid("0a6b1441-1b98-4a35-8ecc-165bc5b11e3f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan450@gmail.com", "Tan450", "hashed_password_450", null, false, false, "Tran450", null, "user", null, 0 },
                    { new Guid("0a8e7631-be0d-4e2b-aecc-0dcfcdd7767c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan517@gmail.com", "Tan517", "hashed_password_517", null, false, false, "Tran517", null, "user", null, 0 },
                    { new Guid("0a90d2b4-7763-4bf8-99db-3b3b7639b1f8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan852@gmail.com", "Tan852", "hashed_password_852", null, false, false, "Tran852", null, "user", null, 0 },
                    { new Guid("0a97fe0d-4bc6-4231-b0bb-703ed579908f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan101@gmail.com", "Tan101", "hashed_password_101", null, false, false, "Tran101", null, "user", null, 0 },
                    { new Guid("0aff9ade-7187-42ee-bdfe-472dcb976523"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan583@gmail.com", "Tan583", "hashed_password_583", null, false, false, "Tran583", null, "user", null, 0 },
                    { new Guid("0b0e0abc-dcab-4e59-b718-278faf47d9e2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan140@gmail.com", "Tan140", "hashed_password_140", null, false, false, "Tran140", null, "user", null, 0 },
                    { new Guid("0b7c6d8c-df9f-4b71-95d2-bb350424c4da"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan137@gmail.com", "Tan137", "hashed_password_137", null, false, false, "Tran137", null, "user", null, 0 },
                    { new Guid("0bd67e72-fe21-4fd8-b781-d1efafb7aa77"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan896@gmail.com", "Tan896", "hashed_password_896", null, false, false, "Tran896", null, "user", null, 0 },
                    { new Guid("0c0623c6-a268-4139-b36e-0e2f3a6e2b2d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan173@gmail.com", "Tan173", "hashed_password_173", null, false, false, "Tran173", null, "user", null, 0 },
                    { new Guid("0c46615a-f391-4d32-a8eb-50c8bea06e78"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan675@gmail.com", "Tan675", "hashed_password_675", null, false, false, "Tran675", null, "user", null, 0 },
                    { new Guid("0d92054d-4a46-45a8-b702-ba0bf75594b9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan541@gmail.com", "Tan541", "hashed_password_541", null, false, false, "Tran541", null, "user", null, 0 },
                    { new Guid("0d92e0cf-43f4-4e35-be05-4adc01d6c8c8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan92@gmail.com", "Tan92", "hashed_password_92", null, false, false, "Tran92", null, "user", null, 0 },
                    { new Guid("0de9d5c6-2048-4d01-9b70-7b1fc51c8249"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan528@gmail.com", "Tan528", "hashed_password_528", null, false, false, "Tran528", null, "user", null, 0 },
                    { new Guid("0df0096c-e265-42aa-9290-c0fd582666c3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan784@gmail.com", "Tan784", "hashed_password_784", null, false, false, "Tran784", null, "user", null, 0 },
                    { new Guid("0ef05128-bdd7-4b00-aede-fcf4ee3b07dd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan963@gmail.com", "Tan963", "hashed_password_963", null, false, false, "Tran963", null, "user", null, 0 },
                    { new Guid("0f79194f-d966-4785-9dc5-f0cd74fe6ca2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan253@gmail.com", "Tan253", "hashed_password_253", null, false, false, "Tran253", null, "user", null, 0 },
                    { new Guid("0f939fe2-ee3d-4310-ab42-49141d4f1203"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan618@gmail.com", "Tan618", "hashed_password_618", null, false, false, "Tran618", null, "user", null, 0 },
                    { new Guid("10a89ed6-d64e-497a-9c67-d094fede8ce3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan478@gmail.com", "Tan478", "hashed_password_478", null, false, false, "Tran478", null, "user", null, 0 },
                    { new Guid("10aea879-379e-4f6f-9fa7-8644cfd35272"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan237@gmail.com", "Tan237", "hashed_password_237", null, false, false, "Tran237", null, "user", null, 0 },
                    { new Guid("10d6a21e-a299-4130-abb0-362e8fc4f777"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan964@gmail.com", "Tan964", "hashed_password_964", null, false, false, "Tran964", null, "user", null, 0 },
                    { new Guid("112cbd6a-bbaa-4662-ac03-e665c50b9298"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan341@gmail.com", "Tan341", "hashed_password_341", null, false, false, "Tran341", null, "user", null, 0 },
                    { new Guid("114ab360-455a-4e5e-bfe9-4bd3159a6d93"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan813@gmail.com", "Tan813", "hashed_password_813", null, false, false, "Tran813", null, "user", null, 0 },
                    { new Guid("11b90ac7-d0fa-4e4d-8e7b-857018b6ed6a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan886@gmail.com", "Tan886", "hashed_password_886", null, false, false, "Tran886", null, "user", null, 0 },
                    { new Guid("12720f74-1485-4163-b51e-0273bc7ccea4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan84@gmail.com", "Tan84", "hashed_password_84", null, false, false, "Tran84", null, "user", null, 0 },
                    { new Guid("128097c9-64cc-45e8-87cf-47f9d7c5f331"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan573@gmail.com", "Tan573", "hashed_password_573", null, false, false, "Tran573", null, "user", null, 0 },
                    { new Guid("1297a339-737c-4039-bcb6-bdb90dd87c5c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan722@gmail.com", "Tan722", "hashed_password_722", null, false, false, "Tran722", null, "user", null, 0 },
                    { new Guid("1303245c-6c18-42eb-83e7-8fdd54dcea0a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan877@gmail.com", "Tan877", "hashed_password_877", null, false, false, "Tran877", null, "user", null, 0 },
                    { new Guid("13210a79-9362-4360-81ce-6253bdda03c5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan248@gmail.com", "Tan248", "hashed_password_248", null, false, false, "Tran248", null, "user", null, 0 },
                    { new Guid("132197f2-3af2-4a79-b282-ce5d1d415bee"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan957@gmail.com", "Tan957", "hashed_password_957", null, false, false, "Tran957", null, "user", null, 0 },
                    { new Guid("138b362e-015e-4152-b63f-24675a8d4b96"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan191@gmail.com", "Tan191", "hashed_password_191", null, false, false, "Tran191", null, "user", null, 0 },
                    { new Guid("13977ee4-f1ab-4417-a7ba-e50cdea73934"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan168@gmail.com", "Tan168", "hashed_password_168", null, false, false, "Tran168", null, "user", null, 0 },
                    { new Guid("142c40da-4603-4cc1-bbda-6f3bc91ca2a9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan550@gmail.com", "Tan550", "hashed_password_550", null, false, false, "Tran550", null, "user", null, 0 },
                    { new Guid("151dd3c8-eaad-4166-9747-7a2e2c878909"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan841@gmail.com", "Tan841", "hashed_password_841", null, false, false, "Tran841", null, "user", null, 0 },
                    { new Guid("15f2a458-2da8-43c8-bbce-1c05d289dda6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan125@gmail.com", "Tan125", "hashed_password_125", null, false, false, "Tran125", null, "user", null, 0 },
                    { new Guid("160bb2b5-64e0-4b90-a17d-9d1b9799c9ca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan58@gmail.com", "Tan58", "hashed_password_58", null, false, false, "Tran58", null, "user", null, 0 },
                    { new Guid("161bf918-17f2-40a8-86eb-0abb3d654d4b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan340@gmail.com", "Tan340", "hashed_password_340", null, false, false, "Tran340", null, "user", null, 0 },
                    { new Guid("164d28f3-73d5-4a2f-a235-7c4ba102ac1a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan290@gmail.com", "Tan290", "hashed_password_290", null, false, false, "Tran290", null, "user", null, 0 },
                    { new Guid("166d08fd-c085-4f25-8221-2af854ea4b4b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan397@gmail.com", "Tan397", "hashed_password_397", null, false, false, "Tran397", null, "user", null, 0 },
                    { new Guid("16d46600-7e71-4b70-95fa-42100d1ad17f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan665@gmail.com", "Tan665", "hashed_password_665", null, false, false, "Tran665", null, "user", null, 0 },
                    { new Guid("171cf6fb-a173-483e-a3ef-228b5b054680"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan394@gmail.com", "Tan394", "hashed_password_394", null, false, false, "Tran394", null, "user", null, 0 },
                    { new Guid("17a5323d-0ba6-4ccb-9126-ed5d4b31338e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan986@gmail.com", "Tan986", "hashed_password_986", null, false, false, "Tran986", null, "user", null, 0 },
                    { new Guid("17b97ce8-801f-4d1d-a3ae-6a98656c754c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan640@gmail.com", "Tan640", "hashed_password_640", null, false, false, "Tran640", null, "user", null, 0 },
                    { new Guid("17d76355-aa64-43af-9ab5-fb718e7224eb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan876@gmail.com", "Tan876", "hashed_password_876", null, false, false, "Tran876", null, "user", null, 0 },
                    { new Guid("18024e4d-f6a7-4471-8015-530beaea9fef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan126@gmail.com", "Tan126", "hashed_password_126", null, false, false, "Tran126", null, "user", null, 0 },
                    { new Guid("188676c7-87d3-4a96-8a35-3796f34e5594"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan658@gmail.com", "Tan658", "hashed_password_658", null, false, false, "Tran658", null, "user", null, 0 },
                    { new Guid("18e7e330-87b7-4c38-855d-b251465a5694"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan17@gmail.com", "Tan17", "hashed_password_17", null, false, false, "Tran17", null, "user", null, 0 },
                    { new Guid("18f80eef-0767-496d-ab0a-9f56d96dd0da"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan200@gmail.com", "Tan200", "hashed_password_200", null, false, false, "Tran200", null, "user", null, 0 },
                    { new Guid("193211f7-8da1-4ddf-a685-44ffc16dcfad"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan358@gmail.com", "Tan358", "hashed_password_358", null, false, false, "Tran358", null, "user", null, 0 },
                    { new Guid("196185db-379e-4dc2-a893-890ae1e1d246"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan577@gmail.com", "Tan577", "hashed_password_577", null, false, false, "Tran577", null, "user", null, 0 },
                    { new Guid("19a9d4b0-3726-4c33-8f1c-4eb93420890e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan197@gmail.com", "Tan197", "hashed_password_197", null, false, false, "Tran197", null, "user", null, 0 },
                    { new Guid("1a738c41-8e1f-4520-810d-74d51898a520"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan178@gmail.com", "Tan178", "hashed_password_178", null, false, false, "Tran178", null, "user", null, 0 },
                    { new Guid("1a8908eb-1dbd-46c7-97cf-219c4a9b7c30"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan689@gmail.com", "Tan689", "hashed_password_689", null, false, false, "Tran689", null, "user", null, 0 },
                    { new Guid("1ac30d66-d068-4f6f-be74-1500b916a859"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan499@gmail.com", "Tan499", "hashed_password_499", null, false, false, "Tran499", null, "user", null, 0 },
                    { new Guid("1ae339f6-fde1-4a29-924b-785480e9e55e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan15@gmail.com", "Tan15", "hashed_password_15", null, false, false, "Tran15", null, "user", null, 0 },
                    { new Guid("1afc8e57-14ae-4987-8266-b3693eb4daf4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan627@gmail.com", "Tan627", "hashed_password_627", null, false, false, "Tran627", null, "user", null, 0 },
                    { new Guid("1b1f39f6-2b25-478e-97c4-dd87b3b2a624"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan56@gmail.com", "Tan56", "hashed_password_56", null, false, false, "Tran56", null, "user", null, 0 },
                    { new Guid("1b82f153-ac13-487d-a506-53045e2a4436"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan154@gmail.com", "Tan154", "hashed_password_154", null, false, false, "Tran154", null, "user", null, 0 },
                    { new Guid("1bd85702-e241-4422-a6d3-88e518b95736"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan733@gmail.com", "Tan733", "hashed_password_733", null, false, false, "Tran733", null, "user", null, 0 },
                    { new Guid("1c1870dc-766b-4ce1-a605-a743e09c2bea"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan556@gmail.com", "Tan556", "hashed_password_556", null, false, false, "Tran556", null, "user", null, 0 },
                    { new Guid("1c2c55cd-0e6c-4ef8-bfc0-a6ecf98ca8b8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan425@gmail.com", "Tan425", "hashed_password_425", null, false, false, "Tran425", null, "user", null, 0 },
                    { new Guid("1c7648fb-ab44-4eb9-b432-f8d6e4ea8afd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan890@gmail.com", "Tan890", "hashed_password_890", null, false, false, "Tran890", null, "user", null, 0 },
                    { new Guid("1caed79e-abd1-4692-b44e-3af4a08b6e66"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan814@gmail.com", "Tan814", "hashed_password_814", null, false, false, "Tran814", null, "user", null, 0 },
                    { new Guid("1cd4eeaf-32e6-438f-bdca-1eb384864b40"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan589@gmail.com", "Tan589", "hashed_password_589", null, false, false, "Tran589", null, "user", null, 0 },
                    { new Guid("1d2aa8b7-e09c-4bf2-b88e-029eb45fc415"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan874@gmail.com", "Tan874", "hashed_password_874", null, false, false, "Tran874", null, "user", null, 0 },
                    { new Guid("1d461da1-1c8f-48a1-99e5-68d137a44184"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan460@gmail.com", "Tan460", "hashed_password_460", null, false, false, "Tran460", null, "user", null, 0 },
                    { new Guid("1d6fc02b-4473-4f3e-a801-5d3d3646a0c3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan945@gmail.com", "Tan945", "hashed_password_945", null, false, false, "Tran945", null, "user", null, 0 },
                    { new Guid("1d818ee8-c41f-43a5-98ca-f50f98363af9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan408@gmail.com", "Tan408", "hashed_password_408", null, false, false, "Tran408", null, "user", null, 0 },
                    { new Guid("1e6c70e0-57b0-484d-9249-11dd9aeef688"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan615@gmail.com", "Tan615", "hashed_password_615", null, false, false, "Tran615", null, "user", null, 0 },
                    { new Guid("1eab1258-ff55-429f-806c-694c3c8f3ad8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan926@gmail.com", "Tan926", "hashed_password_926", null, false, false, "Tran926", null, "user", null, 0 },
                    { new Guid("1eb972fd-48d0-477d-bf31-1c3b187f87bf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan31@gmail.com", "Tan31", "hashed_password_31", null, false, false, "Tran31", null, "user", null, 0 },
                    { new Guid("1f08ac6f-a2df-4b79-a539-6fbe0001784e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan970@gmail.com", "Tan970", "hashed_password_970", null, false, false, "Tran970", null, "user", null, 0 },
                    { new Guid("1faf4aee-4e81-40c9-b51f-a31f614ec2f0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan871@gmail.com", "Tan871", "hashed_password_871", null, false, false, "Tran871", null, "user", null, 0 },
                    { new Guid("2013d03b-58c0-460f-a7b2-59fbcd3fe454"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan621@gmail.com", "Tan621", "hashed_password_621", null, false, false, "Tran621", null, "user", null, 0 },
                    { new Guid("20476cb1-4f40-4f67-8669-21e66167962d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan918@gmail.com", "Tan918", "hashed_password_918", null, false, false, "Tran918", null, "user", null, 0 },
                    { new Guid("2047e065-90e4-4019-b9c8-efb5d4b60883"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan597@gmail.com", "Tan597", "hashed_password_597", null, false, false, "Tran597", null, "user", null, 0 },
                    { new Guid("204be82b-870a-4e54-940d-0e1573f38ca2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan486@gmail.com", "Tan486", "hashed_password_486", null, false, false, "Tran486", null, "user", null, 0 },
                    { new Guid("20992a20-e1be-492e-a441-d25d19f93064"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan735@gmail.com", "Tan735", "hashed_password_735", null, false, false, "Tran735", null, "user", null, 0 },
                    { new Guid("20bf8f9d-4376-4089-99a1-f4d3fb6c9228"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan100@gmail.com", "Tan100", "hashed_password_100", null, false, false, "Tran100", null, "user", null, 0 },
                    { new Guid("20d330a7-ef8b-4a33-8fff-9915a9b30292"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan863@gmail.com", "Tan863", "hashed_password_863", null, false, false, "Tran863", null, "user", null, 0 },
                    { new Guid("20ef006d-2565-49fa-abf4-7e97319120e9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan802@gmail.com", "Tan802", "hashed_password_802", null, false, false, "Tran802", null, "user", null, 0 },
                    { new Guid("21531760-fd57-4699-b137-8ae7ca4b7edb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan377@gmail.com", "Tan377", "hashed_password_377", null, false, false, "Tran377", null, "user", null, 0 },
                    { new Guid("217a810c-cfff-4735-8fcf-ed87323e7b3e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan477@gmail.com", "Tan477", "hashed_password_477", null, false, false, "Tran477", null, "user", null, 0 },
                    { new Guid("21af1fe3-f6ef-4a24-aa16-0285340a2bd2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan156@gmail.com", "Tan156", "hashed_password_156", null, false, false, "Tran156", null, "user", null, 0 },
                    { new Guid("225bf789-6036-4d14-a4bb-351bc43f2783"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan593@gmail.com", "Tan593", "hashed_password_593", null, false, false, "Tran593", null, "user", null, 0 },
                    { new Guid("226c62c4-3c2b-4f02-8726-1b0471d8ff9a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan563@gmail.com", "Tan563", "hashed_password_563", null, false, false, "Tran563", null, "user", null, 0 },
                    { new Guid("23175440-3515-49c7-81e2-b2799e97bc39"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan252@gmail.com", "Tan252", "hashed_password_252", null, false, false, "Tran252", null, "user", null, 0 },
                    { new Guid("233253a1-bda9-45c9-9427-1918e695ba47"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan375@gmail.com", "Tan375", "hashed_password_375", null, false, false, "Tran375", null, "user", null, 0 },
                    { new Guid("236abb32-851c-44a7-a967-5ed3a108e47e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan740@gmail.com", "Tan740", "hashed_password_740", null, false, false, "Tran740", null, "user", null, 0 },
                    { new Guid("23933a02-bd48-4d38-abf0-0fc06c5ca904"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan52@gmail.com", "Tan52", "hashed_password_52", null, false, false, "Tran52", null, "user", null, 0 },
                    { new Guid("2397fcb7-b467-4b2c-af5e-8e59a92f3c25"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan838@gmail.com", "Tan838", "hashed_password_838", null, false, false, "Tran838", null, "user", null, 0 },
                    { new Guid("23abd39a-4ed2-4835-b031-1a61584e1f8d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan55@gmail.com", "Tan55", "hashed_password_55", null, false, false, "Tran55", null, "user", null, 0 },
                    { new Guid("2402fd4f-7556-41ce-9379-0498071b26f4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan309@gmail.com", "Tan309", "hashed_password_309", null, false, false, "Tran309", null, "user", null, 0 },
                    { new Guid("24050476-0321-4bce-9b34-0e1be67bf92e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan938@gmail.com", "Tan938", "hashed_password_938", null, false, false, "Tran938", null, "user", null, 0 },
                    { new Guid("24ce951a-d7c6-4615-a9c4-0925604cffad"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan8@gmail.com", "Tan8", "hashed_password_8", null, false, false, "Tran8", null, "user", null, 0 },
                    { new Guid("254c84ea-3b99-453d-b9f9-5eceaf56118f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan899@gmail.com", "Tan899", "hashed_password_899", null, false, false, "Tran899", null, "user", null, 0 },
                    { new Guid("25739987-db0d-452d-a9b1-12a35dfac0d8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan117@gmail.com", "Tan117", "hashed_password_117", null, false, false, "Tran117", null, "user", null, 0 },
                    { new Guid("257a3654-ddc0-4298-8f02-fa8679462094"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan961@gmail.com", "Tan961", "hashed_password_961", null, false, false, "Tran961", null, "user", null, 0 },
                    { new Guid("25ba04c5-6a9e-4d8a-b5ee-74b4497caf56"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan823@gmail.com", "Tan823", "hashed_password_823", null, false, false, "Tran823", null, "user", null, 0 },
                    { new Guid("25c4b724-360b-4af8-aba6-f2141bff6c71"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan520@gmail.com", "Tan520", "hashed_password_520", null, false, false, "Tran520", null, "user", null, 0 },
                    { new Guid("26438cee-7061-4241-b91a-96178a4b8d22"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan382@gmail.com", "Tan382", "hashed_password_382", null, false, false, "Tran382", null, "user", null, 0 },
                    { new Guid("2692d381-8ded-4f5f-9c1c-778c9b20c4e7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan846@gmail.com", "Tan846", "hashed_password_846", null, false, false, "Tran846", null, "user", null, 0 },
                    { new Guid("269b878e-c282-4182-8be4-11be265d257b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan185@gmail.com", "Tan185", "hashed_password_185", null, false, false, "Tran185", null, "user", null, 0 },
                    { new Guid("26a7411e-a68f-49b9-be43-6b8f5cb98aed"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan849@gmail.com", "Tan849", "hashed_password_849", null, false, false, "Tran849", null, "user", null, 0 },
                    { new Guid("26bb1579-64a0-4439-9f3b-2f391895f106"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan0@gmail.com", "Tan0", "hashed_password_0", null, false, false, "Tran0", null, "user", null, 0 },
                    { new Guid("2701d585-82fa-49ad-abe0-8f6c78e33cd7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan626@gmail.com", "Tan626", "hashed_password_626", null, false, false, "Tran626", null, "user", null, 0 },
                    { new Guid("2723dc4b-dad5-416a-9543-bb00fbe78034"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan887@gmail.com", "Tan887", "hashed_password_887", null, false, false, "Tran887", null, "user", null, 0 },
                    { new Guid("273baf52-2798-4d65-b551-281f609b3db6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan303@gmail.com", "Tan303", "hashed_password_303", null, false, false, "Tran303", null, "user", null, 0 },
                    { new Guid("27788e67-fcb0-490f-89ee-e4831a38dc48"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan135@gmail.com", "Tan135", "hashed_password_135", null, false, false, "Tran135", null, "user", null, 0 },
                    { new Guid("2798c7c8-0d5c-47fa-b2c9-d52d1e67b50f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan731@gmail.com", "Tan731", "hashed_password_731", null, false, false, "Tran731", null, "user", null, 0 },
                    { new Guid("27d5cc7c-b12c-4d38-b0f2-b5e54fa57ce2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan793@gmail.com", "Tan793", "hashed_password_793", null, false, false, "Tran793", null, "user", null, 0 },
                    { new Guid("27f1e0b7-0208-4c1a-993f-438a8425e381"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan683@gmail.com", "Tan683", "hashed_password_683", null, false, false, "Tran683", null, "user", null, 0 },
                    { new Guid("2831bd5b-ce10-493e-8633-644b9cfe9738"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan316@gmail.com", "Tan316", "hashed_password_316", null, false, false, "Tran316", null, "user", null, 0 },
                    { new Guid("283f182b-9d13-4e75-91c7-2e0df30a5bc6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan742@gmail.com", "Tan742", "hashed_password_742", null, false, false, "Tran742", null, "user", null, 0 },
                    { new Guid("28d97ced-8261-4adf-8a50-ef5de9e726eb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan472@gmail.com", "Tan472", "hashed_password_472", null, false, false, "Tran472", null, "user", null, 0 },
                    { new Guid("292efbe3-3760-42eb-960b-2c3cf77a3fc6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan796@gmail.com", "Tan796", "hashed_password_796", null, false, false, "Tran796", null, "user", null, 0 },
                    { new Guid("29499c01-095b-4b9d-9599-552cc082beba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan295@gmail.com", "Tan295", "hashed_password_295", null, false, false, "Tran295", null, "user", null, 0 },
                    { new Guid("296a79e4-b716-470a-a93a-812a3938ade4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan81@gmail.com", "Tan81", "hashed_password_81", null, false, false, "Tran81", null, "user", null, 0 },
                    { new Guid("298227b3-9bf0-47a8-886c-865f3800701f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan350@gmail.com", "Tan350", "hashed_password_350", null, false, false, "Tran350", null, "user", null, 0 },
                    { new Guid("29c8fb27-8c61-4c1f-9771-b8ed043fcf55"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan5@gmail.com", "Tan5", "hashed_password_5", null, false, false, "Tran5", null, "user", null, 0 },
                    { new Guid("29e3398e-5b08-42d0-b93c-abe7c8bbeeae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan847@gmail.com", "Tan847", "hashed_password_847", null, false, false, "Tran847", null, "user", null, 0 },
                    { new Guid("2a032026-83ee-4079-8899-417e96cb19f8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan633@gmail.com", "Tan633", "hashed_password_633", null, false, false, "Tran633", null, "user", null, 0 },
                    { new Guid("2a3ffb09-da8c-4d47-84db-65b2e6304be0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan782@gmail.com", "Tan782", "hashed_password_782", null, false, false, "Tran782", null, "user", null, 0 },
                    { new Guid("2b3babf1-c2f2-49f6-af4a-300323c81582"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan189@gmail.com", "Tan189", "hashed_password_189", null, false, false, "Tran189", null, "user", null, 0 },
                    { new Guid("2ba57745-4389-400a-b05c-588ec1dcba02"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan147@gmail.com", "Tan147", "hashed_password_147", null, false, false, "Tran147", null, "user", null, 0 },
                    { new Guid("2bb71f76-40c9-4d2c-9206-d2db5283069b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan103@gmail.com", "Tan103", "hashed_password_103", null, false, false, "Tran103", null, "user", null, 0 },
                    { new Guid("2bf093f6-dd90-4502-9a72-0f625fd07657"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan891@gmail.com", "Tan891", "hashed_password_891", null, false, false, "Tran891", null, "user", null, 0 },
                    { new Guid("2bf90f4a-df71-4e0c-8aeb-255bf41c6f8b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan840@gmail.com", "Tan840", "hashed_password_840", null, false, false, "Tran840", null, "user", null, 0 },
                    { new Guid("2bff01b8-b83a-4337-afc8-14453866f088"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan474@gmail.com", "Tan474", "hashed_password_474", null, false, false, "Tran474", null, "user", null, 0 },
                    { new Guid("2c2ac647-6497-4526-a5cd-9cf83e756166"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan332@gmail.com", "Tan332", "hashed_password_332", null, false, false, "Tran332", null, "user", null, 0 },
                    { new Guid("2c4a1aa2-c2d9-4a4c-a786-7d11a01438c5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan448@gmail.com", "Tan448", "hashed_password_448", null, false, false, "Tran448", null, "user", null, 0 },
                    { new Guid("2c78cf0d-773f-4c7a-a0be-ffe986ae8e13"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan928@gmail.com", "Tan928", "hashed_password_928", null, false, false, "Tran928", null, "user", null, 0 },
                    { new Guid("2cabf8a1-612d-41e0-ad71-6945377c1e7e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan529@gmail.com", "Tan529", "hashed_password_529", null, false, false, "Tran529", null, "user", null, 0 },
                    { new Guid("2d71e1e0-a054-4927-a725-8d02635b07c6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan12@gmail.com", "Tan12", "hashed_password_12", null, false, false, "Tran12", null, "user", null, 0 },
                    { new Guid("2d86ea7a-2172-44f0-b826-e9174bce933e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan94@gmail.com", "Tan94", "hashed_password_94", null, false, false, "Tran94", null, "user", null, 0 },
                    { new Guid("2d8ad373-9daa-46ce-b273-f470189fe9d6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan900@gmail.com", "Tan900", "hashed_password_900", null, false, false, "Tran900", null, "user", null, 0 },
                    { new Guid("2db17597-84f9-4ef8-8214-3074dce83bca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan311@gmail.com", "Tan311", "hashed_password_311", null, false, false, "Tran311", null, "user", null, 0 },
                    { new Guid("2e2e5a74-1ca5-4003-ac25-9b7062e5e432"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan889@gmail.com", "Tan889", "hashed_password_889", null, false, false, "Tran889", null, "user", null, 0 },
                    { new Guid("2e37cd67-9256-477e-b708-a715e512027f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan606@gmail.com", "Tan606", "hashed_password_606", null, false, false, "Tran606", null, "user", null, 0 },
                    { new Guid("2ebe3cbb-e63a-4d14-bfd3-ba5dd18c90f5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan642@gmail.com", "Tan642", "hashed_password_642", null, false, false, "Tran642", null, "user", null, 0 },
                    { new Guid("2ebe64ec-9241-462e-a469-6e57e369ded2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan300@gmail.com", "Tan300", "hashed_password_300", null, false, false, "Tran300", null, "user", null, 0 },
                    { new Guid("2ec93b74-e158-4993-a73d-fc13741b8e85"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan719@gmail.com", "Tan719", "hashed_password_719", null, false, false, "Tran719", null, "user", null, 0 },
                    { new Guid("2ecda3ad-521e-4d7b-807a-9f08b2c1a433"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan771@gmail.com", "Tan771", "hashed_password_771", null, false, false, "Tran771", null, "user", null, 0 },
                    { new Guid("2f245a58-0b00-430e-ae7b-0bda5ce4fabb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan119@gmail.com", "Tan119", "hashed_password_119", null, false, false, "Tran119", null, "user", null, 0 },
                    { new Guid("2f9abeab-ae9c-419a-8413-247da6ce620a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan660@gmail.com", "Tan660", "hashed_password_660", null, false, false, "Tran660", null, "user", null, 0 },
                    { new Guid("2f9dd698-0afc-4a46-bdaf-784b446b3e4c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan916@gmail.com", "Tan916", "hashed_password_916", null, false, false, "Tran916", null, "user", null, 0 },
                    { new Guid("3069aecc-adc8-4243-811f-57e5a2175b2b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan850@gmail.com", "Tan850", "hashed_password_850", null, false, false, "Tran850", null, "user", null, 0 },
                    { new Guid("30b43c98-6a86-47aa-9a73-05b7dbbd787c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan419@gmail.com", "Tan419", "hashed_password_419", null, false, false, "Tran419", null, "user", null, 0 },
                    { new Guid("30cca756-0eb7-4f07-a74d-fa7032555714"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan90@gmail.com", "Tan90", "hashed_password_90", null, false, false, "Tran90", null, "user", null, 0 },
                    { new Guid("30fdbaf8-ce87-4d4a-9fe3-3a6baaa71775"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan554@gmail.com", "Tan554", "hashed_password_554", null, false, false, "Tran554", null, "user", null, 0 },
                    { new Guid("312b5941-d18c-4dc4-ab63-afad5a6f0af8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan282@gmail.com", "Tan282", "hashed_password_282", null, false, false, "Tran282", null, "user", null, 0 },
                    { new Guid("313c2e13-6837-46cd-b569-d35800ece16e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan723@gmail.com", "Tan723", "hashed_password_723", null, false, false, "Tran723", null, "user", null, 0 },
                    { new Guid("31949f5f-5fa7-4890-809e-37be25a82c42"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan717@gmail.com", "Tan717", "hashed_password_717", null, false, false, "Tran717", null, "user", null, 0 },
                    { new Guid("32078e1e-2f98-47db-81f9-cd2809775d40"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan205@gmail.com", "Tan205", "hashed_password_205", null, false, false, "Tran205", null, "user", null, 0 },
                    { new Guid("32a92591-5b4f-48af-bbe8-bbea8806c2ec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan432@gmail.com", "Tan432", "hashed_password_432", null, false, false, "Tran432", null, "user", null, 0 },
                    { new Guid("33b77c43-4514-4f6f-a724-ebc663678b8e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan6@gmail.com", "Tan6", "hashed_password_6", null, false, false, "Tran6", null, "user", null, 0 },
                    { new Guid("33cddaf8-fc8c-4070-89dd-c0e2e4c8b923"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan553@gmail.com", "Tan553", "hashed_password_553", null, false, false, "Tran553", null, "user", null, 0 },
                    { new Guid("340016f2-3a43-404e-8b7e-82c8be04dffb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan897@gmail.com", "Tan897", "hashed_password_897", null, false, false, "Tran897", null, "user", null, 0 },
                    { new Guid("3441fc61-8128-4678-8f46-d96adbadb869"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan32@gmail.com", "Tan32", "hashed_password_32", null, false, false, "Tran32", null, "user", null, 0 },
                    { new Guid("349a2509-a7db-4de5-ac84-7a275e8ac9df"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan755@gmail.com", "Tan755", "hashed_password_755", null, false, false, "Tran755", null, "user", null, 0 },
                    { new Guid("34f9c25a-e786-4a16-9844-9495c0ef09f0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan587@gmail.com", "Tan587", "hashed_password_587", null, false, false, "Tran587", null, "user", null, 0 },
                    { new Guid("355441c6-f578-4c32-b13f-fb52175b6715"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan443@gmail.com", "Tan443", "hashed_password_443", null, false, false, "Tran443", null, "user", null, 0 },
                    { new Guid("355b593e-9ea7-4a60-a458-15fe8c011c14"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan978@gmail.com", "Tan978", "hashed_password_978", null, false, false, "Tran978", null, "user", null, 0 },
                    { new Guid("359fa368-ef29-4928-9e51-fe7179298b17"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan246@gmail.com", "Tan246", "hashed_password_246", null, false, false, "Tran246", null, "user", null, 0 },
                    { new Guid("35a3e36c-515c-4615-9150-aad47e092161"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan416@gmail.com", "Tan416", "hashed_password_416", null, false, false, "Tran416", null, "user", null, 0 },
                    { new Guid("35ba5021-9ac0-4080-beac-9740c758b9ca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan591@gmail.com", "Tan591", "hashed_password_591", null, false, false, "Tran591", null, "user", null, 0 },
                    { new Guid("36259f4d-d2ff-4abb-9bd2-2c7a5ec30844"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan51@gmail.com", "Tan51", "hashed_password_51", null, false, false, "Tran51", null, "user", null, 0 },
                    { new Guid("365d552a-1405-4fff-978f-3dddae65b49b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan730@gmail.com", "Tan730", "hashed_password_730", null, false, false, "Tran730", null, "user", null, 0 },
                    { new Guid("368ae8f9-d08c-45b7-ab00-84a61ceecfa8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan812@gmail.com", "Tan812", "hashed_password_812", null, false, false, "Tran812", null, "user", null, 0 },
                    { new Guid("36a48c55-9519-4a50-ac4a-fc314b36e542"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan751@gmail.com", "Tan751", "hashed_password_751", null, false, false, "Tran751", null, "user", null, 0 },
                    { new Guid("36a71abf-b9f7-4c25-8330-4eeed78811cd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan753@gmail.com", "Tan753", "hashed_password_753", null, false, false, "Tran753", null, "user", null, 0 },
                    { new Guid("36c27ce1-27ef-4b93-9ee2-b98f770c9ec7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan404@gmail.com", "Tan404", "hashed_password_404", null, false, false, "Tran404", null, "user", null, 0 },
                    { new Guid("36f5544b-d4a1-4f16-9165-1ae215830f33"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan790@gmail.com", "Tan790", "hashed_password_790", null, false, false, "Tran790", null, "user", null, 0 },
                    { new Guid("375200fb-9d4a-4564-98a6-2d0e72c53734"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan333@gmail.com", "Tan333", "hashed_password_333", null, false, false, "Tran333", null, "user", null, 0 },
                    { new Guid("377e5cc0-b525-4c39-b671-cd23e7d72957"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan49@gmail.com", "Tan49", "hashed_password_49", null, false, false, "Tran49", null, "user", null, 0 },
                    { new Guid("37bc6491-29dd-40f4-8e6e-13db01d3b834"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan674@gmail.com", "Tan674", "hashed_password_674", null, false, false, "Tran674", null, "user", null, 0 },
                    { new Guid("37d9fdd0-d91d-468e-acaa-280a09943628"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan906@gmail.com", "Tan906", "hashed_password_906", null, false, false, "Tran906", null, "user", null, 0 },
                    { new Guid("3835fdb0-9e8a-46be-8eb5-2865facec2ae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan526@gmail.com", "Tan526", "hashed_password_526", null, false, false, "Tran526", null, "user", null, 0 },
                    { new Guid("383ba8a8-354c-4545-acd6-5b8e176dee03"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan206@gmail.com", "Tan206", "hashed_password_206", null, false, false, "Tran206", null, "user", null, 0 },
                    { new Guid("384afe0c-d5e4-4b04-a4ed-0b018089903c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan880@gmail.com", "Tan880", "hashed_password_880", null, false, false, "Tran880", null, "user", null, 0 },
                    { new Guid("38736e56-92f5-4b4b-9826-1ee2043b640b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan867@gmail.com", "Tan867", "hashed_password_867", null, false, false, "Tran867", null, "user", null, 0 },
                    { new Guid("387fb657-9ae8-4c25-baab-86d8e583f2b2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan149@gmail.com", "Tan149", "hashed_password_149", null, false, false, "Tran149", null, "user", null, 0 },
                    { new Guid("3892ad22-e283-4c38-afcc-de2e65e74d9e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan947@gmail.com", "Tan947", "hashed_password_947", null, false, false, "Tran947", null, "user", null, 0 },
                    { new Guid("390fc07a-d094-427a-a874-30c923499839"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan996@gmail.com", "Tan996", "hashed_password_996", null, false, false, "Tran996", null, "user", null, 0 },
                    { new Guid("391454e0-8071-46de-8c9a-62cb63f573b3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan451@gmail.com", "Tan451", "hashed_password_451", null, false, false, "Tran451", null, "user", null, 0 },
                    { new Guid("3998808d-b321-4b03-bbc0-e5546f47e312"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan202@gmail.com", "Tan202", "hashed_password_202", null, false, false, "Tran202", null, "user", null, 0 },
                    { new Guid("39cd0fcd-dbfe-4ffb-8b10-41f76d383d0a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan80@gmail.com", "Tan80", "hashed_password_80", null, false, false, "Tran80", null, "user", null, 0 },
                    { new Guid("39d9c5b3-953a-40f1-b2b4-8c0a3b5b3862"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan88@gmail.com", "Tan88", "hashed_password_88", null, false, false, "Tran88", null, "user", null, 0 },
                    { new Guid("39eb47a0-4aa4-469a-bbb1-d4a2078053f5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan527@gmail.com", "Tan527", "hashed_password_527", null, false, false, "Tran527", null, "user", null, 0 },
                    { new Guid("3a4a8422-c87c-4323-a9a5-3b91fc80bfaa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan226@gmail.com", "Tan226", "hashed_password_226", null, false, false, "Tran226", null, "user", null, 0 },
                    { new Guid("3a63e45f-6a85-4231-b933-878a562d36cb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan114@gmail.com", "Tan114", "hashed_password_114", null, false, false, "Tran114", null, "user", null, 0 },
                    { new Guid("3b9e3690-a030-4f25-9760-bbed92c2636c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan609@gmail.com", "Tan609", "hashed_password_609", null, false, false, "Tran609", null, "user", null, 0 },
                    { new Guid("3c15fa6d-2bb1-4ba7-a8e5-afdb4f8d1725"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan592@gmail.com", "Tan592", "hashed_password_592", null, false, false, "Tran592", null, "user", null, 0 },
                    { new Guid("3c8cf5ee-e761-46cc-a15b-94bd3de308f4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan691@gmail.com", "Tan691", "hashed_password_691", null, false, false, "Tran691", null, "user", null, 0 },
                    { new Guid("3cc06400-42c1-483b-b728-b7efa081428f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan914@gmail.com", "Tan914", "hashed_password_914", null, false, false, "Tran914", null, "user", null, 0 },
                    { new Guid("3ce1b524-9a69-4549-b703-4cce57e15f97"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan558@gmail.com", "Tan558", "hashed_password_558", null, false, false, "Tran558", null, "user", null, 0 },
                    { new Guid("3d093360-fb41-4e2d-91be-3fedd7b0ae58"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan199@gmail.com", "Tan199", "hashed_password_199", null, false, false, "Tran199", null, "user", null, 0 },
                    { new Guid("3d71f050-06e2-4293-8857-253e202a603e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan22@gmail.com", "Tan22", "hashed_password_22", null, false, false, "Tran22", null, "user", null, 0 },
                    { new Guid("3d98a763-3a1c-4956-bb0e-62f47860761e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan934@gmail.com", "Tan934", "hashed_password_934", null, false, false, "Tran934", null, "user", null, 0 },
                    { new Guid("3e776ef9-83fd-48e6-b7db-360edd314027"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan524@gmail.com", "Tan524", "hashed_password_524", null, false, false, "Tran524", null, "user", null, 0 },
                    { new Guid("3e87d34e-3620-44ca-9782-c9b486c68fda"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan9@gmail.com", "Tan9", "hashed_password_9", null, false, false, "Tran9", null, "user", null, 0 },
                    { new Guid("3e90a162-fcc8-44bd-835e-7c0db825cb16"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan329@gmail.com", "Tan329", "hashed_password_329", null, false, false, "Tran329", null, "user", null, 0 },
                    { new Guid("3ea5651b-da75-4ee8-ac10-43af0ff6a968"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan11@gmail.com", "Tan11", "hashed_password_11", null, false, false, "Tran11", null, "user", null, 0 },
                    { new Guid("3eec754a-8389-48e9-8ce8-f78a7a93236b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan857@gmail.com", "Tan857", "hashed_password_857", null, false, false, "Tran857", null, "user", null, 0 },
                    { new Guid("3f499d80-967c-42c8-be05-967f851440cf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan881@gmail.com", "Tan881", "hashed_password_881", null, false, false, "Tran881", null, "user", null, 0 },
                    { new Guid("3f8cd8d3-15b2-44ab-b5f7-f3425ba6e861"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan832@gmail.com", "Tan832", "hashed_password_832", null, false, false, "Tran832", null, "user", null, 0 },
                    { new Guid("3f91ed29-79fa-4d1b-9196-5bf0afd221dd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan734@gmail.com", "Tan734", "hashed_password_734", null, false, false, "Tran734", null, "user", null, 0 },
                    { new Guid("3f94574b-daca-4d8b-806c-88a261d183cc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan38@gmail.com", "Tan38", "hashed_password_38", null, false, false, "Tran38", null, "user", null, 0 },
                    { new Guid("3f969377-8e95-4386-88b5-3cce7c9a08e5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan994@gmail.com", "Tan994", "hashed_password_994", null, false, false, "Tran994", null, "user", null, 0 },
                    { new Guid("3fde12e5-fe1f-4402-b721-99a138f1c623"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan624@gmail.com", "Tan624", "hashed_password_624", null, false, false, "Tran624", null, "user", null, 0 },
                    { new Guid("40236876-dff0-4c57-afba-26e124b6f3b2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan411@gmail.com", "Tan411", "hashed_password_411", null, false, false, "Tran411", null, "user", null, 0 },
                    { new Guid("403cbe1d-3d8f-45bf-97c7-9ee9207284a2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan651@gmail.com", "Tan651", "hashed_password_651", null, false, false, "Tran651", null, "user", null, 0 },
                    { new Guid("403ff196-dcda-464a-980a-947260f9c467"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan327@gmail.com", "Tan327", "hashed_password_327", null, false, false, "Tran327", null, "user", null, 0 },
                    { new Guid("40d2d254-512d-496c-b163-ca613487a379"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan698@gmail.com", "Tan698", "hashed_password_698", null, false, false, "Tran698", null, "user", null, 0 },
                    { new Guid("41885544-c0ae-4818-a25e-b373dbf32ef5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan422@gmail.com", "Tan422", "hashed_password_422", null, false, false, "Tran422", null, "user", null, 0 },
                    { new Guid("41da4c70-b1cd-4437-a311-bfffbb3f0570"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan323@gmail.com", "Tan323", "hashed_password_323", null, false, false, "Tran323", null, "user", null, 0 },
                    { new Guid("421b435c-c80d-447c-a5ab-40b7f19e0a58"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan711@gmail.com", "Tan711", "hashed_password_711", null, false, false, "Tran711", null, "user", null, 0 },
                    { new Guid("4250d225-9281-4add-9cbf-93f425e1bb53"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan647@gmail.com", "Tan647", "hashed_password_647", null, false, false, "Tran647", null, "user", null, 0 },
                    { new Guid("4263b76e-85e3-493a-85f6-9d14fb3f7f06"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan962@gmail.com", "Tan962", "hashed_password_962", null, false, false, "Tran962", null, "user", null, 0 },
                    { new Guid("429d2857-7ff5-4841-81c0-63fa1f29c5c9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan979@gmail.com", "Tan979", "hashed_password_979", null, false, false, "Tran979", null, "user", null, 0 },
                    { new Guid("42bcf47b-a043-41b2-8002-71dd349ac678"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan873@gmail.com", "Tan873", "hashed_password_873", null, false, false, "Tran873", null, "user", null, 0 },
                    { new Guid("42c3126f-3d49-435f-a59c-a99514ec240e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan514@gmail.com", "Tan514", "hashed_password_514", null, false, false, "Tran514", null, "user", null, 0 },
                    { new Guid("42e560c5-bae5-44a2-ae05-4b731679eac0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan907@gmail.com", "Tan907", "hashed_password_907", null, false, false, "Tran907", null, "user", null, 0 },
                    { new Guid("42ea69d0-e88b-4a3b-ba41-7708ffde0f2b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan946@gmail.com", "Tan946", "hashed_password_946", null, false, false, "Tran946", null, "user", null, 0 },
                    { new Guid("42f96fb5-6d9f-45b5-a821-3cdf99e09a1b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan568@gmail.com", "Tan568", "hashed_password_568", null, false, false, "Tran568", null, "user", null, 0 },
                    { new Guid("43738534-c9f7-4874-886b-ce90cce3c1af"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan853@gmail.com", "Tan853", "hashed_password_853", null, false, false, "Tran853", null, "user", null, 0 },
                    { new Guid("43d9f8ff-f3d4-440e-9320-7a66892a17b0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan98@gmail.com", "Tan98", "hashed_password_98", null, false, false, "Tran98", null, "user", null, 0 },
                    { new Guid("44364c36-9431-4aa0-9b48-03bb7fb4fc40"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan346@gmail.com", "Tan346", "hashed_password_346", null, false, false, "Tran346", null, "user", null, 0 },
                    { new Guid("449ed62b-9606-4e35-a5fc-d45264d6d3eb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan132@gmail.com", "Tan132", "hashed_password_132", null, false, false, "Tran132", null, "user", null, 0 },
                    { new Guid("44b2e45a-4a43-4b47-8cb8-d55cab37987c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan285@gmail.com", "Tan285", "hashed_password_285", null, false, false, "Tran285", null, "user", null, 0 },
                    { new Guid("4514ada9-0599-4242-bf7a-b2df70587822"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan878@gmail.com", "Tan878", "hashed_password_878", null, false, false, "Tran878", null, "user", null, 0 },
                    { new Guid("453d1491-07ee-443d-815d-854552039d96"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan586@gmail.com", "Tan586", "hashed_password_586", null, false, false, "Tran586", null, "user", null, 0 },
                    { new Guid("453fe6dd-e8fc-4dce-b8e3-18483c9f4336"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan650@gmail.com", "Tan650", "hashed_password_650", null, false, false, "Tran650", null, "user", null, 0 },
                    { new Guid("45447b6c-63f6-467d-9858-d879942277bb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan898@gmail.com", "Tan898", "hashed_password_898", null, false, false, "Tran898", null, "user", null, 0 },
                    { new Guid("457bea00-e453-440a-881e-a73c6a5ef27e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan259@gmail.com", "Tan259", "hashed_password_259", null, false, false, "Tran259", null, "user", null, 0 },
                    { new Guid("45834685-afde-4b40-a896-8b3440b94437"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan959@gmail.com", "Tan959", "hashed_password_959", null, false, false, "Tran959", null, "user", null, 0 },
                    { new Guid("459dca4b-d06e-4b22-8d2c-4a8dbc880df1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan72@gmail.com", "Tan72", "hashed_password_72", null, false, false, "Tran72", null, "user", null, 0 },
                    { new Guid("45f6738a-c42b-4c2d-ae09-1f274b08198b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan655@gmail.com", "Tan655", "hashed_password_655", null, false, false, "Tran655", null, "user", null, 0 },
                    { new Guid("46dd9da8-d722-4237-8d98-418318cafb6c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan745@gmail.com", "Tan745", "hashed_password_745", null, false, false, "Tran745", null, "user", null, 0 },
                    { new Guid("46f2696d-c6c2-4e72-a11d-69e558c1409a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan653@gmail.com", "Tan653", "hashed_password_653", null, false, false, "Tran653", null, "user", null, 0 },
                    { new Guid("476cfd40-fbfb-466f-a1e5-827cfd5871b8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan169@gmail.com", "Tan169", "hashed_password_169", null, false, false, "Tran169", null, "user", null, 0 },
                    { new Guid("47a17398-f4ad-4fc1-bcb9-f859e0c790f1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan700@gmail.com", "Tan700", "hashed_password_700", null, false, false, "Tran700", null, "user", null, 0 },
                    { new Guid("481141d7-bb08-4907-8520-e342d8319d5e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan374@gmail.com", "Tan374", "hashed_password_374", null, false, false, "Tran374", null, "user", null, 0 },
                    { new Guid("481adaf1-5709-442f-a1d1-f43f7998ee97"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan622@gmail.com", "Tan622", "hashed_password_622", null, false, false, "Tran622", null, "user", null, 0 },
                    { new Guid("4823ca07-6024-4c6a-a905-3c2fb4cfab6f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan2@gmail.com", "Tan2", "hashed_password_2", null, false, false, "Tran2", null, "user", null, 0 },
                    { new Guid("483a8f75-b708-4172-8622-a24d14ec2995"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan772@gmail.com", "Tan772", "hashed_password_772", null, false, false, "Tran772", null, "user", null, 0 },
                    { new Guid("48c809f9-3c6e-433e-8d0c-d60b56e9076a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan446@gmail.com", "Tan446", "hashed_password_446", null, false, false, "Tran446", null, "user", null, 0 },
                    { new Guid("48d27154-0631-43ae-acf1-7c0abb0e3c43"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan70@gmail.com", "Tan70", "hashed_password_70", null, false, false, "Tran70", null, "user", null, 0 },
                    { new Guid("48fc3cb5-b3fe-4838-8a30-09ed29fc353e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan91@gmail.com", "Tan91", "hashed_password_91", null, false, false, "Tran91", null, "user", null, 0 },
                    { new Guid("49bb64c3-9361-49e7-8901-db3db7a3037b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan281@gmail.com", "Tan281", "hashed_password_281", null, false, false, "Tran281", null, "user", null, 0 },
                    { new Guid("4b40a543-38e6-4eb8-a7ba-ca0632c83d82"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan820@gmail.com", "Tan820", "hashed_password_820", null, false, false, "Tran820", null, "user", null, 0 },
                    { new Guid("4bb57cb3-f398-4605-9477-59ce1338c84f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan484@gmail.com", "Tan484", "hashed_password_484", null, false, false, "Tran484", null, "user", null, 0 },
                    { new Guid("4bd581a6-912f-4218-92a2-310232fa8fd1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan710@gmail.com", "Tan710", "hashed_password_710", null, false, false, "Tran710", null, "user", null, 0 },
                    { new Guid("4be8464c-3730-46f5-9219-9bda47382c35"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan869@gmail.com", "Tan869", "hashed_password_869", null, false, false, "Tran869", null, "user", null, 0 },
                    { new Guid("4cc0d00f-4528-4714-98d1-5732dda0ea95"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan120@gmail.com", "Tan120", "hashed_password_120", null, false, false, "Tran120", null, "user", null, 0 },
                    { new Guid("4cdf2f2b-4d1b-44bb-a947-02d083efb9f7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan45@gmail.com", "Tan45", "hashed_password_45", null, false, false, "Tran45", null, "user", null, 0 },
                    { new Guid("4dcc4128-aabb-4380-ad4b-6db4267bf290"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan325@gmail.com", "Tan325", "hashed_password_325", null, false, false, "Tran325", null, "user", null, 0 },
                    { new Guid("4de6cdbd-6fc5-451d-886a-cdf5fb257ef4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan781@gmail.com", "Tan781", "hashed_password_781", null, false, false, "Tran781", null, "user", null, 0 },
                    { new Guid("4e18a8ff-0e01-43c8-b28a-ebf19603506f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan537@gmail.com", "Tan537", "hashed_password_537", null, false, false, "Tran537", null, "user", null, 0 },
                    { new Guid("4e71d6c0-0d74-4e99-a900-c9c3c6e804c0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan497@gmail.com", "Tan497", "hashed_password_497", null, false, false, "Tran497", null, "user", null, 0 },
                    { new Guid("4efa3a67-8931-447a-8919-49ba2f5f6fce"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan598@gmail.com", "Tan598", "hashed_password_598", null, false, false, "Tran598", null, "user", null, 0 },
                    { new Guid("4f341ab7-97f1-4111-b9b1-f6c7322e217c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan901@gmail.com", "Tan901", "hashed_password_901", null, false, false, "Tran901", null, "user", null, 0 },
                    { new Guid("4f5aef47-8544-4576-8def-18af7d1320ba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan468@gmail.com", "Tan468", "hashed_password_468", null, false, false, "Tran468", null, "user", null, 0 },
                    { new Guid("4f66552b-3d25-4200-bc12-efbff50d3a75"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan488@gmail.com", "Tan488", "hashed_password_488", null, false, false, "Tran488", null, "user", null, 0 },
                    { new Guid("4fa2ad51-2e74-462a-9c52-899dea6fef5c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan536@gmail.com", "Tan536", "hashed_password_536", null, false, false, "Tran536", null, "user", null, 0 },
                    { new Guid("4fc24792-e462-430f-918d-c988c5a8a08c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan150@gmail.com", "Tan150", "hashed_password_150", null, false, false, "Tran150", null, "user", null, 0 },
                    { new Guid("4feec09f-74e7-4791-8786-f65179141ed1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan190@gmail.com", "Tan190", "hashed_password_190", null, false, false, "Tran190", null, "user", null, 0 },
                    { new Guid("4ff40991-b3ed-4ca9-9c19-c5520fb39ce1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan779@gmail.com", "Tan779", "hashed_password_779", null, false, false, "Tran779", null, "user", null, 0 },
                    { new Guid("50425ee9-b333-418a-b68c-10b9aede26c3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan383@gmail.com", "Tan383", "hashed_password_383", null, false, false, "Tran383", null, "user", null, 0 },
                    { new Guid("50738943-40a6-4042-8ebe-357df9869448"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan801@gmail.com", "Tan801", "hashed_password_801", null, false, false, "Tran801", null, "user", null, 0 },
                    { new Guid("515bc7ad-cac4-4915-b502-62c114b23e55"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan201@gmail.com", "Tan201", "hashed_password_201", null, false, false, "Tran201", null, "user", null, 0 },
                    { new Guid("515f1a90-be46-4425-8dfc-c30cd899d53e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan207@gmail.com", "Tan207", "hashed_password_207", null, false, false, "Tran207", null, "user", null, 0 },
                    { new Guid("518356ee-d1c5-4593-ac7a-32e81d35f772"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan170@gmail.com", "Tan170", "hashed_password_170", null, false, false, "Tran170", null, "user", null, 0 },
                    { new Guid("51c6b846-9087-4bb4-a97f-2b8eeb6a948e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan969@gmail.com", "Tan969", "hashed_password_969", null, false, false, "Tran969", null, "user", null, 0 },
                    { new Guid("51eefb9b-4c9a-4420-81b2-cdf0a1ce1362"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan360@gmail.com", "Tan360", "hashed_password_360", null, false, false, "Tran360", null, "user", null, 0 },
                    { new Guid("520555dd-1b14-4673-af74-c7e3accf8271"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan948@gmail.com", "Tan948", "hashed_password_948", null, false, false, "Tran948", null, "user", null, 0 },
                    { new Guid("53466b1d-956f-4785-a11c-7548550138ba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan402@gmail.com", "Tan402", "hashed_password_402", null, false, false, "Tran402", null, "user", null, 0 },
                    { new Guid("53619014-fa8e-422a-b3a7-ff55dfb3c952"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan932@gmail.com", "Tan932", "hashed_password_932", null, false, false, "Tran932", null, "user", null, 0 },
                    { new Guid("538406da-ba94-456a-b72b-729a1c1c1174"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan581@gmail.com", "Tan581", "hashed_password_581", null, false, false, "Tran581", null, "user", null, 0 },
                    { new Guid("53cc4a65-ae6d-40cc-bd42-6c4ad202a1bc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan636@gmail.com", "Tan636", "hashed_password_636", null, false, false, "Tran636", null, "user", null, 0 },
                    { new Guid("53e4a6d1-e4c4-4fbc-8a4b-cdf159f89979"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan856@gmail.com", "Tan856", "hashed_password_856", null, false, false, "Tran856", null, "user", null, 0 },
                    { new Guid("53f24d19-18a0-44b8-b73c-6736c2ca28ef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan401@gmail.com", "Tan401", "hashed_password_401", null, false, false, "Tran401", null, "user", null, 0 },
                    { new Guid("540c6947-c4d5-4c4f-9b2b-222fef441e5b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan603@gmail.com", "Tan603", "hashed_password_603", null, false, false, "Tran603", null, "user", null, 0 },
                    { new Guid("54fb058e-fe0a-4597-ab55-be0b8f8dc163"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan227@gmail.com", "Tan227", "hashed_password_227", null, false, false, "Tran227", null, "user", null, 0 },
                    { new Guid("55313933-fc1b-4575-a26d-a4a33f711464"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan274@gmail.com", "Tan274", "hashed_password_274", null, false, false, "Tran274", null, "user", null, 0 },
                    { new Guid("55460832-7078-4dbe-b3b8-615eb6c73cb7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan697@gmail.com", "Tan697", "hashed_password_697", null, false, false, "Tran697", null, "user", null, 0 },
                    { new Guid("556827dc-46d1-44f6-bab2-e0ecf1e01b12"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan816@gmail.com", "Tan816", "hashed_password_816", null, false, false, "Tran816", null, "user", null, 0 },
                    { new Guid("564afc93-b44b-4b75-a52f-5b6ffe0e843b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan561@gmail.com", "Tan561", "hashed_password_561", null, false, false, "Tran561", null, "user", null, 0 },
                    { new Guid("56572373-7280-44c3-9951-227ce0b57089"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan676@gmail.com", "Tan676", "hashed_password_676", null, false, false, "Tran676", null, "user", null, 0 },
                    { new Guid("566915e9-9f0a-4bf6-9fed-763514b2c4ff"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan679@gmail.com", "Tan679", "hashed_password_679", null, false, false, "Tran679", null, "user", null, 0 },
                    { new Guid("568625c2-b7e7-49da-83fd-7016b8b66966"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan99@gmail.com", "Tan99", "hashed_password_99", null, false, false, "Tran99", null, "user", null, 0 },
                    { new Guid("56948d0e-0fb6-4c01-9b3b-2440fa084f69"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan612@gmail.com", "Tan612", "hashed_password_612", null, false, false, "Tran612", null, "user", null, 0 },
                    { new Guid("56c14308-beb6-4562-87e3-0cdbbab8b124"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan283@gmail.com", "Tan283", "hashed_password_283", null, false, false, "Tran283", null, "user", null, 0 },
                    { new Guid("56c4c8fc-b8ca-432a-8016-4b97989c0c52"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan868@gmail.com", "Tan868", "hashed_password_868", null, false, false, "Tran868", null, "user", null, 0 },
                    { new Guid("5724e0b0-2d35-4935-b543-f27f6dbaa79c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan682@gmail.com", "Tan682", "hashed_password_682", null, false, false, "Tran682", null, "user", null, 0 },
                    { new Guid("5746e391-dabb-4250-b6c7-77e3d674ba75"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan646@gmail.com", "Tan646", "hashed_password_646", null, false, false, "Tran646", null, "user", null, 0 },
                    { new Guid("575b7de2-fe2c-4bfe-b1b0-856f8de56300"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan270@gmail.com", "Tan270", "hashed_password_270", null, false, false, "Tran270", null, "user", null, 0 },
                    { new Guid("57ec9722-7ae3-4852-b239-276589c0ebb3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan74@gmail.com", "Tan74", "hashed_password_74", null, false, false, "Tran74", null, "user", null, 0 },
                    { new Guid("57ed714d-06f8-47e6-8116-a76f2a0e9f94"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan391@gmail.com", "Tan391", "hashed_password_391", null, false, false, "Tran391", null, "user", null, 0 },
                    { new Guid("58487166-3292-4e80-8be1-20488f26646d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan336@gmail.com", "Tan336", "hashed_password_336", null, false, false, "Tran336", null, "user", null, 0 },
                    { new Guid("58aa4b49-a00d-4e54-a288-97fa976c56fd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan78@gmail.com", "Tan78", "hashed_password_78", null, false, false, "Tran78", null, "user", null, 0 },
                    { new Guid("58b5274b-0258-45fd-8923-f36272103cda"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan965@gmail.com", "Tan965", "hashed_password_965", null, false, false, "Tran965", null, "user", null, 0 },
                    { new Guid("590d7392-f9d4-40bc-b2e1-ce4c140f02cb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan378@gmail.com", "Tan378", "hashed_password_378", null, false, false, "Tran378", null, "user", null, 0 },
                    { new Guid("597f090e-8f19-444c-ac46-d60c8a4b3666"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan800@gmail.com", "Tan800", "hashed_password_800", null, false, false, "Tran800", null, "user", null, 0 },
                    { new Guid("59867078-caeb-47bf-8c58-c25df68b13a8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan453@gmail.com", "Tan453", "hashed_password_453", null, false, false, "Tran453", null, "user", null, 0 },
                    { new Guid("59edcf5f-6534-4007-8f02-90da26c1bc2b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan138@gmail.com", "Tan138", "hashed_password_138", null, false, false, "Tran138", null, "user", null, 0 },
                    { new Guid("5a262825-84cb-4e1f-9516-bc80d489331f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan972@gmail.com", "Tan972", "hashed_password_972", null, false, false, "Tran972", null, "user", null, 0 },
                    { new Guid("5a432612-f8f4-40e4-b0b3-61d30e72d089"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan261@gmail.com", "Tan261", "hashed_password_261", null, false, false, "Tran261", null, "user", null, 0 },
                    { new Guid("5a4c1702-5707-43c4-81f0-1ddc5e43e28d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan562@gmail.com", "Tan562", "hashed_password_562", null, false, false, "Tran562", null, "user", null, 0 },
                    { new Guid("5acb3e7d-d01a-4c78-b187-b22c0ba902e6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan286@gmail.com", "Tan286", "hashed_password_286", null, false, false, "Tran286", null, "user", null, 0 },
                    { new Guid("5b066979-59ee-442e-8642-90f8b37d0656"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan808@gmail.com", "Tan808", "hashed_password_808", null, false, false, "Tran808", null, "user", null, 0 },
                    { new Guid("5c0f2afc-4651-4530-9ae4-880c4bc9cf5c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan525@gmail.com", "Tan525", "hashed_password_525", null, false, false, "Tran525", null, "user", null, 0 },
                    { new Guid("5c303e28-b401-4dcd-8c7c-ec31fd938ce4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan294@gmail.com", "Tan294", "hashed_password_294", null, false, false, "Tran294", null, "user", null, 0 },
                    { new Guid("5c51caf5-5582-41b9-bc29-630ad5f5e55b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan704@gmail.com", "Tan704", "hashed_password_704", null, false, false, "Tran704", null, "user", null, 0 },
                    { new Guid("5d0b5a9b-0e43-4fcd-8532-ef303627bc6f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan858@gmail.com", "Tan858", "hashed_password_858", null, false, false, "Tran858", null, "user", null, 0 },
                    { new Guid("5d92e0c7-6a86-4ce7-b1d1-2909cc5f06cd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan870@gmail.com", "Tan870", "hashed_password_870", null, false, false, "Tran870", null, "user", null, 0 },
                    { new Guid("5db8b91a-63b3-4392-9aad-b1cf19b06fe5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan415@gmail.com", "Tan415", "hashed_password_415", null, false, false, "Tran415", null, "user", null, 0 },
                    { new Guid("5dc3c860-17a4-450a-9765-479b517ed3c0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan974@gmail.com", "Tan974", "hashed_password_974", null, false, false, "Tran974", null, "user", null, 0 },
                    { new Guid("5ddfc43a-2c84-4c91-a044-6b8de56effc8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan540@gmail.com", "Tan540", "hashed_password_540", null, false, false, "Tran540", null, "user", null, 0 },
                    { new Guid("5e105480-784f-4351-8b0d-44ef4cab5250"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan134@gmail.com", "Tan134", "hashed_password_134", null, false, false, "Tran134", null, "user", null, 0 },
                    { new Guid("5e3bae3f-15b2-4889-939b-89a8688afc36"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan842@gmail.com", "Tan842", "hashed_password_842", null, false, false, "Tran842", null, "user", null, 0 },
                    { new Guid("5eb6af11-c230-4a5e-a739-94e9ac8f3efb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan518@gmail.com", "Tan518", "hashed_password_518", null, false, false, "Tran518", null, "user", null, 0 },
                    { new Guid("5f0fa1bc-3222-4845-80b0-02c409f28076"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan968@gmail.com", "Tan968", "hashed_password_968", null, false, false, "Tran968", null, "user", null, 0 },
                    { new Guid("5fa0a4f8-45b7-4b04-9e49-16de392283d7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan218@gmail.com", "Tan218", "hashed_password_218", null, false, false, "Tran218", null, "user", null, 0 },
                    { new Guid("60ac9e26-47c2-458d-b957-83df053e7be4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan351@gmail.com", "Tan351", "hashed_password_351", null, false, false, "Tran351", null, "user", null, 0 },
                    { new Guid("60ca7ea0-bc29-48e9-9738-04285853dbc3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan762@gmail.com", "Tan762", "hashed_password_762", null, false, false, "Tran762", null, "user", null, 0 },
                    { new Guid("60f1c8bf-f0ef-407d-921c-4ffcd907ce52"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan462@gmail.com", "Tan462", "hashed_password_462", null, false, false, "Tran462", null, "user", null, 0 },
                    { new Guid("6161da80-deac-46ff-bb8c-590c60c793a1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan664@gmail.com", "Tan664", "hashed_password_664", null, false, false, "Tran664", null, "user", null, 0 },
                    { new Guid("61cd7742-573b-4965-8a93-80b93e5affc9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan703@gmail.com", "Tan703", "hashed_password_703", null, false, false, "Tran703", null, "user", null, 0 },
                    { new Guid("6246b760-7230-43cf-9b13-bbe56dd8ab4c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan611@gmail.com", "Tan611", "hashed_password_611", null, false, false, "Tran611", null, "user", null, 0 },
                    { new Guid("625501d5-fb5c-44de-9bd7-9076d70e07f0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan141@gmail.com", "Tan141", "hashed_password_141", null, false, false, "Tran141", null, "user", null, 0 },
                    { new Guid("62727c13-9ccc-4d3a-b706-3424f8019df8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan4@gmail.com", "Tan4", "hashed_password_4", null, false, false, "Tran4", null, "user", null, 0 },
                    { new Guid("6275b696-2b3d-4074-b28b-c08dbdbb28c6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan758@gmail.com", "Tan758", "hashed_password_758", null, false, false, "Tran758", null, "user", null, 0 },
                    { new Guid("629128a1-ac14-4361-9277-8bb98d113d29"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan162@gmail.com", "Tan162", "hashed_password_162", null, false, false, "Tran162", null, "user", null, 0 },
                    { new Guid("62c72713-5459-4fc7-bcec-e6f8d4f1a241"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan455@gmail.com", "Tan455", "hashed_password_455", null, false, false, "Tran455", null, "user", null, 0 },
                    { new Guid("62cd4a2c-61d8-4697-8c74-593e1733a5a8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan230@gmail.com", "Tan230", "hashed_password_230", null, false, false, "Tran230", null, "user", null, 0 },
                    { new Guid("62d3b6d9-74c5-4c35-8892-29933e0838b6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan940@gmail.com", "Tan940", "hashed_password_940", null, false, false, "Tran940", null, "user", null, 0 },
                    { new Guid("62dfc755-6dd7-4832-98d3-56f2ad9f7d23"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan269@gmail.com", "Tan269", "hashed_password_269", null, false, false, "Tran269", null, "user", null, 0 },
                    { new Guid("6332bfbd-b624-4d69-976c-04481905708c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan696@gmail.com", "Tan696", "hashed_password_696", null, false, false, "Tran696", null, "user", null, 0 },
                    { new Guid("6342cd60-6679-4e36-a2f6-f26428f6c407"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan590@gmail.com", "Tan590", "hashed_password_590", null, false, false, "Tran590", null, "user", null, 0 },
                    { new Guid("637e1101-fb48-48c3-b038-3a692077e58c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan214@gmail.com", "Tan214", "hashed_password_214", null, false, false, "Tran214", null, "user", null, 0 },
                    { new Guid("637ed532-b936-4a3f-9359-415f5d2f6026"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan738@gmail.com", "Tan738", "hashed_password_738", null, false, false, "Tran738", null, "user", null, 0 },
                    { new Guid("63ad5eaa-e4be-497a-a189-d344549db094"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan144@gmail.com", "Tan144", "hashed_password_144", null, false, false, "Tran144", null, "user", null, 0 },
                    { new Guid("63e5a47b-71de-4902-aeef-963c70730ffa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan273@gmail.com", "Tan273", "hashed_password_273", null, false, false, "Tran273", null, "user", null, 0 },
                    { new Guid("63f8bd41-0e40-4cd8-997c-600ef1bf986d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan507@gmail.com", "Tan507", "hashed_password_507", null, false, false, "Tran507", null, "user", null, 0 },
                    { new Guid("64ac36c0-2426-48f3-8c12-01d5528914e8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan393@gmail.com", "Tan393", "hashed_password_393", null, false, false, "Tran393", null, "user", null, 0 },
                    { new Guid("64b133c5-93d2-425d-bd95-8dd9e63bf6da"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan44@gmail.com", "Tan44", "hashed_password_44", null, false, false, "Tran44", null, "user", null, 0 },
                    { new Guid("65289bc3-8b6d-4d2d-87c1-837abee5d259"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan987@gmail.com", "Tan987", "hashed_password_987", null, false, false, "Tran987", null, "user", null, 0 },
                    { new Guid("655b1b80-77f6-414b-b7fd-da34dd8002bf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan305@gmail.com", "Tan305", "hashed_password_305", null, false, false, "Tran305", null, "user", null, 0 },
                    { new Guid("655e82fe-f446-4133-a4e8-19f9f0b33bfd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan244@gmail.com", "Tan244", "hashed_password_244", null, false, false, "Tran244", null, "user", null, 0 },
                    { new Guid("65961592-959c-40d8-b415-fe646eacb68f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan62@gmail.com", "Tan62", "hashed_password_62", null, false, false, "Tran62", null, "user", null, 0 },
                    { new Guid("6599c96e-da48-403f-a83a-33286c2d00c4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan396@gmail.com", "Tan396", "hashed_password_396", null, false, false, "Tran396", null, "user", null, 0 },
                    { new Guid("65d27b27-66b6-4c8d-8a7f-bb6e4678826b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan454@gmail.com", "Tan454", "hashed_password_454", null, false, false, "Tran454", null, "user", null, 0 },
                    { new Guid("6708debd-4c24-4b4d-aa50-20eb548a5212"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan198@gmail.com", "Tan198", "hashed_password_198", null, false, false, "Tran198", null, "user", null, 0 },
                    { new Guid("6742f284-2a4d-4a27-9142-30631d7aec7d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan130@gmail.com", "Tan130", "hashed_password_130", null, false, false, "Tran130", null, "user", null, 0 },
                    { new Guid("67dd05d0-0f7c-49fa-b781-9764fc99bc5c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan481@gmail.com", "Tan481", "hashed_password_481", null, false, false, "Tran481", null, "user", null, 0 },
                    { new Guid("683497f8-8aca-4a2b-ba8e-ce74e1b7a133"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan145@gmail.com", "Tan145", "hashed_password_145", null, false, false, "Tran145", null, "user", null, 0 },
                    { new Guid("68399ceb-6d3a-4525-b798-d88a788924e6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan233@gmail.com", "Tan233", "hashed_password_233", null, false, false, "Tran233", null, "user", null, 0 },
                    { new Guid("68a6aa53-b864-4368-8915-fcdbbb81fe80"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan610@gmail.com", "Tan610", "hashed_password_610", null, false, false, "Tran610", null, "user", null, 0 },
                    { new Guid("68f595d4-f79a-4f6f-88c6-8b523387339b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan77@gmail.com", "Tan77", "hashed_password_77", null, false, false, "Tran77", null, "user", null, 0 },
                    { new Guid("6919c4cc-4133-4c05-885b-ebac02e22c42"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan748@gmail.com", "Tan748", "hashed_password_748", null, false, false, "Tran748", null, "user", null, 0 },
                    { new Guid("691ed2a8-4a84-410b-b80a-c1c52e2eb685"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan181@gmail.com", "Tan181", "hashed_password_181", null, false, false, "Tran181", null, "user", null, 0 },
                    { new Guid("69287f7d-27d7-4b2a-a17b-c8b93b900a36"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan937@gmail.com", "Tan937", "hashed_password_937", null, false, false, "Tran937", null, "user", null, 0 },
                    { new Guid("69356f58-2dab-4377-adeb-e63dec065114"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan983@gmail.com", "Tan983", "hashed_password_983", null, false, false, "Tran983", null, "user", null, 0 },
                    { new Guid("694567f0-a224-4101-b361-a8b267bff6d2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan565@gmail.com", "Tan565", "hashed_password_565", null, false, false, "Tran565", null, "user", null, 0 },
                    { new Guid("69d495ba-7fdf-4dde-ae15-6b1c96c256c8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan34@gmail.com", "Tan34", "hashed_password_34", null, false, false, "Tran34", null, "user", null, 0 },
                    { new Guid("6a1df1a1-52c9-4837-bb29-477f02b22f35"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan337@gmail.com", "Tan337", "hashed_password_337", null, false, false, "Tran337", null, "user", null, 0 },
                    { new Guid("6a86edc2-77f9-46ce-83d2-751fb0c69782"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan671@gmail.com", "Tan671", "hashed_password_671", null, false, false, "Tran671", null, "user", null, 0 },
                    { new Guid("6ae04076-005b-44b8-91f0-6ebb325b2742"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan381@gmail.com", "Tan381", "hashed_password_381", null, false, false, "Tran381", null, "user", null, 0 },
                    { new Guid("6ae92431-890f-4bc9-b199-097fb9ba92b5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan123@gmail.com", "Tan123", "hashed_password_123", null, false, false, "Tran123", null, "user", null, 0 },
                    { new Guid("6b1ea1bc-1e77-4dfe-9c40-d9c2d6d71e65"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan522@gmail.com", "Tan522", "hashed_password_522", null, false, false, "Tran522", null, "user", null, 0 },
                    { new Guid("6b2b8efc-61ab-488e-bd66-56e0e97f266e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan532@gmail.com", "Tan532", "hashed_password_532", null, false, false, "Tran532", null, "user", null, 0 },
                    { new Guid("6b33bd09-b7ff-4364-9e4e-60f06d1bc927"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan153@gmail.com", "Tan153", "hashed_password_153", null, false, false, "Tran153", null, "user", null, 0 },
                    { new Guid("6bfac893-69d8-4dd1-b569-a447b62b760e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan115@gmail.com", "Tan115", "hashed_password_115", null, false, false, "Tran115", null, "user", null, 0 },
                    { new Guid("6c349a81-bb2a-42df-b26d-d6228eaa790f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan943@gmail.com", "Tan943", "hashed_password_943", null, false, false, "Tran943", null, "user", null, 0 },
                    { new Guid("6c416319-febd-4f9b-98ed-e84067a89cf1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan924@gmail.com", "Tan924", "hashed_password_924", null, false, false, "Tran924", null, "user", null, 0 },
                    { new Guid("6ce5f096-513d-4f10-9984-d702becca472"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan588@gmail.com", "Tan588", "hashed_password_588", null, false, false, "Tran588", null, "user", null, 0 },
                    { new Guid("6cf488ee-792f-49ec-a6c6-1bdd43625f39"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan766@gmail.com", "Tan766", "hashed_password_766", null, false, false, "Tran766", null, "user", null, 0 },
                    { new Guid("6d120395-b370-4bc5-96ad-9e330c1895e7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan465@gmail.com", "Tan465", "hashed_password_465", null, false, false, "Tran465", null, "user", null, 0 },
                    { new Guid("6d58c081-1fea-4b99-9eec-2bcf0240af45"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan213@gmail.com", "Tan213", "hashed_password_213", null, false, false, "Tran213", null, "user", null, 0 },
                    { new Guid("6d6a918f-7469-4b7a-86a8-f65d0c9a0a47"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan535@gmail.com", "Tan535", "hashed_password_535", null, false, false, "Tran535", null, "user", null, 0 },
                    { new Guid("6d72f16a-527f-45a8-8651-fe0e982fb392"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan228@gmail.com", "Tan228", "hashed_password_228", null, false, false, "Tran228", null, "user", null, 0 },
                    { new Guid("6ddae668-8710-4580-b5a9-28b0adafd54b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan941@gmail.com", "Tan941", "hashed_password_941", null, false, false, "Tran941", null, "user", null, 0 },
                    { new Guid("6ddddf27-825b-4056-9818-47f66eb73247"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan386@gmail.com", "Tan386", "hashed_password_386", null, false, false, "Tran386", null, "user", null, 0 },
                    { new Guid("6e007143-6e50-4984-8f73-80edabb2f185"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan209@gmail.com", "Tan209", "hashed_password_209", null, false, false, "Tran209", null, "user", null, 0 },
                    { new Guid("6e5ed85a-b6ee-4a70-ac5b-65458c44882d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan27@gmail.com", "Tan27", "hashed_password_27", null, false, false, "Tran27", null, "user", null, 0 },
                    { new Guid("6e61a316-53d1-4ad5-bbd1-7d50579c19aa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan352@gmail.com", "Tan352", "hashed_password_352", null, false, false, "Tran352", null, "user", null, 0 },
                    { new Guid("6e9fd495-1b48-411b-a71a-92f94331b779"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan975@gmail.com", "Tan975", "hashed_password_975", null, false, false, "Tran975", null, "user", null, 0 },
                    { new Guid("6f2ebeb6-c3a0-4cd5-9e85-9c81580b9d50"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan571@gmail.com", "Tan571", "hashed_password_571", null, false, false, "Tran571", null, "user", null, 0 },
                    { new Guid("6f33f70b-7bba-4c4c-995b-84368aae1ed8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan266@gmail.com", "Tan266", "hashed_password_266", null, false, false, "Tran266", null, "user", null, 0 },
                    { new Guid("6f3afe28-271b-4846-900a-6959be036f24"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan936@gmail.com", "Tan936", "hashed_password_936", null, false, false, "Tran936", null, "user", null, 0 },
                    { new Guid("6ff3dc12-0803-409a-a4e9-058fd7deab3d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan837@gmail.com", "Tan837", "hashed_password_837", null, false, false, "Tran837", null, "user", null, 0 },
                    { new Guid("7021154c-0fbe-46fd-b926-52a4532c8e62"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan792@gmail.com", "Tan792", "hashed_password_792", null, false, false, "Tran792", null, "user", null, 0 },
                    { new Guid("702aafaf-b5e0-4e43-801a-e4126ba1c156"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan903@gmail.com", "Tan903", "hashed_password_903", null, false, false, "Tran903", null, "user", null, 0 },
                    { new Guid("70f8f1bf-9bb7-48ba-bad7-e24282c54b83"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan30@gmail.com", "Tan30", "hashed_password_30", null, false, false, "Tran30", null, "user", null, 0 },
                    { new Guid("71150c6b-57c2-4b5c-a6af-c2fafd2d785a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan724@gmail.com", "Tan724", "hashed_password_724", null, false, false, "Tran724", null, "user", null, 0 },
                    { new Guid("71609381-3148-4575-bc4d-8b81aa053c0a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan106@gmail.com", "Tan106", "hashed_password_106", null, false, false, "Tran106", null, "user", null, 0 },
                    { new Guid("718fa952-0d88-44ce-bbb8-41c1713baca3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan741@gmail.com", "Tan741", "hashed_password_741", null, false, false, "Tran741", null, "user", null, 0 },
                    { new Guid("71e831f1-01c4-4e6c-ac47-5e40ff51a042"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan546@gmail.com", "Tan546", "hashed_password_546", null, false, false, "Tran546", null, "user", null, 0 },
                    { new Guid("72069637-3f77-49dc-b6c6-4a60725811c5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan786@gmail.com", "Tan786", "hashed_password_786", null, false, false, "Tran786", null, "user", null, 0 },
                    { new Guid("721e2621-1972-4e4d-a424-7b85995de2e0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan220@gmail.com", "Tan220", "hashed_password_220", null, false, false, "Tran220", null, "user", null, 0 },
                    { new Guid("722745b1-5631-4537-9966-5d99d6c67f9a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan73@gmail.com", "Tan73", "hashed_password_73", null, false, false, "Tran73", null, "user", null, 0 },
                    { new Guid("72337037-aa08-4ae7-8904-da12c8530623"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan254@gmail.com", "Tan254", "hashed_password_254", null, false, false, "Tran254", null, "user", null, 0 },
                    { new Guid("7275ce4c-7472-4464-887c-57be13d60314"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan656@gmail.com", "Tan656", "hashed_password_656", null, false, false, "Tran656", null, "user", null, 0 },
                    { new Guid("72ac4c23-f29b-4cbe-9384-299f213399cb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan26@gmail.com", "Tan26", "hashed_password_26", null, false, false, "Tran26", null, "user", null, 0 },
                    { new Guid("73438734-9893-4307-930c-565413ec5155"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan580@gmail.com", "Tan580", "hashed_password_580", null, false, false, "Tran580", null, "user", null, 0 },
                    { new Guid("73f423df-f1e7-43b5-8622-32e114684549"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan993@gmail.com", "Tan993", "hashed_password_993", null, false, false, "Tran993", null, "user", null, 0 },
                    { new Guid("74050320-844e-473a-9248-86e179fcd97d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan548@gmail.com", "Tan548", "hashed_password_548", null, false, false, "Tran548", null, "user", null, 0 },
                    { new Guid("744820e7-fc94-465c-818b-845313a3a01d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan769@gmail.com", "Tan769", "hashed_password_769", null, false, false, "Tran769", null, "user", null, 0 },
                    { new Guid("74ae39d7-bc66-4f01-970e-f9a421a1621a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan339@gmail.com", "Tan339", "hashed_password_339", null, false, false, "Tran339", null, "user", null, 0 },
                    { new Guid("758ad68a-1f3d-4da8-a022-8c11e3bd26f3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan774@gmail.com", "Tan774", "hashed_password_774", null, false, false, "Tran774", null, "user", null, 0 },
                    { new Guid("75c677df-a2f6-4506-a52a-78d0c7014d0b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan566@gmail.com", "Tan566", "hashed_password_566", null, false, false, "Tran566", null, "user", null, 0 },
                    { new Guid("761141c5-8bf9-471f-baec-f5dd170ba6cb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan739@gmail.com", "Tan739", "hashed_password_739", null, false, false, "Tran739", null, "user", null, 0 },
                    { new Guid("76987de8-4288-4733-a1ce-538d4b15c6ba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan18@gmail.com", "Tan18", "hashed_password_18", null, false, false, "Tran18", null, "user", null, 0 },
                    { new Guid("76e24508-32f0-4294-aae5-28e5b24bd3a7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan418@gmail.com", "Tan418", "hashed_password_418", null, false, false, "Tran418", null, "user", null, 0 },
                    { new Guid("77144262-8f29-499e-98c6-01d9cc58c625"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan966@gmail.com", "Tan966", "hashed_password_966", null, false, false, "Tran966", null, "user", null, 0 },
                    { new Guid("772b3363-035c-4586-ae41-3e1e67889314"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan491@gmail.com", "Tan491", "hashed_password_491", null, false, false, "Tran491", null, "user", null, 0 },
                    { new Guid("78349e02-ed48-4978-ba73-b6547fa37655"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan866@gmail.com", "Tan866", "hashed_password_866", null, false, false, "Tran866", null, "user", null, 0 },
                    { new Guid("78565563-54f3-4c5b-9531-82c98995fa61"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan287@gmail.com", "Tan287", "hashed_password_287", null, false, false, "Tran287", null, "user", null, 0 },
                    { new Guid("78bec3e9-9d0c-4f1e-b90b-ae366db4c5ca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "tan182206@gmail.com", "Tan", "hashed_password_1", null, false, false, "Tran", null, "user", null, 0 },
                    { new Guid("78d3cf0d-09f6-47ac-b1b4-1b36dd85ef6e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan628@gmail.com", "Tan628", "hashed_password_628", null, false, false, "Tran628", null, "user", null, 0 },
                    { new Guid("7930ec46-4327-4bcb-ab01-bafa97a1732d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan1@gmail.com", "Tan1", "hashed_password_1", null, false, false, "Tran1", null, "user", null, 0 },
                    { new Guid("796b6a86-b904-461d-bb32-8dad79b39406"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan508@gmail.com", "Tan508", "hashed_password_508", null, false, false, "Tran508", null, "user", null, 0 },
                    { new Guid("79925190-8ac8-4aa7-962b-0efd5237d000"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan39@gmail.com", "Tan39", "hashed_password_39", null, false, false, "Tran39", null, "user", null, 0 },
                    { new Guid("7a024820-16f4-47d7-bedd-a2a139aa541c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan770@gmail.com", "Tan770", "hashed_password_770", null, false, false, "Tran770", null, "user", null, 0 },
                    { new Guid("7a2b2f72-c025-4419-bc57-1a8a0232df65"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan63@gmail.com", "Tan63", "hashed_password_63", null, false, false, "Tran63", null, "user", null, 0 },
                    { new Guid("7a3d53e8-d21c-466f-9cf6-435846908447"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan356@gmail.com", "Tan356", "hashed_password_356", null, false, false, "Tran356", null, "user", null, 0 },
                    { new Guid("7a80da6d-9ce0-4a23-92b8-468b7b4fdfe6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan872@gmail.com", "Tan872", "hashed_password_872", null, false, false, "Tran872", null, "user", null, 0 },
                    { new Guid("7afe36d4-0778-4eb2-89b7-e1eca224b6e6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan476@gmail.com", "Tan476", "hashed_password_476", null, false, false, "Tran476", null, "user", null, 0 },
                    { new Guid("7b63b1f7-4c88-4ace-920b-c5115c6302df"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan879@gmail.com", "Tan879", "hashed_password_879", null, false, false, "Tran879", null, "user", null, 0 },
                    { new Guid("7b686e7e-56b6-4451-b883-db47840f7f24"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan424@gmail.com", "Tan424", "hashed_password_424", null, false, false, "Tran424", null, "user", null, 0 },
                    { new Guid("7b93e19a-b362-47b9-a93c-cd0d29cbb9e4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan614@gmail.com", "Tan614", "hashed_password_614", null, false, false, "Tran614", null, "user", null, 0 },
                    { new Guid("7ba8a32b-cddb-44d9-b06a-f60ac5a82fd6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan754@gmail.com", "Tan754", "hashed_password_754", null, false, false, "Tran754", null, "user", null, 0 },
                    { new Guid("7bb30e2f-6da2-4e1d-a4b1-7f3ddea64ab3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan240@gmail.com", "Tan240", "hashed_password_240", null, false, false, "Tran240", null, "user", null, 0 },
                    { new Guid("7bc0518e-ff56-40ca-a4d3-1c2fbf1f9e3a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan692@gmail.com", "Tan692", "hashed_password_692", null, false, false, "Tran692", null, "user", null, 0 },
                    { new Guid("7c58056f-e5ae-4d5a-ae62-35ae026195c4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan461@gmail.com", "Tan461", "hashed_password_461", null, false, false, "Tran461", null, "user", null, 0 },
                    { new Guid("7c58f639-a5e7-4506-97cf-344bd3a180e1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan343@gmail.com", "Tan343", "hashed_password_343", null, false, false, "Tran343", null, "user", null, 0 },
                    { new Guid("7c5b458c-c29f-474d-bf35-3ae22099e21b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan458@gmail.com", "Tan458", "hashed_password_458", null, false, false, "Tran458", null, "user", null, 0 },
                    { new Guid("7c648e4d-d145-4712-9ff2-1de14a901b75"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan322@gmail.com", "Tan322", "hashed_password_322", null, false, false, "Tran322", null, "user", null, 0 },
                    { new Guid("7c6e8683-7bcb-4de8-8e90-af0cd7c89d8b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan317@gmail.com", "Tan317", "hashed_password_317", null, false, false, "Tran317", null, "user", null, 0 },
                    { new Guid("7c6fb850-4777-4b04-aeb1-786fbfe95c1b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan152@gmail.com", "Tan152", "hashed_password_152", null, false, false, "Tran152", null, "user", null, 0 },
                    { new Guid("7d10d480-391c-4c06-883f-89fa77cab4df"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan715@gmail.com", "Tan715", "hashed_password_715", null, false, false, "Tran715", null, "user", null, 0 },
                    { new Guid("7d22bf01-b793-4a8e-9672-993ebeaa0461"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan231@gmail.com", "Tan231", "hashed_password_231", null, false, false, "Tran231", null, "user", null, 0 },
                    { new Guid("7d79e453-edec-43b6-a9ca-6675171fdc56"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan143@gmail.com", "Tan143", "hashed_password_143", null, false, false, "Tran143", null, "user", null, 0 },
                    { new Guid("7da580e1-1f4d-469c-8fc1-1a2c28ef11de"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan95@gmail.com", "Tan95", "hashed_password_95", null, false, false, "Tran95", null, "user", null, 0 },
                    { new Guid("7e137307-95d5-449f-ac14-b41c501bc7db"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan195@gmail.com", "Tan195", "hashed_password_195", null, false, false, "Tran195", null, "user", null, 0 },
                    { new Guid("7e82d506-e5b4-453b-bbc4-8e6bb5c470c0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan373@gmail.com", "Tan373", "hashed_password_373", null, false, false, "Tran373", null, "user", null, 0 },
                    { new Guid("7f0f16ad-3109-4c2e-ae88-a967cfab303a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan403@gmail.com", "Tan403", "hashed_password_403", null, false, false, "Tran403", null, "user", null, 0 },
                    { new Guid("807fc761-e51f-4bdd-a1f1-e1982999f39a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan884@gmail.com", "Tan884", "hashed_password_884", null, false, false, "Tran884", null, "user", null, 0 },
                    { new Guid("80b7231a-8021-424a-8582-9c604d799b56"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan736@gmail.com", "Tan736", "hashed_password_736", null, false, false, "Tran736", null, "user", null, 0 },
                    { new Guid("80d50d2f-a510-4043-b350-854e49e1320b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan414@gmail.com", "Tan414", "hashed_password_414", null, false, false, "Tran414", null, "user", null, 0 },
                    { new Guid("814ccf80-a673-4dfb-8ed4-1ae05a88dfb6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan596@gmail.com", "Tan596", "hashed_password_596", null, false, false, "Tran596", null, "user", null, 0 },
                    { new Guid("816f0c72-f499-42d9-b3a6-c30189beb4f0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan338@gmail.com", "Tan338", "hashed_password_338", null, false, false, "Tran338", null, "user", null, 0 },
                    { new Guid("818670e7-0463-4e86-89e8-a442a77d717b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan668@gmail.com", "Tan668", "hashed_password_668", null, false, false, "Tran668", null, "user", null, 0 },
                    { new Guid("81be6e16-fe8a-40b5-9e87-ccf74d246232"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan243@gmail.com", "Tan243", "hashed_password_243", null, false, false, "Tran243", null, "user", null, 0 },
                    { new Guid("8211473f-c615-4a72-b7b1-933ebb8dda1c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan709@gmail.com", "Tan709", "hashed_password_709", null, false, false, "Tran709", null, "user", null, 0 },
                    { new Guid("82205b3c-dd11-478d-82b4-618a45b5b34e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan666@gmail.com", "Tan666", "hashed_password_666", null, false, false, "Tran666", null, "user", null, 0 },
                    { new Guid("82a01202-71aa-4a1b-b80b-1ab241c9b05c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan440@gmail.com", "Tan440", "hashed_password_440", null, false, false, "Tran440", null, "user", null, 0 },
                    { new Guid("82a857a3-a2bf-4965-99ea-7af43b1e89ad"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan768@gmail.com", "Tan768", "hashed_password_768", null, false, false, "Tran768", null, "user", null, 0 },
                    { new Guid("83415c67-57b3-4cb9-9d9a-86e692be4fe6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan235@gmail.com", "Tan235", "hashed_password_235", null, false, false, "Tran235", null, "user", null, 0 },
                    { new Guid("834701e5-95a3-4e54-9dd0-457e80f16f15"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan361@gmail.com", "Tan361", "hashed_password_361", null, false, false, "Tran361", null, "user", null, 0 },
                    { new Guid("836ad48f-d699-44f0-b2f7-510a93e83e8e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan775@gmail.com", "Tan775", "hashed_password_775", null, false, false, "Tran775", null, "user", null, 0 },
                    { new Guid("8390d7d6-99a1-4a14-81fe-67d8af45fd79"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan163@gmail.com", "Tan163", "hashed_password_163", null, false, false, "Tran163", null, "user", null, 0 },
                    { new Guid("842f47c8-20eb-48e5-bf41-282b28e750a4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan278@gmail.com", "Tan278", "hashed_password_278", null, false, false, "Tran278", null, "user", null, 0 },
                    { new Guid("845316fd-4fbf-4904-a786-f4208643c1ac"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan557@gmail.com", "Tan557", "hashed_password_557", null, false, false, "Tran557", null, "user", null, 0 },
                    { new Guid("846311e4-a05d-446d-86c1-55a19fd5155d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan778@gmail.com", "Tan778", "hashed_password_778", null, false, false, "Tran778", null, "user", null, 0 },
                    { new Guid("84897d08-a5a8-4c5e-9cb1-c4828ab40abd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan171@gmail.com", "Tan171", "hashed_password_171", null, false, false, "Tran171", null, "user", null, 0 },
                    { new Guid("8496a917-0b30-4b7e-9e6a-e2dbfac025bf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan638@gmail.com", "Tan638", "hashed_password_638", null, false, false, "Tran638", null, "user", null, 0 },
                    { new Guid("84dcb97c-9a24-4598-af6d-52e53a2c30c4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan371@gmail.com", "Tan371", "hashed_password_371", null, false, false, "Tran371", null, "user", null, 0 },
                    { new Guid("84e5b1ff-a1cd-4f28-b1e7-d2a241e8e282"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan180@gmail.com", "Tan180", "hashed_password_180", null, false, false, "Tran180", null, "user", null, 0 },
                    { new Guid("855808bc-f634-4c7e-a81c-f55d64259319"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan921@gmail.com", "Tan921", "hashed_password_921", null, false, false, "Tran921", null, "user", null, 0 },
                    { new Guid("856a8720-4844-4105-a967-29a763e507fc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan342@gmail.com", "Tan342", "hashed_password_342", null, false, false, "Tran342", null, "user", null, 0 },
                    { new Guid("85cb9d8c-e9ee-4c92-a82a-eef0ab198990"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan272@gmail.com", "Tan272", "hashed_password_272", null, false, false, "Tran272", null, "user", null, 0 },
                    { new Guid("8633d609-5749-4b7e-87d3-17c23d1e9901"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan65@gmail.com", "Tan65", "hashed_password_65", null, false, false, "Tran65", null, "user", null, 0 },
                    { new Guid("86a4861d-c5f3-4ecd-a57e-e56738a97b20"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan193@gmail.com", "Tan193", "hashed_password_193", null, false, false, "Tran193", null, "user", null, 0 },
                    { new Guid("86c03bd1-1595-4dd8-a11a-48dac77e4fab"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan146@gmail.com", "Tan146", "hashed_password_146", null, false, false, "Tran146", null, "user", null, 0 },
                    { new Guid("86c0d5dc-eee1-4e14-ac8d-0710d6ba600d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan447@gmail.com", "Tan447", "hashed_password_447", null, false, false, "Tran447", null, "user", null, 0 },
                    { new Guid("86d5e20a-d724-402a-abdc-a7ccedf608d5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan746@gmail.com", "Tan746", "hashed_password_746", null, false, false, "Tran746", null, "user", null, 0 },
                    { new Guid("86e84219-3e07-4b21-b318-bb978a4e6db8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan25@gmail.com", "Tan25", "hashed_password_25", null, false, false, "Tran25", null, "user", null, 0 },
                    { new Guid("870f5c66-8725-46f9-b36e-f5faa2386146"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan670@gmail.com", "Tan670", "hashed_password_670", null, false, false, "Tran670", null, "user", null, 0 },
                    { new Guid("87963154-33a6-4a27-b345-a6ee2bbd3f55"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan693@gmail.com", "Tan693", "hashed_password_693", null, false, false, "Tran693", null, "user", null, 0 },
                    { new Guid("87e248f7-0e45-4c65-a569-22aac1b92a90"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan905@gmail.com", "Tan905", "hashed_password_905", null, false, false, "Tran905", null, "user", null, 0 },
                    { new Guid("884a4f4e-dfac-46df-be70-5c04935ae8b6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan776@gmail.com", "Tan776", "hashed_password_776", null, false, false, "Tran776", null, "user", null, 0 },
                    { new Guid("8859a98f-ba4f-4471-98c9-eca21a0db1b2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan166@gmail.com", "Tan166", "hashed_password_166", null, false, false, "Tran166", null, "user", null, 0 },
                    { new Guid("889232ce-3b8a-41a9-9d63-d07f01e4a662"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan470@gmail.com", "Tan470", "hashed_password_470", null, false, false, "Tran470", null, "user", null, 0 },
                    { new Guid("88ed9106-ecaf-4261-9f15-41990f1b438e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan494@gmail.com", "Tan494", "hashed_password_494", null, false, false, "Tran494", null, "user", null, 0 },
                    { new Guid("89135ca3-1e59-4a0d-baa7-08be4b480fe0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan713@gmail.com", "Tan713", "hashed_password_713", null, false, false, "Tran713", null, "user", null, 0 },
                    { new Guid("8987c9d2-16bf-4baa-8b69-c564ef33ffd3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan951@gmail.com", "Tan951", "hashed_password_951", null, false, false, "Tran951", null, "user", null, 0 },
                    { new Guid("899ff0c8-2a0f-4ebf-a065-52132e1a2e61"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan482@gmail.com", "Tan482", "hashed_password_482", null, false, false, "Tran482", null, "user", null, 0 },
                    { new Guid("89c1366f-d8b7-4626-96ef-1a717e9d82fd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan797@gmail.com", "Tan797", "hashed_password_797", null, false, false, "Tran797", null, "user", null, 0 },
                    { new Guid("89c868d6-0aef-474d-81f9-58daad1e25c5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan204@gmail.com", "Tan204", "hashed_password_204", null, false, false, "Tran204", null, "user", null, 0 },
                    { new Guid("8a8a1fba-999c-40e7-a8d2-0a4c03a5c6f7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan701@gmail.com", "Tan701", "hashed_password_701", null, false, false, "Tran701", null, "user", null, 0 },
                    { new Guid("8aa97352-c895-461b-8959-c0844c6caf3d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan973@gmail.com", "Tan973", "hashed_password_973", null, false, false, "Tran973", null, "user", null, 0 },
                    { new Guid("8ac2fbc2-8bd4-4720-96a5-1cd9a5fa4fe4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan222@gmail.com", "Tan222", "hashed_password_222", null, false, false, "Tran222", null, "user", null, 0 },
                    { new Guid("8b08d02d-d721-472c-9420-bb21b3e2dfe6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan728@gmail.com", "Tan728", "hashed_password_728", null, false, false, "Tran728", null, "user", null, 0 },
                    { new Guid("8b0b632b-51f1-412c-aa24-0026420c63e6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan662@gmail.com", "Tan662", "hashed_password_662", null, false, false, "Tran662", null, "user", null, 0 },
                    { new Guid("8b2688cc-4085-428b-83bf-0056eea01588"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan761@gmail.com", "Tan761", "hashed_password_761", null, false, false, "Tran761", null, "user", null, 0 },
                    { new Guid("8b94f89b-256a-43a0-84a6-e48b3175269c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan203@gmail.com", "Tan203", "hashed_password_203", null, false, false, "Tran203", null, "user", null, 0 },
                    { new Guid("8ba44293-9a2c-4684-8c6e-4ba70e11aac3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan29@gmail.com", "Tan29", "hashed_password_29", null, false, false, "Tran29", null, "user", null, 0 },
                    { new Guid("8ba828a8-d0f3-4a13-8752-cd5596595282"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan729@gmail.com", "Tan729", "hashed_password_729", null, false, false, "Tran729", null, "user", null, 0 },
                    { new Guid("8ba895d4-bc77-4125-bd35-b1f964a95480"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan313@gmail.com", "Tan313", "hashed_password_313", null, false, false, "Tran313", null, "user", null, 0 },
                    { new Guid("8bda5ce1-5cef-498d-8812-9f241afdebff"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan925@gmail.com", "Tan925", "hashed_password_925", null, false, false, "Tran925", null, "user", null, 0 },
                    { new Guid("8cc151be-c1ee-400b-a515-6ed6fde87413"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan211@gmail.com", "Tan211", "hashed_password_211", null, false, false, "Tran211", null, "user", null, 0 },
                    { new Guid("8cc68ad6-1751-4593-a5cb-ad12e9a3a203"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan167@gmail.com", "Tan167", "hashed_password_167", null, false, false, "Tran167", null, "user", null, 0 },
                    { new Guid("8cec31d9-d801-4ff7-822e-2fa891df71a8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan667@gmail.com", "Tan667", "hashed_password_667", null, false, false, "Tran667", null, "user", null, 0 },
                    { new Guid("8d050ec6-eccf-499f-8bfe-144dd1a9cc06"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan804@gmail.com", "Tan804", "hashed_password_804", null, false, false, "Tran804", null, "user", null, 0 },
                    { new Guid("8d2e30a4-52a8-4ed4-961f-9a775ac3bcab"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan66@gmail.com", "Tan66", "hashed_password_66", null, false, false, "Tran66", null, "user", null, 0 },
                    { new Guid("8d328ef5-a409-4eb7-90c3-57c7b04d5208"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan367@gmail.com", "Tan367", "hashed_password_367", null, false, false, "Tran367", null, "user", null, 0 },
                    { new Guid("8d3f4e6c-9cfc-4c84-a2ac-886b7d7578df"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan368@gmail.com", "Tan368", "hashed_password_368", null, false, false, "Tran368", null, "user", null, 0 },
                    { new Guid("8d671c56-d27b-4a05-943d-ad82ee192f0e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan669@gmail.com", "Tan669", "hashed_password_669", null, false, false, "Tran669", null, "user", null, 0 },
                    { new Guid("8db63832-bbe5-4a83-aa88-0bea8b81ead3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan699@gmail.com", "Tan699", "hashed_password_699", null, false, false, "Tran699", null, "user", null, 0 },
                    { new Guid("8de4c7ab-0063-424f-a72d-8a1e988665a9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan225@gmail.com", "Tan225", "hashed_password_225", null, false, false, "Tran225", null, "user", null, 0 },
                    { new Guid("8e028f47-0f26-4bcd-a46f-2b43c6d178d5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan616@gmail.com", "Tan616", "hashed_password_616", null, false, false, "Tran616", null, "user", null, 0 },
                    { new Guid("8e072298-3a8f-4de3-a569-8e400087490a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan42@gmail.com", "Tan42", "hashed_password_42", null, false, false, "Tran42", null, "user", null, 0 },
                    { new Guid("8e65bb50-3c0d-4b1c-bb4a-8a25ab823d82"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan930@gmail.com", "Tan930", "hashed_password_930", null, false, false, "Tran930", null, "user", null, 0 },
                    { new Guid("8ef0b491-99cb-46ee-a82c-445621e1a72c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan705@gmail.com", "Tan705", "hashed_password_705", null, false, false, "Tran705", null, "user", null, 0 },
                    { new Guid("8ef313bf-3409-4f09-b65a-cedf3b7df437"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan480@gmail.com", "Tan480", "hashed_password_480", null, false, false, "Tran480", null, "user", null, 0 },
                    { new Guid("8f29bb8f-6e5f-4241-b19d-8d8b8d3d3d24"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan427@gmail.com", "Tan427", "hashed_password_427", null, false, false, "Tran427", null, "user", null, 0 },
                    { new Guid("8f2a503f-140a-425e-8151-bdb9b7eb23c3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan380@gmail.com", "Tan380", "hashed_password_380", null, false, false, "Tran380", null, "user", null, 0 },
                    { new Guid("8f66ea5a-1298-489c-ae56-26da1c3ef1cb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan389@gmail.com", "Tan389", "hashed_password_389", null, false, false, "Tran389", null, "user", null, 0 },
                    { new Guid("9082a4a4-f899-48f5-9b91-be0e68157ba1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan312@gmail.com", "Tan312", "hashed_password_312", null, false, false, "Tran312", null, "user", null, 0 },
                    { new Guid("9084d095-76f8-43f6-86a2-df23f6a12107"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan530@gmail.com", "Tan530", "hashed_password_530", null, false, false, "Tran530", null, "user", null, 0 },
                    { new Guid("90b460bd-e2dd-4ca5-b8a8-5d2496893da4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan410@gmail.com", "Tan410", "hashed_password_410", null, false, false, "Tran410", null, "user", null, 0 },
                    { new Guid("90b4a88b-ad3e-46b4-8054-1515214122e7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan177@gmail.com", "Tan177", "hashed_password_177", null, false, false, "Tran177", null, "user", null, 0 },
                    { new Guid("90d424fb-670f-413d-8dea-f9c53106a606"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan239@gmail.com", "Tan239", "hashed_password_239", null, false, false, "Tran239", null, "user", null, 0 },
                    { new Guid("90f717fb-0a9d-40db-ac67-bc497b0fe849"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan531@gmail.com", "Tan531", "hashed_password_531", null, false, false, "Tran531", null, "user", null, 0 },
                    { new Guid("9119f50b-97bb-4c1f-83b8-041c5f9b8669"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan236@gmail.com", "Tan236", "hashed_password_236", null, false, false, "Tran236", null, "user", null, 0 },
                    { new Guid("916c870f-5b82-42fb-9ee8-0dc57bdcef1f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan831@gmail.com", "Tan831", "hashed_password_831", null, false, false, "Tran831", null, "user", null, 0 },
                    { new Guid("91929f76-e0d5-4bfb-96b4-7c91ac6b42ec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan407@gmail.com", "Tan407", "hashed_password_407", null, false, false, "Tran407", null, "user", null, 0 },
                    { new Guid("91c70124-7eb2-45c4-989a-05354caf44c1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan631@gmail.com", "Tan631", "hashed_password_631", null, false, false, "Tran631", null, "user", null, 0 },
                    { new Guid("92105e24-b5ce-4b7c-bc6a-c98c303f0e22"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan688@gmail.com", "Tan688", "hashed_password_688", null, false, false, "Tran688", null, "user", null, 0 },
                    { new Guid("925749de-53ad-4fac-bb84-ab12c79d58ca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan449@gmail.com", "Tan449", "hashed_password_449", null, false, false, "Tran449", null, "user", null, 0 },
                    { new Guid("92a4c0a0-19ee-4975-a05a-71af05259aa3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan219@gmail.com", "Tan219", "hashed_password_219", null, false, false, "Tran219", null, "user", null, 0 },
                    { new Guid("931c05fa-2aae-478b-9891-03b43881193d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan686@gmail.com", "Tan686", "hashed_password_686", null, false, false, "Tran686", null, "user", null, 0 },
                    { new Guid("934344f9-ec06-421c-ae40-8a184c8bcc04"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan860@gmail.com", "Tan860", "hashed_password_860", null, false, false, "Tran860", null, "user", null, 0 },
                    { new Guid("935dbeb6-90d0-4f36-8470-c62e830e06d8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan59@gmail.com", "Tan59", "hashed_password_59", null, false, false, "Tran59", null, "user", null, 0 },
                    { new Guid("93b3701a-bf58-494b-afd6-8a1524303dd0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan288@gmail.com", "Tan288", "hashed_password_288", null, false, false, "Tran288", null, "user", null, 0 },
                    { new Guid("93eb3d54-3084-4dca-a6c4-a9d762641836"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan50@gmail.com", "Tan50", "hashed_password_50", null, false, false, "Tran50", null, "user", null, 0 },
                    { new Guid("93f46dd4-da74-4c96-884a-ea6321a27122"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan485@gmail.com", "Tan485", "hashed_password_485", null, false, false, "Tran485", null, "user", null, 0 },
                    { new Guid("94d17628-7a5c-4cef-9405-874a8d2875d4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan956@gmail.com", "Tan956", "hashed_password_956", null, false, false, "Tran956", null, "user", null, 0 },
                    { new Guid("9514293b-2b31-4ee3-9f45-c4b29e90f4d8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan848@gmail.com", "Tan848", "hashed_password_848", null, false, false, "Tran848", null, "user", null, 0 },
                    { new Guid("955144b2-07a0-4961-aff8-e62fb5755c67"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan506@gmail.com", "Tan506", "hashed_password_506", null, false, false, "Tran506", null, "user", null, 0 },
                    { new Guid("95ab58f4-e19d-48c5-aa59-e1e81632a06f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan334@gmail.com", "Tan334", "hashed_password_334", null, false, false, "Tran334", null, "user", null, 0 },
                    { new Guid("95f9de89-9ccc-4bbb-a42f-c14a87b62303"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan83@gmail.com", "Tan83", "hashed_password_83", null, false, false, "Tran83", null, "user", null, 0 },
                    { new Guid("96641721-25d3-4332-9aa1-34a4b3289165"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan613@gmail.com", "Tan613", "hashed_password_613", null, false, false, "Tran613", null, "user", null, 0 },
                    { new Guid("969bffac-e96b-463e-9745-24cf0932ef8c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan958@gmail.com", "Tan958", "hashed_password_958", null, false, false, "Tran958", null, "user", null, 0 },
                    { new Guid("96c445e9-d37d-4daa-a139-999b5b0ef8ff"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan105@gmail.com", "Tan105", "hashed_password_105", null, false, false, "Tran105", null, "user", null, 0 },
                    { new Guid("96dc21c7-90a4-444f-991f-f45a18136ddb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan320@gmail.com", "Tan320", "hashed_password_320", null, false, false, "Tran320", null, "user", null, 0 },
                    { new Guid("96e9b444-2e7b-4480-8a1c-24c1d0e075f6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan69@gmail.com", "Tan69", "hashed_password_69", null, false, false, "Tran69", null, "user", null, 0 },
                    { new Guid("96ec6597-90e2-4135-9a19-2d92f2fbccf9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan998@gmail.com", "Tan998", "hashed_password_998", null, false, false, "Tran998", null, "user", null, 0 },
                    { new Guid("97316d38-eade-4f17-a69a-a643bb886935"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan892@gmail.com", "Tan892", "hashed_password_892", null, false, false, "Tran892", null, "user", null, 0 },
                    { new Guid("976320b9-0757-4343-bcba-332f058e810f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan694@gmail.com", "Tan694", "hashed_password_694", null, false, false, "Tran694", null, "user", null, 0 },
                    { new Guid("97a7c913-c64e-46e9-a10a-8d4667e629ac"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan827@gmail.com", "Tan827", "hashed_password_827", null, false, false, "Tran827", null, "user", null, 0 },
                    { new Guid("9876339c-6372-4e4b-af64-eb6bd2076609"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan933@gmail.com", "Tan933", "hashed_password_933", null, false, false, "Tran933", null, "user", null, 0 },
                    { new Guid("99bbc198-f17c-4715-acef-47fa466739eb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan330@gmail.com", "Tan330", "hashed_password_330", null, false, false, "Tran330", null, "user", null, 0 },
                    { new Guid("99dd641e-8034-4bc7-920d-191349f8b3a9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan912@gmail.com", "Tan912", "hashed_password_912", null, false, false, "Tran912", null, "user", null, 0 },
                    { new Guid("9a788b0a-952e-4b49-b4b0-d9415bd3015d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan388@gmail.com", "Tan388", "hashed_password_388", null, false, false, "Tran388", null, "user", null, 0 },
                    { new Guid("9aabf99c-d2ad-4058-82f4-b61febbb6583"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan277@gmail.com", "Tan277", "hashed_password_277", null, false, false, "Tran277", null, "user", null, 0 },
                    { new Guid("9aea0157-2ad3-43f8-920f-9bcb73c5c6bb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan496@gmail.com", "Tan496", "hashed_password_496", null, false, false, "Tran496", null, "user", null, 0 },
                    { new Guid("9b008029-b5dd-4d7d-ab15-6878f1009028"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan981@gmail.com", "Tan981", "hashed_password_981", null, false, false, "Tran981", null, "user", null, 0 },
                    { new Guid("9b3a2458-708f-4eaa-892e-57cef97b068b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan910@gmail.com", "Tan910", "hashed_password_910", null, false, false, "Tran910", null, "user", null, 0 },
                    { new Guid("9b9692f4-149c-45d4-8212-f97e19beeeac"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan224@gmail.com", "Tan224", "hashed_password_224", null, false, false, "Tran224", null, "user", null, 0 },
                    { new Guid("9c840168-0969-4030-9f78-158431e39c42"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan574@gmail.com", "Tan574", "hashed_password_574", null, false, false, "Tran574", null, "user", null, 0 },
                    { new Guid("9cbf4c9c-989c-4206-bb36-4a2f4c85dabf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan894@gmail.com", "Tan894", "hashed_password_894", null, false, false, "Tran894", null, "user", null, 0 },
                    { new Guid("9d010156-4912-4c9f-9ecd-e0112bcab5b5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan409@gmail.com", "Tan409", "hashed_password_409", null, false, false, "Tran409", null, "user", null, 0 },
                    { new Guid("9d2df44c-500c-4a63-b4be-7377b2815c64"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan301@gmail.com", "Tan301", "hashed_password_301", null, false, false, "Tran301", null, "user", null, 0 },
                    { new Guid("9d649d49-86e0-4180-9cf6-b885800f3a5a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan654@gmail.com", "Tan654", "hashed_password_654", null, false, false, "Tran654", null, "user", null, 0 },
                    { new Guid("9d9190c4-0d54-4f76-ae63-ecb36f3e5ddf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan436@gmail.com", "Tan436", "hashed_password_436", null, false, false, "Tran436", null, "user", null, 0 },
                    { new Guid("9da0ffec-d5e8-4b5b-8dd3-1d8f4d39cdef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan576@gmail.com", "Tan576", "hashed_password_576", null, false, false, "Tran576", null, "user", null, 0 },
                    { new Guid("9dbd1751-4651-4bc8-80b6-175db87724bf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan372@gmail.com", "Tan372", "hashed_password_372", null, false, false, "Tran372", null, "user", null, 0 },
                    { new Guid("9e65db84-49d1-4bbf-9cf8-1e906c80e601"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan10@gmail.com", "Tan10", "hashed_password_10", null, false, false, "Tran10", null, "user", null, 0 },
                    { new Guid("9e75369a-42c6-4fc2-a529-f47fc8c4f70a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan927@gmail.com", "Tan927", "hashed_password_927", null, false, false, "Tran927", null, "user", null, 0 },
                    { new Guid("9e7cf7f5-2154-4113-8312-52cea13cb6c7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan672@gmail.com", "Tan672", "hashed_password_672", null, false, false, "Tran672", null, "user", null, 0 },
                    { new Guid("9f019204-2dc7-4c79-ae56-86821eb56465"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan952@gmail.com", "Tan952", "hashed_password_952", null, false, false, "Tran952", null, "user", null, 0 },
                    { new Guid("9fdb57d1-927e-4754-a88f-52312ab72d8f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan960@gmail.com", "Tan960", "hashed_password_960", null, false, false, "Tran960", null, "user", null, 0 },
                    { new Guid("9fe052f9-b8d2-4ee3-9cde-4b9f4d5727ec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan935@gmail.com", "Tan935", "hashed_password_935", null, false, false, "Tran935", null, "user", null, 0 },
                    { new Guid("9feb46e7-535d-42f8-a0ed-6875b6597e58"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan643@gmail.com", "Tan643", "hashed_password_643", null, false, false, "Tran643", null, "user", null, 0 },
                    { new Guid("a020416c-c81d-48f4-8b38-a4ddb0c9e587"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan271@gmail.com", "Tan271", "hashed_password_271", null, false, false, "Tran271", null, "user", null, 0 },
                    { new Guid("a025a3f3-ace4-40aa-a99b-82ac7c6438ba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan107@gmail.com", "Tan107", "hashed_password_107", null, false, false, "Tran107", null, "user", null, 0 },
                    { new Guid("a02b18e9-b850-4b51-9385-f716fccb70dc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan997@gmail.com", "Tan997", "hashed_password_997", null, false, false, "Tran997", null, "user", null, 0 },
                    { new Guid("a07668d3-3722-4064-b3c3-763c1022aa8d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan127@gmail.com", "Tan127", "hashed_password_127", null, false, false, "Tran127", null, "user", null, 0 },
                    { new Guid("a0c78717-2188-4313-922c-449d38a159b2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan756@gmail.com", "Tan756", "hashed_password_756", null, false, false, "Tran756", null, "user", null, 0 },
                    { new Guid("a0da7c4d-088b-4332-b527-f8d26b9ec91f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan534@gmail.com", "Tan534", "hashed_password_534", null, false, false, "Tran534", null, "user", null, 0 },
                    { new Guid("a0de5f2d-0257-40c3-9257-a4eae88c4840"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan549@gmail.com", "Tan549", "hashed_password_549", null, false, false, "Tran549", null, "user", null, 0 },
                    { new Guid("a1bad7e1-2399-498e-99db-85a6417a1996"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan208@gmail.com", "Tan208", "hashed_password_208", null, false, false, "Tran208", null, "user", null, 0 },
                    { new Guid("a1d078ec-185a-428b-ab29-16ba23663990"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan644@gmail.com", "Tan644", "hashed_password_644", null, false, false, "Tran644", null, "user", null, 0 },
                    { new Guid("a23714d0-7e3e-41e7-82ce-bc886ccfe5b5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan353@gmail.com", "Tan353", "hashed_password_353", null, false, false, "Tran353", null, "user", null, 0 },
                    { new Guid("a298fb4b-9fdf-49c9-8110-dbacc3af22e0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan826@gmail.com", "Tan826", "hashed_password_826", null, false, false, "Tran826", null, "user", null, 0 },
                    { new Guid("a30f2a51-64f4-4168-901a-31e85587eb6c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan760@gmail.com", "Tan760", "hashed_password_760", null, false, false, "Tran760", null, "user", null, 0 },
                    { new Guid("a326f55a-f3b4-448b-bc3d-527b6761a27d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan657@gmail.com", "Tan657", "hashed_password_657", null, false, false, "Tran657", null, "user", null, 0 },
                    { new Guid("a345a6c7-ee11-4b69-bc3c-d39a92fc9503"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan515@gmail.com", "Tan515", "hashed_password_515", null, false, false, "Tran515", null, "user", null, 0 },
                    { new Guid("a35a8ac2-9c7e-4f5e-a7f4-55d8b67f275a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan68@gmail.com", "Tan68", "hashed_password_68", null, false, false, "Tran68", null, "user", null, 0 },
                    { new Guid("a3726b2e-7fe2-4210-8064-214bd88f571c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan931@gmail.com", "Tan931", "hashed_password_931", null, false, false, "Tran931", null, "user", null, 0 },
                    { new Guid("a3a17f53-eb71-4758-a515-25ba2da63ea6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan379@gmail.com", "Tan379", "hashed_password_379", null, false, false, "Tran379", null, "user", null, 0 },
                    { new Guid("a3d8e3e8-fb34-46a3-a166-f2845ddb9fea"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan109@gmail.com", "Tan109", "hashed_password_109", null, false, false, "Tran109", null, "user", null, 0 },
                    { new Guid("a3f38289-9f3b-418f-bc1a-0206d3271260"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan685@gmail.com", "Tan685", "hashed_password_685", null, false, false, "Tran685", null, "user", null, 0 },
                    { new Guid("a42e4c12-b500-4335-b5ec-9b35b3bda310"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan464@gmail.com", "Tan464", "hashed_password_464", null, false, false, "Tran464", null, "user", null, 0 },
                    { new Guid("a4639a56-1490-46dc-9836-6a481c7e3b0d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan324@gmail.com", "Tan324", "hashed_password_324", null, false, false, "Tran324", null, "user", null, 0 },
                    { new Guid("a4777922-154d-4c73-9627-7424e0a18af7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan759@gmail.com", "Tan759", "hashed_password_759", null, false, false, "Tran759", null, "user", null, 0 },
                    { new Guid("a4ea9c29-b5a7-402b-8a7b-8ac7d9199a18"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan276@gmail.com", "Tan276", "hashed_password_276", null, false, false, "Tran276", null, "user", null, 0 },
                    { new Guid("a50ab9a9-8068-4f37-8124-f19f5a74f654"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan370@gmail.com", "Tan370", "hashed_password_370", null, false, false, "Tran370", null, "user", null, 0 },
                    { new Guid("a5377460-4b28-4db1-9fb0-391469b4e952"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan888@gmail.com", "Tan888", "hashed_password_888", null, false, false, "Tran888", null, "user", null, 0 },
                    { new Guid("a560e6d3-d6d2-4a5b-a117-f16b5cbd1596"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan108@gmail.com", "Tan108", "hashed_password_108", null, false, false, "Tran108", null, "user", null, 0 },
                    { new Guid("a5772980-b1c0-44d4-8a82-00dcf4e43f6c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan365@gmail.com", "Tan365", "hashed_password_365", null, false, false, "Tran365", null, "user", null, 0 },
                    { new Guid("a5af06f8-dcac-45f6-906a-9ea8e6c6d562"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan347@gmail.com", "Tan347", "hashed_password_347", null, false, false, "Tran347", null, "user", null, 0 },
                    { new Guid("a5d2203e-085e-4bf4-855a-8f434993633b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan258@gmail.com", "Tan258", "hashed_password_258", null, false, false, "Tran258", null, "user", null, 0 },
                    { new Guid("a62c74a7-5cbd-4c02-a809-d46b62f01180"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan326@gmail.com", "Tan326", "hashed_password_326", null, false, false, "Tran326", null, "user", null, 0 },
                    { new Guid("a6f78a34-1792-4a44-a2f7-ffa317d67813"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan413@gmail.com", "Tan413", "hashed_password_413", null, false, false, "Tran413", null, "user", null, 0 },
                    { new Guid("a709c9ec-2163-418b-a80e-55e14164c2fe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan176@gmail.com", "Tan176", "hashed_password_176", null, false, false, "Tran176", null, "user", null, 0 },
                    { new Guid("a71d5e3a-9458-44d0-a154-768929fa6615"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan690@gmail.com", "Tan690", "hashed_password_690", null, false, false, "Tran690", null, "user", null, 0 },
                    { new Guid("a76c8cb8-2e24-41cb-8693-bb8b990a949d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan217@gmail.com", "Tan217", "hashed_password_217", null, false, false, "Tran217", null, "user", null, 0 },
                    { new Guid("a79dd0cf-2abd-4d5c-94b2-9b47fb29fed9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan923@gmail.com", "Tan923", "hashed_password_923", null, false, false, "Tran923", null, "user", null, 0 },
                    { new Guid("a7e0f7e1-d083-4059-a962-9b2d86acaf66"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan630@gmail.com", "Tan630", "hashed_password_630", null, false, false, "Tran630", null, "user", null, 0 },
                    { new Guid("a7ee1bae-8d7a-4f55-906e-4e5cff36a325"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan359@gmail.com", "Tan359", "hashed_password_359", null, false, false, "Tran359", null, "user", null, 0 },
                    { new Guid("a82700b0-0522-466c-83b7-f87b28c2dd09"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan749@gmail.com", "Tan749", "hashed_password_749", null, false, false, "Tran749", null, "user", null, 0 },
                    { new Guid("a859ca05-d18a-4edf-afbb-545609d2d6f3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan764@gmail.com", "Tan764", "hashed_password_764", null, false, false, "Tran764", null, "user", null, 0 },
                    { new Guid("a8792a7a-f541-4adb-84f2-00808767fd6b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan635@gmail.com", "Tan635", "hashed_password_635", null, false, false, "Tran635", null, "user", null, 0 },
                    { new Guid("a8dbcd74-373e-4156-a83c-2401c1ec3ebe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan232@gmail.com", "Tan232", "hashed_password_232", null, false, false, "Tran232", null, "user", null, 0 },
                    { new Guid("a9174bb1-4ddc-4cbe-afc6-d5c93579ab8b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan151@gmail.com", "Tan151", "hashed_password_151", null, false, false, "Tran151", null, "user", null, 0 },
                    { new Guid("a95f938a-3682-44cd-a83d-22928eaeb8b0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan500@gmail.com", "Tan500", "hashed_password_500", null, false, false, "Tran500", null, "user", null, 0 },
                    { new Guid("a97e9641-e776-4f4b-95bf-784f50b32a7c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan902@gmail.com", "Tan902", "hashed_password_902", null, false, false, "Tran902", null, "user", null, 0 },
                    { new Guid("a97fc1b1-3d6f-4e0e-98f2-e21106b90048"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan129@gmail.com", "Tan129", "hashed_password_129", null, false, false, "Tran129", null, "user", null, 0 },
                    { new Guid("a98fd70a-b2b2-4a96-a39e-bc0161d33bd9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan579@gmail.com", "Tan579", "hashed_password_579", null, false, false, "Tran579", null, "user", null, 0 },
                    { new Guid("a9d287b3-6fde-4d44-b050-6173405b99b1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan714@gmail.com", "Tan714", "hashed_password_714", null, false, false, "Tran714", null, "user", null, 0 },
                    { new Guid("aa1d7c12-2980-48eb-a46a-ade26c77c375"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan405@gmail.com", "Tan405", "hashed_password_405", null, false, false, "Tran405", null, "user", null, 0 },
                    { new Guid("aa6857a4-f102-4dc0-a536-b06ee0119978"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan40@gmail.com", "Tan40", "hashed_password_40", null, false, false, "Tran40", null, "user", null, 0 },
                    { new Guid("aa8f9a03-f791-42b9-adf4-76e2cf2acb86"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan659@gmail.com", "Tan659", "hashed_password_659", null, false, false, "Tran659", null, "user", null, 0 },
                    { new Guid("aacc8688-276d-4a95-9cdc-8c6354a2318e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan93@gmail.com", "Tan93", "hashed_password_93", null, false, false, "Tran93", null, "user", null, 0 },
                    { new Guid("aadab96d-4605-4cdc-828d-3e2aaad73b80"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan533@gmail.com", "Tan533", "hashed_password_533", null, false, false, "Tran533", null, "user", null, 0 },
                    { new Guid("ab0a1cc3-b36a-4f42-9610-bc402f251ef6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan833@gmail.com", "Tan833", "hashed_password_833", null, false, false, "Tran833", null, "user", null, 0 },
                    { new Guid("ab46176c-30a0-4003-98c9-3f92e41dcf5f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan116@gmail.com", "Tan116", "hashed_password_116", null, false, false, "Tran116", null, "user", null, 0 },
                    { new Guid("ab5d7be3-b7f0-4c02-90a9-18e9060e25b7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan639@gmail.com", "Tan639", "hashed_password_639", null, false, false, "Tran639", null, "user", null, 0 },
                    { new Guid("ab6f8921-6f37-4d89-aaa5-9e540f226484"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan564@gmail.com", "Tan564", "hashed_password_564", null, false, false, "Tran564", null, "user", null, 0 },
                    { new Guid("abced968-c783-442d-9cd1-9f330a51c899"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan89@gmail.com", "Tan89", "hashed_password_89", null, false, false, "Tran89", null, "user", null, 0 },
                    { new Guid("abd3cad0-33f5-42b9-91d8-289b3259cde9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan43@gmail.com", "Tan43", "hashed_password_43", null, false, false, "Tran43", null, "user", null, 0 },
                    { new Guid("abe8c4c1-5f7d-4c54-a405-39c8d2d1a84c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan71@gmail.com", "Tan71", "hashed_password_71", null, false, false, "Tran71", null, "user", null, 0 },
                    { new Guid("ac1ffa9c-d1bc-4198-89e5-70d544ca25fc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan712@gmail.com", "Tan712", "hashed_password_712", null, false, false, "Tran712", null, "user", null, 0 },
                    { new Guid("ad534242-ff4c-4fe7-9a85-9836637c3015"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan308@gmail.com", "Tan308", "hashed_password_308", null, false, false, "Tran308", null, "user", null, 0 },
                    { new Guid("ad66a311-06ac-4065-b385-db0dba2ad285"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan807@gmail.com", "Tan807", "hashed_password_807", null, false, false, "Tran807", null, "user", null, 0 },
                    { new Guid("ad9356b5-de5b-4aa1-bf9a-1e669462ea76"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan791@gmail.com", "Tan791", "hashed_password_791", null, false, false, "Tran791", null, "user", null, 0 },
                    { new Guid("ae11f780-ffec-4a2e-a83c-ddecbc61467e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan680@gmail.com", "Tan680", "hashed_password_680", null, false, false, "Tran680", null, "user", null, 0 },
                    { new Guid("ae3998ca-6dec-4e6e-8a06-0f0125e9044a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan547@gmail.com", "Tan547", "hashed_password_547", null, false, false, "Tran547", null, "user", null, 0 },
                    { new Guid("ae5260db-3ed1-4758-b32f-2a6f526045a5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan319@gmail.com", "Tan319", "hashed_password_319", null, false, false, "Tran319", null, "user", null, 0 },
                    { new Guid("ae97053d-6405-4075-b1e3-c638b417a432"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan307@gmail.com", "Tan307", "hashed_password_307", null, false, false, "Tran307", null, "user", null, 0 },
                    { new Guid("afa1cfb4-f737-4c0a-b25d-dcdd7b86f3dd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan257@gmail.com", "Tan257", "hashed_password_257", null, false, false, "Tran257", null, "user", null, 0 },
                    { new Guid("b039c85c-41c6-4285-9361-1077d36c7a69"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan284@gmail.com", "Tan284", "hashed_password_284", null, false, false, "Tran284", null, "user", null, 0 },
                    { new Guid("b0dec926-e450-4a09-9483-95b54c99e7e2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan124@gmail.com", "Tan124", "hashed_password_124", null, false, false, "Tran124", null, "user", null, 0 },
                    { new Guid("b1a33237-e5ba-4c75-b4f1-75a1d0abf57a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan652@gmail.com", "Tan652", "hashed_password_652", null, false, false, "Tran652", null, "user", null, 0 },
                    { new Guid("b1e1e10b-7338-41f9-8fda-cc5d87a6973f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan575@gmail.com", "Tan575", "hashed_password_575", null, false, false, "Tran575", null, "user", null, 0 },
                    { new Guid("b233a335-ba80-4edd-af25-330fc673f436"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan75@gmail.com", "Tan75", "hashed_password_75", null, false, false, "Tran75", null, "user", null, 0 },
                    { new Guid("b306d986-4e95-4304-a635-8b1e3805e0d8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan399@gmail.com", "Tan399", "hashed_password_399", null, false, false, "Tran399", null, "user", null, 0 },
                    { new Guid("b3856be0-4da4-44d7-aab1-b56fae5cb354"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan929@gmail.com", "Tan929", "hashed_password_929", null, false, false, "Tran929", null, "user", null, 0 },
                    { new Guid("b3c72b73-9a71-414a-ae4c-4d48555d2f1d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan502@gmail.com", "Tan502", "hashed_password_502", null, false, false, "Tran502", null, "user", null, 0 },
                    { new Guid("b3cd273b-8692-44b9-88ca-4f701f934152"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan13@gmail.com", "Tan13", "hashed_password_13", null, false, false, "Tran13", null, "user", null, 0 },
                    { new Guid("b3cd93d7-50a8-477c-9758-58c3f9b5d36d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan895@gmail.com", "Tan895", "hashed_password_895", null, false, false, "Tran895", null, "user", null, 0 },
                    { new Guid("b496bac4-8c8c-404d-a6bf-96de0e3c0e39"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan922@gmail.com", "Tan922", "hashed_password_922", null, false, false, "Tran922", null, "user", null, 0 },
                    { new Guid("b4ef5989-fe54-4ab4-b49f-7a53e48ada08"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan60@gmail.com", "Tan60", "hashed_password_60", null, false, false, "Tran60", null, "user", null, 0 },
                    { new Guid("b536e655-d13c-4a6e-8a34-e1a53982ef31"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan369@gmail.com", "Tan369", "hashed_password_369", null, false, false, "Tran369", null, "user", null, 0 },
                    { new Guid("b551065c-b0da-460e-b0d0-688a6a67abac"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan982@gmail.com", "Tan982", "hashed_password_982", null, false, false, "Tran982", null, "user", null, 0 },
                    { new Guid("b56a7967-db0f-4cfc-b216-31ce5a6e3246"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan623@gmail.com", "Tan623", "hashed_password_623", null, false, false, "Tran623", null, "user", null, 0 },
                    { new Guid("b5ae652a-e5fa-4482-991a-d897f4a0fbff"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan423@gmail.com", "Tan423", "hashed_password_423", null, false, false, "Tran423", null, "user", null, 0 },
                    { new Guid("b5ced080-27d7-438c-ae52-bbda56d2beae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan795@gmail.com", "Tan795", "hashed_password_795", null, false, false, "Tran795", null, "user", null, 0 },
                    { new Guid("b5de4f3b-ac29-4896-8a83-27d33ef895f8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan942@gmail.com", "Tan942", "hashed_password_942", null, false, false, "Tran942", null, "user", null, 0 },
                    { new Guid("b5ebed64-ff2c-45bc-b803-0e11282994ca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan512@gmail.com", "Tan512", "hashed_password_512", null, false, false, "Tran512", null, "user", null, 0 },
                    { new Guid("b610d3a5-337d-4cff-9944-86df0f40bf5a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan976@gmail.com", "Tan976", "hashed_password_976", null, false, false, "Tran976", null, "user", null, 0 },
                    { new Guid("b64ff4a2-cc0f-4680-9cae-d82ff2936529"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan469@gmail.com", "Tan469", "hashed_password_469", null, false, false, "Tran469", null, "user", null, 0 },
                    { new Guid("b6599015-61f5-4d83-a4d3-186d3fe9dca8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan788@gmail.com", "Tan788", "hashed_password_788", null, false, false, "Tran788", null, "user", null, 0 },
                    { new Guid("b670ef1e-57f6-4154-b7b6-a91d207e0d9f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan128@gmail.com", "Tan128", "hashed_password_128", null, false, false, "Tran128", null, "user", null, 0 },
                    { new Guid("b673d781-8aa3-4ecc-b107-373bb80cea7f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan142@gmail.com", "Tan142", "hashed_password_142", null, false, false, "Tran142", null, "user", null, 0 },
                    { new Guid("b67f04c9-78d0-4a19-82e9-9b49317dfabc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan473@gmail.com", "Tan473", "hashed_password_473", null, false, false, "Tran473", null, "user", null, 0 },
                    { new Guid("b7411944-b32e-45c9-aa3e-0b397f12e70c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan46@gmail.com", "Tan46", "hashed_password_46", null, false, false, "Tran46", null, "user", null, 0 },
                    { new Guid("b74adc47-68b6-40d7-adb8-3b1812d653e8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan172@gmail.com", "Tan172", "hashed_password_172", null, false, false, "Tran172", null, "user", null, 0 },
                    { new Guid("b76cef8e-14a1-40b8-9ee1-44bfef6a14f2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan400@gmail.com", "Tan400", "hashed_password_400", null, false, false, "Tran400", null, "user", null, 0 },
                    { new Guid("b7a6ca4a-3861-4b74-a30c-5b282264d560"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan637@gmail.com", "Tan637", "hashed_password_637", null, false, false, "Tran637", null, "user", null, 0 },
                    { new Guid("b7c21162-6504-4848-818f-cb55f2f8f181"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan216@gmail.com", "Tan216", "hashed_password_216", null, false, false, "Tran216", null, "user", null, 0 },
                    { new Guid("b8205edb-509f-4439-8147-6694d0230593"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan357@gmail.com", "Tan357", "hashed_password_357", null, false, false, "Tran357", null, "user", null, 0 },
                    { new Guid("b9147c84-7638-465b-97f9-39b2d3e2d4f0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan249@gmail.com", "Tan249", "hashed_password_249", null, false, false, "Tran249", null, "user", null, 0 },
                    { new Guid("b9220087-4d20-4286-89fa-700eb39867da"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan428@gmail.com", "Tan428", "hashed_password_428", null, false, false, "Tran428", null, "user", null, 0 },
                    { new Guid("b93dce61-969c-458d-8176-323c640b7d78"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan490@gmail.com", "Tan490", "hashed_password_490", null, false, false, "Tran490", null, "user", null, 0 },
                    { new Guid("b9535c84-48d2-49b2-b37b-5df8074a418a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan773@gmail.com", "Tan773", "hashed_password_773", null, false, false, "Tran773", null, "user", null, 0 },
                    { new Guid("b978ca9e-4ae5-49ff-a949-f840d941297f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan430@gmail.com", "Tan430", "hashed_password_430", null, false, false, "Tran430", null, "user", null, 0 },
                    { new Guid("b9b203dc-1b77-44ed-bb90-c117b4c941b2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan504@gmail.com", "Tan504", "hashed_password_504", null, false, false, "Tran504", null, "user", null, 0 },
                    { new Guid("b9c72d57-6144-41d3-8180-7171dc93bf30"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan186@gmail.com", "Tan186", "hashed_password_186", null, false, false, "Tran186", null, "user", null, 0 },
                    { new Guid("b9f25ca3-97af-4231-b3e0-361fda5735bb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan299@gmail.com", "Tan299", "hashed_password_299", null, false, false, "Tran299", null, "user", null, 0 },
                    { new Guid("ba4553b6-331a-4ee3-a0bc-cc163f379f96"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan475@gmail.com", "Tan475", "hashed_password_475", null, false, false, "Tran475", null, "user", null, 0 },
                    { new Guid("ba785ba2-4d92-40cf-81ae-9096ce0a6e20"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan471@gmail.com", "Tan471", "hashed_password_471", null, false, false, "Tran471", null, "user", null, 0 },
                    { new Guid("bb5589f3-13a0-4bce-baca-5a189c05ec4c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan904@gmail.com", "Tan904", "hashed_password_904", null, false, false, "Tran904", null, "user", null, 0 },
                    { new Guid("bbaf84a3-b27f-47f3-9bf9-3f0d86581cf5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan684@gmail.com", "Tan684", "hashed_password_684", null, false, false, "Tran684", null, "user", null, 0 },
                    { new Guid("bbf00c7a-2ff7-4ee9-a7ec-6327824b7baf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan104@gmail.com", "Tan104", "hashed_password_104", null, false, false, "Tran104", null, "user", null, 0 },
                    { new Guid("bc06da38-4e0a-459e-b09f-2689d8405f6a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan555@gmail.com", "Tan555", "hashed_password_555", null, false, false, "Tran555", null, "user", null, 0 },
                    { new Guid("bcb770e4-a68e-43c9-8f62-32679513afb4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan545@gmail.com", "Tan545", "hashed_password_545", null, false, false, "Tran545", null, "user", null, 0 },
                    { new Guid("bccc5859-87a6-4391-9dc4-b5785d11f645"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan819@gmail.com", "Tan819", "hashed_password_819", null, false, false, "Tran819", null, "user", null, 0 },
                    { new Guid("bcdbbfa4-4157-432c-8b8d-a2dc8f2c569d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan908@gmail.com", "Tan908", "hashed_password_908", null, false, false, "Tran908", null, "user", null, 0 },
                    { new Guid("bd5105ee-25e9-4628-a279-4c86690c659f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan817@gmail.com", "Tan817", "hashed_password_817", null, false, false, "Tran817", null, "user", null, 0 },
                    { new Guid("bd8229aa-aac1-4fce-b3d3-4cad3cc955fb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan967@gmail.com", "Tan967", "hashed_password_967", null, false, false, "Tran967", null, "user", null, 0 },
                    { new Guid("bda45075-7c91-4024-aee0-877d6368616d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan417@gmail.com", "Tan417", "hashed_password_417", null, false, false, "Tran417", null, "user", null, 0 },
                    { new Guid("be52fe89-fb23-43aa-91c9-404ab0d05e8d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan980@gmail.com", "Tan980", "hashed_password_980", null, false, false, "Tran980", null, "user", null, 0 },
                    { new Guid("bec3b13f-d8b2-4de5-b4ca-cd0d2f2176d0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan268@gmail.com", "Tan268", "hashed_password_268", null, false, false, "Tran268", null, "user", null, 0 },
                    { new Guid("bf98c978-a97f-4118-aa73-86f23f48f0e9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan234@gmail.com", "Tan234", "hashed_password_234", null, false, false, "Tran234", null, "user", null, 0 },
                    { new Guid("bfd9ddd3-fe19-4fbd-8a61-27afa8d4019a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan262@gmail.com", "Tan262", "hashed_password_262", null, false, false, "Tran262", null, "user", null, 0 },
                    { new Guid("bfed9b0b-60a3-4de7-83e3-a05f6bd43258"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan392@gmail.com", "Tan392", "hashed_password_392", null, false, false, "Tran392", null, "user", null, 0 },
                    { new Guid("c04ce751-d3e1-4339-a97c-e68931a44d98"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan164@gmail.com", "Tan164", "hashed_password_164", null, false, false, "Tran164", null, "user", null, 0 },
                    { new Guid("c06cb117-6535-41ce-817a-0100e7d820c6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan348@gmail.com", "Tan348", "hashed_password_348", null, false, false, "Tran348", null, "user", null, 0 },
                    { new Guid("c0d5eec8-57ff-4270-879f-3878cb0d7cc3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan917@gmail.com", "Tan917", "hashed_password_917", null, false, false, "Tran917", null, "user", null, 0 },
                    { new Guid("c0df39b5-ea30-4769-bf4b-d6fd32095846"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan67@gmail.com", "Tan67", "hashed_password_67", null, false, false, "Tran67", null, "user", null, 0 },
                    { new Guid("c0eb53c8-fa33-4b6a-820c-3a07d6485e16"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan54@gmail.com", "Tan54", "hashed_password_54", null, false, false, "Tran54", null, "user", null, 0 },
                    { new Guid("c11c3f5b-137b-4e5b-9744-eecb85613452"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan53@gmail.com", "Tan53", "hashed_password_53", null, false, false, "Tran53", null, "user", null, 0 },
                    { new Guid("c175e2a0-2447-4081-872a-75cbe7a25183"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan48@gmail.com", "Tan48", "hashed_password_48", null, false, false, "Tran48", null, "user", null, 0 },
                    { new Guid("c1efab46-4b18-4711-b0bd-f28e93470229"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan212@gmail.com", "Tan212", "hashed_password_212", null, false, false, "Tran212", null, "user", null, 0 },
                    { new Guid("c1fde2b3-db65-4c23-be07-27e7f1975482"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan789@gmail.com", "Tan789", "hashed_password_789", null, false, false, "Tran789", null, "user", null, 0 },
                    { new Guid("c22b18f6-6896-4b6b-aa72-3c90dbee54dd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan466@gmail.com", "Tan466", "hashed_password_466", null, false, false, "Tran466", null, "user", null, 0 },
                    { new Guid("c24d11d6-f42e-48cb-965b-79c293121e5e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan582@gmail.com", "Tan582", "hashed_password_582", null, false, false, "Tran582", null, "user", null, 0 },
                    { new Guid("c2657893-39f0-47e0-a189-4e273f0a2d82"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan256@gmail.com", "Tan256", "hashed_password_256", null, false, false, "Tran256", null, "user", null, 0 },
                    { new Guid("c29a4ed0-409c-42e8-8284-00c3396893a5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan264@gmail.com", "Tan264", "hashed_password_264", null, false, false, "Tran264", null, "user", null, 0 },
                    { new Guid("c2a9c327-70ec-4ed8-9691-be82a9078963"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan158@gmail.com", "Tan158", "hashed_password_158", null, false, false, "Tran158", null, "user", null, 0 },
                    { new Guid("c2bfd288-a1a1-40d5-8afd-18adbf32dfb7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan157@gmail.com", "Tan157", "hashed_password_157", null, false, false, "Tran157", null, "user", null, 0 },
                    { new Guid("c3113cf1-f8f0-4363-87f7-3941171ea2d3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan429@gmail.com", "Tan429", "hashed_password_429", null, false, false, "Tran429", null, "user", null, 0 },
                    { new Guid("c39b72c3-bfa7-4257-b565-ac69c0a5e79b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan21@gmail.com", "Tan21", "hashed_password_21", null, false, false, "Tran21", null, "user", null, 0 },
                    { new Guid("c3aa78df-eb43-479c-9f65-693390f2a14d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan456@gmail.com", "Tan456", "hashed_password_456", null, false, false, "Tran456", null, "user", null, 0 },
                    { new Guid("c3c3ea63-58ad-4c2b-8792-38da04535f6a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan121@gmail.com", "Tan121", "hashed_password_121", null, false, false, "Tran121", null, "user", null, 0 },
                    { new Guid("c41d5b04-ab9a-43a2-b1a0-b07c88a4f422"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan645@gmail.com", "Tan645", "hashed_password_645", null, false, false, "Tran645", null, "user", null, 0 },
                    { new Guid("c4e89586-6a68-408b-826d-5684b62bf1f3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan811@gmail.com", "Tan811", "hashed_password_811", null, false, false, "Tran811", null, "user", null, 0 },
                    { new Guid("c54b2162-cca4-41cb-a4a6-db873bd36f6c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan492@gmail.com", "Tan492", "hashed_password_492", null, false, false, "Tran492", null, "user", null, 0 },
                    { new Guid("c56528cc-fc93-4265-9d07-2afdecd34f8e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan806@gmail.com", "Tan806", "hashed_password_806", null, false, false, "Tran806", null, "user", null, 0 },
                    { new Guid("c5663f22-57ef-47f8-907c-334f8f4c388c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan752@gmail.com", "Tan752", "hashed_password_752", null, false, false, "Tran752", null, "user", null, 0 },
                    { new Guid("c572f2ce-087d-4643-a298-2dfaba468601"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan780@gmail.com", "Tan780", "hashed_password_780", null, false, false, "Tran780", null, "user", null, 0 },
                    { new Guid("c582aa56-a8a4-48ac-b32a-4ee60b04dca3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan995@gmail.com", "Tan995", "hashed_password_995", null, false, false, "Tran995", null, "user", null, 0 },
                    { new Guid("c597c551-63ae-4c63-9178-2a923caa62ea"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan989@gmail.com", "Tan989", "hashed_password_989", null, false, false, "Tran989", null, "user", null, 0 },
                    { new Guid("c6992225-67b8-4b2a-b531-fda17b224ff8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan493@gmail.com", "Tan493", "hashed_password_493", null, false, false, "Tran493", null, "user", null, 0 },
                    { new Guid("c72cff20-e9cd-4b6f-a63b-62e8aa41145f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan605@gmail.com", "Tan605", "hashed_password_605", null, false, false, "Tran605", null, "user", null, 0 },
                    { new Guid("c74bcad9-902f-41a0-a882-0eb15345a120"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan267@gmail.com", "Tan267", "hashed_password_267", null, false, false, "Tran267", null, "user", null, 0 },
                    { new Guid("c7c72e0f-41fa-4699-804c-d090211858e4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan437@gmail.com", "Tan437", "hashed_password_437", null, false, false, "Tran437", null, "user", null, 0 },
                    { new Guid("c819a963-b96d-4bc9-a1be-32e1b036183a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "tan182205@gmail.com", "Tan", "hashed_password_1", null, false, false, "Tran", null, "user", null, 0 },
                    { new Guid("c8472d66-af51-40ea-a790-4729aadb3689"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan737@gmail.com", "Tan737", "hashed_password_737", null, false, false, "Tran737", null, "user", null, 0 },
                    { new Guid("c8a448ae-f492-4da1-8328-2f8b27c5aa20"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan133@gmail.com", "Tan133", "hashed_password_133", null, false, false, "Tran133", null, "user", null, 0 },
                    { new Guid("c8beaeb3-d240-40c7-803b-4a6014091f58"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan16@gmail.com", "Tan16", "hashed_password_16", null, false, false, "Tran16", null, "user", null, 0 },
                    { new Guid("c9b50c66-f362-4127-9d6f-3ef8ea4d12d9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan516@gmail.com", "Tan516", "hashed_password_516", null, false, false, "Tran516", null, "user", null, 0 },
                    { new Guid("ca117e7b-2894-49bf-9623-04d472fc4c2e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan875@gmail.com", "Tan875", "hashed_password_875", null, false, false, "Tran875", null, "user", null, 0 },
                    { new Guid("ca264da0-491c-4f96-81a5-916f2ab84703"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan843@gmail.com", "Tan843", "hashed_password_843", null, false, false, "Tran843", null, "user", null, 0 },
                    { new Guid("ca33282d-285b-4c09-9d8d-698f5dd48462"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan439@gmail.com", "Tan439", "hashed_password_439", null, false, false, "Tran439", null, "user", null, 0 },
                    { new Guid("ca4efed8-2811-45ea-9607-780a1b97ae45"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan349@gmail.com", "Tan349", "hashed_password_349", null, false, false, "Tran349", null, "user", null, 0 },
                    { new Guid("caba0efd-950a-452c-9593-b16cebc1a14d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan634@gmail.com", "Tan634", "hashed_password_634", null, false, false, "Tran634", null, "user", null, 0 },
                    { new Guid("cacec5b7-11b9-4e68-a5db-2cd1715beacf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan331@gmail.com", "Tan331", "hashed_password_331", null, false, false, "Tran331", null, "user", null, 0 },
                    { new Guid("cb5482e6-577e-48d0-b2de-f109eee54737"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan122@gmail.com", "Tan122", "hashed_password_122", null, false, false, "Tran122", null, "user", null, 0 },
                    { new Guid("cb620418-4dc7-456d-b302-2ef7436d2ec6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan292@gmail.com", "Tan292", "hashed_password_292", null, false, false, "Tran292", null, "user", null, 0 },
                    { new Guid("cb9b3bf6-a4d9-40bd-99cb-893d6b2e6309"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan594@gmail.com", "Tan594", "hashed_password_594", null, false, false, "Tran594", null, "user", null, 0 },
                    { new Guid("cbb6f25b-1b20-447a-b8cd-1fac13df88a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan247@gmail.com", "Tan247", "hashed_password_247", null, false, false, "Tran247", null, "user", null, 0 },
                    { new Guid("ccdf9050-6277-4a70-8869-282f0ed426a5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan238@gmail.com", "Tan238", "hashed_password_238", null, false, false, "Tran238", null, "user", null, 0 },
                    { new Guid("cd29a8c8-b4ee-4604-bdac-f2677859e8c6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan602@gmail.com", "Tan602", "hashed_password_602", null, false, false, "Tran602", null, "user", null, 0 },
                    { new Guid("cd630dfe-ca44-439a-816d-1c226e228a8c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan678@gmail.com", "Tan678", "hashed_password_678", null, false, false, "Tran678", null, "user", null, 0 },
                    { new Guid("cdb54940-3f38-4961-9672-80253c525a16"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan96@gmail.com", "Tan96", "hashed_password_96", null, false, false, "Tran96", null, "user", null, 0 },
                    { new Guid("ce3d49d0-01a3-453c-a2e1-4acafe93e9a9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan501@gmail.com", "Tan501", "hashed_password_501", null, false, false, "Tran501", null, "user", null, 0 },
                    { new Guid("ce879741-e90d-41d2-8e0e-152a451d7389"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan505@gmail.com", "Tan505", "hashed_password_505", null, false, false, "Tran505", null, "user", null, 0 },
                    { new Guid("ceb9dc04-3d8f-4ebf-8f25-9323e46c15e4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan318@gmail.com", "Tan318", "hashed_password_318", null, false, false, "Tran318", null, "user", null, 0 },
                    { new Guid("ceef1ab7-2693-4b25-bd0e-4c3504a539c8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan433@gmail.com", "Tan433", "hashed_password_433", null, false, false, "Tran433", null, "user", null, 0 },
                    { new Guid("cf17bda1-8937-4167-8a4e-d911c59a6017"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan799@gmail.com", "Tan799", "hashed_password_799", null, false, false, "Tran799", null, "user", null, 0 },
                    { new Guid("cf246031-f88c-459c-801e-8a895ec60812"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan915@gmail.com", "Tan915", "hashed_password_915", null, false, false, "Tran915", null, "user", null, 0 },
                    { new Guid("cf8a3e37-5411-4580-8efc-f441917d1ade"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan818@gmail.com", "Tan818", "hashed_password_818", null, false, false, "Tran818", null, "user", null, 0 },
                    { new Guid("cfb59b4b-01fa-4668-8bae-f2860f2f48b1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan279@gmail.com", "Tan279", "hashed_password_279", null, false, false, "Tran279", null, "user", null, 0 },
                    { new Guid("d01b2764-4d66-43da-9dae-9d4b4331c203"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan726@gmail.com", "Tan726", "hashed_password_726", null, false, false, "Tran726", null, "user", null, 0 },
                    { new Guid("d02cc983-fd86-426f-9f06-b10ba86b7568"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan463@gmail.com", "Tan463", "hashed_password_463", null, false, false, "Tran463", null, "user", null, 0 },
                    { new Guid("d126bbad-1fa9-4c35-ba5e-ca744f7f1474"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan885@gmail.com", "Tan885", "hashed_password_885", null, false, false, "Tran885", null, "user", null, 0 },
                    { new Guid("d1c4c11d-69b3-440b-b39c-debe332be3b2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan824@gmail.com", "Tan824", "hashed_password_824", null, false, false, "Tran824", null, "user", null, 0 },
                    { new Guid("d1cfded6-46f5-4361-be65-35cbc7ac2b21"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan661@gmail.com", "Tan661", "hashed_password_661", null, false, false, "Tran661", null, "user", null, 0 },
                    { new Guid("d1fb11ec-da7c-4759-9b54-2ca1e3509677"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan836@gmail.com", "Tan836", "hashed_password_836", null, false, false, "Tran836", null, "user", null, 0 },
                    { new Guid("d2380779-7bbd-4768-8657-6ebffec5f60b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan139@gmail.com", "Tan139", "hashed_password_139", null, false, false, "Tran139", null, "user", null, 0 },
                    { new Guid("d251ab4c-e8b8-4156-a89d-0c2da50b8bd7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan919@gmail.com", "Tan919", "hashed_password_919", null, false, false, "Tran919", null, "user", null, 0 },
                    { new Guid("d2794d07-28dd-4b89-b1e1-8a818c2e100f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan920@gmail.com", "Tan920", "hashed_password_920", null, false, false, "Tran920", null, "user", null, 0 },
                    { new Guid("d28e08cc-afd4-4a07-bd4f-a3711beb928b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan97@gmail.com", "Tan97", "hashed_password_97", null, false, false, "Tran97", null, "user", null, 0 },
                    { new Guid("d29a50b4-2ec5-4eef-9586-af51edf8df78"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan599@gmail.com", "Tan599", "hashed_password_599", null, false, false, "Tran599", null, "user", null, 0 },
                    { new Guid("d2f2cdd8-9c14-41f6-90a6-40da992f24db"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan855@gmail.com", "Tan855", "hashed_password_855", null, false, false, "Tran855", null, "user", null, 0 },
                    { new Guid("d2f996bb-8cbd-41f2-ab2d-a8840082980c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan489@gmail.com", "Tan489", "hashed_password_489", null, false, false, "Tran489", null, "user", null, 0 },
                    { new Guid("d3449943-0022-4af9-a35f-45288393c6e6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan990@gmail.com", "Tan990", "hashed_password_990", null, false, false, "Tran990", null, "user", null, 0 },
                    { new Guid("d3d04a17-f170-41cf-89c1-95a4d2807e82"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan706@gmail.com", "Tan706", "hashed_password_706", null, false, false, "Tran706", null, "user", null, 0 },
                    { new Guid("d4100eac-8c40-41a8-89f5-ff9ff3ece62a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan567@gmail.com", "Tan567", "hashed_password_567", null, false, false, "Tran567", null, "user", null, 0 },
                    { new Guid("d47fe560-b898-4f75-a4bf-251253a6137a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan859@gmail.com", "Tan859", "hashed_password_859", null, false, false, "Tran859", null, "user", null, 0 },
                    { new Guid("d4ae0769-9d9e-48fe-b39b-41bbb9bec5ac"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan750@gmail.com", "Tan750", "hashed_password_750", null, false, false, "Tran750", null, "user", null, 0 },
                    { new Guid("d4f6cefc-36b1-45fe-a7d0-ee6ecb706b6e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan757@gmail.com", "Tan757", "hashed_password_757", null, false, false, "Tran757", null, "user", null, 0 },
                    { new Guid("d562ca3b-7779-4d78-a9d5-e1788601f3ba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan355@gmail.com", "Tan355", "hashed_password_355", null, false, false, "Tran355", null, "user", null, 0 },
                    { new Guid("d5b9bca7-aef2-42cf-9522-5a85a40be608"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan37@gmail.com", "Tan37", "hashed_password_37", null, false, false, "Tran37", null, "user", null, 0 },
                    { new Guid("d5beecc0-fd1d-4481-9a06-b14712a16ee8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan362@gmail.com", "Tan362", "hashed_password_362", null, false, false, "Tran362", null, "user", null, 0 },
                    { new Guid("d5c73acf-1e83-4a66-b323-c7d895c49d94"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan395@gmail.com", "Tan395", "hashed_password_395", null, false, false, "Tran395", null, "user", null, 0 },
                    { new Guid("d5e042ca-a9a9-49fe-b177-90c609a2dea0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan487@gmail.com", "Tan487", "hashed_password_487", null, false, false, "Tran487", null, "user", null, 0 },
                    { new Guid("d61a3423-ce1a-4e2d-a812-0b467349c0ba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan523@gmail.com", "Tan523", "hashed_password_523", null, false, false, "Tran523", null, "user", null, 0 },
                    { new Guid("d634cf5e-60e2-4f5b-9ee7-05b83a91a493"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan113@gmail.com", "Tan113", "hashed_password_113", null, false, false, "Tran113", null, "user", null, 0 },
                    { new Guid("d645b1a3-90d6-4649-adac-d0d4d032f0f9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan79@gmail.com", "Tan79", "hashed_password_79", null, false, false, "Tran79", null, "user", null, 0 },
                    { new Guid("d6495dda-b546-42a1-be0d-5a90f2f109f9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan479@gmail.com", "Tan479", "hashed_password_479", null, false, false, "Tran479", null, "user", null, 0 },
                    { new Guid("d665a86d-8de3-4e86-8f85-0267d05b8259"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan76@gmail.com", "Tan76", "hashed_password_76", null, false, false, "Tran76", null, "user", null, 0 },
                    { new Guid("d6c1e9cc-4efc-42c8-8416-9f8bb340b6a5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan431@gmail.com", "Tan431", "hashed_password_431", null, false, false, "Tran431", null, "user", null, 0 },
                    { new Guid("d6d3a616-1d03-4512-8a4d-0e1909c88ab8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan457@gmail.com", "Tan457", "hashed_password_457", null, false, false, "Tran457", null, "user", null, 0 },
                    { new Guid("d6e492c0-c1d7-446a-8950-e8640f81bd9c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan194@gmail.com", "Tan194", "hashed_password_194", null, false, false, "Tran194", null, "user", null, 0 },
                    { new Guid("d7055a5a-ad02-4cd5-b38b-29f39cc2e93e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan538@gmail.com", "Tan538", "hashed_password_538", null, false, false, "Tran538", null, "user", null, 0 },
                    { new Guid("d72e449d-8272-4c7f-b1a2-13e141edfa7a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan210@gmail.com", "Tan210", "hashed_password_210", null, false, false, "Tran210", null, "user", null, 0 },
                    { new Guid("d771573c-f96a-484d-a38e-1d07d4806caf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan830@gmail.com", "Tan830", "hashed_password_830", null, false, false, "Tran830", null, "user", null, 0 },
                    { new Guid("d7c44788-7f37-4bea-87e1-68968005c45d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan483@gmail.com", "Tan483", "hashed_password_483", null, false, false, "Tran483", null, "user", null, 0 },
                    { new Guid("d7c7eed1-b56a-459a-b589-59443d633979"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan155@gmail.com", "Tan155", "hashed_password_155", null, false, false, "Tran155", null, "user", null, 0 },
                    { new Guid("d7cc2dcd-c315-437b-aaf3-9a6e2d9ccca9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan785@gmail.com", "Tan785", "hashed_password_785", null, false, false, "Tran785", null, "user", null, 0 },
                    { new Guid("d8073339-28ac-43c2-a8c3-5c8918269343"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan747@gmail.com", "Tan747", "hashed_password_747", null, false, false, "Tran747", null, "user", null, 0 },
                    { new Guid("d836e00c-9c7d-47d9-be92-440fb30ba860"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan215@gmail.com", "Tan215", "hashed_password_215", null, false, false, "Tran215", null, "user", null, 0 },
                    { new Guid("d84b5e40-4bc4-4b5c-962f-c95cf5a8135a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan310@gmail.com", "Tan310", "hashed_password_310", null, false, false, "Tran310", null, "user", null, 0 },
                    { new Guid("d8602881-aea6-4d3f-9ccf-0aa1f1f87bca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan36@gmail.com", "Tan36", "hashed_password_36", null, false, false, "Tran36", null, "user", null, 0 },
                    { new Guid("d8a7c224-63ce-4935-8b2f-fc0a796b160d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan629@gmail.com", "Tan629", "hashed_password_629", null, false, false, "Tran629", null, "user", null, 0 },
                    { new Guid("d918934f-a033-4486-aa47-e6453ab48963"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan521@gmail.com", "Tan521", "hashed_password_521", null, false, false, "Tran521", null, "user", null, 0 },
                    { new Guid("d93cf170-f5bc-4c12-abf3-cd91e845516e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan834@gmail.com", "Tan834", "hashed_password_834", null, false, false, "Tran834", null, "user", null, 0 },
                    { new Guid("d97b66b6-0680-4ee6-a424-89c182257209"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan744@gmail.com", "Tan744", "hashed_password_744", null, false, false, "Tran744", null, "user", null, 0 },
                    { new Guid("d9942e97-d3a9-4bb9-95e2-f3b14e11827e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan1000@gmail.com", "Tan1000", "hashed_password_1000", null, false, false, "Tran1000", null, "user", null, 0 },
                    { new Guid("d9e68834-b6de-4af2-a7e8-4f1696bf5600"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan3@gmail.com", "Tan3", "hashed_password_3", null, false, false, "Tran3", null, "user", null, 0 },
                    { new Guid("da14231b-0714-4eab-b46f-2f65c74e84f6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan604@gmail.com", "Tan604", "hashed_password_604", null, false, false, "Tran604", null, "user", null, 0 },
                    { new Guid("da195666-8486-4e9a-8da7-3ff5642e6006"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan57@gmail.com", "Tan57", "hashed_password_57", null, false, false, "Tran57", null, "user", null, 0 },
                    { new Guid("da31ec87-068e-4a52-a861-5426473ced0d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan184@gmail.com", "Tan184", "hashed_password_184", null, false, false, "Tran184", null, "user", null, 0 },
                    { new Guid("daa9611c-dd79-4b50-9a99-f1676289ad7e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan767@gmail.com", "Tan767", "hashed_password_767", null, false, false, "Tran767", null, "user", null, 0 },
                    { new Guid("dabd1a0e-43fe-4d5c-a573-d19ded91fbd1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan783@gmail.com", "Tan783", "hashed_password_783", null, false, false, "Tran783", null, "user", null, 0 },
                    { new Guid("db0ec234-e51f-49c2-8421-bfefc9e826fc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan513@gmail.com", "Tan513", "hashed_password_513", null, false, false, "Tran513", null, "user", null, 0 },
                    { new Guid("db3be8f1-eeb4-4e27-8c0d-d8f282cc1c44"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan542@gmail.com", "Tan542", "hashed_password_542", null, false, false, "Tran542", null, "user", null, 0 },
                    { new Guid("dbe8a169-4513-473b-ac80-4a5358b6828e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan321@gmail.com", "Tan321", "hashed_password_321", null, false, false, "Tran321", null, "user", null, 0 },
                    { new Guid("dc01735c-b76c-449a-8cc2-b20f3cd020ac"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan159@gmail.com", "Tan159", "hashed_password_159", null, false, false, "Tran159", null, "user", null, 0 },
                    { new Guid("dc422654-fe44-42c8-980a-9a5fff14188a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan19@gmail.com", "Tan19", "hashed_password_19", null, false, false, "Tran19", null, "user", null, 0 },
                    { new Guid("dc6d3539-4b89-41e5-872c-373702b550dd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan825@gmail.com", "Tan825", "hashed_password_825", null, false, false, "Tran825", null, "user", null, 0 },
                    { new Guid("dc93263c-3cd9-4588-b706-b88de1b0ffd7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan718@gmail.com", "Tan718", "hashed_password_718", null, false, false, "Tran718", null, "user", null, 0 },
                    { new Guid("dce259b7-ea12-4e7e-923d-c022466ea149"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan110@gmail.com", "Tan110", "hashed_password_110", null, false, false, "Tran110", null, "user", null, 0 },
                    { new Guid("dd78bbfa-4d44-41ad-bd2b-3e95c1bca258"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan229@gmail.com", "Tan229", "hashed_password_229", null, false, false, "Tran229", null, "user", null, 0 },
                    { new Guid("de047887-38d1-4246-ac9a-2b6d15afc7be"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan328@gmail.com", "Tan328", "hashed_password_328", null, false, false, "Tran328", null, "user", null, 0 },
                    { new Guid("de5b2c17-0b7f-41c6-b4a5-c5931f8207fc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan61@gmail.com", "Tan61", "hashed_password_61", null, false, false, "Tran61", null, "user", null, 0 },
                    { new Guid("def22452-2a30-425e-9e7d-b72b83acb321"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan280@gmail.com", "Tan280", "hashed_password_280", null, false, false, "Tran280", null, "user", null, 0 },
                    { new Guid("df2be2a2-ec3b-41ee-8984-8fa742b1d7ea"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan183@gmail.com", "Tan183", "hashed_password_183", null, false, false, "Tran183", null, "user", null, 0 },
                    { new Guid("df3c4cbe-5281-48ed-93aa-cdbe5669eef0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan893@gmail.com", "Tan893", "hashed_password_893", null, false, false, "Tran893", null, "user", null, 0 },
                    { new Guid("df84ee82-4400-4d4e-bcf2-e95c307a7a9f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan911@gmail.com", "Tan911", "hashed_password_911", null, false, false, "Tran911", null, "user", null, 0 },
                    { new Guid("df8683b3-90a8-4f30-8274-a22e239ee134"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan112@gmail.com", "Tan112", "hashed_password_112", null, false, false, "Tran112", null, "user", null, 0 },
                    { new Guid("dfb122d6-b80a-4632-83fa-fee5ae1bfaec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan844@gmail.com", "Tan844", "hashed_password_844", null, false, false, "Tran844", null, "user", null, 0 },
                    { new Guid("e0ebaa43-fc05-4d8f-b2ed-264db07beb01"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan732@gmail.com", "Tan732", "hashed_password_732", null, false, false, "Tran732", null, "user", null, 0 },
                    { new Guid("e18dccf8-f59d-4187-b878-9ea70010aacc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan663@gmail.com", "Tan663", "hashed_password_663", null, false, false, "Tran663", null, "user", null, 0 },
                    { new Guid("e1b7b374-9985-486d-b81b-4fda6d9278f2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan851@gmail.com", "Tan851", "hashed_password_851", null, false, false, "Tran851", null, "user", null, 0 },
                    { new Guid("e1e2df37-b3b0-4a63-a4c0-5fdb75c6c914"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan426@gmail.com", "Tan426", "hashed_password_426", null, false, false, "Tran426", null, "user", null, 0 },
                    { new Guid("e2690aaa-3b35-4439-b67e-c9d36cece6ea"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan390@gmail.com", "Tan390", "hashed_password_390", null, false, false, "Tran390", null, "user", null, 0 },
                    { new Guid("e272317c-4a2e-4394-b2fd-1bcfc29b6219"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan160@gmail.com", "Tan160", "hashed_password_160", null, false, false, "Tran160", null, "user", null, 0 },
                    { new Guid("e299383c-fa6b-4e99-b568-010f7a6d1746"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan677@gmail.com", "Tan677", "hashed_password_677", null, false, false, "Tran677", null, "user", null, 0 },
                    { new Guid("e2c4fa0c-f647-4eec-9da7-6d556fa74369"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan707@gmail.com", "Tan707", "hashed_password_707", null, false, false, "Tran707", null, "user", null, 0 },
                    { new Guid("e2cdc393-7a9b-47e1-95ad-10346253ab66"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan445@gmail.com", "Tan445", "hashed_password_445", null, false, false, "Tran445", null, "user", null, 0 },
                    { new Guid("e2e058f4-8f43-4170-ba05-3f08ecda5694"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan777@gmail.com", "Tan777", "hashed_password_777", null, false, false, "Tran777", null, "user", null, 0 },
                    { new Guid("e35740e6-52f3-445d-a387-7f2933277a53"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan289@gmail.com", "Tan289", "hashed_password_289", null, false, false, "Tran289", null, "user", null, 0 },
                    { new Guid("e3747a7b-90c6-46ae-9936-62032a71f599"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan315@gmail.com", "Tan315", "hashed_password_315", null, false, false, "Tran315", null, "user", null, 0 },
                    { new Guid("e38ae70c-2442-4c42-812b-3d59884c6e99"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan503@gmail.com", "Tan503", "hashed_password_503", null, false, false, "Tran503", null, "user", null, 0 },
                    { new Guid("e3cf22e8-24ea-481b-af40-4721ea333358"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan988@gmail.com", "Tan988", "hashed_password_988", null, false, false, "Tran988", null, "user", null, 0 },
                    { new Guid("e4617648-2365-42c7-ac5b-be1622278e5f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan861@gmail.com", "Tan861", "hashed_password_861", null, false, false, "Tran861", null, "user", null, 0 },
                    { new Guid("e48283fc-602c-4494-ba01-09f7856c7b6f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan809@gmail.com", "Tan809", "hashed_password_809", null, false, false, "Tran809", null, "user", null, 0 },
                    { new Guid("e4a6e5aa-54d0-4a5a-94f5-da877afa3cdd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan687@gmail.com", "Tan687", "hashed_password_687", null, false, false, "Tran687", null, "user", null, 0 },
                    { new Guid("e4dfb366-3bbc-4ca5-ac00-0e846b355abb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan839@gmail.com", "Tan839", "hashed_password_839", null, false, false, "Tran839", null, "user", null, 0 },
                    { new Guid("e5c29051-b0c6-45e9-a4bd-de2a899ab116"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan828@gmail.com", "Tan828", "hashed_password_828", null, false, false, "Tran828", null, "user", null, 0 },
                    { new Guid("e5d96357-f38e-42b8-a36a-1d1d70fc3e58"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan607@gmail.com", "Tan607", "hashed_password_607", null, false, false, "Tran607", null, "user", null, 0 },
                    { new Guid("e5dc73ca-d09c-476a-a1a6-a9236c25fb21"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan810@gmail.com", "Tan810", "hashed_password_810", null, false, false, "Tran810", null, "user", null, 0 },
                    { new Guid("e5ed6d99-f4dd-47bf-9f01-b2235439ebdc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan118@gmail.com", "Tan118", "hashed_password_118", null, false, false, "Tran118", null, "user", null, 0 },
                    { new Guid("e607a625-839c-4354-a4ce-0758796cef10"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan845@gmail.com", "Tan845", "hashed_password_845", null, false, false, "Tran845", null, "user", null, 0 },
                    { new Guid("e6857851-3a17-44d3-868b-93667b574dbe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan909@gmail.com", "Tan909", "hashed_password_909", null, false, false, "Tran909", null, "user", null, 0 },
                    { new Guid("e6982b1d-9e7e-4715-b8ca-f9b9ae7734fc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan24@gmail.com", "Tan24", "hashed_password_24", null, false, false, "Tran24", null, "user", null, 0 },
                    { new Guid("e743cb9e-ef8e-4498-8554-31950e23f9d3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan412@gmail.com", "Tan412", "hashed_password_412", null, false, false, "Tran412", null, "user", null, 0 },
                    { new Guid("e74d5f36-2f3d-4f7e-b7f4-cc3e8b68ef48"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan649@gmail.com", "Tan649", "hashed_password_649", null, false, false, "Tran649", null, "user", null, 0 },
                    { new Guid("e7b71409-fd43-4ccd-96d5-5add20e37661"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan111@gmail.com", "Tan111", "hashed_password_111", null, false, false, "Tran111", null, "user", null, 0 },
                    { new Guid("e85f485d-646f-4783-9aa2-4bbd330dd5be"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan570@gmail.com", "Tan570", "hashed_password_570", null, false, false, "Tran570", null, "user", null, 0 },
                    { new Guid("e8853a9e-a6c2-453a-9e05-08a3e19e782f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan435@gmail.com", "Tan435", "hashed_password_435", null, false, false, "Tran435", null, "user", null, 0 },
                    { new Guid("e889058b-9cf4-4c96-943d-d07d827662b6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan551@gmail.com", "Tan551", "hashed_password_551", null, false, false, "Tran551", null, "user", null, 0 },
                    { new Guid("e8e2298e-d6e4-4cba-a173-1810ce1c8877"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan442@gmail.com", "Tan442", "hashed_password_442", null, false, false, "Tran442", null, "user", null, 0 },
                    { new Guid("e93516bc-806c-4b03-8dfa-a576ab420a48"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan882@gmail.com", "Tan882", "hashed_password_882", null, false, false, "Tran882", null, "user", null, 0 },
                    { new Guid("e96a5120-d557-4d64-a4f9-6ea11ad0f2de"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan601@gmail.com", "Tan601", "hashed_password_601", null, false, false, "Tran601", null, "user", null, 0 },
                    { new Guid("e98fbfa7-3a81-4cbb-a836-319379ac12ff"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan702@gmail.com", "Tan702", "hashed_password_702", null, false, false, "Tran702", null, "user", null, 0 },
                    { new Guid("e9c30499-f21e-4110-b737-2bab2b235189"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan708@gmail.com", "Tan708", "hashed_password_708", null, false, false, "Tran708", null, "user", null, 0 },
                    { new Guid("e9d3ca1b-00c5-46d7-849c-65fe3e632261"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan984@gmail.com", "Tan984", "hashed_password_984", null, false, false, "Tran984", null, "user", null, 0 },
                    { new Guid("e9dba650-051e-49d4-8950-57c9b2c68c36"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan763@gmail.com", "Tan763", "hashed_password_763", null, false, false, "Tran763", null, "user", null, 0 },
                    { new Guid("e9faf6b6-b185-4d12-91f4-cd64a0d1d74a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan681@gmail.com", "Tan681", "hashed_password_681", null, false, false, "Tran681", null, "user", null, 0 },
                    { new Guid("ea0be63c-b2d2-4602-ba41-b52503088953"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan794@gmail.com", "Tan794", "hashed_password_794", null, false, false, "Tran794", null, "user", null, 0 },
                    { new Guid("ea8ff6d7-f35f-499b-a8d3-35878a5b5a4a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan265@gmail.com", "Tan265", "hashed_password_265", null, false, false, "Tran265", null, "user", null, 0 },
                    { new Guid("ea9462fd-3ffd-40f0-9b60-1fefbfe96588"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan595@gmail.com", "Tan595", "hashed_password_595", null, false, false, "Tran595", null, "user", null, 0 },
                    { new Guid("eb1e61ea-5e65-49a3-86aa-b512e42c7a4e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan444@gmail.com", "Tan444", "hashed_password_444", null, false, false, "Tran444", null, "user", null, 0 },
                    { new Guid("eb3b5ae5-185e-483f-8ebe-c4c5384cc9af"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan434@gmail.com", "Tan434", "hashed_password_434", null, false, false, "Tran434", null, "user", null, 0 },
                    { new Guid("eb449bbd-8a27-4790-a1be-aae115c0da89"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan971@gmail.com", "Tan971", "hashed_password_971", null, false, false, "Tran971", null, "user", null, 0 },
                    { new Guid("eb4dacd5-c339-435f-8805-4378d34826ec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan864@gmail.com", "Tan864", "hashed_password_864", null, false, false, "Tran864", null, "user", null, 0 },
                    { new Guid("eb85305b-e554-4286-b703-b2de2edc32cc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan510@gmail.com", "Tan510", "hashed_password_510", null, false, false, "Tran510", null, "user", null, 0 },
                    { new Guid("ebae184b-c212-45bc-a24a-bb569caae34c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan23@gmail.com", "Tan23", "hashed_password_23", null, false, false, "Tran23", null, "user", null, 0 },
                    { new Guid("ebe8a588-bfa5-4aed-8393-886363378921"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan543@gmail.com", "Tan543", "hashed_password_543", null, false, false, "Tran543", null, "user", null, 0 },
                    { new Guid("ebf046d9-139b-4a92-8388-e9c6cbbd971b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan148@gmail.com", "Tan148", "hashed_password_148", null, false, false, "Tran148", null, "user", null, 0 },
                    { new Guid("ec019dc7-8f0c-4386-a4be-b67efc082f73"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan82@gmail.com", "Tan82", "hashed_password_82", null, false, false, "Tran82", null, "user", null, 0 },
                    { new Guid("ec770c96-6231-4408-924e-c1d4d2780921"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan955@gmail.com", "Tan955", "hashed_password_955", null, false, false, "Tran955", null, "user", null, 0 },
                    { new Guid("ecfb0314-ccae-4307-9cba-76ce791b4e3f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan862@gmail.com", "Tan862", "hashed_password_862", null, false, false, "Tran862", null, "user", null, 0 },
                    { new Guid("ed36e611-ea6f-4a66-b75d-e7ebfce0c973"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan87@gmail.com", "Tan87", "hashed_password_87", null, false, false, "Tran87", null, "user", null, 0 },
                    { new Guid("ed82e2d9-9bd2-4ce8-8221-2c976f879304"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan578@gmail.com", "Tan578", "hashed_password_578", null, false, false, "Tran578", null, "user", null, 0 },
                    { new Guid("ed8f28b1-3baa-4fd9-ba24-a02329fb8a01"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan192@gmail.com", "Tan192", "hashed_password_192", null, false, false, "Tran192", null, "user", null, 0 },
                    { new Guid("edcd5825-6144-4b59-8539-2e440014e154"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan600@gmail.com", "Tan600", "hashed_password_600", null, false, false, "Tran600", null, "user", null, 0 },
                    { new Guid("edfc88d9-ec84-40d6-a402-de589b526afc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan250@gmail.com", "Tan250", "hashed_password_250", null, false, false, "Tran250", null, "user", null, 0 },
                    { new Guid("ee2ae82a-1001-497d-a84d-37e603741dca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan293@gmail.com", "Tan293", "hashed_password_293", null, false, false, "Tran293", null, "user", null, 0 },
                    { new Guid("ee95c93f-32fe-4341-a73f-1c9e1911a5cc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan165@gmail.com", "Tan165", "hashed_password_165", null, false, false, "Tran165", null, "user", null, 0 },
                    { new Guid("ef51d9b4-9bce-4e4b-93c4-7a3a64298e58"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan385@gmail.com", "Tan385", "hashed_password_385", null, false, false, "Tran385", null, "user", null, 0 },
                    { new Guid("f061accf-108b-4459-87a5-e4a6cef5989c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan335@gmail.com", "Tan335", "hashed_password_335", null, false, false, "Tran335", null, "user", null, 0 },
                    { new Guid("f0b17790-b033-4177-bc2c-faa935cea706"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan725@gmail.com", "Tan725", "hashed_password_725", null, false, false, "Tran725", null, "user", null, 0 },
                    { new Guid("f0c62fb1-5b67-47a2-892b-6be15306edc9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan86@gmail.com", "Tan86", "hashed_password_86", null, false, false, "Tran86", null, "user", null, 0 },
                    { new Guid("f0c87f05-6bed-4cb2-8082-aef2b26dfe96"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan787@gmail.com", "Tan787", "hashed_password_787", null, false, false, "Tran787", null, "user", null, 0 },
                    { new Guid("f0ef8234-9f1d-4968-a707-1ef3230f3ae4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan241@gmail.com", "Tan241", "hashed_password_241", null, false, false, "Tran241", null, "user", null, 0 },
                    { new Guid("f12b454d-de90-4154-bf3c-2025bf23ce09"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan944@gmail.com", "Tan944", "hashed_password_944", null, false, false, "Tran944", null, "user", null, 0 },
                    { new Guid("f133f218-ed8e-4fc0-bb7f-be0055306710"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan803@gmail.com", "Tan803", "hashed_password_803", null, false, false, "Tran803", null, "user", null, 0 },
                    { new Guid("f147b4eb-161a-40ed-bf21-e3630f667906"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan539@gmail.com", "Tan539", "hashed_password_539", null, false, false, "Tran539", null, "user", null, 0 },
                    { new Guid("f17439a4-2b37-4ba0-8934-3c9ac715a6cf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan939@gmail.com", "Tan939", "hashed_password_939", null, false, false, "Tran939", null, "user", null, 0 },
                    { new Guid("f17be5a8-84da-4c32-af5d-8cbb9bf17d11"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan620@gmail.com", "Tan620", "hashed_password_620", null, false, false, "Tran620", null, "user", null, 0 },
                    { new Guid("f2565adf-81b4-4cd9-b5a1-6c241a689966"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan102@gmail.com", "Tan102", "hashed_password_102", null, false, false, "Tran102", null, "user", null, 0 },
                    { new Guid("f271402d-ec3f-4bb5-ab06-35dd79ba05c1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan263@gmail.com", "Tan263", "hashed_password_263", null, false, false, "Tran263", null, "user", null, 0 },
                    { new Guid("f2869f4b-6a33-44d2-8054-cd2345ae9687"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan47@gmail.com", "Tan47", "hashed_password_47", null, false, false, "Tran47", null, "user", null, 0 },
                    { new Guid("f2b2abf2-8c4e-41a5-b6a0-d661988e47d3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan452@gmail.com", "Tan452", "hashed_password_452", null, false, false, "Tran452", null, "user", null, 0 },
                    { new Guid("f3049e7c-b46f-47a3-9d82-8ef8ac6c2570"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan617@gmail.com", "Tan617", "hashed_password_617", null, false, false, "Tran617", null, "user", null, 0 },
                    { new Guid("f31cba14-7a1b-4c6e-8b53-91a30b3c6cf6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan727@gmail.com", "Tan727", "hashed_password_727", null, false, false, "Tran727", null, "user", null, 0 },
                    { new Guid("f39f95c2-7740-4067-8cb0-66c0d108695a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan552@gmail.com", "Tan552", "hashed_password_552", null, false, false, "Tran552", null, "user", null, 0 },
                    { new Guid("f443f59f-d379-4549-aa23-1adddbfaeae5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan161@gmail.com", "Tan161", "hashed_password_161", null, false, false, "Tran161", null, "user", null, 0 },
                    { new Guid("f4dc17a5-d3d9-4f19-989b-f3a374a83aed"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan245@gmail.com", "Tan245", "hashed_password_245", null, false, false, "Tran245", null, "user", null, 0 },
                    { new Guid("f4f4372b-a90b-4e3d-b6e7-40307087204b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan950@gmail.com", "Tan950", "hashed_password_950", null, false, false, "Tran950", null, "user", null, 0 },
                    { new Guid("f57785c8-5aad-4802-8820-45f6e1aef70a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan344@gmail.com", "Tan344", "hashed_password_344", null, false, false, "Tran344", null, "user", null, 0 },
                    { new Guid("f5850d8a-ea48-47a7-a323-718b08a519a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan366@gmail.com", "Tan366", "hashed_password_366", null, false, false, "Tran366", null, "user", null, 0 },
                    { new Guid("f5c5a728-9919-429e-885d-a35b2759270d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan511@gmail.com", "Tan511", "hashed_password_511", null, false, false, "Tran511", null, "user", null, 0 },
                    { new Guid("f629fd0c-141b-474c-9f35-f03d605c4cbb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan314@gmail.com", "Tan314", "hashed_password_314", null, false, false, "Tran314", null, "user", null, 0 },
                    { new Guid("f6be0541-d021-42f1-884f-04b15a9dc62d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan33@gmail.com", "Tan33", "hashed_password_33", null, false, false, "Tran33", null, "user", null, 0 },
                    { new Guid("f6d9f488-449a-4ef3-a905-af969fdd38ba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan175@gmail.com", "Tan175", "hashed_password_175", null, false, false, "Tran175", null, "user", null, 0 },
                    { new Guid("f757fafb-b058-4703-b8fa-9513488d20d5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan949@gmail.com", "Tan949", "hashed_password_949", null, false, false, "Tran949", null, "user", null, 0 },
                    { new Guid("f7840174-ff15-46fa-87b6-03bb2a86732d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan822@gmail.com", "Tan822", "hashed_password_822", null, false, false, "Tran822", null, "user", null, 0 },
                    { new Guid("f7edc445-f670-4780-ad01-d57a25baea7d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan865@gmail.com", "Tan865", "hashed_password_865", null, false, false, "Tran865", null, "user", null, 0 },
                    { new Guid("f7f1bfd8-4ff5-4c34-b015-f4105ddc0298"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan977@gmail.com", "Tan977", "hashed_password_977", null, false, false, "Tran977", null, "user", null, 0 },
                    { new Guid("f80b70c7-f2a2-4230-8964-d5421d07f7c9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan559@gmail.com", "Tan559", "hashed_password_559", null, false, false, "Tran559", null, "user", null, 0 },
                    { new Guid("f87759f1-2ff5-4daf-9683-7ed17a8f6713"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan354@gmail.com", "Tan354", "hashed_password_354", null, false, false, "Tran354", null, "user", null, 0 },
                    { new Guid("f87a7236-b595-47e8-98db-bd3d8632402d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan954@gmail.com", "Tan954", "hashed_password_954", null, false, false, "Tran954", null, "user", null, 0 },
                    { new Guid("f8cee417-0c9c-4822-8da3-3a9d12a394ef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan187@gmail.com", "Tan187", "hashed_password_187", null, false, false, "Tran187", null, "user", null, 0 },
                    { new Guid("f8d6619f-ff21-482d-95e7-139a48c95fb0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan584@gmail.com", "Tan584", "hashed_password_584", null, false, false, "Tran584", null, "user", null, 0 },
                    { new Guid("f926ae78-2a48-499f-be44-6edba89eb51b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan883@gmail.com", "Tan883", "hashed_password_883", null, false, false, "Tran883", null, "user", null, 0 },
                    { new Guid("f9839e82-f145-4e81-ba37-9364852a1e75"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan695@gmail.com", "Tan695", "hashed_password_695", null, false, false, "Tran695", null, "user", null, 0 },
                    { new Guid("f9a34a91-6913-4066-88ae-5e4dc29535b9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan999@gmail.com", "Tan999", "hashed_password_999", null, false, false, "Tran999", null, "user", null, 0 },
                    { new Guid("f9bf3ebb-98d8-451c-9ced-dff004770d18"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan406@gmail.com", "Tan406", "hashed_password_406", null, false, false, "Tran406", null, "user", null, 0 },
                    { new Guid("f9ee889c-fca1-4bf5-b70d-6b186d3ff51f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan854@gmail.com", "Tan854", "hashed_password_854", null, false, false, "Tran854", null, "user", null, 0 },
                    { new Guid("fa4e405a-f8b2-4bbb-817f-2362c1ac061e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan85@gmail.com", "Tan85", "hashed_password_85", null, false, false, "Tran85", null, "user", null, 0 },
                    { new Guid("fa5a5913-97d7-4da8-a349-f642ee68799d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan64@gmail.com", "Tan64", "hashed_password_64", null, false, false, "Tran64", null, "user", null, 0 },
                    { new Guid("fafabc9d-ed59-4d22-891e-ccf3bf7b97d0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan345@gmail.com", "Tan345", "hashed_password_345", null, false, false, "Tran345", null, "user", null, 0 },
                    { new Guid("fb0511fc-bb7a-4deb-9869-ec125638c389"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan306@gmail.com", "Tan306", "hashed_password_306", null, false, false, "Tran306", null, "user", null, 0 },
                    { new Guid("fb4729c7-b9cb-45a2-9eac-0384da86f211"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan913@gmail.com", "Tan913", "hashed_password_913", null, false, false, "Tran913", null, "user", null, 0 },
                    { new Guid("fb6b70be-16e5-4a4e-8224-816fb7ca257f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan387@gmail.com", "Tan387", "hashed_password_387", null, false, false, "Tran387", null, "user", null, 0 },
                    { new Guid("fbbe2414-570c-43b1-82cd-b5b714be5caf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan815@gmail.com", "Tan815", "hashed_password_815", null, false, false, "Tran815", null, "user", null, 0 },
                    { new Guid("fbd18e14-c58e-463e-b33f-2d828eba08e5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan136@gmail.com", "Tan136", "hashed_password_136", null, false, false, "Tran136", null, "user", null, 0 },
                    { new Guid("fbf9f632-8fa2-41fa-9aed-ee8acb4ecf1a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan398@gmail.com", "Tan398", "hashed_password_398", null, false, false, "Tran398", null, "user", null, 0 },
                    { new Guid("fc6720b4-6f12-4fb1-bcb9-12bcce8179e6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan625@gmail.com", "Tan625", "hashed_password_625", null, false, false, "Tran625", null, "user", null, 0 },
                    { new Guid("fcb61446-d72c-42f2-97ca-976cc1fe3513"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan251@gmail.com", "Tan251", "hashed_password_251", null, false, false, "Tran251", null, "user", null, 0 },
                    { new Guid("fcf5d521-97f9-44bb-9dcc-c7c1b5a1c559"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan720@gmail.com", "Tan720", "hashed_password_720", null, false, false, "Tran720", null, "user", null, 0 },
                    { new Guid("fcf94c97-3088-4768-b78d-719c3c6d16db"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan585@gmail.com", "Tan585", "hashed_password_585", null, false, false, "Tran585", null, "user", null, 0 },
                    { new Guid("fd27ae59-03cf-4f00-91a6-ac3b32f923f2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan459@gmail.com", "Tan459", "hashed_password_459", null, false, false, "Tran459", null, "user", null, 0 },
                    { new Guid("fd48e6c9-36c4-4022-81ea-467e1b613d31"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan441@gmail.com", "Tan441", "hashed_password_441", null, false, false, "Tran441", null, "user", null, 0 },
                    { new Guid("fd5ddc1c-51a6-4e0a-9131-402138177391"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan255@gmail.com", "Tan255", "hashed_password_255", null, false, false, "Tran255", null, "user", null, 0 },
                    { new Guid("fd69d11c-b2de-4848-ab26-727db7184c95"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan608@gmail.com", "Tan608", "hashed_password_608", null, false, false, "Tran608", null, "user", null, 0 },
                    { new Guid("fd7f53c2-9ee0-4dc5-b5bb-1596f3271c39"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan721@gmail.com", "Tan721", "hashed_password_721", null, false, false, "Tran721", null, "user", null, 0 },
                    { new Guid("fd9fd14b-7de2-4c98-99da-a3b7563266f0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan519@gmail.com", "Tan519", "hashed_password_519", null, false, false, "Tran519", null, "user", null, 0 },
                    { new Guid("fe093680-7116-431b-8a21-74c9465e9aa0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan296@gmail.com", "Tan296", "hashed_password_296", null, false, false, "Tran296", null, "user", null, 0 },
                    { new Guid("fe255f3f-1bd2-46c7-94f4-ee5f533d2e2d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan560@gmail.com", "Tan560", "hashed_password_560", null, false, false, "Tran560", null, "user", null, 0 },
                    { new Guid("fe3bf391-dea8-48d4-9f49-2c2c592b0d1e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan302@gmail.com", "Tan302", "hashed_password_302", null, false, false, "Tran302", null, "user", null, 0 },
                    { new Guid("fe5de52e-ef6c-4a78-a462-8022dd96fa62"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan495@gmail.com", "Tan495", "hashed_password_495", null, false, false, "Tran495", null, "user", null, 0 },
                    { new Guid("fe803e87-6f77-4609-86ad-b921b210d4fe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan35@gmail.com", "Tan35", "hashed_password_35", null, false, false, "Tran35", null, "user", null, 0 },
                    { new Guid("feb82bb4-dd72-498c-8799-642a07263518"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan20@gmail.com", "Tan20", "hashed_password_20", null, false, false, "Tran20", null, "user", null, 0 },
                    { new Guid("fec3b823-73b2-4764-acfd-98572fccdbf5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan572@gmail.com", "Tan572", "hashed_password_572", null, false, false, "Tran572", null, "user", null, 0 },
                    { new Guid("fed453f5-6f89-43e4-8d59-7357923a5e2b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan384@gmail.com", "Tan384", "hashed_password_384", null, false, false, "Tran384", null, "user", null, 0 },
                    { new Guid("fefa6abf-813b-412f-a642-e6aabf354c48"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan179@gmail.com", "Tan179", "hashed_password_179", null, false, false, "Tran179", null, "user", null, 0 },
                    { new Guid("ff063e86-f7b1-4161-8fba-181aaab2d198"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan716@gmail.com", "Tan716", "hashed_password_716", null, false, false, "Tran716", null, "user", null, 0 },
                    { new Guid("ffe0f865-fc03-4a93-9654-330baa1466b6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan498@gmail.com", "Tan498", "hashed_password_498", null, false, false, "Tran498", null, "user", null, 0 },
                    { new Guid("ffe5699b-e913-464a-acf7-fc44ad11d008"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan376@gmail.com", "Tan376", "hashed_password_376", null, false, false, "Tran376", null, "user", null, 0 },
                    { new Guid("ffe60c1f-2e0c-472c-8bc4-b4e25007b5fd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan509@gmail.com", "Tan509", "hashed_password_509", null, false, false, "Tran509", null, "user", null, 0 },
                    { new Guid("fff31754-874e-45a1-a58d-09dc5464b0de"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan648@gmail.com", "Tan648", "hashed_password_648", null, false, false, "Tran648", null, "user", null, 0 },
                    { new Guid("fff92c07-455d-4d27-be07-0c24c83df705"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan7@gmail.com", "Tan7", "hashed_password_7", null, false, false, "Tran7", null, "user", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ParentId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0032a29f-6717-49ef-9114-300eb0337ecc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 457", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("004285eb-c9c7-4a0d-a1c5-b50908b4881f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 471", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("0052dcd7-c8a0-4c6f-ab83-3f50ba5144fb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 255", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("005f1e7d-904a-48c0-846a-aa3a2f8cb336"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 43", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("00dabe04-7f0b-4339-9e92-2bcd203fb3d2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 417", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("015cc312-e227-475e-bcb7-1e16486b3383"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 455", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("017b388e-9a32-441f-a1f7-cfca0d2b0b14"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 59", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("0193a52e-b390-4c94-a1b3-74094ff73225"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 489", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("01a4d663-045a-4c7f-a606-02d8ce7a3bd5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 9", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("01ba1a48-a8ba-4466-a7e7-9cc868a59b30"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 540", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("01ed43c2-bc4e-41d7-86d6-09bde2266ba7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 789", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("02627790-a69d-4f03-bf8c-b83f58ec249c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 879", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("028a8fa4-214d-4a81-93bc-72b1e3c59883"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 855", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("028fa506-1548-47c4-b7c3-ba7dedab4612"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 972", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("02ed51c2-5c01-4ade-8810-ea8a0048f7cc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 345", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("03315619-8a71-4b60-aa11-c987bee07024"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 600", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("0335e5ef-a305-42a1-b201-fccd3bc3c493"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 559", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("037c5925-4268-48c2-a742-378097b41d38"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 804", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("03e36e26-ba45-42aa-8d99-16443eea72c0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 479", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("042f3762-c57f-4f7a-91d1-4f4cdb824334"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 731", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("043a25fa-226e-400a-88ba-d0365d579bed"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 476", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("043de415-286d-41cd-aa16-8b8d72016a5c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 3", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("04cf6858-2d3f-42f9-a9d9-4bc2d4ef7f99"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 230", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("04d10bb0-1c9f-4615-a1b5-e4f298c5f7f4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 183", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("050684f3-0c1b-43c0-9d28-9d47c6ba53a4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 189", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("050a387a-595f-4ea2-b45f-be1d6144d828"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 527", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("0574d352-c117-4d79-b4f3-a8ae029eb60d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 521", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("060c150a-8e1d-4b56-9e9e-20855045d611"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 846", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("063a5f31-03e0-4c4f-9882-7dd6076c696d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 638", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("06dd9ab2-84b7-432a-92f4-f9b919a75808"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 101", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("081812ed-2bad-4275-8adc-21f88ab14448"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 210", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("081d564e-e719-4cdd-ac80-490ec7cec679"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 941", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("0844e900-19f4-457a-a52c-36dbd6c04775"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 624", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("0863302c-47c2-45d3-9e5f-6e026006c276"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 960", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("08807598-3986-454e-bbb7-37783658327f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 635", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("08abe0b4-b247-4b18-a405-3c420de05d4f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 623", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("095e7a8e-f782-4ea3-a04f-98838b69daff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 178", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("097bd27e-2b8e-42f1-b55a-0440877f8aad"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 432", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("097dd915-b45c-4c9d-93e1-e20c35272719"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 513", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("09a2c415-3701-4dd9-9b30-5ca2ddf54bc1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 591", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("09ba0872-bf27-4dcd-b4ae-fc59ea0b98b5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 999", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("09d2c5a4-d498-40b8-b189-36961a592373"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 739", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("0a306a58-fefa-480b-9ecb-7000b03f7dc5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 955", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("0a6b8301-327b-4315-b871-981a5cf88cdc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 463", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("0a90bc43-144c-4db6-974e-4b4bc66a447e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 867", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("0b1f7f51-5b06-40d4-b033-4ff99b8bab5d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 677", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("0b54eaf2-6c03-47fc-9766-8ef618cd4a1d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 714", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("0b5bb601-8421-4b5d-a6d7-ecbd85e4dff8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 937", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("0b99c3da-ba62-44ce-9e59-86d7a2577032"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 14", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("0bb62ced-702d-4463-aa7d-efb69baac2b7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 985", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("0bc5c8fd-59f0-4a42-94a2-664a1e5d42ee"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 212", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("0bcf17ed-4f32-4933-8436-6749668b0800"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 869", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("0d478b5d-df7c-4773-9c0f-8965c88901c7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 637", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("0d580edd-9a03-4f85-8e30-7fc6750a7616"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 723", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("0d60ce28-e1e4-43b2-b273-b7c79ec1bb07"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 604", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("0d680b61-fc14-410f-a65d-c4add26919a3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 168", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("0d86b1e4-e5ca-4561-8147-1e32d997faf3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 586", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("0df640cc-783b-41c7-b6ed-de36f63910bb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 54", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("0e0c045f-5aff-4e0c-a658-4a3b2feea7e1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 990", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("0e1c37f2-d892-4081-8e86-35843a387733"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 177", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("0e6196d0-d695-47b7-a3cf-90d2576cad78"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 601", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("0eb48479-f056-42af-a0f7-1b97fee4186c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 545", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("0eb9f707-e263-470e-8a52-b7fe387303ce"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 247", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("0ec6eb42-227d-48ea-b673-d8b1cf4a5d0b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 204", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("0ecb1d34-98ab-471b-9b8c-78aa188bf66a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 919", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("0f1f88f5-2b9f-4357-92c8-79cc2cee0401"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 701", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("0f4652ab-500f-4a35-9544-f0b857ba30a2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 185", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("0fe223ee-d69b-45f8-a305-599e2e69e8db"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 567", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("100a48c9-5976-4b19-a2cf-42bbc552c65f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 262", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("10478477-add9-40b2-9cd4-d70ad6466334"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 344", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("1074bb80-07bb-4646-814c-4ca8f31469b5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 629", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("10b4018b-ffdc-4fd3-8761-49081338f51d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 787", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("10cfba80-66b4-4254-9a65-2eed305dd9f5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 609", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("11eea498-cd91-45e0-8cc5-d0a35f3fece1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 978", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("1204f6bf-7b96-4aa0-8e9c-a9005c5731fd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 598", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("123a4b48-e40f-4642-b973-986d6c861b60"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 450", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("12c8e352-05f1-4f82-afaf-ddc5e4ba34b1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 459", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("139a23a6-a00d-4661-b674-70456d16c5fd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 766", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("140220a1-0ec8-41ff-8ec7-a8bce00fe0a1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 106", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("141ff887-57ad-4c84-8671-72f831d8a101"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 70", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("148a153b-1353-4408-bb9c-7ea54f7af403"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 89", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("14e55e7c-5ce7-4737-b03f-d8db38c982b6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 237", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("14f0b778-1211-452a-8db9-5bb62087d72a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 914", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("14fdda39-d65a-44df-88b4-10df6e29d2f8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 611", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("153fb12f-6202-4cb5-8dda-69be034567b1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 456", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("1552c741-df8e-4bc0-90e1-b9eec981d1ec"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 676", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("155c6462-6287-433a-94a3-fa12fa5ca42e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 163", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("1649c398-7ae2-4805-b4a5-c0d8f4e59eef"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 311", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("1656c58f-00c3-49ee-a412-4a638652f0a0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 949", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("16af9c35-4d5f-49ac-8830-6acc17a39f0c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 1", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("16f65b81-0a70-4c1b-a219-d59cd1677eeb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 791", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("179e516c-3eb6-467b-9f36-850cbae7e0c9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 968", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("17f0c061-68ab-40bd-9ee5-67aef6588bd8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 310", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("19095afe-ad8e-45b5-a18c-0d3daeed058b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 287", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("193aaa9d-ede7-497a-b78c-05e630e17fc1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 688", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("1968431d-21c3-420c-a991-618347c20625"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 137", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("1b09e9da-4691-473a-8450-1e3a04168956"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 510", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("1b327d8a-cff8-4365-bbe9-374f5c0e2e76"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 939", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("1b3b6fc1-b5e0-4e97-a3ca-073938f3bba3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 800", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("1b42f76a-27bd-48f4-9814-cf007abca9a6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 566", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("1b681944-4d29-497c-b41c-58d79b908076"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 892", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("1b946ee7-aebe-46fb-98a4-45f6d3386f04"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 434", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("1bc04b1f-6707-4303-82b2-9cd128667efe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 269", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("1be733d5-dd52-485a-a10e-fa4f68488479"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 27", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("1bfa1fc6-baca-44d9-81ff-22b9dd79f56c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 484", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("1c0944e2-0b2e-4acb-a879-8782d56c2347"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 738", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("1c1847ed-201f-47c0-b85e-37416afdfc7a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 433", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("1c3ec914-f554-4c99-8f60-8241d6382f6f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 856", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("1c533a58-0e49-4137-a6a9-b5d59327c965"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 406", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("1ca1b14e-e36e-4468-8316-bc910a56d13e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 672", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("1cc55be2-d8ef-4444-808e-c2652bce4297"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 16", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("1d0107a5-573e-47b9-b967-e68a71c0c7f2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 517", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("1d21ef27-2b16-4a84-b9cb-5b456807350e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 37", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("1d756a6e-33de-4fa9-8e6a-7271199ca8ea"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 169", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("1e21e72d-3fee-4c03-896f-9f4b628ee3b2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 423", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("1e66ec51-692e-40de-8b3e-5990893ade96"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 343", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("1e904b85-425e-4014-b5cd-8cc5364800e3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 933", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("1eab28cc-c4a1-4b67-acd4-ba94e01e76ba"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 96", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("1eae9791-6033-4079-8a11-f6618f85d7ff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 313", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("1ec2dd79-8a80-408d-9884-1932598a5f8d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 663", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("1efb286f-9b6f-4776-93c2-6fd3f1106643"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 554", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("1f369968-05a2-4d7b-9b63-edf658cb2d33"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 502", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("1f46aa19-34a4-4550-adfc-7eb92136f4cd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 584", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("1f78a2c9-4fd5-4996-be0f-42449bf3834d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 729", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("1f7cd4e2-e4c7-4dd9-918d-c4cd08a5f486"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 214", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("1f822ec6-484b-41ec-9ea6-792e7c2a124f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 414", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("1fa95dbd-b5f5-4423-b609-d3eaacc02293"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 259", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("203b74db-c89e-4e99-8706-12cdee9bc6fb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 498", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("2066815a-f5c6-47de-9e72-203a9be35afa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Jean", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("206c5329-b30e-4c00-8421-9ee9229c77d5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 12", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("20931b11-d7a9-4641-b9c2-1e7ce98898ff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 233", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("213cd353-5242-4c9e-9545-4833fdc3d3c3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 290", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("21adae0c-5ecb-4af5-b0b7-2f0fa8b31ee9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 378", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("21e52cbf-1ce9-4f7e-8659-1c283465952d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 155", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("21fad798-ebf1-4c0d-8379-5860adb4eaf7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 451", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("224c0396-fbc9-45c9-9c50-3a9336377dd3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 727", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("22a7342e-088f-470a-895e-00111b64fe13"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 469", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("22dd9c78-b6ab-41d9-a278-cd13fc8edff0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 626", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("22ef5bcf-b05c-4b3a-ae12-299d6d0579d8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 913", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("2318db08-cd62-4658-8867-cc44f4a952a0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 550", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("236455ac-0f4a-4650-9d49-138b10658a0c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 509", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("2387e265-1bf5-4a41-a61e-57af70f4ffbc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 384", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("239ae6c1-f8de-4894-a62a-c56b2bd35ad5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 885", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("239e07f5-fd8f-4b52-9236-3a4bd8f4eec3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 141", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("24533382-7a48-42d3-b7de-530df907092e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 668", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("25055eab-393a-4c81-8e9b-3e0437e124a7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 147", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("250dcaf2-9b01-4998-ace3-ffcad5e59a17"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 831", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("2550cb37-e096-4815-a4b1-5534c0455818"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 192", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("2551d83f-47e1-4aea-b736-ac1ed91a6f67"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 28", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("2575646d-e02c-42c6-8e88-83a2e8ad3c13"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 555", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("257c4911-5a28-4fbd-bd21-15aa39fd12c8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 980", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("259ad866-8a33-43ac-8fb1-e1056eb57227"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 265", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("25e2491e-dc84-495e-9123-7585bcb970e8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 952", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("25f960d7-c4f6-49c5-a48d-886db7ef9fa6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 458", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("264e4033-739f-48c8-b67b-dfbfbde227b3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 588", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("26641704-52ec-4738-ba5b-b154b0605828"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 115", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("266ecd08-c6b5-42cd-83bc-0b5b7f076f83"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 87", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("272706ae-4e45-4c5e-90b4-1b4f171c9377"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 267", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("287ac805-2401-4905-aba5-eb079c912c8e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 312", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("2890e013-57e4-4224-bf9e-38779b3c1959"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 689", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("28b71584-d5ad-4019-a227-ff09152617b4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 898", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("2923883e-4ebd-4e9f-8d02-88281977f384"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 970", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("2989f6d7-2e66-401a-8335-18f5d5f72c26"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 693", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("29d5f452-569b-40e1-a097-3426de72f4d8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 340", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("29e3564a-d54c-48eb-88cc-e4ec38f9f8f2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 395", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("29e52b11-ee07-4359-89bb-0a7281ea34ba"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 606", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("2a4581b3-de02-4f9d-9dc3-515dc7dcb80b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 445", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("2ac8193d-27b1-4dfc-920e-7dfacdfda5c4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 986", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("2ae19cae-581e-42d4-a47f-47c18c489972"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 899", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("2b2ef35d-08bc-4330-8539-93e0dcd7d74c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 47", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("2b3c84ff-9489-4dc2-9096-0c76bd2d5ee6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 576", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("2b49c2ee-2429-49de-98c6-dd33c243d245"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 884", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("2b77a73b-deb8-4e04-ae77-5ea2b65597b9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 307", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("2b7df797-041b-4c69-b30a-0a4b0399f19f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 981", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("2bcbd057-60d1-4bb6-94de-3a98a8c636e1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 815", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("2bdedb01-5103-4be1-ba91-a2c361c97d50"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 772", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("2be2d6b8-ff1e-40c4-86de-716735b6e24f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 352", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("2bf30cb5-1164-45d6-a32c-ff1636c02dce"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 549", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("2c07651a-1618-4d17-a997-c2f465fcd82a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 966", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("2c3bc94f-0ee2-4b8f-86ff-f8d95a087eef"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 370", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("2c45ae55-5548-4806-9da1-785902b7ac31"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 718", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("2c58e566-ffbc-486b-9de2-f00dc790f28a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 732", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("2c5edacd-b933-4045-a295-b455e543e1bf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 235", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("2cdd1633-73dc-41d6-a8fb-d0b67c68b70e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 556", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("2d09973d-6c8b-40fc-8fe0-040925fb21ec"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 19", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("2d576a7e-dee4-43af-a15d-5f1a16afb79e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 501", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("2d8266b1-fcff-44f2-b245-b876716bbc20"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 219", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("2dfe5466-0075-4675-add9-3d04255c11b7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 602", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("2e30d790-eeb7-4d0a-9e2c-3d4f5e69aa4b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 461", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("2ec7533d-d6ae-4a6d-a999-e5da5c163667"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 705", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("2f1dd7b6-9333-4654-9b58-e355193df36c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 795", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("2f8e1ca0-b430-46b4-a570-51e4ba3a5cd1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 325", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("2f9f07f0-9fe5-449e-be97-7b2404622fcc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 90", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("2fed41d4-db6f-41bb-829d-dd97d0f739a3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 331", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("2ff41a5a-4ec8-4339-9520-a30e7d350a14"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 962", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("2fff93f3-f591-46ab-a415-ff80739aa1ad"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 243", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("3003b270-d490-42e3-bd52-c59ee955a165"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 64", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("313ddab0-0277-4bcb-988f-42e2b9b81351"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 483", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("315dfcb9-4865-4cb1-8ff9-74278ff1d463"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 402", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("318e64b3-04af-4943-a3bf-053c0472563b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 446", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("3199b883-f987-4af0-8bf3-d2383f86f104"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 302", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("31b73020-5b3b-4f78-9270-a5f395c1f78a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 660", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("31eaf3f3-5a9e-4a66-a545-f971625dcca9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 614", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("3230d263-d6f0-405b-b938-96b7082af956"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo ba lỗ", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("3239f21f-e6f5-4bb6-8c57-f5ff1dcc2233"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 946", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("3308ad1d-66fc-473a-b705-f4fcc0d9b025"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 511", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("331323a0-b27e-4465-8aab-b021417cadab"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 694", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("3414078e-1fa3-4d9d-8c2c-f8a1e17d2e92"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 58", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("34473fa7-6a5c-4c8c-97bd-80ee86132e46"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 348", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("3466d10c-0c03-47c2-840d-98e591d84a4d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 288", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("34875e37-2256-4c57-8073-db0994417c0e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 232", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("3527a85d-f86f-4088-920a-3509f4649f2a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 871", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("35565fe6-5406-4ce0-be76-44dfa5c06cc0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 982", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("35f9603f-ad23-450b-b57d-80866c8984ff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 319", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("364032c3-0a34-45dc-bc38-a147b32936a2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 925", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("364c5290-0c27-414c-a7ed-ca5c6db0c578"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 314", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("3694547e-6980-4e07-b940-4e615e13d071"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 454", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("36a50e9e-3721-42f2-824a-658970cf282b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 1000", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("36c6dca3-e618-4f3b-a6f5-395c8005d345"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 135", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("36feb3ee-e72b-4423-a1a0-35d027f76ee4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 801", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("373d838e-71e9-460b-8823-02fb9884c260"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 860", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("376b2bb3-0696-4b2a-908d-ab39b64950eb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 590", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("37f76afb-12b9-4df3-9158-5f33ad339429"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 819", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("3917c35f-40e4-486e-9ab4-a9f76c95e9c0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 702", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("39f371dc-96a1-4152-a6c0-fca964180b3b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 734", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("3a36d5ca-16b9-4ba1-9787-db577888d3df"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 467", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("3b63d036-8ffd-4126-a69c-cae61c504f2b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 21", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("3c60878f-5cdd-4957-9daf-b8c87ccdb08e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 291", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("3c962cf9-0831-4684-b6a9-739c721b7b4e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 15", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("3d27b76e-e78b-4bdc-8fdd-886bea3967ff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 711", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("3df7bb52-7dae-43fb-97f9-face4689b495"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 419", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("3dfdb3b2-9938-46d6-bb0d-0f9177c4b7e6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 645", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("3e38d868-c122-4680-8db5-479a23f6c648"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 874", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("3e690769-d1ce-4e96-bb7c-32130dd2400b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 546", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("3e6dd6de-c7f5-4ac5-8603-df9d500cf1fa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 695", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("3e90601c-1128-480f-865a-6de53ec32b68"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 437", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("3ea1d47b-30e6-42cf-9795-4b51a0816eaa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 488", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("3eb68680-fea5-460d-8606-f255dc7e6fbe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 174", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("3ee3fe53-f4ff-4140-8f08-56836151b423"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 890", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("3ee6bb4e-fc42-4260-add8-43adb11c4c03"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 18", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("3ef0622d-d442-488a-ac77-e89399a82e27"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 427", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("3ef69288-ae15-4b83-870e-6de86b4dbbfb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 211", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("3f1b0098-8c0f-48c3-849d-20975bea5462"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 797", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("3f36c369-74a3-4faf-b90b-239f15f3358b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 165", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("3f532a59-1af7-4b43-aabf-efee2ceb300e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 670", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("3f5d3814-6cb2-45b8-a91c-3a24dcee0eb6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 164", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("3ff8df62-d2c1-488a-bb72-3b57c45d0b44"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 205", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("409fe3d7-aca5-4e76-bc69-d5238bb844bb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 224", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("40a15976-9c54-41d7-9674-6689428ce4af"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 160", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("40e6401d-bd39-4ff2-9fca-7bbc7a2cfec7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 579", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("41335979-ac35-4dca-a1cb-e6963a51ff43"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 653", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("416ab87b-7df5-4874-826d-0611b1c23815"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 887", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("417f50a9-a8b2-4362-a27f-461b5c8c8021"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 422", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("4184d49b-a26b-4cd3-9179-57c675089f91"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 226", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("41b7c1e3-1eb5-4f2b-b48a-78026f3b409d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 671", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("42c910f8-be17-4d36-8919-4e4d7f48cf9c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 665", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("430ab026-d342-464f-ac9a-34ffc1dbe0dc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 92", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("4341fafd-e296-4a33-993a-0fd26cbdd80b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 525", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("435d8e88-57fc-4a66-a7f4-0152c1680a7d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 778", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("4362b98d-a149-4c9d-8d68-4e4a09bb4441"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 253", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("43cbf14b-cdc8-43ba-b465-da39baac5dd5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 523", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("43e7e402-9896-4a77-ab02-cd3ba9a8a357"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 491", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("43e7e88a-bc6d-4c74-8ce5-28e8ade14034"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 360", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("43fcdccf-8b9c-4d14-b148-f6cae4a4b963"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 749", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("445b8e3e-77c1-4bd7-8c2b-bb97a93e13e4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 526", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("44bf407b-e31f-48ae-a1b0-55a5b9bf4eb4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 657", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("450b2215-96ed-49bc-8397-d3c88c576eef"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 30", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("4515d34b-925e-4f78-9773-31b829972e42"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 615", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("4532892a-0870-4afd-81a6-4515ff88c5f0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 320", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("4570deec-6c25-47cf-b15c-1cf3d065c52e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 261", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("45a6c19d-57b3-4826-a64a-b8edab42ca4e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 944", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("45aaa5af-94fa-4bfb-87a8-02211f8249db"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 908", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("45b5ef40-047b-4605-af60-f1b551bc3af8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 853", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("466b9be9-0cf3-40aa-937b-26d141c70928"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 490", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("4670f28f-fdd9-4943-9e22-a897e06b2c69"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 159", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("467db834-a2ca-44d2-9a55-6e0ca917105d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 173", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("46addd42-0733-4ad4-b9be-e4b061dffada"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 143", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("470f517e-6b2b-497c-a3c6-65a5fa372104"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 31", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("47415b6a-4c7c-41d9-b996-ead0059c33ed"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 704", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("47b70c6f-5405-4dad-b1f8-f61f27fcbd13"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 368", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("483ebe77-5cc5-4086-a9fc-559ce830ea96"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 715", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("487f6495-5253-4872-acfb-3ebb4df1b77c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 119", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("48e2f30c-9992-43b5-b1f0-7a0892f05cf5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 612", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("49534404-06b6-4906-86f3-21c0c0db83bd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 575", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("49764aa2-f68b-4f9b-ad2a-a7665b60e66d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 238", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("4996e6eb-4927-46c9-8b1a-1e9474aa632a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 537", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("49bbc92f-8f9b-4b73-b9a8-76ecfb7adef3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 176", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("49f3eda9-fc08-4134-a596-05f5734d69be"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 905", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("4a414701-e27c-413a-90e0-fe8c08f9986e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 341", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("4a4ffbb8-0d65-471e-a825-ea86e541f395"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 674", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("4ac94c60-8d25-4a12-819b-c55b051ced76"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 128", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("4b24490b-fab2-410a-96c0-d9aa7b6a150b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 904", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("4b3567d0-560f-4610-ab7e-6b40e0d73aa2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 162", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("4b3f4445-beb3-409b-be76-ba97e6e0a5e7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 299", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("4b5ee6da-470e-460f-8e3d-cc57e40b1df5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 613", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("4b833a4c-d9b6-4863-b6cc-f6a9609837ac"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 435", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("4b8a9a7d-eb13-489c-b6f8-11581fedba13"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 976", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("4bb54757-4ba2-4d71-b5fc-c89af90fe885"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 569", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("4bd42f2b-4d9c-4a4f-b780-6e6a3af285fe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 881", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("4c224493-a44a-465e-ba66-6cdfc91549ef"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 690", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("4c5a801d-470d-439c-bd05-9f4298fde6b2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 136", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("4c6770c0-ef39-4fd8-aacc-c60a334418a3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 263", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("4c7755a9-d9a6-45d7-a139-2fc77809b690"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 411", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("4cb61ecf-4aef-461d-a202-fad3612b1ae1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 844", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("4cf1da69-c103-4087-a72a-5bc54f5bca0e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 692", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("4cf8a4c1-33c8-4908-bbfa-15bec7d1ac21"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 622", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("4d83b28a-b592-440d-af52-8eec715f16b8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 346", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("4de7e37f-2b45-4ca1-8306-531b40496621"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 992", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("4df02cb2-66f5-4248-819d-8321004fe5ff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 679", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("4e46f91e-d463-4cca-9e04-84565f9c40a7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 961", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("4ec27d0d-aa59-4ee2-bced-266f83ee5c11"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 779", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("4f020dec-8928-4c05-923b-200539b248ec"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 52", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("501c2d4f-a2ee-4946-9dd1-a19fcae36373"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 208", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("5061ac8e-375d-4460-b58f-40b5bf19bec0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 475", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("50668b24-0ac1-4213-b7d1-82bf888c0bdd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 877", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("509427db-c367-4589-b272-31a0626af6d2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 687", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("51021d70-49ef-4a8f-956c-98a9ba18cb38"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 347", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("51641fe8-2eaa-4999-81fe-37263c12bcfd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 543", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("516ef6d1-9abf-44ad-8ea1-f9274c6a9285"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 149", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("5174aef8-a675-4d93-90ca-096c9d878cbb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 965", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("5192b952-f76f-4312-83b6-a24560289ede"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 60", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("51ce5753-8707-4e6a-bfda-ec03ddf1d936"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 786", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("51f466d2-920a-4c32-a0bc-e18044fe31ae"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 385", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("522b8ce9-2553-47e1-9b83-a1a7b61b6acb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 565", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("525bbfc5-9aa1-48b1-b794-71c614ff640c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 334", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("525e21c2-42a0-4554-9f63-311275be819a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 29", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("528544ab-819a-465c-8bb4-422bc5dbe326"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 309", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("52d01646-c72b-4326-aaa0-aa95ccd1608b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 534", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("52fed89e-322f-4c1e-9590-2e3ac78b9d73"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 785", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("530b1b9f-5a07-4074-9694-92f3dba4ee70"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 707", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("5325196d-a456-4f49-a119-1bba100f7405"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 102", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("53421d8f-4959-4f87-9621-4ef24fbd376e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 270", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("53489384-80b0-4ea5-9c80-10cd399b4043"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 121", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("53a48969-4c34-4603-872f-37b29e9b874d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 863", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("53dca670-a4fb-4059-aca0-35b800002888"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 425", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("544c85f6-785a-4170-92eb-53f35df64549"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 578", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("54517134-9c4e-4adf-ae9f-cf7a02d509e2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 737", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("5485c083-3ac4-4eb9-a72b-fb564b718bc3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 49", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("54f8fd27-090c-43bd-ba09-61458bf69b63"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 481", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("5506a3f9-7ca7-4224-a365-d9a72e782cbf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 608", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("5555d51f-56b6-4611-b76d-5d571eba96fa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 342", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("556c1ca2-9435-46c1-9030-e6985e2c5760"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 633", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("5576dd2c-91b7-4dcc-9cac-d4e5c47df3b6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 316", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("55b16007-e1de-43aa-bbe0-8de58b508c04"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 837", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("55d77e7c-6ec2-4ee2-81f7-a3bac95d6167"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 272", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("55e68342-b6b8-4319-844a-2244d4980411"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 82", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("55f547ba-023f-460b-93b0-f226995df43b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 113", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("560097fe-adf2-4284-8e37-6aa7a2c6dbf1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 957", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("56d0b4ff-925b-44e2-bb8e-a1d4d7c38887"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 332", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("56e88b42-bc0b-44eb-a0f6-836a6e008f4d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 743", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("57534f8c-0ace-4217-98ba-470733e9f680"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 421", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("576f51a0-0604-4b4f-a0dd-b1b0abd52d0d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 99", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("57b28f9d-0608-49bb-8bca-c6ad0fc0e8d5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 396", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("57ce1bb0-0803-40c2-9ef0-9141a5ac8ae1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 175", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("57e3adca-6899-43a2-985c-58e12128d0de"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 249", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("57ef7c8d-7440-4dc7-8555-612ac62ae9a7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 932", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("58127bdf-9e2d-4efd-ab17-0105c9bf5b0c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 144", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("5838afe5-7823-4799-ab5b-6e0bc3d305b7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 833", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("58a54ec7-bbc5-4892-aba5-f7611aef34e6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 391", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("5975b57f-7910-4ee9-900e-91abf82db9d1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 13", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("598d5478-5412-4c8a-bf7c-4f6c4d5b8439"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 661", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("59efe9df-1db5-4618-a7f0-40e8286133a6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 239", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("5a23e9f5-bd18-49ab-8d32-50145dfdd7a4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 847", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("5a3d93d6-97b2-44f4-8d10-7005ffe04f31"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 480", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("5abf63c3-e795-4517-84a6-4a4e28a3c943"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 902", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("5ae1f7de-c809-45ea-b9c5-ca3308712f2e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 132", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("5b472745-1469-4945-aed3-91ab6a74525c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 646", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("5bf7292f-4a5c-4aca-bb4a-4b9e26fe6b67"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 294", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("5c0b0580-9ec5-4228-98dd-945747a55281"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 32", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("5c7d0cf2-4f6d-41a7-b5d1-cd668504c23c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 335", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("5c8c9cf6-2c60-43e4-889a-2fd443d680df"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 398", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("5cd8f50e-5f7f-4494-83e2-db8533a6c5a1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 166", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("5d43a4d4-1c7f-40c7-9da8-849e005afbf6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 495", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("5d715f0d-7380-4a63-8668-c90ace749137"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 938", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("5ddfe70a-7a87-40bb-88b6-580faf78fa27"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 975", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("5df86f0b-ae98-4ce8-acd0-9c32f000214d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 725", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("5dfe15e5-6417-4e38-a341-6440a61e2302"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 830", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("5e304d75-d5df-4b4c-b07f-da5208b86e8e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 236", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("5ebf4e05-1536-49ff-8573-9b17b4e7f422"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 300", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("5ecfa55f-3e31-4df5-af6f-c8e2c7741ce7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 709", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("5f3b8728-d6b9-41fc-b769-58acb17c617f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 866", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("5f8d48cb-720b-4e38-855d-fdfc14a47edf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 599", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("5fa0760c-991a-422a-84e2-60671d06106c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 607", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("5fe3e791-ade6-49bd-8340-37610888cfb5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 218", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("604b775f-f227-4e90-9c3e-92b7cca6805c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 883", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("60ed96a5-9048-4651-b994-5743d8b99063"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 442", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("60fa13fc-336a-4635-b92e-f4990048916e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 337", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("61e6f7f1-ed37-4aca-9af7-24c1a3dcd0ed"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 617", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("62182afb-b2fc-4da6-b256-e59f58b9853d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 896", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("6242cd86-de4d-421f-817d-06fc7c2ee64e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 167", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("6245e10b-4887-48d7-885e-cc6c9eab860d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 943", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("629616b4-669f-4649-b152-f2a85f6b408a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 284", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("62c32e5d-2460-4645-a063-57a6e9314156"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 987", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("632029b4-c6cd-4ed7-b569-14011c3185f6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 379", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("637d3928-3e8b-4035-9804-818693d2dda2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 759", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("638829ba-52ae-4542-9c9d-9d8c6e8a72e1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 353", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("638b335a-d0b9-4f05-bc88-96cee722f339"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 306", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("639d1ff3-0a32-4aec-8a57-b8473b886735"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 195", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("63bdf074-d053-48d8-b696-d3f1ca26e121"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 388", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("63d7f758-4af6-4c2f-a942-9cf81001c32b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 364", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("6415f396-e63d-4040-a278-3e1f9f00b18e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 532", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("6445d9fe-d14a-41f1-a15c-6f04b3f9f0bc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 760", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("6447731a-e697-4bbf-a855-cf87e52eed78"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 36", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("644be0a3-eb9d-42fa-891b-3c365816bad0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 441", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("64619a1f-820f-4bdb-bcd8-37cb98021ecf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 951", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("64c29dfa-69d8-4b07-91d4-736c35503801"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 486", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("652f1e5b-e002-409f-b6de-a531541da05c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 256", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("656fc023-5c52-4ed6-b9dd-509ec50fb373"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 86", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("65875264-03d6-416a-9dd1-0c9bf0f8e7a0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 940", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("65a06769-fb93-4493-9fe2-a063ccbfdb3d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 826", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("65b66fae-07ff-48db-8d8c-85e8ca491348"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 806", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("65cd684d-6541-4934-b501-c6f3583cc740"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 642", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("65d01fc1-4c45-45a5-bc98-ed8f6e15e224"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 915", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("66783eb1-6ffd-4594-8ab3-41207336c0ba"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 55", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("6723eda4-b08f-4bb4-8cfa-1f93ff0205bd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 973", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("6726c32b-9f4b-4cc9-90e2-ce3d060655a6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 564", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("676439ef-56a9-41eb-8a67-9238573eeab7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 466", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("67785d39-e19a-4737-a786-d3283fe57291"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 967", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("67e07631-1ead-4d4f-bb59-bf55dd53996d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 956", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("67facf06-5457-4e06-906a-357be76426d2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 508", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("685ccdd4-562e-48f0-ae48-75b811f155df"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 41", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("6894ac4e-0ba1-454a-8871-68cf5d6539d2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 953", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("68f133fa-be03-4454-9a9c-8d37dd470a78"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 207", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("6a7665e3-5e5b-4bdf-9a90-1499ccc28d39"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 625", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("6a7b317d-a6ad-40ae-9543-8d6b3975cd49"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 516", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("6a9bc595-b195-45d5-ad39-9b1c5398f20d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 131", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("6af79536-ba07-4808-a775-69bfd1a051aa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 993", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("6bd20066-f477-439a-9e77-05f4973be823"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 758", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("6bd8becf-6089-4697-854b-dd5fa2eea0e2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 257", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("6c675fec-564d-4318-a211-bacff33465c0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 190", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("6c933afd-a3e2-4bd7-b8c2-5f3dcad0867c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 851", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("6ca1b2a5-9add-43c8-bb0e-0dd9fd788298"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 906", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("6cc74414-3f54-4649-acac-2b5d521f5b9d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 443", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("6cfeb58a-8130-4ada-8034-abf0b7459c96"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 655", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("6cff8ed9-4c55-43e7-8dfb-3e6c6ff32202"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 928", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("6d880406-97f4-4974-ad48-1b31a6e93a5c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 664", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("6d8ae680-f737-494b-a38d-0fb0e197fdff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 180", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("6d9d825a-9315-4ff3-9267-0a9f3c640690"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 792", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("6da05a88-7549-4cee-8937-d91c35df877b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 506", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("6de06a45-84f7-4648-b1ab-f64e13aff340"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 227", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("6de22dbd-1dbd-4661-98f4-89af0ef3c8d0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 696", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("6e41b21e-2a6e-4a6e-b91d-bc908283d387"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 426", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("6e540d42-2a9b-4536-a922-2221178fcfe1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 410", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("6ec4322b-1a6f-4be5-91b5-3ec9082b94ef"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 834", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("6f5553c4-fb5f-410f-9754-b8e504f25d6a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 254", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("70308084-9506-4f36-8aea-d74202f56dd2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 428", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("703814e8-4395-467d-aba5-007cf480582b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 991", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("70ec983a-1c9d-461c-b357-c5a18fa6fd1f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 339", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("71143a3c-9101-4651-87a0-9bbb9999756c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 124", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("711c40cb-f8f4-4855-b6ec-1f9cafba81e1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 367", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("713b7ab8-901d-4b0d-a9a1-cbd9b217467b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 630", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("715d3620-4bf9-4a21-89df-b2f21a14dcfc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 350", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("7176cb15-f7ff-43dd-a46f-112f46443592"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 728", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("71a7e418-85e8-4faf-a087-b52493b11df9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 478", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("71e886de-7d2d-41c1-8a8f-ae01917a1e47"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 587", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("727b925b-5439-4ca6-8942-432c0fe0f167"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 277", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("72813165-2257-4570-934f-96d5c5b845a8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 105", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("7290e6f7-c82f-4f50-b138-5d75957bcbc7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 472", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("739faf12-d12d-4fb3-b5c9-5a4b95a9c653"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 181", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("73a0c823-4cb3-4d56-b53e-3c31620b53d0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 654", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("73f7e24b-dc69-4a36-9c30-30da023816a4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 327", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("73f8ca9a-9100-4478-8915-f50ae152eb35"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 538", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("74b92096-32f0-42c9-8a6b-e1f313f50365"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 722", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("74c01cd3-7b16-4123-a1e9-2333011f9ab6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 108", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("75062031-afbf-4213-b000-8ada8c7ddbfb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 333", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("75684b0a-5c13-469c-8f70-c8c6ce2caf6f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 420", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("75835334-9b89-4f1b-8043-133badb2ba5b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 399", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("75a83287-52f6-4477-81a4-95b84ce41ac4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 854", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("75c06dbb-a1a4-4385-80b5-2dc52c195768"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 505", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("763fecae-43a7-4c98-b6fb-a17ce78816a1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 125", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("764169a1-cd06-418c-b559-4e290076bf86"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 627", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("766feb84-a03b-421f-8c71-cc06077b59eb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 39", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("76b533f1-4ec3-4622-97ac-460162299336"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 888", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("7708a33f-981a-4b82-b9a3-fd93fba37705"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 271", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("7713d1d7-eff4-4667-a466-2b9bd4302e47"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 244", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("772c926d-a2b9-4f6b-9bf0-bc7fdac32f38"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 134", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("77382003-9a55-4844-9344-a84514010f83"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 945", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("774522cc-5073-497f-bf66-cc4928169c6d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 529", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("776f256e-f848-4600-aefb-ced9d3d3c886"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 374", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("777bb199-5c3a-44a5-a93d-ebb4dcdc8634"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 886", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("77b629e6-0d0c-46a7-8a28-a91ff9548cf5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 122", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("7801d6e2-9dc4-462c-9bcb-160011a10e74"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 726", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("78a08cb1-d370-4069-a2d8-1a483affc27a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 282", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("78d61082-3301-494d-ba4b-882d17f28e5e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 496", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("7901e028-2c57-4aec-8df1-c2702c05ed50"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 862", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("79672253-fffd-45b8-bd0a-de8acbbb8779"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 286", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("796a6b9b-0506-469e-a123-0dc59c3d10a9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 911", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("796b3392-016e-4c7a-9384-19fc5127a932"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 351", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("79d5aeae-b718-45fa-97e2-7b58e04b1f2e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 107", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("7a049d6c-c00f-452a-8754-71f00f127f7e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 930", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("7a2ebf84-c762-42d6-a2db-0091327366a3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 91", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("7a2f1271-63d2-4593-9c55-9c31a2738a1a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 118", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("7a419f74-eacb-4dbc-bdf0-6644748fea02"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 807", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("7adff1a2-3ce2-423b-814f-bc38b70a5ba2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 994", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("7b4ad072-2f90-4223-9a90-7e2d772052fe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 209", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("7b59938d-e7d6-4d62-9469-a62c4206afe4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 88", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("7b7c326f-b5d2-4299-80dc-40755d16fcf4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 493", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("7bad3af7-3907-475a-9c9a-db5465ef760b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 203", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("7bdaa79f-5ed0-4880-9545-060873cf0fc4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 222", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("7bfa90bf-5fa7-4a3e-92ca-d8dc91996148"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 699", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("7ce0621b-3fba-4dd4-80f2-9da519fb59c4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 444", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("7d08134c-8667-4e0c-8d93-2a8176843e66"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 683", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("7d2d736a-fac7-49b1-a9cb-15733306081c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 740", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("7d33fccd-7847-42c6-ad86-1459f9ff2a56"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 750", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("7d6c84db-842b-4b07-8bb8-6d74762b3ec1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 17", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("7d6f5866-72fe-4f33-b9a7-34422c96c8b8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 63", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("7d83a45e-25ad-4623-9d4b-0f0e8cf99e22"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 229", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("7de13385-ec97-4668-af55-8cf2848c64e1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 216", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("7e0171ed-b3ab-4ead-9b90-021529dcb922"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 295", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("7ea3475a-a5c6-408b-8a21-ceca74885335"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 393", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("7fc8ad30-a672-4093-9952-37d79b6e7d11"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 321", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("7fd4c0da-b48d-478d-bbdd-f56b627de511"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 926", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("7fd6a041-098c-4fd8-9595-f905f6c6a5ab"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 818", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("803f121a-3883-46de-84ea-8cff8419ed30"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 116", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("80b912d7-ee4d-4695-b07f-4480e2ae61f0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 73", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("80cdd3f5-a2f2-45d3-b7d9-a411ed2f5e40"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 110", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("80df666c-d900-4fc3-a8e2-1ee68f124b8a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 920", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("81128d89-9cdf-4e39-8e02-f9f31d046375"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 643", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("813b8931-30bc-46a9-bede-b25bf3fd9979"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 716", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("81457b21-ec33-4585-b2c4-9ec67ca811c2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 720", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("819f16fd-6d12-44ca-9666-26e8339e14a5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 328", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("820bb24c-f4aa-4459-8d53-b92588f3e3ea"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 996", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("82976a77-9747-4b38-b1bb-264a5a40b7d9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 504", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("83e2fabc-5085-489d-a878-db0a08f8f41a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 126", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("83f643cd-feb3-4bfe-b631-de5be0919e50"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 841", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("844873b3-4b74-4dce-9c85-f67fad904259"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 742", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("84d752a1-b5b2-4ac8-82ce-9719039006d8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 79", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("84dda86d-c430-4976-b3e6-553e23c785c5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 595", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("8508d38e-df02-45db-8f5c-76e5352e3668"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 363", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("85170250-206a-4bf7-994f-e2a5d64cb8f3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 161", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("85749ae4-dd98-4ee8-9fe0-4cfc24e168e3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 816", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("8653b9e6-17ea-4823-879d-14eb0ad6e863"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 875", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("86845cf3-4840-4e3e-939b-81cc8d9eb1e6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 95", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("86ba9cc8-54e5-4463-9f88-a5e3be357e27"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 684", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("87635baf-b4d7-4e52-a4f9-9691b8d80f60"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 26", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("87c73524-7aa5-4626-a6a4-b9ae0e6f2810"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 104", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("87cbe09a-bcb7-4882-95a7-06b9c82ff85f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 376", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("8802da39-81d9-4dff-8d68-2856cf3e0e14"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 67", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("888d0ff7-88a7-442f-8fc5-98da3da3675f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 436", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("889529bc-7328-4a6a-8d14-ae65ebdebc37"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 514", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("88b36b4b-3dae-4e88-b9a1-4b87824c9453"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 648", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("88c78cfd-d3da-4235-8ffc-b785a350a0ac"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 298", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("88ed681c-4a01-4417-9007-51a1021c2a03"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 741", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("88f9dad1-8b41-4365-806f-7b7111ab3f6b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 281", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("88ff89a7-3e59-42fc-919f-9fc28862bb0d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 413", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("890b3147-0f2e-4b66-b57c-158387bb871b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 213", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("892e913b-db15-46ca-aeb6-68943154a1e6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 998", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("89ee4b2e-acbe-4ad7-9acb-106f8becfa21"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 936", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("89f7aee9-c447-4eb3-872a-908abbf31705"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 38", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("8a155e06-d9bb-45a7-b8d3-17794662ce68"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 574", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("8a2564cf-8f89-4114-860c-e009b8750294"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 775", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("8a8b1513-b769-4a6e-abe4-ba5dcd4a5622"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 416", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("8b2b4667-be05-4455-b218-41ce9b44672e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 790", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("8b997419-4321-4a9d-a64f-f955d06d6b26"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 56", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("8b9dffc3-e92c-4e98-87f2-56918b51d236"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 817", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("8baa06d6-3e38-4d9f-819a-8ac40cfacb6b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 20", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("8bad526a-4208-42c2-b834-b772918bb8c9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 266", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("8c7fe439-9165-47a1-9cd2-2de369590962"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 616", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("8d991abd-7e9d-470b-89cf-bb88cb3d38be"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 292", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("8e21dd01-4ec2-4f76-80b0-0394ffa5615b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 356", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("8e2a763c-7885-4b7d-a98a-7ced15284a63"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 822", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("8e81caed-2659-4b16-90b2-82b0e5be66c3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 408", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("8eb04526-e949-444e-8608-eb005d802d65"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 829", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("8eea1e42-5e7f-4d87-92e0-6d49ac997b6e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 551", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("8ef359ec-94b7-4ddd-98e1-c991193674c5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 323", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("9001d97d-fe4a-4668-8a25-2376e8437d8b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 580", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("900fb668-825d-4f96-bb5a-c6ee710a6d52"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 821", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("90400d60-fc5d-4f63-b623-350bb09e454d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 61", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("905ef35a-d936-4c54-a5cc-081616067577"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 403", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("9088b5c8-0872-4d47-9f31-9490f6ae7d03"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 225", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("90ca655c-132f-4b0f-99d4-2b1e8e9768b5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 746", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("90ec2ac2-60d9-4f1c-b160-37c57a1fa8ed"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 675", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("91a4586d-27f7-4042-8f9b-66ec467ecf5d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 187", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("91c7c99b-69ad-4f4b-b1ff-a4ba114388f7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 100", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("926408d4-71b0-497a-a87b-41dcbb7f914a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 528", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("92750c25-11bf-4fe9-bc98-5561d4da866d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 541", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("92c0c4f5-fe60-4980-9ddf-30d26731c7af"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 75", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("92f29657-7fc9-4c5b-b134-82c25972b0bb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 301", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("9315ff6e-0d5f-45ab-88d6-d639ee3d4d2f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 592", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("933520c2-4364-4768-a922-215fd21f4862"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 803", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("93792023-c5de-405c-ac91-8a9e9cce5f77"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 530", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("93fb6997-c8b1-48e2-8a66-38b3d5ec2fe2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 250", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("94ff892d-e480-4237-8eed-e3162302948d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 788", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("96a39fa8-20e7-4a03-b59f-273aa710645b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 142", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("97546efa-c2f8-4f7a-918e-b03842ced9e3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 770", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("97875e6f-f35b-4ce8-ad55-e1a8a8dada91"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 439", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("97dc441f-0fd4-4611-bc39-c102c889bb86"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 796", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("981d8c0b-687d-49f4-bddc-e5022b40bfdc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 390", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("9928650a-f5c6-44a9-b538-b31d629875e9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 228", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("9983eb85-76ea-4289-acbd-29774bf0f563"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 836", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("99afd4ac-d8eb-48a6-a519-51938fab8163"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 809", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("99b7a073-e830-4f2a-a106-f73cfa1f3192"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 868", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("99ccf9e0-0fc8-4010-aece-c1a48c0e02aa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 873", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("99ddef43-25fe-4df0-85d7-b1d641fd5b4a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 400", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("99eeac90-9446-4d3f-8d27-1a83f642d49e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 405", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("9a11b158-1bac-4286-8a4c-fef7e807a84a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 666", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("9a470eb9-76eb-40bb-8da7-c8f13fee9ea9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 336", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("9a8d0c1b-fcbd-4637-b436-fbad4e2dc9a0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 33", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("9aa571f5-c96c-4e45-a780-08f6f6900604"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 594", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("9aa87f58-c289-4a89-9586-83f20e48163a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 747", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("9ab06aaf-8f1e-44bc-8c19-b948d1184995"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 500", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("9ac0d320-ac8c-46fd-9669-8e7468fe3ef6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 278", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("9ad04395-09c7-450f-a2db-50fdf0c823a4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 682", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("9b3a5da1-b39d-4c2c-ad10-2235717165ce"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 893", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("9bd0e686-3538-40d5-8a61-f7bd2598c5fd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 859", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("9c14d86f-91d9-431d-b706-5e642d3388d3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 2", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("9c1eb44c-9788-415b-b531-66e1651c9921"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 279", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("9c46631a-b16f-4450-bdf2-3c1769d14211"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 258", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("9c6f0afb-5d5b-4e36-8b40-0b9eb03fe6fe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 686", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("9ce4e365-bb9c-420d-ad91-dc80aa1ae54d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 989", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("9de12d88-ef92-45c9-bb6c-f7850711ba07"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 717", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("9e24fc72-02cb-4d9a-8d63-ac4210cec5c0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 188", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("9e90cb5e-6037-460e-b3d7-69643a7f5bf6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 813", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("9e95485f-85a8-43bb-8a48-791199138c28"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 366", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("9e987978-c53e-438b-a88e-38e4cd052aa9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 97", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("9ea19486-34a0-4477-a27d-be64df1dbb21"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 220", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("9f6e96dd-8c0e-4749-a5cd-0b8b27c4b259"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 322", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("9f71ee90-915c-4192-8311-c53ff103d594"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 735", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("9fe30176-76e5-4011-92bb-88881f8d6026"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 912", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("a01f087a-4ee8-48d5-85f8-f9369ddf8da9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 196", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("a061062f-681d-4d77-bcb6-364c52ca6371"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 148", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("a08abad0-be72-4bad-9f1d-fde9b34ad86d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 621", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("a0bf6814-a46f-4e28-a97f-948f699c1465"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 57", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("a0e5d054-2424-44d7-bcf6-f144b5fd7c4c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 193", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("a10e39ab-da2e-4945-8994-747d4dc6e4c5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 23", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("a139980c-8c2a-464e-ac50-d901defe8da5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 296", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("a1648dc7-2c74-4458-a8d5-92b985447ee0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 767", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("a16b8ac1-7c02-4348-8a84-0bdc8c7803d0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 553", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("a1a52565-0276-41e0-85b1-69073259b886"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 83", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("a1a9c981-aefa-474a-a8d5-96aa4b4d029a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 429", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("a1e26508-fdd8-478d-b615-ed18b0eb0e66"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 857", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("a2068bdd-30cc-4f29-89eb-9e7a822de0d6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 644", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("a2187b15-27a7-4a86-b4e7-f052f3b8a405"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 199", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("a2326fcf-ebf9-4009-9793-f4479b45f76a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 372", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("a25639f3-de77-4781-9864-fc738056e3ae"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 593", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("a280a349-d949-4b32-b4e2-35081584d257"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 650", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("a28f17ff-0044-4711-b253-16b329e1d22a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 900", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("a2fd7ab7-3411-41aa-95bb-4538c07b0297"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 273", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("a30738db-3308-4a5e-8c04-99a9fbe909ff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 558", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("a3288382-8278-4a0a-a12c-6fdefef05e22"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 632", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("a33e25ed-e434-44a9-9771-d8a19adc7e0e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 305", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("a387df31-f6da-45c9-81f2-624d747b0edc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 781", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("a3bcb21a-e39c-4c17-8b51-1af00f3c5ae5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 673", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("a3dbe8f0-f284-4f61-a74a-2372944c171d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 362", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("a4624466-4d80-4f99-a72f-0162705f4402"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 140", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("a472057f-599b-49a3-9ee0-980930961524"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 25", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("a4a8735b-c840-4106-b13c-4f544dc25e0a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 910", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("a50ee7f4-803e-49f0-b931-0b44a00174c5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 577", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("a557669f-a585-4460-8265-eaf36172876c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 570", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("a5e6c67a-64d9-4883-bb07-2445c78ee937"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 977", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("a6383c5d-1b90-4ef9-8a60-3d26ee81f646"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 153", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("a6612650-b22b-42b8-9460-3be6eec7a052"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 460", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("a6ab3466-4817-4e6e-9882-8e96fc63660d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 832", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("a7637460-dbd3-4b15-ade4-9b9377c66545"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 698", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("a77c13a2-1f90-4cde-b065-cccb3661ac50"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 512", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("a7a750d3-121b-4e5c-b0c2-ab499e6775ac"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 48", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("a86e2c6a-fc83-4c06-afba-f87ec7b3065e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 659", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("a89b1c13-3dfb-4f2e-b39d-e9fc93016685"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 453", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("a89b26f1-cad0-4696-b7fc-5cab34e68864"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 793", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("a9265170-fe22-490c-8e87-f43c7bc9e736"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 231", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("a97503f4-ceb5-42f7-9bf4-61569e21ab68"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 544", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("a9ccd5ec-f348-48fa-9bf2-b126b874c497"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 315", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("a9f8944e-a7a7-46f3-8d82-b0a902e11c24"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 685", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("aa052ba1-6ef9-4bc6-82b9-63784af86948"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 958", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("aa0db502-4d8b-4b4d-bb23-7718a64de1d9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 780", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("aa41ec4f-6617-487f-8c3d-2439df90a49b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 776", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("aa55450c-ea72-4876-a050-ea5c8b70fb06"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 245", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("ab2d2763-0e19-44fc-8795-737c96654b54"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 876", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("abab7df9-54d0-454c-80cf-4ac80ca95138"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 62", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("abb6421f-f5a3-4714-a080-8046feee2e50"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 669", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("abd79490-6094-4b47-9bfb-09b35faddfa9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 42", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("abecabdc-1356-4145-b299-803e9c25e28e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 35", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("ac3b2be0-3fa2-4822-9c26-23790c552bf5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 389", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("acba5ab6-70da-4473-8467-60209508c0da"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 651", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("ace6f383-a85f-4952-915d-bf95df5164a0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 810", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("acfc2556-ac59-4102-a923-db7b047f7323"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 597", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("ad01ac5d-4e92-4bec-830e-7f9a96bcf0ed"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 757", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("ad184c3f-6f6d-4c2c-8621-599281684c56"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 753", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("ad984dfa-2b92-497b-a491-eb212099e8fb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 53", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("ae3552c3-6f87-4657-a06a-a74386baaaf9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 515", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("ae54f070-c4cc-4c1b-95bf-261fcbce2613"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 194", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("ae89fdd6-c71f-4732-8271-a96c7ab50b17"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 603", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("ae9b8944-fc8e-499d-85bc-1c22dbc061d6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 861", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("aef0912c-0137-481d-b3d6-a4aa510185b2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 878", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("aef61b4d-4885-48f6-98a9-e228ff9c6f3e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 748", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("aef7c2aa-4c24-43b9-a952-42afbf6a0ff7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 563", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("af0f901d-4e3c-4242-b910-9417816e284e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 412", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("afb42727-f145-435f-bfe7-9adae1a37ed2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 465", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("afb448af-4cf1-4e98-a851-50eba0a2f881"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 721", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("afe51c08-a464-4b13-ba66-87441452bb0c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 524", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("b07818c8-f503-494e-90fa-30ca02dd059b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 6", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("b08ba12b-34ae-42b7-84a2-8f9b99d4506a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 724", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("b095635b-322b-4b7c-91f5-e295cc573f8f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 145", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("b18199f0-bf76-45a0-b511-eec399de9ccb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 802", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("b1895a5a-a615-4779-82ad-fc37cecc8789"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 157", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("b1ef15a0-23c8-4f46-b685-346d7dd3d53a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 572", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("b23296c2-eed5-4e03-a4c6-2bfc2a9ead58"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 94", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("b2488ddd-145c-4c02-9381-4be36058686b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 112", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("b26b2324-66ed-427d-9978-fcf1e8b228d7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 71", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("b288079e-03d5-4c9f-8b93-acf89551ec4b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 631", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("b2b3936e-72c8-49cd-ad64-a55f60a5b1b2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 882", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("b3056009-8ae9-485b-959e-ed59006ecd85"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 828", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("b31e9b7c-d12b-4b0c-948a-9af72bb39e3a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 440", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("b3360a34-be68-4820-95dd-3cbbb677e5a5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 539", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("b3a8eecf-7808-4faa-a9d4-504cdbd54a98"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 794", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("b3bd238b-f00d-4921-90c0-021825748c75"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 783", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("b438095c-78c2-4529-9fbc-bbf4bd4fb5a8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 507", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("b43d9e8e-9127-4a52-9492-3b1934ac63ad"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 191", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("b44d25f3-37a4-4658-822b-b39c0fce7907"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 474", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("b45342d3-6179-466a-853e-346b9e0732e5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 373", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("b49a2f2c-301d-48eb-83b7-c666ba7dba39"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 468", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("b4e93b14-76ef-48de-8f18-e9c2a670c07f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 697", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("b5447856-adec-4aa6-8f7a-44070f0bbdf9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 5", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("b569b25e-d162-4cbc-9b0a-6f7812a000e4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 825", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("b56b86a0-a043-4e94-a083-c26b5b942e2d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 712", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("b5d576eb-942d-41df-9f1a-d37a013335c3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 865", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("b5dae714-f55e-41e0-a786-e996ebb0e054"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 285", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("b6295fc6-eeb4-4197-8126-582ec079fb59"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 647", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("b6409a25-4eaa-4cf0-8231-2033ba4d5fdb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 447", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("b6f11f3c-b7a7-4fde-93c0-e4c6ea3e7ebc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 172", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("b6fcd966-e744-44bd-bdd5-9dbbfaaed772"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 678", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("b707038d-f9b2-439a-8889-fb5278ef8b5c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 561", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("b7419044-0952-4681-b955-3560579ea1a6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 358", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("b75ba3f5-b9de-4c3f-83e9-cbbc23852ffc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 782", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("b7834bcf-f029-41cb-a97f-b659ab8c3ef4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 182", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("b7a6d83e-db62-4395-b1a4-1610e8958563"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 573", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("b7a9df7d-7882-4070-8808-a95af93b06b0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 338", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("b7fecdba-aced-4210-aa54-61aacced15d5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 582", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("b8049eac-e0c2-4fb6-95e8-78d2f185a2a1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 34", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("b80f2950-f695-4b74-909d-48e1d610ef2f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 361", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("b81f8c4c-8fe3-4517-8e8a-c85e66807fa3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 916", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("b825b395-7913-438c-8b59-cf91ab219581"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 359", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("b852c8de-04b3-4483-8381-b85685419fe8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 365", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("b8e5aacb-b7ae-4192-b154-0980005fabf5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 835", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("b91a3ebd-925a-4819-b8f6-b338df34bc80"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 620", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("b93414b9-43a5-4691-ba03-d8f902b68083"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 773", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("b9459212-b4c9-401c-8cba-3f062fd501ed"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 4", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("b984a126-07f6-4f6a-be17-94231b5eea9b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 571", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("b98aade9-ceb9-4ba5-acc6-85911a7b2649"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 494", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("b99c22d7-084c-477a-b79d-9b48e4c09d9e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 518", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("ba19aab9-e641-4c36-bcc1-08d19d29b9c6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 477", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("baec76e3-949c-4ec8-844c-35952296c243"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 799", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("bb1e6b81-7f52-4234-8843-bf82a0340cbc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 84", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("bb2f1d10-c021-4e4d-afa3-09e532090f74"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 979", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("bbcf57c3-9a46-4ed4-ba9c-50bb0c4ddee6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 452", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("bbdc6dbd-d651-4df7-932d-59df46532584"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 382", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("bc291c50-7f76-408d-ad22-994475adb9ca"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 548", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("bc9cf27c-3b3a-403b-8748-029244f10822"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 303", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("bca2c569-b30a-497b-910c-697ee5b5bc7c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 150", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("bd250b12-4feb-4d24-8c1d-640045483c1e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 8", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("bd70a0c7-b355-4080-b615-66ba0dc7ca2a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 324", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("bdb016ca-b2c7-4849-b5ca-11b2a9b06616"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 40", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("be54ade2-6016-4b6e-969c-c88a6c09c31f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 201", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("be8c4177-f04f-44aa-bc25-19748f82029f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 394", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("bf07cfbc-ed6a-4983-a0c4-59fbbd57f6ce"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 371", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("bf6033a3-dc20-4215-8dad-a8540fbcc5e4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 111", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("bfbbf984-3236-44f1-a3e6-b418637dcf15"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 431", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("c024e9e0-2ee0-4a85-8c15-1e1bdd38b6cf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 184", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("c048008b-d1b8-4dbf-b327-33780be7451f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 65", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("c0e48abb-d315-4d95-a034-c2f0e9c50e88"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 924", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("c1064a10-c761-4a5b-87bd-fb4c9191c4c4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 641", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("c10d0fbe-f55c-4be4-8c95-b442d8677df3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 520", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("c123c6cc-a47c-429a-beb5-4827b5196f63"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 487", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("c14d2c98-1f8f-4dd4-b595-4c6dcf6a4649"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 139", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("c17726d0-9a1c-4b09-a864-e0515f36128f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 289", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("c1a0289f-9412-4979-85ab-9c19b82f7aab"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 246", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("c1f56312-6fbf-4e07-8019-099ba3d8e843"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 415", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("c29bb647-6423-4d9a-b282-3df11f071443"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 706", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("c2cbe95d-4898-492a-951d-52111052f627"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 152", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("c2d4623c-ae7a-491c-85e3-3b0d9a72b25e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 585", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("c31da60e-6eb1-4164-bfc5-c39d8ce272c1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 823", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("c3c6e7b4-ea23-451e-ab54-e2cb89bfdc09"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 120", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("c3d2287b-9189-467f-8044-fcfb60d5805c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 870", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("c3eb2021-452d-4dab-8cdc-afc6eb7a24a8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 449", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("c3f3a35b-b823-4872-a9cf-6f162f3e27c7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 839", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("c3f4bd6a-6363-4026-877f-fb50e5a98ef3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 98", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("c44533e2-e0bc-4bad-a699-1ba8f57697ea"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 680", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("c471f838-4ac9-4f9e-8d61-29013671edad"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 154", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("c5242287-5e20-46b1-9df9-08feea14925a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 114", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("c54da52f-f9ea-42c5-91da-8deec4efce4e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 260", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("c5847c86-075d-4d05-b50f-d03f2a63b274"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 922", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("c5edd4c2-ee26-4ff7-8f2b-c9c0ebfddca4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 895", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("c60cd5e9-3e0f-47ac-b67d-8235d6e74530"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 820", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("c63d3c06-8bc0-4661-964c-604a4cc30ce7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 464", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("c644945a-1a1b-4fe3-9fde-f82e255aa8e9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 848", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("c6df534e-2262-482e-a539-8c59628697ff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 430", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("c703ecb3-ada3-4394-98b9-44bc32825a37"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 652", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("c736d0c6-9f22-4c7d-a0e7-727e60b52ab8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 700", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("c755c898-3516-4c83-a729-78af7796dc17"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 7", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("c76a145b-3d0b-415f-89fb-ba2ed7df7ef4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 703", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("c7821482-b270-4c85-88d0-880c3bbac8bf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 80", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("c78689ad-936b-4fb2-a671-9e37d4a5e544"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 542", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("c7bc0a4b-5f1f-410f-92a5-c0a035b3da8f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 392", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("c7da1128-a9f3-4cd0-8ae9-82c3fcfe645d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 849", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("c7de246f-09ff-4eac-aecc-364627dcfb0b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 929", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("c7f84ca5-f64a-4503-826f-8c4c8b351f8d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 357", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("c828d1ad-1618-416c-bd97-103fd18ea2a6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 380", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("c840aeef-101c-42c4-9bcc-a38ee3003c8a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 482", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("c8456b57-0432-4e16-b638-71c58e047af6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 24", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("c8e990fd-ae78-4a00-9bfb-633f026bdbb2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 499", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("c942dd22-f4c1-4e0c-af93-38a02eaa31eb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 942", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("caa7f5dc-392c-4de7-bda5-26d7a921ec29"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 522", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("cace7809-8879-41b0-8bb0-1bd980664e02"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 473", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("cb2dd703-76a9-48b6-9bb3-1d5d2cc6a74b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 768", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("cb412ba1-10cb-47a8-8628-e728d0eeb65d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 326", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("cb58544f-f418-4eb0-b03c-4defa383f1a3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 424", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("cbd82cb8-d29f-45f8-b8a4-bba4b9025c78"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 78", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("cbdcc32f-b8cd-4770-86fe-8c32961787f6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 880", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("cc4d944b-33c2-46ef-a000-56f7822e17f5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 354", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("ccc31ab0-bbf6-445d-b507-751c885378c9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 769", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("cd0d35d9-0c3e-4892-a8fb-60060bb61f24"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 756", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("cd87c69b-409a-4094-9e40-cbc9e899d121"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 369", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("cd9cbb58-155e-46bd-9c96-b8a28d5fcc76"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 969", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("cdcdc7b5-f1c4-4846-a95a-f93170904972"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 733", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("cdf07bd9-f837-4a17-acb9-d3ba58562d8b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 931", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("cead975b-48ed-4301-b8f8-e726f251696a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 355", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("cf01ca22-92fe-405e-9d28-156998082025"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 85", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("cf03d12b-1f59-428c-886c-c8837544d616"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 954", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("cfb5aed1-6a0d-4869-875f-e54c027dc6f0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 197", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("cfb7cf16-5fdd-4ed7-a559-d078ee125200"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 681", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("cfcde0ca-481b-4a7b-be99-466566a31042"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 377", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("d0053ad7-c057-4573-a5a1-2be2dbfe3d70"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 557", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("d01e49fd-747a-46fa-bbe7-c0363afb620e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 963", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("d0638e2e-774d-4290-9ab2-d651f0feec91"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 304", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("d0833927-8a25-4be2-b808-65ac8d6bbc28"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 639", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("d0b20163-c7bc-4443-9500-65a1da43efce"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 252", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("d1283054-fb40-4dd5-9548-6d1bfe53a689"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 763", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("d1780d30-75ad-4d0e-a3a9-9526f527039f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 74", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("d1ab0f9e-96ac-4612-864a-844ddf966ca4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 843", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("d20f087e-525d-4448-b345-92ccf0fd94f1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 470", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("d278e97f-6298-4a29-8a42-da8046269678"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 784", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("d284aee2-9e83-405b-9028-b4ac5ede13d9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 10", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("d2c4773a-6fba-42af-9df4-45b79b588ec8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 387", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("d2c5f371-043f-4e48-b612-1416be45ca81"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 909", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("d2ed86c7-5b91-4dd3-a086-9c74ab0ebac3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 117", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("d37cc1db-6040-4216-b6c3-8671ed8b0641"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 708", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("d38e49a6-133f-494b-8730-5ffad90e02cb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 808", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("d3b2655b-9281-40cc-9ccd-2ffced4d829d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 827", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("d3bf37ee-8232-445c-b83b-fc0516ac8f86"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 45", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("d3e68e70-c27f-4332-816c-0f8b7d94860c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 950", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("d3fb9041-da40-4ce4-a85c-96ec011d7bf9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 947", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("d483339e-8d13-46b8-a858-0e5df4b1d0fb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 934", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("d4906112-0da1-494d-91ec-8ac71f368d06"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 636", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("d4d47da6-7f80-4df0-8e10-3980ecf78c92"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 619", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("d4f370ab-bfe1-412b-b2f9-96fa11ab395a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 921", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("d5403e4e-d3e8-4e94-8906-bd08ca06540f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 381", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("d5730454-3aba-4425-aeec-67cce0cb785a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 667", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("d598e75b-6b35-4172-a27d-3b1ef6934b61"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 81", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("d60878ca-9f77-40ba-bc71-560e064fb544"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 386", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("d6321c83-23ec-4b34-9020-c72cbd0acc50"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 535", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("d64f33af-48c3-42d9-a97e-cb42315f9993"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 202", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("d65a219e-ea78-4e75-8c12-38919581e227"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 221", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("d6fbdd6c-3c9d-4cb4-bb9e-ef54bcec8bfa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 280", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("d72c7960-d036-44ea-a125-24e7018674dc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 383", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("d7f82238-9ca1-4e69-bccf-c30ccfc59eed"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 745", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("d809906d-4f04-48d3-a368-56f99a31b560"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 988", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("d839bcdb-b5a0-43c1-af86-b5cca7c208a4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 531", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("d881bd9d-5474-4cd9-b865-8c2b2d9ae168"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 805", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("d887357f-c0a5-43db-8b71-0fb3da0736ce"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 268", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("d88e0014-989e-4452-abb4-c215f85b8531"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 995", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("d8b7e2c6-d85c-4616-ab9e-343573d8046c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 812", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("d96621ba-bbd8-4530-a5c6-d20503d7856d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 130", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("d9c2a1cb-6698-4b34-8854-6f9368cdd63c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("d9f84ed8-2dd1-4e7e-872c-82a78c58ddc5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 751", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("da0b165a-4d4c-4869-a4e1-dfd560bbeb98"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 935", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("da0b5c60-15e2-428f-9dac-1fcf37fd056b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 536", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("daa8014e-ce74-4a20-b604-3b8f97d468d3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 907", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("db143a62-97a8-476a-92b7-9ef9416aecc7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 22", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("dbf15525-0c1d-41b5-98c0-0768aa8327c1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 492", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("dc793e04-19ef-4e60-8d7c-2c747022a426"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 927", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("dca4acc9-77d9-4acd-bad4-4c257bf8b3a1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 736", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("dcde5e7b-5cc9-4892-9122-48e4d481f28d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 198", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("dd0aea5d-ad63-42b3-8b52-3384eddbf9ce"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 610", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("dd2e6870-c444-4e5f-bf54-4d10d7d1d3da"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 349", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("dd480fff-3e94-49fb-b278-6469cdf35349"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 891", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("dd98a0a1-5523-45b5-81d8-83752c56bf4a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 764", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("de4d2c2a-c6af-4a0f-b12f-3aefb87bbce4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 777", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("de512397-9d94-4b21-a29b-e0013864fa1a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 242", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("df165dc6-12cc-4a60-8605-708281464f58"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 959", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("df2431d7-6b1f-4933-b614-c2bdd64a593c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 971", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("df64e922-2cea-474d-ab73-96d404c224b6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 401", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("df8ba60d-1e41-4b09-ad66-7a79ce8b05f7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 984", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("dfb71f00-b7fa-4e9a-979f-cc7de04c7355"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 317", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("dfd40f2a-e9f0-49fe-9a1e-a83efd3246e8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 170", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("dfd8f0db-675e-40b6-92e3-c5d76bee5cc3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 123", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("dfe5ea50-4168-46de-bd49-1d9205f84b87"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 438", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("e034e59a-bd0c-46f4-8756-ec5257a985b7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 76", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("e0c32d0b-4b40-438a-9944-537cc079913e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 409", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("e0e2aba5-29e4-4c6d-afdf-37836cf3f4d0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 824", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("e0f87145-ef1e-4417-b09b-63946fa05dbf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 375", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("e1eea32b-f86a-479a-8f60-abd1e5afa42c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 330", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("e1f075fb-cf37-44a6-9f94-89303a491342"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 51", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("e22780a7-2d7d-4d1c-9d7b-b9298a5bfc13"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 11", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("e2441304-d829-4649-b2d6-ef2d8b0c8309"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 560", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("e2461344-f491-42fc-afd8-b61c6a44c304"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 754", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("e280292f-cf97-49f9-9d02-fd878c267201"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 583", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("e2c43aa8-63d8-42d7-a12b-089d9c697021"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 811", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("e33d0ed6-6a96-4818-a19a-ad21339fd58a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 719", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("e3954e81-913c-4903-98c2-ae46e3a16791"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 171", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("e3d14b54-868a-4036-b6cd-a0ff0be01ae0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 762", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("e40d6ba6-8f44-4e3e-9484-f9a22f2ac1d1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 133", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("e438cd29-87f0-4cb2-a46a-a529d051897d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 240", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("e4422399-0891-484c-bf78-ed0db310d9e9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 275", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("e498c41b-e080-49b2-bee6-59359cb8bff1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 217", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("e5081412-09b2-4437-8c32-5601c2503e34"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 755", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("e694f264-990a-4256-bc30-e086e5ef5667"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 710", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("e6fa8211-af34-48b1-a18b-b5b1189f2164"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 109", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("e702635e-986f-462e-b9b4-91aff7556267"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 69", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("e73e7f9d-bcfa-4713-916e-8e973cfa9f3f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 974", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("e7a7ec10-fd77-4c46-9586-6c43ca34bb7a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 103", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("e7cfc70d-1cae-429d-8776-ac7914cf8d31"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 765", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("e7ef145d-ff83-46e8-853e-e720b546b255"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 581", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("e85d7a90-7956-4646-9128-44077692b870"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 662", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("e863fd76-18d8-4351-a83c-02a0e56c1610"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 179", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("e896c9be-1e6b-4079-9a8c-d615a83183b0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 897", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("e89c6d58-c512-44ba-9f03-2a13d994bd6b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 129", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("e8aa2a16-fe81-487b-86d6-c511ba62b6f7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 274", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("e90d0a86-8634-40d0-a8ed-4fd0e6113a29"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 68", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("e9720ce8-2224-4b0c-af8f-2daeacc221a0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 918", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("e9fea921-ac1d-4961-91b6-1a3dd8f71806"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 842", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("ea5627c8-44a4-4772-b53e-a2903e7550fc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 547", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("ead1a252-8c5b-49b7-ab90-3ccd793eb2d6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 649", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("eb06c4d4-7fb1-4c6e-9bc3-13b7faf4bff3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 864", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("eb102c66-aa94-4a6e-b1ea-d2ba579db828"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 562", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("eb485f03-a036-43a5-a07b-fcd5032dd010"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 640", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("ebabd207-f834-4bce-a3d8-ec2e9fb4ae4e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 297", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("ebb47821-d8b5-49d5-b494-13fece9866dd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 404", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("ebba12a3-fc44-41fa-8bd3-cedc8155b581"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 151", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("ec10d40c-f7af-4f23-8819-6cc46c540eb1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 127", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("ecface6f-15bc-4602-bb93-f2f03e60aa6c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 72", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("ed598d99-7bd4-4b09-a8d4-6437b0ef8eba"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 798", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("edcb8d9d-1397-4be5-8ac3-06f2c7fbbf2f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 329", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("edf9b92f-8910-4e55-ab12-bf062eff4642"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 894", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("ee2c3a5e-f54a-4751-8d67-2eb157c4ce6b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 838", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("ee837721-4fd5-4f6b-96c0-23bc98153da9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 77", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("eeb5ce94-77f4-44ad-9d7a-757b16d849be"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 66", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("eee72f96-9205-4b76-9d2a-edc0a5cb3a92"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 138", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("eef7d4d1-a60e-400f-a065-f89232fa1e79"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 503", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("ef3ab9de-1217-40fc-8ba3-8e5483586e18"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 215", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("efbf2dd8-252f-4129-aea0-ca9b34a40cdd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 596", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("f018e733-3438-470a-8479-2cfd60896d16"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 872", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("f05e11f5-230f-4d42-a46a-b6b41801afb9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 850", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("f08df615-b35b-4f7e-8b0f-c4628ce6ee88"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 497", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("f0b90918-bc50-4e0f-b898-7d2a9abe7a50"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 568", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("f0cdfb2f-6ade-4be8-a74d-dfe9b89f6087"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 418", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("f113ef8c-f6b6-4196-b399-87329df6ca85"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 206", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("f13650a9-321f-4d5c-92e7-6108aaad07a3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 903", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("f174587b-7280-4ea0-8255-08626d0d796a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 901", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("f17ec0f5-8461-46a2-bcba-10e72eff9f72"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 251", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("f1f1591e-a130-45ce-8482-7ccc91203fa8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 605", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("f2053b2f-4a9f-4adf-8b30-2fc785756d5a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 997", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("f2528da5-0374-4fc4-b21e-4753708db6cc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 814", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("f2681663-6a44-4692-9ef8-683abcb8a067"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 618", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("f2b6c793-fdee-4e5a-8175-c17fc1e916a0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 407", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("f2ccc2f9-88a5-4a26-871a-66907d76a47d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 156", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("f2e34230-328b-499a-bd4c-42392135490d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 845", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("f32eb286-ae06-4bca-9d21-6ac7d9d0447e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 448", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("f3a7e93b-2b81-4e57-9c96-2d5d320da020"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 656", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("f3c36acd-9609-4e46-a646-b38374fbbdd9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 397", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("f4054b7d-4106-4316-a83f-c75017a321c5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 46", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("f406bbb8-83e0-407a-b062-8a0b766b946d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 771", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("f4070e1c-53db-4814-b649-654b2eccc036"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 146", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("f484b4a9-1797-43b8-85a4-39c7d9431126"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 234", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("f5100ad0-978a-42e4-a928-a8495c0dbe44"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 223", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("f548649b-4750-42d7-821d-fa9207298733"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 840", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("f5613bb3-bd3e-489d-8618-b2193495d71e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 552", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("f5d062a2-026e-4df0-98c8-12814fa652ff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 917", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("f651d220-ee5b-4f8f-89e2-788728a3fb8c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 713", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("f652ddd4-304d-4c73-8365-f1b1fcb9082b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 983", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("f7117c30-bc9b-4fa8-9d86-911b32f74ff7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 200", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("f7288884-e7e9-4361-97bf-7cdae85c9bc4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 462", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("f7987b11-dc1f-4f3e-8567-0da8a7d29a39"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 293", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("f79a0f0d-7df9-48c2-bbdf-635bb40c9a13"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 533", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("f85b3678-5d6d-436e-bf6c-cfca8d915996"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 628", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("f89251f5-7145-45d9-a0cb-9df8ec035da2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 186", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("f895ba6c-c6a2-48d5-8f0d-7470f80df740"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 852", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("f89ecf38-1225-4327-b61f-56d4c4f7724b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 858", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("f94c6a7c-4c12-4ecd-9113-9548422594c9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 761", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("f9735b9a-b417-4d60-a4b6-8df7c46b0059"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 589", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("f9fbbdd0-d091-4479-b9dc-85bdf3ffb64e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 283", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("fa1377f7-a192-41d5-9da7-008343c8d082"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 774", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("fa8e715b-c493-4d2e-9c83-effb341a3fca"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 752", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("facd6751-c8f1-443e-96e8-2a71203fc250"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 923", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("fb970bd4-4726-43b7-903a-4d422dcc596c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 691", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("fc23e750-0838-40c9-8d1f-91f661a02daf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 276", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("fc269b38-6b1d-4ce5-a6c7-cedef0cccfb0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 248", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("fcc33a74-3fb4-48d2-b08e-427c32d6732c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 158", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("fd00a27e-a757-4aae-811f-63bac7758811"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 658", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("fd0996c3-9387-44d5-9fec-b80a8605fcdb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 964", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("fd0f4e97-9820-444a-974b-d27174323bda"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 889", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("fd39fde4-8e07-441f-8a7b-815714bf7051"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 485", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("fd4a7e62-fff7-48e6-812e-5e4040b36052"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 50", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("fdbd6100-d45f-424a-ba46-4ec684212d47"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 264", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("fde01361-c636-4154-a3f3-78bf167f4448"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 519", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("fdf77172-8288-4188-a9cb-f2ad6d9e3390"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 241", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("fe00bc5c-5ed3-443a-8355-de81525486b5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 308", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("fec0255d-4045-4281-8b91-2f5ff071ff56"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 93", new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"), null },
                    { new Guid("fec4e172-80aa-4c5e-9efc-e0e093510a5f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 730", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("fefc16a2-1087-48bb-a7c1-b820d1e1f6ac"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 634", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("ff532704-4f94-452f-86b1-0b532caa5bf8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 744", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("ffbedf8b-22ef-40bc-bd21-cbbbd6861f03"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 948", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("ffc96f26-8d32-4f36-8403-2561aa3e8e5b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 318", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null },
                    { new Guid("ffdb80de-ab76-46f4-899e-cb429cef02ee"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 44", new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"), null }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "CompanyAddress", "CompanyName", "CreatedAt", "IsDeleted", "TaxCode", "UpdatedAt", "UserId" },
                values: new object[] { new Guid("9e88b5c0-908e-46fa-b453-232bc2611ff2"), "123 Main St, Cityville", "ABC Company", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE123", null, new Guid("c819a963-b96d-4bc9-a1be-32e1b036183a") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0032a29f-6717-49ef-9114-300eb0337ecc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("004285eb-c9c7-4a0d-a1c5-b50908b4881f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0052dcd7-c8a0-4c6f-ab83-3f50ba5144fb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("005f1e7d-904a-48c0-846a-aa3a2f8cb336"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00dabe04-7f0b-4339-9e92-2bcd203fb3d2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("015cc312-e227-475e-bcb7-1e16486b3383"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("017b388e-9a32-441f-a1f7-cfca0d2b0b14"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0193a52e-b390-4c94-a1b3-74094ff73225"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("01a4d663-045a-4c7f-a606-02d8ce7a3bd5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("01ba1a48-a8ba-4466-a7e7-9cc868a59b30"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("01ed43c2-bc4e-41d7-86d6-09bde2266ba7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("02627790-a69d-4f03-bf8c-b83f58ec249c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("028a8fa4-214d-4a81-93bc-72b1e3c59883"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("028fa506-1548-47c4-b7c3-ba7dedab4612"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("02ed51c2-5c01-4ade-8810-ea8a0048f7cc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("03315619-8a71-4b60-aa11-c987bee07024"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0335e5ef-a305-42a1-b201-fccd3bc3c493"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("037c5925-4268-48c2-a742-378097b41d38"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("03e36e26-ba45-42aa-8d99-16443eea72c0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("042f3762-c57f-4f7a-91d1-4f4cdb824334"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("043a25fa-226e-400a-88ba-d0365d579bed"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("043de415-286d-41cd-aa16-8b8d72016a5c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("04cf6858-2d3f-42f9-a9d9-4bc2d4ef7f99"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("04d10bb0-1c9f-4615-a1b5-e4f298c5f7f4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("050684f3-0c1b-43c0-9d28-9d47c6ba53a4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("050a387a-595f-4ea2-b45f-be1d6144d828"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0574d352-c117-4d79-b4f3-a8ae029eb60d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("060c150a-8e1d-4b56-9e9e-20855045d611"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("063a5f31-03e0-4c4f-9882-7dd6076c696d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("06dd9ab2-84b7-432a-92f4-f9b919a75808"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("081812ed-2bad-4275-8adc-21f88ab14448"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("081d564e-e719-4cdd-ac80-490ec7cec679"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0844e900-19f4-457a-a52c-36dbd6c04775"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0863302c-47c2-45d3-9e5f-6e026006c276"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("08807598-3986-454e-bbb7-37783658327f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("08abe0b4-b247-4b18-a405-3c420de05d4f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("095e7a8e-f782-4ea3-a04f-98838b69daff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("097bd27e-2b8e-42f1-b55a-0440877f8aad"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("097dd915-b45c-4c9d-93e1-e20c35272719"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("09a2c415-3701-4dd9-9b30-5ca2ddf54bc1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("09ba0872-bf27-4dcd-b4ae-fc59ea0b98b5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("09d2c5a4-d498-40b8-b189-36961a592373"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0a306a58-fefa-480b-9ecb-7000b03f7dc5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0a6b8301-327b-4315-b871-981a5cf88cdc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0a90bc43-144c-4db6-974e-4b4bc66a447e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0b1f7f51-5b06-40d4-b033-4ff99b8bab5d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0b54eaf2-6c03-47fc-9766-8ef618cd4a1d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0b5bb601-8421-4b5d-a6d7-ecbd85e4dff8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0b99c3da-ba62-44ce-9e59-86d7a2577032"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0bb62ced-702d-4463-aa7d-efb69baac2b7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0bc5c8fd-59f0-4a42-94a2-664a1e5d42ee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0bcf17ed-4f32-4933-8436-6749668b0800"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0d478b5d-df7c-4773-9c0f-8965c88901c7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0d580edd-9a03-4f85-8e30-7fc6750a7616"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0d60ce28-e1e4-43b2-b273-b7c79ec1bb07"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0d680b61-fc14-410f-a65d-c4add26919a3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0d86b1e4-e5ca-4561-8147-1e32d997faf3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0df640cc-783b-41c7-b6ed-de36f63910bb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0e0c045f-5aff-4e0c-a658-4a3b2feea7e1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0e1c37f2-d892-4081-8e86-35843a387733"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0e6196d0-d695-47b7-a3cf-90d2576cad78"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0eb48479-f056-42af-a0f7-1b97fee4186c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0eb9f707-e263-470e-8a52-b7fe387303ce"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ec6eb42-227d-48ea-b673-d8b1cf4a5d0b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ecb1d34-98ab-471b-9b8c-78aa188bf66a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0f1f88f5-2b9f-4357-92c8-79cc2cee0401"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0f4652ab-500f-4a35-9544-f0b857ba30a2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0fe223ee-d69b-45f8-a305-599e2e69e8db"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("100a48c9-5976-4b19-a2cf-42bbc552c65f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("10478477-add9-40b2-9cd4-d70ad6466334"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1074bb80-07bb-4646-814c-4ca8f31469b5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("10b4018b-ffdc-4fd3-8761-49081338f51d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("10cfba80-66b4-4254-9a65-2eed305dd9f5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("11eea498-cd91-45e0-8cc5-d0a35f3fece1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1204f6bf-7b96-4aa0-8e9c-a9005c5731fd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("123a4b48-e40f-4642-b973-986d6c861b60"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("12c8e352-05f1-4f82-afaf-ddc5e4ba34b1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("139a23a6-a00d-4661-b674-70456d16c5fd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("140220a1-0ec8-41ff-8ec7-a8bce00fe0a1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("141ff887-57ad-4c84-8671-72f831d8a101"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("148a153b-1353-4408-bb9c-7ea54f7af403"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("14e55e7c-5ce7-4737-b03f-d8db38c982b6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("14f0b778-1211-452a-8db9-5bb62087d72a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("14fdda39-d65a-44df-88b4-10df6e29d2f8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("153fb12f-6202-4cb5-8dda-69be034567b1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1552c741-df8e-4bc0-90e1-b9eec981d1ec"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("155c6462-6287-433a-94a3-fa12fa5ca42e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1649c398-7ae2-4805-b4a5-c0d8f4e59eef"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1656c58f-00c3-49ee-a412-4a638652f0a0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("16af9c35-4d5f-49ac-8830-6acc17a39f0c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("16f65b81-0a70-4c1b-a219-d59cd1677eeb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("179e516c-3eb6-467b-9f36-850cbae7e0c9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("17f0c061-68ab-40bd-9ee5-67aef6588bd8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("19095afe-ad8e-45b5-a18c-0d3daeed058b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("193aaa9d-ede7-497a-b78c-05e630e17fc1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1968431d-21c3-420c-a991-618347c20625"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1b09e9da-4691-473a-8450-1e3a04168956"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1b327d8a-cff8-4365-bbe9-374f5c0e2e76"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1b3b6fc1-b5e0-4e97-a3ca-073938f3bba3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1b42f76a-27bd-48f4-9814-cf007abca9a6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1b681944-4d29-497c-b41c-58d79b908076"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1b946ee7-aebe-46fb-98a4-45f6d3386f04"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1bc04b1f-6707-4303-82b2-9cd128667efe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1be733d5-dd52-485a-a10e-fa4f68488479"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1bfa1fc6-baca-44d9-81ff-22b9dd79f56c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1c0944e2-0b2e-4acb-a879-8782d56c2347"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1c1847ed-201f-47c0-b85e-37416afdfc7a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1c3ec914-f554-4c99-8f60-8241d6382f6f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1c533a58-0e49-4137-a6a9-b5d59327c965"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1ca1b14e-e36e-4468-8316-bc910a56d13e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1cc55be2-d8ef-4444-808e-c2652bce4297"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1d0107a5-573e-47b9-b967-e68a71c0c7f2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1d21ef27-2b16-4a84-b9cb-5b456807350e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1d756a6e-33de-4fa9-8e6a-7271199ca8ea"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1e21e72d-3fee-4c03-896f-9f4b628ee3b2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1e66ec51-692e-40de-8b3e-5990893ade96"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1e904b85-425e-4014-b5cd-8cc5364800e3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1eab28cc-c4a1-4b67-acd4-ba94e01e76ba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1eae9791-6033-4079-8a11-f6618f85d7ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1ec2dd79-8a80-408d-9884-1932598a5f8d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1efb286f-9b6f-4776-93c2-6fd3f1106643"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1f369968-05a2-4d7b-9b63-edf658cb2d33"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1f46aa19-34a4-4550-adfc-7eb92136f4cd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1f78a2c9-4fd5-4996-be0f-42449bf3834d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1f7cd4e2-e4c7-4dd9-918d-c4cd08a5f486"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1f822ec6-484b-41ec-9ea6-792e7c2a124f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1fa95dbd-b5f5-4423-b609-d3eaacc02293"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("203b74db-c89e-4e99-8706-12cdee9bc6fb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2066815a-f5c6-47de-9e72-203a9be35afa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("206c5329-b30e-4c00-8421-9ee9229c77d5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("20931b11-d7a9-4641-b9c2-1e7ce98898ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("213cd353-5242-4c9e-9545-4833fdc3d3c3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("21adae0c-5ecb-4af5-b0b7-2f0fa8b31ee9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("21e52cbf-1ce9-4f7e-8659-1c283465952d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("21fad798-ebf1-4c0d-8379-5860adb4eaf7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("224c0396-fbc9-45c9-9c50-3a9336377dd3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("22a7342e-088f-470a-895e-00111b64fe13"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("22dd9c78-b6ab-41d9-a278-cd13fc8edff0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("22ef5bcf-b05c-4b3a-ae12-299d6d0579d8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2318db08-cd62-4658-8867-cc44f4a952a0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("236455ac-0f4a-4650-9d49-138b10658a0c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2387e265-1bf5-4a41-a61e-57af70f4ffbc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("239ae6c1-f8de-4894-a62a-c56b2bd35ad5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("239e07f5-fd8f-4b52-9236-3a4bd8f4eec3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("24533382-7a48-42d3-b7de-530df907092e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("25055eab-393a-4c81-8e9b-3e0437e124a7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("250dcaf2-9b01-4998-ace3-ffcad5e59a17"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2550cb37-e096-4815-a4b1-5534c0455818"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2551d83f-47e1-4aea-b736-ac1ed91a6f67"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2575646d-e02c-42c6-8e88-83a2e8ad3c13"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("257c4911-5a28-4fbd-bd21-15aa39fd12c8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("259ad866-8a33-43ac-8fb1-e1056eb57227"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("25e2491e-dc84-495e-9123-7585bcb970e8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("25f960d7-c4f6-49c5-a48d-886db7ef9fa6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("264e4033-739f-48c8-b67b-dfbfbde227b3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("26641704-52ec-4738-ba5b-b154b0605828"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("266ecd08-c6b5-42cd-83bc-0b5b7f076f83"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("272706ae-4e45-4c5e-90b4-1b4f171c9377"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("287ac805-2401-4905-aba5-eb079c912c8e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2890e013-57e4-4224-bf9e-38779b3c1959"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("28b71584-d5ad-4019-a227-ff09152617b4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2923883e-4ebd-4e9f-8d02-88281977f384"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2989f6d7-2e66-401a-8335-18f5d5f72c26"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("29d5f452-569b-40e1-a097-3426de72f4d8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("29e3564a-d54c-48eb-88cc-e4ec38f9f8f2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("29e52b11-ee07-4359-89bb-0a7281ea34ba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2a4581b3-de02-4f9d-9dc3-515dc7dcb80b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2ac8193d-27b1-4dfc-920e-7dfacdfda5c4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2ae19cae-581e-42d4-a47f-47c18c489972"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2b2ef35d-08bc-4330-8539-93e0dcd7d74c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2b3c84ff-9489-4dc2-9096-0c76bd2d5ee6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2b49c2ee-2429-49de-98c6-dd33c243d245"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2b77a73b-deb8-4e04-ae77-5ea2b65597b9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2b7df797-041b-4c69-b30a-0a4b0399f19f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2bcbd057-60d1-4bb6-94de-3a98a8c636e1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2bdedb01-5103-4be1-ba91-a2c361c97d50"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2be2d6b8-ff1e-40c4-86de-716735b6e24f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2bf30cb5-1164-45d6-a32c-ff1636c02dce"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2c07651a-1618-4d17-a997-c2f465fcd82a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2c3bc94f-0ee2-4b8f-86ff-f8d95a087eef"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2c45ae55-5548-4806-9da1-785902b7ac31"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2c58e566-ffbc-486b-9de2-f00dc790f28a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2c5edacd-b933-4045-a295-b455e543e1bf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2cdd1633-73dc-41d6-a8fb-d0b67c68b70e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2d09973d-6c8b-40fc-8fe0-040925fb21ec"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2d576a7e-dee4-43af-a15d-5f1a16afb79e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2d8266b1-fcff-44f2-b245-b876716bbc20"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2dfe5466-0075-4675-add9-3d04255c11b7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2e30d790-eeb7-4d0a-9e2c-3d4f5e69aa4b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2ec7533d-d6ae-4a6d-a999-e5da5c163667"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2f1dd7b6-9333-4654-9b58-e355193df36c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2f8e1ca0-b430-46b4-a570-51e4ba3a5cd1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2f9f07f0-9fe5-449e-be97-7b2404622fcc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2fed41d4-db6f-41bb-829d-dd97d0f739a3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2ff41a5a-4ec8-4339-9520-a30e7d350a14"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2fff93f3-f591-46ab-a415-ff80739aa1ad"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3003b270-d490-42e3-bd52-c59ee955a165"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("313ddab0-0277-4bcb-988f-42e2b9b81351"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("315dfcb9-4865-4cb1-8ff9-74278ff1d463"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("318e64b3-04af-4943-a3bf-053c0472563b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3199b883-f987-4af0-8bf3-d2383f86f104"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("31b73020-5b3b-4f78-9270-a5f395c1f78a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("31eaf3f3-5a9e-4a66-a545-f971625dcca9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3230d263-d6f0-405b-b938-96b7082af956"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3239f21f-e6f5-4bb6-8c57-f5ff1dcc2233"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3308ad1d-66fc-473a-b705-f4fcc0d9b025"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("331323a0-b27e-4465-8aab-b021417cadab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3414078e-1fa3-4d9d-8c2c-f8a1e17d2e92"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("34473fa7-6a5c-4c8c-97bd-80ee86132e46"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3466d10c-0c03-47c2-840d-98e591d84a4d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("34875e37-2256-4c57-8073-db0994417c0e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3527a85d-f86f-4088-920a-3509f4649f2a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("35565fe6-5406-4ce0-be76-44dfa5c06cc0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("35f9603f-ad23-450b-b57d-80866c8984ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("364032c3-0a34-45dc-bc38-a147b32936a2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("364c5290-0c27-414c-a7ed-ca5c6db0c578"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3694547e-6980-4e07-b940-4e615e13d071"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("36a50e9e-3721-42f2-824a-658970cf282b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("36c6dca3-e618-4f3b-a6f5-395c8005d345"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("36feb3ee-e72b-4423-a1a0-35d027f76ee4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("373d838e-71e9-460b-8823-02fb9884c260"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("376b2bb3-0696-4b2a-908d-ab39b64950eb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("37f76afb-12b9-4df3-9158-5f33ad339429"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3917c35f-40e4-486e-9ab4-a9f76c95e9c0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("39f371dc-96a1-4152-a6c0-fca964180b3b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3a36d5ca-16b9-4ba1-9787-db577888d3df"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3b63d036-8ffd-4126-a69c-cae61c504f2b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3c60878f-5cdd-4957-9daf-b8c87ccdb08e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3c962cf9-0831-4684-b6a9-739c721b7b4e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3d27b76e-e78b-4bdc-8fdd-886bea3967ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3df7bb52-7dae-43fb-97f9-face4689b495"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3dfdb3b2-9938-46d6-bb0d-0f9177c4b7e6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3e38d868-c122-4680-8db5-479a23f6c648"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3e690769-d1ce-4e96-bb7c-32130dd2400b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3e6dd6de-c7f5-4ac5-8603-df9d500cf1fa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3e90601c-1128-480f-865a-6de53ec32b68"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3ea1d47b-30e6-42cf-9795-4b51a0816eaa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3eb68680-fea5-460d-8606-f255dc7e6fbe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3ee3fe53-f4ff-4140-8f08-56836151b423"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3ee6bb4e-fc42-4260-add8-43adb11c4c03"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3ef0622d-d442-488a-ac77-e89399a82e27"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3ef69288-ae15-4b83-870e-6de86b4dbbfb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f1b0098-8c0f-48c3-849d-20975bea5462"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f36c369-74a3-4faf-b90b-239f15f3358b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f532a59-1af7-4b43-aabf-efee2ceb300e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f5d3814-6cb2-45b8-a91c-3a24dcee0eb6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3ff8df62-d2c1-488a-bb72-3b57c45d0b44"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("409fe3d7-aca5-4e76-bc69-d5238bb844bb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("40a15976-9c54-41d7-9674-6689428ce4af"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("40e6401d-bd39-4ff2-9fca-7bbc7a2cfec7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("41335979-ac35-4dca-a1cb-e6963a51ff43"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("416ab87b-7df5-4874-826d-0611b1c23815"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("417f50a9-a8b2-4362-a27f-461b5c8c8021"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4184d49b-a26b-4cd3-9179-57c675089f91"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("41b7c1e3-1eb5-4f2b-b48a-78026f3b409d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("42c910f8-be17-4d36-8919-4e4d7f48cf9c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("430ab026-d342-464f-ac9a-34ffc1dbe0dc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4341fafd-e296-4a33-993a-0fd26cbdd80b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("435d8e88-57fc-4a66-a7f4-0152c1680a7d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4362b98d-a149-4c9d-8d68-4e4a09bb4441"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("43cbf14b-cdc8-43ba-b465-da39baac5dd5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("43e7e402-9896-4a77-ab02-cd3ba9a8a357"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("43e7e88a-bc6d-4c74-8ce5-28e8ade14034"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("43fcdccf-8b9c-4d14-b148-f6cae4a4b963"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("445b8e3e-77c1-4bd7-8c2b-bb97a93e13e4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("44bf407b-e31f-48ae-a1b0-55a5b9bf4eb4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("450b2215-96ed-49bc-8397-d3c88c576eef"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4515d34b-925e-4f78-9773-31b829972e42"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4532892a-0870-4afd-81a6-4515ff88c5f0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4570deec-6c25-47cf-b15c-1cf3d065c52e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("45a6c19d-57b3-4826-a64a-b8edab42ca4e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("45aaa5af-94fa-4bfb-87a8-02211f8249db"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("45b5ef40-047b-4605-af60-f1b551bc3af8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("466b9be9-0cf3-40aa-937b-26d141c70928"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4670f28f-fdd9-4943-9e22-a897e06b2c69"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("467db834-a2ca-44d2-9a55-6e0ca917105d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("46addd42-0733-4ad4-b9be-e4b061dffada"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("470f517e-6b2b-497c-a3c6-65a5fa372104"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("47415b6a-4c7c-41d9-b996-ead0059c33ed"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("47b70c6f-5405-4dad-b1f8-f61f27fcbd13"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("483ebe77-5cc5-4086-a9fc-559ce830ea96"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("487f6495-5253-4872-acfb-3ebb4df1b77c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("48e2f30c-9992-43b5-b1f0-7a0892f05cf5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("49534404-06b6-4906-86f3-21c0c0db83bd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("49764aa2-f68b-4f9b-ad2a-a7665b60e66d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4996e6eb-4927-46c9-8b1a-1e9474aa632a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("49bbc92f-8f9b-4b73-b9a8-76ecfb7adef3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("49f3eda9-fc08-4134-a596-05f5734d69be"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4a414701-e27c-413a-90e0-fe8c08f9986e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4a4ffbb8-0d65-471e-a825-ea86e541f395"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4ac94c60-8d25-4a12-819b-c55b051ced76"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4b24490b-fab2-410a-96c0-d9aa7b6a150b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4b3567d0-560f-4610-ab7e-6b40e0d73aa2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4b3f4445-beb3-409b-be76-ba97e6e0a5e7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4b5ee6da-470e-460f-8e3d-cc57e40b1df5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4b833a4c-d9b6-4863-b6cc-f6a9609837ac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4b8a9a7d-eb13-489c-b6f8-11581fedba13"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4bb54757-4ba2-4d71-b5fc-c89af90fe885"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4bd42f2b-4d9c-4a4f-b780-6e6a3af285fe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c224493-a44a-465e-ba66-6cdfc91549ef"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c5a801d-470d-439c-bd05-9f4298fde6b2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c6770c0-ef39-4fd8-aacc-c60a334418a3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c7755a9-d9a6-45d7-a139-2fc77809b690"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4cb61ecf-4aef-461d-a202-fad3612b1ae1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4cf1da69-c103-4087-a72a-5bc54f5bca0e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4cf8a4c1-33c8-4908-bbfa-15bec7d1ac21"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4d83b28a-b592-440d-af52-8eec715f16b8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4de7e37f-2b45-4ca1-8306-531b40496621"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4df02cb2-66f5-4248-819d-8321004fe5ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4e46f91e-d463-4cca-9e04-84565f9c40a7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4ec27d0d-aa59-4ee2-bced-266f83ee5c11"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4f020dec-8928-4c05-923b-200539b248ec"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("501c2d4f-a2ee-4946-9dd1-a19fcae36373"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5061ac8e-375d-4460-b58f-40b5bf19bec0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("50668b24-0ac1-4213-b7d1-82bf888c0bdd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("509427db-c367-4589-b272-31a0626af6d2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("51021d70-49ef-4a8f-956c-98a9ba18cb38"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("51641fe8-2eaa-4999-81fe-37263c12bcfd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("516ef6d1-9abf-44ad-8ea1-f9274c6a9285"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5174aef8-a675-4d93-90ca-096c9d878cbb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5192b952-f76f-4312-83b6-a24560289ede"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("51ce5753-8707-4e6a-bfda-ec03ddf1d936"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("51f466d2-920a-4c32-a0bc-e18044fe31ae"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("522b8ce9-2553-47e1-9b83-a1a7b61b6acb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("525bbfc5-9aa1-48b1-b794-71c614ff640c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("525e21c2-42a0-4554-9f63-311275be819a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("528544ab-819a-465c-8bb4-422bc5dbe326"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("52d01646-c72b-4326-aaa0-aa95ccd1608b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("52fed89e-322f-4c1e-9590-2e3ac78b9d73"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("530b1b9f-5a07-4074-9694-92f3dba4ee70"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5325196d-a456-4f49-a119-1bba100f7405"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("53421d8f-4959-4f87-9621-4ef24fbd376e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("53489384-80b0-4ea5-9c80-10cd399b4043"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("53a48969-4c34-4603-872f-37b29e9b874d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("53dca670-a4fb-4059-aca0-35b800002888"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("544c85f6-785a-4170-92eb-53f35df64549"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("54517134-9c4e-4adf-ae9f-cf7a02d509e2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5485c083-3ac4-4eb9-a72b-fb564b718bc3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("54f8fd27-090c-43bd-ba09-61458bf69b63"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5506a3f9-7ca7-4224-a365-d9a72e782cbf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5555d51f-56b6-4611-b76d-5d571eba96fa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("556c1ca2-9435-46c1-9030-e6985e2c5760"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5576dd2c-91b7-4dcc-9cac-d4e5c47df3b6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("55b16007-e1de-43aa-bbe0-8de58b508c04"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("55d77e7c-6ec2-4ee2-81f7-a3bac95d6167"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("55e68342-b6b8-4319-844a-2244d4980411"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("55f547ba-023f-460b-93b0-f226995df43b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("560097fe-adf2-4284-8e37-6aa7a2c6dbf1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("56d0b4ff-925b-44e2-bb8e-a1d4d7c38887"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("56e88b42-bc0b-44eb-a0f6-836a6e008f4d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("57534f8c-0ace-4217-98ba-470733e9f680"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("576f51a0-0604-4b4f-a0dd-b1b0abd52d0d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("57b28f9d-0608-49bb-8bca-c6ad0fc0e8d5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("57ce1bb0-0803-40c2-9ef0-9141a5ac8ae1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("57e3adca-6899-43a2-985c-58e12128d0de"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("57ef7c8d-7440-4dc7-8555-612ac62ae9a7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("58127bdf-9e2d-4efd-ab17-0105c9bf5b0c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5838afe5-7823-4799-ab5b-6e0bc3d305b7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("58a54ec7-bbc5-4892-aba5-f7611aef34e6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5975b57f-7910-4ee9-900e-91abf82db9d1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("598d5478-5412-4c8a-bf7c-4f6c4d5b8439"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("59efe9df-1db5-4618-a7f0-40e8286133a6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5a23e9f5-bd18-49ab-8d32-50145dfdd7a4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5a3d93d6-97b2-44f4-8d10-7005ffe04f31"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5abf63c3-e795-4517-84a6-4a4e28a3c943"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5ae1f7de-c809-45ea-b9c5-ca3308712f2e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5b472745-1469-4945-aed3-91ab6a74525c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5bf7292f-4a5c-4aca-bb4a-4b9e26fe6b67"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5c0b0580-9ec5-4228-98dd-945747a55281"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5c7d0cf2-4f6d-41a7-b5d1-cd668504c23c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5c8c9cf6-2c60-43e4-889a-2fd443d680df"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5cd8f50e-5f7f-4494-83e2-db8533a6c5a1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5d43a4d4-1c7f-40c7-9da8-849e005afbf6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5d715f0d-7380-4a63-8668-c90ace749137"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5ddfe70a-7a87-40bb-88b6-580faf78fa27"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5df86f0b-ae98-4ce8-acd0-9c32f000214d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5dfe15e5-6417-4e38-a341-6440a61e2302"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5e304d75-d5df-4b4c-b07f-da5208b86e8e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5ebf4e05-1536-49ff-8573-9b17b4e7f422"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5ecfa55f-3e31-4df5-af6f-c8e2c7741ce7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5f3b8728-d6b9-41fc-b769-58acb17c617f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5f8d48cb-720b-4e38-855d-fdfc14a47edf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5fa0760c-991a-422a-84e2-60671d06106c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5fe3e791-ade6-49bd-8340-37610888cfb5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("604b775f-f227-4e90-9c3e-92b7cca6805c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("60ed96a5-9048-4651-b994-5743d8b99063"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("60fa13fc-336a-4635-b92e-f4990048916e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("61e6f7f1-ed37-4aca-9af7-24c1a3dcd0ed"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62182afb-b2fc-4da6-b256-e59f58b9853d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6242cd86-de4d-421f-817d-06fc7c2ee64e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6245e10b-4887-48d7-885e-cc6c9eab860d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("629616b4-669f-4649-b152-f2a85f6b408a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62c32e5d-2460-4645-a063-57a6e9314156"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("632029b4-c6cd-4ed7-b569-14011c3185f6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("637d3928-3e8b-4035-9804-818693d2dda2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("638829ba-52ae-4542-9c9d-9d8c6e8a72e1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("638b335a-d0b9-4f05-bc88-96cee722f339"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("639d1ff3-0a32-4aec-8a57-b8473b886735"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("63bdf074-d053-48d8-b696-d3f1ca26e121"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("63d7f758-4af6-4c2f-a942-9cf81001c32b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6415f396-e63d-4040-a278-3e1f9f00b18e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6445d9fe-d14a-41f1-a15c-6f04b3f9f0bc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6447731a-e697-4bbf-a855-cf87e52eed78"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("644be0a3-eb9d-42fa-891b-3c365816bad0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("64619a1f-820f-4bdb-bcd8-37cb98021ecf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("64c29dfa-69d8-4b07-91d4-736c35503801"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("652f1e5b-e002-409f-b6de-a531541da05c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("656fc023-5c52-4ed6-b9dd-509ec50fb373"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("65875264-03d6-416a-9dd1-0c9bf0f8e7a0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("65a06769-fb93-4493-9fe2-a063ccbfdb3d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("65b66fae-07ff-48db-8d8c-85e8ca491348"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("65cd684d-6541-4934-b501-c6f3583cc740"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("65d01fc1-4c45-45a5-bc98-ed8f6e15e224"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("66783eb1-6ffd-4594-8ab3-41207336c0ba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6723eda4-b08f-4bb4-8cfa-1f93ff0205bd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6726c32b-9f4b-4cc9-90e2-ce3d060655a6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("676439ef-56a9-41eb-8a67-9238573eeab7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("67785d39-e19a-4737-a786-d3283fe57291"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("67e07631-1ead-4d4f-bb59-bf55dd53996d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("67facf06-5457-4e06-906a-357be76426d2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("685ccdd4-562e-48f0-ae48-75b811f155df"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6894ac4e-0ba1-454a-8871-68cf5d6539d2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("68f133fa-be03-4454-9a9c-8d37dd470a78"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6a7665e3-5e5b-4bdf-9a90-1499ccc28d39"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6a7b317d-a6ad-40ae-9543-8d6b3975cd49"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6a9bc595-b195-45d5-ad39-9b1c5398f20d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6af79536-ba07-4808-a775-69bfd1a051aa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6bd20066-f477-439a-9e77-05f4973be823"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6bd8becf-6089-4697-854b-dd5fa2eea0e2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6c675fec-564d-4318-a211-bacff33465c0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6c933afd-a3e2-4bd7-b8c2-5f3dcad0867c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6ca1b2a5-9add-43c8-bb0e-0dd9fd788298"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6cc74414-3f54-4649-acac-2b5d521f5b9d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6cfeb58a-8130-4ada-8034-abf0b7459c96"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6cff8ed9-4c55-43e7-8dfb-3e6c6ff32202"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6d880406-97f4-4974-ad48-1b31a6e93a5c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6d8ae680-f737-494b-a38d-0fb0e197fdff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6d9d825a-9315-4ff3-9267-0a9f3c640690"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6da05a88-7549-4cee-8937-d91c35df877b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6de06a45-84f7-4648-b1ab-f64e13aff340"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6de22dbd-1dbd-4661-98f4-89af0ef3c8d0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6e41b21e-2a6e-4a6e-b91d-bc908283d387"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6e540d42-2a9b-4536-a922-2221178fcfe1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6ec4322b-1a6f-4be5-91b5-3ec9082b94ef"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6f5553c4-fb5f-410f-9754-b8e504f25d6a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("70308084-9506-4f36-8aea-d74202f56dd2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("703814e8-4395-467d-aba5-007cf480582b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("70ec983a-1c9d-461c-b357-c5a18fa6fd1f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("71143a3c-9101-4651-87a0-9bbb9999756c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("711c40cb-f8f4-4855-b6ec-1f9cafba81e1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("713b7ab8-901d-4b0d-a9a1-cbd9b217467b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("715d3620-4bf9-4a21-89df-b2f21a14dcfc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7176cb15-f7ff-43dd-a46f-112f46443592"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("71a7e418-85e8-4faf-a087-b52493b11df9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("71e886de-7d2d-41c1-8a8f-ae01917a1e47"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("727b925b-5439-4ca6-8942-432c0fe0f167"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("72813165-2257-4570-934f-96d5c5b845a8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7290e6f7-c82f-4f50-b138-5d75957bcbc7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("739faf12-d12d-4fb3-b5c9-5a4b95a9c653"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("73a0c823-4cb3-4d56-b53e-3c31620b53d0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("73f7e24b-dc69-4a36-9c30-30da023816a4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("73f8ca9a-9100-4478-8915-f50ae152eb35"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("74b92096-32f0-42c9-8a6b-e1f313f50365"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("74c01cd3-7b16-4123-a1e9-2333011f9ab6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("75062031-afbf-4213-b000-8ada8c7ddbfb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("75684b0a-5c13-469c-8f70-c8c6ce2caf6f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("75835334-9b89-4f1b-8043-133badb2ba5b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("75a83287-52f6-4477-81a4-95b84ce41ac4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("75c06dbb-a1a4-4385-80b5-2dc52c195768"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("763fecae-43a7-4c98-b6fb-a17ce78816a1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("764169a1-cd06-418c-b559-4e290076bf86"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("766feb84-a03b-421f-8c71-cc06077b59eb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("76b533f1-4ec3-4622-97ac-460162299336"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7708a33f-981a-4b82-b9a3-fd93fba37705"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7713d1d7-eff4-4667-a466-2b9bd4302e47"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("772c926d-a2b9-4f6b-9bf0-bc7fdac32f38"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("77382003-9a55-4844-9344-a84514010f83"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("774522cc-5073-497f-bf66-cc4928169c6d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("776f256e-f848-4600-aefb-ced9d3d3c886"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("777bb199-5c3a-44a5-a93d-ebb4dcdc8634"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("77b629e6-0d0c-46a7-8a28-a91ff9548cf5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7801d6e2-9dc4-462c-9bcb-160011a10e74"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("78a08cb1-d370-4069-a2d8-1a483affc27a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("78d61082-3301-494d-ba4b-882d17f28e5e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7901e028-2c57-4aec-8df1-c2702c05ed50"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("79672253-fffd-45b8-bd0a-de8acbbb8779"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("796a6b9b-0506-469e-a123-0dc59c3d10a9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("796b3392-016e-4c7a-9384-19fc5127a932"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("79d5aeae-b718-45fa-97e2-7b58e04b1f2e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7a049d6c-c00f-452a-8754-71f00f127f7e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7a2ebf84-c762-42d6-a2db-0091327366a3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7a2f1271-63d2-4593-9c55-9c31a2738a1a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7a419f74-eacb-4dbc-bdf0-6644748fea02"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7adff1a2-3ce2-423b-814f-bc38b70a5ba2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7b4ad072-2f90-4223-9a90-7e2d772052fe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7b59938d-e7d6-4d62-9469-a62c4206afe4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7b7c326f-b5d2-4299-80dc-40755d16fcf4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7bad3af7-3907-475a-9c9a-db5465ef760b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7bdaa79f-5ed0-4880-9545-060873cf0fc4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7bfa90bf-5fa7-4a3e-92ca-d8dc91996148"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7ce0621b-3fba-4dd4-80f2-9da519fb59c4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d08134c-8667-4e0c-8d93-2a8176843e66"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d2d736a-fac7-49b1-a9cb-15733306081c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d33fccd-7847-42c6-ad86-1459f9ff2a56"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d6c84db-842b-4b07-8bb8-6d74762b3ec1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d6f5866-72fe-4f33-b9a7-34422c96c8b8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d83a45e-25ad-4623-9d4b-0f0e8cf99e22"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7de13385-ec97-4668-af55-8cf2848c64e1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7e0171ed-b3ab-4ead-9b90-021529dcb922"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7ea3475a-a5c6-408b-8a21-ceca74885335"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7fc8ad30-a672-4093-9952-37d79b6e7d11"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7fd4c0da-b48d-478d-bbdd-f56b627de511"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7fd6a041-098c-4fd8-9595-f905f6c6a5ab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("803f121a-3883-46de-84ea-8cff8419ed30"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("80b912d7-ee4d-4695-b07f-4480e2ae61f0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("80cdd3f5-a2f2-45d3-b7d9-a411ed2f5e40"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("80df666c-d900-4fc3-a8e2-1ee68f124b8a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81128d89-9cdf-4e39-8e02-f9f31d046375"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("813b8931-30bc-46a9-bede-b25bf3fd9979"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81457b21-ec33-4585-b2c4-9ec67ca811c2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("819f16fd-6d12-44ca-9666-26e8339e14a5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("820bb24c-f4aa-4459-8d53-b92588f3e3ea"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("82976a77-9747-4b38-b1bb-264a5a40b7d9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("83e2fabc-5085-489d-a878-db0a08f8f41a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("83f643cd-feb3-4bfe-b631-de5be0919e50"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("844873b3-4b74-4dce-9c85-f67fad904259"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("84d752a1-b5b2-4ac8-82ce-9719039006d8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("84dda86d-c430-4976-b3e6-553e23c785c5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8508d38e-df02-45db-8f5c-76e5352e3668"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("85170250-206a-4bf7-994f-e2a5d64cb8f3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("85749ae4-dd98-4ee8-9fe0-4cfc24e168e3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8653b9e6-17ea-4823-879d-14eb0ad6e863"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("86845cf3-4840-4e3e-939b-81cc8d9eb1e6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("86ba9cc8-54e5-4463-9f88-a5e3be357e27"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87635baf-b4d7-4e52-a4f9-9691b8d80f60"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87c73524-7aa5-4626-a6a4-b9ae0e6f2810"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87cbe09a-bcb7-4882-95a7-06b9c82ff85f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8802da39-81d9-4dff-8d68-2856cf3e0e14"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("888d0ff7-88a7-442f-8fc5-98da3da3675f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("889529bc-7328-4a6a-8d14-ae65ebdebc37"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("88b36b4b-3dae-4e88-b9a1-4b87824c9453"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("88c78cfd-d3da-4235-8ffc-b785a350a0ac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("88ed681c-4a01-4417-9007-51a1021c2a03"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("88f9dad1-8b41-4365-806f-7b7111ab3f6b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("88ff89a7-3e59-42fc-919f-9fc28862bb0d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("890b3147-0f2e-4b66-b57c-158387bb871b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("892e913b-db15-46ca-aeb6-68943154a1e6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("89ee4b2e-acbe-4ad7-9acb-106f8becfa21"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("89f7aee9-c447-4eb3-872a-908abbf31705"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a155e06-d9bb-45a7-b8d3-17794662ce68"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a2564cf-8f89-4114-860c-e009b8750294"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a8b1513-b769-4a6e-abe4-ba5dcd4a5622"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8b2b4667-be05-4455-b218-41ce9b44672e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8b997419-4321-4a9d-a64f-f955d06d6b26"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8b9dffc3-e92c-4e98-87f2-56918b51d236"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8baa06d6-3e38-4d9f-819a-8ac40cfacb6b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8bad526a-4208-42c2-b834-b772918bb8c9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8c7fe439-9165-47a1-9cd2-2de369590962"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8d991abd-7e9d-470b-89cf-bb88cb3d38be"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8e21dd01-4ec2-4f76-80b0-0394ffa5615b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8e2a763c-7885-4b7d-a98a-7ced15284a63"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8e81caed-2659-4b16-90b2-82b0e5be66c3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8eb04526-e949-444e-8608-eb005d802d65"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8eea1e42-5e7f-4d87-92e0-6d49ac997b6e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8ef359ec-94b7-4ddd-98e1-c991193674c5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9001d97d-fe4a-4668-8a25-2376e8437d8b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("900fb668-825d-4f96-bb5a-c6ee710a6d52"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("90400d60-fc5d-4f63-b623-350bb09e454d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("905ef35a-d936-4c54-a5cc-081616067577"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9088b5c8-0872-4d47-9f31-9490f6ae7d03"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("90ca655c-132f-4b0f-99d4-2b1e8e9768b5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("90ec2ac2-60d9-4f1c-b160-37c57a1fa8ed"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("91a4586d-27f7-4042-8f9b-66ec467ecf5d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("91c7c99b-69ad-4f4b-b1ff-a4ba114388f7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("926408d4-71b0-497a-a87b-41dcbb7f914a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("92750c25-11bf-4fe9-bc98-5561d4da866d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("92c0c4f5-fe60-4980-9ddf-30d26731c7af"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("92f29657-7fc9-4c5b-b134-82c25972b0bb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9315ff6e-0d5f-45ab-88d6-d639ee3d4d2f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("933520c2-4364-4768-a922-215fd21f4862"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("93792023-c5de-405c-ac91-8a9e9cce5f77"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("93fb6997-c8b1-48e2-8a66-38b3d5ec2fe2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("94ff892d-e480-4237-8eed-e3162302948d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("96a39fa8-20e7-4a03-b59f-273aa710645b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("97546efa-c2f8-4f7a-918e-b03842ced9e3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("97875e6f-f35b-4ce8-ad55-e1a8a8dada91"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("97dc441f-0fd4-4611-bc39-c102c889bb86"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("981d8c0b-687d-49f4-bddc-e5022b40bfdc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9928650a-f5c6-44a9-b538-b31d629875e9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9983eb85-76ea-4289-acbd-29774bf0f563"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("99afd4ac-d8eb-48a6-a519-51938fab8163"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("99b7a073-e830-4f2a-a106-f73cfa1f3192"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("99ccf9e0-0fc8-4010-aece-c1a48c0e02aa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("99ddef43-25fe-4df0-85d7-b1d641fd5b4a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("99eeac90-9446-4d3f-8d27-1a83f642d49e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9a11b158-1bac-4286-8a4c-fef7e807a84a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9a470eb9-76eb-40bb-8da7-c8f13fee9ea9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9a8d0c1b-fcbd-4637-b436-fbad4e2dc9a0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9aa571f5-c96c-4e45-a780-08f6f6900604"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9aa87f58-c289-4a89-9586-83f20e48163a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9ab06aaf-8f1e-44bc-8c19-b948d1184995"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9ac0d320-ac8c-46fd-9669-8e7468fe3ef6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9ad04395-09c7-450f-a2db-50fdf0c823a4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9b3a5da1-b39d-4c2c-ad10-2235717165ce"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9bd0e686-3538-40d5-8a61-f7bd2598c5fd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9c14d86f-91d9-431d-b706-5e642d3388d3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9c1eb44c-9788-415b-b531-66e1651c9921"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9c46631a-b16f-4450-bdf2-3c1769d14211"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9c6f0afb-5d5b-4e36-8b40-0b9eb03fe6fe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9ce4e365-bb9c-420d-ad91-dc80aa1ae54d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9de12d88-ef92-45c9-bb6c-f7850711ba07"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9e24fc72-02cb-4d9a-8d63-ac4210cec5c0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9e90cb5e-6037-460e-b3d7-69643a7f5bf6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9e95485f-85a8-43bb-8a48-791199138c28"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9e987978-c53e-438b-a88e-38e4cd052aa9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9ea19486-34a0-4477-a27d-be64df1dbb21"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9f6e96dd-8c0e-4749-a5cd-0b8b27c4b259"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9f71ee90-915c-4192-8311-c53ff103d594"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9fe30176-76e5-4011-92bb-88881f8d6026"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a01f087a-4ee8-48d5-85f8-f9369ddf8da9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a061062f-681d-4d77-bcb6-364c52ca6371"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a08abad0-be72-4bad-9f1d-fde9b34ad86d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a0bf6814-a46f-4e28-a97f-948f699c1465"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a0e5d054-2424-44d7-bcf6-f144b5fd7c4c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a10e39ab-da2e-4945-8994-747d4dc6e4c5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a139980c-8c2a-464e-ac50-d901defe8da5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a1648dc7-2c74-4458-a8d5-92b985447ee0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a16b8ac1-7c02-4348-8a84-0bdc8c7803d0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a1a52565-0276-41e0-85b1-69073259b886"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a1a9c981-aefa-474a-a8d5-96aa4b4d029a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a1e26508-fdd8-478d-b615-ed18b0eb0e66"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a2068bdd-30cc-4f29-89eb-9e7a822de0d6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a2187b15-27a7-4a86-b4e7-f052f3b8a405"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a2326fcf-ebf9-4009-9793-f4479b45f76a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a25639f3-de77-4781-9864-fc738056e3ae"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a280a349-d949-4b32-b4e2-35081584d257"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a28f17ff-0044-4711-b253-16b329e1d22a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a2fd7ab7-3411-41aa-95bb-4538c07b0297"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a30738db-3308-4a5e-8c04-99a9fbe909ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a3288382-8278-4a0a-a12c-6fdefef05e22"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a33e25ed-e434-44a9-9771-d8a19adc7e0e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a387df31-f6da-45c9-81f2-624d747b0edc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a3bcb21a-e39c-4c17-8b51-1af00f3c5ae5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a3dbe8f0-f284-4f61-a74a-2372944c171d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a4624466-4d80-4f99-a72f-0162705f4402"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a472057f-599b-49a3-9ee0-980930961524"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a4a8735b-c840-4106-b13c-4f544dc25e0a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a50ee7f4-803e-49f0-b931-0b44a00174c5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a557669f-a585-4460-8265-eaf36172876c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a5e6c67a-64d9-4883-bb07-2445c78ee937"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a6383c5d-1b90-4ef9-8a60-3d26ee81f646"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a6612650-b22b-42b8-9460-3be6eec7a052"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a6ab3466-4817-4e6e-9882-8e96fc63660d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a7637460-dbd3-4b15-ade4-9b9377c66545"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a77c13a2-1f90-4cde-b065-cccb3661ac50"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a7a750d3-121b-4e5c-b0c2-ab499e6775ac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a86e2c6a-fc83-4c06-afba-f87ec7b3065e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a89b1c13-3dfb-4f2e-b39d-e9fc93016685"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a89b26f1-cad0-4696-b7fc-5cab34e68864"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a9265170-fe22-490c-8e87-f43c7bc9e736"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a97503f4-ceb5-42f7-9bf4-61569e21ab68"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a9ccd5ec-f348-48fa-9bf2-b126b874c497"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a9f8944e-a7a7-46f3-8d82-b0a902e11c24"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aa052ba1-6ef9-4bc6-82b9-63784af86948"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aa0db502-4d8b-4b4d-bb23-7718a64de1d9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aa41ec4f-6617-487f-8c3d-2439df90a49b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aa55450c-ea72-4876-a050-ea5c8b70fb06"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ab2d2763-0e19-44fc-8795-737c96654b54"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("abab7df9-54d0-454c-80cf-4ac80ca95138"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("abb6421f-f5a3-4714-a080-8046feee2e50"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("abd79490-6094-4b47-9bfb-09b35faddfa9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("abecabdc-1356-4145-b299-803e9c25e28e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ac3b2be0-3fa2-4822-9c26-23790c552bf5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("acba5ab6-70da-4473-8467-60209508c0da"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ace6f383-a85f-4952-915d-bf95df5164a0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("acfc2556-ac59-4102-a923-db7b047f7323"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ad01ac5d-4e92-4bec-830e-7f9a96bcf0ed"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ad184c3f-6f6d-4c2c-8621-599281684c56"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ad984dfa-2b92-497b-a491-eb212099e8fb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ae3552c3-6f87-4657-a06a-a74386baaaf9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ae54f070-c4cc-4c1b-95bf-261fcbce2613"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ae89fdd6-c71f-4732-8271-a96c7ab50b17"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ae9b8944-fc8e-499d-85bc-1c22dbc061d6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aef0912c-0137-481d-b3d6-a4aa510185b2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aef61b4d-4885-48f6-98a9-e228ff9c6f3e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aef7c2aa-4c24-43b9-a952-42afbf6a0ff7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("af0f901d-4e3c-4242-b910-9417816e284e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("afb42727-f145-435f-bfe7-9adae1a37ed2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("afb448af-4cf1-4e98-a851-50eba0a2f881"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("afe51c08-a464-4b13-ba66-87441452bb0c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b07818c8-f503-494e-90fa-30ca02dd059b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b08ba12b-34ae-42b7-84a2-8f9b99d4506a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b095635b-322b-4b7c-91f5-e295cc573f8f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b18199f0-bf76-45a0-b511-eec399de9ccb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b1895a5a-a615-4779-82ad-fc37cecc8789"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b1ef15a0-23c8-4f46-b685-346d7dd3d53a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b23296c2-eed5-4e03-a4c6-2bfc2a9ead58"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b2488ddd-145c-4c02-9381-4be36058686b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b26b2324-66ed-427d-9978-fcf1e8b228d7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b288079e-03d5-4c9f-8b93-acf89551ec4b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b2b3936e-72c8-49cd-ad64-a55f60a5b1b2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3056009-8ae9-485b-959e-ed59006ecd85"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b31e9b7c-d12b-4b0c-948a-9af72bb39e3a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3360a34-be68-4820-95dd-3cbbb677e5a5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3a8eecf-7808-4faa-a9d4-504cdbd54a98"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3bd238b-f00d-4921-90c0-021825748c75"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b438095c-78c2-4529-9fbc-bbf4bd4fb5a8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b43d9e8e-9127-4a52-9492-3b1934ac63ad"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b44d25f3-37a4-4658-822b-b39c0fce7907"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b45342d3-6179-466a-853e-346b9e0732e5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b49a2f2c-301d-48eb-83b7-c666ba7dba39"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b4e93b14-76ef-48de-8f18-e9c2a670c07f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b5447856-adec-4aa6-8f7a-44070f0bbdf9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b569b25e-d162-4cbc-9b0a-6f7812a000e4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b56b86a0-a043-4e94-a083-c26b5b942e2d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b5d576eb-942d-41df-9f1a-d37a013335c3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b5dae714-f55e-41e0-a786-e996ebb0e054"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b6295fc6-eeb4-4197-8126-582ec079fb59"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b6409a25-4eaa-4cf0-8231-2033ba4d5fdb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b6f11f3c-b7a7-4fde-93c0-e4c6ea3e7ebc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b6fcd966-e744-44bd-bdd5-9dbbfaaed772"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b707038d-f9b2-439a-8889-fb5278ef8b5c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b7419044-0952-4681-b955-3560579ea1a6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b75ba3f5-b9de-4c3f-83e9-cbbc23852ffc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b7834bcf-f029-41cb-a97f-b659ab8c3ef4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b7a6d83e-db62-4395-b1a4-1610e8958563"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b7a9df7d-7882-4070-8808-a95af93b06b0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b7fecdba-aced-4210-aa54-61aacced15d5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b8049eac-e0c2-4fb6-95e8-78d2f185a2a1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b80f2950-f695-4b74-909d-48e1d610ef2f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b81f8c4c-8fe3-4517-8e8a-c85e66807fa3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b825b395-7913-438c-8b59-cf91ab219581"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b852c8de-04b3-4483-8381-b85685419fe8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b8e5aacb-b7ae-4192-b154-0980005fabf5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b91a3ebd-925a-4819-b8f6-b338df34bc80"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b93414b9-43a5-4691-ba03-d8f902b68083"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b9459212-b4c9-401c-8cba-3f062fd501ed"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b984a126-07f6-4f6a-be17-94231b5eea9b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b98aade9-ceb9-4ba5-acc6-85911a7b2649"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b99c22d7-084c-477a-b79d-9b48e4c09d9e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ba19aab9-e641-4c36-bcc1-08d19d29b9c6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("baec76e3-949c-4ec8-844c-35952296c243"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bb1e6b81-7f52-4234-8843-bf82a0340cbc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bb2f1d10-c021-4e4d-afa3-09e532090f74"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bbcf57c3-9a46-4ed4-ba9c-50bb0c4ddee6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bbdc6dbd-d651-4df7-932d-59df46532584"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bc291c50-7f76-408d-ad22-994475adb9ca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bc9cf27c-3b3a-403b-8748-029244f10822"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bca2c569-b30a-497b-910c-697ee5b5bc7c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bd250b12-4feb-4d24-8c1d-640045483c1e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bd70a0c7-b355-4080-b615-66ba0dc7ca2a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bdb016ca-b2c7-4849-b5ca-11b2a9b06616"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("be54ade2-6016-4b6e-969c-c88a6c09c31f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("be8c4177-f04f-44aa-bc25-19748f82029f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bf07cfbc-ed6a-4983-a0c4-59fbbd57f6ce"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bf6033a3-dc20-4215-8dad-a8540fbcc5e4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bfbbf984-3236-44f1-a3e6-b418637dcf15"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c024e9e0-2ee0-4a85-8c15-1e1bdd38b6cf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c048008b-d1b8-4dbf-b327-33780be7451f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c0e48abb-d315-4d95-a034-c2f0e9c50e88"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c1064a10-c761-4a5b-87bd-fb4c9191c4c4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c10d0fbe-f55c-4be4-8c95-b442d8677df3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c123c6cc-a47c-429a-beb5-4827b5196f63"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c14d2c98-1f8f-4dd4-b595-4c6dcf6a4649"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c17726d0-9a1c-4b09-a864-e0515f36128f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c1a0289f-9412-4979-85ab-9c19b82f7aab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c1f56312-6fbf-4e07-8019-099ba3d8e843"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c29bb647-6423-4d9a-b282-3df11f071443"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c2cbe95d-4898-492a-951d-52111052f627"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c2d4623c-ae7a-491c-85e3-3b0d9a72b25e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c31da60e-6eb1-4164-bfc5-c39d8ce272c1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c3c6e7b4-ea23-451e-ab54-e2cb89bfdc09"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c3d2287b-9189-467f-8044-fcfb60d5805c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c3eb2021-452d-4dab-8cdc-afc6eb7a24a8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c3f3a35b-b823-4872-a9cf-6f162f3e27c7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c3f4bd6a-6363-4026-877f-fb50e5a98ef3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c44533e2-e0bc-4bad-a699-1ba8f57697ea"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c471f838-4ac9-4f9e-8d61-29013671edad"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c5242287-5e20-46b1-9df9-08feea14925a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c54da52f-f9ea-42c5-91da-8deec4efce4e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c5847c86-075d-4d05-b50f-d03f2a63b274"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c5edd4c2-ee26-4ff7-8f2b-c9c0ebfddca4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c60cd5e9-3e0f-47ac-b67d-8235d6e74530"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c63d3c06-8bc0-4661-964c-604a4cc30ce7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c644945a-1a1b-4fe3-9fde-f82e255aa8e9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c6df534e-2262-482e-a539-8c59628697ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c703ecb3-ada3-4394-98b9-44bc32825a37"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c736d0c6-9f22-4c7d-a0e7-727e60b52ab8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c755c898-3516-4c83-a729-78af7796dc17"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c76a145b-3d0b-415f-89fb-ba2ed7df7ef4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c7821482-b270-4c85-88d0-880c3bbac8bf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c78689ad-936b-4fb2-a671-9e37d4a5e544"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c7bc0a4b-5f1f-410f-92a5-c0a035b3da8f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c7da1128-a9f3-4cd0-8ae9-82c3fcfe645d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c7de246f-09ff-4eac-aecc-364627dcfb0b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c7f84ca5-f64a-4503-826f-8c4c8b351f8d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c828d1ad-1618-416c-bd97-103fd18ea2a6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c840aeef-101c-42c4-9bcc-a38ee3003c8a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c8456b57-0432-4e16-b638-71c58e047af6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c8e990fd-ae78-4a00-9bfb-633f026bdbb2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c942dd22-f4c1-4e0c-af93-38a02eaa31eb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("caa7f5dc-392c-4de7-bda5-26d7a921ec29"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cace7809-8879-41b0-8bb0-1bd980664e02"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cb2dd703-76a9-48b6-9bb3-1d5d2cc6a74b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cb412ba1-10cb-47a8-8628-e728d0eeb65d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cb58544f-f418-4eb0-b03c-4defa383f1a3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cbd82cb8-d29f-45f8-b8a4-bba4b9025c78"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cbdcc32f-b8cd-4770-86fe-8c32961787f6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cc4d944b-33c2-46ef-a000-56f7822e17f5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ccc31ab0-bbf6-445d-b507-751c885378c9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cd0d35d9-0c3e-4892-a8fb-60060bb61f24"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cd87c69b-409a-4094-9e40-cbc9e899d121"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cd9cbb58-155e-46bd-9c96-b8a28d5fcc76"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cdcdc7b5-f1c4-4846-a95a-f93170904972"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cdf07bd9-f837-4a17-acb9-d3ba58562d8b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cead975b-48ed-4301-b8f8-e726f251696a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cf01ca22-92fe-405e-9d28-156998082025"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cf03d12b-1f59-428c-886c-c8837544d616"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cfb5aed1-6a0d-4869-875f-e54c027dc6f0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cfb7cf16-5fdd-4ed7-a559-d078ee125200"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cfcde0ca-481b-4a7b-be99-466566a31042"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d0053ad7-c057-4573-a5a1-2be2dbfe3d70"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d01e49fd-747a-46fa-bbe7-c0363afb620e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d0638e2e-774d-4290-9ab2-d651f0feec91"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d0833927-8a25-4be2-b808-65ac8d6bbc28"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d0b20163-c7bc-4443-9500-65a1da43efce"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d1283054-fb40-4dd5-9548-6d1bfe53a689"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d1780d30-75ad-4d0e-a3a9-9526f527039f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d1ab0f9e-96ac-4612-864a-844ddf966ca4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d20f087e-525d-4448-b345-92ccf0fd94f1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d278e97f-6298-4a29-8a42-da8046269678"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d284aee2-9e83-405b-9028-b4ac5ede13d9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d2c4773a-6fba-42af-9df4-45b79b588ec8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d2c5f371-043f-4e48-b612-1416be45ca81"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d2ed86c7-5b91-4dd3-a086-9c74ab0ebac3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d37cc1db-6040-4216-b6c3-8671ed8b0641"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d38e49a6-133f-494b-8730-5ffad90e02cb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d3b2655b-9281-40cc-9ccd-2ffced4d829d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d3bf37ee-8232-445c-b83b-fc0516ac8f86"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d3e68e70-c27f-4332-816c-0f8b7d94860c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d3fb9041-da40-4ce4-a85c-96ec011d7bf9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d483339e-8d13-46b8-a858-0e5df4b1d0fb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d4906112-0da1-494d-91ec-8ac71f368d06"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d4d47da6-7f80-4df0-8e10-3980ecf78c92"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d4f370ab-bfe1-412b-b2f9-96fa11ab395a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d5403e4e-d3e8-4e94-8906-bd08ca06540f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d5730454-3aba-4425-aeec-67cce0cb785a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d598e75b-6b35-4172-a27d-3b1ef6934b61"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d60878ca-9f77-40ba-bc71-560e064fb544"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d6321c83-23ec-4b34-9020-c72cbd0acc50"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d64f33af-48c3-42d9-a97e-cb42315f9993"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d65a219e-ea78-4e75-8c12-38919581e227"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d6fbdd6c-3c9d-4cb4-bb9e-ef54bcec8bfa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d72c7960-d036-44ea-a125-24e7018674dc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d7f82238-9ca1-4e69-bccf-c30ccfc59eed"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d809906d-4f04-48d3-a368-56f99a31b560"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d839bcdb-b5a0-43c1-af86-b5cca7c208a4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d881bd9d-5474-4cd9-b865-8c2b2d9ae168"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d887357f-c0a5-43db-8b71-0fb3da0736ce"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d88e0014-989e-4452-abb4-c215f85b8531"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d8b7e2c6-d85c-4616-ab9e-343573d8046c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d96621ba-bbd8-4530-a5c6-d20503d7856d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d9c2a1cb-6698-4b34-8854-6f9368cdd63c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d9f84ed8-2dd1-4e7e-872c-82a78c58ddc5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("da0b165a-4d4c-4869-a4e1-dfd560bbeb98"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("da0b5c60-15e2-428f-9dac-1fcf37fd056b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("daa8014e-ce74-4a20-b604-3b8f97d468d3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("db143a62-97a8-476a-92b7-9ef9416aecc7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dbf15525-0c1d-41b5-98c0-0768aa8327c1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dc793e04-19ef-4e60-8d7c-2c747022a426"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dca4acc9-77d9-4acd-bad4-4c257bf8b3a1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dcde5e7b-5cc9-4892-9122-48e4d481f28d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dd0aea5d-ad63-42b3-8b52-3384eddbf9ce"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dd2e6870-c444-4e5f-bf54-4d10d7d1d3da"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dd480fff-3e94-49fb-b278-6469cdf35349"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dd98a0a1-5523-45b5-81d8-83752c56bf4a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("de4d2c2a-c6af-4a0f-b12f-3aefb87bbce4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("de512397-9d94-4b21-a29b-e0013864fa1a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("df165dc6-12cc-4a60-8605-708281464f58"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("df2431d7-6b1f-4933-b614-c2bdd64a593c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("df64e922-2cea-474d-ab73-96d404c224b6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("df8ba60d-1e41-4b09-ad66-7a79ce8b05f7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dfb71f00-b7fa-4e9a-979f-cc7de04c7355"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dfd40f2a-e9f0-49fe-9a1e-a83efd3246e8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dfd8f0db-675e-40b6-92e3-c5d76bee5cc3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dfe5ea50-4168-46de-bd49-1d9205f84b87"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e034e59a-bd0c-46f4-8756-ec5257a985b7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e0c32d0b-4b40-438a-9944-537cc079913e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e0e2aba5-29e4-4c6d-afdf-37836cf3f4d0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e0f87145-ef1e-4417-b09b-63946fa05dbf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e1eea32b-f86a-479a-8f60-abd1e5afa42c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e1f075fb-cf37-44a6-9f94-89303a491342"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e22780a7-2d7d-4d1c-9d7b-b9298a5bfc13"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e2441304-d829-4649-b2d6-ef2d8b0c8309"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e2461344-f491-42fc-afd8-b61c6a44c304"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e280292f-cf97-49f9-9d02-fd878c267201"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e2c43aa8-63d8-42d7-a12b-089d9c697021"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e33d0ed6-6a96-4818-a19a-ad21339fd58a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e3954e81-913c-4903-98c2-ae46e3a16791"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e3d14b54-868a-4036-b6cd-a0ff0be01ae0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e40d6ba6-8f44-4e3e-9484-f9a22f2ac1d1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e438cd29-87f0-4cb2-a46a-a529d051897d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e4422399-0891-484c-bf78-ed0db310d9e9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e498c41b-e080-49b2-bee6-59359cb8bff1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e5081412-09b2-4437-8c32-5601c2503e34"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e694f264-990a-4256-bc30-e086e5ef5667"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e6fa8211-af34-48b1-a18b-b5b1189f2164"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e702635e-986f-462e-b9b4-91aff7556267"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e73e7f9d-bcfa-4713-916e-8e973cfa9f3f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e7a7ec10-fd77-4c46-9586-6c43ca34bb7a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e7cfc70d-1cae-429d-8776-ac7914cf8d31"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e7ef145d-ff83-46e8-853e-e720b546b255"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e85d7a90-7956-4646-9128-44077692b870"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e863fd76-18d8-4351-a83c-02a0e56c1610"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e896c9be-1e6b-4079-9a8c-d615a83183b0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e89c6d58-c512-44ba-9f03-2a13d994bd6b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e8aa2a16-fe81-487b-86d6-c511ba62b6f7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e90d0a86-8634-40d0-a8ed-4fd0e6113a29"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e9720ce8-2224-4b0c-af8f-2daeacc221a0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e9fea921-ac1d-4961-91b6-1a3dd8f71806"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ea5627c8-44a4-4772-b53e-a2903e7550fc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ead1a252-8c5b-49b7-ab90-3ccd793eb2d6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eb06c4d4-7fb1-4c6e-9bc3-13b7faf4bff3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eb102c66-aa94-4a6e-b1ea-d2ba579db828"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eb485f03-a036-43a5-a07b-fcd5032dd010"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ebabd207-f834-4bce-a3d8-ec2e9fb4ae4e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ebb47821-d8b5-49d5-b494-13fece9866dd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ebba12a3-fc44-41fa-8bd3-cedc8155b581"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ec10d40c-f7af-4f23-8819-6cc46c540eb1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ecface6f-15bc-4602-bb93-f2f03e60aa6c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ed598d99-7bd4-4b09-a8d4-6437b0ef8eba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("edcb8d9d-1397-4be5-8ac3-06f2c7fbbf2f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("edf9b92f-8910-4e55-ab12-bf062eff4642"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ee2c3a5e-f54a-4751-8d67-2eb157c4ce6b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ee837721-4fd5-4f6b-96c0-23bc98153da9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eeb5ce94-77f4-44ad-9d7a-757b16d849be"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eee72f96-9205-4b76-9d2a-edc0a5cb3a92"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eef7d4d1-a60e-400f-a065-f89232fa1e79"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ef3ab9de-1217-40fc-8ba3-8e5483586e18"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("efbf2dd8-252f-4129-aea0-ca9b34a40cdd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f018e733-3438-470a-8479-2cfd60896d16"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f05e11f5-230f-4d42-a46a-b6b41801afb9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f08df615-b35b-4f7e-8b0f-c4628ce6ee88"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f0b90918-bc50-4e0f-b898-7d2a9abe7a50"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f0cdfb2f-6ade-4be8-a74d-dfe9b89f6087"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f113ef8c-f6b6-4196-b399-87329df6ca85"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f13650a9-321f-4d5c-92e7-6108aaad07a3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f174587b-7280-4ea0-8255-08626d0d796a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f17ec0f5-8461-46a2-bcba-10e72eff9f72"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f1f1591e-a130-45ce-8482-7ccc91203fa8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f2053b2f-4a9f-4adf-8b30-2fc785756d5a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f2528da5-0374-4fc4-b21e-4753708db6cc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f2681663-6a44-4692-9ef8-683abcb8a067"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f2b6c793-fdee-4e5a-8175-c17fc1e916a0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f2ccc2f9-88a5-4a26-871a-66907d76a47d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f2e34230-328b-499a-bd4c-42392135490d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f32eb286-ae06-4bca-9d21-6ac7d9d0447e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f3a7e93b-2b81-4e57-9c96-2d5d320da020"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f3c36acd-9609-4e46-a646-b38374fbbdd9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f4054b7d-4106-4316-a83f-c75017a321c5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f406bbb8-83e0-407a-b062-8a0b766b946d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f4070e1c-53db-4814-b649-654b2eccc036"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f484b4a9-1797-43b8-85a4-39c7d9431126"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f5100ad0-978a-42e4-a928-a8495c0dbe44"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f548649b-4750-42d7-821d-fa9207298733"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f5613bb3-bd3e-489d-8618-b2193495d71e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f5d062a2-026e-4df0-98c8-12814fa652ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f651d220-ee5b-4f8f-89e2-788728a3fb8c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f652ddd4-304d-4c73-8365-f1b1fcb9082b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f7117c30-bc9b-4fa8-9d86-911b32f74ff7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f7288884-e7e9-4361-97bf-7cdae85c9bc4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f7987b11-dc1f-4f3e-8567-0da8a7d29a39"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f79a0f0d-7df9-48c2-bbdf-635bb40c9a13"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f85b3678-5d6d-436e-bf6c-cfca8d915996"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f89251f5-7145-45d9-a0cb-9df8ec035da2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f895ba6c-c6a2-48d5-8f0d-7470f80df740"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f89ecf38-1225-4327-b61f-56d4c4f7724b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f94c6a7c-4c12-4ecd-9113-9548422594c9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f9735b9a-b417-4d60-a4b6-8df7c46b0059"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f9fbbdd0-d091-4479-b9dc-85bdf3ffb64e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fa1377f7-a192-41d5-9da7-008343c8d082"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fa8e715b-c493-4d2e-9c83-effb341a3fca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("facd6751-c8f1-443e-96e8-2a71203fc250"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fb970bd4-4726-43b7-903a-4d422dcc596c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fc23e750-0838-40c9-8d1f-91f661a02daf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fc269b38-6b1d-4ce5-a6c7-cedef0cccfb0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fcc33a74-3fb4-48d2-b08e-427c32d6732c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd00a27e-a757-4aae-811f-63bac7758811"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd0996c3-9387-44d5-9fec-b80a8605fcdb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd0f4e97-9820-444a-974b-d27174323bda"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd39fde4-8e07-441f-8a7b-815714bf7051"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd4a7e62-fff7-48e6-812e-5e4040b36052"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fdbd6100-d45f-424a-ba46-4ec684212d47"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fde01361-c636-4154-a3f3-78bf167f4448"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fdf77172-8288-4188-a9cb-f2ad6d9e3390"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fe00bc5c-5ed3-443a-8355-de81525486b5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fec0255d-4045-4281-8b91-2f5ff071ff56"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fec4e172-80aa-4c5e-9efc-e0e093510a5f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fefc16a2-1087-48bb-a7c1-b820d1e1f6ac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ff532704-4f94-452f-86b1-0b532caa5bf8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffbedf8b-22ef-40bc-bd21-cbbbd6861f03"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffc96f26-8d32-4f36-8403-2561aa3e8e5b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffdb80de-ab76-46f4-899e-cb429cef02ee"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("9e88b5c0-908e-46fa-b453-232bc2611ff2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("000c82ed-f12e-4386-b567-cf4fa6ca9ee9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("000e6dae-cdbe-4e79-b3dc-5060f7954ef1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("003b5e90-2a5d-4795-a257-059bd3ecc875"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("005104a2-c83c-4900-ba0a-a782e16e02b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("005d7d2d-9ca8-4ee8-aac1-09c19387e2eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("006ac1cf-c905-4911-838b-099c5d7227c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("007efc54-64d4-4f7f-85dc-694db1282d2f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00efb09f-9c2f-42f1-94f8-c6ca143bac2c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("016b1f1c-e215-427d-90de-e5184a11ea6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("01890211-dca2-4658-89c6-66a9b9f2f668"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("01f82cf1-be81-4d6e-b08c-6636172532f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("026e936d-a31d-4d21-b174-7aed498a8767"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0280b861-f8ac-404c-b269-19e67b37514a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("037d89f7-3240-4aa5-bd99-e298b72a2b63"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0384db44-b41d-4234-8e69-7ecade758620"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("03a3f6e7-079a-4178-b8e5-ec546fed0208"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("040a350e-b922-4873-94c6-c843d8960059"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("04107e3f-2b27-46df-a458-1c71d0c022d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("04490845-7303-48ec-b833-5a1d87a65065"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("046c1d03-2cf8-44f1-a815-a77d5a89afeb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("046c515a-fa18-4e57-8fee-8283461fe412"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0503be6d-a47d-476c-8b04-00269c24ac8d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("05b31a42-b844-4dff-97b8-d0828ee2fa4c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("065439c9-fbca-47e3-9d3a-f775a4d3f9dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("07494704-817c-473b-b70b-f7c03a577a12"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("074e69c8-9a40-4a8b-af17-7279e3b4826b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("07569347-e1f4-49f8-ad40-8d8fb1428a59"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("07d0667d-cfe8-49ac-a81e-b6c52742fc07"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("07dae015-259f-4782-a736-e26173747cd6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("07e60d1e-f81c-44c7-85fd-28f16ec31270"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("07eb0968-17f0-4167-84d4-cef3409c99d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("081b987b-0a3d-490f-b399-ff25bbf9829c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("087457bc-ad38-48da-ab4c-1ff0cfec0893"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("08b07cda-6b6c-4010-a845-3b005c4ed70e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("08efa311-32e3-46b0-b2cd-1d00681a60a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("090a1829-afff-4ee6-881c-6c93e091f4c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("091afdd6-4a5d-4892-afe4-1889b1a5abdd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("093a5480-b74b-479b-bd38-d145a0637d7b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("098ae222-c72f-4001-b3d3-ec0bb2bf0c3a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09902f88-c534-424c-afbb-13b0fcf12ff5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0a6b1441-1b98-4a35-8ecc-165bc5b11e3f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0a8e7631-be0d-4e2b-aecc-0dcfcdd7767c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0a90d2b4-7763-4bf8-99db-3b3b7639b1f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0a97fe0d-4bc6-4231-b0bb-703ed579908f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0aff9ade-7187-42ee-bdfe-472dcb976523"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0b0e0abc-dcab-4e59-b718-278faf47d9e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0b7c6d8c-df9f-4b71-95d2-bb350424c4da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0bd67e72-fe21-4fd8-b781-d1efafb7aa77"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0c0623c6-a268-4139-b36e-0e2f3a6e2b2d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0c46615a-f391-4d32-a8eb-50c8bea06e78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0d92054d-4a46-45a8-b702-ba0bf75594b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0d92e0cf-43f4-4e35-be05-4adc01d6c8c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0de9d5c6-2048-4d01-9b70-7b1fc51c8249"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0df0096c-e265-42aa-9290-c0fd582666c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0ef05128-bdd7-4b00-aede-fcf4ee3b07dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f79194f-d966-4785-9dc5-f0cd74fe6ca2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f939fe2-ee3d-4310-ab42-49141d4f1203"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10a89ed6-d64e-497a-9c67-d094fede8ce3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10aea879-379e-4f6f-9fa7-8644cfd35272"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10d6a21e-a299-4130-abb0-362e8fc4f777"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("112cbd6a-bbaa-4662-ac03-e665c50b9298"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("114ab360-455a-4e5e-bfe9-4bd3159a6d93"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11b90ac7-d0fa-4e4d-8e7b-857018b6ed6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("12720f74-1485-4163-b51e-0273bc7ccea4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("128097c9-64cc-45e8-87cf-47f9d7c5f331"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1297a339-737c-4039-bcb6-bdb90dd87c5c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1303245c-6c18-42eb-83e7-8fdd54dcea0a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13210a79-9362-4360-81ce-6253bdda03c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("132197f2-3af2-4a79-b282-ce5d1d415bee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("138b362e-015e-4152-b63f-24675a8d4b96"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13977ee4-f1ab-4417-a7ba-e50cdea73934"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("142c40da-4603-4cc1-bbda-6f3bc91ca2a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("151dd3c8-eaad-4166-9747-7a2e2c878909"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("15f2a458-2da8-43c8-bbce-1c05d289dda6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("160bb2b5-64e0-4b90-a17d-9d1b9799c9ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("161bf918-17f2-40a8-86eb-0abb3d654d4b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("164d28f3-73d5-4a2f-a235-7c4ba102ac1a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("166d08fd-c085-4f25-8221-2af854ea4b4b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("16d46600-7e71-4b70-95fa-42100d1ad17f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("171cf6fb-a173-483e-a3ef-228b5b054680"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17a5323d-0ba6-4ccb-9126-ed5d4b31338e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17b97ce8-801f-4d1d-a3ae-6a98656c754c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17d76355-aa64-43af-9ab5-fb718e7224eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18024e4d-f6a7-4471-8015-530beaea9fef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("188676c7-87d3-4a96-8a35-3796f34e5594"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18e7e330-87b7-4c38-855d-b251465a5694"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18f80eef-0767-496d-ab0a-9f56d96dd0da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("193211f7-8da1-4ddf-a685-44ffc16dcfad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("196185db-379e-4dc2-a893-890ae1e1d246"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("19a9d4b0-3726-4c33-8f1c-4eb93420890e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a738c41-8e1f-4520-810d-74d51898a520"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a8908eb-1dbd-46c7-97cf-219c4a9b7c30"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1ac30d66-d068-4f6f-be74-1500b916a859"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1ae339f6-fde1-4a29-924b-785480e9e55e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1afc8e57-14ae-4987-8266-b3693eb4daf4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b1f39f6-2b25-478e-97c4-dd87b3b2a624"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b82f153-ac13-487d-a506-53045e2a4436"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1bd85702-e241-4422-a6d3-88e518b95736"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c1870dc-766b-4ce1-a605-a743e09c2bea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c2c55cd-0e6c-4ef8-bfc0-a6ecf98ca8b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c7648fb-ab44-4eb9-b432-f8d6e4ea8afd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1caed79e-abd1-4692-b44e-3af4a08b6e66"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1cd4eeaf-32e6-438f-bdca-1eb384864b40"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d2aa8b7-e09c-4bf2-b88e-029eb45fc415"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d461da1-1c8f-48a1-99e5-68d137a44184"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d6fc02b-4473-4f3e-a801-5d3d3646a0c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d818ee8-c41f-43a5-98ca-f50f98363af9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e6c70e0-57b0-484d-9249-11dd9aeef688"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1eab1258-ff55-429f-806c-694c3c8f3ad8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1eb972fd-48d0-477d-bf31-1c3b187f87bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1f08ac6f-a2df-4b79-a539-6fbe0001784e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1faf4aee-4e81-40c9-b51f-a31f614ec2f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2013d03b-58c0-460f-a7b2-59fbcd3fe454"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20476cb1-4f40-4f67-8669-21e66167962d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2047e065-90e4-4019-b9c8-efb5d4b60883"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("204be82b-870a-4e54-940d-0e1573f38ca2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20992a20-e1be-492e-a441-d25d19f93064"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20bf8f9d-4376-4089-99a1-f4d3fb6c9228"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20d330a7-ef8b-4a33-8fff-9915a9b30292"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20ef006d-2565-49fa-abf4-7e97319120e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("21531760-fd57-4699-b137-8ae7ca4b7edb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("217a810c-cfff-4735-8fcf-ed87323e7b3e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("21af1fe3-f6ef-4a24-aa16-0285340a2bd2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("225bf789-6036-4d14-a4bb-351bc43f2783"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("226c62c4-3c2b-4f02-8726-1b0471d8ff9a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("23175440-3515-49c7-81e2-b2799e97bc39"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("233253a1-bda9-45c9-9427-1918e695ba47"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("236abb32-851c-44a7-a967-5ed3a108e47e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("23933a02-bd48-4d38-abf0-0fc06c5ca904"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2397fcb7-b467-4b2c-af5e-8e59a92f3c25"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("23abd39a-4ed2-4835-b031-1a61584e1f8d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2402fd4f-7556-41ce-9379-0498071b26f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24050476-0321-4bce-9b34-0e1be67bf92e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24ce951a-d7c6-4615-a9c4-0925604cffad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("254c84ea-3b99-453d-b9f9-5eceaf56118f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("25739987-db0d-452d-a9b1-12a35dfac0d8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("257a3654-ddc0-4298-8f02-fa8679462094"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("25ba04c5-6a9e-4d8a-b5ee-74b4497caf56"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("25c4b724-360b-4af8-aba6-f2141bff6c71"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26438cee-7061-4241-b91a-96178a4b8d22"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2692d381-8ded-4f5f-9c1c-778c9b20c4e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("269b878e-c282-4182-8be4-11be265d257b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26a7411e-a68f-49b9-be43-6b8f5cb98aed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26bb1579-64a0-4439-9f3b-2f391895f106"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2701d585-82fa-49ad-abe0-8f6c78e33cd7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2723dc4b-dad5-416a-9543-bb00fbe78034"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("273baf52-2798-4d65-b551-281f609b3db6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("27788e67-fcb0-490f-89ee-e4831a38dc48"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2798c7c8-0d5c-47fa-b2c9-d52d1e67b50f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("27d5cc7c-b12c-4d38-b0f2-b5e54fa57ce2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("27f1e0b7-0208-4c1a-993f-438a8425e381"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2831bd5b-ce10-493e-8633-644b9cfe9738"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("283f182b-9d13-4e75-91c7-2e0df30a5bc6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("28d97ced-8261-4adf-8a50-ef5de9e726eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("292efbe3-3760-42eb-960b-2c3cf77a3fc6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("29499c01-095b-4b9d-9599-552cc082beba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("296a79e4-b716-470a-a93a-812a3938ade4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("298227b3-9bf0-47a8-886c-865f3800701f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("29c8fb27-8c61-4c1f-9771-b8ed043fcf55"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("29e3398e-5b08-42d0-b93c-abe7c8bbeeae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a032026-83ee-4079-8899-417e96cb19f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a3ffb09-da8c-4d47-84db-65b2e6304be0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2b3babf1-c2f2-49f6-af4a-300323c81582"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ba57745-4389-400a-b05c-588ec1dcba02"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2bb71f76-40c9-4d2c-9206-d2db5283069b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2bf093f6-dd90-4502-9a72-0f625fd07657"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2bf90f4a-df71-4e0c-8aeb-255bf41c6f8b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2bff01b8-b83a-4337-afc8-14453866f088"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2c2ac647-6497-4526-a5cd-9cf83e756166"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2c4a1aa2-c2d9-4a4c-a786-7d11a01438c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2c78cf0d-773f-4c7a-a0be-ffe986ae8e13"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2cabf8a1-612d-41e0-ad71-6945377c1e7e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2d71e1e0-a054-4927-a725-8d02635b07c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2d86ea7a-2172-44f0-b826-e9174bce933e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2d8ad373-9daa-46ce-b273-f470189fe9d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2db17597-84f9-4ef8-8214-3074dce83bca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2e2e5a74-1ca5-4003-ac25-9b7062e5e432"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2e37cd67-9256-477e-b708-a715e512027f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ebe3cbb-e63a-4d14-bfd3-ba5dd18c90f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ebe64ec-9241-462e-a469-6e57e369ded2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ec93b74-e158-4993-a73d-fc13741b8e85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ecda3ad-521e-4d7b-807a-9f08b2c1a433"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2f245a58-0b00-430e-ae7b-0bda5ce4fabb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2f9abeab-ae9c-419a-8413-247da6ce620a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2f9dd698-0afc-4a46-bdaf-784b446b3e4c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3069aecc-adc8-4243-811f-57e5a2175b2b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30b43c98-6a86-47aa-9a73-05b7dbbd787c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30cca756-0eb7-4f07-a74d-fa7032555714"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30fdbaf8-ce87-4d4a-9fe3-3a6baaa71775"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("312b5941-d18c-4dc4-ab63-afad5a6f0af8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("313c2e13-6837-46cd-b569-d35800ece16e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31949f5f-5fa7-4890-809e-37be25a82c42"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("32078e1e-2f98-47db-81f9-cd2809775d40"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("32a92591-5b4f-48af-bbe8-bbea8806c2ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33b77c43-4514-4f6f-a724-ebc663678b8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33cddaf8-fc8c-4070-89dd-c0e2e4c8b923"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("340016f2-3a43-404e-8b7e-82c8be04dffb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3441fc61-8128-4678-8f46-d96adbadb869"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("349a2509-a7db-4de5-ac84-7a275e8ac9df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("34f9c25a-e786-4a16-9844-9495c0ef09f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("355441c6-f578-4c32-b13f-fb52175b6715"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("355b593e-9ea7-4a60-a458-15fe8c011c14"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("359fa368-ef29-4928-9e51-fe7179298b17"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("35a3e36c-515c-4615-9150-aad47e092161"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("35ba5021-9ac0-4080-beac-9740c758b9ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36259f4d-d2ff-4abb-9bd2-2c7a5ec30844"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("365d552a-1405-4fff-978f-3dddae65b49b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("368ae8f9-d08c-45b7-ab00-84a61ceecfa8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36a48c55-9519-4a50-ac4a-fc314b36e542"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36a71abf-b9f7-4c25-8330-4eeed78811cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36c27ce1-27ef-4b93-9ee2-b98f770c9ec7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36f5544b-d4a1-4f16-9165-1ae215830f33"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("375200fb-9d4a-4564-98a6-2d0e72c53734"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("377e5cc0-b525-4c39-b671-cd23e7d72957"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("37bc6491-29dd-40f4-8e6e-13db01d3b834"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("37d9fdd0-d91d-468e-acaa-280a09943628"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3835fdb0-9e8a-46be-8eb5-2865facec2ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("383ba8a8-354c-4545-acd6-5b8e176dee03"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("384afe0c-d5e4-4b04-a4ed-0b018089903c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("38736e56-92f5-4b4b-9826-1ee2043b640b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("387fb657-9ae8-4c25-baab-86d8e583f2b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3892ad22-e283-4c38-afcc-de2e65e74d9e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("390fc07a-d094-427a-a874-30c923499839"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("391454e0-8071-46de-8c9a-62cb63f573b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3998808d-b321-4b03-bbc0-e5546f47e312"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39cd0fcd-dbfe-4ffb-8b10-41f76d383d0a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39d9c5b3-953a-40f1-b2b4-8c0a3b5b3862"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39eb47a0-4aa4-469a-bbb1-d4a2078053f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a4a8422-c87c-4323-a9a5-3b91fc80bfaa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a63e45f-6a85-4231-b933-878a562d36cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b9e3690-a030-4f25-9760-bbed92c2636c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3c15fa6d-2bb1-4ba7-a8e5-afdb4f8d1725"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3c8cf5ee-e761-46cc-a15b-94bd3de308f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3cc06400-42c1-483b-b728-b7efa081428f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ce1b524-9a69-4549-b703-4cce57e15f97"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3d093360-fb41-4e2d-91be-3fedd7b0ae58"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3d71f050-06e2-4293-8857-253e202a603e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3d98a763-3a1c-4956-bb0e-62f47860761e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e776ef9-83fd-48e6-b7db-360edd314027"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e87d34e-3620-44ca-9782-c9b486c68fda"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e90a162-fcc8-44bd-835e-7c0db825cb16"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ea5651b-da75-4ee8-ac10-43af0ff6a968"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3eec754a-8389-48e9-8ce8-f78a7a93236b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3f499d80-967c-42c8-be05-967f851440cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3f8cd8d3-15b2-44ab-b5f7-f3425ba6e861"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3f91ed29-79fa-4d1b-9196-5bf0afd221dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3f94574b-daca-4d8b-806c-88a261d183cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3f969377-8e95-4386-88b5-3cce7c9a08e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3fde12e5-fe1f-4402-b721-99a138f1c623"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40236876-dff0-4c57-afba-26e124b6f3b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("403cbe1d-3d8f-45bf-97c7-9ee9207284a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("403ff196-dcda-464a-980a-947260f9c467"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40d2d254-512d-496c-b163-ca613487a379"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41885544-c0ae-4818-a25e-b373dbf32ef5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41da4c70-b1cd-4437-a311-bfffbb3f0570"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("421b435c-c80d-447c-a5ab-40b7f19e0a58"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4250d225-9281-4add-9cbf-93f425e1bb53"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4263b76e-85e3-493a-85f6-9d14fb3f7f06"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("429d2857-7ff5-4841-81c0-63fa1f29c5c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("42bcf47b-a043-41b2-8002-71dd349ac678"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("42c3126f-3d49-435f-a59c-a99514ec240e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("42e560c5-bae5-44a2-ae05-4b731679eac0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("42ea69d0-e88b-4a3b-ba41-7708ffde0f2b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("42f96fb5-6d9f-45b5-a821-3cdf99e09a1b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("43738534-c9f7-4874-886b-ce90cce3c1af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("43d9f8ff-f3d4-440e-9320-7a66892a17b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44364c36-9431-4aa0-9b48-03bb7fb4fc40"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("449ed62b-9606-4e35-a5fc-d45264d6d3eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44b2e45a-4a43-4b47-8cb8-d55cab37987c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4514ada9-0599-4242-bf7a-b2df70587822"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("453d1491-07ee-443d-815d-854552039d96"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("453fe6dd-e8fc-4dce-b8e3-18483c9f4336"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45447b6c-63f6-467d-9858-d879942277bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("457bea00-e453-440a-881e-a73c6a5ef27e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45834685-afde-4b40-a896-8b3440b94437"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("459dca4b-d06e-4b22-8d2c-4a8dbc880df1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45f6738a-c42b-4c2d-ae09-1f274b08198b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("46dd9da8-d722-4237-8d98-418318cafb6c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("46f2696d-c6c2-4e72-a11d-69e558c1409a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("476cfd40-fbfb-466f-a1e5-827cfd5871b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("47a17398-f4ad-4fc1-bcb9-f859e0c790f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("481141d7-bb08-4907-8520-e342d8319d5e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("481adaf1-5709-442f-a1d1-f43f7998ee97"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4823ca07-6024-4c6a-a905-3c2fb4cfab6f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("483a8f75-b708-4172-8622-a24d14ec2995"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("48c809f9-3c6e-433e-8d0c-d60b56e9076a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("48d27154-0631-43ae-acf1-7c0abb0e3c43"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("48fc3cb5-b3fe-4838-8a30-09ed29fc353e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("49bb64c3-9361-49e7-8901-db3db7a3037b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4b40a543-38e6-4eb8-a7ba-ca0632c83d82"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4bb57cb3-f398-4605-9477-59ce1338c84f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4bd581a6-912f-4218-92a2-310232fa8fd1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4be8464c-3730-46f5-9219-9bda47382c35"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4cc0d00f-4528-4714-98d1-5732dda0ea95"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4cdf2f2b-4d1b-44bb-a947-02d083efb9f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4dcc4128-aabb-4380-ad4b-6db4267bf290"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4de6cdbd-6fc5-451d-886a-cdf5fb257ef4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4e18a8ff-0e01-43c8-b28a-ebf19603506f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4e71d6c0-0d74-4e99-a900-c9c3c6e804c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4efa3a67-8931-447a-8919-49ba2f5f6fce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4f341ab7-97f1-4111-b9b1-f6c7322e217c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4f5aef47-8544-4576-8def-18af7d1320ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4f66552b-3d25-4200-bc12-efbff50d3a75"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4fa2ad51-2e74-462a-9c52-899dea6fef5c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4fc24792-e462-430f-918d-c988c5a8a08c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4feec09f-74e7-4791-8786-f65179141ed1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ff40991-b3ed-4ca9-9c19-c5520fb39ce1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50425ee9-b333-418a-b68c-10b9aede26c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50738943-40a6-4042-8ebe-357df9869448"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("515bc7ad-cac4-4915-b502-62c114b23e55"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("515f1a90-be46-4425-8dfc-c30cd899d53e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("518356ee-d1c5-4593-ac7a-32e81d35f772"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("51c6b846-9087-4bb4-a97f-2b8eeb6a948e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("51eefb9b-4c9a-4420-81b2-cdf0a1ce1362"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("520555dd-1b14-4673-af74-c7e3accf8271"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("53466b1d-956f-4785-a11c-7548550138ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("53619014-fa8e-422a-b3a7-ff55dfb3c952"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("538406da-ba94-456a-b72b-729a1c1c1174"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("53cc4a65-ae6d-40cc-bd42-6c4ad202a1bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("53e4a6d1-e4c4-4fbc-8a4b-cdf159f89979"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("53f24d19-18a0-44b8-b73c-6736c2ca28ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("540c6947-c4d5-4c4f-9b2b-222fef441e5b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("54fb058e-fe0a-4597-ab55-be0b8f8dc163"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55313933-fc1b-4575-a26d-a4a33f711464"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55460832-7078-4dbe-b3b8-615eb6c73cb7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("556827dc-46d1-44f6-bab2-e0ecf1e01b12"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("564afc93-b44b-4b75-a52f-5b6ffe0e843b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56572373-7280-44c3-9951-227ce0b57089"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("566915e9-9f0a-4bf6-9fed-763514b2c4ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("568625c2-b7e7-49da-83fd-7016b8b66966"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56948d0e-0fb6-4c01-9b3b-2440fa084f69"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56c14308-beb6-4562-87e3-0cdbbab8b124"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56c4c8fc-b8ca-432a-8016-4b97989c0c52"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5724e0b0-2d35-4935-b543-f27f6dbaa79c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5746e391-dabb-4250-b6c7-77e3d674ba75"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("575b7de2-fe2c-4bfe-b1b0-856f8de56300"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("57ec9722-7ae3-4852-b239-276589c0ebb3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("57ed714d-06f8-47e6-8116-a76f2a0e9f94"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("58487166-3292-4e80-8be1-20488f26646d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("58aa4b49-a00d-4e54-a288-97fa976c56fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("58b5274b-0258-45fd-8923-f36272103cda"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("590d7392-f9d4-40bc-b2e1-ce4c140f02cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("597f090e-8f19-444c-ac46-d60c8a4b3666"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59867078-caeb-47bf-8c58-c25df68b13a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59edcf5f-6534-4007-8f02-90da26c1bc2b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a262825-84cb-4e1f-9516-bc80d489331f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a432612-f8f4-40e4-b0b3-61d30e72d089"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a4c1702-5707-43c4-81f0-1ddc5e43e28d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5acb3e7d-d01a-4c78-b187-b22c0ba902e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b066979-59ee-442e-8642-90f8b37d0656"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5c0f2afc-4651-4530-9ae4-880c4bc9cf5c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5c303e28-b401-4dcd-8c7c-ec31fd938ce4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5c51caf5-5582-41b9-bc29-630ad5f5e55b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5d0b5a9b-0e43-4fcd-8532-ef303627bc6f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5d92e0c7-6a86-4ce7-b1d1-2909cc5f06cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5db8b91a-63b3-4392-9aad-b1cf19b06fe5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5dc3c860-17a4-450a-9765-479b517ed3c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ddfc43a-2c84-4c91-a044-6b8de56effc8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5e105480-784f-4351-8b0d-44ef4cab5250"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5e3bae3f-15b2-4889-939b-89a8688afc36"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5eb6af11-c230-4a5e-a739-94e9ac8f3efb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f0fa1bc-3222-4845-80b0-02c409f28076"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fa0a4f8-45b7-4b04-9e49-16de392283d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("60ac9e26-47c2-458d-b957-83df053e7be4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("60ca7ea0-bc29-48e9-9738-04285853dbc3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("60f1c8bf-f0ef-407d-921c-4ffcd907ce52"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6161da80-deac-46ff-bb8c-590c60c793a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("61cd7742-573b-4965-8a93-80b93e5affc9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6246b760-7230-43cf-9b13-bbe56dd8ab4c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("625501d5-fb5c-44de-9bd7-9076d70e07f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62727c13-9ccc-4d3a-b706-3424f8019df8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6275b696-2b3d-4074-b28b-c08dbdbb28c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("629128a1-ac14-4361-9277-8bb98d113d29"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62c72713-5459-4fc7-bcec-e6f8d4f1a241"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62cd4a2c-61d8-4697-8c74-593e1733a5a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62d3b6d9-74c5-4c35-8892-29933e0838b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62dfc755-6dd7-4832-98d3-56f2ad9f7d23"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6332bfbd-b624-4d69-976c-04481905708c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6342cd60-6679-4e36-a2f6-f26428f6c407"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("637e1101-fb48-48c3-b038-3a692077e58c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("637ed532-b936-4a3f-9359-415f5d2f6026"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("63ad5eaa-e4be-497a-a189-d344549db094"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("63e5a47b-71de-4902-aeef-963c70730ffa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("63f8bd41-0e40-4cd8-997c-600ef1bf986d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("64ac36c0-2426-48f3-8c12-01d5528914e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("64b133c5-93d2-425d-bd95-8dd9e63bf6da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("65289bc3-8b6d-4d2d-87c1-837abee5d259"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("655b1b80-77f6-414b-b7fd-da34dd8002bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("655e82fe-f446-4133-a4e8-19f9f0b33bfd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("65961592-959c-40d8-b415-fe646eacb68f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6599c96e-da48-403f-a83a-33286c2d00c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("65d27b27-66b6-4c8d-8a7f-bb6e4678826b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6708debd-4c24-4b4d-aa50-20eb548a5212"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6742f284-2a4d-4a27-9142-30631d7aec7d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("67dd05d0-0f7c-49fa-b781-9764fc99bc5c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("683497f8-8aca-4a2b-ba8e-ce74e1b7a133"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68399ceb-6d3a-4525-b798-d88a788924e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68a6aa53-b864-4368-8915-fcdbbb81fe80"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68f595d4-f79a-4f6f-88c6-8b523387339b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6919c4cc-4133-4c05-885b-ebac02e22c42"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("691ed2a8-4a84-410b-b80a-c1c52e2eb685"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69287f7d-27d7-4b2a-a17b-c8b93b900a36"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69356f58-2dab-4377-adeb-e63dec065114"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("694567f0-a224-4101-b361-a8b267bff6d2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69d495ba-7fdf-4dde-ae15-6b1c96c256c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a1df1a1-52c9-4837-bb29-477f02b22f35"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a86edc2-77f9-46ce-83d2-751fb0c69782"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ae04076-005b-44b8-91f0-6ebb325b2742"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ae92431-890f-4bc9-b199-097fb9ba92b5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6b1ea1bc-1e77-4dfe-9c40-d9c2d6d71e65"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6b2b8efc-61ab-488e-bd66-56e0e97f266e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6b33bd09-b7ff-4364-9e4e-60f06d1bc927"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6bfac893-69d8-4dd1-b569-a447b62b760e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c349a81-bb2a-42df-b26d-d6228eaa790f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c416319-febd-4f9b-98ed-e84067a89cf1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ce5f096-513d-4f10-9984-d702becca472"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6cf488ee-792f-49ec-a6c6-1bdd43625f39"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d120395-b370-4bc5-96ad-9e330c1895e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d58c081-1fea-4b99-9eec-2bcf0240af45"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d6a918f-7469-4b7a-86a8-f65d0c9a0a47"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d72f16a-527f-45a8-8651-fe0e982fb392"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ddae668-8710-4580-b5a9-28b0adafd54b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ddddf27-825b-4056-9818-47f66eb73247"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6e007143-6e50-4984-8f73-80edabb2f185"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6e5ed85a-b6ee-4a70-ac5b-65458c44882d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6e61a316-53d1-4ad5-bbd1-7d50579c19aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6e9fd495-1b48-411b-a71a-92f94331b779"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f2ebeb6-c3a0-4cd5-9e85-9c81580b9d50"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f33f70b-7bba-4c4c-995b-84368aae1ed8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f3afe28-271b-4846-900a-6959be036f24"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ff3dc12-0803-409a-a4e9-058fd7deab3d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7021154c-0fbe-46fd-b926-52a4532c8e62"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("702aafaf-b5e0-4e43-801a-e4126ba1c156"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("70f8f1bf-9bb7-48ba-bad7-e24282c54b83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71150c6b-57c2-4b5c-a6af-c2fafd2d785a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71609381-3148-4575-bc4d-8b81aa053c0a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("718fa952-0d88-44ce-bbb8-41c1713baca3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71e831f1-01c4-4e6c-ac47-5e40ff51a042"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("72069637-3f77-49dc-b6c6-4a60725811c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("721e2621-1972-4e4d-a424-7b85995de2e0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("722745b1-5631-4537-9966-5d99d6c67f9a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("72337037-aa08-4ae7-8904-da12c8530623"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7275ce4c-7472-4464-887c-57be13d60314"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("72ac4c23-f29b-4cbe-9384-299f213399cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("73438734-9893-4307-930c-565413ec5155"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("73f423df-f1e7-43b5-8622-32e114684549"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("74050320-844e-473a-9248-86e179fcd97d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("744820e7-fc94-465c-818b-845313a3a01d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("74ae39d7-bc66-4f01-970e-f9a421a1621a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("758ad68a-1f3d-4da8-a022-8c11e3bd26f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("75c677df-a2f6-4506-a52a-78d0c7014d0b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("761141c5-8bf9-471f-baec-f5dd170ba6cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("76987de8-4288-4733-a1ce-538d4b15c6ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("76e24508-32f0-4294-aae5-28e5b24bd3a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("77144262-8f29-499e-98c6-01d9cc58c625"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("772b3363-035c-4586-ae41-3e1e67889314"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("78349e02-ed48-4978-ba73-b6547fa37655"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("78565563-54f3-4c5b-9531-82c98995fa61"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("78bec3e9-9d0c-4f1e-b90b-ae366db4c5ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("78d3cf0d-09f6-47ac-b1b4-1b36dd85ef6e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7930ec46-4327-4bcb-ab01-bafa97a1732d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("796b6a86-b904-461d-bb32-8dad79b39406"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("79925190-8ac8-4aa7-962b-0efd5237d000"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a024820-16f4-47d7-bedd-a2a139aa541c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a2b2f72-c025-4419-bc57-1a8a0232df65"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a3d53e8-d21c-466f-9cf6-435846908447"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a80da6d-9ce0-4a23-92b8-468b7b4fdfe6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7afe36d4-0778-4eb2-89b7-e1eca224b6e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7b63b1f7-4c88-4ace-920b-c5115c6302df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7b686e7e-56b6-4451-b883-db47840f7f24"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7b93e19a-b362-47b9-a93c-cd0d29cbb9e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ba8a32b-cddb-44d9-b06a-f60ac5a82fd6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7bb30e2f-6da2-4e1d-a4b1-7f3ddea64ab3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7bc0518e-ff56-40ca-a4d3-1c2fbf1f9e3a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c58056f-e5ae-4d5a-ae62-35ae026195c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c58f639-a5e7-4506-97cf-344bd3a180e1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c5b458c-c29f-474d-bf35-3ae22099e21b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c648e4d-d145-4712-9ff2-1de14a901b75"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c6e8683-7bcb-4de8-8e90-af0cd7c89d8b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c6fb850-4777-4b04-aeb1-786fbfe95c1b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d10d480-391c-4c06-883f-89fa77cab4df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d22bf01-b793-4a8e-9672-993ebeaa0461"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d79e453-edec-43b6-a9ca-6675171fdc56"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7da580e1-1f4d-469c-8fc1-1a2c28ef11de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7e137307-95d5-449f-ac14-b41c501bc7db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7e82d506-e5b4-453b-bbc4-8e6bb5c470c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7f0f16ad-3109-4c2e-ae88-a967cfab303a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("807fc761-e51f-4bdd-a1f1-e1982999f39a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("80b7231a-8021-424a-8582-9c604d799b56"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("80d50d2f-a510-4043-b350-854e49e1320b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("814ccf80-a673-4dfb-8ed4-1ae05a88dfb6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("816f0c72-f499-42d9-b3a6-c30189beb4f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("818670e7-0463-4e86-89e8-a442a77d717b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81be6e16-fe8a-40b5-9e87-ccf74d246232"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8211473f-c615-4a72-b7b1-933ebb8dda1c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82205b3c-dd11-478d-82b4-618a45b5b34e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82a01202-71aa-4a1b-b80b-1ab241c9b05c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82a857a3-a2bf-4965-99ea-7af43b1e89ad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("83415c67-57b3-4cb9-9d9a-86e692be4fe6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("834701e5-95a3-4e54-9dd0-457e80f16f15"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("836ad48f-d699-44f0-b2f7-510a93e83e8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8390d7d6-99a1-4a14-81fe-67d8af45fd79"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("842f47c8-20eb-48e5-bf41-282b28e750a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("845316fd-4fbf-4904-a786-f4208643c1ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("846311e4-a05d-446d-86c1-55a19fd5155d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84897d08-a5a8-4c5e-9cb1-c4828ab40abd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8496a917-0b30-4b7e-9e6a-e2dbfac025bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84dcb97c-9a24-4598-af6d-52e53a2c30c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84e5b1ff-a1cd-4f28-b1e7-d2a241e8e282"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("855808bc-f634-4c7e-a81c-f55d64259319"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("856a8720-4844-4105-a967-29a763e507fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("85cb9d8c-e9ee-4c92-a82a-eef0ab198990"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8633d609-5749-4b7e-87d3-17c23d1e9901"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86a4861d-c5f3-4ecd-a57e-e56738a97b20"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86c03bd1-1595-4dd8-a11a-48dac77e4fab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86c0d5dc-eee1-4e14-ac8d-0710d6ba600d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86d5e20a-d724-402a-abdc-a7ccedf608d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86e84219-3e07-4b21-b318-bb978a4e6db8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("870f5c66-8725-46f9-b36e-f5faa2386146"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("87963154-33a6-4a27-b345-a6ee2bbd3f55"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("87e248f7-0e45-4c65-a569-22aac1b92a90"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("884a4f4e-dfac-46df-be70-5c04935ae8b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8859a98f-ba4f-4471-98c9-eca21a0db1b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("889232ce-3b8a-41a9-9d63-d07f01e4a662"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("88ed9106-ecaf-4261-9f15-41990f1b438e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("89135ca3-1e59-4a0d-baa7-08be4b480fe0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8987c9d2-16bf-4baa-8b69-c564ef33ffd3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("899ff0c8-2a0f-4ebf-a065-52132e1a2e61"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("89c1366f-d8b7-4626-96ef-1a717e9d82fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("89c868d6-0aef-474d-81f9-58daad1e25c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8a8a1fba-999c-40e7-a8d2-0a4c03a5c6f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8aa97352-c895-461b-8959-c0844c6caf3d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ac2fbc2-8bd4-4720-96a5-1cd9a5fa4fe4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b08d02d-d721-472c-9420-bb21b3e2dfe6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b0b632b-51f1-412c-aa24-0026420c63e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b2688cc-4085-428b-83bf-0056eea01588"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b94f89b-256a-43a0-84a6-e48b3175269c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ba44293-9a2c-4684-8c6e-4ba70e11aac3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ba828a8-d0f3-4a13-8752-cd5596595282"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ba895d4-bc77-4125-bd35-b1f964a95480"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8bda5ce1-5cef-498d-8812-9f241afdebff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8cc151be-c1ee-400b-a515-6ed6fde87413"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8cc68ad6-1751-4593-a5cb-ad12e9a3a203"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8cec31d9-d801-4ff7-822e-2fa891df71a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8d050ec6-eccf-499f-8bfe-144dd1a9cc06"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8d2e30a4-52a8-4ed4-961f-9a775ac3bcab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8d328ef5-a409-4eb7-90c3-57c7b04d5208"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8d3f4e6c-9cfc-4c84-a2ac-886b7d7578df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8d671c56-d27b-4a05-943d-ad82ee192f0e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8db63832-bbe5-4a83-aa88-0bea8b81ead3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8de4c7ab-0063-424f-a72d-8a1e988665a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e028f47-0f26-4bcd-a46f-2b43c6d178d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e072298-3a8f-4de3-a569-8e400087490a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e65bb50-3c0d-4b1c-bb4a-8a25ab823d82"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ef0b491-99cb-46ee-a82c-445621e1a72c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ef313bf-3409-4f09-b65a-cedf3b7df437"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f29bb8f-6e5f-4241-b19d-8d8b8d3d3d24"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f2a503f-140a-425e-8151-bdb9b7eb23c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f66ea5a-1298-489c-ae56-26da1c3ef1cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9082a4a4-f899-48f5-9b91-be0e68157ba1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9084d095-76f8-43f6-86a2-df23f6a12107"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("90b460bd-e2dd-4ca5-b8a8-5d2496893da4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("90b4a88b-ad3e-46b4-8054-1515214122e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("90d424fb-670f-413d-8dea-f9c53106a606"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("90f717fb-0a9d-40db-ac67-bc497b0fe849"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9119f50b-97bb-4c1f-83b8-041c5f9b8669"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("916c870f-5b82-42fb-9ee8-0dc57bdcef1f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("91929f76-e0d5-4bfb-96b4-7c91ac6b42ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("91c70124-7eb2-45c4-989a-05354caf44c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("92105e24-b5ce-4b7c-bc6a-c98c303f0e22"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("925749de-53ad-4fac-bb84-ab12c79d58ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("92a4c0a0-19ee-4975-a05a-71af05259aa3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("931c05fa-2aae-478b-9891-03b43881193d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("934344f9-ec06-421c-ae40-8a184c8bcc04"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("935dbeb6-90d0-4f36-8470-c62e830e06d8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("93b3701a-bf58-494b-afd6-8a1524303dd0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("93eb3d54-3084-4dca-a6c4-a9d762641836"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("93f46dd4-da74-4c96-884a-ea6321a27122"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("94d17628-7a5c-4cef-9405-874a8d2875d4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9514293b-2b31-4ee3-9f45-c4b29e90f4d8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("955144b2-07a0-4961-aff8-e62fb5755c67"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95ab58f4-e19d-48c5-aa59-e1e81632a06f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95f9de89-9ccc-4bbb-a42f-c14a87b62303"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96641721-25d3-4332-9aa1-34a4b3289165"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("969bffac-e96b-463e-9745-24cf0932ef8c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96c445e9-d37d-4daa-a139-999b5b0ef8ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96dc21c7-90a4-444f-991f-f45a18136ddb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96e9b444-2e7b-4480-8a1c-24c1d0e075f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96ec6597-90e2-4135-9a19-2d92f2fbccf9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("97316d38-eade-4f17-a69a-a643bb886935"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("976320b9-0757-4343-bcba-332f058e810f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("97a7c913-c64e-46e9-a10a-8d4667e629ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9876339c-6372-4e4b-af64-eb6bd2076609"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99bbc198-f17c-4715-acef-47fa466739eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99dd641e-8034-4bc7-920d-191349f8b3a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9a788b0a-952e-4b49-b4b0-d9415bd3015d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9aabf99c-d2ad-4058-82f4-b61febbb6583"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9aea0157-2ad3-43f8-920f-9bcb73c5c6bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b008029-b5dd-4d7d-ab15-6878f1009028"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b3a2458-708f-4eaa-892e-57cef97b068b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b9692f4-149c-45d4-8212-f97e19beeeac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9c840168-0969-4030-9f78-158431e39c42"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9cbf4c9c-989c-4206-bb36-4a2f4c85dabf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d010156-4912-4c9f-9ecd-e0112bcab5b5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d2df44c-500c-4a63-b4be-7377b2815c64"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d649d49-86e0-4180-9cf6-b885800f3a5a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d9190c4-0d54-4f76-ae63-ecb36f3e5ddf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9da0ffec-d5e8-4b5b-8dd3-1d8f4d39cdef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9dbd1751-4651-4bc8-80b6-175db87724bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9e65db84-49d1-4bbf-9cf8-1e906c80e601"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9e75369a-42c6-4fc2-a529-f47fc8c4f70a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9e7cf7f5-2154-4113-8312-52cea13cb6c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9f019204-2dc7-4c79-ae56-86821eb56465"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9fdb57d1-927e-4754-a88f-52312ab72d8f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9fe052f9-b8d2-4ee3-9cde-4b9f4d5727ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9feb46e7-535d-42f8-a0ed-6875b6597e58"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a020416c-c81d-48f4-8b38-a4ddb0c9e587"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a025a3f3-ace4-40aa-a99b-82ac7c6438ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a02b18e9-b850-4b51-9385-f716fccb70dc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a07668d3-3722-4064-b3c3-763c1022aa8d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0c78717-2188-4313-922c-449d38a159b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0da7c4d-088b-4332-b527-f8d26b9ec91f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0de5f2d-0257-40c3-9257-a4eae88c4840"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a1bad7e1-2399-498e-99db-85a6417a1996"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a1d078ec-185a-428b-ab29-16ba23663990"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a23714d0-7e3e-41e7-82ce-bc886ccfe5b5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a298fb4b-9fdf-49c9-8110-dbacc3af22e0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a30f2a51-64f4-4168-901a-31e85587eb6c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a326f55a-f3b4-448b-bc3d-527b6761a27d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a345a6c7-ee11-4b69-bc3c-d39a92fc9503"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a35a8ac2-9c7e-4f5e-a7f4-55d8b67f275a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a3726b2e-7fe2-4210-8064-214bd88f571c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a3a17f53-eb71-4758-a515-25ba2da63ea6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a3d8e3e8-fb34-46a3-a166-f2845ddb9fea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a3f38289-9f3b-418f-bc1a-0206d3271260"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a42e4c12-b500-4335-b5ec-9b35b3bda310"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a4639a56-1490-46dc-9836-6a481c7e3b0d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a4777922-154d-4c73-9627-7424e0a18af7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a4ea9c29-b5a7-402b-8a7b-8ac7d9199a18"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a50ab9a9-8068-4f37-8124-f19f5a74f654"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a5377460-4b28-4db1-9fb0-391469b4e952"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a560e6d3-d6d2-4a5b-a117-f16b5cbd1596"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a5772980-b1c0-44d4-8a82-00dcf4e43f6c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a5af06f8-dcac-45f6-906a-9ea8e6c6d562"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a5d2203e-085e-4bf4-855a-8f434993633b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a62c74a7-5cbd-4c02-a809-d46b62f01180"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6f78a34-1792-4a44-a2f7-ffa317d67813"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a709c9ec-2163-418b-a80e-55e14164c2fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a71d5e3a-9458-44d0-a154-768929fa6615"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a76c8cb8-2e24-41cb-8693-bb8b990a949d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a79dd0cf-2abd-4d5c-94b2-9b47fb29fed9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a7e0f7e1-d083-4059-a962-9b2d86acaf66"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a7ee1bae-8d7a-4f55-906e-4e5cff36a325"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a82700b0-0522-466c-83b7-f87b28c2dd09"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a859ca05-d18a-4edf-afbb-545609d2d6f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a8792a7a-f541-4adb-84f2-00808767fd6b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a8dbcd74-373e-4156-a83c-2401c1ec3ebe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a9174bb1-4ddc-4cbe-afc6-d5c93579ab8b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a95f938a-3682-44cd-a83d-22928eaeb8b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a97e9641-e776-4f4b-95bf-784f50b32a7c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a97fc1b1-3d6f-4e0e-98f2-e21106b90048"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a98fd70a-b2b2-4a96-a39e-bc0161d33bd9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a9d287b3-6fde-4d44-b050-6173405b99b1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa1d7c12-2980-48eb-a46a-ade26c77c375"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa6857a4-f102-4dc0-a536-b06ee0119978"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa8f9a03-f791-42b9-adf4-76e2cf2acb86"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aacc8688-276d-4a95-9cdc-8c6354a2318e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aadab96d-4605-4cdc-828d-3e2aaad73b80"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ab0a1cc3-b36a-4f42-9610-bc402f251ef6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ab46176c-30a0-4003-98c9-3f92e41dcf5f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ab5d7be3-b7f0-4c02-90a9-18e9060e25b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ab6f8921-6f37-4d89-aaa5-9e540f226484"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abced968-c783-442d-9cd1-9f330a51c899"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abd3cad0-33f5-42b9-91d8-289b3259cde9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abe8c4c1-5f7d-4c54-a405-39c8d2d1a84c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ac1ffa9c-d1bc-4198-89e5-70d544ca25fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad534242-ff4c-4fe7-9a85-9836637c3015"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad66a311-06ac-4065-b385-db0dba2ad285"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad9356b5-de5b-4aa1-bf9a-1e669462ea76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae11f780-ffec-4a2e-a83c-ddecbc61467e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae3998ca-6dec-4e6e-8a06-0f0125e9044a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae5260db-3ed1-4758-b32f-2a6f526045a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae97053d-6405-4075-b1e3-c638b417a432"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afa1cfb4-f737-4c0a-b25d-dcdd7b86f3dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b039c85c-41c6-4285-9361-1077d36c7a69"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0dec926-e450-4a09-9483-95b54c99e7e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1a33237-e5ba-4c75-b4f1-75a1d0abf57a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1e1e10b-7338-41f9-8fda-cc5d87a6973f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b233a335-ba80-4edd-af25-330fc673f436"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b306d986-4e95-4304-a635-8b1e3805e0d8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b3856be0-4da4-44d7-aab1-b56fae5cb354"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b3c72b73-9a71-414a-ae4c-4d48555d2f1d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b3cd273b-8692-44b9-88ca-4f701f934152"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b3cd93d7-50a8-477c-9758-58c3f9b5d36d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b496bac4-8c8c-404d-a6bf-96de0e3c0e39"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b4ef5989-fe54-4ab4-b49f-7a53e48ada08"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b536e655-d13c-4a6e-8a34-e1a53982ef31"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b551065c-b0da-460e-b0d0-688a6a67abac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b56a7967-db0f-4cfc-b216-31ce5a6e3246"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5ae652a-e5fa-4482-991a-d897f4a0fbff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5ced080-27d7-438c-ae52-bbda56d2beae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5de4f3b-ac29-4896-8a83-27d33ef895f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5ebed64-ff2c-45bc-b803-0e11282994ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b610d3a5-337d-4cff-9944-86df0f40bf5a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b64ff4a2-cc0f-4680-9cae-d82ff2936529"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6599015-61f5-4d83-a4d3-186d3fe9dca8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b670ef1e-57f6-4154-b7b6-a91d207e0d9f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b673d781-8aa3-4ecc-b107-373bb80cea7f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b67f04c9-78d0-4a19-82e9-9b49317dfabc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b7411944-b32e-45c9-aa3e-0b397f12e70c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b74adc47-68b6-40d7-adb8-3b1812d653e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b76cef8e-14a1-40b8-9ee1-44bfef6a14f2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b7a6ca4a-3861-4b74-a30c-5b282264d560"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b7c21162-6504-4848-818f-cb55f2f8f181"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8205edb-509f-4439-8147-6694d0230593"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b9147c84-7638-465b-97f9-39b2d3e2d4f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b9220087-4d20-4286-89fa-700eb39867da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b93dce61-969c-458d-8176-323c640b7d78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b9535c84-48d2-49b2-b37b-5df8074a418a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b978ca9e-4ae5-49ff-a949-f840d941297f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b9b203dc-1b77-44ed-bb90-c117b4c941b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b9c72d57-6144-41d3-8180-7171dc93bf30"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b9f25ca3-97af-4231-b3e0-361fda5735bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ba4553b6-331a-4ee3-a0bc-cc163f379f96"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ba785ba2-4d92-40cf-81ae-9096ce0a6e20"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bb5589f3-13a0-4bce-baca-5a189c05ec4c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bbaf84a3-b27f-47f3-9bf9-3f0d86581cf5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bbf00c7a-2ff7-4ee9-a7ec-6327824b7baf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bc06da38-4e0a-459e-b09f-2689d8405f6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bcb770e4-a68e-43c9-8f62-32679513afb4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bccc5859-87a6-4391-9dc4-b5785d11f645"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bcdbbfa4-4157-432c-8b8d-a2dc8f2c569d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bd5105ee-25e9-4628-a279-4c86690c659f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bd8229aa-aac1-4fce-b3d3-4cad3cc955fb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bda45075-7c91-4024-aee0-877d6368616d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be52fe89-fb23-43aa-91c9-404ab0d05e8d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bec3b13f-d8b2-4de5-b4ca-cd0d2f2176d0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf98c978-a97f-4118-aa73-86f23f48f0e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bfd9ddd3-fe19-4fbd-8a61-27afa8d4019a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bfed9b0b-60a3-4de7-83e3-a05f6bd43258"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c04ce751-d3e1-4339-a97c-e68931a44d98"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c06cb117-6535-41ce-817a-0100e7d820c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c0d5eec8-57ff-4270-879f-3878cb0d7cc3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c0df39b5-ea30-4769-bf4b-d6fd32095846"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c0eb53c8-fa33-4b6a-820c-3a07d6485e16"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c11c3f5b-137b-4e5b-9744-eecb85613452"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c175e2a0-2447-4081-872a-75cbe7a25183"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c1efab46-4b18-4711-b0bd-f28e93470229"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c1fde2b3-db65-4c23-be07-27e7f1975482"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c22b18f6-6896-4b6b-aa72-3c90dbee54dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c24d11d6-f42e-48cb-965b-79c293121e5e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c2657893-39f0-47e0-a189-4e273f0a2d82"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c29a4ed0-409c-42e8-8284-00c3396893a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c2a9c327-70ec-4ed8-9691-be82a9078963"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c2bfd288-a1a1-40d5-8afd-18adbf32dfb7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3113cf1-f8f0-4363-87f7-3941171ea2d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c39b72c3-bfa7-4257-b565-ac69c0a5e79b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3aa78df-eb43-479c-9f65-693390f2a14d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3c3ea63-58ad-4c2b-8792-38da04535f6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c41d5b04-ab9a-43a2-b1a0-b07c88a4f422"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4e89586-6a68-408b-826d-5684b62bf1f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c54b2162-cca4-41cb-a4a6-db873bd36f6c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c56528cc-fc93-4265-9d07-2afdecd34f8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c5663f22-57ef-47f8-907c-334f8f4c388c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c572f2ce-087d-4643-a298-2dfaba468601"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c582aa56-a8a4-48ac-b32a-4ee60b04dca3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c597c551-63ae-4c63-9178-2a923caa62ea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6992225-67b8-4b2a-b531-fda17b224ff8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c72cff20-e9cd-4b6f-a63b-62e8aa41145f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c74bcad9-902f-41a0-a882-0eb15345a120"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7c72e0f-41fa-4699-804c-d090211858e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c8472d66-af51-40ea-a790-4729aadb3689"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c8a448ae-f492-4da1-8328-2f8b27c5aa20"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c8beaeb3-d240-40c7-803b-4a6014091f58"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c9b50c66-f362-4127-9d6f-3ef8ea4d12d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ca117e7b-2894-49bf-9623-04d472fc4c2e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ca264da0-491c-4f96-81a5-916f2ab84703"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ca33282d-285b-4c09-9d8d-698f5dd48462"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ca4efed8-2811-45ea-9607-780a1b97ae45"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("caba0efd-950a-452c-9593-b16cebc1a14d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cacec5b7-11b9-4e68-a5db-2cd1715beacf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb5482e6-577e-48d0-b2de-f109eee54737"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb620418-4dc7-456d-b302-2ef7436d2ec6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb9b3bf6-a4d9-40bd-99cb-893d6b2e6309"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cbb6f25b-1b20-447a-b8cd-1fac13df88a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ccdf9050-6277-4a70-8869-282f0ed426a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd29a8c8-b4ee-4604-bdac-f2677859e8c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd630dfe-ca44-439a-816d-1c226e228a8c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cdb54940-3f38-4961-9672-80253c525a16"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ce3d49d0-01a3-453c-a2e1-4acafe93e9a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ce879741-e90d-41d2-8e0e-152a451d7389"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ceb9dc04-3d8f-4ebf-8f25-9323e46c15e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ceef1ab7-2693-4b25-bd0e-4c3504a539c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cf17bda1-8937-4167-8a4e-d911c59a6017"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cf246031-f88c-459c-801e-8a895ec60812"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cf8a3e37-5411-4580-8efc-f441917d1ade"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cfb59b4b-01fa-4668-8bae-f2860f2f48b1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d01b2764-4d66-43da-9dae-9d4b4331c203"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d02cc983-fd86-426f-9f06-b10ba86b7568"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d126bbad-1fa9-4c35-ba5e-ca744f7f1474"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d1c4c11d-69b3-440b-b39c-debe332be3b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d1cfded6-46f5-4361-be65-35cbc7ac2b21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d1fb11ec-da7c-4759-9b54-2ca1e3509677"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d2380779-7bbd-4768-8657-6ebffec5f60b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d251ab4c-e8b8-4156-a89d-0c2da50b8bd7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d2794d07-28dd-4b89-b1e1-8a818c2e100f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d28e08cc-afd4-4a07-bd4f-a3711beb928b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d29a50b4-2ec5-4eef-9586-af51edf8df78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d2f2cdd8-9c14-41f6-90a6-40da992f24db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d2f996bb-8cbd-41f2-ab2d-a8840082980c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d3449943-0022-4af9-a35f-45288393c6e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d3d04a17-f170-41cf-89c1-95a4d2807e82"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d4100eac-8c40-41a8-89f5-ff9ff3ece62a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d47fe560-b898-4f75-a4bf-251253a6137a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d4ae0769-9d9e-48fe-b39b-41bbb9bec5ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d4f6cefc-36b1-45fe-a7d0-ee6ecb706b6e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d562ca3b-7779-4d78-a9d5-e1788601f3ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5b9bca7-aef2-42cf-9522-5a85a40be608"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5beecc0-fd1d-4481-9a06-b14712a16ee8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5c73acf-1e83-4a66-b323-c7d895c49d94"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5e042ca-a9a9-49fe-b177-90c609a2dea0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d61a3423-ce1a-4e2d-a812-0b467349c0ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d634cf5e-60e2-4f5b-9ee7-05b83a91a493"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d645b1a3-90d6-4649-adac-d0d4d032f0f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d6495dda-b546-42a1-be0d-5a90f2f109f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d665a86d-8de3-4e86-8f85-0267d05b8259"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d6c1e9cc-4efc-42c8-8416-9f8bb340b6a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d6d3a616-1d03-4512-8a4d-0e1909c88ab8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d6e492c0-c1d7-446a-8950-e8640f81bd9c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7055a5a-ad02-4cd5-b38b-29f39cc2e93e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d72e449d-8272-4c7f-b1a2-13e141edfa7a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d771573c-f96a-484d-a38e-1d07d4806caf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7c44788-7f37-4bea-87e1-68968005c45d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7c7eed1-b56a-459a-b589-59443d633979"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7cc2dcd-c315-437b-aaf3-9a6e2d9ccca9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8073339-28ac-43c2-a8c3-5c8918269343"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d836e00c-9c7d-47d9-be92-440fb30ba860"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d84b5e40-4bc4-4b5c-962f-c95cf5a8135a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8602881-aea6-4d3f-9ccf-0aa1f1f87bca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8a7c224-63ce-4935-8b2f-fc0a796b160d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d918934f-a033-4486-aa47-e6453ab48963"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d93cf170-f5bc-4c12-abf3-cd91e845516e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d97b66b6-0680-4ee6-a424-89c182257209"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d9942e97-d3a9-4bb9-95e2-f3b14e11827e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d9e68834-b6de-4af2-a7e8-4f1696bf5600"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("da14231b-0714-4eab-b46f-2f65c74e84f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("da195666-8486-4e9a-8da7-3ff5642e6006"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("da31ec87-068e-4a52-a861-5426473ced0d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("daa9611c-dd79-4b50-9a99-f1676289ad7e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dabd1a0e-43fe-4d5c-a573-d19ded91fbd1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("db0ec234-e51f-49c2-8421-bfefc9e826fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("db3be8f1-eeb4-4e27-8c0d-d8f282cc1c44"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dbe8a169-4513-473b-ac80-4a5358b6828e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc01735c-b76c-449a-8cc2-b20f3cd020ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc422654-fe44-42c8-980a-9a5fff14188a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc6d3539-4b89-41e5-872c-373702b550dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc93263c-3cd9-4588-b706-b88de1b0ffd7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dce259b7-ea12-4e7e-923d-c022466ea149"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dd78bbfa-4d44-41ad-bd2b-3e95c1bca258"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("de047887-38d1-4246-ac9a-2b6d15afc7be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("de5b2c17-0b7f-41c6-b4a5-c5931f8207fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("def22452-2a30-425e-9e7d-b72b83acb321"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("df2be2a2-ec3b-41ee-8984-8fa742b1d7ea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("df3c4cbe-5281-48ed-93aa-cdbe5669eef0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("df84ee82-4400-4d4e-bcf2-e95c307a7a9f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("df8683b3-90a8-4f30-8274-a22e239ee134"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dfb122d6-b80a-4632-83fa-fee5ae1bfaec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e0ebaa43-fc05-4d8f-b2ed-264db07beb01"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e18dccf8-f59d-4187-b878-9ea70010aacc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e1b7b374-9985-486d-b81b-4fda6d9278f2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e1e2df37-b3b0-4a63-a4c0-5fdb75c6c914"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e2690aaa-3b35-4439-b67e-c9d36cece6ea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e272317c-4a2e-4394-b2fd-1bcfc29b6219"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e299383c-fa6b-4e99-b568-010f7a6d1746"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e2c4fa0c-f647-4eec-9da7-6d556fa74369"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e2cdc393-7a9b-47e1-95ad-10346253ab66"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e2e058f4-8f43-4170-ba05-3f08ecda5694"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e35740e6-52f3-445d-a387-7f2933277a53"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e3747a7b-90c6-46ae-9936-62032a71f599"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e38ae70c-2442-4c42-812b-3d59884c6e99"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e3cf22e8-24ea-481b-af40-4721ea333358"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4617648-2365-42c7-ac5b-be1622278e5f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e48283fc-602c-4494-ba01-09f7856c7b6f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4a6e5aa-54d0-4a5a-94f5-da877afa3cdd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4dfb366-3bbc-4ca5-ac00-0e846b355abb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5c29051-b0c6-45e9-a4bd-de2a899ab116"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5d96357-f38e-42b8-a36a-1d1d70fc3e58"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5dc73ca-d09c-476a-a1a6-a9236c25fb21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5ed6d99-f4dd-47bf-9f01-b2235439ebdc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e607a625-839c-4354-a4ce-0758796cef10"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e6857851-3a17-44d3-868b-93667b574dbe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e6982b1d-9e7e-4715-b8ca-f9b9ae7734fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e743cb9e-ef8e-4498-8554-31950e23f9d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e74d5f36-2f3d-4f7e-b7f4-cc3e8b68ef48"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e7b71409-fd43-4ccd-96d5-5add20e37661"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e85f485d-646f-4783-9aa2-4bbd330dd5be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e8853a9e-a6c2-453a-9e05-08a3e19e782f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e889058b-9cf4-4c96-943d-d07d827662b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e8e2298e-d6e4-4cba-a173-1810ce1c8877"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e93516bc-806c-4b03-8dfa-a576ab420a48"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e96a5120-d557-4d64-a4f9-6ea11ad0f2de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e98fbfa7-3a81-4cbb-a836-319379ac12ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e9c30499-f21e-4110-b737-2bab2b235189"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e9d3ca1b-00c5-46d7-849c-65fe3e632261"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e9dba650-051e-49d4-8950-57c9b2c68c36"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e9faf6b6-b185-4d12-91f4-cd64a0d1d74a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ea0be63c-b2d2-4602-ba41-b52503088953"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ea8ff6d7-f35f-499b-a8d3-35878a5b5a4a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ea9462fd-3ffd-40f0-9b60-1fefbfe96588"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb1e61ea-5e65-49a3-86aa-b512e42c7a4e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb3b5ae5-185e-483f-8ebe-c4c5384cc9af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb449bbd-8a27-4790-a1be-aae115c0da89"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb4dacd5-c339-435f-8805-4378d34826ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb85305b-e554-4286-b703-b2de2edc32cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ebae184b-c212-45bc-a24a-bb569caae34c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ebe8a588-bfa5-4aed-8393-886363378921"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ebf046d9-139b-4a92-8388-e9c6cbbd971b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ec019dc7-8f0c-4386-a4be-b67efc082f73"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ec770c96-6231-4408-924e-c1d4d2780921"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ecfb0314-ccae-4307-9cba-76ce791b4e3f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ed36e611-ea6f-4a66-b75d-e7ebfce0c973"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ed82e2d9-9bd2-4ce8-8221-2c976f879304"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ed8f28b1-3baa-4fd9-ba24-a02329fb8a01"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("edcd5825-6144-4b59-8539-2e440014e154"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("edfc88d9-ec84-40d6-a402-de589b526afc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ee2ae82a-1001-497d-a84d-37e603741dca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ee95c93f-32fe-4341-a73f-1c9e1911a5cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ef51d9b4-9bce-4e4b-93c4-7a3a64298e58"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f061accf-108b-4459-87a5-e4a6cef5989c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0b17790-b033-4177-bc2c-faa935cea706"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0c62fb1-5b67-47a2-892b-6be15306edc9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0c87f05-6bed-4cb2-8082-aef2b26dfe96"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0ef8234-9f1d-4968-a707-1ef3230f3ae4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f12b454d-de90-4154-bf3c-2025bf23ce09"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f133f218-ed8e-4fc0-bb7f-be0055306710"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f147b4eb-161a-40ed-bf21-e3630f667906"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f17439a4-2b37-4ba0-8934-3c9ac715a6cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f17be5a8-84da-4c32-af5d-8cbb9bf17d11"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2565adf-81b4-4cd9-b5a1-6c241a689966"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f271402d-ec3f-4bb5-ab06-35dd79ba05c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2869f4b-6a33-44d2-8054-cd2345ae9687"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2b2abf2-8c4e-41a5-b6a0-d661988e47d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f3049e7c-b46f-47a3-9d82-8ef8ac6c2570"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f31cba14-7a1b-4c6e-8b53-91a30b3c6cf6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f39f95c2-7740-4067-8cb0-66c0d108695a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f443f59f-d379-4549-aa23-1adddbfaeae5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f4dc17a5-d3d9-4f19-989b-f3a374a83aed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f4f4372b-a90b-4e3d-b6e7-40307087204b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f57785c8-5aad-4802-8820-45f6e1aef70a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f5850d8a-ea48-47a7-a323-718b08a519a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f5c5a728-9919-429e-885d-a35b2759270d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f629fd0c-141b-474c-9f35-f03d605c4cbb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f6be0541-d021-42f1-884f-04b15a9dc62d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f6d9f488-449a-4ef3-a905-af969fdd38ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f757fafb-b058-4703-b8fa-9513488d20d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f7840174-ff15-46fa-87b6-03bb2a86732d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f7edc445-f670-4780-ad01-d57a25baea7d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f7f1bfd8-4ff5-4c34-b015-f4105ddc0298"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f80b70c7-f2a2-4230-8964-d5421d07f7c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f87759f1-2ff5-4daf-9683-7ed17a8f6713"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f87a7236-b595-47e8-98db-bd3d8632402d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f8cee417-0c9c-4822-8da3-3a9d12a394ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f8d6619f-ff21-482d-95e7-139a48c95fb0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f926ae78-2a48-499f-be44-6edba89eb51b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f9839e82-f145-4e81-ba37-9364852a1e75"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f9a34a91-6913-4066-88ae-5e4dc29535b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f9bf3ebb-98d8-451c-9ced-dff004770d18"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f9ee889c-fca1-4bf5-b70d-6b186d3ff51f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa4e405a-f8b2-4bbb-817f-2362c1ac061e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa5a5913-97d7-4da8-a349-f642ee68799d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fafabc9d-ed59-4d22-891e-ccf3bf7b97d0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fb0511fc-bb7a-4deb-9869-ec125638c389"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fb4729c7-b9cb-45a2-9eac-0384da86f211"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fb6b70be-16e5-4a4e-8224-816fb7ca257f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fbbe2414-570c-43b1-82cd-b5b714be5caf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fbd18e14-c58e-463e-b33f-2d828eba08e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fbf9f632-8fa2-41fa-9aed-ee8acb4ecf1a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc6720b4-6f12-4fb1-bcb9-12bcce8179e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fcb61446-d72c-42f2-97ca-976cc1fe3513"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fcf5d521-97f9-44bb-9dcc-c7c1b5a1c559"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fcf94c97-3088-4768-b78d-719c3c6d16db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fd27ae59-03cf-4f00-91a6-ac3b32f923f2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fd48e6c9-36c4-4022-81ea-467e1b613d31"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fd5ddc1c-51a6-4e0a-9131-402138177391"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fd69d11c-b2de-4848-ab26-727db7184c95"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fd7f53c2-9ee0-4dc5-b5bb-1596f3271c39"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fd9fd14b-7de2-4c98-99da-a3b7563266f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe093680-7116-431b-8a21-74c9465e9aa0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe255f3f-1bd2-46c7-94f4-ee5f533d2e2d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe3bf391-dea8-48d4-9f49-2c2c592b0d1e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe5de52e-ef6c-4a78-a462-8022dd96fa62"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe803e87-6f77-4609-86ad-b921b210d4fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("feb82bb4-dd72-498c-8799-642a07263518"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fec3b823-73b2-4764-acfd-98572fccdbf5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fed453f5-6f89-43e4-8d59-7357923a5e2b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fefa6abf-813b-412f-a642-e6aabf354c48"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ff063e86-f7b1-4161-8fba-181aaab2d198"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ffe0f865-fc03-4a93-9654-330baa1466b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ffe5699b-e913-464a-acf7-fc44ad11d008"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ffe60c1f-2e0c-472c-8bc4-b4e25007b5fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fff31754-874e-45a1-a58d-09dc5464b0de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fff92c07-455d-4d27-be07-0c24c83df705"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2fc63556-1ef0-4b8f-8bb1-d6f281cbc978"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cc038e44-8930-4057-95db-39dd9d1e9595"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c819a963-b96d-4bc9-a1be-32e1b036183a"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "FirstName", "HashedPassword", "ImageUrl", "IsDeleted", "IsVerify", "LastName", "PhoneNumber", "Role", "UpdatedAt", "VerifyCode" },
                values: new object[,]
                {
                    { new Guid("3438161a-836d-4e51-9168-e27611183d2d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "tan182205@gmail.com", "Tan", "hashed_password_1", null, false, false, "Tran", null, "user", null, 0 },
                    { new Guid("66bf31d6-9284-422d-8024-361b45585b76"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "tan182206@gmail.com", "Tan", "hashed_password_1", null, false, false, "Tran", null, "user", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "CompanyAddress", "CompanyName", "CreatedAt", "IsDeleted", "TaxCode", "UpdatedAt", "UserId" },
                values: new object[] { new Guid("3acd11e3-69ff-4d3c-ac73-29cd9f7f839c"), "123 Main St, Cityville", "ABC Company", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE123", null, new Guid("3438161a-836d-4e51-9168-e27611183d2d") });
        }
    }
}
