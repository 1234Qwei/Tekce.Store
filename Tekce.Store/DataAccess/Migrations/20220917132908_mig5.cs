using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserGroups",
                table: "UserGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserClaims",
                table: "UserClaims");

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("013a7ba9-0839-43d8-8622-46e1cc36b06d"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("034364d2-a01f-4302-a7b5-e951d5950ff8"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("05e45e43-7c8a-428a-a2bc-b5dab2fd35c1"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("0a2facd0-4bc4-4094-aca7-a68559e6d10f"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("0b0589a0-f4cd-404a-b757-c68f0724319e"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("0e407368-440e-48dc-8072-e5aff375f191"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("0f888893-eeac-4e1a-bb1e-060e389de08a"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("10e85791-f77e-4e68-af93-454a3418ed15"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("14d885d9-31a0-409f-a6ee-a53f94fb64a3"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("1bf7c9c9-f246-4b1b-9cd9-c6a9e1531d48"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("1e704e78-8dcb-4eb4-bb26-10d4b9f76d49"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("1f498a9f-d573-419d-8c05-b25fa38916d4"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("22956e88-5aeb-4c45-b9f9-986dcd3e4bf7"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("233e4da5-a506-416d-b573-00d43bbdcd49"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("25ad6665-690b-4dfb-b84f-01c273c3d1fe"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("29caa88a-7f63-4f6e-a0f0-19891ba8705a"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("2b1bd578-8973-4005-b63d-6b7361b57ac7"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("2dbf2550-3925-4872-8c46-4ba51239a735"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("2f9e9eb0-b89f-4050-8e9f-4b540ffb9ea8"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("2fe1a353-8415-42e9-a9a5-40a9b2a2fcc3"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("337f5398-c1fd-49b2-a7db-7855b4098ddb"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("33bf6e9a-827e-40d6-bf91-69287a614131"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("33d9bedc-ba44-4005-a337-98655be7c75c"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("35094886-a959-4aa4-ab6f-ba278fd3e4c2"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("3543189f-b9cb-4eb0-b60c-46f158ac52d7"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("362eeb42-78d6-4521-85b9-3dfa266cc508"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("3641fdb9-1328-472b-b860-be9c9068a529"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("367dd424-398c-47bb-a96e-4f4c13b71459"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("38957c5a-53f4-417c-a860-f56b814fd256"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("395c3f3a-c837-4621-9c35-a63d8bc2e783"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("3c10378e-a38f-4a84-ae8c-eacb94e7fcdc"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("3e3c9085-9375-4362-b0ef-e8145a6c3a50"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("42601b4c-0d3b-4e0a-85f5-a6e02589a60a"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("427f092b-4498-4f3a-b0e4-6995562d57fa"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("4289222e-22b8-43fe-b1bd-2951806ca16a"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("4464ac2e-2e3c-4717-b272-2a0c1be011fa"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("44ab149a-c4ea-4a64-a027-e8fb98b74fd5"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("45e55b4e-f6f7-4d59-9265-d52356e010ae"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("46c0e8f9-4e22-4d40-9f1b-18ef9b5878f1"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("477bf374-e326-4100-a99b-4812308ff56e"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("4c310082-5b3f-4cd9-8181-7e24fddb2e11"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("4c5f7735-c44e-450b-95ef-986af57595e5"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("4d0fae81-9798-4790-82ee-ddb2aea0b760"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("4e2ddcee-9598-4958-8308-5187dc9f4e9c"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("4e45438f-2fd3-4f71-b11c-de07ea79437a"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("4f0cd345-79c6-402a-a455-deba147e609e"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("4f7a681e-0d5d-4c5b-9a9e-e85f7df65961"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("50d8bfab-33b6-46ef-8168-39a6f8743db3"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("51984db9-958f-4a11-842d-acd106976b15"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("534ee674-f5c8-4764-a602-9582c896cca9"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("53fc4e1b-5de8-4d48-b81b-1f2458829537"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("57a5ec1a-a281-4bc0-afee-6f315f7bd1af"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("5bb4482e-ec50-4cb7-950f-49ead7d4ce29"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("5c57297f-585d-41e6-bb1a-670a6b523287"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("5dbaaeb8-ba0b-4022-9261-ec45789b4789"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("6428e509-d82c-4683-9148-94e5a398a9d1"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("64ea33a5-fa13-4820-9484-e49206009f93"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("66b3c7e4-dae1-4e10-b387-774cad442870"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("67a91588-f63c-4fe8-a7f1-c83bd5c91b46"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("68dc4b37-71b5-405a-ba44-21276be04ce1"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("6987697d-fa42-4a03-a6cb-bff0ae26dcfe"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("69d1041f-92e4-4d2d-a50a-2b158ed82cf5"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("6ac74305-bcf9-4af7-8121-7ced8538c8dc"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("6c166cbf-25cb-4b11-a0b5-156bef19af57"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("6c18b231-10bd-4823-b2a3-e6994eb299a7"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("6df7210a-a96a-49b1-88ee-ab7c677190a5"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("6ea9cf4f-c373-47b3-aee2-d7e1e7a7eb2e"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("6ffcf7d6-8b05-4a79-81d9-c21f93e6b1b8"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("70236ef5-e6da-405e-8714-2471c039dff8"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("718e6779-c256-462b-a09b-85a836fe8237"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("71eee4d6-6c30-4b9d-a808-1e544aa2d38f"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("726e00cc-d6eb-4f88-9ba6-43ad47d0a6b6"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("7425e542-24c1-4f16-b034-76e327fbe817"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("74c6b1b0-f295-4dd8-a06a-4f291464c2f9"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("78212d3e-cb08-4432-b616-6b33f73f10e3"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("7a1329a6-fc6b-49d2-9030-27fb58cc6da1"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("7daed0fc-d389-4f3d-8fea-c932d0059352"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("80e3f153-fbb0-49b7-9d93-4051eb53ef4f"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("80e64156-3296-4f62-9537-6709f9d853f2"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("816b1c16-2a00-4542-8cd0-3de8322d6309"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("84b68c50-ded4-42da-a03b-b4bbd2c86bad"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("84db0902-a581-4c97-bb7e-b64cec24b66d"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("855cf178-4e53-418c-b40a-7d8bcaddb111"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("89983521-3755-46d0-bcec-2cf7605815c0"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("914f962b-ded6-4b64-ba01-514fb4b7db84"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("91b6712f-d2f6-4911-904c-0bf58f62b571"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("92afe69e-8bc0-45d6-8f56-b4a78f65ac5f"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("92be6481-5e61-43ef-92c9-fcfd858dd9f6"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("982172c2-cc96-4267-8901-3a209c2009cb"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("98a94961-439f-44f4-bf23-6e518655393b"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("a10fa7db-d440-4a8d-91fc-e10b0b72b1b9"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("a1e9797e-c489-4db5-ac3a-ba896857379d"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("a701c71a-2bfe-4b46-899a-0d42901910e6"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("ab053920-92d7-4f33-b7a5-20968396c414"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("ac328a4d-a592-4063-b2af-1c01877bd07d"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("ac4d9f4b-c2b4-4377-8b4c-9ae17816a0fd"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("aca0834b-56ae-4c4a-89a7-7ec8b6fd8bdc"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("ad09e4fe-ed0e-42fb-a9ab-7f8841211a4d"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("adc9d9be-642d-41ee-855a-45537af55af7"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("afb00f47-ca22-4ddf-a1dc-9311ed68cbf3"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("b18c2e27-1075-4ecb-a88e-07975b1d19a8"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("b5e793bd-8fdf-4cb7-b38a-9f7443b5af9a"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("b988a369-d413-4da6-a738-34c09a999616"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("b9bf3e22-8f6c-44cf-a60a-69f5c7083ada"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("baefbda2-234d-4001-a1ff-67073a782309"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("bc3db746-ab46-4368-89cc-c2e7da2800c5"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("bcb84637-00d2-4d73-8c00-fb923bb9e4a3"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("bd87bf74-0ea6-443e-88fc-e15fa60bb9b1"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("bfc8c8b4-4ae6-4f27-8307-8671434d312e"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("c0d3fc59-07e8-4a1c-9da9-c21c4096bb09"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("c21cbbb7-b546-446e-8fd1-95f8918d1111"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("c3da3b2b-1363-48de-b276-b1708ab42695"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("c96aecb2-8d95-4194-a935-c29fc342a6a6"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("d0d54f9f-4068-41f4-a275-4b8ec51d8c43"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("d1bc350e-a6c4-417f-bf43-0b9054327e4c"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("d2997564-39d1-4fcf-b76a-a4d341283acb"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("d3b0ea13-8fd0-4bcd-97b6-acf95ef5a361"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("d584c5c3-bd72-4d0e-98e9-f90fbb742af2"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("d5d72c4c-d7d0-4d55-8ad3-6a7130945a77"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("d65073c1-1f8c-4d0d-8e98-00ed825fc530"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("d6b7a2f7-ffcf-4306-b39d-06d02c68275d"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("d9b6db3d-cbac-4778-a0c6-5b70c71f656e"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("dd7dadc2-a942-4968-b170-fc0ce9a032de"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e1533612-c1fc-4d88-8014-eb779387b915"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e195d01f-0c4c-4247-b551-fb5b41c08725"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e39b570a-d485-4408-a79e-c41801bd0c61"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e4f6f0ba-5f0a-4368-b0eb-e2a820a3b86b"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e5588741-9469-4758-b57d-051280034679"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e5820841-bc43-4591-9810-00b2d90381e8"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e59b4cf7-700a-4861-a23a-006f778c2896"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e7d57b1b-f533-42a8-85ae-5200682177b3"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e9db04b9-6042-4452-a67a-fee3f3920bb2"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("ea312dd9-92ba-4ace-b303-a4622db40137"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("ea55f696-d610-4f8d-9a35-f129a98e08a6"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("f6aa55a6-b153-493a-967d-1503e659cae1"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("f6afdb72-9f41-4cbb-8f79-64abc1640924"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("f995bc49-c7d9-4ba5-a17f-d81896cbbe17"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("fb57c7b8-ae9f-4bb3-9f00-ca9fb7538058"));

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "MobilePhones",
                table: "Users",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Users",
                newName: "CreatedById");

            migrationBuilder.RenameColumn(
                name: "ChangedBy",
                table: "Users",
                newName: "ChangedById");

            migrationBuilder.RenameIndex(
                name: "IX_Users_MobilePhones",
                table: "Users",
                newName: "IX_Users_PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "UserGroups",
                newName: "CreatedById");

            migrationBuilder.RenameColumn(
                name: "ChangedBy",
                table: "UserGroups",
                newName: "ChangedById");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "UserClaims",
                newName: "CreatedById");

            migrationBuilder.RenameColumn(
                name: "ChangedBy",
                table: "UserClaims",
                newName: "ChangedById");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Translates",
                newName: "CreatedById");

            migrationBuilder.RenameColumn(
                name: "ChangedBy",
                table: "Translates",
                newName: "ChangedById");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "OperationClaims",
                newName: "CreatedById");

            migrationBuilder.RenameColumn(
                name: "ChangedBy",
                table: "OperationClaims",
                newName: "ChangedById");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "MobileLogins",
                newName: "CreatedById");

            migrationBuilder.RenameColumn(
                name: "ChangedBy",
                table: "MobileLogins",
                newName: "ChangedById");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Locations",
                newName: "CreatedById");

            migrationBuilder.RenameColumn(
                name: "ChangedBy",
                table: "Locations",
                newName: "ChangedById");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Languages",
                newName: "CreatedById");

            migrationBuilder.RenameColumn(
                name: "ChangedBy",
                table: "Languages",
                newName: "ChangedById");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Groups",
                newName: "CreatedById");

            migrationBuilder.RenameColumn(
                name: "ChangedBy",
                table: "Groups",
                newName: "ChangedById");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "GroupClaims",
                newName: "CreatedById");

            migrationBuilder.RenameColumn(
                name: "ChangedBy",
                table: "GroupClaims",
                newName: "ChangedById");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Users",
                type: "timestamp without time zone",
                nullable: true,
                defaultValue: new DateTime(2022, 9, 17, 16, 29, 8, 471, DateTimeKind.Local).AddTicks(993),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 9, 3, 17, 51, 11, 917, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Changed",
                table: "Users",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Users",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserGroups",
                type: "timestamp without time zone",
                nullable: true,
                defaultValue: new DateTime(2022, 9, 17, 16, 29, 8, 471, DateTimeKind.Local).AddTicks(9771),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Changed",
                table: "UserGroups",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserClaims",
                type: "timestamp without time zone",
                nullable: true,
                defaultValue: new DateTime(2022, 9, 17, 16, 29, 8, 471, DateTimeKind.Local).AddTicks(437),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Changed",
                table: "UserClaims",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Translates",
                type: "timestamp without time zone",
                nullable: true,
                defaultValue: new DateTime(2022, 9, 17, 16, 29, 8, 470, DateTimeKind.Local).AddTicks(8389),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Changed",
                table: "Translates",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "OperationClaims",
                type: "timestamp without time zone",
                nullable: true,
                defaultValue: new DateTime(2022, 9, 17, 16, 29, 8, 470, DateTimeKind.Local).AddTicks(7407),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Changed",
                table: "OperationClaims",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SendDate",
                table: "MobileLogins",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "MobileLogins",
                type: "timestamp without time zone",
                nullable: true,
                defaultValue: new DateTime(2022, 9, 17, 16, 29, 8, 470, DateTimeKind.Local).AddTicks(6790),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Changed",
                table: "MobileLogins",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "TimeStamp",
                table: "Logs",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Locations",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Changed",
                table: "Locations",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Languages",
                type: "timestamp without time zone",
                nullable: true,
                defaultValue: new DateTime(2022, 9, 17, 16, 29, 8, 470, DateTimeKind.Local).AddTicks(5786),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Changed",
                table: "Languages",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Groups",
                type: "timestamp without time zone",
                nullable: true,
                defaultValue: new DateTime(2022, 9, 17, 16, 29, 8, 470, DateTimeKind.Local).AddTicks(5030),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Changed",
                table: "Groups",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "GroupClaims",
                type: "timestamp without time zone",
                nullable: true,
                defaultValue: new DateTime(2022, 9, 17, 16, 29, 8, 470, DateTimeKind.Local).AddTicks(3393),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Changed",
                table: "GroupClaims",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserGroups",
                table: "UserGroups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserClaims",
                table: "UserClaims",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Translates",
                columns: new[] { "Id", "Changed", "ChangedById", "Code", "CreatedById", "LangId", "Value" },
                values: new object[,]
                {
                    { new Guid("01ad5028-2572-4e2b-b279-f5876a78e32c"), null, null, "AuthorizationsDenied", null, new Guid("00000000-0000-0000-0000-000000000001"), "Yetkiniz olmayan bir alana girmeye çalıştığınız tespit edildi." },
                    { new Guid("025340c6-57c2-4a25-b5ba-56048c673727"), null, null, "Updated", null, new Guid("00000000-0000-0000-0000-000000000001"), "Başarıyla Güncellendi." },
                    { new Guid("02c8d7ad-9dca-4aef-842c-aef67391f25e"), null, null, "CID", null, new Guid("00000000-0000-0000-0000-000000000002"), "Citizenship Number" },
                    { new Guid("031b838a-ee12-4a25-8221-63e6574ae994"), null, null, "StringLengthMustBeGreaterThanThree", null, new Guid("00000000-0000-0000-0000-000000000002"), "Please Enter A Phrase Of At Least 3 Characters." },
                    { new Guid("03a68caf-a62d-4945-a54c-75747c458ed7"), null, null, "PasswordEmpty", null, new Guid("00000000-0000-0000-0000-000000000002"), "Password can not be empty!" },
                    { new Guid("03bf1769-5f67-4a16-b4c8-77ff4251ea9a"), null, null, "SendMobileCode", null, new Guid("00000000-0000-0000-0000-000000000002"), "Please Enter The Code Sent To You By SMS!" },
                    { new Guid("04316bc7-3677-4b71-a514-e3a44a4536a9"), null, null, "LogList", null, new Guid("00000000-0000-0000-0000-000000000002"), "LogList" },
                    { new Guid("058909b0-fea2-41dc-a29c-a7543cfe115c"), null, null, "Required", null, new Guid("00000000-0000-0000-0000-000000000002"), "This field is required!" },
                    { new Guid("05ee1bf2-2342-48ea-8bdc-36df2ac56f77"), null, null, "WrongCID", null, new Guid("00000000-0000-0000-0000-000000000001"), "Vatandaşlık No Sistemimizde Bulunamadı. Lütfen Yeni Kayıt Oluşturun!" },
                    { new Guid("0dcfdc22-b5e5-429d-8de6-617b7830a277"), null, null, "SendMobileCode", null, new Guid("00000000-0000-0000-0000-000000000001"), "Lütfen Size SMS Olarak Gönderilen Kodu Girin!" },
                    { new Guid("105c248c-8b72-4869-a2b5-db42ce4062ee"), null, null, "Password", null, new Guid("00000000-0000-0000-0000-000000000002"), "Password" },
                    { new Guid("112dd912-ab67-433f-9e96-c10a97107bbe"), null, null, "TrueButCellPhone", null, new Guid("00000000-0000-0000-0000-000000000002"), "The information is correct. Cell phone is required." },
                    { new Guid("179079b4-a238-4b67-a09b-2ab15ea865e8"), null, null, "LangCode", null, new Guid("00000000-0000-0000-0000-000000000001"), "Dil Kodu" },
                    { new Guid("183cddb5-1ba7-4ac5-a4f2-4d1fbe2535f6"), null, null, "FullName", null, new Guid("00000000-0000-0000-0000-000000000001"), "Tam Adı" },
                    { new Guid("1a9c58a1-4d0f-4ce6-a648-30338a1300be"), null, null, "GrupPermissions", null, new Guid("00000000-0000-0000-0000-000000000002"), "Grup Permissions" },
                    { new Guid("1aad2e1b-6b98-42bb-9440-43095fdc4825"), null, null, "AppMenu", null, new Guid("00000000-0000-0000-0000-000000000002"), "Application" },
                    { new Guid("24cf8451-ac95-42d5-9725-b0d9e53aa80c"), null, null, "OperationClaimExists", null, new Guid("00000000-0000-0000-0000-000000000002"), "This operation permit already exists." },
                    { new Guid("25f60e8b-bca5-4181-a22d-962edbad4a0b"), null, null, "Address", null, new Guid("00000000-0000-0000-0000-000000000002"), "Address" },
                    { new Guid("28ed6892-0568-4681-a488-363fb36190fe"), null, null, "Unknown", null, new Guid("00000000-0000-0000-0000-000000000002"), "Unknown!" },
                    { new Guid("29e5bfe9-ef63-4108-ae52-b73aab43dccd"), null, null, "UserNotFound", null, new Guid("00000000-0000-0000-0000-000000000001"), "Kimlik Bilgileri Doğrulanamadı. Lütfen Yeni Kayıt Ekranını kullanın." },
                    { new Guid("2d47a601-a2c5-4191-9d41-b5ce6480a57f"), null, null, "GrupPermissions", null, new Guid("00000000-0000-0000-0000-000000000001"), "Grup Yetkileri" },
                    { new Guid("2ee8dfad-f47c-436e-9549-2dffa891736f"), null, null, "Add", null, new Guid("00000000-0000-0000-0000-000000000001"), "Ekle" },
                    { new Guid("31659afe-ad5f-42a3-87eb-bbafe6add7f2"), null, null, "LanguageList", null, new Guid("00000000-0000-0000-0000-000000000001"), "Dil Listesi" },
                    { new Guid("359cd498-a3ab-4882-956e-9ab5e587a08a"), null, null, "ChangePassword", null, new Guid("00000000-0000-0000-0000-000000000001"), "Parola Değiştir" },
                    { new Guid("36d2bb6e-44cc-44de-97ca-dc3f8661091b"), null, null, "VerifyCid", null, new Guid("00000000-0000-0000-0000-000000000002"), "Verify Citizen Id" },
                    { new Guid("38b84d2e-af2d-4591-be54-d89f9dea9952"), null, null, "Languages", null, new Guid("00000000-0000-0000-0000-000000000001"), "Diller" },
                    { new Guid("38baef77-4d72-4829-9a13-e222d25d6bc0"), null, null, "Alias", null, new Guid("00000000-0000-0000-0000-000000000001"), "Görünen Ad" },
                    { new Guid("3bab3f08-b6a2-422d-acd3-401c6d2e932c"), null, null, "TranslateList", null, new Guid("00000000-0000-0000-0000-000000000001"), "Dil Çeviri Listesi" },
                    { new Guid("3dae52f9-2a53-4761-9d2c-516b44dfffba"), null, null, "Updated", null, new Guid("00000000-0000-0000-0000-000000000002"), "Successfully Updated." },
                    { new Guid("41cf931d-2c4a-4ecf-9943-f8e6a74ea159"), null, null, "Permissions", null, new Guid("00000000-0000-0000-0000-000000000001"), "Permissions" },
                    { new Guid("436ca114-f0f2-4430-8b5e-e5606afa87a7"), null, null, "Create", null, new Guid("00000000-0000-0000-0000-000000000002"), "Create" },
                    { new Guid("46f6863e-a46f-4157-a9eb-fa001a7ef570"), null, null, "Name", null, new Guid("00000000-0000-0000-0000-000000000001"), "Adı" },
                    { new Guid("4a99746b-9080-4454-a465-38b07c17bfe6"), null, null, "NoRecordsFound", null, new Guid("00000000-0000-0000-0000-000000000001"), "Kayıt Bulunamadı" },
                    { new Guid("4aff797c-eef3-4e75-b1b5-2b28803c42f1"), null, null, "ChangePassword", null, new Guid("00000000-0000-0000-0000-000000000002"), "Change Password" },
                    { new Guid("4e2ad1d5-9ba2-40f9-9df5-4d793bee2769"), null, null, "Update", null, new Guid("00000000-0000-0000-0000-000000000001"), "Güncelle" },
                    { new Guid("4f7ae65e-66fe-4a5e-b2bc-d6807bea0160"), null, null, "UserNotFound", null, new Guid("00000000-0000-0000-0000-000000000002"), "Credentials Could Not Verify. Please use the New Registration Screen." },
                    { new Guid("50a14e42-6b5b-4aa7-823c-cc72da1ab9b5"), null, null, "PasswordUppercaseLetter", null, new Guid("00000000-0000-0000-0000-000000000002"), "Must Contain At Least 1 Capital Letter!" },
                    { new Guid("51923bb2-eb38-4fc1-b5e2-2e31e089919a"), null, null, "UsersGroups", null, new Guid("00000000-0000-0000-0000-000000000002"), "User's Groups" },
                    { new Guid("5195bb25-ceff-46b7-b495-7d146ed5bc18"), null, null, "TranslateWords", null, new Guid("00000000-0000-0000-0000-000000000001"), "Dil Çevirileri" },
                    { new Guid("52706703-0359-4abd-a368-bc0cf2f8d26d"), null, null, "Update", null, new Guid("00000000-0000-0000-0000-000000000002"), "Update" },
                    { new Guid("5436878a-6df9-495e-8419-94c07c27397f"), null, null, "Notes", null, new Guid("00000000-0000-0000-0000-000000000002"), "Notes" },
                    { new Guid("55f181f9-2694-41e8-be23-cababe351ec4"), null, null, "ConfirmPassword", null, new Guid("00000000-0000-0000-0000-000000000001"), "Parolayı Doğrula" },
                    { new Guid("58f1c7ec-e5bd-44e2-9d4c-efc446392afa"), null, null, "SendPassword", null, new Guid("00000000-0000-0000-0000-000000000001"), "Yeni Parolanız E-Posta Adresinize Gönderildi." },
                    { new Guid("5ab3ee59-fbc3-4d4e-83d3-fdc2071f5383"), null, null, "SmsServiceNotFound", null, new Guid("00000000-0000-0000-0000-000000000001"), "SMS Servisine Ulaşılamıyor." },
                    { new Guid("5c43273a-b9c0-4427-8334-d4663b4d6714"), null, null, "CID", null, new Guid("00000000-0000-0000-0000-000000000001"), "Vatandaşlık No" },
                    { new Guid("5dababda-5244-4efd-a69a-abc781476613"), null, null, "InvalidCode", null, new Guid("00000000-0000-0000-0000-000000000001"), "Geçersiz Bir Kod Girdiniz!" },
                    { new Guid("5e34c907-c3c3-4dfe-ab79-5dda65c398ee"), null, null, "Create", null, new Guid("00000000-0000-0000-0000-000000000001"), "Yeni" },
                    { new Guid("5e99ac4e-117b-41a6-be28-688c40e9c298"), null, null, "LangCode", null, new Guid("00000000-0000-0000-0000-000000000002"), "Lang Code" },
                    { new Guid("62675537-9c04-4901-8bda-347e89eb34ba"), null, null, "NameAlreadyExist", null, new Guid("00000000-0000-0000-0000-000000000001"), "Oluşturmaya Çalıştığınız Nesne Zaten Var." },
                    { new Guid("65736f5b-0378-4be5-be37-87d966d534b7"), null, null, "NameAlreadyExist", null, new Guid("00000000-0000-0000-0000-000000000002"), "The Object You Are Trying To Create Already Exists." },
                    { new Guid("65cf8455-3181-43bb-82ab-5b5e06f68325"), null, null, "Groups", null, new Guid("00000000-0000-0000-0000-000000000001"), "Gruplar" },
                    { new Guid("66c1f596-c96d-4d08-abd8-b8ec5d9f7359"), null, null, "Added", null, new Guid("00000000-0000-0000-0000-000000000001"), "Başarıyla Eklendi." },
                    { new Guid("6a161498-39f5-4c7e-9716-c31896c3aabf"), null, null, "UsersClaims", null, new Guid("00000000-0000-0000-0000-000000000002"), "User's Claims" },
                    { new Guid("6a525c7c-671b-4cad-9e9c-e80a1a7401c0"), null, null, "PasswordSpecialCharacter", null, new Guid("00000000-0000-0000-0000-000000000002"), "Must Contain At Least 1 Symbol!" },
                    { new Guid("6bc94fed-05c7-421e-aa8d-0681388392c1"), null, null, "Value", null, new Guid("00000000-0000-0000-0000-000000000002"), "Value" },
                    { new Guid("6c3346b5-7855-4c92-92f3-a610d76c287e"), null, null, "NewPassword", null, new Guid("00000000-0000-0000-0000-000000000002"), "New Password:" },
                    { new Guid("6d3e8286-5fa2-48af-b9af-20fc0819ac0f"), null, null, "TokenProviderException", null, new Guid("00000000-0000-0000-0000-000000000002"), "Token Provider cannot be empty!" },
                    { new Guid("6e24bd8e-cd8a-471b-8abc-5b2f7a3d393f"), null, null, "Value", null, new Guid("00000000-0000-0000-0000-000000000001"), "Değer" },
                    { new Guid("6eb36ac9-d0ea-4cc5-a6dd-a6f4ec1533a2"), null, null, "PasswordError", null, new Guid("00000000-0000-0000-0000-000000000001"), "Kimlik Bilgileri Doğrulanamadı, Kullanıcı adı ve/veya parola hatalı." },
                    { new Guid("6fd4a892-947e-4bb7-a12a-6f94d752627d"), null, null, "OperationClaim", null, new Guid("00000000-0000-0000-0000-000000000002"), "Operation Claim" },
                    { new Guid("6ff8dc64-a7d0-4762-bf9b-92678a623338"), null, null, "AuthorizationsDenied", null, new Guid("00000000-0000-0000-0000-000000000002"), "It has been detected that you are trying to enter an area that you do not have authorization." },
                    { new Guid("73677ab1-8bd1-4528-aed6-11a9567a2750"), null, null, "Groups", null, new Guid("00000000-0000-0000-0000-000000000002"), "Groups" },
                    { new Guid("749a7219-3d8b-4d24-9ad4-6ff57eda67a5"), null, null, "Deleted", null, new Guid("00000000-0000-0000-0000-000000000002"), "Successfully Deleted." },
                    { new Guid("75337d5b-4abb-4433-9f46-e146749e8497"), null, null, "Description", null, new Guid("00000000-0000-0000-0000-000000000002"), "Description" },
                    { new Guid("7a8187af-c468-4a81-ad87-eea9c4ab304a"), null, null, "TranslateWords", null, new Guid("00000000-0000-0000-0000-000000000002"), "Translate Words" },
                    { new Guid("7bc1078c-6f41-4bfd-9225-594abbe37f6c"), null, null, "LogList", null, new Guid("00000000-0000-0000-0000-000000000001"), "İşlem Kütüğü" },
                    { new Guid("7e0a4a47-1aea-4d29-85ac-230050333957"), null, null, "SuccessfulLogin", null, new Guid("00000000-0000-0000-0000-000000000002"), "Login to the system is successful." },
                    { new Guid("836a5d61-59a0-40f4-8f13-bf8ddca7a36a"), null, null, "Required", null, new Guid("00000000-0000-0000-0000-000000000001"), "Bu alan zorunludur!" },
                    { new Guid("8f55f4c4-5178-4589-9ab8-f77a868dbc04"), null, null, "SuccessfulLogin", null, new Guid("00000000-0000-0000-0000-000000000001"), "Sisteme giriş başarılı." },
                    { new Guid("929707d6-9541-4218-bcab-5628a7827441"), null, null, "InvalidCode", null, new Guid("00000000-0000-0000-0000-000000000002"), "You Entered An Invalid Code!" },
                    { new Guid("93176ebf-c1cf-4fa4-aeeb-9d540da8c132"), null, null, "Description", null, new Guid("00000000-0000-0000-0000-000000000001"), "Açıklama" },
                    { new Guid("95182d4f-602c-4c21-ba97-99569e9df769"), null, null, "Login", null, new Guid("00000000-0000-0000-0000-000000000001"), "Giriş" },
                    { new Guid("95feaba9-1971-4f59-b1f2-bedbf04c6a8b"), null, null, "PasswordError", null, new Guid("00000000-0000-0000-0000-000000000002"), "Credentials Failed to Authenticate, Username and / or password incorrect." },
                    { new Guid("968f5bb6-9e8b-4469-bf77-6c07986fbc97"), null, null, "Permissions", null, new Guid("00000000-0000-0000-0000-000000000002"), "İzinler" },
                    { new Guid("96e7ed42-4522-44f5-9ea7-ef74c923df9b"), null, null, "PasswordDigit", null, new Guid("00000000-0000-0000-0000-000000000001"), "En Az 1 Rakam İçermelidir!" },
                    { new Guid("979548d8-294b-4bc9-95f6-b06722a4c0ea"), null, null, "Users", null, new Guid("00000000-0000-0000-0000-000000000001"), "Kullanıcılar" },
                    { new Guid("99761575-78ef-4c8d-813c-363005496031"), null, null, "Login", null, new Guid("00000000-0000-0000-0000-000000000002"), "Login" },
                    { new Guid("9b65e1c9-849f-421c-b4eb-344a1b7e162c"), null, null, "Save", null, new Guid("00000000-0000-0000-0000-000000000002"), "Save" },
                    { new Guid("9c248340-160f-4b92-aacc-e1a04a5f051f"), null, null, "LanguageList", null, new Guid("00000000-0000-0000-0000-000000000002"), "Language List" },
                    { new Guid("9c7e82ad-9e8a-4a2e-80ce-0ef7710ecf46"), null, null, "AppMenu", null, new Guid("00000000-0000-0000-0000-000000000001"), "Uygulama" },
                    { new Guid("a058eeca-efc6-47de-af48-cc8d4ff6c718"), null, null, "PasswordLowercaseLetter", null, new Guid("00000000-0000-0000-0000-000000000001"), "En Az 1 Küçük Harf İçermelidir!" },
                    { new Guid("a1a83d01-83c4-4c14-867e-57ffe281dc3e"), null, null, "PasswordLength", null, new Guid("00000000-0000-0000-0000-000000000001"), "Minimum 8 Karakter Uzunluğunda Olmalıdır!" },
                    { new Guid("a8a96e60-ddc3-485e-9415-fc4019caa17d"), null, null, "OperationClaimExists", null, new Guid("00000000-0000-0000-0000-000000000001"), "Bu operasyon izni zaten mevcut." },
                    { new Guid("aa720b5a-3638-40ce-843a-d5204e9d595f"), null, null, "MobilePhones", null, new Guid("00000000-0000-0000-0000-000000000001"), "Cep Telefonu" },
                    { new Guid("ab250938-b321-4dc6-879d-52b512f7cd01"), null, null, "GroupList", null, new Guid("00000000-0000-0000-0000-000000000002"), "Group List" },
                    { new Guid("ab6630e8-9139-4dbe-b5fa-9938f45c7efb"), null, null, "UserList", null, new Guid("00000000-0000-0000-0000-000000000001"), "Kullanıcı Listesi" },
                    { new Guid("ab99a081-3515-4085-aff4-bddff2b7d2ef"), null, null, "SmsServiceNotFound", null, new Guid("00000000-0000-0000-0000-000000000002"), "Unable to Reach SMS Service." },
                    { new Guid("ab9cf431-d64e-426f-8467-4ec5a2ef960b"), null, null, "Notes", null, new Guid("00000000-0000-0000-0000-000000000001"), "Notlar" },
                    { new Guid("ad6d3c31-e606-4cae-8bed-caa817eac454"), null, null, "Alias", null, new Guid("00000000-0000-0000-0000-000000000002"), "Alias" },
                    { new Guid("ad6dc560-451b-43ba-bd63-277386239aae"), null, null, "Deleted", null, new Guid("00000000-0000-0000-0000-000000000001"), "Başarıyla Silindi." },
                    { new Guid("af431c8b-f639-4837-a180-08bbe63eaac1"), null, null, "Address", null, new Guid("00000000-0000-0000-0000-000000000001"), "Adres" },
                    { new Guid("b1156835-f782-4e38-a55d-b01ebb6d48bf"), null, null, "NoRecordsFound", null, new Guid("00000000-0000-0000-0000-000000000002"), "No Records Found" },
                    { new Guid("b14ead32-2f58-4ce5-b99a-bba283fce9db"), null, null, "FullName", null, new Guid("00000000-0000-0000-0000-000000000002"), "Full Name" },
                    { new Guid("b1cf58c4-fb6c-4b59-b088-29c7c47efd60"), null, null, "GroupName", null, new Guid("00000000-0000-0000-0000-000000000001"), "Grup Adı" },
                    { new Guid("b5574132-ef93-4a86-8a14-45c15282d95b"), null, null, "GroupList", null, new Guid("00000000-0000-0000-0000-000000000001"), "Grup Listesi" },
                    { new Guid("b910e866-66c9-42ff-9fa1-88dc833ffa39"), null, null, "Name", null, new Guid("00000000-0000-0000-0000-000000000002"), "Name" },
                    { new Guid("b92a212b-6a2e-43a8-b993-87f3992d9918"), null, null, "Email", null, new Guid("00000000-0000-0000-0000-000000000002"), "Email" },
                    { new Guid("ba3e41bb-c8d2-4d3d-ab58-e817c78efb00"), null, null, "Password", null, new Guid("00000000-0000-0000-0000-000000000001"), "Parola" },
                    { new Guid("bb5839ae-1842-403d-9610-294d5cf1b977"), null, null, "Email", null, new Guid("00000000-0000-0000-0000-000000000001"), "E posta" },
                    { new Guid("bfa167f8-d408-453f-9b04-9ceb2b7f0246"), null, null, "PasswordUppercaseLetter", null, new Guid("00000000-0000-0000-0000-000000000001"), "En Az 1 Büyük Harf İçermelidir!" },
                    { new Guid("c2a907b5-3d3c-4db8-918a-25c1f8d58f9c"), null, null, "Delete", null, new Guid("00000000-0000-0000-0000-000000000001"), "Sil" },
                    { new Guid("c73ec3de-34ef-4af6-b8ff-58b8301f59c1"), null, null, "CouldNotBeVerifyCid", null, new Guid("00000000-0000-0000-0000-000000000002"), "Could not be verify Citizen Id" },
                    { new Guid("c763e34e-af05-4873-a498-4cf7ea49be9e"), null, null, "UsersGroups", null, new Guid("00000000-0000-0000-0000-000000000001"), "Kullanıcının Grupları" },
                    { new Guid("cd9c6df2-a6d1-4094-be07-1331a903fb79"), null, null, "Users", null, new Guid("00000000-0000-0000-0000-000000000002"), "Users" },
                    { new Guid("d2405333-264b-4edc-8ab2-8f3d80f04cbb"), null, null, "OperationClaimList", null, new Guid("00000000-0000-0000-0000-000000000001"), "Yetki Listesi" },
                    { new Guid("d3a8bc1e-1c94-4683-98b4-6f6f8b6dd665"), null, null, "NewPassword", null, new Guid("00000000-0000-0000-0000-000000000001"), "Yeni Parola:" },
                    { new Guid("d4dd9126-8e14-4b57-bd7a-f98cf8df97f0"), null, null, "DeleteConfirm", null, new Guid("00000000-0000-0000-0000-000000000002"), "Are you sure?" },
                    { new Guid("d671c02b-e8a9-4863-835d-3c2f4dfba8e9"), null, null, "Delete", null, new Guid("00000000-0000-0000-0000-000000000002"), "Delete" },
                    { new Guid("d7653777-52cc-445c-9f1f-998b375b930b"), null, null, "MobilePhones", null, new Guid("00000000-0000-0000-0000-000000000002"), "Mobile Phone" },
                    { new Guid("d8d34fc4-07e8-4a83-9343-297894f9190e"), null, null, "Add", null, new Guid("00000000-0000-0000-0000-000000000002"), "Add" },
                    { new Guid("da6e1bfb-0977-442a-b8a0-0ffc76859648"), null, null, "PasswordDigit", null, new Guid("00000000-0000-0000-0000-000000000002"), "It Must Contain At Least 1 Digit!" },
                    { new Guid("dd416331-3e10-4f97-a93a-173d3ca0be0d"), null, null, "TrueButCellPhone", null, new Guid("00000000-0000-0000-0000-000000000001"), "Bilgiler doğru. Cep telefonu gerekiyor." },
                    { new Guid("e242f465-afb3-4ddc-b66f-621c9e1e1c28"), null, null, "UsersClaims", null, new Guid("00000000-0000-0000-0000-000000000001"), "Kullanıcının Yetkileri" },
                    { new Guid("e250ac95-786f-4c17-9cd2-7bf92649b91d"), null, null, "PasswordSpecialCharacter", null, new Guid("00000000-0000-0000-0000-000000000001"), "En Az 1 Simge İçermelidir!" },
                    { new Guid("e32098c5-40b9-41a8-8b16-9953680bd7ae"), null, null, "DeleteConfirm", null, new Guid("00000000-0000-0000-0000-000000000001"), "Emin misiniz?" },
                    { new Guid("e3c3064a-8736-4acd-8b6e-41871c7e59b1"), null, null, "WrongCID", null, new Guid("00000000-0000-0000-0000-000000000002"), "Citizenship Number Not Found In Our System. Please Create New Registration!" },
                    { new Guid("e4732b0f-c92b-4e4c-9bb7-6b0cd5fddab7"), null, null, "TokenProviderException", null, new Guid("00000000-0000-0000-0000-000000000001"), "Token Provider boş olamaz!" },
                    { new Guid("e655c701-f834-478c-9ef3-7bbb35bb9063"), null, null, "Save", null, new Guid("00000000-0000-0000-0000-000000000001"), "Kaydet" },
                    { new Guid("e6844747-1501-4c32-a28d-ef7fe567b35b"), null, null, "OperationClaim", null, new Guid("00000000-0000-0000-0000-000000000001"), "Operasyon Yetkileri" },
                    { new Guid("eaf348e3-34ec-469b-8b36-d804f42e9cf1"), null, null, "Added", null, new Guid("00000000-0000-0000-0000-000000000002"), "Successfully Added." },
                    { new Guid("eb0c6188-631e-44be-a60c-3676742b93cd"), null, null, "TranslateList", null, new Guid("00000000-0000-0000-0000-000000000002"), "Translate List" },
                    { new Guid("eb8b3a0b-64db-48cd-9ff5-3ec52829f30f"), null, null, "GroupName", null, new Guid("00000000-0000-0000-0000-000000000002"), "Group Name" },
                    { new Guid("ec0d7ea4-8972-444c-afd5-47ca4a730372"), null, null, "Management", null, new Guid("00000000-0000-0000-0000-000000000002"), "Management" },
                    { new Guid("ecfc01a4-8e81-4bb7-be43-c9efecb75c0f"), null, null, "CouldNotBeVerifyCid", null, new Guid("00000000-0000-0000-0000-000000000001"), "Kimlik No Doğrulanamadı." },
                    { new Guid("ef5bce3b-2aa0-499e-a83a-6c0ff275eb2c"), null, null, "StringLengthMustBeGreaterThanThree", null, new Guid("00000000-0000-0000-0000-000000000001"), "Lütfen En Az 3 Karakterden Oluşan Bir İfade Girin." },
                    { new Guid("f010c381-2ad0-4ce1-8b11-bdd7e113bfa1"), null, null, "Unknown", null, new Guid("00000000-0000-0000-0000-000000000001"), "Bilinmiyor!" },
                    { new Guid("f02eb26c-f35f-4f1a-a3f0-a7afd180de08"), null, null, "UserList", null, new Guid("00000000-0000-0000-0000-000000000002"), "User List" },
                    { new Guid("f2c98d60-d082-40c9-b033-acf0304644ca"), null, null, "VerifyCid", null, new Guid("00000000-0000-0000-0000-000000000001"), "Kimlik No Doğrulandı." },
                    { new Guid("f311730f-b530-47b7-8808-0c6a1efb6bd5"), null, null, "PasswordLowercaseLetter", null, new Guid("00000000-0000-0000-0000-000000000002"), "Must Contain At Least 1 Lowercase Letter!" },
                    { new Guid("f355f3e9-19a4-421e-ba87-dc565bd06170"), null, null, "Languages", null, new Guid("00000000-0000-0000-0000-000000000002"), "Languages" },
                    { new Guid("f4e91339-71d6-4fe0-9a83-320920fd815b"), null, null, "Code", null, new Guid("00000000-0000-0000-0000-000000000001"), "Kod" },
                    { new Guid("f63ec4a7-c643-4f02-9c56-88e5c033284a"), null, null, "SendPassword", null, new Guid("00000000-0000-0000-0000-000000000002"), "Your new password has been sent to your e-mail address." },
                    { new Guid("f9b96034-0b5d-4fe1-a202-3852d3215e60"), null, null, "OperationClaimList", null, new Guid("00000000-0000-0000-0000-000000000002"), "OperationClaim List" },
                    { new Guid("fab96010-c98c-475a-912e-2aa09fe96118"), null, null, "PasswordEmpty", null, new Guid("00000000-0000-0000-0000-000000000001"), "Parola boş olamaz!" },
                    { new Guid("fbb1d28c-9672-46f6-8e59-19bc72611d4c"), null, null, "Management", null, new Guid("00000000-0000-0000-0000-000000000001"), "Yönetim" },
                    { new Guid("fc425c57-49f7-495f-8048-d06ce94c0847"), null, null, "Code", null, new Guid("00000000-0000-0000-0000-000000000002"), "Code" },
                    { new Guid("fc99313f-4762-4b6b-965f-89b3c169ebc4"), null, null, "PasswordLength", null, new Guid("00000000-0000-0000-0000-000000000002"), "Must be at least 8 characters long! " },
                    { new Guid("ff00562b-c25f-44ce-9128-2d2a48b87abf"), null, null, "ConfirmPassword", null, new Guid("00000000-0000-0000-0000-000000000002"), "Confirm Password" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_ChangedById",
                table: "Users",
                column: "ChangedById");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CreatedById",
                table: "Users",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_UserGroups_ChangedById",
                table: "UserGroups",
                column: "ChangedById");

            migrationBuilder.CreateIndex(
                name: "IX_UserGroups_CreatedById",
                table: "UserGroups",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_ChangedById",
                table: "UserClaims",
                column: "ChangedById");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_CreatedById",
                table: "UserClaims",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Translates_ChangedById",
                table: "Translates",
                column: "ChangedById");

            migrationBuilder.CreateIndex(
                name: "IX_Translates_CreatedById",
                table: "Translates",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_OperationClaims_ChangedById",
                table: "OperationClaims",
                column: "ChangedById");

            migrationBuilder.CreateIndex(
                name: "IX_OperationClaims_CreatedById",
                table: "OperationClaims",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_MobileLogins_ChangedById",
                table: "MobileLogins",
                column: "ChangedById");

            migrationBuilder.CreateIndex(
                name: "IX_MobileLogins_CreatedById",
                table: "MobileLogins",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_ChangedById",
                table: "Locations",
                column: "ChangedById");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CreatedById",
                table: "Locations",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_ChangedById",
                table: "Languages",
                column: "ChangedById");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_CreatedById",
                table: "Languages",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_ChangedById",
                table: "Groups",
                column: "ChangedById");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_CreatedById",
                table: "Groups",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_GroupClaims_ChangedById",
                table: "GroupClaims",
                column: "ChangedById");

            migrationBuilder.CreateIndex(
                name: "IX_GroupClaims_CreatedById",
                table: "GroupClaims",
                column: "CreatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupClaims_Users_ChangedById",
                table: "GroupClaims",
                column: "ChangedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupClaims_Users_CreatedById",
                table: "GroupClaims",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Users_ChangedById",
                table: "Groups",
                column: "ChangedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Users_CreatedById",
                table: "Groups",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_Users_ChangedById",
                table: "Languages",
                column: "ChangedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_Users_CreatedById",
                table: "Languages",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Users_ChangedById",
                table: "Locations",
                column: "ChangedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Users_CreatedById",
                table: "Locations",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MobileLogins_Users_ChangedById",
                table: "MobileLogins",
                column: "ChangedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MobileLogins_Users_CreatedById",
                table: "MobileLogins",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OperationClaims_Users_ChangedById",
                table: "OperationClaims",
                column: "ChangedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OperationClaims_Users_CreatedById",
                table: "OperationClaims",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Translates_Users_ChangedById",
                table: "Translates",
                column: "ChangedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Translates_Users_CreatedById",
                table: "Translates",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserClaims_Users_ChangedById",
                table: "UserClaims",
                column: "ChangedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserClaims_Users_CreatedById",
                table: "UserClaims",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserGroups_Users_ChangedById",
                table: "UserGroups",
                column: "ChangedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserGroups_Users_CreatedById",
                table: "UserGroups",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_ChangedById",
                table: "Users",
                column: "ChangedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_CreatedById",
                table: "Users",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupClaims_Users_ChangedById",
                table: "GroupClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupClaims_Users_CreatedById",
                table: "GroupClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Users_ChangedById",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Users_CreatedById",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Languages_Users_ChangedById",
                table: "Languages");

            migrationBuilder.DropForeignKey(
                name: "FK_Languages_Users_CreatedById",
                table: "Languages");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Users_ChangedById",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Users_CreatedById",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_MobileLogins_Users_ChangedById",
                table: "MobileLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_MobileLogins_Users_CreatedById",
                table: "MobileLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_OperationClaims_Users_ChangedById",
                table: "OperationClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_OperationClaims_Users_CreatedById",
                table: "OperationClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_Translates_Users_ChangedById",
                table: "Translates");

            migrationBuilder.DropForeignKey(
                name: "FK_Translates_Users_CreatedById",
                table: "Translates");

            migrationBuilder.DropForeignKey(
                name: "FK_UserClaims_Users_ChangedById",
                table: "UserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserClaims_Users_CreatedById",
                table: "UserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserGroups_Users_ChangedById",
                table: "UserGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_UserGroups_Users_CreatedById",
                table: "UserGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_ChangedById",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_CreatedById",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ChangedById",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CreatedById",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserGroups",
                table: "UserGroups");

            migrationBuilder.DropIndex(
                name: "IX_UserGroups_ChangedById",
                table: "UserGroups");

            migrationBuilder.DropIndex(
                name: "IX_UserGroups_CreatedById",
                table: "UserGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserClaims",
                table: "UserClaims");

            migrationBuilder.DropIndex(
                name: "IX_UserClaims_ChangedById",
                table: "UserClaims");

            migrationBuilder.DropIndex(
                name: "IX_UserClaims_CreatedById",
                table: "UserClaims");

            migrationBuilder.DropIndex(
                name: "IX_Translates_ChangedById",
                table: "Translates");

            migrationBuilder.DropIndex(
                name: "IX_Translates_CreatedById",
                table: "Translates");

            migrationBuilder.DropIndex(
                name: "IX_OperationClaims_ChangedById",
                table: "OperationClaims");

            migrationBuilder.DropIndex(
                name: "IX_OperationClaims_CreatedById",
                table: "OperationClaims");

            migrationBuilder.DropIndex(
                name: "IX_MobileLogins_ChangedById",
                table: "MobileLogins");

            migrationBuilder.DropIndex(
                name: "IX_MobileLogins_CreatedById",
                table: "MobileLogins");

            migrationBuilder.DropIndex(
                name: "IX_Locations_ChangedById",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_CreatedById",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Languages_ChangedById",
                table: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_Languages_CreatedById",
                table: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_Groups_ChangedById",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_CreatedById",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_GroupClaims_ChangedById",
                table: "GroupClaims");

            migrationBuilder.DropIndex(
                name: "IX_GroupClaims_CreatedById",
                table: "GroupClaims");

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("01ad5028-2572-4e2b-b279-f5876a78e32c"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("025340c6-57c2-4a25-b5ba-56048c673727"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("02c8d7ad-9dca-4aef-842c-aef67391f25e"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("031b838a-ee12-4a25-8221-63e6574ae994"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("03a68caf-a62d-4945-a54c-75747c458ed7"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("03bf1769-5f67-4a16-b4c8-77ff4251ea9a"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("04316bc7-3677-4b71-a514-e3a44a4536a9"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("058909b0-fea2-41dc-a29c-a7543cfe115c"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("05ee1bf2-2342-48ea-8bdc-36df2ac56f77"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("0dcfdc22-b5e5-429d-8de6-617b7830a277"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("105c248c-8b72-4869-a2b5-db42ce4062ee"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("112dd912-ab67-433f-9e96-c10a97107bbe"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("179079b4-a238-4b67-a09b-2ab15ea865e8"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("183cddb5-1ba7-4ac5-a4f2-4d1fbe2535f6"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("1a9c58a1-4d0f-4ce6-a648-30338a1300be"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("1aad2e1b-6b98-42bb-9440-43095fdc4825"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("24cf8451-ac95-42d5-9725-b0d9e53aa80c"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("25f60e8b-bca5-4181-a22d-962edbad4a0b"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("28ed6892-0568-4681-a488-363fb36190fe"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("29e5bfe9-ef63-4108-ae52-b73aab43dccd"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("2d47a601-a2c5-4191-9d41-b5ce6480a57f"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("2ee8dfad-f47c-436e-9549-2dffa891736f"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("31659afe-ad5f-42a3-87eb-bbafe6add7f2"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("359cd498-a3ab-4882-956e-9ab5e587a08a"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("36d2bb6e-44cc-44de-97ca-dc3f8661091b"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("38b84d2e-af2d-4591-be54-d89f9dea9952"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("38baef77-4d72-4829-9a13-e222d25d6bc0"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("3bab3f08-b6a2-422d-acd3-401c6d2e932c"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("3dae52f9-2a53-4761-9d2c-516b44dfffba"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("41cf931d-2c4a-4ecf-9943-f8e6a74ea159"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("436ca114-f0f2-4430-8b5e-e5606afa87a7"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("46f6863e-a46f-4157-a9eb-fa001a7ef570"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("4a99746b-9080-4454-a465-38b07c17bfe6"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("4aff797c-eef3-4e75-b1b5-2b28803c42f1"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("4e2ad1d5-9ba2-40f9-9df5-4d793bee2769"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("4f7ae65e-66fe-4a5e-b2bc-d6807bea0160"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("50a14e42-6b5b-4aa7-823c-cc72da1ab9b5"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("51923bb2-eb38-4fc1-b5e2-2e31e089919a"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("5195bb25-ceff-46b7-b495-7d146ed5bc18"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("52706703-0359-4abd-a368-bc0cf2f8d26d"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("5436878a-6df9-495e-8419-94c07c27397f"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("55f181f9-2694-41e8-be23-cababe351ec4"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("58f1c7ec-e5bd-44e2-9d4c-efc446392afa"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("5ab3ee59-fbc3-4d4e-83d3-fdc2071f5383"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("5c43273a-b9c0-4427-8334-d4663b4d6714"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("5dababda-5244-4efd-a69a-abc781476613"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("5e34c907-c3c3-4dfe-ab79-5dda65c398ee"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("5e99ac4e-117b-41a6-be28-688c40e9c298"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("62675537-9c04-4901-8bda-347e89eb34ba"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("65736f5b-0378-4be5-be37-87d966d534b7"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("65cf8455-3181-43bb-82ab-5b5e06f68325"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("66c1f596-c96d-4d08-abd8-b8ec5d9f7359"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("6a161498-39f5-4c7e-9716-c31896c3aabf"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("6a525c7c-671b-4cad-9e9c-e80a1a7401c0"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("6bc94fed-05c7-421e-aa8d-0681388392c1"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("6c3346b5-7855-4c92-92f3-a610d76c287e"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("6d3e8286-5fa2-48af-b9af-20fc0819ac0f"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("6e24bd8e-cd8a-471b-8abc-5b2f7a3d393f"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("6eb36ac9-d0ea-4cc5-a6dd-a6f4ec1533a2"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("6fd4a892-947e-4bb7-a12a-6f94d752627d"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("6ff8dc64-a7d0-4762-bf9b-92678a623338"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("73677ab1-8bd1-4528-aed6-11a9567a2750"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("749a7219-3d8b-4d24-9ad4-6ff57eda67a5"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("75337d5b-4abb-4433-9f46-e146749e8497"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("7a8187af-c468-4a81-ad87-eea9c4ab304a"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("7bc1078c-6f41-4bfd-9225-594abbe37f6c"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("7e0a4a47-1aea-4d29-85ac-230050333957"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("836a5d61-59a0-40f4-8f13-bf8ddca7a36a"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("8f55f4c4-5178-4589-9ab8-f77a868dbc04"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("929707d6-9541-4218-bcab-5628a7827441"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("93176ebf-c1cf-4fa4-aeeb-9d540da8c132"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("95182d4f-602c-4c21-ba97-99569e9df769"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("95feaba9-1971-4f59-b1f2-bedbf04c6a8b"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("968f5bb6-9e8b-4469-bf77-6c07986fbc97"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("96e7ed42-4522-44f5-9ea7-ef74c923df9b"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("979548d8-294b-4bc9-95f6-b06722a4c0ea"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("99761575-78ef-4c8d-813c-363005496031"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("9b65e1c9-849f-421c-b4eb-344a1b7e162c"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("9c248340-160f-4b92-aacc-e1a04a5f051f"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("9c7e82ad-9e8a-4a2e-80ce-0ef7710ecf46"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("a058eeca-efc6-47de-af48-cc8d4ff6c718"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("a1a83d01-83c4-4c14-867e-57ffe281dc3e"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("a8a96e60-ddc3-485e-9415-fc4019caa17d"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("aa720b5a-3638-40ce-843a-d5204e9d595f"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("ab250938-b321-4dc6-879d-52b512f7cd01"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("ab6630e8-9139-4dbe-b5fa-9938f45c7efb"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("ab99a081-3515-4085-aff4-bddff2b7d2ef"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("ab9cf431-d64e-426f-8467-4ec5a2ef960b"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("ad6d3c31-e606-4cae-8bed-caa817eac454"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("ad6dc560-451b-43ba-bd63-277386239aae"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("af431c8b-f639-4837-a180-08bbe63eaac1"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("b1156835-f782-4e38-a55d-b01ebb6d48bf"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("b14ead32-2f58-4ce5-b99a-bba283fce9db"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("b1cf58c4-fb6c-4b59-b088-29c7c47efd60"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("b5574132-ef93-4a86-8a14-45c15282d95b"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("b910e866-66c9-42ff-9fa1-88dc833ffa39"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("b92a212b-6a2e-43a8-b993-87f3992d9918"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("ba3e41bb-c8d2-4d3d-ab58-e817c78efb00"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("bb5839ae-1842-403d-9610-294d5cf1b977"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("bfa167f8-d408-453f-9b04-9ceb2b7f0246"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("c2a907b5-3d3c-4db8-918a-25c1f8d58f9c"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("c73ec3de-34ef-4af6-b8ff-58b8301f59c1"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("c763e34e-af05-4873-a498-4cf7ea49be9e"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("cd9c6df2-a6d1-4094-be07-1331a903fb79"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("d2405333-264b-4edc-8ab2-8f3d80f04cbb"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("d3a8bc1e-1c94-4683-98b4-6f6f8b6dd665"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("d4dd9126-8e14-4b57-bd7a-f98cf8df97f0"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("d671c02b-e8a9-4863-835d-3c2f4dfba8e9"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("d7653777-52cc-445c-9f1f-998b375b930b"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("d8d34fc4-07e8-4a83-9343-297894f9190e"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("da6e1bfb-0977-442a-b8a0-0ffc76859648"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("dd416331-3e10-4f97-a93a-173d3ca0be0d"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e242f465-afb3-4ddc-b66f-621c9e1e1c28"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e250ac95-786f-4c17-9cd2-7bf92649b91d"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e32098c5-40b9-41a8-8b16-9953680bd7ae"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e3c3064a-8736-4acd-8b6e-41871c7e59b1"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e4732b0f-c92b-4e4c-9bb7-6b0cd5fddab7"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e655c701-f834-478c-9ef3-7bbb35bb9063"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("e6844747-1501-4c32-a28d-ef7fe567b35b"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("eaf348e3-34ec-469b-8b36-d804f42e9cf1"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("eb0c6188-631e-44be-a60c-3676742b93cd"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("eb8b3a0b-64db-48cd-9ff5-3ec52829f30f"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("ec0d7ea4-8972-444c-afd5-47ca4a730372"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("ecfc01a4-8e81-4bb7-be43-c9efecb75c0f"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("ef5bce3b-2aa0-499e-a83a-6c0ff275eb2c"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("f010c381-2ad0-4ce1-8b11-bdd7e113bfa1"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("f02eb26c-f35f-4f1a-a3f0-a7afd180de08"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("f2c98d60-d082-40c9-b033-acf0304644ca"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("f311730f-b530-47b7-8808-0c6a1efb6bd5"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("f355f3e9-19a4-421e-ba87-dc565bd06170"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("f4e91339-71d6-4fe0-9a83-320920fd815b"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("f63ec4a7-c643-4f02-9c56-88e5c033284a"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("f9b96034-0b5d-4fe1-a202-3852d3215e60"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("fab96010-c98c-475a-912e-2aa09fe96118"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("fbb1d28c-9672-46f6-8e59-19bc72611d4c"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("fc425c57-49f7-495f-8048-d06ce94c0847"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("fc99313f-4762-4b6b-965f-89b3c169ebc4"));

            migrationBuilder.DeleteData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: new Guid("ff00562b-c25f-44ce-9128-2d2a48b87abf"));

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Users",
                newName: "MobilePhones");

            migrationBuilder.RenameColumn(
                name: "CreatedById",
                table: "Users",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "ChangedById",
                table: "Users",
                newName: "ChangedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Users_PhoneNumber",
                table: "Users",
                newName: "IX_Users_MobilePhones");

            migrationBuilder.RenameColumn(
                name: "CreatedById",
                table: "UserGroups",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "ChangedById",
                table: "UserGroups",
                newName: "ChangedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedById",
                table: "UserClaims",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "ChangedById",
                table: "UserClaims",
                newName: "ChangedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedById",
                table: "Translates",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "ChangedById",
                table: "Translates",
                newName: "ChangedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedById",
                table: "OperationClaims",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "ChangedById",
                table: "OperationClaims",
                newName: "ChangedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedById",
                table: "MobileLogins",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "ChangedById",
                table: "MobileLogins",
                newName: "ChangedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedById",
                table: "Locations",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "ChangedById",
                table: "Locations",
                newName: "ChangedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedById",
                table: "Languages",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "ChangedById",
                table: "Languages",
                newName: "ChangedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedById",
                table: "Groups",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "ChangedById",
                table: "Groups",
                newName: "ChangedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedById",
                table: "GroupClaims",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "ChangedById",
                table: "GroupClaims",
                newName: "ChangedBy");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Users",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2022, 9, 3, 17, 51, 11, 917, DateTimeKind.Local).AddTicks(8950),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 9, 17, 16, 29, 8, 471, DateTimeKind.Local).AddTicks(993));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Changed",
                table: "Users",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Users",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Users",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Users",
                type: "character varying(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserGroups",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 9, 17, 16, 29, 8, 471, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Changed",
                table: "UserGroups",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserClaims",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 9, 17, 16, 29, 8, 471, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Changed",
                table: "UserClaims",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Translates",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 9, 17, 16, 29, 8, 470, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Changed",
                table: "Translates",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "OperationClaims",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 9, 17, 16, 29, 8, 470, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Changed",
                table: "OperationClaims",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SendDate",
                table: "MobileLogins",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "MobileLogins",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 9, 17, 16, 29, 8, 470, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Changed",
                table: "MobileLogins",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "TimeStamp",
                table: "Logs",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Locations",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Changed",
                table: "Locations",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Languages",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 9, 17, 16, 29, 8, 470, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Changed",
                table: "Languages",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Groups",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 9, 17, 16, 29, 8, 470, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Changed",
                table: "Groups",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "GroupClaims",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 9, 17, 16, 29, 8, 470, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Changed",
                table: "GroupClaims",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserGroups",
                table: "UserGroups",
                columns: new[] { "UserId", "GroupId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserClaims",
                table: "UserClaims",
                columns: new[] { "Id", "UserId", "ClaimId" });

            migrationBuilder.InsertData(
                table: "Translates",
                columns: new[] { "Id", "Changed", "ChangedBy", "Code", "Created", "CreatedBy", "LangId", "Value" },
                values: new object[,]
                {
                    { new Guid("013a7ba9-0839-43d8-8622-46e1cc36b06d"), null, null, "UsersClaims", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kullanıcının Yetkileri" },
                    { new Guid("034364d2-a01f-4302-a7b5-e951d5950ff8"), null, null, "TrueButCellPhone", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "The information is correct. Cell phone is required." },
                    { new Guid("05e45e43-7c8a-428a-a2bc-b5dab2fd35c1"), null, null, "PasswordLowercaseLetter", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Must Contain At Least 1 Lowercase Letter!" },
                    { new Guid("0a2facd0-4bc4-4094-aca7-a68559e6d10f"), null, null, "Update", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Update" },
                    { new Guid("0b0589a0-f4cd-404a-b757-c68f0724319e"), null, null, "CouldNotBeVerifyCid", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Could not be verify Citizen Id" },
                    { new Guid("0e407368-440e-48dc-8072-e5aff375f191"), null, null, "DeleteConfirm", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Are you sure?" },
                    { new Guid("0f888893-eeac-4e1a-bb1e-060e389de08a"), null, null, "SendMobileCode", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Lütfen Size SMS Olarak Gönderilen Kodu Girin!" },
                    { new Guid("10e85791-f77e-4e68-af93-454a3418ed15"), null, null, "StringLengthMustBeGreaterThanThree", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Please Enter A Phrase Of At Least 3 Characters." },
                    { new Guid("14d885d9-31a0-409f-a6ee-a53f94fb64a3"), null, null, "OperationClaimExists", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Bu operasyon izni zaten mevcut." },
                    { new Guid("1bf7c9c9-f246-4b1b-9cd9-c6a9e1531d48"), null, null, "MobilePhones", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Mobile Phone" },
                    { new Guid("1e704e78-8dcb-4eb4-bb26-10d4b9f76d49"), null, null, "LogList", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "LogList" },
                    { new Guid("1f498a9f-d573-419d-8c05-b25fa38916d4"), null, null, "GroupName", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Grup Adı" },
                    { new Guid("22956e88-5aeb-4c45-b9f9-986dcd3e4bf7"), null, null, "Notes", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Notlar" },
                    { new Guid("233e4da5-a506-416d-b573-00d43bbdcd49"), null, null, "Create", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Create" },
                    { new Guid("25ad6665-690b-4dfb-b84f-01c273c3d1fe"), null, null, "NameAlreadyExist", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Oluşturmaya Çalıştığınız Nesne Zaten Var." },
                    { new Guid("29caa88a-7f63-4f6e-a0f0-19891ba8705a"), null, null, "FullName", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Tam Adı" },
                    { new Guid("2b1bd578-8973-4005-b63d-6b7361b57ac7"), null, null, "SmsServiceNotFound", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Unable to Reach SMS Service." },
                    { new Guid("2dbf2550-3925-4872-8c46-4ba51239a735"), null, null, "VerifyCid", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Verify Citizen Id" },
                    { new Guid("2f9e9eb0-b89f-4050-8e9f-4b540ffb9ea8"), null, null, "StringLengthMustBeGreaterThanThree", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Lütfen En Az 3 Karakterden Oluşan Bir İfade Girin." },
                    { new Guid("2fe1a353-8415-42e9-a9a5-40a9b2a2fcc3"), null, null, "Management", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Yönetim" },
                    { new Guid("337f5398-c1fd-49b2-a7db-7855b4098ddb"), null, null, "UserNotFound", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Credentials Could Not Verify. Please use the New Registration Screen." },
                    { new Guid("33bf6e9a-827e-40d6-bf91-69287a614131"), null, null, "Alias", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Alias" },
                    { new Guid("33d9bedc-ba44-4005-a337-98655be7c75c"), null, null, "Permissions", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Permissions" },
                    { new Guid("35094886-a959-4aa4-ab6f-ba278fd3e4c2"), null, null, "VerifyCid", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kimlik No Doğrulandı." },
                    { new Guid("3543189f-b9cb-4eb0-b60c-46f158ac52d7"), null, null, "PasswordDigit", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "It Must Contain At Least 1 Digit!" },
                    { new Guid("362eeb42-78d6-4521-85b9-3dfa266cc508"), null, null, "Name", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Name" },
                    { new Guid("3641fdb9-1328-472b-b860-be9c9068a529"), null, null, "PasswordError", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Credentials Failed to Authenticate, Username and / or password incorrect." },
                    { new Guid("367dd424-398c-47bb-a96e-4f4c13b71459"), null, null, "Deleted", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Başarıyla Silindi." },
                    { new Guid("38957c5a-53f4-417c-a860-f56b814fd256"), null, null, "WrongCID", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Citizenship Number Not Found In Our System. Please Create New Registration!" },
                    { new Guid("395c3f3a-c837-4621-9c35-a63d8bc2e783"), null, null, "Management", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Management" },
                    { new Guid("3c10378e-a38f-4a84-ae8c-eacb94e7fcdc"), null, null, "ChangePassword", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Parola Değiştir" },
                    { new Guid("3e3c9085-9375-4362-b0ef-e8145a6c3a50"), null, null, "PasswordSpecialCharacter", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "En Az 1 Simge İçermelidir!" },
                    { new Guid("42601b4c-0d3b-4e0a-85f5-a6e02589a60a"), null, null, "GroupList", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Grup Listesi" },
                    { new Guid("427f092b-4498-4f3a-b0e4-6995562d57fa"), null, null, "PasswordUppercaseLetter", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "En Az 1 Büyük Harf İçermelidir!" },
                    { new Guid("4289222e-22b8-43fe-b1bd-2951806ca16a"), null, null, "AppMenu", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Application" },
                    { new Guid("4464ac2e-2e3c-4717-b272-2a0c1be011fa"), null, null, "Address", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Address" },
                    { new Guid("44ab149a-c4ea-4a64-a027-e8fb98b74fd5"), null, null, "PasswordError", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kimlik Bilgileri Doğrulanamadı, Kullanıcı adı ve/veya parola hatalı." },
                    { new Guid("45e55b4e-f6f7-4d59-9265-d52356e010ae"), null, null, "Code", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Code" },
                    { new Guid("46c0e8f9-4e22-4d40-9f1b-18ef9b5878f1"), null, null, "SuccessfulLogin", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Sisteme giriş başarılı." },
                    { new Guid("477bf374-e326-4100-a99b-4812308ff56e"), null, null, "SendPassword", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Yeni Parolanız E-Posta Adresinize Gönderildi." },
                    { new Guid("4c310082-5b3f-4cd9-8181-7e24fddb2e11"), null, null, "Updated", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Successfully Updated." },
                    { new Guid("4c5f7735-c44e-450b-95ef-986af57595e5"), null, null, "Deleted", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Successfully Deleted." },
                    { new Guid("4d0fae81-9798-4790-82ee-ddb2aea0b760"), null, null, "Users", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kullanıcılar" },
                    { new Guid("4e2ddcee-9598-4958-8308-5187dc9f4e9c"), null, null, "Required", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Bu alan zorunludur!" },
                    { new Guid("4e45438f-2fd3-4f71-b11c-de07ea79437a"), null, null, "DeleteConfirm", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Emin misiniz?" },
                    { new Guid("4f0cd345-79c6-402a-a455-deba147e609e"), null, null, "Login", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Login" },
                    { new Guid("4f7a681e-0d5d-4c5b-9a9e-e85f7df65961"), null, null, "GrupPermissions", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Grup Permissions" },
                    { new Guid("50d8bfab-33b6-46ef-8168-39a6f8743db3"), null, null, "UserList", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kullanıcı Listesi" },
                    { new Guid("51984db9-958f-4a11-842d-acd106976b15"), null, null, "PasswordLength", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Must be at least 8 characters long! " },
                    { new Guid("534ee674-f5c8-4764-a602-9582c896cca9"), null, null, "Added", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Successfully Added." },
                    { new Guid("53fc4e1b-5de8-4d48-b81b-1f2458829537"), null, null, "Required", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "This field is required!" },
                    { new Guid("57a5ec1a-a281-4bc0-afee-6f315f7bd1af"), null, null, "Create", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Yeni" },
                    { new Guid("5bb4482e-ec50-4cb7-950f-49ead7d4ce29"), null, null, "NewPassword", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "New Password:" },
                    { new Guid("5c57297f-585d-41e6-bb1a-670a6b523287"), null, null, "Unknown", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Unknown!" },
                    { new Guid("5dbaaeb8-ba0b-4022-9261-ec45789b4789"), null, null, "OperationClaimExists", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "This operation permit already exists." },
                    { new Guid("6428e509-d82c-4683-9148-94e5a398a9d1"), null, null, "Add", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Ekle" },
                    { new Guid("64ea33a5-fa13-4820-9484-e49206009f93"), null, null, "Added", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Başarıyla Eklendi." },
                    { new Guid("66b3c7e4-dae1-4e10-b387-774cad442870"), null, null, "GrupPermissions", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Grup Yetkileri" },
                    { new Guid("67a91588-f63c-4fe8-a7f1-c83bd5c91b46"), null, null, "Login", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Giriş" },
                    { new Guid("68dc4b37-71b5-405a-ba44-21276be04ce1"), null, null, "NameAlreadyExist", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "The Object You Are Trying To Create Already Exists." },
                    { new Guid("6987697d-fa42-4a03-a6cb-bff0ae26dcfe"), null, null, "Languages", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Diller" },
                    { new Guid("69d1041f-92e4-4d2d-a50a-2b158ed82cf5"), null, null, "PasswordEmpty", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Parola boş olamaz!" },
                    { new Guid("6ac74305-bcf9-4af7-8121-7ced8538c8dc"), null, null, "GroupList", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Group List" },
                    { new Guid("6c166cbf-25cb-4b11-a0b5-156bef19af57"), null, null, "AuthorizationsDenied", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Yetkiniz olmayan bir alana girmeye çalıştığınız tespit edildi." },
                    { new Guid("6c18b231-10bd-4823-b2a3-e6994eb299a7"), null, null, "PasswordUppercaseLetter", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Must Contain At Least 1 Capital Letter!" },
                    { new Guid("6df7210a-a96a-49b1-88ee-ab7c677190a5"), null, null, "FullName", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Full Name" },
                    { new Guid("6ea9cf4f-c373-47b3-aee2-d7e1e7a7eb2e"), null, null, "TranslateWords", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Translate Words" },
                    { new Guid("6ffcf7d6-8b05-4a79-81d9-c21f93e6b1b8"), null, null, "Password", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Parola" },
                    { new Guid("70236ef5-e6da-405e-8714-2471c039dff8"), null, null, "Permissions", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "İzinler" },
                    { new Guid("718e6779-c256-462b-a09b-85a836fe8237"), null, null, "LangCode", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Lang Code" },
                    { new Guid("71eee4d6-6c30-4b9d-a808-1e544aa2d38f"), null, null, "Value", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Değer" },
                    { new Guid("726e00cc-d6eb-4f88-9ba6-43ad47d0a6b6"), null, null, "NewPassword", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Yeni Parola:" },
                    { new Guid("7425e542-24c1-4f16-b034-76e327fbe817"), null, null, "Save", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kaydet" },
                    { new Guid("74c6b1b0-f295-4dd8-a06a-4f291464c2f9"), null, null, "LanguageList", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Dil Listesi" },
                    { new Guid("78212d3e-cb08-4432-b616-6b33f73f10e3"), null, null, "Notes", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Notes" },
                    { new Guid("7a1329a6-fc6b-49d2-9030-27fb58cc6da1"), null, null, "CouldNotBeVerifyCid", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kimlik No Doğrulanamadı." },
                    { new Guid("7daed0fc-d389-4f3d-8fea-c932d0059352"), null, null, "Name", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Adı" },
                    { new Guid("80e3f153-fbb0-49b7-9d93-4051eb53ef4f"), null, null, "Email", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "E posta" },
                    { new Guid("80e64156-3296-4f62-9537-6709f9d853f2"), null, null, "TranslateWords", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Dil Çevirileri" },
                    { new Guid("816b1c16-2a00-4542-8cd0-3de8322d6309"), null, null, "OperationClaimList", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "OperationClaim List" },
                    { new Guid("84b68c50-ded4-42da-a03b-b4bbd2c86bad"), null, null, "ChangePassword", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Change Password" },
                    { new Guid("84db0902-a581-4c97-bb7e-b64cec24b66d"), null, null, "OperationClaimList", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Yetki Listesi" },
                    { new Guid("855cf178-4e53-418c-b40a-7d8bcaddb111"), null, null, "Password", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Password" },
                    { new Guid("89983521-3755-46d0-bcec-2cf7605815c0"), null, null, "CID", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Citizenship Number" },
                    { new Guid("914f962b-ded6-4b64-ba01-514fb4b7db84"), null, null, "NoRecordsFound", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "No Records Found" },
                    { new Guid("91b6712f-d2f6-4911-904c-0bf58f62b571"), null, null, "UsersClaims", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "User's Claims" },
                    { new Guid("92afe69e-8bc0-45d6-8f56-b4a78f65ac5f"), null, null, "SendMobileCode", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Please Enter The Code Sent To You By SMS!" },
                    { new Guid("92be6481-5e61-43ef-92c9-fcfd858dd9f6"), null, null, "Groups", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Groups" },
                    { new Guid("982172c2-cc96-4267-8901-3a209c2009cb"), null, null, "Email", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Email" },
                    { new Guid("98a94961-439f-44f4-bf23-6e518655393b"), null, null, "TranslateList", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Translate List" },
                    { new Guid("a10fa7db-d440-4a8d-91fc-e10b0b72b1b9"), null, null, "Languages", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Languages" },
                    { new Guid("a1e9797e-c489-4db5-ac3a-ba896857379d"), null, null, "InvalidCode", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Geçersiz Bir Kod Girdiniz!" },
                    { new Guid("a701c71a-2bfe-4b46-899a-0d42901910e6"), null, null, "Update", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Güncelle" },
                    { new Guid("ab053920-92d7-4f33-b7a5-20968396c414"), null, null, "UserNotFound", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kimlik Bilgileri Doğrulanamadı. Lütfen Yeni Kayıt Ekranını kullanın." },
                    { new Guid("ac328a4d-a592-4063-b2af-1c01877bd07d"), null, null, "UsersGroups", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "User's Groups" },
                    { new Guid("ac4d9f4b-c2b4-4377-8b4c-9ae17816a0fd"), null, null, "PasswordEmpty", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Password can not be empty!" },
                    { new Guid("aca0834b-56ae-4c4a-89a7-7ec8b6fd8bdc"), null, null, "OperationClaim", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Operation Claim" },
                    { new Guid("ad09e4fe-ed0e-42fb-a9ab-7f8841211a4d"), null, null, "Save", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Save" },
                    { new Guid("adc9d9be-642d-41ee-855a-45537af55af7"), null, null, "Users", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Users" },
                    { new Guid("afb00f47-ca22-4ddf-a1dc-9311ed68cbf3"), null, null, "AuthorizationsDenied", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "It has been detected that you are trying to enter an area that you do not have authorization." },
                    { new Guid("b18c2e27-1075-4ecb-a88e-07975b1d19a8"), null, null, "WrongCID", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Vatandaşlık No Sistemimizde Bulunamadı. Lütfen Yeni Kayıt Oluşturun!" },
                    { new Guid("b5e793bd-8fdf-4cb7-b38a-9f7443b5af9a"), null, null, "Description", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Description" },
                    { new Guid("b988a369-d413-4da6-a738-34c09a999616"), null, null, "Address", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Adres" },
                    { new Guid("b9bf3e22-8f6c-44cf-a60a-69f5c7083ada"), null, null, "InvalidCode", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "You Entered An Invalid Code!" },
                    { new Guid("baefbda2-234d-4001-a1ff-67073a782309"), null, null, "PasswordDigit", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "En Az 1 Rakam İçermelidir!" },
                    { new Guid("bc3db746-ab46-4368-89cc-c2e7da2800c5"), null, null, "LanguageList", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Language List" },
                    { new Guid("bcb84637-00d2-4d73-8c00-fb923bb9e4a3"), null, null, "SendPassword", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Your new password has been sent to your e-mail address." },
                    { new Guid("bd87bf74-0ea6-443e-88fc-e15fa60bb9b1"), null, null, "Updated", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Başarıyla Güncellendi." },
                    { new Guid("bfc8c8b4-4ae6-4f27-8307-8671434d312e"), null, null, "Alias", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Görünen Ad" },
                    { new Guid("c0d3fc59-07e8-4a1c-9da9-c21c4096bb09"), null, null, "ConfirmPassword", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Parolayı Doğrula" },
                    { new Guid("c21cbbb7-b546-446e-8fd1-95f8918d1111"), null, null, "TrueButCellPhone", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Bilgiler doğru. Cep telefonu gerekiyor." },
                    { new Guid("c3da3b2b-1363-48de-b276-b1708ab42695"), null, null, "UserList", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "User List" },
                    { new Guid("c96aecb2-8d95-4194-a935-c29fc342a6a6"), null, null, "NoRecordsFound", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kayıt Bulunamadı" },
                    { new Guid("d0d54f9f-4068-41f4-a275-4b8ec51d8c43"), null, null, "Delete", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Sil" },
                    { new Guid("d1bc350e-a6c4-417f-bf43-0b9054327e4c"), null, null, "Description", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Açıklama" },
                    { new Guid("d2997564-39d1-4fcf-b76a-a4d341283acb"), null, null, "ConfirmPassword", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Confirm Password" },
                    { new Guid("d3b0ea13-8fd0-4bcd-97b6-acf95ef5a361"), null, null, "TranslateList", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Dil Çeviri Listesi" },
                    { new Guid("d584c5c3-bd72-4d0e-98e9-f90fbb742af2"), null, null, "AppMenu", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Uygulama" },
                    { new Guid("d5d72c4c-d7d0-4d55-8ad3-6a7130945a77"), null, null, "Code", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kod" },
                    { new Guid("d65073c1-1f8c-4d0d-8e98-00ed825fc530"), null, null, "GroupName", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Group Name" },
                    { new Guid("d6b7a2f7-ffcf-4306-b39d-06d02c68275d"), null, null, "SmsServiceNotFound", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "SMS Servisine Ulaşılamıyor." },
                    { new Guid("d9b6db3d-cbac-4778-a0c6-5b70c71f656e"), null, null, "LangCode", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Dil Kodu" },
                    { new Guid("dd7dadc2-a942-4968-b170-fc0ce9a032de"), null, null, "CID", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Vatandaşlık No" },
                    { new Guid("e1533612-c1fc-4d88-8014-eb779387b915"), null, null, "UsersGroups", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kullanıcının Grupları" },
                    { new Guid("e195d01f-0c4c-4247-b551-fb5b41c08725"), null, null, "LogList", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "İşlem Kütüğü" },
                    { new Guid("e39b570a-d485-4408-a79e-c41801bd0c61"), null, null, "Unknown", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Bilinmiyor!" },
                    { new Guid("e4f6f0ba-5f0a-4368-b0eb-e2a820a3b86b"), null, null, "PasswordLowercaseLetter", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "En Az 1 Küçük Harf İçermelidir!" },
                    { new Guid("e5588741-9469-4758-b57d-051280034679"), null, null, "Delete", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Delete" },
                    { new Guid("e5820841-bc43-4591-9810-00b2d90381e8"), null, null, "Groups", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Gruplar" },
                    { new Guid("e59b4cf7-700a-4861-a23a-006f778c2896"), null, null, "OperationClaim", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Operasyon Yetkileri" },
                    { new Guid("e7d57b1b-f533-42a8-85ae-5200682177b3"), null, null, "Add", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Add" },
                    { new Guid("e9db04b9-6042-4452-a67a-fee3f3920bb2"), null, null, "PasswordSpecialCharacter", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Must Contain At Least 1 Symbol!" },
                    { new Guid("ea312dd9-92ba-4ace-b303-a4622db40137"), null, null, "TokenProviderException", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Token Provider boş olamaz!" },
                    { new Guid("ea55f696-d610-4f8d-9a35-f129a98e08a6"), null, null, "SuccessfulLogin", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Login to the system is successful." },
                    { new Guid("f6aa55a6-b153-493a-967d-1503e659cae1"), null, null, "Value", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Value" },
                    { new Guid("f6afdb72-9f41-4cbb-8f79-64abc1640924"), null, null, "PasswordLength", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Minimum 8 Karakter Uzunluğunda Olmalıdır!" },
                    { new Guid("f995bc49-c7d9-4ba5-a17f-d81896cbbe17"), null, null, "MobilePhones", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Cep Telefonu" },
                    { new Guid("fb57c7b8-ae9f-4bb3-9f00-ca9fb7538058"), null, null, "TokenProviderException", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Token Provider cannot be empty!" }
                });
        }
    }
}
