using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TetPee.Repository.Migrations
{
    /// <inheritdoc />
    public partial class checkheckseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("05300d73-cc84-4684-9021-01a9cf9400bc"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("2280e82a-63a0-40d3-a9e2-90daa69774bf"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("41e0d1f6-624f-452e-9f64-e9cbb417a583"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("4329a7cc-9252-4bc5-8e7b-ec189d5c1a84"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("67f72277-d090-4018-ab77-2b6a214f2d11"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("75ae8c46-ea46-4e30-bea8-ae7bc8a8aaa2"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("b05e8080-59db-4385-b8e2-77459ca786be"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("d78c228d-4b65-4992-858b-909422eed624"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("d9b0b7ea-5429-475e-97b0-93d285921dbb"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("e158230f-c318-446c-8b1b-a31c00a16bbc"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("eccc1102-4824-4a26-866b-2753a29bb718"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("05564ee2-9966-49eb-87e1-460e3f411b45"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("10363064-90e5-4d72-a12b-dd56e04a43c7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("118eaca0-5f40-4111-a825-63f43f3dd9fa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3000ea39-704f-4321-99bb-4fe38882703c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("554f3092-8c22-4cfb-bfbb-5fe76025c75c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("663c7491-69a1-44ab-9b34-42794944a627"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("79cf9b82-71d9-4961-83f8-8a01616f55d6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a6fa20d-34f4-4065-94cc-1376fe62326e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ae58b5b1-a448-4749-926f-be2a5d6ede5e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c3c9b582-d2bb-4786-9bcf-7e33ddbf655e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c6fb3b01-9fb1-4f5c-ab26-6ee95d79cdca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e034645b-c747-49bc-88f8-990d7ef9b60b"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("3711927c-6ded-4444-834e-debd91298175"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("3f3bc816-d80f-4170-b14b-1e544005ebce"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("49251e76-343b-41e7-b59c-30fec7c540de"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("52148e13-2390-4bea-9243-14c5689923cb"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("613b6fae-bbd6-4357-9657-7544147eb289"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("9b593d55-d6a9-4fb3-a7c6-cab5a8f7e70a"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("9d87b637-fca2-4486-bd85-4f85afb51464"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("ab645396-fd9c-4bed-9d53-7f4bc7245ca6"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("bf7f1c1d-1290-4edc-8a19-9fc6820d22b7"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("d5c4646a-969a-49cf-be56-5dd1b71f8d5f"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("ebfdc190-b6d3-4665-bdb6-0d0d0460d58b"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("028dc0ac-16db-45c4-833e-14f2c036437d"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("05494e30-63d7-47b5-a0b6-00ad3b94856a"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("066f9b71-62df-425f-b8c0-bc84e5987a0d"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("40bd409e-3ca2-43d3-a670-6dd77bf5e8a1"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("4507cc45-c0c6-4937-b82b-27e994e5401b"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("594a63a3-692a-45ee-a8d8-b307e34f8aa1"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("6cfe37eb-12d9-4672-b2f0-888a5d439d68"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("96a0e781-4c31-4a60-bcb0-9715323e9836"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("acbfe78e-6cf2-4500-995e-e9246917a827"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("acdd208d-4b34-4d69-9c0d-337952b146bb"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("b7f357d1-3d9b-47d6-8bea-88cc3a2f5dce"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("d0bfcb53-9a79-4061-9dc3-e8092cad34be"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("d59d90ef-46bf-4af8-a860-b7d8d3ff614c"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("f52dc5b4-131c-497b-8b35-a80873201470"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1c8fc93b-afca-478a-af9c-9de67eb3b896"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("2324fedd-2111-4bf8-9635-4ad773de5616"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("428732a2-2255-4a8d-a4d6-f2272f5b2ebf"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4c136267-f6dc-49bf-b0a3-fe05a6601bc8"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("99aab642-74f1-4bec-938d-52b646ff6ccf"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a0a1216d-3af0-430a-b1c7-d6b86acae7e9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d4e8aa76-ce50-4320-99ac-03371dfe7144"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("dc8c305f-eea8-4d9a-af15-1511f7088fd2"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("eba3a7a3-eab0-4f7b-9413-f8b6eeef0b97"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f79cb979-935d-49d6-b0ee-714d619119df"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ff558f2a-9024-492f-a2f3-1b7d76aadca5"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("0543c211-2df4-4626-9583-801431adc0fb"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("1b1f226c-9183-4a85-b892-dcf335936044"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("526b7957-ad66-41df-945c-0ef00484116c"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("60b02070-720d-4b9c-bb62-f17cfba32675"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("6c12faf9-2c10-45cd-b08c-2002d46e2dd4"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("86d0cf72-2dce-40f3-8ad0-594784ae3d9a"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("9f21257e-efb4-4972-bb81-c7fc54cf9ff7"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("a1b4db2d-aa49-44f0-a78a-8e4d5e8fd8be"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("a8b114ab-0649-4cd8-9655-9711a2aadc71"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("b3bf17b3-5c61-4216-a017-1db04e0f6a02"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("ea907db9-b764-4893-87ca-34e62973e0f3"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("1b1efc04-d704-46ca-8f8f-c5c85c696019"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("2fc81d5d-f148-4dff-bf64-14ceb8c0a2ac"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("50cce5ea-8722-440d-a7ff-97992de1413d"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("656ea6f3-1c27-456a-910b-c44091710053"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("775c1709-b435-4996-b1e4-91f7bfc945d0"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("914a9c48-04bf-48f5-bf20-36fd7eaca007"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("97897a58-e9d3-4356-b812-28a7f36d1dc5"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("97db43d1-846d-4f43-a790-976751cb15fe"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("9f2d5c35-a0e7-47ec-94a1-cb356d4ca6b2"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("c6df90ff-f5eb-4b3a-80c0-b4dbfeef85bc"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("fc943070-d81c-4d1e-950d-bd576447407a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b9e93e4e-7820-47f1-b6b7-9d56aa2f8112"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("13a0775f-d927-46af-92a0-98ce6bf9872d"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("14fba841-414f-41c7-aeae-4ac05d1b7443"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("24218c39-d924-4137-a1e6-a86ddf218c0d"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("4efaef53-730f-4684-a24d-7c8827dce33d"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("8755a3a6-f339-4483-80c5-50e9894e92ac"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("8f398fa5-5d97-41db-862d-d0b78646bc41"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("a7744125-73e8-4d77-8ddc-3cca872b2d9d"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("bb82b217-9945-4217-be1d-a068c8e7325d"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("c53eca07-83ab-4395-91d4-863d551a4185"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("cd8e2a7c-92ad-4266-b920-c7608db52e4b"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("e9582886-36e0-4bb0-ae45-35c4250a832f"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("051ac0fc-419a-4e53-a426-fb127bd2ab11"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("05ced153-c940-468c-b399-63a369c347a9"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("05f6fa15-ef28-40da-8824-b756df22a69c"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("0c413b2f-97bc-4c20-be92-82970a31f8fa"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("0fdbe00d-76c6-491c-ac0d-a8c98fc05807"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("10a097e8-c69f-46cc-af31-83e5209d06a2"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("15bac45d-db26-4a4b-a291-c82c86fb6439"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("15e9540f-0749-464b-99b5-da15a6506a24"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("1bb141e7-9adf-4064-86d4-683dc13fd668"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("202cc38b-19e7-4b5e-9996-60a7b05ac136"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("22aa7d30-7634-47b0-acdd-b04e6867886f"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("281a2f69-fdec-41d3-8def-4410a2c2eb39"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("2994f29e-4bc4-416f-af6f-cfe8ec99331e"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("2e4d4508-4a25-4a27-b437-55a25fec2b76"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("2fb9d7e1-2952-491b-aed4-b1f7945a134b"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("335740a1-eccd-4823-bcbf-74e69a79e2f6"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("33d7ab3a-7326-496a-a036-f644087b74a1"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("34840de1-ac05-4d07-9e61-d432c8029d48"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("37741c75-0c8c-4b7d-bba8-00fbe3ad143c"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("38681a50-78ab-431b-941f-79973b2621b8"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("3959407b-47dc-411e-b184-817a8e46e214"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("3ff7c173-bf6c-4456-9a88-f1ee98f833e1"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("44244219-b589-4da3-aab6-412d3d6133ea"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("451c635a-2e59-47b2-9438-5381c0c60c69"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("462aed08-bf0e-4567-89bb-b612e4bfd71f"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("49f050d0-7727-48db-94e7-92b2fce4047f"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("4b267545-7572-4da0-acb7-d307b526878c"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("4d4e4de8-b1ce-476a-9be1-e4c10544a4da"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("4f8db7af-91cb-44c3-8e37-3f6f61ea25bc"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("507afe5f-4bce-4321-add4-161e1d249edb"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("50d153bd-3add-461e-b967-3762bae56cd5"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("5126daa9-4a94-45cc-b9b6-f3bd019cf3f9"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("548fe377-425f-4405-a39c-8f4242ff1a92"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("56eaa900-9cba-441d-bcdf-582cecf7d193"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("5c38c208-b62d-4b11-ae25-1240e88ab694"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("5da12b1b-02f7-4d0f-b447-508dbcd24542"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("62e89587-214d-4994-827c-de3d045c887b"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("65107afa-f201-4208-bb7a-3b61bc625d90"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("688acf6b-0757-4c02-9ef3-84c92693b888"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("6ba2028b-15c8-4b7f-961e-79b8044321af"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("6ebc24cf-03b2-406b-9414-a16be4bb907f"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("71f5375a-b3e6-4570-911e-2dbaa630dcd5"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("74935e12-4f02-4152-b607-1453b6bc4bed"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("76156b0a-a7f0-4b35-9b13-33b8bd80cce6"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("761b1dcb-f5a5-418f-b5ba-c2867ebe38d0"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("76eb9286-4567-407a-aa27-171a4c4ff3ee"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("7d5184eb-96a7-4efa-a605-3461db550ac2"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("8450b974-81c7-4bc2-ad56-fd91b6490dd8"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("89ab27ab-a528-4f54-9300-354ace062b7b"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("8c52776c-669e-4613-a186-cb8010eee936"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("914f2528-a543-4a89-a79c-9ec7c3090486"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("921154f4-02c3-4e1e-ad7f-5bc2e366dba1"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("93ba2986-f1e8-44ce-bc50-44628a3c858d"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("942c3f7f-1440-4c51-99dc-128a9aab1ff4"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("95d0f3f2-8a4e-44ae-9549-680570a3f133"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("966a92ed-b86d-400e-85f8-0e51aeb58646"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("9a2d872a-8068-4de1-9289-aaf3df48d4b5"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("9d7bc718-ffe4-402d-8f73-e5c98d4cce67"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("9f236cb1-c686-406f-92e9-69e2e3a445c8"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("a4dec2f4-f7f9-45db-af0c-e555000fb43b"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("a65098da-a84b-47b1-aab9-2d6957fed03a"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("a6654d17-cdb5-4eff-9477-e2ef974d7b2e"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("ac81d67e-1b27-406c-8a33-a1000eff9a59"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("ad157592-9b5d-4a75-bc8f-5b02023a2f8e"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("aecedfa3-4b68-448c-8bfa-31c26546c3e4"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("af93cc02-b51f-46eb-8ca4-17a6da762049"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("b0a0a41a-6f83-4113-997b-f2288ced519b"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("b22b2401-9e75-4fb4-b835-af62c5932992"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("b36024c1-5579-435b-a2cc-709ec6656d26"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("ba37570e-b880-48dc-816e-c2b1f325b7a8"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("ba647f48-2ea8-42bd-9128-6f6c56d2dc86"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("bcc10348-6fb8-4e4e-b8d1-3d7c7625d5c4"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("c30a1e97-beb9-42af-8cff-94bc228de757"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("c3f2efc5-5d1c-47c9-a22b-4cc9b9b80842"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("c5a26ae0-318e-4d84-a190-3a3642bc98f3"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("c7aa2184-18d6-4736-baa3-a77e887a0184"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("c9fccec6-ffed-45dc-9d2b-0d441ead931c"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("cdbceef4-ebc3-44bb-a674-90b231599f0f"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("d0810ab8-ebdb-4d4f-afec-3739867ccf3b"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("d0acde2f-2706-4a2c-8675-491f27a332d8"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("d1b4d23c-9d22-4c18-977e-444c8bd9913a"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("d3f31a61-806d-46f9-b7c2-f7d0968bd810"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("d3fffcfd-5cdc-405f-a308-b9012c43d0aa"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("d4b356d5-a19f-4688-a385-0542371006cb"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("da3a2e6f-a586-4595-9685-e61909c34c17"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("db96738c-a4f9-4279-95ab-2fba7108f443"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("dc40606a-9dbc-41d2-8f5e-11f39e5f43dd"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("dc49e699-6a7a-432f-8654-0c5c40f63d78"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("ddcdaff7-d5ff-419a-9941-8104f3885e50"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("e2bf42c1-b668-4fb6-98c7-ae9ff0262ba0"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("e63be605-1bc2-4b0e-b3d6-56c5052daff7"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("e63cd800-6b38-4053-a0b8-f11b2cca8013"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("e95d3850-e5ef-4fd0-94cf-917adf6e6579"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("e9d9cfb4-3a2a-4b4f-b0d1-df24432da0d7"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("ea29951b-1644-419e-8ede-6148bfbe403f"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("ea29c8b8-4bc8-4a85-982d-334e32ac63c2"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("f12b3874-53ba-4ef0-8a35-fd1079d9a8db"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("f422ec15-29b2-4193-a098-8611133e65fd"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("f720e6f0-882f-420e-9d3f-767cdc55b781"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("f95ee933-57ce-49b0-8f4d-b833ffc9bff9"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("fce3954b-c8f6-40ff-ac45-9c5c3941b873"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("68211c11-7e8f-4473-b8ce-f486e1533174"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e2125eea-ed9b-4766-a679-6fb82361da66"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("629849bf-2c7c-4697-8213-79a55994ddfa"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("bb24f80c-849c-4192-8c39-e3e9c6603c8f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("024b88f2-4a56-4923-b8b2-5d672e7fee95"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09f720d9-4124-4b24-b035-d175da3c4066"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("11d2c7df-db0d-4a80-975e-bd5249e81747"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("18bdd307-ad5f-4c94-8822-2a76f4bdde71"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1bbe1119-39d3-487f-a3e7-d920a8acb7f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("20bce81b-f410-48b8-a441-30b71078b7a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("374f43e9-e985-4b46-a345-9b82253590db"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ea00bf3-ec77-40c4-9a18-6d3b642ffc22"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("520e84ac-9f70-46a2-a6b3-3489fdf8da47"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("550181b6-87bc-4797-99e4-e22750735773"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("829f0bc6-78ca-40c2-b783-50f34756e209"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9da2962a-25ec-48f7-80d6-9b4feeab8d4a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a907374e-dae3-47b6-bf05-92555c4816ad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d12be56f-2cf2-47ca-8645-13820aa5f565"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("9bffd57a-5e20-4b0c-9793-71d4b49a7150"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0ec5b7a6-d6ff-4ce2-9f91-11db3a790b13"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f429881-cf3e-4c38-bbdb-b800718a54be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("21f16c04-2543-4c0c-b77b-02b83251bd5c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("79387519-3fc0-4cc8-960a-ecce15589de3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7f27b169-c92d-4579-925a-5fccc12d5940"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9c3a55e7-ab2c-4649-8812-d50b4325714a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a211dc27-cbc4-4f00-a2b9-701f42f64914"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa203afe-629a-4d68-9a66-8a78e439171e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad4c1f6e-18eb-41b2-86b3-a93d8dbaa8d2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("da413ab7-031a-4e68-b989-2e876257acee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e677c949-884b-4212-aadf-a25ae9d44fcc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("05b90914-8b10-4bb7-bff0-63f3a2064980"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("20aee67c-cf7a-4eb5-a71f-a9f1126f3aea"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("c9e76b33-153e-4d44-9fdc-7c22201cb71a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c756f726-7848-495a-b79e-0be333137aab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9a34bbf2-cf8b-4865-95dc-794e30aade23"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ParentId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("05b90914-8b10-4bb7-bff0-63f3a2064980"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo", null, null },
                    { new Guid("20aee67c-cf7a-4eb5-a71f-a9f1126f3aea"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần", null, null }
                });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Price", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("051ac0fc-419a-4e53-a426-fb127bd2ab11"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("05ced153-c940-468c-b399-63a369c347a9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("05f6fa15-ef28-40da-8824-b756df22a69c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("0c413b2f-97bc-4c20-be92-82970a31f8fa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("0fdbe00d-76c6-491c-ac0d-a8c98fc05807"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("10a097e8-c69f-46cc-af31-83e5209d06a2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("15bac45d-db26-4a4b-a291-c82c86fb6439"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("15e9540f-0749-464b-99b5-da15a6506a24"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("1bb141e7-9adf-4064-86d4-683dc13fd668"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("202cc38b-19e7-4b5e-9996-60a7b05ac136"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("22aa7d30-7634-47b0-acdd-b04e6867886f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("281a2f69-fdec-41d3-8def-4410a2c2eb39"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("2994f29e-4bc4-416f-af6f-cfe8ec99331e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("2e4d4508-4a25-4a27-b437-55a25fec2b76"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("2fb9d7e1-2952-491b-aed4-b1f7945a134b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("335740a1-eccd-4823-bcbf-74e69a79e2f6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("33d7ab3a-7326-496a-a036-f644087b74a1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("34840de1-ac05-4d07-9e61-d432c8029d48"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("37741c75-0c8c-4b7d-bba8-00fbe3ad143c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("38681a50-78ab-431b-941f-79973b2621b8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("3959407b-47dc-411e-b184-817a8e46e214"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("3ff7c173-bf6c-4456-9a88-f1ee98f833e1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("44244219-b589-4da3-aab6-412d3d6133ea"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("451c635a-2e59-47b2-9438-5381c0c60c69"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("462aed08-bf0e-4567-89bb-b612e4bfd71f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("49f050d0-7727-48db-94e7-92b2fce4047f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("4b267545-7572-4da0-acb7-d307b526878c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("4d4e4de8-b1ce-476a-9be1-e4c10544a4da"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("4f8db7af-91cb-44c3-8e37-3f6f61ea25bc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("507afe5f-4bce-4321-add4-161e1d249edb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("50d153bd-3add-461e-b967-3762bae56cd5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("5126daa9-4a94-45cc-b9b6-f3bd019cf3f9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("548fe377-425f-4405-a39c-8f4242ff1a92"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("56eaa900-9cba-441d-bcdf-582cecf7d193"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("5c38c208-b62d-4b11-ae25-1240e88ab694"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("5da12b1b-02f7-4d0f-b447-508dbcd24542"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("62e89587-214d-4994-827c-de3d045c887b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("65107afa-f201-4208-bb7a-3b61bc625d90"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("688acf6b-0757-4c02-9ef3-84c92693b888"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("6ba2028b-15c8-4b7f-961e-79b8044321af"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("6ebc24cf-03b2-406b-9414-a16be4bb907f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("71f5375a-b3e6-4570-911e-2dbaa630dcd5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("74935e12-4f02-4152-b607-1453b6bc4bed"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("76156b0a-a7f0-4b35-9b13-33b8bd80cce6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("761b1dcb-f5a5-418f-b5ba-c2867ebe38d0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("76eb9286-4567-407a-aa27-171a4c4ff3ee"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("7d5184eb-96a7-4efa-a605-3461db550ac2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("8450b974-81c7-4bc2-ad56-fd91b6490dd8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("89ab27ab-a528-4f54-9300-354ace062b7b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("8c52776c-669e-4613-a186-cb8010eee936"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("914f2528-a543-4a89-a79c-9ec7c3090486"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("921154f4-02c3-4e1e-ad7f-5bc2e366dba1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("93ba2986-f1e8-44ce-bc50-44628a3c858d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("942c3f7f-1440-4c51-99dc-128a9aab1ff4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("95d0f3f2-8a4e-44ae-9549-680570a3f133"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("966a92ed-b86d-400e-85f8-0e51aeb58646"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("9a2d872a-8068-4de1-9289-aaf3df48d4b5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("9bffd57a-5e20-4b0c-9793-71d4b49a7150"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("9d7bc718-ffe4-402d-8f73-e5c98d4cce67"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("9f236cb1-c686-406f-92e9-69e2e3a445c8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("a4dec2f4-f7f9-45db-af0c-e555000fb43b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("a65098da-a84b-47b1-aab9-2d6957fed03a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("a6654d17-cdb5-4eff-9477-e2ef974d7b2e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("ac81d67e-1b27-406c-8a33-a1000eff9a59"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("ad157592-9b5d-4a75-bc8f-5b02023a2f8e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("aecedfa3-4b68-448c-8bfa-31c26546c3e4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("af93cc02-b51f-46eb-8ca4-17a6da762049"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("b0a0a41a-6f83-4113-997b-f2288ced519b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("b22b2401-9e75-4fb4-b835-af62c5932992"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("b36024c1-5579-435b-a2cc-709ec6656d26"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("ba37570e-b880-48dc-816e-c2b1f325b7a8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("ba647f48-2ea8-42bd-9128-6f6c56d2dc86"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("bcc10348-6fb8-4e4e-b8d1-3d7c7625d5c4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("c30a1e97-beb9-42af-8cff-94bc228de757"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("c3f2efc5-5d1c-47c9-a22b-4cc9b9b80842"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("c5a26ae0-318e-4d84-a190-3a3642bc98f3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("c7aa2184-18d6-4736-baa3-a77e887a0184"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("c9fccec6-ffed-45dc-9d2b-0d441ead931c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("cdbceef4-ebc3-44bb-a674-90b231599f0f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("d0810ab8-ebdb-4d4f-afec-3739867ccf3b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("d0acde2f-2706-4a2c-8675-491f27a332d8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("d1b4d23c-9d22-4c18-977e-444c8bd9913a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("d3f31a61-806d-46f9-b7c2-f7d0968bd810"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("d3fffcfd-5cdc-405f-a308-b9012c43d0aa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("d4b356d5-a19f-4688-a385-0542371006cb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("da3a2e6f-a586-4595-9685-e61909c34c17"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("db96738c-a4f9-4279-95ab-2fba7108f443"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("dc40606a-9dbc-41d2-8f5e-11f39e5f43dd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("dc49e699-6a7a-432f-8654-0c5c40f63d78"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("ddcdaff7-d5ff-419a-9941-8104f3885e50"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("e2bf42c1-b668-4fb6-98c7-ae9ff0262ba0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("e63be605-1bc2-4b0e-b3d6-56c5052daff7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("e63cd800-6b38-4053-a0b8-f11b2cca8013"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("e95d3850-e5ef-4fd0-94cf-917adf6e6579"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("e9d9cfb4-3a2a-4b4f-b0d1-df24432da0d7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("ea29951b-1644-419e-8ede-6148bfbe403f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("ea29c8b8-4bc8-4a85-982d-334e32ac63c2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("f12b3874-53ba-4ef0-8a35-fd1079d9a8db"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("f422ec15-29b2-4193-a098-8611133e65fd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("f720e6f0-882f-420e-9d3f-767cdc55b781"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("f95ee933-57ce-49b0-8f4d-b833ffc9bff9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("fce3954b-c8f6-40ff-ac45-9c5c3941b873"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedAt", "DateOfBirth", "Email", "FirstName", "HashedPassword", "ImageUrl", "IsDeleted", "IsVerify", "LastName", "PhoneNumber", "Role", "UpdatedAt", "VerifyCode" },
                values: new object[,]
                {
                    { new Guid("0ec5b7a6-d6ff-4ce2-9f91-11db3a790b13"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan4@gmail.com", "Tan4", "hashed_password_4", null, false, false, "Tran4", null, "User", null, 0 },
                    { new Guid("0f429881-cf3e-4c38-bbdb-b800718a54be"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan10@gmail.com", "Tan10", "hashed_password_10", null, false, false, "Tran10", null, "User", null, 0 },
                    { new Guid("21f16c04-2543-4c0c-b77b-02b83251bd5c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan7@gmail.com", "Tan7", "hashed_password_7", null, false, false, "Tran7", null, "Seller", null, 0 },
                    { new Guid("79387519-3fc0-4cc8-960a-ecce15589de3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan3@gmail.com", "Tan3", "hashed_password_3", null, false, false, "Tran3", null, "Seller", null, 0 },
                    { new Guid("7f27b169-c92d-4579-925a-5fccc12d5940"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan1@gmail.com", "Tan1", "hashed_password_1", null, false, false, "Tran1", null, "Seller", null, 0 },
                    { new Guid("9a34bbf2-cf8b-4865-95dc-794e30aade23"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tan182205@gmail.com", "Tan", "hashed_password_1", null, false, false, "Tran", null, "user", null, 0 },
                    { new Guid("9c3a55e7-ab2c-4649-8812-d50b4325714a"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan2@gmail.com", "Tan2", "hashed_password_2", null, false, false, "Tran2", null, "User", null, 0 },
                    { new Guid("a211dc27-cbc4-4f00-a2b9-701f42f64914"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan9@gmail.com", "Tan9", "hashed_password_9", null, false, false, "Tran9", null, "Seller", null, 0 },
                    { new Guid("aa203afe-629a-4d68-9a66-8a78e439171e"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan0@gmail.com", "Tan0", "hashed_password_0", null, false, false, "Tran0", null, "User", null, 0 },
                    { new Guid("ad4c1f6e-18eb-41b2-86b3-a93d8dbaa8d2"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan8@gmail.com", "Tan8", "hashed_password_8", null, false, false, "Tran8", null, "User", null, 0 },
                    { new Guid("c756f726-7848-495a-b79e-0be333137aab"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tan182206@gmail.com", "Tan", "hashed_password_1", null, false, false, "Tran", null, "user", null, 0 },
                    { new Guid("da413ab7-031a-4e68-b989-2e876257acee"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan6@gmail.com", "Tan6", "hashed_password_6", null, false, false, "Tran6", null, "User", null, 0 },
                    { new Guid("e677c949-884b-4212-aadf-a25ae9d44fcc"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan5@gmail.com", "Tan5", "hashed_password_5", null, false, false, "Tran5", null, "Seller", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "TotalAmount", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("05300d73-cc84-4684-9021-01a9cf9400bc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("21f16c04-2543-4c0c-b77b-02b83251bd5c") },
                    { new Guid("2280e82a-63a0-40d3-a9e2-90daa69774bf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("79387519-3fc0-4cc8-960a-ecce15589de3") },
                    { new Guid("41e0d1f6-624f-452e-9f64-e9cbb417a583"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("a211dc27-cbc4-4f00-a2b9-701f42f64914") },
                    { new Guid("4329a7cc-9252-4bc5-8e7b-ec189d5c1a84"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("e677c949-884b-4212-aadf-a25ae9d44fcc") },
                    { new Guid("67f72277-d090-4018-ab77-2b6a214f2d11"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("da413ab7-031a-4e68-b989-2e876257acee") },
                    { new Guid("75ae8c46-ea46-4e30-bea8-ae7bc8a8aaa2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("aa203afe-629a-4d68-9a66-8a78e439171e") },
                    { new Guid("b05e8080-59db-4385-b8e2-77459ca786be"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("0ec5b7a6-d6ff-4ce2-9f91-11db3a790b13") },
                    { new Guid("d78c228d-4b65-4992-858b-909422eed624"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("0f429881-cf3e-4c38-bbdb-b800718a54be") },
                    { new Guid("d9b0b7ea-5429-475e-97b0-93d285921dbb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("ad4c1f6e-18eb-41b2-86b3-a93d8dbaa8d2") },
                    { new Guid("e158230f-c318-446c-8b1b-a31c00a16bbc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("7f27b169-c92d-4579-925a-5fccc12d5940") },
                    { new Guid("eccc1102-4824-4a26-866b-2753a29bb718"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("9c3a55e7-ab2c-4649-8812-d50b4325714a") }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ParentId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("118eaca0-5f40-4111-a825-63f43f3dd9fa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Kaki", new Guid("20aee67c-cf7a-4eb5-a71f-a9f1126f3aea"), null },
                    { new Guid("68211c11-7e8f-4473-b8ce-f486e1533174"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao", new Guid("05b90914-8b10-4bb7-bff0-63f3a2064980"), null },
                    { new Guid("ae58b5b1-a448-4749-926f-be2a5d6ede5e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo ba lỗ", new Guid("05b90914-8b10-4bb7-bff0-63f3a2064980"), null },
                    { new Guid("e2125eea-ed9b-4766-a679-6fb82361da66"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Jean", new Guid("20aee67c-cf7a-4eb5-a71f-a9f1126f3aea"), null }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "CreatedAt", "IsDeleted", "Status", "TotalAmount", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("1c8fc93b-afca-478a-af9c-9de67eb3b896"), "Bien hoa, Dong Nai9", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed9", 10009m, null, new Guid("ad4c1f6e-18eb-41b2-86b3-a93d8dbaa8d2") },
                    { new Guid("2324fedd-2111-4bf8-9635-4ad773de5616"), "Bien hoa, Dong Nai6", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed6", 10006m, null, new Guid("e677c949-884b-4212-aadf-a25ae9d44fcc") },
                    { new Guid("428732a2-2255-4a8d-a4d6-f2272f5b2ebf"), "Bien hoa, Dong Nai8", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed8", 10008m, null, new Guid("21f16c04-2543-4c0c-b77b-02b83251bd5c") },
                    { new Guid("4c136267-f6dc-49bf-b0a3-fe05a6601bc8"), "Bien hoa, Dong Nai7", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed7", 10007m, null, new Guid("da413ab7-031a-4e68-b989-2e876257acee") },
                    { new Guid("629849bf-2c7c-4697-8213-79a55994ddfa"), "Bien hoa, Dong Nai", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed", 10000m, null, new Guid("c756f726-7848-495a-b79e-0be333137aab") },
                    { new Guid("99aab642-74f1-4bec-938d-52b646ff6ccf"), "Bien hoa, Dong Nai4", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed4", 10004m, null, new Guid("79387519-3fc0-4cc8-960a-ecce15589de3") },
                    { new Guid("a0a1216d-3af0-430a-b1c7-d6b86acae7e9"), "Bien hoa, Dong Nai5", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed5", 10005m, null, new Guid("0ec5b7a6-d6ff-4ce2-9f91-11db3a790b13") },
                    { new Guid("bb24f80c-849c-4192-8c39-e3e9c6603c8f"), "Bien hoa, Dong Nai", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed", 10000m, null, new Guid("c756f726-7848-495a-b79e-0be333137aab") },
                    { new Guid("d4e8aa76-ce50-4320-99ac-03371dfe7144"), "Bien hoa, Dong Nai10", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed10", 10010m, null, new Guid("a211dc27-cbc4-4f00-a2b9-701f42f64914") },
                    { new Guid("dc8c305f-eea8-4d9a-af15-1511f7088fd2"), "Bien hoa, Dong Nai2", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed2", 10002m, null, new Guid("7f27b169-c92d-4579-925a-5fccc12d5940") },
                    { new Guid("eba3a7a3-eab0-4f7b-9413-f8b6eeef0b97"), "Bien hoa, Dong Nai11", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed11", 10011m, null, new Guid("0f429881-cf3e-4c38-bbdb-b800718a54be") },
                    { new Guid("f79cb979-935d-49d6-b0ee-714d619119df"), "Bien hoa, Dong Nai3", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed3", 10003m, null, new Guid("9c3a55e7-ab2c-4649-8812-d50b4325714a") },
                    { new Guid("ff558f2a-9024-492f-a2f3-1b7d76aadca5"), "Bien hoa, Dong Nai1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed1", 10001m, null, new Guid("aa203afe-629a-4d68-9a66-8a78e439171e") }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "CompanyAddress", "CompanyName", "CreatedAt", "IsDeleted", "TaxCode", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("13a0775f-d927-46af-92a0-98ce6bf9872d"), "123 Main St, Cityville8", "ABC Company8", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE8", null, new Guid("21f16c04-2543-4c0c-b77b-02b83251bd5c") },
                    { new Guid("14fba841-414f-41c7-aeae-4ac05d1b7443"), "123 Main St, Cityville4", "ABC Company4", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE4", null, new Guid("79387519-3fc0-4cc8-960a-ecce15589de3") },
                    { new Guid("24218c39-d924-4137-a1e6-a86ddf218c0d"), "123 Main St, Cityville7", "ABC Company7", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE7", null, new Guid("da413ab7-031a-4e68-b989-2e876257acee") },
                    { new Guid("4efaef53-730f-4684-a24d-7c8827dce33d"), "123 Main St, Cityville3", "ABC Company3", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE3", null, new Guid("9c3a55e7-ab2c-4649-8812-d50b4325714a") },
                    { new Guid("8755a3a6-f339-4483-80c5-50e9894e92ac"), "123 Main St, Cityville2", "ABC Company2", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE2", null, new Guid("7f27b169-c92d-4579-925a-5fccc12d5940") },
                    { new Guid("8f398fa5-5d97-41db-862d-d0b78646bc41"), "123 Main St, Cityville1", "ABC Company1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE1", null, new Guid("aa203afe-629a-4d68-9a66-8a78e439171e") },
                    { new Guid("a7744125-73e8-4d77-8ddc-3cca872b2d9d"), "123 Main St, Cityville10", "ABC Company10", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE10", null, new Guid("a211dc27-cbc4-4f00-a2b9-701f42f64914") },
                    { new Guid("bb82b217-9945-4217-be1d-a068c8e7325d"), "123 Main St, Cityville11", "ABC Company11", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE11", null, new Guid("0f429881-cf3e-4c38-bbdb-b800718a54be") },
                    { new Guid("c53eca07-83ab-4395-91d4-863d551a4185"), "123 Main St, Cityville5", "ABC Company5", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE5", null, new Guid("0ec5b7a6-d6ff-4ce2-9f91-11db3a790b13") },
                    { new Guid("c9e76b33-153e-4d44-9fdc-7c22201cb71a"), "123 Main St, Cityville", "ABC Company", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE123", null, new Guid("9a34bbf2-cf8b-4865-95dc-794e30aade23") },
                    { new Guid("cd8e2a7c-92ad-4266-b920-c7608db52e4b"), "123 Main St, Cityville9", "ABC Company9", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE9", null, new Guid("ad4c1f6e-18eb-41b2-86b3-a93d8dbaa8d2") },
                    { new Guid("e9582886-36e0-4bb0-ae45-35c4250a832f"), "123 Main St, Cityville6", "ABC Company6", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE6", null, new Guid("e677c949-884b-4212-aadf-a25ae9d44fcc") }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ParentId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("05564ee2-9966-49eb-87e1-460e3f411b45"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Jean7", new Guid("e2125eea-ed9b-4766-a679-6fb82361da66"), null },
                    { new Guid("10363064-90e5-4d72-a12b-dd56e04a43c7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Jean5", new Guid("e2125eea-ed9b-4766-a679-6fb82361da66"), null },
                    { new Guid("3000ea39-704f-4321-99bb-4fe38882703c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao8", new Guid("68211c11-7e8f-4473-b8ce-f486e1533174"), null },
                    { new Guid("554f3092-8c22-4cfb-bfbb-5fe76025c75c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Jean3", new Guid("e2125eea-ed9b-4766-a679-6fb82361da66"), null },
                    { new Guid("663c7491-69a1-44ab-9b34-42794944a627"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Jean9", new Guid("e2125eea-ed9b-4766-a679-6fb82361da66"), null },
                    { new Guid("79cf9b82-71d9-4961-83f8-8a01616f55d6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao10", new Guid("68211c11-7e8f-4473-b8ce-f486e1533174"), null },
                    { new Guid("8a6fa20d-34f4-4065-94cc-1376fe62326e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao6", new Guid("68211c11-7e8f-4473-b8ce-f486e1533174"), null },
                    { new Guid("c3c9b582-d2bb-4786-9bcf-7e33ddbf655e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao2", new Guid("68211c11-7e8f-4473-b8ce-f486e1533174"), null },
                    { new Guid("c6fb3b01-9fb1-4f5c-ab26-6ee95d79cdca"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Jean1", new Guid("e2125eea-ed9b-4766-a679-6fb82361da66"), null },
                    { new Guid("e034645b-c747-49bc-88f8-990d7ef9b60b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao4", new Guid("68211c11-7e8f-4473-b8ce-f486e1533174"), null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "Name", "Price", "SellerId", "UpdatedAt", "UrlImage" },
                values: new object[,]
                {
                    { new Guid("024b88f2-4a56-4923-b8b2-5d672e7fee95"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt2", false, "T-Shirt2", 199000m, new Guid("c9e76b33-153e-4d44-9fdc-7c22201cb71a"), null, "" },
                    { new Guid("09f720d9-4124-4b24-b035-d175da3c4066"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt9", false, "T-Shirt9", 199000m, new Guid("c9e76b33-153e-4d44-9fdc-7c22201cb71a"), null, "" },
                    { new Guid("11d2c7df-db0d-4a80-975e-bd5249e81747"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Áo sơ mi nam công sở, thiết kế hiện đại, chất liệu vải cao cấp, thoáng mát.", false, "Áo Sơ Mi Nam", 299000m, new Guid("c9e76b33-153e-4d44-9fdc-7c22201cb71a"), null, "https://example.com/images/ao_so_mi_nam.jpg" },
                    { new Guid("18bdd307-ad5f-4c94-8822-2a76f4bdde71"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt10", false, "T-Shirt10", 199000m, new Guid("c9e76b33-153e-4d44-9fdc-7c22201cb71a"), null, "" },
                    { new Guid("1bbe1119-39d3-487f-a3e7-d920a8acb7f9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt8", false, "T-Shirt8", 199000m, new Guid("c9e76b33-153e-4d44-9fdc-7c22201cb71a"), null, "" },
                    { new Guid("20bce81b-f410-48b8-a441-30b71078b7a9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quần jeans nữ dáng ôm, tôn dáng, chất liệu denim co giãn, phù hợp cho mọi dịp.", false, "Quần Jeans Nữ", 399000m, new Guid("c9e76b33-153e-4d44-9fdc-7c22201cb71a"), null, "https://example.com/images/quan_jeans_nu.jpg" },
                    { new Guid("374f43e9-e985-4b46-a345-9b82253590db"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Áo thun nam chất liệu cotton cao cấp, thoáng mát, phù hợp cho mọi hoạt động hàng ngày.", false, "Áo Thun Nam", 199000m, new Guid("c9e76b33-153e-4d44-9fdc-7c22201cb71a"), null, "https://example.com/images/ao_thun_nam.jpg" },
                    { new Guid("4ea00bf3-ec77-40c4-9a18-6d3b642ffc22"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt0", false, "T-Shirt0", 199000m, new Guid("c9e76b33-153e-4d44-9fdc-7c22201cb71a"), null, "" },
                    { new Guid("520e84ac-9f70-46a2-a6b3-3489fdf8da47"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt4", false, "T-Shirt4", 199000m, new Guid("c9e76b33-153e-4d44-9fdc-7c22201cb71a"), null, "" },
                    { new Guid("550181b6-87bc-4797-99e4-e22750735773"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt1", false, "T-Shirt1", 199000m, new Guid("c9e76b33-153e-4d44-9fdc-7c22201cb71a"), null, "" },
                    { new Guid("829f0bc6-78ca-40c2-b783-50f34756e209"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt3", false, "T-Shirt3", 199000m, new Guid("c9e76b33-153e-4d44-9fdc-7c22201cb71a"), null, "" },
                    { new Guid("9da2962a-25ec-48f7-80d6-9b4feeab8d4a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt7", false, "T-Shirt7", 199000m, new Guid("c9e76b33-153e-4d44-9fdc-7c22201cb71a"), null, "" },
                    { new Guid("a907374e-dae3-47b6-bf05-92555c4816ad"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt5", false, "T-Shirt5", 199000m, new Guid("c9e76b33-153e-4d44-9fdc-7c22201cb71a"), null, "" },
                    { new Guid("b9e93e4e-7820-47f1-b6b7-9d56aa2f8112"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Chân váy nữ xòe, thiết kế trẻ trung, chất liệu vải mềm mại, phù hợp cho mọi dịp.", false, "Chân Váy Nữ", 249000m, new Guid("c9e76b33-153e-4d44-9fdc-7c22201cb71a"), null, "https://example.com/images/chan_vay_nu.jpg" },
                    { new Guid("d12be56f-2cf2-47ca-8645-13820aa5f565"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt6", false, "T-Shirt6", 199000m, new Guid("c9e76b33-153e-4d44-9fdc-7c22201cb71a"), null, "" }
                });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "ProductId", "TotalInStock", "TotalSell", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("3711927c-6ded-4444-834e-debd91298175"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("829f0bc6-78ca-40c2-b783-50f34756e209"), 1000m, 1000m, null },
                    { new Guid("3f3bc816-d80f-4170-b14b-1e544005ebce"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("1bbe1119-39d3-487f-a3e7-d920a8acb7f9"), 1000m, 1000m, null },
                    { new Guid("49251e76-343b-41e7-b59c-30fec7c540de"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("550181b6-87bc-4797-99e4-e22750735773"), 1000m, 1000m, null },
                    { new Guid("52148e13-2390-4bea-9243-14c5689923cb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("18bdd307-ad5f-4c94-8822-2a76f4bdde71"), 1000m, 1000m, null },
                    { new Guid("613b6fae-bbd6-4357-9657-7544147eb289"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("a907374e-dae3-47b6-bf05-92555c4816ad"), 1000m, 1000m, null },
                    { new Guid("9b593d55-d6a9-4fb3-a7c6-cab5a8f7e70a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("024b88f2-4a56-4923-b8b2-5d672e7fee95"), 1000m, 1000m, null },
                    { new Guid("9d87b637-fca2-4486-bd85-4f85afb51464"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("9da2962a-25ec-48f7-80d6-9b4feeab8d4a"), 1000m, 1000m, null },
                    { new Guid("ab645396-fd9c-4bed-9d53-7f4bc7245ca6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("09f720d9-4124-4b24-b035-d175da3c4066"), 1000m, 1000m, null },
                    { new Guid("bf7f1c1d-1290-4edc-8a19-9fc6820d22b7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("4ea00bf3-ec77-40c4-9a18-6d3b642ffc22"), 1000m, 1000m, null },
                    { new Guid("d5c4646a-969a-49cf-be56-5dd1b71f8d5f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("d12be56f-2cf2-47ca-8645-13820aa5f565"), 1000m, 1000m, null },
                    { new Guid("ebfdc190-b6d3-4665-bdb6-0d0d0460d58b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("520e84ac-9f70-46a2-a6b3-3489fdf8da47"), 1000m, 1000m, null }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "OrderId", "ProductId", "Quantity", "UnitPrice", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("028dc0ac-16db-45c4-833e-14f2c036437d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("629849bf-2c7c-4697-8213-79a55994ddfa"), new Guid("374f43e9-e985-4b46-a345-9b82253590db"), 2, 19990000m, null },
                    { new Guid("05494e30-63d7-47b5-a0b6-00ad3b94856a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("bb24f80c-849c-4192-8c39-e3e9c6603c8f"), new Guid("11d2c7df-db0d-4a80-975e-bd5249e81747"), 1, 29990000m, null },
                    { new Guid("066f9b71-62df-425f-b8c0-bc84e5987a0d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("629849bf-2c7c-4697-8213-79a55994ddfa"), new Guid("374f43e9-e985-4b46-a345-9b82253590db"), 2, 19990000m, null },
                    { new Guid("40bd409e-3ca2-43d3-a670-6dd77bf5e8a1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("629849bf-2c7c-4697-8213-79a55994ddfa"), new Guid("374f43e9-e985-4b46-a345-9b82253590db"), 2, 19990000m, null },
                    { new Guid("4507cc45-c0c6-4937-b82b-27e994e5401b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("629849bf-2c7c-4697-8213-79a55994ddfa"), new Guid("374f43e9-e985-4b46-a345-9b82253590db"), 2, 19990000m, null },
                    { new Guid("594a63a3-692a-45ee-a8d8-b307e34f8aa1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("629849bf-2c7c-4697-8213-79a55994ddfa"), new Guid("374f43e9-e985-4b46-a345-9b82253590db"), 2, 19990000m, null },
                    { new Guid("6cfe37eb-12d9-4672-b2f0-888a5d439d68"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("629849bf-2c7c-4697-8213-79a55994ddfa"), new Guid("374f43e9-e985-4b46-a345-9b82253590db"), 2, 19990000m, null },
                    { new Guid("96a0e781-4c31-4a60-bcb0-9715323e9836"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("629849bf-2c7c-4697-8213-79a55994ddfa"), new Guid("20bce81b-f410-48b8-a441-30b71078b7a9"), 1, 39990000m, null },
                    { new Guid("acbfe78e-6cf2-4500-995e-e9246917a827"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("629849bf-2c7c-4697-8213-79a55994ddfa"), new Guid("374f43e9-e985-4b46-a345-9b82253590db"), 2, 19990000m, null },
                    { new Guid("acdd208d-4b34-4d69-9c0d-337952b146bb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("629849bf-2c7c-4697-8213-79a55994ddfa"), new Guid("374f43e9-e985-4b46-a345-9b82253590db"), 2, 19990000m, null },
                    { new Guid("b7f357d1-3d9b-47d6-8bea-88cc3a2f5dce"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("629849bf-2c7c-4697-8213-79a55994ddfa"), new Guid("374f43e9-e985-4b46-a345-9b82253590db"), 2, 19990000m, null },
                    { new Guid("d0bfcb53-9a79-4061-9dc3-e8092cad34be"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("629849bf-2c7c-4697-8213-79a55994ddfa"), new Guid("374f43e9-e985-4b46-a345-9b82253590db"), 2, 19990000m, null },
                    { new Guid("d59d90ef-46bf-4af8-a860-b7d8d3ff614c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("629849bf-2c7c-4697-8213-79a55994ddfa"), new Guid("374f43e9-e985-4b46-a345-9b82253590db"), 2, 19990000m, null },
                    { new Guid("f52dc5b4-131c-497b-8b35-a80873201470"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("629849bf-2c7c-4697-8213-79a55994ddfa"), new Guid("374f43e9-e985-4b46-a345-9b82253590db"), 2, 19990000m, null }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "IsDeleted", "ProductID", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0543c211-2df4-4626-9583-801431adc0fb"), new Guid("05b90914-8b10-4bb7-bff0-63f3a2064980"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("374f43e9-e985-4b46-a345-9b82253590db"), null },
                    { new Guid("1b1f226c-9183-4a85-b892-dcf335936044"), new Guid("05b90914-8b10-4bb7-bff0-63f3a2064980"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("374f43e9-e985-4b46-a345-9b82253590db"), null },
                    { new Guid("526b7957-ad66-41df-945c-0ef00484116c"), new Guid("05b90914-8b10-4bb7-bff0-63f3a2064980"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("374f43e9-e985-4b46-a345-9b82253590db"), null },
                    { new Guid("60b02070-720d-4b9c-bb62-f17cfba32675"), new Guid("05b90914-8b10-4bb7-bff0-63f3a2064980"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("374f43e9-e985-4b46-a345-9b82253590db"), null },
                    { new Guid("6c12faf9-2c10-45cd-b08c-2002d46e2dd4"), new Guid("05b90914-8b10-4bb7-bff0-63f3a2064980"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("374f43e9-e985-4b46-a345-9b82253590db"), null },
                    { new Guid("86d0cf72-2dce-40f3-8ad0-594784ae3d9a"), new Guid("05b90914-8b10-4bb7-bff0-63f3a2064980"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("374f43e9-e985-4b46-a345-9b82253590db"), null },
                    { new Guid("9f21257e-efb4-4972-bb81-c7fc54cf9ff7"), new Guid("05b90914-8b10-4bb7-bff0-63f3a2064980"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("374f43e9-e985-4b46-a345-9b82253590db"), null },
                    { new Guid("a1b4db2d-aa49-44f0-a78a-8e4d5e8fd8be"), new Guid("05b90914-8b10-4bb7-bff0-63f3a2064980"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("374f43e9-e985-4b46-a345-9b82253590db"), null },
                    { new Guid("a8b114ab-0649-4cd8-9655-9711a2aadc71"), new Guid("05b90914-8b10-4bb7-bff0-63f3a2064980"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("374f43e9-e985-4b46-a345-9b82253590db"), null },
                    { new Guid("b3bf17b3-5c61-4216-a017-1db04e0f6a02"), new Guid("05b90914-8b10-4bb7-bff0-63f3a2064980"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("374f43e9-e985-4b46-a345-9b82253590db"), null },
                    { new Guid("ea907db9-b764-4893-87ca-34e62973e0f3"), new Guid("05b90914-8b10-4bb7-bff0-63f3a2064980"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("374f43e9-e985-4b46-a345-9b82253590db"), null }
                });

            migrationBuilder.InsertData(
                table: "ProductStorages",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "ProductId", "StorageId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1b1efc04-d704-46ca-8f8f-c5c85c696019"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("374f43e9-e985-4b46-a345-9b82253590db"), new Guid("9bffd57a-5e20-4b0c-9793-71d4b49a7150"), null },
                    { new Guid("2fc81d5d-f148-4dff-bf64-14ceb8c0a2ac"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("374f43e9-e985-4b46-a345-9b82253590db"), new Guid("9bffd57a-5e20-4b0c-9793-71d4b49a7150"), null },
                    { new Guid("50cce5ea-8722-440d-a7ff-97992de1413d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("374f43e9-e985-4b46-a345-9b82253590db"), new Guid("9bffd57a-5e20-4b0c-9793-71d4b49a7150"), null },
                    { new Guid("656ea6f3-1c27-456a-910b-c44091710053"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("374f43e9-e985-4b46-a345-9b82253590db"), new Guid("9bffd57a-5e20-4b0c-9793-71d4b49a7150"), null },
                    { new Guid("775c1709-b435-4996-b1e4-91f7bfc945d0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("374f43e9-e985-4b46-a345-9b82253590db"), new Guid("9bffd57a-5e20-4b0c-9793-71d4b49a7150"), null },
                    { new Guid("914a9c48-04bf-48f5-bf20-36fd7eaca007"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("374f43e9-e985-4b46-a345-9b82253590db"), new Guid("9bffd57a-5e20-4b0c-9793-71d4b49a7150"), null },
                    { new Guid("97897a58-e9d3-4356-b812-28a7f36d1dc5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("374f43e9-e985-4b46-a345-9b82253590db"), new Guid("9bffd57a-5e20-4b0c-9793-71d4b49a7150"), null },
                    { new Guid("97db43d1-846d-4f43-a790-976751cb15fe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("374f43e9-e985-4b46-a345-9b82253590db"), new Guid("9bffd57a-5e20-4b0c-9793-71d4b49a7150"), null },
                    { new Guid("9f2d5c35-a0e7-47ec-94a1-cb356d4ca6b2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("374f43e9-e985-4b46-a345-9b82253590db"), new Guid("9bffd57a-5e20-4b0c-9793-71d4b49a7150"), null },
                    { new Guid("c6df90ff-f5eb-4b3a-80c0-b4dbfeef85bc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("374f43e9-e985-4b46-a345-9b82253590db"), new Guid("9bffd57a-5e20-4b0c-9793-71d4b49a7150"), null },
                    { new Guid("fc943070-d81c-4d1e-950d-bd576447407a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("374f43e9-e985-4b46-a345-9b82253590db"), new Guid("9bffd57a-5e20-4b0c-9793-71d4b49a7150"), null }
                });
        }
    }
}
