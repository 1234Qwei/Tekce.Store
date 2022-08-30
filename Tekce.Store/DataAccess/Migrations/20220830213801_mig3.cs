using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserClaims",
                table: "UserClaims");

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("002d1bab-d8c0-4b82-b477-6fdd0fe14a31"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("01d8c4d4-527f-47af-9160-62b63e605766"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("02a3fd49-2d87-4a6d-afd2-74f9cc473bbe"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("0354ac58-fb26-4a5c-b06c-dd46ba4335ad"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("0416f629-874a-453d-b802-fa76adcf96ee"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("07e96291-384a-46de-81ad-553bafc7a8ec"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("0967ec4e-2449-4560-b3ff-51afc9ef763b"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("0c0a58d8-e1a7-4e63-92d3-8533825294c8"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("0cd7498e-2944-4d53-a2c4-8cd4ea2e787b"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("1150fc79-61b8-4ce1-a97b-59ef5762325e"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("11f62045-4ba9-48b3-a171-3e9f92547913"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("14609896-12ea-41ff-88eb-c7129289e369"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("14a8d8bd-1d28-4b81-8441-dfea6bbc4f1e"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("14ff4b4d-86b7-46d5-a1f1-b5e4b85e1e87"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("1a1816a8-441f-4289-88ac-4814873d038d"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("1d0c59c9-f973-48ae-a0de-838481b980bb"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("1d962571-477b-428b-a072-5498af6c0ef3"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("1e267617-72f0-4c91-9864-6a95b1d12620"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("2411730b-3b4b-4420-84ba-d32287a0cee5"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("254786bb-dde1-4d87-8519-19c0fd457074"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("296bb66a-dcbd-4d09-85c8-fa014353c2c8"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("302caeca-0cf5-4f44-8d65-97bd1fe6c602"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("3365de33-fee3-484c-913b-781823eebb09"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("3abf54ef-1daf-44b0-98cc-947bfee33095"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("3d19caa0-9152-4aec-850e-b617ccb47d8e"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("3e6c6696-91ae-48ad-9d9a-1bf9430cb820"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("403ec277-9c8a-4d88-b1dc-464370c8eb00"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("40c14bc9-12fa-4bae-bda3-634d0120bbde"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("4121cac2-d28a-4e35-96b0-6bac66f15434"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("41e4613a-4bfa-47cd-a3d9-629324f261f2"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("461ca27c-abc6-4a52-8024-6d0c79087aa9"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("471c88fb-faf7-462a-804c-0ad8956a57ad"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("4a68ebbc-d280-4a78-b574-900a2a24973e"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("4d0aaa92-be60-435e-bb77-60fa0835443d"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("4d8761f2-0c72-49e0-84e2-d531a7358917"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("4e16972b-539d-4a32-b910-d560c45bcce7"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("4e553fe7-6520-44e2-80aa-f140d760d1cf"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("4f3316fe-03d8-4b25-93c7-4ad265cd25d1"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("4fac4098-9cef-4280-90e8-a3422aaef4cf"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("4fdb4b35-3071-4d65-aade-38b01b20f4b3"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("506f240e-54b1-4115-8643-f4c9b06063c8"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("510a4171-7156-404d-a174-6498ceb6337a"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("54ee27b1-3a9b-4c82-9e39-285d625d0240"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("5506b383-74d8-41af-b9d5-c9cd50047284"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("5635afd8-29a5-46f9-8566-46c69655be4b"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("56f71d7e-3bd3-4d5f-a1c8-81040a7f85a5"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("579f5fa1-7aac-45c0-a369-b0d999c0bb25"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("5816408f-7be1-447a-bbf8-f6f30821592e"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("59211049-fa7d-4612-84ef-f4d4b16d1f19"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("5eeb8d00-e0a5-4883-8303-9903ebe44668"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("6055fabe-cf36-4f25-8306-f9b1dd097a3f"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("611a7193-572d-4cf6-a3d0-e3f402e6ead8"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("677b3476-1456-4d4e-a520-f26ce518e757"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("67d27494-8470-451b-9564-d76e3fb55c95"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("6944ff7a-c9e7-4911-96b3-9c94d429cfd1"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("6c1029e8-1c1f-40ab-a21a-a44dff7844b8"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("70039507-03b6-43c5-a920-90e0db21c35d"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("722737c0-a367-4b01-88e6-2567cd9e23ae"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("73029ebd-6109-4a19-9d93-c68a43225230"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("738670fd-f6ff-409a-8e05-9c183dfc40cd"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("74ef87c3-5656-4878-b222-fa2d692d959c"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("778cdc10-3ca4-435c-8009-36b38f69c0aa"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("7c0995d7-7e19-40b1-8713-c240b2c64434"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("7c36e242-8c7c-436b-8118-ba54464814eb"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("81619f2b-3eef-411d-9ea7-eed42d94df7b"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("8580fa0a-5fd6-4440-b72c-b6abff839457"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("87cd3cca-c958-4e58-af5a-187dc538f097"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("8d08630e-ece6-4abe-bd1b-6d36ffd6d79c"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("8d571bcf-4820-47bd-9900-ee8f5b4b76c1"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("8dbeb033-e614-4a26-866c-2380c517536c"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("92d3e2e4-ea5d-4879-a9a4-8eada5e36273"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("93c1d888-0be1-4dab-9549-4a6bf9e984eb"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("95a5f750-8778-4364-9858-2d03a76648a0"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("964d2ed8-4b00-43fc-ab83-a60025f7b08f"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("99b3e8bc-d295-4404-84c4-af62b3192d5a"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("9dd5c4e1-bb2a-4d15-952a-38a72230bba4"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("a10b3664-5a75-45b1-af92-b8ebaaa91218"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("a3895021-af51-4e0b-8fd7-4c41e8fe8751"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("a3c51ba4-51d1-41c1-bf57-0c6e57c84d45"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("a4369f43-dbb6-4972-b8f7-f1d4d01690af"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("a7150155-793d-494d-bec9-d2d95ce749de"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("a8368de1-39e1-4c3b-b5ee-a80417348638"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("a984c2db-4051-4349-8955-03fa40e643c3"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("abd9bb0d-a379-4a65-ab86-6f96a3ee6a05"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("ac487452-7f61-45a8-b6db-17fa8c53f6ce"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("aca08521-45d0-4f23-abc7-35b5b2ab1318"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("acab7199-fcff-436f-817c-9363d57817be"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("ad87cdb4-b6ed-475f-a44c-0dc529f2f359"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("b143620d-229f-448f-b3ff-e0398802d3f9"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("b165e40d-09c7-4b8c-8f16-530cadb1c988"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("b37f5a99-72f2-4e01-8e21-85e007e323bc"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("b59a33e9-190f-4840-94e6-b1417550b1c0"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("b7157871-5e95-4417-bb35-0b4ee4728f6b"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("bb79c2d4-14a6-41bf-bfb4-dc9112a4c77a"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("bf970cc8-98e4-4490-808e-d24d754b3797"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("c1f71880-3ae9-45e8-91e9-8561f444f8f3"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("c2074d47-85c1-46fd-8877-3ab45126cb85"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("c2259639-2dc6-480b-a5c7-8bc5466a1641"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("c3897da7-1a3d-4511-8678-62968f19645e"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("c47b22f7-79a2-4d6e-a8e1-8f35f21c83df"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("c4c722c5-96b8-43e4-9be8-0b8796e806fb"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("c572b6d2-9c73-4dbd-a398-623b4d98bfe3"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("c5eba2af-0f97-4bac-889e-dd08af75d297"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("c6a86a37-f36a-4a80-98b6-9562d0608f30"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("c6b863fb-81d7-4033-b112-56c114d80424"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("c70ce3bb-a065-4b5e-a9d0-ec8592620c30"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("c781c5c0-8b51-4512-9f5a-e37f1534c962"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("ca7a062e-8597-4214-8c5e-2a55ee2f63b7"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("ca8962ef-3ef0-4004-9652-713cd5ab86fb"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("caaf4484-2fb2-45ca-9f83-87ed7a631565"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("cce410b9-b67b-4d88-a00f-819ee96285af"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("ce30863a-9a54-4acf-96bb-97756bebe231"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("d079d7eb-4433-42c9-8fa5-d1f8e8b695ac"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("d0cc8d54-6e82-4b59-b73d-7fb752136a7f"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("d14dec4e-d5f9-4681-bd84-efd5de612a7e"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("d63e3ce4-e009-424e-a7b1-70b4e10f8fc2"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("d7025b80-e199-40ed-95fc-79455a453dd9"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("d90110e5-a187-4e57-af69-ac51d671fbeb"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("d9915917-7333-4388-b382-668d92782d9b"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("da76f0f8-5eb8-4172-b402-f2a06b21b8ef"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("dc06a4bf-cddc-4f47-8bf0-0733d935c330"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("dc42c697-100d-47b8-9bd6-ff0453590ec0"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("dd932ae9-3dab-475d-bc74-118022e0c576"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("deac6338-bd14-41b9-9c0a-2bcc98b7fd50"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e0a85369-976b-46f5-8803-39d919289d60"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e1361114-5ac8-4812-b6aa-5d0def965755"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e3d88728-cc21-4b5a-bbb2-abced0d2bad3"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e7413391-365a-4a8d-be4d-1d5956e2bf25"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e8185d7a-b522-40fb-91d3-f444ebd1c245"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e88cbafc-ff05-447f-8005-768cbeea480d"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e93dcf53-ba5f-4640-bf16-2d23a3b1f1ad"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("ecb9df34-71b0-40ee-b505-c3b18e8e9913"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("ecf2caf4-783b-4668-bcee-bbd9f48ad28a"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("f1bee5c5-4c7e-4b84-9e62-89b3354e5669"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("f3cb58e8-7cff-42f4-bc12-5185ff1d46dd"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("f7ef1446-6fe2-4913-ba18-027451d918db"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("f7f3fef4-7d90-413b-b4ce-b4a9815e556f"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("feb245f5-5a26-4b0c-b850-74664446cad7"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Users",
                type: "timestamp without time zone",
                nullable: true,
                defaultValue: new DateTime(2022, 8, 31, 0, 38, 0, 942, DateTimeKind.Local).AddTicks(2419),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 8, 31, 0, 34, 8, 349, DateTimeKind.Local).AddTicks(2811));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserClaims",
                table: "UserClaims",
                columns: new[] { "Id", "UserId", "ClaimId" });

            migrationBuilder.InsertData(
                table: "Translates",
                columns: new[] { "Id", "Changed", "ChangedBy", "Code", "Created", "CreatedBy", "LangId", "Value" },
                values: new object[,]
                {
                    { new Guid("be3f33b3-6c9f-483c-92ec-ee10555d0111"), null, null, "Login", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Giriş" },
                    { new Guid("86501228-939c-4b77-8593-3b0587cdd7dd"), null, null, "Code", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kod" },
                    { new Guid("558003bf-4696-40d5-a8ed-9ba1d2d82701"), null, null, "ConfirmPassword", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Confirm Password" },
                    { new Guid("c7004893-0f89-467a-b6fe-37662f735bf1"), null, null, "ConfirmPassword", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Parolayı Doğrula" },
                    { new Guid("c64afa03-92dd-4c1b-a925-ac94ba7efba7"), null, null, "Notes", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Notes" },
                    { new Guid("703bb537-fa7f-44a3-aeda-3ded566e44c6"), null, null, "Notes", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Notlar" },
                    { new Guid("70f9d16e-f0fe-434a-a222-8f114582165e"), null, null, "Address", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Address" },
                    { new Guid("bf603a6d-d225-4156-8f33-61a00e0af3cc"), null, null, "Address", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Adres" },
                    { new Guid("746963b5-4980-4700-86bc-d319a0e5c967"), null, null, "FullName", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Full Name" },
                    { new Guid("b96944e0-cef0-420b-86bc-7863c9ae9434"), null, null, "FullName", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Tam Adı" },
                    { new Guid("8f41ccfb-e5c6-4233-b5e4-3cfde0eb696e"), null, null, "GroupName", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Group Name" },
                    { new Guid("71e82a4f-427d-4d60-a65c-a04d8faa1e09"), null, null, "GroupName", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Grup Adı" },
                    { new Guid("bfd88872-cbc6-4f05-9d74-06bca2f3ed3d"), null, null, "Save", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Save" },
                    { new Guid("e2cb61a9-c070-48e6-90dc-d84b117fe5dd"), null, null, "Save", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kaydet" },
                    { new Guid("e30886fc-2145-4645-87c9-8dc350b18cc2"), null, null, "ChangePassword", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Change Password" },
                    { new Guid("6cf53938-1b61-4c58-b1af-ed85fe0060b1"), null, null, "Code", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Code" },
                    { new Guid("ce009b40-146b-4378-99b7-19153a024346"), null, null, "ChangePassword", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Parola Değiştir" },
                    { new Guid("b5987a6c-6583-46af-8edc-5e541283bfe0"), null, null, "NewPassword", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Yeni Parola:" },
                    { new Guid("a60a627d-f714-4347-b399-227f4188f11d"), null, null, "Unknown", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Unknown!" },
                    { new Guid("ac7cb685-8b9d-4355-8354-c15019546c61"), null, null, "Unknown", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Bilinmiyor!" },
                    { new Guid("9c917898-9a44-4589-b44e-9509617a4e4a"), null, null, "TokenProviderException", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Token Provider cannot be empty!" },
                    { new Guid("0d8e183d-c3d6-4d95-8e4c-94b0c0640f7b"), null, null, "TokenProviderException", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Token Provider boş olamaz!" },
                    { new Guid("79f815dd-77ac-4e4b-b5a2-3e9e414fa582"), null, null, "TrueButCellPhone", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "The information is correct. Cell phone is required." },
                    { new Guid("1dd638d2-33ec-424e-b1c9-5fc0359e721a"), null, null, "TrueButCellPhone", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Bilgiler doğru. Cep telefonu gerekiyor." },
                    { new Guid("d0b2034c-42ae-41d6-b76b-25d5e97634a8"), null, null, "SmsServiceNotFound", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Unable to Reach SMS Service." },
                    { new Guid("a616b8f5-f300-455a-80c6-2a59baefd713"), null, null, "SmsServiceNotFound", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "SMS Servisine Ulaşılamıyor." },
                    { new Guid("3eca76db-4dc4-4e56-9a57-4e2e3771e2d9"), null, null, "InvalidCode", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "You Entered An Invalid Code!" },
                    { new Guid("2485d259-f6af-4c3d-ab15-73f9f109e4cd"), null, null, "InvalidCode", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Geçersiz Bir Kod Girdiniz!" },
                    { new Guid("ae161f8e-0b78-4c19-92b0-c8915e051d84"), null, null, "SendPassword", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Your new password has been sent to your e-mail address." },
                    { new Guid("dbdd5473-104c-4fab-944b-baf43de627d1"), null, null, "SendPassword", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Yeni Parolanız E-Posta Adresinize Gönderildi." },
                    { new Guid("18a87c90-3e72-4402-b6a5-fcf1ec137b03"), null, null, "PasswordSpecialCharacter", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Must Contain At Least 1 Symbol!" },
                    { new Guid("b95900c4-6aba-4932-81a2-dc2ac9ad2075"), null, null, "NewPassword", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "New Password:" },
                    { new Guid("0890b6ce-ed6c-4813-870f-c8b22f5e6917"), null, null, "Alias", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Görünen Ad" },
                    { new Guid("8cf00c5a-ad2a-48ad-af9f-90288eda9acd"), null, null, "Alias", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Alias" },
                    { new Guid("bf3a355d-f6cf-4d86-be0a-ff16275cb054"), null, null, "Description", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Açıklama" },
                    { new Guid("90469c8b-f0a6-4ed0-b2cf-2210456cd30f"), null, null, "LogList", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "LogList" },
                    { new Guid("d9dc8181-7c40-41f0-a34b-8093c73bff33"), null, null, "LogList", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "İşlem Kütüğü" },
                    { new Guid("05392f6f-2753-4c78-930c-8d78efe5a306"), null, null, "TranslateList", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Translate List" },
                    { new Guid("b16e2a8c-3ebc-43ed-ad7d-aa6f1fa26bd4"), null, null, "TranslateList", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Dil Çeviri Listesi" },
                    { new Guid("356c871c-6fb8-4234-8133-3ff0106ed81b"), null, null, "LanguageList", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Language List" },
                    { new Guid("545572e0-6c8b-452d-8ae4-2399f983499b"), null, null, "LanguageList", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Dil Listesi" },
                    { new Guid("cc9a2f36-78f7-4955-b18e-3ef1140e0f54"), null, null, "OperationClaimList", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "OperationClaim List" },
                    { new Guid("fc3dd97a-8bbe-46e0-90ea-667032e03505"), null, null, "OperationClaimList", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Yetki Listesi" },
                    { new Guid("d94081ec-22ea-4427-80ae-b1b3e38d8f67"), null, null, "UserList", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "User List" },
                    { new Guid("6005aa17-bab0-4762-9d32-58c84aab27f8"), null, null, "UserList", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kullanıcı Listesi" },
                    { new Guid("e6b36020-0656-47f0-897f-330ae436d6e8"), null, null, "Add", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Add" },
                    { new Guid("c4329a81-8a81-4287-b5eb-623db60248d0"), null, null, "Add", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Ekle" },
                    { new Guid("3db92173-0d31-4922-ba21-514f54bee8b5"), null, null, "GrupPermissions", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Grup Permissions" },
                    { new Guid("27d933d6-e2cf-42cb-8562-97d5b819d74f"), null, null, "GrupPermissions", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Grup Yetkileri" },
                    { new Guid("fa7e3ba4-fe3b-4894-8c7b-c45ca5952400"), null, null, "GroupList", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Group List" },
                    { new Guid("2233452b-652c-4173-93c3-615e1647b222"), null, null, "GroupList", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Grup Listesi" },
                    { new Guid("75a6c940-a341-4838-b2f6-cc851b4a41b1"), null, null, "Permissions", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "İzinler" },
                    { new Guid("6a947e2d-edef-4845-ba08-3196d722ea93"), null, null, "Description", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Description" },
                    { new Guid("29f273b3-d502-42e0-9f5d-ec6077e305d1"), null, null, "Value", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Değer" },
                    { new Guid("3ea7820d-e7de-45a3-b13c-c4b391d3cbb4"), null, null, "Value", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Value" },
                    { new Guid("1b05bf77-fff8-4d25-8794-514a00c8f94e"), null, null, "LangCode", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Dil Kodu" },
                    { new Guid("8abf87b8-8a43-4cbc-aa65-916d0050a8b3"), null, null, "LangCode", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Lang Code" },
                    { new Guid("0854c82f-0028-4035-b6b2-4b9f82fa7447"), null, null, "Name", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Adı" },
                    { new Guid("13a3a01e-2c9e-4330-93b6-22e62325920b"), null, null, "PasswordSpecialCharacter", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "En Az 1 Simge İçermelidir!" },
                    { new Guid("e88a145d-cbe0-49c0-a654-2d07a7bf525a"), null, null, "Name", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Name" },
                    { new Guid("80277a61-bf6c-4eb4-b9fd-46a1bd933472"), null, null, "MobilePhones", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Mobile Phone" },
                    { new Guid("8c078a6c-8897-4eaa-8f0d-b26e5608a219"), null, null, "NoRecordsFound", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kayıt Bulunamadı" },
                    { new Guid("d18d0dec-2621-4b6c-8ff1-7f3316442ff3"), null, null, "NoRecordsFound", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "No Records Found" },
                    { new Guid("5b6f85fc-c728-4689-9cce-7cee87283327"), null, null, "Required", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Bu alan zorunludur!" },
                    { new Guid("1d6a9c7f-ae97-4b0d-9cac-deb807127738"), null, null, "Required", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "This field is required!" },
                    { new Guid("8aaabb13-738d-4b93-bc46-b9ee596bd956"), null, null, "Permissions", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Permissions" },
                    { new Guid("b43c33d5-32d6-4903-ba03-425fe947bbb0"), null, null, "MobilePhones", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Cep Telefonu" },
                    { new Guid("0d2dea8b-b841-44a2-bf82-854ed0924f56"), null, null, "PasswordDigit", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "It Must Contain At Least 1 Digit!" },
                    { new Guid("eb86185f-b4dc-4512-8011-68f666aeb07e"), null, null, "PasswordDigit", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "En Az 1 Rakam İçermelidir!" },
                    { new Guid("175ab9ab-040d-4f21-b6d4-e028c7d635d7"), null, null, "PasswordLowercaseLetter", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Must Contain At Least 1 Lowercase Letter!" },
                    { new Guid("83d1bcd5-bc6f-4082-8731-a2c65ffa9b73"), null, null, "Added", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Successfully Added." },
                    { new Guid("b71c815c-96af-4681-878a-e54a725c8585"), null, null, "Added", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Başarıyla Eklendi." },
                    { new Guid("f0bb88f2-903d-4e20-866a-6b441d555f2b"), null, null, "AppMenu", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Application" },
                    { new Guid("9b0da6ea-034f-4c3e-bdf2-996303bb538d"), null, null, "AppMenu", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Uygulama" },
                    { new Guid("3140658e-f9fa-48f8-a62e-bd133e1b7338"), null, null, "Management", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Management" },
                    { new Guid("c03bec61-7b52-49f3-8501-640fe9b64574"), null, null, "Management", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Yönetim" },
                    { new Guid("87dcabf9-6870-4a32-a09e-144527463db9"), null, null, "TranslateWords", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Translate Words" },
                    { new Guid("e4f973a2-e586-421e-afaf-b183ec193e55"), null, null, "TranslateWords", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Dil Çevirileri" },
                    { new Guid("5be7ee03-24eb-47fe-84d4-68307f195594"), null, null, "Languages", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Languages" },
                    { new Guid("e8018f8a-667d-46b7-9c57-3f840a4337a6"), null, null, "Languages", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Diller" },
                    { new Guid("8b3a2f74-817d-4996-8ce7-0166805ed49f"), null, null, "OperationClaim", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Operation Claim" },
                    { new Guid("b70a5dfa-4707-42aa-8fd6-67323fa2c69c"), null, null, "OperationClaim", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Operasyon Yetkileri" },
                    { new Guid("3f80afb7-791c-494b-8ef7-0f13e12e3e92"), null, null, "Groups", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Groups" },
                    { new Guid("f78efd7c-9df1-41f8-9a9b-5172b4557e39"), null, null, "Users", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Users" },
                    { new Guid("928e360f-15ec-4d5d-a57c-5d6cf92417d6"), null, null, "Create", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Create" },
                    { new Guid("c84ed780-4b2c-44f0-a74a-71135ef1ced1"), null, null, "UsersClaims", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "User's Claims" },
                    { new Guid("c151e878-d7dc-4be6-a7e2-09abe1ca8e12"), null, null, "UsersGroups", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "User's Groups" },
                    { new Guid("4ebb9247-dbba-4d91-b581-d4f34637416a"), null, null, "Email", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "E posta" },
                    { new Guid("8d175127-5f09-49f8-9aac-166e333dd3c1"), null, null, "Password", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Parola" },
                    { new Guid("d3f9ba74-4d52-4f44-baa5-403f0b774fb5"), null, null, "Update", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Güncelle" },
                    { new Guid("2a4c2ab9-9033-4196-bbd9-cbbdd38df365"), null, null, "Delete", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Sil" },
                    { new Guid("f315b994-67c6-44cb-b064-6c931d2d93cf"), null, null, "UsersGroups", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kullanıcının Grupları" },
                    { new Guid("ad7b867c-a8cc-4950-b35e-356e4f712ecd"), null, null, "UsersClaims", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kullanıcının Yetkileri" },
                    { new Guid("c4e6f9a1-8c92-478d-8b18-32cde96c783d"), null, null, "Updated", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Başarıyla Güncellendi." },
                    { new Guid("5112ac1e-cb1a-409a-91f3-97c8735ed1eb"), null, null, "Create", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Yeni" },
                    { new Guid("38bae803-b3c5-4085-9658-0b39bd53a3dd"), null, null, "Groups", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Gruplar" },
                    { new Guid("c096cc86-a172-4e6c-a175-b0d50c54c2cc"), null, null, "Login", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Login" },
                    { new Guid("24c87c97-4d81-48f8-b2e7-c54dd5c1c8b6"), null, null, "Email", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Email" },
                    { new Guid("4804c8ec-a815-4a83-a528-c5bddb27be79"), null, null, "Password", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Password" },
                    { new Guid("4a5fb2ab-7897-42e3-b0d1-03f4682c7245"), null, null, "Update", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Update" },
                    { new Guid("242444d8-0709-4086-b7b2-6aa9b3604e6a"), null, null, "Delete", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Delete" },
                    { new Guid("c8d34e9a-200b-4b47-b397-eda352d12460"), null, null, "Users", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kullanıcılar" },
                    { new Guid("acb4782a-3d2e-4958-afae-f786d570b617"), null, null, "DeleteConfirm", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Emin misiniz?" },
                    { new Guid("410be70b-b0fd-49b0-8540-8fd3189055f8"), null, null, "Updated", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Successfully Updated." },
                    { new Guid("fbf82790-9e79-4797-a199-159afc9ea980"), null, null, "Deleted", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Successfully Deleted." },
                    { new Guid("fe93699d-e78c-46b1-ba18-24616c4e538d"), null, null, "PasswordLowercaseLetter", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "En Az 1 Küçük Harf İçermelidir!" },
                    { new Guid("e6a23e57-34f7-4b23-98ef-039f865a0fcf"), null, null, "PasswordUppercaseLetter", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Must Contain At Least 1 Capital Letter!" },
                    { new Guid("17ee2827-cb55-4013-8a98-cd16b0b85e33"), null, null, "PasswordUppercaseLetter", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "En Az 1 Büyük Harf İçermelidir!" },
                    { new Guid("6da7a474-ef83-48aa-bcdb-bbc00f7f5502"), null, null, "PasswordLength", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Must be at least 8 characters long! " },
                    { new Guid("61479139-ad9e-4fc7-ba8c-062aaed11c3b"), null, null, "PasswordLength", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Minimum 8 Karakter Uzunluğunda Olmalıdır!" },
                    { new Guid("e75a07b3-fd42-4448-ac8f-2a9aae23a6e6"), null, null, "PasswordEmpty", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Password can not be empty!" },
                    { new Guid("f946d22c-17e9-4ec8-8d2e-f6d82f91f041"), null, null, "PasswordEmpty", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Parola boş olamaz!" },
                    { new Guid("723d3920-7dab-4c76-81ab-485169554b76"), null, null, "CID", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Citizenship Number" },
                    { new Guid("a322344c-21e1-4649-bf25-d8e1f613bf87"), null, null, "CID", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Vatandaşlık No" },
                    { new Guid("ee682d8e-cb1e-469a-8107-639e8f8b56ab"), null, null, "WrongCID", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Citizenship Number Not Found In Our System. Please Create New Registration!" },
                    { new Guid("2e762770-1a0d-47ce-a403-7f469afa852b"), null, null, "WrongCID", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Vatandaşlık No Sistemimizde Bulunamadı. Lütfen Yeni Kayıt Oluşturun!" },
                    { new Guid("f76b2aa2-3979-444d-b2fe-dca218e750ba"), null, null, "NameAlreadyExist", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "The Object You Are Trying To Create Already Exists." },
                    { new Guid("1da2d933-e5ef-42a8-bba0-c8c8346a1437"), null, null, "NameAlreadyExist", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Oluşturmaya Çalıştığınız Nesne Zaten Var." },
                    { new Guid("30ccab6b-b1f0-4a04-9cc9-80e62e01334c"), null, null, "SendMobileCode", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Please Enter The Code Sent To You By SMS!" },
                    { new Guid("70f44a94-85e4-403e-adde-8c21b10f8c4c"), null, null, "SendMobileCode", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Lütfen Size SMS Olarak Gönderilen Kodu Girin!" },
                    { new Guid("fd4e82b9-d0a4-437a-9fb8-18b7f077cb33"), null, null, "SuccessfulLogin", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Login to the system is successful." },
                    { new Guid("8a1c7d42-b929-443e-8157-f801f787a592"), null, null, "SuccessfulLogin", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Sisteme giriş başarılı." },
                    { new Guid("fed9b57c-6931-4ac7-9f24-dd33746c61d6"), null, null, "OperationClaimExists", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Bu operasyon izni zaten mevcut." },
                    { new Guid("68e50cd6-1e27-44ec-8124-ade1aa0d8dcd"), null, null, "OperationClaimExists", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "This operation permit already exists." },
                    { new Guid("4b2a2f97-ad27-4dec-8756-7d362beda395"), null, null, "StringLengthMustBeGreaterThanThree", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Lütfen En Az 3 Karakterden Oluşan Bir İfade Girin." },
                    { new Guid("bf83a360-5b65-4597-b414-c35f8d37afc1"), null, null, "StringLengthMustBeGreaterThanThree", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Please Enter A Phrase Of At Least 3 Characters." },
                    { new Guid("66cba36d-87bf-43e8-b879-0e468b305c89"), null, null, "CouldNotBeVerifyCid", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kimlik No Doğrulanamadı." },
                    { new Guid("306241ba-3f50-4745-be38-595356cc1160"), null, null, "CouldNotBeVerifyCid", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Could not be verify Citizen Id" },
                    { new Guid("732bd376-96e0-41a1-85e8-551dd5a62b3c"), null, null, "Deleted", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Başarıyla Silindi." },
                    { new Guid("4325dc8f-cb78-4296-8be2-f9b81dac6b3d"), null, null, "VerifyCid", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kimlik No Doğrulandı." },
                    { new Guid("ea01ab9a-7a0c-44b6-85cd-feb9a8cbdb94"), null, null, "AuthorizationsDenied", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Yetkiniz olmayan bir alana girmeye çalıştığınız tespit edildi." },
                    { new Guid("acdb0ae8-901f-4a9d-99eb-2566fda69e56"), null, null, "AuthorizationsDenied", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "It has been detected that you are trying to enter an area that you do not have authorization." },
                    { new Guid("bf77e8e2-7657-43f3-af25-89b0fc8522b1"), null, null, "UserNotFound", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kimlik Bilgileri Doğrulanamadı. Lütfen Yeni Kayıt Ekranını kullanın." },
                    { new Guid("52d81953-5cc7-45f0-bd23-b010a18dc163"), null, null, "UserNotFound", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Credentials Could Not Verify. Please use the New Registration Screen." },
                    { new Guid("acb327b1-360b-453b-8413-67dd5b94b79d"), null, null, "PasswordError", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kimlik Bilgileri Doğrulanamadı, Kullanıcı adı ve/veya parola hatalı." },
                    { new Guid("b012a2ce-60e8-49f0-b420-f215b460c17a"), null, null, "PasswordError", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Credentials Failed to Authenticate, Username and / or password incorrect." },
                    { new Guid("0821831a-6465-440f-ade1-55cb408018cc"), null, null, "VerifyCid", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Verify Citizen Id" },
                    { new Guid("9b1b85ca-b5d8-4a84-9be0-7be5ad8ab8a6"), null, null, "DeleteConfirm", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Are you sure?" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserClaims",
                table: "UserClaims");

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("05392f6f-2753-4c78-930c-8d78efe5a306"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("0821831a-6465-440f-ade1-55cb408018cc"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("0854c82f-0028-4035-b6b2-4b9f82fa7447"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("0890b6ce-ed6c-4813-870f-c8b22f5e6917"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("0d2dea8b-b841-44a2-bf82-854ed0924f56"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("0d8e183d-c3d6-4d95-8e4c-94b0c0640f7b"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("13a3a01e-2c9e-4330-93b6-22e62325920b"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("175ab9ab-040d-4f21-b6d4-e028c7d635d7"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("17ee2827-cb55-4013-8a98-cd16b0b85e33"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("18a87c90-3e72-4402-b6a5-fcf1ec137b03"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("1b05bf77-fff8-4d25-8794-514a00c8f94e"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("1d6a9c7f-ae97-4b0d-9cac-deb807127738"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("1da2d933-e5ef-42a8-bba0-c8c8346a1437"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("1dd638d2-33ec-424e-b1c9-5fc0359e721a"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("2233452b-652c-4173-93c3-615e1647b222"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("242444d8-0709-4086-b7b2-6aa9b3604e6a"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("2485d259-f6af-4c3d-ab15-73f9f109e4cd"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("24c87c97-4d81-48f8-b2e7-c54dd5c1c8b6"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("27d933d6-e2cf-42cb-8562-97d5b819d74f"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("29f273b3-d502-42e0-9f5d-ec6077e305d1"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("2a4c2ab9-9033-4196-bbd9-cbbdd38df365"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("2e762770-1a0d-47ce-a403-7f469afa852b"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("306241ba-3f50-4745-be38-595356cc1160"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("30ccab6b-b1f0-4a04-9cc9-80e62e01334c"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("3140658e-f9fa-48f8-a62e-bd133e1b7338"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("356c871c-6fb8-4234-8133-3ff0106ed81b"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("38bae803-b3c5-4085-9658-0b39bd53a3dd"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("3db92173-0d31-4922-ba21-514f54bee8b5"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("3ea7820d-e7de-45a3-b13c-c4b391d3cbb4"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("3eca76db-4dc4-4e56-9a57-4e2e3771e2d9"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("3f80afb7-791c-494b-8ef7-0f13e12e3e92"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("410be70b-b0fd-49b0-8540-8fd3189055f8"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("4325dc8f-cb78-4296-8be2-f9b81dac6b3d"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("4804c8ec-a815-4a83-a528-c5bddb27be79"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("4a5fb2ab-7897-42e3-b0d1-03f4682c7245"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("4b2a2f97-ad27-4dec-8756-7d362beda395"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("4ebb9247-dbba-4d91-b581-d4f34637416a"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("5112ac1e-cb1a-409a-91f3-97c8735ed1eb"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("52d81953-5cc7-45f0-bd23-b010a18dc163"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("545572e0-6c8b-452d-8ae4-2399f983499b"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("558003bf-4696-40d5-a8ed-9ba1d2d82701"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("5b6f85fc-c728-4689-9cce-7cee87283327"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("5be7ee03-24eb-47fe-84d4-68307f195594"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("6005aa17-bab0-4762-9d32-58c84aab27f8"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("61479139-ad9e-4fc7-ba8c-062aaed11c3b"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("66cba36d-87bf-43e8-b879-0e468b305c89"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("68e50cd6-1e27-44ec-8124-ade1aa0d8dcd"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("6a947e2d-edef-4845-ba08-3196d722ea93"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("6cf53938-1b61-4c58-b1af-ed85fe0060b1"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("6da7a474-ef83-48aa-bcdb-bbc00f7f5502"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("703bb537-fa7f-44a3-aeda-3ded566e44c6"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("70f44a94-85e4-403e-adde-8c21b10f8c4c"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("70f9d16e-f0fe-434a-a222-8f114582165e"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("71e82a4f-427d-4d60-a65c-a04d8faa1e09"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("723d3920-7dab-4c76-81ab-485169554b76"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("732bd376-96e0-41a1-85e8-551dd5a62b3c"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("746963b5-4980-4700-86bc-d319a0e5c967"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("75a6c940-a341-4838-b2f6-cc851b4a41b1"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("79f815dd-77ac-4e4b-b5a2-3e9e414fa582"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("80277a61-bf6c-4eb4-b9fd-46a1bd933472"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("83d1bcd5-bc6f-4082-8731-a2c65ffa9b73"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("86501228-939c-4b77-8593-3b0587cdd7dd"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("87dcabf9-6870-4a32-a09e-144527463db9"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("8a1c7d42-b929-443e-8157-f801f787a592"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("8aaabb13-738d-4b93-bc46-b9ee596bd956"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("8abf87b8-8a43-4cbc-aa65-916d0050a8b3"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("8b3a2f74-817d-4996-8ce7-0166805ed49f"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("8c078a6c-8897-4eaa-8f0d-b26e5608a219"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("8cf00c5a-ad2a-48ad-af9f-90288eda9acd"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("8d175127-5f09-49f8-9aac-166e333dd3c1"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("8f41ccfb-e5c6-4233-b5e4-3cfde0eb696e"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("90469c8b-f0a6-4ed0-b2cf-2210456cd30f"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("928e360f-15ec-4d5d-a57c-5d6cf92417d6"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("9b0da6ea-034f-4c3e-bdf2-996303bb538d"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("9b1b85ca-b5d8-4a84-9be0-7be5ad8ab8a6"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("9c917898-9a44-4589-b44e-9509617a4e4a"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("a322344c-21e1-4649-bf25-d8e1f613bf87"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("a60a627d-f714-4347-b399-227f4188f11d"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("a616b8f5-f300-455a-80c6-2a59baefd713"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("ac7cb685-8b9d-4355-8354-c15019546c61"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("acb327b1-360b-453b-8413-67dd5b94b79d"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("acb4782a-3d2e-4958-afae-f786d570b617"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("acdb0ae8-901f-4a9d-99eb-2566fda69e56"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("ad7b867c-a8cc-4950-b35e-356e4f712ecd"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("ae161f8e-0b78-4c19-92b0-c8915e051d84"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("b012a2ce-60e8-49f0-b420-f215b460c17a"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("b16e2a8c-3ebc-43ed-ad7d-aa6f1fa26bd4"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("b43c33d5-32d6-4903-ba03-425fe947bbb0"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("b5987a6c-6583-46af-8edc-5e541283bfe0"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("b70a5dfa-4707-42aa-8fd6-67323fa2c69c"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("b71c815c-96af-4681-878a-e54a725c8585"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("b95900c4-6aba-4932-81a2-dc2ac9ad2075"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("b96944e0-cef0-420b-86bc-7863c9ae9434"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("be3f33b3-6c9f-483c-92ec-ee10555d0111"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("bf3a355d-f6cf-4d86-be0a-ff16275cb054"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("bf603a6d-d225-4156-8f33-61a00e0af3cc"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("bf77e8e2-7657-43f3-af25-89b0fc8522b1"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("bf83a360-5b65-4597-b414-c35f8d37afc1"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("bfd88872-cbc6-4f05-9d74-06bca2f3ed3d"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("c03bec61-7b52-49f3-8501-640fe9b64574"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("c096cc86-a172-4e6c-a175-b0d50c54c2cc"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("c151e878-d7dc-4be6-a7e2-09abe1ca8e12"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("c4329a81-8a81-4287-b5eb-623db60248d0"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("c4e6f9a1-8c92-478d-8b18-32cde96c783d"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("c64afa03-92dd-4c1b-a925-ac94ba7efba7"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("c7004893-0f89-467a-b6fe-37662f735bf1"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("c84ed780-4b2c-44f0-a74a-71135ef1ced1"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("c8d34e9a-200b-4b47-b397-eda352d12460"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("cc9a2f36-78f7-4955-b18e-3ef1140e0f54"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("ce009b40-146b-4378-99b7-19153a024346"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("d0b2034c-42ae-41d6-b76b-25d5e97634a8"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("d18d0dec-2621-4b6c-8ff1-7f3316442ff3"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("d3f9ba74-4d52-4f44-baa5-403f0b774fb5"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("d94081ec-22ea-4427-80ae-b1b3e38d8f67"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("d9dc8181-7c40-41f0-a34b-8093c73bff33"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("dbdd5473-104c-4fab-944b-baf43de627d1"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e2cb61a9-c070-48e6-90dc-d84b117fe5dd"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e30886fc-2145-4645-87c9-8dc350b18cc2"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e4f973a2-e586-421e-afaf-b183ec193e55"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e6a23e57-34f7-4b23-98ef-039f865a0fcf"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e6b36020-0656-47f0-897f-330ae436d6e8"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e75a07b3-fd42-4448-ac8f-2a9aae23a6e6"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e8018f8a-667d-46b7-9c57-3f840a4337a6"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e88a145d-cbe0-49c0-a654-2d07a7bf525a"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("ea01ab9a-7a0c-44b6-85cd-feb9a8cbdb94"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("eb86185f-b4dc-4512-8011-68f666aeb07e"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("ee682d8e-cb1e-469a-8107-639e8f8b56ab"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("f0bb88f2-903d-4e20-866a-6b441d555f2b"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("f315b994-67c6-44cb-b064-6c931d2d93cf"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("f76b2aa2-3979-444d-b2fe-dca218e750ba"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("f78efd7c-9df1-41f8-9a9b-5172b4557e39"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("f946d22c-17e9-4ec8-8d2e-f6d82f91f041"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("fa7e3ba4-fe3b-4894-8c7b-c45ca5952400"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("fbf82790-9e79-4797-a199-159afc9ea980"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("fc3dd97a-8bbe-46e0-90ea-667032e03505"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("fd4e82b9-d0a4-437a-9fb8-18b7f077cb33"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("fe93699d-e78c-46b1-ba18-24616c4e538d"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("fed9b57c-6931-4ac7-9f24-dd33746c61d6"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Users",
                type: "timestamp without time zone",
                nullable: true,
                defaultValue: new DateTime(2022, 8, 31, 0, 34, 8, 349, DateTimeKind.Local).AddTicks(2811),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 8, 31, 0, 38, 0, 942, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserClaims",
                table: "UserClaims",
                columns: new[] { "UserId", "ClaimId" });

            migrationBuilder.InsertData(
                table: "Translates",
                columns: new[] { "Id", "Changed", "ChangedBy", "Code", "Created", "CreatedBy", "LangId", "Value" },
                values: new object[,]
                {
                    { new Guid("54ee27b1-3a9b-4c82-9e39-285d625d0240"), null, null, "Login", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Giriş" },
                    { new Guid("ca7a062e-8597-4214-8c5e-2a55ee2f63b7"), null, null, "Code", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kod" },
                    { new Guid("a7150155-793d-494d-bec9-d2d95ce749de"), null, null, "ConfirmPassword", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Confirm Password" },
                    { new Guid("8d571bcf-4820-47bd-9900-ee8f5b4b76c1"), null, null, "ConfirmPassword", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Parolayı Doğrula" },
                    { new Guid("73029ebd-6109-4a19-9d93-c68a43225230"), null, null, "Notes", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Notes" },
                    { new Guid("dc06a4bf-cddc-4f47-8bf0-0733d935c330"), null, null, "Notes", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Notlar" },
                    { new Guid("1d0c59c9-f973-48ae-a0de-838481b980bb"), null, null, "Address", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Address" },
                    { new Guid("02a3fd49-2d87-4a6d-afd2-74f9cc473bbe"), null, null, "Address", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Adres" },
                    { new Guid("4fac4098-9cef-4280-90e8-a3422aaef4cf"), null, null, "FullName", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Full Name" },
                    { new Guid("70039507-03b6-43c5-a920-90e0db21c35d"), null, null, "FullName", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Tam Adı" },
                    { new Guid("95a5f750-8778-4364-9858-2d03a76648a0"), null, null, "GroupName", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Group Name" },
                    { new Guid("510a4171-7156-404d-a174-6498ceb6337a"), null, null, "GroupName", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Grup Adı" },
                    { new Guid("e0a85369-976b-46f5-8803-39d919289d60"), null, null, "Save", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Save" },
                    { new Guid("b7157871-5e95-4417-bb35-0b4ee4728f6b"), null, null, "Save", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kaydet" },
                    { new Guid("3d19caa0-9152-4aec-850e-b617ccb47d8e"), null, null, "ChangePassword", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Change Password" },
                    { new Guid("2411730b-3b4b-4420-84ba-d32287a0cee5"), null, null, "Code", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Code" },
                    { new Guid("feb245f5-5a26-4b0c-b850-74664446cad7"), null, null, "ChangePassword", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Parola Değiştir" },
                    { new Guid("8580fa0a-5fd6-4440-b72c-b6abff839457"), null, null, "NewPassword", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Yeni Parola:" },
                    { new Guid("738670fd-f6ff-409a-8e05-9c183dfc40cd"), null, null, "Unknown", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Unknown!" },
                    { new Guid("caaf4484-2fb2-45ca-9f83-87ed7a631565"), null, null, "Unknown", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Bilinmiyor!" },
                    { new Guid("da76f0f8-5eb8-4172-b402-f2a06b21b8ef"), null, null, "TokenProviderException", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Token Provider cannot be empty!" },
                    { new Guid("579f5fa1-7aac-45c0-a369-b0d999c0bb25"), null, null, "TokenProviderException", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Token Provider boş olamaz!" },
                    { new Guid("6944ff7a-c9e7-4911-96b3-9c94d429cfd1"), null, null, "TrueButCellPhone", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "The information is correct. Cell phone is required." },
                    { new Guid("1d962571-477b-428b-a072-5498af6c0ef3"), null, null, "TrueButCellPhone", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Bilgiler doğru. Cep telefonu gerekiyor." },
                    { new Guid("f7ef1446-6fe2-4913-ba18-027451d918db"), null, null, "SmsServiceNotFound", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Unable to Reach SMS Service." },
                    { new Guid("ecb9df34-71b0-40ee-b505-c3b18e8e9913"), null, null, "SmsServiceNotFound", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "SMS Servisine Ulaşılamıyor." },
                    { new Guid("59211049-fa7d-4612-84ef-f4d4b16d1f19"), null, null, "InvalidCode", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "You Entered An Invalid Code!" },
                    { new Guid("677b3476-1456-4d4e-a520-f26ce518e757"), null, null, "InvalidCode", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Geçersiz Bir Kod Girdiniz!" },
                    { new Guid("f3cb58e8-7cff-42f4-bc12-5185ff1d46dd"), null, null, "SendPassword", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Your new password has been sent to your e-mail address." },
                    { new Guid("4e553fe7-6520-44e2-80aa-f140d760d1cf"), null, null, "SendPassword", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Yeni Parolanız E-Posta Adresinize Gönderildi." },
                    { new Guid("ad87cdb4-b6ed-475f-a44c-0dc529f2f359"), null, null, "PasswordSpecialCharacter", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Must Contain At Least 1 Symbol!" },
                    { new Guid("41e4613a-4bfa-47cd-a3d9-629324f261f2"), null, null, "NewPassword", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "New Password:" },
                    { new Guid("403ec277-9c8a-4d88-b1dc-464370c8eb00"), null, null, "Alias", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Görünen Ad" },
                    { new Guid("4d8761f2-0c72-49e0-84e2-d531a7358917"), null, null, "Alias", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Alias" },
                    { new Guid("c3897da7-1a3d-4511-8678-62968f19645e"), null, null, "Description", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Açıklama" },
                    { new Guid("0354ac58-fb26-4a5c-b06c-dd46ba4335ad"), null, null, "LogList", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "LogList" },
                    { new Guid("93c1d888-0be1-4dab-9549-4a6bf9e984eb"), null, null, "LogList", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "İşlem Kütüğü" },
                    { new Guid("8d08630e-ece6-4abe-bd1b-6d36ffd6d79c"), null, null, "TranslateList", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Translate List" },
                    { new Guid("254786bb-dde1-4d87-8519-19c0fd457074"), null, null, "TranslateList", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Dil Çeviri Listesi" },
                    { new Guid("deac6338-bd14-41b9-9c0a-2bcc98b7fd50"), null, null, "LanguageList", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Language List" },
                    { new Guid("964d2ed8-4b00-43fc-ab83-a60025f7b08f"), null, null, "LanguageList", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Dil Listesi" },
                    { new Guid("302caeca-0cf5-4f44-8d65-97bd1fe6c602"), null, null, "OperationClaimList", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "OperationClaim List" },
                    { new Guid("3e6c6696-91ae-48ad-9d9a-1bf9430cb820"), null, null, "OperationClaimList", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Yetki Listesi" },
                    { new Guid("778cdc10-3ca4-435c-8009-36b38f69c0aa"), null, null, "UserList", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "User List" },
                    { new Guid("5506b383-74d8-41af-b9d5-c9cd50047284"), null, null, "UserList", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kullanıcı Listesi" },
                    { new Guid("f7f3fef4-7d90-413b-b4ce-b4a9815e556f"), null, null, "Add", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Add" },
                    { new Guid("b37f5a99-72f2-4e01-8e21-85e007e323bc"), null, null, "Add", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Ekle" },
                    { new Guid("4fdb4b35-3071-4d65-aade-38b01b20f4b3"), null, null, "GrupPermissions", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Grup Permissions" },
                    { new Guid("1e267617-72f0-4c91-9864-6a95b1d12620"), null, null, "GrupPermissions", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Grup Yetkileri" },
                    { new Guid("d9915917-7333-4388-b382-668d92782d9b"), null, null, "GroupList", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Group List" },
                    { new Guid("ac487452-7f61-45a8-b6db-17fa8c53f6ce"), null, null, "GroupList", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Grup Listesi" },
                    { new Guid("c572b6d2-9c73-4dbd-a398-623b4d98bfe3"), null, null, "Permissions", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "İzinler" },
                    { new Guid("d63e3ce4-e009-424e-a7b1-70b4e10f8fc2"), null, null, "Description", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Description" },
                    { new Guid("c2259639-2dc6-480b-a5c7-8bc5466a1641"), null, null, "Value", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Değer" },
                    { new Guid("a984c2db-4051-4349-8955-03fa40e643c3"), null, null, "Value", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Value" },
                    { new Guid("471c88fb-faf7-462a-804c-0ad8956a57ad"), null, null, "LangCode", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Dil Kodu" },
                    { new Guid("c1f71880-3ae9-45e8-91e9-8561f444f8f3"), null, null, "LangCode", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Lang Code" },
                    { new Guid("e7413391-365a-4a8d-be4d-1d5956e2bf25"), null, null, "Name", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Adı" },
                    { new Guid("ca8962ef-3ef0-4004-9652-713cd5ab86fb"), null, null, "PasswordSpecialCharacter", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "En Az 1 Simge İçermelidir!" },
                    { new Guid("c6a86a37-f36a-4a80-98b6-9562d0608f30"), null, null, "Name", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Name" },
                    { new Guid("bb79c2d4-14a6-41bf-bfb4-dc9112a4c77a"), null, null, "MobilePhones", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Mobile Phone" },
                    { new Guid("0967ec4e-2449-4560-b3ff-51afc9ef763b"), null, null, "NoRecordsFound", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kayıt Bulunamadı" },
                    { new Guid("a10b3664-5a75-45b1-af92-b8ebaaa91218"), null, null, "NoRecordsFound", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "No Records Found" },
                    { new Guid("e88cbafc-ff05-447f-8005-768cbeea480d"), null, null, "Required", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Bu alan zorunludur!" },
                    { new Guid("b165e40d-09c7-4b8c-8f16-530cadb1c988"), null, null, "Required", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "This field is required!" },
                    { new Guid("0c0a58d8-e1a7-4e63-92d3-8533825294c8"), null, null, "Permissions", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Permissions" },
                    { new Guid("d90110e5-a187-4e57-af69-ac51d671fbeb"), null, null, "MobilePhones", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Cep Telefonu" },
                    { new Guid("e1361114-5ac8-4812-b6aa-5d0def965755"), null, null, "PasswordDigit", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "It Must Contain At Least 1 Digit!" },
                    { new Guid("cce410b9-b67b-4d88-a00f-819ee96285af"), null, null, "PasswordDigit", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "En Az 1 Rakam İçermelidir!" },
                    { new Guid("002d1bab-d8c0-4b82-b477-6fdd0fe14a31"), null, null, "PasswordLowercaseLetter", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Must Contain At Least 1 Lowercase Letter!" },
                    { new Guid("7c36e242-8c7c-436b-8118-ba54464814eb"), null, null, "Added", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Successfully Added." },
                    { new Guid("c4c722c5-96b8-43e4-9be8-0b8796e806fb"), null, null, "Added", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Başarıyla Eklendi." },
                    { new Guid("5816408f-7be1-447a-bbf8-f6f30821592e"), null, null, "AppMenu", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Application" },
                    { new Guid("8dbeb033-e614-4a26-866c-2380c517536c"), null, null, "AppMenu", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Uygulama" },
                    { new Guid("611a7193-572d-4cf6-a3d0-e3f402e6ead8"), null, null, "Management", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Management" },
                    { new Guid("ecf2caf4-783b-4668-bcee-bbd9f48ad28a"), null, null, "Management", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Yönetim" },
                    { new Guid("5eeb8d00-e0a5-4883-8303-9903ebe44668"), null, null, "TranslateWords", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Translate Words" },
                    { new Guid("67d27494-8470-451b-9564-d76e3fb55c95"), null, null, "TranslateWords", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Dil Çevirileri" },
                    { new Guid("56f71d7e-3bd3-4d5f-a1c8-81040a7f85a5"), null, null, "Languages", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Languages" },
                    { new Guid("dd932ae9-3dab-475d-bc74-118022e0c576"), null, null, "Languages", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Diller" },
                    { new Guid("dc42c697-100d-47b8-9bd6-ff0453590ec0"), null, null, "OperationClaim", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Operation Claim" },
                    { new Guid("d0cc8d54-6e82-4b59-b73d-7fb752136a7f"), null, null, "OperationClaim", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Operasyon Yetkileri" },
                    { new Guid("4d0aaa92-be60-435e-bb77-60fa0835443d"), null, null, "Groups", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Groups" },
                    { new Guid("e8185d7a-b522-40fb-91d3-f444ebd1c245"), null, null, "Users", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Users" },
                    { new Guid("01d8c4d4-527f-47af-9160-62b63e605766"), null, null, "Create", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Create" },
                    { new Guid("3365de33-fee3-484c-913b-781823eebb09"), null, null, "UsersClaims", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "User's Claims" },
                    { new Guid("d7025b80-e199-40ed-95fc-79455a453dd9"), null, null, "UsersGroups", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "User's Groups" },
                    { new Guid("722737c0-a367-4b01-88e6-2567cd9e23ae"), null, null, "Email", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "E posta" },
                    { new Guid("a4369f43-dbb6-4972-b8f7-f1d4d01690af"), null, null, "Password", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Parola" },
                    { new Guid("0cd7498e-2944-4d53-a2c4-8cd4ea2e787b"), null, null, "Update", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Güncelle" },
                    { new Guid("e3d88728-cc21-4b5a-bbb2-abced0d2bad3"), null, null, "Delete", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Sil" },
                    { new Guid("bf970cc8-98e4-4490-808e-d24d754b3797"), null, null, "UsersGroups", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kullanıcının Grupları" },
                    { new Guid("1a1816a8-441f-4289-88ac-4814873d038d"), null, null, "UsersClaims", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kullanıcının Yetkileri" },
                    { new Guid("c5eba2af-0f97-4bac-889e-dd08af75d297"), null, null, "Updated", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Başarıyla Güncellendi." },
                    { new Guid("81619f2b-3eef-411d-9ea7-eed42d94df7b"), null, null, "Create", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Yeni" },
                    { new Guid("1150fc79-61b8-4ce1-a97b-59ef5762325e"), null, null, "Groups", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Gruplar" },
                    { new Guid("99b3e8bc-d295-4404-84c4-af62b3192d5a"), null, null, "Login", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Login" },
                    { new Guid("b59a33e9-190f-4840-94e6-b1417550b1c0"), null, null, "Email", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Email" },
                    { new Guid("abd9bb0d-a379-4a65-ab86-6f96a3ee6a05"), null, null, "Password", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Password" },
                    { new Guid("4e16972b-539d-4a32-b910-d560c45bcce7"), null, null, "Update", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Update" },
                    { new Guid("6055fabe-cf36-4f25-8306-f9b1dd097a3f"), null, null, "Delete", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Delete" },
                    { new Guid("7c0995d7-7e19-40b1-8713-c240b2c64434"), null, null, "Users", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kullanıcılar" },
                    { new Guid("6c1029e8-1c1f-40ab-a21a-a44dff7844b8"), null, null, "DeleteConfirm", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Emin misiniz?" },
                    { new Guid("b143620d-229f-448f-b3ff-e0398802d3f9"), null, null, "Updated", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Successfully Updated." },
                    { new Guid("acab7199-fcff-436f-817c-9363d57817be"), null, null, "Deleted", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Successfully Deleted." },
                    { new Guid("c70ce3bb-a065-4b5e-a9d0-ec8592620c30"), null, null, "PasswordLowercaseLetter", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "En Az 1 Küçük Harf İçermelidir!" },
                    { new Guid("d14dec4e-d5f9-4681-bd84-efd5de612a7e"), null, null, "PasswordUppercaseLetter", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Must Contain At Least 1 Capital Letter!" },
                    { new Guid("11f62045-4ba9-48b3-a171-3e9f92547913"), null, null, "PasswordUppercaseLetter", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "En Az 1 Büyük Harf İçermelidir!" },
                    { new Guid("e93dcf53-ba5f-4640-bf16-2d23a3b1f1ad"), null, null, "PasswordLength", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Must be at least 8 characters long! " },
                    { new Guid("296bb66a-dcbd-4d09-85c8-fa014353c2c8"), null, null, "PasswordLength", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Minimum 8 Karakter Uzunluğunda Olmalıdır!" },
                    { new Guid("07e96291-384a-46de-81ad-553bafc7a8ec"), null, null, "PasswordEmpty", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Password can not be empty!" },
                    { new Guid("5635afd8-29a5-46f9-8566-46c69655be4b"), null, null, "PasswordEmpty", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Parola boş olamaz!" },
                    { new Guid("461ca27c-abc6-4a52-8024-6d0c79087aa9"), null, null, "CID", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Citizenship Number" },
                    { new Guid("a3895021-af51-4e0b-8fd7-4c41e8fe8751"), null, null, "CID", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Vatandaşlık No" },
                    { new Guid("c2074d47-85c1-46fd-8877-3ab45126cb85"), null, null, "WrongCID", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Citizenship Number Not Found In Our System. Please Create New Registration!" },
                    { new Guid("74ef87c3-5656-4878-b222-fa2d692d959c"), null, null, "WrongCID", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Vatandaşlık No Sistemimizde Bulunamadı. Lütfen Yeni Kayıt Oluşturun!" },
                    { new Guid("ce30863a-9a54-4acf-96bb-97756bebe231"), null, null, "NameAlreadyExist", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "The Object You Are Trying To Create Already Exists." },
                    { new Guid("9dd5c4e1-bb2a-4d15-952a-38a72230bba4"), null, null, "NameAlreadyExist", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Oluşturmaya Çalıştığınız Nesne Zaten Var." },
                    { new Guid("506f240e-54b1-4115-8643-f4c9b06063c8"), null, null, "SendMobileCode", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Please Enter The Code Sent To You By SMS!" },
                    { new Guid("4121cac2-d28a-4e35-96b0-6bac66f15434"), null, null, "SendMobileCode", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Lütfen Size SMS Olarak Gönderilen Kodu Girin!" },
                    { new Guid("87cd3cca-c958-4e58-af5a-187dc538f097"), null, null, "SuccessfulLogin", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Login to the system is successful." },
                    { new Guid("14609896-12ea-41ff-88eb-c7129289e369"), null, null, "SuccessfulLogin", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Sisteme giriş başarılı." },
                    { new Guid("a3c51ba4-51d1-41c1-bf57-0c6e57c84d45"), null, null, "OperationClaimExists", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Bu operasyon izni zaten mevcut." },
                    { new Guid("f1bee5c5-4c7e-4b84-9e62-89b3354e5669"), null, null, "OperationClaimExists", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "This operation permit already exists." },
                    { new Guid("14ff4b4d-86b7-46d5-a1f1-b5e4b85e1e87"), null, null, "StringLengthMustBeGreaterThanThree", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Lütfen En Az 3 Karakterden Oluşan Bir İfade Girin." },
                    { new Guid("d079d7eb-4433-42c9-8fa5-d1f8e8b695ac"), null, null, "StringLengthMustBeGreaterThanThree", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Please Enter A Phrase Of At Least 3 Characters." },
                    { new Guid("0416f629-874a-453d-b802-fa76adcf96ee"), null, null, "CouldNotBeVerifyCid", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kimlik No Doğrulanamadı." },
                    { new Guid("c781c5c0-8b51-4512-9f5a-e37f1534c962"), null, null, "CouldNotBeVerifyCid", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Could not be verify Citizen Id" },
                    { new Guid("4a68ebbc-d280-4a78-b574-900a2a24973e"), null, null, "Deleted", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Başarıyla Silindi." },
                    { new Guid("c6b863fb-81d7-4033-b112-56c114d80424"), null, null, "VerifyCid", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kimlik No Doğrulandı." },
                    { new Guid("40c14bc9-12fa-4bae-bda3-634d0120bbde"), null, null, "AuthorizationsDenied", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Yetkiniz olmayan bir alana girmeye çalıştığınız tespit edildi." },
                    { new Guid("c47b22f7-79a2-4d6e-a8e1-8f35f21c83df"), null, null, "AuthorizationsDenied", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "It has been detected that you are trying to enter an area that you do not have authorization." },
                    { new Guid("14a8d8bd-1d28-4b81-8441-dfea6bbc4f1e"), null, null, "UserNotFound", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kimlik Bilgileri Doğrulanamadı. Lütfen Yeni Kayıt Ekranını kullanın." },
                    { new Guid("92d3e2e4-ea5d-4879-a9a4-8eada5e36273"), null, null, "UserNotFound", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Credentials Could Not Verify. Please use the New Registration Screen." },
                    { new Guid("aca08521-45d0-4f23-abc7-35b5b2ab1318"), null, null, "PasswordError", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kimlik Bilgileri Doğrulanamadı, Kullanıcı adı ve/veya parola hatalı." },
                    { new Guid("a8368de1-39e1-4c3b-b5ee-a80417348638"), null, null, "PasswordError", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Credentials Failed to Authenticate, Username and / or password incorrect." },
                    { new Guid("4f3316fe-03d8-4b25-93c7-4ad265cd25d1"), null, null, "VerifyCid", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Verify Citizen Id" },
                    { new Guid("3abf54ef-1daf-44b0-98cc-947bfee33095"), null, null, "DeleteConfirm", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Are you sure?" }
                });
        }
    }
}
