using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TetPee.Repository.Migrations
{
    /// <inheritdoc />
    public partial class checkDetailCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("051269b9-f343-460b-8794-a570f6aa1f38"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("0ce31fda-bc07-42f9-b3e8-80cf904172a9"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("25bd650a-b715-4031-ac76-0799501ef44d"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("2bee142c-9765-46ce-b664-c0f992eb8f4a"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("2cb03e4a-b415-491f-9342-db0c4d127a3a"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("89d26d02-ae0e-4f95-bd76-3f5e0f6897d6"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("a0b8f5e2-8bcd-42ff-8057-4c4b6b037a8f"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("a0e6d68d-e22b-4523-a7e9-dcdf56e8cf9d"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("a53677d5-e8f5-4630-8873-bf23714ed459"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("d1321bd3-5995-46e7-a520-0215fa5addbc"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("ef012b50-8922-4129-8960-8e3f166108c3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("06c0a33e-1637-48ae-af24-adef750ca7e2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1d31a103-425e-4243-9660-164b2f84e5b9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2b0217cf-7883-418b-8ea3-ad1383124a8a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5d673817-5ca4-4554-8ee2-9b15360ec9cc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("675680bc-1643-439a-bde9-f3cfae1dfeda"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7f987db7-535e-491c-9cc5-4e807ed9ed41"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87135a23-9902-44c7-a36a-3db2a7d96677"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8e381796-c4fb-4458-9d6f-109be87dc3dc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9d372067-add0-434a-96f6-9f026c5f3496"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aee972b3-272d-48e1-9dcb-d36448c4e180"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d229ddf8-3dc1-4996-9165-4673d1c15ca3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ecd76c91-12d4-4033-9a80-8bbe8ddf761f"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("2944a64d-04ea-43fd-9bd2-91c9bb87ea71"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("4dd66c23-793b-4433-8d7b-3126d1ae55ac"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("7749703c-5ea6-491a-88af-50016be30a5b"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("7b8d9351-9646-4589-bdd6-a60733a862af"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("8914192b-cd58-4bfd-b866-0f8fe7972b1d"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("a88bf2a9-c4a6-4345-b4f8-73e1ada3e055"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("aaa483e2-21a5-48dd-8ab5-905309a914f2"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("aef61c33-7d7b-47f0-8710-8dee20d76020"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("d71222df-d3e5-4874-8aa9-3c6997b2336b"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("f1ae7b79-df6f-480a-aa44-f9b16310a0a7"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("fd3abce8-6683-4122-b520-300aa8a0129b"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("04bbb028-a5b5-4450-89b9-ab77c967089b"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("26d06959-1e11-4752-b36e-383685950656"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("2ba6e994-ac4a-45c1-a010-7a84b916bea9"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("342ff427-a1ef-43e4-a8f4-d59f71362e6a"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("5aa01d3a-2ad7-45bd-8d5e-76bfc18f7b91"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("5d2fa7c4-7051-4e63-900a-a23ab9fb12ba"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("6636301d-3509-42ce-b6ee-432d186f9029"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("6c155229-d9dd-488d-a415-5198ee7d33f7"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("7632da7f-0a66-4e3b-bc2e-0357c82ff2ec"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("a96d63d9-cafd-424c-a88c-558a38b072e8"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("afdaae31-5e9a-463d-a522-a1f1e2743d19"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("bc63219f-b999-400f-9b54-4cd63e2c501e"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("bcfe733f-74a1-4e37-a130-3195945c6f6e"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("ca6c9f1a-d9a7-4dc5-a605-6858cf923565"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0eadec31-9472-4eb8-bc2d-c567202a6e6a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1b51ec7a-94cb-4adf-924e-82b8673b8c4c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("299e674b-25b6-4eb7-a299-4bb47cfc8ece"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4a4c9e3d-6c47-4a8e-bdc2-bf27fd9a0c1d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a75b01fa-dfa5-4b0e-b028-3ae55eabe6de"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c423f534-14f9-47a5-88dc-8b94374d8292"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cdef6ff8-e56e-4bfc-baf0-192af5639636"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("dd8fdecf-6a55-41b1-bec8-c9fa4283b658"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e2074dcd-9605-44eb-8161-880920473739"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e7b3ddcf-b46e-4e6d-b9a7-cfb59bd054da"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ee7b64d2-bf18-4552-ae25-9055deef5aa6"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("2bf6d30e-8e8e-4ddf-be7a-a778da580d2b"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("2c1db32b-adc1-4b0b-bb27-68d7bf63de0e"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5a4d6fb1-407c-4bfe-a9df-d877af320802"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("63bcbcd7-b461-4636-b3ca-d9f5112f45c9"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("87fd0162-8a13-4f98-ab57-a304cdd294f8"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("9681b955-d36c-4fe5-8612-8c7320ec3fab"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("ab73b236-7e84-4289-8021-c7a41d42d454"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("b05ff33b-eaf5-40fd-b541-f9678e40e179"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("ca817862-68ee-4b14-84b6-83da19410083"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("e8b4d396-374e-471c-b309-528f9126a321"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("ed08f95b-cc74-4069-be8b-6640ce158981"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("0482e24c-fe41-4013-b367-e6f9bce84c9a"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("186116df-50ac-49ad-8b01-9f5d454327fe"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("1d972796-6164-4691-b4c3-3c0d11611cf4"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("22088db1-6b77-4415-9332-58ec787c3d3e"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("36b555f0-4421-4f78-aafb-d5b28cc6459a"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("511dc3f1-f2a5-446a-b169-81b2191bcd48"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("650f3b84-a010-4d70-9f8c-c939c4a7d438"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("7558e0ff-efda-491a-bb5d-c788cf69c134"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("b7e266e8-f8e3-4a29-aa70-29f31ac34b44"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("c863a6fa-b449-4aeb-b307-e4a310dc24a7"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("dd757d65-3ead-4fe3-9ca8-07d381544857"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38f883a9-cec8-4c47-be8c-971914c658f4"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("356239c6-c666-4fac-b782-ce0166a36ef4"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("4378cb34-27a1-4a1c-8d64-dd3bd80dbf18"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("8be716f3-b634-43ea-947f-e5ec2d0ef9c9"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("949a4d3d-611c-4f5a-b1d4-b99bb4c22a99"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("99e27a16-10e9-41ea-b1d4-7cd663c2b73e"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("b8861924-763b-442f-930a-385c1f27bc70"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("de82b6c5-e2be-460a-81fe-3048b2386d7b"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("e8ca298d-6203-47c3-8a6f-578e26843cb7"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("f34deb81-45c4-46e2-9f3f-8d3dda6942ab"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("fbbb29a0-b8df-4685-9238-93335d490f57"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("fd20a73b-84fa-407f-9917-344866a30b7d"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("0183cc5a-7328-46a7-b3cc-0475796f2bb9"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("049b976f-3155-4989-bf8b-571c3a92e4d6"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("05790b2c-bca4-42c4-8da2-3b36aa7b43d9"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("0800bae6-7d2e-4fb7-807b-1cb2f3c13181"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("0b62aa9a-b731-4827-8293-afb3a6637578"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("0cd9e9a6-ac83-47aa-ad34-90ce3a3f9d0c"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("17f933ec-f147-4868-8ec7-d545668f422b"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("1bad3a4f-a5b9-4b13-ab8f-a8fc24319e8e"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("1c56021b-0b92-4bbf-8f32-c5f3accb9cdf"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("1d141fbf-dd62-4ea5-b881-196e6ed002e2"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("242a65f3-f757-4877-9512-4d2ddaa7726d"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("2c3b0216-b89b-4006-806a-8c3aa04cc19b"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("2f163ec8-2d32-4f94-a7fe-080976729700"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("39485431-1092-4529-8ca8-e01e90e997fd"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("3d8352cc-43cf-4c10-9786-03da70b25972"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("3f48af34-b407-4631-9254-9527d1086773"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("40b36f30-c2e2-499d-95da-2b8018a608fe"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("4199f2e4-facb-451a-bcc2-74e71e4867fc"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("4320a5a4-9038-473e-9971-993792c676e0"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("45ce2f54-d7e4-426c-8a00-78e36d29a69f"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("47cbf735-07be-41f4-a693-57d773d23c1e"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("4cd0d235-91d7-4cc1-ad3a-1d475214ce5e"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("4eaed66e-a94c-4daa-8f0b-710c94f853d6"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("504c5293-45e3-40a6-b50b-8cf57344b4d8"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("5cac611b-f5a0-4172-b830-7ef11b5c4903"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("60aa71cf-baef-4a81-966f-16f57d7e36df"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("650a7c3c-938a-4057-ae84-357e353f613a"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("69e93a37-cebf-4d48-bc89-f69d384e4296"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("706f7d19-5e3f-4908-8dff-006ad7dfc46c"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("7207c826-d8e5-4eba-83f2-6c3004a60d10"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("74f949cc-8700-4d78-87cf-5dbfa4e43d10"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("7733ea06-8b9e-4568-b1b9-b06286df8675"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("780d41f0-99f9-484b-943a-ba4fec2544a7"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("7be98691-868a-4dca-a35c-bda5e53ef107"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("7ff7610e-c54b-4547-a89c-689103c7aa28"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("802e26ae-f458-46c4-b412-c63e17dce953"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("80943423-fb0d-475d-afe7-e1ef3e8ba3b6"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("825c8a4b-223b-4eeb-9957-44ab7ab301ff"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("859aa85c-0145-4f25-a300-6dfab8cb944f"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("8782d675-2e8d-4cc6-9d2b-78e04eaecbdd"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("879e6e90-0889-4d5c-bf8a-ed2198aebdeb"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("88b49e40-457d-4d2f-93b6-311c486f007a"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("88e135d8-2562-4f0d-8789-9cbeea0ada4b"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("89311cc9-ae5a-4831-b1de-95af25f0b6a8"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("8d88a840-198a-415c-afd9-78980c586f49"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("8dcbcdd5-b050-4a53-9062-fec3d446efd9"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("904102d5-63d1-47ca-b6d6-02492e5cff76"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("915a2fa6-b6d8-493a-b273-6232e678f0c7"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("951247fc-7b84-4d6a-b3e0-09ad8a815863"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("9a87b7bd-ffd6-4c3d-8dc5-d2566ee2519e"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("9f7b15f5-eb32-4200-8595-28f66ca2e8ba"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("a1e9439d-7c34-4dab-b207-83ee6c813446"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("a2f8d23a-164e-449c-86e2-a67005882d79"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("a46fd3bc-e076-42ae-a911-106d76defe4f"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("a8246c2c-c198-4a20-89ac-37defa074f8a"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("a8f4d042-dce7-40f6-a6c3-a9ffb57d6e08"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("a91976ee-7d27-4423-ab0d-7b676fc61c78"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("a9241ba1-7e66-452b-949c-e6e0b8215d32"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("aa3a4734-6aa9-4618-b926-8ab7551b6b36"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("ac51b9e4-5823-43b3-a786-2777dc8526bb"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("ad0f25d1-468c-45c7-8a7e-bf6eed861cb1"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("add6ffd1-060e-4b95-bd6c-9a4ce11a5aaa"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("b09ab14a-06cf-4105-9ba1-5ab64d77163c"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("b34d10e3-64aa-4282-afb9-b802e1c95235"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("b6d8cd93-3519-49df-8853-594c041f6a1b"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("b85876f5-3152-4816-a3c9-b9018cc3e3ba"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("ba63a116-87ba-424c-a41a-ec8aac0a727e"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("bdbcb950-130e-4d5c-a6b5-f025fda6deac"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("c2078180-7318-4018-86f4-8c87bdb8e54e"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("c288f0a8-8498-4fcf-a411-4f26f1c78c93"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("c7ce510d-2d0b-4410-a1a5-801238f6ab3b"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("c81ae011-acd9-428b-91b3-def6c105d511"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("ce4bca2c-cf38-4f76-b205-b8ec7b988ea4"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("d5f75a8d-4deb-4a15-be43-865357658580"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("d7c500e7-9716-433c-bbd4-b679dc8a3e0f"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("d9fa2157-3343-47d2-a123-d82c5b03aa80"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("da0e8c8c-c495-42f0-a53b-60c4c547f197"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("dd0b7826-d458-444c-be52-743ab7190efe"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("e1ce7769-fd1a-46d3-89d7-9ad3081ef418"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("e1f5046b-2eb4-4d4a-9e0c-c5673e60c4db"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("e3306646-cd0b-4ea6-9917-53d43498f77d"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("e55dc51a-03a7-48e7-a300-b490f2e71a27"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("e6432869-ddb7-4a7a-b040-3db306574186"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("e863d7a9-f4de-4c7e-a2de-cd83e84b3314"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("e8d9f27d-4a21-4c0b-b366-12808ac0e5a3"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("eacebbb7-f5bb-4144-af76-c90c1e2d8519"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("ebc417c2-3098-4b7b-944a-c6a2e02ec54c"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("f0405c39-add2-4bcb-8bb0-8441915bb752"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("f098be0f-2221-4c6b-854f-788f88e43435"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("f0b62ef7-dc7a-47ce-aa26-baf0c2406ca6"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("f10b6c27-e564-4cd2-99b3-9d8c6927e8d9"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("f25bb0b6-30ff-415b-834c-73b84f9c51bc"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("f359bfe1-21e6-4116-bdcf-54b31601184f"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("f5152575-eb82-4d80-ae27-4f53b9819671"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("f5e0dcde-f86a-40ac-adbf-cc8fc653f3bd"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("f97071da-4ec1-4cff-9261-3a8b6b180dd9"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("fad8b395-a82e-4a6a-bd3d-4bfc37298fe6"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("fb3eeb93-74da-4844-9104-24692fa3989a"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("fc064ee4-8970-47a7-be6a-a2c55632a2d7"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("fd024c14-2b93-4b77-be56-9b4746089550"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("ff3bf3ee-6436-45fd-a577-02dd7327853f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6b11f036-a212-49b1-904a-6ad7ea43d638"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("de3b1085-5cb0-4a92-8357-a5284819bf6c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fbf25fbf-5881-4a56-ae4b-bea5a4183e55"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("554e280a-40c9-4a48-bb3b-b362c8ab178b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c9fc2d56-19cc-48a5-a5b8-936c14fae664"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ff57824-8810-485a-9767-147798cdd845"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("146d4211-3b46-4b17-a95a-a12c918c3ce5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3598c444-c41a-4d74-976a-918cc55d2803"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("59c95733-e5e6-4b3e-bba5-c13456bd8a2b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5b28ebcc-e93e-41e1-9bf9-fdc4763dd025"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e8bad4d-3d1c-448e-b2ec-e9b12d45c6e4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("87010c49-da1b-484d-8baf-e53c27bbfb0c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b5208bd1-6cdb-4a01-87f1-9a6651ecc1a1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6c8b787-9591-4883-aaf3-b197b861d112"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c7d3fed5-8140-439c-a74f-220d61669d64"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d307145e-0a9a-452a-a079-b3d50b7feea1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dcdda066-1bab-4ca3-ab48-d4dd8a77b0ff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e2036b88-618b-4434-930a-6143bfec0e52"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("f511404b-4ea3-493a-bf12-65e157180921"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0a2e86e2-495f-49a5-9d50-1d8adb6248d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17fbafc5-630f-4941-a0ce-293148e13e86"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e189e92-a0ab-416d-a708-9560d283bd2b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4e88318e-2947-4475-90f5-e96f957d7b1a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a31de00-b990-4d94-9f59-fb38b96e5c8f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8891c817-d862-446d-9ba9-af4b3227ab83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ac332d83-c238-4d7c-a3b6-517d2c881474"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b32389a7-c793-4c70-b0ce-67017447f991"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d9629043-b6be-4637-9847-c149a2f63ce9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ed8f52ce-2934-46e3-8f01-dfa6b0da0344"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f4c07995-701e-4e7e-be73-6e1be55ecd7d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dd4b94c7-24ef-45e2-ade5-06003ffc2bc2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f5834f1c-904e-4a32-87a0-3d6368baa0d3"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("3778eb62-d2d7-4599-bef0-200d342d595b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17ee3cb9-9e49-4a44-887c-789205cba897"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6cd18250-2f0f-4f39-acef-e4be69b9eb2b"));

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalAmount",
                table: "Carts",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(18,2)");

            migrationBuilder.CreateTable(
                name: "CartDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    CartId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartDetails_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ParentId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2ec7aeaa-fff2-4884-9a1d-45a1b1a2142f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần", null, null },
                    { new Guid("a354210c-20ad-4313-b53a-415c4bfb02d3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo", null, null }
                });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Price", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("043db74d-f4cc-450d-932b-b22e1de4446e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("07ab47fb-5f51-4f92-a5a7-52d0804ccd59"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("09550072-9d6a-45d2-9374-865017497a88"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("0c2fa4be-ffcc-4283-9f6b-2eb15b38f53a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("0dfe6c3e-e489-4a70-b609-4ce22ff3f57d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("0f27d867-0439-4872-91cc-cb309da55445"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("11bf56d0-0a15-47ef-ad94-649c2328ee42"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("14626a63-8012-417c-b432-62e5d697c9a2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("1472d128-5fe2-4246-9384-49fba2efb3b3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("17892b81-a56a-4f70-8608-46d83297fff0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("1b27940f-369d-475e-9b95-a1da84fb44c6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("2202aca3-5695-4122-a508-1527ac9cd8b1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("23be33ba-c6a6-4ca3-b2aa-c19d5cc28192"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("240793de-ea0e-44e4-bcea-69981f8a3101"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("240c0711-22b7-43d2-a4b8-367c36dc17ec"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("2a54d1f5-5ad4-4095-b928-977860e133f5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("2bc7f681-35df-4bac-a820-c7215c6fa4f9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("2bfc4092-b23f-44a7-96d7-ec00c9059005"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("2d4015b2-96eb-4f1e-a6c0-c52f420a9b62"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("2e6daa10-d17e-427e-a463-3bfc1b92f3e8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("317f825f-9985-499a-87c7-9d2372230cc2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("346b2b9a-aa41-4437-9e2d-a74bfaacbf22"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("3bcdc169-fb2d-4165-a859-bc0258f88506"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("3c0ddb8d-71cb-40f6-8eb6-967ec473ff7a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("40e715bf-50e6-403d-a712-c26541969d70"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("453dd81e-dd72-4454-84c6-f99c915b7636"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("46166c6b-15ea-4ce1-a564-7b20da94d17d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("47d34896-1ffa-4995-b19b-036b31781a37"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("49515985-3699-4530-9d92-b11664e5643d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("4f95dc4d-d36b-483a-a420-6f37dbe14241"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("52ba1b16-b4b9-4861-872e-388b69fbaf53"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("54be530e-b106-4a21-8a81-91c74322dfb8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("5a1d4447-13ee-4dac-a94f-b9c67e8c93a1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("617a2918-3fee-4299-b3a7-9888c0d31028"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("62f395d1-e954-45f6-831e-7a8ec61e865e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("658ef9ee-8f30-4d78-9042-9c1c5675fe32"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("681696ae-343f-4851-afa7-ce046863417c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("687f407a-d3a1-4958-aeed-15dbecaaa2bd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("6979bf20-087b-4211-b75f-9180d0a2d233"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("69b0672c-c51a-4901-ae0f-f766be2910c8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("6eec97ae-44df-424b-a5fd-8640b870d164"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("721904b1-9aaa-4819-a799-ba70a70e812c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("72d151ff-a7ed-4952-a637-447d3e2cd915"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("747dd12e-81e2-4a8e-b520-fdd252f820d9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("78992868-81bd-43bd-ab82-066c314b6377"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("7cad0837-b68e-4277-86f3-b923b9292f67"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("840b84e9-1cbb-4871-8c4a-74e7079bba13"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("84c541c7-bd90-450d-a89d-6861378af758"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("875a2323-01f3-475a-a6bf-bf3f4b37e31b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("878743dc-c1f8-4597-877c-4afed2dd0134"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("880556e5-01cf-4de0-bcc8-bab7752d795d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("8b321d59-57da-4b6a-b4f2-e41045909d54"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("8b8f0089-6345-4f73-a20b-53845ee08b7d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("8d326888-4f6e-4a2e-b2f5-5225ee177200"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("8d9bd3fe-0292-4024-913b-2ee76de25095"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("8e90ef9b-b1e2-452e-a91d-ddd5e6f654e0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("8f89ffa1-41fa-4ecd-9134-751f0faf600f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("99beb8c5-ede5-4fab-b601-c8462f2424d6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("9c18f0b1-91cd-4148-906a-5aced95da2b1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("9c975576-7806-4918-a86e-3ecc1c81d973"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("a001a6d4-117b-4e2a-ad3f-5e515686a7a0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("a0ce72c7-0f4e-48b3-87ce-5c4533dc1c9a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("a15f0d7b-a157-4a05-99e9-d4d4d05f3f23"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("a2e03764-5ef3-480e-b529-9fd053ed77c5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("a591c2e3-cc5f-4a0b-a841-98d2dea00831"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("a59a4b63-4b5b-4fb0-b8bf-bb85d7d1ba40"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("a805f9e8-5300-4f6d-bbb4-80fa2a6d7772"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("aa99d822-0632-475a-af35-9307f0b4e681"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("aad4ab45-1fc3-4307-9773-b82dce9e238e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("aba89f83-94a5-4ba8-98f4-4e578cb2ed07"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("acc9120d-a2cc-4302-b570-446e4b2fa6ef"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("ae0f8d04-dad2-46c3-97d5-fad23ed80bd0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("b04a27a0-c106-4a59-a19f-720a7ce669fc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("b362ed2d-bacb-40ce-a23e-2211a50fef05"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("b6560073-c1bc-4a2c-b612-530560610f48"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("c2a97e2f-aaf7-4c4d-ab4d-6c1d66735951"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("c61d4f34-0922-46e6-ab65-767cdaab2569"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("c6cdb6cc-d4b2-4ea7-a200-3324d4660e83"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("c82d73f9-1fed-4e77-9a8e-7e8d8f3c5162"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("cc50360c-2549-4357-991a-42f6f6558c7c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("d0f5066f-e4d8-4656-ac64-a09df5c6af22"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("d1e8e5c4-0e17-4ead-9c21-7bcf533040ba"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("d276352f-7163-4d68-9213-c67cbbc77f0f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("d2dbb820-0f68-4074-a52c-9c2160a73f5e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("d525be3b-077a-451b-908e-e22ee1c6099a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("d58ac02c-3163-474e-8b40-de366e0afed9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("d6aaca1d-ca1a-4c80-8ea4-4e6b50fcac75"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("d87a8f92-bb71-4569-9a35-692657c6ca88"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("d929adc3-b69a-43f3-b1c6-3e08ffefc2de"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("d9a5b8aa-a17d-4247-a0a8-e440d9d19c8e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("dfa80cff-6764-4e9e-963b-f3f8cf01b7b1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("e50ec803-4554-4f41-8c93-c48478179d45"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("e51b0d35-c68d-4437-8623-9354eb57663d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("e55cfc28-4261-4c69-b49d-83d680e0513b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("e5c73778-ec63-4d81-acc2-e57eb8242dd4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("e7980240-7d6b-4453-b7ef-ee9b15ed0cc8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("ea2acb9b-cbde-4a53-b034-b9a09d263ec3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("efd6ed10-360a-4af3-b12c-bf9654598d4f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("f0c2127e-7f01-4294-8a0a-05fff87b1178"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("f67636b2-1710-4487-ba2f-910c72e2cf44"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("fb3fb448-3ddb-4520-996a-5f7d40faeb4f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("fe76f714-8539-477e-8e6c-2d8da6b50a09"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedAt", "DateOfBirth", "Email", "FirstName", "HashedPassword", "ImageUrl", "IsDeleted", "IsVerify", "LastName", "PhoneNumber", "Role", "UpdatedAt", "VerifyCode" },
                values: new object[,]
                {
                    { new Guid("03198527-0aad-4373-9c0b-f50a4a764144"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tan182206@gmail.com", "Tan", "hashed_password_1", null, false, false, "Tran", null, "User", null, 0 },
                    { new Guid("058407da-b5f1-449b-9dec-160597c6c898"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan3@gmail.com", "Tan3", "hashed_password_3", null, false, false, "Tran3", null, "Seller", null, 0 },
                    { new Guid("176b6be0-9dab-424d-8394-bde71f75acae"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan9@gmail.com", "Tan9", "hashed_password_9", null, false, false, "Tran9", null, "Seller", null, 0 },
                    { new Guid("1aca32bc-dc1d-4d51-87ef-79bfe4cdac4c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan5@gmail.com", "Tan5", "hashed_password_5", null, false, false, "Tran5", null, "Seller", null, 0 },
                    { new Guid("20734490-818d-428f-98f9-38a14a35a63e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan0@gmail.com", "Tan0", "hashed_password_0", null, false, false, "Tran0", null, "User", null, 0 },
                    { new Guid("2d9ccdb6-74f1-4243-9d92-3d4e5db15b5b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan4@gmail.com", "Tan4", "hashed_password_4", null, false, false, "Tran4", null, "User", null, 0 },
                    { new Guid("4117118b-abbd-4993-b556-94d44135b059"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan8@gmail.com", "Tan8", "hashed_password_8", null, false, false, "Tran8", null, "User", null, 0 },
                    { new Guid("640216a0-b0e9-400d-a8c5-5fb8510a0644"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan7@gmail.com", "Tan7", "hashed_password_7", null, false, false, "Tran7", null, "Seller", null, 0 },
                    { new Guid("8cf16160-8173-4ede-8834-419a48fd7879"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan1@gmail.com", "Tan1", "hashed_password_1", null, false, false, "Tran1", null, "Seller", null, 0 },
                    { new Guid("9475b3ca-5a61-423c-8a2e-91dacd311612"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan6@gmail.com", "Tan6", "hashed_password_6", null, false, false, "Tran6", null, "User", null, 0 },
                    { new Guid("d7e355ad-d26c-4203-9659-c80f033ba855"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan2@gmail.com", "Tan2", "hashed_password_2", null, false, false, "Tran2", null, "User", null, 0 },
                    { new Guid("e60be085-65a5-4552-9659-ecd171e87a8e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tan182205@gmail.com", "Tan", "hashed_password_1", null, false, false, "Tran", null, "User", null, 0 },
                    { new Guid("ef11b4ed-5890-4134-b133-5af4325a8828"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "piedteam@gmail.com", "Pied", "PiedTeam", null, false, false, "Team", null, "Admin", null, 0 },
                    { new Guid("f853a07d-8437-466f-b7a0-2f689d5b7a3d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan10@gmail.com", "Tan10", "hashed_password_10", null, false, false, "Tran10", null, "User", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "TotalAmount", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("027544b7-c4fa-49c4-bf80-0f9a8007d18f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("1aca32bc-dc1d-4d51-87ef-79bfe4cdac4c") },
                    { new Guid("058c021d-5bed-4e16-a2ff-7e67d33bafb5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("2d9ccdb6-74f1-4243-9d92-3d4e5db15b5b") },
                    { new Guid("3c01c68e-2924-4d3e-b1c1-a7039a6a8aa5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("f853a07d-8437-466f-b7a0-2f689d5b7a3d") },
                    { new Guid("3ddf5c76-18fe-4b56-b221-97d3f642f55b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("4117118b-abbd-4993-b556-94d44135b059") },
                    { new Guid("431211dc-58b1-4c05-a3c1-8b160aee5f3f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("d7e355ad-d26c-4203-9659-c80f033ba855") },
                    { new Guid("4d8991f9-343b-4cc4-a63a-1e1381c87637"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("9475b3ca-5a61-423c-8a2e-91dacd311612") },
                    { new Guid("69893398-4879-4587-a1e3-115f93638164"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("8cf16160-8173-4ede-8834-419a48fd7879") },
                    { new Guid("6dee79af-8f43-40d9-9d5c-16fab30c7f53"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("640216a0-b0e9-400d-a8c5-5fb8510a0644") },
                    { new Guid("a34f6cbf-63fd-4ed0-9f57-43705d6435f2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("176b6be0-9dab-424d-8394-bde71f75acae") },
                    { new Guid("a77ee83d-c7c3-43c7-b9fd-103caacaf490"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("20734490-818d-428f-98f9-38a14a35a63e") },
                    { new Guid("e7b059db-01a4-460f-89d5-2efe92a10ee8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("058407da-b5f1-449b-9dec-160597c6c898") }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ParentId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("355edb3b-4be6-4989-882b-86625fd97204"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao", new Guid("a354210c-20ad-4313-b53a-415c4bfb02d3"), null },
                    { new Guid("9df0a0d2-893d-4d2b-8551-a5e136e55f2c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo ba lỗ", new Guid("a354210c-20ad-4313-b53a-415c4bfb02d3"), null },
                    { new Guid("c2744a56-4093-4c14-9410-800305672ceb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Kaki", new Guid("2ec7aeaa-fff2-4884-9a1d-45a1b1a2142f"), null },
                    { new Guid("c84f8a06-0232-49a8-ab37-319c33980799"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Jean", new Guid("2ec7aeaa-fff2-4884-9a1d-45a1b1a2142f"), null }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "CreatedAt", "IsDeleted", "Status", "TotalAmount", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("0223e20c-4224-405a-8692-7b5701f87b87"), "Bien hoa, Dong Nai2", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed2", 10002m, null, new Guid("8cf16160-8173-4ede-8834-419a48fd7879") },
                    { new Guid("0cbb1831-0d5c-4d9b-9ac0-1668194b5461"), "Bien hoa, Dong Nai10", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed10", 10010m, null, new Guid("176b6be0-9dab-424d-8394-bde71f75acae") },
                    { new Guid("4f4a2405-7919-44b7-a159-fa626efe835b"), "Bien hoa, Dong Nai6", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed6", 10006m, null, new Guid("1aca32bc-dc1d-4d51-87ef-79bfe4cdac4c") },
                    { new Guid("69eba3d7-823a-4334-864a-0b20e1afff0f"), "Bien hoa, Dong Nai11", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed11", 10011m, null, new Guid("f853a07d-8437-466f-b7a0-2f689d5b7a3d") },
                    { new Guid("777678d5-b516-4c3b-95c6-dcbc8ccdf5e0"), "Bien hoa, Dong Nai8", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed8", 10008m, null, new Guid("640216a0-b0e9-400d-a8c5-5fb8510a0644") },
                    { new Guid("7dc544b7-d3ef-4e03-a48b-0cdffebb4288"), "Bien hoa, Dong Nai4", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed4", 10004m, null, new Guid("058407da-b5f1-449b-9dec-160597c6c898") },
                    { new Guid("81ac6b55-c0c7-4f4f-b2e0-6ff83882b09b"), "Bien hoa, Dong Nai1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed1", 10001m, null, new Guid("20734490-818d-428f-98f9-38a14a35a63e") },
                    { new Guid("9ad4a6cc-6fb7-4f60-9f0b-65bbc319378b"), "Bien hoa, Dong Nai3", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed3", 10003m, null, new Guid("d7e355ad-d26c-4203-9659-c80f033ba855") },
                    { new Guid("bec0c37d-0f8a-4939-89d0-4b8fe25e35d9"), "Bien hoa, Dong Nai7", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed7", 10007m, null, new Guid("9475b3ca-5a61-423c-8a2e-91dacd311612") },
                    { new Guid("c6a2200f-40d7-4492-a684-d1d84424e876"), "Bien hoa, Dong Nai9", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed9", 10009m, null, new Guid("4117118b-abbd-4993-b556-94d44135b059") },
                    { new Guid("ce63098d-40f3-4546-b61e-f0eabe51f593"), "Bien hoa, Dong Nai", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed", 10000m, null, new Guid("03198527-0aad-4373-9c0b-f50a4a764144") },
                    { new Guid("e5d7aa5b-3678-4daf-a8f9-a3127edb7a12"), "Bien hoa, Dong Nai5", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed5", 10005m, null, new Guid("2d9ccdb6-74f1-4243-9d92-3d4e5db15b5b") },
                    { new Guid("ffb2ee6a-3240-4266-86d5-6e71174170c0"), "Bien hoa, Dong Nai", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed", 10000m, null, new Guid("03198527-0aad-4373-9c0b-f50a4a764144") }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "CompanyAddress", "CompanyName", "CreatedAt", "IsDeleted", "TaxCode", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("2a768757-7f13-4040-9791-224f61a9b09c"), "123 Main St, Cityville3", "ABC Company3", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE3", null, new Guid("d7e355ad-d26c-4203-9659-c80f033ba855") },
                    { new Guid("2fa659c5-3a65-4ad0-8a4f-5326b2c0d1ac"), "123 Main St, Cityville", "ABC Company", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE123", null, new Guid("e60be085-65a5-4552-9659-ecd171e87a8e") },
                    { new Guid("32fd05a7-3ee6-4412-92c3-34ad4fecc670"), "123 Main St, Cityville10", "ABC Company10", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE10", null, new Guid("176b6be0-9dab-424d-8394-bde71f75acae") },
                    { new Guid("5f8fd31b-e992-49ac-b1b9-e7c60434b8c7"), "123 Main St, Cityville5", "ABC Company5", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE5", null, new Guid("2d9ccdb6-74f1-4243-9d92-3d4e5db15b5b") },
                    { new Guid("66488689-b0ac-4ab4-b8ca-b413f575723c"), "123 Main St, Cityville11", "ABC Company11", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE11", null, new Guid("f853a07d-8437-466f-b7a0-2f689d5b7a3d") },
                    { new Guid("6e72687a-b7d7-4460-add7-6941cde96458"), "123 Main St, Cityville1", "ABC Company1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE1", null, new Guid("20734490-818d-428f-98f9-38a14a35a63e") },
                    { new Guid("746f80ad-5b55-469c-834c-0ee5dc949b17"), "123 Main St, Cityville8", "ABC Company8", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE8", null, new Guid("640216a0-b0e9-400d-a8c5-5fb8510a0644") },
                    { new Guid("7cac99bc-e933-4a8f-b839-20663ff27703"), "123 Main St, Cityville4", "ABC Company4", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE4", null, new Guid("058407da-b5f1-449b-9dec-160597c6c898") },
                    { new Guid("8e0dea23-c31d-4cf4-857b-4296cbe3721e"), "123 Main St, Cityville7", "ABC Company7", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE7", null, new Guid("9475b3ca-5a61-423c-8a2e-91dacd311612") },
                    { new Guid("a761bc10-6866-4401-a3a9-3165b78939c2"), "123 Main St, Cityville9", "ABC Company9", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE9", null, new Guid("4117118b-abbd-4993-b556-94d44135b059") },
                    { new Guid("ade2ae32-80cb-4ddb-acf1-7e842155db06"), "123 Main St, Cityville6", "ABC Company6", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE6", null, new Guid("1aca32bc-dc1d-4d51-87ef-79bfe4cdac4c") },
                    { new Guid("e80f7c48-6f5a-496d-b959-0273bd3afca6"), "123 Main St, Cityville2", "ABC Company2", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE2", null, new Guid("8cf16160-8173-4ede-8834-419a48fd7879") }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ParentId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("043ee77f-43cf-4458-8d0f-4510e61e709e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Jean9", new Guid("c84f8a06-0232-49a8-ab37-319c33980799"), null },
                    { new Guid("1ef3ae6a-b027-4145-908a-58f62b916a45"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Jean5", new Guid("c84f8a06-0232-49a8-ab37-319c33980799"), null },
                    { new Guid("6e18d087-f317-418c-a018-e0f34b478f9e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao8", new Guid("355edb3b-4be6-4989-882b-86625fd97204"), null },
                    { new Guid("783cda44-e685-4e72-95c2-030a1fffc9cf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao4", new Guid("355edb3b-4be6-4989-882b-86625fd97204"), null },
                    { new Guid("813fe488-3e47-4585-b81f-abcea0a7f4fd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao10", new Guid("355edb3b-4be6-4989-882b-86625fd97204"), null },
                    { new Guid("96cb0a88-adfa-43fe-8454-7596c7255987"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao2", new Guid("355edb3b-4be6-4989-882b-86625fd97204"), null },
                    { new Guid("9ae994e3-6beb-4257-8b23-9064aaae1a34"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Jean7", new Guid("c84f8a06-0232-49a8-ab37-319c33980799"), null },
                    { new Guid("9eb02f87-4613-4c6c-b576-a6154b977cff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao6", new Guid("355edb3b-4be6-4989-882b-86625fd97204"), null },
                    { new Guid("b581d1b6-b982-44bf-8d87-4934e134eb08"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Jean3", new Guid("c84f8a06-0232-49a8-ab37-319c33980799"), null },
                    { new Guid("bce373a0-139f-4567-abe3-cabdaf5e01a9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Jean1", new Guid("c84f8a06-0232-49a8-ab37-319c33980799"), null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "Name", "Price", "SellerId", "UpdatedAt", "UrlImage" },
                values: new object[,]
                {
                    { new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Áo thun nam chất liệu cotton cao cấp, thoáng mát, phù hợp cho mọi hoạt động hàng ngày.", false, "Áo Thun Nam", 199000m, new Guid("2fa659c5-3a65-4ad0-8a4f-5326b2c0d1ac"), null, "https://example.com/images/ao_thun_nam.jpg" },
                    { new Guid("12b7b0ce-b395-4e7c-a3ec-7f27d485e10a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt7", false, "T-Shirt7", 199000m, new Guid("2fa659c5-3a65-4ad0-8a4f-5326b2c0d1ac"), null, "" },
                    { new Guid("3683c03a-7164-4c2b-9a8e-feef06ded0d4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt10", false, "T-Shirt10", 199000m, new Guid("2fa659c5-3a65-4ad0-8a4f-5326b2c0d1ac"), null, "" },
                    { new Guid("3b24a462-acc0-445e-ae11-b8dd2463b6e8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Áo sơ mi nam công sở, thiết kế hiện đại, chất liệu vải cao cấp, thoáng mát.", false, "Áo Sơ Mi Nam", 299000m, new Guid("2fa659c5-3a65-4ad0-8a4f-5326b2c0d1ac"), null, "https://example.com/images/ao_so_mi_nam.jpg" },
                    { new Guid("52ebd2f2-6127-454d-a1b4-ab3abefad087"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt8", false, "T-Shirt8", 199000m, new Guid("2fa659c5-3a65-4ad0-8a4f-5326b2c0d1ac"), null, "" },
                    { new Guid("534a29b0-6bc9-414e-936d-313f2e3cd2c2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt2", false, "T-Shirt2", 199000m, new Guid("2fa659c5-3a65-4ad0-8a4f-5326b2c0d1ac"), null, "" },
                    { new Guid("6edc2b7f-caed-492d-8e07-08433dfb6829"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt4", false, "T-Shirt4", 199000m, new Guid("2fa659c5-3a65-4ad0-8a4f-5326b2c0d1ac"), null, "" },
                    { new Guid("977d849d-d226-42ed-8550-922ab36c3494"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt1", false, "T-Shirt1", 199000m, new Guid("2fa659c5-3a65-4ad0-8a4f-5326b2c0d1ac"), null, "" },
                    { new Guid("9afbde63-84a6-4fe1-9a33-ceacad8c1142"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quần jeans nữ dáng ôm, tôn dáng, chất liệu denim co giãn, phù hợp cho mọi dịp.", false, "Quần Jeans Nữ", 399000m, new Guid("2fa659c5-3a65-4ad0-8a4f-5326b2c0d1ac"), null, "https://example.com/images/quan_jeans_nu.jpg" },
                    { new Guid("a2f1cccf-f4c3-4d97-aaad-44e529683493"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt3", false, "T-Shirt3", 199000m, new Guid("2fa659c5-3a65-4ad0-8a4f-5326b2c0d1ac"), null, "" },
                    { new Guid("a68ba329-c005-4b1c-9216-96d5c71bb9a6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Chân váy nữ xòe, thiết kế trẻ trung, chất liệu vải mềm mại, phù hợp cho mọi dịp.", false, "Chân Váy Nữ", 249000m, new Guid("2fa659c5-3a65-4ad0-8a4f-5326b2c0d1ac"), null, "https://example.com/images/chan_vay_nu.jpg" },
                    { new Guid("a9b0dba2-2fe7-4a50-ba27-40607dc5db4e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt6", false, "T-Shirt6", 199000m, new Guid("2fa659c5-3a65-4ad0-8a4f-5326b2c0d1ac"), null, "" },
                    { new Guid("c12c4965-16d7-4661-aa7c-0689a3727054"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt0", false, "T-Shirt0", 199000m, new Guid("2fa659c5-3a65-4ad0-8a4f-5326b2c0d1ac"), null, "" },
                    { new Guid("e0267ab6-10ab-4d53-82d8-b9c6f87f9b5f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt5", false, "T-Shirt5", 199000m, new Guid("2fa659c5-3a65-4ad0-8a4f-5326b2c0d1ac"), null, "" },
                    { new Guid("f0f7a31e-0763-4b93-b811-b04bd2a11b92"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt9", false, "T-Shirt9", 199000m, new Guid("2fa659c5-3a65-4ad0-8a4f-5326b2c0d1ac"), null, "" }
                });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "ProductId", "TotalInStock", "TotalSell", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0c92ca98-f0bc-4d6a-9c12-c1a451813832"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("6edc2b7f-caed-492d-8e07-08433dfb6829"), 1000m, 1000m, null },
                    { new Guid("2a5676ed-5130-48db-9991-5a82df9b74c8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("534a29b0-6bc9-414e-936d-313f2e3cd2c2"), 1000m, 1000m, null },
                    { new Guid("42c99a46-ba17-45e3-97c7-aaea8a5d946a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("a2f1cccf-f4c3-4d97-aaad-44e529683493"), 1000m, 1000m, null },
                    { new Guid("8d668262-0268-4f9c-b6b0-618a851ba5a2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("a9b0dba2-2fe7-4a50-ba27-40607dc5db4e"), 1000m, 1000m, null },
                    { new Guid("94c5df6a-6828-41a7-8fe3-bf79572c146d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("52ebd2f2-6127-454d-a1b4-ab3abefad087"), 1000m, 1000m, null },
                    { new Guid("a43c14eb-0b64-4fe9-ad24-4a49ee270f2c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("c12c4965-16d7-4661-aa7c-0689a3727054"), 1000m, 1000m, null },
                    { new Guid("aa61a401-1af1-4b02-ad7d-c3b336a54f99"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("f0f7a31e-0763-4b93-b811-b04bd2a11b92"), 1000m, 1000m, null },
                    { new Guid("bae62ec4-e6ad-4eb1-9fdc-897e2a2fa649"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("977d849d-d226-42ed-8550-922ab36c3494"), 1000m, 1000m, null },
                    { new Guid("c37e88d8-3a19-4fe3-8237-910a22748b2e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("12b7b0ce-b395-4e7c-a3ec-7f27d485e10a"), 1000m, 1000m, null },
                    { new Guid("ee2de563-8380-48cf-a76d-f919cd727160"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("e0267ab6-10ab-4d53-82d8-b9c6f87f9b5f"), 1000m, 1000m, null },
                    { new Guid("f54b4796-d53d-4dd5-8837-32ffce353f08"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("3683c03a-7164-4c2b-9a8e-feef06ded0d4"), 1000m, 1000m, null }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "OrderId", "ProductId", "Quantity", "UnitPrice", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("135c8ce5-5033-4aa0-8f42-002abdb7ed01"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("ffb2ee6a-3240-4266-86d5-6e71174170c0"), new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), 2, 19990000m, null },
                    { new Guid("225a0e69-9ff1-435d-9d2f-92fdad8e5573"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("ffb2ee6a-3240-4266-86d5-6e71174170c0"), new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), 2, 19990000m, null },
                    { new Guid("43afb203-a2d7-4dd7-9bae-39cafd22bb86"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("ffb2ee6a-3240-4266-86d5-6e71174170c0"), new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), 2, 19990000m, null },
                    { new Guid("5c6f3aa3-0196-4000-b644-0625403eb1fe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("ffb2ee6a-3240-4266-86d5-6e71174170c0"), new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), 2, 19990000m, null },
                    { new Guid("62bf8a82-1c13-434b-a5cd-e26d9bb31dea"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("ffb2ee6a-3240-4266-86d5-6e71174170c0"), new Guid("9afbde63-84a6-4fe1-9a33-ceacad8c1142"), 1, 39990000m, null },
                    { new Guid("773b22a4-fa33-4ba7-8727-d54b92c51924"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("ffb2ee6a-3240-4266-86d5-6e71174170c0"), new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), 2, 19990000m, null },
                    { new Guid("79deb5ab-0a74-40ca-88d4-ad2dceceb07c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("ffb2ee6a-3240-4266-86d5-6e71174170c0"), new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), 2, 19990000m, null },
                    { new Guid("900d86db-c374-4bca-858a-027ef1dd8805"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("ffb2ee6a-3240-4266-86d5-6e71174170c0"), new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), 2, 19990000m, null },
                    { new Guid("a085eda0-8a81-4750-91c7-533f965267c2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("ce63098d-40f3-4546-b61e-f0eabe51f593"), new Guid("3b24a462-acc0-445e-ae11-b8dd2463b6e8"), 1, 29990000m, null },
                    { new Guid("bddbfbc0-0051-40be-b32e-18279796fcb2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("ffb2ee6a-3240-4266-86d5-6e71174170c0"), new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), 2, 19990000m, null },
                    { new Guid("d7c383fe-c002-4d01-9279-fbabbfc56c74"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("ffb2ee6a-3240-4266-86d5-6e71174170c0"), new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), 2, 19990000m, null },
                    { new Guid("db880daf-5d45-4cc2-b9b2-8c7f54333137"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("ffb2ee6a-3240-4266-86d5-6e71174170c0"), new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), 2, 19990000m, null },
                    { new Guid("e3118d37-9a7b-4bb1-bcd0-1b1ad293c039"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("ffb2ee6a-3240-4266-86d5-6e71174170c0"), new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), 2, 19990000m, null },
                    { new Guid("e5c1b5b8-5c49-4bb1-8fd2-3aa622947129"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("ffb2ee6a-3240-4266-86d5-6e71174170c0"), new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), 2, 19990000m, null }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "IsDeleted", "ProductID", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("09e8f850-2fa3-4fc2-8cdb-cd050e8b2abc"), new Guid("a354210c-20ad-4313-b53a-415c4bfb02d3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), null },
                    { new Guid("0f32778e-2a73-4127-b7b6-b48ba8ca488b"), new Guid("a354210c-20ad-4313-b53a-415c4bfb02d3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), null },
                    { new Guid("4a4b03da-a502-4942-a891-32b36d8077cf"), new Guid("a354210c-20ad-4313-b53a-415c4bfb02d3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), null },
                    { new Guid("723e01ea-781c-41d6-bc68-f778fa6d2086"), new Guid("a354210c-20ad-4313-b53a-415c4bfb02d3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), null },
                    { new Guid("96c5b1da-d177-471a-abb4-1c31c89e15ff"), new Guid("a354210c-20ad-4313-b53a-415c4bfb02d3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), null },
                    { new Guid("9748096e-26a0-42fb-b875-ce879e8b5939"), new Guid("a354210c-20ad-4313-b53a-415c4bfb02d3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), null },
                    { new Guid("aef9d142-d96f-4d41-a078-c2d834fdd1e5"), new Guid("a354210c-20ad-4313-b53a-415c4bfb02d3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), null },
                    { new Guid("c6fbad9d-8341-496a-81ec-680cb6fbd35d"), new Guid("a354210c-20ad-4313-b53a-415c4bfb02d3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), null },
                    { new Guid("cbe351ed-5051-4c97-bf7f-b774c92a6dca"), new Guid("a354210c-20ad-4313-b53a-415c4bfb02d3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), null },
                    { new Guid("d43aaf78-f8bb-4fa9-9211-7e40d09c99e5"), new Guid("a354210c-20ad-4313-b53a-415c4bfb02d3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), null },
                    { new Guid("ed4fab51-6fa5-4570-9cee-6d2add072ac2"), new Guid("a354210c-20ad-4313-b53a-415c4bfb02d3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), null }
                });

            migrationBuilder.InsertData(
                table: "ProductStorages",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "ProductId", "StorageId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("062ed822-4a40-457c-a27f-e35a2bb55c93"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), new Guid("453dd81e-dd72-4454-84c6-f99c915b7636"), null },
                    { new Guid("21ceb35a-3e4c-40b6-9061-284fc29da610"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), new Guid("453dd81e-dd72-4454-84c6-f99c915b7636"), null },
                    { new Guid("7f0994eb-fc97-40e0-a4df-f34363467ba5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), new Guid("453dd81e-dd72-4454-84c6-f99c915b7636"), null },
                    { new Guid("7f67ddda-64c7-417a-8a07-dc6fc891b2fd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), new Guid("453dd81e-dd72-4454-84c6-f99c915b7636"), null },
                    { new Guid("8a9ca6ee-aee8-4e0d-bfa2-23524edb8f9c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), new Guid("453dd81e-dd72-4454-84c6-f99c915b7636"), null },
                    { new Guid("906f1ac5-c229-4b4a-983d-e1a764a75a52"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), new Guid("453dd81e-dd72-4454-84c6-f99c915b7636"), null },
                    { new Guid("936cd6a6-479e-4d33-b4b2-757cbf8eb7f5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), new Guid("453dd81e-dd72-4454-84c6-f99c915b7636"), null },
                    { new Guid("b2f6016b-b5e6-4d84-8320-ae82eb08ee5d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), new Guid("453dd81e-dd72-4454-84c6-f99c915b7636"), null },
                    { new Guid("da0e6c50-181c-4c20-8f03-ebeab6af79fc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), new Guid("453dd81e-dd72-4454-84c6-f99c915b7636"), null },
                    { new Guid("ea3e9f2c-8326-4e60-9f4e-aaad027183a6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), new Guid("453dd81e-dd72-4454-84c6-f99c915b7636"), null },
                    { new Guid("ed6bbbd0-d428-4d8c-9981-c6b4a75c20fb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("0611454f-3608-4723-ab2c-8635026d10bf"), new Guid("453dd81e-dd72-4454-84c6-f99c915b7636"), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_CartId",
                table: "CartDetails",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_ProductId",
                table: "CartDetails",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartDetails");

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("027544b7-c4fa-49c4-bf80-0f9a8007d18f"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("058c021d-5bed-4e16-a2ff-7e67d33bafb5"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("3c01c68e-2924-4d3e-b1c1-a7039a6a8aa5"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("3ddf5c76-18fe-4b56-b221-97d3f642f55b"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("431211dc-58b1-4c05-a3c1-8b160aee5f3f"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("4d8991f9-343b-4cc4-a63a-1e1381c87637"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("69893398-4879-4587-a1e3-115f93638164"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("6dee79af-8f43-40d9-9d5c-16fab30c7f53"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("a34f6cbf-63fd-4ed0-9f57-43705d6435f2"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("a77ee83d-c7c3-43c7-b9fd-103caacaf490"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("e7b059db-01a4-460f-89d5-2efe92a10ee8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("043ee77f-43cf-4458-8d0f-4510e61e709e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1ef3ae6a-b027-4145-908a-58f62b916a45"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6e18d087-f317-418c-a018-e0f34b478f9e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("783cda44-e685-4e72-95c2-030a1fffc9cf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("813fe488-3e47-4585-b81f-abcea0a7f4fd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("96cb0a88-adfa-43fe-8454-7596c7255987"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9ae994e3-6beb-4257-8b23-9064aaae1a34"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9df0a0d2-893d-4d2b-8551-a5e136e55f2c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9eb02f87-4613-4c6c-b576-a6154b977cff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b581d1b6-b982-44bf-8d87-4934e134eb08"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bce373a0-139f-4567-abe3-cabdaf5e01a9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c2744a56-4093-4c14-9410-800305672ceb"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("0c92ca98-f0bc-4d6a-9c12-c1a451813832"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("2a5676ed-5130-48db-9991-5a82df9b74c8"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("42c99a46-ba17-45e3-97c7-aaea8a5d946a"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("8d668262-0268-4f9c-b6b0-618a851ba5a2"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("94c5df6a-6828-41a7-8fe3-bf79572c146d"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("a43c14eb-0b64-4fe9-ad24-4a49ee270f2c"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("aa61a401-1af1-4b02-ad7d-c3b336a54f99"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("bae62ec4-e6ad-4eb1-9fdc-897e2a2fa649"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("c37e88d8-3a19-4fe3-8237-910a22748b2e"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("ee2de563-8380-48cf-a76d-f919cd727160"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("f54b4796-d53d-4dd5-8837-32ffce353f08"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("135c8ce5-5033-4aa0-8f42-002abdb7ed01"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("225a0e69-9ff1-435d-9d2f-92fdad8e5573"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("43afb203-a2d7-4dd7-9bae-39cafd22bb86"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("5c6f3aa3-0196-4000-b644-0625403eb1fe"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("62bf8a82-1c13-434b-a5cd-e26d9bb31dea"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("773b22a4-fa33-4ba7-8727-d54b92c51924"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("79deb5ab-0a74-40ca-88d4-ad2dceceb07c"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("900d86db-c374-4bca-858a-027ef1dd8805"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("a085eda0-8a81-4750-91c7-533f965267c2"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("bddbfbc0-0051-40be-b32e-18279796fcb2"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("d7c383fe-c002-4d01-9279-fbabbfc56c74"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("db880daf-5d45-4cc2-b9b2-8c7f54333137"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("e3118d37-9a7b-4bb1-bcd0-1b1ad293c039"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("e5c1b5b8-5c49-4bb1-8fd2-3aa622947129"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0223e20c-4224-405a-8692-7b5701f87b87"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0cbb1831-0d5c-4d9b-9ac0-1668194b5461"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4f4a2405-7919-44b7-a159-fa626efe835b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("69eba3d7-823a-4334-864a-0b20e1afff0f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("777678d5-b516-4c3b-95c6-dcbc8ccdf5e0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7dc544b7-d3ef-4e03-a48b-0cdffebb4288"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("81ac6b55-c0c7-4f4f-b2e0-6ff83882b09b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9ad4a6cc-6fb7-4f60-9f0b-65bbc319378b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("bec0c37d-0f8a-4939-89d0-4b8fe25e35d9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c6a2200f-40d7-4492-a684-d1d84424e876"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e5d7aa5b-3678-4daf-a8f9-a3127edb7a12"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("09e8f850-2fa3-4fc2-8cdb-cd050e8b2abc"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("0f32778e-2a73-4127-b7b6-b48ba8ca488b"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("4a4b03da-a502-4942-a891-32b36d8077cf"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("723e01ea-781c-41d6-bc68-f778fa6d2086"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("96c5b1da-d177-471a-abb4-1c31c89e15ff"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("9748096e-26a0-42fb-b875-ce879e8b5939"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("aef9d142-d96f-4d41-a078-c2d834fdd1e5"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("c6fbad9d-8341-496a-81ec-680cb6fbd35d"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("cbe351ed-5051-4c97-bf7f-b774c92a6dca"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("d43aaf78-f8bb-4fa9-9211-7e40d09c99e5"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("ed4fab51-6fa5-4570-9cee-6d2add072ac2"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("062ed822-4a40-457c-a27f-e35a2bb55c93"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("21ceb35a-3e4c-40b6-9061-284fc29da610"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("7f0994eb-fc97-40e0-a4df-f34363467ba5"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("7f67ddda-64c7-417a-8a07-dc6fc891b2fd"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("8a9ca6ee-aee8-4e0d-bfa2-23524edb8f9c"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("906f1ac5-c229-4b4a-983d-e1a764a75a52"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("936cd6a6-479e-4d33-b4b2-757cbf8eb7f5"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("b2f6016b-b5e6-4d84-8320-ae82eb08ee5d"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("da0e6c50-181c-4c20-8f03-ebeab6af79fc"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("ea3e9f2c-8326-4e60-9f4e-aaad027183a6"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("ed6bbbd0-d428-4d8c-9981-c6b4a75c20fb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a68ba329-c005-4b1c-9216-96d5c71bb9a6"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("2a768757-7f13-4040-9791-224f61a9b09c"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("32fd05a7-3ee6-4412-92c3-34ad4fecc670"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("5f8fd31b-e992-49ac-b1b9-e7c60434b8c7"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("66488689-b0ac-4ab4-b8ca-b413f575723c"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("6e72687a-b7d7-4460-add7-6941cde96458"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("746f80ad-5b55-469c-834c-0ee5dc949b17"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("7cac99bc-e933-4a8f-b839-20663ff27703"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("8e0dea23-c31d-4cf4-857b-4296cbe3721e"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("a761bc10-6866-4401-a3a9-3165b78939c2"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("ade2ae32-80cb-4ddb-acf1-7e842155db06"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("e80f7c48-6f5a-496d-b959-0273bd3afca6"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("043db74d-f4cc-450d-932b-b22e1de4446e"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("07ab47fb-5f51-4f92-a5a7-52d0804ccd59"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("09550072-9d6a-45d2-9374-865017497a88"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("0c2fa4be-ffcc-4283-9f6b-2eb15b38f53a"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("0dfe6c3e-e489-4a70-b609-4ce22ff3f57d"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("0f27d867-0439-4872-91cc-cb309da55445"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("11bf56d0-0a15-47ef-ad94-649c2328ee42"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("14626a63-8012-417c-b432-62e5d697c9a2"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("1472d128-5fe2-4246-9384-49fba2efb3b3"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("17892b81-a56a-4f70-8608-46d83297fff0"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("1b27940f-369d-475e-9b95-a1da84fb44c6"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("2202aca3-5695-4122-a508-1527ac9cd8b1"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("23be33ba-c6a6-4ca3-b2aa-c19d5cc28192"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("240793de-ea0e-44e4-bcea-69981f8a3101"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("240c0711-22b7-43d2-a4b8-367c36dc17ec"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("2a54d1f5-5ad4-4095-b928-977860e133f5"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("2bc7f681-35df-4bac-a820-c7215c6fa4f9"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("2bfc4092-b23f-44a7-96d7-ec00c9059005"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("2d4015b2-96eb-4f1e-a6c0-c52f420a9b62"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("2e6daa10-d17e-427e-a463-3bfc1b92f3e8"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("317f825f-9985-499a-87c7-9d2372230cc2"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("346b2b9a-aa41-4437-9e2d-a74bfaacbf22"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("3bcdc169-fb2d-4165-a859-bc0258f88506"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("3c0ddb8d-71cb-40f6-8eb6-967ec473ff7a"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("40e715bf-50e6-403d-a712-c26541969d70"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("46166c6b-15ea-4ce1-a564-7b20da94d17d"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("47d34896-1ffa-4995-b19b-036b31781a37"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("49515985-3699-4530-9d92-b11664e5643d"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("4f95dc4d-d36b-483a-a420-6f37dbe14241"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("52ba1b16-b4b9-4861-872e-388b69fbaf53"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("54be530e-b106-4a21-8a81-91c74322dfb8"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("5a1d4447-13ee-4dac-a94f-b9c67e8c93a1"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("617a2918-3fee-4299-b3a7-9888c0d31028"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("62f395d1-e954-45f6-831e-7a8ec61e865e"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("658ef9ee-8f30-4d78-9042-9c1c5675fe32"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("681696ae-343f-4851-afa7-ce046863417c"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("687f407a-d3a1-4958-aeed-15dbecaaa2bd"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("6979bf20-087b-4211-b75f-9180d0a2d233"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("69b0672c-c51a-4901-ae0f-f766be2910c8"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("6eec97ae-44df-424b-a5fd-8640b870d164"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("721904b1-9aaa-4819-a799-ba70a70e812c"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("72d151ff-a7ed-4952-a637-447d3e2cd915"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("747dd12e-81e2-4a8e-b520-fdd252f820d9"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("78992868-81bd-43bd-ab82-066c314b6377"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("7cad0837-b68e-4277-86f3-b923b9292f67"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("840b84e9-1cbb-4871-8c4a-74e7079bba13"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("84c541c7-bd90-450d-a89d-6861378af758"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("875a2323-01f3-475a-a6bf-bf3f4b37e31b"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("878743dc-c1f8-4597-877c-4afed2dd0134"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("880556e5-01cf-4de0-bcc8-bab7752d795d"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("8b321d59-57da-4b6a-b4f2-e41045909d54"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("8b8f0089-6345-4f73-a20b-53845ee08b7d"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("8d326888-4f6e-4a2e-b2f5-5225ee177200"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("8d9bd3fe-0292-4024-913b-2ee76de25095"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("8e90ef9b-b1e2-452e-a91d-ddd5e6f654e0"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("8f89ffa1-41fa-4ecd-9134-751f0faf600f"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("99beb8c5-ede5-4fab-b601-c8462f2424d6"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("9c18f0b1-91cd-4148-906a-5aced95da2b1"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("9c975576-7806-4918-a86e-3ecc1c81d973"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("a001a6d4-117b-4e2a-ad3f-5e515686a7a0"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("a0ce72c7-0f4e-48b3-87ce-5c4533dc1c9a"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("a15f0d7b-a157-4a05-99e9-d4d4d05f3f23"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("a2e03764-5ef3-480e-b529-9fd053ed77c5"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("a591c2e3-cc5f-4a0b-a841-98d2dea00831"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("a59a4b63-4b5b-4fb0-b8bf-bb85d7d1ba40"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("a805f9e8-5300-4f6d-bbb4-80fa2a6d7772"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("aa99d822-0632-475a-af35-9307f0b4e681"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("aad4ab45-1fc3-4307-9773-b82dce9e238e"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("aba89f83-94a5-4ba8-98f4-4e578cb2ed07"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("acc9120d-a2cc-4302-b570-446e4b2fa6ef"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("ae0f8d04-dad2-46c3-97d5-fad23ed80bd0"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("b04a27a0-c106-4a59-a19f-720a7ce669fc"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("b362ed2d-bacb-40ce-a23e-2211a50fef05"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("b6560073-c1bc-4a2c-b612-530560610f48"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("c2a97e2f-aaf7-4c4d-ab4d-6c1d66735951"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("c61d4f34-0922-46e6-ab65-767cdaab2569"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("c6cdb6cc-d4b2-4ea7-a200-3324d4660e83"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("c82d73f9-1fed-4e77-9a8e-7e8d8f3c5162"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("cc50360c-2549-4357-991a-42f6f6558c7c"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("d0f5066f-e4d8-4656-ac64-a09df5c6af22"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("d1e8e5c4-0e17-4ead-9c21-7bcf533040ba"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("d276352f-7163-4d68-9213-c67cbbc77f0f"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("d2dbb820-0f68-4074-a52c-9c2160a73f5e"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("d525be3b-077a-451b-908e-e22ee1c6099a"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("d58ac02c-3163-474e-8b40-de366e0afed9"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("d6aaca1d-ca1a-4c80-8ea4-4e6b50fcac75"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("d87a8f92-bb71-4569-9a35-692657c6ca88"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("d929adc3-b69a-43f3-b1c6-3e08ffefc2de"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("d9a5b8aa-a17d-4247-a0a8-e440d9d19c8e"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("dfa80cff-6764-4e9e-963b-f3f8cf01b7b1"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("e50ec803-4554-4f41-8c93-c48478179d45"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("e51b0d35-c68d-4437-8623-9354eb57663d"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("e55cfc28-4261-4c69-b49d-83d680e0513b"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("e5c73778-ec63-4d81-acc2-e57eb8242dd4"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("e7980240-7d6b-4453-b7ef-ee9b15ed0cc8"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("ea2acb9b-cbde-4a53-b034-b9a09d263ec3"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("efd6ed10-360a-4af3-b12c-bf9654598d4f"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("f0c2127e-7f01-4294-8a0a-05fff87b1178"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("f67636b2-1710-4487-ba2f-910c72e2cf44"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("fb3fb448-3ddb-4520-996a-5f7d40faeb4f"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("fe76f714-8539-477e-8e6c-2d8da6b50a09"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ef11b4ed-5890-4134-b133-5af4325a8828"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("355edb3b-4be6-4989-882b-86625fd97204"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c84f8a06-0232-49a8-ab37-319c33980799"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ce63098d-40f3-4546-b61e-f0eabe51f593"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ffb2ee6a-3240-4266-86d5-6e71174170c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0611454f-3608-4723-ab2c-8635026d10bf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12b7b0ce-b395-4e7c-a3ec-7f27d485e10a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3683c03a-7164-4c2b-9a8e-feef06ded0d4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b24a462-acc0-445e-ae11-b8dd2463b6e8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("52ebd2f2-6127-454d-a1b4-ab3abefad087"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("534a29b0-6bc9-414e-936d-313f2e3cd2c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6edc2b7f-caed-492d-8e07-08433dfb6829"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("977d849d-d226-42ed-8550-922ab36c3494"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9afbde63-84a6-4fe1-9a33-ceacad8c1142"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a2f1cccf-f4c3-4d97-aaad-44e529683493"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a9b0dba2-2fe7-4a50-ba27-40607dc5db4e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c12c4965-16d7-4661-aa7c-0689a3727054"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e0267ab6-10ab-4d53-82d8-b9c6f87f9b5f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f0f7a31e-0763-4b93-b811-b04bd2a11b92"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("453dd81e-dd72-4454-84c6-f99c915b7636"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("058407da-b5f1-449b-9dec-160597c6c898"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("176b6be0-9dab-424d-8394-bde71f75acae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1aca32bc-dc1d-4d51-87ef-79bfe4cdac4c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20734490-818d-428f-98f9-38a14a35a63e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2d9ccdb6-74f1-4243-9d92-3d4e5db15b5b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4117118b-abbd-4993-b556-94d44135b059"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("640216a0-b0e9-400d-a8c5-5fb8510a0644"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8cf16160-8173-4ede-8834-419a48fd7879"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9475b3ca-5a61-423c-8a2e-91dacd311612"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7e355ad-d26c-4203-9659-c80f033ba855"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f853a07d-8437-466f-b7a0-2f689d5b7a3d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2ec7aeaa-fff2-4884-9a1d-45a1b1a2142f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a354210c-20ad-4313-b53a-415c4bfb02d3"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("2fa659c5-3a65-4ad0-8a4f-5326b2c0d1ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("03198527-0aad-4373-9c0b-f50a4a764144"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e60be085-65a5-4552-9659-ecd171e87a8e"));

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalAmount",
                table: "Carts",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ParentId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("dd4b94c7-24ef-45e2-ade5-06003ffc2bc2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo", null, null },
                    { new Guid("f5834f1c-904e-4a32-87a0-3d6368baa0d3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần", null, null }
                });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Price", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0183cc5a-7328-46a7-b3cc-0475796f2bb9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("049b976f-3155-4989-bf8b-571c3a92e4d6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("05790b2c-bca4-42c4-8da2-3b36aa7b43d9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("0800bae6-7d2e-4fb7-807b-1cb2f3c13181"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("0b62aa9a-b731-4827-8293-afb3a6637578"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("0cd9e9a6-ac83-47aa-ad34-90ce3a3f9d0c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("17f933ec-f147-4868-8ec7-d545668f422b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("1bad3a4f-a5b9-4b13-ab8f-a8fc24319e8e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("1c56021b-0b92-4bbf-8f32-c5f3accb9cdf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("1d141fbf-dd62-4ea5-b881-196e6ed002e2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("242a65f3-f757-4877-9512-4d2ddaa7726d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("2c3b0216-b89b-4006-806a-8c3aa04cc19b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("2f163ec8-2d32-4f94-a7fe-080976729700"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("39485431-1092-4529-8ca8-e01e90e997fd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("3d8352cc-43cf-4c10-9786-03da70b25972"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("3f48af34-b407-4631-9254-9527d1086773"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("40b36f30-c2e2-499d-95da-2b8018a608fe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("4199f2e4-facb-451a-bcc2-74e71e4867fc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("4320a5a4-9038-473e-9971-993792c676e0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("45ce2f54-d7e4-426c-8a00-78e36d29a69f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("47cbf735-07be-41f4-a693-57d773d23c1e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("4cd0d235-91d7-4cc1-ad3a-1d475214ce5e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("4eaed66e-a94c-4daa-8f0b-710c94f853d6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("504c5293-45e3-40a6-b50b-8cf57344b4d8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("5cac611b-f5a0-4172-b830-7ef11b5c4903"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("60aa71cf-baef-4a81-966f-16f57d7e36df"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("650a7c3c-938a-4057-ae84-357e353f613a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("69e93a37-cebf-4d48-bc89-f69d384e4296"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("706f7d19-5e3f-4908-8dff-006ad7dfc46c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("7207c826-d8e5-4eba-83f2-6c3004a60d10"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("74f949cc-8700-4d78-87cf-5dbfa4e43d10"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("7733ea06-8b9e-4568-b1b9-b06286df8675"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("780d41f0-99f9-484b-943a-ba4fec2544a7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("7be98691-868a-4dca-a35c-bda5e53ef107"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("7ff7610e-c54b-4547-a89c-689103c7aa28"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("802e26ae-f458-46c4-b412-c63e17dce953"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("80943423-fb0d-475d-afe7-e1ef3e8ba3b6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("825c8a4b-223b-4eeb-9957-44ab7ab301ff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("859aa85c-0145-4f25-a300-6dfab8cb944f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("8782d675-2e8d-4cc6-9d2b-78e04eaecbdd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("879e6e90-0889-4d5c-bf8a-ed2198aebdeb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("88b49e40-457d-4d2f-93b6-311c486f007a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("88e135d8-2562-4f0d-8789-9cbeea0ada4b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("89311cc9-ae5a-4831-b1de-95af25f0b6a8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("8d88a840-198a-415c-afd9-78980c586f49"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("8dcbcdd5-b050-4a53-9062-fec3d446efd9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("904102d5-63d1-47ca-b6d6-02492e5cff76"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("915a2fa6-b6d8-493a-b273-6232e678f0c7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("951247fc-7b84-4d6a-b3e0-09ad8a815863"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("9a87b7bd-ffd6-4c3d-8dc5-d2566ee2519e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("9f7b15f5-eb32-4200-8595-28f66ca2e8ba"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("a1e9439d-7c34-4dab-b207-83ee6c813446"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("a2f8d23a-164e-449c-86e2-a67005882d79"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("a46fd3bc-e076-42ae-a911-106d76defe4f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("a8246c2c-c198-4a20-89ac-37defa074f8a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("a8f4d042-dce7-40f6-a6c3-a9ffb57d6e08"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("a91976ee-7d27-4423-ab0d-7b676fc61c78"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("a9241ba1-7e66-452b-949c-e6e0b8215d32"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("aa3a4734-6aa9-4618-b926-8ab7551b6b36"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("ac51b9e4-5823-43b3-a786-2777dc8526bb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("ad0f25d1-468c-45c7-8a7e-bf6eed861cb1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("add6ffd1-060e-4b95-bd6c-9a4ce11a5aaa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("b09ab14a-06cf-4105-9ba1-5ab64d77163c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("b34d10e3-64aa-4282-afb9-b802e1c95235"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("b6d8cd93-3519-49df-8853-594c041f6a1b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("b85876f5-3152-4816-a3c9-b9018cc3e3ba"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("ba63a116-87ba-424c-a41a-ec8aac0a727e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("bdbcb950-130e-4d5c-a6b5-f025fda6deac"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("c2078180-7318-4018-86f4-8c87bdb8e54e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("c288f0a8-8498-4fcf-a411-4f26f1c78c93"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("c7ce510d-2d0b-4410-a1a5-801238f6ab3b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("c81ae011-acd9-428b-91b3-def6c105d511"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("ce4bca2c-cf38-4f76-b205-b8ec7b988ea4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("d5f75a8d-4deb-4a15-be43-865357658580"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("d7c500e7-9716-433c-bbd4-b679dc8a3e0f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("d9fa2157-3343-47d2-a123-d82c5b03aa80"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("da0e8c8c-c495-42f0-a53b-60c4c547f197"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("dd0b7826-d458-444c-be52-743ab7190efe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("e1ce7769-fd1a-46d3-89d7-9ad3081ef418"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("e1f5046b-2eb4-4d4a-9e0c-c5673e60c4db"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("e3306646-cd0b-4ea6-9917-53d43498f77d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("e55dc51a-03a7-48e7-a300-b490f2e71a27"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("e6432869-ddb7-4a7a-b040-3db306574186"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("e863d7a9-f4de-4c7e-a2de-cd83e84b3314"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("e8d9f27d-4a21-4c0b-b366-12808ac0e5a3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("eacebbb7-f5bb-4144-af76-c90c1e2d8519"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("ebc417c2-3098-4b7b-944a-c6a2e02ec54c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("f0405c39-add2-4bcb-8bb0-8441915bb752"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("f098be0f-2221-4c6b-854f-788f88e43435"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("f0b62ef7-dc7a-47ce-aa26-baf0c2406ca6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("f10b6c27-e564-4cd2-99b3-9d8c6927e8d9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("f25bb0b6-30ff-415b-834c-73b84f9c51bc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("f359bfe1-21e6-4116-bdcf-54b31601184f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("f511404b-4ea3-493a-bf12-65e157180921"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("f5152575-eb82-4d80-ae27-4f53b9819671"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("f5e0dcde-f86a-40ac-adbf-cc8fc653f3bd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("f97071da-4ec1-4cff-9261-3a8b6b180dd9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("fad8b395-a82e-4a6a-bd3d-4bfc37298fe6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("fb3eeb93-74da-4844-9104-24692fa3989a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("fc064ee4-8970-47a7-be6a-a2c55632a2d7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("fd024c14-2b93-4b77-be56-9b4746089550"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("ff3bf3ee-6436-45fd-a577-02dd7327853f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedAt", "DateOfBirth", "Email", "FirstName", "HashedPassword", "ImageUrl", "IsDeleted", "IsVerify", "LastName", "PhoneNumber", "Role", "UpdatedAt", "VerifyCode" },
                values: new object[,]
                {
                    { new Guid("0a2e86e2-495f-49a5-9d50-1d8adb6248d5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan3@gmail.com", "Tan3", "hashed_password_3", null, false, false, "Tran3", null, "Seller", null, 0 },
                    { new Guid("17ee3cb9-9e49-4a44-887c-789205cba897"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tan182206@gmail.com", "Tan", "hashed_password_1", null, false, false, "Tran", null, "User", null, 0 },
                    { new Guid("17fbafc5-630f-4941-a0ce-293148e13e86"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan8@gmail.com", "Tan8", "hashed_password_8", null, false, false, "Tran8", null, "User", null, 0 },
                    { new Guid("1e189e92-a0ab-416d-a708-9560d283bd2b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan7@gmail.com", "Tan7", "hashed_password_7", null, false, false, "Tran7", null, "Seller", null, 0 },
                    { new Guid("4e88318e-2947-4475-90f5-e96f957d7b1a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan0@gmail.com", "Tan0", "hashed_password_0", null, false, false, "Tran0", null, "User", null, 0 },
                    { new Guid("6a31de00-b990-4d94-9f59-fb38b96e5c8f"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan4@gmail.com", "Tan4", "hashed_password_4", null, false, false, "Tran4", null, "User", null, 0 },
                    { new Guid("6b11f036-a212-49b1-904a-6ad7ea43d638"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "piedteam@gmail.com", "Pied", "PiedTeam", null, false, false, "Team", null, "Admin", null, 0 },
                    { new Guid("6cd18250-2f0f-4f39-acef-e4be69b9eb2b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tan182205@gmail.com", "Tan", "hashed_password_1", null, false, false, "Tran", null, "User", null, 0 },
                    { new Guid("8891c817-d862-446d-9ba9-af4b3227ab83"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan10@gmail.com", "Tan10", "hashed_password_10", null, false, false, "Tran10", null, "User", null, 0 },
                    { new Guid("ac332d83-c238-4d7c-a3b6-517d2c881474"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan9@gmail.com", "Tan9", "hashed_password_9", null, false, false, "Tran9", null, "Seller", null, 0 },
                    { new Guid("b32389a7-c793-4c70-b0ce-67017447f991"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan1@gmail.com", "Tan1", "hashed_password_1", null, false, false, "Tran1", null, "Seller", null, 0 },
                    { new Guid("d9629043-b6be-4637-9847-c149a2f63ce9"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan5@gmail.com", "Tan5", "hashed_password_5", null, false, false, "Tran5", null, "Seller", null, 0 },
                    { new Guid("ed8f52ce-2934-46e3-8f01-dfa6b0da0344"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan2@gmail.com", "Tan2", "hashed_password_2", null, false, false, "Tran2", null, "User", null, 0 },
                    { new Guid("f4c07995-701e-4e7e-be73-6e1be55ecd7d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan6@gmail.com", "Tan6", "hashed_password_6", null, false, false, "Tran6", null, "User", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "TotalAmount", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("051269b9-f343-460b-8794-a570f6aa1f38"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("6a31de00-b990-4d94-9f59-fb38b96e5c8f") },
                    { new Guid("0ce31fda-bc07-42f9-b3e8-80cf904172a9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("f4c07995-701e-4e7e-be73-6e1be55ecd7d") },
                    { new Guid("25bd650a-b715-4031-ac76-0799501ef44d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("17fbafc5-630f-4941-a0ce-293148e13e86") },
                    { new Guid("2bee142c-9765-46ce-b664-c0f992eb8f4a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("1e189e92-a0ab-416d-a708-9560d283bd2b") },
                    { new Guid("2cb03e4a-b415-491f-9342-db0c4d127a3a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("0a2e86e2-495f-49a5-9d50-1d8adb6248d5") },
                    { new Guid("89d26d02-ae0e-4f95-bd76-3f5e0f6897d6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("ac332d83-c238-4d7c-a3b6-517d2c881474") },
                    { new Guid("a0b8f5e2-8bcd-42ff-8057-4c4b6b037a8f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("b32389a7-c793-4c70-b0ce-67017447f991") },
                    { new Guid("a0e6d68d-e22b-4523-a7e9-dcdf56e8cf9d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("d9629043-b6be-4637-9847-c149a2f63ce9") },
                    { new Guid("a53677d5-e8f5-4630-8873-bf23714ed459"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("8891c817-d862-446d-9ba9-af4b3227ab83") },
                    { new Guid("d1321bd3-5995-46e7-a520-0215fa5addbc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("ed8f52ce-2934-46e3-8f01-dfa6b0da0344") },
                    { new Guid("ef012b50-8922-4129-8960-8e3f166108c3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("4e88318e-2947-4475-90f5-e96f957d7b1a") }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ParentId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("06c0a33e-1637-48ae-af24-adef750ca7e2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo ba lỗ", new Guid("dd4b94c7-24ef-45e2-ade5-06003ffc2bc2"), null },
                    { new Guid("675680bc-1643-439a-bde9-f3cfae1dfeda"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Kaki", new Guid("f5834f1c-904e-4a32-87a0-3d6368baa0d3"), null },
                    { new Guid("de3b1085-5cb0-4a92-8357-a5284819bf6c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao", new Guid("dd4b94c7-24ef-45e2-ade5-06003ffc2bc2"), null },
                    { new Guid("fbf25fbf-5881-4a56-ae4b-bea5a4183e55"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Jean", new Guid("f5834f1c-904e-4a32-87a0-3d6368baa0d3"), null }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "CreatedAt", "IsDeleted", "Status", "TotalAmount", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("0eadec31-9472-4eb8-bc2d-c567202a6e6a"), "Bien hoa, Dong Nai5", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed5", 10005m, null, new Guid("6a31de00-b990-4d94-9f59-fb38b96e5c8f") },
                    { new Guid("1b51ec7a-94cb-4adf-924e-82b8673b8c4c"), "Bien hoa, Dong Nai2", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed2", 10002m, null, new Guid("b32389a7-c793-4c70-b0ce-67017447f991") },
                    { new Guid("299e674b-25b6-4eb7-a299-4bb47cfc8ece"), "Bien hoa, Dong Nai3", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed3", 10003m, null, new Guid("ed8f52ce-2934-46e3-8f01-dfa6b0da0344") },
                    { new Guid("4a4c9e3d-6c47-4a8e-bdc2-bf27fd9a0c1d"), "Bien hoa, Dong Nai4", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed4", 10004m, null, new Guid("0a2e86e2-495f-49a5-9d50-1d8adb6248d5") },
                    { new Guid("554e280a-40c9-4a48-bb3b-b362c8ab178b"), "Bien hoa, Dong Nai", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed", 10000m, null, new Guid("17ee3cb9-9e49-4a44-887c-789205cba897") },
                    { new Guid("a75b01fa-dfa5-4b0e-b028-3ae55eabe6de"), "Bien hoa, Dong Nai1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed1", 10001m, null, new Guid("4e88318e-2947-4475-90f5-e96f957d7b1a") },
                    { new Guid("c423f534-14f9-47a5-88dc-8b94374d8292"), "Bien hoa, Dong Nai10", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed10", 10010m, null, new Guid("ac332d83-c238-4d7c-a3b6-517d2c881474") },
                    { new Guid("c9fc2d56-19cc-48a5-a5b8-936c14fae664"), "Bien hoa, Dong Nai", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed", 10000m, null, new Guid("17ee3cb9-9e49-4a44-887c-789205cba897") },
                    { new Guid("cdef6ff8-e56e-4bfc-baf0-192af5639636"), "Bien hoa, Dong Nai6", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed6", 10006m, null, new Guid("d9629043-b6be-4637-9847-c149a2f63ce9") },
                    { new Guid("dd8fdecf-6a55-41b1-bec8-c9fa4283b658"), "Bien hoa, Dong Nai7", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed7", 10007m, null, new Guid("f4c07995-701e-4e7e-be73-6e1be55ecd7d") },
                    { new Guid("e2074dcd-9605-44eb-8161-880920473739"), "Bien hoa, Dong Nai9", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed9", 10009m, null, new Guid("17fbafc5-630f-4941-a0ce-293148e13e86") },
                    { new Guid("e7b3ddcf-b46e-4e6d-b9a7-cfb59bd054da"), "Bien hoa, Dong Nai11", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed11", 10011m, null, new Guid("8891c817-d862-446d-9ba9-af4b3227ab83") },
                    { new Guid("ee7b64d2-bf18-4552-ae25-9055deef5aa6"), "Bien hoa, Dong Nai8", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed8", 10008m, null, new Guid("1e189e92-a0ab-416d-a708-9560d283bd2b") }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "CompanyAddress", "CompanyName", "CreatedAt", "IsDeleted", "TaxCode", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("356239c6-c666-4fac-b782-ce0166a36ef4"), "123 Main St, Cityville2", "ABC Company2", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE2", null, new Guid("b32389a7-c793-4c70-b0ce-67017447f991") },
                    { new Guid("3778eb62-d2d7-4599-bef0-200d342d595b"), "123 Main St, Cityville", "ABC Company", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE123", null, new Guid("6cd18250-2f0f-4f39-acef-e4be69b9eb2b") },
                    { new Guid("4378cb34-27a1-4a1c-8d64-dd3bd80dbf18"), "123 Main St, Cityville1", "ABC Company1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE1", null, new Guid("4e88318e-2947-4475-90f5-e96f957d7b1a") },
                    { new Guid("8be716f3-b634-43ea-947f-e5ec2d0ef9c9"), "123 Main St, Cityville10", "ABC Company10", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE10", null, new Guid("ac332d83-c238-4d7c-a3b6-517d2c881474") },
                    { new Guid("949a4d3d-611c-4f5a-b1d4-b99bb4c22a99"), "123 Main St, Cityville11", "ABC Company11", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE11", null, new Guid("8891c817-d862-446d-9ba9-af4b3227ab83") },
                    { new Guid("99e27a16-10e9-41ea-b1d4-7cd663c2b73e"), "123 Main St, Cityville3", "ABC Company3", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE3", null, new Guid("ed8f52ce-2934-46e3-8f01-dfa6b0da0344") },
                    { new Guid("b8861924-763b-442f-930a-385c1f27bc70"), "123 Main St, Cityville8", "ABC Company8", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE8", null, new Guid("1e189e92-a0ab-416d-a708-9560d283bd2b") },
                    { new Guid("de82b6c5-e2be-460a-81fe-3048b2386d7b"), "123 Main St, Cityville5", "ABC Company5", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE5", null, new Guid("6a31de00-b990-4d94-9f59-fb38b96e5c8f") },
                    { new Guid("e8ca298d-6203-47c3-8a6f-578e26843cb7"), "123 Main St, Cityville7", "ABC Company7", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE7", null, new Guid("f4c07995-701e-4e7e-be73-6e1be55ecd7d") },
                    { new Guid("f34deb81-45c4-46e2-9f3f-8d3dda6942ab"), "123 Main St, Cityville9", "ABC Company9", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE9", null, new Guid("17fbafc5-630f-4941-a0ce-293148e13e86") },
                    { new Guid("fbbb29a0-b8df-4685-9238-93335d490f57"), "123 Main St, Cityville4", "ABC Company4", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE4", null, new Guid("0a2e86e2-495f-49a5-9d50-1d8adb6248d5") },
                    { new Guid("fd20a73b-84fa-407f-9917-344866a30b7d"), "123 Main St, Cityville6", "ABC Company6", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE6", null, new Guid("d9629043-b6be-4637-9847-c149a2f63ce9") }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ParentId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1d31a103-425e-4243-9660-164b2f84e5b9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Jean1", new Guid("fbf25fbf-5881-4a56-ae4b-bea5a4183e55"), null },
                    { new Guid("2b0217cf-7883-418b-8ea3-ad1383124a8a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao4", new Guid("de3b1085-5cb0-4a92-8357-a5284819bf6c"), null },
                    { new Guid("5d673817-5ca4-4554-8ee2-9b15360ec9cc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Jean7", new Guid("fbf25fbf-5881-4a56-ae4b-bea5a4183e55"), null },
                    { new Guid("7f987db7-535e-491c-9cc5-4e807ed9ed41"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao8", new Guid("de3b1085-5cb0-4a92-8357-a5284819bf6c"), null },
                    { new Guid("87135a23-9902-44c7-a36a-3db2a7d96677"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Jean3", new Guid("fbf25fbf-5881-4a56-ae4b-bea5a4183e55"), null },
                    { new Guid("8e381796-c4fb-4458-9d6f-109be87dc3dc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Jean5", new Guid("fbf25fbf-5881-4a56-ae4b-bea5a4183e55"), null },
                    { new Guid("9d372067-add0-434a-96f6-9f026c5f3496"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao2", new Guid("de3b1085-5cb0-4a92-8357-a5284819bf6c"), null },
                    { new Guid("aee972b3-272d-48e1-9dcb-d36448c4e180"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao10", new Guid("de3b1085-5cb0-4a92-8357-a5284819bf6c"), null },
                    { new Guid("d229ddf8-3dc1-4996-9165-4673d1c15ca3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao6", new Guid("de3b1085-5cb0-4a92-8357-a5284819bf6c"), null },
                    { new Guid("ecd76c91-12d4-4033-9a80-8bbe8ddf761f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Jean9", new Guid("fbf25fbf-5881-4a56-ae4b-bea5a4183e55"), null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "Name", "Price", "SellerId", "UpdatedAt", "UrlImage" },
                values: new object[,]
                {
                    { new Guid("0ff57824-8810-485a-9767-147798cdd845"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt3", false, "T-Shirt3", 199000m, new Guid("3778eb62-d2d7-4599-bef0-200d342d595b"), null, "" },
                    { new Guid("146d4211-3b46-4b17-a95a-a12c918c3ce5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt10", false, "T-Shirt10", 199000m, new Guid("3778eb62-d2d7-4599-bef0-200d342d595b"), null, "" },
                    { new Guid("3598c444-c41a-4d74-976a-918cc55d2803"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt9", false, "T-Shirt9", 199000m, new Guid("3778eb62-d2d7-4599-bef0-200d342d595b"), null, "" },
                    { new Guid("38f883a9-cec8-4c47-be8c-971914c658f4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Chân váy nữ xòe, thiết kế trẻ trung, chất liệu vải mềm mại, phù hợp cho mọi dịp.", false, "Chân Váy Nữ", 249000m, new Guid("3778eb62-d2d7-4599-bef0-200d342d595b"), null, "https://example.com/images/chan_vay_nu.jpg" },
                    { new Guid("59c95733-e5e6-4b3e-bba5-c13456bd8a2b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt5", false, "T-Shirt5", 199000m, new Guid("3778eb62-d2d7-4599-bef0-200d342d595b"), null, "" },
                    { new Guid("5b28ebcc-e93e-41e1-9bf9-fdc4763dd025"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt0", false, "T-Shirt0", 199000m, new Guid("3778eb62-d2d7-4599-bef0-200d342d595b"), null, "" },
                    { new Guid("7e8bad4d-3d1c-448e-b2ec-e9b12d45c6e4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt4", false, "T-Shirt4", 199000m, new Guid("3778eb62-d2d7-4599-bef0-200d342d595b"), null, "" },
                    { new Guid("87010c49-da1b-484d-8baf-e53c27bbfb0c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Áo sơ mi nam công sở, thiết kế hiện đại, chất liệu vải cao cấp, thoáng mát.", false, "Áo Sơ Mi Nam", 299000m, new Guid("3778eb62-d2d7-4599-bef0-200d342d595b"), null, "https://example.com/images/ao_so_mi_nam.jpg" },
                    { new Guid("b5208bd1-6cdb-4a01-87f1-9a6651ecc1a1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt6", false, "T-Shirt6", 199000m, new Guid("3778eb62-d2d7-4599-bef0-200d342d595b"), null, "" },
                    { new Guid("b6c8b787-9591-4883-aaf3-b197b861d112"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quần jeans nữ dáng ôm, tôn dáng, chất liệu denim co giãn, phù hợp cho mọi dịp.", false, "Quần Jeans Nữ", 399000m, new Guid("3778eb62-d2d7-4599-bef0-200d342d595b"), null, "https://example.com/images/quan_jeans_nu.jpg" },
                    { new Guid("c7d3fed5-8140-439c-a74f-220d61669d64"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt8", false, "T-Shirt8", 199000m, new Guid("3778eb62-d2d7-4599-bef0-200d342d595b"), null, "" },
                    { new Guid("d307145e-0a9a-452a-a079-b3d50b7feea1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt1", false, "T-Shirt1", 199000m, new Guid("3778eb62-d2d7-4599-bef0-200d342d595b"), null, "" },
                    { new Guid("dcdda066-1bab-4ca3-ab48-d4dd8a77b0ff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt7", false, "T-Shirt7", 199000m, new Guid("3778eb62-d2d7-4599-bef0-200d342d595b"), null, "" },
                    { new Guid("e2036b88-618b-4434-930a-6143bfec0e52"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt2", false, "T-Shirt2", 199000m, new Guid("3778eb62-d2d7-4599-bef0-200d342d595b"), null, "" },
                    { new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Áo thun nam chất liệu cotton cao cấp, thoáng mát, phù hợp cho mọi hoạt động hàng ngày.", false, "Áo Thun Nam", 199000m, new Guid("3778eb62-d2d7-4599-bef0-200d342d595b"), null, "https://example.com/images/ao_thun_nam.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "ProductId", "TotalInStock", "TotalSell", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2944a64d-04ea-43fd-9bd2-91c9bb87ea71"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("7e8bad4d-3d1c-448e-b2ec-e9b12d45c6e4"), 1000m, 1000m, null },
                    { new Guid("4dd66c23-793b-4433-8d7b-3126d1ae55ac"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("3598c444-c41a-4d74-976a-918cc55d2803"), 1000m, 1000m, null },
                    { new Guid("7749703c-5ea6-491a-88af-50016be30a5b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("e2036b88-618b-4434-930a-6143bfec0e52"), 1000m, 1000m, null },
                    { new Guid("7b8d9351-9646-4589-bdd6-a60733a862af"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("59c95733-e5e6-4b3e-bba5-c13456bd8a2b"), 1000m, 1000m, null },
                    { new Guid("8914192b-cd58-4bfd-b866-0f8fe7972b1d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("5b28ebcc-e93e-41e1-9bf9-fdc4763dd025"), 1000m, 1000m, null },
                    { new Guid("a88bf2a9-c4a6-4345-b4f8-73e1ada3e055"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("146d4211-3b46-4b17-a95a-a12c918c3ce5"), 1000m, 1000m, null },
                    { new Guid("aaa483e2-21a5-48dd-8ab5-905309a914f2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("dcdda066-1bab-4ca3-ab48-d4dd8a77b0ff"), 1000m, 1000m, null },
                    { new Guid("aef61c33-7d7b-47f0-8710-8dee20d76020"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("0ff57824-8810-485a-9767-147798cdd845"), 1000m, 1000m, null },
                    { new Guid("d71222df-d3e5-4874-8aa9-3c6997b2336b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("d307145e-0a9a-452a-a079-b3d50b7feea1"), 1000m, 1000m, null },
                    { new Guid("f1ae7b79-df6f-480a-aa44-f9b16310a0a7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("b5208bd1-6cdb-4a01-87f1-9a6651ecc1a1"), 1000m, 1000m, null },
                    { new Guid("fd3abce8-6683-4122-b520-300aa8a0129b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("c7d3fed5-8140-439c-a74f-220d61669d64"), 1000m, 1000m, null }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "OrderId", "ProductId", "Quantity", "UnitPrice", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("04bbb028-a5b5-4450-89b9-ab77c967089b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("c9fc2d56-19cc-48a5-a5b8-936c14fae664"), new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), 2, 19990000m, null },
                    { new Guid("26d06959-1e11-4752-b36e-383685950656"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("c9fc2d56-19cc-48a5-a5b8-936c14fae664"), new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), 2, 19990000m, null },
                    { new Guid("2ba6e994-ac4a-45c1-a010-7a84b916bea9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("c9fc2d56-19cc-48a5-a5b8-936c14fae664"), new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), 2, 19990000m, null },
                    { new Guid("342ff427-a1ef-43e4-a8f4-d59f71362e6a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("c9fc2d56-19cc-48a5-a5b8-936c14fae664"), new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), 2, 19990000m, null },
                    { new Guid("5aa01d3a-2ad7-45bd-8d5e-76bfc18f7b91"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("c9fc2d56-19cc-48a5-a5b8-936c14fae664"), new Guid("b6c8b787-9591-4883-aaf3-b197b861d112"), 1, 39990000m, null },
                    { new Guid("5d2fa7c4-7051-4e63-900a-a23ab9fb12ba"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("c9fc2d56-19cc-48a5-a5b8-936c14fae664"), new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), 2, 19990000m, null },
                    { new Guid("6636301d-3509-42ce-b6ee-432d186f9029"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("c9fc2d56-19cc-48a5-a5b8-936c14fae664"), new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), 2, 19990000m, null },
                    { new Guid("6c155229-d9dd-488d-a415-5198ee7d33f7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("c9fc2d56-19cc-48a5-a5b8-936c14fae664"), new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), 2, 19990000m, null },
                    { new Guid("7632da7f-0a66-4e3b-bc2e-0357c82ff2ec"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("c9fc2d56-19cc-48a5-a5b8-936c14fae664"), new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), 2, 19990000m, null },
                    { new Guid("a96d63d9-cafd-424c-a88c-558a38b072e8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("c9fc2d56-19cc-48a5-a5b8-936c14fae664"), new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), 2, 19990000m, null },
                    { new Guid("afdaae31-5e9a-463d-a522-a1f1e2743d19"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("c9fc2d56-19cc-48a5-a5b8-936c14fae664"), new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), 2, 19990000m, null },
                    { new Guid("bc63219f-b999-400f-9b54-4cd63e2c501e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("c9fc2d56-19cc-48a5-a5b8-936c14fae664"), new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), 2, 19990000m, null },
                    { new Guid("bcfe733f-74a1-4e37-a130-3195945c6f6e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("554e280a-40c9-4a48-bb3b-b362c8ab178b"), new Guid("87010c49-da1b-484d-8baf-e53c27bbfb0c"), 1, 29990000m, null },
                    { new Guid("ca6c9f1a-d9a7-4dc5-a605-6858cf923565"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("c9fc2d56-19cc-48a5-a5b8-936c14fae664"), new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), 2, 19990000m, null }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "IsDeleted", "ProductID", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2bf6d30e-8e8e-4ddf-be7a-a778da580d2b"), new Guid("dd4b94c7-24ef-45e2-ade5-06003ffc2bc2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), null },
                    { new Guid("2c1db32b-adc1-4b0b-bb27-68d7bf63de0e"), new Guid("dd4b94c7-24ef-45e2-ade5-06003ffc2bc2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), null },
                    { new Guid("5a4d6fb1-407c-4bfe-a9df-d877af320802"), new Guid("dd4b94c7-24ef-45e2-ade5-06003ffc2bc2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), null },
                    { new Guid("63bcbcd7-b461-4636-b3ca-d9f5112f45c9"), new Guid("dd4b94c7-24ef-45e2-ade5-06003ffc2bc2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), null },
                    { new Guid("87fd0162-8a13-4f98-ab57-a304cdd294f8"), new Guid("dd4b94c7-24ef-45e2-ade5-06003ffc2bc2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), null },
                    { new Guid("9681b955-d36c-4fe5-8612-8c7320ec3fab"), new Guid("dd4b94c7-24ef-45e2-ade5-06003ffc2bc2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), null },
                    { new Guid("ab73b236-7e84-4289-8021-c7a41d42d454"), new Guid("dd4b94c7-24ef-45e2-ade5-06003ffc2bc2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), null },
                    { new Guid("b05ff33b-eaf5-40fd-b541-f9678e40e179"), new Guid("dd4b94c7-24ef-45e2-ade5-06003ffc2bc2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), null },
                    { new Guid("ca817862-68ee-4b14-84b6-83da19410083"), new Guid("dd4b94c7-24ef-45e2-ade5-06003ffc2bc2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), null },
                    { new Guid("e8b4d396-374e-471c-b309-528f9126a321"), new Guid("dd4b94c7-24ef-45e2-ade5-06003ffc2bc2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), null },
                    { new Guid("ed08f95b-cc74-4069-be8b-6640ce158981"), new Guid("dd4b94c7-24ef-45e2-ade5-06003ffc2bc2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), null }
                });

            migrationBuilder.InsertData(
                table: "ProductStorages",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "ProductId", "StorageId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0482e24c-fe41-4013-b367-e6f9bce84c9a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), new Guid("f511404b-4ea3-493a-bf12-65e157180921"), null },
                    { new Guid("186116df-50ac-49ad-8b01-9f5d454327fe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), new Guid("f511404b-4ea3-493a-bf12-65e157180921"), null },
                    { new Guid("1d972796-6164-4691-b4c3-3c0d11611cf4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), new Guid("f511404b-4ea3-493a-bf12-65e157180921"), null },
                    { new Guid("22088db1-6b77-4415-9332-58ec787c3d3e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), new Guid("f511404b-4ea3-493a-bf12-65e157180921"), null },
                    { new Guid("36b555f0-4421-4f78-aafb-d5b28cc6459a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), new Guid("f511404b-4ea3-493a-bf12-65e157180921"), null },
                    { new Guid("511dc3f1-f2a5-446a-b169-81b2191bcd48"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), new Guid("f511404b-4ea3-493a-bf12-65e157180921"), null },
                    { new Guid("650f3b84-a010-4d70-9f8c-c939c4a7d438"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), new Guid("f511404b-4ea3-493a-bf12-65e157180921"), null },
                    { new Guid("7558e0ff-efda-491a-bb5d-c788cf69c134"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), new Guid("f511404b-4ea3-493a-bf12-65e157180921"), null },
                    { new Guid("b7e266e8-f8e3-4a29-aa70-29f31ac34b44"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), new Guid("f511404b-4ea3-493a-bf12-65e157180921"), null },
                    { new Guid("c863a6fa-b449-4aeb-b307-e4a310dc24a7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), new Guid("f511404b-4ea3-493a-bf12-65e157180921"), null },
                    { new Guid("dd757d65-3ead-4fe3-9ca8-07d381544857"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("f930f34a-8f1e-4880-9839-f60eb08fa53a"), new Guid("f511404b-4ea3-493a-bf12-65e157180921"), null }
                });
        }
    }
}
