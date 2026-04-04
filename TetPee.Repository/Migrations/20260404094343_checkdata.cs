using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TetPee.Repository.Migrations
{
    /// <inheritdoc />
    public partial class checkdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("34d9819e-62d1-484d-bab9-2feac2df8f40"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("3738387d-ef95-4512-8f59-8ae98c7fa352"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("5ab90acd-008e-4828-b41c-0e663a3b4d0d"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("82af644e-2046-4d9e-ae26-c1185a42d522"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("837ce73a-7abf-4b09-b96c-1689cc81a65f"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("9adb245e-a086-49b4-ac41-45f47133f441"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("a6bdf16c-784f-4272-b871-16fa3a5267a4"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("b87809cf-cc20-4f9a-ae2f-eadede0348a5"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("e63a72ad-e90a-4389-b824-6593f0398e18"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("ecb12bcb-17c5-4794-a9ed-919bf74b6057"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: new Guid("ee9e4124-a592-402a-801c-30afee9e6d12"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1ea3eab2-73cb-4dcb-907d-c389767b5ddf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("67faef00-d16b-4c76-b697-9d28be242344"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87b83f1e-7a12-45b3-b7fd-39debb2d21cd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9069183f-a9b0-47b3-a6e6-b9dc00a5a421"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9be91b88-62e2-476e-b20f-63e4be81ef1b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a759c27a-6512-46db-8e6a-5959d122e514"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ab674672-33d2-48e0-a386-a03a0392993e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b46861ff-57d5-4a43-a107-06e5aa04837c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c5a122c0-8913-4fcb-8940-c375dcb9eb94"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d0dae292-3596-496f-8c57-f4d1e0e5f137"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e9801ece-7017-45b7-b2f3-8104f8809b95"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fcdbde43-4964-4b92-a3e7-d207922e84e5"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("0fd876a1-1fe3-4d7a-87a0-f8c9619aea4e"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("13f6f006-055b-43d1-b2df-dda5925dfe84"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("39e9192f-b0eb-49a0-8423-49c8a849faed"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("41186a43-d9b4-4a52-b538-d21962074721"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("4651696c-7eda-4890-85da-47f3a6c3aafb"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("4d5a9899-3e6c-4718-bd27-cc324dfe2bf1"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("667a013f-a872-4bf6-a9c4-b7fde213c147"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("8bdbfe1b-8b70-4d85-8b2c-46a3342d9bed"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("b1500ac1-866d-414e-ae57-f660c2374c88"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("c6f138fb-968c-4e71-9146-453c0e821660"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("e1c7454d-4027-4489-a63a-7894ca9f02d8"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("1324af89-240c-49f3-ac07-4ad154606795"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("1fa9a4da-c6ba-48e7-ba65-75feb5c5f872"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("22dd0f30-9948-49cf-8f40-ffd7e6789e5a"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("37e12d79-4c5e-4c62-ab5c-79011a3b64ae"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("5f0b9126-0f44-411d-bc09-2123267cfe11"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("61b5a81d-c7bf-44ee-87f4-964bbf792e63"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("897082d6-b866-4185-adc9-91f5963e0e96"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("b2bcf755-5b09-4e59-a181-91ead4b01769"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("c17cafc6-6a30-4735-8882-9296c1ca7b58"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("c48a1db4-9abd-4bb7-8d6a-7cca81c40c27"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("c5a40a54-0095-468d-b591-9b1f3c0e297a"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("c7b40bbc-9b72-4a1b-8d45-ecaefbeae4cf"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("d398b698-68fb-4851-a052-d0a1dde087f7"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: new Guid("f7f12e27-5325-4d97-a5c4-bc7a097b507d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("363790e7-8972-4d6e-b52e-4f972546587d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3c2ace5f-dd8e-4499-833a-19d6c41fef63"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6dbf8736-a91c-498b-b04c-c619b7049d9f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8602d049-8d65-4127-a509-6165b4fe68a2"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("866987c8-f122-4a29-a1e9-d78c9ff73f2b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a6151212-5fe3-4d85-b1bb-eda8af4e5f36"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("bb6722c9-b251-4c36-9f8f-8d6f1df89a9d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d15ceca7-1d08-4630-a5fa-f1d2f1e85433"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f4dcc68f-1601-4285-a89a-13ce3c4b4039"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f6b242c6-f3f7-421f-94f1-87a57d602d43"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("fc3256bc-a4b9-4d2f-930d-ad7c8943999a"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("00e37116-8443-4153-b42b-52f4e248b733"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("23330f34-4de4-408f-ae5e-c1a3a3d7f81f"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("2a306035-191f-4d01-ba55-f619e7de3478"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("485abe4a-a261-4e00-aff7-ebba30b73602"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("8669efb1-eb49-42e9-b4fb-79087ec2d346"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("a9147f37-70fb-4bda-b3b0-396916ed3700"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("c62f6ed3-1a06-4bf9-822e-457c721e24dc"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("cfa51756-a574-4267-9a82-a85f549b61b4"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("d49d63d3-0058-43bd-8455-a1453f1b8a13"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("f7386c01-98b0-4b07-b111-4c979fe94cf3"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("f8a4cabf-a489-483e-b7ec-1acbe806b78a"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("1d6a9e28-0696-4694-a26c-a92c23eebd2e"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("29be8955-0ed6-403e-9ea5-92bd92ac70af"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("2e0929ee-9533-4180-91e0-44a52777c43f"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("408d20be-87bb-47d4-ac62-deef1566cd25"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("7bdd9b8a-5108-44da-9126-8d69e67ac5fb"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("8406d02e-4a8f-4dbe-8f4e-ef25849d94a7"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("877ea24c-6bdf-4fcb-934c-6551fae830ee"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("8c6b27a7-ad24-4f1f-bf90-63c94d6485e8"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("97713485-d01c-4f3a-bbce-010f74fe2196"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("c568af14-8ec9-43f5-b044-b78897fec807"));

            migrationBuilder.DeleteData(
                table: "ProductStorages",
                keyColumn: "Id",
                keyValue: new Guid("e24af1d6-5221-4c55-bf23-aa6d594190f2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ce276cc3-dab8-427c-a343-c72d8efb797c"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("1a9ccff8-7bee-4d18-ac0c-41d409c6f5e3"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("4362fb06-b29c-4ce4-8d85-bc9391318ec8"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("4e57b0d4-55f0-4e0f-aa0a-343adbfae571"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("5fd743ad-5a5e-4c9f-87ca-43359fcd8d11"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("7ff0a4c4-95db-4859-9402-41b740fee9d7"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("872bf6a1-32a4-453f-b5bd-41b0ba030583"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("949334a8-1b21-4f62-8628-8896e053076a"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("a86dec5b-b323-4507-86cf-8404176d7513"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("b22e5241-5b21-4f27-aa2c-3d22265ca710"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("c63f0254-a3b9-447b-a1ec-8c6075016edb"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("ee708045-2aa7-4753-8119-f80810e43922"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("01b189df-9bb4-4c17-b89c-0173b9a7af46"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("05ae6002-6774-4b0d-b1b3-84103fc12b20"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("06dc9801-8ca0-46fe-91c2-987ad2ddc4c0"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("0bfa83bc-1fe6-44cd-b997-68cef2d9e2ce"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("0d5eb2c6-07b2-4304-aeb9-c0eef57e9c16"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("124fc7b8-bd91-420b-a952-1233c8e8d809"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("133067a1-851e-4e6f-bb40-380b5360c8f8"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("195411d0-1976-45fb-85dc-5f1e480a1c13"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("197c549d-e4ad-4079-9fc7-798507fa1584"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("1b882aa8-e93a-4c97-9130-565bb408492d"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("1ea72c0a-02df-46b3-ae3f-9c65ff21847a"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("20951727-c745-45ed-b72e-64b038f4a1e0"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("22b71218-c7d2-450b-9c32-a3b1fd402c51"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("238bddaa-f035-4498-8c3a-a7d09770f02b"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("24fe2cd1-7726-4d66-aa5d-bde0abe5f55c"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("26945784-7038-478a-90d7-7c3953a22ce1"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("2756f7d4-f7c8-4a27-98e4-cd65148b8490"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("281dcec9-f180-4120-a197-5b6ba9ce8d23"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("29297066-77d6-435e-8b7b-ab82b1d55f71"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("2c79f08a-f9d8-46a6-a425-d9080ede6120"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("2cfef277-89b8-413a-85df-cb89a52d8844"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("30d2ab1f-2e7e-468f-b0bf-d5cca8619510"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("31010ad9-3eef-4486-be69-cf79fa220f4e"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("31039ac8-b97a-4f64-8d26-c5d745b46c9c"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("33ccf7b6-21a7-4122-b5c8-c707443e916b"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("34a7344f-4080-4f4a-94d0-09b756ca22fa"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("3a7f6ff3-fbcc-4cce-93ff-343b2297bdab"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("3c4eafd4-220c-4c13-a385-a9628e239e09"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("3d13ca59-e842-473d-830e-a718ec75b5df"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("3e77fba5-42a9-4553-a6e9-785f76b69427"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("3f1a2711-67e0-4ef7-8f63-f84332201a93"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("41f30694-489b-41c6-a77d-1e77b92eb69d"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("4632e036-59c1-40da-aaf9-288fef16f0cb"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("4cadc9ed-806c-47ae-8c2c-7a567be005fa"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("4dcf8ea3-e069-4606-8074-b83ea3c66073"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("4e654d40-b7b3-4b39-a63c-75ce391ed09b"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("4f39942d-cc9a-4dfc-a6ec-80f52b575886"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("548cf434-4d3c-4683-af80-58ff6e81685c"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("5578da26-7879-434e-99de-2247dff3489d"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("596d9c54-12c2-4df0-80d8-20da058562a8"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("5cf97fe3-d71b-4e43-aeb2-ebc970bd4a39"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("5e7483b9-35a3-4f82-ade0-c8bac93f5fc8"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("61783746-54bc-442e-b0da-507791d09cf8"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("63176417-d8ce-4479-8169-a59fe7afd975"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("63af598c-cbfb-45f3-acb2-26a4024b8e1e"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("65c2036b-149a-4369-bd60-c3f580694c69"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("68e99e1a-3c6a-42b1-b9d8-6fccd0292341"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("6cecd1c8-2dae-4324-a7d5-4562a3b21d1d"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("6ee3399d-9ceb-4c0b-8e11-c676fc1a5c65"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("731e60a6-8aaa-431e-94b1-d7c40675edf1"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("743dfdc1-31b1-418d-9ae1-d6bbee321986"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("7bfe07e2-e849-442c-9f2b-c8bfe60da3fd"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("7f53ba64-63e1-4a85-b29c-606bb35aac0f"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("807ef838-bd26-4769-86f2-d05796017ac9"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("80d09d5e-01f4-438a-8ad7-f953b76bfa00"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("8c6e3177-0461-45b9-b596-f1383c8ef6dc"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("91a7dedc-cc5a-4c90-b5b0-f617a7c6e2da"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("9231812c-e9a7-4fcd-b702-aff6f87bd6c2"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("95098db8-e8c6-4e73-9fa4-9f36ee2aa31f"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("962ffa72-0fb6-4c0e-8476-8dabd625f486"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("a32fd20b-f2e2-4606-a963-e37fa4a40797"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("a36efeec-342e-497f-b883-e8cd35fe3fd3"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("a4df5d5b-8c6b-46ee-a122-874e9b4a8779"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("a7c45dae-7b28-4d9c-93cb-7a9cc69293f0"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("a96c79b4-d7a0-4035-8084-5585dc31c210"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("ac6dfe6c-bb17-48b6-be51-64a24b61c2ce"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("b65f42b2-7a84-4a89-af88-61627f76fd7a"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("b6d6f10f-8523-4dfd-aebb-61064d51fc73"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("bfd3d2bf-b57e-4083-81f1-06a8b7316fa3"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("c01c41d9-95b9-4063-af77-bf00d92f978a"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("c14118d2-b236-43d6-8283-ca69d85ec1a0"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("c5d0169b-b568-48e9-9aee-88b67a6ad111"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("c76a7e38-de84-402e-8f26-eeba6e80443b"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("cdcb37d0-c82b-47c1-950b-80ca44388ddb"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("ce146adc-983d-47a4-bc02-66a7f36370cb"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("ce4ed7d5-6fe0-44f0-bd60-3a69f22a022c"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("d1888070-ddeb-48e7-aec5-2452e3175473"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("d38b2dec-f11f-459c-a3ae-000aec1fdb00"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("d6aef704-8427-4705-aae1-034df27a6c40"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("db302bec-8b8c-485f-ac07-c52c24723601"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("db3e5024-105d-4df3-a61a-a3079675f81d"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("dc043136-5a05-49c8-8e81-3262e933c133"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("dd20a275-c7e2-4cfb-8eb7-084ce5e508ac"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("df729a3c-2bee-4cd2-b565-bd019e1145c6"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("df7eee66-1b5c-4374-8acc-3eafc68cc9f4"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("e2800853-f9a9-46c3-8b41-42516cac89ec"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("e34c9e00-4d8e-4182-b66c-ac437282dfd7"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("e47dfa00-9302-4af5-9f13-f7e54272dbdf"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("e4887bf4-74f6-4d9e-a7f4-873aa827a0a8"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("e51e7d53-4c5c-4aea-8a5d-5b534b740949"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("e52e628b-b8cf-4c2c-99ff-4f4447f9b606"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("eb23ec35-bfee-4368-904d-d11f5e05e6a0"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("f0275a23-a6a9-4426-ad10-172b1de1df71"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("f2b45ab5-d8b3-4f41-94a1-deb5ffc0a1fe"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("f531f97d-e042-41b0-addf-f98e62cfc87f"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("f59acc10-fba5-48d5-bf4f-3774f8f2b5f9"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("f68c6a27-027b-49dc-acd7-782a5bb336d7"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("f7c00ec7-8de3-4069-b8b7-424143f8196d"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("f9a1117f-3316-4925-bec0-fbda658d6b48"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("fce2bce1-bd94-477c-8087-fa601df8c81f"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("fe8cb582-942e-4d8f-a73d-8bf40e22d0ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4a63b095-d993-4e6f-a933-a658eb18c89b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("92197675-c799-49d2-bb0f-0e65a76b1d35"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("980734ed-b1a2-4e9e-aea2-52f2c9b8ac30"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c1796fbd-1622-4032-9818-c4f49fbd5e2f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("19faf434-f99b-46fd-b223-efab454c795b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2a0aea6a-8858-4264-b279-5c9ad860b9e5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e43b0b5-f2b2-4d74-9e12-7e153e1a95b2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4eaa6ab1-93f0-4635-90a3-58d13c1c1e06"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65d2afc2-5755-418d-941b-396e6addd772"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7919ac33-4eae-409e-ac9b-b49851cd3164"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("865a578f-10dd-4c4e-9c63-eb58cefd74e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("86eb3235-91aa-409d-b199-fba95683a349"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8f68bf06-6ef9-4c49-bec5-d3c9106d5e7d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b5962eb6-0674-4296-9e83-ab3de599bb23"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c5db0d5a-15fc-4e73-b74a-78e378ed3dfa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8708d31-917a-49cf-94b5-8aedc825ebf9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d21132bb-4c91-4007-b697-8b97bd2c2866"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"));

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: new Guid("8dc41dcb-759a-428a-99e2-b0b73c4b0d74"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1ddce2c8-0032-4982-8383-a9b5c29472b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1dfe8cbb-e476-4a4d-b877-c07f149be580"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("51a8768d-590d-4831-978c-6b7960d7f39b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5845db73-d330-4a73-8f17-54c68091115d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8cd0e1ba-01be-4fa3-84b7-cbd9fb5dbdc5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b4c573be-8016-452a-8c21-afedc1f825a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b7470810-5d68-468c-be82-319a1a66b5a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c61ac8a1-9234-410c-889d-4861579cf4c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d23b0da1-4cd7-48b5-aa80-ae4cd1b7609c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f5d12cce-b112-4af2-a139-c20d6383b6d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f6ed49d3-2a5a-44cc-a34b-c4aadc646e82"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("50740698-0960-4fe4-8e77-a6c1942c007d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("73f84fd2-68a9-4d98-9be2-85c55131d709"));

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: new Guid("cc171d60-444b-41be-a417-2172586d1dd8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa9b32af-cb28-4544-997d-efeec184005b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("47b076a3-d798-4702-b6f0-ea8b950d99f3"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("50740698-0960-4fe4-8e77-a6c1942c007d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần", null, null },
                    { new Guid("73f84fd2-68a9-4d98-9be2-85c55131d709"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo", null, null }
                });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Price", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("01b189df-9bb4-4c17-b89c-0173b9a7af46"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("05ae6002-6774-4b0d-b1b3-84103fc12b20"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("06dc9801-8ca0-46fe-91c2-987ad2ddc4c0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("0bfa83bc-1fe6-44cd-b997-68cef2d9e2ce"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("0d5eb2c6-07b2-4304-aeb9-c0eef57e9c16"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("124fc7b8-bd91-420b-a952-1233c8e8d809"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("133067a1-851e-4e6f-bb40-380b5360c8f8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("195411d0-1976-45fb-85dc-5f1e480a1c13"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("197c549d-e4ad-4079-9fc7-798507fa1584"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("1b882aa8-e93a-4c97-9130-565bb408492d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("1ea72c0a-02df-46b3-ae3f-9c65ff21847a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("20951727-c745-45ed-b72e-64b038f4a1e0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("22b71218-c7d2-450b-9c32-a3b1fd402c51"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("238bddaa-f035-4498-8c3a-a7d09770f02b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("24fe2cd1-7726-4d66-aa5d-bde0abe5f55c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("26945784-7038-478a-90d7-7c3953a22ce1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("2756f7d4-f7c8-4a27-98e4-cd65148b8490"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("281dcec9-f180-4120-a197-5b6ba9ce8d23"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("29297066-77d6-435e-8b7b-ab82b1d55f71"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("2c79f08a-f9d8-46a6-a425-d9080ede6120"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("2cfef277-89b8-413a-85df-cb89a52d8844"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("30d2ab1f-2e7e-468f-b0bf-d5cca8619510"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("31010ad9-3eef-4486-be69-cf79fa220f4e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("31039ac8-b97a-4f64-8d26-c5d745b46c9c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("33ccf7b6-21a7-4122-b5c8-c707443e916b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("34a7344f-4080-4f4a-94d0-09b756ca22fa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("3a7f6ff3-fbcc-4cce-93ff-343b2297bdab"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("3c4eafd4-220c-4c13-a385-a9628e239e09"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("3d13ca59-e842-473d-830e-a718ec75b5df"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("3e77fba5-42a9-4553-a6e9-785f76b69427"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("3f1a2711-67e0-4ef7-8f63-f84332201a93"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("41f30694-489b-41c6-a77d-1e77b92eb69d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("4632e036-59c1-40da-aaf9-288fef16f0cb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("4cadc9ed-806c-47ae-8c2c-7a567be005fa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("4dcf8ea3-e069-4606-8074-b83ea3c66073"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("4e654d40-b7b3-4b39-a63c-75ce391ed09b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("4f39942d-cc9a-4dfc-a6ec-80f52b575886"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("548cf434-4d3c-4683-af80-58ff6e81685c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("5578da26-7879-434e-99de-2247dff3489d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("596d9c54-12c2-4df0-80d8-20da058562a8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("5cf97fe3-d71b-4e43-aeb2-ebc970bd4a39"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("5e7483b9-35a3-4f82-ade0-c8bac93f5fc8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("61783746-54bc-442e-b0da-507791d09cf8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("63176417-d8ce-4479-8169-a59fe7afd975"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("63af598c-cbfb-45f3-acb2-26a4024b8e1e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("65c2036b-149a-4369-bd60-c3f580694c69"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("68e99e1a-3c6a-42b1-b9d8-6fccd0292341"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("6cecd1c8-2dae-4324-a7d5-4562a3b21d1d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("6ee3399d-9ceb-4c0b-8e11-c676fc1a5c65"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("731e60a6-8aaa-431e-94b1-d7c40675edf1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("743dfdc1-31b1-418d-9ae1-d6bbee321986"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("7bfe07e2-e849-442c-9f2b-c8bfe60da3fd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("7f53ba64-63e1-4a85-b29c-606bb35aac0f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("807ef838-bd26-4769-86f2-d05796017ac9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("80d09d5e-01f4-438a-8ad7-f953b76bfa00"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("8c6e3177-0461-45b9-b596-f1383c8ef6dc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("8dc41dcb-759a-428a-99e2-b0b73c4b0d74"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("91a7dedc-cc5a-4c90-b5b0-f617a7c6e2da"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("9231812c-e9a7-4fcd-b702-aff6f87bd6c2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("95098db8-e8c6-4e73-9fa4-9f36ee2aa31f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("962ffa72-0fb6-4c0e-8476-8dabd625f486"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("a32fd20b-f2e2-4606-a963-e37fa4a40797"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("a36efeec-342e-497f-b883-e8cd35fe3fd3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("a4df5d5b-8c6b-46ee-a122-874e9b4a8779"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("a7c45dae-7b28-4d9c-93cb-7a9cc69293f0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("a96c79b4-d7a0-4035-8084-5585dc31c210"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("ac6dfe6c-bb17-48b6-be51-64a24b61c2ce"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("b65f42b2-7a84-4a89-af88-61627f76fd7a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("b6d6f10f-8523-4dfd-aebb-61064d51fc73"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("bfd3d2bf-b57e-4083-81f1-06a8b7316fa3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("c01c41d9-95b9-4063-af77-bf00d92f978a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("c14118d2-b236-43d6-8283-ca69d85ec1a0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("c5d0169b-b568-48e9-9aee-88b67a6ad111"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("c76a7e38-de84-402e-8f26-eeba6e80443b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("cdcb37d0-c82b-47c1-950b-80ca44388ddb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("ce146adc-983d-47a4-bc02-66a7f36370cb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("ce4ed7d5-6fe0-44f0-bd60-3a69f22a022c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("d1888070-ddeb-48e7-aec5-2452e3175473"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("d38b2dec-f11f-459c-a3ae-000aec1fdb00"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("d6aef704-8427-4705-aae1-034df27a6c40"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("db302bec-8b8c-485f-ac07-c52c24723601"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("db3e5024-105d-4df3-a61a-a3079675f81d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("dc043136-5a05-49c8-8e81-3262e933c133"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("dd20a275-c7e2-4cfb-8eb7-084ce5e508ac"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("df729a3c-2bee-4cd2-b565-bd019e1145c6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("df7eee66-1b5c-4374-8acc-3eafc68cc9f4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("e2800853-f9a9-46c3-8b41-42516cac89ec"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("e34c9e00-4d8e-4182-b66c-ac437282dfd7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("e47dfa00-9302-4af5-9f13-f7e54272dbdf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("e4887bf4-74f6-4d9e-a7f4-873aa827a0a8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("e51e7d53-4c5c-4aea-8a5d-5b534b740949"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("e52e628b-b8cf-4c2c-99ff-4f4447f9b606"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("eb23ec35-bfee-4368-904d-d11f5e05e6a0"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("f0275a23-a6a9-4426-ad10-172b1de1df71"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("f2b45ab5-d8b3-4f41-94a1-deb5ffc0a1fe"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("f531f97d-e042-41b0-addf-f98e62cfc87f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("f59acc10-fba5-48d5-bf4f-3774f8f2b5f9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("f68c6a27-027b-49dc-acd7-782a5bb336d7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("f7c00ec7-8de3-4069-b8b7-424143f8196d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("f9a1117f-3316-4925-bec0-fbda658d6b48"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("fce2bce1-bd94-477c-8087-fa601df8c81f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null },
                    { new Guid("fe8cb582-942e-4d8f-a73d-8bf40e22d0ff"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, "store", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedAt", "DateOfBirth", "Email", "FirstName", "HashedPassword", "ImageUrl", "IsDeleted", "IsVerify", "LastName", "PhoneNumber", "Role", "UpdatedAt", "VerifyCode" },
                values: new object[,]
                {
                    { new Guid("1ddce2c8-0032-4982-8383-a9b5c29472b7"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan4@gmail.com", "Tan4", "hashed_password_4", null, false, false, "Tran4", null, "User", null, 0 },
                    { new Guid("1dfe8cbb-e476-4a4d-b877-c07f149be580"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan2@gmail.com", "Tan2", "hashed_password_2", null, false, false, "Tran2", null, "User", null, 0 },
                    { new Guid("47b076a3-d798-4702-b6f0-ea8b950d99f3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tan182205@gmail.com", "Tan", "hashed_password_1", null, false, false, "Tran", null, "user", null, 0 },
                    { new Guid("51a8768d-590d-4831-978c-6b7960d7f39b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan6@gmail.com", "Tan6", "hashed_password_6", null, false, false, "Tran6", null, "User", null, 0 },
                    { new Guid("5845db73-d330-4a73-8f17-54c68091115d"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan9@gmail.com", "Tan9", "hashed_password_9", null, false, false, "Tran9", null, "Seller", null, 0 },
                    { new Guid("8cd0e1ba-01be-4fa3-84b7-cbd9fb5dbdc5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan3@gmail.com", "Tan3", "hashed_password_3", null, false, false, "Tran3", null, "Seller", null, 0 },
                    { new Guid("aa9b32af-cb28-4544-997d-efeec184005b"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "tan182206@gmail.com", "Tan", "hashed_password_1", null, false, false, "Tran", null, "user", null, 0 },
                    { new Guid("b4c573be-8016-452a-8c21-afedc1f825a8"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan7@gmail.com", "Tan7", "hashed_password_7", null, false, false, "Tran7", null, "Seller", null, 0 },
                    { new Guid("b7470810-5d68-468c-be82-319a1a66b5a3"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan10@gmail.com", "Tan10", "hashed_password_10", null, false, false, "Tran10", null, "User", null, 0 },
                    { new Guid("c61ac8a1-9234-410c-889d-4861579cf4c6"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan1@gmail.com", "Tan1", "hashed_password_1", null, false, false, "Tran1", null, "Seller", null, 0 },
                    { new Guid("d23b0da1-4cd7-48b5-aa80-ae4cd1b7609c"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan5@gmail.com", "Tan5", "hashed_password_5", null, false, false, "Tran5", null, "Seller", null, 0 },
                    { new Guid("f5d12cce-b112-4af2-a139-c20d6383b6d5"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan0@gmail.com", "Tan0", "hashed_password_0", null, false, false, "Tran0", null, "User", null, 0 },
                    { new Guid("f6ed49d3-2a5a-44cc-a34b-c4aadc646e82"), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Tan8@gmail.com", "Tan8", "hashed_password_8", null, false, false, "Tran8", null, "User", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "TotalAmount", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("34d9819e-62d1-484d-bab9-2feac2df8f40"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("1dfe8cbb-e476-4a4d-b877-c07f149be580") },
                    { new Guid("3738387d-ef95-4512-8f59-8ae98c7fa352"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("f6ed49d3-2a5a-44cc-a34b-c4aadc646e82") },
                    { new Guid("5ab90acd-008e-4828-b41c-0e663a3b4d0d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("51a8768d-590d-4831-978c-6b7960d7f39b") },
                    { new Guid("82af644e-2046-4d9e-ae26-c1185a42d522"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("8cd0e1ba-01be-4fa3-84b7-cbd9fb5dbdc5") },
                    { new Guid("837ce73a-7abf-4b09-b96c-1689cc81a65f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("f5d12cce-b112-4af2-a139-c20d6383b6d5") },
                    { new Guid("9adb245e-a086-49b4-ac41-45f47133f441"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("5845db73-d330-4a73-8f17-54c68091115d") },
                    { new Guid("a6bdf16c-784f-4272-b871-16fa3a5267a4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("1ddce2c8-0032-4982-8383-a9b5c29472b7") },
                    { new Guid("b87809cf-cc20-4f9a-ae2f-eadede0348a5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("b7470810-5d68-468c-be82-319a1a66b5a3") },
                    { new Guid("e63a72ad-e90a-4389-b824-6593f0398e18"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("b4c573be-8016-452a-8c21-afedc1f825a8") },
                    { new Guid("ecb12bcb-17c5-4794-a9ed-919bf74b6057"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("d23b0da1-4cd7-48b5-aa80-ae4cd1b7609c") },
                    { new Guid("ee9e4124-a592-402a-801c-30afee9e6d12"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, 10000m, null, new Guid("c61ac8a1-9234-410c-889d-4861579cf4c6") }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ParentId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("4a63b095-d993-4e6f-a933-a658eb18c89b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao", new Guid("73f84fd2-68a9-4d98-9be2-85c55131d709"), null },
                    { new Guid("92197675-c799-49d2-bb0f-0e65a76b1d35"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Jean", new Guid("50740698-0960-4fe4-8e77-a6c1942c007d"), null },
                    { new Guid("ab674672-33d2-48e0-a386-a03a0392993e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo ba lỗ", new Guid("73f84fd2-68a9-4d98-9be2-85c55131d709"), null },
                    { new Guid("b46861ff-57d5-4a43-a107-06e5aa04837c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Kaki", new Guid("50740698-0960-4fe4-8e77-a6c1942c007d"), null }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "CreatedAt", "IsDeleted", "Status", "TotalAmount", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("363790e7-8972-4d6e-b52e-4f972546587d"), "Bien hoa, Dong Nai2", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed2", 10002m, null, new Guid("c61ac8a1-9234-410c-889d-4861579cf4c6") },
                    { new Guid("3c2ace5f-dd8e-4499-833a-19d6c41fef63"), "Bien hoa, Dong Nai5", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed5", 10005m, null, new Guid("1ddce2c8-0032-4982-8383-a9b5c29472b7") },
                    { new Guid("6dbf8736-a91c-498b-b04c-c619b7049d9f"), "Bien hoa, Dong Nai1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed1", 10001m, null, new Guid("f5d12cce-b112-4af2-a139-c20d6383b6d5") },
                    { new Guid("8602d049-8d65-4127-a509-6165b4fe68a2"), "Bien hoa, Dong Nai8", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed8", 10008m, null, new Guid("b4c573be-8016-452a-8c21-afedc1f825a8") },
                    { new Guid("866987c8-f122-4a29-a1e9-d78c9ff73f2b"), "Bien hoa, Dong Nai3", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed3", 10003m, null, new Guid("1dfe8cbb-e476-4a4d-b877-c07f149be580") },
                    { new Guid("980734ed-b1a2-4e9e-aea2-52f2c9b8ac30"), "Bien hoa, Dong Nai", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed", 10000m, null, new Guid("aa9b32af-cb28-4544-997d-efeec184005b") },
                    { new Guid("a6151212-5fe3-4d85-b1bb-eda8af4e5f36"), "Bien hoa, Dong Nai7", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed7", 10007m, null, new Guid("51a8768d-590d-4831-978c-6b7960d7f39b") },
                    { new Guid("bb6722c9-b251-4c36-9f8f-8d6f1df89a9d"), "Bien hoa, Dong Nai4", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed4", 10004m, null, new Guid("8cd0e1ba-01be-4fa3-84b7-cbd9fb5dbdc5") },
                    { new Guid("c1796fbd-1622-4032-9818-c4f49fbd5e2f"), "Bien hoa, Dong Nai", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed", 10000m, null, new Guid("aa9b32af-cb28-4544-997d-efeec184005b") },
                    { new Guid("d15ceca7-1d08-4630-a5fa-f1d2f1e85433"), "Bien hoa, Dong Nai10", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed10", 10010m, null, new Guid("5845db73-d330-4a73-8f17-54c68091115d") },
                    { new Guid("f4dcc68f-1601-4285-a89a-13ce3c4b4039"), "Bien hoa, Dong Nai11", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed11", 10011m, null, new Guid("b7470810-5d68-468c-be82-319a1a66b5a3") },
                    { new Guid("f6b242c6-f3f7-421f-94f1-87a57d602d43"), "Bien hoa, Dong Nai6", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed6", 10006m, null, new Guid("d23b0da1-4cd7-48b5-aa80-ae4cd1b7609c") },
                    { new Guid("fc3256bc-a4b9-4d2f-930d-ad7c8943999a"), "Bien hoa, Dong Nai9", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Completed9", 10009m, null, new Guid("f6ed49d3-2a5a-44cc-a34b-c4aadc646e82") }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "CompanyAddress", "CompanyName", "CreatedAt", "IsDeleted", "TaxCode", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("1a9ccff8-7bee-4d18-ac0c-41d409c6f5e3"), "123 Main St, Cityville5", "ABC Company5", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE5", null, new Guid("1ddce2c8-0032-4982-8383-a9b5c29472b7") },
                    { new Guid("4362fb06-b29c-4ce4-8d85-bc9391318ec8"), "123 Main St, Cityville11", "ABC Company11", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE11", null, new Guid("b7470810-5d68-468c-be82-319a1a66b5a3") },
                    { new Guid("4e57b0d4-55f0-4e0f-aa0a-343adbfae571"), "123 Main St, Cityville4", "ABC Company4", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE4", null, new Guid("8cd0e1ba-01be-4fa3-84b7-cbd9fb5dbdc5") },
                    { new Guid("5fd743ad-5a5e-4c9f-87ca-43359fcd8d11"), "123 Main St, Cityville10", "ABC Company10", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE10", null, new Guid("5845db73-d330-4a73-8f17-54c68091115d") },
                    { new Guid("7ff0a4c4-95db-4859-9402-41b740fee9d7"), "123 Main St, Cityville8", "ABC Company8", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE8", null, new Guid("b4c573be-8016-452a-8c21-afedc1f825a8") },
                    { new Guid("872bf6a1-32a4-453f-b5bd-41b0ba030583"), "123 Main St, Cityville1", "ABC Company1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE1", null, new Guid("f5d12cce-b112-4af2-a139-c20d6383b6d5") },
                    { new Guid("949334a8-1b21-4f62-8628-8896e053076a"), "123 Main St, Cityville6", "ABC Company6", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE6", null, new Guid("d23b0da1-4cd7-48b5-aa80-ae4cd1b7609c") },
                    { new Guid("a86dec5b-b323-4507-86cf-8404176d7513"), "123 Main St, Cityville3", "ABC Company3", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE3", null, new Guid("1dfe8cbb-e476-4a4d-b877-c07f149be580") },
                    { new Guid("b22e5241-5b21-4f27-aa2c-3d22265ca710"), "123 Main St, Cityville2", "ABC Company2", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE2", null, new Guid("c61ac8a1-9234-410c-889d-4861579cf4c6") },
                    { new Guid("c63f0254-a3b9-447b-a1ec-8c6075016edb"), "123 Main St, Cityville9", "ABC Company9", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE9", null, new Guid("f6ed49d3-2a5a-44cc-a34b-c4aadc646e82") },
                    { new Guid("cc171d60-444b-41be-a417-2172586d1dd8"), "123 Main St, Cityville", "ABC Company", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE123", null, new Guid("47b076a3-d798-4702-b6f0-ea8b950d99f3") },
                    { new Guid("ee708045-2aa7-4753-8119-f80810e43922"), "123 Main St, Cityville7", "ABC Company7", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "TAXCODE7", null, new Guid("51a8768d-590d-4831-978c-6b7960d7f39b") }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ParentId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1ea3eab2-73cb-4dcb-907d-c389767b5ddf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Jean3", new Guid("92197675-c799-49d2-bb0f-0e65a76b1d35"), null },
                    { new Guid("67faef00-d16b-4c76-b697-9d28be242344"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao10", new Guid("4a63b095-d993-4e6f-a933-a658eb18c89b"), null },
                    { new Guid("87b83f1e-7a12-45b3-b7fd-39debb2d21cd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Jean5", new Guid("92197675-c799-49d2-bb0f-0e65a76b1d35"), null },
                    { new Guid("9069183f-a9b0-47b3-a6e6-b9dc00a5a421"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Jean7", new Guid("92197675-c799-49d2-bb0f-0e65a76b1d35"), null },
                    { new Guid("9be91b88-62e2-476e-b20f-63e4be81ef1b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Jean1", new Guid("92197675-c799-49d2-bb0f-0e65a76b1d35"), null },
                    { new Guid("a759c27a-6512-46db-8e6a-5959d122e514"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao2", new Guid("4a63b095-d993-4e6f-a933-a658eb18c89b"), null },
                    { new Guid("c5a122c0-8913-4fcb-8940-c375dcb9eb94"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao6", new Guid("4a63b095-d993-4e6f-a933-a658eb18c89b"), null },
                    { new Guid("d0dae292-3596-496f-8c57-f4d1e0e5f137"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Quần Jean9", new Guid("92197675-c799-49d2-bb0f-0e65a76b1d35"), null },
                    { new Guid("e9801ece-7017-45b7-b2f3-8104f8809b95"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao4", new Guid("4a63b095-d993-4e6f-a933-a658eb18c89b"), null },
                    { new Guid("fcdbde43-4964-4b92-a3e7-d207922e84e5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "Áo thể thao8", new Guid("4a63b095-d993-4e6f-a933-a658eb18c89b"), null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "Name", "Price", "SellerId", "UpdatedAt", "UrlImage" },
                values: new object[,]
                {
                    { new Guid("19faf434-f99b-46fd-b223-efab454c795b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Quần jeans nữ dáng ôm, tôn dáng, chất liệu denim co giãn, phù hợp cho mọi dịp.", false, "Quần Jeans Nữ", 399000m, new Guid("cc171d60-444b-41be-a417-2172586d1dd8"), null, "https://example.com/images/quan_jeans_nu.jpg" },
                    { new Guid("2a0aea6a-8858-4264-b279-5c9ad860b9e5"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt3", false, "T-Shirt3", 199000m, new Guid("cc171d60-444b-41be-a417-2172586d1dd8"), null, "" },
                    { new Guid("2e43b0b5-f2b2-4d74-9e12-7e153e1a95b2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt4", false, "T-Shirt4", 199000m, new Guid("cc171d60-444b-41be-a417-2172586d1dd8"), null, "" },
                    { new Guid("4eaa6ab1-93f0-4635-90a3-58d13c1c1e06"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt0", false, "T-Shirt0", 199000m, new Guid("cc171d60-444b-41be-a417-2172586d1dd8"), null, "" },
                    { new Guid("65d2afc2-5755-418d-941b-396e6addd772"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Áo sơ mi nam công sở, thiết kế hiện đại, chất liệu vải cao cấp, thoáng mát.", false, "Áo Sơ Mi Nam", 299000m, new Guid("cc171d60-444b-41be-a417-2172586d1dd8"), null, "https://example.com/images/ao_so_mi_nam.jpg" },
                    { new Guid("7919ac33-4eae-409e-ac9b-b49851cd3164"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt6", false, "T-Shirt6", 199000m, new Guid("cc171d60-444b-41be-a417-2172586d1dd8"), null, "" },
                    { new Guid("865a578f-10dd-4c4e-9c63-eb58cefd74e2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt9", false, "T-Shirt9", 199000m, new Guid("cc171d60-444b-41be-a417-2172586d1dd8"), null, "" },
                    { new Guid("86eb3235-91aa-409d-b199-fba95683a349"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt10", false, "T-Shirt10", 199000m, new Guid("cc171d60-444b-41be-a417-2172586d1dd8"), null, "" },
                    { new Guid("8f68bf06-6ef9-4c49-bec5-d3c9106d5e7d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt7", false, "T-Shirt7", 199000m, new Guid("cc171d60-444b-41be-a417-2172586d1dd8"), null, "" },
                    { new Guid("b5962eb6-0674-4296-9e83-ab3de599bb23"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt2", false, "T-Shirt2", 199000m, new Guid("cc171d60-444b-41be-a417-2172586d1dd8"), null, "" },
                    { new Guid("c5db0d5a-15fc-4e73-b74a-78e378ed3dfa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt1", false, "T-Shirt1", 199000m, new Guid("cc171d60-444b-41be-a417-2172586d1dd8"), null, "" },
                    { new Guid("c8708d31-917a-49cf-94b5-8aedc825ebf9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt5", false, "T-Shirt5", 199000m, new Guid("cc171d60-444b-41be-a417-2172586d1dd8"), null, "" },
                    { new Guid("ce276cc3-dab8-427c-a343-c72d8efb797c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Chân váy nữ xòe, thiết kế trẻ trung, chất liệu vải mềm mại, phù hợp cho mọi dịp.", false, "Chân Váy Nữ", 249000m, new Guid("cc171d60-444b-41be-a417-2172586d1dd8"), null, "https://example.com/images/chan_vay_nu.jpg" },
                    { new Guid("d21132bb-4c91-4007-b697-8b97bd2c2866"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic T-Shirt8", false, "T-Shirt8", 199000m, new Guid("cc171d60-444b-41be-a417-2172586d1dd8"), null, "" },
                    { new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Áo thun nam chất liệu cotton cao cấp, thoáng mát, phù hợp cho mọi hoạt động hàng ngày.", false, "Áo Thun Nam", 199000m, new Guid("cc171d60-444b-41be-a417-2172586d1dd8"), null, "https://example.com/images/ao_thun_nam.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "ProductId", "TotalInStock", "TotalSell", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0fd876a1-1fe3-4d7a-87a0-f8c9619aea4e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("2e43b0b5-f2b2-4d74-9e12-7e153e1a95b2"), 1000m, 1000m, null },
                    { new Guid("13f6f006-055b-43d1-b2df-dda5925dfe84"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("4eaa6ab1-93f0-4635-90a3-58d13c1c1e06"), 1000m, 1000m, null },
                    { new Guid("39e9192f-b0eb-49a0-8423-49c8a849faed"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("c8708d31-917a-49cf-94b5-8aedc825ebf9"), 1000m, 1000m, null },
                    { new Guid("41186a43-d9b4-4a52-b538-d21962074721"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("7919ac33-4eae-409e-ac9b-b49851cd3164"), 1000m, 1000m, null },
                    { new Guid("4651696c-7eda-4890-85da-47f3a6c3aafb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("86eb3235-91aa-409d-b199-fba95683a349"), 1000m, 1000m, null },
                    { new Guid("4d5a9899-3e6c-4718-bd27-cc324dfe2bf1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("b5962eb6-0674-4296-9e83-ab3de599bb23"), 1000m, 1000m, null },
                    { new Guid("667a013f-a872-4bf6-a9c4-b7fde213c147"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("865a578f-10dd-4c4e-9c63-eb58cefd74e2"), 1000m, 1000m, null },
                    { new Guid("8bdbfe1b-8b70-4d85-8b2c-46a3342d9bed"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("8f68bf06-6ef9-4c49-bec5-d3c9106d5e7d"), 1000m, 1000m, null },
                    { new Guid("b1500ac1-866d-414e-ae57-f660c2374c88"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("d21132bb-4c91-4007-b697-8b97bd2c2866"), 1000m, 1000m, null },
                    { new Guid("c6f138fb-968c-4e71-9146-453c0e821660"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("c5db0d5a-15fc-4e73-b74a-78e378ed3dfa"), 1000m, 1000m, null },
                    { new Guid("e1c7454d-4027-4489-a63a-7894ca9f02d8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("2a0aea6a-8858-4264-b279-5c9ad860b9e5"), 1000m, 1000m, null }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "OrderId", "ProductId", "Quantity", "UnitPrice", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1324af89-240c-49f3-ac07-4ad154606795"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("980734ed-b1a2-4e9e-aea2-52f2c9b8ac30"), new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), 2, 19990000m, null },
                    { new Guid("1fa9a4da-c6ba-48e7-ba65-75feb5c5f872"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("980734ed-b1a2-4e9e-aea2-52f2c9b8ac30"), new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), 2, 19990000m, null },
                    { new Guid("22dd0f30-9948-49cf-8f40-ffd7e6789e5a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("980734ed-b1a2-4e9e-aea2-52f2c9b8ac30"), new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), 2, 19990000m, null },
                    { new Guid("37e12d79-4c5e-4c62-ab5c-79011a3b64ae"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("980734ed-b1a2-4e9e-aea2-52f2c9b8ac30"), new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), 2, 19990000m, null },
                    { new Guid("5f0b9126-0f44-411d-bc09-2123267cfe11"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("980734ed-b1a2-4e9e-aea2-52f2c9b8ac30"), new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), 2, 19990000m, null },
                    { new Guid("61b5a81d-c7bf-44ee-87f4-964bbf792e63"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("980734ed-b1a2-4e9e-aea2-52f2c9b8ac30"), new Guid("19faf434-f99b-46fd-b223-efab454c795b"), 1, 39990000m, null },
                    { new Guid("897082d6-b866-4185-adc9-91f5963e0e96"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("980734ed-b1a2-4e9e-aea2-52f2c9b8ac30"), new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), 2, 19990000m, null },
                    { new Guid("b2bcf755-5b09-4e59-a181-91ead4b01769"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("980734ed-b1a2-4e9e-aea2-52f2c9b8ac30"), new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), 2, 19990000m, null },
                    { new Guid("c17cafc6-6a30-4735-8882-9296c1ca7b58"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("980734ed-b1a2-4e9e-aea2-52f2c9b8ac30"), new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), 2, 19990000m, null },
                    { new Guid("c48a1db4-9abd-4bb7-8d6a-7cca81c40c27"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("980734ed-b1a2-4e9e-aea2-52f2c9b8ac30"), new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), 2, 19990000m, null },
                    { new Guid("c5a40a54-0095-468d-b591-9b1f3c0e297a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("980734ed-b1a2-4e9e-aea2-52f2c9b8ac30"), new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), 2, 19990000m, null },
                    { new Guid("c7b40bbc-9b72-4a1b-8d45-ecaefbeae4cf"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("c1796fbd-1622-4032-9818-c4f49fbd5e2f"), new Guid("65d2afc2-5755-418d-941b-396e6addd772"), 1, 29990000m, null },
                    { new Guid("d398b698-68fb-4851-a052-d0a1dde087f7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("980734ed-b1a2-4e9e-aea2-52f2c9b8ac30"), new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), 2, 19990000m, null },
                    { new Guid("f7f12e27-5325-4d97-a5c4-bc7a097b507d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("980734ed-b1a2-4e9e-aea2-52f2c9b8ac30"), new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), 2, 19990000m, null }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "IsDeleted", "ProductID", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00e37116-8443-4153-b42b-52f4e248b733"), new Guid("73f84fd2-68a9-4d98-9be2-85c55131d709"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), null },
                    { new Guid("23330f34-4de4-408f-ae5e-c1a3a3d7f81f"), new Guid("73f84fd2-68a9-4d98-9be2-85c55131d709"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), null },
                    { new Guid("2a306035-191f-4d01-ba55-f619e7de3478"), new Guid("73f84fd2-68a9-4d98-9be2-85c55131d709"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), null },
                    { new Guid("485abe4a-a261-4e00-aff7-ebba30b73602"), new Guid("73f84fd2-68a9-4d98-9be2-85c55131d709"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), null },
                    { new Guid("8669efb1-eb49-42e9-b4fb-79087ec2d346"), new Guid("73f84fd2-68a9-4d98-9be2-85c55131d709"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), null },
                    { new Guid("a9147f37-70fb-4bda-b3b0-396916ed3700"), new Guid("73f84fd2-68a9-4d98-9be2-85c55131d709"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), null },
                    { new Guid("c62f6ed3-1a06-4bf9-822e-457c721e24dc"), new Guid("73f84fd2-68a9-4d98-9be2-85c55131d709"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), null },
                    { new Guid("cfa51756-a574-4267-9a82-a85f549b61b4"), new Guid("73f84fd2-68a9-4d98-9be2-85c55131d709"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), null },
                    { new Guid("d49d63d3-0058-43bd-8455-a1453f1b8a13"), new Guid("73f84fd2-68a9-4d98-9be2-85c55131d709"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), null },
                    { new Guid("f7386c01-98b0-4b07-b111-4c979fe94cf3"), new Guid("73f84fd2-68a9-4d98-9be2-85c55131d709"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), null },
                    { new Guid("f8a4cabf-a489-483e-b7ec-1acbe806b78a"), new Guid("73f84fd2-68a9-4d98-9be2-85c55131d709"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), null }
                });

            migrationBuilder.InsertData(
                table: "ProductStorages",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "ProductId", "StorageId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1d6a9e28-0696-4694-a26c-a92c23eebd2e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), new Guid("8dc41dcb-759a-428a-99e2-b0b73c4b0d74"), null },
                    { new Guid("29be8955-0ed6-403e-9ea5-92bd92ac70af"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), new Guid("8dc41dcb-759a-428a-99e2-b0b73c4b0d74"), null },
                    { new Guid("2e0929ee-9533-4180-91e0-44a52777c43f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), new Guid("8dc41dcb-759a-428a-99e2-b0b73c4b0d74"), null },
                    { new Guid("408d20be-87bb-47d4-ac62-deef1566cd25"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), new Guid("8dc41dcb-759a-428a-99e2-b0b73c4b0d74"), null },
                    { new Guid("7bdd9b8a-5108-44da-9126-8d69e67ac5fb"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), new Guid("8dc41dcb-759a-428a-99e2-b0b73c4b0d74"), null },
                    { new Guid("8406d02e-4a8f-4dbe-8f4e-ef25849d94a7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), new Guid("8dc41dcb-759a-428a-99e2-b0b73c4b0d74"), null },
                    { new Guid("877ea24c-6bdf-4fcb-934c-6551fae830ee"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), new Guid("8dc41dcb-759a-428a-99e2-b0b73c4b0d74"), null },
                    { new Guid("8c6b27a7-ad24-4f1f-bf90-63c94d6485e8"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), new Guid("8dc41dcb-759a-428a-99e2-b0b73c4b0d74"), null },
                    { new Guid("97713485-d01c-4f3a-bbce-010f74fe2196"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), new Guid("8dc41dcb-759a-428a-99e2-b0b73c4b0d74"), null },
                    { new Guid("c568af14-8ec9-43f5-b044-b78897fec807"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), new Guid("8dc41dcb-759a-428a-99e2-b0b73c4b0d74"), null },
                    { new Guid("e24af1d6-5221-4c55-bf23-aa6d594190f2"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("efc6239c-8134-4f9f-98bf-ea212ec1b4bd"), new Guid("8dc41dcb-759a-428a-99e2-b0b73c4b0d74"), null }
                });
        }
    }
}
