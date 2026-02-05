using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TetPee.Repository.Migrations
{
    /// <inheritdoc />
    public partial class _12345 : Migration
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
                    { new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần", null, null },
                    { new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "FirstName", "HashedPassword", "ImageUrl", "IsDeleted", "IsVerify", "LastName", "PhoneNumber", "Role", "UpdatedAt", "VerifyCode" },
                values: new object[,]
                {
                    { new Guid("00036b22-fa80-40c6-a959-7bb96855ce29"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan951@gmail.com", "Tan951", "hashed_password_951", null, false, false, "Tran951", null, "user", null, 0 },
                    { new Guid("0101161e-27ff-4437-98ab-8dde0fa7a6d5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan986@gmail.com", "Tan986", "hashed_password_986", null, false, false, "Tran986", null, "user", null, 0 },
                    { new Guid("0121729a-1564-4895-880b-9cccb562a3d7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan385@gmail.com", "Tan385", "hashed_password_385", null, false, false, "Tran385", null, "user", null, 0 },
                    { new Guid("01503c73-763f-4765-bc30-61b1f6dd36e6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan263@gmail.com", "Tan263", "hashed_password_263", null, false, false, "Tran263", null, "user", null, 0 },
                    { new Guid("0179785e-6c08-4323-8aa6-9c5a2fc12767"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan863@gmail.com", "Tan863", "hashed_password_863", null, false, false, "Tran863", null, "user", null, 0 },
                    { new Guid("0205c5a7-553f-40b0-85a7-bb8f48cf901d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan522@gmail.com", "Tan522", "hashed_password_522", null, false, false, "Tran522", null, "user", null, 0 },
                    { new Guid("026f3f6d-a8db-4a74-a354-b952d2ed3e76"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan879@gmail.com", "Tan879", "hashed_password_879", null, false, false, "Tran879", null, "user", null, 0 },
                    { new Guid("029248d2-9800-45c5-ba53-0f3d5fd1ea78"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan395@gmail.com", "Tan395", "hashed_password_395", null, false, false, "Tran395", null, "user", null, 0 },
                    { new Guid("02e6717f-7ce9-4d9f-a384-ffff79f451f6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan75@gmail.com", "Tan75", "hashed_password_75", null, false, false, "Tran75", null, "user", null, 0 },
                    { new Guid("033e4015-167c-4b8f-b536-befaed6ff7be"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan623@gmail.com", "Tan623", "hashed_password_623", null, false, false, "Tran623", null, "user", null, 0 },
                    { new Guid("034c2ab3-a036-4477-80aa-ca97b2ba12e9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan256@gmail.com", "Tan256", "hashed_password_256", null, false, false, "Tran256", null, "user", null, 0 },
                    { new Guid("036dba19-1fc8-44b5-8af6-44ed82ed4d2c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan239@gmail.com", "Tan239", "hashed_password_239", null, false, false, "Tran239", null, "user", null, 0 },
                    { new Guid("03e210e5-6532-42ed-88b4-53f9414026bd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan803@gmail.com", "Tan803", "hashed_password_803", null, false, false, "Tran803", null, "user", null, 0 },
                    { new Guid("0403210a-fe51-4956-8de4-34cb317463a7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan593@gmail.com", "Tan593", "hashed_password_593", null, false, false, "Tran593", null, "user", null, 0 },
                    { new Guid("043f63dc-38c8-435b-ac22-667671b02a11"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan125@gmail.com", "Tan125", "hashed_password_125", null, false, false, "Tran125", null, "user", null, 0 },
                    { new Guid("05057519-5e3d-46be-8aaf-c80a23a27b0b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan493@gmail.com", "Tan493", "hashed_password_493", null, false, false, "Tran493", null, "user", null, 0 },
                    { new Guid("0564b95d-46e5-40c0-a690-8af993dd9f7a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan999@gmail.com", "Tan999", "hashed_password_999", null, false, false, "Tran999", null, "user", null, 0 },
                    { new Guid("057b5b6b-99fa-45b3-b50e-5c6821568010"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan292@gmail.com", "Tan292", "hashed_password_292", null, false, false, "Tran292", null, "user", null, 0 },
                    { new Guid("05a5bf03-d809-4ad9-aac7-dcc22bd225a9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan916@gmail.com", "Tan916", "hashed_password_916", null, false, false, "Tran916", null, "user", null, 0 },
                    { new Guid("05a8ade5-9a8e-4acf-8430-b4f6e016eca7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan288@gmail.com", "Tan288", "hashed_password_288", null, false, false, "Tran288", null, "user", null, 0 },
                    { new Guid("05a93b92-f335-4b7b-b2d9-0b5d668eeb12"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan326@gmail.com", "Tan326", "hashed_password_326", null, false, false, "Tran326", null, "user", null, 0 },
                    { new Guid("0603cceb-2b45-4c09-b3be-7c3b9586bcce"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan647@gmail.com", "Tan647", "hashed_password_647", null, false, false, "Tran647", null, "user", null, 0 },
                    { new Guid("06357151-0c69-4236-b31d-e60490702ed9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan117@gmail.com", "Tan117", "hashed_password_117", null, false, false, "Tran117", null, "user", null, 0 },
                    { new Guid("063a53ee-71fb-4325-a41f-72abb5603ef5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan142@gmail.com", "Tan142", "hashed_password_142", null, false, false, "Tran142", null, "user", null, 0 },
                    { new Guid("06504f5c-26ac-4a8f-adfc-42e441d4a214"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan646@gmail.com", "Tan646", "hashed_password_646", null, false, false, "Tran646", null, "user", null, 0 },
                    { new Guid("06583432-d109-4c87-9992-448ff6241321"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan217@gmail.com", "Tan217", "hashed_password_217", null, false, false, "Tran217", null, "user", null, 0 },
                    { new Guid("065d7112-b1a7-4147-85c6-ef07b43250c7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan328@gmail.com", "Tan328", "hashed_password_328", null, false, false, "Tran328", null, "user", null, 0 },
                    { new Guid("06c8def6-a5a0-48d6-84d6-f46ff3b45686"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan932@gmail.com", "Tan932", "hashed_password_932", null, false, false, "Tran932", null, "user", null, 0 },
                    { new Guid("07308174-545c-4f5b-8cc6-7611dd63fa12"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan100@gmail.com", "Tan100", "hashed_password_100", null, false, false, "Tran100", null, "user", null, 0 },
                    { new Guid("07458f5b-d1c4-4eee-80ea-d1dad021e5b7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan539@gmail.com", "Tan539", "hashed_password_539", null, false, false, "Tran539", null, "user", null, 0 },
                    { new Guid("078e2ebe-782c-4b49-818b-4d7e5a551dbd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan313@gmail.com", "Tan313", "hashed_password_313", null, false, false, "Tran313", null, "user", null, 0 },
                    { new Guid("079fa487-c130-44a0-a5a2-18b96ee392d8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan920@gmail.com", "Tan920", "hashed_password_920", null, false, false, "Tran920", null, "user", null, 0 },
                    { new Guid("084a759f-1282-428c-b2c4-8a43a79d72ae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan201@gmail.com", "Tan201", "hashed_password_201", null, false, false, "Tran201", null, "user", null, 0 },
                    { new Guid("084d48b5-fbf1-496b-a8a3-7b28a3362698"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan940@gmail.com", "Tan940", "hashed_password_940", null, false, false, "Tran940", null, "user", null, 0 },
                    { new Guid("0865620d-5da4-47c4-9265-3f7dc138f39e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan331@gmail.com", "Tan331", "hashed_password_331", null, false, false, "Tran331", null, "user", null, 0 },
                    { new Guid("0951a924-c236-4990-934b-630f0c2cdbbc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan743@gmail.com", "Tan743", "hashed_password_743", null, false, false, "Tran743", null, "user", null, 0 },
                    { new Guid("0954e4cd-9fc5-48fa-be9e-f58993b88290"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan255@gmail.com", "Tan255", "hashed_password_255", null, false, false, "Tran255", null, "user", null, 0 },
                    { new Guid("097d3ef0-fd40-41ab-a39e-a3d401f03bc6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan587@gmail.com", "Tan587", "hashed_password_587", null, false, false, "Tran587", null, "user", null, 0 },
                    { new Guid("098b73de-93c7-45a9-8aaf-410cf20d58c8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan394@gmail.com", "Tan394", "hashed_password_394", null, false, false, "Tran394", null, "user", null, 0 },
                    { new Guid("09e922a7-6292-4e8f-9450-23267a89dcd4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan898@gmail.com", "Tan898", "hashed_password_898", null, false, false, "Tran898", null, "user", null, 0 },
                    { new Guid("09f802ae-ee7f-4dfd-82e8-22f2adf4d9aa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan146@gmail.com", "Tan146", "hashed_password_146", null, false, false, "Tran146", null, "user", null, 0 },
                    { new Guid("0a0ea634-5260-492b-a70c-aa56e444659e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan563@gmail.com", "Tan563", "hashed_password_563", null, false, false, "Tran563", null, "user", null, 0 },
                    { new Guid("0a13b047-81be-4f53-abb1-afe75afa8ac1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan679@gmail.com", "Tan679", "hashed_password_679", null, false, false, "Tran679", null, "user", null, 0 },
                    { new Guid("0aa6eb0b-27ac-477d-af7a-be86e7ec5933"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan643@gmail.com", "Tan643", "hashed_password_643", null, false, false, "Tran643", null, "user", null, 0 },
                    { new Guid("0b378700-9ae8-4476-a309-be31f9697273"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan931@gmail.com", "Tan931", "hashed_password_931", null, false, false, "Tran931", null, "user", null, 0 },
                    { new Guid("0b4c3fd3-89cc-4a87-a926-462dd376bbdb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan780@gmail.com", "Tan780", "hashed_password_780", null, false, false, "Tran780", null, "user", null, 0 },
                    { new Guid("0b7ecb41-0d66-4595-a2b8-b719c551f839"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan203@gmail.com", "Tan203", "hashed_password_203", null, false, false, "Tran203", null, "user", null, 0 },
                    { new Guid("0b86ada9-bad4-4511-90d4-ad5b924ed8fa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan66@gmail.com", "Tan66", "hashed_password_66", null, false, false, "Tran66", null, "user", null, 0 },
                    { new Guid("0c75f0bd-8d26-4df5-a3a3-776eec63c739"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan893@gmail.com", "Tan893", "hashed_password_893", null, false, false, "Tran893", null, "user", null, 0 },
                    { new Guid("0cafbd73-072e-4450-ae4c-d23d66059df2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan752@gmail.com", "Tan752", "hashed_password_752", null, false, false, "Tran752", null, "user", null, 0 },
                    { new Guid("0d3dff61-505c-42b4-988e-733d2a5e80b4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan112@gmail.com", "Tan112", "hashed_password_112", null, false, false, "Tran112", null, "user", null, 0 },
                    { new Guid("0d828ee3-bf52-48ee-85ba-a85f4587ec53"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan666@gmail.com", "Tan666", "hashed_password_666", null, false, false, "Tran666", null, "user", null, 0 },
                    { new Guid("0dd0a815-04dc-4e53-a9b0-b1d07153e612"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan959@gmail.com", "Tan959", "hashed_password_959", null, false, false, "Tran959", null, "user", null, 0 },
                    { new Guid("0e23bbc6-699f-4860-9561-1484e59484d1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan466@gmail.com", "Tan466", "hashed_password_466", null, false, false, "Tran466", null, "user", null, 0 },
                    { new Guid("0e3cd4e5-3f43-4784-b13b-2fa3ad5955a2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan323@gmail.com", "Tan323", "hashed_password_323", null, false, false, "Tran323", null, "user", null, 0 },
                    { new Guid("0e490f63-2232-4d7a-bd1d-16a2acb5cb86"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan997@gmail.com", "Tan997", "hashed_password_997", null, false, false, "Tran997", null, "user", null, 0 },
                    { new Guid("0e915994-9811-4b3a-8b44-30473575c878"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan197@gmail.com", "Tan197", "hashed_password_197", null, false, false, "Tran197", null, "user", null, 0 },
                    { new Guid("0ec71101-ac30-4cad-bb88-b6d930205ff3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan417@gmail.com", "Tan417", "hashed_password_417", null, false, false, "Tran417", null, "user", null, 0 },
                    { new Guid("0eea9cce-934f-4663-a10a-b907deb7d336"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan408@gmail.com", "Tan408", "hashed_password_408", null, false, false, "Tran408", null, "user", null, 0 },
                    { new Guid("0f06e28d-0b53-49a4-990a-5b4bba9a4855"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan107@gmail.com", "Tan107", "hashed_password_107", null, false, false, "Tran107", null, "user", null, 0 },
                    { new Guid("0f317eba-0de8-489e-8e71-d7ceb028fee9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan29@gmail.com", "Tan29", "hashed_password_29", null, false, false, "Tran29", null, "user", null, 0 },
                    { new Guid("0f4ccb4c-60dd-48df-ad2e-15a634ad400c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan770@gmail.com", "Tan770", "hashed_password_770", null, false, false, "Tran770", null, "user", null, 0 },
                    { new Guid("0f7092e8-76af-4b78-964d-bc70030d4ad8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan981@gmail.com", "Tan981", "hashed_password_981", null, false, false, "Tran981", null, "user", null, 0 },
                    { new Guid("0f90358a-1bbc-4f0a-8e2c-fff23582ba27"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan550@gmail.com", "Tan550", "hashed_password_550", null, false, false, "Tran550", null, "user", null, 0 },
                    { new Guid("0fada7d3-222d-4b22-8bc5-90a2ea966781"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan485@gmail.com", "Tan485", "hashed_password_485", null, false, false, "Tran485", null, "user", null, 0 },
                    { new Guid("0fe354f8-7347-420f-bc22-6e2e1d2dfc1e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan171@gmail.com", "Tan171", "hashed_password_171", null, false, false, "Tran171", null, "user", null, 0 },
                    { new Guid("0ff506f3-2ef5-464b-b1a1-17a7fefd6996"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan80@gmail.com", "Tan80", "hashed_password_80", null, false, false, "Tran80", null, "user", null, 0 },
                    { new Guid("102cc218-0acf-4c2f-ac19-4f4063b3ad13"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan73@gmail.com", "Tan73", "hashed_password_73", null, false, false, "Tran73", null, "user", null, 0 },
                    { new Guid("10674bac-5dfe-4eef-ada6-d8b2250d9396"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan541@gmail.com", "Tan541", "hashed_password_541", null, false, false, "Tran541", null, "user", null, 0 },
                    { new Guid("106839b3-b82c-48e0-84a4-b26a8d1a8b85"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan796@gmail.com", "Tan796", "hashed_password_796", null, false, false, "Tran796", null, "user", null, 0 },
                    { new Guid("109b7430-8dbb-43b6-9985-9fb5a036119d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan972@gmail.com", "Tan972", "hashed_password_972", null, false, false, "Tran972", null, "user", null, 0 },
                    { new Guid("10a1a493-058d-4d46-8a78-4a383055e143"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan735@gmail.com", "Tan735", "hashed_password_735", null, false, false, "Tran735", null, "user", null, 0 },
                    { new Guid("10c1f47e-bd87-4375-989c-02e41aa99d4e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan917@gmail.com", "Tan917", "hashed_password_917", null, false, false, "Tran917", null, "user", null, 0 },
                    { new Guid("11360804-50b5-413f-93da-b3cfe00382bd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan98@gmail.com", "Tan98", "hashed_password_98", null, false, false, "Tran98", null, "user", null, 0 },
                    { new Guid("1152c3ad-d572-4913-a6e7-e172321a23a1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "tan182205@gmail.com", "Tan", "hashed_password_1", null, false, false, "Tran", null, "user", null, 0 },
                    { new Guid("1188a663-255a-4a3b-a007-ac61039bcb56"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan579@gmail.com", "Tan579", "hashed_password_579", null, false, false, "Tran579", null, "user", null, 0 },
                    { new Guid("1294cf50-e0b8-476d-ab81-c9eebb3b3622"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan854@gmail.com", "Tan854", "hashed_password_854", null, false, false, "Tran854", null, "user", null, 0 },
                    { new Guid("1309e877-e744-4f4e-ac66-d68cbd511fd8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan556@gmail.com", "Tan556", "hashed_password_556", null, false, false, "Tran556", null, "user", null, 0 },
                    { new Guid("133dd920-d48a-4ba3-8c7c-7bd2ac0b999b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan857@gmail.com", "Tan857", "hashed_password_857", null, false, false, "Tran857", null, "user", null, 0 },
                    { new Guid("137b5c3e-8f6d-494b-801b-e0e342d5c21f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan977@gmail.com", "Tan977", "hashed_password_977", null, false, false, "Tran977", null, "user", null, 0 },
                    { new Guid("137dc94c-2f50-4a29-abbe-d27eabd6da02"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan800@gmail.com", "Tan800", "hashed_password_800", null, false, false, "Tran800", null, "user", null, 0 },
                    { new Guid("1391a953-fb3c-4650-9d80-9889d8593a0d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan175@gmail.com", "Tan175", "hashed_password_175", null, false, false, "Tran175", null, "user", null, 0 },
                    { new Guid("13cd0784-d161-4684-bd0f-6afd5803baa5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan369@gmail.com", "Tan369", "hashed_password_369", null, false, false, "Tran369", null, "user", null, 0 },
                    { new Guid("13cf229d-1b10-49b1-a014-3c29306bb5e1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan468@gmail.com", "Tan468", "hashed_password_468", null, false, false, "Tran468", null, "user", null, 0 },
                    { new Guid("13d507e3-e88d-48dc-9a14-9cb9d1b760a1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan641@gmail.com", "Tan641", "hashed_password_641", null, false, false, "Tran641", null, "user", null, 0 },
                    { new Guid("13e27d8f-8480-4fcd-96bd-d528ab834600"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan240@gmail.com", "Tan240", "hashed_password_240", null, false, false, "Tran240", null, "user", null, 0 },
                    { new Guid("14afd07b-e665-4366-b7ff-2c2384d5f93c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan673@gmail.com", "Tan673", "hashed_password_673", null, false, false, "Tran673", null, "user", null, 0 },
                    { new Guid("14cd3232-375b-45ae-9804-9bcbd1c507c5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan892@gmail.com", "Tan892", "hashed_password_892", null, false, false, "Tran892", null, "user", null, 0 },
                    { new Guid("15f84b10-6b5e-4451-acfd-14a2015edf3b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan905@gmail.com", "Tan905", "hashed_password_905", null, false, false, "Tran905", null, "user", null, 0 },
                    { new Guid("160e10fa-550e-4534-9c12-94640bfef364"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan247@gmail.com", "Tan247", "hashed_password_247", null, false, false, "Tran247", null, "user", null, 0 },
                    { new Guid("1636ebe3-1ce9-4c1c-924e-f6f5594e6864"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan403@gmail.com", "Tan403", "hashed_password_403", null, false, false, "Tran403", null, "user", null, 0 },
                    { new Guid("163e5805-f48c-46d2-b007-0e6530385bf9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan189@gmail.com", "Tan189", "hashed_password_189", null, false, false, "Tran189", null, "user", null, 0 },
                    { new Guid("16760830-e1a1-4041-85be-453df59d61f0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan927@gmail.com", "Tan927", "hashed_password_927", null, false, false, "Tran927", null, "user", null, 0 },
                    { new Guid("16b103ab-54fb-4e2a-a344-815350147f9a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan246@gmail.com", "Tan246", "hashed_password_246", null, false, false, "Tran246", null, "user", null, 0 },
                    { new Guid("16be594f-0281-4217-9475-371be7184659"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan221@gmail.com", "Tan221", "hashed_password_221", null, false, false, "Tran221", null, "user", null, 0 },
                    { new Guid("16d3bb1f-1f70-4115-9b98-3ba86e6829be"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan25@gmail.com", "Tan25", "hashed_password_25", null, false, false, "Tran25", null, "user", null, 0 },
                    { new Guid("16e5d4d9-41d3-4b55-bcd1-43b344996adf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "tan182206@gmail.com", "Tan", "hashed_password_1", null, false, false, "Tran", null, "user", null, 0 },
                    { new Guid("1740fe02-4644-418e-a69b-5d1aab0cfd98"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan585@gmail.com", "Tan585", "hashed_password_585", null, false, false, "Tran585", null, "user", null, 0 },
                    { new Guid("17c549c9-88ee-444d-ba5d-910b07bda143"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan704@gmail.com", "Tan704", "hashed_password_704", null, false, false, "Tran704", null, "user", null, 0 },
                    { new Guid("18634104-24dd-4125-8431-97e5734c106c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan703@gmail.com", "Tan703", "hashed_password_703", null, false, false, "Tran703", null, "user", null, 0 },
                    { new Guid("186b9ef1-000e-4b13-b44e-bd806dac5db7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan477@gmail.com", "Tan477", "hashed_password_477", null, false, false, "Tran477", null, "user", null, 0 },
                    { new Guid("18b2ce9f-2873-4e18-8cd4-b9d8b87c8e93"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan801@gmail.com", "Tan801", "hashed_password_801", null, false, false, "Tran801", null, "user", null, 0 },
                    { new Guid("18b420d2-f2ee-4cdc-b967-88bf1c14d9f0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan737@gmail.com", "Tan737", "hashed_password_737", null, false, false, "Tran737", null, "user", null, 0 },
                    { new Guid("18de8209-924b-486d-b594-e0b0a192867b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan726@gmail.com", "Tan726", "hashed_password_726", null, false, false, "Tran726", null, "user", null, 0 },
                    { new Guid("18f36a9f-88cc-4a11-b751-a3f12b1fe452"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan941@gmail.com", "Tan941", "hashed_password_941", null, false, false, "Tran941", null, "user", null, 0 },
                    { new Guid("18f710ab-67f0-4708-9a94-219141dceaef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan195@gmail.com", "Tan195", "hashed_password_195", null, false, false, "Tran195", null, "user", null, 0 },
                    { new Guid("1916e883-6148-41a4-93ea-ad4857eda251"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan602@gmail.com", "Tan602", "hashed_password_602", null, false, false, "Tran602", null, "user", null, 0 },
                    { new Guid("196a8bec-03ee-484c-9968-f85acdfb9cb0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan512@gmail.com", "Tan512", "hashed_password_512", null, false, false, "Tran512", null, "user", null, 0 },
                    { new Guid("19d463d3-b81f-41c0-9e9e-c199af01c835"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan446@gmail.com", "Tan446", "hashed_password_446", null, false, false, "Tran446", null, "user", null, 0 },
                    { new Guid("1a044f3a-d0a7-416a-ac44-ef5432abe96b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan837@gmail.com", "Tan837", "hashed_password_837", null, false, false, "Tran837", null, "user", null, 0 },
                    { new Guid("1a254335-8ca8-42a0-905a-49c262c62020"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan632@gmail.com", "Tan632", "hashed_password_632", null, false, false, "Tran632", null, "user", null, 0 },
                    { new Guid("1a4c5040-9bc0-43dc-832d-e41dbc0c118f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan814@gmail.com", "Tan814", "hashed_password_814", null, false, false, "Tran814", null, "user", null, 0 },
                    { new Guid("1a5a60b9-5618-40aa-abd7-bb76337bb4e5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan442@gmail.com", "Tan442", "hashed_password_442", null, false, false, "Tran442", null, "user", null, 0 },
                    { new Guid("1ae7638c-1e1c-44a8-9f41-efc4b57085a4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan612@gmail.com", "Tan612", "hashed_password_612", null, false, false, "Tran612", null, "user", null, 0 },
                    { new Guid("1b55fd72-1520-47ec-8aa1-b6f35cdf6566"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan76@gmail.com", "Tan76", "hashed_password_76", null, false, false, "Tran76", null, "user", null, 0 },
                    { new Guid("1b6bc939-0234-445b-92cf-5813391b0d07"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan498@gmail.com", "Tan498", "hashed_password_498", null, false, false, "Tran498", null, "user", null, 0 },
                    { new Guid("1bc6d853-2f15-49eb-a5e0-2d281b7f1f31"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan766@gmail.com", "Tan766", "hashed_password_766", null, false, false, "Tran766", null, "user", null, 0 },
                    { new Guid("1bd4b3c9-fba6-4b10-a4dd-ae1c908e8499"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan899@gmail.com", "Tan899", "hashed_password_899", null, false, false, "Tran899", null, "user", null, 0 },
                    { new Guid("1cb22af1-97ed-45cb-b75a-a0b6fef7d5fa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan128@gmail.com", "Tan128", "hashed_password_128", null, false, false, "Tran128", null, "user", null, 0 },
                    { new Guid("1d1413f6-cae7-4e67-9f13-8c43ba7b3b7a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan259@gmail.com", "Tan259", "hashed_password_259", null, false, false, "Tran259", null, "user", null, 0 },
                    { new Guid("1d7b0a7c-a1ab-4e6b-92b8-de98174ac0af"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan699@gmail.com", "Tan699", "hashed_password_699", null, false, false, "Tran699", null, "user", null, 0 },
                    { new Guid("1d7c2198-fdae-4dba-a0e8-f9fda7329951"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan307@gmail.com", "Tan307", "hashed_password_307", null, false, false, "Tran307", null, "user", null, 0 },
                    { new Guid("1d803c2c-017b-4c26-b63b-fde569ed1135"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan170@gmail.com", "Tan170", "hashed_password_170", null, false, false, "Tran170", null, "user", null, 0 },
                    { new Guid("1dea8ae4-eab7-4367-86f2-dfe2d36bb4b3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan3@gmail.com", "Tan3", "hashed_password_3", null, false, false, "Tran3", null, "user", null, 0 },
                    { new Guid("1dfcbbc5-68c2-4a86-9f72-a2cfe070d889"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan711@gmail.com", "Tan711", "hashed_password_711", null, false, false, "Tran711", null, "user", null, 0 },
                    { new Guid("1e01fdd1-cc93-4a28-aa67-36e369973b46"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan667@gmail.com", "Tan667", "hashed_password_667", null, false, false, "Tran667", null, "user", null, 0 },
                    { new Guid("1e194f73-46b4-490b-bac4-f55e24b4e320"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan943@gmail.com", "Tan943", "hashed_password_943", null, false, false, "Tran943", null, "user", null, 0 },
                    { new Guid("1e65ba7e-2d58-461e-a993-daad6740e27d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan48@gmail.com", "Tan48", "hashed_password_48", null, false, false, "Tran48", null, "user", null, 0 },
                    { new Guid("1e68625b-4e13-4922-9a37-6d8089a34512"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan286@gmail.com", "Tan286", "hashed_password_286", null, false, false, "Tran286", null, "user", null, 0 },
                    { new Guid("1e7327a0-1d38-49eb-9a9b-1066e412f513"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan564@gmail.com", "Tan564", "hashed_password_564", null, false, false, "Tran564", null, "user", null, 0 },
                    { new Guid("1ea9f99e-ff40-405a-93e2-ec27a9b764b5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan337@gmail.com", "Tan337", "hashed_password_337", null, false, false, "Tran337", null, "user", null, 0 },
                    { new Guid("1f669773-eada-4f2f-b2ff-79eae1af7917"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan2@gmail.com", "Tan2", "hashed_password_2", null, false, false, "Tran2", null, "user", null, 0 },
                    { new Guid("20210e0b-78ec-4cfd-85c3-7619f5a35818"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan551@gmail.com", "Tan551", "hashed_password_551", null, false, false, "Tran551", null, "user", null, 0 },
                    { new Guid("2043e4d3-a61d-45d7-920f-c04ba2d66550"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan4@gmail.com", "Tan4", "hashed_password_4", null, false, false, "Tran4", null, "user", null, 0 },
                    { new Guid("20445e35-dbc6-4277-933b-53826e6fbcc5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan826@gmail.com", "Tan826", "hashed_password_826", null, false, false, "Tran826", null, "user", null, 0 },
                    { new Guid("20a5a1b5-d310-4f27-953d-a94a6c752187"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan729@gmail.com", "Tan729", "hashed_password_729", null, false, false, "Tran729", null, "user", null, 0 },
                    { new Guid("20df5a45-4bda-4c86-9487-480406b89b4c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan925@gmail.com", "Tan925", "hashed_password_925", null, false, false, "Tran925", null, "user", null, 0 },
                    { new Guid("20dfde4e-cfb0-4c11-bb52-c48ee7310027"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan991@gmail.com", "Tan991", "hashed_password_991", null, false, false, "Tran991", null, "user", null, 0 },
                    { new Guid("211a3093-a9a6-4021-a005-ef17879facdc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan600@gmail.com", "Tan600", "hashed_password_600", null, false, false, "Tran600", null, "user", null, 0 },
                    { new Guid("21bb67b0-51b6-4439-b76a-d6042d266185"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan480@gmail.com", "Tan480", "hashed_password_480", null, false, false, "Tran480", null, "user", null, 0 },
                    { new Guid("222e1b60-e64e-4393-928c-52b263ccb1a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan227@gmail.com", "Tan227", "hashed_password_227", null, false, false, "Tran227", null, "user", null, 0 },
                    { new Guid("2254e60c-49c9-4228-89ad-45f0e901f5d7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan183@gmail.com", "Tan183", "hashed_password_183", null, false, false, "Tran183", null, "user", null, 0 },
                    { new Guid("229ac764-a891-4244-8e68-601f3a4103ca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan65@gmail.com", "Tan65", "hashed_password_65", null, false, false, "Tran65", null, "user", null, 0 },
                    { new Guid("22b1fbd0-dd13-41a4-b992-0720668a33e3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan427@gmail.com", "Tan427", "hashed_password_427", null, false, false, "Tran427", null, "user", null, 0 },
                    { new Guid("22b6d73b-96b1-44e3-a5e4-b2fa438e21fc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan928@gmail.com", "Tan928", "hashed_password_928", null, false, false, "Tran928", null, "user", null, 0 },
                    { new Guid("22ef8f10-792b-4c57-9bd7-bb79e0664d5c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan214@gmail.com", "Tan214", "hashed_password_214", null, false, false, "Tran214", null, "user", null, 0 },
                    { new Guid("230792c1-0f0c-47f9-9d01-dcabdeeb7d0f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan855@gmail.com", "Tan855", "hashed_password_855", null, false, false, "Tran855", null, "user", null, 0 },
                    { new Guid("233f6172-9531-426a-ba1c-f7495c73a570"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan610@gmail.com", "Tan610", "hashed_password_610", null, false, false, "Tran610", null, "user", null, 0 },
                    { new Guid("23ad5ac8-8016-46d4-90fb-bd3c88d9a4e1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan947@gmail.com", "Tan947", "hashed_password_947", null, false, false, "Tran947", null, "user", null, 0 },
                    { new Guid("244904db-de7d-49f6-9109-644fe6d7655c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan373@gmail.com", "Tan373", "hashed_password_373", null, false, false, "Tran373", null, "user", null, 0 },
                    { new Guid("24b8b61b-4887-4129-8017-75a2c62c6836"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan633@gmail.com", "Tan633", "hashed_password_633", null, false, false, "Tran633", null, "user", null, 0 },
                    { new Guid("24d2d875-eb91-4186-9f3b-a91755b4099d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan572@gmail.com", "Tan572", "hashed_password_572", null, false, false, "Tran572", null, "user", null, 0 },
                    { new Guid("24e6670c-e24b-4807-8f96-ab8ce4a795de"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan213@gmail.com", "Tan213", "hashed_password_213", null, false, false, "Tran213", null, "user", null, 0 },
                    { new Guid("257bcff0-d13d-43a6-a2cc-aef950c2d445"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan862@gmail.com", "Tan862", "hashed_password_862", null, false, false, "Tran862", null, "user", null, 0 },
                    { new Guid("25a37c97-fad2-4cbe-a3c6-6e18700c8dfe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan844@gmail.com", "Tan844", "hashed_password_844", null, false, false, "Tran844", null, "user", null, 0 },
                    { new Guid("26a551ee-7852-4b68-9da8-3eff031d23c9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan465@gmail.com", "Tan465", "hashed_password_465", null, false, false, "Tran465", null, "user", null, 0 },
                    { new Guid("27006934-f3ad-456b-a397-613210a25576"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan827@gmail.com", "Tan827", "hashed_password_827", null, false, false, "Tran827", null, "user", null, 0 },
                    { new Guid("275c83ba-4aff-48f2-a269-ce1d9635542a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan499@gmail.com", "Tan499", "hashed_password_499", null, false, false, "Tran499", null, "user", null, 0 },
                    { new Guid("2785a4be-e54b-45b1-8da8-b4c73b128a0d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan746@gmail.com", "Tan746", "hashed_password_746", null, false, false, "Tran746", null, "user", null, 0 },
                    { new Guid("2791a607-b2ba-4933-b970-438d3b02dc3a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan877@gmail.com", "Tan877", "hashed_password_877", null, false, false, "Tran877", null, "user", null, 0 },
                    { new Guid("27c3764f-dd45-4025-9ba9-f2b122f2115e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan934@gmail.com", "Tan934", "hashed_password_934", null, false, false, "Tran934", null, "user", null, 0 },
                    { new Guid("282c445c-c601-4f88-9a36-82b9520e4e26"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan750@gmail.com", "Tan750", "hashed_password_750", null, false, false, "Tran750", null, "user", null, 0 },
                    { new Guid("283e0852-5aa0-4f2c-a691-3b283a581154"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan817@gmail.com", "Tan817", "hashed_password_817", null, false, false, "Tran817", null, "user", null, 0 },
                    { new Guid("283e88ed-ddd9-4d94-b9d7-8cda8c5b6ec3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan606@gmail.com", "Tan606", "hashed_password_606", null, false, false, "Tran606", null, "user", null, 0 },
                    { new Guid("2857e2be-dca1-437b-9d2d-427215a417f6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan573@gmail.com", "Tan573", "hashed_password_573", null, false, false, "Tran573", null, "user", null, 0 },
                    { new Guid("29a3d4b2-8640-471e-9e6e-0390dc670fde"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan308@gmail.com", "Tan308", "hashed_password_308", null, false, false, "Tran308", null, "user", null, 0 },
                    { new Guid("2a3d6da7-1f63-4831-a47d-467b4b8143cd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan290@gmail.com", "Tan290", "hashed_password_290", null, false, false, "Tran290", null, "user", null, 0 },
                    { new Guid("2ad115a6-73bf-4f49-896e-24038e185a2b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan773@gmail.com", "Tan773", "hashed_password_773", null, false, false, "Tran773", null, "user", null, 0 },
                    { new Guid("2b169532-5b4b-4c2c-b35f-f4edeaf68e9c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan583@gmail.com", "Tan583", "hashed_password_583", null, false, false, "Tran583", null, "user", null, 0 },
                    { new Guid("2b37b53b-9d4b-4074-bad2-4e987f1185ef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan710@gmail.com", "Tan710", "hashed_password_710", null, false, false, "Tran710", null, "user", null, 0 },
                    { new Guid("2b3d6750-4ae6-49b4-a3fa-a11b024ebf0f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan268@gmail.com", "Tan268", "hashed_password_268", null, false, false, "Tran268", null, "user", null, 0 },
                    { new Guid("2ba6125c-5b09-4e03-911e-599ae71cc90d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan269@gmail.com", "Tan269", "hashed_password_269", null, false, false, "Tran269", null, "user", null, 0 },
                    { new Guid("2bbec3ff-3662-499b-bb53-72572d4210c9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan946@gmail.com", "Tan946", "hashed_password_946", null, false, false, "Tran946", null, "user", null, 0 },
                    { new Guid("2c26d8c0-64be-4ac1-a5af-1d4b8b485fca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan104@gmail.com", "Tan104", "hashed_password_104", null, false, false, "Tran104", null, "user", null, 0 },
                    { new Guid("2c51361b-88ef-4cf0-95b0-c91759babf1f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan237@gmail.com", "Tan237", "hashed_password_237", null, false, false, "Tran237", null, "user", null, 0 },
                    { new Guid("2c851ba1-bb1c-4a00-a6f9-c43e6dcdfc66"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan533@gmail.com", "Tan533", "hashed_password_533", null, false, false, "Tran533", null, "user", null, 0 },
                    { new Guid("2c8af53f-2f95-4e65-8242-c5f7151b7323"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan540@gmail.com", "Tan540", "hashed_password_540", null, false, false, "Tran540", null, "user", null, 0 },
                    { new Guid("2cf1d815-6927-4524-8bd5-920e8f54a22d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan399@gmail.com", "Tan399", "hashed_password_399", null, false, false, "Tran399", null, "user", null, 0 },
                    { new Guid("2cff7884-58a5-47c4-8de8-f4f699e72cdf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan131@gmail.com", "Tan131", "hashed_password_131", null, false, false, "Tran131", null, "user", null, 0 },
                    { new Guid("2d7e8d09-4126-4671-8e78-b13ca787c5fd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan771@gmail.com", "Tan771", "hashed_password_771", null, false, false, "Tran771", null, "user", null, 0 },
                    { new Guid("2dcdf657-80a8-4925-81f0-1d58505a0f8c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan216@gmail.com", "Tan216", "hashed_password_216", null, false, false, "Tran216", null, "user", null, 0 },
                    { new Guid("2e07efd1-5042-48bd-a474-dd40aa3a3dca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan912@gmail.com", "Tan912", "hashed_password_912", null, false, false, "Tran912", null, "user", null, 0 },
                    { new Guid("2ec5ddf3-583c-43f4-941a-aa5c039f4096"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan684@gmail.com", "Tan684", "hashed_password_684", null, false, false, "Tran684", null, "user", null, 0 },
                    { new Guid("2f44c591-45cb-44bd-a34f-29878f4ba52f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan144@gmail.com", "Tan144", "hashed_password_144", null, false, false, "Tran144", null, "user", null, 0 },
                    { new Guid("2f59281d-4b17-4754-ace8-8ac61df0b7b7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan508@gmail.com", "Tan508", "hashed_password_508", null, false, false, "Tran508", null, "user", null, 0 },
                    { new Guid("2fc1fcbe-1d9c-45bd-a516-25b9db2ca2c4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan34@gmail.com", "Tan34", "hashed_password_34", null, false, false, "Tran34", null, "user", null, 0 },
                    { new Guid("3012ac66-90d7-424c-8cda-c7973ca0c755"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan884@gmail.com", "Tan884", "hashed_password_884", null, false, false, "Tran884", null, "user", null, 0 },
                    { new Guid("30135232-7222-4f3b-be84-b422759d1085"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan852@gmail.com", "Tan852", "hashed_password_852", null, false, false, "Tran852", null, "user", null, 0 },
                    { new Guid("3051e27d-abfa-4cf7-af20-003e9ec39d21"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan367@gmail.com", "Tan367", "hashed_password_367", null, false, false, "Tran367", null, "user", null, 0 },
                    { new Guid("3053256e-edc2-499e-a355-3dbab9cbfaa8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan481@gmail.com", "Tan481", "hashed_password_481", null, false, false, "Tran481", null, "user", null, 0 },
                    { new Guid("306ec1f3-b781-4aee-a6aa-43a9d439e376"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan356@gmail.com", "Tan356", "hashed_password_356", null, false, false, "Tran356", null, "user", null, 0 },
                    { new Guid("30744684-6418-4272-8fab-0fc902589a34"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan173@gmail.com", "Tan173", "hashed_password_173", null, false, false, "Tran173", null, "user", null, 0 },
                    { new Guid("316a475a-9e0b-4e1e-9939-f2e5f4837a04"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan662@gmail.com", "Tan662", "hashed_password_662", null, false, false, "Tran662", null, "user", null, 0 },
                    { new Guid("31abead8-8665-42a7-9a3a-05ef189836eb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan57@gmail.com", "Tan57", "hashed_password_57", null, false, false, "Tran57", null, "user", null, 0 },
                    { new Guid("31ed9126-e9a1-4b67-8f5b-28cad8f2e27a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan830@gmail.com", "Tan830", "hashed_password_830", null, false, false, "Tran830", null, "user", null, 0 },
                    { new Guid("323814b2-747f-43f4-bb82-fb915e440f33"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan35@gmail.com", "Tan35", "hashed_password_35", null, false, false, "Tran35", null, "user", null, 0 },
                    { new Guid("325870ca-04e1-4ce2-ad96-85bf16a75fe6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan524@gmail.com", "Tan524", "hashed_password_524", null, false, false, "Tran524", null, "user", null, 0 },
                    { new Guid("32879947-dd82-4b06-9377-ad5cbfc051b1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan968@gmail.com", "Tan968", "hashed_password_968", null, false, false, "Tran968", null, "user", null, 0 },
                    { new Guid("32b57042-70ee-4634-bb62-9cf429a9f163"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan560@gmail.com", "Tan560", "hashed_password_560", null, false, false, "Tran560", null, "user", null, 0 },
                    { new Guid("32bc0db1-84d9-4b1a-aab3-e7a9441e310f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan525@gmail.com", "Tan525", "hashed_password_525", null, false, false, "Tran525", null, "user", null, 0 },
                    { new Guid("32dbcc86-c531-4180-a98e-4691facf100e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan17@gmail.com", "Tan17", "hashed_password_17", null, false, false, "Tran17", null, "user", null, 0 },
                    { new Guid("32f58506-8b44-4474-9c9a-c9871618eda6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan254@gmail.com", "Tan254", "hashed_password_254", null, false, false, "Tran254", null, "user", null, 0 },
                    { new Guid("333c52ed-89b6-48be-a140-e95c8570e79f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan709@gmail.com", "Tan709", "hashed_password_709", null, false, false, "Tran709", null, "user", null, 0 },
                    { new Guid("336b041b-44af-413f-89cf-ef5f47679bfe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan978@gmail.com", "Tan978", "hashed_password_978", null, false, false, "Tran978", null, "user", null, 0 },
                    { new Guid("3379a741-fbf6-4dd2-96d8-19742f92f6f1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan566@gmail.com", "Tan566", "hashed_password_566", null, false, false, "Tran566", null, "user", null, 0 },
                    { new Guid("33cafee5-f5f4-4d40-b36d-4981a979c29f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan296@gmail.com", "Tan296", "hashed_password_296", null, false, false, "Tran296", null, "user", null, 0 },
                    { new Guid("33eb8284-9757-4a78-8806-10e521728f9f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan62@gmail.com", "Tan62", "hashed_password_62", null, false, false, "Tran62", null, "user", null, 0 },
                    { new Guid("3469e601-9e55-4d29-baa9-b26c73a22cf9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan544@gmail.com", "Tan544", "hashed_password_544", null, false, false, "Tran544", null, "user", null, 0 },
                    { new Guid("34aed693-9a43-42a0-8326-b8d58c1494be"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan70@gmail.com", "Tan70", "hashed_password_70", null, false, false, "Tran70", null, "user", null, 0 },
                    { new Guid("34c2c93a-6ac8-40ed-88af-09b6ae38eff3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan330@gmail.com", "Tan330", "hashed_password_330", null, false, false, "Tran330", null, "user", null, 0 },
                    { new Guid("35013e9b-3899-4baf-bf15-b1b0687d111b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan786@gmail.com", "Tan786", "hashed_password_786", null, false, false, "Tran786", null, "user", null, 0 },
                    { new Guid("3591cb1b-07a0-456f-ad53-019d6b3eeee3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan495@gmail.com", "Tan495", "hashed_password_495", null, false, false, "Tran495", null, "user", null, 0 },
                    { new Guid("35a0328f-3a39-499a-b266-765764f0cfed"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan458@gmail.com", "Tan458", "hashed_password_458", null, false, false, "Tran458", null, "user", null, 0 },
                    { new Guid("35c6a5e1-0b5e-4d20-9b0c-611cf02b14fc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan437@gmail.com", "Tan437", "hashed_password_437", null, false, false, "Tran437", null, "user", null, 0 },
                    { new Guid("362fe557-0b49-4ef8-8e2d-0fa5b9132284"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan243@gmail.com", "Tan243", "hashed_password_243", null, false, false, "Tran243", null, "user", null, 0 },
                    { new Guid("3649e2f1-9a43-4273-9c4f-3dd5a342f5b1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan347@gmail.com", "Tan347", "hashed_password_347", null, false, false, "Tran347", null, "user", null, 0 },
                    { new Guid("36758ee5-56f6-4c6a-94f5-073ea759880c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan462@gmail.com", "Tan462", "hashed_password_462", null, false, false, "Tran462", null, "user", null, 0 },
                    { new Guid("367ab3e1-c8ed-4a5e-afb8-1294edff266d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan297@gmail.com", "Tan297", "hashed_password_297", null, false, false, "Tran297", null, "user", null, 0 },
                    { new Guid("3694a0e0-c796-40fe-af10-bd7b6cf77141"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan976@gmail.com", "Tan976", "hashed_password_976", null, false, false, "Tran976", null, "user", null, 0 },
                    { new Guid("36b33991-2822-4cc6-9d82-abc5fc7575d7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan272@gmail.com", "Tan272", "hashed_password_272", null, false, false, "Tran272", null, "user", null, 0 },
                    { new Guid("36d1e83f-d814-42de-bf96-e4915b54ff62"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan406@gmail.com", "Tan406", "hashed_password_406", null, false, false, "Tran406", null, "user", null, 0 },
                    { new Guid("36fc3491-448d-4697-bc99-cb4924c0ec18"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan637@gmail.com", "Tan637", "hashed_password_637", null, false, false, "Tran637", null, "user", null, 0 },
                    { new Guid("3704689e-a92e-4081-847e-e8008a40ec56"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan706@gmail.com", "Tan706", "hashed_password_706", null, false, false, "Tran706", null, "user", null, 0 },
                    { new Guid("371f527c-31da-4051-98f3-4de366aef96b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan134@gmail.com", "Tan134", "hashed_password_134", null, false, false, "Tran134", null, "user", null, 0 },
                    { new Guid("37e414cb-4e4b-4500-8d08-733e2a35ba92"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan470@gmail.com", "Tan470", "hashed_password_470", null, false, false, "Tran470", null, "user", null, 0 },
                    { new Guid("380e5f32-2821-47eb-a9a3-ba6d81545bea"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan598@gmail.com", "Tan598", "hashed_password_598", null, false, false, "Tran598", null, "user", null, 0 },
                    { new Guid("3814dd2a-1295-45e5-9afa-87a907dffa7a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan114@gmail.com", "Tan114", "hashed_password_114", null, false, false, "Tran114", null, "user", null, 0 },
                    { new Guid("382237f1-a4e0-4b42-8950-8115352aa350"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan153@gmail.com", "Tan153", "hashed_password_153", null, false, false, "Tran153", null, "user", null, 0 },
                    { new Guid("38592ac1-b6a6-48b5-8cdb-978b602ff82e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan881@gmail.com", "Tan881", "hashed_password_881", null, false, false, "Tran881", null, "user", null, 0 },
                    { new Guid("38d6ee12-9399-4b6e-9738-d27c4afa4d9b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan740@gmail.com", "Tan740", "hashed_password_740", null, false, false, "Tran740", null, "user", null, 0 },
                    { new Guid("39472f7c-0057-42da-ae92-058a838d1a59"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan202@gmail.com", "Tan202", "hashed_password_202", null, false, false, "Tran202", null, "user", null, 0 },
                    { new Guid("39500352-cef6-43b7-b351-c6b2c6e0fe4f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan813@gmail.com", "Tan813", "hashed_password_813", null, false, false, "Tran813", null, "user", null, 0 },
                    { new Guid("3950de38-e382-4a76-84e0-4cbd6e61496e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan249@gmail.com", "Tan249", "hashed_password_249", null, false, false, "Tran249", null, "user", null, 0 },
                    { new Guid("3967114d-4afb-4512-b464-b2420b66bdfd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan880@gmail.com", "Tan880", "hashed_password_880", null, false, false, "Tran880", null, "user", null, 0 },
                    { new Guid("39d91084-5814-4fc5-87d2-8dc87d3fe5d6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan40@gmail.com", "Tan40", "hashed_password_40", null, false, false, "Tran40", null, "user", null, 0 },
                    { new Guid("39e418e3-50ae-47f3-8896-a79ee3a5bc16"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan716@gmail.com", "Tan716", "hashed_password_716", null, false, false, "Tran716", null, "user", null, 0 },
                    { new Guid("39f130f7-df46-476e-a03a-15571d9fb860"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan81@gmail.com", "Tan81", "hashed_password_81", null, false, false, "Tran81", null, "user", null, 0 },
                    { new Guid("3a081ae5-deea-4ed1-9cac-c0c802d35c2f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan538@gmail.com", "Tan538", "hashed_password_538", null, false, false, "Tran538", null, "user", null, 0 },
                    { new Guid("3a445815-d539-49a4-92de-d68f9151fe54"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan471@gmail.com", "Tan471", "hashed_password_471", null, false, false, "Tran471", null, "user", null, 0 },
                    { new Guid("3ab2a517-4e26-4831-a8a2-a0f591140bfd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan599@gmail.com", "Tan599", "hashed_password_599", null, false, false, "Tran599", null, "user", null, 0 },
                    { new Guid("3accabb6-6296-46a6-b84d-76a85bc80d78"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan289@gmail.com", "Tan289", "hashed_password_289", null, false, false, "Tran289", null, "user", null, 0 },
                    { new Guid("3afc144e-c8c4-45b0-85e6-3c3206f14ea4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan960@gmail.com", "Tan960", "hashed_password_960", null, false, false, "Tran960", null, "user", null, 0 },
                    { new Guid("3b1d7888-32a5-4483-b73c-f437ae1ff5f6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan938@gmail.com", "Tan938", "hashed_password_938", null, false, false, "Tran938", null, "user", null, 0 },
                    { new Guid("3b821e26-064a-4754-b31b-05082c82af30"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan918@gmail.com", "Tan918", "hashed_password_918", null, false, false, "Tran918", null, "user", null, 0 },
                    { new Guid("3b90c1f4-b5db-40b3-b91f-dbb947be4b1a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan569@gmail.com", "Tan569", "hashed_password_569", null, false, false, "Tran569", null, "user", null, 0 },
                    { new Guid("3ba37a85-5cc9-41d6-876a-0c30399d087a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan434@gmail.com", "Tan434", "hashed_password_434", null, false, false, "Tran434", null, "user", null, 0 },
                    { new Guid("3ba465ad-fe5f-4566-bc53-4a91d8c8473c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan319@gmail.com", "Tan319", "hashed_password_319", null, false, false, "Tran319", null, "user", null, 0 },
                    { new Guid("3be4d545-172f-4f2e-93b4-fef072eda2d6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan176@gmail.com", "Tan176", "hashed_password_176", null, false, false, "Tran176", null, "user", null, 0 },
                    { new Guid("3c0d547f-1044-4d1d-b343-0feeebed224d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan205@gmail.com", "Tan205", "hashed_password_205", null, false, false, "Tran205", null, "user", null, 0 },
                    { new Guid("3c330672-19b2-47aa-91f4-e8236e6f942f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan621@gmail.com", "Tan621", "hashed_password_621", null, false, false, "Tran621", null, "user", null, 0 },
                    { new Guid("3c3701a1-fb07-497d-9031-56b980f90477"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan516@gmail.com", "Tan516", "hashed_password_516", null, false, false, "Tran516", null, "user", null, 0 },
                    { new Guid("3c53509d-3042-4cea-ba57-1e4d7db745ba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan302@gmail.com", "Tan302", "hashed_password_302", null, false, false, "Tran302", null, "user", null, 0 },
                    { new Guid("3d17e8ff-8481-4bea-b77f-7e2e2811d191"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan219@gmail.com", "Tan219", "hashed_password_219", null, false, false, "Tran219", null, "user", null, 0 },
                    { new Guid("3d3c600b-4f1d-44c5-af49-04317a41f4ba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan145@gmail.com", "Tan145", "hashed_password_145", null, false, false, "Tran145", null, "user", null, 0 },
                    { new Guid("3d414407-ef30-4411-894f-583a061e9cbd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan914@gmail.com", "Tan914", "hashed_password_914", null, false, false, "Tran914", null, "user", null, 0 },
                    { new Guid("3d50ee7a-7971-4a78-af65-81f58b54deb3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan168@gmail.com", "Tan168", "hashed_password_168", null, false, false, "Tran168", null, "user", null, 0 },
                    { new Guid("3df5e88e-658b-4368-8081-fdef9f6f4ae3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan514@gmail.com", "Tan514", "hashed_password_514", null, false, false, "Tran514", null, "user", null, 0 },
                    { new Guid("3f283c22-37cd-492f-ae21-7f6b052b112b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan537@gmail.com", "Tan537", "hashed_password_537", null, false, false, "Tran537", null, "user", null, 0 },
                    { new Guid("3f4323ba-4c99-4b58-a9c0-b06d6cd76f89"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan440@gmail.com", "Tan440", "hashed_password_440", null, false, false, "Tran440", null, "user", null, 0 },
                    { new Guid("3f4b4e63-48ea-40f6-8a56-582b78c207a5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan630@gmail.com", "Tan630", "hashed_password_630", null, false, false, "Tran630", null, "user", null, 0 },
                    { new Guid("400ebe55-2990-4cb6-91b7-acdc6b410fb2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan185@gmail.com", "Tan185", "hashed_password_185", null, false, false, "Tran185", null, "user", null, 0 },
                    { new Guid("4049033c-fb7e-4446-93e3-ad532f9babb2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan120@gmail.com", "Tan120", "hashed_password_120", null, false, false, "Tran120", null, "user", null, 0 },
                    { new Guid("4057b497-01f1-4aca-98fc-1f68610cd25b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan428@gmail.com", "Tan428", "hashed_password_428", null, false, false, "Tran428", null, "user", null, 0 },
                    { new Guid("405b50c5-0034-488b-9a2c-95ecb8568053"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan88@gmail.com", "Tan88", "hashed_password_88", null, false, false, "Tran88", null, "user", null, 0 },
                    { new Guid("40846a7d-224f-4bd3-8c0e-511bf0a368aa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan411@gmail.com", "Tan411", "hashed_password_411", null, false, false, "Tran411", null, "user", null, 0 },
                    { new Guid("40912e53-61f6-490c-b963-1e4c2131e830"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan310@gmail.com", "Tan310", "hashed_password_310", null, false, false, "Tran310", null, "user", null, 0 },
                    { new Guid("409bdc4d-7702-4010-8340-edbd074a0e57"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan680@gmail.com", "Tan680", "hashed_password_680", null, false, false, "Tran680", null, "user", null, 0 },
                    { new Guid("40a7cda6-347f-4160-a045-9f472223914a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan140@gmail.com", "Tan140", "hashed_password_140", null, false, false, "Tran140", null, "user", null, 0 },
                    { new Guid("40c19900-f71c-4dc7-b05c-027301cc3455"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan567@gmail.com", "Tan567", "hashed_password_567", null, false, false, "Tran567", null, "user", null, 0 },
                    { new Guid("40d02118-415b-4611-89ae-fa32968ba2e9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan211@gmail.com", "Tan211", "hashed_password_211", null, false, false, "Tran211", null, "user", null, 0 },
                    { new Guid("41b48c9b-880c-4d70-9988-3e1fa20a096e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan351@gmail.com", "Tan351", "hashed_password_351", null, false, false, "Tran351", null, "user", null, 0 },
                    { new Guid("41c67dd8-eb55-436c-ba3d-2a61e1de7143"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan422@gmail.com", "Tan422", "hashed_password_422", null, false, false, "Tran422", null, "user", null, 0 },
                    { new Guid("4238193a-0a33-4dd3-b743-5fc3cf3ff242"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan309@gmail.com", "Tan309", "hashed_password_309", null, false, false, "Tran309", null, "user", null, 0 },
                    { new Guid("424aee77-2a80-4743-8016-5b1bc933e8db"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan846@gmail.com", "Tan846", "hashed_password_846", null, false, false, "Tran846", null, "user", null, 0 },
                    { new Guid("426486ec-affc-4e42-a9f3-b4d1260b1963"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan136@gmail.com", "Tan136", "hashed_password_136", null, false, false, "Tran136", null, "user", null, 0 },
                    { new Guid("42a3dfe4-b9f3-4d75-a9cd-cca6d6b6bf93"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan250@gmail.com", "Tan250", "hashed_password_250", null, false, false, "Tran250", null, "user", null, 0 },
                    { new Guid("42aa7a98-5e07-4575-aa39-c34de0f86c2b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan348@gmail.com", "Tan348", "hashed_password_348", null, false, false, "Tran348", null, "user", null, 0 },
                    { new Guid("431d2500-52fe-42e3-ad76-fb3c32444daf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan390@gmail.com", "Tan390", "hashed_password_390", null, false, false, "Tran390", null, "user", null, 0 },
                    { new Guid("437173b5-32fd-4ace-9bdd-f7805c31c203"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan44@gmail.com", "Tan44", "hashed_password_44", null, false, false, "Tran44", null, "user", null, 0 },
                    { new Guid("437498e4-4eac-4fc4-8b14-02c73ac44411"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan8@gmail.com", "Tan8", "hashed_password_8", null, false, false, "Tran8", null, "user", null, 0 },
                    { new Guid("439a0042-f99b-4c22-a5c4-15e87ba189fd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan257@gmail.com", "Tan257", "hashed_password_257", null, false, false, "Tran257", null, "user", null, 0 },
                    { new Guid("43bc9153-7ae7-45d8-b3b2-76df1644fae2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan41@gmail.com", "Tan41", "hashed_password_41", null, false, false, "Tran41", null, "user", null, 0 },
                    { new Guid("43ed3e6f-ffd4-4771-993a-b2bf03cad61b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan586@gmail.com", "Tan586", "hashed_password_586", null, false, false, "Tran586", null, "user", null, 0 },
                    { new Guid("43f4cae4-a3ce-4f7f-9450-20b05945fc96"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan936@gmail.com", "Tan936", "hashed_password_936", null, false, false, "Tran936", null, "user", null, 0 },
                    { new Guid("447bb4bf-58cd-42b7-8f6a-afbadd62bc0f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan336@gmail.com", "Tan336", "hashed_password_336", null, false, false, "Tran336", null, "user", null, 0 },
                    { new Guid("44989835-4244-40e7-ba53-2ddf67d4fca2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan859@gmail.com", "Tan859", "hashed_password_859", null, false, false, "Tran859", null, "user", null, 0 },
                    { new Guid("450600ac-cb9a-46cc-8933-388c476fe355"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan455@gmail.com", "Tan455", "hashed_password_455", null, false, false, "Tran455", null, "user", null, 0 },
                    { new Guid("454ef522-cd4c-4e32-ae4d-0137abc520ff"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan687@gmail.com", "Tan687", "hashed_password_687", null, false, false, "Tran687", null, "user", null, 0 },
                    { new Guid("45bd920b-f8b7-4d6f-afc9-182e747e2e6b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan283@gmail.com", "Tan283", "hashed_password_283", null, false, false, "Tran283", null, "user", null, 0 },
                    { new Guid("45d5d55a-3825-4c61-ae20-6c6e0305c0d5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan607@gmail.com", "Tan607", "hashed_password_607", null, false, false, "Tran607", null, "user", null, 0 },
                    { new Guid("45ee4b7d-2a0f-4d36-9a31-d706b9efffe9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan19@gmail.com", "Tan19", "hashed_password_19", null, false, false, "Tran19", null, "user", null, 0 },
                    { new Guid("45f827b1-9929-45c4-8b30-c8f9180b83cf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan601@gmail.com", "Tan601", "hashed_password_601", null, false, false, "Tran601", null, "user", null, 0 },
                    { new Guid("4696bdc0-5b2d-4b0b-b671-6b4c2d6f17dd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan895@gmail.com", "Tan895", "hashed_password_895", null, false, false, "Tran895", null, "user", null, 0 },
                    { new Guid("46c34152-df35-4837-b24c-04ca3b84efa7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan342@gmail.com", "Tan342", "hashed_password_342", null, false, false, "Tran342", null, "user", null, 0 },
                    { new Guid("47e294c9-cc46-4382-8779-04aa4f2b3c6c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan476@gmail.com", "Tan476", "hashed_password_476", null, false, false, "Tran476", null, "user", null, 0 },
                    { new Guid("48af1057-9119-4f2a-b34b-16c665311eef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan138@gmail.com", "Tan138", "hashed_password_138", null, false, false, "Tran138", null, "user", null, 0 },
                    { new Guid("490b3c16-b6a9-46f9-8d73-91fe4e5e2a00"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan660@gmail.com", "Tan660", "hashed_password_660", null, false, false, "Tran660", null, "user", null, 0 },
                    { new Guid("4934bbde-7812-4587-b826-df07b30c369c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan907@gmail.com", "Tan907", "hashed_password_907", null, false, false, "Tran907", null, "user", null, 0 },
                    { new Guid("498baef9-5837-4c6a-adcf-b8cc671b6a72"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan802@gmail.com", "Tan802", "hashed_password_802", null, false, false, "Tran802", null, "user", null, 0 },
                    { new Guid("4abb0c00-2fd5-485c-940b-a7f4b96e7280"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan402@gmail.com", "Tan402", "hashed_password_402", null, false, false, "Tran402", null, "user", null, 0 },
                    { new Guid("4ac6d35d-dcae-42aa-8bcd-71ca64cd91d1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan317@gmail.com", "Tan317", "hashed_password_317", null, false, false, "Tran317", null, "user", null, 0 },
                    { new Guid("4ae35bad-c6f6-47b2-8dc1-fed2e8ccc18c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan207@gmail.com", "Tan207", "hashed_password_207", null, false, false, "Tran207", null, "user", null, 0 },
                    { new Guid("4aedae2c-36f2-4383-994d-59d4bae29b94"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan868@gmail.com", "Tan868", "hashed_password_868", null, false, false, "Tran868", null, "user", null, 0 },
                    { new Guid("4b202621-03a4-4553-82c1-88e08db8993e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan324@gmail.com", "Tan324", "hashed_password_324", null, false, false, "Tran324", null, "user", null, 0 },
                    { new Guid("4b29fc58-3e2e-43b9-bd62-5e22cb49b8ac"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan933@gmail.com", "Tan933", "hashed_password_933", null, false, false, "Tran933", null, "user", null, 0 },
                    { new Guid("4b47bf27-0aa2-4fed-a6e1-3f847d031c56"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan1000@gmail.com", "Tan1000", "hashed_password_1000", null, false, false, "Tran1000", null, "user", null, 0 },
                    { new Guid("4b9746b2-1c1d-4dac-8630-dd1e82f7bd74"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan873@gmail.com", "Tan873", "hashed_password_873", null, false, false, "Tran873", null, "user", null, 0 },
                    { new Guid("4c328c67-9734-4ef1-9f03-22ca47cb7826"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan469@gmail.com", "Tan469", "hashed_password_469", null, false, false, "Tran469", null, "user", null, 0 },
                    { new Guid("4c970444-43aa-47df-9c57-0bd8ac3974af"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan584@gmail.com", "Tan584", "hashed_password_584", null, false, false, "Tran584", null, "user", null, 0 },
                    { new Guid("4c9a24d3-7b88-4bd6-8387-37c83bcaccbd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan99@gmail.com", "Tan99", "hashed_password_99", null, false, false, "Tran99", null, "user", null, 0 },
                    { new Guid("4ca27eea-84ed-4f2d-b1ce-bd005e5896ef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan957@gmail.com", "Tan957", "hashed_password_957", null, false, false, "Tran957", null, "user", null, 0 },
                    { new Guid("4ca8fca6-9a1b-47bb-9375-feae0d5ea23b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan314@gmail.com", "Tan314", "hashed_password_314", null, false, false, "Tran314", null, "user", null, 0 },
                    { new Guid("4ce7834d-70fc-4b2c-a710-55eaca095fb5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan622@gmail.com", "Tan622", "hashed_password_622", null, false, false, "Tran622", null, "user", null, 0 },
                    { new Guid("4d93f2a8-82c5-4aa6-b7ad-d701b98dc969"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan944@gmail.com", "Tan944", "hashed_password_944", null, false, false, "Tran944", null, "user", null, 0 },
                    { new Guid("4dc59338-3fc5-4978-8b57-109248c87c3a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan222@gmail.com", "Tan222", "hashed_password_222", null, false, false, "Tran222", null, "user", null, 0 },
                    { new Guid("4e69f295-4d67-4004-852a-feeed2d7d642"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan467@gmail.com", "Tan467", "hashed_password_467", null, false, false, "Tran467", null, "user", null, 0 },
                    { new Guid("4e7dea9c-1e31-495e-a15c-d1b3c077ad9c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan757@gmail.com", "Tan757", "hashed_password_757", null, false, false, "Tran757", null, "user", null, 0 },
                    { new Guid("4ebaf848-6846-486f-9a3a-4923a2416076"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan761@gmail.com", "Tan761", "hashed_password_761", null, false, false, "Tran761", null, "user", null, 0 },
                    { new Guid("4f905f05-bba3-4f71-9df2-c29377efa29c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan108@gmail.com", "Tan108", "hashed_password_108", null, false, false, "Tran108", null, "user", null, 0 },
                    { new Guid("4fecc6dd-ec63-46bd-8182-c9db91844e94"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan774@gmail.com", "Tan774", "hashed_password_774", null, false, false, "Tran774", null, "user", null, 0 },
                    { new Guid("4feefd32-c190-4a61-b8fe-16d09501903a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan618@gmail.com", "Tan618", "hashed_password_618", null, false, false, "Tran618", null, "user", null, 0 },
                    { new Guid("50538a6c-c631-4d72-bdd6-50dc0e0214ac"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan701@gmail.com", "Tan701", "hashed_password_701", null, false, false, "Tran701", null, "user", null, 0 },
                    { new Guid("50627b9f-291b-4639-8d45-0946c5ab7870"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan52@gmail.com", "Tan52", "hashed_password_52", null, false, false, "Tran52", null, "user", null, 0 },
                    { new Guid("50910ae8-fbab-49f0-b1ba-f2a389b1e467"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan836@gmail.com", "Tan836", "hashed_password_836", null, false, false, "Tran836", null, "user", null, 0 },
                    { new Guid("50ae891c-760b-45f5-9d9e-5a82e9bc3108"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan973@gmail.com", "Tan973", "hashed_password_973", null, false, false, "Tran973", null, "user", null, 0 },
                    { new Guid("50be653b-14a0-42d8-ba57-d5b8eb2c28fa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan865@gmail.com", "Tan865", "hashed_password_865", null, false, false, "Tran865", null, "user", null, 0 },
                    { new Guid("50e242b8-708a-446f-b56e-73be724ab21d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan954@gmail.com", "Tan954", "hashed_password_954", null, false, false, "Tran954", null, "user", null, 0 },
                    { new Guid("5140bbea-ef45-4832-8b2c-69849d833bc7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan700@gmail.com", "Tan700", "hashed_password_700", null, false, false, "Tran700", null, "user", null, 0 },
                    { new Guid("51663b2e-afc6-4ffa-a411-aea713e37b09"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan980@gmail.com", "Tan980", "hashed_password_980", null, false, false, "Tran980", null, "user", null, 0 },
                    { new Guid("5203b6b1-6a83-48ae-933d-7d38b8719738"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan248@gmail.com", "Tan248", "hashed_password_248", null, false, false, "Tran248", null, "user", null, 0 },
                    { new Guid("52fcf5c8-ffc6-472d-b9a0-fc0b3bb82a3d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan306@gmail.com", "Tan306", "hashed_password_306", null, false, false, "Tran306", null, "user", null, 0 },
                    { new Guid("5470a130-c42a-43f8-948f-c4bb5a2a86c0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan253@gmail.com", "Tan253", "hashed_password_253", null, false, false, "Tran253", null, "user", null, 0 },
                    { new Guid("55137bd2-7f8f-4376-83e8-de34488a6fd6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan42@gmail.com", "Tan42", "hashed_password_42", null, false, false, "Tran42", null, "user", null, 0 },
                    { new Guid("559c6b1e-870a-48a3-a625-0af4d0a95d4e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan162@gmail.com", "Tan162", "hashed_password_162", null, false, false, "Tran162", null, "user", null, 0 },
                    { new Guid("55a9b9fc-22b2-4ea7-9afb-b0678481eb42"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan7@gmail.com", "Tan7", "hashed_password_7", null, false, false, "Tran7", null, "user", null, 0 },
                    { new Guid("561c8e9d-fc4f-4042-bd5d-9f58c0bb9f85"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan384@gmail.com", "Tan384", "hashed_password_384", null, false, false, "Tran384", null, "user", null, 0 },
                    { new Guid("564f06a7-ed52-45fa-b0e1-0e1e4fa9492b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan74@gmail.com", "Tan74", "hashed_password_74", null, false, false, "Tran74", null, "user", null, 0 },
                    { new Guid("567f2847-c90f-487c-afb5-73ac92ee229e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan639@gmail.com", "Tan639", "hashed_password_639", null, false, false, "Tran639", null, "user", null, 0 },
                    { new Guid("56859ee2-5e69-4da3-8638-c099961d751e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan926@gmail.com", "Tan926", "hashed_password_926", null, false, false, "Tran926", null, "user", null, 0 },
                    { new Guid("568c61b5-4e3c-4101-8b35-1f08e07c303c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan431@gmail.com", "Tan431", "hashed_password_431", null, false, false, "Tran431", null, "user", null, 0 },
                    { new Guid("56aae6ef-e48b-4544-8cdb-71cbccee3a19"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan497@gmail.com", "Tan497", "hashed_password_497", null, false, false, "Tran497", null, "user", null, 0 },
                    { new Guid("56ab442b-d63d-4224-b0be-1bc59d1b21aa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan720@gmail.com", "Tan720", "hashed_password_720", null, false, false, "Tran720", null, "user", null, 0 },
                    { new Guid("56fbf8d3-6ebd-4b85-add5-0a46066a6425"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan264@gmail.com", "Tan264", "hashed_password_264", null, false, false, "Tran264", null, "user", null, 0 },
                    { new Guid("571402fe-0906-43b3-9616-97f80f9ef1eb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan341@gmail.com", "Tan341", "hashed_password_341", null, false, false, "Tran341", null, "user", null, 0 },
                    { new Guid("5735bd69-4714-4fd2-82a0-4260dbac4183"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan383@gmail.com", "Tan383", "hashed_password_383", null, false, false, "Tran383", null, "user", null, 0 },
                    { new Guid("5754d060-4fff-4129-8a49-b02b28c603f8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan728@gmail.com", "Tan728", "hashed_password_728", null, false, false, "Tran728", null, "user", null, 0 },
                    { new Guid("575ecfbf-4419-461c-acff-2b5e7f68ef8c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan89@gmail.com", "Tan89", "hashed_password_89", null, false, false, "Tran89", null, "user", null, 0 },
                    { new Guid("581b1e51-cfce-4ed9-873b-3fef2d1b935e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan79@gmail.com", "Tan79", "hashed_password_79", null, false, false, "Tran79", null, "user", null, 0 },
                    { new Guid("581e12a2-bca0-4ecf-b181-e3edfd216b11"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan983@gmail.com", "Tan983", "hashed_password_983", null, false, false, "Tran983", null, "user", null, 0 },
                    { new Guid("5837d474-6b80-4cf8-81d5-068ba685297c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan106@gmail.com", "Tan106", "hashed_password_106", null, false, false, "Tran106", null, "user", null, 0 },
                    { new Guid("58510c93-9d09-4301-8605-bce1d2ef3eba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan500@gmail.com", "Tan500", "hashed_password_500", null, false, false, "Tran500", null, "user", null, 0 },
                    { new Guid("587eeef7-62a2-41e4-8a87-d6479ac1c11d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan419@gmail.com", "Tan419", "hashed_password_419", null, false, false, "Tran419", null, "user", null, 0 },
                    { new Guid("58bc2130-4fc1-403b-9d61-89ac3402bc6f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan555@gmail.com", "Tan555", "hashed_password_555", null, false, false, "Tran555", null, "user", null, 0 },
                    { new Guid("58c2daea-df6e-4c1c-841d-14f82e8e2f67"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan377@gmail.com", "Tan377", "hashed_password_377", null, false, false, "Tran377", null, "user", null, 0 },
                    { new Guid("58cd2eb6-02fe-44bc-9dc4-ef23939d0310"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan209@gmail.com", "Tan209", "hashed_password_209", null, false, false, "Tran209", null, "user", null, 0 },
                    { new Guid("58cf92ad-ab15-4abb-a8a5-6064a11e2e3b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan609@gmail.com", "Tan609", "hashed_password_609", null, false, false, "Tran609", null, "user", null, 0 },
                    { new Guid("58f3c2ec-399c-4ee5-8c5d-8b1383b252cc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan741@gmail.com", "Tan741", "hashed_password_741", null, false, false, "Tran741", null, "user", null, 0 },
                    { new Guid("59401cb7-ec3b-4bdb-9861-af34e0ac38c0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan732@gmail.com", "Tan732", "hashed_password_732", null, false, false, "Tran732", null, "user", null, 0 },
                    { new Guid("59604c58-8601-4b63-b70a-81536a60b810"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan343@gmail.com", "Tan343", "hashed_password_343", null, false, false, "Tran343", null, "user", null, 0 },
                    { new Guid("599c1cc3-f172-4d34-9070-a9889f5d712c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan305@gmail.com", "Tan305", "hashed_password_305", null, false, false, "Tran305", null, "user", null, 0 },
                    { new Guid("59a4bfcd-1c8b-4b33-b9e5-69828397afb2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan705@gmail.com", "Tan705", "hashed_password_705", null, false, false, "Tran705", null, "user", null, 0 },
                    { new Guid("59a8296a-52aa-48ff-96bc-e980a5f024c1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan547@gmail.com", "Tan547", "hashed_password_547", null, false, false, "Tran547", null, "user", null, 0 },
                    { new Guid("59fac80d-4772-467d-9b4f-c462090ba739"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan625@gmail.com", "Tan625", "hashed_password_625", null, false, false, "Tran625", null, "user", null, 0 },
                    { new Guid("5a0df5d7-92b9-4eaa-ac2c-5b2223e2796d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan474@gmail.com", "Tan474", "hashed_password_474", null, false, false, "Tran474", null, "user", null, 0 },
                    { new Guid("5a1bac17-424a-4f70-9b37-9c994261a8ac"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan338@gmail.com", "Tan338", "hashed_password_338", null, false, false, "Tran338", null, "user", null, 0 },
                    { new Guid("5a5db2eb-5373-41ad-a4ac-cc5748d3b6b1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan303@gmail.com", "Tan303", "hashed_password_303", null, false, false, "Tran303", null, "user", null, 0 },
                    { new Guid("5a5e1633-57f1-4f00-8543-925d7a68c746"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan182@gmail.com", "Tan182", "hashed_password_182", null, false, false, "Tran182", null, "user", null, 0 },
                    { new Guid("5ab401da-c538-426c-a160-0f3aaa691168"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan619@gmail.com", "Tan619", "hashed_password_619", null, false, false, "Tran619", null, "user", null, 0 },
                    { new Guid("5ada3082-0ab8-4dc3-b3f7-dd8aa7a10fc6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan675@gmail.com", "Tan675", "hashed_password_675", null, false, false, "Tran675", null, "user", null, 0 },
                    { new Guid("5b5eb7e2-b0aa-481d-9e29-c2e391e27023"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan64@gmail.com", "Tan64", "hashed_password_64", null, false, false, "Tran64", null, "user", null, 0 },
                    { new Guid("5c4a2334-3ce1-4f42-a131-2e33630e9941"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan582@gmail.com", "Tan582", "hashed_password_582", null, false, false, "Tran582", null, "user", null, 0 },
                    { new Guid("5c91886d-3d2d-4338-812c-0cf3499b94aa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan186@gmail.com", "Tan186", "hashed_password_186", null, false, false, "Tran186", null, "user", null, 0 },
                    { new Guid("5c99c490-9a66-4988-ac5b-8ee958048347"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan335@gmail.com", "Tan335", "hashed_password_335", null, false, false, "Tran335", null, "user", null, 0 },
                    { new Guid("5c9ea0c0-1fa3-4069-884e-e3138f569896"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan665@gmail.com", "Tan665", "hashed_password_665", null, false, false, "Tran665", null, "user", null, 0 },
                    { new Guid("5ce48907-f935-4d62-aae2-bf21721ad4d9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan939@gmail.com", "Tan939", "hashed_password_939", null, false, false, "Tran939", null, "user", null, 0 },
                    { new Guid("5cf1db25-52b0-4553-b5dc-20b768b39f85"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan447@gmail.com", "Tan447", "hashed_password_447", null, false, false, "Tran447", null, "user", null, 0 },
                    { new Guid("5d06b206-2e89-4fd6-80f2-dba5ac7416ef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan798@gmail.com", "Tan798", "hashed_password_798", null, false, false, "Tran798", null, "user", null, 0 },
                    { new Guid("5d5135f4-5919-4ce3-b598-ef5fc5bea445"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan561@gmail.com", "Tan561", "hashed_password_561", null, false, false, "Tran561", null, "user", null, 0 },
                    { new Guid("5db96827-f6bf-4f79-875a-4bd86d5187f5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan484@gmail.com", "Tan484", "hashed_password_484", null, false, false, "Tran484", null, "user", null, 0 },
                    { new Guid("5df45a36-9442-4af8-bb9d-7911428e3313"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan768@gmail.com", "Tan768", "hashed_password_768", null, false, false, "Tran768", null, "user", null, 0 },
                    { new Guid("5e0c0d2f-d5cf-4f18-80da-5e0af06c7ee5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan996@gmail.com", "Tan996", "hashed_password_996", null, false, false, "Tran996", null, "user", null, 0 },
                    { new Guid("5e42ad81-2e5f-4cce-b5e9-999d09bd3313"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan591@gmail.com", "Tan591", "hashed_password_591", null, false, false, "Tran591", null, "user", null, 0 },
                    { new Guid("5e56306e-3f82-476b-ac52-eab27c3300f3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan644@gmail.com", "Tan644", "hashed_password_644", null, false, false, "Tran644", null, "user", null, 0 },
                    { new Guid("5e7c2b67-a20c-4da5-a007-f1a6597f8a7c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan851@gmail.com", "Tan851", "hashed_password_851", null, false, false, "Tran851", null, "user", null, 0 },
                    { new Guid("5e92c8f7-d8ab-48e9-8299-4c8c96f9b38d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan924@gmail.com", "Tan924", "hashed_password_924", null, false, false, "Tran924", null, "user", null, 0 },
                    { new Guid("5e976013-6f79-4813-ac59-abf85b68e52b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan33@gmail.com", "Tan33", "hashed_password_33", null, false, false, "Tran33", null, "user", null, 0 },
                    { new Guid("5e9dee58-780e-45b4-b628-1222207abec0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan165@gmail.com", "Tan165", "hashed_password_165", null, false, false, "Tran165", null, "user", null, 0 },
                    { new Guid("5f4dda62-9841-4036-9f19-e2b0f97252cc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan559@gmail.com", "Tan559", "hashed_password_559", null, false, false, "Tran559", null, "user", null, 0 },
                    { new Guid("5f72d85e-48ef-48dd-af02-d92a42f620f2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan945@gmail.com", "Tan945", "hashed_password_945", null, false, false, "Tran945", null, "user", null, 0 },
                    { new Guid("5fd8c4ce-71e2-4283-8f30-0acc48659897"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan807@gmail.com", "Tan807", "hashed_password_807", null, false, false, "Tran807", null, "user", null, 0 },
                    { new Guid("5fe9c759-4683-47dd-b2b0-72ff7d85f02c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan719@gmail.com", "Tan719", "hashed_password_719", null, false, false, "Tran719", null, "user", null, 0 },
                    { new Guid("60379af5-6058-4522-a391-902e22ae6408"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan935@gmail.com", "Tan935", "hashed_password_935", null, false, false, "Tran935", null, "user", null, 0 },
                    { new Guid("6041c26b-4047-4d11-acbf-a68a4725c04a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan742@gmail.com", "Tan742", "hashed_password_742", null, false, false, "Tran742", null, "user", null, 0 },
                    { new Guid("60781ffd-bcb6-4051-bf90-55174d62d8f4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan571@gmail.com", "Tan571", "hashed_password_571", null, false, false, "Tran571", null, "user", null, 0 },
                    { new Guid("611eea91-decb-4876-bb04-eecbc441b0a9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan93@gmail.com", "Tan93", "hashed_password_93", null, false, false, "Tran93", null, "user", null, 0 },
                    { new Guid("612ba695-f127-4cdb-86ab-886809970475"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan545@gmail.com", "Tan545", "hashed_password_545", null, false, false, "Tran545", null, "user", null, 0 },
                    { new Guid("61400919-8f9c-4748-bba0-5a0f07291441"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan21@gmail.com", "Tan21", "hashed_password_21", null, false, false, "Tran21", null, "user", null, 0 },
                    { new Guid("6173b732-636e-4a0e-abb3-3b4afbda8048"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan245@gmail.com", "Tan245", "hashed_password_245", null, false, false, "Tran245", null, "user", null, 0 },
                    { new Guid("617fd59d-5118-448e-9454-710c92dca1fa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan848@gmail.com", "Tan848", "hashed_password_848", null, false, false, "Tran848", null, "user", null, 0 },
                    { new Guid("61b454a4-3a8c-43db-90c2-029d560f13b4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan990@gmail.com", "Tan990", "hashed_password_990", null, false, false, "Tran990", null, "user", null, 0 },
                    { new Guid("621e13a5-8bb9-4be2-a0aa-f007384fc43e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan61@gmail.com", "Tan61", "hashed_password_61", null, false, false, "Tran61", null, "user", null, 0 },
                    { new Guid("62baa6ce-0863-4531-b435-0c0210cb01fd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan906@gmail.com", "Tan906", "hashed_password_906", null, false, false, "Tran906", null, "user", null, 0 },
                    { new Guid("62dd4d28-54c2-4073-b88d-ebc63e0b39db"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan225@gmail.com", "Tan225", "hashed_password_225", null, false, false, "Tran225", null, "user", null, 0 },
                    { new Guid("634a80db-9c70-4fe6-bbd8-28e7241d283e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan575@gmail.com", "Tan575", "hashed_password_575", null, false, false, "Tran575", null, "user", null, 0 },
                    { new Guid("6375ff17-41ca-4ee7-a968-41b0bdbb4f13"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan511@gmail.com", "Tan511", "hashed_password_511", null, false, false, "Tran511", null, "user", null, 0 },
                    { new Guid("638fd544-1c99-49c8-84b1-390d5ae63dc4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan82@gmail.com", "Tan82", "hashed_password_82", null, false, false, "Tran82", null, "user", null, 0 },
                    { new Guid("63f3ab5e-6eb9-48e9-9451-9bf2ab5f3627"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan187@gmail.com", "Tan187", "hashed_password_187", null, false, false, "Tran187", null, "user", null, 0 },
                    { new Guid("646118a1-a59d-4c84-919e-8079cfc24050"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan163@gmail.com", "Tan163", "hashed_password_163", null, false, false, "Tran163", null, "user", null, 0 },
                    { new Guid("64fef925-eac4-4999-95c7-de4ff66a7188"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan767@gmail.com", "Tan767", "hashed_password_767", null, false, false, "Tran767", null, "user", null, 0 },
                    { new Guid("653e65ed-1beb-45c2-bfe1-2624701f8811"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan291@gmail.com", "Tan291", "hashed_password_291", null, false, false, "Tran291", null, "user", null, 0 },
                    { new Guid("6631163b-b0cb-4172-9a09-7cafa5b85cae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan273@gmail.com", "Tan273", "hashed_password_273", null, false, false, "Tran273", null, "user", null, 0 },
                    { new Guid("667504a3-d954-40ee-b27f-101d072a6a8a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan574@gmail.com", "Tan574", "hashed_password_574", null, false, false, "Tran574", null, "user", null, 0 },
                    { new Guid("66e74a89-443b-49aa-ac89-8c8b3182a877"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan885@gmail.com", "Tan885", "hashed_password_885", null, false, false, "Tran885", null, "user", null, 0 },
                    { new Guid("67f02635-af21-4a7a-9c79-0b943d6578f2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan181@gmail.com", "Tan181", "hashed_password_181", null, false, false, "Tran181", null, "user", null, 0 },
                    { new Guid("685d3d8b-443d-4a14-98b6-95a0e8c327ba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan118@gmail.com", "Tan118", "hashed_password_118", null, false, false, "Tran118", null, "user", null, 0 },
                    { new Guid("695088fd-08b8-4d16-b9e2-2cb312c7ce2b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan333@gmail.com", "Tan333", "hashed_password_333", null, false, false, "Tran333", null, "user", null, 0 },
                    { new Guid("695871a1-8cd1-46b1-8548-e59a1ea2b351"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan349@gmail.com", "Tan349", "hashed_password_349", null, false, false, "Tran349", null, "user", null, 0 },
                    { new Guid("69856442-b70e-420b-a4e8-44721df1fe97"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan681@gmail.com", "Tan681", "hashed_password_681", null, false, false, "Tran681", null, "user", null, 0 },
                    { new Guid("698dd9c7-fa18-476e-b517-0e89379e2d20"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan67@gmail.com", "Tan67", "hashed_password_67", null, false, false, "Tran67", null, "user", null, 0 },
                    { new Guid("69da6abf-4dcd-468a-a1b7-f04a16e14324"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan818@gmail.com", "Tan818", "hashed_password_818", null, false, false, "Tran818", null, "user", null, 0 },
                    { new Guid("6a120671-2dfe-4a8c-9fe4-f5c53d557398"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan210@gmail.com", "Tan210", "hashed_password_210", null, false, false, "Tran210", null, "user", null, 0 },
                    { new Guid("6a379e5a-998a-4f87-b860-bca53e486e57"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan412@gmail.com", "Tan412", "hashed_password_412", null, false, false, "Tran412", null, "user", null, 0 },
                    { new Guid("6ad5a93f-a9c9-4afa-8eb1-83de9536bdc2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan46@gmail.com", "Tan46", "hashed_password_46", null, false, false, "Tran46", null, "user", null, 0 },
                    { new Guid("6b11da1a-0c45-4126-b25f-8ba44366fdd8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan733@gmail.com", "Tan733", "hashed_password_733", null, false, false, "Tran733", null, "user", null, 0 },
                    { new Guid("6c2be972-934f-41ff-9f9e-5377cf19d370"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan69@gmail.com", "Tan69", "hashed_password_69", null, false, false, "Tran69", null, "user", null, 0 },
                    { new Guid("6c5147de-a61f-4af2-a8da-5ce404f8fa7e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan151@gmail.com", "Tan151", "hashed_password_151", null, false, false, "Tran151", null, "user", null, 0 },
                    { new Guid("6c577a28-e75e-4446-a250-258cb8ae17a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan811@gmail.com", "Tan811", "hashed_password_811", null, false, false, "Tran811", null, "user", null, 0 },
                    { new Guid("6c6546fe-ab14-4c24-b751-2a662abc3c87"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan759@gmail.com", "Tan759", "hashed_password_759", null, false, false, "Tran759", null, "user", null, 0 },
                    { new Guid("6c6eff75-833d-4138-b127-2327a8a3d50c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan636@gmail.com", "Tan636", "hashed_password_636", null, false, false, "Tran636", null, "user", null, 0 },
                    { new Guid("6c848c87-e2d5-4391-8ac8-23816454f2de"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan127@gmail.com", "Tan127", "hashed_password_127", null, false, false, "Tran127", null, "user", null, 0 },
                    { new Guid("6cb717c6-a022-4be2-9d22-8720c9191941"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan180@gmail.com", "Tan180", "hashed_password_180", null, false, false, "Tran180", null, "user", null, 0 },
                    { new Guid("6d1b8fd9-854c-4321-97bc-67c0cc78b527"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan624@gmail.com", "Tan624", "hashed_password_624", null, false, false, "Tran624", null, "user", null, 0 },
                    { new Guid("6d79249d-62b2-430f-89cc-e7bc6a9dd93e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan232@gmail.com", "Tan232", "hashed_password_232", null, false, false, "Tran232", null, "user", null, 0 },
                    { new Guid("6dd49bdb-7c19-4b31-88e9-d376014ad47e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan910@gmail.com", "Tan910", "hashed_password_910", null, false, false, "Tran910", null, "user", null, 0 },
                    { new Guid("6e801dee-9812-477d-bba7-bf6d1dc260cc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan355@gmail.com", "Tan355", "hashed_password_355", null, false, false, "Tran355", null, "user", null, 0 },
                    { new Guid("6f104568-cbad-4641-8233-71f4fdb3353b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan984@gmail.com", "Tan984", "hashed_password_984", null, false, false, "Tran984", null, "user", null, 0 },
                    { new Guid("6f171b9a-48f7-4a42-9ffc-48b39027b7e7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan922@gmail.com", "Tan922", "hashed_password_922", null, false, false, "Tran922", null, "user", null, 0 },
                    { new Guid("6f32159d-2908-4021-ab5a-07cc140b1c40"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan6@gmail.com", "Tan6", "hashed_password_6", null, false, false, "Tran6", null, "user", null, 0 },
                    { new Guid("6f6aeea5-48b0-4f78-b00f-77154c66525b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan56@gmail.com", "Tan56", "hashed_password_56", null, false, false, "Tran56", null, "user", null, 0 },
                    { new Guid("6f6fb7d6-8ac2-46a0-85be-112464605329"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan791@gmail.com", "Tan791", "hashed_password_791", null, false, false, "Tran791", null, "user", null, 0 },
                    { new Guid("6f759861-6168-4518-901a-f3cc96f5f20f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan381@gmail.com", "Tan381", "hashed_password_381", null, false, false, "Tran381", null, "user", null, 0 },
                    { new Guid("6fac237a-b94d-4b31-a762-0edae792e915"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan1@gmail.com", "Tan1", "hashed_password_1", null, false, false, "Tran1", null, "user", null, 0 },
                    { new Guid("6fada6fd-7f57-4369-9e1d-8e6d16b47523"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan158@gmail.com", "Tan158", "hashed_password_158", null, false, false, "Tran158", null, "user", null, 0 },
                    { new Guid("6fb5ac43-a532-495c-b586-1d7ceee26a0e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan423@gmail.com", "Tan423", "hashed_password_423", null, false, false, "Tran423", null, "user", null, 0 },
                    { new Guid("6fde66d1-df3f-45fd-8151-ff56371262b6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan789@gmail.com", "Tan789", "hashed_password_789", null, false, false, "Tran789", null, "user", null, 0 },
                    { new Guid("700966f8-b1e3-40d9-8c18-82840a08eeb0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan554@gmail.com", "Tan554", "hashed_password_554", null, false, false, "Tran554", null, "user", null, 0 },
                    { new Guid("707b4edb-2725-4d7b-aa88-db11dc3b8484"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan671@gmail.com", "Tan671", "hashed_password_671", null, false, false, "Tran671", null, "user", null, 0 },
                    { new Guid("707d3c05-869b-418a-b717-ec2a185d5e08"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan904@gmail.com", "Tan904", "hashed_password_904", null, false, false, "Tran904", null, "user", null, 0 },
                    { new Guid("70af780c-aa5a-4e21-8991-9b85cab77ab1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan352@gmail.com", "Tan352", "hashed_password_352", null, false, false, "Tran352", null, "user", null, 0 },
                    { new Guid("7102b909-122a-4f2b-81ad-e61ef8247c26"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan473@gmail.com", "Tan473", "hashed_password_473", null, false, false, "Tran473", null, "user", null, 0 },
                    { new Guid("71098526-7218-4217-8a38-4ca2114a47bd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan502@gmail.com", "Tan502", "hashed_password_502", null, false, false, "Tran502", null, "user", null, 0 },
                    { new Guid("714c6eec-6ae0-4eaa-8546-5f0b532b2e74"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan59@gmail.com", "Tan59", "hashed_password_59", null, false, false, "Tran59", null, "user", null, 0 },
                    { new Guid("71622a71-e9e4-419b-b6a3-758ca6cd470e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan546@gmail.com", "Tan546", "hashed_password_546", null, false, false, "Tran546", null, "user", null, 0 },
                    { new Guid("71bbaf01-ddca-43b5-a7e8-d7a4fedee329"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan147@gmail.com", "Tan147", "hashed_password_147", null, false, false, "Tran147", null, "user", null, 0 },
                    { new Guid("71becfca-f76d-40b0-8c73-2769e4cf26aa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan627@gmail.com", "Tan627", "hashed_password_627", null, false, false, "Tran627", null, "user", null, 0 },
                    { new Guid("71c70ea0-6fb1-4f9d-928a-db46d1555b5e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan864@gmail.com", "Tan864", "hashed_password_864", null, false, false, "Tran864", null, "user", null, 0 },
                    { new Guid("71ca4f2f-12d3-4746-9606-53f69b345913"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan132@gmail.com", "Tan132", "hashed_password_132", null, false, false, "Tran132", null, "user", null, 0 },
                    { new Guid("726ebc79-3bc5-4ca4-b24b-59f08ecbfafe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan993@gmail.com", "Tan993", "hashed_password_993", null, false, false, "Tran993", null, "user", null, 0 },
                    { new Guid("72ab6bd0-ceae-4a32-8695-f074b3b7c964"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan597@gmail.com", "Tan597", "hashed_password_597", null, false, false, "Tran597", null, "user", null, 0 },
                    { new Guid("72f2e8e2-191a-4c33-8a72-3217afd1f25b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan407@gmail.com", "Tan407", "hashed_password_407", null, false, false, "Tran407", null, "user", null, 0 },
                    { new Guid("7317a46a-069d-4223-9364-746a9bde6bf4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan234@gmail.com", "Tan234", "hashed_password_234", null, false, false, "Tran234", null, "user", null, 0 },
                    { new Guid("731a1b0a-f8ca-4589-8612-11d518b58af5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan371@gmail.com", "Tan371", "hashed_password_371", null, false, false, "Tran371", null, "user", null, 0 },
                    { new Guid("732f1b03-e993-4e2c-91da-6771153a3a31"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan903@gmail.com", "Tan903", "hashed_password_903", null, false, false, "Tran903", null, "user", null, 0 },
                    { new Guid("73b3cd69-35a7-4d1d-b3cf-97060847872b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan479@gmail.com", "Tan479", "hashed_password_479", null, false, false, "Tran479", null, "user", null, 0 },
                    { new Guid("73b66784-4f07-4ee2-b97c-87552a54b9ae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan975@gmail.com", "Tan975", "hashed_password_975", null, false, false, "Tran975", null, "user", null, 0 },
                    { new Guid("73d1b4e4-954a-45fb-b6e7-3e550cc1ed90"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan172@gmail.com", "Tan172", "hashed_password_172", null, false, false, "Tran172", null, "user", null, 0 },
                    { new Guid("73e7a71d-a183-4578-bb64-508e87fa179d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan702@gmail.com", "Tan702", "hashed_password_702", null, false, false, "Tran702", null, "user", null, 0 },
                    { new Guid("73f88fe6-1424-4543-aa7f-025eeb8b1cc9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan161@gmail.com", "Tan161", "hashed_password_161", null, false, false, "Tran161", null, "user", null, 0 },
                    { new Guid("741a71be-c006-4053-ae46-898e1c89a7e3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan570@gmail.com", "Tan570", "hashed_password_570", null, false, false, "Tran570", null, "user", null, 0 },
                    { new Guid("749f1fa5-d181-4d4a-9e6d-4c72d866fed2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan346@gmail.com", "Tan346", "hashed_password_346", null, false, false, "Tran346", null, "user", null, 0 },
                    { new Guid("7574c65d-32d1-484f-94d8-1fdb31033a9a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan799@gmail.com", "Tan799", "hashed_password_799", null, false, false, "Tran799", null, "user", null, 0 },
                    { new Guid("757ad461-9d43-430b-a389-853b7e247478"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan878@gmail.com", "Tan878", "hashed_password_878", null, false, false, "Tran878", null, "user", null, 0 },
                    { new Guid("759b2294-5e37-40ff-8108-fab15e1e10f6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan285@gmail.com", "Tan285", "hashed_password_285", null, false, false, "Tran285", null, "user", null, 0 },
                    { new Guid("75e7112f-c78e-4ed2-ab8f-61b338f7921e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan669@gmail.com", "Tan669", "hashed_password_669", null, false, false, "Tran669", null, "user", null, 0 },
                    { new Guid("75f9a5fd-8d86-4618-9826-3b50a46ad722"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan519@gmail.com", "Tan519", "hashed_password_519", null, false, false, "Tran519", null, "user", null, 0 },
                    { new Guid("763e0b52-a009-4283-b806-d1dd57c041f5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan832@gmail.com", "Tan832", "hashed_password_832", null, false, false, "Tran832", null, "user", null, 0 },
                    { new Guid("7683da2c-4c33-4082-84a6-87ce6f0c7493"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan915@gmail.com", "Tan915", "hashed_password_915", null, false, false, "Tran915", null, "user", null, 0 },
                    { new Guid("77127b72-d1a2-4b7e-8427-837e98543967"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan236@gmail.com", "Tan236", "hashed_password_236", null, false, false, "Tran236", null, "user", null, 0 },
                    { new Guid("7716ee99-538d-432a-bce7-ef55cd50ab74"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan657@gmail.com", "Tan657", "hashed_password_657", null, false, false, "Tran657", null, "user", null, 0 },
                    { new Guid("771d9637-38d6-4146-8e5f-b62fc519c2f9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan101@gmail.com", "Tan101", "hashed_password_101", null, false, false, "Tran101", null, "user", null, 0 },
                    { new Guid("77a3bdc5-bb5c-4760-a5fe-113b9817e302"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan860@gmail.com", "Tan860", "hashed_password_860", null, false, false, "Tran860", null, "user", null, 0 },
                    { new Guid("77fc954e-0a53-4616-acc2-aa50be358a03"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan712@gmail.com", "Tan712", "hashed_password_712", null, false, false, "Tran712", null, "user", null, 0 },
                    { new Guid("780db987-c8b4-4314-85ea-b439ed3b9cac"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan824@gmail.com", "Tan824", "hashed_password_824", null, false, false, "Tran824", null, "user", null, 0 },
                    { new Guid("78441591-3584-4667-aff3-058a2044ebe5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan958@gmail.com", "Tan958", "hashed_password_958", null, false, false, "Tran958", null, "user", null, 0 },
                    { new Guid("78a135d3-0d94-4979-aaa8-0ab0d8baf0c3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan126@gmail.com", "Tan126", "hashed_password_126", null, false, false, "Tran126", null, "user", null, 0 },
                    { new Guid("79a69e0a-c995-4916-b44b-4d2f0c730275"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan316@gmail.com", "Tan316", "hashed_password_316", null, false, false, "Tran316", null, "user", null, 0 },
                    { new Guid("79bfc13e-74b3-4a09-8e76-108bff0442f3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan715@gmail.com", "Tan715", "hashed_password_715", null, false, false, "Tran715", null, "user", null, 0 },
                    { new Guid("7b1505db-4fa3-484b-9878-ce532b4ad511"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan133@gmail.com", "Tan133", "hashed_password_133", null, false, false, "Tran133", null, "user", null, 0 },
                    { new Guid("7b1822f9-ac55-4101-8df3-ecde8e8e1e85"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan376@gmail.com", "Tan376", "hashed_password_376", null, false, false, "Tran376", null, "user", null, 0 },
                    { new Guid("7b571864-fba4-4c65-917a-575bdcb6c437"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan196@gmail.com", "Tan196", "hashed_password_196", null, false, false, "Tran196", null, "user", null, 0 },
                    { new Guid("7b9ff988-15f5-4b8d-b722-d1d0a402f620"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan457@gmail.com", "Tan457", "hashed_password_457", null, false, false, "Tran457", null, "user", null, 0 },
                    { new Guid("7bd90cb1-2d47-463c-8900-1a8a498c300b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan366@gmail.com", "Tan366", "hashed_password_366", null, false, false, "Tran366", null, "user", null, 0 },
                    { new Guid("7c26eeda-c349-4c56-8954-4374106ca663"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan31@gmail.com", "Tan31", "hashed_password_31", null, false, false, "Tran31", null, "user", null, 0 },
                    { new Guid("7c38321e-9c89-4cbb-a58a-5c9244ead675"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan5@gmail.com", "Tan5", "hashed_password_5", null, false, false, "Tran5", null, "user", null, 0 },
                    { new Guid("7c4ba0df-a266-4671-ba11-6cf1af1c681f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan501@gmail.com", "Tan501", "hashed_password_501", null, false, false, "Tran501", null, "user", null, 0 },
                    { new Guid("7d3116c9-fb38-4e62-9c9b-7b065c54a94a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan10@gmail.com", "Tan10", "hashed_password_10", null, false, false, "Tran10", null, "user", null, 0 },
                    { new Guid("7d862203-1c8b-47cd-a740-96a314425165"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan164@gmail.com", "Tan164", "hashed_password_164", null, false, false, "Tran164", null, "user", null, 0 },
                    { new Guid("7d9a5ea7-e53e-40f2-a358-4b50c340ecea"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan911@gmail.com", "Tan911", "hashed_password_911", null, false, false, "Tran911", null, "user", null, 0 },
                    { new Guid("7db3c075-7218-4276-8ddc-912b44d198d6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan327@gmail.com", "Tan327", "hashed_password_327", null, false, false, "Tran327", null, "user", null, 0 },
                    { new Guid("7e2a8cfa-49a3-488a-b9d7-a5c4102e2c26"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan18@gmail.com", "Tan18", "hashed_password_18", null, false, false, "Tran18", null, "user", null, 0 },
                    { new Guid("7e57bf91-f019-4e49-baa0-2a110510e4bb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan115@gmail.com", "Tan115", "hashed_password_115", null, false, false, "Tran115", null, "user", null, 0 },
                    { new Guid("7e8e65a0-7c27-4435-b3d1-65456d34ec20"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan424@gmail.com", "Tan424", "hashed_password_424", null, false, false, "Tran424", null, "user", null, 0 },
                    { new Guid("7fbd85ec-e0ff-4867-9804-532639618701"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan659@gmail.com", "Tan659", "hashed_password_659", null, false, false, "Tran659", null, "user", null, 0 },
                    { new Guid("7fbe640a-b05b-48eb-9a2f-8e2374c9a3fa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan487@gmail.com", "Tan487", "hashed_password_487", null, false, false, "Tran487", null, "user", null, 0 },
                    { new Guid("7fe8c8e6-0839-46fd-9ff2-4222fe733796"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan448@gmail.com", "Tan448", "hashed_password_448", null, false, false, "Tran448", null, "user", null, 0 },
                    { new Guid("7ff0881c-3140-4a29-bcc2-0da9979f624f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan902@gmail.com", "Tan902", "hashed_password_902", null, false, false, "Tran902", null, "user", null, 0 },
                    { new Guid("801f8395-eb84-457b-b787-999f3cf392a6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan436@gmail.com", "Tan436", "hashed_password_436", null, false, false, "Tran436", null, "user", null, 0 },
                    { new Guid("80219176-c7cd-4be0-afc1-1432018f12bc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan693@gmail.com", "Tan693", "hashed_password_693", null, false, false, "Tran693", null, "user", null, 0 },
                    { new Guid("80545b01-0e44-451e-90c6-bea093964959"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan190@gmail.com", "Tan190", "hashed_password_190", null, false, false, "Tran190", null, "user", null, 0 },
                    { new Guid("805c5aee-2140-4fd2-83ab-cbb3e72c1e46"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan329@gmail.com", "Tan329", "hashed_password_329", null, false, false, "Tran329", null, "user", null, 0 },
                    { new Guid("8072d999-c26c-4fed-8186-c2bb79dce9cb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan850@gmail.com", "Tan850", "hashed_password_850", null, false, false, "Tran850", null, "user", null, 0 },
                    { new Guid("80831a31-16c0-4122-ab2d-072a4a60cd62"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan578@gmail.com", "Tan578", "hashed_password_578", null, false, false, "Tran578", null, "user", null, 0 },
                    { new Guid("80d1e150-00f1-4eae-94ce-be1fec18e331"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan252@gmail.com", "Tan252", "hashed_password_252", null, false, false, "Tran252", null, "user", null, 0 },
                    { new Guid("811652a0-bdf1-42d5-bcb3-0c12b1b831b2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan95@gmail.com", "Tan95", "hashed_password_95", null, false, false, "Tran95", null, "user", null, 0 },
                    { new Guid("81811790-29b4-4076-89d0-cde71e73c1c8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan650@gmail.com", "Tan650", "hashed_password_650", null, false, false, "Tran650", null, "user", null, 0 },
                    { new Guid("81b9aa52-03b8-4a0d-be79-633c0180ff4d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan527@gmail.com", "Tan527", "hashed_password_527", null, false, false, "Tran527", null, "user", null, 0 },
                    { new Guid("8209da4f-1f93-464d-9292-f9e9ac0b84b7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan626@gmail.com", "Tan626", "hashed_password_626", null, false, false, "Tran626", null, "user", null, 0 },
                    { new Guid("824cd558-7c44-4db7-821c-a2a7aee634ca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan194@gmail.com", "Tan194", "hashed_password_194", null, false, false, "Tran194", null, "user", null, 0 },
                    { new Guid("826cafe3-ca70-44bb-b055-ebbe3bc60dc5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan400@gmail.com", "Tan400", "hashed_password_400", null, false, false, "Tran400", null, "user", null, 0 },
                    { new Guid("82d035f8-2660-492d-bb86-4c6c3ec5fec2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan71@gmail.com", "Tan71", "hashed_password_71", null, false, false, "Tran71", null, "user", null, 0 },
                    { new Guid("833e5721-837a-4e65-9041-f33871564f37"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan159@gmail.com", "Tan159", "hashed_password_159", null, false, false, "Tran159", null, "user", null, 0 },
                    { new Guid("83aad3b8-9d3e-452c-8735-03ff55d9eec3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan166@gmail.com", "Tan166", "hashed_password_166", null, false, false, "Tran166", null, "user", null, 0 },
                    { new Guid("83bbb2b2-1bb5-41c5-9c75-29212e29ceaf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan992@gmail.com", "Tan992", "hashed_password_992", null, false, false, "Tran992", null, "user", null, 0 },
                    { new Guid("83e6f005-20e5-4cd7-ae1c-e852e1c519d1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan382@gmail.com", "Tan382", "hashed_password_382", null, false, false, "Tran382", null, "user", null, 0 },
                    { new Guid("8414ea49-0d82-4368-865b-dcb9fc4a3eb6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan875@gmail.com", "Tan875", "hashed_password_875", null, false, false, "Tran875", null, "user", null, 0 },
                    { new Guid("84166e05-50be-48cd-aead-a7808201f138"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan12@gmail.com", "Tan12", "hashed_password_12", null, false, false, "Tran12", null, "user", null, 0 },
                    { new Guid("8434a8bc-afff-44b1-9b0f-65e3bf5955a4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan731@gmail.com", "Tan731", "hashed_password_731", null, false, false, "Tran731", null, "user", null, 0 },
                    { new Guid("845f5a1e-faef-40a5-a927-51300704f1de"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan581@gmail.com", "Tan581", "hashed_password_581", null, false, false, "Tran581", null, "user", null, 0 },
                    { new Guid("84a8aa44-d531-4475-a637-86072f816e7c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan30@gmail.com", "Tan30", "hashed_password_30", null, false, false, "Tran30", null, "user", null, 0 },
                    { new Guid("85108aca-cd12-495f-aa18-0ddc0b5a7d96"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan218@gmail.com", "Tan218", "hashed_password_218", null, false, false, "Tran218", null, "user", null, 0 },
                    { new Guid("85a80627-cef6-43f2-8d84-25326b4a7302"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan334@gmail.com", "Tan334", "hashed_password_334", null, false, false, "Tran334", null, "user", null, 0 },
                    { new Guid("861fca83-4276-42ae-98bb-5a74c0529592"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan649@gmail.com", "Tan649", "hashed_password_649", null, false, false, "Tran649", null, "user", null, 0 },
                    { new Guid("861ffdb0-8adb-4fa8-81ce-e867afcb6477"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan595@gmail.com", "Tan595", "hashed_password_595", null, false, false, "Tran595", null, "user", null, 0 },
                    { new Guid("86217617-bcf0-480f-b484-ba3e33742ad6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan228@gmail.com", "Tan228", "hashed_password_228", null, false, false, "Tran228", null, "user", null, 0 },
                    { new Guid("86296708-665f-4f2e-8e8a-edef55053703"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan265@gmail.com", "Tan265", "hashed_password_265", null, false, false, "Tran265", null, "user", null, 0 },
                    { new Guid("8720b15d-8e22-46db-8633-b2ca117e256d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan804@gmail.com", "Tan804", "hashed_password_804", null, false, false, "Tran804", null, "user", null, 0 },
                    { new Guid("8770c109-1d7d-4ef6-ae5b-da7e8b4f007f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan77@gmail.com", "Tan77", "hashed_password_77", null, false, false, "Tran77", null, "user", null, 0 },
                    { new Guid("87747741-fa91-4032-a72a-0e4f19c1bbba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan839@gmail.com", "Tan839", "hashed_password_839", null, false, false, "Tran839", null, "user", null, 0 },
                    { new Guid("87b5b843-c9ed-4015-bcd2-344b3df6c064"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan119@gmail.com", "Tan119", "hashed_password_119", null, false, false, "Tran119", null, "user", null, 0 },
                    { new Guid("87e3b529-1172-478c-b723-246408cf5e2f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan198@gmail.com", "Tan198", "hashed_password_198", null, false, false, "Tran198", null, "user", null, 0 },
                    { new Guid("87e3f9ba-ef77-4aa8-b0df-05bb953bb49b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan490@gmail.com", "Tan490", "hashed_password_490", null, false, false, "Tran490", null, "user", null, 0 },
                    { new Guid("87e74c1f-6b1f-40a9-9359-7bb2c0ca900f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan503@gmail.com", "Tan503", "hashed_password_503", null, false, false, "Tran503", null, "user", null, 0 },
                    { new Guid("88498b10-671a-457f-bd26-cb188cda0fd5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan961@gmail.com", "Tan961", "hashed_password_961", null, false, false, "Tran961", null, "user", null, 0 },
                    { new Guid("886966f3-8535-4ab6-82e6-f6551e00899a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan909@gmail.com", "Tan909", "hashed_password_909", null, false, false, "Tran909", null, "user", null, 0 },
                    { new Guid("88b6d57a-70bb-4823-98cd-fabbb90a9043"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan53@gmail.com", "Tan53", "hashed_password_53", null, false, false, "Tran53", null, "user", null, 0 },
                    { new Guid("88de878f-50ea-472a-9747-05886f2fb080"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan835@gmail.com", "Tan835", "hashed_password_835", null, false, false, "Tran835", null, "user", null, 0 },
                    { new Guid("88e824b4-0800-4ebb-a012-433f9cdc04a6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan361@gmail.com", "Tan361", "hashed_password_361", null, false, false, "Tran361", null, "user", null, 0 },
                    { new Guid("88fdf2aa-17f9-4d4d-a789-3d9bedde39cc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan739@gmail.com", "Tan739", "hashed_password_739", null, false, false, "Tran739", null, "user", null, 0 },
                    { new Guid("8981a213-a162-427a-b6d8-54eb694190c6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan505@gmail.com", "Tan505", "hashed_password_505", null, false, false, "Tran505", null, "user", null, 0 },
                    { new Guid("89f59edf-f1c9-4511-982f-f39cbb8eb344"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan760@gmail.com", "Tan760", "hashed_password_760", null, false, false, "Tran760", null, "user", null, 0 },
                    { new Guid("8a4fc6cb-0397-403e-8a2c-8025cb86934f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan365@gmail.com", "Tan365", "hashed_password_365", null, false, false, "Tran365", null, "user", null, 0 },
                    { new Guid("8a9248c3-6118-4b8f-b40e-a63ab85619ca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan460@gmail.com", "Tan460", "hashed_password_460", null, false, false, "Tran460", null, "user", null, 0 },
                    { new Guid("8aa5621e-6e63-43a6-ad63-414768902153"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan507@gmail.com", "Tan507", "hashed_password_507", null, false, false, "Tran507", null, "user", null, 0 },
                    { new Guid("8ad49880-2578-4ea4-91bf-c55382b2da13"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan751@gmail.com", "Tan751", "hashed_password_751", null, false, false, "Tran751", null, "user", null, 0 },
                    { new Guid("8ae54e05-2dc1-46db-9d44-32b4ac8da5d8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan640@gmail.com", "Tan640", "hashed_password_640", null, false, false, "Tran640", null, "user", null, 0 },
                    { new Guid("8b7baf53-9e65-40c6-aec5-b82f20a4df7d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan590@gmail.com", "Tan590", "hashed_password_590", null, false, false, "Tran590", null, "user", null, 0 },
                    { new Guid("8badc67c-1388-4154-ae0e-3cbd1114eb2a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan14@gmail.com", "Tan14", "hashed_password_14", null, false, false, "Tran14", null, "user", null, 0 },
                    { new Guid("8c0a0194-74e4-4e27-a153-b27c71e73757"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan620@gmail.com", "Tan620", "hashed_password_620", null, false, false, "Tran620", null, "user", null, 0 },
                    { new Guid("8c0d4b7d-65b7-4b0d-8096-8d4816dd4092"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan762@gmail.com", "Tan762", "hashed_password_762", null, false, false, "Tran762", null, "user", null, 0 },
                    { new Guid("8c17db06-d37f-47f0-9121-ca9c9f7dd37f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan300@gmail.com", "Tan300", "hashed_password_300", null, false, false, "Tran300", null, "user", null, 0 },
                    { new Guid("8cb14c77-1f33-4ffb-8e90-f7b955043fee"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan588@gmail.com", "Tan588", "hashed_password_588", null, false, false, "Tran588", null, "user", null, 0 },
                    { new Guid("8ceb147f-053b-4d21-bd87-4b7cabae1549"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan831@gmail.com", "Tan831", "hashed_password_831", null, false, false, "Tran831", null, "user", null, 0 },
                    { new Guid("8cef9aa5-aa2e-45c4-970a-37b99faacc61"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan974@gmail.com", "Tan974", "hashed_password_974", null, false, false, "Tran974", null, "user", null, 0 },
                    { new Guid("8d0b87fd-065e-4f11-a257-a381bb03f589"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan543@gmail.com", "Tan543", "hashed_password_543", null, false, false, "Tran543", null, "user", null, 0 },
                    { new Guid("8d84e5f4-5bb1-42d6-b513-84988e67d4b8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan617@gmail.com", "Tan617", "hashed_password_617", null, false, false, "Tran617", null, "user", null, 0 },
                    { new Guid("8daba000-8b52-4dc0-8a00-4b7a7a4d1229"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan781@gmail.com", "Tan781", "hashed_password_781", null, false, false, "Tran781", null, "user", null, 0 },
                    { new Guid("8eb5ce5d-1b50-4107-9fef-38485e75ba78"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan847@gmail.com", "Tan847", "hashed_password_847", null, false, false, "Tran847", null, "user", null, 0 },
                    { new Guid("8ef23e68-d45c-4c69-9f74-f08bb9afdc1a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan433@gmail.com", "Tan433", "hashed_password_433", null, false, false, "Tran433", null, "user", null, 0 },
                    { new Guid("8ef360c7-0b27-4d63-bade-1ad55f09c643"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan685@gmail.com", "Tan685", "hashed_password_685", null, false, false, "Tran685", null, "user", null, 0 },
                    { new Guid("8ef620fc-0b0d-403e-8dd5-2347035cb2a4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan558@gmail.com", "Tan558", "hashed_password_558", null, false, false, "Tran558", null, "user", null, 0 },
                    { new Guid("8f065271-4823-4a35-a6f4-055fca8a65f5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan613@gmail.com", "Tan613", "hashed_password_613", null, false, false, "Tran613", null, "user", null, 0 },
                    { new Guid("8f6a5202-df19-4993-bf48-7a6ce3b68a4c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan38@gmail.com", "Tan38", "hashed_password_38", null, false, false, "Tran38", null, "user", null, 0 },
                    { new Guid("8f743ee4-cbbc-4ce5-bfba-a694183839b7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan843@gmail.com", "Tan843", "hashed_password_843", null, false, false, "Tran843", null, "user", null, 0 },
                    { new Guid("8f8b0dab-958c-4dec-aa1c-0b7993e04a77"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan368@gmail.com", "Tan368", "hashed_password_368", null, false, false, "Tran368", null, "user", null, 0 },
                    { new Guid("8f8bd469-f1e4-4eb0-8138-ac94ec551b56"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan418@gmail.com", "Tan418", "hashed_password_418", null, false, false, "Tran418", null, "user", null, 0 },
                    { new Guid("8f8f8e7e-833f-4070-bf97-5a783100c900"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan438@gmail.com", "Tan438", "hashed_password_438", null, false, false, "Tran438", null, "user", null, 0 },
                    { new Guid("8f91e1b3-de06-4e2b-902d-91861286ce33"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan294@gmail.com", "Tan294", "hashed_password_294", null, false, false, "Tran294", null, "user", null, 0 },
                    { new Guid("8fa036d9-41d7-48cd-b186-481534a8a73b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan350@gmail.com", "Tan350", "hashed_password_350", null, false, false, "Tran350", null, "user", null, 0 },
                    { new Guid("8fe39cee-9122-47ba-b29c-ed7dab258f18"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan871@gmail.com", "Tan871", "hashed_password_871", null, false, false, "Tran871", null, "user", null, 0 },
                    { new Guid("901102aa-7cc8-4bc4-9ea4-7e2c1aae548d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan565@gmail.com", "Tan565", "hashed_password_565", null, false, false, "Tran565", null, "user", null, 0 },
                    { new Guid("91121fac-26ed-46b9-87e4-84d658baf636"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan823@gmail.com", "Tan823", "hashed_password_823", null, false, false, "Tran823", null, "user", null, 0 },
                    { new Guid("916a655e-6273-410b-89bd-6ba4ad0d0345"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan869@gmail.com", "Tan869", "hashed_password_869", null, false, false, "Tran869", null, "user", null, 0 },
                    { new Guid("91aa72ea-c845-40f9-ae58-380b4c79c78e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan449@gmail.com", "Tan449", "hashed_password_449", null, false, false, "Tran449", null, "user", null, 0 },
                    { new Guid("926bcbdf-0c4b-4e89-bf3c-7e1fe4756827"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan603@gmail.com", "Tan603", "hashed_password_603", null, false, false, "Tran603", null, "user", null, 0 },
                    { new Guid("92793e07-5b8c-4662-bc36-e4e55d5b8bfc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan616@gmail.com", "Tan616", "hashed_password_616", null, false, false, "Tran616", null, "user", null, 0 },
                    { new Guid("92ce9f6b-1e45-4dd7-a173-3d25669a0649"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan536@gmail.com", "Tan536", "hashed_password_536", null, false, false, "Tran536", null, "user", null, 0 },
                    { new Guid("93028112-f86a-4fdf-b175-739d60649c64"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan258@gmail.com", "Tan258", "hashed_password_258", null, false, false, "Tran258", null, "user", null, 0 },
                    { new Guid("93c1f9a7-b0f5-4763-a3fa-e9e34f55163d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan953@gmail.com", "Tan953", "hashed_password_953", null, false, false, "Tran953", null, "user", null, 0 },
                    { new Guid("95537da8-517c-4348-a692-7950b3fddd3c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan178@gmail.com", "Tan178", "hashed_password_178", null, false, false, "Tran178", null, "user", null, 0 },
                    { new Guid("959382e2-1755-41e1-947b-9b5f44f9bb46"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan504@gmail.com", "Tan504", "hashed_password_504", null, false, false, "Tran504", null, "user", null, 0 },
                    { new Guid("95d748ec-4051-4aa1-b71f-b86ac1f65fff"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan425@gmail.com", "Tan425", "hashed_password_425", null, false, false, "Tran425", null, "user", null, 0 },
                    { new Guid("95fb49b7-7717-4b01-bf77-fe22cf996fde"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan886@gmail.com", "Tan886", "hashed_password_886", null, false, false, "Tran886", null, "user", null, 0 },
                    { new Guid("95fb868b-5988-4d38-b6cf-55cc47fc6b40"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan670@gmail.com", "Tan670", "hashed_password_670", null, false, false, "Tran670", null, "user", null, 0 },
                    { new Guid("96260dc7-0ef6-4654-8d9d-ff4dc29afd84"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan663@gmail.com", "Tan663", "hashed_password_663", null, false, false, "Tran663", null, "user", null, 0 },
                    { new Guid("963f7c77-1abc-4106-b8c5-1c20b25140a8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan55@gmail.com", "Tan55", "hashed_password_55", null, false, false, "Tran55", null, "user", null, 0 },
                    { new Guid("964d3cc7-f016-48a3-a9bd-c0105770a3a9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan160@gmail.com", "Tan160", "hashed_password_160", null, false, false, "Tran160", null, "user", null, 0 },
                    { new Guid("969b7346-6cf4-470c-a3e2-6a64835a5353"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan191@gmail.com", "Tan191", "hashed_password_191", null, false, false, "Tran191", null, "user", null, 0 },
                    { new Guid("96a236ed-418d-4209-bf51-ce9c170f0997"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan552@gmail.com", "Tan552", "hashed_password_552", null, false, false, "Tran552", null, "user", null, 0 },
                    { new Guid("97aea8d9-6f4b-4ad5-b4f9-658134857186"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan530@gmail.com", "Tan530", "hashed_password_530", null, false, false, "Tran530", null, "user", null, 0 },
                    { new Guid("97b8321e-3291-4a7d-868c-0e33190613a9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan451@gmail.com", "Tan451", "hashed_password_451", null, false, false, "Tran451", null, "user", null, 0 },
                    { new Guid("983e1cae-7e70-4224-915d-3644fb2312d3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan143@gmail.com", "Tan143", "hashed_password_143", null, false, false, "Tran143", null, "user", null, 0 },
                    { new Guid("98418369-882c-47ff-b5dc-b82dd92f650d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan325@gmail.com", "Tan325", "hashed_password_325", null, false, false, "Tran325", null, "user", null, 0 },
                    { new Guid("9844f89d-6808-446c-a7cc-2a11d35e5d35"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan464@gmail.com", "Tan464", "hashed_password_464", null, false, false, "Tran464", null, "user", null, 0 },
                    { new Guid("987f758a-6bd9-4377-97d8-c927a8b21785"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan45@gmail.com", "Tan45", "hashed_password_45", null, false, false, "Tran45", null, "user", null, 0 },
                    { new Guid("98ec2b6c-928e-4eaa-a643-e88e9b2db0f3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan528@gmail.com", "Tan528", "hashed_password_528", null, false, false, "Tran528", null, "user", null, 0 },
                    { new Guid("990640b5-69a9-4d7c-be73-87cc98bb613f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan157@gmail.com", "Tan157", "hashed_password_157", null, false, false, "Tran157", null, "user", null, 0 },
                    { new Guid("996dec2d-cc9c-4d04-97ac-58e229adc6c7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan888@gmail.com", "Tan888", "hashed_password_888", null, false, false, "Tran888", null, "user", null, 0 },
                    { new Guid("999e49d1-5f32-49ed-9c5b-9a4f74404126"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan54@gmail.com", "Tan54", "hashed_password_54", null, false, false, "Tran54", null, "user", null, 0 },
                    { new Guid("99cc96c8-e63a-4e8f-ba70-6aa37e3071c2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan110@gmail.com", "Tan110", "hashed_password_110", null, false, false, "Tran110", null, "user", null, 0 },
                    { new Guid("99d91dfe-4527-4b74-b7f5-88fce29b2938"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan690@gmail.com", "Tan690", "hashed_password_690", null, false, false, "Tran690", null, "user", null, 0 },
                    { new Guid("9a953325-7db3-4a64-8374-4f0ec03a4a37"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan576@gmail.com", "Tan576", "hashed_password_576", null, false, false, "Tran576", null, "user", null, 0 },
                    { new Guid("9a991c65-beb5-47ef-af59-2db168351d82"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan241@gmail.com", "Tan241", "hashed_password_241", null, false, false, "Tran241", null, "user", null, 0 },
                    { new Guid("9ab53936-e2cc-433c-863c-e6b007462595"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan244@gmail.com", "Tan244", "hashed_password_244", null, false, false, "Tran244", null, "user", null, 0 },
                    { new Guid("9ad7635d-06e3-45fd-99b3-bf7e6dcbd03b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan982@gmail.com", "Tan982", "hashed_password_982", null, false, false, "Tran982", null, "user", null, 0 },
                    { new Guid("9b228598-4d84-402a-9b80-cdb72bcb1189"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan638@gmail.com", "Tan638", "hashed_password_638", null, false, false, "Tran638", null, "user", null, 0 },
                    { new Guid("9ba5234c-1a40-477d-bc72-fcbf84015c27"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan989@gmail.com", "Tan989", "hashed_password_989", null, false, false, "Tran989", null, "user", null, 0 },
                    { new Guid("9c1ed185-d96c-40f6-8b47-3877ee6c55cf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan22@gmail.com", "Tan22", "hashed_password_22", null, false, false, "Tran22", null, "user", null, 0 },
                    { new Guid("9c26faf3-a7fb-4133-a7e3-87a15722c268"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan764@gmail.com", "Tan764", "hashed_password_764", null, false, false, "Tran764", null, "user", null, 0 },
                    { new Guid("9c42fb2a-545c-4089-9241-104cf4acf219"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan994@gmail.com", "Tan994", "hashed_password_994", null, false, false, "Tran994", null, "user", null, 0 },
                    { new Guid("9c55bc4f-348b-4671-b6be-3793b6f7aae3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan266@gmail.com", "Tan266", "hashed_password_266", null, false, false, "Tran266", null, "user", null, 0 },
                    { new Guid("9c66ab1c-f88f-463b-b4fb-0bef54727673"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan734@gmail.com", "Tan734", "hashed_password_734", null, false, false, "Tran734", null, "user", null, 0 },
                    { new Guid("9c6c7a1b-1b2b-45ee-aa71-e4bc2c75ac2f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan262@gmail.com", "Tan262", "hashed_password_262", null, false, false, "Tran262", null, "user", null, 0 },
                    { new Guid("9cd2a8b2-acc3-4aa6-a01d-1e5d09b80fef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan648@gmail.com", "Tan648", "hashed_password_648", null, false, false, "Tran648", null, "user", null, 0 },
                    { new Guid("9d159a00-056f-4e30-ad67-47c16c6f3936"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan656@gmail.com", "Tan656", "hashed_password_656", null, false, false, "Tran656", null, "user", null, 0 },
                    { new Guid("9d44fb10-1da4-4c0e-81ff-8a96b46f0675"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan23@gmail.com", "Tan23", "hashed_password_23", null, false, false, "Tran23", null, "user", null, 0 },
                    { new Guid("9d575f80-0404-47d5-bea8-fa96e75e03d9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan526@gmail.com", "Tan526", "hashed_password_526", null, false, false, "Tran526", null, "user", null, 0 },
                    { new Guid("9d78f4b0-b1ab-445c-a15a-a0032557caa6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan68@gmail.com", "Tan68", "hashed_password_68", null, false, false, "Tran68", null, "user", null, 0 },
                    { new Guid("9d95a6bc-a5fd-48f2-b6b9-79fdf4b07e3d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan206@gmail.com", "Tan206", "hashed_password_206", null, false, false, "Tran206", null, "user", null, 0 },
                    { new Guid("9db530b9-fed8-4549-8bea-ad9f70a52b87"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan43@gmail.com", "Tan43", "hashed_password_43", null, false, false, "Tran43", null, "user", null, 0 },
                    { new Guid("9dca1802-b65e-409b-bc2d-3fa55a7fdbab"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan94@gmail.com", "Tan94", "hashed_password_94", null, false, false, "Tran94", null, "user", null, 0 },
                    { new Guid("9dee87d9-1734-404d-b0e8-fd5a4ccfa971"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan453@gmail.com", "Tan453", "hashed_password_453", null, false, false, "Tran453", null, "user", null, 0 },
                    { new Guid("9e0a57ac-5ddd-4d1e-a23a-45035a5900e4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan388@gmail.com", "Tan388", "hashed_password_388", null, false, false, "Tran388", null, "user", null, 0 },
                    { new Guid("9e4950d4-0fea-4b52-ba09-d18924e33a1c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan923@gmail.com", "Tan923", "hashed_password_923", null, false, false, "Tran923", null, "user", null, 0 },
                    { new Guid("9e770ef9-b63e-489a-8187-8dd722651c63"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan49@gmail.com", "Tan49", "hashed_password_49", null, false, false, "Tran49", null, "user", null, 0 },
                    { new Guid("9ec0f34c-6ba4-477a-8eb5-7ea8f3e9acf2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan634@gmail.com", "Tan634", "hashed_password_634", null, false, false, "Tran634", null, "user", null, 0 },
                    { new Guid("9f14c327-d802-438e-b328-8917d8d04694"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan825@gmail.com", "Tan825", "hashed_password_825", null, false, false, "Tran825", null, "user", null, 0 },
                    { new Guid("9f35f185-fe93-4cf5-8a45-f266ee4a11c8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan167@gmail.com", "Tan167", "hashed_password_167", null, false, false, "Tran167", null, "user", null, 0 },
                    { new Guid("9f4560e0-ea4d-4758-8797-a46be452c9d4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan722@gmail.com", "Tan722", "hashed_password_722", null, false, false, "Tran722", null, "user", null, 0 },
                    { new Guid("9f6e258a-168a-43f8-b257-ff3995bc6921"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan435@gmail.com", "Tan435", "hashed_password_435", null, false, false, "Tran435", null, "user", null, 0 },
                    { new Guid("9f7b6bf3-81bb-4fdc-ae89-4a5d651ee9f8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan763@gmail.com", "Tan763", "hashed_password_763", null, false, false, "Tran763", null, "user", null, 0 },
                    { new Guid("9fb712ff-adff-4adf-aef7-d40c78031868"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan793@gmail.com", "Tan793", "hashed_password_793", null, false, false, "Tran793", null, "user", null, 0 },
                    { new Guid("9fc1bc29-815c-4544-8a12-824779959d0e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan192@gmail.com", "Tan192", "hashed_password_192", null, false, false, "Tran192", null, "user", null, 0 },
                    { new Guid("a0494db4-850a-4195-90fe-6f9f3a6a6846"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan179@gmail.com", "Tan179", "hashed_password_179", null, false, false, "Tran179", null, "user", null, 0 },
                    { new Guid("a0583201-19d0-4485-94e0-e532bc9856ef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan193@gmail.com", "Tan193", "hashed_password_193", null, false, false, "Tran193", null, "user", null, 0 },
                    { new Guid("a0be4734-2a1a-49df-8bc8-0a33b777a4fb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan482@gmail.com", "Tan482", "hashed_password_482", null, false, false, "Tran482", null, "user", null, 0 },
                    { new Guid("a11c68e2-1526-4ac4-bea3-d72d9434e1a0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan655@gmail.com", "Tan655", "hashed_password_655", null, false, false, "Tran655", null, "user", null, 0 },
                    { new Guid("a1560a1c-d033-4e5b-b711-109ebc4cafd7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan970@gmail.com", "Tan970", "hashed_password_970", null, false, false, "Tran970", null, "user", null, 0 },
                    { new Guid("a1ed51ef-95e1-4557-8178-ce74653cf3ba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan820@gmail.com", "Tan820", "hashed_password_820", null, false, false, "Tran820", null, "user", null, 0 },
                    { new Guid("a26ba124-f324-4070-8710-00170d0687c1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan375@gmail.com", "Tan375", "hashed_password_375", null, false, false, "Tran375", null, "user", null, 0 },
                    { new Guid("a281681e-f231-45e5-9315-24e9ac28278f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan87@gmail.com", "Tan87", "hashed_password_87", null, false, false, "Tran87", null, "user", null, 0 },
                    { new Guid("a318c84f-6a6e-4eb9-9c2c-0825d3d16967"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan152@gmail.com", "Tan152", "hashed_password_152", null, false, false, "Tran152", null, "user", null, 0 },
                    { new Guid("a3543ffd-23d5-4e94-bd6a-fc76f61806e3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan821@gmail.com", "Tan821", "hashed_password_821", null, false, false, "Tran821", null, "user", null, 0 },
                    { new Guid("a3bf6550-bd1d-45d7-b8a0-c483119b71b0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan238@gmail.com", "Tan238", "hashed_password_238", null, false, false, "Tran238", null, "user", null, 0 },
                    { new Guid("a3d7f9bd-4b7c-4dee-a309-701be85589bb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan808@gmail.com", "Tan808", "hashed_password_808", null, false, false, "Tran808", null, "user", null, 0 },
                    { new Guid("a3e9b2d0-2eb9-4a2c-bcaf-6bedaae9de4b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan322@gmail.com", "Tan322", "hashed_password_322", null, false, false, "Tran322", null, "user", null, 0 },
                    { new Guid("a3f50355-9095-4029-b698-bc529ea6386a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan204@gmail.com", "Tan204", "hashed_password_204", null, false, false, "Tran204", null, "user", null, 0 },
                    { new Guid("a3fce2aa-851c-4675-9543-460d70692fc4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan861@gmail.com", "Tan861", "hashed_password_861", null, false, false, "Tran861", null, "user", null, 0 },
                    { new Guid("a45d4cc6-64b7-48ac-ba34-8f934e9f9906"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan102@gmail.com", "Tan102", "hashed_password_102", null, false, false, "Tran102", null, "user", null, 0 },
                    { new Guid("a4675d2b-5a65-4937-8376-90528e226d06"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan971@gmail.com", "Tan971", "hashed_password_971", null, false, false, "Tran971", null, "user", null, 0 },
                    { new Guid("a46f2e37-9ca0-4a24-a28a-16c92544898a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan281@gmail.com", "Tan281", "hashed_password_281", null, false, false, "Tran281", null, "user", null, 0 },
                    { new Guid("a4cdf3a5-e727-4357-86a1-8eb7ef1c1a92"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan998@gmail.com", "Tan998", "hashed_password_998", null, false, false, "Tran998", null, "user", null, 0 },
                    { new Guid("a4d2ab1b-7b8e-46ff-9536-563023605151"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan549@gmail.com", "Tan549", "hashed_password_549", null, false, false, "Tran549", null, "user", null, 0 },
                    { new Guid("a5353a22-f7af-4e77-ba16-6efb1a5a8d67"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan548@gmail.com", "Tan548", "hashed_password_548", null, false, false, "Tran548", null, "user", null, 0 },
                    { new Guid("a55afec5-84f8-4a77-a7f0-24a6c07d5efe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan32@gmail.com", "Tan32", "hashed_password_32", null, false, false, "Tran32", null, "user", null, 0 },
                    { new Guid("a5a61171-5871-4c4c-ab13-411ca1e7a30a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan749@gmail.com", "Tan749", "hashed_password_749", null, false, false, "Tran749", null, "user", null, 0 },
                    { new Guid("a5f3bc1f-c163-4448-adf6-82c91c6779b7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan278@gmail.com", "Tan278", "hashed_password_278", null, false, false, "Tran278", null, "user", null, 0 },
                    { new Guid("a627ec69-e3df-410c-933f-95727bf5b952"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan141@gmail.com", "Tan141", "hashed_password_141", null, false, false, "Tran141", null, "user", null, 0 },
                    { new Guid("a62e6c2b-8967-47e1-955b-8ded71bcfb7d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan845@gmail.com", "Tan845", "hashed_password_845", null, false, false, "Tran845", null, "user", null, 0 },
                    { new Guid("a684d2b5-2e4e-462b-a359-8e854b937d72"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan359@gmail.com", "Tan359", "hashed_password_359", null, false, false, "Tran359", null, "user", null, 0 },
                    { new Guid("a6aaadda-004a-4534-a4da-c57b21bdca16"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan318@gmail.com", "Tan318", "hashed_password_318", null, false, false, "Tran318", null, "user", null, 0 },
                    { new Guid("a6b58dd9-a315-441a-9879-b4bae90b1368"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan124@gmail.com", "Tan124", "hashed_password_124", null, false, false, "Tran124", null, "user", null, 0 },
                    { new Guid("a7be39a8-7ca5-4e6a-bc4b-ccea6d38c9d6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan678@gmail.com", "Tan678", "hashed_password_678", null, false, false, "Tran678", null, "user", null, 0 },
                    { new Guid("a7ff21d5-ad24-4035-82c9-ae93fae5aaa1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan122@gmail.com", "Tan122", "hashed_password_122", null, false, false, "Tran122", null, "user", null, 0 },
                    { new Guid("a81c10ee-a222-4da4-b017-79d135b304ef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan842@gmail.com", "Tan842", "hashed_password_842", null, false, false, "Tran842", null, "user", null, 0 },
                    { new Guid("a87a1e57-1ace-479a-b749-cdb917b69702"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan155@gmail.com", "Tan155", "hashed_password_155", null, false, false, "Tran155", null, "user", null, 0 },
                    { new Guid("a87fad79-a1f0-43d2-a4bc-50a64d4e3d64"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan261@gmail.com", "Tan261", "hashed_password_261", null, false, false, "Tran261", null, "user", null, 0 },
                    { new Guid("a8ab8ea1-d4ee-455b-b367-dd8047975080"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan506@gmail.com", "Tan506", "hashed_password_506", null, false, false, "Tran506", null, "user", null, 0 },
                    { new Guid("a8d3ad8e-c62c-44b0-9566-6b98bba28a8f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan721@gmail.com", "Tan721", "hashed_password_721", null, false, false, "Tran721", null, "user", null, 0 },
                    { new Guid("a90a8158-7c83-4658-b482-011dd7ff4227"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan270@gmail.com", "Tan270", "hashed_password_270", null, false, false, "Tran270", null, "user", null, 0 },
                    { new Guid("a99af6dc-df85-4168-a655-2daeea082000"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan758@gmail.com", "Tan758", "hashed_password_758", null, false, false, "Tran758", null, "user", null, 0 },
                    { new Guid("a9a5d165-c95a-4d63-bcab-0807ede29c32"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan529@gmail.com", "Tan529", "hashed_password_529", null, false, false, "Tran529", null, "user", null, 0 },
                    { new Guid("a9c0145d-9609-4974-9b79-050967d2374d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan652@gmail.com", "Tan652", "hashed_password_652", null, false, false, "Tran652", null, "user", null, 0 },
                    { new Guid("a9c2463b-c5b7-4a42-b404-b6d042b4f9cf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan553@gmail.com", "Tan553", "hashed_password_553", null, false, false, "Tran553", null, "user", null, 0 },
                    { new Guid("a9c30841-bc93-4200-a200-686996c3fd2e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan518@gmail.com", "Tan518", "hashed_password_518", null, false, false, "Tran518", null, "user", null, 0 },
                    { new Guid("a9d95834-2152-4792-8e7f-2d2b5658f09f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan301@gmail.com", "Tan301", "hashed_password_301", null, false, false, "Tran301", null, "user", null, 0 },
                    { new Guid("aac8a50f-5a1e-4dc2-8b81-f1c303da6af8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan233@gmail.com", "Tan233", "hashed_password_233", null, false, false, "Tran233", null, "user", null, 0 },
                    { new Guid("abb7344e-d029-41ec-9c2e-bf37f1330d81"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan410@gmail.com", "Tan410", "hashed_password_410", null, false, false, "Tran410", null, "user", null, 0 },
                    { new Guid("abcf6753-bfaf-4e0d-84c7-71b957286d53"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan557@gmail.com", "Tan557", "hashed_password_557", null, false, false, "Tran557", null, "user", null, 0 },
                    { new Guid("ac0ff00f-53d7-4aa9-b73e-d962b262c1cf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan754@gmail.com", "Tan754", "hashed_password_754", null, false, false, "Tran754", null, "user", null, 0 },
                    { new Guid("ac2f819c-ccae-49c2-ae4f-b0eb7902400c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan113@gmail.com", "Tan113", "hashed_password_113", null, false, false, "Tran113", null, "user", null, 0 },
                    { new Guid("ad62f3d9-83f7-42b6-a156-97a5e0f8e1a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan396@gmail.com", "Tan396", "hashed_password_396", null, false, false, "Tran396", null, "user", null, 0 },
                    { new Guid("ad6806a3-f470-4867-b1b6-72529d8be27d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan357@gmail.com", "Tan357", "hashed_password_357", null, false, false, "Tran357", null, "user", null, 0 },
                    { new Guid("ad7288bd-d90a-4ce1-b130-ed9db832e6f6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan580@gmail.com", "Tan580", "hashed_password_580", null, false, false, "Tran580", null, "user", null, 0 },
                    { new Guid("ae5ea27b-adef-4c0c-a9e4-b151c7c3e8c5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan605@gmail.com", "Tan605", "hashed_password_605", null, false, false, "Tran605", null, "user", null, 0 },
                    { new Guid("aec121e1-3a34-44d2-b57f-1af78e647a25"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan374@gmail.com", "Tan374", "hashed_password_374", null, false, false, "Tran374", null, "user", null, 0 },
                    { new Guid("af91c1cf-e380-4072-9486-763b7a77f9ec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan838@gmail.com", "Tan838", "hashed_password_838", null, false, false, "Tran838", null, "user", null, 0 },
                    { new Guid("afada213-5362-4e41-91e0-87e336567a2d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan459@gmail.com", "Tan459", "hashed_password_459", null, false, false, "Tran459", null, "user", null, 0 },
                    { new Guid("afeb2e31-d6c5-4f76-8363-e3d0ba1984ae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan312@gmail.com", "Tan312", "hashed_password_312", null, false, false, "Tran312", null, "user", null, 0 },
                    { new Guid("b1a8512d-0c49-4574-9e2e-e51995e46c92"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan441@gmail.com", "Tan441", "hashed_password_441", null, false, false, "Tran441", null, "user", null, 0 },
                    { new Guid("b2bcd0eb-bc5f-4b89-815b-c032044493b5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan833@gmail.com", "Tan833", "hashed_password_833", null, false, false, "Tran833", null, "user", null, 0 },
                    { new Guid("b2d534aa-93e2-43c1-8d46-795152fda050"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan812@gmail.com", "Tan812", "hashed_password_812", null, false, false, "Tran812", null, "user", null, 0 },
                    { new Guid("b3211b76-2196-4732-a169-6c32047de664"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan950@gmail.com", "Tan950", "hashed_password_950", null, false, false, "Tran950", null, "user", null, 0 },
                    { new Guid("b3568547-7833-4588-8e0a-f1946f07994b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan409@gmail.com", "Tan409", "hashed_password_409", null, false, false, "Tran409", null, "user", null, 0 },
                    { new Guid("b35e3963-0baf-4d49-ba47-d6f534a107c0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan718@gmail.com", "Tan718", "hashed_password_718", null, false, false, "Tran718", null, "user", null, 0 },
                    { new Guid("b3ad8b59-e232-42cb-a797-7ca26916667e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan753@gmail.com", "Tan753", "hashed_password_753", null, false, false, "Tran753", null, "user", null, 0 },
                    { new Guid("b3b59def-97c0-4712-b1c7-96d3dcc85857"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan966@gmail.com", "Tan966", "hashed_password_966", null, false, false, "Tran966", null, "user", null, 0 },
                    { new Guid("b442452f-9543-4888-a5d2-b3346b1d365b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan220@gmail.com", "Tan220", "hashed_password_220", null, false, false, "Tran220", null, "user", null, 0 },
                    { new Guid("b51acb49-7463-405a-bbc8-0d36156b1ca7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan689@gmail.com", "Tan689", "hashed_password_689", null, false, false, "Tran689", null, "user", null, 0 },
                    { new Guid("b5246afe-b67b-4931-9ffa-76a57a7e4e7a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan461@gmail.com", "Tan461", "hashed_password_461", null, false, false, "Tran461", null, "user", null, 0 },
                    { new Guid("b53972df-f6bd-451b-b694-e01025507a15"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan494@gmail.com", "Tan494", "hashed_password_494", null, false, false, "Tran494", null, "user", null, 0 },
                    { new Guid("b596681c-65c4-4af7-ac1b-fc95a4a9f09f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan725@gmail.com", "Tan725", "hashed_password_725", null, false, false, "Tran725", null, "user", null, 0 },
                    { new Guid("b5c7f0a1-ee23-49e0-a5a4-d35d635a1bb4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan772@gmail.com", "Tan772", "hashed_password_772", null, false, false, "Tran772", null, "user", null, 0 },
                    { new Guid("b636e2d5-85d7-4d90-b0d5-5383364ce312"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan415@gmail.com", "Tan415", "hashed_password_415", null, false, false, "Tran415", null, "user", null, 0 },
                    { new Guid("b6538550-8fb5-4aba-90c4-45d47fd027fc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan156@gmail.com", "Tan156", "hashed_password_156", null, false, false, "Tran156", null, "user", null, 0 },
                    { new Guid("b68811d4-a20b-4bd2-9cb9-38a9cf365bdd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan963@gmail.com", "Tan963", "hashed_password_963", null, false, false, "Tran963", null, "user", null, 0 },
                    { new Guid("b6926ed3-3529-41ca-8f19-b09f29d8363e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan450@gmail.com", "Tan450", "hashed_password_450", null, false, false, "Tran450", null, "user", null, 0 },
                    { new Guid("b69e5bb1-7daf-48ff-8c2d-eef5b41d4701"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan520@gmail.com", "Tan520", "hashed_password_520", null, false, false, "Tran520", null, "user", null, 0 },
                    { new Guid("b69fe75b-1496-4dad-9ca6-a9d681a54c88"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan794@gmail.com", "Tan794", "hashed_password_794", null, false, false, "Tran794", null, "user", null, 0 },
                    { new Guid("b6c68c32-3323-48dd-946c-45f23bd16a60"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan697@gmail.com", "Tan697", "hashed_password_697", null, false, false, "Tran697", null, "user", null, 0 },
                    { new Guid("b6e12a8f-3e9b-4b6f-91cc-e2eac92527fd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan370@gmail.com", "Tan370", "hashed_password_370", null, false, false, "Tran370", null, "user", null, 0 },
                    { new Guid("b6f53ad6-d0d1-4531-88ea-66ceec7df052"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan362@gmail.com", "Tan362", "hashed_password_362", null, false, false, "Tran362", null, "user", null, 0 },
                    { new Guid("b78a1f2e-2bd7-4932-9327-bda5848e20c6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan629@gmail.com", "Tan629", "hashed_password_629", null, false, false, "Tran629", null, "user", null, 0 },
                    { new Guid("b795095d-e120-4b1b-8246-af7eeb3bd32a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan676@gmail.com", "Tan676", "hashed_password_676", null, false, false, "Tran676", null, "user", null, 0 },
                    { new Guid("b7eeee78-a4c5-4bdd-a746-395047743f7c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan121@gmail.com", "Tan121", "hashed_password_121", null, false, false, "Tran121", null, "user", null, 0 },
                    { new Guid("b83fb2ed-4666-40fa-84b6-769be1956aec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan332@gmail.com", "Tan332", "hashed_password_332", null, false, false, "Tran332", null, "user", null, 0 },
                    { new Guid("b8853937-8f95-4cc9-a847-f47b389661f3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan876@gmail.com", "Tan876", "hashed_password_876", null, false, false, "Tran876", null, "user", null, 0 },
                    { new Guid("b90566ea-6a90-4f78-bd2e-2ba2198bb2cc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan488@gmail.com", "Tan488", "hashed_password_488", null, false, false, "Tran488", null, "user", null, 0 },
                    { new Guid("b92f9fb4-b88b-456d-bf56-bb8b147de07a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan688@gmail.com", "Tan688", "hashed_password_688", null, false, false, "Tran688", null, "user", null, 0 },
                    { new Guid("b9842b8c-d296-4ad2-855a-4a611d06ac8f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan169@gmail.com", "Tan169", "hashed_password_169", null, false, false, "Tran169", null, "user", null, 0 },
                    { new Guid("b9a97764-a611-48a6-966c-f77dbdedca5e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan271@gmail.com", "Tan271", "hashed_password_271", null, false, false, "Tran271", null, "user", null, 0 },
                    { new Guid("b9ba4a9e-0af0-4d75-aaab-0d22d771e365"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan858@gmail.com", "Tan858", "hashed_password_858", null, false, false, "Tran858", null, "user", null, 0 },
                    { new Guid("b9d4caf8-0fe1-4fa1-a74d-25f2f53effd9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan952@gmail.com", "Tan952", "hashed_password_952", null, false, false, "Tran952", null, "user", null, 0 },
                    { new Guid("b9d9e5c4-727e-4cae-91d6-73a8ecbe0184"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan592@gmail.com", "Tan592", "hashed_password_592", null, false, false, "Tran592", null, "user", null, 0 },
                    { new Guid("b9dfc722-54be-493c-a22d-5bab7a0474da"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan279@gmail.com", "Tan279", "hashed_password_279", null, false, false, "Tran279", null, "user", null, 0 },
                    { new Guid("ba12404d-841a-48dd-a3b1-b70541b85c37"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan149@gmail.com", "Tan149", "hashed_password_149", null, false, false, "Tran149", null, "user", null, 0 },
                    { new Guid("ba4d9b48-c3ce-4e42-9e20-56356e3e0c45"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan277@gmail.com", "Tan277", "hashed_password_277", null, false, false, "Tran277", null, "user", null, 0 },
                    { new Guid("ba589f75-f93c-48db-b296-8dd3aa66488b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan921@gmail.com", "Tan921", "hashed_password_921", null, false, false, "Tran921", null, "user", null, 0 },
                    { new Guid("bb2103ac-67bb-4737-b508-66efcb5d6f74"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan123@gmail.com", "Tan123", "hashed_password_123", null, false, false, "Tran123", null, "user", null, 0 },
                    { new Guid("bb276031-cade-4daa-bece-e4ffcd18b365"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan645@gmail.com", "Tan645", "hashed_password_645", null, false, false, "Tran645", null, "user", null, 0 },
                    { new Guid("bb30b360-5d05-4549-b392-8f37a8fd75ec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan515@gmail.com", "Tan515", "hashed_password_515", null, false, false, "Tran515", null, "user", null, 0 },
                    { new Guid("bb556ccd-6f9f-4fe4-9c00-09fe35a4f263"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan92@gmail.com", "Tan92", "hashed_password_92", null, false, false, "Tran92", null, "user", null, 0 },
                    { new Guid("bb6a6484-a8ff-4537-9a81-466f38bdb292"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan748@gmail.com", "Tan748", "hashed_password_748", null, false, false, "Tran748", null, "user", null, 0 },
                    { new Guid("bbbff2a9-fce5-4de7-ae8a-c15e8f2523c3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan829@gmail.com", "Tan829", "hashed_password_829", null, false, false, "Tran829", null, "user", null, 0 },
                    { new Guid("bbd594f0-7d10-4ba3-af96-c658d4678bf6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan809@gmail.com", "Tan809", "hashed_password_809", null, false, false, "Tran809", null, "user", null, 0 },
                    { new Guid("bc34a5bc-1c4c-4073-924f-b989cab6b4b2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan866@gmail.com", "Tan866", "hashed_password_866", null, false, false, "Tran866", null, "user", null, 0 },
                    { new Guid("bc515f9c-7438-4862-8abf-481aef5cae44"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan562@gmail.com", "Tan562", "hashed_password_562", null, false, false, "Tran562", null, "user", null, 0 },
                    { new Guid("bc62ed17-bb9e-4b58-810a-0327702d75aa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan295@gmail.com", "Tan295", "hashed_password_295", null, false, false, "Tran295", null, "user", null, 0 },
                    { new Guid("bcd90beb-7f5e-490d-a671-fbe78f27d1c5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan642@gmail.com", "Tan642", "hashed_password_642", null, false, false, "Tran642", null, "user", null, 0 },
                    { new Guid("bcdbb753-1469-464b-8892-f5c9cf952dca"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan200@gmail.com", "Tan200", "hashed_password_200", null, false, false, "Tran200", null, "user", null, 0 },
                    { new Guid("bd5fc58a-221c-491b-8ec6-cd0a7f657567"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan372@gmail.com", "Tan372", "hashed_password_372", null, false, false, "Tran372", null, "user", null, 0 },
                    { new Guid("bd6ae6d1-a7de-45ee-befc-18b95d7318df"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan24@gmail.com", "Tan24", "hashed_password_24", null, false, false, "Tran24", null, "user", null, 0 },
                    { new Guid("be567c77-e26b-4de2-ad07-0190f86e740f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan668@gmail.com", "Tan668", "hashed_password_668", null, false, false, "Tran668", null, "user", null, 0 },
                    { new Guid("be83bdd9-6d93-41ce-8cdd-195cce8448d9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan274@gmail.com", "Tan274", "hashed_password_274", null, false, false, "Tran274", null, "user", null, 0 },
                    { new Guid("bebca501-2de2-4499-b441-cd1464fa0fbc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan358@gmail.com", "Tan358", "hashed_password_358", null, false, false, "Tran358", null, "user", null, 0 },
                    { new Guid("beda9372-5fa3-4e39-a56c-5af5588d90ff"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan339@gmail.com", "Tan339", "hashed_password_339", null, false, false, "Tran339", null, "user", null, 0 },
                    { new Guid("bfd2fe8b-dc18-4357-977e-9c43af97441a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan150@gmail.com", "Tan150", "hashed_password_150", null, false, false, "Tran150", null, "user", null, 0 },
                    { new Guid("c021e527-4fed-4ba2-9977-97cb6c1f4844"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan96@gmail.com", "Tan96", "hashed_password_96", null, false, false, "Tran96", null, "user", null, 0 },
                    { new Guid("c06d9fae-d7b6-4285-a805-af6763fbda13"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan604@gmail.com", "Tan604", "hashed_password_604", null, false, false, "Tran604", null, "user", null, 0 },
                    { new Guid("c092c775-0b53-4f25-aa9d-ee6906e06d81"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan456@gmail.com", "Tan456", "hashed_password_456", null, false, false, "Tran456", null, "user", null, 0 },
                    { new Guid("c154d985-b4a3-472f-a82d-449479a4607f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan229@gmail.com", "Tan229", "hashed_password_229", null, false, false, "Tran229", null, "user", null, 0 },
                    { new Guid("c1789a4f-48d0-4b4c-8bb5-fd4d2b17f12f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan841@gmail.com", "Tan841", "hashed_password_841", null, false, false, "Tran841", null, "user", null, 0 },
                    { new Guid("c196cdcf-f109-4b83-8f0d-714f3b10cc87"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan0@gmail.com", "Tan0", "hashed_password_0", null, false, false, "Tran0", null, "user", null, 0 },
                    { new Guid("c1aa8ee6-fda4-4019-91bd-7dd33a075964"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan611@gmail.com", "Tan611", "hashed_password_611", null, false, false, "Tran611", null, "user", null, 0 },
                    { new Guid("c2515310-fcd5-45e8-957f-e2be919a2b1b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan682@gmail.com", "Tan682", "hashed_password_682", null, false, false, "Tran682", null, "user", null, 0 },
                    { new Guid("c2678431-b22f-4249-995c-ca040fdd74a4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan184@gmail.com", "Tan184", "hashed_password_184", null, false, false, "Tran184", null, "user", null, 0 },
                    { new Guid("c26c9233-c57e-4dee-9460-146b409536a7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan713@gmail.com", "Tan713", "hashed_password_713", null, false, false, "Tran713", null, "user", null, 0 },
                    { new Guid("c2a0adf9-26f6-4b92-ac87-e0f5652c5a8c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan387@gmail.com", "Tan387", "hashed_password_387", null, false, false, "Tran387", null, "user", null, 0 },
                    { new Guid("c3a980fe-ab36-46bb-b1c7-4258fb2dc951"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan231@gmail.com", "Tan231", "hashed_password_231", null, false, false, "Tran231", null, "user", null, 0 },
                    { new Guid("c3b67b29-5fc3-4adf-826d-719f64c499c2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan472@gmail.com", "Tan472", "hashed_password_472", null, false, false, "Tran472", null, "user", null, 0 },
                    { new Guid("c3bd4243-b875-4d8b-adbf-7df14211a885"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan534@gmail.com", "Tan534", "hashed_password_534", null, false, false, "Tran534", null, "user", null, 0 },
                    { new Guid("c411fdcd-d9aa-4a31-8ac0-2ba68b402a5c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan380@gmail.com", "Tan380", "hashed_password_380", null, false, false, "Tran380", null, "user", null, 0 },
                    { new Guid("c4410cec-a97d-41c0-9719-473c1f0a5248"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan783@gmail.com", "Tan783", "hashed_password_783", null, false, false, "Tran783", null, "user", null, 0 },
                    { new Guid("c4500892-ef8e-440e-bfaf-599c2e2c8cad"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan889@gmail.com", "Tan889", "hashed_password_889", null, false, false, "Tran889", null, "user", null, 0 },
                    { new Guid("c48ebd1d-5ac1-48c5-8bd4-f4af0b79ca08"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan452@gmail.com", "Tan452", "hashed_password_452", null, false, false, "Tran452", null, "user", null, 0 },
                    { new Guid("c4ac27d8-3046-4a9b-8b8f-6cb766d7057c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan275@gmail.com", "Tan275", "hashed_password_275", null, false, false, "Tran275", null, "user", null, 0 },
                    { new Guid("c4bf8ca8-1672-4e23-af18-baf8a616ebcb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan674@gmail.com", "Tan674", "hashed_password_674", null, false, false, "Tran674", null, "user", null, 0 },
                    { new Guid("c58f6db2-e209-4eda-bab9-6742214cb61c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan956@gmail.com", "Tan956", "hashed_password_956", null, false, false, "Tran956", null, "user", null, 0 },
                    { new Guid("c6446084-761c-4f16-b2b0-19919a4c8c40"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan723@gmail.com", "Tan723", "hashed_password_723", null, false, false, "Tran723", null, "user", null, 0 },
                    { new Guid("c69e1db1-90b2-407d-9346-d0d872983028"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan491@gmail.com", "Tan491", "hashed_password_491", null, false, false, "Tran491", null, "user", null, 0 },
                    { new Guid("c6ca817d-7bc0-4a77-ae00-45985b92b381"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan177@gmail.com", "Tan177", "hashed_password_177", null, false, false, "Tran177", null, "user", null, 0 },
                    { new Guid("c6f7d418-aff6-43dc-83f7-9045bbe9f410"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan890@gmail.com", "Tan890", "hashed_password_890", null, false, false, "Tran890", null, "user", null, 0 },
                    { new Guid("c738b821-7a96-4362-826d-d27cefc9e0b4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan882@gmail.com", "Tan882", "hashed_password_882", null, false, false, "Tran882", null, "user", null, 0 },
                    { new Guid("c7c1cfa6-b8db-4544-af1b-24b0517878ff"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan717@gmail.com", "Tan717", "hashed_password_717", null, false, false, "Tran717", null, "user", null, 0 },
                    { new Guid("c81dd4d3-9cea-4f3f-af78-ef51c197e65c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan521@gmail.com", "Tan521", "hashed_password_521", null, false, false, "Tran521", null, "user", null, 0 },
                    { new Guid("c870c4e4-7162-4215-8844-e924dce3ff36"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan109@gmail.com", "Tan109", "hashed_password_109", null, false, false, "Tran109", null, "user", null, 0 },
                    { new Guid("c8a48d96-6942-4e94-9d89-d971b51696fe"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan755@gmail.com", "Tan755", "hashed_password_755", null, false, false, "Tran755", null, "user", null, 0 },
                    { new Guid("c8c800f2-868a-4db0-a9ce-6900425e1337"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan321@gmail.com", "Tan321", "hashed_password_321", null, false, false, "Tran321", null, "user", null, 0 },
                    { new Guid("c8d96396-46e1-4ef8-ae87-ef4303cdaff4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan492@gmail.com", "Tan492", "hashed_password_492", null, false, false, "Tran492", null, "user", null, 0 },
                    { new Guid("c8f7e91f-662c-4a69-9f87-c52b2ffdc3a5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan397@gmail.com", "Tan397", "hashed_password_397", null, false, false, "Tran397", null, "user", null, 0 },
                    { new Guid("c90a27d6-8e5a-4825-bce6-0814056a4e1d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan405@gmail.com", "Tan405", "hashed_password_405", null, false, false, "Tran405", null, "user", null, 0 },
                    { new Guid("c9450229-6acd-4dae-aed0-494b2a33fdd2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan379@gmail.com", "Tan379", "hashed_password_379", null, false, false, "Tran379", null, "user", null, 0 },
                    { new Guid("c9572945-99c6-41b5-b865-2fa239d2d286"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan320@gmail.com", "Tan320", "hashed_password_320", null, false, false, "Tran320", null, "user", null, 0 },
                    { new Guid("c982d348-b9c8-4241-8e83-96891757bc5d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan894@gmail.com", "Tan894", "hashed_password_894", null, false, false, "Tran894", null, "user", null, 0 },
                    { new Guid("ca16844b-6499-46b3-939c-33d7dd788b10"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan531@gmail.com", "Tan531", "hashed_password_531", null, false, false, "Tran531", null, "user", null, 0 },
                    { new Guid("ca8896fd-bf68-46ef-a47a-21b496a0be76"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan631@gmail.com", "Tan631", "hashed_password_631", null, false, false, "Tran631", null, "user", null, 0 },
                    { new Guid("ca9ac6c2-1d29-43c4-9984-835c6d5db6e3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan765@gmail.com", "Tan765", "hashed_password_765", null, false, false, "Tran765", null, "user", null, 0 },
                    { new Guid("cad09fc9-a553-4455-930b-683ab81561c1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan242@gmail.com", "Tan242", "hashed_password_242", null, false, false, "Tran242", null, "user", null, 0 },
                    { new Guid("cae3461f-ecb9-4aa2-84c6-f2726a032f9a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan651@gmail.com", "Tan651", "hashed_password_651", null, false, false, "Tran651", null, "user", null, 0 },
                    { new Guid("cb1ad664-4a98-47e3-a803-756a5e5d97f7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan568@gmail.com", "Tan568", "hashed_password_568", null, false, false, "Tran568", null, "user", null, 0 },
                    { new Guid("cb44fef4-3684-43d9-8416-791dda4e4f2b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan105@gmail.com", "Tan105", "hashed_password_105", null, false, false, "Tran105", null, "user", null, 0 },
                    { new Guid("cbf2e929-b760-446c-a223-eaae8d01ac07"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan509@gmail.com", "Tan509", "hashed_password_509", null, false, false, "Tran509", null, "user", null, 0 },
                    { new Guid("ccec1f0d-670f-4042-a01f-68da1629ff14"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan913@gmail.com", "Tan913", "hashed_password_913", null, false, false, "Tran913", null, "user", null, 0 },
                    { new Guid("ccf1ef72-9abd-417f-bb62-501856e3b24e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan694@gmail.com", "Tan694", "hashed_password_694", null, false, false, "Tran694", null, "user", null, 0 },
                    { new Guid("cd1518a1-6480-486a-b59a-6a2cf01b8c3e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan872@gmail.com", "Tan872", "hashed_password_872", null, false, false, "Tran872", null, "user", null, 0 },
                    { new Guid("cd2297d3-c5d2-4efe-bdbc-d8f1d4d43229"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan948@gmail.com", "Tan948", "hashed_password_948", null, false, false, "Tran948", null, "user", null, 0 },
                    { new Guid("cd25eaa7-1cc0-4db8-a816-451ccbd2a7c5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan404@gmail.com", "Tan404", "hashed_password_404", null, false, false, "Tran404", null, "user", null, 0 },
                    { new Guid("cd8f1479-fc62-4e59-946a-526a1e3cf3b2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan661@gmail.com", "Tan661", "hashed_password_661", null, false, false, "Tran661", null, "user", null, 0 },
                    { new Guid("cdaa033e-173c-468a-802f-fb35c87ee377"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan724@gmail.com", "Tan724", "hashed_password_724", null, false, false, "Tran724", null, "user", null, 0 },
                    { new Guid("cdd46003-1066-4a7e-b595-02017c9baec0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan964@gmail.com", "Tan964", "hashed_password_964", null, false, false, "Tran964", null, "user", null, 0 },
                    { new Guid("cdeac1ce-003a-43eb-9d17-49888ca47817"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan16@gmail.com", "Tan16", "hashed_password_16", null, false, false, "Tran16", null, "user", null, 0 },
                    { new Guid("cdfa436f-e3bd-47e2-8121-089ea7992fae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan47@gmail.com", "Tan47", "hashed_password_47", null, false, false, "Tran47", null, "user", null, 0 },
                    { new Guid("ce137653-f328-4904-bcb4-02fda885987e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan226@gmail.com", "Tan226", "hashed_password_226", null, false, false, "Tran226", null, "user", null, 0 },
                    { new Guid("ce429853-b453-4253-88e4-4c11e1ca4941"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan683@gmail.com", "Tan683", "hashed_password_683", null, false, false, "Tran683", null, "user", null, 0 },
                    { new Guid("cf602b10-59d7-4872-b953-06f49bedbfde"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan36@gmail.com", "Tan36", "hashed_password_36", null, false, false, "Tran36", null, "user", null, 0 },
                    { new Guid("cf6d9298-06e2-41bd-b139-b2cc11a3ff47"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan792@gmail.com", "Tan792", "hashed_password_792", null, false, false, "Tran792", null, "user", null, 0 },
                    { new Guid("cf76d701-637b-4640-a7c2-29982e40cc30"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan420@gmail.com", "Tan420", "hashed_password_420", null, false, false, "Tran420", null, "user", null, 0 },
                    { new Guid("d0016ef5-9d5a-4500-93a7-6cfdbd043289"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan26@gmail.com", "Tan26", "hashed_password_26", null, false, false, "Tran26", null, "user", null, 0 },
                    { new Guid("d133e86f-04ed-4ee1-b3c9-4a9dd4a441ff"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan777@gmail.com", "Tan777", "hashed_password_777", null, false, false, "Tran777", null, "user", null, 0 },
                    { new Guid("d1582435-b304-4f1b-9c55-ccfff187dcf5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan445@gmail.com", "Tan445", "hashed_password_445", null, false, false, "Tran445", null, "user", null, 0 },
                    { new Guid("d15c5afb-f3de-475d-8c5c-e0da11576f78"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan517@gmail.com", "Tan517", "hashed_password_517", null, false, false, "Tran517", null, "user", null, 0 },
                    { new Guid("d17ae9f8-cf40-4ee0-a394-af4efb53a9de"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan987@gmail.com", "Tan987", "hashed_password_987", null, false, false, "Tran987", null, "user", null, 0 },
                    { new Guid("d18a9f0f-fc59-4b22-98d9-69d728097ed4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan20@gmail.com", "Tan20", "hashed_password_20", null, false, false, "Tran20", null, "user", null, 0 },
                    { new Guid("d18b0d25-9724-4430-b9d1-edb4e44f75a4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan282@gmail.com", "Tan282", "hashed_password_282", null, false, false, "Tran282", null, "user", null, 0 },
                    { new Guid("d18f8014-5240-4822-af5e-d948c23428f1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan116@gmail.com", "Tan116", "hashed_password_116", null, false, false, "Tran116", null, "user", null, 0 },
                    { new Guid("d1a702ca-4df6-4275-9c2c-d3967a26babd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan614@gmail.com", "Tan614", "hashed_password_614", null, false, false, "Tran614", null, "user", null, 0 },
                    { new Guid("d1a76600-f404-4407-b000-ec8fc23f1913"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan426@gmail.com", "Tan426", "hashed_password_426", null, false, false, "Tran426", null, "user", null, 0 },
                    { new Guid("d1cdb8b7-f186-4fa4-bcb9-9434eb544cc7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan738@gmail.com", "Tan738", "hashed_password_738", null, false, false, "Tran738", null, "user", null, 0 },
                    { new Guid("d20266d0-1022-42f8-9b69-b74f5043b6df"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan708@gmail.com", "Tan708", "hashed_password_708", null, false, false, "Tran708", null, "user", null, 0 },
                    { new Guid("d261d036-9301-44f5-8a12-1ae4c8bbb441"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan398@gmail.com", "Tan398", "hashed_password_398", null, false, false, "Tran398", null, "user", null, 0 },
                    { new Guid("d26d2d62-502d-4f83-802b-650f4b423c28"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan353@gmail.com", "Tan353", "hashed_password_353", null, false, false, "Tran353", null, "user", null, 0 },
                    { new Guid("d29491b4-0ee8-4240-a398-8e06f93f0ed0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan816@gmail.com", "Tan816", "hashed_password_816", null, false, false, "Tran816", null, "user", null, 0 },
                    { new Guid("d2a0b623-de95-4a4e-918f-a0cff007d4a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan311@gmail.com", "Tan311", "hashed_password_311", null, false, false, "Tran311", null, "user", null, 0 },
                    { new Guid("d2e96628-5698-41cc-8cd2-338c3bebc3d0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan672@gmail.com", "Tan672", "hashed_password_672", null, false, false, "Tran672", null, "user", null, 0 },
                    { new Guid("d2f9ab59-1728-4677-a117-9747b2e6e015"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan810@gmail.com", "Tan810", "hashed_password_810", null, false, false, "Tran810", null, "user", null, 0 },
                    { new Guid("d3056888-7cb7-4a6f-8c5a-9af469d7f63f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan513@gmail.com", "Tan513", "hashed_password_513", null, false, false, "Tran513", null, "user", null, 0 },
                    { new Guid("d3d809ab-1437-486b-b9e7-04bb4f350077"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan344@gmail.com", "Tan344", "hashed_password_344", null, false, false, "Tran344", null, "user", null, 0 },
                    { new Guid("d3dd9595-dd74-49ee-821c-908e2f568aa9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan874@gmail.com", "Tan874", "hashed_password_874", null, false, false, "Tran874", null, "user", null, 0 },
                    { new Guid("d4543db9-db32-4f25-beac-046a70a078b4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan84@gmail.com", "Tan84", "hashed_password_84", null, false, false, "Tran84", null, "user", null, 0 },
                    { new Guid("d481299f-91ea-4d45-9339-c2de04d886ba"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan747@gmail.com", "Tan747", "hashed_password_747", null, false, false, "Tran747", null, "user", null, 0 },
                    { new Guid("d4acb96e-b99b-4d85-99ee-f0b1b7f81cd6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan386@gmail.com", "Tan386", "hashed_password_386", null, false, false, "Tran386", null, "user", null, 0 },
                    { new Guid("d4af65fe-5f4a-4929-9ccb-efed1e028012"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan779@gmail.com", "Tan779", "hashed_password_779", null, false, false, "Tran779", null, "user", null, 0 },
                    { new Guid("d4c8b1fa-79a2-4dcd-af6d-dee54f9f0d73"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan979@gmail.com", "Tan979", "hashed_password_979", null, false, false, "Tran979", null, "user", null, 0 },
                    { new Guid("d51d4e09-2ae7-4a53-a018-799143b73e70"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan532@gmail.com", "Tan532", "hashed_password_532", null, false, false, "Tran532", null, "user", null, 0 },
                    { new Guid("d528838c-493e-4535-b90e-1b988d18a7b2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan148@gmail.com", "Tan148", "hashed_password_148", null, false, false, "Tran148", null, "user", null, 0 },
                    { new Guid("d56d9e85-f806-4a55-a038-1257c0ca6dc6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan775@gmail.com", "Tan775", "hashed_password_775", null, false, false, "Tran775", null, "user", null, 0 },
                    { new Guid("d573e086-21d7-4ffd-9e3a-ae411e5147de"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan883@gmail.com", "Tan883", "hashed_password_883", null, false, false, "Tran883", null, "user", null, 0 },
                    { new Guid("d5f535c2-597a-475c-9e66-c5e8ae15426b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan304@gmail.com", "Tan304", "hashed_password_304", null, false, false, "Tran304", null, "user", null, 0 },
                    { new Guid("d63cdc87-1522-4e6e-9902-fe10aabb1edb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan691@gmail.com", "Tan691", "hashed_password_691", null, false, false, "Tran691", null, "user", null, 0 },
                    { new Guid("d69f3406-f255-475e-8976-dfec74cf891d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan199@gmail.com", "Tan199", "hashed_password_199", null, false, false, "Tran199", null, "user", null, 0 },
                    { new Guid("d7617530-57b3-4c10-96af-5c1b809e0f93"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan443@gmail.com", "Tan443", "hashed_password_443", null, false, false, "Tran443", null, "user", null, 0 },
                    { new Guid("d7818998-50d9-44e6-893f-c30959c12bf3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan897@gmail.com", "Tan897", "hashed_password_897", null, false, false, "Tran897", null, "user", null, 0 },
                    { new Guid("d7886b8c-9450-485b-b574-c8cce5329e2b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan130@gmail.com", "Tan130", "hashed_password_130", null, false, false, "Tran130", null, "user", null, 0 },
                    { new Guid("d79c79d1-0737-4022-8baa-9ee73a8b4f72"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan867@gmail.com", "Tan867", "hashed_password_867", null, false, false, "Tran867", null, "user", null, 0 },
                    { new Guid("d80d2a22-ba8d-497d-bc55-87d307b3ad97"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan13@gmail.com", "Tan13", "hashed_password_13", null, false, false, "Tran13", null, "user", null, 0 },
                    { new Guid("d8c2f0c5-bb38-44c1-a2b7-1b7649cb64bf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan63@gmail.com", "Tan63", "hashed_password_63", null, false, false, "Tran63", null, "user", null, 0 },
                    { new Guid("d8c32936-aa17-44d7-8198-26af6f96dd69"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan797@gmail.com", "Tan797", "hashed_password_797", null, false, false, "Tran797", null, "user", null, 0 },
                    { new Guid("d91c61d7-d283-4362-a638-9a4638fd009f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan354@gmail.com", "Tan354", "hashed_password_354", null, false, false, "Tran354", null, "user", null, 0 },
                    { new Guid("d9985a20-7fa2-469b-9f17-a145e13d45ee"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan85@gmail.com", "Tan85", "hashed_password_85", null, false, false, "Tran85", null, "user", null, 0 },
                    { new Guid("d9b5e41e-b5a4-4c4f-9383-b34321ec8523"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan900@gmail.com", "Tan900", "hashed_password_900", null, false, false, "Tran900", null, "user", null, 0 },
                    { new Guid("d9e92f32-b5d8-487f-ad98-057e4b8fdb50"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan414@gmail.com", "Tan414", "hashed_password_414", null, false, false, "Tran414", null, "user", null, 0 },
                    { new Guid("dac02d5c-2f2b-4525-ab63-5b67eaaddc08"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan97@gmail.com", "Tan97", "hashed_password_97", null, false, false, "Tran97", null, "user", null, 0 },
                    { new Guid("db7ef33a-4c25-412c-9f15-eb8ffc5262de"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan37@gmail.com", "Tan37", "hashed_password_37", null, false, false, "Tran37", null, "user", null, 0 },
                    { new Guid("dd6247e6-a642-4e53-9df7-2dc4f0e73cc3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan439@gmail.com", "Tan439", "hashed_password_439", null, false, false, "Tran439", null, "user", null, 0 },
                    { new Guid("ddc3cda4-be18-4783-846d-164422045ff8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan782@gmail.com", "Tan782", "hashed_password_782", null, false, false, "Tran782", null, "user", null, 0 },
                    { new Guid("dde22cbf-dae6-4e2e-a4ae-9087aad8100c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan930@gmail.com", "Tan930", "hashed_password_930", null, false, false, "Tran930", null, "user", null, 0 },
                    { new Guid("de6731cd-3c84-42b9-9195-7658a0f862ed"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan284@gmail.com", "Tan284", "hashed_password_284", null, false, false, "Tran284", null, "user", null, 0 },
                    { new Guid("de89a73a-0098-477f-ba85-6df0cb46df13"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan363@gmail.com", "Tan363", "hashed_password_363", null, false, false, "Tran363", null, "user", null, 0 },
                    { new Guid("dec6d016-e81f-4325-b39f-cca4015d3b4b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan788@gmail.com", "Tan788", "hashed_password_788", null, false, false, "Tran788", null, "user", null, 0 },
                    { new Guid("df22f758-caa7-4d0d-a84f-7b6dd66b0d2c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan834@gmail.com", "Tan834", "hashed_password_834", null, false, false, "Tran834", null, "user", null, 0 },
                    { new Guid("dfa40a1d-c871-4434-bc97-c84dcf3cc698"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan378@gmail.com", "Tan378", "hashed_password_378", null, false, false, "Tran378", null, "user", null, 0 },
                    { new Guid("e0009eb2-e4b9-4ed9-8414-5a2c46cc8726"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan276@gmail.com", "Tan276", "hashed_password_276", null, false, false, "Tran276", null, "user", null, 0 },
                    { new Guid("e0016bab-7413-45c2-b520-4823b7ef3283"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan654@gmail.com", "Tan654", "hashed_password_654", null, false, false, "Tran654", null, "user", null, 0 },
                    { new Guid("e00a6d49-8301-47b5-bf6f-a02ec42c3396"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan686@gmail.com", "Tan686", "hashed_password_686", null, false, false, "Tran686", null, "user", null, 0 },
                    { new Guid("e00ca874-76c3-4123-a8d0-e6b06ee513e2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan891@gmail.com", "Tan891", "hashed_password_891", null, false, false, "Tran891", null, "user", null, 0 },
                    { new Guid("e0279e43-31cb-48a6-8cb8-3913db8d1778"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan129@gmail.com", "Tan129", "hashed_password_129", null, false, false, "Tran129", null, "user", null, 0 },
                    { new Guid("e02f265b-abda-441c-b953-7bd75b375e97"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan401@gmail.com", "Tan401", "hashed_password_401", null, false, false, "Tran401", null, "user", null, 0 },
                    { new Guid("e099898d-ad99-4375-9d49-0c24f6d9adef"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan251@gmail.com", "Tan251", "hashed_password_251", null, false, false, "Tran251", null, "user", null, 0 },
                    { new Guid("e1039d21-32fd-4ec6-ba92-cc0a97a39fd1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan293@gmail.com", "Tan293", "hashed_password_293", null, false, false, "Tran293", null, "user", null, 0 },
                    { new Guid("e1295c03-32e6-46a7-a291-18064d2aca32"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan299@gmail.com", "Tan299", "hashed_password_299", null, false, false, "Tran299", null, "user", null, 0 },
                    { new Guid("e12c6571-abd2-4338-a025-225c4f6f7a22"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan937@gmail.com", "Tan937", "hashed_password_937", null, false, false, "Tran937", null, "user", null, 0 },
                    { new Guid("e14c45e1-0ac9-458f-be5c-7fe940c8718b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan822@gmail.com", "Tan822", "hashed_password_822", null, false, false, "Tran822", null, "user", null, 0 },
                    { new Guid("e1ad87f1-0f54-4974-aa72-f4fddbf4609d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan60@gmail.com", "Tan60", "hashed_password_60", null, false, false, "Tran60", null, "user", null, 0 },
                    { new Guid("e20aa3e6-b917-4c6f-9cd7-1f57218288a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan856@gmail.com", "Tan856", "hashed_password_856", null, false, false, "Tran856", null, "user", null, 0 },
                    { new Guid("e239c6fe-9712-4f3b-89a7-c15b0c3c9ae3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan840@gmail.com", "Tan840", "hashed_password_840", null, false, false, "Tran840", null, "user", null, 0 },
                    { new Guid("e2a15d7c-c741-4890-9e9c-40fd16755de1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan535@gmail.com", "Tan535", "hashed_password_535", null, false, false, "Tran535", null, "user", null, 0 },
                    { new Guid("e336fc54-f001-4740-8b57-bc6b61baf74f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan28@gmail.com", "Tan28", "hashed_password_28", null, false, false, "Tran28", null, "user", null, 0 },
                    { new Guid("e34d8200-1841-4dbc-bf16-fd7223ec74e0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan790@gmail.com", "Tan790", "hashed_password_790", null, false, false, "Tran790", null, "user", null, 0 },
                    { new Guid("e3650927-0d8f-4bbf-a979-3716062befb2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan695@gmail.com", "Tan695", "hashed_password_695", null, false, false, "Tran695", null, "user", null, 0 },
                    { new Guid("e3785051-777d-4a93-aa38-71e799023477"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan969@gmail.com", "Tan969", "hashed_password_969", null, false, false, "Tran969", null, "user", null, 0 },
                    { new Guid("e389c55f-75c4-4418-a5e7-23d29436a991"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan90@gmail.com", "Tan90", "hashed_password_90", null, false, false, "Tran90", null, "user", null, 0 },
                    { new Guid("e3d59c8a-5bde-43a8-b524-9337f688d1d5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan776@gmail.com", "Tan776", "hashed_password_776", null, false, false, "Tran776", null, "user", null, 0 },
                    { new Guid("e3f112f9-c9c5-4776-95b5-f902a543a9cc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan608@gmail.com", "Tan608", "hashed_password_608", null, false, false, "Tran608", null, "user", null, 0 },
                    { new Guid("e4127cc8-d831-4162-8aa6-4dc0f20ab283"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan942@gmail.com", "Tan942", "hashed_password_942", null, false, false, "Tran942", null, "user", null, 0 },
                    { new Guid("e437a854-20f8-448a-9e14-542c2a39df9b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan345@gmail.com", "Tan345", "hashed_password_345", null, false, false, "Tran345", null, "user", null, 0 },
                    { new Guid("e43b573d-d70f-4839-85fa-b0c4c978ef27"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan985@gmail.com", "Tan985", "hashed_password_985", null, false, false, "Tran985", null, "user", null, 0 },
                    { new Guid("e477ac91-f88e-4a30-a9b9-5d9de5c05dd2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan230@gmail.com", "Tan230", "hashed_password_230", null, false, false, "Tran230", null, "user", null, 0 },
                    { new Guid("e47988f7-482d-4b60-9e90-4d3adad5c3bf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan542@gmail.com", "Tan542", "hashed_password_542", null, false, false, "Tran542", null, "user", null, 0 },
                    { new Guid("e4c01959-88f0-488f-9724-a31dba13a3d6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan594@gmail.com", "Tan594", "hashed_password_594", null, false, false, "Tran594", null, "user", null, 0 },
                    { new Guid("e4e041d2-83c1-4210-b7dc-8ab366cf9a95"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan696@gmail.com", "Tan696", "hashed_password_696", null, false, false, "Tran696", null, "user", null, 0 },
                    { new Guid("e5d0df4b-832d-4a47-9469-8e668cbec19e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan208@gmail.com", "Tan208", "hashed_password_208", null, false, false, "Tran208", null, "user", null, 0 },
                    { new Guid("e5eeae7a-6fc9-4e15-9371-794be3d47563"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan589@gmail.com", "Tan589", "hashed_password_589", null, false, false, "Tran589", null, "user", null, 0 },
                    { new Guid("e65858ea-3b65-478e-9620-f4a8c82c11ea"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan392@gmail.com", "Tan392", "hashed_password_392", null, false, false, "Tran392", null, "user", null, 0 },
                    { new Guid("e6ad7609-4aae-45c4-8a05-d1daf8d9f25f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan887@gmail.com", "Tan887", "hashed_password_887", null, false, false, "Tran887", null, "user", null, 0 },
                    { new Guid("e6e34e92-e024-46dc-80ca-655dd0510392"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan745@gmail.com", "Tan745", "hashed_password_745", null, false, false, "Tran745", null, "user", null, 0 },
                    { new Guid("e703d2c9-3b24-4d9c-9d8d-b85a834d5f5b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan596@gmail.com", "Tan596", "hashed_password_596", null, false, false, "Tran596", null, "user", null, 0 },
                    { new Guid("e773114e-1582-4298-ab06-bd4851404dce"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan901@gmail.com", "Tan901", "hashed_password_901", null, false, false, "Tran901", null, "user", null, 0 },
                    { new Guid("e79c3a1b-391a-49fe-97e2-c9a97d002f49"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan949@gmail.com", "Tan949", "hashed_password_949", null, false, false, "Tran949", null, "user", null, 0 },
                    { new Guid("e7bbd4da-472c-45e6-a8da-35ed241c66da"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan819@gmail.com", "Tan819", "hashed_password_819", null, false, false, "Tran819", null, "user", null, 0 },
                    { new Guid("e8538ff1-b596-4780-8e08-79753223865a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan174@gmail.com", "Tan174", "hashed_password_174", null, false, false, "Tran174", null, "user", null, 0 },
                    { new Guid("e85f8160-bcb7-4d2e-9358-cdc87c97a84c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan135@gmail.com", "Tan135", "hashed_password_135", null, false, false, "Tran135", null, "user", null, 0 },
                    { new Guid("e8a85962-883f-40b8-b8b4-051e7fce7e1f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan787@gmail.com", "Tan787", "hashed_password_787", null, false, false, "Tran787", null, "user", null, 0 },
                    { new Guid("e91e6584-c7b6-417c-8f89-0b96af655fce"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan815@gmail.com", "Tan815", "hashed_password_815", null, false, false, "Tran815", null, "user", null, 0 },
                    { new Guid("e921d878-e918-4ba9-8641-f289c8f9e581"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan9@gmail.com", "Tan9", "hashed_password_9", null, false, false, "Tran9", null, "user", null, 0 },
                    { new Guid("ea0e8335-1fd6-49a8-8145-7e5f45ef8b21"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan298@gmail.com", "Tan298", "hashed_password_298", null, false, false, "Tran298", null, "user", null, 0 },
                    { new Guid("ea2b678b-3a1a-44e5-803f-ab806dd4f194"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan111@gmail.com", "Tan111", "hashed_password_111", null, false, false, "Tran111", null, "user", null, 0 },
                    { new Guid("ea83ff33-8207-42cc-b20d-5fa17f0cdd25"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan83@gmail.com", "Tan83", "hashed_password_83", null, false, false, "Tran83", null, "user", null, 0 },
                    { new Guid("eaf281d9-fe4f-421b-8fd6-afecf504d9c5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan744@gmail.com", "Tan744", "hashed_password_744", null, false, false, "Tran744", null, "user", null, 0 },
                    { new Guid("eb426f65-f4dc-48da-bde0-98e0ac157649"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan784@gmail.com", "Tan784", "hashed_password_784", null, false, false, "Tran784", null, "user", null, 0 },
                    { new Guid("eb91d114-1599-4375-99a9-a677a12b5a9f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan988@gmail.com", "Tan988", "hashed_password_988", null, false, false, "Tran988", null, "user", null, 0 },
                    { new Guid("ebcdd3df-6154-4e6d-9b3b-4617af60a3af"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan707@gmail.com", "Tan707", "hashed_password_707", null, false, false, "Tran707", null, "user", null, 0 },
                    { new Guid("ebd90765-7ad3-4f7f-a60a-295b28a8c1e7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan86@gmail.com", "Tan86", "hashed_password_86", null, false, false, "Tran86", null, "user", null, 0 },
                    { new Guid("ec04bfc0-31c1-40f4-b055-6f1713b1fae9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan391@gmail.com", "Tan391", "hashed_password_391", null, false, false, "Tran391", null, "user", null, 0 },
                    { new Guid("ec7e6eca-6a08-44ec-bb2e-b0e4ae11614f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan965@gmail.com", "Tan965", "hashed_password_965", null, false, false, "Tran965", null, "user", null, 0 },
                    { new Guid("ecb8a3cd-2bd9-48d3-820d-812d01055cc3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan51@gmail.com", "Tan51", "hashed_password_51", null, false, false, "Tran51", null, "user", null, 0 },
                    { new Guid("ecd72f30-0e44-472b-be23-b40b21a815d6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan50@gmail.com", "Tan50", "hashed_password_50", null, false, false, "Tran50", null, "user", null, 0 },
                    { new Guid("ece20912-1f9d-4d2f-a18c-c5fb41676802"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan416@gmail.com", "Tan416", "hashed_password_416", null, false, false, "Tran416", null, "user", null, 0 },
                    { new Guid("ece9a26f-48d5-486f-8c11-d345adf055f4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan756@gmail.com", "Tan756", "hashed_password_756", null, false, false, "Tran756", null, "user", null, 0 },
                    { new Guid("ed93f135-e7d7-4923-994d-49b66a6df27b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan364@gmail.com", "Tan364", "hashed_password_364", null, false, false, "Tran364", null, "user", null, 0 },
                    { new Guid("edcfe7d9-2c44-4b02-b4cd-952dd8cb80c3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan267@gmail.com", "Tan267", "hashed_password_267", null, false, false, "Tran267", null, "user", null, 0 },
                    { new Guid("edd99abc-75af-4fa2-93cb-7387e3123379"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan287@gmail.com", "Tan287", "hashed_password_287", null, false, false, "Tran287", null, "user", null, 0 },
                    { new Guid("edef6402-0abf-43b2-b295-a9fc069df3b2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan736@gmail.com", "Tan736", "hashed_password_736", null, false, false, "Tran736", null, "user", null, 0 },
                    { new Guid("ee2a5159-e549-417c-bc62-3f19fd7a720d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan139@gmail.com", "Tan139", "hashed_password_139", null, false, false, "Tran139", null, "user", null, 0 },
                    { new Guid("ee44555e-5642-4534-809b-e90708bcf41b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan39@gmail.com", "Tan39", "hashed_password_39", null, false, false, "Tran39", null, "user", null, 0 },
                    { new Guid("ee457275-ff83-4e10-b981-d0a6c08ced7c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan698@gmail.com", "Tan698", "hashed_password_698", null, false, false, "Tran698", null, "user", null, 0 },
                    { new Guid("ef72c1e0-805c-43c8-bd54-93fc03f697bc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan727@gmail.com", "Tan727", "hashed_password_727", null, false, false, "Tran727", null, "user", null, 0 },
                    { new Guid("efd03f5d-6c4a-48fc-9f44-6ebe85e48b59"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan340@gmail.com", "Tan340", "hashed_password_340", null, false, false, "Tran340", null, "user", null, 0 },
                    { new Guid("efd38e4b-cf05-4fd9-a222-1b42212a1815"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan785@gmail.com", "Tan785", "hashed_password_785", null, false, false, "Tran785", null, "user", null, 0 },
                    { new Guid("f0033737-d423-45d6-bbc7-c275832c08cd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan15@gmail.com", "Tan15", "hashed_password_15", null, false, false, "Tran15", null, "user", null, 0 },
                    { new Guid("f009e837-6fec-47be-8a0f-131ab2c16779"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan870@gmail.com", "Tan870", "hashed_password_870", null, false, false, "Tran870", null, "user", null, 0 },
                    { new Guid("f0183ddf-de95-4ee5-9070-85f234adbcaf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan360@gmail.com", "Tan360", "hashed_password_360", null, false, false, "Tran360", null, "user", null, 0 },
                    { new Guid("f01e2e6d-76cd-44be-bf59-a575696f41ab"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan962@gmail.com", "Tan962", "hashed_password_962", null, false, false, "Tran962", null, "user", null, 0 },
                    { new Guid("f11e797c-1961-401e-a79f-9549db8cd811"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan769@gmail.com", "Tan769", "hashed_password_769", null, false, false, "Tran769", null, "user", null, 0 },
                    { new Guid("f11f08f0-7593-4a0b-86a4-acb442a225d4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan496@gmail.com", "Tan496", "hashed_password_496", null, false, false, "Tran496", null, "user", null, 0 },
                    { new Guid("f12ecffe-f9d5-40c2-a3d4-f688d82bc786"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan429@gmail.com", "Tan429", "hashed_password_429", null, false, false, "Tran429", null, "user", null, 0 },
                    { new Guid("f16574c0-55a4-4a9a-a546-1b3e7999313e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan483@gmail.com", "Tan483", "hashed_password_483", null, false, false, "Tran483", null, "user", null, 0 },
                    { new Guid("f1821894-22d7-4061-aef8-329b4cf30c75"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan215@gmail.com", "Tan215", "hashed_password_215", null, false, false, "Tran215", null, "user", null, 0 },
                    { new Guid("f1a126ca-0cc7-430e-a2df-3ba6c4526d0a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan510@gmail.com", "Tan510", "hashed_password_510", null, false, false, "Tran510", null, "user", null, 0 },
                    { new Guid("f1aac6ae-4f66-4a7a-b4db-c0e2ed7fe27b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan523@gmail.com", "Tan523", "hashed_password_523", null, false, false, "Tran523", null, "user", null, 0 },
                    { new Guid("f20678d0-0e1a-4723-9c94-c5b7936e93aa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan489@gmail.com", "Tan489", "hashed_password_489", null, false, false, "Tran489", null, "user", null, 0 },
                    { new Guid("f2381451-d675-4d25-8c25-316750992a37"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan137@gmail.com", "Tan137", "hashed_password_137", null, false, false, "Tran137", null, "user", null, 0 },
                    { new Guid("f24fcbb4-2473-41a7-a717-0d410ea71fe3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan421@gmail.com", "Tan421", "hashed_password_421", null, false, false, "Tran421", null, "user", null, 0 },
                    { new Guid("f307e141-2a25-4370-9d71-347c669d2cf0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan778@gmail.com", "Tan778", "hashed_password_778", null, false, false, "Tran778", null, "user", null, 0 },
                    { new Guid("f3214415-1cf0-4f0f-896f-1e6c1842eb8e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan677@gmail.com", "Tan677", "hashed_password_677", null, false, false, "Tran677", null, "user", null, 0 },
                    { new Guid("f3557ba5-4ab9-4a66-99ae-5a001dde3bf9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan896@gmail.com", "Tan896", "hashed_password_896", null, false, false, "Tran896", null, "user", null, 0 },
                    { new Guid("f3812a7b-2d1d-485f-b75a-b1ad741e95a5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan805@gmail.com", "Tan805", "hashed_password_805", null, false, false, "Tran805", null, "user", null, 0 },
                    { new Guid("f38b50ed-8298-4aa4-ac48-6a6903f4db8c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan795@gmail.com", "Tan795", "hashed_password_795", null, false, false, "Tran795", null, "user", null, 0 },
                    { new Guid("f394339d-3470-444a-b7a1-f9127f6dd9ec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan628@gmail.com", "Tan628", "hashed_password_628", null, false, false, "Tran628", null, "user", null, 0 },
                    { new Guid("f3dfe64a-04bc-4355-b5c0-6f10bfa5b82d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan967@gmail.com", "Tan967", "hashed_password_967", null, false, false, "Tran967", null, "user", null, 0 },
                    { new Guid("f3f2b84f-7cd5-4088-93d7-6ef661e988c6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan212@gmail.com", "Tan212", "hashed_password_212", null, false, false, "Tran212", null, "user", null, 0 },
                    { new Guid("f408cdfe-3bbc-499e-88ac-448a5ce650ac"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan478@gmail.com", "Tan478", "hashed_password_478", null, false, false, "Tran478", null, "user", null, 0 },
                    { new Guid("f40bec3e-eab9-45a0-a95b-358058533606"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan91@gmail.com", "Tan91", "hashed_password_91", null, false, false, "Tran91", null, "user", null, 0 },
                    { new Guid("f410cf65-5369-4dd4-9acb-b1a66bcd47cc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan58@gmail.com", "Tan58", "hashed_password_58", null, false, false, "Tran58", null, "user", null, 0 },
                    { new Guid("f4617fdd-93c4-442e-83cc-b36437677804"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan413@gmail.com", "Tan413", "hashed_password_413", null, false, false, "Tran413", null, "user", null, 0 },
                    { new Guid("f4e8671f-856b-4cd9-bf3b-e09a6d68f9df"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan103@gmail.com", "Tan103", "hashed_password_103", null, false, false, "Tran103", null, "user", null, 0 },
                    { new Guid("f51a3a4b-3fe5-46bb-b45c-ff7313e52071"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan849@gmail.com", "Tan849", "hashed_password_849", null, false, false, "Tran849", null, "user", null, 0 },
                    { new Guid("f53c83d0-0ad9-4222-8835-2360f28b8b9c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan235@gmail.com", "Tan235", "hashed_password_235", null, false, false, "Tran235", null, "user", null, 0 },
                    { new Guid("f5a12e6c-397b-484d-a2a5-06f48e7ddf8a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan224@gmail.com", "Tan224", "hashed_password_224", null, false, false, "Tran224", null, "user", null, 0 },
                    { new Guid("f60b4de3-48fd-4ac3-8ff1-fe97cab92a7a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan929@gmail.com", "Tan929", "hashed_password_929", null, false, false, "Tran929", null, "user", null, 0 },
                    { new Guid("f610cfc6-93fd-4cd9-b2f4-70deb30aec50"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan664@gmail.com", "Tan664", "hashed_password_664", null, false, false, "Tran664", null, "user", null, 0 },
                    { new Guid("f6132098-b244-4df8-a242-a459803d48b4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan463@gmail.com", "Tan463", "hashed_password_463", null, false, false, "Tran463", null, "user", null, 0 },
                    { new Guid("f6ce01ef-8610-4182-b54c-890f453dd1a4"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan955@gmail.com", "Tan955", "hashed_password_955", null, false, false, "Tran955", null, "user", null, 0 },
                    { new Guid("f731f8c2-e9ad-4b10-8a38-8346c2ddfd77"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan188@gmail.com", "Tan188", "hashed_password_188", null, false, false, "Tran188", null, "user", null, 0 },
                    { new Guid("f76d8934-9a3f-412e-843e-629c6718b294"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan260@gmail.com", "Tan260", "hashed_password_260", null, false, false, "Tran260", null, "user", null, 0 },
                    { new Guid("f807203d-d634-496a-9e10-971c4b41aea1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan454@gmail.com", "Tan454", "hashed_password_454", null, false, false, "Tran454", null, "user", null, 0 },
                    { new Guid("f913f0b4-ad3d-4934-865b-f96f88ecc3c1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan11@gmail.com", "Tan11", "hashed_password_11", null, false, false, "Tran11", null, "user", null, 0 },
                    { new Guid("fa1be520-cdfb-4a3a-928a-0bb95fde7e4c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan315@gmail.com", "Tan315", "hashed_password_315", null, false, false, "Tran315", null, "user", null, 0 },
                    { new Guid("fa785786-cf3b-40df-a7b5-cb92822cc7bf"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan635@gmail.com", "Tan635", "hashed_password_635", null, false, false, "Tran635", null, "user", null, 0 },
                    { new Guid("fa7918ae-34ca-481d-a2ca-e6ccccdaaf41"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan393@gmail.com", "Tan393", "hashed_password_393", null, false, false, "Tran393", null, "user", null, 0 },
                    { new Guid("fab0ef5b-21d4-4451-9481-4874ec9330ec"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan692@gmail.com", "Tan692", "hashed_password_692", null, false, false, "Tran692", null, "user", null, 0 },
                    { new Guid("faf5be74-064f-4290-8499-a95cf130798c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan615@gmail.com", "Tan615", "hashed_password_615", null, false, false, "Tran615", null, "user", null, 0 },
                    { new Guid("fb3e7af3-5501-44d0-8c03-e7a8d5ba77bb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan444@gmail.com", "Tan444", "hashed_password_444", null, false, false, "Tran444", null, "user", null, 0 },
                    { new Guid("fb6ca9c8-612a-4324-b8a3-8e0dcbbfa157"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan475@gmail.com", "Tan475", "hashed_password_475", null, false, false, "Tran475", null, "user", null, 0 },
                    { new Guid("fb740ee6-e6ea-4747-b7d5-0665a285ce5a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan486@gmail.com", "Tan486", "hashed_password_486", null, false, false, "Tran486", null, "user", null, 0 },
                    { new Guid("fb79138a-3cdc-474e-abe4-9d61836165b3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan853@gmail.com", "Tan853", "hashed_password_853", null, false, false, "Tran853", null, "user", null, 0 },
                    { new Guid("fbc53cec-729d-48d3-8ca4-ef38b747548c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan27@gmail.com", "Tan27", "hashed_password_27", null, false, false, "Tran27", null, "user", null, 0 },
                    { new Guid("fc0ba793-c672-46ba-a2b5-eb18c5e365bb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan432@gmail.com", "Tan432", "hashed_password_432", null, false, false, "Tran432", null, "user", null, 0 },
                    { new Guid("fc147fe1-4d70-43d7-ae14-4480e4ccc363"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan389@gmail.com", "Tan389", "hashed_password_389", null, false, false, "Tran389", null, "user", null, 0 },
                    { new Guid("fc29324f-f5a2-4edf-824d-21aa26ed10c0"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan154@gmail.com", "Tan154", "hashed_password_154", null, false, false, "Tran154", null, "user", null, 0 },
                    { new Guid("fc84ba97-6f91-4dc4-9f75-37e327341d8a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan78@gmail.com", "Tan78", "hashed_password_78", null, false, false, "Tran78", null, "user", null, 0 },
                    { new Guid("fcef7568-8382-4837-805d-8d2d6784c611"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan577@gmail.com", "Tan577", "hashed_password_577", null, false, false, "Tran577", null, "user", null, 0 },
                    { new Guid("fd2dfff4-7370-46d3-8b9b-81d57b4ce286"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan223@gmail.com", "Tan223", "hashed_password_223", null, false, false, "Tran223", null, "user", null, 0 },
                    { new Guid("fd79f502-8f9c-4006-b5fa-0990906ed57a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan730@gmail.com", "Tan730", "hashed_password_730", null, false, false, "Tran730", null, "user", null, 0 },
                    { new Guid("fd8d01f6-3ce2-49c6-9e11-da05002491eb"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan919@gmail.com", "Tan919", "hashed_password_919", null, false, false, "Tran919", null, "user", null, 0 },
                    { new Guid("fd9f009f-3086-49c1-9c22-bb3ff3f6eeaa"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan714@gmail.com", "Tan714", "hashed_password_714", null, false, false, "Tran714", null, "user", null, 0 },
                    { new Guid("fe203d76-23dd-40ed-b97f-2fbae771eb53"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan280@gmail.com", "Tan280", "hashed_password_280", null, false, false, "Tran280", null, "user", null, 0 },
                    { new Guid("febaab9c-545b-4c98-8ee4-6b6b244d5889"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan653@gmail.com", "Tan653", "hashed_password_653", null, false, false, "Tran653", null, "user", null, 0 },
                    { new Guid("fef66d55-d1b6-4393-ac27-f8cff7136b7c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan908@gmail.com", "Tan908", "hashed_password_908", null, false, false, "Tran908", null, "user", null, 0 },
                    { new Guid("ff4d0e04-6ef1-4700-8e1c-511c47fdb7c1"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan828@gmail.com", "Tan828", "hashed_password_828", null, false, false, "Tran828", null, "user", null, 0 },
                    { new Guid("ff56394f-4ded-4b16-aa8e-5991577ae624"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan430@gmail.com", "Tan430", "hashed_password_430", null, false, false, "Tran430", null, "user", null, 0 },
                    { new Guid("ff6b6991-d1b5-4e1f-815a-2f9443b13be9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan806@gmail.com", "Tan806", "hashed_password_806", null, false, false, "Tran806", null, "user", null, 0 },
                    { new Guid("ff98ba69-e208-4d2b-8efd-ed24d9fa0a33"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan658@gmail.com", "Tan658", "hashed_password_658", null, false, false, "Tran658", null, "user", null, 0 },
                    { new Guid("ffaec7aa-a072-4f48-8de3-7126d56ffa74"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan72@gmail.com", "Tan72", "hashed_password_72", null, false, false, "Tran72", null, "user", null, 0 },
                    { new Guid("ffb2a892-0c2e-4590-8cbc-a605444efecd"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Tan995@gmail.com", "Tan995", "hashed_password_995", null, false, false, "Tran995", null, "user", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ParentId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("002d09be-fa23-45ed-aec7-b43640a2ec0e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 897", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("00ca7576-8d1c-48f1-811a-e6d43e9c930d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 421", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("0104b219-4cc0-42e6-80aa-f78efa2a11a5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 290", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("012f8646-258f-4666-a8c2-941f61003d09"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 452", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("01bb5261-f9df-4161-925e-625dc8247f5a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 48", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("01ce4023-e408-480a-b77b-0f2cf1df225a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 525", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("022474b2-769b-4a68-86d3-dfb283e2cff7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 145", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("022fa5d1-ed98-46b7-8693-aab179ae5b22"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 707", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("026e9d20-afb0-4b85-a25a-6c0af7350a06"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 669", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("027cd481-bc33-4014-bc73-f1b61ebd5b90"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 786", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("02be543e-5971-442f-90e9-40bae94139ed"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 508", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("02e40eb0-f947-45a7-80be-dc929979692e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 410", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("0307710b-5ea9-4841-87df-dc5e281cb0ee"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 97", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("034914c3-bfe5-47ad-8bc4-6989a72bd5d0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 193", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("034e0dad-f7a6-4792-8ef8-e141dc6d151d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 413", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("034ed9e3-06e0-42c8-ab74-fb6107e8aafe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 350", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("0370fab7-c99c-4dc1-842f-d25a42872e13"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 195", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("038985a1-dd32-4c17-854d-bc44e3bc4532"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 134", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("03c18ae4-07e8-4e32-af26-0a636b4ba278"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 514", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("03eec2f1-643c-451a-8a10-703672313063"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 925", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("03fa75d6-7c27-4ac6-98b9-eb8b1f66f438"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 266", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("041456a6-7778-4ae9-9702-6170d5b2a600"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 451", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("0482a443-c571-48b8-958f-e58932f5c1d5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 633", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("048db737-a638-49dd-b583-6467ddab01d6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 162", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("04af38b0-1cba-4bdb-857e-0076926e9e1d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 857", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("04c58f7f-880d-4a41-851c-140906940e4e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 627", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("04f89fba-49dd-4d13-bae7-5332e1568fbf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 845", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("0517ad35-5fff-4fc5-8930-88f5d199fc97"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 578", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("05211675-c634-442a-bed3-62ecf13d2649"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 946", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("0523bcd9-cf79-459a-84e2-a3e5feed9fb0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 455", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("053d3d9b-5312-4385-a7bf-d9cd3fcc320a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 485", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("0572b0ef-7cb4-4a7b-b106-294f86031f73"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 908", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("05849444-1de1-4c96-b25f-822cb5e54e36"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 689", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("05852635-abca-4d43-95a3-964db02e6f48"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 956", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("060da8fc-9c75-4620-84fb-11075c20c134"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 226", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("0610ca4a-d568-4614-a955-34d25e9119ab"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 951", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("062b62c2-4e42-46ce-8410-17d8f11eb052"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 111", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("063fd565-48ed-42ae-8be2-963cc687caca"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 353", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("067c3ef5-9f1e-4a40-9e46-27703d85989a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 316", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("06f20613-13dc-4059-8da3-56d23c178e15"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 630", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("07c078f3-0ac2-4837-97c3-bf81a7ad12aa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 557", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("080d9c02-10dc-478c-b986-c8d364f41bc3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 358", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("089a629b-6221-4535-bf15-4a95ea10ceac"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 889", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("08e205ef-9e3d-469e-8314-fc563033c1a0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 864", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("09227b11-95d9-4e02-9b41-7fff2a63e367"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 244", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("0949416b-21a8-4dfc-a1b4-61b8427b231a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 33", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("0971641d-dd80-4f6e-8e69-e9385f51a09f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 784", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("09dc57d2-4fa5-418b-a93e-8c10efd971c1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 526", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("09e3dd47-09d5-4c6d-9463-88e100c3ef08"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 961", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("0a032d35-7908-4f8b-b52a-7cc45e646470"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 715", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("0ac00934-f7ec-4e35-8e3d-3fe4bf6a4a04"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 355", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("0b00e6cf-cf9f-4d28-bdd1-fe92b3840984"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 401", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("0b0526ef-f37b-4fbe-8f95-9211144c90cc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 662", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("0b13c263-bb3b-4496-8b83-9fed9972c06c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 391", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("0b21965c-465c-4615-afa2-ba313e87da93"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 52", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("0b47fd81-eb6e-49a3-b532-f3fdbf3d5942"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 757", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("0bd0302a-60be-4f1c-bb3a-d8477cccb260"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 844", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("0cd592fe-53f1-402b-826d-e525e47a28eb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 506", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("0d1809b1-a30a-40b5-8950-dcf04a910da0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 673", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("0d3ad4b6-c33c-4f0f-b04b-275b832eff3c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 19", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("0d70abf1-4992-4002-b54a-c88a7aa6d5aa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 722", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("0d854b28-dd64-4c58-bd64-ac246fe2e35d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 487", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("0db84eec-aee1-45a8-b61e-4364a69d5b24"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 246", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("0e090664-d4cb-4333-ba07-d7b05368775d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 418", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("0e0c0b39-893d-43b0-91c3-e2fb0a5423f4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 1", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("0e13d1c5-f0f1-48d1-8f8f-f5a27d969518"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 729", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("0e27d1d8-92cb-4925-8850-714c000ccdae"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 942", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("0ed4bdf1-526a-4f58-b92a-3db869ad78ca"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 212", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("0ef15c3d-7c64-400a-a6bb-4c08e9ad64fe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 399", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("0eff5908-11eb-42a8-9a40-b5b55fde2d3a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 863", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("0f36acc9-2725-4358-86e8-627436792010"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 205", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("0f3b34af-56fd-48da-b9ae-1ad1113fdd1e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 359", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("0f528548-d642-42e5-9013-5a22baec909c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 824", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("102bef0a-5288-4a5c-b206-7d0c0049e16a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 229", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("102e2643-8dfc-4b8c-9a63-019572744d3a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 14", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("10aa10fb-f559-48ff-8dcc-8d8d5b611f54"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 980", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("10b6acdc-d755-44f9-89d6-687c45545f7c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 808", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("10c421db-41e9-4455-a1c7-852f02600d0c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 983", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("11003beb-a39c-470b-9ea3-d24c91951e19"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 918", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("1120740c-3bc1-4e3c-84c8-f736038bd27d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 954", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("117bc837-e4ea-4d32-b7d2-248b630b4867"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 473", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("11a16c60-8670-48ff-9dde-3e68e2d92be8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 365", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("11e75e02-fb4c-4fb5-a375-3da2047c8b9a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 785", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("120dea3b-b12b-469f-b675-9da1ba926e20"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 682", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("1251edcf-c111-46d8-b3b4-3b7c0b9576d0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 826", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("1323b809-76a5-466a-8d0f-1d60c26ec7f1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 656", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("137fe095-af15-48d8-9dec-71dcb9c6ad57"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 950", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("13e486e6-f309-42fa-ac45-af0053c17cc2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 465", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("14092c31-3c31-4918-82c8-c607ff2591da"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 723", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("1437b43d-1804-4609-ab7c-8f9f9fccf66a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 582", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("143eee0c-df42-4f13-8bb7-d8435d7cef5a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 364", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("14e8ca0f-d896-4ebd-9fca-bc2666058ab5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 357", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("14eabc18-3b1a-4769-b25c-4f0be5c0f59d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 962", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("150668b2-7fc3-4380-b1f6-199b2d149b74"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 870", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("153cb911-67c2-4fa6-bc13-8e0397d2b622"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 745", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("158818ea-aa0a-473f-8d92-9e6c94043f9c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 884", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("1594e221-e773-433e-8231-19f2247788c2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 511", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("15bc1a99-8ccf-4f18-ab5d-19720a53a25a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 121", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("1633727b-58bc-40de-a5de-9f6942edfb7b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 496", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("178cae99-7f34-4660-9c64-42b6ae240b13"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 109", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("17c98460-54f7-4c51-a0e8-0bd0c1af39bd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 650", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("181e60ad-654c-486e-8c9f-37176fd42e1b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 339", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("1923d9ec-f4e8-404e-8fc4-0835a2fc8638"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 456", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("19ceae0e-f2ec-4527-a8b6-0b40abceaa15"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 176", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("19f758a3-74ae-45e6-8732-f2a1cf30ce61"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 262", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("1a057eae-2162-436b-8b7d-1d51364018ba"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 405", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("1a23c6f2-23bd-4275-907b-ea7d8a673a95"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 57", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("1a39d401-6c78-477f-805c-b66c91998463"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 278", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("1a803f77-a00d-499e-b73a-e389fc3a5558"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 507", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("1adccc64-2561-46b6-9de3-09d9ddb35cd0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 644", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("1b097e76-cbd0-415d-9050-931cae9e33ac"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 116", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("1b15ddfd-6161-47e4-af7b-9f6a81f3dab6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 596", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("1b2dc661-3cdb-481b-ba59-78308423f044"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 777", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("1b3ccdad-6a65-48ad-b3c1-f28e0bbdd610"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 383", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("1b913dec-f792-4964-935e-5e468be28942"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 131", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("1b943557-bd0f-4d62-9c87-f714a8dda80b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 232", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("1bc441e0-0848-4384-ad82-aec625b233ff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 721", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("1c055ffb-1a43-44f7-9a6d-5f5d2d615bbf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 732", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("1c3c408f-f627-40a0-aaf6-f9cd3e70460f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 449", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("1c5849fc-ff9b-41c9-bdb0-f3bc8041374e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 965", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("1c6395c7-5fdf-4bfb-aba7-d75dd5db7c49"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 247", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("1ca3dfa4-5bad-48b5-bc57-055b9ce71f77"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 299", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("1cab5af3-d59f-4260-bc09-c04d1f1b182e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 628", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("1cb9ffee-d36e-4d4d-9d0e-d2e043a18efd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 585", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("1ce7780f-4d80-46e3-a9b5-fb82181e5d48"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 2", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("1d16f88d-983a-4493-84bd-9d71c284037b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 190", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("1d50c1c0-f84f-42a4-a979-56906c639b83"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 270", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("1db101eb-eccb-4809-b11c-922c8dad36c3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 168", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("1e0cf29f-54ee-4d9e-bf36-08f5a72b555e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 767", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("1e2d0ca8-554f-45c3-aa81-2e69561d9b6e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 875", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("1ef2f2f7-edc2-4196-8ec2-3158cffc13de"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 727", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("1f162684-35e9-4554-8ea0-0743dff6c53b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 282", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("1f7f3140-1c7e-4b42-85cf-4bb4940f91d9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 970", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("1fa903e3-9b6d-4742-9f88-f430c9dd06ca"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 811", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("1fc407a6-55f4-4cfb-a1f4-cd0330a177b1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 464", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("20004069-2728-4f8e-a84c-9e8c26f6a5c7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 850", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("2011b069-554b-48cd-86d5-a4b6f59cad50"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 762", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("2048cc30-6cd7-4622-927f-f162da7a8de3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 110", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("204d4257-2413-43a7-b009-fd73a0d856d3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 294", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("2075a19b-1702-4e9b-9966-1a91ddf8db4d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 822", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("20a039b5-92fb-4072-a590-0eb5a86f6740"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 139", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("20c32a96-2566-4592-96cf-3c0c5ef6d5f9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 588", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("20d2e9f2-4f18-4fd6-b68c-171f55a56372"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 484", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("20e2bb49-36a8-4cf0-b068-b3f834a4f13d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 678", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("20fad80d-dc99-41d9-81cf-6b3d9eef1c63"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 792", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("214a39a4-cb25-41ce-b482-5320c6716462"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 971", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("214b5122-ecfe-454b-8c5b-9139e039671a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 532", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("21d73996-08a2-44fb-96aa-9aeb0592ee4e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 862", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("21e7aeb6-4c13-4c07-8dae-ddfc23846131"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 263", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("223b29a2-080e-4665-bfd5-dbdcc02c7d73"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 658", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("22d84fda-694d-4be0-aa1a-0709730dbfdd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 998", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("22e5803d-7d04-4f3f-9cf5-86b297471e99"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 308", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("22f2c09b-29fc-471e-90c0-1dae4b1e612c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 774", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("230f0603-1e84-4949-8dd7-ecf083291645"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 876", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("233ad97d-a09b-4052-8b23-f0f07e4c62c2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 95", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("239b882a-4d14-4f05-bc55-e81415f06fa7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 572", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("23ab6afc-b6ae-40ce-9b98-555cc6871518"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 34", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("2406e26b-f596-46ec-8f4a-c3b6c8d4e9fc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 67", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("2435442c-16a7-4d35-8d88-a0f5877d1d6e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 565", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("246b0a91-0ddc-4981-b28d-cdb9c2acd591"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 182", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("24ddb89a-b626-4ad1-a0b9-4441692aa613"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 217", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("2534e1e0-aed0-491d-a0d8-4317de332722"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 46", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("25945f54-b04d-4fe0-bc70-e05b112aeea0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 443", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("259e9745-8000-462b-9366-711729c33f3e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 305", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("25a29b53-27ca-4bda-9b40-faf9d2f576b5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 71", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("25fbfa57-cdbe-40d8-9543-2c92a54e3362"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("2668f63e-d698-461a-911f-541088ad0cca"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 665", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("26ee9590-e5bb-4a8c-a85e-d17cfa514574"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 500", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("26fd4992-94bd-477e-aa1d-8ed0d0519aa1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 236", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("273c851d-5538-4399-8136-2c354f9668d2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 512", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("2793a669-7ded-4be1-98d5-e928c7d4e8b8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 827", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("27c878b5-d109-4b90-9c25-f2290d59bcea"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 474", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("27e2e18a-4682-4d80-bbfa-b200262cb2d8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 519", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("27e3d360-49a8-468f-80b6-4dbd0559c8fe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 645", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("28c43900-f1a8-442a-a5f8-af5b16a59f57"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 112", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("28e3f931-986f-431b-834f-2a8107cbcb7e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 122", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("29134198-0af8-4461-b606-8adb67c83ca2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 672", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("293c98ce-7f6f-4f75-8baa-efee00978e8a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 467", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("295aa6f5-4eab-4fcd-8ef7-0974010da830"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 635", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("29dce494-2e62-4036-a11e-3781c2a7bb66"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 896", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("29eb0312-4d50-4830-bee7-8dfdea6e170d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 437", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("2a411f9f-ce9a-4d7e-9348-17d5ea331973"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 238", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("2a53cb44-dfa0-4637-8f5a-84b6a9fb50ce"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 7", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("2b033441-b8f2-4d0a-acf3-a2e11edd245c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 253", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("2b214576-1bab-4632-85c3-f497145c39f3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 580", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("2b6ca37b-98f2-4214-83b9-e5a38053c9d5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 696", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("2c27e06b-923f-4e20-85aa-2e91b13ec66d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 894", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("2c4df7d5-172c-4b6b-bc43-ab697bd3d778"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 143", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("2c66328c-5ed2-466b-a6ac-bff03c1c5ba7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 250", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("2c74b000-5641-4e5d-9ef1-e592cdef5afb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 218", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("2d259514-d0e0-4fe1-819b-b93a65cf6d6b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 126", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("2d29e42c-2756-421e-81ab-d2de45e905a7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 224", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("2d4b6dbd-0bd1-460a-ba05-454c23ffb4ea"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 16", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("2dcab973-1a7a-4e0d-9caf-2f347c17cf45"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 890", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("2dd4d3ac-be51-4717-a8f2-939241f3d639"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 893", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("2dfb03ff-0edd-477b-b55a-9863df7e441c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 646", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("2e60a12a-f98c-4201-9195-d7137a11e343"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 868", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("2e8e7876-f930-4faa-8657-e46f52807b38"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 273", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("2eb91d8c-c4ab-4bf5-a546-1503b0362d28"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 936", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("2fc2cfd9-653d-4214-9384-7dcda1727d30"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 836", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("300d1031-f663-4ece-9c5d-ca3c3eda752c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 866", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("3056a2b9-2e6e-4241-a071-df090e3a1e0b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 409", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("307c99fa-5707-4025-b901-0817f374f204"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 462", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("308bb737-5876-44af-b2cf-07cb9188d958"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 83", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("30917b6d-49f7-45aa-bf01-c1c8076aac05"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 118", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("30ac0a75-bc04-471d-b243-18d00903c7f8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 891", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("30b77dc7-db9e-4e5d-85ea-2574031491f0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 419", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("30d0ea2b-d378-4fdb-9952-9d44d754ac97"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 336", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("30e71711-cab3-4a4e-8237-4324b78c3002"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 424", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("32156bf2-b209-4761-930b-4c6697cf8dde"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 865", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("321df0d3-0598-444a-93e5-b06be7936c32"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 937", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("322c0a18-9046-44cf-b061-ca63db2cf641"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 352", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("325ab73c-5820-42db-8ddf-a0bd15902da0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 709", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("327c740e-7b44-4f0e-a12a-67bf48271cb9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 823", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("32fb1a6c-8c4d-4c3c-97f2-035198b6efd3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 82", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("333f0ace-8091-4cb3-af02-2b77fbe98019"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 815", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("33cf4cc6-dd8c-49cc-b2bf-4100df5cbac9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 579", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("34041cca-e3d8-446c-ac44-681a2e513e1d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 285", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("34599576-999a-40e0-9058-96b836451da5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 560", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("3475cb95-fa26-4a3a-883a-ee9e96128d66"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 841", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("3483bf4a-ad32-4d03-810c-4a9c5a0eaed1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 958", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("348fec03-d5bf-4216-8150-491f9ea54167"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 345", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("34c66037-5fdb-4da6-a0b7-f7044702b12f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 272", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("34d92463-9bc7-44a8-be78-d7bedc45aa65"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 200", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("3510962b-a9eb-4181-85ae-424ee3a80b91"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 765", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("351f5757-5620-4cd9-879c-4e72c579ef18"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 770", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("353ae88e-f5d2-4c6f-a633-7d4c642c3b11"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 814", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("3548cd7d-4ced-495c-92c6-14fa3140b957"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 356", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("356c2ff9-da49-4c5f-abe7-edd660ab01db"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 78", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("3590f789-b0c9-4ccb-8630-c3b4e357bcf6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 550", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("35bf2b97-66da-44c4-a79c-1d600dca02a6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 252", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("36102ee8-ce95-42b9-8b20-c18ed23640da"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 92", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("3617d1de-26b7-4452-84fd-df38cb457f12"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 407", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("3624ffd3-5b57-4879-ae3b-b6d35e6fc1b6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 330", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("36c18ba5-6f89-45ec-9961-33c01375ab3c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 561", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("371cd0a3-199a-4afe-aa8d-45dce185d4d3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 905", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("375c0def-0dfc-4f27-962a-ba99975fe4f6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 832", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("3760642f-83b9-4427-a774-9499a944b5ef"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 302", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("37dd5963-430a-47c4-b06a-05d7d0145917"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 694", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("37efe076-78f9-4762-97be-4c4c78b03374"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 620", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("3802aef7-4b44-424d-9b6a-7b4c41ed383f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 985", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("380a8b05-bdd1-4493-ac22-c43bf7cc617a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 77", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("38306984-108c-4fc5-94e6-bad90afd112d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 442", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("38ca35c4-9cb4-478b-8abf-de5a85687252"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 422", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("38e64781-f317-4180-a581-e485ee27cc48"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 906", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("392dd39b-1169-47be-a50a-27a16f2c580b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 528", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("3959e32b-7131-48cb-b6a9-2623837e357e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 529", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("3982699d-780d-4e7b-adab-3a0f0547e8b4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 45", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("3a231dd6-1086-4e02-bf45-016428502ebf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 395", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("3a43fa35-e0ec-4ef5-b2d1-52cda6f3827f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 412", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("3a6039b2-5f55-41a9-8f88-260379bb21f6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 685", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("3a7717bf-6835-4e79-8f59-4e2da9167b71"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 292", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("3a9f58bc-7559-4cb6-8478-c2550d262ca5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 314", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("3acd86d0-8aa6-4acc-a51c-27bc2159d03d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 281", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("3ba44478-756b-46db-a105-bc3b80b93569"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 142", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("3c2a5caa-a6ad-4b9f-9e24-a5105654e85d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 691", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("3c86c2bf-790f-49ee-a1e2-d83039c5644d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 591", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("3cf09d06-972a-4b01-b308-23f94a81bbfb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 98", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("3d447520-dd44-4e25-af22-67d836e53044"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 949", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("3d6e7f02-b77f-407b-a7d7-6329797c5af2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 404", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("3d7a01b8-3be2-4916-813c-5e1b673a5567"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 776", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("3db14ecb-bd5b-4b59-b811-bb63309766d6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 717", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("3e3558d4-64e2-47aa-b9f3-eba147e49ff4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 740", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("3e5b009c-f021-4230-a55b-b4dd45030a60"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 706", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("3e66ea42-5522-49e5-8ded-23d0143751d9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 37", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("3ea44795-2303-44d6-80c9-0da0d2a9ebd0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 518", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("3ec7467b-f167-423a-b812-145efb8429dd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 319", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("3ef20926-6d11-465e-b0ad-f7c5f05ed23f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 787", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("3f0e08cd-3887-4def-8cc8-6c8b67752b05"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 703", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("3f52d1c9-850e-4d70-9dd2-d704186deb60"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 169", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("3fbd2b9d-5ccc-4335-a6a6-f089dd7344fd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 124", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("4042c98d-8ee7-40e9-ae18-4ae7738ee755"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 173", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("4049d3a4-d58c-4092-9ea4-941c266c2a5c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 55", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("404dbf12-6335-44cd-80c1-1574592d4b5b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 375", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("40ce9d33-24c6-475b-95e6-4c8ab8ba855d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 403", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("40e736b3-1236-401d-9d18-103db06e819c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 795", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("423b4c60-25c9-43b2-91b9-a6dedf202a56"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 104", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("4269d14f-7770-4354-8aef-e9e6813cb676"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 989", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("42a3634a-d033-4ad6-9915-b829efd9435c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 877", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("42ca2935-70f6-465d-8aa4-217530940688"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 411", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("4385a525-3db0-4ff3-8e11-2e24ea08b280"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 293", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("43f2d122-3cb1-4cdc-91f6-bb0e2bfb853b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 991", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("4419d792-c88c-4cd0-845e-28658ab5f5af"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 821", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("444d5fad-1203-4465-90ca-2ec10099edef"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 416", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("445735a5-a375-4990-b2df-88a90d14b00e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 799", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("44731e7f-c583-4852-b501-c9d188163870"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 737", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("448a465e-1794-4724-b522-980188e9c912"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 8", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("44acc8ab-c51a-4272-9f69-ee31e2301a31"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 434", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("44fc0862-1ba1-4fc4-9853-ac3e2d45082e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 361", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("45f8715d-cc7f-4ce1-b13d-3def92822ff6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 680", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("46165c2d-0f4a-4b3c-bdf3-fb7281677af4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 513", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("461b9b84-e0b0-4d40-ab24-817b282efc72"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 167", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("4626fee4-446c-4a76-b6bd-2897d28fdeea"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 538", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("464102de-f157-44fa-a468-55e8a2aea6a7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 952", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("46548827-f3d0-4d5d-9c52-01c3654c204b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 616", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("46cc536c-84d5-448c-96d3-cc1f4ef9dbfa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 530", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("4714f976-a83b-4be1-a98f-109eb2170dcd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 146", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("472eab19-642c-476c-adab-94ed03821f16"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 344", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("47379400-5aee-4d93-844e-b372d1367dae"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 41", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("47780411-e9e8-424e-9553-ba98598d137a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 587", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("47930b66-cb3e-4e1b-a0a7-f860c6a7c7d6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 898", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("47b2f12f-edfa-497f-b8c7-b82f477a46e7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 551", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("47f973cd-c7bf-4009-846b-a851407a9734"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 880", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("485ada1b-7584-4e25-b9aa-bd5c414d5b7c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 558", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("487e4075-6aa5-4779-a76f-b005d8f82eeb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 75", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("488633d1-068c-4a3b-aebf-054c214d56b0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 711", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("488958ef-17f2-4e53-96df-976b17a3193e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 730", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("48cd4cc2-d4ce-4115-a158-20ec523ee2e8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 128", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("48e3da21-dea9-4329-9954-dd191783e8f6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 28", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("4921dc33-97fb-4198-9aa2-1910daa8358f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 903", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("49539d90-c139-48ae-9571-1484e3e929de"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 947", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("49609b95-bbd4-41d3-95fa-7ed84c17f4c1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 639", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("4976a06f-040f-47b1-adf5-a05f5cd407f5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 223", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("498088e7-2c0c-4eba-a058-426a6b647feb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 608", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("49e0051b-3a3d-46b1-88e7-072a2fe88438"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 755", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("49fb3d71-dc4d-4b6a-ba86-691a2374bd69"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 6", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("4a42aac6-aeef-4d08-b5a6-689c3f4825de"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 681", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("4a741af9-f10c-4195-ac99-45488bd97aac"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 648", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("4b0a246a-ba5a-4217-948a-5c394c9af7be"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 670", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("4b23517f-7d2b-449d-8bef-33599e9e810b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 341", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("4b632ea0-1181-48c0-a2b8-528833fa1964"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 311", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("4b7fc85e-abd3-4b75-a6c4-2773424d2753"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 230", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("4b8776f7-5af5-488b-8a64-dcdada8d6520"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 38", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("4bb1fe38-d96d-4362-ae66-c47c06ab84f9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 533", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("4c283f0d-aae7-4c90-866b-8cb676743fd7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 945", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("4c2fb61c-c4d7-41f7-8141-88f3f2aade74"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 179", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("4cb2041f-f4e4-4a1a-8a0c-081cde4efc5c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 510", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("4d36a48c-2dfa-4da0-9233-6f110f46cceb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 915", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("4d38e7d8-493e-4eca-b110-9c6815b1982a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 288", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("4d3d7874-1cbe-4d96-9efb-ba5d8001ee4b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 887", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("4d4c7e0c-9f91-46cb-8c6d-404e5959fa2f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 701", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("4d6c72d3-6ec8-4b0c-968e-7655a8796173"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 204", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("4d785d79-8e2e-4e75-be83-c338343e0988"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 675", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("4db8eaf3-f0ef-4f5e-86cb-a5e82d1969f0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 605", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("4de7ea94-23fd-42ae-ab7e-5c33c5fad975"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 215", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("4e999b57-4e4e-4bc6-b099-3c4897fae6ab"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 115", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("4f094307-c130-4954-8de4-b2aecca2d0e6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 174", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("4f2ad724-e5e8-492f-ac4d-b03d7c55a142"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 132", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("4f768b9a-1a92-419c-911d-03d8d61fdc94"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 710", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("4f781193-083c-485b-aa9f-a1b2f08346f7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 504", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("5052fdd9-d5ca-4009-85db-59b6a7f98437"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 589", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("507c5568-7106-4878-a5fd-b63938096766"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 396", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("507e8114-f8a9-4f6d-b1a8-5f4480024345"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 348", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("5082f88f-1d44-4a42-9161-f01a36ac3d6e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 524", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("50c4657b-4bbb-4984-9bf9-8f965268e575"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 492", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("51133396-5ff2-4ee6-ad05-a1a974b531f4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 677", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("511d121b-d3d2-47b7-a113-e6fca267f68f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 948", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("515617cd-d661-4d55-803b-20d57296237c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 611", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("519e8daa-fb3c-4b7f-a370-52c92e79ab95"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 523", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("51a81649-16ba-4eee-b4bf-bf6127dceeec"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 716", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("51e959ca-f0ce-43d6-bb5b-08c054329e44"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 192", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("52c1e21a-e1a4-4bc2-bcb5-450f413c3ce2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 604", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("52ce8f06-8803-467c-a338-e6fafee6bfca"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 911", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("535279b4-9d87-4f78-aa64-36fd72d4c087"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 393", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("5366e9ae-9b4c-460e-b029-24f7fdd7474f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 463", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("5385bb75-c5cb-4c78-a5fd-bc7a2dea9683"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 625", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("53a9c67d-a675-4ee8-8f51-f3826c8d56f3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 312", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("53d6c1a2-9a80-44c8-9bb6-f83f3f49ee2b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 175", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("53e9761a-7bd3-4d63-939d-af20dd1d2f3b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 423", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("545c5ae0-7abd-4ab7-8e17-73ada0e77b02"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 542", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("54bc1077-fa4e-4b32-8746-76262e1baaca"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 910", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("55bca52a-6f47-413e-8381-7f91022c9f6a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 291", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("56251ed5-9df0-4baa-a4b0-3ad54e2bf491"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 932", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("56416996-005b-4349-bb84-d6d2df6da23d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 183", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("568f447c-3995-4643-8f98-3ddf79418c63"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 289", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("571539eb-8c6d-4255-a56d-1f66d27c5700"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 773", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("5729bbfc-e31e-4960-b8e0-8dfcaca6c81f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 271", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("575b1fa9-10d3-4d29-9973-863682bff152"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 9", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("575c16a2-640e-452a-ba80-9a21473f4d1f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 123", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("57b27f72-45fb-4af3-a17e-5304241abdd9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 858", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("585367ef-81ce-4d3e-bf02-6dfaa7519d4b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 641", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("58bee705-2c26-46a0-9835-dbed8e770286"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 846", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("595b9fae-ee91-4372-8b62-3fbbb8b92524"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 536", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("59905c88-90bb-457b-8a83-6ef6ae48a414"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 892", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("59917fcf-4791-45ca-9653-6db03b0b3c26"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 748", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("59e09812-9b38-4853-af6d-2814c34728b9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 222", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("59f80011-2c0a-4d32-9c8a-82f67dc567c0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 150", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("5a45be4c-ea84-44ea-a4f7-ab61735a2a1f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 427", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("5a4eeef3-0cba-4cc0-b42d-b5eb42e00b68"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 602", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("5a5dcf85-90af-4aab-b243-27a380f642e6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 738", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("5a622bce-4b97-4cf6-82ae-bb0f748b0b50"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 203", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("5a66ae49-4d34-47e2-b458-ef98c9bafb18"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 454", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("5a83445a-25fd-46fc-9992-17a05098b63a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 301", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("5aa8415e-8efd-4b1d-8a61-04d04243240e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 692", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("5b3fcbfa-01d2-49a1-ae8d-68b680aa6c7b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 321", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("5bdb34bf-f010-420f-9658-8a57b5d48e0a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 547", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("5bdc677d-dd78-408c-973c-4ee175b304dc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 909", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("5be795d1-5458-4575-804f-818491fa9260"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 886", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("5c6dbe7a-63a2-4f04-9887-0c57ee68b34b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 597", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("5cb02205-f129-415d-b412-67219da30d3e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 235", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("5ce224a5-0103-4286-bf2a-c4a5901e3687"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 999", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("5dbe9470-719a-4eb4-a021-3f2f4a1accdb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 912", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("5df5975c-8fb9-4c2e-a01d-71fcfa39f768"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 209", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("5e78e4e9-d9e2-4400-81d8-7421bb7f192d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 995", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("5ea59a4c-5162-41da-9d60-8867e6e6fd70"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 590", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("5f123708-30f5-43ff-bd9a-c7cd29c2487d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 406", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("603fdfba-0315-4b90-bd31-b3baf19c5ac7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 744", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("60a0dad4-3e0f-4d4c-bcf3-42ba9cf9c377"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 828", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("60c6974a-f9c0-4fb5-b2ed-82e01ed7592f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 931", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("60e9b765-393e-4f41-b92b-4f613e92bf11"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 495", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("60f48abd-f509-4634-9569-5c7bc7a57da0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 286", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("6136fee7-edc9-4427-b93d-73c910ca6a06"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 310", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("6149a855-c940-46df-87ae-680e5187b970"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 323", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("614b7d1f-135a-4300-95c4-db450d7d0168"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 137", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("615bf9dc-01a8-4c42-8cb8-f5aba47b3db1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 80", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("61956876-0932-4509-a709-eea86ba548d3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 804", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("61b5978f-3412-4114-bfe2-bb675aa94a29"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 120", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("621304e2-570a-4f51-9406-3b3b05fc55c2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 264", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("6228332e-80b8-42f4-924c-78cf48b17bac"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 938", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("628476e4-7bf2-40b3-8f97-315104ffc41b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 279", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("62c0177c-5469-45d5-a386-620475ce09ab"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 654", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("62ccf462-7ba5-4899-a0a7-0fc6a2bbdaa8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 816", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("62d51f14-bf5f-4156-8235-d4697e7790a5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 720", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("62ed8783-1d23-4431-be67-cd7c27e3b8c1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 829", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("6300014e-220a-4b3b-9267-2ef55a57c5de"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 619", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("63135955-db3a-4264-861b-3e5cba495a72"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 693", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("6359dfb0-ab8c-4a74-872f-308e1e801ba4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 934", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("6361e95b-70a1-46f7-ace6-622008ac722f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 392", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("63bd1675-a057-467e-a48f-da4b703930f1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 189", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("63c4fa34-5ba0-43c3-a5fc-45e4b22846d8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 3", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("6414a7da-62ae-44a5-a328-822327cc2d9f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 394", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("64a44b6d-58f7-4d6f-ba4d-cc6343155f46"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 637", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("64f25e19-39cb-41be-99b2-8828d80c7c9a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 408", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("6515f352-05e5-42ab-a648-502244baa598"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 257", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("651644a7-0194-4c5e-9095-f8393cc96acb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 503", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("6576666e-d555-4f64-a9e6-5c3e30a6d216"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 107", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("65ab7177-2bd0-4ebc-a929-361559dbb896"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 274", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("65f1ce2a-7203-4979-9698-c35d20d9b013"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 295", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("661e4dd7-9a90-49c8-baf2-5a70887585ba"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 62", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("6665b71c-e919-4063-b9db-2973b00567a4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 65", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("66ae852a-af1c-44a0-984f-7bbfbbdce926"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Jean", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("66c002eb-5318-44cd-9cac-dec08c6154a3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 853", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("66d49788-c823-4dac-9874-8ce2cc3f7f58"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 187", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("66ee5e2e-228d-4a0d-89a6-3e3a32e49716"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 562", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("66f134c4-5010-4618-9d57-d29484119bcc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 430", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("6731e615-f8e7-48e5-8e33-4cdcf074468e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 69", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("6741a467-9fb5-40c7-8b86-abb0c164e340"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 852", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("6752add1-ab72-4879-8bdd-1e986a3a086b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 363", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("68b58f9f-2e5d-45d0-a719-334b64d7fb70"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 901", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("68e0f2f8-e7f2-465e-99ff-4a0ec2d43e89"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 91", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("69126a1b-b0f2-4ea2-81d0-1f2e9a335d87"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 24", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("691bafa3-6334-4549-9472-418d2b0c847e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 521", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("691fe65f-5767-4d53-9c01-d6bc0a0965c9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 742", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("69955e8e-a3cb-46eb-82ee-b8c00472793e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 152", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("6a0791b3-754d-4ef5-9655-9a002e7825a9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 571", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("6a1622c2-e354-4924-b596-8b39e2c2ba3e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 201", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("6a466a9f-5324-42cc-84c8-a71e8cc6cb71"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 108", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("6a60da57-c6bf-4cbf-9dde-d11331f46503"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 835", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("6a939de0-ecfc-4e5a-8c16-96157505a383"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 73", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("6aef6d5d-9755-42e3-81cd-fa40ac17e705"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 96", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("6b08bae3-87ee-4e70-a50b-f4f320c92ef5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 885", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("6b798dbe-29d1-45c2-b430-8d4491258064"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 17", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("6c06e361-bb1b-4d7e-83fc-97be903b2f49"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 592", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("6c308e4c-44fe-4970-918f-3c9107bdd641"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 990", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("6c77f640-372f-47b6-982e-6b01f20c31cc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 255", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("6c794c41-88c7-4e24-98e6-beb75d9f7c0c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 164", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("6c907704-1dcc-450e-baf9-d6e69f3a251a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 854", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("6cf7c8fa-25d8-4975-bb37-f4f9d75a0f67"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 438", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("6d0311d7-ab03-406e-8fd1-7426ccaa2d04"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 924", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("6d2f6959-0047-4fd3-943b-b4f007eea18f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 397", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("6d7a0b72-cd78-4b99-ba72-48aa9495d36f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 977", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("6e168d8c-c992-4b9f-9ea6-1240884b10c6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 810", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("6e44ec15-70a7-4e71-98c1-e343e0465d42"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 545", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("6ea68f16-1033-4d42-95b4-5fcad98f100a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 607", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("6ece044d-299e-4b83-b9af-bf9003338c5a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 660", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("6f25f4e6-9d47-49d7-a85f-0ba44c9e0ba6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 439", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("6f3389b7-1ce7-4f00-a6eb-45928061be87"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 683", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("6f583a4c-5001-4a0d-88eb-7e0594935405"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 992", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("6f76950c-5d60-4266-8228-7afb19ef66b7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 684", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("6fa2974b-414d-444a-a86e-0861c457b5f1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 812", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("6fcf9c4d-e6c3-4d8d-acbb-4fba07cab02b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 360", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("6fe4bb40-c130-4de2-b95a-fa9189e58ad6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 668", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("6ffd9503-c5f1-4ac3-85bc-67b1996f0e63"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 369", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("702133d2-8c0e-4da5-a1da-8a4498803045"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 163", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("702af30a-8c46-404a-a50f-9a2f92c19ab9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 988", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("70de84c5-887c-472c-8a47-673be0654122"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 805", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("70eb00c8-ea52-43b8-bc0f-35879a2132e9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 36", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("7116e9c2-c060-40fb-8469-4eb80ca60584"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 429", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("7184dd93-5c43-412f-bf51-8a2ea7b23609"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 140", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("720b1fec-e639-4b08-90ce-e125df75c9d8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 517", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("7220bf3e-c3cf-413c-a8d8-3266feb938f0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 70", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("72a4e866-e960-4c44-8560-d7a7032c1e1a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 185", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("72c9ac69-8779-40fa-a2a2-bd23bf319965"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 385", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("72e7d3b5-3b8e-4bd0-95ff-71f8324543fe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 569", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("72fb6985-a267-4215-ae61-9efda9339664"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 968", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("7327bc9e-c2f8-41a2-8f25-fb08099998af"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 81", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("73342235-35b3-4b36-b551-c34ac089022b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 161", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("73573637-7f94-4074-9472-c849589ced7f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 267", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("73dd5f20-619f-4938-9429-54b2f65fa102"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 119", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("74c40980-3098-4c94-8303-4654df8783e1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 494", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("74c6fcc4-d59f-49fb-8585-0711afc7b820"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 298", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("752b6aea-795e-4470-aa61-3a4160e825fe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 378", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("758be912-2183-45e2-8ef3-28648f5f09ae"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 210", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("76064514-6962-4905-a99a-5212581b42e2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 66", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("76bc06a3-6642-4042-b4a9-6b1dda972784"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 548", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("76d2ae61-1f18-448f-af1f-60278006a4ae"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 802", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("76e17898-d500-4e84-9499-d5605fb1f528"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 307", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("7700c83a-9899-4475-9a94-1dcc24d3e8fb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 655", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("77c07f23-d8ff-41a2-b9da-2157f98f8ae0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 102", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("77c79ae8-0284-4086-8ceb-6294fc537c19"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 241", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("77ca3d0b-961d-4062-b6d8-675712382daf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 415", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("77cd8c6e-db4b-4579-a773-f3a73ca91fc1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 718", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("781a73f6-1076-4159-913d-b2b367aa0d47"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 803", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("7834d83c-cf69-424c-aae3-168ea9d9a255"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 202", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("7874d40c-cdc2-43f6-ba74-fb9e397aedcc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 796", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("7992578a-8359-43e5-ad3c-3ba1b1d32143"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 342", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("79dcb78b-c44f-479a-a9e3-0937aa194bf6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 700", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("7a07231c-143a-4e3a-b765-97333f6f737b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 327", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("7a1ff96d-bf74-4e07-acce-abd76068cdd0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 206", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("7a5242d8-4982-406a-9d4a-30a8bdacf2d5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 475", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("7aae3217-2c06-49fd-aa7a-66c86089d7a5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 309", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("7aea12e5-ddd4-42a0-b658-d19ee9531714"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 374", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("7b0a86f9-1795-4bd4-a51d-2ff3d165007f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo ba lỗ", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("7b2c9baf-366c-4610-8005-b279861455e6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 750", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("7b8fa2c0-31fc-4f48-9866-3e76f54bba65"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 775", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("7bb5b9cd-e7ef-4deb-9e7b-05af9c2c7805"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 320", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("7c717811-4886-4b22-b0ce-fcd55446ce46"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 35", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("7cab6e9f-c959-4f9e-8715-a990d4cb9f04"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 147", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("7d282b1f-cf48-411c-b89f-2a05b26823c1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 979", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("7dee7a4c-05ca-440e-bc23-90393b8dafc4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 797", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("7e450f95-9a3c-4742-810b-2e8fc2fc9767"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 837", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("7e4ddfa2-3838-4df2-92c6-df987c940ee6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 469", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("7e62083b-1b0b-4367-aca1-3fbeb4e02571"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 626", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("7e72e4bb-eeb0-4f9f-a1f5-276cdfc0a944"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 414", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("7eccff0d-470c-46bd-a6cf-02948c8c8b5c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 743", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("7ee2d9e3-1abb-43a7-9da8-c414c298e79a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 156", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("7f4b8893-5d9b-41a0-9a19-0024ee795c20"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 64", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("7f7d41a1-e589-43f3-a7cf-e39b6551ea49"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 913", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("7fb02b8b-3a53-4d46-923c-145223b0555f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 157", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("7ffb5a8f-2111-45a5-841a-8b7bb6bc1ac8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 50", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("801099cf-267e-468d-b03c-b8099f01c075"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 191", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("80388753-f0df-4346-bb53-8dfb5d06bf90"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 431", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("80bd06d7-2661-43d6-b4f1-261ba696bb87"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 74", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("80f34ab0-cfb0-4340-abfd-a788a9d0f72e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 724", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("815a945a-65bb-4247-8c95-007acf26b194"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 647", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("819bb326-bce1-4ac6-b0ac-88a943b2b1bd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 601", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("81fadf8d-6226-4dc3-a4de-4d52c9fed708"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 379", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("821b711c-e9dc-4b99-9c0d-2b7aaae2e029"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 769", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("82202e8b-b793-4fa6-912f-8efccf6354de"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 220", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("82585b9d-a282-4a33-b490-b939e42354c5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 838", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("82aba22c-2495-4767-b541-56fd20b7fc51"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 243", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("82cb1319-0b4b-488d-9022-f6f8583f9344"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 939", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("83844c97-1d1b-49c2-b907-a86baddd259f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 972", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("83bc85a6-2087-4b88-90b7-3c9a52ba671e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 869", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("83e75d87-9202-41e7-9dfb-c332adce75ab"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 679", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("8415119c-0676-4643-b04b-bdaace8cb28f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 136", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("8445e567-f92f-4e78-9130-90dc6e69acea"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 603", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("84528f80-d40e-4973-96ad-21b6c07a8e80"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 731", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("847b356b-a08e-4797-9ff7-c6045b537c8b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 304", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("8495bcd8-38fd-4e6e-9141-4464d266fe75"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 93", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("84a6d4ff-3320-4a75-a5ec-03084d0f3722"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 318", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("850319d7-d02a-4463-af24-1260ef8596d7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 197", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("85172d63-1fba-46e8-8c25-433f9e75f533"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 957", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("85270ca0-4ab1-4612-b145-bb248ceca7d0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 800", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("8615fefd-d861-403f-ac9c-807ec5156630"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 149", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("8644e6df-fe99-4b66-999a-e2bf9a8512f1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 809", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("865bef73-69c4-4cd7-8897-06c3aabb418f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 987", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("868cc47c-d232-44ce-b477-95e6b70c9dfc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 313", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("86f0afe7-ebc4-4f1b-b6e6-9f1abcf897d9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 861", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("8741c9b9-58d2-4c20-a1ec-23f5951438de"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 61", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("8758d95c-fb76-4281-8690-9bb2205b730b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 661", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("87c3835e-df2a-4c15-b9e2-5c146d2b1cfe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 746", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("87cdde21-b004-4a49-8ac6-b390bc91590a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 941", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("87fc65e3-28bf-4884-bc85-7240fb02bf17"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 895", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("8818838e-cafe-452a-955f-f8f2c73106ca"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 666", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("881914d0-5e77-4e28-8245-bf60e4c8b556"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 441", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("885b4bcf-650c-4d88-9338-7dd4e58d2db4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 609", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("88968ed1-b5a8-4cd6-ad18-a9b59e6d1ae5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 848", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("88f4662f-2a3e-4134-9d50-dfccc08ea2af"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 712", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("893c5743-8ec4-435a-915c-11ce065efa61"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 389", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("8962aba0-877c-4bf0-bbe3-dc1966b2143f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 537", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("896586ad-2681-47ff-99b4-875e9e63a804"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 347", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("89c663e9-5a3c-4ca1-a7a5-0e78955394ec"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 276", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("89f888cc-6f1f-4b90-8162-41b11f575473"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 944", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("8a7e7554-a251-422e-b170-af9714363bcc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 480", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("8b251c54-34d3-4dae-b9eb-a62a74f71467"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 993", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("8b58ce84-4ee4-4332-ac1f-048340bd9a99"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 268", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("8bb99683-802d-4bec-aad2-8eaea0f5b2c6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 759", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("8be90234-aa5d-4b8c-94c9-5cc327951086"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 778", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("8bf3cb5c-1dec-42c8-a525-4aa5c7b7a1f4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 690", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("8bfc6f35-0474-49d9-8b68-ae74ac29f593"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 594", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("8cbbcb2b-5cf4-42dd-82fe-acffd1e8b3c6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 978", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("8d1ae0bb-1c28-4176-9e36-e75a20fb0099"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 499", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("8d352775-cc2d-48d9-8d85-13464db9b569"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 258", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("8d4c3ebb-1e5d-4c72-b331-72fc50c35153"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 1000", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("8ddca6b1-45bb-4763-9504-b8cefc626048"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 338", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("8eb57d4d-0e97-4b23-a43b-6fe0a76618f0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 127", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("8fa0613d-6864-40e1-bc95-a2c7680ffd7d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 531", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("8fecc3aa-16f9-47a9-a2ce-403571893b00"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 598", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("91336345-e3e7-4b22-8a06-237c0c769661"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 698", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("9153a4da-f341-4c2a-b5d6-c4f7dc2c811e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 166", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("9159fa2d-0f8c-423c-a32f-6705262f5e88"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 114", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("915b4134-44ad-48b7-877d-ab2187385fa3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 445", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("91b56f28-4aeb-4049-b927-69bb143809ac"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 63", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("91e73903-65c9-4c4b-84f8-08c3a577a078"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 663", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("926e7add-323d-4162-8968-e7a3b40cfa25"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 245", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("9285395f-07fa-4e91-8196-ee3ebcbd206d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 586", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("92b483ff-2201-4f9d-8090-8c24a9ccc555"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 25", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("92c34363-fcd4-4960-aac2-9693a34d6741"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 22", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("9386fdab-bd2e-4d06-9eb4-525c0423fe2f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 154", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("938970b7-4e60-4b90-932a-a9a6f5c75911"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 974", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("953d613a-9f97-4ae8-97ea-563b03f3e66c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 436", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("955cedb6-93ec-4bea-a16f-6acf1b5e9636"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 488", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("9685002f-fbb5-4d89-8f20-5bf685cb6860"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 600", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("96a76bc9-1767-4db7-87e9-d7453fcfdba1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 219", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("96eef247-fc3f-415c-84eb-193bc4a61a4d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 334", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("97652cfe-4939-44c3-8f05-445f8ef77986"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 141", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("97c667dc-43cc-426e-b2ba-62aa9a2ba2a5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 697", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("98018881-ed41-4624-9ba4-17a481b49920"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 425", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("98199cc8-3e67-4159-9094-8610738e73f3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 840", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("986ca4fd-5624-4a33-8c74-2e0052784364"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 177", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("986fd571-b404-474e-abc5-45241800ee37"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 790", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("98a168bc-4a76-4804-8dd3-39bec0c7ee3c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 973", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("98f7134d-b015-4507-8804-2c50a9d81834"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 144", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("98fd3478-933f-425f-9787-f5a19ec7f5ca"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 458", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("992aebcd-a8f7-4764-a7a5-553408dbf647"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 920", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("995f4744-3f86-45b3-8571-ed6fe2cb78b0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 704", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("99bf4f45-f1f7-460c-afeb-d485ac191192"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 477", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("9a2e3b49-f9d6-42e8-9552-99b8038579af"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 483", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("9acc40c5-e01b-4c12-bbe5-7db7c91da63b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 540", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("9b0e983f-33ee-4423-9a46-b32c992df9f1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 178", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("9b97970f-2575-438c-b495-9275bf05761c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 959", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("9bfae9db-322a-42e8-bca8-18420310c42d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 820", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("9c84034e-3637-44a4-9c16-eeb708d02ba3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 671", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("9c9b670d-168d-4139-98a8-6285ce8f433c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 567", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("9d14a8a6-c8df-475a-8cf7-ae9fcc437d7a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 130", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("9e0a9652-4a45-450d-bf27-916e793a5519"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 967", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("9e409164-0a99-4305-88db-f6b20f9d3d2b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 84", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("9e5bd150-9575-4920-81b4-765b029eb6dd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 331", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("9f0b141d-33b9-413c-ad49-8e8142415b66"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 373", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("9f2c4a69-5cd5-4164-9078-4aaec592b5d9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 577", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("9f448fa9-e13c-4f48-b876-ae95338e9952"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 788", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("9f737340-775a-424c-aabc-c4073141e4e4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 643", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("9f7978f3-c1b0-491a-8bf8-db3e6eb8d8cd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 624", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("9f7be53b-1417-49a4-be7f-5f4711d545a3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 216", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("9f820c9f-4b8b-40a8-89e7-bca5c26b3111"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 921", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("9f826364-74d8-41fc-b81e-25a68be0b92e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 129", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("a02f471d-3484-4f07-b14b-c018eddbb0f6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 553", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("a03e2c0e-4a5b-4381-9b30-93867c93d657"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 638", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("a04ec928-cc4d-4e7e-9116-510f4adab0dc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 734", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("a0ce465b-6e9f-44cb-b63a-b9d775a851d4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 996", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("a0cf61bd-6c46-4d9f-b03f-0df30312f671"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 764", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("a0f824a7-d235-45e8-b26e-39ed29197098"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 335", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("a0fe2082-f66b-47bf-8515-70685327d6ef"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 181", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("a19bb7d4-1212-4e96-ba71-ef21955daaf3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 211", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("a296cb2b-8a0e-4661-bcd4-19a5aaaa951c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 44", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("a378f2d5-d7fa-489d-8d11-94e843fdaf5c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 315", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("a3990033-6422-42e6-9abd-0e6aeb6eae38"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 554", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("a3d078db-fd7f-47da-9d9c-a4d982070ac8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 447", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("a3eb86f4-40e8-4880-914d-1790d693812f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 502", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("a3eef1ee-cad4-4bb4-b76d-1363ab148a66"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 929", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("a446a3ca-4cf7-405b-9930-10b0b0965a6c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 549", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("a457d2e8-6b4b-4442-9f29-ebe15de774ff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 839", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("a4adf4f6-d296-4035-abea-60dd5aaa74ee"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 855", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("a4c3ef9d-b5fc-4cbb-9837-a0e78773c4ad"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 43", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("a4e8c588-f09d-4c2a-beb6-bc6e2b68b3cf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 251", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("a4f4ce69-9e72-4f94-b68d-3f237ca511d6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 242", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("a5a4e960-fde5-4a51-a76c-93e06de96331"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 791", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("a5e16084-62af-435e-831f-cfa76182db79"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 433", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("a656b918-8ef4-4ab0-b600-c4fd632b64e9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 872", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("a65ccbbf-d800-4700-8609-cae2d52a3e65"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 615", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("a6a65828-fc5e-4f00-8ba9-df7db835162e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 632", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("a6e2fe2c-3363-4f7e-b48b-45a43bf9bffe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 754", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("a6ffa7ff-aea1-4da9-8c62-e69f40b9da3c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 881", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("a7afe39d-ec6c-4a05-b334-59adcc906c2e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 325", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("a860593a-f129-426d-aae3-16a56816cb77"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 599", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("a86a4df6-0c13-4c40-b4db-9cf5c1cb39d1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 768", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("a8a18403-229b-428e-8d8f-e52b4c01cb57"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 135", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("a8f8a93f-aaf1-49f8-9d37-e11885b34f90"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 783", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("a91a80d3-d1ea-4bc1-945b-c6cec5c280b6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 214", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("a93a3b49-d5ee-4064-9c14-61d166d377db"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 453", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("a94ec600-a8cb-42a3-865c-51a6a6ba4eec"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 349", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("a99087ae-f04b-4e33-ad81-6afbb6d372ef"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 322", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("a9965acb-98ed-40a6-acbb-88f0047db302"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 18", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("a9d3de13-fe38-460f-9549-3fd801ea7c58"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 728", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("aa609c65-46f6-48ad-ba53-a24fa65117ac"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 101", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("aa93fd05-0eaa-4445-820a-00bda955b54f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 747", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("aadc25b0-927a-43e9-8a92-8274f143c64a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 882", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("aafb886d-5d0d-4756-92fb-d6a10440d04b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 842", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("ab1cc357-05d7-4f80-b31e-85de87a8000c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 556", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("ab5f0aca-6200-44ca-9ac4-6f114109f971"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 324", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("ab6901bb-93be-439d-a472-7635f5b203a7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 400", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("abb06d23-16ac-4c15-9599-c3361f581f39"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 158", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("ac463b9c-9167-4dd3-a3a2-fa4dce6874cd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 818", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("ac60f07c-0c80-4d19-ba80-dd7b38ec5617"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 539", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("acb26994-8789-467d-aa01-d867feb1cea8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 817", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("adb4f695-7de7-4b23-8bf3-80e398be48bc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 332", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("ae0b6968-de7f-48d9-a321-74012eb81c7c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 170", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("ae2651f3-1ff8-46fe-8db3-7626ec23a572"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 688", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("aebb9a00-dcc3-4218-bd0c-64fe6713aa6e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 297", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("aede2dd4-7c8b-445b-982d-f5c288fdc077"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 617", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("aedf420d-36a0-477f-bbb4-2bec9e15b797"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 664", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("aefc4cbc-c39f-453c-ad6f-aaf2ccb06bd5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 735", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("b0a162d5-8579-4d74-9954-a4b2c2de6bd5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 879", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("b118c8f7-e813-47be-a9ef-3bac497eeb83"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 807", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("b174bd5a-f13b-4443-9d43-0390b2800f9f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 584", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("b17c7739-b9da-4e12-8045-968fe60151d2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 516", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("b1b7e67d-14d7-47db-9461-7eb6e7e64770"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 269", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("b2486e62-e035-475e-8892-35a8cc2ba1a0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 15", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("b2769ba7-a984-4fbd-b42b-635afb0444c2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 583", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("b3458b48-3128-42aa-92db-c2631050a553"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 505", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("b3522323-3c40-4dd3-b1e6-4543695d06cc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 13", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("b352936b-7eb2-4acb-bab6-a356ea2b1fd3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 781", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("b3821a8d-49aa-4c55-9973-83bb092d63a1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 58", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("b3c989f7-5510-4498-963e-52d901719b68"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 522", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("b3d4ea47-d097-4ca8-8b7f-ac5b5fd4d570"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 631", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("b5018d82-d11d-49c9-aefe-e04f84bb404b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 103", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("b5c073e4-28f5-4c10-908e-8f96215fa9e0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 739", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("b60544f3-04b2-44c2-88cd-c873a9d116ee"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 117", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("b611a7dd-4b67-479b-ac26-39ee032c1f79"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 780", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("b681fc63-0786-4fc5-8cfa-bea83e1d17af"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 994", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("b7c99f65-7c09-44d2-8b31-3dc4171b6b9e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 460", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("b834e321-dc64-4f99-8913-940c8220972c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 753", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("b85814a0-ede0-41bf-9afe-70583fd6f0c3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 213", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("b8a753a5-fa05-4e54-ac86-c91319c2bdf4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 459", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("b9175685-2194-4859-9351-f383890d9025"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 125", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("ba0ca1f1-5b3f-4f00-9f1a-4bb5beec76fa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 486", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("ba19282f-9355-4840-a7c6-78309c662058"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 377", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("ba1c47cb-fdf0-44e3-b65e-3625333fb8fc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 493", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("baeec7c5-7042-4ad0-b657-a1a3c755938c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 471", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("bafb0120-d82f-40b0-856f-fd0f38378203"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 261", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("bb38c833-fe5a-457c-b464-37a4d2ec71af"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 771", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("bbc64d68-34d4-4647-b667-aaf42f8433f7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 634", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("bc167d24-e3fe-449b-984f-c45de2c99013"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 153", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("bc42562e-603f-415c-aab1-8fd2d2f23353"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 806", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("bc75e811-82de-4595-83df-ca3818cfbe5c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 417", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("bc76af66-7700-4d59-8ea8-6314681efe7e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 29", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("bc8ed676-5734-46fc-a548-088047cf0782"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 563", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("bca09e55-6b7e-42a2-b215-315e09a6475f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 629", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("bca7edcc-d8ba-454f-9bfb-913e04c1eaf4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 867", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("bd1ed5b3-e910-4480-8aaf-a1d21535bce2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 196", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("bde65365-b07a-49b4-b611-483dd599b504"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 612", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("bdee61b7-a355-4042-acb9-484a8ad77fbe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 87", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("be1d928e-cdb4-437e-8788-faeebd198474"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 535", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("be2296e5-96ae-4d44-911f-22ccc23ec1f2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 899", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("be719740-37e2-41b7-9bc7-e142941d6408"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 221", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("be748659-f032-4296-b93e-f3c970e64605"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 702", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("beeaa18c-dd00-45c3-808b-ee61436742fa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 472", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("bef3bcf9-c92b-4da5-86f5-e43dfadc3f88"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 287", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("befa95d3-b049-43f7-a96d-db4eb2e9eabe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 370", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("bfa421eb-a819-4a6d-9374-a8390466ac80"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 819", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("c0121440-3c76-49f5-885c-e3f8c9ef6ffb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 248", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("c01ece69-fa7c-4f66-af90-c16e7ed1cd55"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 653", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("c03050d4-c08a-46a5-997f-592b943fceb6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 105", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("c0320a73-066a-4390-bf64-6a8e94a0fa69"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 543", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("c0471f9d-8744-4ceb-8a28-031ee209040b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 398", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("c06200f9-9118-4702-b21e-08cc438941a9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 960", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("c078d6cb-d7c7-4b07-9c47-3894cc8b96b5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 652", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("c0a844da-de81-4739-aba0-4d193a9954a6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 576", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("c11467b5-6054-46f0-aa6a-e8b271738d56"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 927", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("c128cbc1-9a56-42ce-ad1b-cfef0183540a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 482", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("c1660db8-ba0f-46f1-a1d8-4e3e22aac12e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 159", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("c1ba8a51-0140-421c-b461-198d89df8cae"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 489", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("c260a6f1-3300-4c8a-8d0c-51e4a87bb98e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 713", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("c28fa552-f949-4cd1-8625-334178851af1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 461", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("c297c429-0de6-494e-8be3-cb6fa20e578b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 564", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("c2caac63-c42a-4616-833c-3e51d9e49b5e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 726", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("c3040701-7569-475d-a25d-3b779000bf30"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 825", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("c309d189-e451-47ba-af26-d8dbe56aa272"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 300", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("c39d58d8-13f7-44a4-aacb-030f72a322dc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 376", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("c3bfd385-3b08-4610-a66d-df8784b2fe49"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 798", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("c3e7a205-29b1-42d8-b65b-e11f93eb2c21"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 39", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("c3eaa7ad-5956-4814-ad36-5ed3b56f433a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 573", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("c44eea3e-3d85-4ca8-ad55-7cb7e4d4da63"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 847", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("c4533e0e-66ed-4b26-8cbb-f63d6db123af"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 20", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("c49e859c-9725-40d8-8498-0718f48d9bd1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 657", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("c4d3edf7-2bed-4e87-bc8e-f132e581baa4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 31", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("c509f754-514d-4d2e-8c38-ad01dcf6b9a8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 231", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("c5316f95-4d62-47cc-89e4-4b6fd035e897"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 935", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("c5723d9c-7c54-4a31-85e9-447d82bb202a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 943", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("c59e58a4-5ad0-422c-a626-220d3e402c17"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 928", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("c5aa7301-e992-4d84-80aa-4322cbc17a32"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 420", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("c638129c-df44-40b4-9cdc-d36fae9f1615"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 933", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("c66d1c6c-9923-47a5-8822-ae8c41bd8b8a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 779", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("c67a5679-63cb-4864-9558-38c17a7ce655"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 546", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("c6a90dc5-1dd2-41c4-b97c-d00b778571ec"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 346", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("c6ca868c-8a38-4964-b4ae-236833222193"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 878", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("c72e6097-12d7-48c5-a2b2-76d5f190f5c0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 794", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("c77bf16b-68aa-45ba-90ac-e174f29f4bf7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 509", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("c7a81927-ca2b-42ec-9908-39d89948cf6d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 113", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("c7f1ffe7-9902-4b22-81b0-690d3318ca0d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 651", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("c8125238-31d5-4385-ac09-4d6b1d5d142d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 207", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("c8228347-18df-4f21-9467-c285b38f2f46"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 552", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("c8525e10-b827-4b7f-9dfc-000bbad09d3f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 859", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("c8c9e1e3-40ca-4651-a38d-7f7b0df0b400"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 833", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("c8cf8245-2430-4850-96c1-bc9b6f599603"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 860", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("c8dacdf2-5bea-47a1-932b-8e139d870484"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 306", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("c9d9b453-97d6-4f5b-9957-bd694f2c4920"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 801", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("c9e9f90a-41bb-4ddb-bf21-50bc1e07648b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 32", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("c9edb28e-35e3-4bed-b387-f6ce6b05fe04"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 380", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("ca2031e0-7911-4be8-917e-c404b43cb7e0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 180", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("ca3c5097-0358-4d9f-a672-a20950bd9a35"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 208", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("ca64eec6-2c64-440d-ac48-6d16d88f1e91"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 280", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("ca922feb-ee46-4344-9817-b887d19a2b0a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 47", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("cae930ad-3b43-4e85-bcae-83a4c8b5a88d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 930", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("cb177b03-dfc3-4c46-b44b-a3bb6481bbbe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 26", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("cb580fd0-c4ab-4e13-a9ea-838f7ca649be"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 902", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("cb67e1fe-7372-4dbe-affe-6597edd76520"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 636", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("cb6a7ef8-797c-41b6-a9bd-5a947334e6c6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 595", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("cbead521-d054-458a-8c6e-883aedfa368b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 534", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("cca25c7b-6d40-4c39-8083-5b00dd5934e7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 340", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("ccbaee01-30ec-4abf-8f00-0c72c1cd092b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 969", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("cd4b8ac7-5248-42a9-9593-e71e24c83cc7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 733", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("cde09fda-a1ad-4e65-9886-f022e52c05a8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 527", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("ce3554fb-e1a1-4350-9f44-c478c19ae0b3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 478", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("cec29e4c-c4ed-4424-a458-d0db961e5a09"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 736", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("cf309fff-4604-4381-811d-224fafd76c20"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 79", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("cf4db3a4-c4d2-4383-8141-0593f82b8b1f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 831", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("cfb8158d-6ed8-4b33-856c-8353355aa1e7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 194", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("d00563c0-cd08-4817-8bbc-606bfafa6f63"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 184", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("d0171216-1765-4d21-a512-4ec1d3f3da23"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 94", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("d02c7c76-5237-46a6-91c7-b58550d9bbe0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 758", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("d030577f-0f47-417b-8626-db255f3d2d0d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 566", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("d041d9bb-1e71-4e53-88c6-00069d4e8a9c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 100", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("d04bc4eb-946b-4741-8a5b-15e0ccdb8ddf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 498", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("d075d32e-4bea-46e1-8bb1-6054e17f2c2b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 964", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("d09e1e99-0801-4e6a-934b-b29d448e46fe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 793", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("d0fe57eb-f79b-4ce1-831f-10cc2fc4e40e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 138", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("d129fbc6-76eb-4885-85f3-163c036af29e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 381", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("d13e3114-060d-4248-8907-215b4fb5c5c6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 659", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("d16dce30-a142-4565-bcb2-68d4a732f0d9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 570", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("d17ad774-e310-4f4d-af68-06ccbf78c89e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 623", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("d197d504-6dcc-4bb9-bef5-ea000bf6de93"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 466", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("d1b631c7-10f9-4903-934c-3fb64b52ffec"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 372", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("d235e340-58a6-4466-8902-fd20b33b9384"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 708", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("d2b5255d-7550-4bd4-ab2c-d896d86f539b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 85", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("d2bfba7b-d9ef-4413-af36-b0749160ac51"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 497", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("d2ebd563-3600-4d2e-8c28-65de4636206d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 953", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("d30ea55f-fc48-495e-898a-603bd06eecf2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 402", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("d3322aff-1010-4d42-8d7d-09377dbc3911"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 337", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("d35ee820-4a6d-40a3-ad76-a5214f9aae4e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 237", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("d363e420-0d2a-42e7-b0b8-69ec2dec02f3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 705", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("d36e61ae-78af-4323-9ab3-d22b5fa0ba7c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 234", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("d3c30b46-c24d-4451-ba1e-0bdeb5de3534"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 172", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("d3dad95c-6fc1-4f81-a55d-232965474098"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 133", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("d3f40048-fabd-472a-a1de-8b3e94cfec18"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 59", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("d4041bf2-d139-4c03-a67e-547f6c0be606"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 303", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("d422df74-db7c-4b5a-9345-0dff9aa26a91"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 56", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("d477d7c8-c0a4-44bf-b9fa-4467b91da798"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 371", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("d504f41b-81d1-4766-b564-cd3f4b252401"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 60", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("d50b969b-0594-469b-9511-be3d89577aa7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 186", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("d51b4061-e8fc-4982-b275-673c6ffa32c4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 351", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("d558f6db-be3a-41ee-836d-838779ecac30"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 476", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("d579ce30-4988-4f54-9aeb-b77701b2299f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 772", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("d58668ad-42de-4515-86ed-32660468b084"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 68", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("d5964b2d-4e74-4b8f-b4b5-95930c3dbc34"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 900", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("d5fce167-ea76-42e1-88f9-6d6baf25fe05"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 12", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("d6259e87-bc05-47c1-96b6-1bf053a3f4e6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 725", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("d656a870-f9c2-44b8-ae47-61da86eb23e2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 256", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("d6a97148-af0e-4ebe-9ab1-431117236a21"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 719", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("d77c11f8-e7f8-43e3-91d8-eaab44f6cac4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 751", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("d7e111b9-a96b-42a0-ba1e-02e7f2312005"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 674", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("d7fcf36b-b24a-4122-a2f8-8875ce39c8cc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 699", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("d9dd5b2a-0735-413b-be78-3dfda21772c9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 763", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("d9e8cfce-b99c-4a60-b2a7-260a103f5ef4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 40", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("da8c6af1-3d15-42c2-b6db-ecfe008f191b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 574", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("dac6fdd0-1ea3-466d-91de-13614ca5a065"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 233", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("dadd9403-85de-49bc-a48d-3d2d0be0d9a9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 354", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("dbdc2146-2d22-4aa8-90dd-fcf2bbea4e44"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 368", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("dbf3d2c0-a833-4390-90a5-b5704b6043db"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 873", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("dc8208f8-6a7e-4176-b3f0-978656c2487e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 871", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("dcaac5ba-e5d9-47bd-9811-dc2fb850b84c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 916", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("dcd98b00-22ae-4489-ab7d-b6cb4821c6ac"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 766", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("dd092109-e5f3-4ae8-95e3-3c6ed84c1e04"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 479", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("dd705a3b-325d-4dde-8dea-69d464aee407"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 714", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("ddc2731b-e31a-4de3-bbc9-b4a093fa7ba7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 555", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("dddaec51-ca03-4a0f-825f-36aef2f4bb44"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 614", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("ddf41c93-b0ed-4094-bbb9-f695aa08e044"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 741", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("de7a2f1b-4da1-4d87-8a95-6cef2ec90e5d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 501", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("de970e3e-ea77-47d0-8913-a9f0c57204be"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 284", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("deb179bc-97a1-4477-a726-206677716f46"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 54", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("df15f585-ad41-4fb7-b444-1204ee2c7306"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 446", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("df314808-15ee-4fd0-a8c3-c2812619a3a2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 642", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("df48217f-559c-4df9-8d8e-4e02b775d8b4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 30", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("dfb42393-f377-4d27-801f-d0d2c5ee22e8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 343", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("dfb5ce17-60b1-4662-a751-aa3380886d65"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 390", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("e0514da2-03f7-4aa4-a10b-9bbc9ba8d6f4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 640", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("e06ca5d3-264f-4541-b174-28762a86381d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 593", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("e071ef6f-0e3b-4c29-a816-ae77863133bb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 981", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("e0759ac6-79bd-44a5-8be0-e0f4a6c5b1a3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 955", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("e0a06d12-f552-4115-9c6e-642bf729ef43"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 259", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("e12e2ac2-d33c-4487-b005-13c90d1cf3af"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 450", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("e12efe96-0f2d-4fc8-ac6f-4d65694e55b4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 468", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("e1508d29-4c38-4846-b678-f1485027b18c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 752", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("e1ab1314-bc5d-443d-a928-8724e21bfe90"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 432", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("e1b5090f-8a3f-4956-aeb0-853057b504a4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 695", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("e1bfac0f-99c8-4320-9fff-731c469512cc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 329", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("e2126746-3acc-446a-933b-ba7277b3fc3e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 171", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("e3093d6f-effc-4f0d-aa90-9d40dac1ff68"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 72", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("e32ffe81-7fb8-4185-bf1f-0e8bbaedbaf2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 975", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("e33fdb63-ae72-47e8-8de7-c9752ce9f782"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 240", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("e3593758-6164-4000-ae83-9662d0dfef42"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 761", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("e37009df-2cab-4e07-b41a-ae7e68fa1bc5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 676", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("e39760dc-7d21-42b9-b944-93a74a116b31"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 4", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("e3bd9071-f011-457a-97c1-ec46f2cf9c21"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 228", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("e4504a59-167d-4108-8b37-e6838f8593ad"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 544", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("e478ef35-4c4b-49ac-a361-a4469576b053"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 874", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("e4abd3fc-e811-4916-9b6d-25242980b38b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 907", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("e5092021-9e89-4907-a806-9620f1919b0c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 856", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("e537a6e4-9e01-47fc-9148-cb1545eca6d0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 749", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("e57e545c-37b5-4ff0-9828-ffa983c3aa93"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 51", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("e5845439-e240-477a-8d7d-cc80a381c9b2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 963", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("e58f6444-2539-4dbb-b925-56b9f476a966"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 813", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("e5fe0b37-1653-450c-9306-e1781346747c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 940", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("e64c9ee8-dcaa-490f-8d1c-14c6a7e4e355"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 260", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("e689d069-d36f-448e-8d6e-9643c6f660ce"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 49", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("e7271cb8-d0df-48a2-8d65-df9cdaa8e110"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 613", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("e7a2a8d6-e003-48f9-b20e-b25d01014195"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 366", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("e80a47af-ef89-46c3-9952-79e36a7db056"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 457", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("e85f9226-a824-4d41-8b65-b61c8aa7b740"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 148", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("e8c4be7e-898d-40b2-a4fb-8227cb873a52"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 239", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("e903d443-876b-4df6-98f2-24ebfafc914b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 283", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("e98f51e5-1f49-4783-89ac-7fbf5e2790ee"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 275", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("e99d9072-08ee-4022-8076-ca617e47d231"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 919", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("e9e95d77-861d-4bd9-b3c0-60ec2494b240"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 888", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("ea03f53a-058f-4ba2-822e-413293514e91"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 515", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("ea210033-14b2-4a7d-8c75-b1683f8f990b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 188", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("ea85a788-0210-4c02-86a0-f65e14fc0a1a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 198", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("eb065525-1511-49b0-9b0c-cf64b7870dfa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 27", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("eb19ebf9-bf7c-4cf2-a466-ed4100e0f42f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 922", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("eb3569e9-67cf-4af0-b798-7e1594530102"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 926", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("eb6d8fd2-7250-4363-b409-c87da14e7378"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 686", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("eb85e5a0-301c-48c6-8654-577e76073460"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 568", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("ec135aaa-40e3-4fc0-802c-df626f6d6864"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 435", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("ec33859f-6cc9-4f9a-adb9-b76933e32210"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 851", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("ec3cc671-aa2a-4651-aa7d-bee855792b7a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 151", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("ed8afdef-3e5e-4f79-9738-5758444f8637"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 622", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("edae79b3-baa5-4dc5-8022-1b92cf9f8374"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 760", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("edae8a5e-2951-40bd-ae04-40415907f379"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 559", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("edb2d78a-3e45-4e43-af6a-ebbabc92897e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 296", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("ee3c8e5b-a542-4f57-a95c-2fad945d3410"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 966", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("ee57b93c-8dea-4ae3-8927-585dbd269541"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 834", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("ee74a568-b4ae-4568-8bd0-e75efba30412"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 388", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("ee76df6b-b421-4792-a280-46491f7ed816"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 917", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("ee9c25ce-a744-4105-9277-2fa5c9aae26c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 843", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("ef40317b-495b-4241-b683-57a84c8440bd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 541", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("efb697a0-fc9e-4426-b1c7-4299f38fc6f3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 99", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("efdb2e89-fd91-4f6b-b336-5b2c50f56e18"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 789", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("f0012585-4f92-4da1-8786-d4112f370100"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 490", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("f006229e-6ed0-4212-98a2-b1e6a4ded401"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 904", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("f08fb316-5bd0-4ab6-b504-18dce5d88021"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 23", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("f091a882-4639-4bf1-9768-1bc188045edc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 982", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("f0f32f67-3506-4073-9133-fc63a4c865f6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 426", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("f105aba3-51d9-4a3d-844b-546eee1433ed"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 362", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("f13e35e2-e7e8-4ad6-8d0d-9c237fffda5a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 470", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("f1735428-b6e9-4a81-b5b4-41db6d70bc7a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 88", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("f1fb401d-a12e-4ec2-a5de-2fe41c3282c0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 21", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("f1ffaa97-963c-41ba-997c-6900cecb8323"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 326", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("f2039a66-e005-4326-b538-d2e36f5527a3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 520", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("f2ad91c0-f957-416b-ad79-be64648e65bc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 11", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("f30ecde2-0f12-4146-8f8f-0a9869763cad"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 976", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("f3323054-de46-41f9-9168-46f8b204fda3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 265", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("f33505bb-6d48-493d-aff1-3f2466052cef"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 317", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("f3e6c25d-1beb-46aa-a1c8-9ca3ec2fe227"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 367", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("f42bb993-6208-4368-bbbe-4d1daa03757b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 782", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("f5048dd2-e28c-4bd7-9364-aa534829bfd7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 610", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("f5762f58-f091-4cdd-83ef-80b77770ad11"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 155", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("f5fdf17a-4a68-4c01-8e4c-9ed13078ba83"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 444", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("f62d7681-523e-4dcd-b4ae-7221b858553a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 386", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("f66b6d75-37dd-46e0-98f5-ed2a52503708"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 606", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("f6a09af4-02ed-4d26-a2b8-5137d6660e48"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 687", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("f7320f0a-dad4-420d-ae00-6dd6e01b691f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 448", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("f7849af3-4c7d-4a45-96a4-cfe8e53386fa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 428", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("f7ee2b6d-d511-406a-bbc5-e087a4ce507f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 254", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("f8335fe6-fdff-42c9-8789-343134dbff7d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 277", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("f8a3251c-0bb0-476f-8838-3eae39ca00c0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 90", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("f8d19c4e-9436-41a4-acd9-9c5534691fa7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 849", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("f911cc21-8eb0-4859-a87c-a21cb81da3c9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 42", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("f913a295-f485-4b6f-8e69-dc296f504961"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 756", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("f9177180-4100-4599-8c5c-2b577d81cffe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 249", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("f9391714-4375-4e13-9e8c-63fb28e3cbb1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 384", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("f967010c-6f7f-4420-8de1-71cc797293fb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 830", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("f98d7e97-d155-46f7-8577-6c7162bc9a3b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 986", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("f9b357a0-dd4f-4ac2-8086-a62caa359027"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 86", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("f9b4ee43-ba0a-4f07-8605-dabf36744495"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 387", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("f9bdaff5-edd1-46cf-b758-b8233cf1c6cb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 227", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("f9c015c3-eb94-4476-aff8-cdad649b5d64"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 481", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("f9cddd82-cfc6-4371-b4f3-97ab23ad6872"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 53", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("fa1358fa-71ec-4e96-be2f-8e4b8abe6bad"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 575", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("fa3185fc-1a7f-4f49-8ce9-8f304c583d18"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 440", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("fa80b601-106e-49c8-9c9a-7d026731e63b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 225", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("fa859083-c710-4427-ae07-69bc31e02d6a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 76", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("fa93bb50-932e-4ad6-a2df-ccdfdb67ae65"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 10", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("fb107613-1e66-4da0-acea-a87584e86291"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 914", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("fb1d1841-84dc-430e-996a-1d1c0fb67505"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 984", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("fb24d823-bb9f-4233-b8ed-2e1ec7aed721"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 106", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("fb5d6e81-bb8e-4051-b0f4-c871639f69f5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 165", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("fbc571cf-5e7c-4f63-afb5-9a7dabff5a64"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 333", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("fbd3d24a-529a-4661-921b-8d2880648c26"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 997", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("fbe5c3f9-2b4b-4f67-92e5-d5128a7a9c87"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 160", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("fc079798-2063-41a9-a948-1c6d32a2590c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 667", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("fc653c0a-bda9-4398-827f-e772f4762d27"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 89", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("fc831cb4-0426-4737-87d9-a37e005d7363"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 491", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("fcc0da1e-feb4-4806-90a8-cf9622c9a9c9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 923", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("fcd42bb4-602d-4a7f-939e-8d8129b8f7c7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 883", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("fcdbf534-32aa-4a02-bd39-cb424d9e5510"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 581", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("fd1528c9-dedb-4a83-a5ff-0ef89e10bb9a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 199", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("fd3531e1-7a65-4d13-baa1-f05c69cd4239"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 649", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("fd550cba-2ab7-4c0a-87ec-5f3d3f6f6e5f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 621", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("fd85b300-d48d-4816-aeb7-d393a94e5669"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần 5", new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"), null },
                    { new Guid("fdd9f46e-93d9-4341-9e31-d8bd76662055"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 382", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("fdee0ba5-7922-4f36-b0c4-23af2fc50332"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 328", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null },
                    { new Guid("ff409891-7db4-4004-8e80-0486d0c57ebc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo 618", new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"), null }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "CompanyAddress", "CompanyName", "CreatedAt", "IsDeleted", "TaxCode", "UpdatedAt", "UserId" },
                values: new object[] { new Guid("f6b5cac0-3b71-4e83-98e3-c6339f8e7fe5"), "123 Main St, Cityville", "ABC Company", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE123", null, new Guid("1152c3ad-d572-4913-a6e7-e172321a23a1") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("002d09be-fa23-45ed-aec7-b43640a2ec0e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00ca7576-8d1c-48f1-811a-e6d43e9c930d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0104b219-4cc0-42e6-80aa-f78efa2a11a5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("012f8646-258f-4666-a8c2-941f61003d09"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("01bb5261-f9df-4161-925e-625dc8247f5a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("01ce4023-e408-480a-b77b-0f2cf1df225a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("022474b2-769b-4a68-86d3-dfb283e2cff7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("022fa5d1-ed98-46b7-8693-aab179ae5b22"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("026e9d20-afb0-4b85-a25a-6c0af7350a06"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("027cd481-bc33-4014-bc73-f1b61ebd5b90"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("02be543e-5971-442f-90e9-40bae94139ed"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("02e40eb0-f947-45a7-80be-dc929979692e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0307710b-5ea9-4841-87df-dc5e281cb0ee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("034914c3-bfe5-47ad-8bc4-6989a72bd5d0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("034e0dad-f7a6-4792-8ef8-e141dc6d151d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("034ed9e3-06e0-42c8-ab74-fb6107e8aafe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0370fab7-c99c-4dc1-842f-d25a42872e13"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("038985a1-dd32-4c17-854d-bc44e3bc4532"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("03c18ae4-07e8-4e32-af26-0a636b4ba278"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("03eec2f1-643c-451a-8a10-703672313063"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("03fa75d6-7c27-4ac6-98b9-eb8b1f66f438"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("041456a6-7778-4ae9-9702-6170d5b2a600"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0482a443-c571-48b8-958f-e58932f5c1d5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("048db737-a638-49dd-b583-6467ddab01d6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("04af38b0-1cba-4bdb-857e-0076926e9e1d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("04c58f7f-880d-4a41-851c-140906940e4e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("04f89fba-49dd-4d13-bae7-5332e1568fbf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0517ad35-5fff-4fc5-8930-88f5d199fc97"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("05211675-c634-442a-bed3-62ecf13d2649"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0523bcd9-cf79-459a-84e2-a3e5feed9fb0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("053d3d9b-5312-4385-a7bf-d9cd3fcc320a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0572b0ef-7cb4-4a7b-b106-294f86031f73"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("05849444-1de1-4c96-b25f-822cb5e54e36"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("05852635-abca-4d43-95a3-964db02e6f48"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("060da8fc-9c75-4620-84fb-11075c20c134"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0610ca4a-d568-4614-a955-34d25e9119ab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("062b62c2-4e42-46ce-8410-17d8f11eb052"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("063fd565-48ed-42ae-8be2-963cc687caca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("067c3ef5-9f1e-4a40-9e46-27703d85989a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("06f20613-13dc-4059-8da3-56d23c178e15"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("07c078f3-0ac2-4837-97c3-bf81a7ad12aa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("080d9c02-10dc-478c-b986-c8d364f41bc3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("089a629b-6221-4535-bf15-4a95ea10ceac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("08e205ef-9e3d-469e-8314-fc563033c1a0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("09227b11-95d9-4e02-9b41-7fff2a63e367"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0949416b-21a8-4dfc-a1b4-61b8427b231a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0971641d-dd80-4f6e-8e69-e9385f51a09f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("09dc57d2-4fa5-418b-a93e-8c10efd971c1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("09e3dd47-09d5-4c6d-9463-88e100c3ef08"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0a032d35-7908-4f8b-b52a-7cc45e646470"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ac00934-f7ec-4e35-8e3d-3fe4bf6a4a04"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0b00e6cf-cf9f-4d28-bdd1-fe92b3840984"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0b0526ef-f37b-4fbe-8f95-9211144c90cc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0b13c263-bb3b-4496-8b83-9fed9972c06c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0b21965c-465c-4615-afa2-ba313e87da93"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0b47fd81-eb6e-49a3-b532-f3fdbf3d5942"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0bd0302a-60be-4f1c-bb3a-d8477cccb260"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0cd592fe-53f1-402b-826d-e525e47a28eb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0d1809b1-a30a-40b5-8950-dcf04a910da0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0d3ad4b6-c33c-4f0f-b04b-275b832eff3c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0d70abf1-4992-4002-b54a-c88a7aa6d5aa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0d854b28-dd64-4c58-bd64-ac246fe2e35d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0db84eec-aee1-45a8-b61e-4364a69d5b24"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0e090664-d4cb-4333-ba07-d7b05368775d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0e0c0b39-893d-43b0-91c3-e2fb0a5423f4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0e13d1c5-f0f1-48d1-8f8f-f5a27d969518"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0e27d1d8-92cb-4925-8850-714c000ccdae"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ed4bdf1-526a-4f58-b92a-3db869ad78ca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ef15c3d-7c64-400a-a6bb-4c08e9ad64fe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0eff5908-11eb-42a8-9a40-b5b55fde2d3a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0f36acc9-2725-4358-86e8-627436792010"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0f3b34af-56fd-48da-b9ae-1ad1113fdd1e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0f528548-d642-42e5-9013-5a22baec909c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("102bef0a-5288-4a5c-b206-7d0c0049e16a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("102e2643-8dfc-4b8c-9a63-019572744d3a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("10aa10fb-f559-48ff-8dcc-8d8d5b611f54"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("10b6acdc-d755-44f9-89d6-687c45545f7c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("10c421db-41e9-4455-a1c7-852f02600d0c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("11003beb-a39c-470b-9ea3-d24c91951e19"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1120740c-3bc1-4e3c-84c8-f736038bd27d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("117bc837-e4ea-4d32-b7d2-248b630b4867"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("11a16c60-8670-48ff-9dde-3e68e2d92be8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("11e75e02-fb4c-4fb5-a375-3da2047c8b9a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("120dea3b-b12b-469f-b675-9da1ba926e20"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1251edcf-c111-46d8-b3b4-3b7c0b9576d0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1323b809-76a5-466a-8d0f-1d60c26ec7f1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("137fe095-af15-48d8-9dec-71dcb9c6ad57"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("13e486e6-f309-42fa-ac45-af0053c17cc2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("14092c31-3c31-4918-82c8-c607ff2591da"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1437b43d-1804-4609-ab7c-8f9f9fccf66a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("143eee0c-df42-4f13-8bb7-d8435d7cef5a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("14e8ca0f-d896-4ebd-9fca-bc2666058ab5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("14eabc18-3b1a-4769-b25c-4f0be5c0f59d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("150668b2-7fc3-4380-b1f6-199b2d149b74"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("153cb911-67c2-4fa6-bc13-8e0397d2b622"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("158818ea-aa0a-473f-8d92-9e6c94043f9c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1594e221-e773-433e-8231-19f2247788c2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("15bc1a99-8ccf-4f18-ab5d-19720a53a25a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1633727b-58bc-40de-a5de-9f6942edfb7b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("178cae99-7f34-4660-9c64-42b6ae240b13"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("17c98460-54f7-4c51-a0e8-0bd0c1af39bd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("181e60ad-654c-486e-8c9f-37176fd42e1b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1923d9ec-f4e8-404e-8fc4-0835a2fc8638"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("19ceae0e-f2ec-4527-a8b6-0b40abceaa15"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("19f758a3-74ae-45e6-8732-f2a1cf30ce61"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1a057eae-2162-436b-8b7d-1d51364018ba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1a23c6f2-23bd-4275-907b-ea7d8a673a95"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1a39d401-6c78-477f-805c-b66c91998463"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1a803f77-a00d-499e-b73a-e389fc3a5558"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1adccc64-2561-46b6-9de3-09d9ddb35cd0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1b097e76-cbd0-415d-9050-931cae9e33ac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1b15ddfd-6161-47e4-af7b-9f6a81f3dab6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1b2dc661-3cdb-481b-ba59-78308423f044"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1b3ccdad-6a65-48ad-b3c1-f28e0bbdd610"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1b913dec-f792-4964-935e-5e468be28942"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1b943557-bd0f-4d62-9c87-f714a8dda80b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1bc441e0-0848-4384-ad82-aec625b233ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1c055ffb-1a43-44f7-9a6d-5f5d2d615bbf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1c3c408f-f627-40a0-aaf6-f9cd3e70460f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1c5849fc-ff9b-41c9-bdb0-f3bc8041374e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1c6395c7-5fdf-4bfb-aba7-d75dd5db7c49"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1ca3dfa4-5bad-48b5-bc57-055b9ce71f77"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1cab5af3-d59f-4260-bc09-c04d1f1b182e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1cb9ffee-d36e-4d4d-9d0e-d2e043a18efd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1ce7780f-4d80-46e3-a9b5-fb82181e5d48"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1d16f88d-983a-4493-84bd-9d71c284037b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1d50c1c0-f84f-42a4-a979-56906c639b83"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1db101eb-eccb-4809-b11c-922c8dad36c3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1e0cf29f-54ee-4d9e-bf36-08f5a72b555e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1e2d0ca8-554f-45c3-aa81-2e69561d9b6e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1ef2f2f7-edc2-4196-8ec2-3158cffc13de"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1f162684-35e9-4554-8ea0-0743dff6c53b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1f7f3140-1c7e-4b42-85cf-4bb4940f91d9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1fa903e3-9b6d-4742-9f88-f430c9dd06ca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1fc407a6-55f4-4cfb-a1f4-cd0330a177b1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("20004069-2728-4f8e-a84c-9e8c26f6a5c7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2011b069-554b-48cd-86d5-a4b6f59cad50"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2048cc30-6cd7-4622-927f-f162da7a8de3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("204d4257-2413-43a7-b009-fd73a0d856d3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2075a19b-1702-4e9b-9966-1a91ddf8db4d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("20a039b5-92fb-4072-a590-0eb5a86f6740"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("20c32a96-2566-4592-96cf-3c0c5ef6d5f9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("20d2e9f2-4f18-4fd6-b68c-171f55a56372"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("20e2bb49-36a8-4cf0-b068-b3f834a4f13d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("20fad80d-dc99-41d9-81cf-6b3d9eef1c63"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("214a39a4-cb25-41ce-b482-5320c6716462"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("214b5122-ecfe-454b-8c5b-9139e039671a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("21d73996-08a2-44fb-96aa-9aeb0592ee4e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("21e7aeb6-4c13-4c07-8dae-ddfc23846131"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("223b29a2-080e-4665-bfd5-dbdcc02c7d73"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("22d84fda-694d-4be0-aa1a-0709730dbfdd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("22e5803d-7d04-4f3f-9cf5-86b297471e99"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("22f2c09b-29fc-471e-90c0-1dae4b1e612c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("230f0603-1e84-4949-8dd7-ecf083291645"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("233ad97d-a09b-4052-8b23-f0f07e4c62c2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("239b882a-4d14-4f05-bc55-e81415f06fa7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("23ab6afc-b6ae-40ce-9b98-555cc6871518"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2406e26b-f596-46ec-8f4a-c3b6c8d4e9fc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2435442c-16a7-4d35-8d88-a0f5877d1d6e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("246b0a91-0ddc-4981-b28d-cdb9c2acd591"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("24ddb89a-b626-4ad1-a0b9-4441692aa613"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2534e1e0-aed0-491d-a0d8-4317de332722"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("25945f54-b04d-4fe0-bc70-e05b112aeea0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("259e9745-8000-462b-9366-711729c33f3e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("25a29b53-27ca-4bda-9b40-faf9d2f576b5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("25fbfa57-cdbe-40d8-9543-2c92a54e3362"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2668f63e-d698-461a-911f-541088ad0cca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("26ee9590-e5bb-4a8c-a85e-d17cfa514574"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("26fd4992-94bd-477e-aa1d-8ed0d0519aa1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("273c851d-5538-4399-8136-2c354f9668d2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2793a669-7ded-4be1-98d5-e928c7d4e8b8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("27c878b5-d109-4b90-9c25-f2290d59bcea"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("27e2e18a-4682-4d80-bbfa-b200262cb2d8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("27e3d360-49a8-468f-80b6-4dbd0559c8fe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("28c43900-f1a8-442a-a5f8-af5b16a59f57"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("28e3f931-986f-431b-834f-2a8107cbcb7e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("29134198-0af8-4461-b606-8adb67c83ca2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("293c98ce-7f6f-4f75-8baa-efee00978e8a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("295aa6f5-4eab-4fcd-8ef7-0974010da830"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("29dce494-2e62-4036-a11e-3781c2a7bb66"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("29eb0312-4d50-4830-bee7-8dfdea6e170d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2a411f9f-ce9a-4d7e-9348-17d5ea331973"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2a53cb44-dfa0-4637-8f5a-84b6a9fb50ce"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2b033441-b8f2-4d0a-acf3-a2e11edd245c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2b214576-1bab-4632-85c3-f497145c39f3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2b6ca37b-98f2-4214-83b9-e5a38053c9d5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2c27e06b-923f-4e20-85aa-2e91b13ec66d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2c4df7d5-172c-4b6b-bc43-ab697bd3d778"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2c66328c-5ed2-466b-a6ac-bff03c1c5ba7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2c74b000-5641-4e5d-9ef1-e592cdef5afb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2d259514-d0e0-4fe1-819b-b93a65cf6d6b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2d29e42c-2756-421e-81ab-d2de45e905a7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2d4b6dbd-0bd1-460a-ba05-454c23ffb4ea"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2dcab973-1a7a-4e0d-9caf-2f347c17cf45"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2dd4d3ac-be51-4717-a8f2-939241f3d639"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2dfb03ff-0edd-477b-b55a-9863df7e441c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2e60a12a-f98c-4201-9195-d7137a11e343"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2e8e7876-f930-4faa-8657-e46f52807b38"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2eb91d8c-c4ab-4bf5-a546-1503b0362d28"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2fc2cfd9-653d-4214-9384-7dcda1727d30"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("300d1031-f663-4ece-9c5d-ca3c3eda752c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3056a2b9-2e6e-4241-a071-df090e3a1e0b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("307c99fa-5707-4025-b901-0817f374f204"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("308bb737-5876-44af-b2cf-07cb9188d958"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("30917b6d-49f7-45aa-bf01-c1c8076aac05"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("30ac0a75-bc04-471d-b243-18d00903c7f8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("30b77dc7-db9e-4e5d-85ea-2574031491f0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("30d0ea2b-d378-4fdb-9952-9d44d754ac97"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("30e71711-cab3-4a4e-8237-4324b78c3002"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("32156bf2-b209-4761-930b-4c6697cf8dde"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("321df0d3-0598-444a-93e5-b06be7936c32"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("322c0a18-9046-44cf-b061-ca63db2cf641"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("325ab73c-5820-42db-8ddf-a0bd15902da0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("327c740e-7b44-4f0e-a12a-67bf48271cb9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("32fb1a6c-8c4d-4c3c-97f2-035198b6efd3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("333f0ace-8091-4cb3-af02-2b77fbe98019"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("33cf4cc6-dd8c-49cc-b2bf-4100df5cbac9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("34041cca-e3d8-446c-ac44-681a2e513e1d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("34599576-999a-40e0-9058-96b836451da5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3475cb95-fa26-4a3a-883a-ee9e96128d66"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3483bf4a-ad32-4d03-810c-4a9c5a0eaed1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("348fec03-d5bf-4216-8150-491f9ea54167"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("34c66037-5fdb-4da6-a0b7-f7044702b12f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("34d92463-9bc7-44a8-be78-d7bedc45aa65"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3510962b-a9eb-4181-85ae-424ee3a80b91"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("351f5757-5620-4cd9-879c-4e72c579ef18"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("353ae88e-f5d2-4c6f-a633-7d4c642c3b11"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3548cd7d-4ced-495c-92c6-14fa3140b957"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("356c2ff9-da49-4c5f-abe7-edd660ab01db"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3590f789-b0c9-4ccb-8630-c3b4e357bcf6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("35bf2b97-66da-44c4-a79c-1d600dca02a6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("36102ee8-ce95-42b9-8b20-c18ed23640da"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3617d1de-26b7-4452-84fd-df38cb457f12"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3624ffd3-5b57-4879-ae3b-b6d35e6fc1b6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("36c18ba5-6f89-45ec-9961-33c01375ab3c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("371cd0a3-199a-4afe-aa8d-45dce185d4d3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("375c0def-0dfc-4f27-962a-ba99975fe4f6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3760642f-83b9-4427-a774-9499a944b5ef"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("37dd5963-430a-47c4-b06a-05d7d0145917"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("37efe076-78f9-4762-97be-4c4c78b03374"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3802aef7-4b44-424d-9b6a-7b4c41ed383f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("380a8b05-bdd1-4493-ac22-c43bf7cc617a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("38306984-108c-4fc5-94e6-bad90afd112d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("38ca35c4-9cb4-478b-8abf-de5a85687252"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("38e64781-f317-4180-a581-e485ee27cc48"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("392dd39b-1169-47be-a50a-27a16f2c580b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3959e32b-7131-48cb-b6a9-2623837e357e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3982699d-780d-4e7b-adab-3a0f0547e8b4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3a231dd6-1086-4e02-bf45-016428502ebf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3a43fa35-e0ec-4ef5-b2d1-52cda6f3827f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3a6039b2-5f55-41a9-8f88-260379bb21f6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3a7717bf-6835-4e79-8f59-4e2da9167b71"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3a9f58bc-7559-4cb6-8478-c2550d262ca5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3acd86d0-8aa6-4acc-a51c-27bc2159d03d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3ba44478-756b-46db-a105-bc3b80b93569"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3c2a5caa-a6ad-4b9f-9e24-a5105654e85d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3c86c2bf-790f-49ee-a1e2-d83039c5644d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3cf09d06-972a-4b01-b308-23f94a81bbfb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3d447520-dd44-4e25-af22-67d836e53044"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3d6e7f02-b77f-407b-a7d7-6329797c5af2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3d7a01b8-3be2-4916-813c-5e1b673a5567"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3db14ecb-bd5b-4b59-b811-bb63309766d6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3e3558d4-64e2-47aa-b9f3-eba147e49ff4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3e5b009c-f021-4230-a55b-b4dd45030a60"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3e66ea42-5522-49e5-8ded-23d0143751d9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3ea44795-2303-44d6-80c9-0da0d2a9ebd0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3ec7467b-f167-423a-b812-145efb8429dd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3ef20926-6d11-465e-b0ad-f7c5f05ed23f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f0e08cd-3887-4def-8cc8-6c8b67752b05"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f52d1c9-850e-4d70-9dd2-d704186deb60"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3fbd2b9d-5ccc-4335-a6a6-f089dd7344fd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4042c98d-8ee7-40e9-ae18-4ae7738ee755"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4049d3a4-d58c-4092-9ea4-941c266c2a5c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("404dbf12-6335-44cd-80c1-1574592d4b5b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("40ce9d33-24c6-475b-95e6-4c8ab8ba855d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("40e736b3-1236-401d-9d18-103db06e819c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("423b4c60-25c9-43b2-91b9-a6dedf202a56"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4269d14f-7770-4354-8aef-e9e6813cb676"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("42a3634a-d033-4ad6-9915-b829efd9435c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("42ca2935-70f6-465d-8aa4-217530940688"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4385a525-3db0-4ff3-8e11-2e24ea08b280"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("43f2d122-3cb1-4cdc-91f6-bb0e2bfb853b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4419d792-c88c-4cd0-845e-28658ab5f5af"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("444d5fad-1203-4465-90ca-2ec10099edef"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("445735a5-a375-4990-b2df-88a90d14b00e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("44731e7f-c583-4852-b501-c9d188163870"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("448a465e-1794-4724-b522-980188e9c912"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("44acc8ab-c51a-4272-9f69-ee31e2301a31"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("44fc0862-1ba1-4fc4-9853-ac3e2d45082e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("45f8715d-cc7f-4ce1-b13d-3def92822ff6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("46165c2d-0f4a-4b3c-bdf3-fb7281677af4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("461b9b84-e0b0-4d40-ab24-817b282efc72"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4626fee4-446c-4a76-b6bd-2897d28fdeea"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("464102de-f157-44fa-a468-55e8a2aea6a7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("46548827-f3d0-4d5d-9c52-01c3654c204b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("46cc536c-84d5-448c-96d3-cc1f4ef9dbfa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4714f976-a83b-4be1-a98f-109eb2170dcd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("472eab19-642c-476c-adab-94ed03821f16"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("47379400-5aee-4d93-844e-b372d1367dae"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("47780411-e9e8-424e-9553-ba98598d137a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("47930b66-cb3e-4e1b-a0a7-f860c6a7c7d6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("47b2f12f-edfa-497f-b8c7-b82f477a46e7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("47f973cd-c7bf-4009-846b-a851407a9734"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("485ada1b-7584-4e25-b9aa-bd5c414d5b7c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("487e4075-6aa5-4779-a76f-b005d8f82eeb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("488633d1-068c-4a3b-aebf-054c214d56b0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("488958ef-17f2-4e53-96df-976b17a3193e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("48cd4cc2-d4ce-4115-a158-20ec523ee2e8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("48e3da21-dea9-4329-9954-dd191783e8f6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4921dc33-97fb-4198-9aa2-1910daa8358f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("49539d90-c139-48ae-9571-1484e3e929de"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("49609b95-bbd4-41d3-95fa-7ed84c17f4c1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4976a06f-040f-47b1-adf5-a05f5cd407f5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("498088e7-2c0c-4eba-a058-426a6b647feb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("49e0051b-3a3d-46b1-88e7-072a2fe88438"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("49fb3d71-dc4d-4b6a-ba86-691a2374bd69"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4a42aac6-aeef-4d08-b5a6-689c3f4825de"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4a741af9-f10c-4195-ac99-45488bd97aac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4b0a246a-ba5a-4217-948a-5c394c9af7be"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4b23517f-7d2b-449d-8bef-33599e9e810b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4b632ea0-1181-48c0-a2b8-528833fa1964"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4b7fc85e-abd3-4b75-a6c4-2773424d2753"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4b8776f7-5af5-488b-8a64-dcdada8d6520"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4bb1fe38-d96d-4362-ae66-c47c06ab84f9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c283f0d-aae7-4c90-866b-8cb676743fd7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c2fb61c-c4d7-41f7-8141-88f3f2aade74"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4cb2041f-f4e4-4a1a-8a0c-081cde4efc5c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4d36a48c-2dfa-4da0-9233-6f110f46cceb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4d38e7d8-493e-4eca-b110-9c6815b1982a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4d3d7874-1cbe-4d96-9efb-ba5d8001ee4b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4d4c7e0c-9f91-46cb-8c6d-404e5959fa2f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4d6c72d3-6ec8-4b0c-968e-7655a8796173"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4d785d79-8e2e-4e75-be83-c338343e0988"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4db8eaf3-f0ef-4f5e-86cb-a5e82d1969f0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4de7ea94-23fd-42ae-ab7e-5c33c5fad975"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4e999b57-4e4e-4bc6-b099-3c4897fae6ab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4f094307-c130-4954-8de4-b2aecca2d0e6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4f2ad724-e5e8-492f-ac4d-b03d7c55a142"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4f768b9a-1a92-419c-911d-03d8d61fdc94"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4f781193-083c-485b-aa9f-a1b2f08346f7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5052fdd9-d5ca-4009-85db-59b6a7f98437"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("507c5568-7106-4878-a5fd-b63938096766"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("507e8114-f8a9-4f6d-b1a8-5f4480024345"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5082f88f-1d44-4a42-9161-f01a36ac3d6e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("50c4657b-4bbb-4984-9bf9-8f965268e575"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("51133396-5ff2-4ee6-ad05-a1a974b531f4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("511d121b-d3d2-47b7-a113-e6fca267f68f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("515617cd-d661-4d55-803b-20d57296237c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("519e8daa-fb3c-4b7f-a370-52c92e79ab95"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("51a81649-16ba-4eee-b4bf-bf6127dceeec"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("51e959ca-f0ce-43d6-bb5b-08c054329e44"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("52c1e21a-e1a4-4bc2-bcb5-450f413c3ce2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("52ce8f06-8803-467c-a338-e6fafee6bfca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("535279b4-9d87-4f78-aa64-36fd72d4c087"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5366e9ae-9b4c-460e-b029-24f7fdd7474f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5385bb75-c5cb-4c78-a5fd-bc7a2dea9683"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("53a9c67d-a675-4ee8-8f51-f3826c8d56f3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("53d6c1a2-9a80-44c8-9bb6-f83f3f49ee2b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("53e9761a-7bd3-4d63-939d-af20dd1d2f3b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("545c5ae0-7abd-4ab7-8e17-73ada0e77b02"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("54bc1077-fa4e-4b32-8746-76262e1baaca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("55bca52a-6f47-413e-8381-7f91022c9f6a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("56251ed5-9df0-4baa-a4b0-3ad54e2bf491"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("56416996-005b-4349-bb84-d6d2df6da23d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("568f447c-3995-4643-8f98-3ddf79418c63"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("571539eb-8c6d-4255-a56d-1f66d27c5700"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5729bbfc-e31e-4960-b8e0-8dfcaca6c81f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("575b1fa9-10d3-4d29-9973-863682bff152"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("575c16a2-640e-452a-ba80-9a21473f4d1f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("57b27f72-45fb-4af3-a17e-5304241abdd9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("585367ef-81ce-4d3e-bf02-6dfaa7519d4b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("58bee705-2c26-46a0-9835-dbed8e770286"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("595b9fae-ee91-4372-8b62-3fbbb8b92524"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("59905c88-90bb-457b-8a83-6ef6ae48a414"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("59917fcf-4791-45ca-9653-6db03b0b3c26"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("59e09812-9b38-4853-af6d-2814c34728b9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("59f80011-2c0a-4d32-9c8a-82f67dc567c0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5a45be4c-ea84-44ea-a4f7-ab61735a2a1f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5a4eeef3-0cba-4cc0-b42d-b5eb42e00b68"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5a5dcf85-90af-4aab-b243-27a380f642e6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5a622bce-4b97-4cf6-82ae-bb0f748b0b50"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5a66ae49-4d34-47e2-b458-ef98c9bafb18"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5a83445a-25fd-46fc-9992-17a05098b63a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5aa8415e-8efd-4b1d-8a61-04d04243240e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5b3fcbfa-01d2-49a1-ae8d-68b680aa6c7b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5bdb34bf-f010-420f-9658-8a57b5d48e0a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5bdc677d-dd78-408c-973c-4ee175b304dc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5be795d1-5458-4575-804f-818491fa9260"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5c6dbe7a-63a2-4f04-9887-0c57ee68b34b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5cb02205-f129-415d-b412-67219da30d3e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5ce224a5-0103-4286-bf2a-c4a5901e3687"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5dbe9470-719a-4eb4-a021-3f2f4a1accdb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5df5975c-8fb9-4c2e-a01d-71fcfa39f768"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5e78e4e9-d9e2-4400-81d8-7421bb7f192d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5ea59a4c-5162-41da-9d60-8867e6e6fd70"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5f123708-30f5-43ff-bd9a-c7cd29c2487d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("603fdfba-0315-4b90-bd31-b3baf19c5ac7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("60a0dad4-3e0f-4d4c-bcf3-42ba9cf9c377"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("60c6974a-f9c0-4fb5-b2ed-82e01ed7592f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("60e9b765-393e-4f41-b92b-4f613e92bf11"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("60f48abd-f509-4634-9569-5c7bc7a57da0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6136fee7-edc9-4427-b93d-73c910ca6a06"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6149a855-c940-46df-87ae-680e5187b970"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("614b7d1f-135a-4300-95c4-db450d7d0168"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("615bf9dc-01a8-4c42-8cb8-f5aba47b3db1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("61956876-0932-4509-a709-eea86ba548d3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("61b5978f-3412-4114-bfe2-bb675aa94a29"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("621304e2-570a-4f51-9406-3b3b05fc55c2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6228332e-80b8-42f4-924c-78cf48b17bac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("628476e4-7bf2-40b3-8f97-315104ffc41b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62c0177c-5469-45d5-a386-620475ce09ab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62ccf462-7ba5-4899-a0a7-0fc6a2bbdaa8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62d51f14-bf5f-4156-8235-d4697e7790a5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62ed8783-1d23-4431-be67-cd7c27e3b8c1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6300014e-220a-4b3b-9267-2ef55a57c5de"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("63135955-db3a-4264-861b-3e5cba495a72"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6359dfb0-ab8c-4a74-872f-308e1e801ba4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6361e95b-70a1-46f7-ace6-622008ac722f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("63bd1675-a057-467e-a48f-da4b703930f1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("63c4fa34-5ba0-43c3-a5fc-45e4b22846d8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6414a7da-62ae-44a5-a328-822327cc2d9f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("64a44b6d-58f7-4d6f-ba4d-cc6343155f46"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("64f25e19-39cb-41be-99b2-8828d80c7c9a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6515f352-05e5-42ab-a648-502244baa598"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("651644a7-0194-4c5e-9095-f8393cc96acb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6576666e-d555-4f64-a9e6-5c3e30a6d216"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("65ab7177-2bd0-4ebc-a929-361559dbb896"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("65f1ce2a-7203-4979-9698-c35d20d9b013"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("661e4dd7-9a90-49c8-baf2-5a70887585ba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6665b71c-e919-4063-b9db-2973b00567a4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("66ae852a-af1c-44a0-984f-7bbfbbdce926"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("66c002eb-5318-44cd-9cac-dec08c6154a3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("66d49788-c823-4dac-9874-8ce2cc3f7f58"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("66ee5e2e-228d-4a0d-89a6-3e3a32e49716"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("66f134c4-5010-4618-9d57-d29484119bcc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6731e615-f8e7-48e5-8e33-4cdcf074468e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6741a467-9fb5-40c7-8b86-abb0c164e340"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6752add1-ab72-4879-8bdd-1e986a3a086b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("68b58f9f-2e5d-45d0-a719-334b64d7fb70"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("68e0f2f8-e7f2-465e-99ff-4a0ec2d43e89"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("69126a1b-b0f2-4ea2-81d0-1f2e9a335d87"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("691bafa3-6334-4549-9472-418d2b0c847e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("691fe65f-5767-4d53-9c01-d6bc0a0965c9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("69955e8e-a3cb-46eb-82ee-b8c00472793e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6a0791b3-754d-4ef5-9655-9a002e7825a9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6a1622c2-e354-4924-b596-8b39e2c2ba3e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6a466a9f-5324-42cc-84c8-a71e8cc6cb71"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6a60da57-c6bf-4cbf-9dde-d11331f46503"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6a939de0-ecfc-4e5a-8c16-96157505a383"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6aef6d5d-9755-42e3-81cd-fa40ac17e705"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6b08bae3-87ee-4e70-a50b-f4f320c92ef5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6b798dbe-29d1-45c2-b430-8d4491258064"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6c06e361-bb1b-4d7e-83fc-97be903b2f49"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6c308e4c-44fe-4970-918f-3c9107bdd641"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6c77f640-372f-47b6-982e-6b01f20c31cc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6c794c41-88c7-4e24-98e6-beb75d9f7c0c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6c907704-1dcc-450e-baf9-d6e69f3a251a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6cf7c8fa-25d8-4975-bb37-f4f9d75a0f67"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6d0311d7-ab03-406e-8fd1-7426ccaa2d04"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6d2f6959-0047-4fd3-943b-b4f007eea18f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6d7a0b72-cd78-4b99-ba72-48aa9495d36f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6e168d8c-c992-4b9f-9ea6-1240884b10c6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6e44ec15-70a7-4e71-98c1-e343e0465d42"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6ea68f16-1033-4d42-95b4-5fcad98f100a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6ece044d-299e-4b83-b9af-bf9003338c5a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6f25f4e6-9d47-49d7-a85f-0ba44c9e0ba6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6f3389b7-1ce7-4f00-a6eb-45928061be87"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6f583a4c-5001-4a0d-88eb-7e0594935405"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6f76950c-5d60-4266-8228-7afb19ef66b7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6fa2974b-414d-444a-a86e-0861c457b5f1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6fcf9c4d-e6c3-4d8d-acbb-4fba07cab02b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6fe4bb40-c130-4de2-b95a-fa9189e58ad6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6ffd9503-c5f1-4ac3-85bc-67b1996f0e63"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("702133d2-8c0e-4da5-a1da-8a4498803045"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("702af30a-8c46-404a-a50f-9a2f92c19ab9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("70de84c5-887c-472c-8a47-673be0654122"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("70eb00c8-ea52-43b8-bc0f-35879a2132e9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7116e9c2-c060-40fb-8469-4eb80ca60584"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7184dd93-5c43-412f-bf51-8a2ea7b23609"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("720b1fec-e639-4b08-90ce-e125df75c9d8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7220bf3e-c3cf-413c-a8d8-3266feb938f0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("72a4e866-e960-4c44-8560-d7a7032c1e1a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("72c9ac69-8779-40fa-a2a2-bd23bf319965"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("72e7d3b5-3b8e-4bd0-95ff-71f8324543fe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("72fb6985-a267-4215-ae61-9efda9339664"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7327bc9e-c2f8-41a2-8f25-fb08099998af"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("73342235-35b3-4b36-b551-c34ac089022b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("73573637-7f94-4074-9472-c849589ced7f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("73dd5f20-619f-4938-9429-54b2f65fa102"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("74c40980-3098-4c94-8303-4654df8783e1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("74c6fcc4-d59f-49fb-8585-0711afc7b820"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("752b6aea-795e-4470-aa61-3a4160e825fe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("758be912-2183-45e2-8ef3-28648f5f09ae"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("76064514-6962-4905-a99a-5212581b42e2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("76bc06a3-6642-4042-b4a9-6b1dda972784"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("76d2ae61-1f18-448f-af1f-60278006a4ae"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("76e17898-d500-4e84-9499-d5605fb1f528"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7700c83a-9899-4475-9a94-1dcc24d3e8fb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("77c07f23-d8ff-41a2-b9da-2157f98f8ae0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("77c79ae8-0284-4086-8ceb-6294fc537c19"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("77ca3d0b-961d-4062-b6d8-675712382daf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("77cd8c6e-db4b-4579-a773-f3a73ca91fc1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("781a73f6-1076-4159-913d-b2b367aa0d47"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7834d83c-cf69-424c-aae3-168ea9d9a255"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7874d40c-cdc2-43f6-ba74-fb9e397aedcc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7992578a-8359-43e5-ad3c-3ba1b1d32143"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("79dcb78b-c44f-479a-a9e3-0937aa194bf6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7a07231c-143a-4e3a-b765-97333f6f737b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7a1ff96d-bf74-4e07-acce-abd76068cdd0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7a5242d8-4982-406a-9d4a-30a8bdacf2d5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7aae3217-2c06-49fd-aa7a-66c86089d7a5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7aea12e5-ddd4-42a0-b658-d19ee9531714"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7b0a86f9-1795-4bd4-a51d-2ff3d165007f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7b2c9baf-366c-4610-8005-b279861455e6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7b8fa2c0-31fc-4f48-9866-3e76f54bba65"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7bb5b9cd-e7ef-4deb-9e7b-05af9c2c7805"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7c717811-4886-4b22-b0ce-fcd55446ce46"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7cab6e9f-c959-4f9e-8715-a990d4cb9f04"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d282b1f-cf48-411c-b89f-2a05b26823c1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7dee7a4c-05ca-440e-bc23-90393b8dafc4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7e450f95-9a3c-4742-810b-2e8fc2fc9767"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7e4ddfa2-3838-4df2-92c6-df987c940ee6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7e62083b-1b0b-4367-aca1-3fbeb4e02571"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7e72e4bb-eeb0-4f9f-a1f5-276cdfc0a944"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7eccff0d-470c-46bd-a6cf-02948c8c8b5c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7ee2d9e3-1abb-43a7-9da8-c414c298e79a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7f4b8893-5d9b-41a0-9a19-0024ee795c20"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7f7d41a1-e589-43f3-a7cf-e39b6551ea49"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7fb02b8b-3a53-4d46-923c-145223b0555f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7ffb5a8f-2111-45a5-841a-8b7bb6bc1ac8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("801099cf-267e-468d-b03c-b8099f01c075"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("80388753-f0df-4346-bb53-8dfb5d06bf90"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("80bd06d7-2661-43d6-b4f1-261ba696bb87"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("80f34ab0-cfb0-4340-abfd-a788a9d0f72e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("815a945a-65bb-4247-8c95-007acf26b194"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("819bb326-bce1-4ac6-b0ac-88a943b2b1bd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81fadf8d-6226-4dc3-a4de-4d52c9fed708"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("821b711c-e9dc-4b99-9c0d-2b7aaae2e029"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("82202e8b-b793-4fa6-912f-8efccf6354de"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("82585b9d-a282-4a33-b490-b939e42354c5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("82aba22c-2495-4767-b541-56fd20b7fc51"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("82cb1319-0b4b-488d-9022-f6f8583f9344"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("83844c97-1d1b-49c2-b907-a86baddd259f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("83bc85a6-2087-4b88-90b7-3c9a52ba671e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("83e75d87-9202-41e7-9dfb-c332adce75ab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8415119c-0676-4643-b04b-bdaace8cb28f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8445e567-f92f-4e78-9130-90dc6e69acea"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("84528f80-d40e-4973-96ad-21b6c07a8e80"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("847b356b-a08e-4797-9ff7-c6045b537c8b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8495bcd8-38fd-4e6e-9141-4464d266fe75"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("84a6d4ff-3320-4a75-a5ec-03084d0f3722"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("850319d7-d02a-4463-af24-1260ef8596d7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("85172d63-1fba-46e8-8c25-433f9e75f533"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("85270ca0-4ab1-4612-b145-bb248ceca7d0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8615fefd-d861-403f-ac9c-807ec5156630"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8644e6df-fe99-4b66-999a-e2bf9a8512f1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("865bef73-69c4-4cd7-8897-06c3aabb418f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("868cc47c-d232-44ce-b477-95e6b70c9dfc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("86f0afe7-ebc4-4f1b-b6e6-9f1abcf897d9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8741c9b9-58d2-4c20-a1ec-23f5951438de"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8758d95c-fb76-4281-8690-9bb2205b730b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87c3835e-df2a-4c15-b9e2-5c146d2b1cfe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87cdde21-b004-4a49-8ac6-b390bc91590a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87fc65e3-28bf-4884-bc85-7240fb02bf17"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8818838e-cafe-452a-955f-f8f2c73106ca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("881914d0-5e77-4e28-8245-bf60e4c8b556"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("885b4bcf-650c-4d88-9338-7dd4e58d2db4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("88968ed1-b5a8-4cd6-ad18-a9b59e6d1ae5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("88f4662f-2a3e-4134-9d50-dfccc08ea2af"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("893c5743-8ec4-435a-915c-11ce065efa61"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8962aba0-877c-4bf0-bbe3-dc1966b2143f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("896586ad-2681-47ff-99b4-875e9e63a804"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("89c663e9-5a3c-4ca1-a7a5-0e78955394ec"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("89f888cc-6f1f-4b90-8162-41b11f575473"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a7e7554-a251-422e-b170-af9714363bcc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8b251c54-34d3-4dae-b9eb-a62a74f71467"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8b58ce84-4ee4-4332-ac1f-048340bd9a99"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8bb99683-802d-4bec-aad2-8eaea0f5b2c6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8be90234-aa5d-4b8c-94c9-5cc327951086"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8bf3cb5c-1dec-42c8-a525-4aa5c7b7a1f4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8bfc6f35-0474-49d9-8b68-ae74ac29f593"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8cbbcb2b-5cf4-42dd-82fe-acffd1e8b3c6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8d1ae0bb-1c28-4176-9e36-e75a20fb0099"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8d352775-cc2d-48d9-8d85-13464db9b569"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8d4c3ebb-1e5d-4c72-b331-72fc50c35153"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8ddca6b1-45bb-4763-9504-b8cefc626048"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8eb57d4d-0e97-4b23-a43b-6fe0a76618f0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8fa0613d-6864-40e1-bc95-a2c7680ffd7d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8fecc3aa-16f9-47a9-a2ce-403571893b00"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("91336345-e3e7-4b22-8a06-237c0c769661"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9153a4da-f341-4c2a-b5d6-c4f7dc2c811e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9159fa2d-0f8c-423c-a32f-6705262f5e88"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("915b4134-44ad-48b7-877d-ab2187385fa3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("91b56f28-4aeb-4049-b927-69bb143809ac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("91e73903-65c9-4c4b-84f8-08c3a577a078"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("926e7add-323d-4162-8968-e7a3b40cfa25"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9285395f-07fa-4e91-8196-ee3ebcbd206d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("92b483ff-2201-4f9d-8090-8c24a9ccc555"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("92c34363-fcd4-4960-aac2-9693a34d6741"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9386fdab-bd2e-4d06-9eb4-525c0423fe2f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("938970b7-4e60-4b90-932a-a9a6f5c75911"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("953d613a-9f97-4ae8-97ea-563b03f3e66c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("955cedb6-93ec-4bea-a16f-6acf1b5e9636"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9685002f-fbb5-4d89-8f20-5bf685cb6860"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("96a76bc9-1767-4db7-87e9-d7453fcfdba1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("96eef247-fc3f-415c-84eb-193bc4a61a4d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("97652cfe-4939-44c3-8f05-445f8ef77986"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("97c667dc-43cc-426e-b2ba-62aa9a2ba2a5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("98018881-ed41-4624-9ba4-17a481b49920"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("98199cc8-3e67-4159-9094-8610738e73f3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("986ca4fd-5624-4a33-8c74-2e0052784364"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("986fd571-b404-474e-abc5-45241800ee37"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("98a168bc-4a76-4804-8dd3-39bec0c7ee3c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("98f7134d-b015-4507-8804-2c50a9d81834"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("98fd3478-933f-425f-9787-f5a19ec7f5ca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("992aebcd-a8f7-4764-a7a5-553408dbf647"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("995f4744-3f86-45b3-8571-ed6fe2cb78b0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("99bf4f45-f1f7-460c-afeb-d485ac191192"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9a2e3b49-f9d6-42e8-9552-99b8038579af"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9acc40c5-e01b-4c12-bbe5-7db7c91da63b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9b0e983f-33ee-4423-9a46-b32c992df9f1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9b97970f-2575-438c-b495-9275bf05761c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9bfae9db-322a-42e8-bca8-18420310c42d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9c84034e-3637-44a4-9c16-eeb708d02ba3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9c9b670d-168d-4139-98a8-6285ce8f433c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9d14a8a6-c8df-475a-8cf7-ae9fcc437d7a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9e0a9652-4a45-450d-bf27-916e793a5519"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9e409164-0a99-4305-88db-f6b20f9d3d2b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9e5bd150-9575-4920-81b4-765b029eb6dd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9f0b141d-33b9-413c-ad49-8e8142415b66"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9f2c4a69-5cd5-4164-9078-4aaec592b5d9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9f448fa9-e13c-4f48-b876-ae95338e9952"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9f737340-775a-424c-aabc-c4073141e4e4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9f7978f3-c1b0-491a-8bf8-db3e6eb8d8cd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9f7be53b-1417-49a4-be7f-5f4711d545a3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9f820c9f-4b8b-40a8-89e7-bca5c26b3111"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9f826364-74d8-41fc-b81e-25a68be0b92e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a02f471d-3484-4f07-b14b-c018eddbb0f6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a03e2c0e-4a5b-4381-9b30-93867c93d657"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a04ec928-cc4d-4e7e-9116-510f4adab0dc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a0ce465b-6e9f-44cb-b63a-b9d775a851d4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a0cf61bd-6c46-4d9f-b03f-0df30312f671"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a0f824a7-d235-45e8-b26e-39ed29197098"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a0fe2082-f66b-47bf-8515-70685327d6ef"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a19bb7d4-1212-4e96-ba71-ef21955daaf3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a296cb2b-8a0e-4661-bcd4-19a5aaaa951c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a378f2d5-d7fa-489d-8d11-94e843fdaf5c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a3990033-6422-42e6-9abd-0e6aeb6eae38"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a3d078db-fd7f-47da-9d9c-a4d982070ac8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a3eb86f4-40e8-4880-914d-1790d693812f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a3eef1ee-cad4-4bb4-b76d-1363ab148a66"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a446a3ca-4cf7-405b-9930-10b0b0965a6c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a457d2e8-6b4b-4442-9f29-ebe15de774ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a4adf4f6-d296-4035-abea-60dd5aaa74ee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a4c3ef9d-b5fc-4cbb-9837-a0e78773c4ad"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a4e8c588-f09d-4c2a-beb6-bc6e2b68b3cf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a4f4ce69-9e72-4f94-b68d-3f237ca511d6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a5a4e960-fde5-4a51-a76c-93e06de96331"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a5e16084-62af-435e-831f-cfa76182db79"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a656b918-8ef4-4ab0-b600-c4fd632b64e9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a65ccbbf-d800-4700-8609-cae2d52a3e65"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a6a65828-fc5e-4f00-8ba9-df7db835162e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a6e2fe2c-3363-4f7e-b48b-45a43bf9bffe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a6ffa7ff-aea1-4da9-8c62-e69f40b9da3c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a7afe39d-ec6c-4a05-b334-59adcc906c2e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a860593a-f129-426d-aae3-16a56816cb77"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a86a4df6-0c13-4c40-b4db-9cf5c1cb39d1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a8a18403-229b-428e-8d8f-e52b4c01cb57"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a8f8a93f-aaf1-49f8-9d37-e11885b34f90"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a91a80d3-d1ea-4bc1-945b-c6cec5c280b6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a93a3b49-d5ee-4064-9c14-61d166d377db"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a94ec600-a8cb-42a3-865c-51a6a6ba4eec"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a99087ae-f04b-4e33-ad81-6afbb6d372ef"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a9965acb-98ed-40a6-acbb-88f0047db302"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a9d3de13-fe38-460f-9549-3fd801ea7c58"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aa609c65-46f6-48ad-ba53-a24fa65117ac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aa93fd05-0eaa-4445-820a-00bda955b54f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aadc25b0-927a-43e9-8a92-8274f143c64a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aafb886d-5d0d-4756-92fb-d6a10440d04b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ab1cc357-05d7-4f80-b31e-85de87a8000c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ab5f0aca-6200-44ca-9ac4-6f114109f971"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ab6901bb-93be-439d-a472-7635f5b203a7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("abb06d23-16ac-4c15-9599-c3361f581f39"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ac463b9c-9167-4dd3-a3a2-fa4dce6874cd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ac60f07c-0c80-4d19-ba80-dd7b38ec5617"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("acb26994-8789-467d-aa01-d867feb1cea8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("adb4f695-7de7-4b23-8bf3-80e398be48bc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ae0b6968-de7f-48d9-a321-74012eb81c7c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ae2651f3-1ff8-46fe-8db3-7626ec23a572"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aebb9a00-dcc3-4218-bd0c-64fe6713aa6e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aede2dd4-7c8b-445b-982d-f5c288fdc077"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aedf420d-36a0-477f-bbb4-2bec9e15b797"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aefc4cbc-c39f-453c-ad6f-aaf2ccb06bd5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b0a162d5-8579-4d74-9954-a4b2c2de6bd5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b118c8f7-e813-47be-a9ef-3bac497eeb83"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b174bd5a-f13b-4443-9d43-0390b2800f9f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b17c7739-b9da-4e12-8045-968fe60151d2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b1b7e67d-14d7-47db-9461-7eb6e7e64770"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b2486e62-e035-475e-8892-35a8cc2ba1a0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b2769ba7-a984-4fbd-b42b-635afb0444c2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3458b48-3128-42aa-92db-c2631050a553"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3522323-3c40-4dd3-b1e6-4543695d06cc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b352936b-7eb2-4acb-bab6-a356ea2b1fd3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3821a8d-49aa-4c55-9973-83bb092d63a1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3c989f7-5510-4498-963e-52d901719b68"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3d4ea47-d097-4ca8-8b7f-ac5b5fd4d570"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b5018d82-d11d-49c9-aefe-e04f84bb404b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b5c073e4-28f5-4c10-908e-8f96215fa9e0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b60544f3-04b2-44c2-88cd-c873a9d116ee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b611a7dd-4b67-479b-ac26-39ee032c1f79"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b681fc63-0786-4fc5-8cfa-bea83e1d17af"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b7c99f65-7c09-44d2-8b31-3dc4171b6b9e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b834e321-dc64-4f99-8913-940c8220972c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b85814a0-ede0-41bf-9afe-70583fd6f0c3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b8a753a5-fa05-4e54-ac86-c91319c2bdf4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b9175685-2194-4859-9351-f383890d9025"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ba0ca1f1-5b3f-4f00-9f1a-4bb5beec76fa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ba19282f-9355-4840-a7c6-78309c662058"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ba1c47cb-fdf0-44e3-b65e-3625333fb8fc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("baeec7c5-7042-4ad0-b657-a1a3c755938c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bafb0120-d82f-40b0-856f-fd0f38378203"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bb38c833-fe5a-457c-b464-37a4d2ec71af"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bbc64d68-34d4-4647-b667-aaf42f8433f7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bc167d24-e3fe-449b-984f-c45de2c99013"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bc42562e-603f-415c-aab1-8fd2d2f23353"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bc75e811-82de-4595-83df-ca3818cfbe5c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bc76af66-7700-4d59-8ea8-6314681efe7e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bc8ed676-5734-46fc-a548-088047cf0782"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bca09e55-6b7e-42a2-b215-315e09a6475f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bca7edcc-d8ba-454f-9bfb-913e04c1eaf4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bd1ed5b3-e910-4480-8aaf-a1d21535bce2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bde65365-b07a-49b4-b611-483dd599b504"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bdee61b7-a355-4042-acb9-484a8ad77fbe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("be1d928e-cdb4-437e-8788-faeebd198474"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("be2296e5-96ae-4d44-911f-22ccc23ec1f2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("be719740-37e2-41b7-9bc7-e142941d6408"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("be748659-f032-4296-b93e-f3c970e64605"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("beeaa18c-dd00-45c3-808b-ee61436742fa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bef3bcf9-c92b-4da5-86f5-e43dfadc3f88"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("befa95d3-b049-43f7-a96d-db4eb2e9eabe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bfa421eb-a819-4a6d-9374-a8390466ac80"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c0121440-3c76-49f5-885c-e3f8c9ef6ffb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c01ece69-fa7c-4f66-af90-c16e7ed1cd55"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c03050d4-c08a-46a5-997f-592b943fceb6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c0320a73-066a-4390-bf64-6a8e94a0fa69"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c0471f9d-8744-4ceb-8a28-031ee209040b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c06200f9-9118-4702-b21e-08cc438941a9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c078d6cb-d7c7-4b07-9c47-3894cc8b96b5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c0a844da-de81-4739-aba0-4d193a9954a6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c11467b5-6054-46f0-aa6a-e8b271738d56"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c128cbc1-9a56-42ce-ad1b-cfef0183540a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c1660db8-ba0f-46f1-a1d8-4e3e22aac12e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c1ba8a51-0140-421c-b461-198d89df8cae"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c260a6f1-3300-4c8a-8d0c-51e4a87bb98e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c28fa552-f949-4cd1-8625-334178851af1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c297c429-0de6-494e-8be3-cb6fa20e578b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c2caac63-c42a-4616-833c-3e51d9e49b5e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c3040701-7569-475d-a25d-3b779000bf30"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c309d189-e451-47ba-af26-d8dbe56aa272"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c39d58d8-13f7-44a4-aacb-030f72a322dc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c3bfd385-3b08-4610-a66d-df8784b2fe49"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c3e7a205-29b1-42d8-b65b-e11f93eb2c21"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c3eaa7ad-5956-4814-ad36-5ed3b56f433a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c44eea3e-3d85-4ca8-ad55-7cb7e4d4da63"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c4533e0e-66ed-4b26-8cbb-f63d6db123af"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c49e859c-9725-40d8-8498-0718f48d9bd1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c4d3edf7-2bed-4e87-bc8e-f132e581baa4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c509f754-514d-4d2e-8c38-ad01dcf6b9a8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c5316f95-4d62-47cc-89e4-4b6fd035e897"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c5723d9c-7c54-4a31-85e9-447d82bb202a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c59e58a4-5ad0-422c-a626-220d3e402c17"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c5aa7301-e992-4d84-80aa-4322cbc17a32"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c638129c-df44-40b4-9cdc-d36fae9f1615"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c66d1c6c-9923-47a5-8822-ae8c41bd8b8a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c67a5679-63cb-4864-9558-38c17a7ce655"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c6a90dc5-1dd2-41c4-b97c-d00b778571ec"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c6ca868c-8a38-4964-b4ae-236833222193"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c72e6097-12d7-48c5-a2b2-76d5f190f5c0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c77bf16b-68aa-45ba-90ac-e174f29f4bf7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c7a81927-ca2b-42ec-9908-39d89948cf6d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c7f1ffe7-9902-4b22-81b0-690d3318ca0d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c8125238-31d5-4385-ac09-4d6b1d5d142d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c8228347-18df-4f21-9467-c285b38f2f46"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c8525e10-b827-4b7f-9dfc-000bbad09d3f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c8c9e1e3-40ca-4651-a38d-7f7b0df0b400"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c8cf8245-2430-4850-96c1-bc9b6f599603"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c8dacdf2-5bea-47a1-932b-8e139d870484"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c9d9b453-97d6-4f5b-9957-bd694f2c4920"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c9e9f90a-41bb-4ddb-bf21-50bc1e07648b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c9edb28e-35e3-4bed-b387-f6ce6b05fe04"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ca2031e0-7911-4be8-917e-c404b43cb7e0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ca3c5097-0358-4d9f-a672-a20950bd9a35"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ca64eec6-2c64-440d-ac48-6d16d88f1e91"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ca922feb-ee46-4344-9817-b887d19a2b0a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cae930ad-3b43-4e85-bcae-83a4c8b5a88d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cb177b03-dfc3-4c46-b44b-a3bb6481bbbe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cb580fd0-c4ab-4e13-a9ea-838f7ca649be"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cb67e1fe-7372-4dbe-affe-6597edd76520"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cb6a7ef8-797c-41b6-a9bd-5a947334e6c6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cbead521-d054-458a-8c6e-883aedfa368b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cca25c7b-6d40-4c39-8083-5b00dd5934e7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ccbaee01-30ec-4abf-8f00-0c72c1cd092b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cd4b8ac7-5248-42a9-9593-e71e24c83cc7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cde09fda-a1ad-4e65-9886-f022e52c05a8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ce3554fb-e1a1-4350-9f44-c478c19ae0b3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cec29e4c-c4ed-4424-a458-d0db961e5a09"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cf309fff-4604-4381-811d-224fafd76c20"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cf4db3a4-c4d2-4383-8141-0593f82b8b1f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cfb8158d-6ed8-4b33-856c-8353355aa1e7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d00563c0-cd08-4817-8bbc-606bfafa6f63"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d0171216-1765-4d21-a512-4ec1d3f3da23"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d02c7c76-5237-46a6-91c7-b58550d9bbe0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d030577f-0f47-417b-8626-db255f3d2d0d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d041d9bb-1e71-4e53-88c6-00069d4e8a9c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d04bc4eb-946b-4741-8a5b-15e0ccdb8ddf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d075d32e-4bea-46e1-8bb1-6054e17f2c2b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d09e1e99-0801-4e6a-934b-b29d448e46fe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d0fe57eb-f79b-4ce1-831f-10cc2fc4e40e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d129fbc6-76eb-4885-85f3-163c036af29e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d13e3114-060d-4248-8907-215b4fb5c5c6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d16dce30-a142-4565-bcb2-68d4a732f0d9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d17ad774-e310-4f4d-af68-06ccbf78c89e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d197d504-6dcc-4bb9-bef5-ea000bf6de93"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d1b631c7-10f9-4903-934c-3fb64b52ffec"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d235e340-58a6-4466-8902-fd20b33b9384"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d2b5255d-7550-4bd4-ab2c-d896d86f539b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d2bfba7b-d9ef-4413-af36-b0749160ac51"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d2ebd563-3600-4d2e-8c28-65de4636206d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d30ea55f-fc48-495e-898a-603bd06eecf2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d3322aff-1010-4d42-8d7d-09377dbc3911"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d35ee820-4a6d-40a3-ad76-a5214f9aae4e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d363e420-0d2a-42e7-b0b8-69ec2dec02f3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d36e61ae-78af-4323-9ab3-d22b5fa0ba7c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d3c30b46-c24d-4451-ba1e-0bdeb5de3534"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d3dad95c-6fc1-4f81-a55d-232965474098"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d3f40048-fabd-472a-a1de-8b3e94cfec18"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d4041bf2-d139-4c03-a67e-547f6c0be606"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d422df74-db7c-4b5a-9345-0dff9aa26a91"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d477d7c8-c0a4-44bf-b9fa-4467b91da798"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d504f41b-81d1-4766-b564-cd3f4b252401"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d50b969b-0594-469b-9511-be3d89577aa7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d51b4061-e8fc-4982-b275-673c6ffa32c4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d558f6db-be3a-41ee-836d-838779ecac30"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d579ce30-4988-4f54-9aeb-b77701b2299f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d58668ad-42de-4515-86ed-32660468b084"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d5964b2d-4e74-4b8f-b4b5-95930c3dbc34"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d5fce167-ea76-42e1-88f9-6d6baf25fe05"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d6259e87-bc05-47c1-96b6-1bf053a3f4e6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d656a870-f9c2-44b8-ae47-61da86eb23e2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d6a97148-af0e-4ebe-9ab1-431117236a21"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d77c11f8-e7f8-43e3-91d8-eaab44f6cac4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d7e111b9-a96b-42a0-ba1e-02e7f2312005"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d7fcf36b-b24a-4122-a2f8-8875ce39c8cc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d9dd5b2a-0735-413b-be78-3dfda21772c9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d9e8cfce-b99c-4a60-b2a7-260a103f5ef4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("da8c6af1-3d15-42c2-b6db-ecfe008f191b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dac6fdd0-1ea3-466d-91de-13614ca5a065"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dadd9403-85de-49bc-a48d-3d2d0be0d9a9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dbdc2146-2d22-4aa8-90dd-fcf2bbea4e44"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dbf3d2c0-a833-4390-90a5-b5704b6043db"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dc8208f8-6a7e-4176-b3f0-978656c2487e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dcaac5ba-e5d9-47bd-9811-dc2fb850b84c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dcd98b00-22ae-4489-ab7d-b6cb4821c6ac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dd092109-e5f3-4ae8-95e3-3c6ed84c1e04"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dd705a3b-325d-4dde-8dea-69d464aee407"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ddc2731b-e31a-4de3-bbc9-b4a093fa7ba7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dddaec51-ca03-4a0f-825f-36aef2f4bb44"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ddf41c93-b0ed-4094-bbb9-f695aa08e044"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("de7a2f1b-4da1-4d87-8a95-6cef2ec90e5d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("de970e3e-ea77-47d0-8913-a9f0c57204be"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("deb179bc-97a1-4477-a726-206677716f46"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("df15f585-ad41-4fb7-b444-1204ee2c7306"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("df314808-15ee-4fd0-a8c3-c2812619a3a2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("df48217f-559c-4df9-8d8e-4e02b775d8b4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dfb42393-f377-4d27-801f-d0d2c5ee22e8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dfb5ce17-60b1-4662-a751-aa3380886d65"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e0514da2-03f7-4aa4-a10b-9bbc9ba8d6f4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e06ca5d3-264f-4541-b174-28762a86381d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e071ef6f-0e3b-4c29-a816-ae77863133bb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e0759ac6-79bd-44a5-8be0-e0f4a6c5b1a3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e0a06d12-f552-4115-9c6e-642bf729ef43"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e12e2ac2-d33c-4487-b005-13c90d1cf3af"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e12efe96-0f2d-4fc8-ac6f-4d65694e55b4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e1508d29-4c38-4846-b678-f1485027b18c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e1ab1314-bc5d-443d-a928-8724e21bfe90"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e1b5090f-8a3f-4956-aeb0-853057b504a4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e1bfac0f-99c8-4320-9fff-731c469512cc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e2126746-3acc-446a-933b-ba7277b3fc3e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e3093d6f-effc-4f0d-aa90-9d40dac1ff68"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e32ffe81-7fb8-4185-bf1f-0e8bbaedbaf2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e33fdb63-ae72-47e8-8de7-c9752ce9f782"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e3593758-6164-4000-ae83-9662d0dfef42"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e37009df-2cab-4e07-b41a-ae7e68fa1bc5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e39760dc-7d21-42b9-b944-93a74a116b31"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e3bd9071-f011-457a-97c1-ec46f2cf9c21"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e4504a59-167d-4108-8b37-e6838f8593ad"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e478ef35-4c4b-49ac-a361-a4469576b053"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e4abd3fc-e811-4916-9b6d-25242980b38b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e5092021-9e89-4907-a806-9620f1919b0c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e537a6e4-9e01-47fc-9148-cb1545eca6d0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e57e545c-37b5-4ff0-9828-ffa983c3aa93"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e5845439-e240-477a-8d7d-cc80a381c9b2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e58f6444-2539-4dbb-b925-56b9f476a966"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e5fe0b37-1653-450c-9306-e1781346747c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e64c9ee8-dcaa-490f-8d1c-14c6a7e4e355"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e689d069-d36f-448e-8d6e-9643c6f660ce"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e7271cb8-d0df-48a2-8d65-df9cdaa8e110"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e7a2a8d6-e003-48f9-b20e-b25d01014195"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e80a47af-ef89-46c3-9952-79e36a7db056"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e85f9226-a824-4d41-8b65-b61c8aa7b740"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e8c4be7e-898d-40b2-a4fb-8227cb873a52"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e903d443-876b-4df6-98f2-24ebfafc914b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e98f51e5-1f49-4783-89ac-7fbf5e2790ee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e99d9072-08ee-4022-8076-ca617e47d231"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e9e95d77-861d-4bd9-b3c0-60ec2494b240"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ea03f53a-058f-4ba2-822e-413293514e91"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ea210033-14b2-4a7d-8c75-b1683f8f990b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ea85a788-0210-4c02-86a0-f65e14fc0a1a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eb065525-1511-49b0-9b0c-cf64b7870dfa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eb19ebf9-bf7c-4cf2-a466-ed4100e0f42f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eb3569e9-67cf-4af0-b798-7e1594530102"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eb6d8fd2-7250-4363-b409-c87da14e7378"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eb85e5a0-301c-48c6-8654-577e76073460"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ec135aaa-40e3-4fc0-802c-df626f6d6864"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ec33859f-6cc9-4f9a-adb9-b76933e32210"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ec3cc671-aa2a-4651-aa7d-bee855792b7a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ed8afdef-3e5e-4f79-9738-5758444f8637"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("edae79b3-baa5-4dc5-8022-1b92cf9f8374"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("edae8a5e-2951-40bd-ae04-40415907f379"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("edb2d78a-3e45-4e43-af6a-ebbabc92897e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ee3c8e5b-a542-4f57-a95c-2fad945d3410"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ee57b93c-8dea-4ae3-8927-585dbd269541"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ee74a568-b4ae-4568-8bd0-e75efba30412"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ee76df6b-b421-4792-a280-46491f7ed816"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ee9c25ce-a744-4105-9277-2fa5c9aae26c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ef40317b-495b-4241-b683-57a84c8440bd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("efb697a0-fc9e-4426-b1c7-4299f38fc6f3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("efdb2e89-fd91-4f6b-b336-5b2c50f56e18"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f0012585-4f92-4da1-8786-d4112f370100"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f006229e-6ed0-4212-98a2-b1e6a4ded401"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f08fb316-5bd0-4ab6-b504-18dce5d88021"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f091a882-4639-4bf1-9768-1bc188045edc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f0f32f67-3506-4073-9133-fc63a4c865f6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f105aba3-51d9-4a3d-844b-546eee1433ed"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f13e35e2-e7e8-4ad6-8d0d-9c237fffda5a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f1735428-b6e9-4a81-b5b4-41db6d70bc7a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f1fb401d-a12e-4ec2-a5de-2fe41c3282c0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f1ffaa97-963c-41ba-997c-6900cecb8323"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f2039a66-e005-4326-b538-d2e36f5527a3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f2ad91c0-f957-416b-ad79-be64648e65bc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f30ecde2-0f12-4146-8f8f-0a9869763cad"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f3323054-de46-41f9-9168-46f8b204fda3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f33505bb-6d48-493d-aff1-3f2466052cef"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f3e6c25d-1beb-46aa-a1c8-9ca3ec2fe227"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f42bb993-6208-4368-bbbe-4d1daa03757b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f5048dd2-e28c-4bd7-9364-aa534829bfd7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f5762f58-f091-4cdd-83ef-80b77770ad11"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f5fdf17a-4a68-4c01-8e4c-9ed13078ba83"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f62d7681-523e-4dcd-b4ae-7221b858553a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f66b6d75-37dd-46e0-98f5-ed2a52503708"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f6a09af4-02ed-4d26-a2b8-5137d6660e48"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f7320f0a-dad4-420d-ae00-6dd6e01b691f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f7849af3-4c7d-4a45-96a4-cfe8e53386fa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f7ee2b6d-d511-406a-bbc5-e087a4ce507f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f8335fe6-fdff-42c9-8789-343134dbff7d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f8a3251c-0bb0-476f-8838-3eae39ca00c0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f8d19c4e-9436-41a4-acd9-9c5534691fa7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f911cc21-8eb0-4859-a87c-a21cb81da3c9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f913a295-f485-4b6f-8e69-dc296f504961"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f9177180-4100-4599-8c5c-2b577d81cffe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f9391714-4375-4e13-9e8c-63fb28e3cbb1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f967010c-6f7f-4420-8de1-71cc797293fb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f98d7e97-d155-46f7-8577-6c7162bc9a3b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f9b357a0-dd4f-4ac2-8086-a62caa359027"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f9b4ee43-ba0a-4f07-8605-dabf36744495"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f9bdaff5-edd1-46cf-b758-b8233cf1c6cb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f9c015c3-eb94-4476-aff8-cdad649b5d64"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f9cddd82-cfc6-4371-b4f3-97ab23ad6872"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fa1358fa-71ec-4e96-be2f-8e4b8abe6bad"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fa3185fc-1a7f-4f49-8ce9-8f304c583d18"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fa80b601-106e-49c8-9c9a-7d026731e63b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fa859083-c710-4427-ae07-69bc31e02d6a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fa93bb50-932e-4ad6-a2df-ccdfdb67ae65"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fb107613-1e66-4da0-acea-a87584e86291"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fb1d1841-84dc-430e-996a-1d1c0fb67505"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fb24d823-bb9f-4233-b8ed-2e1ec7aed721"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fb5d6e81-bb8e-4051-b0f4-c871639f69f5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fbc571cf-5e7c-4f63-afb5-9a7dabff5a64"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fbd3d24a-529a-4661-921b-8d2880648c26"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fbe5c3f9-2b4b-4f67-92e5-d5128a7a9c87"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fc079798-2063-41a9-a948-1c6d32a2590c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fc653c0a-bda9-4398-827f-e772f4762d27"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fc831cb4-0426-4737-87d9-a37e005d7363"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fcc0da1e-feb4-4806-90a8-cf9622c9a9c9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fcd42bb4-602d-4a7f-939e-8d8129b8f7c7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fcdbf534-32aa-4a02-bd39-cb424d9e5510"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd1528c9-dedb-4a83-a5ff-0ef89e10bb9a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd3531e1-7a65-4d13-baa1-f05c69cd4239"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd550cba-2ab7-4c0a-87ec-5f3d3f6f6e5f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd85b300-d48d-4816-aeb7-d393a94e5669"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fdd9f46e-93d9-4341-9e31-d8bd76662055"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fdee0ba5-7922-4f36-b0c4-23af2fc50332"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ff409891-7db4-4004-8e80-0486d0c57ebc"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("f6b5cac0-3b71-4e83-98e3-c6339f8e7fe5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00036b22-fa80-40c6-a959-7bb96855ce29"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0101161e-27ff-4437-98ab-8dde0fa7a6d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0121729a-1564-4895-880b-9cccb562a3d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("01503c73-763f-4765-bc30-61b1f6dd36e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0179785e-6c08-4323-8aa6-9c5a2fc12767"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0205c5a7-553f-40b0-85a7-bb8f48cf901d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("026f3f6d-a8db-4a74-a354-b952d2ed3e76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("029248d2-9800-45c5-ba53-0f3d5fd1ea78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("02e6717f-7ce9-4d9f-a384-ffff79f451f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("033e4015-167c-4b8f-b536-befaed6ff7be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("034c2ab3-a036-4477-80aa-ca97b2ba12e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("036dba19-1fc8-44b5-8af6-44ed82ed4d2c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("03e210e5-6532-42ed-88b4-53f9414026bd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0403210a-fe51-4956-8de4-34cb317463a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("043f63dc-38c8-435b-ac22-667671b02a11"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("05057519-5e3d-46be-8aaf-c80a23a27b0b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0564b95d-46e5-40c0-a690-8af993dd9f7a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("057b5b6b-99fa-45b3-b50e-5c6821568010"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("05a5bf03-d809-4ad9-aac7-dcc22bd225a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("05a8ade5-9a8e-4acf-8430-b4f6e016eca7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("05a93b92-f335-4b7b-b2d9-0b5d668eeb12"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0603cceb-2b45-4c09-b3be-7c3b9586bcce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("06357151-0c69-4236-b31d-e60490702ed9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("063a53ee-71fb-4325-a41f-72abb5603ef5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("06504f5c-26ac-4a8f-adfc-42e441d4a214"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("06583432-d109-4c87-9992-448ff6241321"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("065d7112-b1a7-4147-85c6-ef07b43250c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("06c8def6-a5a0-48d6-84d6-f46ff3b45686"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("07308174-545c-4f5b-8cc6-7611dd63fa12"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("07458f5b-d1c4-4eee-80ea-d1dad021e5b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("078e2ebe-782c-4b49-818b-4d7e5a551dbd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("079fa487-c130-44a0-a5a2-18b96ee392d8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("084a759f-1282-428c-b2c4-8a43a79d72ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("084d48b5-fbf1-496b-a8a3-7b28a3362698"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0865620d-5da4-47c4-9265-3f7dc138f39e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0951a924-c236-4990-934b-630f0c2cdbbc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0954e4cd-9fc5-48fa-be9e-f58993b88290"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("097d3ef0-fd40-41ab-a39e-a3d401f03bc6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("098b73de-93c7-45a9-8aaf-410cf20d58c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09e922a7-6292-4e8f-9450-23267a89dcd4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09f802ae-ee7f-4dfd-82e8-22f2adf4d9aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0a0ea634-5260-492b-a70c-aa56e444659e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0a13b047-81be-4f53-abb1-afe75afa8ac1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0aa6eb0b-27ac-477d-af7a-be86e7ec5933"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0b378700-9ae8-4476-a309-be31f9697273"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0b4c3fd3-89cc-4a87-a926-462dd376bbdb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0b7ecb41-0d66-4595-a2b8-b719c551f839"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0b86ada9-bad4-4511-90d4-ad5b924ed8fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0c75f0bd-8d26-4df5-a3a3-776eec63c739"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0cafbd73-072e-4450-ae4c-d23d66059df2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0d3dff61-505c-42b4-988e-733d2a5e80b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0d828ee3-bf52-48ee-85ba-a85f4587ec53"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0dd0a815-04dc-4e53-a9b0-b1d07153e612"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0e23bbc6-699f-4860-9561-1484e59484d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0e3cd4e5-3f43-4784-b13b-2fa3ad5955a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0e490f63-2232-4d7a-bd1d-16a2acb5cb86"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0e915994-9811-4b3a-8b44-30473575c878"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0ec71101-ac30-4cad-bb88-b6d930205ff3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0eea9cce-934f-4663-a10a-b907deb7d336"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f06e28d-0b53-49a4-990a-5b4bba9a4855"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f317eba-0de8-489e-8e71-d7ceb028fee9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f4ccb4c-60dd-48df-ad2e-15a634ad400c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f7092e8-76af-4b78-964d-bc70030d4ad8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f90358a-1bbc-4f0a-8e2c-fff23582ba27"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0fada7d3-222d-4b22-8bc5-90a2ea966781"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0fe354f8-7347-420f-bc22-6e2e1d2dfc1e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0ff506f3-2ef5-464b-b1a1-17a7fefd6996"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("102cc218-0acf-4c2f-ac19-4f4063b3ad13"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10674bac-5dfe-4eef-ada6-d8b2250d9396"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("106839b3-b82c-48e0-84a4-b26a8d1a8b85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("109b7430-8dbb-43b6-9985-9fb5a036119d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10a1a493-058d-4d46-8a78-4a383055e143"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10c1f47e-bd87-4375-989c-02e41aa99d4e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11360804-50b5-413f-93da-b3cfe00382bd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1188a663-255a-4a3b-a007-ac61039bcb56"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1294cf50-e0b8-476d-ab81-c9eebb3b3622"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1309e877-e744-4f4e-ac66-d68cbd511fd8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("133dd920-d48a-4ba3-8c7c-7bd2ac0b999b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("137b5c3e-8f6d-494b-801b-e0e342d5c21f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("137dc94c-2f50-4a29-abbe-d27eabd6da02"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1391a953-fb3c-4650-9d80-9889d8593a0d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13cd0784-d161-4684-bd0f-6afd5803baa5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13cf229d-1b10-49b1-a014-3c29306bb5e1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13d507e3-e88d-48dc-9a14-9cb9d1b760a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13e27d8f-8480-4fcd-96bd-d528ab834600"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("14afd07b-e665-4366-b7ff-2c2384d5f93c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("14cd3232-375b-45ae-9804-9bcbd1c507c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("15f84b10-6b5e-4451-acfd-14a2015edf3b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("160e10fa-550e-4534-9c12-94640bfef364"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1636ebe3-1ce9-4c1c-924e-f6f5594e6864"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("163e5805-f48c-46d2-b007-0e6530385bf9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("16760830-e1a1-4041-85be-453df59d61f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("16b103ab-54fb-4e2a-a344-815350147f9a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("16be594f-0281-4217-9475-371be7184659"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("16d3bb1f-1f70-4115-9b98-3ba86e6829be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("16e5d4d9-41d3-4b55-bcd1-43b344996adf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1740fe02-4644-418e-a69b-5d1aab0cfd98"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17c549c9-88ee-444d-ba5d-910b07bda143"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18634104-24dd-4125-8431-97e5734c106c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("186b9ef1-000e-4b13-b44e-bd806dac5db7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18b2ce9f-2873-4e18-8cd4-b9d8b87c8e93"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18b420d2-f2ee-4cdc-b967-88bf1c14d9f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18de8209-924b-486d-b594-e0b0a192867b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18f36a9f-88cc-4a11-b751-a3f12b1fe452"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18f710ab-67f0-4708-9a94-219141dceaef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1916e883-6148-41a4-93ea-ad4857eda251"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("196a8bec-03ee-484c-9968-f85acdfb9cb0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("19d463d3-b81f-41c0-9e9e-c199af01c835"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a044f3a-d0a7-416a-ac44-ef5432abe96b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a254335-8ca8-42a0-905a-49c262c62020"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a4c5040-9bc0-43dc-832d-e41dbc0c118f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a5a60b9-5618-40aa-abd7-bb76337bb4e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1ae7638c-1e1c-44a8-9f41-efc4b57085a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b55fd72-1520-47ec-8aa1-b6f35cdf6566"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b6bc939-0234-445b-92cf-5813391b0d07"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1bc6d853-2f15-49eb-a5e0-2d281b7f1f31"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1bd4b3c9-fba6-4b10-a4dd-ae1c908e8499"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1cb22af1-97ed-45cb-b75a-a0b6fef7d5fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d1413f6-cae7-4e67-9f13-8c43ba7b3b7a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d7b0a7c-a1ab-4e6b-92b8-de98174ac0af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d7c2198-fdae-4dba-a0e8-f9fda7329951"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d803c2c-017b-4c26-b63b-fde569ed1135"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1dea8ae4-eab7-4367-86f2-dfe2d36bb4b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1dfcbbc5-68c2-4a86-9f72-a2cfe070d889"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e01fdd1-cc93-4a28-aa67-36e369973b46"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e194f73-46b4-490b-bac4-f55e24b4e320"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e65ba7e-2d58-461e-a993-daad6740e27d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e68625b-4e13-4922-9a37-6d8089a34512"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e7327a0-1d38-49eb-9a9b-1066e412f513"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1ea9f99e-ff40-405a-93e2-ec27a9b764b5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1f669773-eada-4f2f-b2ff-79eae1af7917"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20210e0b-78ec-4cfd-85c3-7619f5a35818"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2043e4d3-a61d-45d7-920f-c04ba2d66550"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20445e35-dbc6-4277-933b-53826e6fbcc5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20a5a1b5-d310-4f27-953d-a94a6c752187"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20df5a45-4bda-4c86-9487-480406b89b4c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20dfde4e-cfb0-4c11-bb52-c48ee7310027"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("211a3093-a9a6-4021-a005-ef17879facdc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("21bb67b0-51b6-4439-b76a-d6042d266185"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("222e1b60-e64e-4393-928c-52b263ccb1a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2254e60c-49c9-4228-89ad-45f0e901f5d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("229ac764-a891-4244-8e68-601f3a4103ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22b1fbd0-dd13-41a4-b992-0720668a33e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22b6d73b-96b1-44e3-a5e4-b2fa438e21fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22ef8f10-792b-4c57-9bd7-bb79e0664d5c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("230792c1-0f0c-47f9-9d01-dcabdeeb7d0f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("233f6172-9531-426a-ba1c-f7495c73a570"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("23ad5ac8-8016-46d4-90fb-bd3c88d9a4e1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("244904db-de7d-49f6-9109-644fe6d7655c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24b8b61b-4887-4129-8017-75a2c62c6836"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24d2d875-eb91-4186-9f3b-a91755b4099d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24e6670c-e24b-4807-8f96-ab8ce4a795de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("257bcff0-d13d-43a6-a2cc-aef950c2d445"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("25a37c97-fad2-4cbe-a3c6-6e18700c8dfe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26a551ee-7852-4b68-9da8-3eff031d23c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("27006934-f3ad-456b-a397-613210a25576"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("275c83ba-4aff-48f2-a269-ce1d9635542a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2785a4be-e54b-45b1-8da8-b4c73b128a0d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2791a607-b2ba-4933-b970-438d3b02dc3a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("27c3764f-dd45-4025-9ba9-f2b122f2115e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("282c445c-c601-4f88-9a36-82b9520e4e26"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("283e0852-5aa0-4f2c-a691-3b283a581154"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("283e88ed-ddd9-4d94-b9d7-8cda8c5b6ec3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2857e2be-dca1-437b-9d2d-427215a417f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("29a3d4b2-8640-471e-9e6e-0390dc670fde"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a3d6da7-1f63-4831-a47d-467b4b8143cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ad115a6-73bf-4f49-896e-24038e185a2b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2b169532-5b4b-4c2c-b35f-f4edeaf68e9c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2b37b53b-9d4b-4074-bad2-4e987f1185ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2b3d6750-4ae6-49b4-a3fa-a11b024ebf0f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ba6125c-5b09-4e03-911e-599ae71cc90d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2bbec3ff-3662-499b-bb53-72572d4210c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2c26d8c0-64be-4ac1-a5af-1d4b8b485fca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2c51361b-88ef-4cf0-95b0-c91759babf1f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2c851ba1-bb1c-4a00-a6f9-c43e6dcdfc66"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2c8af53f-2f95-4e65-8242-c5f7151b7323"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2cf1d815-6927-4524-8bd5-920e8f54a22d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2cff7884-58a5-47c4-8de8-f4f699e72cdf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2d7e8d09-4126-4671-8e78-b13ca787c5fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2dcdf657-80a8-4925-81f0-1d58505a0f8c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2e07efd1-5042-48bd-a474-dd40aa3a3dca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ec5ddf3-583c-43f4-941a-aa5c039f4096"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2f44c591-45cb-44bd-a34f-29878f4ba52f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2f59281d-4b17-4754-ace8-8ac61df0b7b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2fc1fcbe-1d9c-45bd-a516-25b9db2ca2c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3012ac66-90d7-424c-8cda-c7973ca0c755"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30135232-7222-4f3b-be84-b422759d1085"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3051e27d-abfa-4cf7-af20-003e9ec39d21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3053256e-edc2-499e-a355-3dbab9cbfaa8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("306ec1f3-b781-4aee-a6aa-43a9d439e376"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30744684-6418-4272-8fab-0fc902589a34"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("316a475a-9e0b-4e1e-9939-f2e5f4837a04"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31abead8-8665-42a7-9a3a-05ef189836eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31ed9126-e9a1-4b67-8f5b-28cad8f2e27a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("323814b2-747f-43f4-bb82-fb915e440f33"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("325870ca-04e1-4ce2-ad96-85bf16a75fe6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("32879947-dd82-4b06-9377-ad5cbfc051b1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("32b57042-70ee-4634-bb62-9cf429a9f163"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("32bc0db1-84d9-4b1a-aab3-e7a9441e310f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("32dbcc86-c531-4180-a98e-4691facf100e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("32f58506-8b44-4474-9c9a-c9871618eda6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("333c52ed-89b6-48be-a140-e95c8570e79f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("336b041b-44af-413f-89cf-ef5f47679bfe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3379a741-fbf6-4dd2-96d8-19742f92f6f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33cafee5-f5f4-4d40-b36d-4981a979c29f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33eb8284-9757-4a78-8806-10e521728f9f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3469e601-9e55-4d29-baa9-b26c73a22cf9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("34aed693-9a43-42a0-8326-b8d58c1494be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("34c2c93a-6ac8-40ed-88af-09b6ae38eff3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("35013e9b-3899-4baf-bf15-b1b0687d111b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3591cb1b-07a0-456f-ad53-019d6b3eeee3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("35a0328f-3a39-499a-b266-765764f0cfed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("35c6a5e1-0b5e-4d20-9b0c-611cf02b14fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("362fe557-0b49-4ef8-8e2d-0fa5b9132284"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3649e2f1-9a43-4273-9c4f-3dd5a342f5b1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36758ee5-56f6-4c6a-94f5-073ea759880c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("367ab3e1-c8ed-4a5e-afb8-1294edff266d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3694a0e0-c796-40fe-af10-bd7b6cf77141"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36b33991-2822-4cc6-9d82-abc5fc7575d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36d1e83f-d814-42de-bf96-e4915b54ff62"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36fc3491-448d-4697-bc99-cb4924c0ec18"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3704689e-a92e-4081-847e-e8008a40ec56"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("371f527c-31da-4051-98f3-4de366aef96b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("37e414cb-4e4b-4500-8d08-733e2a35ba92"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("380e5f32-2821-47eb-a9a3-ba6d81545bea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3814dd2a-1295-45e5-9afa-87a907dffa7a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("382237f1-a4e0-4b42-8950-8115352aa350"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("38592ac1-b6a6-48b5-8cdb-978b602ff82e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("38d6ee12-9399-4b6e-9738-d27c4afa4d9b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39472f7c-0057-42da-ae92-058a838d1a59"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39500352-cef6-43b7-b351-c6b2c6e0fe4f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3950de38-e382-4a76-84e0-4cbd6e61496e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3967114d-4afb-4512-b464-b2420b66bdfd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39d91084-5814-4fc5-87d2-8dc87d3fe5d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39e418e3-50ae-47f3-8896-a79ee3a5bc16"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39f130f7-df46-476e-a03a-15571d9fb860"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a081ae5-deea-4ed1-9cac-c0c802d35c2f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a445815-d539-49a4-92de-d68f9151fe54"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ab2a517-4e26-4831-a8a2-a0f591140bfd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3accabb6-6296-46a6-b84d-76a85bc80d78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3afc144e-c8c4-45b0-85e6-3c3206f14ea4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b1d7888-32a5-4483-b73c-f437ae1ff5f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b821e26-064a-4754-b31b-05082c82af30"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b90c1f4-b5db-40b3-b91f-dbb947be4b1a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ba37a85-5cc9-41d6-876a-0c30399d087a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ba465ad-fe5f-4566-bc53-4a91d8c8473c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3be4d545-172f-4f2e-93b4-fef072eda2d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3c0d547f-1044-4d1d-b343-0feeebed224d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3c330672-19b2-47aa-91f4-e8236e6f942f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3c3701a1-fb07-497d-9031-56b980f90477"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3c53509d-3042-4cea-ba57-1e4d7db745ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3d17e8ff-8481-4bea-b77f-7e2e2811d191"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3d3c600b-4f1d-44c5-af49-04317a41f4ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3d414407-ef30-4411-894f-583a061e9cbd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3d50ee7a-7971-4a78-af65-81f58b54deb3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3df5e88e-658b-4368-8081-fdef9f6f4ae3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3f283c22-37cd-492f-ae21-7f6b052b112b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3f4323ba-4c99-4b58-a9c0-b06d6cd76f89"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3f4b4e63-48ea-40f6-8a56-582b78c207a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("400ebe55-2990-4cb6-91b7-acdc6b410fb2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4049033c-fb7e-4446-93e3-ad532f9babb2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4057b497-01f1-4aca-98fc-1f68610cd25b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("405b50c5-0034-488b-9a2c-95ecb8568053"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40846a7d-224f-4bd3-8c0e-511bf0a368aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40912e53-61f6-490c-b963-1e4c2131e830"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("409bdc4d-7702-4010-8340-edbd074a0e57"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40a7cda6-347f-4160-a045-9f472223914a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40c19900-f71c-4dc7-b05c-027301cc3455"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40d02118-415b-4611-89ae-fa32968ba2e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41b48c9b-880c-4d70-9988-3e1fa20a096e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41c67dd8-eb55-436c-ba3d-2a61e1de7143"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4238193a-0a33-4dd3-b743-5fc3cf3ff242"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("424aee77-2a80-4743-8016-5b1bc933e8db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("426486ec-affc-4e42-a9f3-b4d1260b1963"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("42a3dfe4-b9f3-4d75-a9cd-cca6d6b6bf93"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("42aa7a98-5e07-4575-aa39-c34de0f86c2b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("431d2500-52fe-42e3-ad76-fb3c32444daf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("437173b5-32fd-4ace-9bdd-f7805c31c203"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("437498e4-4eac-4fc4-8b14-02c73ac44411"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("439a0042-f99b-4c22-a5c4-15e87ba189fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("43bc9153-7ae7-45d8-b3b2-76df1644fae2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("43ed3e6f-ffd4-4771-993a-b2bf03cad61b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("43f4cae4-a3ce-4f7f-9450-20b05945fc96"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("447bb4bf-58cd-42b7-8f6a-afbadd62bc0f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44989835-4244-40e7-ba53-2ddf67d4fca2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("450600ac-cb9a-46cc-8933-388c476fe355"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("454ef522-cd4c-4e32-ae4d-0137abc520ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45bd920b-f8b7-4d6f-afc9-182e747e2e6b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45d5d55a-3825-4c61-ae20-6c6e0305c0d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45ee4b7d-2a0f-4d36-9a31-d706b9efffe9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45f827b1-9929-45c4-8b30-c8f9180b83cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4696bdc0-5b2d-4b0b-b671-6b4c2d6f17dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("46c34152-df35-4837-b24c-04ca3b84efa7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("47e294c9-cc46-4382-8779-04aa4f2b3c6c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("48af1057-9119-4f2a-b34b-16c665311eef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("490b3c16-b6a9-46f9-8d73-91fe4e5e2a00"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4934bbde-7812-4587-b826-df07b30c369c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("498baef9-5837-4c6a-adcf-b8cc671b6a72"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4abb0c00-2fd5-485c-940b-a7f4b96e7280"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ac6d35d-dcae-42aa-8bcd-71ca64cd91d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ae35bad-c6f6-47b2-8dc1-fed2e8ccc18c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4aedae2c-36f2-4383-994d-59d4bae29b94"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4b202621-03a4-4553-82c1-88e08db8993e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4b29fc58-3e2e-43b9-bd62-5e22cb49b8ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4b47bf27-0aa2-4fed-a6e1-3f847d031c56"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4b9746b2-1c1d-4dac-8630-dd1e82f7bd74"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c328c67-9734-4ef1-9f03-22ca47cb7826"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c970444-43aa-47df-9c57-0bd8ac3974af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c9a24d3-7b88-4bd6-8387-37c83bcaccbd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ca27eea-84ed-4f2d-b1ce-bd005e5896ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ca8fca6-9a1b-47bb-9375-feae0d5ea23b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ce7834d-70fc-4b2c-a710-55eaca095fb5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4d93f2a8-82c5-4aa6-b7ad-d701b98dc969"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4dc59338-3fc5-4978-8b57-109248c87c3a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4e69f295-4d67-4004-852a-feeed2d7d642"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4e7dea9c-1e31-495e-a15c-d1b3c077ad9c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ebaf848-6846-486f-9a3a-4923a2416076"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4f905f05-bba3-4f71-9df2-c29377efa29c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4fecc6dd-ec63-46bd-8182-c9db91844e94"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4feefd32-c190-4a61-b8fe-16d09501903a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50538a6c-c631-4d72-bdd6-50dc0e0214ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50627b9f-291b-4639-8d45-0946c5ab7870"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50910ae8-fbab-49f0-b1ba-f2a389b1e467"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50ae891c-760b-45f5-9d9e-5a82e9bc3108"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50be653b-14a0-42d8-ba57-d5b8eb2c28fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50e242b8-708a-446f-b56e-73be724ab21d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5140bbea-ef45-4832-8b2c-69849d833bc7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("51663b2e-afc6-4ffa-a411-aea713e37b09"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5203b6b1-6a83-48ae-933d-7d38b8719738"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("52fcf5c8-ffc6-472d-b9a0-fc0b3bb82a3d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5470a130-c42a-43f8-948f-c4bb5a2a86c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55137bd2-7f8f-4376-83e8-de34488a6fd6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("559c6b1e-870a-48a3-a625-0af4d0a95d4e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55a9b9fc-22b2-4ea7-9afb-b0678481eb42"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("561c8e9d-fc4f-4042-bd5d-9f58c0bb9f85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("564f06a7-ed52-45fa-b0e1-0e1e4fa9492b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("567f2847-c90f-487c-afb5-73ac92ee229e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56859ee2-5e69-4da3-8638-c099961d751e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("568c61b5-4e3c-4101-8b35-1f08e07c303c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56aae6ef-e48b-4544-8cdb-71cbccee3a19"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56ab442b-d63d-4224-b0be-1bc59d1b21aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56fbf8d3-6ebd-4b85-add5-0a46066a6425"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("571402fe-0906-43b3-9616-97f80f9ef1eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5735bd69-4714-4fd2-82a0-4260dbac4183"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5754d060-4fff-4129-8a49-b02b28c603f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("575ecfbf-4419-461c-acff-2b5e7f68ef8c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("581b1e51-cfce-4ed9-873b-3fef2d1b935e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("581e12a2-bca0-4ecf-b181-e3edfd216b11"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5837d474-6b80-4cf8-81d5-068ba685297c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("58510c93-9d09-4301-8605-bce1d2ef3eba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("587eeef7-62a2-41e4-8a87-d6479ac1c11d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("58bc2130-4fc1-403b-9d61-89ac3402bc6f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("58c2daea-df6e-4c1c-841d-14f82e8e2f67"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("58cd2eb6-02fe-44bc-9dc4-ef23939d0310"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("58cf92ad-ab15-4abb-a8a5-6064a11e2e3b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("58f3c2ec-399c-4ee5-8c5d-8b1383b252cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59401cb7-ec3b-4bdb-9861-af34e0ac38c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59604c58-8601-4b63-b70a-81536a60b810"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("599c1cc3-f172-4d34-9070-a9889f5d712c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59a4bfcd-1c8b-4b33-b9e5-69828397afb2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59a8296a-52aa-48ff-96bc-e980a5f024c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59fac80d-4772-467d-9b4f-c462090ba739"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a0df5d7-92b9-4eaa-ac2c-5b2223e2796d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a1bac17-424a-4f70-9b37-9c994261a8ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a5db2eb-5373-41ad-a4ac-cc5748d3b6b1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a5e1633-57f1-4f00-8543-925d7a68c746"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ab401da-c538-426c-a160-0f3aaa691168"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ada3082-0ab8-4dc3-b3f7-dd8aa7a10fc6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b5eb7e2-b0aa-481d-9e29-c2e391e27023"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5c4a2334-3ce1-4f42-a131-2e33630e9941"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5c91886d-3d2d-4338-812c-0cf3499b94aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5c99c490-9a66-4988-ac5b-8ee958048347"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5c9ea0c0-1fa3-4069-884e-e3138f569896"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ce48907-f935-4d62-aae2-bf21721ad4d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5cf1db25-52b0-4553-b5dc-20b768b39f85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5d06b206-2e89-4fd6-80f2-dba5ac7416ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5d5135f4-5919-4ce3-b598-ef5fc5bea445"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5db96827-f6bf-4f79-875a-4bd86d5187f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5df45a36-9442-4af8-bb9d-7911428e3313"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5e0c0d2f-d5cf-4f18-80da-5e0af06c7ee5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5e42ad81-2e5f-4cce-b5e9-999d09bd3313"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5e56306e-3f82-476b-ac52-eab27c3300f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5e7c2b67-a20c-4da5-a007-f1a6597f8a7c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5e92c8f7-d8ab-48e9-8299-4c8c96f9b38d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5e976013-6f79-4813-ac59-abf85b68e52b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5e9dee58-780e-45b4-b628-1222207abec0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f4dda62-9841-4036-9f19-e2b0f97252cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f72d85e-48ef-48dd-af02-d92a42f620f2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fd8c4ce-71e2-4283-8f30-0acc48659897"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fe9c759-4683-47dd-b2b0-72ff7d85f02c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("60379af5-6058-4522-a391-902e22ae6408"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6041c26b-4047-4d11-acbf-a68a4725c04a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("60781ffd-bcb6-4051-bf90-55174d62d8f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("611eea91-decb-4876-bb04-eecbc441b0a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("612ba695-f127-4cdb-86ab-886809970475"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("61400919-8f9c-4748-bba0-5a0f07291441"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6173b732-636e-4a0e-abb3-3b4afbda8048"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("617fd59d-5118-448e-9454-710c92dca1fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("61b454a4-3a8c-43db-90c2-029d560f13b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("621e13a5-8bb9-4be2-a0aa-f007384fc43e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62baa6ce-0863-4531-b435-0c0210cb01fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62dd4d28-54c2-4073-b88d-ebc63e0b39db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("634a80db-9c70-4fe6-bbd8-28e7241d283e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6375ff17-41ca-4ee7-a968-41b0bdbb4f13"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("638fd544-1c99-49c8-84b1-390d5ae63dc4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("63f3ab5e-6eb9-48e9-9451-9bf2ab5f3627"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("646118a1-a59d-4c84-919e-8079cfc24050"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("64fef925-eac4-4999-95c7-de4ff66a7188"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("653e65ed-1beb-45c2-bfe1-2624701f8811"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6631163b-b0cb-4172-9a09-7cafa5b85cae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("667504a3-d954-40ee-b27f-101d072a6a8a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66e74a89-443b-49aa-ac89-8c8b3182a877"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("67f02635-af21-4a7a-9c79-0b943d6578f2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("685d3d8b-443d-4a14-98b6-95a0e8c327ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("695088fd-08b8-4d16-b9e2-2cb312c7ce2b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("695871a1-8cd1-46b1-8548-e59a1ea2b351"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69856442-b70e-420b-a4e8-44721df1fe97"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("698dd9c7-fa18-476e-b517-0e89379e2d20"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69da6abf-4dcd-468a-a1b7-f04a16e14324"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a120671-2dfe-4a8c-9fe4-f5c53d557398"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a379e5a-998a-4f87-b860-bca53e486e57"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ad5a93f-a9c9-4afa-8eb1-83de9536bdc2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6b11da1a-0c45-4126-b25f-8ba44366fdd8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c2be972-934f-41ff-9f9e-5377cf19d370"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c5147de-a61f-4af2-a8da-5ce404f8fa7e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c577a28-e75e-4446-a250-258cb8ae17a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c6546fe-ab14-4c24-b751-2a662abc3c87"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c6eff75-833d-4138-b127-2327a8a3d50c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c848c87-e2d5-4391-8ac8-23816454f2de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6cb717c6-a022-4be2-9d22-8720c9191941"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d1b8fd9-854c-4321-97bc-67c0cc78b527"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d79249d-62b2-430f-89cc-e7bc6a9dd93e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6dd49bdb-7c19-4b31-88e9-d376014ad47e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6e801dee-9812-477d-bba7-bf6d1dc260cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f104568-cbad-4641-8233-71f4fdb3353b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f171b9a-48f7-4a42-9ffc-48b39027b7e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f32159d-2908-4021-ab5a-07cc140b1c40"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f6aeea5-48b0-4f78-b00f-77154c66525b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f6fb7d6-8ac2-46a0-85be-112464605329"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f759861-6168-4518-901a-f3cc96f5f20f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6fac237a-b94d-4b31-a762-0edae792e915"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6fada6fd-7f57-4369-9e1d-8e6d16b47523"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6fb5ac43-a532-495c-b586-1d7ceee26a0e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6fde66d1-df3f-45fd-8151-ff56371262b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("700966f8-b1e3-40d9-8c18-82840a08eeb0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("707b4edb-2725-4d7b-aa88-db11dc3b8484"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("707d3c05-869b-418a-b717-ec2a185d5e08"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("70af780c-aa5a-4e21-8991-9b85cab77ab1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7102b909-122a-4f2b-81ad-e61ef8247c26"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71098526-7218-4217-8a38-4ca2114a47bd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("714c6eec-6ae0-4eaa-8546-5f0b532b2e74"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71622a71-e9e4-419b-b6a3-758ca6cd470e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71bbaf01-ddca-43b5-a7e8-d7a4fedee329"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71becfca-f76d-40b0-8c73-2769e4cf26aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71c70ea0-6fb1-4f9d-928a-db46d1555b5e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71ca4f2f-12d3-4746-9606-53f69b345913"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("726ebc79-3bc5-4ca4-b24b-59f08ecbfafe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("72ab6bd0-ceae-4a32-8695-f074b3b7c964"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("72f2e8e2-191a-4c33-8a72-3217afd1f25b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7317a46a-069d-4223-9364-746a9bde6bf4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("731a1b0a-f8ca-4589-8612-11d518b58af5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("732f1b03-e993-4e2c-91da-6771153a3a31"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("73b3cd69-35a7-4d1d-b3cf-97060847872b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("73b66784-4f07-4ee2-b97c-87552a54b9ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("73d1b4e4-954a-45fb-b6e7-3e550cc1ed90"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("73e7a71d-a183-4578-bb64-508e87fa179d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("73f88fe6-1424-4543-aa7f-025eeb8b1cc9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("741a71be-c006-4053-ae46-898e1c89a7e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("749f1fa5-d181-4d4a-9e6d-4c72d866fed2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7574c65d-32d1-484f-94d8-1fdb31033a9a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("757ad461-9d43-430b-a389-853b7e247478"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("759b2294-5e37-40ff-8108-fab15e1e10f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("75e7112f-c78e-4ed2-ab8f-61b338f7921e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("75f9a5fd-8d86-4618-9826-3b50a46ad722"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("763e0b52-a009-4283-b806-d1dd57c041f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7683da2c-4c33-4082-84a6-87ce6f0c7493"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("77127b72-d1a2-4b7e-8427-837e98543967"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7716ee99-538d-432a-bce7-ef55cd50ab74"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("771d9637-38d6-4146-8e5f-b62fc519c2f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("77a3bdc5-bb5c-4760-a5fe-113b9817e302"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("77fc954e-0a53-4616-acc2-aa50be358a03"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("780db987-c8b4-4314-85ea-b439ed3b9cac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("78441591-3584-4667-aff3-058a2044ebe5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("78a135d3-0d94-4979-aaa8-0ab0d8baf0c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("79a69e0a-c995-4916-b44b-4d2f0c730275"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("79bfc13e-74b3-4a09-8e76-108bff0442f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7b1505db-4fa3-484b-9878-ce532b4ad511"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7b1822f9-ac55-4101-8df3-ecde8e8e1e85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7b571864-fba4-4c65-917a-575bdcb6c437"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7b9ff988-15f5-4b8d-b722-d1d0a402f620"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7bd90cb1-2d47-463c-8900-1a8a498c300b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c26eeda-c349-4c56-8954-4374106ca663"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c38321e-9c89-4cbb-a58a-5c9244ead675"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c4ba0df-a266-4671-ba11-6cf1af1c681f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d3116c9-fb38-4e62-9c9b-7b065c54a94a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d862203-1c8b-47cd-a740-96a314425165"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d9a5ea7-e53e-40f2-a358-4b50c340ecea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7db3c075-7218-4276-8ddc-912b44d198d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7e2a8cfa-49a3-488a-b9d7-a5c4102e2c26"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7e57bf91-f019-4e49-baa0-2a110510e4bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7e8e65a0-7c27-4435-b3d1-65456d34ec20"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fbd85ec-e0ff-4867-9804-532639618701"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fbe640a-b05b-48eb-9a2f-8e2374c9a3fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fe8c8e6-0839-46fd-9ff2-4222fe733796"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ff0881c-3140-4a29-bcc2-0da9979f624f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("801f8395-eb84-457b-b787-999f3cf392a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("80219176-c7cd-4be0-afc1-1432018f12bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("80545b01-0e44-451e-90c6-bea093964959"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("805c5aee-2140-4fd2-83ab-cbb3e72c1e46"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8072d999-c26c-4fed-8186-c2bb79dce9cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("80831a31-16c0-4122-ab2d-072a4a60cd62"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("80d1e150-00f1-4eae-94ce-be1fec18e331"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("811652a0-bdf1-42d5-bcb3-0c12b1b831b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81811790-29b4-4076-89d0-cde71e73c1c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81b9aa52-03b8-4a0d-be79-633c0180ff4d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8209da4f-1f93-464d-9292-f9e9ac0b84b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("824cd558-7c44-4db7-821c-a2a7aee634ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("826cafe3-ca70-44bb-b055-ebbe3bc60dc5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82d035f8-2660-492d-bb86-4c6c3ec5fec2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("833e5721-837a-4e65-9041-f33871564f37"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("83aad3b8-9d3e-452c-8735-03ff55d9eec3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("83bbb2b2-1bb5-41c5-9c75-29212e29ceaf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("83e6f005-20e5-4cd7-ae1c-e852e1c519d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8414ea49-0d82-4368-865b-dcb9fc4a3eb6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84166e05-50be-48cd-aead-a7808201f138"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8434a8bc-afff-44b1-9b0f-65e3bf5955a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("845f5a1e-faef-40a5-a927-51300704f1de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84a8aa44-d531-4475-a637-86072f816e7c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("85108aca-cd12-495f-aa18-0ddc0b5a7d96"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("85a80627-cef6-43f2-8d84-25326b4a7302"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("861fca83-4276-42ae-98bb-5a74c0529592"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("861ffdb0-8adb-4fa8-81ce-e867afcb6477"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86217617-bcf0-480f-b484-ba3e33742ad6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86296708-665f-4f2e-8e8a-edef55053703"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8720b15d-8e22-46db-8633-b2ca117e256d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8770c109-1d7d-4ef6-ae5b-da7e8b4f007f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("87747741-fa91-4032-a72a-0e4f19c1bbba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("87b5b843-c9ed-4015-bcd2-344b3df6c064"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("87e3b529-1172-478c-b723-246408cf5e2f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("87e3f9ba-ef77-4aa8-b0df-05bb953bb49b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("87e74c1f-6b1f-40a9-9359-7bb2c0ca900f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("88498b10-671a-457f-bd26-cb188cda0fd5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("886966f3-8535-4ab6-82e6-f6551e00899a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("88b6d57a-70bb-4823-98cd-fabbb90a9043"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("88de878f-50ea-472a-9747-05886f2fb080"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("88e824b4-0800-4ebb-a012-433f9cdc04a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("88fdf2aa-17f9-4d4d-a789-3d9bedde39cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8981a213-a162-427a-b6d8-54eb694190c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("89f59edf-f1c9-4511-982f-f39cbb8eb344"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8a4fc6cb-0397-403e-8a2c-8025cb86934f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8a9248c3-6118-4b8f-b40e-a63ab85619ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8aa5621e-6e63-43a6-ad63-414768902153"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ad49880-2578-4ea4-91bf-c55382b2da13"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ae54e05-2dc1-46db-9d44-32b4ac8da5d8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b7baf53-9e65-40c6-aec5-b82f20a4df7d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8badc67c-1388-4154-ae0e-3cbd1114eb2a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8c0a0194-74e4-4e27-a153-b27c71e73757"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8c0d4b7d-65b7-4b0d-8096-8d4816dd4092"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8c17db06-d37f-47f0-9121-ca9c9f7dd37f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8cb14c77-1f33-4ffb-8e90-f7b955043fee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ceb147f-053b-4d21-bd87-4b7cabae1549"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8cef9aa5-aa2e-45c4-970a-37b99faacc61"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8d0b87fd-065e-4f11-a257-a381bb03f589"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8d84e5f4-5bb1-42d6-b513-84988e67d4b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8daba000-8b52-4dc0-8a00-4b7a7a4d1229"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8eb5ce5d-1b50-4107-9fef-38485e75ba78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ef23e68-d45c-4c69-9f74-f08bb9afdc1a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ef360c7-0b27-4d63-bade-1ad55f09c643"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ef620fc-0b0d-403e-8dd5-2347035cb2a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f065271-4823-4a35-a6f4-055fca8a65f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f6a5202-df19-4993-bf48-7a6ce3b68a4c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f743ee4-cbbc-4ce5-bfba-a694183839b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f8b0dab-958c-4dec-aa1c-0b7993e04a77"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f8bd469-f1e4-4eb0-8138-ac94ec551b56"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f8f8e7e-833f-4070-bf97-5a783100c900"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f91e1b3-de06-4e2b-902d-91861286ce33"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8fa036d9-41d7-48cd-b186-481534a8a73b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8fe39cee-9122-47ba-b29c-ed7dab258f18"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("901102aa-7cc8-4bc4-9ea4-7e2c1aae548d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("91121fac-26ed-46b9-87e4-84d658baf636"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("916a655e-6273-410b-89bd-6ba4ad0d0345"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("91aa72ea-c845-40f9-ae58-380b4c79c78e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("926bcbdf-0c4b-4e89-bf3c-7e1fe4756827"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("92793e07-5b8c-4662-bc36-e4e55d5b8bfc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("92ce9f6b-1e45-4dd7-a173-3d25669a0649"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("93028112-f86a-4fdf-b175-739d60649c64"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("93c1f9a7-b0f5-4763-a3fa-e9e34f55163d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95537da8-517c-4348-a692-7950b3fddd3c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("959382e2-1755-41e1-947b-9b5f44f9bb46"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95d748ec-4051-4aa1-b71f-b86ac1f65fff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95fb49b7-7717-4b01-bf77-fe22cf996fde"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95fb868b-5988-4d38-b6cf-55cc47fc6b40"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96260dc7-0ef6-4654-8d9d-ff4dc29afd84"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("963f7c77-1abc-4106-b8c5-1c20b25140a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("964d3cc7-f016-48a3-a9bd-c0105770a3a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("969b7346-6cf4-470c-a3e2-6a64835a5353"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96a236ed-418d-4209-bf51-ce9c170f0997"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("97aea8d9-6f4b-4ad5-b4f9-658134857186"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("97b8321e-3291-4a7d-868c-0e33190613a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("983e1cae-7e70-4224-915d-3644fb2312d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("98418369-882c-47ff-b5dc-b82dd92f650d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9844f89d-6808-446c-a7cc-2a11d35e5d35"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("987f758a-6bd9-4377-97d8-c927a8b21785"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("98ec2b6c-928e-4eaa-a643-e88e9b2db0f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("990640b5-69a9-4d7c-be73-87cc98bb613f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("996dec2d-cc9c-4d04-97ac-58e229adc6c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("999e49d1-5f32-49ed-9c5b-9a4f74404126"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99cc96c8-e63a-4e8f-ba70-6aa37e3071c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99d91dfe-4527-4b74-b7f5-88fce29b2938"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9a953325-7db3-4a64-8374-4f0ec03a4a37"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9a991c65-beb5-47ef-af59-2db168351d82"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ab53936-e2cc-433c-863c-e6b007462595"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ad7635d-06e3-45fd-99b3-bf7e6dcbd03b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b228598-4d84-402a-9b80-cdb72bcb1189"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ba5234c-1a40-477d-bc72-fcbf84015c27"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9c1ed185-d96c-40f6-8b47-3877ee6c55cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9c26faf3-a7fb-4133-a7e3-87a15722c268"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9c42fb2a-545c-4089-9241-104cf4acf219"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9c55bc4f-348b-4671-b6be-3793b6f7aae3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9c66ab1c-f88f-463b-b4fb-0bef54727673"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9c6c7a1b-1b2b-45ee-aa71-e4bc2c75ac2f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9cd2a8b2-acc3-4aa6-a01d-1e5d09b80fef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d159a00-056f-4e30-ad67-47c16c6f3936"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d44fb10-1da4-4c0e-81ff-8a96b46f0675"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d575f80-0404-47d5-bea8-fa96e75e03d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d78f4b0-b1ab-445c-a15a-a0032557caa6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d95a6bc-a5fd-48f2-b6b9-79fdf4b07e3d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9db530b9-fed8-4549-8bea-ad9f70a52b87"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9dca1802-b65e-409b-bc2d-3fa55a7fdbab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9dee87d9-1734-404d-b0e8-fd5a4ccfa971"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9e0a57ac-5ddd-4d1e-a23a-45035a5900e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9e4950d4-0fea-4b52-ba09-d18924e33a1c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9e770ef9-b63e-489a-8187-8dd722651c63"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ec0f34c-6ba4-477a-8eb5-7ea8f3e9acf2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9f14c327-d802-438e-b328-8917d8d04694"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9f35f185-fe93-4cf5-8a45-f266ee4a11c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9f4560e0-ea4d-4758-8797-a46be452c9d4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9f6e258a-168a-43f8-b257-ff3995bc6921"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9f7b6bf3-81bb-4fdc-ae89-4a5d651ee9f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9fb712ff-adff-4adf-aef7-d40c78031868"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9fc1bc29-815c-4544-8a12-824779959d0e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0494db4-850a-4195-90fe-6f9f3a6a6846"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0583201-19d0-4485-94e0-e532bc9856ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0be4734-2a1a-49df-8bc8-0a33b777a4fb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a11c68e2-1526-4ac4-bea3-d72d9434e1a0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a1560a1c-d033-4e5b-b711-109ebc4cafd7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a1ed51ef-95e1-4557-8178-ce74653cf3ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a26ba124-f324-4070-8710-00170d0687c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a281681e-f231-45e5-9315-24e9ac28278f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a318c84f-6a6e-4eb9-9c2c-0825d3d16967"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a3543ffd-23d5-4e94-bd6a-fc76f61806e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a3bf6550-bd1d-45d7-b8a0-c483119b71b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a3d7f9bd-4b7c-4dee-a309-701be85589bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a3e9b2d0-2eb9-4a2c-bcaf-6bedaae9de4b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a3f50355-9095-4029-b698-bc529ea6386a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a3fce2aa-851c-4675-9543-460d70692fc4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a45d4cc6-64b7-48ac-ba34-8f934e9f9906"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a4675d2b-5a65-4937-8376-90528e226d06"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a46f2e37-9ca0-4a24-a28a-16c92544898a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a4cdf3a5-e727-4357-86a1-8eb7ef1c1a92"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a4d2ab1b-7b8e-46ff-9536-563023605151"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a5353a22-f7af-4e77-ba16-6efb1a5a8d67"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a55afec5-84f8-4a77-a7f0-24a6c07d5efe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a5a61171-5871-4c4c-ab13-411ca1e7a30a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a5f3bc1f-c163-4448-adf6-82c91c6779b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a627ec69-e3df-410c-933f-95727bf5b952"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a62e6c2b-8967-47e1-955b-8ded71bcfb7d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a684d2b5-2e4e-462b-a359-8e854b937d72"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6aaadda-004a-4534-a4da-c57b21bdca16"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6b58dd9-a315-441a-9879-b4bae90b1368"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a7be39a8-7ca5-4e6a-bc4b-ccea6d38c9d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a7ff21d5-ad24-4035-82c9-ae93fae5aaa1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a81c10ee-a222-4da4-b017-79d135b304ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a87a1e57-1ace-479a-b749-cdb917b69702"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a87fad79-a1f0-43d2-a4bc-50a64d4e3d64"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a8ab8ea1-d4ee-455b-b367-dd8047975080"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a8d3ad8e-c62c-44b0-9566-6b98bba28a8f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a90a8158-7c83-4658-b482-011dd7ff4227"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a99af6dc-df85-4168-a655-2daeea082000"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a9a5d165-c95a-4d63-bcab-0807ede29c32"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a9c0145d-9609-4974-9b79-050967d2374d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a9c2463b-c5b7-4a42-b404-b6d042b4f9cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a9c30841-bc93-4200-a200-686996c3fd2e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a9d95834-2152-4792-8e7f-2d2b5658f09f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aac8a50f-5a1e-4dc2-8b81-f1c303da6af8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abb7344e-d029-41ec-9c2e-bf37f1330d81"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcf6753-bfaf-4e0d-84c7-71b957286d53"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ac0ff00f-53d7-4aa9-b73e-d962b262c1cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ac2f819c-ccae-49c2-ae4f-b0eb7902400c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad62f3d9-83f7-42b6-a156-97a5e0f8e1a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad6806a3-f470-4867-b1b6-72529d8be27d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad7288bd-d90a-4ce1-b130-ed9db832e6f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae5ea27b-adef-4c0c-a9e4-b151c7c3e8c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aec121e1-3a34-44d2-b57f-1af78e647a25"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("af91c1cf-e380-4072-9486-763b7a77f9ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afada213-5362-4e41-91e0-87e336567a2d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afeb2e31-d6c5-4f76-8363-e3d0ba1984ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1a8512d-0c49-4574-9e2e-e51995e46c92"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b2bcd0eb-bc5f-4b89-815b-c032044493b5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b2d534aa-93e2-43c1-8d46-795152fda050"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b3211b76-2196-4732-a169-6c32047de664"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b3568547-7833-4588-8e0a-f1946f07994b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b35e3963-0baf-4d49-ba47-d6f534a107c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b3ad8b59-e232-42cb-a797-7ca26916667e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b3b59def-97c0-4712-b1c7-96d3dcc85857"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b442452f-9543-4888-a5d2-b3346b1d365b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b51acb49-7463-405a-bbc8-0d36156b1ca7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5246afe-b67b-4931-9ffa-76a57a7e4e7a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b53972df-f6bd-451b-b694-e01025507a15"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b596681c-65c4-4af7-ac1b-fc95a4a9f09f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5c7f0a1-ee23-49e0-a5a4-d35d635a1bb4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b636e2d5-85d7-4d90-b0d5-5383364ce312"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6538550-8fb5-4aba-90c4-45d47fd027fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b68811d4-a20b-4bd2-9cb9-38a9cf365bdd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6926ed3-3529-41ca-8f19-b09f29d8363e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b69e5bb1-7daf-48ff-8c2d-eef5b41d4701"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b69fe75b-1496-4dad-9ca6-a9d681a54c88"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6c68c32-3323-48dd-946c-45f23bd16a60"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6e12a8f-3e9b-4b6f-91cc-e2eac92527fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6f53ad6-d0d1-4531-88ea-66ceec7df052"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b78a1f2e-2bd7-4932-9327-bda5848e20c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b795095d-e120-4b1b-8246-af7eeb3bd32a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b7eeee78-a4c5-4bdd-a746-395047743f7c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b83fb2ed-4666-40fa-84b6-769be1956aec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8853937-8f95-4cc9-a847-f47b389661f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b90566ea-6a90-4f78-bd2e-2ba2198bb2cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b92f9fb4-b88b-456d-bf56-bb8b147de07a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b9842b8c-d296-4ad2-855a-4a611d06ac8f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b9a97764-a611-48a6-966c-f77dbdedca5e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b9ba4a9e-0af0-4d75-aaab-0d22d771e365"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b9d4caf8-0fe1-4fa1-a74d-25f2f53effd9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b9d9e5c4-727e-4cae-91d6-73a8ecbe0184"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b9dfc722-54be-493c-a22d-5bab7a0474da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ba12404d-841a-48dd-a3b1-b70541b85c37"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ba4d9b48-c3ce-4e42-9e20-56356e3e0c45"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ba589f75-f93c-48db-b296-8dd3aa66488b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bb2103ac-67bb-4737-b508-66efcb5d6f74"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bb276031-cade-4daa-bece-e4ffcd18b365"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bb30b360-5d05-4549-b392-8f37a8fd75ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bb556ccd-6f9f-4fe4-9c00-09fe35a4f263"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bb6a6484-a8ff-4537-9a81-466f38bdb292"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bbbff2a9-fce5-4de7-ae8a-c15e8f2523c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bbd594f0-7d10-4ba3-af96-c658d4678bf6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bc34a5bc-1c4c-4073-924f-b989cab6b4b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bc515f9c-7438-4862-8abf-481aef5cae44"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bc62ed17-bb9e-4b58-810a-0327702d75aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bcd90beb-7f5e-490d-a671-fbe78f27d1c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bcdbb753-1469-464b-8892-f5c9cf952dca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bd5fc58a-221c-491b-8ec6-cd0a7f657567"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bd6ae6d1-a7de-45ee-befc-18b95d7318df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be567c77-e26b-4de2-ad07-0190f86e740f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be83bdd9-6d93-41ce-8cdd-195cce8448d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bebca501-2de2-4499-b441-cd1464fa0fbc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("beda9372-5fa3-4e39-a56c-5af5588d90ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bfd2fe8b-dc18-4357-977e-9c43af97441a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c021e527-4fed-4ba2-9977-97cb6c1f4844"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c06d9fae-d7b6-4285-a805-af6763fbda13"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c092c775-0b53-4f25-aa9d-ee6906e06d81"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c154d985-b4a3-472f-a82d-449479a4607f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c1789a4f-48d0-4b4c-8bb5-fd4d2b17f12f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c196cdcf-f109-4b83-8f0d-714f3b10cc87"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c1aa8ee6-fda4-4019-91bd-7dd33a075964"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c2515310-fcd5-45e8-957f-e2be919a2b1b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c2678431-b22f-4249-995c-ca040fdd74a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c26c9233-c57e-4dee-9460-146b409536a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c2a0adf9-26f6-4b92-ac87-e0f5652c5a8c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3a980fe-ab36-46bb-b1c7-4258fb2dc951"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3b67b29-5fc3-4adf-826d-719f64c499c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3bd4243-b875-4d8b-adbf-7df14211a885"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c411fdcd-d9aa-4a31-8ac0-2ba68b402a5c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4410cec-a97d-41c0-9719-473c1f0a5248"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4500892-ef8e-440e-bfaf-599c2e2c8cad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c48ebd1d-5ac1-48c5-8bd4-f4af0b79ca08"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4ac27d8-3046-4a9b-8b8f-6cb766d7057c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4bf8ca8-1672-4e23-af18-baf8a616ebcb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c58f6db2-e209-4eda-bab9-6742214cb61c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6446084-761c-4f16-b2b0-19919a4c8c40"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c69e1db1-90b2-407d-9346-d0d872983028"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6ca817d-7bc0-4a77-ae00-45985b92b381"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6f7d418-aff6-43dc-83f7-9045bbe9f410"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c738b821-7a96-4362-826d-d27cefc9e0b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7c1cfa6-b8db-4544-af1b-24b0517878ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c81dd4d3-9cea-4f3f-af78-ef51c197e65c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c870c4e4-7162-4215-8844-e924dce3ff36"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c8a48d96-6942-4e94-9d89-d971b51696fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c8c800f2-868a-4db0-a9ce-6900425e1337"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c8d96396-46e1-4ef8-ae87-ef4303cdaff4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c8f7e91f-662c-4a69-9f87-c52b2ffdc3a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c90a27d6-8e5a-4825-bce6-0814056a4e1d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c9450229-6acd-4dae-aed0-494b2a33fdd2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c9572945-99c6-41b5-b865-2fa239d2d286"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c982d348-b9c8-4241-8e83-96891757bc5d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ca16844b-6499-46b3-939c-33d7dd788b10"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ca8896fd-bf68-46ef-a47a-21b496a0be76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ca9ac6c2-1d29-43c4-9984-835c6d5db6e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cad09fc9-a553-4455-930b-683ab81561c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cae3461f-ecb9-4aa2-84c6-f2726a032f9a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb1ad664-4a98-47e3-a803-756a5e5d97f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb44fef4-3684-43d9-8416-791dda4e4f2b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cbf2e929-b760-446c-a223-eaae8d01ac07"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ccec1f0d-670f-4042-a01f-68da1629ff14"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ccf1ef72-9abd-417f-bb62-501856e3b24e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd1518a1-6480-486a-b59a-6a2cf01b8c3e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd2297d3-c5d2-4efe-bdbc-d8f1d4d43229"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd25eaa7-1cc0-4db8-a816-451ccbd2a7c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd8f1479-fc62-4e59-946a-526a1e3cf3b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cdaa033e-173c-468a-802f-fb35c87ee377"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cdd46003-1066-4a7e-b595-02017c9baec0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cdeac1ce-003a-43eb-9d17-49888ca47817"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cdfa436f-e3bd-47e2-8121-089ea7992fae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ce137653-f328-4904-bcb4-02fda885987e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ce429853-b453-4253-88e4-4c11e1ca4941"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cf602b10-59d7-4872-b953-06f49bedbfde"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cf6d9298-06e2-41bd-b139-b2cc11a3ff47"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cf76d701-637b-4640-a7c2-29982e40cc30"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d0016ef5-9d5a-4500-93a7-6cfdbd043289"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d133e86f-04ed-4ee1-b3c9-4a9dd4a441ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d1582435-b304-4f1b-9c55-ccfff187dcf5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d15c5afb-f3de-475d-8c5c-e0da11576f78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d17ae9f8-cf40-4ee0-a394-af4efb53a9de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d18a9f0f-fc59-4b22-98d9-69d728097ed4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d18b0d25-9724-4430-b9d1-edb4e44f75a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d18f8014-5240-4822-af5e-d948c23428f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d1a702ca-4df6-4275-9c2c-d3967a26babd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d1a76600-f404-4407-b000-ec8fc23f1913"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d1cdb8b7-f186-4fa4-bcb9-9434eb544cc7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d20266d0-1022-42f8-9b69-b74f5043b6df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d261d036-9301-44f5-8a12-1ae4c8bbb441"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d26d2d62-502d-4f83-802b-650f4b423c28"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d29491b4-0ee8-4240-a398-8e06f93f0ed0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d2a0b623-de95-4a4e-918f-a0cff007d4a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d2e96628-5698-41cc-8cd2-338c3bebc3d0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d2f9ab59-1728-4677-a117-9747b2e6e015"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d3056888-7cb7-4a6f-8c5a-9af469d7f63f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d3d809ab-1437-486b-b9e7-04bb4f350077"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d3dd9595-dd74-49ee-821c-908e2f568aa9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d4543db9-db32-4f25-beac-046a70a078b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d481299f-91ea-4d45-9339-c2de04d886ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d4acb96e-b99b-4d85-99ee-f0b1b7f81cd6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d4af65fe-5f4a-4929-9ccb-efed1e028012"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d4c8b1fa-79a2-4dcd-af6d-dee54f9f0d73"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d51d4e09-2ae7-4a53-a018-799143b73e70"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d528838c-493e-4535-b90e-1b988d18a7b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d56d9e85-f806-4a55-a038-1257c0ca6dc6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d573e086-21d7-4ffd-9e3a-ae411e5147de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5f535c2-597a-475c-9e66-c5e8ae15426b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d63cdc87-1522-4e6e-9902-fe10aabb1edb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d69f3406-f255-475e-8976-dfec74cf891d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7617530-57b3-4c10-96af-5c1b809e0f93"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7818998-50d9-44e6-893f-c30959c12bf3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7886b8c-9450-485b-b574-c8cce5329e2b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d79c79d1-0737-4022-8baa-9ee73a8b4f72"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d80d2a22-ba8d-497d-bc55-87d307b3ad97"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8c2f0c5-bb38-44c1-a2b7-1b7649cb64bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8c32936-aa17-44d7-8198-26af6f96dd69"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d91c61d7-d283-4362-a638-9a4638fd009f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d9985a20-7fa2-469b-9f17-a145e13d45ee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d9b5e41e-b5a4-4c4f-9383-b34321ec8523"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d9e92f32-b5d8-487f-ad98-057e4b8fdb50"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dac02d5c-2f2b-4525-ab63-5b67eaaddc08"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("db7ef33a-4c25-412c-9f15-eb8ffc5262de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dd6247e6-a642-4e53-9df7-2dc4f0e73cc3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ddc3cda4-be18-4783-846d-164422045ff8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dde22cbf-dae6-4e2e-a4ae-9087aad8100c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("de6731cd-3c84-42b9-9195-7658a0f862ed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("de89a73a-0098-477f-ba85-6df0cb46df13"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dec6d016-e81f-4325-b39f-cca4015d3b4b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("df22f758-caa7-4d0d-a84f-7b6dd66b0d2c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dfa40a1d-c871-4434-bc97-c84dcf3cc698"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e0009eb2-e4b9-4ed9-8414-5a2c46cc8726"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e0016bab-7413-45c2-b520-4823b7ef3283"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e00a6d49-8301-47b5-bf6f-a02ec42c3396"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e00ca874-76c3-4123-a8d0-e6b06ee513e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e0279e43-31cb-48a6-8cb8-3913db8d1778"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e02f265b-abda-441c-b953-7bd75b375e97"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e099898d-ad99-4375-9d49-0c24f6d9adef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e1039d21-32fd-4ec6-ba92-cc0a97a39fd1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e1295c03-32e6-46a7-a291-18064d2aca32"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e12c6571-abd2-4338-a025-225c4f6f7a22"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e14c45e1-0ac9-458f-be5c-7fe940c8718b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e1ad87f1-0f54-4974-aa72-f4fddbf4609d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e20aa3e6-b917-4c6f-9cd7-1f57218288a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e239c6fe-9712-4f3b-89a7-c15b0c3c9ae3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e2a15d7c-c741-4890-9e9c-40fd16755de1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e336fc54-f001-4740-8b57-bc6b61baf74f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e34d8200-1841-4dbc-bf16-fd7223ec74e0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e3650927-0d8f-4bbf-a979-3716062befb2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e3785051-777d-4a93-aa38-71e799023477"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e389c55f-75c4-4418-a5e7-23d29436a991"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e3d59c8a-5bde-43a8-b524-9337f688d1d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e3f112f9-c9c5-4776-95b5-f902a543a9cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4127cc8-d831-4162-8aa6-4dc0f20ab283"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e437a854-20f8-448a-9e14-542c2a39df9b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e43b573d-d70f-4839-85fa-b0c4c978ef27"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e477ac91-f88e-4a30-a9b9-5d9de5c05dd2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e47988f7-482d-4b60-9e90-4d3adad5c3bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4c01959-88f0-488f-9724-a31dba13a3d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4e041d2-83c1-4210-b7dc-8ab366cf9a95"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5d0df4b-832d-4a47-9469-8e668cbec19e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5eeae7a-6fc9-4e15-9371-794be3d47563"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e65858ea-3b65-478e-9620-f4a8c82c11ea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e6ad7609-4aae-45c4-8a05-d1daf8d9f25f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e6e34e92-e024-46dc-80ca-655dd0510392"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e703d2c9-3b24-4d9c-9d8d-b85a834d5f5b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e773114e-1582-4298-ab06-bd4851404dce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e79c3a1b-391a-49fe-97e2-c9a97d002f49"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e7bbd4da-472c-45e6-a8da-35ed241c66da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e8538ff1-b596-4780-8e08-79753223865a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e85f8160-bcb7-4d2e-9358-cdc87c97a84c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e8a85962-883f-40b8-b8b4-051e7fce7e1f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e91e6584-c7b6-417c-8f89-0b96af655fce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e921d878-e918-4ba9-8641-f289c8f9e581"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ea0e8335-1fd6-49a8-8145-7e5f45ef8b21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ea2b678b-3a1a-44e5-803f-ab806dd4f194"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ea83ff33-8207-42cc-b20d-5fa17f0cdd25"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eaf281d9-fe4f-421b-8fd6-afecf504d9c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb426f65-f4dc-48da-bde0-98e0ac157649"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb91d114-1599-4375-99a9-a677a12b5a9f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ebcdd3df-6154-4e6d-9b3b-4617af60a3af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ebd90765-7ad3-4f7f-a60a-295b28a8c1e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ec04bfc0-31c1-40f4-b055-6f1713b1fae9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ec7e6eca-6a08-44ec-bb2e-b0e4ae11614f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ecb8a3cd-2bd9-48d3-820d-812d01055cc3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ecd72f30-0e44-472b-be23-b40b21a815d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ece20912-1f9d-4d2f-a18c-c5fb41676802"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ece9a26f-48d5-486f-8c11-d345adf055f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ed93f135-e7d7-4923-994d-49b66a6df27b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("edcfe7d9-2c44-4b02-b4cd-952dd8cb80c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("edd99abc-75af-4fa2-93cb-7387e3123379"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("edef6402-0abf-43b2-b295-a9fc069df3b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ee2a5159-e549-417c-bc62-3f19fd7a720d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ee44555e-5642-4534-809b-e90708bcf41b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ee457275-ff83-4e10-b981-d0a6c08ced7c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ef72c1e0-805c-43c8-bd54-93fc03f697bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("efd03f5d-6c4a-48fc-9f44-6ebe85e48b59"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("efd38e4b-cf05-4fd9-a222-1b42212a1815"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0033737-d423-45d6-bbc7-c275832c08cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f009e837-6fec-47be-8a0f-131ab2c16779"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0183ddf-de95-4ee5-9070-85f234adbcaf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f01e2e6d-76cd-44be-bf59-a575696f41ab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f11e797c-1961-401e-a79f-9549db8cd811"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f11f08f0-7593-4a0b-86a4-acb442a225d4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f12ecffe-f9d5-40c2-a3d4-f688d82bc786"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f16574c0-55a4-4a9a-a546-1b3e7999313e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f1821894-22d7-4061-aef8-329b4cf30c75"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f1a126ca-0cc7-430e-a2df-3ba6c4526d0a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f1aac6ae-4f66-4a7a-b4db-c0e2ed7fe27b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f20678d0-0e1a-4723-9c94-c5b7936e93aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2381451-d675-4d25-8c25-316750992a37"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f24fcbb4-2473-41a7-a717-0d410ea71fe3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f307e141-2a25-4370-9d71-347c669d2cf0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f3214415-1cf0-4f0f-896f-1e6c1842eb8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f3557ba5-4ab9-4a66-99ae-5a001dde3bf9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f3812a7b-2d1d-485f-b75a-b1ad741e95a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f38b50ed-8298-4aa4-ac48-6a6903f4db8c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f394339d-3470-444a-b7a1-f9127f6dd9ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f3dfe64a-04bc-4355-b5c0-6f10bfa5b82d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f3f2b84f-7cd5-4088-93d7-6ef661e988c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f408cdfe-3bbc-499e-88ac-448a5ce650ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f40bec3e-eab9-45a0-a95b-358058533606"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f410cf65-5369-4dd4-9acb-b1a66bcd47cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f4617fdd-93c4-442e-83cc-b36437677804"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f4e8671f-856b-4cd9-bf3b-e09a6d68f9df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f51a3a4b-3fe5-46bb-b45c-ff7313e52071"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f53c83d0-0ad9-4222-8835-2360f28b8b9c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f5a12e6c-397b-484d-a2a5-06f48e7ddf8a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f60b4de3-48fd-4ac3-8ff1-fe97cab92a7a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f610cfc6-93fd-4cd9-b2f4-70deb30aec50"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f6132098-b244-4df8-a242-a459803d48b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f6ce01ef-8610-4182-b54c-890f453dd1a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f731f8c2-e9ad-4b10-8a38-8346c2ddfd77"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f76d8934-9a3f-412e-843e-629c6718b294"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f807203d-d634-496a-9e10-971c4b41aea1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f913f0b4-ad3d-4934-865b-f96f88ecc3c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa1be520-cdfb-4a3a-928a-0bb95fde7e4c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa785786-cf3b-40df-a7b5-cb92822cc7bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa7918ae-34ca-481d-a2ca-e6ccccdaaf41"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fab0ef5b-21d4-4451-9481-4874ec9330ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("faf5be74-064f-4290-8499-a95cf130798c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fb3e7af3-5501-44d0-8c03-e7a8d5ba77bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fb6ca9c8-612a-4324-b8a3-8e0dcbbfa157"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fb740ee6-e6ea-4747-b7d5-0665a285ce5a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fb79138a-3cdc-474e-abe4-9d61836165b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fbc53cec-729d-48d3-8ca4-ef38b747548c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc0ba793-c672-46ba-a2b5-eb18c5e365bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc147fe1-4d70-43d7-ae14-4480e4ccc363"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc29324f-f5a2-4edf-824d-21aa26ed10c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc84ba97-6f91-4dc4-9f75-37e327341d8a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fcef7568-8382-4837-805d-8d2d6784c611"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fd2dfff4-7370-46d3-8b9b-81d57b4ce286"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fd79f502-8f9c-4006-b5fa-0990906ed57a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fd8d01f6-3ce2-49c6-9e11-da05002491eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fd9f009f-3086-49c1-9c22-bb3ff3f6eeaa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe203d76-23dd-40ed-b97f-2fbae771eb53"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("febaab9c-545b-4c98-8ee4-6b6b244d5889"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fef66d55-d1b6-4393-ac27-f8cff7136b7c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ff4d0e04-6ef1-4700-8e1c-511c47fdb7c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ff56394f-4ded-4b16-aa8e-5991577ae624"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ff6b6991-d1b5-4e1f-815a-2f9443b13be9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ff98ba69-e208-4d2b-8efd-ed24d9fa0a33"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ffaec7aa-a072-4f48-8de3-7126d56ffa74"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ffb2a892-0c2e-4590-8cbc-a605444efecd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("25257b0a-9370-4e06-851a-8e13c4b17c72"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f81526e6-d671-4a83-aedf-f3df1047dadb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1152c3ad-d572-4913-a6e7-e172321a23a1"));

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
