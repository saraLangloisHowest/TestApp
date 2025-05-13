using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class SeedScores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assessments",
                keyColumn: "Id",
                keyValue: new Guid("b0398bee-0a57-45d4-a8ef-2b6ec736ee18"));

            migrationBuilder.DeleteData(
                table: "MaturityLevels",
                keyColumn: "Id",
                keyValue: new Guid("38a8d2df-56c5-40ef-bf49-3083a8250d17"));

            migrationBuilder.DeleteData(
                table: "MaturityLevels",
                keyColumn: "Id",
                keyValue: new Guid("4b36b3a4-e4fd-4814-8e87-73ebb11b3516"));

            migrationBuilder.DeleteData(
                table: "MaturityLevels",
                keyColumn: "Id",
                keyValue: new Guid("73276242-ee96-4f55-8af5-8903af65adc5"));

            migrationBuilder.DeleteData(
                table: "MaturityLevels",
                keyColumn: "Id",
                keyValue: new Guid("8aac6887-36df-4e0b-ae12-2852ef221838"));

            migrationBuilder.DeleteData(
                table: "MaturityLevels",
                keyColumn: "Id",
                keyValue: new Guid("a8114c4d-2771-492e-b778-21bab383bc09"));

            migrationBuilder.DeleteData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: new Guid("9780b4b8-d985-4cb7-8568-a2132675298e"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("02a2636e-bb97-42c9-ac41-8b53ad34e926"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("0335913a-3733-4216-8e37-df1f9e81589c"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("06c6d590-9a6b-49a7-8f7c-7c8882a90f80"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("07aa7dcf-b076-4486-a4ff-49da360f0f7e"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("0cda7da3-ce44-4e3e-b795-b15192da670c"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("0ecd9acc-c8cf-46ae-9a8c-517e2502ae9b"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("0f7438bd-13bd-428e-8ff2-a67280c32269"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("10c03946-eb67-42d4-8923-458e549034b2"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("145e39ac-1fca-4300-95c3-43bbf1cf9e1b"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("18c8772b-3f71-46e8-bf36-6ab56406768d"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("1d87df4a-f585-460c-8f0f-273e10d8662c"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("1f97efce-fd8c-41df-ab78-4029f764c7c3"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("202d9075-f666-4777-b33a-efc65b22544d"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("2161558c-cd37-4dad-a0a9-b4b28548af8d"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("22018490-c992-4f79-a1e9-621f47de08f2"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("2802dac3-abc9-4f1c-a13e-04feb37312d0"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("28425c69-ee30-4391-94ac-2275b495953b"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("2f3b0156-e700-4f9b-b811-c9fc8e3b9983"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("30beda5b-e5c9-4824-9244-7d7a30eb36e4"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("30c87d88-07bc-4eca-80e8-4bc0eafd5832"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("3200da24-45bd-409f-aecc-83621509430d"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("376d4cb0-a301-473f-8440-a0f70fd247d8"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("3aa38a96-60fe-4be5-8879-feac48e0fb5a"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("3c04e88c-d09c-4f14-8cc6-a6eec9951110"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("3c46adcc-f5a0-4a8d-839b-eedaac675da3"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("3ccbd637-81fe-4b9d-ad60-9aefac6b08af"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("3fc4f31a-edc4-42f8-96b8-a69132b9e15f"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("403ab9e6-5a0a-40f0-8583-8c89eb1f4491"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("4059d999-9c22-4547-8c9c-95e88adb6723"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("4159f5bb-0341-45cc-b030-59ff87b60df5"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("4260aae0-adfb-40e6-925c-e136be4787c5"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("4261c7e8-6508-4115-a9be-243af6e3094d"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("42996787-8944-4927-8dcf-e056e317086c"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("47662575-05b1-4554-9375-84ebe0f80765"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("47a30efd-c2b5-45e2-b709-a99280db0eec"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("4b0a3a76-d226-4110-8c22-6daf6700cbe7"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("4db82042-193f-44b3-8068-589ea892b53c"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("529efbcb-5e65-45a6-b77d-beade0537ba6"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("541ed410-49ea-4ecf-9270-a6bd12de6643"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("542fd482-7633-4dd0-800b-35a921128aa0"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("5676fcf1-cde8-414d-8893-afdfb5319d5e"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("56eb139f-5a69-4c1f-8152-342eddfc9bd0"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("5934e6fd-4f7e-4ce8-93f7-ece9001768b6"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("59e63a42-f484-459f-9515-77b365fabd34"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("5af92fb2-0eb1-4eeb-b114-fb751cb84d90"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("5c986374-30e2-46fb-acf4-e2a5fa12df3e"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("5e9b1ec6-a0a5-4873-befb-ecadef318327"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("631993aa-48ae-4dac-be85-055e92f75f5d"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("6331f50d-be21-4afc-ac4e-9a21c3a44afd"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("64e1906b-ae5e-4088-96cf-1f231e34f3c9"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("66414f5c-71e9-47e1-911e-c6950a5cbac9"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("6b68aae1-1577-4cb6-bfa8-fa2ee1725eca"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("6beb1c21-fb25-4296-995d-cf7b4bae8556"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("6ed6d279-38c6-4483-b1e9-19a08e467530"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("724b9216-19e5-4f80-8bae-4e5540136559"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("7409862f-20b7-4c94-9a97-aa995ec9dfbc"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("7419f6ba-8315-43b5-b0b2-a48ec94b743d"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("745b9c02-0f36-4cd2-91a9-1be9fe0ef792"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("787ab9ca-266e-4f5a-96f9-71fbee6a7ddf"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("787d6768-5b86-4e6f-87ae-64ec2e507bd7"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("7a46c852-91bb-4763-a549-21107a2fe7b4"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("7c3a2db9-ec23-4752-a167-e2f18285e4ee"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("80420775-09b4-436f-b3bf-657a6950477f"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("826ad849-cfdf-4be5-91dd-dcce49347a53"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("83411078-d61d-4341-a551-69f816bd5cbf"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("83e855d4-1762-4b75-b361-77c536a3cc7b"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("872cbe16-1795-4919-9cf1-3ea61b1b01a7"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("8a0f6850-e804-486b-bbe2-e7e89423e48f"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("8d977584-0ffe-409e-b0da-15f71c126c49"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("8de92a98-a67d-4b40-9b77-daa59a8b51e4"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("8e446ef4-4d1d-4fd0-ba93-ec00c83c095f"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("8e660168-57bc-47fb-a5b2-658e56a608c8"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("8f277a4a-3972-4354-a709-9d9f29b04074"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("8fde57e5-67c0-453c-9e71-6a2d72710109"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("90329aa5-9700-42db-b5d8-dd49a57dae69"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("915f430d-754e-4a2c-a0c1-3553a384100e"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("945b0a94-831c-4ac1-9f6e-b51af684de39"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("949d9c85-99eb-4737-8113-a6682e43b84d"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("96448544-2b1d-4286-a9dd-9c9493305399"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("96652ce3-1702-4305-bc45-54a7488c0d96"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("96eac62b-208a-4785-8571-e470d51ace9e"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("9765bd3c-91b4-4f3a-94c0-69725e3f8a52"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("980ef38a-315d-478e-8798-55a91e07d26f"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("98df98e9-a974-4681-a3b2-2a4909214725"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("9ad907d9-0c6b-4cd5-88d5-328facbbbee7"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("9cb58120-7799-4374-8da9-062504cb42fb"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("9d9b3f97-76d7-4fd4-882c-ecfc397413d2"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("a067de6f-e191-40d1-a921-bb1f749cc1db"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("a0ebac9d-426c-4439-95c6-beebc805a395"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("a4f85aac-6803-4fff-86a4-de9091594a22"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("a5202ee7-f45c-47d6-a361-39fd7e6a8f83"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("a6ce705e-02be-4349-9713-caa5b7fabaa1"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("a70e4e2f-06c1-4218-a54d-09f4d582d66c"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("a844a9a5-6712-4d1a-88e7-cdaf8a264d07"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("ac8a265d-b0d9-4ee2-871b-8a9f49898186"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("ad8184ef-ab44-4a4b-bc6e-57411bf56603"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("b326dec4-05e4-4ab3-9453-18501b0cebeb"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("b4dc4c81-84de-4501-954e-fc5f03485b56"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("b5de49f4-8fa1-45c1-b60f-778dc95e3024"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("b5fa2050-8299-4a28-8cbe-d295769f7bba"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("bafd2688-e6d8-468b-9e4b-3eac01e39287"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("bba06980-5ef8-4400-8ce2-faf6cf48e129"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("bd12ea6a-c19b-4e29-a624-2844ab3c9d62"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("bdb2ae6a-ff78-43b4-b08a-40d65d9ef52a"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("be958c41-9f55-4c86-abfa-6ea2e96eee68"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("bea7212e-f65e-4cea-8de3-301e1eca811e"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("bed519f5-47e4-43c2-80ad-400360e61c18"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("bf7a7e5b-48ae-4b60-8bf0-3ea7e1dedf1a"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("bfd71013-0314-4e97-a5b3-b5a5fdd24116"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("c0ec76b0-e768-4413-9693-96c1c9ed5d35"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("c145b388-7184-4509-b813-d33ac083de40"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("c205ad14-b422-42b2-8878-8f34b74f03e3"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("c25a02bd-63b3-46d1-a0d0-47130f22b26c"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("c2dd8394-c773-402d-be04-8d5235dd1d8e"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("c49334e6-6197-4219-bb90-5799dd6a3174"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("c49bffb3-e603-440f-b47a-ae971cd512fc"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("c6fe27d2-c4c1-44cf-b21b-a90d7f69df9c"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("c9243af4-d585-48b3-8158-d6d84bcf361e"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("c9913d98-3a49-4e8f-b912-998ba474ac98"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("ca297b6b-f17a-49be-bf22-5bb53e3eb5c5"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("ca73aa04-57eb-491b-bc4a-1ca34fa90c9c"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("d0ea9f07-3380-4d5d-a393-852aa53a774f"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("d10606d1-235f-451a-a086-5501a79c1dbc"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("d3ef9e86-2fca-43ed-8644-b0ab568688fd"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("d69321c8-6180-41bb-abbd-b23dee062252"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("da61c1c3-cb20-4171-bd89-d56ab4712b8c"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("deb3d6cf-026c-4363-aeac-80a997b8c21b"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("df93b549-0043-409a-9da8-a1128fe1630a"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("e30d8635-d3a8-4aa3-90b6-95f02b4fa700"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("e801d590-d24c-4858-856a-0c4a3c221f99"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("e99e93d3-54d6-4e03-a829-10141482c08e"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("eaa4bdf7-e416-4819-acdc-de6d2bce2779"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("eab32a40-df10-41a9-9557-ee3ee88fd301"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("ede7605b-e49c-45b0-87c8-84affaff3a59"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("ee9f0d5c-0778-4d44-80a4-db9bd4b59266"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("f073a952-1f3f-432c-8b47-aceb0d887c3a"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("f153f51e-0632-4890-8e8d-03c8d29f0b55"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("f1bc1862-9482-4958-8ffc-901f4e38d06d"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("f3860b51-fe0c-44c8-8b29-75bb1a0ad196"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("f3a738a7-9584-4b3c-9ad5-290e9cd4e414"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("f3faaae0-08a4-4f93-b00c-27be7d138c73"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("f48edacb-731c-40ec-9116-cb14ce6f2377"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("f50bb826-b98d-4597-9cf7-84b898ae5412"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("f546b414-d5a9-455d-9b36-13388fa41ce2"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("fa0fa529-26b1-45ad-ad1e-2655cd7722c1"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("faa7d1d2-c97d-4d2d-9595-0d8397a714ad"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("fac700a4-70fd-4a98-8072-a9a00267eefe"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("fe7e6b1f-55c7-4a67-935f-0768c3e4415e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("87453e84-dad6-43e2-a59e-456626aa8ef7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c40f473a-ce7e-4f2c-b95b-31410495770a"));

            migrationBuilder.DeleteData(
                table: "Maturities",
                keyColumn: "Id",
                keyValue: new Guid("c3ef7ab0-a332-4cce-9335-4f8de27f0c7d"));

            migrationBuilder.DeleteData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: new Guid("d6530ab5-d604-4c90-a4b3-a217d9cf632f"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("01dcce94-ee8b-46e4-80e6-90faf582d7a3"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("086fdf24-147b-470a-a020-c353854fac17"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("0a228c5d-cb3e-4c1f-8cc5-ac4959e65865"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("0a643c22-096b-430e-bfd8-b4462d987911"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("0aa22cca-6a88-434a-acd0-87320bf6ed01"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("0b8653b4-31ec-4b1b-97d1-12bf98202176"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("0ede0199-74e9-4267-a3b3-e21e20315099"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("1784ecc7-28ef-4177-aa86-766b622fd56d"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("25fe7a69-817b-4f34-b3bf-9c5910987023"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("26e0fdd9-8f1a-4846-b38d-ea889a1f09df"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("26e631f3-3e1a-419e-a31f-6ddb9e8550a3"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("27499ab6-7965-4b5e-8135-c43529ee2c85"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("2fbaaaeb-73eb-4a13-ac68-0bac833a5654"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3133e865-76d7-4d37-8b52-dc5168397524"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("317af496-8d3c-4d98-957a-3bab8a7869b6"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3914c824-49bf-4e17-85f9-1e5d42aa6db5"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3b6a0d51-7b54-4da7-8344-80e350918ba4"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3cc3764b-0ecc-454c-ab3d-527f0ad8fdff"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("418f320e-3338-4997-b056-70c2e5aaefc6"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("41bf3d46-41eb-4845-a2c5-4a7b6a61e0b1"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("42168a35-9677-467e-b236-12cdbc293102"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("42437ae7-a11b-43e7-b0b0-727a03763aab"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("435fd1da-b1ca-423c-a55b-ac7a7cdd7ae6"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("493f29d4-219f-4973-a992-2a253093df97"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("49b8800f-2784-4879-a533-32ef56906460"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("4a753121-3083-4ee1-b559-8def9f6eef79"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("4af110de-df5c-4860-9e23-1c42ca7880ec"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("51402878-da03-4352-a78b-7cba5fe77a7e"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("53894f78-632a-40ac-a733-87ba4985fb0b"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("59e10b84-0f23-46fe-af0a-a45a6e5e4b09"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("5fb4725d-4f0f-4186-ba99-5d658e7cc2cf"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("5fddf469-60c2-4bb4-85e5-dda96cc63d99"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("6053c1d4-8553-4c60-944a-9430c5f11e91"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("617c65f6-1b81-4d4f-a830-75722588761c"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("661dcb5f-c50a-4e86-9756-f11642f04945"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("666a0ea7-fcde-41da-99cd-c18055da0dc4"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("6732cd67-b996-46da-958c-8fe682677605"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("67b4b6b2-bc9c-4515-be2a-49a80d84d3b3"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("684cf7ac-a109-4a4d-9dc2-a1c71ea79e85"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("68e8222c-1314-4a1c-85d5-734c50861917"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("6bbd77b2-dbac-46de-9ea5-b2bdb6b7498b"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("6cb36feb-357a-4765-be60-0ab066c940b9"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("6fb97b52-5261-4f7b-bd7c-c12e0d829581"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("729ba903-5401-4d65-acd0-c2c47e8ff432"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("76d76243-4d8a-4a15-a50b-6e285c4cf9a8"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("785ecadb-c81c-4df7-b2c0-254b934bd67d"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("789e3806-59f9-40fc-9b04-d15bfe0d475e"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("796530ad-fb7d-42b4-bb1f-5f73f2395187"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("7abac9f5-9cab-4a6c-a5c2-7dd9df84eb49"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("7fc2d049-ae03-4bf5-a820-850e39d28a11"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("845ba1e2-92ae-4e74-8807-b5c3739837bf"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("850fb561-fddf-46f7-98d4-153b2ea417db"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("8817eb51-dad1-4bf4-9c49-3de0f05e9781"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("89ba35da-545d-4ca6-9691-65b6af9f178a"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("8e2969d1-715d-4b15-82be-3300f6ff0083"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("90ad6f58-f654-48c5-a0be-106386b116e6"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("90dd6047-fea2-4dcb-80e4-691b1e45e787"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("925805d3-63c2-47c3-ba5d-5e444ff52806"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("94776ff4-977c-43b2-b3d1-7ef530c99897"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("97947d2f-c55c-4e94-ae76-1686cff0bc76"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("a0fa7fcc-fc6f-4dcb-9171-c8a32e78e9f0"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("a203602b-8c86-4082-81f3-d3d8b94d0d3f"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("a46a0859-4d42-4d96-8de1-96c89964b0aa"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("a73bc22a-1df7-40c1-856f-6ce8268ccab0"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("af66ffe2-484a-4a62-ab44-e9a815c11975"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("afead7a6-5602-46a1-b658-c89da02cc410"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b0b53253-ef34-48f3-a3c1-12c10a22e2fe"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b0ed9db4-df1a-4762-81e5-f7757cd6b6f0"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b44f429e-11a2-4ed9-81bc-6f280ce4dc01"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b77a5822-cf0d-41ea-9c7b-6ea2a8527fc7"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("bacffee8-7711-4d3a-baca-bfd72e1c8d86"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("bc1163e7-b953-474a-bcf4-ea836d345f1b"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("bc6eb7e0-2b73-4230-984a-0f72f58dfb9b"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("bd2d05ad-a7fd-4600-b3cb-57ca0a898522"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("bd904c29-6c9d-482e-805e-38d96e6b2b5a"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("bf66f918-a1e7-405f-9f8a-d7e97614f4ea"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("c3bf6957-2760-4588-9061-957d8d1582ec"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("c5d70d13-a151-401d-a5e1-194453ec1b1b"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("c612bb8a-f863-486f-9922-8540aa852aeb"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("c72ac299-ff0c-4dbf-8133-c6938665fc29"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("c86d062f-5b15-4f8b-8ed0-de02213bff8b"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("ccce8cfe-d8f8-4098-9e98-62f5c884f0c6"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("cdcfa6b7-03e0-4a47-9eb0-4b80f7c94c76"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d02c37a5-ceb7-4053-bc36-d8a9ac49e5f5"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d4d8ca3b-86c5-45bc-b772-c39e0d6f4e82"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d60c7720-c8fe-4417-a7a4-8dab71c29cc2"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("dc4a92eb-72df-46ec-865b-579e9e8a3a99"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("e1d70bf8-aee9-4a80-8ef4-65a456d442e7"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("e3a8bb57-9e6a-4c86-8b50-0e3107954861"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("eb5d9410-4f4d-4f9f-a419-601aabb485c0"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("ec20edd4-c8bc-4d2d-b59b-596c75ab31f7"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f27a2a5d-0955-4081-a5dd-9f7ed84b5ff1"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f38eb798-d297-49c1-a9e6-a1e870ed4746"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f6a36400-ca59-4349-bb8c-d429cb7fbb30"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f6b08eee-6470-475c-9808-f5d0f2f19c81"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f8b75ba9-2494-42f8-8ea3-d594c6fcdb03"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f9d4a042-f9b5-40da-b8ac-2dc00c372e90"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("63905826-de4f-4918-8a11-082c61120a2c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("74cf7114-d30c-4555-8796-e8ea663e5143"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("06b67f35-f459-4f1a-98db-e04b3f01d2b1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("28a61c29-b46e-4299-ab7f-31637fa3d5a2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3801fcc8-e6c4-46b5-b1a5-0a652bb265ce"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("44917305-0a39-43e6-b75e-6f58a709feb1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5931d80f-dd54-49b8-a856-0121f4ff126a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5bae836c-dd29-46f7-b36d-1ace1c5f4f3b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5e4c390e-eb7a-4a2e-9315-01027f7df135"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5e7f4af0-5d80-457c-a939-383eb2a06011"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("625db872-cda7-41f9-8f33-5675811e0291"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("64f2b22b-86d4-4d3b-a508-e9fe3db31d79"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7374fa62-6392-4a5a-8249-66a4f046a6c4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7509028d-3fb4-4840-9727-b4a03bdc6694"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7e4d0bc6-a3f9-4afc-9877-3cb27f25558f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8006ee9d-239a-4fc6-88e2-b0e1c4667449"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("863672b2-a93f-4635-b9e4-68901eff2fd8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8afc2316-2097-4601-aeab-28cb9a91df4a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9287ef1b-8b97-470d-8e62-8ba4c5db8df6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b1e6113e-2e82-4023-84d2-574c5dc83bfe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bab4a94d-3302-4842-81c1-0669596d71f2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cda5bbcc-4a24-456e-9240-dbbe0d92e0f0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d79a57e2-ffbc-4806-ac17-ca2122838265"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ec6a2fcf-1182-4b0f-b5a9-93372fdbebfa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ef029eb6-492f-4737-a1a7-3baa5c16a7be"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f1a7eb4a-6ed7-41fe-95a2-396a8d1a7c97"));

            migrationBuilder.DeleteData(
                table: "Functions",
                keyColumn: "Id",
                keyValue: new Guid("3e6599ae-54c8-42c5-aa53-59f83bf20451"));

            migrationBuilder.DeleteData(
                table: "Functions",
                keyColumn: "Id",
                keyValue: new Guid("8478e721-af59-45a8-87e2-b2f671860dbf"));

            migrationBuilder.DeleteData(
                table: "Functions",
                keyColumn: "Id",
                keyValue: new Guid("8b419820-3c3c-49da-bd0d-d20661f7fbb7"));

            migrationBuilder.DeleteData(
                table: "Functions",
                keyColumn: "Id",
                keyValue: new Guid("e2bd0267-3f99-4489-8ad2-2de44411daba"));

            migrationBuilder.DeleteData(
                table: "Functions",
                keyColumn: "Id",
                keyValue: new Guid("ee790a58-2e56-4500-afaa-5ae761d8f90f"));

            migrationBuilder.InsertData(
                table: "Functions",
                columns: new[] { "Id", "Code", "Color", "Created", "Deleted", "Description", "Name", "Order", "Updated" },
                values: new object[,]
                {
                    { new Guid("738e7749-4dd3-4403-973c-f83bc40a2ce2"), null, "43C5F3", null, null, null, "Identify", 0, null },
                    { new Guid("a9a08bf1-2218-4edd-815c-1984528eb78d"), null, "F87264", null, null, null, "Respond", 0, null },
                    { new Guid("ab580cf1-f5c7-4e3c-8b17-28e320ae9c04"), null, "8F92EB", null, null, null, "Protect", 0, null },
                    { new Guid("eacd318f-d9eb-4b18-b8a8-92ea9fec75d9"), null, "F7B848", null, null, null, "Detect", 0, null },
                    { new Guid("ef2980ce-db57-4108-9473-dde9adb9766b"), null, "79F19C", null, null, null, "Recover", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Maturities",
                columns: new[] { "Id", "Code", "Created", "Deleted", "Description", "Name", "Threshold", "Updated" },
                values: new object[] { new Guid("1f7570aa-509a-49e9-9368-6ab4fb3f60e1"), null, null, null, "", "Important", 3, null });

            migrationBuilder.InsertData(
                table: "Municipalities",
                columns: new[] { "Id", "Code", "Created", "Deleted", "Description", "Name", "Updated" },
                values: new object[,]
                {
                    { new Guid("1d376e9e-68ae-4681-8ad6-dc53d94a4ced"), null, null, null, null, "Brugge", null },
                    { new Guid("6867bdef-ad72-4ce1-a4a0-02f55d71c254"), null, null, null, null, "Gent", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Deleted", "IsAdmin", "IsAssesor", "Updated", "UserName" },
                values: new object[,]
                {
                    { new Guid("138d1972-631e-480b-a005-58b9bca8e4ea"), new DateTime(2016, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, null, "mauro.bekaert@lolol.be" },
                    { new Guid("495135fa-7818-4d1a-91fe-ecb7d8f0b619"), new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, true, null, "timo.blomme@hahaha.com" },
                    { new Guid("7d394d9a-e134-4dfe-a8c8-f12cc6de81ca"), new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, null, "sara.langlois2003@gmail.com" },
                    { new Guid("d0972a8b-cc3b-49ac-9925-c21d8862d876"), new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, null, "maarten.sohier@hihi.be" }
                });

            migrationBuilder.InsertData(
                table: "Assessments",
                columns: new[] { "Id", "AssessorId", "Created", "Deleted", "MaturityId", "MunicipalityId", "Updated", "UserId" },
                values: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("138d1972-631e-480b-a005-58b9bca8e4ea"), null, null, new Guid("1f7570aa-509a-49e9-9368-6ab4fb3f60e1"), new Guid("1d376e9e-68ae-4681-8ad6-dc53d94a4ced"), null, new Guid("7d394d9a-e134-4dfe-a8c8-f12cc6de81ca") });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Code", "Created", "Deleted", "Description", "FunctionId", "Name", "Order", "Updated" },
                values: new object[,]
                {
                    { new Guid("01af50a3-adf4-4b32-9598-7e146d5e2e2c"), null, null, null, "De missie, doelstellingen, belanghebbenden en activiteiten van de organisatie worden begrepen en geprioriteerd; deze informatie wordt gebruikt om cyberbeveiligingsrollen, verantwoordelijkheden en risicomanagementbeslissingen te informeren.", new Guid("738e7749-4dd3-4403-973c-f83bc40a2ce2"), "Business Environment", 0, null },
                    { new Guid("02178fc5-8e83-4aa1-8252-a76edda31d02"), null, null, null, "De organisatie begrijpt het cyberbeveiligingsrisico voor de activiteiten van de organisatie (inclusief missie, functies, imago of reputatie), bedrijfsmiddelen van de organisatie en individuen.", new Guid("738e7749-4dd3-4403-973c-f83bc40a2ce2"), "Risk Assessment", 0, null },
                    { new Guid("0fb92d70-1a26-4cc4-9912-76b59a7ffc37"), null, null, null, "Responseprocessen en -procedures worden uitgevoerd en onderhouden om te zorgen dat er wordt gereageerd op gedetecteerde cyberbeveiligingsincidenten.", new Guid("a9a08bf1-2218-4edd-815c-1984528eb78d"), "Response Planning", 0, null },
                    { new Guid("1086b3ef-fa93-4846-8518-8ccad964484b"), null, null, null, "Herstelprocessen en -procedures worden uitgevoerd en gehandhaafd om te zorgen voor herstel van systemen of bedrijfsmiddelen die zijn getroffen door cyberbeveiligingsincidenten.", new Guid("ef2980ce-db57-4108-9473-dde9adb9766b"), "Recovery Planning", 0, null },
                    { new Guid("18678c37-a299-4ca4-b610-607beb60a1a2"), null, null, null, "Herstelactiviteiten worden gecoördineerd met interne en externe partijen (bijv. coördinatiecentra, internetproviders, eigenaren van aanvallende systemen, slachtoffers, andere CSIRT's en leveranciers).", new Guid("ef2980ce-db57-4108-9473-dde9adb9766b"), "Communications", 0, null },
                    { new Guid("1d234796-662d-4391-ba62-27397fbdfbc4"), null, null, null, "Technische beveiligingsoplossingen worden beheerd om de beveiliging en veerkracht van systemen en bedrijfsmiddelen te garanderen, in overeenstemming met beleid, procedures en overeenkomsten.", new Guid("ab580cf1-f5c7-4e3c-8b17-28e320ae9c04"), "Protective Technology", 0, null },
                    { new Guid("1ffbf56c-727e-43a1-b66f-e3be9f6f585c"), null, null, null, "Onderhoud en reparaties aan componenten van industriële besturings- en informatiesystemen worden uitgevoerd in overeenstemming met beleid en procedures.", new Guid("ab580cf1-f5c7-4e3c-8b17-28e320ae9c04"), "Maintenance", 0, null },
                    { new Guid("3a281d1c-8c2f-4fb6-bd19-3cd6c3ea6d7b"), null, null, null, "De prioriteiten, beperkingen, risicotoleranties en aannames van de organisatie worden vastgesteld en gebruikt ter ondersteuning van risicobeslissingen met betrekking tot het beheren van risico's in de toeleveringsketen. De organisatie heeft processen vastgesteld en geïmplementeerd om risico's in de toeleveringsketen te identificeren, te beoordelen en te beheren.", new Guid("738e7749-4dd3-4403-973c-f83bc40a2ce2"), "Supply Chain Risk Management", 0, null },
                    { new Guid("3e57c961-a040-4865-a9ce-743a31597813"), null, null, null, "Response-activiteiten worden gecoördineerd met interne en externe belanghebbenden (bijv. externe ondersteuning van wetshandhavingsinstanties).", new Guid("a9a08bf1-2218-4edd-815c-1984528eb78d"), "Communications", 0, null },
                    { new Guid("4919ea9b-c4f7-45ba-9151-7667dbc43a71"), null, null, null, "Het personeel en de partners van de organisatie krijgen voorlichting over cyberbewustzijn en worden getraind om hun taken en verantwoordelijkheden op het gebied van cyberbeveiliging uit te voeren in overeenstemming met het beleid, de procedures en overeenkomsten op dit gebied.", new Guid("ab580cf1-f5c7-4e3c-8b17-28e320ae9c04"), "Awareness and Training", 0, null },
                    { new Guid("5acbf9d5-6de3-4c86-a451-cb59b74f33c9"), null, null, null, "De prioriteiten, beperkingen, risicotoleranties en aannames van de organisatie worden vastgesteld en gebruikt om beslissingen over operationele risico's te ondersteunen.", new Guid("738e7749-4dd3-4403-973c-f83bc40a2ce2"), "Risk Management Strategy", 0, null },
                    { new Guid("8849e851-d000-4f43-89cf-e84a2875dd9a"), null, null, null, "Herstelactiviteiten worden gecoördineerd met interne en externe partijen (bijv. coördinatiecentra, internetproviders, eigenaren van aanvallende systemen, slachtoffers, andere CSIRT's en leveranciers).", new Guid("ef2980ce-db57-4108-9473-dde9adb9766b"), "Communications", 0, null },
                    { new Guid("8d21ff39-9e60-47e8-bccc-eec610d7b576"), null, null, null, "Afwijkende activiteiten worden gedetecteerd en de potentiële impact van gebeurtenissen wordt begrepen.", new Guid("eacd318f-d9eb-4b18-b8a8-92ea9fec75d9"), "Anomalies and Events", 0, null },
                    { new Guid("90eaf9ed-c180-405b-97f2-4bb13b79231f"), null, null, null, "Het beleid, de procedures en processen voor het beheren en bewaken van de regelgevende, juridische, risico-, milieu- en operationele vereisten van de organisatie worden begrepen en informeren het beheer van cyberbeveiligingsrisico's.", new Guid("738e7749-4dd3-4403-973c-f83bc40a2ce2"), "Governance", 0, null },
                    { new Guid("978c228f-7b3b-4054-8d77-8cc40274a263"), null, null, null, "Er worden analyses uitgevoerd om een effectieve respons te garanderen en herstelactiviteiten te ondersteunen.", new Guid("a9a08bf1-2218-4edd-815c-1984528eb78d"), "Analysis", 0, null },
                    { new Guid("9cbf1981-d460-4ae7-8bd9-f6fe632b71fb"), null, null, null, "Detectieprocessen en -procedures worden onderhouden en getest om ervoor te zorgen dat men op de hoogte is van afwijkende gebeurtenissen.", new Guid("eacd318f-d9eb-4b18-b8a8-92ea9fec75d9"), "Detection Processes", 0, null },
                    { new Guid("a347cd22-9140-4811-ae86-279654488323"), null, null, null, "Toegang tot fysieke en logische activa en bijbehorende faciliteiten is beperkt tot geautoriseerde gebruikers, processen en apparaten, en wordt beheerd in overeenstemming met het ingeschatte risico van ongeautoriseerde toegang tot geautoriseerde activiteiten en transacties.", new Guid("ab580cf1-f5c7-4e3c-8b17-28e320ae9c04"), "Identity Management, Authentication and Access Control", 0, null },
                    { new Guid("a9d192d6-4eea-44a8-9b77-16008c85cb79"), null, null, null, "Er wordt een beveiligingsbeleid (met aandacht voor het doel, de reikwijdte, de rollen, de verantwoordelijkheden, de betrokkenheid van het management en de coördinatie tussen organisatorische entiteiten), processen en procedures onderhouden en gebruikt om de bescherming van informatiesystemen en -middelen te beheren.", new Guid("ab580cf1-f5c7-4e3c-8b17-28e320ae9c04"), "Information Protection Processes and Procedures", 0, null },
                    { new Guid("ac7fff60-df1d-45e1-9f4a-215d4eb287ca"), null, null, null, "Er worden activiteiten uitgevoerd om uitbreiding van een gebeurtenis te voorkomen, de gevolgen ervan te beperken en het incident op te lossen.", new Guid("a9a08bf1-2218-4edd-815c-1984528eb78d"), "Mitigation", 0, null },
                    { new Guid("b572fdd8-874c-4724-8f8c-8893f16c0d38"), null, null, null, "De gegevens, het personeel, de apparaten, systemen en faciliteiten die de organisatie in staat stellen om bedrijfsdoeleinden te bereiken, worden geïdentificeerd en beheerd in overeenstemming met hun relatieve belang voor de doelstellingen van de organisatie en de risicostrategie van de organisatie.", new Guid("738e7749-4dd3-4403-973c-f83bc40a2ce2"), "Asset Management", 0, null },
                    { new Guid("b654d831-9b49-4bb6-a9de-a8ca183a7064"), null, null, null, "Het informatiesysteem en de middelen worden gemonitord om cyberbeveiligingsgebeurtenissen te identificeren en de effectiviteit van beschermende maatregelen te verifiëren.", new Guid("eacd318f-d9eb-4b18-b8a8-92ea9fec75d9"), "Security Continuous Monitoring", 0, null },
                    { new Guid("da934b99-ebd3-49dd-a39b-18e6d917c7db"), null, null, null, "De herstelplanning en -processen worden verbeterd door geleerde lessen op te nemen in toekomstige activiteiten.", new Guid("ef2980ce-db57-4108-9473-dde9adb9766b"), "Improvements", 0, null },
                    { new Guid("e5f506c8-d52d-4a86-aef6-af85755c349a"), null, null, null, "Organisatorische responsactiviteiten worden verbeterd door lessen te trekken uit huidige en eerdere detectie-/responsactiviteiten.", new Guid("a9a08bf1-2218-4edd-815c-1984528eb78d"), "Improvements", 0, null },
                    { new Guid("eaa515f4-682b-43a8-b3bf-4d3d190d141d"), null, null, null, "Informatie en records (gegevens) worden beheerd in overeenstemming met de risicostrategie van de organisatie om de vertrouwelijkheid, integriteit en beschikbaarheid van informatie te beschermen.", new Guid("ab580cf1-f5c7-4e3c-8b17-28e320ae9c04"), "Data Security", 0, null }
                });

            migrationBuilder.InsertData(
                table: "MaturityLevels",
                columns: new[] { "Id", "Created", "Deleted", "Documentation", "Implementation", "Level", "MaturityId", "Updated", "Value" },
                values: new object[,]
                {
                    { new Guid("3e104a83-8d67-4290-b35e-4b76cbf57539"), null, null, "No Process documentation or not formally approved by management.\r\n", "Standard process does not exist.\r\n", "Initial", new Guid("1f7570aa-509a-49e9-9368-6ab4fb3f60e1"), null, 1 },
                    { new Guid("824ed90e-bbba-4da1-bccd-5a00a8a07449"), null, null, "Formally approved Process documentation exists, and exceptions are documented and approved. Documented & approved exceptions < 3% of the time.\r\n", "Formal process exists and is implemented. Evidence available for all activities. Detailed metrics of the process are captured and reported.\r\nMinimal target for metrics has been established. Less than 5% of process exceptions.\"\r\n", "Managed", new Guid("1f7570aa-509a-49e9-9368-6ab4fb3f60e1"), null, 4 },
                    { new Guid("9343760a-ba37-49e0-b849-32741fc6eb43"), null, null, "Formally approved Process documentation exists, and exceptions are documented and approved. Documented & approved exceptions < 0,5% of the time.\r\n", "Formal process exists and is implemented. Evidence available for all activities. Detailed metrics of the process are captured and reported.\r\nMinimal target for metrics has been established and continually improving. Less than 1% of process exceptions.\"\r\n", "Optimizing", new Guid("1f7570aa-509a-49e9-9368-6ab4fb3f60e1"), null, 5 },
                    { new Guid("94b32039-d34b-4c2f-a36b-2ae8d27062d2"), null, null, "Formally approved Process documentation exists, and exceptions are documented and approved. Documented & approved exceptions < 5% of the time.", "Formal process exists and is implemented. Evidence available for most activities. Less than 10% process exceptions.\r\n", "Defined", new Guid("1f7570aa-509a-49e9-9368-6ab4fb3f60e1"), null, 3 },
                    { new Guid("db132e32-2f52-4e3d-a77b-e40bd8c8a820"), null, null, "Formally approved Process documentation exists but not reviewed in the previous 2 years.\r\n", "Ad-hoc process exists and is done informally.\r\n", "Repeatable", new Guid("1f7570aa-509a-49e9-9368-6ab4fb3f60e1"), null, 2 }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Code", "Created", "Deleted", "Description", "Name", "Order", "Updated" },
                values: new object[,]
                {
                    { new Guid("051cc8fb-a72f-47d8-aee4-81d1ddcb9256"), new Guid("4919ea9b-c4f7-45ba-9151-7667dbc43a71"), null, null, null, "Derden belanghebbenden (bijv. leveranciers, klanten, partners) begrijpen hun rollen en verantwoordelijkheden", "PR.AT-3", 0, null },
                    { new Guid("0599f344-9c68-4942-9f90-05cd955c0bf2"), new Guid("5acbf9d5-6de3-4c86-a451-cb59b74f33c9"), null, null, null, "Risicomaatregelen worden geïdentificeerd en geprioriteerd", "ID.RM-1", 0, null },
                    { new Guid("18fff895-9fc1-4a3e-9a3a-cceca872330e"), new Guid("eaa515f4-682b-43a8-b3bf-4d3d190d141d"), null, null, null, "Integriteitscontrolemechanismen worden gebruikt om de integriteit van software, firmware en informatie te controleren.", "PR.DS-6", 0, null },
                    { new Guid("1ba12212-b8e4-43b4-8122-85c8e46131bf"), new Guid("b654d831-9b49-4bb6-a9de-a8ca183a7064"), null, null, null, "Er wordt gecontroleerd op onbevoegd personeel, verbindingen, apparaten en software", "DE.CM-7", 0, null },
                    { new Guid("1f4e442d-693a-488d-bef7-3a497170d8a9"), new Guid("3a281d1c-8c2f-4fb6-bd19-3cd6c3ea6d7b"), null, null, null, "Contracten met leveranciers en externe partners worden gebruikt om passende maatregelen te implementeren die zijn ontworpen om te voldoen aan de doelstellingen van het cyberbeveiligingsprogramma en het risicobeheerplan voor de cyberketen van een organisatie.", "ID.SC-3", 0, null },
                    { new Guid("2079bbeb-5713-47de-950f-5f10788f67e7"), new Guid("a9d192d6-4eea-44a8-9b77-16008c85cb79"), null, null, null, "Effectiviteit van beschermingstechnologieën wordt gedeeld", "PR.IP-8", 0, null },
                    { new Guid("2141bf50-5f2f-45cd-bd44-3e11a197f7bf"), new Guid("a9d192d6-4eea-44a8-9b77-16008c85cb79"), null, null, null, "Cyberbeveiliging is opgenomen in HR-praktijken (bijv. deprovisionering, personeelsscreening)", "PR.IP-11", 0, null },
                    { new Guid("24203a47-35b9-49fd-91fa-5f2859b7d921"), new Guid("e5f506c8-d52d-4a86-aef6-af85755c349a"), null, null, null, "Reactie- en herstelplannen bevatten geleerde lessen", "RS.IM-1", 0, null },
                    { new Guid("279dc133-e6d3-41ce-acde-e2ee99c4576b"), new Guid("01af50a3-adf4-4b32-9598-7e146d5e2e2c"), null, null, null, "De plaats van de organisatie in kritieke infrastructuur en haar bedrijfstak wordt geïdentificeerd en gecommuniceerd", "ID.BE-2", 0, null },
                    { new Guid("2c077640-b3ba-4351-a0ca-6e02b2ed3449"), new Guid("01af50a3-adf4-4b32-9598-7e146d5e2e2c"), null, null, null, "De rol van de organisatie in de toeleveringsketen wordt geïdentificeerd en gecommuniceerd", "ID.BE-1", 0, null },
                    { new Guid("2e72755f-3ff3-4f56-be93-16aebc0f0d0d"), new Guid("b572fdd8-874c-4724-8f8c-8893f16c0d38"), null, null, null, "Externe informatiesystemen worden gecatalogiseerd", "ID.AM-4", 0, null },
                    { new Guid("30a7fc06-3dc9-4581-b5c1-e732338fdf06"), new Guid("a9d192d6-4eea-44a8-9b77-16008c85cb79"), null, null, null, "Back-ups van informatie worden uitgevoerd, onderhouden en getest", "PR.IP-4", 0, null },
                    { new Guid("31b34e3b-6f00-4b04-b00b-d93bfe09306e"), new Guid("978c228f-7b3b-4054-8d77-8cc40274a263"), null, null, null, "Incidenten worden gecategoriseerd in overeenstemming met responsplannen", "RS.AN-4", 0, null },
                    { new Guid("34af178a-0d8a-453e-bb7e-0e07494fa221"), new Guid("1d234796-662d-4391-ba62-27397fbdfbc4"), null, null, null, "Communicatie- en besturingsnetwerken worden beschermd", "PR.PT-4", 0, null },
                    { new Guid("34d2abc7-adfe-45d5-a8fe-791bc4d728d7"), new Guid("b654d831-9b49-4bb6-a9de-a8ca183a7064"), null, null, null, "Activiteit van externe serviceproviders wordt gemonitord om potentiële cyberbeveiligingsgebeurtenissen te detecteren", "DE.CM-6", 0, null },
                    { new Guid("3a9824e4-dcea-416d-b980-3c7b0ef102fd"), new Guid("8849e851-d000-4f43-89cf-e84a2875dd9a"), null, null, null, "Herstelactiviteiten worden gecommuniceerd naar interne en externe belanghebbenden en naar uitvoerende en managementteams", "RC.CO-3", 0, null },
                    { new Guid("3d6f6f8e-3e17-4cbd-be24-b9b915af40de"), new Guid("eaa515f4-682b-43a8-b3bf-4d3d190d141d"), null, null, null, "Activa worden formeel beheerd tijdens verwijdering, overdracht en vervreemding", "PR.DS-3", 0, null },
                    { new Guid("4268937d-a7c9-40f1-b0bc-5acd80487562"), new Guid("b654d831-9b49-4bb6-a9de-a8ca183a7064"), null, null, null, "Personeelsactiviteiten worden gemonitord om potentiële cyberbeveiligingsgebeurtenissen te detecteren", "DE.CM-3", 0, null },
                    { new Guid("4a9ac2f5-eeb5-4d54-af1f-61eb06ecc03f"), new Guid("3e57c961-a040-4865-a9ce-743a31597813"), null, null, null, "Informatie wordt gedeeld in overeenstemming met responsplannen", "RS.CO-3", 0, null },
                    { new Guid("4c30f4dc-e2ab-4b28-962c-32fa201918fa"), new Guid("ac7fff60-df1d-45e1-9f4a-215d4eb287ca"), null, null, null, "Incidenten zijn onder controle", "RS.MI-1", 0, null },
                    { new Guid("4c8755a3-187f-41a5-af01-5f50c62ef87e"), new Guid("3a281d1c-8c2f-4fb6-bd19-3cd6c3ea6d7b"), null, null, null, "Leveranciers en externe partners worden routinematig beoordeeld met behulp van audits, testresultaten of andere vormen van evaluaties om te bevestigen dat ze aan hun contractuele verplichtingen voldoen.", "ID.SC-4", 0, null },
                    { new Guid("4d2fa7a8-e0c1-4cac-bc11-911430c1e47a"), new Guid("a347cd22-9140-4811-ae86-279654488323"), null, null, null, "Netwerkintegriteit wordt beschermd (bijv. netwerksegregatie, netwerksegmentatie)", "PR.AC-5", 0, null },
                    { new Guid("4e564fec-29fa-41eb-adb2-daf82f66a950"), new Guid("3e57c961-a040-4865-a9ce-743a31597813"), null, null, null, "Er wordt op vrijwillige basis informatie gedeeld met externe belanghebbenden om een breder situationeel bewustzijn van cyberbeveiliging te creëren.", "RS.CO-5", 0, null },
                    { new Guid("5280a1e2-8941-4994-a483-fe9235dee0fd"), new Guid("3a281d1c-8c2f-4fb6-bd19-3cd6c3ea6d7b"), null, null, null, "Reactie- en herstelplanning en tests worden uitgevoerd met leveranciers en externe leveranciers", "ID.SC-5", 0, null },
                    { new Guid("5287f11d-1c1c-4938-98f5-20576e7081d9"), new Guid("e5f506c8-d52d-4a86-aef6-af85755c349a"), null, null, null, "Reactie- en herstelstrategieën worden bijgewerkt", "RS.IM-2", 0, null },
                    { new Guid("593cb23d-9e2e-404d-955f-478ed845f50a"), new Guid("5acbf9d5-6de3-4c86-a451-cb59b74f33c9"), null, null, null, "Organisatorische risicotolerantie wordt bepaald en duidelijk uitgedrukt", "ID.RM-2", 0, null },
                    { new Guid("595b625b-7641-4c9a-986d-504090c03c44"), new Guid("b572fdd8-874c-4724-8f8c-8893f16c0d38"), null, null, null, "Hulpbronnen (bijv. hardware, apparaten, gegevens, tijd, personeel en software) worden geprioriteerd op basis van hun classificatie, kriticiteit en bedrijfswaarde.", "ID.AM-5", 0, null },
                    { new Guid("5a3301e7-4545-442a-b78a-2c0312386b19"), new Guid("9cbf1981-d460-4ae7-8bd9-f6fe632b71fb"), null, null, null, "Detectieprocessen worden voortdurend verbeterd", "DE.DP-5", 0, null },
                    { new Guid("5aca2b06-736a-428d-bb85-e1c4b69a7774"), new Guid("978c228f-7b3b-4054-8d77-8cc40274a263"), null, null, null, "Meldingen van detectiesystemen worden onderzocht", "RS.AN-1", 0, null },
                    { new Guid("5c021230-07ef-4269-99a6-648bacd7b46d"), new Guid("a9d192d6-4eea-44a8-9b77-16008c85cb79"), null, null, null, "Er zijn processen voor het beheren van configuratiewijzigingen", "PR.IP-3", 0, null },
                    { new Guid("5f7578d2-ab6a-4f0d-8c67-3a6d54c85110"), new Guid("a347cd22-9140-4811-ae86-279654488323"), null, null, null, "Identiteiten zijn bewezen en gebonden aan referenties en worden bevestigd in interacties", "PR.AC-6", 0, null },
                    { new Guid("6089a8a0-e551-4dbd-822f-01287aa46dcc"), new Guid("eaa515f4-682b-43a8-b3bf-4d3d190d141d"), null, null, null, "Data-in-transit is beschermd", "PR.DS-2", 0, null },
                    { new Guid("6499315c-b528-4d99-b2c2-be37df256922"), new Guid("02178fc5-8e83-4aa1-8252-a76edda31d02"), null, null, null, "Bedreigingen, kwetsbaarheden, waarschijnlijkheden en gevolgen worden gebruikt om risico's te bepalen.", "ID.RA-5", 0, null },
                    { new Guid("6bc829fe-3193-4646-8868-bcf130333741"), new Guid("a347cd22-9140-4811-ae86-279654488323"), null, null, null, "Identiteiten en referenties worden uitgegeven, beheerd, geverifieerd, ingetrokken en gecontroleerd voor geautoriseerde apparaten, gebruikers en processen.", "PR.AC-1", 0, null },
                    { new Guid("6e795f27-4c41-40e9-81d5-63d23b9b1d60"), new Guid("b572fdd8-874c-4724-8f8c-8893f16c0d38"), null, null, null, "Fysieke apparaten en systemen die binnen de organisatie worden gebruikt, worden geïnventariseerd", "ID.AM-1", 0, null },
                    { new Guid("713518df-8599-4ae3-ba32-c16ab59f70f5"), new Guid("b572fdd8-874c-4724-8f8c-8893f16c0d38"), null, null, null, "Softwareplatformen, en applicaties die binnen de organisatie worden gebruikt, worden geïnventariseerd", "ID.AM-2", 0, null },
                    { new Guid("713f72bc-e9be-4ae3-8982-69fa9a16bbfc"), new Guid("0fb92d70-1a26-4cc4-9912-76b59a7ffc37"), null, null, null, "Responsplan wordt uitgevoerd tijdens of na een incident", "RS.RP-1", 0, null },
                    { new Guid("732ffe91-6f74-409f-ba09-72578ce1eecd"), new Guid("1d234796-662d-4391-ba62-27397fbdfbc4"), null, null, null, "Audit/logboekrecords worden bepaald, gedocumenteerd, geïmplementeerd en herzien in overeenstemming met het beleid", "PR.PT-1", 0, null },
                    { new Guid("74619b12-fcfb-4bcf-84b9-e960e8b1cc92"), new Guid("4919ea9b-c4f7-45ba-9151-7667dbc43a71"), null, null, null, "Senior managers begrijpen hun rollen en verantwoordelijkheden", "PR.AT-4", 0, null },
                    { new Guid("778a003a-ae85-40f6-a8e3-2f0d7273f87c"), new Guid("90eaf9ed-c180-405b-97f2-4bb13b79231f"), null, null, null, "Het cyberbeveiligingsbeleid van de organisatie wordt vastgesteld en gecommuniceerd", "ID.GV-1", 0, null },
                    { new Guid("82032357-16f8-41b7-a5cc-91fc6fdf637a"), new Guid("4919ea9b-c4f7-45ba-9151-7667dbc43a71"), null, null, null, "Alle gebruikers zijn geïnformeerd en getraind", "PR.AT-1", 0, null },
                    { new Guid("83d2e050-a0f1-430e-9160-3d963355f590"), new Guid("a9d192d6-4eea-44a8-9b77-16008c85cb79"), null, null, null, "Beschermingsprocessen worden verbeterd", "PR.IP-7", 0, null },
                    { new Guid("8550a4ef-80a6-4046-add4-8015c93071f9"), new Guid("1086b3ef-fa93-4846-8518-8ccad964484b"), null, null, null, "Herstelplan wordt uitgevoerd tijdens of na een cyberbeveiligingsincident", "RC.RP-1", 0, null },
                    { new Guid("86faabda-2814-49c4-9b42-20212b49782a"), new Guid("b654d831-9b49-4bb6-a9de-a8ca183a7064"), null, null, null, "Kwaadaardige code is gedetecteerd", "DE.CM-4", 0, null },
                    { new Guid("887bcf23-304d-4fde-9cf9-c90d6c9ab037"), new Guid("02178fc5-8e83-4aa1-8252-a76edda31d02"), null, null, null, "Informatie over cyberdreigingen wordt ontvangen van forums en bronnen waar informatie wordt gedeeld", "ID.RA-2", 0, null },
                    { new Guid("88f4119c-cfcd-4279-a2e5-0ac5b699d521"), new Guid("8849e851-d000-4f43-89cf-e84a2875dd9a"), null, null, null, "Public relations worden beheerd", "RC.CO-1", 0, null },
                    { new Guid("8afd1a95-a3e7-40a5-af34-8b9e7a34f628"), new Guid("01af50a3-adf4-4b32-9598-7e146d5e2e2c"), null, null, null, "Prioriteiten voor de missie, doelstellingen en activiteiten van de organisatie worden vastgesteld en gecommuniceerd", "ID.BE-3", 0, null },
                    { new Guid("8b6034c1-cae5-4f89-b673-3c76fe9cf7af"), new Guid("b654d831-9b49-4bb6-a9de-a8ca183a7064"), null, null, null, "De fysieke omgeving wordt bewaakt om potentiële cyberbeveiligingsgebeurtenissen te detecteren", "DE.CM-2", 0, null },
                    { new Guid("8b8552af-cb2e-4b4d-90af-bd2f6bd71f1a"), new Guid("3e57c961-a040-4865-a9ce-743a31597813"), null, null, null, "Personeel kent hun rol en volgorde van handelen wanneer een reactie nodig is", "RS.CO-1", 0, null },
                    { new Guid("8b879c8b-ab8e-408b-baee-084d7ba9659e"), new Guid("a9d192d6-4eea-44a8-9b77-16008c85cb79"), null, null, null, "Gegevens worden vernietigd volgens beleid", "PR.IP-6", 0, null },
                    { new Guid("8dab09d8-1098-4aae-8a1a-dd57e6c86d85"), new Guid("b572fdd8-874c-4724-8f8c-8893f16c0d38"), null, null, null, "Cyberbeveiligingsrollen, -verantwoordelijkheden en -bevoegdheden voor het voltallige personeel en externe belanghebbenden zijn vastgesteld.", "ID.AM-6", 0, null },
                    { new Guid("8f4dc8d7-f883-4dbc-9caa-6b90e8bf2d0c"), new Guid("8d21ff39-9e60-47e8-bccc-eec610d7b576"), null, null, null, "Gedetecteerde gebeurtenissen worden geanalyseerd om aanvalsdoelen en -methoden te begrijpen", "DE.AE-2", 0, null },
                    { new Guid("9363a8ce-d0ca-4674-8cc4-34aac6fcaade"), new Guid("8d21ff39-9e60-47e8-bccc-eec610d7b576"), null, null, null, "Gebeurtenisgegevens worden verzameld en gecorreleerd vanuit meerdere bronnen en sensoren", "DE.AE-3", 0, null },
                    { new Guid("94c13ed9-51a3-4702-9876-895c347c86f8"), new Guid("a9d192d6-4eea-44a8-9b77-16008c85cb79"), null, null, null, "Er wordt een basisconfiguratie van informatietechnologie/industriële besturingssystemen gemaakt en onderhouden, waarin beveiligingsprincipes zijn opgenomen (bijv. het concept van de minste functionaliteit).", "PR.IP-1", 0, null },
                    { new Guid("98b051e5-c52e-411f-930b-34980075cb22"), new Guid("a9d192d6-4eea-44a8-9b77-16008c85cb79"), null, null, null, "Er wordt voldaan aan beleid en voorschriften met betrekking tot de fysieke werkomgeving voor bedrijfsmiddelen van de organisatie.", "PR.IP-5", 0, null },
                    { new Guid("993b7cd9-4b1b-4d76-a871-fc336b78d766"), new Guid("3a281d1c-8c2f-4fb6-bd19-3cd6c3ea6d7b"), null, null, null, "Leveranciers en externe partners van informatiesystemen, onderdelen en diensten worden geïdentificeerd, geprioriteerd en beoordeeld met behulp van een proces voor de beoordeling van cyberrisico's in de toeleveringsketen.", "ID.SC-2", 0, null },
                    { new Guid("9b373dc1-5be5-4358-ab6a-ad15b03d977b"), new Guid("8d21ff39-9e60-47e8-bccc-eec610d7b576"), null, null, null, "Drempels voor incidentenwaarschuwing zijn vastgesteld", "DE.AE-5", 0, null },
                    { new Guid("9c0bc48b-b1e9-46a3-b6af-20a5e231e09c"), new Guid("18678c37-a299-4ca4-b610-607beb60a1a2"), null, null, null, "Herstelactiviteiten worden gecommuniceerd naar interne en externe belanghebbenden en naar uitvoerende en managementteams", "RC.CO-3", 0, null },
                    { new Guid("9d3ade37-8d5b-492a-9e18-4624c9a9221b"), new Guid("978c228f-7b3b-4054-8d77-8cc40274a263"), null, null, null, "Er zijn processen vastgesteld om kwetsbaarheden te ontvangen, te analyseren en te reageren op kwetsbaarheden die door interne en externe bronnen (bijv. interne tests, beveiligingsbulletins of beveiligingsonderzoekers) aan de organisatie worden doorgegeven.", "RS.AN-5", 0, null },
                    { new Guid("9da1be8f-b8b4-4682-8b99-e04fe8faa7a2"), new Guid("b654d831-9b49-4bb6-a9de-a8ca183a7064"), null, null, null, "Ongeautoriseerde mobiele code gedetecteerd", "DE.CM-5", 0, null },
                    { new Guid("9ed1543c-cd61-4681-98b2-69a6e635577d"), new Guid("1d234796-662d-4391-ba62-27397fbdfbc4"), null, null, null, "Het principe van de minste functionaliteit wordt toegepast door systemen zo te configureren dat ze alleen essentiële mogelijkheden bieden.", "PR.PT-3", 0, null },
                    { new Guid("9f7aeb36-fcd2-45d6-a545-38ed6e54cc79"), new Guid("978c228f-7b3b-4054-8d77-8cc40274a263"), null, null, null, "De gevolgen van het incident worden begrepen", "RS.AN-2", 0, null },
                    { new Guid("a09848d8-1343-4054-a183-1827d224b033"), new Guid("18678c37-a299-4ca4-b610-607beb60a1a2"), null, null, null, "Public relations worden beheerd", "RC.CO-1", 0, null },
                    { new Guid("a135607e-ef53-4b12-a0bc-c5765e64c972"), new Guid("1ffbf56c-727e-43a1-b66f-e3be9f6f585c"), null, null, null, "Onderhoud op afstand van bedrijfsmiddelen wordt goedgekeurd, vastgelegd en uitgevoerd op een manier die onbevoegde toegang voorkomt.", "PR.MA-2", 0, null },
                    { new Guid("a170ca9e-ea86-48b0-ae11-72499403f43c"), new Guid("02178fc5-8e83-4aa1-8252-a76edda31d02"), null, null, null, "Risicomaatregelen worden geïdentificeerd en geprioriteerd", "ID.RA-6", 0, null },
                    { new Guid("a5beeb6d-a44f-4ca6-b6eb-f15f3ea74ea7"), new Guid("a9d192d6-4eea-44a8-9b77-16008c85cb79"), null, null, null, "Er wordt een plan voor kwetsbaarheidsmanagement ontwikkeld en geïmplementeerd", "PR.IP-12", 0, null },
                    { new Guid("a72a7823-76ab-4bff-a3e2-55d851334606"), new Guid("a347cd22-9140-4811-ae86-279654488323"), null, null, null, "Toegangsmachtigingen en autorisaties worden beheerd, waarbij de principes van 'least privilege' en scheiding van taken worden toegepast.", "PR.AC-4", 0, null },
                    { new Guid("a7563fc7-4ff2-44fe-a5f2-a79bec793214"), new Guid("3e57c961-a040-4865-a9ce-743a31597813"), null, null, null, "Incidenten worden gerapporteerd volgens vastgestelde criteria", "RS.CO-2", 0, null },
                    { new Guid("a886013f-bc1a-411d-9dbe-7bb806388a4d"), new Guid("b572fdd8-874c-4724-8f8c-8893f16c0d38"), null, null, null, "Organisatiecommunicatie en gegevensstromen worden in kaart gebracht", "ID.AM-3", 0, null },
                    { new Guid("ad038674-ef85-43cd-a9ff-905aa6f2ab9c"), new Guid("4919ea9b-c4f7-45ba-9151-7667dbc43a71"), null, null, null, "Fysiek en cyberbeveiligingspersoneel begrijpen hun rollen en verantwoordelijkheden", "PR.AT-5", 0, null },
                    { new Guid("b2cc39a8-f829-472d-bd79-b75d4b252f91"), new Guid("02178fc5-8e83-4aa1-8252-a76edda31d02"), null, null, null, "Kwetsbaarheden van bedrijfsmiddelen worden geïdentificeerd en gedocumenteerd", "ID.RA-1", 0, null },
                    { new Guid("b5c9140c-5b33-40e5-b5a6-b57b2aa70bc4"), new Guid("a347cd22-9140-4811-ae86-279654488323"), null, null, null, "Fysieke toegang tot bedrijfsmiddelen wordt beheerd en beschermd", "PR.AC-2", 0, null },
                    { new Guid("b66c92d9-823a-4df8-9a23-2a83067194f7"), new Guid("90eaf9ed-c180-405b-97f2-4bb13b79231f"), null, null, null, "Wettelijke en regelgevende vereisten met betrekking tot cyberbeveiliging, inclusief verplichtingen op het gebied van privacy en burgerlijke vrijheden, worden begrepen en beheerd.", "ID.GV-3", 0, null },
                    { new Guid("b6acfec6-f955-41a9-aa88-fbacb57183b4"), new Guid("18678c37-a299-4ca4-b610-607beb60a1a2"), null, null, null, "Herstelactiviteiten worden gecommuniceerd naar interne en externe belanghebbenden en naar uitvoerende en managementteams", "RC.CO-3", 0, null },
                    { new Guid("b7f2b613-a98a-465f-a32c-8033c7be56ab"), new Guid("eaa515f4-682b-43a8-b3bf-4d3d190d141d"), null, null, null, "De ontwikkel- en testomgeving(en) zijn gescheiden van de productieomgeving", "PR.DS-7", 0, null },
                    { new Guid("bb798c04-ef09-49a9-9bc1-f4f6262419d8"), new Guid("a347cd22-9140-4811-ae86-279654488323"), null, null, null, "Gebruikers, apparaten en andere middelen worden geverifieerd (bijv. single-factor, multi-factor) in overeenstemming met het risico van de transactie (bijv. de veiligheids- en privacyrisico's van individuen en andere organisatorische risico's).", "PR.AC-7", 0, null },
                    { new Guid("bfa190b6-8988-4781-9864-0a7a6c003fcc"), new Guid("1ffbf56c-727e-43a1-b66f-e3be9f6f585c"), null, null, null, "Onderhoud en reparatie van bedrijfsmiddelen van de organisatie worden uitgevoerd en geregistreerd met goedgekeurde en gecontroleerde gereedschappen.", "PR.MA-1", 0, null },
                    { new Guid("c7ed2d73-037e-441c-a99e-3bac0d81572e"), new Guid("1d234796-662d-4391-ba62-27397fbdfbc4"), null, null, null, "Verwijderbare media worden beschermd en het gebruik ervan beperkt volgens het beleid", "PR.PT-2", 0, null },
                    { new Guid("c9f99618-f5e8-4419-ab4c-042b11b468f2"), new Guid("5acbf9d5-6de3-4c86-a451-cb59b74f33c9"), null, null, null, "De organisatie bepaalt haar risicotolerantie op basis van haar rol in kritieke infrastructuur en sectorspecifieke risicoanalyse.", "ID.RM-3", 0, null },
                    { new Guid("cc382bd0-95d4-4617-8bb9-acf89e042696"), new Guid("9cbf1981-d460-4ae7-8bd9-f6fe632b71fb"), null, null, null, "Detectieprocessen worden getest", "DE.DP-3", 0, null },
                    { new Guid("d0bc871e-ca67-4503-bf32-4efda76e36b9"), new Guid("01af50a3-adf4-4b32-9598-7e146d5e2e2c"), null, null, null, "De veerkrachtvereisten ter ondersteuning van de levering van kritieke diensten zijn vastgesteld voor alle operationele toestanden (bijv. onder dwang/aanval, tijdens herstel, normale activiteiten).", "ID.BE-5", 0, null },
                    { new Guid("d0c3e227-05f1-4be8-a6ee-ac0418fdb94c"), new Guid("b654d831-9b49-4bb6-a9de-a8ca183a7064"), null, null, null, "Kwetsbaarheidsscans worden uitgevoerd", "DE.CM-8", 0, null },
                    { new Guid("d1002e67-98fe-423c-a19c-d4dbc7a28c8c"), new Guid("eaa515f4-682b-43a8-b3bf-4d3d190d141d"), null, null, null, "Gegevens in rust zijn beschermd", "PR.DS-1", 0, null },
                    { new Guid("d60c4129-d959-4404-beeb-3cd1236cfc01"), new Guid("a9d192d6-4eea-44a8-9b77-16008c85cb79"), null, null, null, "Er wordt een System Development Life Cycle geïmplementeerd om systemen te beheren.", "PR.IP-2", 0, null },
                    { new Guid("db73a316-49cb-4db4-9ed9-a59a93bfd92b"), new Guid("eaa515f4-682b-43a8-b3bf-4d3d190d141d"), null, null, null, "Beveiligingen tegen datalekken worden geïmplementeerd", "PR.DS-5", 0, null },
                    { new Guid("ddde1cc2-0859-4584-b51a-be69282718f4"), new Guid("90eaf9ed-c180-405b-97f2-4bb13b79231f"), null, null, null, "Governance- en risicobeheerprocessen richten zich op cyberbeveiligingsrisico's", "ID.GV-4", 0, null },
                    { new Guid("de3a3e6e-a45c-47be-a4f9-b447feb31d46"), new Guid("01af50a3-adf4-4b32-9598-7e146d5e2e2c"), null, null, null, "Afhankelijkheden en kritieke functies voor de levering van kritieke diensten zijn vastgesteld", "ID.BE-4", 0, null },
                    { new Guid("ded75e10-c86a-482b-94c0-21c279b9d06d"), new Guid("9cbf1981-d460-4ae7-8bd9-f6fe632b71fb"), null, null, null, "Informatie over gebeurtenisdetectie wordt doorgegeven", "DE.DP-4", 0, null },
                    { new Guid("e0e23fa5-5ad1-4fa2-8941-c3518ed7f28e"), new Guid("da934b99-ebd3-49dd-a39b-18e6d917c7db"), null, null, null, "Herstelplannen bevatten geleerde lessen", "RC.IM-1", 0, null },
                    { new Guid("e3371e7c-8c1c-4267-9bae-25bc27d031be"), new Guid("a347cd22-9140-4811-ae86-279654488323"), null, null, null, "Toegang op afstand wordt beheerd", "PR.AC-3", 0, null },
                    { new Guid("e75a72b6-82ea-4ed3-92d5-09f3d1f119f1"), new Guid("9cbf1981-d460-4ae7-8bd9-f6fe632b71fb"), null, null, null, "Detectieactiviteiten voldoen aan alle toepasselijke vereisten", "DE.DP-2", 0, null },
                    { new Guid("e8eb7120-994f-4070-8b3e-fc67a8e04a5f"), new Guid("a9d192d6-4eea-44a8-9b77-16008c85cb79"), null, null, null, "Responsplannen (Incident Response en Business Continuity) en herstelplannen (Incident Recovery en Disaster Recovery) zijn aanwezig en worden beheerd", "PR.IP-9", 0, null },
                    { new Guid("ef1d0332-6030-4832-86c2-b4b45c186364"), new Guid("4919ea9b-c4f7-45ba-9151-7667dbc43a71"), null, null, null, "Bevoegde gebruikers begrijpen hun rollen en verantwoordelijkheden", "PR.AT-2", 0, null },
                    { new Guid("f24aa659-df77-485f-bbfe-b464866e1c05"), new Guid("8849e851-d000-4f43-89cf-e84a2875dd9a"), null, null, null, "Herstelactiviteiten worden gecommuniceerd naar interne en externe belanghebbenden en naar uitvoerende en managementteams", "RC.CO-3", 0, null },
                    { new Guid("f4090957-3135-4f6c-a4d3-14d127ac7e50"), new Guid("eaa515f4-682b-43a8-b3bf-4d3d190d141d"), null, null, null, "Voldoende capaciteit om de beschikbaarheid te garanderen", "PR.DS-4", 0, null },
                    { new Guid("f558c9e0-2ed6-4eb2-b651-cffd6b378279"), new Guid("b654d831-9b49-4bb6-a9de-a8ca183a7064"), null, null, null, "Het netwerk wordt bewaakt om potentiële cyberbeveiligingsgebeurtenissen te detecteren", "DE.CM-1", 0, null },
                    { new Guid("fc71ec5f-3851-43b5-a74a-f0059829de1f"), new Guid("3e57c961-a040-4865-a9ce-743a31597813"), null, null, null, "Coördinatie met belanghebbenden vindt plaats in overeenstemming met responsplannen", "RS.CO-4", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Requirements",
                columns: new[] { "Id", "Code", "Created", "Deleted", "Description", "Name", "Order", "SubCategoryId", "Updated" },
                values: new object[,]
                {
                    { new Guid("00e63028-3683-485b-97a7-434edd73c9bd"), null, null, null, "Firewalls moeten worden geïnstalleerd en gebruikt op de netwerkgrenzen en worden aangevuld met firewallbescherming op de eindpunten.", "DE.CM-1.1", 0, new Guid("f558c9e0-2ed6-4eb2-b651-cffd6b378279"), null },
                    { new Guid("066346b0-2f4c-4d9d-a534-8444d2d92c3e"), null, null, null, "De organisatie moet geautomatiseerde mechanismen en door het systeem gegenereerde waarschuwingen implementeren om eventdetectie te ondersteunen en te helpen bij het vaststellen van drempelwaarden voor beveiligingswaarschuwingen.", "DE.AE-5.1", 0, new Guid("9b373dc1-5be5-4358-ab6a-ad15b03d977b"), null },
                    { new Guid("07e18b14-a36a-4f9e-bf4b-e8eb90c0b0c0"), null, null, null, "De personen die verantwoordelijk en aansprakelijk zijn voor het beheer van softwareplatforms en applicaties binnen de organisatie moeten worden geïdentificeerd.", "ID.AM-2.3", 0, new Guid("713518df-8599-4ae3-ba32-c16ab59f70f5"), null },
                    { new Guid("07e68bab-a6fe-46fc-86ee-a2920102ee86"), null, null, null, "De naleving door externe dienstverleners van het beleid en de procedures voor de beveiliging van het personeel en de beveiligingseisen van het contract worden gecontroleerd met betrekking tot hun risico's op het gebied van cyberbeveiliging.", "DE.CM-6.2", 0, new Guid("34d2abc7-adfe-45d5-a8fe-791bc4d728d7"), null },
                    { new Guid("0bf27cce-7945-4e28-82c3-75c83453cfab"), null, null, null, "De organisatie moet valideren dat eventdetectieprocessen werken zoals bedoeld.", "DE.DP-3.1", 0, new Guid("cc382bd0-95d4-4617-8bb9-acf89e042696"), null },
                    { new Guid("0c64bddf-f85b-4398-9c41-cd151a437026"), null, null, null, "De gebruiksbeperking van draagbare opslagmedia moet worden gewaarborgd door middel van een geschikt gedocumenteerd beleid en ondersteunende waarborgen.", "PR.PT-2.1", 0, new Guid("c7ed2d73-037e-441c-a99e-3bac0d81572e"), null },
                    { new Guid("0ed6bd0b-7e3e-4ca7-a10d-316d3d0fb2ba"), null, null, null, "Er moet een allesomvattende strategie worden ontwikkeld en geïmplementeerd om de risico's voor de kritieke systemen van de organisatie te beheren, inclusief de identificatie en prioritering van risicomaatregelen.", "ID.RA-6.1", 0, new Guid("a170ca9e-ea86-48b0-ae11-72499403f43c"), null },
                    { new Guid("103820c1-3688-4475-a8cd-454b0dad4dd4"), null, null, null, "De organisatie voert detectieactiviteiten uit in overeenstemming met toepasselijke federale en regionale wetten, industriële voorschriften en standaarden, beleidsregels en andere toepasselijke vereisten.", "DE.DP-2.1", 0, new Guid("e75a72b6-82ea-4ed3-92d5-09f3d1f119f1"), null },
                    { new Guid("1f5ce754-920c-4759-b382-ba56b4a3e925"), null, null, null, "Informatie-/cyberbeveiligingsincidenten worden gecategoriseerd op basis van de ernst en impact overeenkomstig de evaluatiecriteria in het incidentbestrijdingsplan.", "RS.AN-4.1", 0, new Guid("31b34e3b-6f00-4b04-b00b-d93bfe09306e"), null },
                    { new Guid("21fbd597-4679-4c5f-b7d0-965c3e50f772"), null, null, null, "Prioriteiten voor de missie, doelstellingen en activiteiten van de organisatie worden vastgesteld en gecommuniceerd.", "ID.BE-3.1", 0, new Guid("8afd1a95-a3e7-40a5-af34-8b9e7a34f628"), null },
                    { new Guid("221e49bd-8f7b-43d2-ae5b-4c4c46a5e4cb"), null, null, null, "De organisatie moet ervoor zorgen dat gebeurtenisgegevens worden verzameld en gecorreleerd over de kritieke systemen met behulp van verschillende bronnen, zoals gebeurtenisrapporten, auditmonitoring, netwerkmonitoring, fysieke toegangsmonitoring en gebruikers-/beheerdersrapporten.", "DE.AE-3.2", 0, new Guid("9363a8ce-d0ca-4674-8cc4-34aac6fcaade"), null },
                    { new Guid("23a84fe4-f6f1-43bf-b14b-41fb87ae3d70"), null, null, null, "Er wordt een aparte alternatieve opslaglocatie voor back-ups van het systeem gebruikt en dezelfde veiligheidswaarborgen als de primaire opslaglocatie worden toegepast", "PR.IP-4.3", 0, new Guid("30a7fc06-3dc9-4581-b5c1-e732338fdf06"), null },
                    { new Guid("24d1bc45-4ef4-4cc4-8aac-f6ad902a7140"), null, null, null, "De organisatie moet rapportages implementeren over informatie-/cyberbeveiligingsincidenten op haar kritieke systemen binnen een door de organisatie gedefinieerd tijdsbestek aan door de organisatie gedefinieerd personeel of door de organisatie gedefinieerde rollen.", "RS.CO-2.1", 0, new Guid("a7563fc7-4ff2-44fe-a5f2-a79bec793214"), null },
                    { new Guid("26a9b019-1efb-4325-ac8f-997875eb758a"), null, null, null, "De organisatie moet preventief onderhoud en reparaties aan haar kritieke systeemonderdelen plannen, uitvoeren en documenteren volgens goedgekeurde processen en hulpmiddelen.", "PR.MA-1.2", 0, new Guid("bfa190b6-8988-4781-9864-0a7a6c003fcc"), null },
                    { new Guid("26b66075-0434-423f-af25-884c6015b689"), null, null, null, "De plaats van de organisatie in kritieke infrastructuur en haar bedrijfstak moet worden vastgesteld en gecommuniceerd.", "ID.BE-2.1", 0, new Guid("279dc133-e6d3-41ce-acde-e2ee99c4576b"), null },
                    { new Guid("26e39390-bbc2-4da3-a122-bd5dfa9cc98c"), null, null, null, "De organisatie moet ervoor zorgen dat de logboekrecords een gezaghebbende tijdbron of interne kloktijdstempel bevatten die worden vergeleken en gesynchroniseerd met een gezaghebbende tijdbron.", "PR.PT-1.2", 0, new Guid("732ffe91-6f74-409f-ba09-72578ce1eecd"), null },
                    { new Guid("279a2544-424d-463e-9e75-96d14fb136a8"), null, null, null, "Informatie/informatie over cyberbeveiligingsincidenten moet worden gecommuniceerd en gedeeld met de werknemers van de organisatie in een formaat dat zij kunnen begrijpen.", "RS.CO-3.1", 0, new Guid("4a9ac2f5-eeb5-4d54-af1f-61eb06ecc03f"), null },
                    { new Guid("2b1cec00-1a92-4bc9-9aca-e7a8c5dcf122"), null, null, null, "De organisatie moet minstens één keer per jaar risicobeoordelingen van de cybertoeleveringsketen uitvoeren of wanneer zich een wijziging voordoet in de kritieke systemen, de operationele omgeving of de toeleveringsketen van de organisatie; deze beoordelingen moeten worden gedocumenteerd en de resultaten moeten worden verspreid onder relevante belanghebbenden, waaronder degenen die verantwoordelijk zijn voor ICT/OT-systemen.", "ID.SC-2.1", 0, new Guid("993b7cd9-4b1b-4d76-a871-fc336b78d766"), null },
                    { new Guid("2c789e9f-0784-4e92-a0d4-c410fd50bd88"), null, null, null, "Een inventarisatie van bedrijfsmiddelen die verband houden met informatie en informatieverwerkingsfaciliteiten binnen de organisatie moet worden gedocumenteerd, herzien en bijgewerkt wanneer zich wijzigingen voordoen.", "ID.AM-1.1", 0, new Guid("6e795f27-4c41-40e9-81d5-63d23b9b1d60"), null },
                    { new Guid("2d42aa5f-7a45-4ccf-90a6-9f733489dde4"), null, null, null, "In de levenscyclus van systeem- en applicatieontwikkeling wordt rekening gehouden met beveiliging.", "PR.IP-2.1", 0, new Guid("d60c4129-d959-4404-beeb-3cd1236cfc01"), null },
                    { new Guid("30882678-259f-4b8e-a0fa-81f3dbb3f4f9"), null, null, null, "De organisatie deelt informatie/informatie over cyberbeveiligingsincidenten met relevante belanghebbenden zoals voorzien in het incidentbestrijdingsplan.", "RS.CO-3.2", 0, new Guid("4a9ac2f5-eeb5-4d54-af1f-61eb06ecc03f"), null },
                    { new Guid("3170596e-561c-472b-9b80-ebddf15feeb5"), null, null, null, "De inventaris van bedrijfsmiddelen die verband houden met informatie en informatieverwerkingsfaciliteiten moet veranderingen in de  context van de organisatie weerspiegelen  en alle informatie bevatten die nodig is voor effectieve verantwoording.", "ID.AM-1.2", 0, new Guid("6e795f27-4c41-40e9-81d5-63d23b9b1d60"), null },
                    { new Guid("31eb31ff-4358-4682-b3a5-224e38d1e704"), null, null, null, "De betrouwbaarheid en integriteit van back-ups moet regelmatig worden geverifieerd en getest.", "PR.IP-4.2", 0, new Guid("30a7fc06-3dc9-4581-b5c1-e732338fdf06"), null },
                    { new Guid("346c09ae-b214-4dc8-84a3-6a50654e31af"), null, null, null, "Web- en e-mailfilters moeten worden geïnstalleerd en gebruikt.", "PR.PT-4.1", 0, new Guid("34af178a-0d8a-453e-bb7e-0e07494fa221"), null },
                    { new Guid("34f344e3-d8b8-4c29-b113-c1d6c6734739"), null, null, null, "Informatiebeveiligings- en cyberbeveiligingsrisico's worden gedocumenteerd, formeel goedgekeurd en bijgewerkt wanneer zich wijzigingen voordoen.", "ID.GV-4.2", 0, new Guid("ddde1cc2-0859-4584-b51a-be69282718f4"), null },
                    { new Guid("36bfec99-9376-48db-a364-a1cc3b8ee624"), null, null, null, "Logboeken moeten worden bijgehouden, gedocumenteerd en herzien.", "PR.PT-1.1", 0, new Guid("732ffe91-6f74-409f-ba09-72578ce1eecd"), null },
                    { new Guid("3a5a6217-c361-4030-a13c-50d0e90604e0"), null, null, null, "De organisatie moet een basisconfiguratie voor de bedrijfskritische systemen ontwikkelen, documenteren en onderhouden.", "PR.IP-1.1", 0, new Guid("94c13ed9-51a3-4702-9876-895c347c86f8"), null },
                    { new Guid("3a6e13c5-f62f-4324-9c98-63beece787ac"), null, null, null, "Hogere leidinggevenden moeten aantonen dat ze hun rollen, verantwoordelijkheden en bevoegdheden begrijpen.", "PR.AT-4.1", 0, new Guid("74619b12-fcfb-4bcf-84b9-e960e8b1cc92"), null },
                    { new Guid("3b58b2f0-8d7b-4b1f-adf2-2eb6d4282e2e"), null, null, null, "Wanneer ongeautoriseerde hardware wordt gedetecteerd, wordt deze in quarantaine geplaatst voor mogelijke uitzonderingsbehandeling, verwijderd of vervangen en wordt de inventaris bijgewerkt.", "ID.AM-1.3", 0, new Guid("6e795f27-4c41-40e9-81d5-63d23b9b1d60"), null },
                    { new Guid("3c4def8e-25a1-44fd-86a9-6dfd1a29a661"), null, null, null, "Bedreigingen en kwetsbaarheden moeten worden geïdentificeerd.", "ID.RA-1.1", 0, new Guid("b2cc39a8-f829-472d-bd79-b75d4b252f91"), null },
                    { new Guid("3c89aa9f-ad20-4dfb-a085-ccd1a8c5dc9a"), null, null, null, "De organisatie deelt informatie/informatie over cyberbeveiligingsincidenten vrijwillig, indien van toepassing, met externe belanghebbenden, beveiligingsgroepen uit de branche, om een breder situationeel bewustzijn van informatie/cyberbeveiliging te bereiken.", "RS.CO-5.1", 0, new Guid("4e564fec-29fa-41eb-adb2-daf82f66a950"), null },
                    { new Guid("3cb91a49-8903-4548-82ce-39734648ecaa"), null, null, null, "De organisatie moet evaluaties uitvoeren na een incident om de lessen te analyseren die zijn geleerd uit de reactie op een incident en het herstel, en vervolgens processen / procedures / technologieën verbeteren om de cyberweerbaarheid te vergroten.", "RS.IM-1.1", 0, new Guid("24203a47-35b9-49fd-91fa-5f2859b7d921"), null },
                    { new Guid("3f788de5-7db3-4587-8797-6d81952e1ef1"), null, null, null, "Identiteiten en referenties voor geautoriseerde apparaten en gebruikers moeten worden beheerd, waar mogelijk via geautomatiseerde mechanismen.", "PR.AC-1.2", 0, new Guid("6bc829fe-3193-4646-8868-bcf130333741"), null },
                    { new Guid("4101f946-c223-4367-8836-e48ec75061a1"), null, null, null, "Wettelijke en regelgevende vereisten met betrekking tot informatie-/cyberbeveiliging, waaronder privacyverplichtingen, worden beheerd.", "ID.GV-3.2", 0, new Guid("b66c92d9-823a-4df8-9a23-2a83067194f7"), null },
                    { new Guid("4291fe1f-8192-4843-a193-804f11a8afa4"), null, null, null, "De organisatie moet ervoor zorgen dat sterke authenticators, registratie en sessiebeëindiging voor onderhoud op afstand worden geïmplementeerd.", "PR.MA-2.2", 0, new Guid("a135607e-ef53-4b12-a0bc-c5765e64c972"), null },
                    { new Guid("446bca0e-1fe8-4f3e-ade2-b3a116e300c3"), null, null, null, "De organisatie moet herstelactiviteiten communiceren aan vooraf gedefinieerde belanghebbenden, uitvoerende en managementteams.", "RC.CO-3.1", 0, new Guid("f24aa659-df77-485f-bbfe-b464866e1c05"), null },
                    { new Guid("45572035-97b5-43d7-b539-a42f42cf5985"), null, null, null, "De organisatie moet beleid en procedures definiëren, implementeren en handhaven met betrekking tot nood- en veiligheidssystemen, brandbeveiligingssystemen en omgevingscontroles voor haar kritieke systemen.", "PR.IP-5.1", 0, new Guid("98b051e5-c52e-411f-930b-34980075cb22"), null },
                    { new Guid("4605ac3d-dfe0-4a1c-9687-9dc45582653e"), null, null, null, "Er moet een incidentresponsproces, inclusief rollen, verantwoordelijkheden en bevoegdheden, worden uitgevoerd tijdens of na een informatie-/cyberbeveiligingsincident op de kritieke systemen van de organisatie.", "RS.RP-1.1", 0, new Guid("713f72bc-e9be-4ae3-8982-69fa9a16bbfc"), null },
                    { new Guid("47585fef-7d59-4cc9-a735-1948faa5dd6b"), null, null, null, "Waar nodig moet de netwerkintegriteit van de kritieke systemen van de organisatie worden beschermd door netwerksegmentatie en -segregatie.", "PR.AC-5.2", 0, new Guid("4d2fa7a8-e0c1-4cac-bc11-911430c1e47a"), null },
                    { new Guid("486f47f9-440c-4f01-abf4-00f96395b373"), null, null, null, "Om de cyberweerbaarheid te ondersteunen en de levering van kritieke diensten te beveiligen, worden de nodige vereisten geïdentificeerd, gedocumenteerd en hun implementatie getest en goedgekeurd.", "ID.BE-5.1", 0, new Guid("d0bc871e-ca67-4503-bf32-4efda76e36b9"), null },
                    { new Guid("48d9b9b8-0104-4110-a8e5-f0930e109e6e"), null, null, null, "De organisatie moet controleren en scannen op kwetsbaarheden in haar kritieke systemen en gehoste applicaties en ervoor zorgen dat de systeemfuncties niet negatief worden beïnvloed door het scanproces.", "DE.CM-8.1", 0, new Guid("d0c3e227-05f1-4be8-a6ee-ac0418fdb94c"), null },
                    { new Guid("4aa609e0-63bf-45d1-a80a-6c08d7ba7fd5"), null, null, null, "De organisatie moet software-, firmware- en informatie-integriteitscontroles implementeren om ongeautoriseerde wijzigingen in de kritieke systeemcomponenten tijdens opslag, transport en opstarten te detecteren en wanneer dit nodig is.", "PR.DS-6.1", 0, new Guid("18fff895-9fc1-4a3e-9a3a-cceca872330e"), null },
                    { new Guid("4c9e4623-0afc-4dc5-a394-8107d5d9aa8a"), null, null, null, "Bij het beheer van toegangsrechten moet scheiding van taken (SoD) worden gewaarborgd.", "PR.AC-4.6", 0, new Guid("a72a7823-76ab-4bff-a3e2-55d851334606"), null },
                    { new Guid("4d6b062d-9e35-4af2-be79-6804fece50b8"), null, null, null, "Patches en beveiligingsupdates voor besturingssystemen en kritieke systeemonderdelen moeten worden geïnstalleerd.", "PR.MA-1.1", 0, new Guid("bfa190b6-8988-4781-9864-0a7a6c003fcc"), null },
                    { new Guid("4d8b5409-3b97-40e6-837f-244b0fad2649"), null, null, null, "Waar nodig moet de netwerkintegriteit van de kritieke systemen van de organisatie worden beschermd door (1) Verbindingen tussen systeemcomponenten identificeren, documenteren en controleren. (2) Externe verbindingen naar kritieke systemen van de organisatie beperken. ", "PR.AC-5.3", 0, new Guid("4d2fa7a8-e0c1-4cac-bc11-911430c1e47a"), null },
                    { new Guid("52c22d9e-5b72-4966-a766-8cacc65cca1c"), null, null, null, "De organisatie moet ervoor zorgen dat de gegevens van haar kritieke systemen worden vernietigd in overeenstemming met het beleid.", "PR.IP-6.1", 0, new Guid("8b879c8b-ab8e-408b-baee-084d7ba9659e"), null },
                    { new Guid("57cf6725-6639-48d3-a617-6c8189c84026"), null, null, null, "Er moet een informatiebeveiligings- en cyberbeveiligingsbeleid voor de hele organisatie worden opgesteld, gedocumenteerd, bijgewerkt wanneer zich wijzigingen voordoen, verspreid en goedgekeurd door het senior management.", "ID.GV-1.2", 0, new Guid("778a003a-ae85-40f6-a8e3-2f0d7273f87c"), null },
                    { new Guid("5903d1e9-bdf7-491f-a8d7-5a08906c740c"), null, null, null, "De organisatie dient acceptabele en onacceptabele mobiele code en mobiele code technologieën te definiëren; en het gebruik van mobiele code binnen het systeem te autoriseren, monitoren en controleren.", "DE.CM-5.1", 0, new Guid("9da1be8f-b8b4-4682-8b99-e04fe8faa7a2"), null },
                    { new Guid("59a244c1-768c-46ab-bae1-878164cbb239"), null, null, null, "Personeel dat toegang heeft tot de meest kritieke informatie of technologie van de organisatie moet worden geverifieerd.", "PR.IP-11.1", 0, new Guid("2141bf50-5f2f-45cd-bd44-3e11a197f7bf"), null },
                    { new Guid("5a6de140-50ea-42ff-a4b1-a8cebf75fb44"), null, null, null, "Een inventaris die weergeeft welke softwareplatforms en applicaties in de organisatie worden gebruikt, moet worden gedocumenteerd, herzien en bijgewerkt wanneer zich wijzigingen voordoen.", "ID.AM-2.1", 0, new Guid("713518df-8599-4ae3-ba32-c16ab59f70f5"), null },
                    { new Guid("5cd9a71b-144b-48fe-93d6-3658937af379"), null, null, null, "Informatie die de organisatie opslaat en gebruikt, moet worden geïdentificeerd.", "ID.AM-3.1", 0, new Guid("a886013f-bc1a-411d-9dbe-7bb806388a4d"), null },
                    { new Guid("5dfa3fb0-84cb-4d9b-8add-84bb7d943db7"), null, null, null, "Een cyberrisicobeheerproces dat de belangrijkste interne en externe belanghebbenden identificeert en het aanpakken van risicogerelateerde kwesties en informatie vergemakkelijkt, moet worden gecreëerd, gedocumenteerd, herzien, goedgekeurd en bijgewerkt wanneer zich wijzigingen voordoen.", "ID.RM-1.1", 0, new Guid("0599f344-9c68-4942-9f90-05cd955c0bf2"), null },
                    { new Guid("5f278726-aac4-410e-b961-7f71d8c42478"), null, null, null, "De netwerken van de organisatie die op afstand worden benaderd, moeten worden beveiligd, onder andere door middel van multifactorauthenticatie (MFA).", "PR.AC-3.2", 0, new Guid("e3371e7c-8c1c-4267-9bae-25bc27d031be"), null },
                    { new Guid("5f8bf821-902e-49a4-a46d-9698b8904a07"), null, null, null, "Externe leveranciers zijn verplicht om elke overplaatsing, beëindiging of overgang van personeel met fysieke of logische toegang tot bedrijfskritische systeemonderdelen van de organisatie te melden.", "PR.AT-3.2", 0, new Guid("051cc8fb-a72f-47d8-aee4-81d1ddcb9256"), null },
                    { new Guid("6149036e-9ce5-4a2e-bdda-d0cee80bdbba"), null, null, null, "De organisatie moet gedocumenteerde procedures implementeren voor het verifiëren van de identiteit van personen voordat referenties worden uitgegeven die toegang geven tot de systemen van de organisatie.", "PR.AC-6.1", 0, new Guid("5f7578d2-ab6a-4f0d-8c67-3a6d54c85110"), null },
                    { new Guid("636e5224-4905-4792-b2a4-c2904bb78e34"), null, null, null, "Antivirus-, -spyware- en andere -malwareprogramma's moeten worden geïnstalleerd en bijgewerkt.", "DE.CM-4.1", 0, new Guid("86faabda-2814-49c4-9b42-20212b49782a"), null },
                    { new Guid("63ac466c-685f-48b0-a7f5-3bd5c7c05e4b"), null, null, null, "Firewalls moeten worden geïnstalleerd en geactiveerd op alle netwerken van de organisatie.", "PR.AC-5.1", 0, new Guid("4d2fa7a8-e0c1-4cac-bc11-911430c1e47a"), null },
                    { new Guid("6570a2f8-676a-4e8b-a469-4f88fd06cef5"), null, null, null, "De organisatie moet verbindingen en communicatie aan de buitengrenzen en aan belangrijke interne grenzen binnen de kritieke systemen van de organisatie bewaken en controleren door waar nodig grensbeschermingsapparatuur te implementeren.", "PR.AC-5.4", 0, new Guid("4d2fa7a8-e0c1-4cac-bc11-911430c1e47a"), null },
                    { new Guid("670e8b33-e333-4d90-8f63-854723796ad6"), null, null, null, "Auditgegevens van de kritische systemen van de organisatie moeten worden verplaatst naar een alternatief systeem.", "PR.DS-4.2", 0, new Guid("f4090957-3135-4f6c-a4d3-14d127ac7e50"), null },
                    { new Guid("68a71898-573c-472b-9650-9d8117607b84"), null, null, null, "Er moet een proces worden vastgesteld om kwetsbaarheden van de bedrijfskritische systemen van de organisatie continu te bewaken, te identificeren en te documenteren.", "ID.RA-1.2", 0, new Guid("b2cc39a8-f829-472d-bd79-b75d4b252f91"), null },
                    { new Guid("6dbb2471-e07e-4e97-8bd4-f22de661208a"), null, null, null, "Softwaregebruik en -installatiebeperkingen moeten worden afgedwongen.", "DE.CM-3.3", 0, new Guid("4268937d-a7c9-40f1-b0bc-5acd80487562"), null },
                    { new Guid("6dc25c17-1894-4824-8dd1-c0a4223ecc04"), null, null, null, "Alle verbindingen binnen de ICT/OT-omgeving van de organisatie en met andere interne platforms van de organisatie moeten in kaart worden gebracht, gedocumenteerd, goedgekeurd en waar nodig bijgewerkt.", "ID.AM-3.2", 0, new Guid("a886013f-bc1a-411d-9dbe-7bb806388a4d"), null },
                    { new Guid("6dff6632-ecfe-4aa2-825d-de28f00935e0"), null, null, null, "De organisatie moet verbeteringen die voortkomen uit de monitoring, metingen, beoordelingen en geleerde lessen opnemen in updates van het beschermingsproces (continue verbetering).", "PR.IP-7.1", 0, new Guid("83d2e050-a0f1-430e-9160-3d963355f590"), null },
                    { new Guid("723701a4-0a1e-4652-8047-90046857e12b"), null, null, null, "Niemand heeft beheerdersrechten voor dagelijkse taken.", "PR.AC-4.4", 0, new Guid("a72a7823-76ab-4bff-a3e2-55d851334606"), null },
                    { new Guid("73f20105-3b43-4cf0-b6da-f4c1f6f90fd0"), null, null, null, "De organisatie controleert leveranciers en gebruikers van bedrijfskritische diensten op naleving van de beveiligingseisen.", "PR.AT-3.3", 0, new Guid("051cc8fb-a72f-47d8-aee4-81d1ddcb9256"), null },
                    { new Guid("74930ef3-fd21-49c9-b69b-f6ece8e00104"), null, null, null, "Informatiebeveiligings- en cyberbeveiligingsrisico's worden gedocumenteerd, formeel goedgekeurd en bijgewerkt wanneer zich wijzigingen voordoen.", "ID.GV-4.2", 0, new Guid("ddde1cc2-0859-4584-b51a-be69282718f4"), null },
                    { new Guid("75820bf0-ecb6-45ce-aa7d-b9b86979f726"), null, null, null, "Een informatie- en cyberbeveiligingsproces voor personeelszaken ontwikkelen en onderhouden dat van toepassing is bij het werven, tijdens het dienstverband en bij beëindiging van het dienstverband.", "PR.IP-11.2", 0, new Guid("2141bf50-5f2f-45cd-bd44-3e11a197f7bf"), null },
                    { new Guid("7671e6b3-ae00-4dde-ba5c-b2af273aea18"), null, null, null, "GEEN VEREISTEN / Te overwegen richtlijnen", "", 0, new Guid("6089a8a0-e551-4dbd-822f-01287aa46dcc"), null },
                    { new Guid("7e608c31-6d86-41c1-8e59-a745b3a93cf8"), null, null, null, "De organisatie moet verantwoordelijkheid nastreven voor alle bedrijfskritische activa tijdens het systeemlevenscyclus, inclusief het verwijderen, overdragen en afstoting.", "PR.DS-3.2", 0, new Guid("3d6f6f8e-3e17-4cbd-be24-b9b915af40de"), null },
                    { new Guid("7f36dbcc-1493-4ff6-8e5d-4351ba1510ab"), null, null, null, "Identiteiten en referenties voor geautoriseerde apparaten en gebruikers worden beheerd.", "PR.AC-1.1", 0, new Guid("6bc829fe-3193-4646-8868-bcf130333741"), null },
                    { new Guid("80599bbc-dfb6-4906-aace-1e546b1bbe94"), null, null, null, "De organisatie dient beveiligingscontroles te verifiëren na hardwareonderhoud of -reparaties en indien nodig actie te ondernemen.", "PR.MA-1.4", 0, new Guid("bfa190b6-8988-4781-9864-0a7a6c003fcc"), null },
                    { new Guid("80cd851a-73d1-4e2c-a142-58e0cd741121"), null, null, null, "De organisatie moet een gedocumenteerd proces opstellen en bijhouden dat een voortdurende evaluatie van kwetsbaarheden en strategieën om deze te verminderen mogelijk maakt.", "PR.IP-12.1", 0, new Guid("a5beeb6d-a44f-4ca6-b6eb-f15f3ea74ea7"), null },
                    { new Guid("874101ac-3e95-4687-9e63-a083ce59894e"), null, null, null, "Toegangsrechten voor gebruikers tot de systemen van de organisatie moeten worden gedefinieerd en beheerd.", "PR.AC-4.1", 0, new Guid("a72a7823-76ab-4bff-a3e2-55d851334606"), null },
                    { new Guid("8980a900-cab3-47fb-85c6-2afdf19fccd2"), null, null, null, "Het beheer van fysieke toegang omvat maatregelen met betrekking tot toegang in noodsituaties.", "PR.AC-2.2", 0, new Guid("b5c9140c-5b33-40e5-b5a6-b57b2aa70bc4"), null },
                    { new Guid("8b1d5fb4-e646-42e4-8f2c-6936f589d7cd"), null, null, null, "De rollen, verantwoordelijkheden en bevoegdheden op het gebied van informatiebeveiliging en cyberbeveiliging binnen de organisatie moeten worden gedocumenteerd,", "ID.AM-6.1", 0, new Guid("8dab09d8-1098-4aae-8a1a-dd57e6c86d85"), null },
                    { new Guid("8b62f35e-b115-48b8-9c97-d6afef6496fe"), null, null, null, "Waar mogelijk worden geautomatiseerde mechanismen geïmplementeerd ter ondersteuning van het beheer van gebruikersaccounts op de kritieke systemen van de organisatie, waaronder het uitschakelen, bewaken, rapporteren en verwijderen van gebruikersaccounts.", "PR.AC-4.5", 0, new Guid("a72a7823-76ab-4bff-a3e2-55d851334606"), null },
                    { new Guid("8bcc2382-ac49-437e-80e6-a987a49e26d5"), null, null, null, "De draadloze toegangspunten van de organisatie moeten beveiligd zijn.", "PR.AC-3.1", 0, new Guid("e3371e7c-8c1c-4267-9bae-25bc27d031be"), null },
                    { new Guid("8e1abb26-884d-4797-9b1e-87b94dcb6666"), null, null, null, "De organisatie moet ervoor zorgen dat de nodige maatregelen worden genomen om verlies, misbruik, schade of diefstal van bedrijfsmiddelen tegen te gaan.", "PR.DS-3.3", 0, new Guid("3d6f6f8e-3e17-4cbd-be24-b9b915af40de"), null },
                    { new Guid("8ee2d1f1-66e2-4c08-9db9-4cf7dc5165e4"), null, null, null, "De organisatie moet gedocumenteerde procedures implementeren voor het verifiëren van de identiteit van personen voordat referenties worden uitgegeven die toegang geven tot de systemen van de organisatie.", "PR.AC-7.1", 0, new Guid("bb798c04-ef09-49a9-9bc1-f4f6262419d8"), null },
                    { new Guid("8f9b65e9-7614-4cac-9c23-d33d789300f1"), null, null, null, "De organisatie moet duidelijk haar risicobereidheid bepalen.", "ID.RM-2.1", 0, new Guid("593cb23d-9e2e-404d-955f-478ed845f50a"), null },
                    { new Guid("91fc1b7e-f04f-418d-ac56-37e70fd563e9"), null, null, null, "De rol van de organisatie in kritieke infrastructuur en de sector bepalen de risicobereidheid van de organisatie.", "ID.RM-3.1", 0, new Guid("c9f99618-f5e8-4419-ab4c-042b11b468f2"), null },
                    { new Guid("92706991-06c1-49ae-9efd-0c8bc2021539"), null, null, null, "De organisatie moet herstelactiviteiten communiceren aan vooraf gedefinieerde belanghebbenden, uitvoerende en managementteams.", "RC.CO-3.1", 0, new Guid("9c0bc48b-b1e9-46a3-b6af-20a5e231e09c"), null },
                    { new Guid("936f2e57-8b8a-499c-9606-fb429acbc690"), null, null, null, "De functionaliteit voor activiteitenregistratie van beveiligings-/detectiehardware of -software (bijv. firewalls, antivirus) worden ingeschakeld, back-ups worden gemaakt en herzien.", "DE.AE-3.1", 0, new Guid("9363a8ce-d0ca-4674-8cc4-34aac6fcaade"), null },
                    { new Guid("93fc15e7-a65e-4478-b02f-f37d47c94fb3"), null, null, null, "De organisatie moet de belangrijkste medewerkers van leveranciers en externe partners identificeren en documenteren om hen als belanghebbenden te betrekken bij de reactie- en herstelplanningsactiviteiten.", "ID.SC-5.1", 0, new Guid("5280a1e2-8941-4994-a483-fe9235dee0fd"), null },
                    { new Guid("956f0e07-92de-413d-b682-36be27f11790"), null, null, null, "Beleid en procedures voor informatiebeveiliging en cyberveiligheid worden opgesteld, gedocumenteerd, beoordeeld, goedgekeurd en bijgewerkt wanneer zich wijzigingen voordoen.", "ID.GV-1.1", 0, new Guid("778a003a-ae85-40f6-a8e3-2f0d7273f87c"), null },
                    { new Guid("98753997-ac08-4236-8f95-07fa9a14b66c"), null, null, null, "Er moet worden vastgesteld wie toegang moet hebben tot de bedrijfskritische informatie en technologie van de organisatie en de middelen om toegang te krijgen.", "PR.AC-4.2", 0, new Guid("a72a7823-76ab-4bff-a3e2-55d851334606"), null },
                    { new Guid("9a10e296-a668-4b93-93df-8172ab011950"), null, null, null, "De organisatie moet waarschuwingsdrempels voor incidenten definiëren.", "DE.AE-5.2", 0, new Guid("9b373dc1-5be5-4358-ab6a-ad15b03d977b"), null },
                    { new Guid("9a8a9eb5-0094-4844-9014-55cbdf1c78a4"), null, null, null, "Er wordt een herstelproces voor rampen en informatie-/cyberbeveiligingsincidenten ontwikkeld en zo nodig uitgevoerd.", "RC.RP-1.1", 0, new Guid("8550a4ef-80a6-4046-add4-8015c93071f9"), null },
                    { new Guid("9d6379a4-2889-4494-b6bc-b482faf9a767"), null, null, null, "De organisatie moet ervoor zorgen dat personeel dat verantwoordelijk is voor de fysieke bescherming en beveiliging van de kritieke systemen en faciliteiten van de organisatie gekwalificeerd is door middel van training voordat privileges worden verleend, en dat zij hun verantwoordelijkheden begrijpen.", "PR.AT-5.1", 0, new Guid("ad038674-ef85-43cd-a9ff-905aa6f2ab9c"), null },
                    { new Guid("9ecf49c0-ccb5-40c3-8f03-00a65060c64e"), null, null, null, "De organisatie moet processen en procedures voor het beheer van kwetsbaarheden implementeren die het verwerken, analyseren en verhelpen van kwetsbaarheden uit interne en externe bronnen omvatten.", "RS.AN-5.1", 0, new Guid("9d3ade37-8d5b-492a-9e18-4624c9a9221b"), null },
                    { new Guid("9fa1495e-e1e2-4607-89b8-8b6287733901"), null, null, null, "Er moet een bewustwordingsprogramma voor bedreigingen en kwetsbaarheden worden geïmplementeerd dat de mogelijkheid omvat om informatie uit te wisselen tussen organisaties.", "ID.RA-2.1", 0, new Guid("887bcf23-304d-4fde-9cf9-c90d6c9ab037"), null },
                    { new Guid("a027ac64-b58a-427c-a1fb-c4f6baa49702"), null, null, null, "De organisatie onderzoekt informatie-/cyberbeveiligingsmeldingen van detectiesystemen.", "RS.AN-1.1", 0, new Guid("5aca2b06-736a-428d-bb85-e1c4b69a7774"), null },
                    { new Guid("a15876ba-9822-4524-8023-9e6a55cc0c36"), null, null, null, "De organisatie moet risicobeoordelingen uitvoeren waarbij het risico wordt bepaald door bedreigingen, kwetsbaarheden en de impact op bedrijfsprocessen en bedrijfsmiddelen.", "ID.RA-5.1", 0, new Guid("6499315c-b528-4d99-b2c2-be37df256922"), null },
                    { new Guid("a1c6f144-9734-4ad4-884a-93badd46d28b"), null, null, null, "Alle externe verbindingen door leveranciers die IT/OT-toepassingen of -infrastructuur ondersteunen, moeten worden beveiligd en actief worden bewaakt om ervoor te zorgen dat tijdens de verbinding alleen toegestane acties plaatsvinden.", "DE.CM-6.1", 0, new Guid("34d2abc7-adfe-45d5-a8fe-791bc4d728d7"), null },
                    { new Guid("a3ba0b88-ee2d-4188-86d5-3d3aad5c4c3e"), null, null, null, "De organisatie moet ervoor zorgen dat het personeel hun rollen, doelstellingen, herstelprioriteiten, taakvolgorde en toewijzingsverantwoordelijkheden voor de respons op evenementen begrijpt.", "RS.CO-1.1", 0, new Guid("8b8552af-cb2e-4b4d-90af-bd2f6bd71f1a"), null },
                    { new Guid("a49e3263-d519-4352-9933-dde42c96a339"), null, null, null, "De organisatie coördineert de respons op informatie-/cyberbeveiligingsincidenten met alle vooraf gedefinieerde belanghebbenden.", "RS.CO-4.1", 0, new Guid("fc71ec5f-3851-43b5-a74a-f0059829de1f"), null },
                    { new Guid("a653f39b-df92-4c98-99bf-9416043188ee"), null, null, null, "De organisatie dient het herkennen van en rapporteren over bedreigingen van binnenuit op te nemen in de training voor beveiligingsbewustzijn.", "PR.AT-1.2", 0, new Guid("82032357-16f8-41b7-a5cc-91fc6fdf637a"), null },
                    { new Guid("a6de1749-7b52-4c88-9ffd-52cd2245ad32"), null, null, null, "De organisatie moet de bedrijfskritische systemen zo configureren dat ze alleen essentiële mogelijkheden bieden.", "PR.PT-3.1", 0, new Guid("9ed1543c-cd61-4681-98b2-69a6e635577d"), null },
                    { new Guid("a6e5a7c2-8ff3-4308-a498-23307360ccfb"), null, null, null, "De organisatie moet centraliseren en coördineren hoe informatie wordt verspreid en beheren hoe de organisatie aan het publiek wordt gepresenteerd.", "RC.CO-1.1", 0, new Guid("a09848d8-1343-4054-a183-1827d224b033"), null },
                    { new Guid("a934a73c-a9cc-4a2f-b403-384d9a8b5077"), null, null, null, "De organisatie moet gedetecteerde gebeurtenissen beoordelen en analyseren om inzicht te krijgen in aanvalsdoelen en -methoden.", "DE.AE-2.1", 0, new Guid("8f4dc8d7-f883-4dbc-9caa-6b90e8bf2d0c"), null },
                    { new Guid("ab3e6b47-9f55-429d-88c8-2bf76bf80361"), null, null, null, "Mededelingen over de doeltreffendheid van beschermingstechnologieën worden gedeeld met de juiste partijen.", "PR.IP-8.2", 0, new Guid("2079bbeb-5713-47de-950f-5f10788f67e7"), null },
                    { new Guid("abd06212-f553-44bb-8024-b40d3ac5764d"), null, null, null, "Eindpunt- en netwerkbeschermingstools die het gedrag van eindgebruikers controleren op gevaarlijke activiteiten moeten worden beheerd.", "DE.CM-3.2", 0, new Guid("4268937d-a7c9-40f1-b0bc-5acd80487562"), null },
                    { new Guid("ac7a4efa-62a6-4ce5-8f4d-c320e5ea2a87"), null, null, null, "Back-ups voor bedrijfskritische gegevens van de organisatie moeten worden uitgevoerd en opgeslagen op een ander systeem dan het apparaat waarop de oorspronkelijke gegevens staan.", "PR.IP-4.1", 0, new Guid("30a7fc06-3dc9-4581-b5c1-e732338fdf06"), null },
                    { new Guid("ad70c029-3b99-43cd-999d-bf7ad407321e"), null, null, null, "De fysieke omgeving van de faciliteit wordt bewaakt op mogelijke gebeurtenissen op het gebied van informatie-/cyberbeveiliging.", "DE.CM-2.1", 0, new Guid("8b6034c1-cae5-4f89-b673-3c76fe9cf7af"), null },
                    { new Guid("af16548a-1283-441c-84bf-d830b6faa008"), null, null, null, "De organisatie moet, waar mogelijk, geautomatiseerde mechanismen implementeren om te helpen bij de samenwerking op het gebied van informatie.", "PR.IP-8.3", 0, new Guid("2079bbeb-5713-47de-950f-5f10788f67e7"), null },
                    { new Guid("afe3c6ab-3e69-46bf-aaea-1d51eab39c53"), null, null, null, "Gebruiksbeperkingen, verbindingsvereisten, implementatierichtlijnen en autorisaties voor externe toegang tot de kritieke systeemomgeving van de organisatie moeten worden geïdentificeerd, gedocumenteerd en geïmplementeerd.", "PR.AC-3.3", 0, new Guid("e3371e7c-8c1c-4267-9bae-25bc27d031be"), null },
                    { new Guid("b2dc32d4-b668-4176-a88d-955222a97d6c"), null, null, null, "De inventarisatie van softwareplatforms en applicaties die verband houden met informatie en informatieverwerking moet veranderingen in de  context van de organisatie weerspiegelen  en alle informatie bevatten die nodig is voor effectieve verantwoording.", "ID.AM-2.2", 0, new Guid("713518df-8599-4ae3-ba32-c16ab59f70f5"), null },
                    { new Guid("b6659756-f691-4a29-b6b2-4b1a70116fc5"), null, null, null, "De organisatie werkt samen en deelt informatie over haar kritieke systeemgerelateerde beveiligingsincidenten en risicobeperkende maatregelen met aangewezen partners.", "PR.IP-8.1", 0, new Guid("2079bbeb-5713-47de-950f-5f10788f67e7"), null },
                    { new Guid("b7cadb01-8b26-4749-a7bc-c67784b23060"), null, null, null, "Op basis van de resultaten van de risicobeoordeling van de cybertoeleveringsketen wordt een contractueel kader voor leveranciers en externe partners opgesteld om het delen van gevoelige informatie en gedistribueerde en onderling verbonden ICT/OT-producten en -diensten aan te pakken.", "ID.SC-3.1", 0, new Guid("1f4e442d-693a-488d-bef7-3a497170d8a9"), null },
                    { new Guid("b90a096f-67f0-44c6-bc5c-0ce4fde72a0c"), null, null, null, "De organisatie moet het aansluiten van verwisselbare media technisch verbieden, tenzij dit strikt noodzakelijk is; in andere gevallen moet het uitvoeren van autoruns vanaf dergelijke media worden uitgeschakeld.", "PR.PT-2.2", 0, new Guid("c7ed2d73-037e-441c-a99e-3bac0d81572e"), null },
                    { new Guid("bf0786b3-088d-4a0b-bc86-82137aaa339f"), null, null, null, "Lessen die zijn geleerd uit incidentafhandeling moeten worden vertaald in bijgewerkte of nieuwe incidentafhandelingsprocedures die moeten worden getest, goedgekeurd en getraind.", "RS.IM-1.2", 0, new Guid("24203a47-35b9-49fd-91fa-5f2859b7d921"), null },
                    { new Guid("c2f2905a-ff65-43f6-ba7e-84d7bf545a2b"), null, null, null, "Eindpunt- en netwerkbeschermingstools om het gedrag van eindgebruikers te controleren op gevaarlijke activiteiten moeten worden geïmplementeerd.", "DE.CM-3.1", 0, new Guid("4268937d-a7c9-40f1-b0bc-5acd80487562"), null },
                    { new Guid("c65ec76f-28a3-4605-b9bb-87798b030a42"), null, null, null, "De organisatie moet ongeautoriseerd gebruik van haar bedrijfskritische systemen bewaken en identificeren door het detecteren van ongeautoriseerde lokale verbindingen, netwerkverbindingen en verbindingen op afstand.", "DE.CM-1.2", 0, new Guid("f558c9e0-2ed6-4eb2-b651-cffd6b378279"), null },
                    { new Guid("c695afe4-28b0-467d-be4b-023a16c10fc8"), null, null, null, "Als onderdeel van het algehele risicobeheer van het bedrijf moet een alomvattende strategie voor het beheer van informatiebeveiliging en cyberbeveiligingsrisico's worden ontwikkeld en bijgewerkt wanneer zich veranderingen voordoen.", "ID.GV-4.1", 0, new Guid("ddde1cc2-0859-4584-b51a-be69282718f4"), null },
                    { new Guid("c7686fed-01a2-4e3b-aa2c-c2c960f4fb1e"), null, null, null, "De organisatie moet passende acties ondernemen die resulteren in de bewaking van haar kritieke systemen aan de buitengrenzen en kritieke interne punten wanneer ongeautoriseerde toegang en activiteiten, inclusief gegevenslekken, worden gedetecteerd.", "PR.DS-5.1", 0, new Guid("db73a316-49cb-4db4-9ed9-a59a93bfd92b"), null },
                    { new Guid("c8f3d5a6-5cfa-4bff-bc71-473ad474e532"), null, null, null, "De bedrijfskritische systemen van de organisatie moeten worden gecontroleerd op toegang door onbevoegd personeel, verbindingen, apparaten, toegangspunten en software.", "DE.CM-7.1", 0, new Guid("1ba12212-b8e4-43b4-8122-85c8e46131bf"), null },
                    { new Guid("c9c4cd29-d988-49c1-af61-fdefb149fe14"), null, null, null, "Grondig onderzoek en analyse van de resultaten vormen de basis voor een volledig begrip van de gevolgen van het informatie-/cyberbeveiligingsincident.", "RS.AN-2.1", 0, new Guid("9f7aeb36-fcd2-45d6-a545-38ed6e54cc79"), null },
                    { new Guid("c9db6f15-8900-4356-b16f-ceb3dc888ec7"), null, null, null, "De organisatie moet herstelactiviteiten communiceren aan vooraf gedefinieerde belanghebbenden, uitvoerende en managementteams.", "RC.CO-3.1", 0, new Guid("3a9824e4-dcea-416d-b980-3c7b0ef102fd"), null },
                    { new Guid("cb58dc12-681d-44b2-ba0f-de33672896be"), null, null, null, "De organisatie moet een incidentafhandelingscapaciteit implementeren voor informatie-/cyberbeveiligingsincidenten op haar bedrijfskritische systemen die voorbereiding, detectie en analyse, insluiting, uitroeiing, herstel en gedocumenteerde risicoacceptatie omvat.", "RS.MI-1.1", 0, new Guid("4c30f4dc-e2ab-4b28-962c-32fa201918fa"), null },
                    { new Guid("cd856785-7017-4dce-84d0-248ce08c9aa5"), null, null, null, "Gebruikers met bevoegdheden moeten worden beheerd en bewaakt.", "PR.AC-4.7", 0, new Guid("a72a7823-76ab-4bff-a3e2-55d851334606"), null },
                    { new Guid("ce12e994-a363-4706-ba0a-cdc32d09c6ac"), null, null, null, "Incidentbestrijdingsplannen (Incident Response en Business Continuity) en herstelplannen (Incident Recovery en Disaster Recovery) moeten worden opgesteld, onderhouden, goedgekeurd en getest om de effectiviteit van de plannen en de gereedheid om de plannen uit te voeren te bepalen.", "PR.IP-9.1", 0, new Guid("e8eb7120-994f-4070-8b3e-fc67a8e04a5f"), null },
                    { new Guid("cfdfc3b0-1831-4e17-8b16-a5f3bf2a47dd"), null, null, null, "De organisatie moet de lessen die zijn geleerd uit herstelactiviteiten bij incidenten verwerken in bijgewerkte of nieuwe herstelprocedures voor systemen en dit, na het testen, omlijsten met de juiste training.", "RC.IM-1.1", 0, new Guid("e0e23fa5-5ad1-4fa2-8941-c3518ed7f28e"), null },
                    { new Guid("cffd4d68-4747-487a-8ba0-a816c85651d0"), null, null, null, "Verbeteringen die voortkomen uit het monitoren, meten, beoordelen, testen, beoordelen en geleerde lessen worden opgenomen in herzieningen van detectieprocessen.", "DE.DP-5.1", 0, new Guid("5a3301e7-4545-442a-b78a-2c0312386b19"), null },
                    { new Guid("d4b99b6b-fb1a-4f70-9dae-fbbcb7a2e7de"), null, null, null, "De organisatie moet de respons- en herstelplannen bijwerken om veranderingen in de context aan te pakken.", "RS.IM-2.1", 0, new Guid("5287f11d-1c1c-4938-98f5-20576e7081d9"), null },
                    { new Guid("d68fd0f7-caaa-477c-a444-8f02be75e191"), null, null, null, "Capaciteitsplanning moet ervoor zorgen dat er voldoende middelen zijn voor de kritische systeeminformatieverwerking, netwerken, telecommunicatie en gegevensopslag van de organisatie.", "PR.DS-4.1", 0, new Guid("f4090957-3135-4f6c-a4d3-14d127ac7e50"), null },
                    { new Guid("d7a01000-3ecd-42d0-9908-ffd4b60d4539"), null, null, null, "GEEN VEREISTEN / Te overwegen richtlijnen", "", 0, new Guid("d1002e67-98fe-423c-a19c-d4dbc7a28c8c"), null },
                    { new Guid("da53ec38-e20b-449f-a6f4-4ba4f889e04b"), null, null, null, "Activa en media moeten veilig worden verwijderd.", "PR.DS-3.1", 0, new Guid("3d6f6f8e-3e17-4cbd-be24-b9b915af40de"), null },
                    { new Guid("db1b35c9-a58c-4d59-ab57-c1b75d01f57a"), null, null, null, "De organisatie moet centraliseren en coördineren hoe informatie wordt verspreid en beheren hoe de organisatie aan het publiek wordt gepresenteerd.", "RC.CO-1.1", 0, new Guid("88f4119c-cfcd-4279-a2e5-0ac5b699d521"), null },
                    { new Guid("dcb0990c-2161-49ec-8aee-010b152739ea"), null, null, null, "Onderhoud op afstand mag alleen plaatsvinden na voorafgaande goedkeuring, toezicht om onbevoegde toegang te voorkomen en goedkeuring van het resultaat van de onderhoudsactiviteiten zoals beschreven in goedgekeurde processen of procedures.", "PR.MA-2.1", 0, new Guid("a135607e-ef53-4b12-a0bc-c5765e64c972"), null },
                    { new Guid("deab69b7-c2de-444f-8e53-6cde2022dac6"), null, null, null, "Wijzigingen moeten worden getest en gevalideerd voordat ze worden geïmplementeerd in operationele systemen.", "PR.IP-3.1", 0, new Guid("5c021230-07ef-4269-99a6-648bacd7b46d"), null },
                    { new Guid("deb08d11-98fe-44a6-8cce-ef3aecd6b08b"), null, null, null, "De organisatie moet goedkeuringsvereisten, controle en toezicht afdwingen voor onderhoudsgereedschappen voor gebruik op de kritieke systemen.", "PR.MA-1.3", 0, new Guid("bfa190b6-8988-4781-9864-0a7a6c003fcc"), null },
                    { new Guid("dfda66a2-57f1-4e3f-bf81-6ace0ba8d579"), null, null, null, "Wettelijke en regelgevende vereisten met betrekking tot informatie-/cyberbeveiliging, waaronder privacyverplichtingen, worden begrepen en geïmplementeerd.", "ID.GV-3.1", 0, new Guid("b66c92d9-823a-4df8-9a23-2a83067194f7"), null },
                    { new Guid("e1f6a192-c2af-4b66-95e5-6db506fc7ff5"), null, null, null, "De middelen van de organisatie (hardware, apparaten, gegevens, tijd, personeel, informatie en software) moeten worden geprioriteerd op basis van hun classificatie, kriticiteit en bedrijfswaarde.", "ID.AM-5.1", 0, new Guid("595b625b-7641-4c9a-986d-504090c03c44"), null },
                    { new Guid("e3aeabf9-ae9e-4e7e-86a4-0f526142acf5"), null, null, null, "De organisatie moet informatie over eventdetectie communiceren naar vooraf gedefinieerde partijen.", "DE.DP-4.1", 0, new Guid("ded75e10-c86a-482b-94c0-21c279b9d06d"), null },
                    { new Guid("e42df0a1-7a12-4e1a-ace9-17c4f3e1a41d"), null, null, null, "De organisatie moet herstelactiviteiten communiceren aan vooraf gedefinieerde belanghebbenden, uitvoerende en managementteams.", "RC.CO-3.1", 0, new Guid("b6acfec6-f955-41a9-aa88-fbacb57183b4"), null },
                    { new Guid("e72f9fcf-5fee-4ed3-98d6-b54bb9cddb60"), null, null, null, "De fysieke toegang tot de faciliteit, servers en netwerkcomponenten moet worden beheerd.", "PR.AC-2.1", 0, new Guid("b5c9140c-5b33-40e5-b5a6-b57b2aa70bc4"), null },
                    { new Guid("eaa271d2-2685-456c-9408-06bf06ff8992"), null, null, null, "Afhankelijkheden en missiekritische functies voor de levering van kritieke diensten worden geïdentificeerd, gedocumenteerd en geprioriteerd op basis van hun kriticiteit als onderdeel van het risicobeoordelingsproces.", "ID.BE-4.1", 0, new Guid("de3a3e6e-a45c-47be-a4f9-b447feb31d46"), null },
                    { new Guid("ebd9e308-a8e3-46f7-9f5c-7eee37b7da97"), null, null, null, "Er zijn geen vereisten geïdentificeerd voor de veiligheidsniveau ‘Basis’, maar richtlijnen worden verstrekt om de informatiebeveiliging te verhogen.", "", 0, new Guid("b7f2b613-a98a-465f-a32c-8033c7be56ab"), null },
                    { new Guid("f0e81633-23b8-4a8b-8257-fc33ca8fd35b"), null, null, null, "De organisatie moet alle externe services en de verbindingen die ermee zijn gemaakt in kaart brengen, documenteren, autoriseren en bij wijzigingen bijwerken.", "ID.AM-4.1", 0, new Guid("2e72755f-3ff3-4f56-be93-16aebc0f0d0d"), null },
                    { new Guid("f2a6b805-b0f6-4cb1-9479-cb97ca8269e2"), null, null, null, "Werknemers moeten de juiste training krijgen.", "PR.AT-1.1", 0, new Guid("82032357-16f8-41b7-a5cc-91fc6fdf637a"), null },
                    { new Guid("f4789699-3b6a-415b-8a50-06e6c02cc3ac"), null, null, null, "De rol van de organisatie in de toeleveringsketen moet worden vastgesteld, gedocumenteerd en gecommuniceerd.", "ID.BE-1.1", 0, new Guid("2c077640-b3ba-4351-a0ca-6e02b2ed3449"), null },
                    { new Guid("f4b9f4a8-184d-4f9b-a108-9bf2aafbe63b"), null, null, null, "Bevoegde gebruikers moeten gekwalificeerd zijn voordat ze privileges krijgen en deze gebruikers moeten kunnen aantonen dat ze hun rollen, verantwoordelijkheden en bevoegdheden begrijpen.", "PR.AT-2.1", 0, new Guid("ef1d0332-6030-4832-86c2-b4b45c186364"), null },
                    { new Guid("f5ba1459-8f6b-4c42-9866-20ec45fa3bf3"), null, null, null, "Wanneer niet-geautoriseerde software wordt gedetecteerd, wordt deze in quarantaine geplaatst voor mogelijke uitzonderingsbehandeling, verwijderd of vervangen en wordt de inventaris dienovereenkomstig bijgewerkt.", "ID.AM-2.4", 0, new Guid("713518df-8599-4ae3-ba32-c16ab59f70f5"), null },
                    { new Guid("f8062343-38b2-4cf2-bec3-ad22405bddef"), null, null, null, "Het proces voor het scannen van kwetsbaarheden omvat analyse, herstel en het delen van informatie.", "DE.CM-8.2", 0, new Guid("d0c3e227-05f1-4be8-a6ee-ac0418fdb94c"), null },
                    { new Guid("f81e8187-c412-47c5-a7ad-b89920c4e351"), null, null, null, "De organisatie moet risicobeoordelingen uitvoeren en documenteren waarin het risico wordt bepaald door bedreigingen, kwetsbaarheden, de impact op bedrijfsprocessen en bedrijfsmiddelen en de waarschijnlijkheid dat deze zich voordoen.", "ID.RA-5.2", 0, new Guid("6499315c-b528-4d99-b2c2-be37df256922"), null },
                    { new Guid("f9aa4c76-3af8-4586-b488-98ec590f7bb1"), null, null, null, "De toegang van werknemers tot gegevens en informatie wordt beperkt tot de systemen en specifieke informatie die ze nodig hebben om hun werk te doen (het principe van Least Privilege).", "PR.AC-4.3", 0, new Guid("a72a7823-76ab-4bff-a3e2-55d851334606"), null },
                    { new Guid("fd28aa7e-ed04-4c26-8e24-472c55b3e004"), null, null, null, "De organisatie controleert beoordelingen van de naleving van contractuele verplichtingen door leveranciers en externe partners door routinematig audits, testresultaten en andere evaluaties te controleren.", "ID.SC-4.1", 0, new Guid("4c8755a3-187f-41a5-af01-5f50c62ef87e"), null },
                    { new Guid("ff1925c8-a837-4eb5-bc31-19d3135e947b"), null, null, null, "De organisatie moet beveiligingseisen opstellen en afdwingen voor bedrijfskritieke externe leveranciers en gebruikers.", "PR.AT-3.1", 0, new Guid("051cc8fb-a72f-47d8-aee4-81d1ddcb9256"), null }
                });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "AssessmentId", "RequirementId", "AdditionalInfo", "AssessorComment", "DocumentationMaturityScore", "ImplementationMaturityScore" },
                values: new object[,]
                {
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("00e63028-3683-485b-97a7-434edd73c9bd"), "Well done", "Elephants are cool 00e63028-3683-485b-97a7-434edd73c9bd", 5, 3 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("066346b0-2f4c-4d9d-a534-8444d2d92c3e"), "Well done", "Elephants are cool 066346b0-2f4c-4d9d-a534-8444d2d92c3e", 1, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("07e18b14-a36a-4f9e-bf4b-e8eb90c0b0c0"), "Well done", "Elephants are cool 07e18b14-a36a-4f9e-bf4b-e8eb90c0b0c0", 4, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("07e68bab-a6fe-46fc-86ee-a2920102ee86"), "Well done", "Elephants are cool 07e68bab-a6fe-46fc-86ee-a2920102ee86", 2, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("0bf27cce-7945-4e28-82c3-75c83453cfab"), "Well done", "Elephants are cool 0bf27cce-7945-4e28-82c3-75c83453cfab", 4, 5 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("0c64bddf-f85b-4398-9c41-cd151a437026"), "Well done", "Elephants are cool 0c64bddf-f85b-4398-9c41-cd151a437026", 2, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("0ed6bd0b-7e3e-4ca7-a10d-316d3d0fb2ba"), "Well done", "Elephants are cool 0ed6bd0b-7e3e-4ca7-a10d-316d3d0fb2ba", 4, 3 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("103820c1-3688-4475-a8cd-454b0dad4dd4"), "Well done", "Elephants are cool 103820c1-3688-4475-a8cd-454b0dad4dd4", 1, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("1f5ce754-920c-4759-b382-ba56b4a3e925"), "Well done", "Elephants are cool 1f5ce754-920c-4759-b382-ba56b4a3e925", 3, 3 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("21fbd597-4679-4c5f-b7d0-965c3e50f772"), "Well done", "Elephants are cool 21fbd597-4679-4c5f-b7d0-965c3e50f772", 1, 3 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("221e49bd-8f7b-43d2-ae5b-4c4c46a5e4cb"), "Well done", "Elephants are cool 221e49bd-8f7b-43d2-ae5b-4c4c46a5e4cb", 4, 3 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("23a84fe4-f6f1-43bf-b14b-41fb87ae3d70"), "Well done", "Elephants are cool 23a84fe4-f6f1-43bf-b14b-41fb87ae3d70", 3, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("24d1bc45-4ef4-4cc4-8aac-f6ad902a7140"), "Well done", "Elephants are cool 24d1bc45-4ef4-4cc4-8aac-f6ad902a7140", 1, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("26a9b019-1efb-4325-ac8f-997875eb758a"), "Well done", "Elephants are cool 26a9b019-1efb-4325-ac8f-997875eb758a", 1, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("26b66075-0434-423f-af25-884c6015b689"), "Well done", "Elephants are cool 26b66075-0434-423f-af25-884c6015b689", 3, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("26e39390-bbc2-4da3-a122-bd5dfa9cc98c"), "Well done", "Elephants are cool 26e39390-bbc2-4da3-a122-bd5dfa9cc98c", 4, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("279a2544-424d-463e-9e75-96d14fb136a8"), "Well done", "Elephants are cool 279a2544-424d-463e-9e75-96d14fb136a8", 4, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("2b1cec00-1a92-4bc9-9aca-e7a8c5dcf122"), "Well done", "Elephants are cool 2b1cec00-1a92-4bc9-9aca-e7a8c5dcf122", 4, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("2c789e9f-0784-4e92-a0d4-c410fd50bd88"), "Well done", "Elephants are cool 2c789e9f-0784-4e92-a0d4-c410fd50bd88", 2, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("2d42aa5f-7a45-4ccf-90a6-9f733489dde4"), "Well done", "Elephants are cool 2d42aa5f-7a45-4ccf-90a6-9f733489dde4", 5, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("30882678-259f-4b8e-a0fa-81f3dbb3f4f9"), "Well done", "Elephants are cool 30882678-259f-4b8e-a0fa-81f3dbb3f4f9", 1, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("3170596e-561c-472b-9b80-ebddf15feeb5"), "Well done", "Elephants are cool 3170596e-561c-472b-9b80-ebddf15feeb5", 4, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("31eb31ff-4358-4682-b3a5-224e38d1e704"), "Well done", "Elephants are cool 31eb31ff-4358-4682-b3a5-224e38d1e704", 5, 3 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("346c09ae-b214-4dc8-84a3-6a50654e31af"), "Well done", "Elephants are cool 346c09ae-b214-4dc8-84a3-6a50654e31af", 1, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("34f344e3-d8b8-4c29-b113-c1d6c6734739"), "Well done", "Elephants are cool 34f344e3-d8b8-4c29-b113-c1d6c6734739", 5, 3 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("36bfec99-9376-48db-a364-a1cc3b8ee624"), "Well done", "Elephants are cool 36bfec99-9376-48db-a364-a1cc3b8ee624", 5, 5 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("3a5a6217-c361-4030-a13c-50d0e90604e0"), "Well done", "Elephants are cool 3a5a6217-c361-4030-a13c-50d0e90604e0", 5, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("3a6e13c5-f62f-4324-9c98-63beece787ac"), "Well done", "Elephants are cool 3a6e13c5-f62f-4324-9c98-63beece787ac", 4, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("3b58b2f0-8d7b-4b1f-adf2-2eb6d4282e2e"), "Well done", "Elephants are cool 3b58b2f0-8d7b-4b1f-adf2-2eb6d4282e2e", 1, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("3c4def8e-25a1-44fd-86a9-6dfd1a29a661"), "Well done", "Elephants are cool 3c4def8e-25a1-44fd-86a9-6dfd1a29a661", 3, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("3c89aa9f-ad20-4dfb-a085-ccd1a8c5dc9a"), "Well done", "Elephants are cool 3c89aa9f-ad20-4dfb-a085-ccd1a8c5dc9a", 4, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("3cb91a49-8903-4548-82ce-39734648ecaa"), "Well done", "Elephants are cool 3cb91a49-8903-4548-82ce-39734648ecaa", 5, 3 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("3f788de5-7db3-4587-8797-6d81952e1ef1"), "Well done", "Elephants are cool 3f788de5-7db3-4587-8797-6d81952e1ef1", 3, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("4101f946-c223-4367-8836-e48ec75061a1"), "Well done", "Elephants are cool 4101f946-c223-4367-8836-e48ec75061a1", 3, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("4291fe1f-8192-4843-a193-804f11a8afa4"), "Well done", "Elephants are cool 4291fe1f-8192-4843-a193-804f11a8afa4", 2, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("446bca0e-1fe8-4f3e-ade2-b3a116e300c3"), "Well done", "Elephants are cool 446bca0e-1fe8-4f3e-ade2-b3a116e300c3", 4, 5 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("45572035-97b5-43d7-b539-a42f42cf5985"), "Well done", "Elephants are cool 45572035-97b5-43d7-b539-a42f42cf5985", 1, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("4605ac3d-dfe0-4a1c-9687-9dc45582653e"), "Well done", "Elephants are cool 4605ac3d-dfe0-4a1c-9687-9dc45582653e", 2, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("47585fef-7d59-4cc9-a735-1948faa5dd6b"), "Well done", "Elephants are cool 47585fef-7d59-4cc9-a735-1948faa5dd6b", 4, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("486f47f9-440c-4f01-abf4-00f96395b373"), "Well done", "Elephants are cool 486f47f9-440c-4f01-abf4-00f96395b373", 5, 5 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("48d9b9b8-0104-4110-a8e5-f0930e109e6e"), "Well done", "Elephants are cool 48d9b9b8-0104-4110-a8e5-f0930e109e6e", 4, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("4aa609e0-63bf-45d1-a80a-6c08d7ba7fd5"), "Well done", "Elephants are cool 4aa609e0-63bf-45d1-a80a-6c08d7ba7fd5", 4, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("4c9e4623-0afc-4dc5-a394-8107d5d9aa8a"), "Well done", "Elephants are cool 4c9e4623-0afc-4dc5-a394-8107d5d9aa8a", 1, 3 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("4d6b062d-9e35-4af2-be79-6804fece50b8"), "Well done", "Elephants are cool 4d6b062d-9e35-4af2-be79-6804fece50b8", 1, 5 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("4d8b5409-3b97-40e6-837f-244b0fad2649"), "Well done", "Elephants are cool 4d8b5409-3b97-40e6-837f-244b0fad2649", 4, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("52c22d9e-5b72-4966-a766-8cacc65cca1c"), "Well done", "Elephants are cool 52c22d9e-5b72-4966-a766-8cacc65cca1c", 4, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("57cf6725-6639-48d3-a617-6c8189c84026"), "Well done", "Elephants are cool 57cf6725-6639-48d3-a617-6c8189c84026", 3, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("5903d1e9-bdf7-491f-a8d7-5a08906c740c"), "Well done", "Elephants are cool 5903d1e9-bdf7-491f-a8d7-5a08906c740c", 4, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("59a244c1-768c-46ab-bae1-878164cbb239"), "Well done", "Elephants are cool 59a244c1-768c-46ab-bae1-878164cbb239", 1, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("5a6de140-50ea-42ff-a4b1-a8cebf75fb44"), "Well done", "Elephants are cool 5a6de140-50ea-42ff-a4b1-a8cebf75fb44", 5, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("5cd9a71b-144b-48fe-93d6-3658937af379"), "Well done", "Elephants are cool 5cd9a71b-144b-48fe-93d6-3658937af379", 2, 3 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("5dfa3fb0-84cb-4d9b-8add-84bb7d943db7"), "Well done", "Elephants are cool 5dfa3fb0-84cb-4d9b-8add-84bb7d943db7", 3, 5 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("5f278726-aac4-410e-b961-7f71d8c42478"), "Well done", "Elephants are cool 5f278726-aac4-410e-b961-7f71d8c42478", 5, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("5f8bf821-902e-49a4-a46d-9698b8904a07"), "Well done", "Elephants are cool 5f8bf821-902e-49a4-a46d-9698b8904a07", 3, 5 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("6149036e-9ce5-4a2e-bdda-d0cee80bdbba"), "Well done", "Elephants are cool 6149036e-9ce5-4a2e-bdda-d0cee80bdbba", 2, 5 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("636e5224-4905-4792-b2a4-c2904bb78e34"), "Well done", "Elephants are cool 636e5224-4905-4792-b2a4-c2904bb78e34", 2, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("63ac466c-685f-48b0-a7f5-3bd5c7c05e4b"), "Well done", "Elephants are cool 63ac466c-685f-48b0-a7f5-3bd5c7c05e4b", 5, 5 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("6570a2f8-676a-4e8b-a469-4f88fd06cef5"), "Well done", "Elephants are cool 6570a2f8-676a-4e8b-a469-4f88fd06cef5", 1, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("670e8b33-e333-4d90-8f63-854723796ad6"), "Well done", "Elephants are cool 670e8b33-e333-4d90-8f63-854723796ad6", 2, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("68a71898-573c-472b-9650-9d8117607b84"), "Well done", "Elephants are cool 68a71898-573c-472b-9650-9d8117607b84", 5, 5 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("6dbb2471-e07e-4e97-8bd4-f22de661208a"), "Well done", "Elephants are cool 6dbb2471-e07e-4e97-8bd4-f22de661208a", 3, 3 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("6dc25c17-1894-4824-8dd1-c0a4223ecc04"), "Well done", "Elephants are cool 6dc25c17-1894-4824-8dd1-c0a4223ecc04", 5, 3 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("6dff6632-ecfe-4aa2-825d-de28f00935e0"), "Well done", "Elephants are cool 6dff6632-ecfe-4aa2-825d-de28f00935e0", 2, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("723701a4-0a1e-4652-8047-90046857e12b"), "Well done", "Elephants are cool 723701a4-0a1e-4652-8047-90046857e12b", 5, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("73f20105-3b43-4cf0-b6da-f4c1f6f90fd0"), "Well done", "Elephants are cool 73f20105-3b43-4cf0-b6da-f4c1f6f90fd0", 5, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("74930ef3-fd21-49c9-b69b-f6ece8e00104"), "Well done", "Elephants are cool 74930ef3-fd21-49c9-b69b-f6ece8e00104", 3, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("75820bf0-ecb6-45ce-aa7d-b9b86979f726"), "Well done", "Elephants are cool 75820bf0-ecb6-45ce-aa7d-b9b86979f726", 1, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("7671e6b3-ae00-4dde-ba5c-b2af273aea18"), "Well done", "Elephants are cool 7671e6b3-ae00-4dde-ba5c-b2af273aea18", 5, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("7e608c31-6d86-41c1-8e59-a745b3a93cf8"), "Well done", "Elephants are cool 7e608c31-6d86-41c1-8e59-a745b3a93cf8", 1, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("7f36dbcc-1493-4ff6-8e5d-4351ba1510ab"), "Well done", "Elephants are cool 7f36dbcc-1493-4ff6-8e5d-4351ba1510ab", 5, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("80599bbc-dfb6-4906-aace-1e546b1bbe94"), "Well done", "Elephants are cool 80599bbc-dfb6-4906-aace-1e546b1bbe94", 1, 3 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("80cd851a-73d1-4e2c-a142-58e0cd741121"), "Well done", "Elephants are cool 80cd851a-73d1-4e2c-a142-58e0cd741121", 3, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("874101ac-3e95-4687-9e63-a083ce59894e"), "Well done", "Elephants are cool 874101ac-3e95-4687-9e63-a083ce59894e", 4, 5 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("8980a900-cab3-47fb-85c6-2afdf19fccd2"), "Well done", "Elephants are cool 8980a900-cab3-47fb-85c6-2afdf19fccd2", 4, 3 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("8b1d5fb4-e646-42e4-8f2c-6936f589d7cd"), "Well done", "Elephants are cool 8b1d5fb4-e646-42e4-8f2c-6936f589d7cd", 3, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("8b62f35e-b115-48b8-9c97-d6afef6496fe"), "Well done", "Elephants are cool 8b62f35e-b115-48b8-9c97-d6afef6496fe", 3, 5 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("8bcc2382-ac49-437e-80e6-a987a49e26d5"), "Well done", "Elephants are cool 8bcc2382-ac49-437e-80e6-a987a49e26d5", 1, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("8e1abb26-884d-4797-9b1e-87b94dcb6666"), "Well done", "Elephants are cool 8e1abb26-884d-4797-9b1e-87b94dcb6666", 3, 5 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("8ee2d1f1-66e2-4c08-9db9-4cf7dc5165e4"), "Well done", "Elephants are cool 8ee2d1f1-66e2-4c08-9db9-4cf7dc5165e4", 3, 5 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("8f9b65e9-7614-4cac-9c23-d33d789300f1"), "Well done", "Elephants are cool 8f9b65e9-7614-4cac-9c23-d33d789300f1", 1, 3 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("91fc1b7e-f04f-418d-ac56-37e70fd563e9"), "Well done", "Elephants are cool 91fc1b7e-f04f-418d-ac56-37e70fd563e9", 3, 3 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("92706991-06c1-49ae-9efd-0c8bc2021539"), "Well done", "Elephants are cool 92706991-06c1-49ae-9efd-0c8bc2021539", 3, 5 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("936f2e57-8b8a-499c-9606-fb429acbc690"), "Well done", "Elephants are cool 936f2e57-8b8a-499c-9606-fb429acbc690", 5, 3 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("93fc15e7-a65e-4478-b02f-f37d47c94fb3"), "Well done", "Elephants are cool 93fc15e7-a65e-4478-b02f-f37d47c94fb3", 1, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("956f0e07-92de-413d-b682-36be27f11790"), "Well done", "Elephants are cool 956f0e07-92de-413d-b682-36be27f11790", 5, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("98753997-ac08-4236-8f95-07fa9a14b66c"), "Well done", "Elephants are cool 98753997-ac08-4236-8f95-07fa9a14b66c", 1, 5 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("9a10e296-a668-4b93-93df-8172ab011950"), "Well done", "Elephants are cool 9a10e296-a668-4b93-93df-8172ab011950", 5, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("9a8a9eb5-0094-4844-9014-55cbdf1c78a4"), "Well done", "Elephants are cool 9a8a9eb5-0094-4844-9014-55cbdf1c78a4", 1, 5 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("9d6379a4-2889-4494-b6bc-b482faf9a767"), "Well done", "Elephants are cool 9d6379a4-2889-4494-b6bc-b482faf9a767", 1, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("9ecf49c0-ccb5-40c3-8f03-00a65060c64e"), "Well done", "Elephants are cool 9ecf49c0-ccb5-40c3-8f03-00a65060c64e", 2, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("9fa1495e-e1e2-4607-89b8-8b6287733901"), "Well done", "Elephants are cool 9fa1495e-e1e2-4607-89b8-8b6287733901", 4, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("a027ac64-b58a-427c-a1fb-c4f6baa49702"), "Well done", "Elephants are cool a027ac64-b58a-427c-a1fb-c4f6baa49702", 3, 5 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("a15876ba-9822-4524-8023-9e6a55cc0c36"), "Well done", "Elephants are cool a15876ba-9822-4524-8023-9e6a55cc0c36", 3, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("a1c6f144-9734-4ad4-884a-93badd46d28b"), "Well done", "Elephants are cool a1c6f144-9734-4ad4-884a-93badd46d28b", 2, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("a3ba0b88-ee2d-4188-86d5-3d3aad5c4c3e"), "Well done", "Elephants are cool a3ba0b88-ee2d-4188-86d5-3d3aad5c4c3e", 5, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("a49e3263-d519-4352-9933-dde42c96a339"), "Well done", "Elephants are cool a49e3263-d519-4352-9933-dde42c96a339", 2, 5 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("a653f39b-df92-4c98-99bf-9416043188ee"), "Well done", "Elephants are cool a653f39b-df92-4c98-99bf-9416043188ee", 5, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("a6de1749-7b52-4c88-9ffd-52cd2245ad32"), "Well done", "Elephants are cool a6de1749-7b52-4c88-9ffd-52cd2245ad32", 4, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("a6e5a7c2-8ff3-4308-a498-23307360ccfb"), "Well done", "Elephants are cool a6e5a7c2-8ff3-4308-a498-23307360ccfb", 5, 3 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("a934a73c-a9cc-4a2f-b403-384d9a8b5077"), "Well done", "Elephants are cool a934a73c-a9cc-4a2f-b403-384d9a8b5077", 4, 3 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("ab3e6b47-9f55-429d-88c8-2bf76bf80361"), "Well done", "Elephants are cool ab3e6b47-9f55-429d-88c8-2bf76bf80361", 1, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("abd06212-f553-44bb-8024-b40d3ac5764d"), "Well done", "Elephants are cool abd06212-f553-44bb-8024-b40d3ac5764d", 5, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("ac7a4efa-62a6-4ce5-8f4d-c320e5ea2a87"), "Well done", "Elephants are cool ac7a4efa-62a6-4ce5-8f4d-c320e5ea2a87", 2, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("ad70c029-3b99-43cd-999d-bf7ad407321e"), "Well done", "Elephants are cool ad70c029-3b99-43cd-999d-bf7ad407321e", 3, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("af16548a-1283-441c-84bf-d830b6faa008"), "Well done", "Elephants are cool af16548a-1283-441c-84bf-d830b6faa008", 5, 5 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("afe3c6ab-3e69-46bf-aaea-1d51eab39c53"), "Well done", "Elephants are cool afe3c6ab-3e69-46bf-aaea-1d51eab39c53", 1, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("b2dc32d4-b668-4176-a88d-955222a97d6c"), "Well done", "Elephants are cool b2dc32d4-b668-4176-a88d-955222a97d6c", 3, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("b6659756-f691-4a29-b6b2-4b1a70116fc5"), "Well done", "Elephants are cool b6659756-f691-4a29-b6b2-4b1a70116fc5", 3, 5 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("b7cadb01-8b26-4749-a7bc-c67784b23060"), "Well done", "Elephants are cool b7cadb01-8b26-4749-a7bc-c67784b23060", 4, 5 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("b90a096f-67f0-44c6-bc5c-0ce4fde72a0c"), "Well done", "Elephants are cool b90a096f-67f0-44c6-bc5c-0ce4fde72a0c", 5, 3 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("bf0786b3-088d-4a0b-bc86-82137aaa339f"), "Well done", "Elephants are cool bf0786b3-088d-4a0b-bc86-82137aaa339f", 3, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("c2f2905a-ff65-43f6-ba7e-84d7bf545a2b"), "Well done", "Elephants are cool c2f2905a-ff65-43f6-ba7e-84d7bf545a2b", 5, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("c65ec76f-28a3-4605-b9bb-87798b030a42"), "Well done", "Elephants are cool c65ec76f-28a3-4605-b9bb-87798b030a42", 1, 3 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("c695afe4-28b0-467d-be4b-023a16c10fc8"), "Well done", "Elephants are cool c695afe4-28b0-467d-be4b-023a16c10fc8", 1, 5 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("c7686fed-01a2-4e3b-aa2c-c2c960f4fb1e"), "Well done", "Elephants are cool c7686fed-01a2-4e3b-aa2c-c2c960f4fb1e", 1, 3 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("c8f3d5a6-5cfa-4bff-bc71-473ad474e532"), "Well done", "Elephants are cool c8f3d5a6-5cfa-4bff-bc71-473ad474e532", 3, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("c9c4cd29-d988-49c1-af61-fdefb149fe14"), "Well done", "Elephants are cool c9c4cd29-d988-49c1-af61-fdefb149fe14", 3, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("c9db6f15-8900-4356-b16f-ceb3dc888ec7"), "Well done", "Elephants are cool c9db6f15-8900-4356-b16f-ceb3dc888ec7", 2, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("cb58dc12-681d-44b2-ba0f-de33672896be"), "Well done", "Elephants are cool cb58dc12-681d-44b2-ba0f-de33672896be", 1, 3 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("cd856785-7017-4dce-84d0-248ce08c9aa5"), "Well done", "Elephants are cool cd856785-7017-4dce-84d0-248ce08c9aa5", 1, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("ce12e994-a363-4706-ba0a-cdc32d09c6ac"), "Well done", "Elephants are cool ce12e994-a363-4706-ba0a-cdc32d09c6ac", 4, 3 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("cfdfc3b0-1831-4e17-8b16-a5f3bf2a47dd"), "Well done", "Elephants are cool cfdfc3b0-1831-4e17-8b16-a5f3bf2a47dd", 1, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("cffd4d68-4747-487a-8ba0-a816c85651d0"), "Well done", "Elephants are cool cffd4d68-4747-487a-8ba0-a816c85651d0", 3, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("d4b99b6b-fb1a-4f70-9dae-fbbcb7a2e7de"), "Well done", "Elephants are cool d4b99b6b-fb1a-4f70-9dae-fbbcb7a2e7de", 2, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("d68fd0f7-caaa-477c-a444-8f02be75e191"), "Well done", "Elephants are cool d68fd0f7-caaa-477c-a444-8f02be75e191", 3, 5 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("d7a01000-3ecd-42d0-9908-ffd4b60d4539"), "Well done", "Elephants are cool d7a01000-3ecd-42d0-9908-ffd4b60d4539", 2, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("da53ec38-e20b-449f-a6f4-4ba4f889e04b"), "Well done", "Elephants are cool da53ec38-e20b-449f-a6f4-4ba4f889e04b", 1, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("db1b35c9-a58c-4d59-ab57-c1b75d01f57a"), "Well done", "Elephants are cool db1b35c9-a58c-4d59-ab57-c1b75d01f57a", 4, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("dcb0990c-2161-49ec-8aee-010b152739ea"), "Well done", "Elephants are cool dcb0990c-2161-49ec-8aee-010b152739ea", 4, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("deab69b7-c2de-444f-8e53-6cde2022dac6"), "Well done", "Elephants are cool deab69b7-c2de-444f-8e53-6cde2022dac6", 2, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("deb08d11-98fe-44a6-8cce-ef3aecd6b08b"), "Well done", "Elephants are cool deb08d11-98fe-44a6-8cce-ef3aecd6b08b", 1, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("dfda66a2-57f1-4e3f-bf81-6ace0ba8d579"), "Well done", "Elephants are cool dfda66a2-57f1-4e3f-bf81-6ace0ba8d579", 1, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("e1f6a192-c2af-4b66-95e5-6db506fc7ff5"), "Well done", "Elephants are cool e1f6a192-c2af-4b66-95e5-6db506fc7ff5", 3, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("e3aeabf9-ae9e-4e7e-86a4-0f526142acf5"), "Well done", "Elephants are cool e3aeabf9-ae9e-4e7e-86a4-0f526142acf5", 4, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("e42df0a1-7a12-4e1a-ace9-17c4f3e1a41d"), "Well done", "Elephants are cool e42df0a1-7a12-4e1a-ace9-17c4f3e1a41d", 5, 3 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("e72f9fcf-5fee-4ed3-98d6-b54bb9cddb60"), "Well done", "Elephants are cool e72f9fcf-5fee-4ed3-98d6-b54bb9cddb60", 3, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("eaa271d2-2685-456c-9408-06bf06ff8992"), "Well done", "Elephants are cool eaa271d2-2685-456c-9408-06bf06ff8992", 1, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("ebd9e308-a8e3-46f7-9f5c-7eee37b7da97"), "Well done", "Elephants are cool ebd9e308-a8e3-46f7-9f5c-7eee37b7da97", 3, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("f0e81633-23b8-4a8b-8257-fc33ca8fd35b"), "Well done", "Elephants are cool f0e81633-23b8-4a8b-8257-fc33ca8fd35b", 1, 1 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("f2a6b805-b0f6-4cb1-9479-cb97ca8269e2"), "Well done", "Elephants are cool f2a6b805-b0f6-4cb1-9479-cb97ca8269e2", 5, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("f4789699-3b6a-415b-8a50-06e6c02cc3ac"), "Well done", "Elephants are cool f4789699-3b6a-415b-8a50-06e6c02cc3ac", 5, 3 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("f4b9f4a8-184d-4f9b-a108-9bf2aafbe63b"), "Well done", "Elephants are cool f4b9f4a8-184d-4f9b-a108-9bf2aafbe63b", 1, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("f5ba1459-8f6b-4c42-9866-20ec45fa3bf3"), "Well done", "Elephants are cool f5ba1459-8f6b-4c42-9866-20ec45fa3bf3", 3, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("f8062343-38b2-4cf2-bec3-ad22405bddef"), "Well done", "Elephants are cool f8062343-38b2-4cf2-bec3-ad22405bddef", 5, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("f81e8187-c412-47c5-a7ad-b89920c4e351"), "Well done", "Elephants are cool f81e8187-c412-47c5-a7ad-b89920c4e351", 4, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("f9aa4c76-3af8-4586-b488-98ec590f7bb1"), "Well done", "Elephants are cool f9aa4c76-3af8-4586-b488-98ec590f7bb1", 1, 2 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("fd28aa7e-ed04-4c26-8e24-472c55b3e004"), "Well done", "Elephants are cool fd28aa7e-ed04-4c26-8e24-472c55b3e004", 5, 4 },
                    { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("ff1925c8-a837-4eb5-bc31-19d3135e947b"), "Well done", "Elephants are cool ff1925c8-a837-4eb5-bc31-19d3135e947b", 3, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MaturityLevels",
                keyColumn: "Id",
                keyValue: new Guid("3e104a83-8d67-4290-b35e-4b76cbf57539"));

            migrationBuilder.DeleteData(
                table: "MaturityLevels",
                keyColumn: "Id",
                keyValue: new Guid("824ed90e-bbba-4da1-bccd-5a00a8a07449"));

            migrationBuilder.DeleteData(
                table: "MaturityLevels",
                keyColumn: "Id",
                keyValue: new Guid("9343760a-ba37-49e0-b849-32741fc6eb43"));

            migrationBuilder.DeleteData(
                table: "MaturityLevels",
                keyColumn: "Id",
                keyValue: new Guid("94b32039-d34b-4c2f-a36b-2ae8d27062d2"));

            migrationBuilder.DeleteData(
                table: "MaturityLevels",
                keyColumn: "Id",
                keyValue: new Guid("db132e32-2f52-4e3d-a77b-e40bd8c8a820"));

            migrationBuilder.DeleteData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: new Guid("6867bdef-ad72-4ce1-a4a0-02f55d71c254"));

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("00e63028-3683-485b-97a7-434edd73c9bd") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("066346b0-2f4c-4d9d-a534-8444d2d92c3e") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("07e18b14-a36a-4f9e-bf4b-e8eb90c0b0c0") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("07e68bab-a6fe-46fc-86ee-a2920102ee86") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("0bf27cce-7945-4e28-82c3-75c83453cfab") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("0c64bddf-f85b-4398-9c41-cd151a437026") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("0ed6bd0b-7e3e-4ca7-a10d-316d3d0fb2ba") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("103820c1-3688-4475-a8cd-454b0dad4dd4") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("1f5ce754-920c-4759-b382-ba56b4a3e925") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("21fbd597-4679-4c5f-b7d0-965c3e50f772") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("221e49bd-8f7b-43d2-ae5b-4c4c46a5e4cb") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("23a84fe4-f6f1-43bf-b14b-41fb87ae3d70") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("24d1bc45-4ef4-4cc4-8aac-f6ad902a7140") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("26a9b019-1efb-4325-ac8f-997875eb758a") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("26b66075-0434-423f-af25-884c6015b689") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("26e39390-bbc2-4da3-a122-bd5dfa9cc98c") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("279a2544-424d-463e-9e75-96d14fb136a8") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("2b1cec00-1a92-4bc9-9aca-e7a8c5dcf122") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("2c789e9f-0784-4e92-a0d4-c410fd50bd88") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("2d42aa5f-7a45-4ccf-90a6-9f733489dde4") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("30882678-259f-4b8e-a0fa-81f3dbb3f4f9") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("3170596e-561c-472b-9b80-ebddf15feeb5") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("31eb31ff-4358-4682-b3a5-224e38d1e704") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("346c09ae-b214-4dc8-84a3-6a50654e31af") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("34f344e3-d8b8-4c29-b113-c1d6c6734739") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("36bfec99-9376-48db-a364-a1cc3b8ee624") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("3a5a6217-c361-4030-a13c-50d0e90604e0") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("3a6e13c5-f62f-4324-9c98-63beece787ac") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("3b58b2f0-8d7b-4b1f-adf2-2eb6d4282e2e") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("3c4def8e-25a1-44fd-86a9-6dfd1a29a661") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("3c89aa9f-ad20-4dfb-a085-ccd1a8c5dc9a") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("3cb91a49-8903-4548-82ce-39734648ecaa") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("3f788de5-7db3-4587-8797-6d81952e1ef1") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("4101f946-c223-4367-8836-e48ec75061a1") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("4291fe1f-8192-4843-a193-804f11a8afa4") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("446bca0e-1fe8-4f3e-ade2-b3a116e300c3") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("45572035-97b5-43d7-b539-a42f42cf5985") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("4605ac3d-dfe0-4a1c-9687-9dc45582653e") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("47585fef-7d59-4cc9-a735-1948faa5dd6b") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("486f47f9-440c-4f01-abf4-00f96395b373") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("48d9b9b8-0104-4110-a8e5-f0930e109e6e") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("4aa609e0-63bf-45d1-a80a-6c08d7ba7fd5") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("4c9e4623-0afc-4dc5-a394-8107d5d9aa8a") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("4d6b062d-9e35-4af2-be79-6804fece50b8") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("4d8b5409-3b97-40e6-837f-244b0fad2649") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("52c22d9e-5b72-4966-a766-8cacc65cca1c") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("57cf6725-6639-48d3-a617-6c8189c84026") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("5903d1e9-bdf7-491f-a8d7-5a08906c740c") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("59a244c1-768c-46ab-bae1-878164cbb239") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("5a6de140-50ea-42ff-a4b1-a8cebf75fb44") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("5cd9a71b-144b-48fe-93d6-3658937af379") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("5dfa3fb0-84cb-4d9b-8add-84bb7d943db7") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("5f278726-aac4-410e-b961-7f71d8c42478") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("5f8bf821-902e-49a4-a46d-9698b8904a07") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("6149036e-9ce5-4a2e-bdda-d0cee80bdbba") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("636e5224-4905-4792-b2a4-c2904bb78e34") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("63ac466c-685f-48b0-a7f5-3bd5c7c05e4b") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("6570a2f8-676a-4e8b-a469-4f88fd06cef5") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("670e8b33-e333-4d90-8f63-854723796ad6") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("68a71898-573c-472b-9650-9d8117607b84") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("6dbb2471-e07e-4e97-8bd4-f22de661208a") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("6dc25c17-1894-4824-8dd1-c0a4223ecc04") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("6dff6632-ecfe-4aa2-825d-de28f00935e0") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("723701a4-0a1e-4652-8047-90046857e12b") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("73f20105-3b43-4cf0-b6da-f4c1f6f90fd0") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("74930ef3-fd21-49c9-b69b-f6ece8e00104") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("75820bf0-ecb6-45ce-aa7d-b9b86979f726") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("7671e6b3-ae00-4dde-ba5c-b2af273aea18") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("7e608c31-6d86-41c1-8e59-a745b3a93cf8") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("7f36dbcc-1493-4ff6-8e5d-4351ba1510ab") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("80599bbc-dfb6-4906-aace-1e546b1bbe94") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("80cd851a-73d1-4e2c-a142-58e0cd741121") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("874101ac-3e95-4687-9e63-a083ce59894e") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("8980a900-cab3-47fb-85c6-2afdf19fccd2") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("8b1d5fb4-e646-42e4-8f2c-6936f589d7cd") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("8b62f35e-b115-48b8-9c97-d6afef6496fe") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("8bcc2382-ac49-437e-80e6-a987a49e26d5") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("8e1abb26-884d-4797-9b1e-87b94dcb6666") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("8ee2d1f1-66e2-4c08-9db9-4cf7dc5165e4") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("8f9b65e9-7614-4cac-9c23-d33d789300f1") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("91fc1b7e-f04f-418d-ac56-37e70fd563e9") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("92706991-06c1-49ae-9efd-0c8bc2021539") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("936f2e57-8b8a-499c-9606-fb429acbc690") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("93fc15e7-a65e-4478-b02f-f37d47c94fb3") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("956f0e07-92de-413d-b682-36be27f11790") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("98753997-ac08-4236-8f95-07fa9a14b66c") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("9a10e296-a668-4b93-93df-8172ab011950") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("9a8a9eb5-0094-4844-9014-55cbdf1c78a4") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("9d6379a4-2889-4494-b6bc-b482faf9a767") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("9ecf49c0-ccb5-40c3-8f03-00a65060c64e") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("9fa1495e-e1e2-4607-89b8-8b6287733901") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("a027ac64-b58a-427c-a1fb-c4f6baa49702") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("a15876ba-9822-4524-8023-9e6a55cc0c36") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("a1c6f144-9734-4ad4-884a-93badd46d28b") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("a3ba0b88-ee2d-4188-86d5-3d3aad5c4c3e") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("a49e3263-d519-4352-9933-dde42c96a339") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("a653f39b-df92-4c98-99bf-9416043188ee") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("a6de1749-7b52-4c88-9ffd-52cd2245ad32") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("a6e5a7c2-8ff3-4308-a498-23307360ccfb") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("a934a73c-a9cc-4a2f-b403-384d9a8b5077") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("ab3e6b47-9f55-429d-88c8-2bf76bf80361") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("abd06212-f553-44bb-8024-b40d3ac5764d") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("ac7a4efa-62a6-4ce5-8f4d-c320e5ea2a87") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("ad70c029-3b99-43cd-999d-bf7ad407321e") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("af16548a-1283-441c-84bf-d830b6faa008") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("afe3c6ab-3e69-46bf-aaea-1d51eab39c53") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("b2dc32d4-b668-4176-a88d-955222a97d6c") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("b6659756-f691-4a29-b6b2-4b1a70116fc5") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("b7cadb01-8b26-4749-a7bc-c67784b23060") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("b90a096f-67f0-44c6-bc5c-0ce4fde72a0c") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("bf0786b3-088d-4a0b-bc86-82137aaa339f") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("c2f2905a-ff65-43f6-ba7e-84d7bf545a2b") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("c65ec76f-28a3-4605-b9bb-87798b030a42") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("c695afe4-28b0-467d-be4b-023a16c10fc8") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("c7686fed-01a2-4e3b-aa2c-c2c960f4fb1e") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("c8f3d5a6-5cfa-4bff-bc71-473ad474e532") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("c9c4cd29-d988-49c1-af61-fdefb149fe14") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("c9db6f15-8900-4356-b16f-ceb3dc888ec7") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("cb58dc12-681d-44b2-ba0f-de33672896be") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("cd856785-7017-4dce-84d0-248ce08c9aa5") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("ce12e994-a363-4706-ba0a-cdc32d09c6ac") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("cfdfc3b0-1831-4e17-8b16-a5f3bf2a47dd") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("cffd4d68-4747-487a-8ba0-a816c85651d0") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("d4b99b6b-fb1a-4f70-9dae-fbbcb7a2e7de") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("d68fd0f7-caaa-477c-a444-8f02be75e191") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("d7a01000-3ecd-42d0-9908-ffd4b60d4539") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("da53ec38-e20b-449f-a6f4-4ba4f889e04b") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("db1b35c9-a58c-4d59-ab57-c1b75d01f57a") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("dcb0990c-2161-49ec-8aee-010b152739ea") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("deab69b7-c2de-444f-8e53-6cde2022dac6") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("deb08d11-98fe-44a6-8cce-ef3aecd6b08b") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("dfda66a2-57f1-4e3f-bf81-6ace0ba8d579") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("e1f6a192-c2af-4b66-95e5-6db506fc7ff5") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("e3aeabf9-ae9e-4e7e-86a4-0f526142acf5") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("e42df0a1-7a12-4e1a-ace9-17c4f3e1a41d") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("e72f9fcf-5fee-4ed3-98d6-b54bb9cddb60") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("eaa271d2-2685-456c-9408-06bf06ff8992") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("ebd9e308-a8e3-46f7-9f5c-7eee37b7da97") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("f0e81633-23b8-4a8b-8257-fc33ca8fd35b") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("f2a6b805-b0f6-4cb1-9479-cb97ca8269e2") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("f4789699-3b6a-415b-8a50-06e6c02cc3ac") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("f4b9f4a8-184d-4f9b-a108-9bf2aafbe63b") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("f5ba1459-8f6b-4c42-9866-20ec45fa3bf3") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("f8062343-38b2-4cf2-bec3-ad22405bddef") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("f81e8187-c412-47c5-a7ad-b89920c4e351") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("f9aa4c76-3af8-4586-b488-98ec590f7bb1") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("fd28aa7e-ed04-4c26-8e24-472c55b3e004") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "AssessmentId", "RequirementId" },
                keyValues: new object[] { new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"), new Guid("ff1925c8-a837-4eb5-bc31-19d3135e947b") });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("495135fa-7818-4d1a-91fe-ecb7d8f0b619"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d0972a8b-cc3b-49ac-9925-c21d8862d876"));

            migrationBuilder.DeleteData(
                table: "Assessments",
                keyColumn: "Id",
                keyValue: new Guid("89b3ef5b-5add-4053-b383-0e831bc05522"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("00e63028-3683-485b-97a7-434edd73c9bd"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("066346b0-2f4c-4d9d-a534-8444d2d92c3e"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("07e18b14-a36a-4f9e-bf4b-e8eb90c0b0c0"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("07e68bab-a6fe-46fc-86ee-a2920102ee86"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("0bf27cce-7945-4e28-82c3-75c83453cfab"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("0c64bddf-f85b-4398-9c41-cd151a437026"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("0ed6bd0b-7e3e-4ca7-a10d-316d3d0fb2ba"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("103820c1-3688-4475-a8cd-454b0dad4dd4"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("1f5ce754-920c-4759-b382-ba56b4a3e925"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("21fbd597-4679-4c5f-b7d0-965c3e50f772"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("221e49bd-8f7b-43d2-ae5b-4c4c46a5e4cb"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("23a84fe4-f6f1-43bf-b14b-41fb87ae3d70"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("24d1bc45-4ef4-4cc4-8aac-f6ad902a7140"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("26a9b019-1efb-4325-ac8f-997875eb758a"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("26b66075-0434-423f-af25-884c6015b689"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("26e39390-bbc2-4da3-a122-bd5dfa9cc98c"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("279a2544-424d-463e-9e75-96d14fb136a8"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("2b1cec00-1a92-4bc9-9aca-e7a8c5dcf122"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("2c789e9f-0784-4e92-a0d4-c410fd50bd88"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("2d42aa5f-7a45-4ccf-90a6-9f733489dde4"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("30882678-259f-4b8e-a0fa-81f3dbb3f4f9"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("3170596e-561c-472b-9b80-ebddf15feeb5"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("31eb31ff-4358-4682-b3a5-224e38d1e704"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("346c09ae-b214-4dc8-84a3-6a50654e31af"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("34f344e3-d8b8-4c29-b113-c1d6c6734739"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("36bfec99-9376-48db-a364-a1cc3b8ee624"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("3a5a6217-c361-4030-a13c-50d0e90604e0"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("3a6e13c5-f62f-4324-9c98-63beece787ac"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("3b58b2f0-8d7b-4b1f-adf2-2eb6d4282e2e"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("3c4def8e-25a1-44fd-86a9-6dfd1a29a661"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("3c89aa9f-ad20-4dfb-a085-ccd1a8c5dc9a"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("3cb91a49-8903-4548-82ce-39734648ecaa"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("3f788de5-7db3-4587-8797-6d81952e1ef1"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("4101f946-c223-4367-8836-e48ec75061a1"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("4291fe1f-8192-4843-a193-804f11a8afa4"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("446bca0e-1fe8-4f3e-ade2-b3a116e300c3"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("45572035-97b5-43d7-b539-a42f42cf5985"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("4605ac3d-dfe0-4a1c-9687-9dc45582653e"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("47585fef-7d59-4cc9-a735-1948faa5dd6b"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("486f47f9-440c-4f01-abf4-00f96395b373"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("48d9b9b8-0104-4110-a8e5-f0930e109e6e"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("4aa609e0-63bf-45d1-a80a-6c08d7ba7fd5"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("4c9e4623-0afc-4dc5-a394-8107d5d9aa8a"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("4d6b062d-9e35-4af2-be79-6804fece50b8"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("4d8b5409-3b97-40e6-837f-244b0fad2649"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("52c22d9e-5b72-4966-a766-8cacc65cca1c"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("57cf6725-6639-48d3-a617-6c8189c84026"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("5903d1e9-bdf7-491f-a8d7-5a08906c740c"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("59a244c1-768c-46ab-bae1-878164cbb239"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("5a6de140-50ea-42ff-a4b1-a8cebf75fb44"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("5cd9a71b-144b-48fe-93d6-3658937af379"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("5dfa3fb0-84cb-4d9b-8add-84bb7d943db7"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("5f278726-aac4-410e-b961-7f71d8c42478"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("5f8bf821-902e-49a4-a46d-9698b8904a07"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("6149036e-9ce5-4a2e-bdda-d0cee80bdbba"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("636e5224-4905-4792-b2a4-c2904bb78e34"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("63ac466c-685f-48b0-a7f5-3bd5c7c05e4b"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("6570a2f8-676a-4e8b-a469-4f88fd06cef5"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("670e8b33-e333-4d90-8f63-854723796ad6"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("68a71898-573c-472b-9650-9d8117607b84"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("6dbb2471-e07e-4e97-8bd4-f22de661208a"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("6dc25c17-1894-4824-8dd1-c0a4223ecc04"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("6dff6632-ecfe-4aa2-825d-de28f00935e0"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("723701a4-0a1e-4652-8047-90046857e12b"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("73f20105-3b43-4cf0-b6da-f4c1f6f90fd0"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("74930ef3-fd21-49c9-b69b-f6ece8e00104"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("75820bf0-ecb6-45ce-aa7d-b9b86979f726"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("7671e6b3-ae00-4dde-ba5c-b2af273aea18"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("7e608c31-6d86-41c1-8e59-a745b3a93cf8"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("7f36dbcc-1493-4ff6-8e5d-4351ba1510ab"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("80599bbc-dfb6-4906-aace-1e546b1bbe94"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("80cd851a-73d1-4e2c-a142-58e0cd741121"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("874101ac-3e95-4687-9e63-a083ce59894e"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("8980a900-cab3-47fb-85c6-2afdf19fccd2"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("8b1d5fb4-e646-42e4-8f2c-6936f589d7cd"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("8b62f35e-b115-48b8-9c97-d6afef6496fe"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("8bcc2382-ac49-437e-80e6-a987a49e26d5"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("8e1abb26-884d-4797-9b1e-87b94dcb6666"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("8ee2d1f1-66e2-4c08-9db9-4cf7dc5165e4"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("8f9b65e9-7614-4cac-9c23-d33d789300f1"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("91fc1b7e-f04f-418d-ac56-37e70fd563e9"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("92706991-06c1-49ae-9efd-0c8bc2021539"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("936f2e57-8b8a-499c-9606-fb429acbc690"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("93fc15e7-a65e-4478-b02f-f37d47c94fb3"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("956f0e07-92de-413d-b682-36be27f11790"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("98753997-ac08-4236-8f95-07fa9a14b66c"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("9a10e296-a668-4b93-93df-8172ab011950"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("9a8a9eb5-0094-4844-9014-55cbdf1c78a4"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("9d6379a4-2889-4494-b6bc-b482faf9a767"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("9ecf49c0-ccb5-40c3-8f03-00a65060c64e"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("9fa1495e-e1e2-4607-89b8-8b6287733901"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("a027ac64-b58a-427c-a1fb-c4f6baa49702"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("a15876ba-9822-4524-8023-9e6a55cc0c36"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("a1c6f144-9734-4ad4-884a-93badd46d28b"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("a3ba0b88-ee2d-4188-86d5-3d3aad5c4c3e"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("a49e3263-d519-4352-9933-dde42c96a339"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("a653f39b-df92-4c98-99bf-9416043188ee"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("a6de1749-7b52-4c88-9ffd-52cd2245ad32"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("a6e5a7c2-8ff3-4308-a498-23307360ccfb"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("a934a73c-a9cc-4a2f-b403-384d9a8b5077"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("ab3e6b47-9f55-429d-88c8-2bf76bf80361"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("abd06212-f553-44bb-8024-b40d3ac5764d"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("ac7a4efa-62a6-4ce5-8f4d-c320e5ea2a87"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("ad70c029-3b99-43cd-999d-bf7ad407321e"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("af16548a-1283-441c-84bf-d830b6faa008"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("afe3c6ab-3e69-46bf-aaea-1d51eab39c53"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("b2dc32d4-b668-4176-a88d-955222a97d6c"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("b6659756-f691-4a29-b6b2-4b1a70116fc5"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("b7cadb01-8b26-4749-a7bc-c67784b23060"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("b90a096f-67f0-44c6-bc5c-0ce4fde72a0c"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("bf0786b3-088d-4a0b-bc86-82137aaa339f"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("c2f2905a-ff65-43f6-ba7e-84d7bf545a2b"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("c65ec76f-28a3-4605-b9bb-87798b030a42"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("c695afe4-28b0-467d-be4b-023a16c10fc8"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("c7686fed-01a2-4e3b-aa2c-c2c960f4fb1e"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("c8f3d5a6-5cfa-4bff-bc71-473ad474e532"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("c9c4cd29-d988-49c1-af61-fdefb149fe14"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("c9db6f15-8900-4356-b16f-ceb3dc888ec7"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("cb58dc12-681d-44b2-ba0f-de33672896be"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("cd856785-7017-4dce-84d0-248ce08c9aa5"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("ce12e994-a363-4706-ba0a-cdc32d09c6ac"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("cfdfc3b0-1831-4e17-8b16-a5f3bf2a47dd"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("cffd4d68-4747-487a-8ba0-a816c85651d0"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("d4b99b6b-fb1a-4f70-9dae-fbbcb7a2e7de"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("d68fd0f7-caaa-477c-a444-8f02be75e191"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("d7a01000-3ecd-42d0-9908-ffd4b60d4539"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("da53ec38-e20b-449f-a6f4-4ba4f889e04b"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("db1b35c9-a58c-4d59-ab57-c1b75d01f57a"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("dcb0990c-2161-49ec-8aee-010b152739ea"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("deab69b7-c2de-444f-8e53-6cde2022dac6"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("deb08d11-98fe-44a6-8cce-ef3aecd6b08b"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("dfda66a2-57f1-4e3f-bf81-6ace0ba8d579"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("e1f6a192-c2af-4b66-95e5-6db506fc7ff5"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("e3aeabf9-ae9e-4e7e-86a4-0f526142acf5"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("e42df0a1-7a12-4e1a-ace9-17c4f3e1a41d"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("e72f9fcf-5fee-4ed3-98d6-b54bb9cddb60"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("eaa271d2-2685-456c-9408-06bf06ff8992"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("ebd9e308-a8e3-46f7-9f5c-7eee37b7da97"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("f0e81633-23b8-4a8b-8257-fc33ca8fd35b"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("f2a6b805-b0f6-4cb1-9479-cb97ca8269e2"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("f4789699-3b6a-415b-8a50-06e6c02cc3ac"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("f4b9f4a8-184d-4f9b-a108-9bf2aafbe63b"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("f5ba1459-8f6b-4c42-9866-20ec45fa3bf3"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("f8062343-38b2-4cf2-bec3-ad22405bddef"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("f81e8187-c412-47c5-a7ad-b89920c4e351"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("f9aa4c76-3af8-4586-b488-98ec590f7bb1"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("fd28aa7e-ed04-4c26-8e24-472c55b3e004"));

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "Id",
                keyValue: new Guid("ff1925c8-a837-4eb5-bc31-19d3135e947b"));

            migrationBuilder.DeleteData(
                table: "Maturities",
                keyColumn: "Id",
                keyValue: new Guid("1f7570aa-509a-49e9-9368-6ab4fb3f60e1"));

            migrationBuilder.DeleteData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: new Guid("1d376e9e-68ae-4681-8ad6-dc53d94a4ced"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("051cc8fb-a72f-47d8-aee4-81d1ddcb9256"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("0599f344-9c68-4942-9f90-05cd955c0bf2"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("18fff895-9fc1-4a3e-9a3a-cceca872330e"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("1ba12212-b8e4-43b4-8122-85c8e46131bf"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("1f4e442d-693a-488d-bef7-3a497170d8a9"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("2079bbeb-5713-47de-950f-5f10788f67e7"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("2141bf50-5f2f-45cd-bd44-3e11a197f7bf"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("24203a47-35b9-49fd-91fa-5f2859b7d921"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("279dc133-e6d3-41ce-acde-e2ee99c4576b"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("2c077640-b3ba-4351-a0ca-6e02b2ed3449"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("2e72755f-3ff3-4f56-be93-16aebc0f0d0d"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("30a7fc06-3dc9-4581-b5c1-e732338fdf06"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("31b34e3b-6f00-4b04-b00b-d93bfe09306e"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("34af178a-0d8a-453e-bb7e-0e07494fa221"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("34d2abc7-adfe-45d5-a8fe-791bc4d728d7"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3a9824e4-dcea-416d-b980-3c7b0ef102fd"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3d6f6f8e-3e17-4cbd-be24-b9b915af40de"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("4268937d-a7c9-40f1-b0bc-5acd80487562"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("4a9ac2f5-eeb5-4d54-af1f-61eb06ecc03f"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("4c30f4dc-e2ab-4b28-962c-32fa201918fa"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("4c8755a3-187f-41a5-af01-5f50c62ef87e"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("4d2fa7a8-e0c1-4cac-bc11-911430c1e47a"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("4e564fec-29fa-41eb-adb2-daf82f66a950"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("5280a1e2-8941-4994-a483-fe9235dee0fd"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("5287f11d-1c1c-4938-98f5-20576e7081d9"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("593cb23d-9e2e-404d-955f-478ed845f50a"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("595b625b-7641-4c9a-986d-504090c03c44"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("5a3301e7-4545-442a-b78a-2c0312386b19"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("5aca2b06-736a-428d-bb85-e1c4b69a7774"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("5c021230-07ef-4269-99a6-648bacd7b46d"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("5f7578d2-ab6a-4f0d-8c67-3a6d54c85110"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("6089a8a0-e551-4dbd-822f-01287aa46dcc"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("6499315c-b528-4d99-b2c2-be37df256922"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("6bc829fe-3193-4646-8868-bcf130333741"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("6e795f27-4c41-40e9-81d5-63d23b9b1d60"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("713518df-8599-4ae3-ba32-c16ab59f70f5"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("713f72bc-e9be-4ae3-8982-69fa9a16bbfc"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("732ffe91-6f74-409f-ba09-72578ce1eecd"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("74619b12-fcfb-4bcf-84b9-e960e8b1cc92"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("778a003a-ae85-40f6-a8e3-2f0d7273f87c"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("82032357-16f8-41b7-a5cc-91fc6fdf637a"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("83d2e050-a0f1-430e-9160-3d963355f590"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("8550a4ef-80a6-4046-add4-8015c93071f9"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("86faabda-2814-49c4-9b42-20212b49782a"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("887bcf23-304d-4fde-9cf9-c90d6c9ab037"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("88f4119c-cfcd-4279-a2e5-0ac5b699d521"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("8afd1a95-a3e7-40a5-af34-8b9e7a34f628"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("8b6034c1-cae5-4f89-b673-3c76fe9cf7af"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("8b8552af-cb2e-4b4d-90af-bd2f6bd71f1a"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("8b879c8b-ab8e-408b-baee-084d7ba9659e"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("8dab09d8-1098-4aae-8a1a-dd57e6c86d85"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("8f4dc8d7-f883-4dbc-9caa-6b90e8bf2d0c"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9363a8ce-d0ca-4674-8cc4-34aac6fcaade"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("94c13ed9-51a3-4702-9876-895c347c86f8"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("98b051e5-c52e-411f-930b-34980075cb22"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("993b7cd9-4b1b-4d76-a871-fc336b78d766"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9b373dc1-5be5-4358-ab6a-ad15b03d977b"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9c0bc48b-b1e9-46a3-b6af-20a5e231e09c"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9d3ade37-8d5b-492a-9e18-4624c9a9221b"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9da1be8f-b8b4-4682-8b99-e04fe8faa7a2"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9ed1543c-cd61-4681-98b2-69a6e635577d"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9f7aeb36-fcd2-45d6-a545-38ed6e54cc79"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("a09848d8-1343-4054-a183-1827d224b033"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("a135607e-ef53-4b12-a0bc-c5765e64c972"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("a170ca9e-ea86-48b0-ae11-72499403f43c"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("a5beeb6d-a44f-4ca6-b6eb-f15f3ea74ea7"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("a72a7823-76ab-4bff-a3e2-55d851334606"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("a7563fc7-4ff2-44fe-a5f2-a79bec793214"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("a886013f-bc1a-411d-9dbe-7bb806388a4d"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("ad038674-ef85-43cd-a9ff-905aa6f2ab9c"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b2cc39a8-f829-472d-bd79-b75d4b252f91"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b5c9140c-5b33-40e5-b5a6-b57b2aa70bc4"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b66c92d9-823a-4df8-9a23-2a83067194f7"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b6acfec6-f955-41a9-aa88-fbacb57183b4"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b7f2b613-a98a-465f-a32c-8033c7be56ab"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("bb798c04-ef09-49a9-9bc1-f4f6262419d8"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("bfa190b6-8988-4781-9864-0a7a6c003fcc"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("c7ed2d73-037e-441c-a99e-3bac0d81572e"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("c9f99618-f5e8-4419-ab4c-042b11b468f2"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("cc382bd0-95d4-4617-8bb9-acf89e042696"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d0bc871e-ca67-4503-bf32-4efda76e36b9"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d0c3e227-05f1-4be8-a6ee-ac0418fdb94c"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d1002e67-98fe-423c-a19c-d4dbc7a28c8c"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d60c4129-d959-4404-beeb-3cd1236cfc01"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("db73a316-49cb-4db4-9ed9-a59a93bfd92b"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("ddde1cc2-0859-4584-b51a-be69282718f4"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("de3a3e6e-a45c-47be-a4f9-b447feb31d46"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("ded75e10-c86a-482b-94c0-21c279b9d06d"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("e0e23fa5-5ad1-4fa2-8941-c3518ed7f28e"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("e3371e7c-8c1c-4267-9bae-25bc27d031be"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("e75a72b6-82ea-4ed3-92d5-09f3d1f119f1"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("e8eb7120-994f-4070-8b3e-fc67a8e04a5f"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("ef1d0332-6030-4832-86c2-b4b45c186364"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f24aa659-df77-485f-bbfe-b464866e1c05"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f4090957-3135-4f6c-a4d3-14d127ac7e50"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f558c9e0-2ed6-4eb2-b651-cffd6b378279"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("fc71ec5f-3851-43b5-a74a-f0059829de1f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("138d1972-631e-480b-a005-58b9bca8e4ea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d394d9a-e134-4dfe-a8c8-f12cc6de81ca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("01af50a3-adf4-4b32-9598-7e146d5e2e2c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("02178fc5-8e83-4aa1-8252-a76edda31d02"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0fb92d70-1a26-4cc4-9912-76b59a7ffc37"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1086b3ef-fa93-4846-8518-8ccad964484b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("18678c37-a299-4ca4-b610-607beb60a1a2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1d234796-662d-4391-ba62-27397fbdfbc4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1ffbf56c-727e-43a1-b66f-e3be9f6f585c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3a281d1c-8c2f-4fb6-bd19-3cd6c3ea6d7b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3e57c961-a040-4865-a9ce-743a31597813"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4919ea9b-c4f7-45ba-9151-7667dbc43a71"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5acbf9d5-6de3-4c86-a451-cb59b74f33c9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8849e851-d000-4f43-89cf-e84a2875dd9a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8d21ff39-9e60-47e8-bccc-eec610d7b576"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("90eaf9ed-c180-405b-97f2-4bb13b79231f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("978c228f-7b3b-4054-8d77-8cc40274a263"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9cbf1981-d460-4ae7-8bd9-f6fe632b71fb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a347cd22-9140-4811-ae86-279654488323"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a9d192d6-4eea-44a8-9b77-16008c85cb79"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ac7fff60-df1d-45e1-9f4a-215d4eb287ca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b572fdd8-874c-4724-8f8c-8893f16c0d38"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b654d831-9b49-4bb6-a9de-a8ca183a7064"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("da934b99-ebd3-49dd-a39b-18e6d917c7db"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e5f506c8-d52d-4a86-aef6-af85755c349a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eaa515f4-682b-43a8-b3bf-4d3d190d141d"));

            migrationBuilder.DeleteData(
                table: "Functions",
                keyColumn: "Id",
                keyValue: new Guid("738e7749-4dd3-4403-973c-f83bc40a2ce2"));

            migrationBuilder.DeleteData(
                table: "Functions",
                keyColumn: "Id",
                keyValue: new Guid("a9a08bf1-2218-4edd-815c-1984528eb78d"));

            migrationBuilder.DeleteData(
                table: "Functions",
                keyColumn: "Id",
                keyValue: new Guid("ab580cf1-f5c7-4e3c-8b17-28e320ae9c04"));

            migrationBuilder.DeleteData(
                table: "Functions",
                keyColumn: "Id",
                keyValue: new Guid("eacd318f-d9eb-4b18-b8a8-92ea9fec75d9"));

            migrationBuilder.DeleteData(
                table: "Functions",
                keyColumn: "Id",
                keyValue: new Guid("ef2980ce-db57-4108-9473-dde9adb9766b"));

            migrationBuilder.InsertData(
                table: "Functions",
                columns: new[] { "Id", "Code", "Color", "Created", "Deleted", "Description", "Name", "Order", "Updated" },
                values: new object[,]
                {
                    { new Guid("3e6599ae-54c8-42c5-aa53-59f83bf20451"), null, "79F19C", null, null, null, "Recover", 0, null },
                    { new Guid("8478e721-af59-45a8-87e2-b2f671860dbf"), null, "F87264", null, null, null, "Respond", 0, null },
                    { new Guid("8b419820-3c3c-49da-bd0d-d20661f7fbb7"), null, "43C5F3", null, null, null, "Identify", 0, null },
                    { new Guid("e2bd0267-3f99-4489-8ad2-2de44411daba"), null, "8F92EB", null, null, null, "Protect", 0, null },
                    { new Guid("ee790a58-2e56-4500-afaa-5ae761d8f90f"), null, "F7B848", null, null, null, "Detect", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Maturities",
                columns: new[] { "Id", "Code", "Created", "Deleted", "Description", "Name", "Threshold", "Updated" },
                values: new object[] { new Guid("c3ef7ab0-a332-4cce-9335-4f8de27f0c7d"), null, null, null, "", "Important", 3, null });

            migrationBuilder.InsertData(
                table: "Municipalities",
                columns: new[] { "Id", "Code", "Created", "Deleted", "Description", "Name", "Updated" },
                values: new object[,]
                {
                    { new Guid("9780b4b8-d985-4cb7-8568-a2132675298e"), null, null, null, null, "Gent", null },
                    { new Guid("d6530ab5-d604-4c90-a4b3-a217d9cf632f"), null, null, null, null, "Brugge", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Deleted", "IsAdmin", "IsAssesor", "Updated", "UserName" },
                values: new object[,]
                {
                    { new Guid("63905826-de4f-4918-8a11-082c61120a2c"), new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, null, "sara.langlois2003@gmail.com" },
                    { new Guid("74cf7114-d30c-4555-8796-e8ea663e5143"), new DateTime(2016, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, null, "mauro.bekaert@lolol.be" },
                    { new Guid("87453e84-dad6-43e2-a59e-456626aa8ef7"), new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, true, null, "timo.blomme@hahaha.com" },
                    { new Guid("c40f473a-ce7e-4f2c-b95b-31410495770a"), new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, null, "maarten.sohier@hihi.be" }
                });

            migrationBuilder.InsertData(
                table: "Assessments",
                columns: new[] { "Id", "AssessorId", "Created", "Deleted", "MaturityId", "MunicipalityId", "Updated", "UserId" },
                values: new object[] { new Guid("b0398bee-0a57-45d4-a8ef-2b6ec736ee18"), new Guid("74cf7114-d30c-4555-8796-e8ea663e5143"), null, null, new Guid("c3ef7ab0-a332-4cce-9335-4f8de27f0c7d"), new Guid("d6530ab5-d604-4c90-a4b3-a217d9cf632f"), null, new Guid("63905826-de4f-4918-8a11-082c61120a2c") });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Code", "Created", "Deleted", "Description", "FunctionId", "Name", "Order", "Updated" },
                values: new object[,]
                {
                    { new Guid("06b67f35-f459-4f1a-98db-e04b3f01d2b1"), null, null, null, "Herstelactiviteiten worden gecoördineerd met interne en externe partijen (bijv. coördinatiecentra, internetproviders, eigenaren van aanvallende systemen, slachtoffers, andere CSIRT's en leveranciers).", new Guid("3e6599ae-54c8-42c5-aa53-59f83bf20451"), "Communications", 0, null },
                    { new Guid("28a61c29-b46e-4299-ab7f-31637fa3d5a2"), null, null, null, "Technische beveiligingsoplossingen worden beheerd om de beveiliging en veerkracht van systemen en bedrijfsmiddelen te garanderen, in overeenstemming met beleid, procedures en overeenkomsten.", new Guid("e2bd0267-3f99-4489-8ad2-2de44411daba"), "Protective Technology", 0, null },
                    { new Guid("3801fcc8-e6c4-46b5-b1a5-0a652bb265ce"), null, null, null, "Het beleid, de procedures en processen voor het beheren en bewaken van de regelgevende, juridische, risico-, milieu- en operationele vereisten van de organisatie worden begrepen en informeren het beheer van cyberbeveiligingsrisico's.", new Guid("8b419820-3c3c-49da-bd0d-d20661f7fbb7"), "Governance", 0, null },
                    { new Guid("44917305-0a39-43e6-b75e-6f58a709feb1"), null, null, null, "Het personeel en de partners van de organisatie krijgen voorlichting over cyberbewustzijn en worden getraind om hun taken en verantwoordelijkheden op het gebied van cyberbeveiliging uit te voeren in overeenstemming met het beleid, de procedures en overeenkomsten op dit gebied.", new Guid("e2bd0267-3f99-4489-8ad2-2de44411daba"), "Awareness and Training", 0, null },
                    { new Guid("5931d80f-dd54-49b8-a856-0121f4ff126a"), null, null, null, "Responseprocessen en -procedures worden uitgevoerd en onderhouden om te zorgen dat er wordt gereageerd op gedetecteerde cyberbeveiligingsincidenten.", new Guid("8478e721-af59-45a8-87e2-b2f671860dbf"), "Response Planning", 0, null },
                    { new Guid("5bae836c-dd29-46f7-b36d-1ace1c5f4f3b"), null, null, null, "De missie, doelstellingen, belanghebbenden en activiteiten van de organisatie worden begrepen en geprioriteerd; deze informatie wordt gebruikt om cyberbeveiligingsrollen, verantwoordelijkheden en risicomanagementbeslissingen te informeren.", new Guid("8b419820-3c3c-49da-bd0d-d20661f7fbb7"), "Business Environment", 0, null },
                    { new Guid("5e4c390e-eb7a-4a2e-9315-01027f7df135"), null, null, null, "Toegang tot fysieke en logische activa en bijbehorende faciliteiten is beperkt tot geautoriseerde gebruikers, processen en apparaten, en wordt beheerd in overeenstemming met het ingeschatte risico van ongeautoriseerde toegang tot geautoriseerde activiteiten en transacties.", new Guid("e2bd0267-3f99-4489-8ad2-2de44411daba"), "Identity Management, Authentication and Access Control", 0, null },
                    { new Guid("5e7f4af0-5d80-457c-a939-383eb2a06011"), null, null, null, "Informatie en records (gegevens) worden beheerd in overeenstemming met de risicostrategie van de organisatie om de vertrouwelijkheid, integriteit en beschikbaarheid van informatie te beschermen.", new Guid("e2bd0267-3f99-4489-8ad2-2de44411daba"), "Data Security", 0, null },
                    { new Guid("625db872-cda7-41f9-8f33-5675811e0291"), null, null, null, "Herstelprocessen en -procedures worden uitgevoerd en gehandhaafd om te zorgen voor herstel van systemen of bedrijfsmiddelen die zijn getroffen door cyberbeveiligingsincidenten.", new Guid("3e6599ae-54c8-42c5-aa53-59f83bf20451"), "Recovery Planning", 0, null },
                    { new Guid("64f2b22b-86d4-4d3b-a508-e9fe3db31d79"), null, null, null, "De prioriteiten, beperkingen, risicotoleranties en aannames van de organisatie worden vastgesteld en gebruikt ter ondersteuning van risicobeslissingen met betrekking tot het beheren van risico's in de toeleveringsketen. De organisatie heeft processen vastgesteld en geïmplementeerd om risico's in de toeleveringsketen te identificeren, te beoordelen en te beheren.", new Guid("8b419820-3c3c-49da-bd0d-d20661f7fbb7"), "Supply Chain Risk Management", 0, null },
                    { new Guid("7374fa62-6392-4a5a-8249-66a4f046a6c4"), null, null, null, "Er worden activiteiten uitgevoerd om uitbreiding van een gebeurtenis te voorkomen, de gevolgen ervan te beperken en het incident op te lossen.", new Guid("8478e721-af59-45a8-87e2-b2f671860dbf"), "Mitigation", 0, null },
                    { new Guid("7509028d-3fb4-4840-9727-b4a03bdc6694"), null, null, null, "Er worden analyses uitgevoerd om een effectieve respons te garanderen en herstelactiviteiten te ondersteunen.", new Guid("8478e721-af59-45a8-87e2-b2f671860dbf"), "Analysis", 0, null },
                    { new Guid("7e4d0bc6-a3f9-4afc-9877-3cb27f25558f"), null, null, null, "Detectieprocessen en -procedures worden onderhouden en getest om ervoor te zorgen dat men op de hoogte is van afwijkende gebeurtenissen.", new Guid("ee790a58-2e56-4500-afaa-5ae761d8f90f"), "Detection Processes", 0, null },
                    { new Guid("8006ee9d-239a-4fc6-88e2-b0e1c4667449"), null, null, null, "Herstelactiviteiten worden gecoördineerd met interne en externe partijen (bijv. coördinatiecentra, internetproviders, eigenaren van aanvallende systemen, slachtoffers, andere CSIRT's en leveranciers).", new Guid("3e6599ae-54c8-42c5-aa53-59f83bf20451"), "Communications", 0, null },
                    { new Guid("863672b2-a93f-4635-b9e4-68901eff2fd8"), null, null, null, "Het informatiesysteem en de middelen worden gemonitord om cyberbeveiligingsgebeurtenissen te identificeren en de effectiviteit van beschermende maatregelen te verifiëren.", new Guid("ee790a58-2e56-4500-afaa-5ae761d8f90f"), "Security Continuous Monitoring", 0, null },
                    { new Guid("8afc2316-2097-4601-aeab-28cb9a91df4a"), null, null, null, "Onderhoud en reparaties aan componenten van industriële besturings- en informatiesystemen worden uitgevoerd in overeenstemming met beleid en procedures.", new Guid("e2bd0267-3f99-4489-8ad2-2de44411daba"), "Maintenance", 0, null },
                    { new Guid("9287ef1b-8b97-470d-8e62-8ba4c5db8df6"), null, null, null, "Response-activiteiten worden gecoördineerd met interne en externe belanghebbenden (bijv. externe ondersteuning van wetshandhavingsinstanties).", new Guid("8478e721-af59-45a8-87e2-b2f671860dbf"), "Communications", 0, null },
                    { new Guid("b1e6113e-2e82-4023-84d2-574c5dc83bfe"), null, null, null, "De prioriteiten, beperkingen, risicotoleranties en aannames van de organisatie worden vastgesteld en gebruikt om beslissingen over operationele risico's te ondersteunen.", new Guid("8b419820-3c3c-49da-bd0d-d20661f7fbb7"), "Risk Management Strategy", 0, null },
                    { new Guid("bab4a94d-3302-4842-81c1-0669596d71f2"), null, null, null, "Afwijkende activiteiten worden gedetecteerd en de potentiële impact van gebeurtenissen wordt begrepen.", new Guid("ee790a58-2e56-4500-afaa-5ae761d8f90f"), "Anomalies and Events", 0, null },
                    { new Guid("cda5bbcc-4a24-456e-9240-dbbe0d92e0f0"), null, null, null, "De organisatie begrijpt het cyberbeveiligingsrisico voor de activiteiten van de organisatie (inclusief missie, functies, imago of reputatie), bedrijfsmiddelen van de organisatie en individuen.", new Guid("8b419820-3c3c-49da-bd0d-d20661f7fbb7"), "Risk Assessment", 0, null },
                    { new Guid("d79a57e2-ffbc-4806-ac17-ca2122838265"), null, null, null, "Er wordt een beveiligingsbeleid (met aandacht voor het doel, de reikwijdte, de rollen, de verantwoordelijkheden, de betrokkenheid van het management en de coördinatie tussen organisatorische entiteiten), processen en procedures onderhouden en gebruikt om de bescherming van informatiesystemen en -middelen te beheren.", new Guid("e2bd0267-3f99-4489-8ad2-2de44411daba"), "Information Protection Processes and Procedures", 0, null },
                    { new Guid("ec6a2fcf-1182-4b0f-b5a9-93372fdbebfa"), null, null, null, "De herstelplanning en -processen worden verbeterd door geleerde lessen op te nemen in toekomstige activiteiten.", new Guid("3e6599ae-54c8-42c5-aa53-59f83bf20451"), "Improvements", 0, null },
                    { new Guid("ef029eb6-492f-4737-a1a7-3baa5c16a7be"), null, null, null, "De gegevens, het personeel, de apparaten, systemen en faciliteiten die de organisatie in staat stellen om bedrijfsdoeleinden te bereiken, worden geïdentificeerd en beheerd in overeenstemming met hun relatieve belang voor de doelstellingen van de organisatie en de risicostrategie van de organisatie.", new Guid("8b419820-3c3c-49da-bd0d-d20661f7fbb7"), "Asset Management", 0, null },
                    { new Guid("f1a7eb4a-6ed7-41fe-95a2-396a8d1a7c97"), null, null, null, "Organisatorische responsactiviteiten worden verbeterd door lessen te trekken uit huidige en eerdere detectie-/responsactiviteiten.", new Guid("8478e721-af59-45a8-87e2-b2f671860dbf"), "Improvements", 0, null }
                });

            migrationBuilder.InsertData(
                table: "MaturityLevels",
                columns: new[] { "Id", "Created", "Deleted", "Documentation", "Implementation", "Level", "MaturityId", "Updated", "Value" },
                values: new object[,]
                {
                    { new Guid("38a8d2df-56c5-40ef-bf49-3083a8250d17"), null, null, "Formally approved Process documentation exists, and exceptions are documented and approved. Documented & approved exceptions < 0,5% of the time.\r\n", "Formal process exists and is implemented. Evidence available for all activities. Detailed metrics of the process are captured and reported.\r\nMinimal target for metrics has been established and continually improving. Less than 1% of process exceptions.\"\r\n", "Optimizing", new Guid("c3ef7ab0-a332-4cce-9335-4f8de27f0c7d"), null, 5 },
                    { new Guid("4b36b3a4-e4fd-4814-8e87-73ebb11b3516"), null, null, "Formally approved Process documentation exists, and exceptions are documented and approved. Documented & approved exceptions < 3% of the time.\r\n", "Formal process exists and is implemented. Evidence available for all activities. Detailed metrics of the process are captured and reported.\r\nMinimal target for metrics has been established. Less than 5% of process exceptions.\"\r\n", "Managed", new Guid("c3ef7ab0-a332-4cce-9335-4f8de27f0c7d"), null, 4 },
                    { new Guid("73276242-ee96-4f55-8af5-8903af65adc5"), null, null, "No Process documentation or not formally approved by management.\r\n", "Standard process does not exist.\r\n", "Initial", new Guid("c3ef7ab0-a332-4cce-9335-4f8de27f0c7d"), null, 1 },
                    { new Guid("8aac6887-36df-4e0b-ae12-2852ef221838"), null, null, "Formally approved Process documentation exists, and exceptions are documented and approved. Documented & approved exceptions < 5% of the time.", "Formal process exists and is implemented. Evidence available for most activities. Less than 10% process exceptions.\r\n", "Defined", new Guid("c3ef7ab0-a332-4cce-9335-4f8de27f0c7d"), null, 3 },
                    { new Guid("a8114c4d-2771-492e-b778-21bab383bc09"), null, null, "Formally approved Process documentation exists but not reviewed in the previous 2 years.\r\n", "Ad-hoc process exists and is done informally.\r\n", "Repeatable", new Guid("c3ef7ab0-a332-4cce-9335-4f8de27f0c7d"), null, 2 }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Code", "Created", "Deleted", "Description", "Name", "Order", "Updated" },
                values: new object[,]
                {
                    { new Guid("01dcce94-ee8b-46e4-80e6-90faf582d7a3"), new Guid("44917305-0a39-43e6-b75e-6f58a709feb1"), null, null, null, "Derden belanghebbenden (bijv. leveranciers, klanten, partners) begrijpen hun rollen en verantwoordelijkheden", "PR.AT-3", 0, null },
                    { new Guid("086fdf24-147b-470a-a020-c353854fac17"), new Guid("9287ef1b-8b97-470d-8e62-8ba4c5db8df6"), null, null, null, "Coördinatie met belanghebbenden vindt plaats in overeenstemming met responsplannen", "RS.CO-4", 0, null },
                    { new Guid("0a228c5d-cb3e-4c1f-8cc5-ac4959e65865"), new Guid("f1a7eb4a-6ed7-41fe-95a2-396a8d1a7c97"), null, null, null, "Reactie- en herstelstrategieën worden bijgewerkt", "RS.IM-2", 0, null },
                    { new Guid("0a643c22-096b-430e-bfd8-b4462d987911"), new Guid("5bae836c-dd29-46f7-b36d-1ace1c5f4f3b"), null, null, null, "Prioriteiten voor de missie, doelstellingen en activiteiten van de organisatie worden vastgesteld en gecommuniceerd", "ID.BE-3", 0, null },
                    { new Guid("0aa22cca-6a88-434a-acd0-87320bf6ed01"), new Guid("d79a57e2-ffbc-4806-ac17-ca2122838265"), null, null, null, "Responsplannen (Incident Response en Business Continuity) en herstelplannen (Incident Recovery en Disaster Recovery) zijn aanwezig en worden beheerd", "PR.IP-9", 0, null },
                    { new Guid("0b8653b4-31ec-4b1b-97d1-12bf98202176"), new Guid("b1e6113e-2e82-4023-84d2-574c5dc83bfe"), null, null, null, "De organisatie bepaalt haar risicotolerantie op basis van haar rol in kritieke infrastructuur en sectorspecifieke risicoanalyse.", "ID.RM-3", 0, null },
                    { new Guid("0ede0199-74e9-4267-a3b3-e21e20315099"), new Guid("5e7f4af0-5d80-457c-a939-383eb2a06011"), null, null, null, "Data-in-transit is beschermd", "PR.DS-2", 0, null },
                    { new Guid("1784ecc7-28ef-4177-aa86-766b622fd56d"), new Guid("7509028d-3fb4-4840-9727-b4a03bdc6694"), null, null, null, "Incidenten worden gecategoriseerd in overeenstemming met responsplannen", "RS.AN-4", 0, null },
                    { new Guid("25fe7a69-817b-4f34-b3bf-9c5910987023"), new Guid("06b67f35-f459-4f1a-98db-e04b3f01d2b1"), null, null, null, "Herstelactiviteiten worden gecommuniceerd naar interne en externe belanghebbenden en naar uitvoerende en managementteams", "RC.CO-3", 0, null },
                    { new Guid("26e0fdd9-8f1a-4846-b38d-ea889a1f09df"), new Guid("06b67f35-f459-4f1a-98db-e04b3f01d2b1"), null, null, null, "Public relations worden beheerd", "RC.CO-1", 0, null },
                    { new Guid("26e631f3-3e1a-419e-a31f-6ddb9e8550a3"), new Guid("5e4c390e-eb7a-4a2e-9315-01027f7df135"), null, null, null, "Toegangsmachtigingen en autorisaties worden beheerd, waarbij de principes van 'least privilege' en scheiding van taken worden toegepast.", "PR.AC-4", 0, null },
                    { new Guid("27499ab6-7965-4b5e-8135-c43529ee2c85"), new Guid("8006ee9d-239a-4fc6-88e2-b0e1c4667449"), null, null, null, "Herstelactiviteiten worden gecommuniceerd naar interne en externe belanghebbenden en naar uitvoerende en managementteams", "RC.CO-3", 0, null },
                    { new Guid("2fbaaaeb-73eb-4a13-ac68-0bac833a5654"), new Guid("5e7f4af0-5d80-457c-a939-383eb2a06011"), null, null, null, "Activa worden formeel beheerd tijdens verwijdering, overdracht en vervreemding", "PR.DS-3", 0, null },
                    { new Guid("3133e865-76d7-4d37-8b52-dc5168397524"), new Guid("9287ef1b-8b97-470d-8e62-8ba4c5db8df6"), null, null, null, "Incidenten worden gerapporteerd volgens vastgestelde criteria", "RS.CO-2", 0, null },
                    { new Guid("317af496-8d3c-4d98-957a-3bab8a7869b6"), new Guid("5bae836c-dd29-46f7-b36d-1ace1c5f4f3b"), null, null, null, "Afhankelijkheden en kritieke functies voor de levering van kritieke diensten zijn vastgesteld", "ID.BE-4", 0, null },
                    { new Guid("3914c824-49bf-4e17-85f9-1e5d42aa6db5"), new Guid("ef029eb6-492f-4737-a1a7-3baa5c16a7be"), null, null, null, "Organisatiecommunicatie en gegevensstromen worden in kaart gebracht", "ID.AM-3", 0, null },
                    { new Guid("3b6a0d51-7b54-4da7-8344-80e350918ba4"), new Guid("863672b2-a93f-4635-b9e4-68901eff2fd8"), null, null, null, "Activiteit van externe serviceproviders wordt gemonitord om potentiële cyberbeveiligingsgebeurtenissen te detecteren", "DE.CM-6", 0, null },
                    { new Guid("3cc3764b-0ecc-454c-ab3d-527f0ad8fdff"), new Guid("3801fcc8-e6c4-46b5-b1a5-0a652bb265ce"), null, null, null, "Governance- en risicobeheerprocessen richten zich op cyberbeveiligingsrisico's", "ID.GV-4", 0, null },
                    { new Guid("418f320e-3338-4997-b056-70c2e5aaefc6"), new Guid("9287ef1b-8b97-470d-8e62-8ba4c5db8df6"), null, null, null, "Informatie wordt gedeeld in overeenstemming met responsplannen", "RS.CO-3", 0, null },
                    { new Guid("41bf3d46-41eb-4845-a2c5-4a7b6a61e0b1"), new Guid("cda5bbcc-4a24-456e-9240-dbbe0d92e0f0"), null, null, null, "Kwetsbaarheden van bedrijfsmiddelen worden geïdentificeerd en gedocumenteerd", "ID.RA-1", 0, null },
                    { new Guid("42168a35-9677-467e-b236-12cdbc293102"), new Guid("5e4c390e-eb7a-4a2e-9315-01027f7df135"), null, null, null, "Identiteiten en referenties worden uitgegeven, beheerd, geverifieerd, ingetrokken en gecontroleerd voor geautoriseerde apparaten, gebruikers en processen.", "PR.AC-1", 0, null },
                    { new Guid("42437ae7-a11b-43e7-b0b0-727a03763aab"), new Guid("ef029eb6-492f-4737-a1a7-3baa5c16a7be"), null, null, null, "Softwareplatformen, en applicaties die binnen de organisatie worden gebruikt, worden geïnventariseerd", "ID.AM-2", 0, null },
                    { new Guid("435fd1da-b1ca-423c-a55b-ac7a7cdd7ae6"), new Guid("64f2b22b-86d4-4d3b-a508-e9fe3db31d79"), null, null, null, "Leveranciers en externe partners worden routinematig beoordeeld met behulp van audits, testresultaten of andere vormen van evaluaties om te bevestigen dat ze aan hun contractuele verplichtingen voldoen.", "ID.SC-4", 0, null },
                    { new Guid("493f29d4-219f-4973-a992-2a253093df97"), new Guid("5e7f4af0-5d80-457c-a939-383eb2a06011"), null, null, null, "Voldoende capaciteit om de beschikbaarheid te garanderen", "PR.DS-4", 0, null },
                    { new Guid("49b8800f-2784-4879-a533-32ef56906460"), new Guid("28a61c29-b46e-4299-ab7f-31637fa3d5a2"), null, null, null, "Verwijderbare media worden beschermd en het gebruik ervan beperkt volgens het beleid", "PR.PT-2", 0, null },
                    { new Guid("4a753121-3083-4ee1-b559-8def9f6eef79"), new Guid("863672b2-a93f-4635-b9e4-68901eff2fd8"), null, null, null, "Personeelsactiviteiten worden gemonitord om potentiële cyberbeveiligingsgebeurtenissen te detecteren", "DE.CM-3", 0, null },
                    { new Guid("4af110de-df5c-4860-9e23-1c42ca7880ec"), new Guid("bab4a94d-3302-4842-81c1-0669596d71f2"), null, null, null, "Drempels voor incidentenwaarschuwing zijn vastgesteld", "DE.AE-5", 0, null },
                    { new Guid("51402878-da03-4352-a78b-7cba5fe77a7e"), new Guid("f1a7eb4a-6ed7-41fe-95a2-396a8d1a7c97"), null, null, null, "Reactie- en herstelplannen bevatten geleerde lessen", "RS.IM-1", 0, null },
                    { new Guid("53894f78-632a-40ac-a733-87ba4985fb0b"), new Guid("cda5bbcc-4a24-456e-9240-dbbe0d92e0f0"), null, null, null, "Bedreigingen, kwetsbaarheden, waarschijnlijkheden en gevolgen worden gebruikt om risico's te bepalen.", "ID.RA-5", 0, null },
                    { new Guid("59e10b84-0f23-46fe-af0a-a45a6e5e4b09"), new Guid("28a61c29-b46e-4299-ab7f-31637fa3d5a2"), null, null, null, "Het principe van de minste functionaliteit wordt toegepast door systemen zo te configureren dat ze alleen essentiële mogelijkheden bieden.", "PR.PT-3", 0, null },
                    { new Guid("5fb4725d-4f0f-4186-ba99-5d658e7cc2cf"), new Guid("28a61c29-b46e-4299-ab7f-31637fa3d5a2"), null, null, null, "Audit/logboekrecords worden bepaald, gedocumenteerd, geïmplementeerd en herzien in overeenstemming met het beleid", "PR.PT-1", 0, null },
                    { new Guid("5fddf469-60c2-4bb4-85e5-dda96cc63d99"), new Guid("cda5bbcc-4a24-456e-9240-dbbe0d92e0f0"), null, null, null, "Risicomaatregelen worden geïdentificeerd en geprioriteerd", "ID.RA-6", 0, null },
                    { new Guid("6053c1d4-8553-4c60-944a-9430c5f11e91"), new Guid("64f2b22b-86d4-4d3b-a508-e9fe3db31d79"), null, null, null, "Contracten met leveranciers en externe partners worden gebruikt om passende maatregelen te implementeren die zijn ontworpen om te voldoen aan de doelstellingen van het cyberbeveiligingsprogramma en het risicobeheerplan voor de cyberketen van een organisatie.", "ID.SC-3", 0, null },
                    { new Guid("617c65f6-1b81-4d4f-a830-75722588761c"), new Guid("d79a57e2-ffbc-4806-ac17-ca2122838265"), null, null, null, "Er wordt een basisconfiguratie van informatietechnologie/industriële besturingssystemen gemaakt en onderhouden, waarin beveiligingsprincipes zijn opgenomen (bijv. het concept van de minste functionaliteit).", "PR.IP-1", 0, null },
                    { new Guid("661dcb5f-c50a-4e86-9756-f11642f04945"), new Guid("d79a57e2-ffbc-4806-ac17-ca2122838265"), null, null, null, "Effectiviteit van beschermingstechnologieën wordt gedeeld", "PR.IP-8", 0, null },
                    { new Guid("666a0ea7-fcde-41da-99cd-c18055da0dc4"), new Guid("d79a57e2-ffbc-4806-ac17-ca2122838265"), null, null, null, "Er wordt een plan voor kwetsbaarheidsmanagement ontwikkeld en geïmplementeerd", "PR.IP-12", 0, null },
                    { new Guid("6732cd67-b996-46da-958c-8fe682677605"), new Guid("d79a57e2-ffbc-4806-ac17-ca2122838265"), null, null, null, "Er wordt voldaan aan beleid en voorschriften met betrekking tot de fysieke werkomgeving voor bedrijfsmiddelen van de organisatie.", "PR.IP-5", 0, null },
                    { new Guid("67b4b6b2-bc9c-4515-be2a-49a80d84d3b3"), new Guid("d79a57e2-ffbc-4806-ac17-ca2122838265"), null, null, null, "Cyberbeveiliging is opgenomen in HR-praktijken (bijv. deprovisionering, personeelsscreening)", "PR.IP-11", 0, null },
                    { new Guid("684cf7ac-a109-4a4d-9dc2-a1c71ea79e85"), new Guid("863672b2-a93f-4635-b9e4-68901eff2fd8"), null, null, null, "Kwetsbaarheidsscans worden uitgevoerd", "DE.CM-8", 0, null },
                    { new Guid("68e8222c-1314-4a1c-85d5-734c50861917"), new Guid("5e4c390e-eb7a-4a2e-9315-01027f7df135"), null, null, null, "Gebruikers, apparaten en andere middelen worden geverifieerd (bijv. single-factor, multi-factor) in overeenstemming met het risico van de transactie (bijv. de veiligheids- en privacyrisico's van individuen en andere organisatorische risico's).", "PR.AC-7", 0, null },
                    { new Guid("6bbd77b2-dbac-46de-9ea5-b2bdb6b7498b"), new Guid("863672b2-a93f-4635-b9e4-68901eff2fd8"), null, null, null, "Er wordt gecontroleerd op onbevoegd personeel, verbindingen, apparaten en software", "DE.CM-7", 0, null },
                    { new Guid("6cb36feb-357a-4765-be60-0ab066c940b9"), new Guid("863672b2-a93f-4635-b9e4-68901eff2fd8"), null, null, null, "Het netwerk wordt bewaakt om potentiële cyberbeveiligingsgebeurtenissen te detecteren", "DE.CM-1", 0, null },
                    { new Guid("6fb97b52-5261-4f7b-bd7c-c12e0d829581"), new Guid("5e4c390e-eb7a-4a2e-9315-01027f7df135"), null, null, null, "Netwerkintegriteit wordt beschermd (bijv. netwerksegregatie, netwerksegmentatie)", "PR.AC-5", 0, null },
                    { new Guid("729ba903-5401-4d65-acd0-c2c47e8ff432"), new Guid("d79a57e2-ffbc-4806-ac17-ca2122838265"), null, null, null, "Back-ups van informatie worden uitgevoerd, onderhouden en getest", "PR.IP-4", 0, null },
                    { new Guid("76d76243-4d8a-4a15-a50b-6e285c4cf9a8"), new Guid("7e4d0bc6-a3f9-4afc-9877-3cb27f25558f"), null, null, null, "Detectieprocessen worden voortdurend verbeterd", "DE.DP-5", 0, null },
                    { new Guid("785ecadb-c81c-4df7-b2c0-254b934bd67d"), new Guid("64f2b22b-86d4-4d3b-a508-e9fe3db31d79"), null, null, null, "Reactie- en herstelplanning en tests worden uitgevoerd met leveranciers en externe leveranciers", "ID.SC-5", 0, null },
                    { new Guid("789e3806-59f9-40fc-9b04-d15bfe0d475e"), new Guid("ef029eb6-492f-4737-a1a7-3baa5c16a7be"), null, null, null, "Hulpbronnen (bijv. hardware, apparaten, gegevens, tijd, personeel en software) worden geprioriteerd op basis van hun classificatie, kriticiteit en bedrijfswaarde.", "ID.AM-5", 0, null },
                    { new Guid("796530ad-fb7d-42b4-bb1f-5f73f2395187"), new Guid("3801fcc8-e6c4-46b5-b1a5-0a652bb265ce"), null, null, null, "Het cyberbeveiligingsbeleid van de organisatie wordt vastgesteld en gecommuniceerd", "ID.GV-1", 0, null },
                    { new Guid("7abac9f5-9cab-4a6c-a5c2-7dd9df84eb49"), new Guid("863672b2-a93f-4635-b9e4-68901eff2fd8"), null, null, null, "De fysieke omgeving wordt bewaakt om potentiële cyberbeveiligingsgebeurtenissen te detecteren", "DE.CM-2", 0, null },
                    { new Guid("7fc2d049-ae03-4bf5-a820-850e39d28a11"), new Guid("cda5bbcc-4a24-456e-9240-dbbe0d92e0f0"), null, null, null, "Informatie over cyberdreigingen wordt ontvangen van forums en bronnen waar informatie wordt gedeeld", "ID.RA-2", 0, null },
                    { new Guid("845ba1e2-92ae-4e74-8807-b5c3739837bf"), new Guid("ef029eb6-492f-4737-a1a7-3baa5c16a7be"), null, null, null, "Externe informatiesystemen worden gecatalogiseerd", "ID.AM-4", 0, null },
                    { new Guid("850fb561-fddf-46f7-98d4-153b2ea417db"), new Guid("5e7f4af0-5d80-457c-a939-383eb2a06011"), null, null, null, "Beveiligingen tegen datalekken worden geïmplementeerd", "PR.DS-5", 0, null },
                    { new Guid("8817eb51-dad1-4bf4-9c49-3de0f05e9781"), new Guid("44917305-0a39-43e6-b75e-6f58a709feb1"), null, null, null, "Fysiek en cyberbeveiligingspersoneel begrijpen hun rollen en verantwoordelijkheden", "PR.AT-5", 0, null },
                    { new Guid("89ba35da-545d-4ca6-9691-65b6af9f178a"), new Guid("7509028d-3fb4-4840-9727-b4a03bdc6694"), null, null, null, "Er zijn processen vastgesteld om kwetsbaarheden te ontvangen, te analyseren en te reageren op kwetsbaarheden die door interne en externe bronnen (bijv. interne tests, beveiligingsbulletins of beveiligingsonderzoekers) aan de organisatie worden doorgegeven.", "RS.AN-5", 0, null },
                    { new Guid("8e2969d1-715d-4b15-82be-3300f6ff0083"), new Guid("d79a57e2-ffbc-4806-ac17-ca2122838265"), null, null, null, "Er wordt een System Development Life Cycle geïmplementeerd om systemen te beheren.", "PR.IP-2", 0, null },
                    { new Guid("90ad6f58-f654-48c5-a0be-106386b116e6"), new Guid("5bae836c-dd29-46f7-b36d-1ace1c5f4f3b"), null, null, null, "De plaats van de organisatie in kritieke infrastructuur en haar bedrijfstak wordt geïdentificeerd en gecommuniceerd", "ID.BE-2", 0, null },
                    { new Guid("90dd6047-fea2-4dcb-80e4-691b1e45e787"), new Guid("44917305-0a39-43e6-b75e-6f58a709feb1"), null, null, null, "Alle gebruikers zijn geïnformeerd en getraind", "PR.AT-1", 0, null },
                    { new Guid("925805d3-63c2-47c3-ba5d-5e444ff52806"), new Guid("d79a57e2-ffbc-4806-ac17-ca2122838265"), null, null, null, "Gegevens worden vernietigd volgens beleid", "PR.IP-6", 0, null },
                    { new Guid("94776ff4-977c-43b2-b3d1-7ef530c99897"), new Guid("ef029eb6-492f-4737-a1a7-3baa5c16a7be"), null, null, null, "Cyberbeveiligingsrollen, -verantwoordelijkheden en -bevoegdheden voor het voltallige personeel en externe belanghebbenden zijn vastgesteld.", "ID.AM-6", 0, null },
                    { new Guid("97947d2f-c55c-4e94-ae76-1686cff0bc76"), new Guid("9287ef1b-8b97-470d-8e62-8ba4c5db8df6"), null, null, null, "Personeel kent hun rol en volgorde van handelen wanneer een reactie nodig is", "RS.CO-1", 0, null },
                    { new Guid("a0fa7fcc-fc6f-4dcb-9171-c8a32e78e9f0"), new Guid("bab4a94d-3302-4842-81c1-0669596d71f2"), null, null, null, "Gebeurtenisgegevens worden verzameld en gecorreleerd vanuit meerdere bronnen en sensoren", "DE.AE-3", 0, null },
                    { new Guid("a203602b-8c86-4082-81f3-d3d8b94d0d3f"), new Guid("7509028d-3fb4-4840-9727-b4a03bdc6694"), null, null, null, "De gevolgen van het incident worden begrepen", "RS.AN-2", 0, null },
                    { new Guid("a46a0859-4d42-4d96-8de1-96c89964b0aa"), new Guid("44917305-0a39-43e6-b75e-6f58a709feb1"), null, null, null, "Bevoegde gebruikers begrijpen hun rollen en verantwoordelijkheden", "PR.AT-2", 0, null },
                    { new Guid("a73bc22a-1df7-40c1-856f-6ce8268ccab0"), new Guid("d79a57e2-ffbc-4806-ac17-ca2122838265"), null, null, null, "Beschermingsprocessen worden verbeterd", "PR.IP-7", 0, null },
                    { new Guid("af66ffe2-484a-4a62-ab44-e9a815c11975"), new Guid("ef029eb6-492f-4737-a1a7-3baa5c16a7be"), null, null, null, "Fysieke apparaten en systemen die binnen de organisatie worden gebruikt, worden geïnventariseerd", "ID.AM-1", 0, null },
                    { new Guid("afead7a6-5602-46a1-b658-c89da02cc410"), new Guid("b1e6113e-2e82-4023-84d2-574c5dc83bfe"), null, null, null, "Risicomaatregelen worden geïdentificeerd en geprioriteerd", "ID.RM-1", 0, null },
                    { new Guid("b0b53253-ef34-48f3-a3c1-12c10a22e2fe"), new Guid("5e7f4af0-5d80-457c-a939-383eb2a06011"), null, null, null, "Gegevens in rust zijn beschermd", "PR.DS-1", 0, null },
                    { new Guid("b0ed9db4-df1a-4762-81e5-f7757cd6b6f0"), new Guid("863672b2-a93f-4635-b9e4-68901eff2fd8"), null, null, null, "Ongeautoriseerde mobiele code gedetecteerd", "DE.CM-5", 0, null },
                    { new Guid("b44f429e-11a2-4ed9-81bc-6f280ce4dc01"), new Guid("8006ee9d-239a-4fc6-88e2-b0e1c4667449"), null, null, null, "Herstelactiviteiten worden gecommuniceerd naar interne en externe belanghebbenden en naar uitvoerende en managementteams", "RC.CO-3", 0, null },
                    { new Guid("b77a5822-cf0d-41ea-9c7b-6ea2a8527fc7"), new Guid("5bae836c-dd29-46f7-b36d-1ace1c5f4f3b"), null, null, null, "De veerkrachtvereisten ter ondersteuning van de levering van kritieke diensten zijn vastgesteld voor alle operationele toestanden (bijv. onder dwang/aanval, tijdens herstel, normale activiteiten).", "ID.BE-5", 0, null },
                    { new Guid("bacffee8-7711-4d3a-baca-bfd72e1c8d86"), new Guid("44917305-0a39-43e6-b75e-6f58a709feb1"), null, null, null, "Senior managers begrijpen hun rollen en verantwoordelijkheden", "PR.AT-4", 0, null },
                    { new Guid("bc1163e7-b953-474a-bcf4-ea836d345f1b"), new Guid("5e4c390e-eb7a-4a2e-9315-01027f7df135"), null, null, null, "Identiteiten zijn bewezen en gebonden aan referenties en worden bevestigd in interacties", "PR.AC-6", 0, null },
                    { new Guid("bc6eb7e0-2b73-4230-984a-0f72f58dfb9b"), new Guid("5e7f4af0-5d80-457c-a939-383eb2a06011"), null, null, null, "De ontwikkel- en testomgeving(en) zijn gescheiden van de productieomgeving", "PR.DS-7", 0, null },
                    { new Guid("bd2d05ad-a7fd-4600-b3cb-57ca0a898522"), new Guid("3801fcc8-e6c4-46b5-b1a5-0a652bb265ce"), null, null, null, "Wettelijke en regelgevende vereisten met betrekking tot cyberbeveiliging, inclusief verplichtingen op het gebied van privacy en burgerlijke vrijheden, worden begrepen en beheerd.", "ID.GV-3", 0, null },
                    { new Guid("bd904c29-6c9d-482e-805e-38d96e6b2b5a"), new Guid("ec6a2fcf-1182-4b0f-b5a9-93372fdbebfa"), null, null, null, "Herstelplannen bevatten geleerde lessen", "RC.IM-1", 0, null },
                    { new Guid("bf66f918-a1e7-405f-9f8a-d7e97614f4ea"), new Guid("8afc2316-2097-4601-aeab-28cb9a91df4a"), null, null, null, "Onderhoud en reparatie van bedrijfsmiddelen van de organisatie worden uitgevoerd en geregistreerd met goedgekeurde en gecontroleerde gereedschappen.", "PR.MA-1", 0, null },
                    { new Guid("c3bf6957-2760-4588-9061-957d8d1582ec"), new Guid("9287ef1b-8b97-470d-8e62-8ba4c5db8df6"), null, null, null, "Er wordt op vrijwillige basis informatie gedeeld met externe belanghebbenden om een breder situationeel bewustzijn van cyberbeveiliging te creëren.", "RS.CO-5", 0, null },
                    { new Guid("c5d70d13-a151-401d-a5e1-194453ec1b1b"), new Guid("7e4d0bc6-a3f9-4afc-9877-3cb27f25558f"), null, null, null, "Informatie over gebeurtenisdetectie wordt doorgegeven", "DE.DP-4", 0, null },
                    { new Guid("c612bb8a-f863-486f-9922-8540aa852aeb"), new Guid("bab4a94d-3302-4842-81c1-0669596d71f2"), null, null, null, "Gedetecteerde gebeurtenissen worden geanalyseerd om aanvalsdoelen en -methoden te begrijpen", "DE.AE-2", 0, null },
                    { new Guid("c72ac299-ff0c-4dbf-8133-c6938665fc29"), new Guid("06b67f35-f459-4f1a-98db-e04b3f01d2b1"), null, null, null, "Herstelactiviteiten worden gecommuniceerd naar interne en externe belanghebbenden en naar uitvoerende en managementteams", "RC.CO-3", 0, null },
                    { new Guid("c86d062f-5b15-4f8b-8ed0-de02213bff8b"), new Guid("8afc2316-2097-4601-aeab-28cb9a91df4a"), null, null, null, "Onderhoud op afstand van bedrijfsmiddelen wordt goedgekeurd, vastgelegd en uitgevoerd op een manier die onbevoegde toegang voorkomt.", "PR.MA-2", 0, null },
                    { new Guid("ccce8cfe-d8f8-4098-9e98-62f5c884f0c6"), new Guid("625db872-cda7-41f9-8f33-5675811e0291"), null, null, null, "Herstelplan wordt uitgevoerd tijdens of na een cyberbeveiligingsincident", "RC.RP-1", 0, null },
                    { new Guid("cdcfa6b7-03e0-4a47-9eb0-4b80f7c94c76"), new Guid("5931d80f-dd54-49b8-a856-0121f4ff126a"), null, null, null, "Responsplan wordt uitgevoerd tijdens of na een incident", "RS.RP-1", 0, null },
                    { new Guid("d02c37a5-ceb7-4053-bc36-d8a9ac49e5f5"), new Guid("d79a57e2-ffbc-4806-ac17-ca2122838265"), null, null, null, "Er zijn processen voor het beheren van configuratiewijzigingen", "PR.IP-3", 0, null },
                    { new Guid("d4d8ca3b-86c5-45bc-b772-c39e0d6f4e82"), new Guid("7e4d0bc6-a3f9-4afc-9877-3cb27f25558f"), null, null, null, "Detectieprocessen worden getest", "DE.DP-3", 0, null },
                    { new Guid("d60c7720-c8fe-4417-a7a4-8dab71c29cc2"), new Guid("8006ee9d-239a-4fc6-88e2-b0e1c4667449"), null, null, null, "Public relations worden beheerd", "RC.CO-1", 0, null },
                    { new Guid("dc4a92eb-72df-46ec-865b-579e9e8a3a99"), new Guid("7509028d-3fb4-4840-9727-b4a03bdc6694"), null, null, null, "Meldingen van detectiesystemen worden onderzocht", "RS.AN-1", 0, null },
                    { new Guid("e1d70bf8-aee9-4a80-8ef4-65a456d442e7"), new Guid("5bae836c-dd29-46f7-b36d-1ace1c5f4f3b"), null, null, null, "De rol van de organisatie in de toeleveringsketen wordt geïdentificeerd en gecommuniceerd", "ID.BE-1", 0, null },
                    { new Guid("e3a8bb57-9e6a-4c86-8b50-0e3107954861"), new Guid("7e4d0bc6-a3f9-4afc-9877-3cb27f25558f"), null, null, null, "Detectieactiviteiten voldoen aan alle toepasselijke vereisten", "DE.DP-2", 0, null },
                    { new Guid("eb5d9410-4f4d-4f9f-a419-601aabb485c0"), new Guid("28a61c29-b46e-4299-ab7f-31637fa3d5a2"), null, null, null, "Communicatie- en besturingsnetwerken worden beschermd", "PR.PT-4", 0, null },
                    { new Guid("ec20edd4-c8bc-4d2d-b59b-596c75ab31f7"), new Guid("64f2b22b-86d4-4d3b-a508-e9fe3db31d79"), null, null, null, "Leveranciers en externe partners van informatiesystemen, onderdelen en diensten worden geïdentificeerd, geprioriteerd en beoordeeld met behulp van een proces voor de beoordeling van cyberrisico's in de toeleveringsketen.", "ID.SC-2", 0, null },
                    { new Guid("f27a2a5d-0955-4081-a5dd-9f7ed84b5ff1"), new Guid("5e4c390e-eb7a-4a2e-9315-01027f7df135"), null, null, null, "Fysieke toegang tot bedrijfsmiddelen wordt beheerd en beschermd", "PR.AC-2", 0, null },
                    { new Guid("f38eb798-d297-49c1-a9e6-a1e870ed4746"), new Guid("5e4c390e-eb7a-4a2e-9315-01027f7df135"), null, null, null, "Toegang op afstand wordt beheerd", "PR.AC-3", 0, null },
                    { new Guid("f6a36400-ca59-4349-bb8c-d429cb7fbb30"), new Guid("b1e6113e-2e82-4023-84d2-574c5dc83bfe"), null, null, null, "Organisatorische risicotolerantie wordt bepaald en duidelijk uitgedrukt", "ID.RM-2", 0, null },
                    { new Guid("f6b08eee-6470-475c-9808-f5d0f2f19c81"), new Guid("7374fa62-6392-4a5a-8249-66a4f046a6c4"), null, null, null, "Incidenten zijn onder controle", "RS.MI-1", 0, null },
                    { new Guid("f8b75ba9-2494-42f8-8ea3-d594c6fcdb03"), new Guid("863672b2-a93f-4635-b9e4-68901eff2fd8"), null, null, null, "Kwaadaardige code is gedetecteerd", "DE.CM-4", 0, null },
                    { new Guid("f9d4a042-f9b5-40da-b8ac-2dc00c372e90"), new Guid("5e7f4af0-5d80-457c-a939-383eb2a06011"), null, null, null, "Integriteitscontrolemechanismen worden gebruikt om de integriteit van software, firmware en informatie te controleren.", "PR.DS-6", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Requirements",
                columns: new[] { "Id", "Code", "Created", "Deleted", "Description", "Name", "Order", "SubCategoryId", "Updated" },
                values: new object[,]
                {
                    { new Guid("02a2636e-bb97-42c9-ac41-8b53ad34e926"), null, null, null, "De netwerken van de organisatie die op afstand worden benaderd, moeten worden beveiligd, onder andere door middel van multifactorauthenticatie (MFA).", "PR.AC-3.2", 0, new Guid("f38eb798-d297-49c1-a9e6-a1e870ed4746"), null },
                    { new Guid("0335913a-3733-4216-8e37-df1f9e81589c"), null, null, null, "De organisatie moet waarschuwingsdrempels voor incidenten definiëren.", "DE.AE-5.2", 0, new Guid("4af110de-df5c-4860-9e23-1c42ca7880ec"), null },
                    { new Guid("06c6d590-9a6b-49a7-8f7c-7c8882a90f80"), null, null, null, "Een inventaris die weergeeft welke softwareplatforms en applicaties in de organisatie worden gebruikt, moet worden gedocumenteerd, herzien en bijgewerkt wanneer zich wijzigingen voordoen.", "ID.AM-2.1", 0, new Guid("42437ae7-a11b-43e7-b0b0-727a03763aab"), null },
                    { new Guid("07aa7dcf-b076-4486-a4ff-49da360f0f7e"), null, null, null, "De organisatie moet de belangrijkste medewerkers van leveranciers en externe partners identificeren en documenteren om hen als belanghebbenden te betrekken bij de reactie- en herstelplanningsactiviteiten.", "ID.SC-5.1", 0, new Guid("785ecadb-c81c-4df7-b2c0-254b934bd67d"), null },
                    { new Guid("0cda7da3-ce44-4e3e-b795-b15192da670c"), null, null, null, "Waar mogelijk worden geautomatiseerde mechanismen geïmplementeerd ter ondersteuning van het beheer van gebruikersaccounts op de kritieke systemen van de organisatie, waaronder het uitschakelen, bewaken, rapporteren en verwijderen van gebruikersaccounts.", "PR.AC-4.5", 0, new Guid("26e631f3-3e1a-419e-a31f-6ddb9e8550a3"), null },
                    { new Guid("0ecd9acc-c8cf-46ae-9a8c-517e2502ae9b"), null, null, null, "De organisatie moet alle externe services en de verbindingen die ermee zijn gemaakt in kaart brengen, documenteren, autoriseren en bij wijzigingen bijwerken.", "ID.AM-4.1", 0, new Guid("845ba1e2-92ae-4e74-8807-b5c3739837bf"), null },
                    { new Guid("0f7438bd-13bd-428e-8ff2-a67280c32269"), null, null, null, "Firewalls moeten worden geïnstalleerd en geactiveerd op alle netwerken van de organisatie.", "PR.AC-5.1", 0, new Guid("6fb97b52-5261-4f7b-bd7c-c12e0d829581"), null },
                    { new Guid("10c03946-eb67-42d4-8923-458e549034b2"), null, null, null, "De organisatie onderzoekt informatie-/cyberbeveiligingsmeldingen van detectiesystemen.", "RS.AN-1.1", 0, new Guid("dc4a92eb-72df-46ec-865b-579e9e8a3a99"), null },
                    { new Guid("145e39ac-1fca-4300-95c3-43bbf1cf9e1b"), null, null, null, "De fysieke toegang tot de faciliteit, servers en netwerkcomponenten moet worden beheerd.", "PR.AC-2.1", 0, new Guid("f27a2a5d-0955-4081-a5dd-9f7ed84b5ff1"), null },
                    { new Guid("18c8772b-3f71-46e8-bf36-6ab56406768d"), null, null, null, "De organisatie moet ervoor zorgen dat personeel dat verantwoordelijk is voor de fysieke bescherming en beveiliging van de kritieke systemen en faciliteiten van de organisatie gekwalificeerd is door middel van training voordat privileges worden verleend, en dat zij hun verantwoordelijkheden begrijpen.", "PR.AT-5.1", 0, new Guid("8817eb51-dad1-4bf4-9c49-3de0f05e9781"), null },
                    { new Guid("1d87df4a-f585-460c-8f0f-273e10d8662c"), null, null, null, "Back-ups voor bedrijfskritische gegevens van de organisatie moeten worden uitgevoerd en opgeslagen op een ander systeem dan het apparaat waarop de oorspronkelijke gegevens staan.", "PR.IP-4.1", 0, new Guid("729ba903-5401-4d65-acd0-c2c47e8ff432"), null },
                    { new Guid("1f97efce-fd8c-41df-ab78-4029f764c7c3"), null, null, null, "Alle verbindingen binnen de ICT/OT-omgeving van de organisatie en met andere interne platforms van de organisatie moeten in kaart worden gebracht, gedocumenteerd, goedgekeurd en waar nodig bijgewerkt.", "ID.AM-3.2", 0, new Guid("3914c824-49bf-4e17-85f9-1e5d42aa6db5"), null },
                    { new Guid("202d9075-f666-4777-b33a-efc65b22544d"), null, null, null, "De organisatie moet ervoor zorgen dat sterke authenticators, registratie en sessiebeëindiging voor onderhoud op afstand worden geïmplementeerd.", "PR.MA-2.2", 0, new Guid("c86d062f-5b15-4f8b-8ed0-de02213bff8b"), null },
                    { new Guid("2161558c-cd37-4dad-a0a9-b4b28548af8d"), null, null, null, "Verbeteringen die voortkomen uit het monitoren, meten, beoordelen, testen, beoordelen en geleerde lessen worden opgenomen in herzieningen van detectieprocessen.", "DE.DP-5.1", 0, new Guid("76d76243-4d8a-4a15-a50b-6e285c4cf9a8"), null },
                    { new Guid("22018490-c992-4f79-a1e9-621f47de08f2"), null, null, null, "Informatiebeveiligings- en cyberbeveiligingsrisico's worden gedocumenteerd, formeel goedgekeurd en bijgewerkt wanneer zich wijzigingen voordoen.", "ID.GV-4.2", 0, new Guid("3cc3764b-0ecc-454c-ab3d-527f0ad8fdff"), null },
                    { new Guid("2802dac3-abc9-4f1c-a13e-04feb37312d0"), null, null, null, "Grondig onderzoek en analyse van de resultaten vormen de basis voor een volledig begrip van de gevolgen van het informatie-/cyberbeveiligingsincident.", "RS.AN-2.1", 0, new Guid("a203602b-8c86-4082-81f3-d3d8b94d0d3f"), null },
                    { new Guid("28425c69-ee30-4391-94ac-2275b495953b"), null, null, null, "Onderhoud op afstand mag alleen plaatsvinden na voorafgaande goedkeuring, toezicht om onbevoegde toegang te voorkomen en goedkeuring van het resultaat van de onderhoudsactiviteiten zoals beschreven in goedgekeurde processen of procedures.", "PR.MA-2.1", 0, new Guid("c86d062f-5b15-4f8b-8ed0-de02213bff8b"), null },
                    { new Guid("2f3b0156-e700-4f9b-b811-c9fc8e3b9983"), null, null, null, "De organisatie moet een basisconfiguratie voor de bedrijfskritische systemen ontwikkelen, documenteren en onderhouden.", "PR.IP-1.1", 0, new Guid("617c65f6-1b81-4d4f-a830-75722588761c"), null },
                    { new Guid("30beda5b-e5c9-4824-9244-7d7a30eb36e4"), null, null, null, "De toegang van werknemers tot gegevens en informatie wordt beperkt tot de systemen en specifieke informatie die ze nodig hebben om hun werk te doen (het principe van Least Privilege).", "PR.AC-4.3", 0, new Guid("26e631f3-3e1a-419e-a31f-6ddb9e8550a3"), null },
                    { new Guid("30c87d88-07bc-4eca-80e8-4bc0eafd5832"), null, null, null, "Er moet een bewustwordingsprogramma voor bedreigingen en kwetsbaarheden worden geïmplementeerd dat de mogelijkheid omvat om informatie uit te wisselen tussen organisaties.", "ID.RA-2.1", 0, new Guid("7fc2d049-ae03-4bf5-a820-850e39d28a11"), null },
                    { new Guid("3200da24-45bd-409f-aecc-83621509430d"), null, null, null, "De organisatie controleert leveranciers en gebruikers van bedrijfskritische diensten op naleving van de beveiligingseisen.", "PR.AT-3.3", 0, new Guid("01dcce94-ee8b-46e4-80e6-90faf582d7a3"), null },
                    { new Guid("376d4cb0-a301-473f-8440-a0f70fd247d8"), null, null, null, "De organisatie moet, waar mogelijk, geautomatiseerde mechanismen implementeren om te helpen bij de samenwerking op het gebied van informatie.", "PR.IP-8.3", 0, new Guid("661dcb5f-c50a-4e86-9756-f11642f04945"), null },
                    { new Guid("3aa38a96-60fe-4be5-8879-feac48e0fb5a"), null, null, null, "De organisatie moet beveiligingseisen opstellen en afdwingen voor bedrijfskritieke externe leveranciers en gebruikers.", "PR.AT-3.1", 0, new Guid("01dcce94-ee8b-46e4-80e6-90faf582d7a3"), null },
                    { new Guid("3c04e88c-d09c-4f14-8cc6-a6eec9951110"), null, null, null, "Er moet een allesomvattende strategie worden ontwikkeld en geïmplementeerd om de risico's voor de kritieke systemen van de organisatie te beheren, inclusief de identificatie en prioritering van risicomaatregelen.", "ID.RA-6.1", 0, new Guid("5fddf469-60c2-4bb4-85e5-dda96cc63d99"), null },
                    { new Guid("3c46adcc-f5a0-4a8d-839b-eedaac675da3"), null, null, null, "Informatie die de organisatie opslaat en gebruikt, moet worden geïdentificeerd.", "ID.AM-3.1", 0, new Guid("3914c824-49bf-4e17-85f9-1e5d42aa6db5"), null },
                    { new Guid("3ccbd637-81fe-4b9d-ad60-9aefac6b08af"), null, null, null, "De organisatie moet herstelactiviteiten communiceren aan vooraf gedefinieerde belanghebbenden, uitvoerende en managementteams.", "RC.CO-3.1", 0, new Guid("c72ac299-ff0c-4dbf-8133-c6938665fc29"), null },
                    { new Guid("3fc4f31a-edc4-42f8-96b8-a69132b9e15f"), null, null, null, "De gebruiksbeperking van draagbare opslagmedia moet worden gewaarborgd door middel van een geschikt gedocumenteerd beleid en ondersteunende waarborgen.", "PR.PT-2.1", 0, new Guid("49b8800f-2784-4879-a533-32ef56906460"), null },
                    { new Guid("403ab9e6-5a0a-40f0-8583-8c89eb1f4491"), null, null, null, "Logboeken moeten worden bijgehouden, gedocumenteerd en herzien.", "PR.PT-1.1", 0, new Guid("5fb4725d-4f0f-4186-ba99-5d658e7cc2cf"), null },
                    { new Guid("4059d999-9c22-4547-8c9c-95e88adb6723"), null, null, null, "Eindpunt- en netwerkbeschermingstools om het gedrag van eindgebruikers te controleren op gevaarlijke activiteiten moeten worden geïmplementeerd.", "DE.CM-3.1", 0, new Guid("4a753121-3083-4ee1-b559-8def9f6eef79"), null },
                    { new Guid("4159f5bb-0341-45cc-b030-59ff87b60df5"), null, null, null, "De organisatie moet software-, firmware- en informatie-integriteitscontroles implementeren om ongeautoriseerde wijzigingen in de kritieke systeemcomponenten tijdens opslag, transport en opstarten te detecteren en wanneer dit nodig is.", "PR.DS-6.1", 0, new Guid("f9d4a042-f9b5-40da-b8ac-2dc00c372e90"), null },
                    { new Guid("4260aae0-adfb-40e6-925c-e136be4787c5"), null, null, null, "De organisatie moet preventief onderhoud en reparaties aan haar kritieke systeemonderdelen plannen, uitvoeren en documenteren volgens goedgekeurde processen en hulpmiddelen.", "PR.MA-1.2", 0, new Guid("bf66f918-a1e7-405f-9f8a-d7e97614f4ea"), null },
                    { new Guid("4261c7e8-6508-4115-a9be-243af6e3094d"), null, null, null, "De organisatie moet herstelactiviteiten communiceren aan vooraf gedefinieerde belanghebbenden, uitvoerende en managementteams.", "RC.CO-3.1", 0, new Guid("b44f429e-11a2-4ed9-81bc-6f280ce4dc01"), null },
                    { new Guid("42996787-8944-4927-8dcf-e056e317086c"), null, null, null, "Een informatie- en cyberbeveiligingsproces voor personeelszaken ontwikkelen en onderhouden dat van toepassing is bij het werven, tijdens het dienstverband en bij beëindiging van het dienstverband.", "PR.IP-11.2", 0, new Guid("67b4b6b2-bc9c-4515-be2a-49a80d84d3b3"), null },
                    { new Guid("47662575-05b1-4554-9375-84ebe0f80765"), null, null, null, "De organisatie moet verantwoordelijkheid nastreven voor alle bedrijfskritische activa tijdens het systeemlevenscyclus, inclusief het verwijderen, overdragen en afstoting.", "PR.DS-3.2", 0, new Guid("2fbaaaeb-73eb-4a13-ac68-0bac833a5654"), null },
                    { new Guid("47a30efd-c2b5-45e2-b709-a99280db0eec"), null, null, null, "Firewalls moeten worden geïnstalleerd en gebruikt op de netwerkgrenzen en worden aangevuld met firewallbescherming op de eindpunten.", "DE.CM-1.1", 0, new Guid("6cb36feb-357a-4765-be60-0ab066c940b9"), null },
                    { new Guid("4b0a3a76-d226-4110-8c22-6daf6700cbe7"), null, null, null, "De organisatie dient acceptabele en onacceptabele mobiele code en mobiele code technologieën te definiëren; en het gebruik van mobiele code binnen het systeem te autoriseren, monitoren en controleren.", "DE.CM-5.1", 0, new Guid("b0ed9db4-df1a-4762-81e5-f7757cd6b6f0"), null },
                    { new Guid("4db82042-193f-44b3-8068-589ea892b53c"), null, null, null, "Wanneer ongeautoriseerde hardware wordt gedetecteerd, wordt deze in quarantaine geplaatst voor mogelijke uitzonderingsbehandeling, verwijderd of vervangen en wordt de inventaris bijgewerkt.", "ID.AM-1.3", 0, new Guid("af66ffe2-484a-4a62-ab44-e9a815c11975"), null },
                    { new Guid("529efbcb-5e65-45a6-b77d-beade0537ba6"), null, null, null, "Antivirus-, -spyware- en andere -malwareprogramma's moeten worden geïnstalleerd en bijgewerkt.", "DE.CM-4.1", 0, new Guid("f8b75ba9-2494-42f8-8ea3-d594c6fcdb03"), null },
                    { new Guid("541ed410-49ea-4ecf-9270-a6bd12de6643"), null, null, null, "De naleving door externe dienstverleners van het beleid en de procedures voor de beveiliging van het personeel en de beveiligingseisen van het contract worden gecontroleerd met betrekking tot hun risico's op het gebied van cyberbeveiliging.", "DE.CM-6.2", 0, new Guid("3b6a0d51-7b54-4da7-8344-80e350918ba4"), null },
                    { new Guid("542fd482-7633-4dd0-800b-35a921128aa0"), null, null, null, "De organisatie deelt informatie/informatie over cyberbeveiligingsincidenten vrijwillig, indien van toepassing, met externe belanghebbenden, beveiligingsgroepen uit de branche, om een breder situationeel bewustzijn van informatie/cyberbeveiliging te bereiken.", "RS.CO-5.1", 0, new Guid("c3bf6957-2760-4588-9061-957d8d1582ec"), null },
                    { new Guid("5676fcf1-cde8-414d-8893-afdfb5319d5e"), null, null, null, "Er wordt een herstelproces voor rampen en informatie-/cyberbeveiligingsincidenten ontwikkeld en zo nodig uitgevoerd.", "RC.RP-1.1", 0, new Guid("ccce8cfe-d8f8-4098-9e98-62f5c884f0c6"), null },
                    { new Guid("56eb139f-5a69-4c1f-8152-342eddfc9bd0"), null, null, null, "Patches en beveiligingsupdates voor besturingssystemen en kritieke systeemonderdelen moeten worden geïnstalleerd.", "PR.MA-1.1", 0, new Guid("bf66f918-a1e7-405f-9f8a-d7e97614f4ea"), null },
                    { new Guid("5934e6fd-4f7e-4ce8-93f7-ece9001768b6"), null, null, null, "Er moet een incidentresponsproces, inclusief rollen, verantwoordelijkheden en bevoegdheden, worden uitgevoerd tijdens of na een informatie-/cyberbeveiligingsincident op de kritieke systemen van de organisatie.", "RS.RP-1.1", 0, new Guid("cdcfa6b7-03e0-4a47-9eb0-4b80f7c94c76"), null },
                    { new Guid("59e63a42-f484-459f-9515-77b365fabd34"), null, null, null, "De organisatie moet de respons- en herstelplannen bijwerken om veranderingen in de context aan te pakken.", "RS.IM-2.1", 0, new Guid("0a228c5d-cb3e-4c1f-8cc5-ac4959e65865"), null },
                    { new Guid("5af92fb2-0eb1-4eeb-b114-fb751cb84d90"), null, null, null, "De organisatie moet ongeautoriseerd gebruik van haar bedrijfskritische systemen bewaken en identificeren door het detecteren van ongeautoriseerde lokale verbindingen, netwerkverbindingen en verbindingen op afstand.", "DE.CM-1.2", 0, new Guid("6cb36feb-357a-4765-be60-0ab066c940b9"), null },
                    { new Guid("5c986374-30e2-46fb-acf4-e2a5fa12df3e"), null, null, null, "Identiteiten en referenties voor geautoriseerde apparaten en gebruikers worden beheerd.", "PR.AC-1.1", 0, new Guid("42168a35-9677-467e-b236-12cdbc293102"), null },
                    { new Guid("5e9b1ec6-a0a5-4873-befb-ecadef318327"), null, null, null, "Toegangsrechten voor gebruikers tot de systemen van de organisatie moeten worden gedefinieerd en beheerd.", "PR.AC-4.1", 0, new Guid("26e631f3-3e1a-419e-a31f-6ddb9e8550a3"), null },
                    { new Guid("631993aa-48ae-4dac-be85-055e92f75f5d"), null, null, null, "Gebruiksbeperkingen, verbindingsvereisten, implementatierichtlijnen en autorisaties voor externe toegang tot de kritieke systeemomgeving van de organisatie moeten worden geïdentificeerd, gedocumenteerd en geïmplementeerd.", "PR.AC-3.3", 0, new Guid("f38eb798-d297-49c1-a9e6-a1e870ed4746"), null },
                    { new Guid("6331f50d-be21-4afc-ac4e-9a21c3a44afd"), null, null, null, "Hogere leidinggevenden moeten aantonen dat ze hun rollen, verantwoordelijkheden en bevoegdheden begrijpen.", "PR.AT-4.1", 0, new Guid("bacffee8-7711-4d3a-baca-bfd72e1c8d86"), null },
                    { new Guid("64e1906b-ae5e-4088-96cf-1f231e34f3c9"), null, null, null, "Capaciteitsplanning moet ervoor zorgen dat er voldoende middelen zijn voor de kritische systeeminformatieverwerking, netwerken, telecommunicatie en gegevensopslag van de organisatie.", "PR.DS-4.1", 0, new Guid("493f29d4-219f-4973-a992-2a253093df97"), null },
                    { new Guid("66414f5c-71e9-47e1-911e-c6950a5cbac9"), null, null, null, "Op basis van de resultaten van de risicobeoordeling van de cybertoeleveringsketen wordt een contractueel kader voor leveranciers en externe partners opgesteld om het delen van gevoelige informatie en gedistribueerde en onderling verbonden ICT/OT-producten en -diensten aan te pakken.", "ID.SC-3.1", 0, new Guid("6053c1d4-8553-4c60-944a-9430c5f11e91"), null },
                    { new Guid("6b68aae1-1577-4cb6-bfa8-fa2ee1725eca"), null, null, null, "Bedreigingen en kwetsbaarheden moeten worden geïdentificeerd.", "ID.RA-1.1", 0, new Guid("41bf3d46-41eb-4845-a2c5-4a7b6a61e0b1"), null },
                    { new Guid("6beb1c21-fb25-4296-995d-cf7b4bae8556"), null, null, null, "Waar nodig moet de netwerkintegriteit van de kritieke systemen van de organisatie worden beschermd door netwerksegmentatie en -segregatie.", "PR.AC-5.2", 0, new Guid("6fb97b52-5261-4f7b-bd7c-c12e0d829581"), null },
                    { new Guid("6ed6d279-38c6-4483-b1e9-19a08e467530"), null, null, null, "Personeel dat toegang heeft tot de meest kritieke informatie of technologie van de organisatie moet worden geverifieerd.", "PR.IP-11.1", 0, new Guid("67b4b6b2-bc9c-4515-be2a-49a80d84d3b3"), null },
                    { new Guid("724b9216-19e5-4f80-8bae-4e5540136559"), null, null, null, "Als onderdeel van het algehele risicobeheer van het bedrijf moet een alomvattende strategie voor het beheer van informatiebeveiliging en cyberbeveiligingsrisico's worden ontwikkeld en bijgewerkt wanneer zich veranderingen voordoen.", "ID.GV-4.1", 0, new Guid("3cc3764b-0ecc-454c-ab3d-527f0ad8fdff"), null },
                    { new Guid("7409862f-20b7-4c94-9a97-aa995ec9dfbc"), null, null, null, "Afhankelijkheden en missiekritische functies voor de levering van kritieke diensten worden geïdentificeerd, gedocumenteerd en geprioriteerd op basis van hun kriticiteit als onderdeel van het risicobeoordelingsproces.", "ID.BE-4.1", 0, new Guid("317af496-8d3c-4d98-957a-3bab8a7869b6"), null },
                    { new Guid("7419f6ba-8315-43b5-b0b2-a48ec94b743d"), null, null, null, "De organisatie moet risicobeoordelingen uitvoeren en documenteren waarin het risico wordt bepaald door bedreigingen, kwetsbaarheden, de impact op bedrijfsprocessen en bedrijfsmiddelen en de waarschijnlijkheid dat deze zich voordoen.", "ID.RA-5.2", 0, new Guid("53894f78-632a-40ac-a733-87ba4985fb0b"), null },
                    { new Guid("745b9c02-0f36-4cd2-91a9-1be9fe0ef792"), null, null, null, "De organisatie moet beleid en procedures definiëren, implementeren en handhaven met betrekking tot nood- en veiligheidssystemen, brandbeveiligingssystemen en omgevingscontroles voor haar kritieke systemen.", "PR.IP-5.1", 0, new Guid("6732cd67-b996-46da-958c-8fe682677605"), null },
                    { new Guid("787ab9ca-266e-4f5a-96f9-71fbee6a7ddf"), null, null, null, "Om de cyberweerbaarheid te ondersteunen en de levering van kritieke diensten te beveiligen, worden de nodige vereisten geïdentificeerd, gedocumenteerd en hun implementatie getest en goedgekeurd.", "ID.BE-5.1", 0, new Guid("b77a5822-cf0d-41ea-9c7b-6ea2a8527fc7"), null },
                    { new Guid("787d6768-5b86-4e6f-87ae-64ec2e507bd7"), null, null, null, "De inventarisatie van softwareplatforms en applicaties die verband houden met informatie en informatieverwerking moet veranderingen in de  context van de organisatie weerspiegelen  en alle informatie bevatten die nodig is voor effectieve verantwoording.", "ID.AM-2.2", 0, new Guid("42437ae7-a11b-43e7-b0b0-727a03763aab"), null },
                    { new Guid("7a46c852-91bb-4763-a549-21107a2fe7b4"), null, null, null, "De rollen, verantwoordelijkheden en bevoegdheden op het gebied van informatiebeveiliging en cyberbeveiliging binnen de organisatie moeten worden gedocumenteerd,", "ID.AM-6.1", 0, new Guid("94776ff4-977c-43b2-b3d1-7ef530c99897"), null },
                    { new Guid("7c3a2db9-ec23-4752-a167-e2f18285e4ee"), null, null, null, "Informatie/informatie over cyberbeveiligingsincidenten moet worden gecommuniceerd en gedeeld met de werknemers van de organisatie in een formaat dat zij kunnen begrijpen.", "RS.CO-3.1", 0, new Guid("418f320e-3338-4997-b056-70c2e5aaefc6"), null },
                    { new Guid("80420775-09b4-436f-b3bf-657a6950477f"), null, null, null, "De organisatie moet de lessen die zijn geleerd uit herstelactiviteiten bij incidenten verwerken in bijgewerkte of nieuwe herstelprocedures voor systemen en dit, na het testen, omlijsten met de juiste training.", "RC.IM-1.1", 0, new Guid("bd904c29-6c9d-482e-805e-38d96e6b2b5a"), null },
                    { new Guid("826ad849-cfdf-4be5-91dd-dcce49347a53"), null, null, null, "Er moet een informatiebeveiligings- en cyberbeveiligingsbeleid voor de hele organisatie worden opgesteld, gedocumenteerd, bijgewerkt wanneer zich wijzigingen voordoen, verspreid en goedgekeurd door het senior management.", "ID.GV-1.2", 0, new Guid("796530ad-fb7d-42b4-bb1f-5f73f2395187"), null },
                    { new Guid("83411078-d61d-4341-a551-69f816bd5cbf"), null, null, null, "Gebruikers met bevoegdheden moeten worden beheerd en bewaakt.", "PR.AC-4.7", 0, new Guid("26e631f3-3e1a-419e-a31f-6ddb9e8550a3"), null },
                    { new Guid("83e855d4-1762-4b75-b361-77c536a3cc7b"), null, null, null, "De organisatie moet controleren en scannen op kwetsbaarheden in haar kritieke systemen en gehoste applicaties en ervoor zorgen dat de systeemfuncties niet negatief worden beïnvloed door het scanproces.", "DE.CM-8.1", 0, new Guid("684cf7ac-a109-4a4d-9dc2-a1c71ea79e85"), null },
                    { new Guid("872cbe16-1795-4919-9cf1-3ea61b1b01a7"), null, null, null, "De functionaliteit voor activiteitenregistratie van beveiligings-/detectiehardware of -software (bijv. firewalls, antivirus) worden ingeschakeld, back-ups worden gemaakt en herzien.", "DE.AE-3.1", 0, new Guid("a0fa7fcc-fc6f-4dcb-9171-c8a32e78e9f0"), null },
                    { new Guid("8a0f6850-e804-486b-bbe2-e7e89423e48f"), null, null, null, "De organisatie voert detectieactiviteiten uit in overeenstemming met toepasselijke federale en regionale wetten, industriële voorschriften en standaarden, beleidsregels en andere toepasselijke vereisten.", "DE.DP-2.1", 0, new Guid("e3a8bb57-9e6a-4c86-8b50-0e3107954861"), null },
                    { new Guid("8d977584-0ffe-409e-b0da-15f71c126c49"), null, null, null, "De organisatie moet een incidentafhandelingscapaciteit implementeren voor informatie-/cyberbeveiligingsincidenten op haar bedrijfskritische systemen die voorbereiding, detectie en analyse, insluiting, uitroeiing, herstel en gedocumenteerde risicoacceptatie omvat.", "RS.MI-1.1", 0, new Guid("f6b08eee-6470-475c-9808-f5d0f2f19c81"), null },
                    { new Guid("8de92a98-a67d-4b40-9b77-daa59a8b51e4"), null, null, null, "De organisatie moet geautomatiseerde mechanismen en door het systeem gegenereerde waarschuwingen implementeren om eventdetectie te ondersteunen en te helpen bij het vaststellen van drempelwaarden voor beveiligingswaarschuwingen.", "DE.AE-5.1", 0, new Guid("4af110de-df5c-4860-9e23-1c42ca7880ec"), null },
                    { new Guid("8e446ef4-4d1d-4fd0-ba93-ec00c83c095f"), null, null, null, "Het proces voor het scannen van kwetsbaarheden omvat analyse, herstel en het delen van informatie.", "DE.CM-8.2", 0, new Guid("684cf7ac-a109-4a4d-9dc2-a1c71ea79e85"), null },
                    { new Guid("8e660168-57bc-47fb-a5b2-658e56a608c8"), null, null, null, "GEEN VEREISTEN / Te overwegen richtlijnen", "", 0, new Guid("b0b53253-ef34-48f3-a3c1-12c10a22e2fe"), null },
                    { new Guid("8f277a4a-3972-4354-a709-9d9f29b04074"), null, null, null, "Er moet worden vastgesteld wie toegang moet hebben tot de bedrijfskritische informatie en technologie van de organisatie en de middelen om toegang te krijgen.", "PR.AC-4.2", 0, new Guid("26e631f3-3e1a-419e-a31f-6ddb9e8550a3"), null },
                    { new Guid("8fde57e5-67c0-453c-9e71-6a2d72710109"), null, null, null, "De organisatie moet ervoor zorgen dat de logboekrecords een gezaghebbende tijdbron of interne kloktijdstempel bevatten die worden vergeleken en gesynchroniseerd met een gezaghebbende tijdbron.", "PR.PT-1.2", 0, new Guid("5fb4725d-4f0f-4186-ba99-5d658e7cc2cf"), null },
                    { new Guid("90329aa5-9700-42db-b5d8-dd49a57dae69"), null, null, null, "De organisatie moet minstens één keer per jaar risicobeoordelingen van de cybertoeleveringsketen uitvoeren of wanneer zich een wijziging voordoet in de kritieke systemen, de operationele omgeving of de toeleveringsketen van de organisatie; deze beoordelingen moeten worden gedocumenteerd en de resultaten moeten worden verspreid onder relevante belanghebbenden, waaronder degenen die verantwoordelijk zijn voor ICT/OT-systemen.", "ID.SC-2.1", 0, new Guid("ec20edd4-c8bc-4d2d-b59b-596c75ab31f7"), null },
                    { new Guid("915f430d-754e-4a2c-a0c1-3553a384100e"), null, null, null, "De organisatie dient beveiligingscontroles te verifiëren na hardwareonderhoud of -reparaties en indien nodig actie te ondernemen.", "PR.MA-1.4", 0, new Guid("bf66f918-a1e7-405f-9f8a-d7e97614f4ea"), null },
                    { new Guid("945b0a94-831c-4ac1-9f6e-b51af684de39"), null, null, null, "De inventaris van bedrijfsmiddelen die verband houden met informatie en informatieverwerkingsfaciliteiten moet veranderingen in de  context van de organisatie weerspiegelen  en alle informatie bevatten die nodig is voor effectieve verantwoording.", "ID.AM-1.2", 0, new Guid("af66ffe2-484a-4a62-ab44-e9a815c11975"), null },
                    { new Guid("949d9c85-99eb-4737-8113-a6682e43b84d"), null, null, null, "Niemand heeft beheerdersrechten voor dagelijkse taken.", "PR.AC-4.4", 0, new Guid("26e631f3-3e1a-419e-a31f-6ddb9e8550a3"), null },
                    { new Guid("96448544-2b1d-4286-a9dd-9c9493305399"), null, null, null, "Incidentbestrijdingsplannen (Incident Response en Business Continuity) en herstelplannen (Incident Recovery en Disaster Recovery) moeten worden opgesteld, onderhouden, goedgekeurd en getest om de effectiviteit van de plannen en de gereedheid om de plannen uit te voeren te bepalen.", "PR.IP-9.1", 0, new Guid("0aa22cca-6a88-434a-acd0-87320bf6ed01"), null },
                    { new Guid("96652ce3-1702-4305-bc45-54a7488c0d96"), null, null, null, "De organisatie moet informatie over eventdetectie communiceren naar vooraf gedefinieerde partijen.", "DE.DP-4.1", 0, new Guid("c5d70d13-a151-401d-a5e1-194453ec1b1b"), null },
                    { new Guid("96eac62b-208a-4785-8571-e470d51ace9e"), null, null, null, "De organisatie moet processen en procedures voor het beheer van kwetsbaarheden implementeren die het verwerken, analyseren en verhelpen van kwetsbaarheden uit interne en externe bronnen omvatten.", "RS.AN-5.1", 0, new Guid("89ba35da-545d-4ca6-9691-65b6af9f178a"), null },
                    { new Guid("9765bd3c-91b4-4f3a-94c0-69725e3f8a52"), null, null, null, "De organisatie moet herstelactiviteiten communiceren aan vooraf gedefinieerde belanghebbenden, uitvoerende en managementteams.", "RC.CO-3.1", 0, new Guid("25fe7a69-817b-4f34-b3bf-9c5910987023"), null },
                    { new Guid("980ef38a-315d-478e-8798-55a91e07d26f"), null, null, null, "De organisatie moet passende acties ondernemen die resulteren in de bewaking van haar kritieke systemen aan de buitengrenzen en kritieke interne punten wanneer ongeautoriseerde toegang en activiteiten, inclusief gegevenslekken, worden gedetecteerd.", "PR.DS-5.1", 0, new Guid("850fb561-fddf-46f7-98d4-153b2ea417db"), null },
                    { new Guid("98df98e9-a974-4681-a3b2-2a4909214725"), null, null, null, "De organisatie moet de bedrijfskritische systemen zo configureren dat ze alleen essentiële mogelijkheden bieden.", "PR.PT-3.1", 0, new Guid("59e10b84-0f23-46fe-af0a-a45a6e5e4b09"), null },
                    { new Guid("9ad907d9-0c6b-4cd5-88d5-328facbbbee7"), null, null, null, "De organisatie moet centraliseren en coördineren hoe informatie wordt verspreid en beheren hoe de organisatie aan het publiek wordt gepresenteerd.", "RC.CO-1.1", 0, new Guid("d60c7720-c8fe-4417-a7a4-8dab71c29cc2"), null },
                    { new Guid("9cb58120-7799-4374-8da9-062504cb42fb"), null, null, null, "Wijzigingen moeten worden getest en gevalideerd voordat ze worden geïmplementeerd in operationele systemen.", "PR.IP-3.1", 0, new Guid("d02c37a5-ceb7-4053-bc36-d8a9ac49e5f5"), null },
                    { new Guid("9d9b3f97-76d7-4fd4-882c-ecfc397413d2"), null, null, null, "Web- en e-mailfilters moeten worden geïnstalleerd en gebruikt.", "PR.PT-4.1", 0, new Guid("eb5d9410-4f4d-4f9f-a419-601aabb485c0"), null },
                    { new Guid("a067de6f-e191-40d1-a921-bb1f749cc1db"), null, null, null, "De betrouwbaarheid en integriteit van back-ups moet regelmatig worden geverifieerd en getest.", "PR.IP-4.2", 0, new Guid("729ba903-5401-4d65-acd0-c2c47e8ff432"), null },
                    { new Guid("a0ebac9d-426c-4439-95c6-beebc805a395"), null, null, null, "De organisatie moet gedetecteerde gebeurtenissen beoordelen en analyseren om inzicht te krijgen in aanvalsdoelen en -methoden.", "DE.AE-2.1", 0, new Guid("c612bb8a-f863-486f-9922-8540aa852aeb"), null },
                    { new Guid("a4f85aac-6803-4fff-86a4-de9091594a22"), null, null, null, "Werknemers moeten de juiste training krijgen.", "PR.AT-1.1", 0, new Guid("90dd6047-fea2-4dcb-80e4-691b1e45e787"), null },
                    { new Guid("a5202ee7-f45c-47d6-a361-39fd7e6a8f83"), null, null, null, "Bij het beheer van toegangsrechten moet scheiding van taken (SoD) worden gewaarborgd.", "PR.AC-4.6", 0, new Guid("26e631f3-3e1a-419e-a31f-6ddb9e8550a3"), null },
                    { new Guid("a6ce705e-02be-4349-9713-caa5b7fabaa1"), null, null, null, "De draadloze toegangspunten van de organisatie moeten beveiligd zijn.", "PR.AC-3.1", 0, new Guid("f38eb798-d297-49c1-a9e6-a1e870ed4746"), null },
                    { new Guid("a70e4e2f-06c1-4218-a54d-09f4d582d66c"), null, null, null, "De rol van de organisatie in kritieke infrastructuur en de sector bepalen de risicobereidheid van de organisatie.", "ID.RM-3.1", 0, new Guid("0b8653b4-31ec-4b1b-97d1-12bf98202176"), null },
                    { new Guid("a844a9a5-6712-4d1a-88e7-cdaf8a264d07"), null, null, null, "Mededelingen over de doeltreffendheid van beschermingstechnologieën worden gedeeld met de juiste partijen.", "PR.IP-8.2", 0, new Guid("661dcb5f-c50a-4e86-9756-f11642f04945"), null },
                    { new Guid("ac8a265d-b0d9-4ee2-871b-8a9f49898186"), null, null, null, "De organisatie dient het herkennen van en rapporteren over bedreigingen van binnenuit op te nemen in de training voor beveiligingsbewustzijn.", "PR.AT-1.2", 0, new Guid("90dd6047-fea2-4dcb-80e4-691b1e45e787"), null },
                    { new Guid("ad8184ef-ab44-4a4b-bc6e-57411bf56603"), null, null, null, "Lessen die zijn geleerd uit incidentafhandeling moeten worden vertaald in bijgewerkte of nieuwe incidentafhandelingsprocedures die moeten worden getest, goedgekeurd en getraind.", "RS.IM-1.2", 0, new Guid("51402878-da03-4352-a78b-7cba5fe77a7e"), null },
                    { new Guid("b326dec4-05e4-4ab3-9453-18501b0cebeb"), null, null, null, "Auditgegevens van de kritische systemen van de organisatie moeten worden verplaatst naar een alternatief systeem.", "PR.DS-4.2", 0, new Guid("493f29d4-219f-4973-a992-2a253093df97"), null },
                    { new Guid("b4dc4c81-84de-4501-954e-fc5f03485b56"), null, null, null, "De bedrijfskritische systemen van de organisatie moeten worden gecontroleerd op toegang door onbevoegd personeel, verbindingen, apparaten, toegangspunten en software.", "DE.CM-7.1", 0, new Guid("6bbd77b2-dbac-46de-9ea5-b2bdb6b7498b"), null },
                    { new Guid("b5de49f4-8fa1-45c1-b60f-778dc95e3024"), null, null, null, "Het beheer van fysieke toegang omvat maatregelen met betrekking tot toegang in noodsituaties.", "PR.AC-2.2", 0, new Guid("f27a2a5d-0955-4081-a5dd-9f7ed84b5ff1"), null },
                    { new Guid("b5fa2050-8299-4a28-8cbe-d295769f7bba"), null, null, null, "Er moet een proces worden vastgesteld om kwetsbaarheden van de bedrijfskritische systemen van de organisatie continu te bewaken, te identificeren en te documenteren.", "ID.RA-1.2", 0, new Guid("41bf3d46-41eb-4845-a2c5-4a7b6a61e0b1"), null },
                    { new Guid("bafd2688-e6d8-468b-9e4b-3eac01e39287"), null, null, null, "De organisatie deelt informatie/informatie over cyberbeveiligingsincidenten met relevante belanghebbenden zoals voorzien in het incidentbestrijdingsplan.", "RS.CO-3.2", 0, new Guid("418f320e-3338-4997-b056-70c2e5aaefc6"), null },
                    { new Guid("bba06980-5ef8-4400-8ce2-faf6cf48e129"), null, null, null, "De organisatie coördineert de respons op informatie-/cyberbeveiligingsincidenten met alle vooraf gedefinieerde belanghebbenden.", "RS.CO-4.1", 0, new Guid("086fdf24-147b-470a-a020-c353854fac17"), null },
                    { new Guid("bd12ea6a-c19b-4e29-a624-2844ab3c9d62"), null, null, null, "De organisatie moet herstelactiviteiten communiceren aan vooraf gedefinieerde belanghebbenden, uitvoerende en managementteams.", "RC.CO-3.1", 0, new Guid("27499ab6-7965-4b5e-8135-c43529ee2c85"), null },
                    { new Guid("bdb2ae6a-ff78-43b4-b08a-40d65d9ef52a"), null, null, null, "Softwaregebruik en -installatiebeperkingen moeten worden afgedwongen.", "DE.CM-3.3", 0, new Guid("4a753121-3083-4ee1-b559-8def9f6eef79"), null },
                    { new Guid("be958c41-9f55-4c86-abfa-6ea2e96eee68"), null, null, null, "De organisatie controleert beoordelingen van de naleving van contractuele verplichtingen door leveranciers en externe partners door routinematig audits, testresultaten en andere evaluaties te controleren.", "ID.SC-4.1", 0, new Guid("435fd1da-b1ca-423c-a55b-ac7a7cdd7ae6"), null },
                    { new Guid("bea7212e-f65e-4cea-8de3-301e1eca811e"), null, null, null, "Er zijn geen vereisten geïdentificeerd voor de veiligheidsniveau ‘Basis’, maar richtlijnen worden verstrekt om de informatiebeveiliging te verhogen.", "", 0, new Guid("bc6eb7e0-2b73-4230-984a-0f72f58dfb9b"), null },
                    { new Guid("bed519f5-47e4-43c2-80ad-400360e61c18"), null, null, null, "Een cyberrisicobeheerproces dat de belangrijkste interne en externe belanghebbenden identificeert en het aanpakken van risicogerelateerde kwesties en informatie vergemakkelijkt, moet worden gecreëerd, gedocumenteerd, herzien, goedgekeurd en bijgewerkt wanneer zich wijzigingen voordoen.", "ID.RM-1.1", 0, new Guid("afead7a6-5602-46a1-b658-c89da02cc410"), null },
                    { new Guid("bf7a7e5b-48ae-4b60-8bf0-3ea7e1dedf1a"), null, null, null, "De organisatie moet ervoor zorgen dat de nodige maatregelen worden genomen om verlies, misbruik, schade of diefstal van bedrijfsmiddelen tegen te gaan.", "PR.DS-3.3", 0, new Guid("2fbaaaeb-73eb-4a13-ac68-0bac833a5654"), null },
                    { new Guid("bfd71013-0314-4e97-a5b3-b5a5fdd24116"), null, null, null, "De organisatie moet gedocumenteerde procedures implementeren voor het verifiëren van de identiteit van personen voordat referenties worden uitgegeven die toegang geven tot de systemen van de organisatie.", "PR.AC-7.1", 0, new Guid("68e8222c-1314-4a1c-85d5-734c50861917"), null },
                    { new Guid("c0ec76b0-e768-4413-9693-96c1c9ed5d35"), null, null, null, "De organisatie moet risicobeoordelingen uitvoeren waarbij het risico wordt bepaald door bedreigingen, kwetsbaarheden en de impact op bedrijfsprocessen en bedrijfsmiddelen.", "ID.RA-5.1", 0, new Guid("53894f78-632a-40ac-a733-87ba4985fb0b"), null },
                    { new Guid("c145b388-7184-4509-b813-d33ac083de40"), null, null, null, "De organisatie moet ervoor zorgen dat het personeel hun rollen, doelstellingen, herstelprioriteiten, taakvolgorde en toewijzingsverantwoordelijkheden voor de respons op evenementen begrijpt.", "RS.CO-1.1", 0, new Guid("97947d2f-c55c-4e94-ae76-1686cff0bc76"), null },
                    { new Guid("c205ad14-b422-42b2-8878-8f34b74f03e3"), null, null, null, "De organisatie moet valideren dat eventdetectieprocessen werken zoals bedoeld.", "DE.DP-3.1", 0, new Guid("d4d8ca3b-86c5-45bc-b772-c39e0d6f4e82"), null },
                    { new Guid("c25a02bd-63b3-46d1-a0d0-47130f22b26c"), null, null, null, "De organisatie werkt samen en deelt informatie over haar kritieke systeemgerelateerde beveiligingsincidenten en risicobeperkende maatregelen met aangewezen partners.", "PR.IP-8.1", 0, new Guid("661dcb5f-c50a-4e86-9756-f11642f04945"), null },
                    { new Guid("c2dd8394-c773-402d-be04-8d5235dd1d8e"), null, null, null, "Beleid en procedures voor informatiebeveiliging en cyberveiligheid worden opgesteld, gedocumenteerd, beoordeeld, goedgekeurd en bijgewerkt wanneer zich wijzigingen voordoen.", "ID.GV-1.1", 0, new Guid("796530ad-fb7d-42b4-bb1f-5f73f2395187"), null },
                    { new Guid("c49334e6-6197-4219-bb90-5799dd6a3174"), null, null, null, "Eindpunt- en netwerkbeschermingstools die het gedrag van eindgebruikers controleren op gevaarlijke activiteiten moeten worden beheerd.", "DE.CM-3.2", 0, new Guid("4a753121-3083-4ee1-b559-8def9f6eef79"), null },
                    { new Guid("c49bffb3-e603-440f-b47a-ae971cd512fc"), null, null, null, "Wettelijke en regelgevende vereisten met betrekking tot informatie-/cyberbeveiliging, waaronder privacyverplichtingen, worden begrepen en geïmplementeerd.", "ID.GV-3.1", 0, new Guid("bd2d05ad-a7fd-4600-b3cb-57ca0a898522"), null },
                    { new Guid("c6fe27d2-c4c1-44cf-b21b-a90d7f69df9c"), null, null, null, "De organisatie moet rapportages implementeren over informatie-/cyberbeveiligingsincidenten op haar kritieke systemen binnen een door de organisatie gedefinieerd tijdsbestek aan door de organisatie gedefinieerd personeel of door de organisatie gedefinieerde rollen.", "RS.CO-2.1", 0, new Guid("3133e865-76d7-4d37-8b52-dc5168397524"), null },
                    { new Guid("c9243af4-d585-48b3-8158-d6d84bcf361e"), null, null, null, "Identiteiten en referenties voor geautoriseerde apparaten en gebruikers moeten worden beheerd, waar mogelijk via geautomatiseerde mechanismen.", "PR.AC-1.2", 0, new Guid("42168a35-9677-467e-b236-12cdbc293102"), null },
                    { new Guid("c9913d98-3a49-4e8f-b912-998ba474ac98"), null, null, null, "De organisatie moet goedkeuringsvereisten, controle en toezicht afdwingen voor onderhoudsgereedschappen voor gebruik op de kritieke systemen.", "PR.MA-1.3", 0, new Guid("bf66f918-a1e7-405f-9f8a-d7e97614f4ea"), null },
                    { new Guid("ca297b6b-f17a-49be-bf22-5bb53e3eb5c5"), null, null, null, "De middelen van de organisatie (hardware, apparaten, gegevens, tijd, personeel, informatie en software) moeten worden geprioriteerd op basis van hun classificatie, kriticiteit en bedrijfswaarde.", "ID.AM-5.1", 0, new Guid("789e3806-59f9-40fc-9b04-d15bfe0d475e"), null },
                    { new Guid("ca73aa04-57eb-491b-bc4a-1ca34fa90c9c"), null, null, null, "De organisatie moet het aansluiten van verwisselbare media technisch verbieden, tenzij dit strikt noodzakelijk is; in andere gevallen moet het uitvoeren van autoruns vanaf dergelijke media worden uitgeschakeld.", "PR.PT-2.2", 0, new Guid("49b8800f-2784-4879-a533-32ef56906460"), null },
                    { new Guid("d0ea9f07-3380-4d5d-a393-852aa53a774f"), null, null, null, "De organisatie moet verbindingen en communicatie aan de buitengrenzen en aan belangrijke interne grenzen binnen de kritieke systemen van de organisatie bewaken en controleren door waar nodig grensbeschermingsapparatuur te implementeren.", "PR.AC-5.4", 0, new Guid("6fb97b52-5261-4f7b-bd7c-c12e0d829581"), null },
                    { new Guid("d10606d1-235f-451a-a086-5501a79c1dbc"), null, null, null, "Waar nodig moet de netwerkintegriteit van de kritieke systemen van de organisatie worden beschermd door (1) Verbindingen tussen systeemcomponenten identificeren, documenteren en controleren. (2) Externe verbindingen naar kritieke systemen van de organisatie beperken. ", "PR.AC-5.3", 0, new Guid("6fb97b52-5261-4f7b-bd7c-c12e0d829581"), null },
                    { new Guid("d3ef9e86-2fca-43ed-8644-b0ab568688fd"), null, null, null, "De fysieke omgeving van de faciliteit wordt bewaakt op mogelijke gebeurtenissen op het gebied van informatie-/cyberbeveiliging.", "DE.CM-2.1", 0, new Guid("7abac9f5-9cab-4a6c-a5c2-7dd9df84eb49"), null },
                    { new Guid("d69321c8-6180-41bb-abbd-b23dee062252"), null, null, null, "De organisatie moet gedocumenteerde procedures implementeren voor het verifiëren van de identiteit van personen voordat referenties worden uitgegeven die toegang geven tot de systemen van de organisatie.", "PR.AC-6.1", 0, new Guid("bc1163e7-b953-474a-bcf4-ea836d345f1b"), null },
                    { new Guid("da61c1c3-cb20-4171-bd89-d56ab4712b8c"), null, null, null, "In de levenscyclus van systeem- en applicatieontwikkeling wordt rekening gehouden met beveiliging.", "PR.IP-2.1", 0, new Guid("8e2969d1-715d-4b15-82be-3300f6ff0083"), null },
                    { new Guid("deb3d6cf-026c-4363-aeac-80a997b8c21b"), null, null, null, "De organisatie moet verbeteringen die voortkomen uit de monitoring, metingen, beoordelingen en geleerde lessen opnemen in updates van het beschermingsproces (continue verbetering).", "PR.IP-7.1", 0, new Guid("a73bc22a-1df7-40c1-856f-6ce8268ccab0"), null },
                    { new Guid("df93b549-0043-409a-9da8-a1128fe1630a"), null, null, null, "Bevoegde gebruikers moeten gekwalificeerd zijn voordat ze privileges krijgen en deze gebruikers moeten kunnen aantonen dat ze hun rollen, verantwoordelijkheden en bevoegdheden begrijpen.", "PR.AT-2.1", 0, new Guid("a46a0859-4d42-4d96-8de1-96c89964b0aa"), null },
                    { new Guid("e30d8635-d3a8-4aa3-90b6-95f02b4fa700"), null, null, null, "De organisatie moet ervoor zorgen dat gebeurtenisgegevens worden verzameld en gecorreleerd over de kritieke systemen met behulp van verschillende bronnen, zoals gebeurtenisrapporten, auditmonitoring, netwerkmonitoring, fysieke toegangsmonitoring en gebruikers-/beheerdersrapporten.", "DE.AE-3.2", 0, new Guid("a0fa7fcc-fc6f-4dcb-9171-c8a32e78e9f0"), null },
                    { new Guid("e801d590-d24c-4858-856a-0c4a3c221f99"), null, null, null, "Informatiebeveiligings- en cyberbeveiligingsrisico's worden gedocumenteerd, formeel goedgekeurd en bijgewerkt wanneer zich wijzigingen voordoen.", "ID.GV-4.2", 0, new Guid("3cc3764b-0ecc-454c-ab3d-527f0ad8fdff"), null },
                    { new Guid("e99e93d3-54d6-4e03-a829-10141482c08e"), null, null, null, "De personen die verantwoordelijk en aansprakelijk zijn voor het beheer van softwareplatforms en applicaties binnen de organisatie moeten worden geïdentificeerd.", "ID.AM-2.3", 0, new Guid("42437ae7-a11b-43e7-b0b0-727a03763aab"), null },
                    { new Guid("eaa4bdf7-e416-4819-acdc-de6d2bce2779"), null, null, null, "GEEN VEREISTEN / Te overwegen richtlijnen", "", 0, new Guid("0ede0199-74e9-4267-a3b3-e21e20315099"), null },
                    { new Guid("eab32a40-df10-41a9-9557-ee3ee88fd301"), null, null, null, "De organisatie moet een gedocumenteerd proces opstellen en bijhouden dat een voortdurende evaluatie van kwetsbaarheden en strategieën om deze te verminderen mogelijk maakt.", "PR.IP-12.1", 0, new Guid("666a0ea7-fcde-41da-99cd-c18055da0dc4"), null },
                    { new Guid("ede7605b-e49c-45b0-87c8-84affaff3a59"), null, null, null, "De organisatie moet centraliseren en coördineren hoe informatie wordt verspreid en beheren hoe de organisatie aan het publiek wordt gepresenteerd.", "RC.CO-1.1", 0, new Guid("26e0fdd9-8f1a-4846-b38d-ea889a1f09df"), null },
                    { new Guid("ee9f0d5c-0778-4d44-80a4-db9bd4b59266"), null, null, null, "Alle externe verbindingen door leveranciers die IT/OT-toepassingen of -infrastructuur ondersteunen, moeten worden beveiligd en actief worden bewaakt om ervoor te zorgen dat tijdens de verbinding alleen toegestane acties plaatsvinden.", "DE.CM-6.1", 0, new Guid("3b6a0d51-7b54-4da7-8344-80e350918ba4"), null },
                    { new Guid("f073a952-1f3f-432c-8b47-aceb0d887c3a"), null, null, null, "De organisatie moet evaluaties uitvoeren na een incident om de lessen te analyseren die zijn geleerd uit de reactie op een incident en het herstel, en vervolgens processen / procedures / technologieën verbeteren om de cyberweerbaarheid te vergroten.", "RS.IM-1.1", 0, new Guid("51402878-da03-4352-a78b-7cba5fe77a7e"), null },
                    { new Guid("f153f51e-0632-4890-8e8d-03c8d29f0b55"), null, null, null, "De organisatie moet ervoor zorgen dat de gegevens van haar kritieke systemen worden vernietigd in overeenstemming met het beleid.", "PR.IP-6.1", 0, new Guid("925805d3-63c2-47c3-ba5d-5e444ff52806"), null },
                    { new Guid("f1bc1862-9482-4958-8ffc-901f4e38d06d"), null, null, null, "Er wordt een aparte alternatieve opslaglocatie voor back-ups van het systeem gebruikt en dezelfde veiligheidswaarborgen als de primaire opslaglocatie worden toegepast", "PR.IP-4.3", 0, new Guid("729ba903-5401-4d65-acd0-c2c47e8ff432"), null },
                    { new Guid("f3860b51-fe0c-44c8-8b29-75bb1a0ad196"), null, null, null, "Wettelijke en regelgevende vereisten met betrekking tot informatie-/cyberbeveiliging, waaronder privacyverplichtingen, worden beheerd.", "ID.GV-3.2", 0, new Guid("bd2d05ad-a7fd-4600-b3cb-57ca0a898522"), null },
                    { new Guid("f3a738a7-9584-4b3c-9ad5-290e9cd4e414"), null, null, null, "Wanneer niet-geautoriseerde software wordt gedetecteerd, wordt deze in quarantaine geplaatst voor mogelijke uitzonderingsbehandeling, verwijderd of vervangen en wordt de inventaris dienovereenkomstig bijgewerkt.", "ID.AM-2.4", 0, new Guid("42437ae7-a11b-43e7-b0b0-727a03763aab"), null },
                    { new Guid("f3faaae0-08a4-4f93-b00c-27be7d138c73"), null, null, null, "Een inventarisatie van bedrijfsmiddelen die verband houden met informatie en informatieverwerkingsfaciliteiten binnen de organisatie moet worden gedocumenteerd, herzien en bijgewerkt wanneer zich wijzigingen voordoen.", "ID.AM-1.1", 0, new Guid("af66ffe2-484a-4a62-ab44-e9a815c11975"), null },
                    { new Guid("f48edacb-731c-40ec-9116-cb14ce6f2377"), null, null, null, "De plaats van de organisatie in kritieke infrastructuur en haar bedrijfstak moet worden vastgesteld en gecommuniceerd.", "ID.BE-2.1", 0, new Guid("90ad6f58-f654-48c5-a0be-106386b116e6"), null },
                    { new Guid("f50bb826-b98d-4597-9cf7-84b898ae5412"), null, null, null, "De rol van de organisatie in de toeleveringsketen moet worden vastgesteld, gedocumenteerd en gecommuniceerd.", "ID.BE-1.1", 0, new Guid("e1d70bf8-aee9-4a80-8ef4-65a456d442e7"), null },
                    { new Guid("f546b414-d5a9-455d-9b36-13388fa41ce2"), null, null, null, "Prioriteiten voor de missie, doelstellingen en activiteiten van de organisatie worden vastgesteld en gecommuniceerd.", "ID.BE-3.1", 0, new Guid("0a643c22-096b-430e-bfd8-b4462d987911"), null },
                    { new Guid("fa0fa529-26b1-45ad-ad1e-2655cd7722c1"), null, null, null, "Activa en media moeten veilig worden verwijderd.", "PR.DS-3.1", 0, new Guid("2fbaaaeb-73eb-4a13-ac68-0bac833a5654"), null },
                    { new Guid("faa7d1d2-c97d-4d2d-9595-0d8397a714ad"), null, null, null, "Externe leveranciers zijn verplicht om elke overplaatsing, beëindiging of overgang van personeel met fysieke of logische toegang tot bedrijfskritische systeemonderdelen van de organisatie te melden.", "PR.AT-3.2", 0, new Guid("01dcce94-ee8b-46e4-80e6-90faf582d7a3"), null },
                    { new Guid("fac700a4-70fd-4a98-8072-a9a00267eefe"), null, null, null, "De organisatie moet duidelijk haar risicobereidheid bepalen.", "ID.RM-2.1", 0, new Guid("f6a36400-ca59-4349-bb8c-d429cb7fbb30"), null },
                    { new Guid("fe7e6b1f-55c7-4a67-935f-0768c3e4415e"), null, null, null, "Informatie-/cyberbeveiligingsincidenten worden gecategoriseerd op basis van de ernst en impact overeenkomstig de evaluatiecriteria in het incidentbestrijdingsplan.", "RS.AN-4.1", 0, new Guid("1784ecc7-28ef-4177-aa86-766b622fd56d"), null }
                });
        }
    }
}
