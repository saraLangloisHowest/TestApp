using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Functions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Functions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Maturities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Threshold = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maturities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Municipalities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipalities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsAssesor = table.Column<bool>(type: "bit", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    FunctionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Functions_FunctionId",
                        column: x => x.FunctionId,
                        principalTable: "Functions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaturityLevels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Documentation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Implementation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaturityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaturityLevels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaturityLevels_Maturities_MaturityId",
                        column: x => x.MaturityId,
                        principalTable: "Maturities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assessments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MunicipalityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaturityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssessorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assessments_Maturities_MaturityId",
                        column: x => x.MaturityId,
                        principalTable: "Maturities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assessments_Municipalities_MunicipalityId",
                        column: x => x.MunicipalityId,
                        principalTable: "Municipalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assessments_Users_AssessorId",
                        column: x => x.AssessorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assessments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Requirements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requirements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requirements_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Guidances",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    RequirementId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsTitle = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guidances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Guidances_Requirements_RequirementId",
                        column: x => x.RequirementId,
                        principalTable: "Requirements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Scores",
                columns: table => new
                {
                    AssessmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequirementId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DocumentationMaturityScore = table.Column<int>(type: "int", nullable: false),
                    ImplementationMaturityScore = table.Column<int>(type: "int", nullable: false),
                    AdditionalInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssessorComment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scores", x => new { x.RequirementId, x.AssessmentId });
                    table.ForeignKey(
                        name: "FK_Scores_Assessments_AssessmentId",
                        column: x => x.AssessmentId,
                        principalTable: "Assessments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Scores_Requirements_RequirementId",
                        column: x => x.RequirementId,
                        principalTable: "Requirements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Functions",
                columns: new[] { "Id", "Code", "Color", "Created", "Deleted", "Description", "Name", "Order", "Updated" },
                values: new object[,]
                {
                    { new Guid("087cf09d-e377-4b31-8ff0-c10572dcf50c"), null, "F7B848", null, null, null, "Detect", 0, null },
                    { new Guid("144eed86-7514-492f-9e54-a26ce2208960"), null, "F87264", null, null, null, "Respond", 0, null },
                    { new Guid("77d1c963-ffb7-4c02-92af-d66ee1d312e6"), null, "79F19C", null, null, null, "Recover", 0, null },
                    { new Guid("b12263cb-93cf-43e9-a68f-3de7ee09904b"), null, "43C5F3", null, null, null, "Identify", 0, null },
                    { new Guid("ec1598a1-d2aa-4648-96f2-0b19d108f85f"), null, "8F92EB", null, null, null, "Protect", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Deleted", "IsAdmin", "IsAssesor", "Updated", "UserName" },
                values: new object[,]
                {
                    { new Guid("3535c924-bddf-422b-99d9-6ab8bae1bc56"), new DateTime(2016, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, null, "mauro.bekaert@lolol.be" },
                    { new Guid("808dd535-acb7-43cb-ac79-8763abe85fcc"), new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, null, "maarten.sohier@hihi.be" },
                    { new Guid("81857a0a-e2f5-47ff-948c-d96b51154c73"), new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, true, null, "timo.blomme@hahaha.com" },
                    { new Guid("c2569ef6-dcff-4c61-a0c2-3f4cbf185ba8"), new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, null, "sara.langlois2003@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Code", "Created", "Deleted", "Description", "FunctionId", "Name", "Order", "Updated" },
                values: new object[,]
                {
                    { new Guid("02389bc7-3f58-406f-a930-c9f388e64aec"), null, null, null, "Organisatorische responsactiviteiten worden verbeterd door lessen te trekken uit huidige en eerdere detectie-/responsactiviteiten.", new Guid("144eed86-7514-492f-9e54-a26ce2208960"), "Improvements", 0, null },
                    { new Guid("1f14b306-9f40-4b03-836a-c18192d25609"), null, null, null, "Technische beveiligingsoplossingen worden beheerd om de beveiliging en veerkracht van systemen en bedrijfsmiddelen te garanderen, in overeenstemming met beleid, procedures en overeenkomsten.", new Guid("ec1598a1-d2aa-4648-96f2-0b19d108f85f"), "Protective Technology", 0, null },
                    { new Guid("27b18cf8-7338-4712-9e55-a2c6c48a7a7c"), null, null, null, "De prioriteiten, beperkingen, risicotoleranties en aannames van de organisatie worden vastgesteld en gebruikt ter ondersteuning van risicobeslissingen met betrekking tot het beheren van risico's in de toeleveringsketen. De organisatie heeft processen vastgesteld en geïmplementeerd om risico's in de toeleveringsketen te identificeren, te beoordelen en te beheren.", new Guid("b12263cb-93cf-43e9-a68f-3de7ee09904b"), "Supply Chain Risk Management", 0, null },
                    { new Guid("3582034a-eb08-457b-ae77-923beed0f2aa"), null, null, null, "De gegevens, het personeel, de apparaten, systemen en faciliteiten die de organisatie in staat stellen om bedrijfsdoeleinden te bereiken, worden geïdentificeerd en beheerd in overeenstemming met hun relatieve belang voor de doelstellingen van de organisatie en de risicostrategie van de organisatie.", new Guid("b12263cb-93cf-43e9-a68f-3de7ee09904b"), "Asset Management", 0, null },
                    { new Guid("4785bc21-1fc1-496b-ac6d-76f4bebbe03d"), null, null, null, "Response-activiteiten worden gecoördineerd met interne en externe belanghebbenden (bijv. externe ondersteuning van wetshandhavingsinstanties).", new Guid("144eed86-7514-492f-9e54-a26ce2208960"), "Communications", 0, null },
                    { new Guid("51534b5f-4d70-4bce-bc1a-053c1b85448b"), null, null, null, "De organisatie begrijpt het cyberbeveiligingsrisico voor de activiteiten van de organisatie (inclusief missie, functies, imago of reputatie), bedrijfsmiddelen van de organisatie en individuen.", new Guid("b12263cb-93cf-43e9-a68f-3de7ee09904b"), "Risk Assessment", 0, null },
                    { new Guid("54c2204a-0602-4055-bdbb-8e3816415e6a"), null, null, null, "Er wordt een beveiligingsbeleid (met aandacht voor het doel, de reikwijdte, de rollen, de verantwoordelijkheden, de betrokkenheid van het management en de coördinatie tussen organisatorische entiteiten), processen en procedures onderhouden en gebruikt om de bescherming van informatiesystemen en -middelen te beheren.", new Guid("ec1598a1-d2aa-4648-96f2-0b19d108f85f"), "Information Protection Processes and Procedures", 0, null },
                    { new Guid("5eeba92d-a247-4bcf-8365-1874cc11a94e"), null, null, null, "Toegang tot fysieke en logische activa en bijbehorende faciliteiten is beperkt tot geautoriseerde gebruikers, processen en apparaten, en wordt beheerd in overeenstemming met het ingeschatte risico van ongeautoriseerde toegang tot geautoriseerde activiteiten en transacties.", new Guid("ec1598a1-d2aa-4648-96f2-0b19d108f85f"), "Identity Management, Authentication and Access Control", 0, null },
                    { new Guid("83e4862b-8fb5-4fa1-a25b-12d7c03fcaa4"), null, null, null, "Het informatiesysteem en de middelen worden gemonitord om cyberbeveiligingsgebeurtenissen te identificeren en de effectiviteit van beschermende maatregelen te verifiëren.", new Guid("087cf09d-e377-4b31-8ff0-c10572dcf50c"), "Security Continuous Monitoring", 0, null },
                    { new Guid("8455d293-6693-4724-97ac-b956a5aa0ba8"), null, null, null, "Er worden activiteiten uitgevoerd om uitbreiding van een gebeurtenis te voorkomen, de gevolgen ervan te beperken en het incident op te lossen.", new Guid("144eed86-7514-492f-9e54-a26ce2208960"), "Mitigation", 0, null },
                    { new Guid("98851b50-3a6f-48e9-b57b-10a6598e83ff"), null, null, null, "Herstelprocessen en -procedures worden uitgevoerd en gehandhaafd om te zorgen voor herstel van systemen of bedrijfsmiddelen die zijn getroffen door cyberbeveiligingsincidenten.", new Guid("77d1c963-ffb7-4c02-92af-d66ee1d312e6"), "Recovery Planning", 0, null },
                    { new Guid("a22a3b5a-cbbb-4316-918e-c5c7bc4025e7"), null, null, null, "De missie, doelstellingen, belanghebbenden en activiteiten van de organisatie worden begrepen en geprioriteerd; deze informatie wordt gebruikt om cyberbeveiligingsrollen, verantwoordelijkheden en risicomanagementbeslissingen te informeren.", new Guid("b12263cb-93cf-43e9-a68f-3de7ee09904b"), "Business Environment", 0, null },
                    { new Guid("a4bd3257-a36c-4a3a-8f10-177d039d6e1f"), null, null, null, "Afwijkende activiteiten worden gedetecteerd en de potentiële impact van gebeurtenissen wordt begrepen.", new Guid("087cf09d-e377-4b31-8ff0-c10572dcf50c"), "Anomalies and Events", 0, null },
                    { new Guid("b18ebcc4-d748-4eb7-8900-9ff87b75abc3"), null, null, null, "Onderhoud en reparaties aan componenten van industriële besturings- en informatiesystemen worden uitgevoerd in overeenstemming met beleid en procedures.", new Guid("ec1598a1-d2aa-4648-96f2-0b19d108f85f"), "Maintenance", 0, null },
                    { new Guid("b1a54f91-ae4d-4129-a544-d6018e1111f5"), null, null, null, "Het beleid, de procedures en processen voor het beheren en bewaken van de regelgevende, juridische, risico-, milieu- en operationele vereisten van de organisatie worden begrepen en informeren het beheer van cyberbeveiligingsrisico's.", new Guid("b12263cb-93cf-43e9-a68f-3de7ee09904b"), "Governance", 0, null },
                    { new Guid("b91b0d83-5055-47a3-9751-ff102e9a02a2"), null, null, null, "Herstelactiviteiten worden gecoördineerd met interne en externe partijen (bijv. coördinatiecentra, internetproviders, eigenaren van aanvallende systemen, slachtoffers, andere CSIRT's en leveranciers).", new Guid("77d1c963-ffb7-4c02-92af-d66ee1d312e6"), "Communications", 0, null },
                    { new Guid("bd5e358e-4b02-4b11-ad6b-7224b1162a4f"), null, null, null, "Detectieprocessen en -procedures worden onderhouden en getest om ervoor te zorgen dat men op de hoogte is van afwijkende gebeurtenissen.", new Guid("087cf09d-e377-4b31-8ff0-c10572dcf50c"), "Detection Processes", 0, null },
                    { new Guid("c3f70af5-3017-4b20-80c5-4831a657213a"), null, null, null, "Herstelactiviteiten worden gecoördineerd met interne en externe partijen (bijv. coördinatiecentra, internetproviders, eigenaren van aanvallende systemen, slachtoffers, andere CSIRT's en leveranciers).", new Guid("77d1c963-ffb7-4c02-92af-d66ee1d312e6"), "Communications", 0, null },
                    { new Guid("cc2e8aa1-c6e1-48eb-877a-e7989d854c5f"), null, null, null, "Responseprocessen en -procedures worden uitgevoerd en onderhouden om te zorgen dat er wordt gereageerd op gedetecteerde cyberbeveiligingsincidenten.", new Guid("144eed86-7514-492f-9e54-a26ce2208960"), "Response Planning", 0, null },
                    { new Guid("cc4de849-3967-41dd-8f1f-412a50e23fd9"), null, null, null, "Informatie en records (gegevens) worden beheerd in overeenstemming met de risicostrategie van de organisatie om de vertrouwelijkheid, integriteit en beschikbaarheid van informatie te beschermen.", new Guid("ec1598a1-d2aa-4648-96f2-0b19d108f85f"), "Data Security", 0, null },
                    { new Guid("d0fd7718-5747-4995-a03f-cfd802252880"), null, null, null, "De prioriteiten, beperkingen, risicotoleranties en aannames van de organisatie worden vastgesteld en gebruikt om beslissingen over operationele risico's te ondersteunen.", new Guid("b12263cb-93cf-43e9-a68f-3de7ee09904b"), "Risk Management Strategy", 0, null },
                    { new Guid("ddcad526-18cf-4c2f-895d-3e46b360c5a8"), null, null, null, "Er worden analyses uitgevoerd om een effectieve respons te garanderen en herstelactiviteiten te ondersteunen.", new Guid("144eed86-7514-492f-9e54-a26ce2208960"), "Analysis", 0, null },
                    { new Guid("e6c81e86-b234-470e-854d-f555aad1b656"), null, null, null, "Het personeel en de partners van de organisatie krijgen voorlichting over cyberbewustzijn en worden getraind om hun taken en verantwoordelijkheden op het gebied van cyberbeveiliging uit te voeren in overeenstemming met het beleid, de procedures en overeenkomsten op dit gebied.", new Guid("ec1598a1-d2aa-4648-96f2-0b19d108f85f"), "Awareness and Training", 0, null },
                    { new Guid("ea40d933-8b8d-4ea3-a1fc-cc20bdd1cf67"), null, null, null, "De herstelplanning en -processen worden verbeterd door geleerde lessen op te nemen in toekomstige activiteiten.", new Guid("77d1c963-ffb7-4c02-92af-d66ee1d312e6"), "Improvements", 0, null }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Code", "Created", "Deleted", "Description", "Name", "Order", "Updated" },
                values: new object[,]
                {
                    { new Guid("00b0546a-188c-46e7-b7ff-8170d44d91e1"), new Guid("e6c81e86-b234-470e-854d-f555aad1b656"), null, null, null, "Alle gebruikers zijn geïnformeerd en getraind", "PR.AT-1", 0, null },
                    { new Guid("05b68187-2321-4265-8a7d-785ee89bfd0a"), new Guid("54c2204a-0602-4055-bdbb-8e3816415e6a"), null, null, null, "Er wordt een plan voor kwetsbaarheidsmanagement ontwikkeld en geïmplementeerd", "PR.IP-12", 0, null },
                    { new Guid("0844488b-dd64-4391-8639-915364440548"), new Guid("1f14b306-9f40-4b03-836a-c18192d25609"), null, null, null, "Het principe van de minste functionaliteit wordt toegepast door systemen zo te configureren dat ze alleen essentiële mogelijkheden bieden.", "PR.PT-3", 0, null },
                    { new Guid("08814892-1f8a-42cf-8fbc-4703a878dd89"), new Guid("27b18cf8-7338-4712-9e55-a2c6c48a7a7c"), null, null, null, "Reactie- en herstelplanning en tests worden uitgevoerd met leveranciers en externe leveranciers", "ID.SC-5", 0, null },
                    { new Guid("0a6f698d-69f4-4096-829e-d718e718ead1"), new Guid("83e4862b-8fb5-4fa1-a25b-12d7c03fcaa4"), null, null, null, "Kwaadaardige code is gedetecteerd", "DE.CM-4", 0, null },
                    { new Guid("0b724057-dbb0-4128-9ce4-d4d8d9ea9a5b"), new Guid("83e4862b-8fb5-4fa1-a25b-12d7c03fcaa4"), null, null, null, "Personeelsactiviteiten worden gemonitord om potentiële cyberbeveiligingsgebeurtenissen te detecteren", "DE.CM-3", 0, null },
                    { new Guid("1862fcd7-12a3-4891-90f5-4dfcf0969950"), new Guid("cc4de849-3967-41dd-8f1f-412a50e23fd9"), null, null, null, "Voldoende capaciteit om de beschikbaarheid te garanderen", "PR.DS-4", 0, null },
                    { new Guid("196af6aa-b118-4e73-9bb8-cc142218249d"), new Guid("ddcad526-18cf-4c2f-895d-3e46b360c5a8"), null, null, null, "Incidenten worden gecategoriseerd in overeenstemming met responsplannen", "RS.AN-4", 0, null },
                    { new Guid("23d6735c-e53a-4d13-943d-193d26fa5ccd"), new Guid("b1a54f91-ae4d-4129-a544-d6018e1111f5"), null, null, null, "Het cyberbeveiligingsbeleid van de organisatie wordt vastgesteld en gecommuniceerd", "ID.GV-1", 0, null },
                    { new Guid("248e1d27-5e8a-40be-bf6f-2c0350cc9940"), new Guid("5eeba92d-a247-4bcf-8365-1874cc11a94e"), null, null, null, "Gebruikers, apparaten en andere middelen worden geverifieerd (bijv. single-factor, multi-factor) in overeenstemming met het risico van de transactie (bijv. de veiligheids- en privacyrisico's van individuen en andere organisatorische risico's).", "PR.AC-7", 0, null },
                    { new Guid("27318d56-fb6a-4fbc-8730-7b797bea5f69"), new Guid("a4bd3257-a36c-4a3a-8f10-177d039d6e1f"), null, null, null, "Drempels voor incidentenwaarschuwing zijn vastgesteld", "DE.AE-5", 0, null },
                    { new Guid("282a6b61-939e-4ae3-ba23-7da1e96e8e01"), new Guid("54c2204a-0602-4055-bdbb-8e3816415e6a"), null, null, null, "Er wordt een System Development Life Cycle geïmplementeerd om systemen te beheren.", "PR.IP-2", 0, null },
                    { new Guid("2852f793-3fb5-4b93-aeba-9038476c323b"), new Guid("51534b5f-4d70-4bce-bc1a-053c1b85448b"), null, null, null, "Bedreigingen, kwetsbaarheden, waarschijnlijkheden en gevolgen worden gebruikt om risico's te bepalen.", "ID.RA-5", 0, null },
                    { new Guid("28ed5193-b5e2-48a0-89a7-4dbafdb4c19c"), new Guid("5eeba92d-a247-4bcf-8365-1874cc11a94e"), null, null, null, "Identiteiten zijn bewezen en gebonden aan referenties en worden bevestigd in interacties", "PR.AC-6", 0, null },
                    { new Guid("293b8aa4-7c0b-42c4-887d-f46a999bf990"), new Guid("ddcad526-18cf-4c2f-895d-3e46b360c5a8"), null, null, null, "Er zijn processen vastgesteld om kwetsbaarheden te ontvangen, te analyseren en te reageren op kwetsbaarheden die door interne en externe bronnen (bijv. interne tests, beveiligingsbulletins of beveiligingsonderzoekers) aan de organisatie worden doorgegeven.", "RS.AN-5", 0, null },
                    { new Guid("2cde404a-7546-4c6a-8e21-354e8cdc9d51"), new Guid("5eeba92d-a247-4bcf-8365-1874cc11a94e"), null, null, null, "Netwerkintegriteit wordt beschermd (bijv. netwerksegregatie, netwerksegmentatie)", "PR.AC-5", 0, null },
                    { new Guid("2d08ab05-11f9-42ec-b00d-4f6eba9e5a7d"), new Guid("3582034a-eb08-457b-ae77-923beed0f2aa"), null, null, null, "Cyberbeveiligingsrollen, -verantwoordelijkheden en -bevoegdheden voor het voltallige personeel en externe belanghebbenden zijn vastgesteld.", "ID.AM-6", 0, null },
                    { new Guid("31a2ed92-0373-4564-836e-1ae2835387e7"), new Guid("cc2e8aa1-c6e1-48eb-877a-e7989d854c5f"), null, null, null, "Responsplan wordt uitgevoerd tijdens of na een incident", "RS.RP-1", 0, null },
                    { new Guid("326bc5e6-d058-47ce-b095-3e9edf66645d"), new Guid("51534b5f-4d70-4bce-bc1a-053c1b85448b"), null, null, null, "Kwetsbaarheden van bedrijfsmiddelen worden geïdentificeerd en gedocumenteerd", "ID.RA-1", 0, null },
                    { new Guid("35716ca1-54f4-4da1-9f4c-549b864fbd7f"), new Guid("54c2204a-0602-4055-bdbb-8e3816415e6a"), null, null, null, "Er wordt voldaan aan beleid en voorschriften met betrekking tot de fysieke werkomgeving voor bedrijfsmiddelen van de organisatie.", "PR.IP-5", 0, null },
                    { new Guid("3aac6d55-3af7-4736-bf25-efb06571fd44"), new Guid("54c2204a-0602-4055-bdbb-8e3816415e6a"), null, null, null, "Beschermingsprocessen worden verbeterd", "PR.IP-7", 0, null },
                    { new Guid("3ba0913c-157d-4c00-9a01-3d67e50fc63c"), new Guid("1f14b306-9f40-4b03-836a-c18192d25609"), null, null, null, "Communicatie- en besturingsnetwerken worden beschermd", "PR.PT-4", 0, null },
                    { new Guid("3ce5b82f-a3e5-4f8c-9197-74ed354628d7"), new Guid("cc4de849-3967-41dd-8f1f-412a50e23fd9"), null, null, null, "Activa worden formeel beheerd tijdens verwijdering, overdracht en vervreemding", "PR.DS-3", 0, null },
                    { new Guid("3d101931-d5e0-4526-8b10-2a7b0e8bc1c8"), new Guid("c3f70af5-3017-4b20-80c5-4831a657213a"), null, null, null, "Public relations worden beheerd", "RC.CO-1", 0, null },
                    { new Guid("428d2230-4839-4f52-88d6-3793f86346e8"), new Guid("a22a3b5a-cbbb-4316-918e-c5c7bc4025e7"), null, null, null, "De rol van de organisatie in de toeleveringsketen wordt geïdentificeerd en gecommuniceerd", "ID.BE-1", 0, null },
                    { new Guid("43c21f64-cdb3-4029-86f2-89c6fb3ce6e5"), new Guid("d0fd7718-5747-4995-a03f-cfd802252880"), null, null, null, "Risicomaatregelen worden geïdentificeerd en geprioriteerd", "ID.RM-1", 0, null },
                    { new Guid("441875b4-6a70-4168-8207-c523db1869ca"), new Guid("a22a3b5a-cbbb-4316-918e-c5c7bc4025e7"), null, null, null, "Afhankelijkheden en kritieke functies voor de levering van kritieke diensten zijn vastgesteld", "ID.BE-4", 0, null },
                    { new Guid("47185c82-5e80-4978-8ee8-8286780b8eb7"), new Guid("54c2204a-0602-4055-bdbb-8e3816415e6a"), null, null, null, "Cyberbeveiliging is opgenomen in HR-praktijken (bijv. deprovisionering, personeelsscreening)", "PR.IP-11", 0, null },
                    { new Guid("47a5caef-9f2e-415a-98b7-84d575267c99"), new Guid("83e4862b-8fb5-4fa1-a25b-12d7c03fcaa4"), null, null, null, "De fysieke omgeving wordt bewaakt om potentiële cyberbeveiligingsgebeurtenissen te detecteren", "DE.CM-2", 0, null },
                    { new Guid("4bb4d5a3-aaaa-4080-87c2-44c20c11bfbb"), new Guid("bd5e358e-4b02-4b11-ad6b-7224b1162a4f"), null, null, null, "Detectieprocessen worden getest", "DE.DP-3", 0, null },
                    { new Guid("4f7a5503-ea4c-4930-955c-e7a796186f8e"), new Guid("4785bc21-1fc1-496b-ac6d-76f4bebbe03d"), null, null, null, "Incidenten worden gerapporteerd volgens vastgestelde criteria", "RS.CO-2", 0, null },
                    { new Guid("52648ebd-a57b-4b63-9783-46e273fe8f88"), new Guid("4785bc21-1fc1-496b-ac6d-76f4bebbe03d"), null, null, null, "Coördinatie met belanghebbenden vindt plaats in overeenstemming met responsplannen", "RS.CO-4", 0, null },
                    { new Guid("54fb5220-24c4-4799-af0a-62ee2fa69ac7"), new Guid("d0fd7718-5747-4995-a03f-cfd802252880"), null, null, null, "Organisatorische risicotolerantie wordt bepaald en duidelijk uitgedrukt", "ID.RM-2", 0, null },
                    { new Guid("56f2ed06-4355-4022-9234-9bdf42e4f239"), new Guid("bd5e358e-4b02-4b11-ad6b-7224b1162a4f"), null, null, null, "Informatie over gebeurtenisdetectie wordt doorgegeven", "DE.DP-4", 0, null },
                    { new Guid("589502c5-0ad6-4f10-918f-e5ec8361f3b8"), new Guid("8455d293-6693-4724-97ac-b956a5aa0ba8"), null, null, null, "Incidenten zijn onder controle", "RS.MI-1", 0, null },
                    { new Guid("597a3eea-258b-431e-a5ba-e057b88257bd"), new Guid("1f14b306-9f40-4b03-836a-c18192d25609"), null, null, null, "Verwijderbare media worden beschermd en het gebruik ervan beperkt volgens het beleid", "PR.PT-2", 0, null },
                    { new Guid("5bed0913-70b5-42e1-bbb9-24478ad9dca3"), new Guid("54c2204a-0602-4055-bdbb-8e3816415e6a"), null, null, null, "Er wordt een basisconfiguratie van informatietechnologie/industriële besturingssystemen gemaakt en onderhouden, waarin beveiligingsprincipes zijn opgenomen (bijv. het concept van de minste functionaliteit).", "PR.IP-1", 0, null },
                    { new Guid("5e12f636-163c-4781-99a1-c2efd008c7cc"), new Guid("54c2204a-0602-4055-bdbb-8e3816415e6a"), null, null, null, "Responsplannen (Incident Response en Business Continuity) en herstelplannen (Incident Recovery en Disaster Recovery) zijn aanwezig en worden beheerd", "PR.IP-9", 0, null },
                    { new Guid("5e7d5a1c-5030-4084-a1af-4708325c3d74"), new Guid("54c2204a-0602-4055-bdbb-8e3816415e6a"), null, null, null, "Effectiviteit van beschermingstechnologieën wordt gedeeld", "PR.IP-8", 0, null },
                    { new Guid("5fe22d16-eba1-4c3b-aa0e-d769d3178ba6"), new Guid("b1a54f91-ae4d-4129-a544-d6018e1111f5"), null, null, null, "Wettelijke en regelgevende vereisten met betrekking tot cyberbeveiliging, inclusief verplichtingen op het gebied van privacy en burgerlijke vrijheden, worden begrepen en beheerd.", "ID.GV-3", 0, null },
                    { new Guid("62b42d7a-45ed-473d-a9b8-a195131a518c"), new Guid("3582034a-eb08-457b-ae77-923beed0f2aa"), null, null, null, "Softwareplatformen, en applicaties die binnen de organisatie worden gebruikt, worden geïnventariseerd", "ID.AM-2", 0, null },
                    { new Guid("66ac4acc-78f5-43e7-90fd-81f3bf302988"), new Guid("a4bd3257-a36c-4a3a-8f10-177d039d6e1f"), null, null, null, "Gebeurtenisgegevens worden verzameld en gecorreleerd vanuit meerdere bronnen en sensoren", "DE.AE-3", 0, null },
                    { new Guid("66d3eaae-ca38-4f2e-9ea3-063bdc24177a"), new Guid("b91b0d83-5055-47a3-9751-ff102e9a02a2"), null, null, null, "Public relations worden beheerd", "RC.CO-1", 0, null },
                    { new Guid("67ad615f-76ac-4228-bfce-7fd92711d3ef"), new Guid("b91b0d83-5055-47a3-9751-ff102e9a02a2"), null, null, null, "Herstelactiviteiten worden gecommuniceerd naar interne en externe belanghebbenden en naar uitvoerende en managementteams", "RC.CO-3", 0, null },
                    { new Guid("683cf835-1ff6-42db-8b57-6be000b243f9"), new Guid("c3f70af5-3017-4b20-80c5-4831a657213a"), null, null, null, "Herstelactiviteiten worden gecommuniceerd naar interne en externe belanghebbenden en naar uitvoerende en managementteams", "RC.CO-3", 0, null },
                    { new Guid("755060fa-c759-46d6-a29e-c32ac8b33485"), new Guid("51534b5f-4d70-4bce-bc1a-053c1b85448b"), null, null, null, "Informatie over cyberdreigingen wordt ontvangen van forums en bronnen waar informatie wordt gedeeld", "ID.RA-2", 0, null },
                    { new Guid("76127fb4-96d6-4756-a9ba-cde96ce6d8bd"), new Guid("3582034a-eb08-457b-ae77-923beed0f2aa"), null, null, null, "Externe informatiesystemen worden gecatalogiseerd", "ID.AM-4", 0, null },
                    { new Guid("7efe7130-a8d9-40f8-a058-bbb7752ffb90"), new Guid("e6c81e86-b234-470e-854d-f555aad1b656"), null, null, null, "Derden belanghebbenden (bijv. leveranciers, klanten, partners) begrijpen hun rollen en verantwoordelijkheden", "PR.AT-3", 0, null },
                    { new Guid("829b5f0e-c4c0-420d-8fce-1bb0dd92df00"), new Guid("27b18cf8-7338-4712-9e55-a2c6c48a7a7c"), null, null, null, "Leveranciers en externe partners worden routinematig beoordeeld met behulp van audits, testresultaten of andere vormen van evaluaties om te bevestigen dat ze aan hun contractuele verplichtingen voldoen.", "ID.SC-4", 0, null },
                    { new Guid("877ff2fe-327b-4e39-8284-078f745f902f"), new Guid("ea40d933-8b8d-4ea3-a1fc-cc20bdd1cf67"), null, null, null, "Herstelplannen bevatten geleerde lessen", "RC.IM-1", 0, null },
                    { new Guid("897fb6e3-0a01-42be-801a-fd75e353dd5c"), new Guid("ddcad526-18cf-4c2f-895d-3e46b360c5a8"), null, null, null, "De gevolgen van het incident worden begrepen", "RS.AN-2", 0, null },
                    { new Guid("8bb48182-8bf7-4a9f-ba97-35340c408770"), new Guid("bd5e358e-4b02-4b11-ad6b-7224b1162a4f"), null, null, null, "Detectieprocessen worden voortdurend verbeterd", "DE.DP-5", 0, null },
                    { new Guid("96ff9f50-7168-44a4-9265-e7c8adbcd31e"), new Guid("27b18cf8-7338-4712-9e55-a2c6c48a7a7c"), null, null, null, "Contracten met leveranciers en externe partners worden gebruikt om passende maatregelen te implementeren die zijn ontworpen om te voldoen aan de doelstellingen van het cyberbeveiligingsprogramma en het risicobeheerplan voor de cyberketen van een organisatie.", "ID.SC-3", 0, null },
                    { new Guid("97f1e731-3647-4099-8b99-6d7f8eb7d29b"), new Guid("4785bc21-1fc1-496b-ac6d-76f4bebbe03d"), null, null, null, "Personeel kent hun rol en volgorde van handelen wanneer een reactie nodig is", "RS.CO-1", 0, null },
                    { new Guid("99b739ae-770a-4777-8176-6014ce82cf4f"), new Guid("83e4862b-8fb5-4fa1-a25b-12d7c03fcaa4"), null, null, null, "Activiteit van externe serviceproviders wordt gemonitord om potentiële cyberbeveiligingsgebeurtenissen te detecteren", "DE.CM-6", 0, null },
                    { new Guid("9a94b93d-029e-42d6-866f-0c24c5af6729"), new Guid("a22a3b5a-cbbb-4316-918e-c5c7bc4025e7"), null, null, null, "De veerkrachtvereisten ter ondersteuning van de levering van kritieke diensten zijn vastgesteld voor alle operationele toestanden (bijv. onder dwang/aanval, tijdens herstel, normale activiteiten).", "ID.BE-5", 0, null },
                    { new Guid("9cb33945-5d3b-42f5-9afb-2b867da7a96d"), new Guid("83e4862b-8fb5-4fa1-a25b-12d7c03fcaa4"), null, null, null, "Het netwerk wordt bewaakt om potentiële cyberbeveiligingsgebeurtenissen te detecteren", "DE.CM-1", 0, null },
                    { new Guid("9d66ffbf-c19e-427d-aa63-5080df3f52a6"), new Guid("83e4862b-8fb5-4fa1-a25b-12d7c03fcaa4"), null, null, null, "Er wordt gecontroleerd op onbevoegd personeel, verbindingen, apparaten en software", "DE.CM-7", 0, null },
                    { new Guid("a27a9dcd-2763-41a2-90f8-6882a8f76863"), new Guid("cc4de849-3967-41dd-8f1f-412a50e23fd9"), null, null, null, "Integriteitscontrolemechanismen worden gebruikt om de integriteit van software, firmware en informatie te controleren.", "PR.DS-6", 0, null },
                    { new Guid("a486436b-c608-4fca-bd20-e3de96e14c04"), new Guid("b18ebcc4-d748-4eb7-8900-9ff87b75abc3"), null, null, null, "Onderhoud op afstand van bedrijfsmiddelen wordt goedgekeurd, vastgelegd en uitgevoerd op een manier die onbevoegde toegang voorkomt.", "PR.MA-2", 0, null },
                    { new Guid("a4c1a0ed-0572-4dae-a7c7-06f802b29b41"), new Guid("a4bd3257-a36c-4a3a-8f10-177d039d6e1f"), null, null, null, "Gedetecteerde gebeurtenissen worden geanalyseerd om aanvalsdoelen en -methoden te begrijpen", "DE.AE-2", 0, null },
                    { new Guid("a5fde2ed-106a-4b2c-85d1-60d5ee5080ca"), new Guid("a22a3b5a-cbbb-4316-918e-c5c7bc4025e7"), null, null, null, "Prioriteiten voor de missie, doelstellingen en activiteiten van de organisatie worden vastgesteld en gecommuniceerd", "ID.BE-3", 0, null },
                    { new Guid("a85eb8b9-d6a3-41bf-991a-ed67145531e5"), new Guid("a22a3b5a-cbbb-4316-918e-c5c7bc4025e7"), null, null, null, "De plaats van de organisatie in kritieke infrastructuur en haar bedrijfstak wordt geïdentificeerd en gecommuniceerd", "ID.BE-2", 0, null },
                    { new Guid("a97f9ba0-c00f-4136-ba1a-17043173ac36"), new Guid("cc4de849-3967-41dd-8f1f-412a50e23fd9"), null, null, null, "Data-in-transit is beschermd", "PR.DS-2", 0, null },
                    { new Guid("ab940b74-29d7-4cf3-bf03-9d7b71e83bde"), new Guid("e6c81e86-b234-470e-854d-f555aad1b656"), null, null, null, "Fysiek en cyberbeveiligingspersoneel begrijpen hun rollen en verantwoordelijkheden", "PR.AT-5", 0, null },
                    { new Guid("abe79008-12a4-4b75-a901-e29e958415fd"), new Guid("b91b0d83-5055-47a3-9751-ff102e9a02a2"), null, null, null, "Herstelactiviteiten worden gecommuniceerd naar interne en externe belanghebbenden en naar uitvoerende en managementteams", "RC.CO-3", 0, null },
                    { new Guid("b12b82a9-4b4b-477a-9cb9-547480405ce6"), new Guid("5eeba92d-a247-4bcf-8365-1874cc11a94e"), null, null, null, "Toegang op afstand wordt beheerd", "PR.AC-3", 0, null },
                    { new Guid("b30237ac-9af6-4094-86b5-491d002967a0"), new Guid("02389bc7-3f58-406f-a930-c9f388e64aec"), null, null, null, "Reactie- en herstelstrategieën worden bijgewerkt", "RS.IM-2", 0, null },
                    { new Guid("b42cf775-7f99-47f1-8c1a-e784637a5659"), new Guid("51534b5f-4d70-4bce-bc1a-053c1b85448b"), null, null, null, "Risicomaatregelen worden geïdentificeerd en geprioriteerd", "ID.RA-6", 0, null },
                    { new Guid("b5f16d89-0c08-4d97-848a-d93df20a73b7"), new Guid("83e4862b-8fb5-4fa1-a25b-12d7c03fcaa4"), null, null, null, "Kwetsbaarheidsscans worden uitgevoerd", "DE.CM-8", 0, null },
                    { new Guid("b6aae802-8f50-4244-9d43-0bf4ac34e250"), new Guid("cc4de849-3967-41dd-8f1f-412a50e23fd9"), null, null, null, "Gegevens in rust zijn beschermd", "PR.DS-1", 0, null },
                    { new Guid("b7148b20-1081-49a7-9b78-1e38381f567d"), new Guid("98851b50-3a6f-48e9-b57b-10a6598e83ff"), null, null, null, "Herstelplan wordt uitgevoerd tijdens of na een cyberbeveiligingsincident", "RC.RP-1", 0, null },
                    { new Guid("bae7ad28-41b1-4224-8a48-a30aa01d3b18"), new Guid("bd5e358e-4b02-4b11-ad6b-7224b1162a4f"), null, null, null, "Detectieactiviteiten voldoen aan alle toepasselijke vereisten", "DE.DP-2", 0, null },
                    { new Guid("bd45c860-c928-4711-9a97-47a4b47d1c2c"), new Guid("ddcad526-18cf-4c2f-895d-3e46b360c5a8"), null, null, null, "Meldingen van detectiesystemen worden onderzocht", "RS.AN-1", 0, null },
                    { new Guid("be27b381-7821-4a6e-8939-75e4d9be59ab"), new Guid("e6c81e86-b234-470e-854d-f555aad1b656"), null, null, null, "Bevoegde gebruikers begrijpen hun rollen en verantwoordelijkheden", "PR.AT-2", 0, null },
                    { new Guid("c1af763e-8934-4a88-9f17-6e2483499cc9"), new Guid("02389bc7-3f58-406f-a930-c9f388e64aec"), null, null, null, "Reactie- en herstelplannen bevatten geleerde lessen", "RS.IM-1", 0, null },
                    { new Guid("caf1fa04-f1af-4d13-822e-b90985227fd0"), new Guid("b18ebcc4-d748-4eb7-8900-9ff87b75abc3"), null, null, null, "Onderhoud en reparatie van bedrijfsmiddelen van de organisatie worden uitgevoerd en geregistreerd met goedgekeurde en gecontroleerde gereedschappen.", "PR.MA-1", 0, null },
                    { new Guid("cd443392-46ee-4cfd-9a3a-8295ff49cb88"), new Guid("cc4de849-3967-41dd-8f1f-412a50e23fd9"), null, null, null, "Beveiligingen tegen datalekken worden geïmplementeerd", "PR.DS-5", 0, null },
                    { new Guid("d1c5b109-851e-4d7d-92e6-dfdd2a16cd3c"), new Guid("27b18cf8-7338-4712-9e55-a2c6c48a7a7c"), null, null, null, "Leveranciers en externe partners van informatiesystemen, onderdelen en diensten worden geïdentificeerd, geprioriteerd en beoordeeld met behulp van een proces voor de beoordeling van cyberrisico's in de toeleveringsketen.", "ID.SC-2", 0, null },
                    { new Guid("d2ed32b5-2fff-40f3-b0bb-bff3d76c73a6"), new Guid("3582034a-eb08-457b-ae77-923beed0f2aa"), null, null, null, "Hulpbronnen (bijv. hardware, apparaten, gegevens, tijd, personeel en software) worden geprioriteerd op basis van hun classificatie, kriticiteit en bedrijfswaarde.", "ID.AM-5", 0, null },
                    { new Guid("d77ec7d2-7861-4d75-be15-e869a91a6818"), new Guid("5eeba92d-a247-4bcf-8365-1874cc11a94e"), null, null, null, "Identiteiten en referenties worden uitgegeven, beheerd, geverifieerd, ingetrokken en gecontroleerd voor geautoriseerde apparaten, gebruikers en processen.", "PR.AC-1", 0, null },
                    { new Guid("d8c91a0e-75e2-4993-89c6-8864e4b84c51"), new Guid("54c2204a-0602-4055-bdbb-8e3816415e6a"), null, null, null, "Er zijn processen voor het beheren van configuratiewijzigingen", "PR.IP-3", 0, null },
                    { new Guid("da13781d-bb4b-4fbc-83c8-4a3929e5c3c3"), new Guid("b1a54f91-ae4d-4129-a544-d6018e1111f5"), null, null, null, "Governance- en risicobeheerprocessen richten zich op cyberbeveiligingsrisico's", "ID.GV-4", 0, null },
                    { new Guid("dbccbcb1-c12d-4614-8188-9859724da993"), new Guid("d0fd7718-5747-4995-a03f-cfd802252880"), null, null, null, "De organisatie bepaalt haar risicotolerantie op basis van haar rol in kritieke infrastructuur en sectorspecifieke risicoanalyse.", "ID.RM-3", 0, null },
                    { new Guid("ddb5aef4-1f11-4d69-9205-d3c77b82f762"), new Guid("5eeba92d-a247-4bcf-8365-1874cc11a94e"), null, null, null, "Fysieke toegang tot bedrijfsmiddelen wordt beheerd en beschermd", "PR.AC-2", 0, null },
                    { new Guid("dfa1b7a7-6e77-40a3-bc40-8a41e122b4ff"), new Guid("c3f70af5-3017-4b20-80c5-4831a657213a"), null, null, null, "Herstelactiviteiten worden gecommuniceerd naar interne en externe belanghebbenden en naar uitvoerende en managementteams", "RC.CO-3", 0, null },
                    { new Guid("e15c1640-1562-4428-976f-2cd8968293a7"), new Guid("83e4862b-8fb5-4fa1-a25b-12d7c03fcaa4"), null, null, null, "Ongeautoriseerde mobiele code gedetecteerd", "DE.CM-5", 0, null },
                    { new Guid("e27de27d-3caa-4ec5-9ed6-b5fc0ecf2a29"), new Guid("3582034a-eb08-457b-ae77-923beed0f2aa"), null, null, null, "Organisatiecommunicatie en gegevensstromen worden in kaart gebracht", "ID.AM-3", 0, null },
                    { new Guid("e5ecea85-29b3-42f0-9b10-5f1c5007904f"), new Guid("54c2204a-0602-4055-bdbb-8e3816415e6a"), null, null, null, "Gegevens worden vernietigd volgens beleid", "PR.IP-6", 0, null },
                    { new Guid("ee422e01-c4e1-4cf0-a78a-f5647928d767"), new Guid("1f14b306-9f40-4b03-836a-c18192d25609"), null, null, null, "Audit/logboekrecords worden bepaald, gedocumenteerd, geïmplementeerd en herzien in overeenstemming met het beleid", "PR.PT-1", 0, null },
                    { new Guid("eee2cfb6-c286-485f-b090-082aefc5d806"), new Guid("4785bc21-1fc1-496b-ac6d-76f4bebbe03d"), null, null, null, "Er wordt op vrijwillige basis informatie gedeeld met externe belanghebbenden om een breder situationeel bewustzijn van cyberbeveiliging te creëren.", "RS.CO-5", 0, null },
                    { new Guid("ef31e59a-a699-4274-a6e1-05b7760e704b"), new Guid("cc4de849-3967-41dd-8f1f-412a50e23fd9"), null, null, null, "De ontwikkel- en testomgeving(en) zijn gescheiden van de productieomgeving", "PR.DS-7", 0, null },
                    { new Guid("ef591248-7538-4de3-8c2e-d9e8f3730578"), new Guid("e6c81e86-b234-470e-854d-f555aad1b656"), null, null, null, "Senior managers begrijpen hun rollen en verantwoordelijkheden", "PR.AT-4", 0, null },
                    { new Guid("f0b125a3-4cee-4236-888a-71fbb081be62"), new Guid("54c2204a-0602-4055-bdbb-8e3816415e6a"), null, null, null, "Back-ups van informatie worden uitgevoerd, onderhouden en getest", "PR.IP-4", 0, null },
                    { new Guid("f31e0f28-89c7-4b31-8487-bc2b5985694e"), new Guid("3582034a-eb08-457b-ae77-923beed0f2aa"), null, null, null, "Fysieke apparaten en systemen die binnen de organisatie worden gebruikt, worden geïnventariseerd", "ID.AM-1", 0, null },
                    { new Guid("f4ad5b18-d5b6-4ebb-ae8a-769c79aa7947"), new Guid("5eeba92d-a247-4bcf-8365-1874cc11a94e"), null, null, null, "Toegangsmachtigingen en autorisaties worden beheerd, waarbij de principes van 'least privilege' en scheiding van taken worden toegepast.", "PR.AC-4", 0, null },
                    { new Guid("f764d524-c037-4dca-8103-58b1875caf33"), new Guid("4785bc21-1fc1-496b-ac6d-76f4bebbe03d"), null, null, null, "Informatie wordt gedeeld in overeenstemming met responsplannen", "RS.CO-3", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Requirements",
                columns: new[] { "Id", "Code", "Created", "Deleted", "Description", "Name", "Order", "SubCategoryId", "Updated" },
                values: new object[,]
                {
                    { new Guid("00758902-aa6d-41e3-bcff-8240071c293b"), null, null, null, "Identiteiten en referenties voor geautoriseerde apparaten en gebruikers worden beheerd.", "PR.AC-1.1", 0, new Guid("d77ec7d2-7861-4d75-be15-e869a91a6818"), null },
                    { new Guid("024e7f4f-c197-4338-939f-50db28e8b151"), null, null, null, "De organisatie moet ervoor zorgen dat de logboekrecords een gezaghebbende tijdbron of interne kloktijdstempel bevatten die worden vergeleken en gesynchroniseerd met een gezaghebbende tijdbron.", "PR.PT-1.2", 0, new Guid("ee422e01-c4e1-4cf0-a78a-f5647928d767"), null },
                    { new Guid("02d18ade-f2ca-4213-a485-c3f8763f02aa"), null, null, null, "Er moet een informatiebeveiligings- en cyberbeveiligingsbeleid voor de hele organisatie worden opgesteld, gedocumenteerd, bijgewerkt wanneer zich wijzigingen voordoen, verspreid en goedgekeurd door het senior management.", "ID.GV-1.2", 0, new Guid("23d6735c-e53a-4d13-943d-193d26fa5ccd"), null },
                    { new Guid("03089949-d5aa-43e7-9a46-3c750bd0a509"), null, null, null, "De organisatie moet ongeautoriseerd gebruik van haar bedrijfskritische systemen bewaken en identificeren door het detecteren van ongeautoriseerde lokale verbindingen, netwerkverbindingen en verbindingen op afstand.", "DE.CM-1.2", 0, new Guid("9cb33945-5d3b-42f5-9afb-2b867da7a96d"), null },
                    { new Guid("03bb81c7-c46f-4272-b685-27aea5008c76"), null, null, null, "De organisatie moet ervoor zorgen dat het personeel hun rollen, doelstellingen, herstelprioriteiten, taakvolgorde en toewijzingsverantwoordelijkheden voor de respons op evenementen begrijpt.", "RS.CO-1.1", 0, new Guid("97f1e731-3647-4099-8b99-6d7f8eb7d29b"), null },
                    { new Guid("0426cb41-5b87-450d-a348-0987c0613485"), null, null, null, "De organisatie moet waarschuwingsdrempels voor incidenten definiëren.", "DE.AE-5.2", 0, new Guid("27318d56-fb6a-4fbc-8730-7b797bea5f69"), null },
                    { new Guid("04a131c0-26fd-416f-878f-c8c5aa11fcb4"), null, null, null, "In de levenscyclus van systeem- en applicatieontwikkeling wordt rekening gehouden met beveiliging.", "PR.IP-2.1", 0, new Guid("282a6b61-939e-4ae3-ba23-7da1e96e8e01"), null },
                    { new Guid("06bdcb3e-8797-4271-b055-31e7ded2aa72"), null, null, null, "Informatiebeveiligings- en cyberbeveiligingsrisico's worden gedocumenteerd, formeel goedgekeurd en bijgewerkt wanneer zich wijzigingen voordoen.", "ID.GV-4.2", 0, new Guid("da13781d-bb4b-4fbc-83c8-4a3929e5c3c3"), null },
                    { new Guid("0e879a4e-8378-4ea4-bd68-9505bcf6c40c"), null, null, null, "De netwerken van de organisatie die op afstand worden benaderd, moeten worden beveiligd, onder andere door middel van multifactorauthenticatie (MFA).", "PR.AC-3.2", 0, new Guid("b12b82a9-4b4b-477a-9cb9-547480405ce6"), null },
                    { new Guid("10974efc-2032-4c12-8d04-b8110286a790"), null, null, null, "De organisatie moet ervoor zorgen dat personeel dat verantwoordelijk is voor de fysieke bescherming en beveiliging van de kritieke systemen en faciliteiten van de organisatie gekwalificeerd is door middel van training voordat privileges worden verleend, en dat zij hun verantwoordelijkheden begrijpen.", "PR.AT-5.1", 0, new Guid("ab940b74-29d7-4cf3-bf03-9d7b71e83bde"), null },
                    { new Guid("11459423-9d3a-496c-be8c-6286b77f87d9"), null, null, null, "De draadloze toegangspunten van de organisatie moeten beveiligd zijn.", "PR.AC-3.1", 0, new Guid("b12b82a9-4b4b-477a-9cb9-547480405ce6"), null },
                    { new Guid("121db905-5b17-4fe9-b20e-3b3e8b7adafe"), null, null, null, "De organisatie voert detectieactiviteiten uit in overeenstemming met toepasselijke federale en regionale wetten, industriële voorschriften en standaarden, beleidsregels en andere toepasselijke vereisten.", "DE.DP-2.1", 0, new Guid("bae7ad28-41b1-4224-8a48-a30aa01d3b18"), null },
                    { new Guid("143f6895-cfcb-4a4f-954f-1f4a676c001b"), null, null, null, "De betrouwbaarheid en integriteit van back-ups moet regelmatig worden geverifieerd en getest.", "PR.IP-4.2", 0, new Guid("f0b125a3-4cee-4236-888a-71fbb081be62"), null },
                    { new Guid("14b02c7e-1c81-470f-95f9-57d62fd5e109"), null, null, null, "Afhankelijkheden en missiekritische functies voor de levering van kritieke diensten worden geïdentificeerd, gedocumenteerd en geprioriteerd op basis van hun kriticiteit als onderdeel van het risicobeoordelingsproces.", "ID.BE-4.1", 0, new Guid("441875b4-6a70-4168-8207-c523db1869ca"), null },
                    { new Guid("1597eb95-7d9f-42b2-95ed-46b735532405"), null, null, null, "De fysieke toegang tot de faciliteit, servers en netwerkcomponenten moet worden beheerd.", "PR.AC-2.1", 0, new Guid("ddb5aef4-1f11-4d69-9205-d3c77b82f762"), null },
                    { new Guid("163df1bf-3cab-42ff-93ae-5f7398805cb3"), null, null, null, "Informatie die de organisatie opslaat en gebruikt, moet worden geïdentificeerd.", "ID.AM-3.1", 0, new Guid("e27de27d-3caa-4ec5-9ed6-b5fc0ecf2a29"), null },
                    { new Guid("175b0cf2-a853-44ab-a809-4c4707e4d52b"), null, null, null, "Waar mogelijk worden geautomatiseerde mechanismen geïmplementeerd ter ondersteuning van het beheer van gebruikersaccounts op de kritieke systemen van de organisatie, waaronder het uitschakelen, bewaken, rapporteren en verwijderen van gebruikersaccounts.", "PR.AC-4.5", 0, new Guid("f4ad5b18-d5b6-4ebb-ae8a-769c79aa7947"), null },
                    { new Guid("18936d80-98d4-4ee1-8e4a-a1b558365678"), null, null, null, "De organisatie moet herstelactiviteiten communiceren aan vooraf gedefinieerde belanghebbenden, uitvoerende en managementteams.", "RC.CO-3.1", 0, new Guid("67ad615f-76ac-4228-bfce-7fd92711d3ef"), null },
                    { new Guid("1935a31c-081f-46b5-827a-3dee9836d13f"), null, null, null, "Wettelijke en regelgevende vereisten met betrekking tot informatie-/cyberbeveiliging, waaronder privacyverplichtingen, worden beheerd.", "ID.GV-3.2", 0, new Guid("5fe22d16-eba1-4c3b-aa0e-d769d3178ba6"), null },
                    { new Guid("1a8bfc24-839e-43f9-b3bb-eec134285c3f"), null, null, null, "De organisatie moet preventief onderhoud en reparaties aan haar kritieke systeemonderdelen plannen, uitvoeren en documenteren volgens goedgekeurde processen en hulpmiddelen.", "PR.MA-1.2", 0, new Guid("caf1fa04-f1af-4d13-822e-b90985227fd0"), null },
                    { new Guid("1aead25f-0105-4f7b-bfb2-f51b8bfc6ca6"), null, null, null, "Back-ups voor bedrijfskritische gegevens van de organisatie moeten worden uitgevoerd en opgeslagen op een ander systeem dan het apparaat waarop de oorspronkelijke gegevens staan.", "PR.IP-4.1", 0, new Guid("f0b125a3-4cee-4236-888a-71fbb081be62"), null },
                    { new Guid("1ce74fc8-e3fc-49c0-a7ae-c2c213a2e5d4"), null, null, null, "De organisatie moet, waar mogelijk, geautomatiseerde mechanismen implementeren om te helpen bij de samenwerking op het gebied van informatie.", "PR.IP-8.3", 0, new Guid("5e7d5a1c-5030-4084-a1af-4708325c3d74"), null },
                    { new Guid("1d409ab2-50f6-4805-bf1a-e40721bb1592"), null, null, null, "De organisatie moet risicobeoordelingen uitvoeren en documenteren waarin het risico wordt bepaald door bedreigingen, kwetsbaarheden, de impact op bedrijfsprocessen en bedrijfsmiddelen en de waarschijnlijkheid dat deze zich voordoen.", "ID.RA-5.2", 0, new Guid("2852f793-3fb5-4b93-aeba-9038476c323b"), null },
                    { new Guid("1e65b3fd-7414-4380-beb0-4f46fdf9b4b3"), null, null, null, "Verbeteringen die voortkomen uit het monitoren, meten, beoordelen, testen, beoordelen en geleerde lessen worden opgenomen in herzieningen van detectieprocessen.", "DE.DP-5.1", 0, new Guid("8bb48182-8bf7-4a9f-ba97-35340c408770"), null },
                    { new Guid("2737f5c2-794c-4816-939e-75bb1a68f508"), null, null, null, "De organisatie moet minstens één keer per jaar risicobeoordelingen van de cybertoeleveringsketen uitvoeren of wanneer zich een wijziging voordoet in de kritieke systemen, de operationele omgeving of de toeleveringsketen van de organisatie; deze beoordelingen moeten worden gedocumenteerd en de resultaten moeten worden verspreid onder relevante belanghebbenden, waaronder degenen die verantwoordelijk zijn voor ICT/OT-systemen.", "ID.SC-2.1", 0, new Guid("d1c5b109-851e-4d7d-92e6-dfdd2a16cd3c"), null },
                    { new Guid("2741441f-573f-403e-bb60-a4133b3c81fe"), null, null, null, "De organisatie moet duidelijk haar risicobereidheid bepalen.", "ID.RM-2.1", 0, new Guid("54fb5220-24c4-4799-af0a-62ee2fa69ac7"), null },
                    { new Guid("281e035c-cdfd-4af9-a1b1-77861375cce9"), null, null, null, "De organisatie moet verbindingen en communicatie aan de buitengrenzen en aan belangrijke interne grenzen binnen de kritieke systemen van de organisatie bewaken en controleren door waar nodig grensbeschermingsapparatuur te implementeren.", "PR.AC-5.4", 0, new Guid("2cde404a-7546-4c6a-8e21-354e8cdc9d51"), null },
                    { new Guid("28a5c3a6-b2cb-41f2-b244-a17fc15a2de2"), null, null, null, "Er wordt een herstelproces voor rampen en informatie-/cyberbeveiligingsincidenten ontwikkeld en zo nodig uitgevoerd.", "RC.RP-1.1", 0, new Guid("b7148b20-1081-49a7-9b78-1e38381f567d"), null },
                    { new Guid("2a9d1179-9173-4fa9-86d2-9793f50b6be4"), null, null, null, "Informatiebeveiligings- en cyberbeveiligingsrisico's worden gedocumenteerd, formeel goedgekeurd en bijgewerkt wanneer zich wijzigingen voordoen.", "ID.GV-4.2", 0, new Guid("da13781d-bb4b-4fbc-83c8-4a3929e5c3c3"), null },
                    { new Guid("2ad2158a-a856-4196-943b-6e973098fea4"), null, null, null, "De organisatie moet beveiligingseisen opstellen en afdwingen voor bedrijfskritieke externe leveranciers en gebruikers.", "PR.AT-3.1", 0, new Guid("7efe7130-a8d9-40f8-a058-bbb7752ffb90"), null },
                    { new Guid("2c9fab40-4f71-4b11-bd5b-6e624695c09d"), null, null, null, "De rollen, verantwoordelijkheden en bevoegdheden op het gebied van informatiebeveiliging en cyberbeveiliging binnen de organisatie moeten worden gedocumenteerd,", "ID.AM-6.1", 0, new Guid("2d08ab05-11f9-42ec-b00d-4f6eba9e5a7d"), null },
                    { new Guid("2e6a36af-0cd1-485f-8d42-0f242590d96a"), null, null, null, "De toegang van werknemers tot gegevens en informatie wordt beperkt tot de systemen en specifieke informatie die ze nodig hebben om hun werk te doen (het principe van Least Privilege).", "PR.AC-4.3", 0, new Guid("f4ad5b18-d5b6-4ebb-ae8a-769c79aa7947"), null },
                    { new Guid("3222dcbd-decb-4893-8a49-2565374a098c"), null, null, null, "Een inventarisatie van bedrijfsmiddelen die verband houden met informatie en informatieverwerkingsfaciliteiten binnen de organisatie moet worden gedocumenteerd, herzien en bijgewerkt wanneer zich wijzigingen voordoen.", "ID.AM-1.1", 0, new Guid("f31e0f28-89c7-4b31-8487-bc2b5985694e"), null },
                    { new Guid("32d08c20-7f85-42bc-9a7b-18a5036adb52"), null, null, null, "Toegangsrechten voor gebruikers tot de systemen van de organisatie moeten worden gedefinieerd en beheerd.", "PR.AC-4.1", 0, new Guid("f4ad5b18-d5b6-4ebb-ae8a-769c79aa7947"), null },
                    { new Guid("366a8e60-0a7d-4bfd-be74-ea1f525ac49b"), null, null, null, "Een inventaris die weergeeft welke softwareplatforms en applicaties in de organisatie worden gebruikt, moet worden gedocumenteerd, herzien en bijgewerkt wanneer zich wijzigingen voordoen.", "ID.AM-2.1", 0, new Guid("62b42d7a-45ed-473d-a9b8-a195131a518c"), null },
                    { new Guid("368d7f43-7523-4944-8314-97243e99f77c"), null, null, null, "Identiteiten en referenties voor geautoriseerde apparaten en gebruikers moeten worden beheerd, waar mogelijk via geautomatiseerde mechanismen.", "PR.AC-1.2", 0, new Guid("d77ec7d2-7861-4d75-be15-e869a91a6818"), null },
                    { new Guid("36d5f5b7-0c71-43a8-86e0-eeb60b35801f"), null, null, null, "De bedrijfskritische systemen van de organisatie moeten worden gecontroleerd op toegang door onbevoegd personeel, verbindingen, apparaten, toegangspunten en software.", "DE.CM-7.1", 0, new Guid("9d66ffbf-c19e-427d-aa63-5080df3f52a6"), null },
                    { new Guid("370d4b61-2c3b-42ac-a8da-ceb8e94a2f17"), null, null, null, "De organisatie dient het herkennen van en rapporteren over bedreigingen van binnenuit op te nemen in de training voor beveiligingsbewustzijn.", "PR.AT-1.2", 0, new Guid("00b0546a-188c-46e7-b7ff-8170d44d91e1"), null },
                    { new Guid("3c19aee4-93aa-4889-b929-2198ae6cf3fd"), null, null, null, "Lessen die zijn geleerd uit incidentafhandeling moeten worden vertaald in bijgewerkte of nieuwe incidentafhandelingsprocedures die moeten worden getest, goedgekeurd en getraind.", "RS.IM-1.2", 0, new Guid("c1af763e-8934-4a88-9f17-6e2483499cc9"), null },
                    { new Guid("3ed90109-4345-40bb-b255-bf88d7e004dc"), null, null, null, "Er zijn geen vereisten geïdentificeerd voor de veiligheidsniveau ‘Basis’, maar richtlijnen worden verstrekt om de informatiebeveiliging te verhogen.", "", 0, new Guid("ef31e59a-a699-4274-a6e1-05b7760e704b"), null },
                    { new Guid("40d04bc4-0d9a-431c-a314-4616169f0158"), null, null, null, "Eindpunt- en netwerkbeschermingstools die het gedrag van eindgebruikers controleren op gevaarlijke activiteiten moeten worden beheerd.", "DE.CM-3.2", 0, new Guid("0b724057-dbb0-4128-9ce4-d4d8d9ea9a5b"), null },
                    { new Guid("42989b42-3972-4bd0-a517-dbbcbb7ee339"), null, null, null, "De organisatie moet risicobeoordelingen uitvoeren waarbij het risico wordt bepaald door bedreigingen, kwetsbaarheden en de impact op bedrijfsprocessen en bedrijfsmiddelen.", "ID.RA-5.1", 0, new Guid("2852f793-3fb5-4b93-aeba-9038476c323b"), null },
                    { new Guid("43697126-82da-4d17-b3ea-7e1c8c8a277d"), null, null, null, "Er moet een allesomvattende strategie worden ontwikkeld en geïmplementeerd om de risico's voor de kritieke systemen van de organisatie te beheren, inclusief de identificatie en prioritering van risicomaatregelen.", "ID.RA-6.1", 0, new Guid("b42cf775-7f99-47f1-8c1a-e784637a5659"), null },
                    { new Guid("4691bf59-6c1e-4aaa-be13-4bc4644b54be"), null, null, null, "Gebruikers met bevoegdheden moeten worden beheerd en bewaakt.", "PR.AC-4.7", 0, new Guid("f4ad5b18-d5b6-4ebb-ae8a-769c79aa7947"), null },
                    { new Guid("473a5030-7cac-4444-a61c-b456b97a2bbf"), null, null, null, "De organisatie moet ervoor zorgen dat de gegevens van haar kritieke systemen worden vernietigd in overeenstemming met het beleid.", "PR.IP-6.1", 0, new Guid("e5ecea85-29b3-42f0-9b10-5f1c5007904f"), null },
                    { new Guid("477c6b9a-26ef-46b3-a532-ad9fca42d74b"), null, null, null, "Bevoegde gebruikers moeten gekwalificeerd zijn voordat ze privileges krijgen en deze gebruikers moeten kunnen aantonen dat ze hun rollen, verantwoordelijkheden en bevoegdheden begrijpen.", "PR.AT-2.1", 0, new Guid("be27b381-7821-4a6e-8939-75e4d9be59ab"), null },
                    { new Guid("47920750-bd38-41a8-83aa-90941a46f7c5"), null, null, null, "De organisatie deelt informatie/informatie over cyberbeveiligingsincidenten vrijwillig, indien van toepassing, met externe belanghebbenden, beveiligingsgroepen uit de branche, om een breder situationeel bewustzijn van informatie/cyberbeveiliging te bereiken.", "RS.CO-5.1", 0, new Guid("eee2cfb6-c286-485f-b090-082aefc5d806"), null },
                    { new Guid("48596b17-feac-4069-88ae-08708326697d"), null, null, null, "Mededelingen over de doeltreffendheid van beschermingstechnologieën worden gedeeld met de juiste partijen.", "PR.IP-8.2", 0, new Guid("5e7d5a1c-5030-4084-a1af-4708325c3d74"), null },
                    { new Guid("4a362b3e-dbb7-4c34-9fa6-7837d922d668"), null, null, null, "Hogere leidinggevenden moeten aantonen dat ze hun rollen, verantwoordelijkheden en bevoegdheden begrijpen.", "PR.AT-4.1", 0, new Guid("ef591248-7538-4de3-8c2e-d9e8f3730578"), null },
                    { new Guid("4aa9c68d-48f4-46ee-b83b-a760fbe5a543"), null, null, null, "De organisatie moet een incidentafhandelingscapaciteit implementeren voor informatie-/cyberbeveiligingsincidenten op haar bedrijfskritische systemen die voorbereiding, detectie en analyse, insluiting, uitroeiing, herstel en gedocumenteerde risicoacceptatie omvat.", "RS.MI-1.1", 0, new Guid("589502c5-0ad6-4f10-918f-e5ec8361f3b8"), null },
                    { new Guid("4c5e0f41-078b-4b4f-9533-724702fd0ea5"), null, null, null, "De organisatie moet gedetecteerde gebeurtenissen beoordelen en analyseren om inzicht te krijgen in aanvalsdoelen en -methoden.", "DE.AE-2.1", 0, new Guid("a4c1a0ed-0572-4dae-a7c7-06f802b29b41"), null },
                    { new Guid("4d0871b8-7285-411e-bf6e-fd21718fc919"), null, null, null, "De organisatie moet herstelactiviteiten communiceren aan vooraf gedefinieerde belanghebbenden, uitvoerende en managementteams.", "RC.CO-3.1", 0, new Guid("dfa1b7a7-6e77-40a3-bc40-8a41e122b4ff"), null },
                    { new Guid("4d178cc8-9985-45e5-b5cf-b0a68e9bf352"), null, null, null, "De middelen van de organisatie (hardware, apparaten, gegevens, tijd, personeel, informatie en software) moeten worden geprioriteerd op basis van hun classificatie, kriticiteit en bedrijfswaarde.", "ID.AM-5.1", 0, new Guid("d2ed32b5-2fff-40f3-b0bb-bff3d76c73a6"), null },
                    { new Guid("4d2ba230-5d21-45ba-aafa-96cd1a1464c6"), null, null, null, "De organisatie moet verbeteringen die voortkomen uit de monitoring, metingen, beoordelingen en geleerde lessen opnemen in updates van het beschermingsproces (continue verbetering).", "PR.IP-7.1", 0, new Guid("3aac6d55-3af7-4736-bf25-efb06571fd44"), null },
                    { new Guid("4e1b9997-ff74-4a5b-b104-de7ab148083b"), null, null, null, "Het proces voor het scannen van kwetsbaarheden omvat analyse, herstel en het delen van informatie.", "DE.CM-8.2", 0, new Guid("b5f16d89-0c08-4d97-848a-d93df20a73b7"), null },
                    { new Guid("5147afb1-f167-4bf8-b361-be78688238a0"), null, null, null, "De organisatie moet valideren dat eventdetectieprocessen werken zoals bedoeld.", "DE.DP-3.1", 0, new Guid("4bb4d5a3-aaaa-4080-87c2-44c20c11bfbb"), null },
                    { new Guid("521a3f6f-a77b-4a82-a83e-14ef43265e5b"), null, null, null, "GEEN VEREISTEN / Te overwegen richtlijnen", "", 0, new Guid("b6aae802-8f50-4244-9d43-0bf4ac34e250"), null },
                    { new Guid("5321040b-72c1-460a-80c2-63beb35e4279"), null, null, null, "De organisatie moet het aansluiten van verwisselbare media technisch verbieden, tenzij dit strikt noodzakelijk is; in andere gevallen moet het uitvoeren van autoruns vanaf dergelijke media worden uitgeschakeld.", "PR.PT-2.2", 0, new Guid("597a3eea-258b-431e-a5ba-e057b88257bd"), null },
                    { new Guid("560ea20e-3e79-4929-b370-c4e1cf48d0b3"), null, null, null, "De organisatie moet verantwoordelijkheid nastreven voor alle bedrijfskritische activa tijdens het systeemlevenscyclus, inclusief het verwijderen, overdragen en afstoting.", "PR.DS-3.2", 0, new Guid("3ce5b82f-a3e5-4f8c-9197-74ed354628d7"), null },
                    { new Guid("58f0a97b-fd64-4330-af29-b217a0d131c6"), null, null, null, "De organisatie controleert leveranciers en gebruikers van bedrijfskritische diensten op naleving van de beveiligingseisen.", "PR.AT-3.3", 0, new Guid("7efe7130-a8d9-40f8-a058-bbb7752ffb90"), null },
                    { new Guid("5c287f07-d920-4405-aa1f-e6cfbc2d3895"), null, null, null, "Een informatie- en cyberbeveiligingsproces voor personeelszaken ontwikkelen en onderhouden dat van toepassing is bij het werven, tijdens het dienstverband en bij beëindiging van het dienstverband.", "PR.IP-11.2", 0, new Guid("47185c82-5e80-4978-8ee8-8286780b8eb7"), null },
                    { new Guid("5c894451-c4e7-4470-969f-c9abdb9200a2"), null, null, null, "Gebruiksbeperkingen, verbindingsvereisten, implementatierichtlijnen en autorisaties voor externe toegang tot de kritieke systeemomgeving van de organisatie moeten worden geïdentificeerd, gedocumenteerd en geïmplementeerd.", "PR.AC-3.3", 0, new Guid("b12b82a9-4b4b-477a-9cb9-547480405ce6"), null },
                    { new Guid("5d0667f8-6554-44e0-9bb2-bb9a668f19bc"), null, null, null, "De organisatie moet processen en procedures voor het beheer van kwetsbaarheden implementeren die het verwerken, analyseren en verhelpen van kwetsbaarheden uit interne en externe bronnen omvatten.", "RS.AN-5.1", 0, new Guid("293b8aa4-7c0b-42c4-887d-f46a999bf990"), null },
                    { new Guid("5dfa74f7-17f5-4afe-ad70-125f5b436d0b"), null, null, null, "Activa en media moeten veilig worden verwijderd.", "PR.DS-3.1", 0, new Guid("3ce5b82f-a3e5-4f8c-9197-74ed354628d7"), null },
                    { new Guid("5ee1a4c1-0bb3-49c3-b0f0-38bf741111f3"), null, null, null, "De organisatie moet gedocumenteerde procedures implementeren voor het verifiëren van de identiteit van personen voordat referenties worden uitgegeven die toegang geven tot de systemen van de organisatie.", "PR.AC-6.1", 0, new Guid("28ed5193-b5e2-48a0-89a7-4dbafdb4c19c"), null },
                    { new Guid("5fd33377-d613-4135-aa82-3c298cbb7fc1"), null, null, null, "Er moet een incidentresponsproces, inclusief rollen, verantwoordelijkheden en bevoegdheden, worden uitgevoerd tijdens of na een informatie-/cyberbeveiligingsincident op de kritieke systemen van de organisatie.", "RS.RP-1.1", 0, new Guid("31a2ed92-0373-4564-836e-1ae2835387e7"), null },
                    { new Guid("6117a864-c9ea-4a80-9355-d467bc405574"), null, null, null, "De plaats van de organisatie in kritieke infrastructuur en haar bedrijfstak moet worden vastgesteld en gecommuniceerd.", "ID.BE-2.1", 0, new Guid("a85eb8b9-d6a3-41bf-991a-ed67145531e5"), null },
                    { new Guid("62895797-e596-4e56-af3b-6eecb7cfd642"), null, null, null, "De organisatie moet informatie over eventdetectie communiceren naar vooraf gedefinieerde partijen.", "DE.DP-4.1", 0, new Guid("56f2ed06-4355-4022-9234-9bdf42e4f239"), null },
                    { new Guid("64f915b0-759c-4a78-b9ec-fc68bdfc85f0"), null, null, null, "De organisatie moet ervoor zorgen dat sterke authenticators, registratie en sessiebeëindiging voor onderhoud op afstand worden geïmplementeerd.", "PR.MA-2.2", 0, new Guid("a486436b-c608-4fca-bd20-e3de96e14c04"), null },
                    { new Guid("68583cdb-77a3-4d50-bce6-6dc158b323e0"), null, null, null, "De fysieke omgeving van de faciliteit wordt bewaakt op mogelijke gebeurtenissen op het gebied van informatie-/cyberbeveiliging.", "DE.CM-2.1", 0, new Guid("47a5caef-9f2e-415a-98b7-84d575267c99"), null },
                    { new Guid("68a7b99b-9f22-4785-b8c3-76c32b3f3b93"), null, null, null, "Bedreigingen en kwetsbaarheden moeten worden geïdentificeerd.", "ID.RA-1.1", 0, new Guid("326bc5e6-d058-47ce-b095-3e9edf66645d"), null },
                    { new Guid("6a4112c9-f3e7-4f8b-9d84-b09758ab8e13"), null, null, null, "Alle verbindingen binnen de ICT/OT-omgeving van de organisatie en met andere interne platforms van de organisatie moeten in kaart worden gebracht, gedocumenteerd, goedgekeurd en waar nodig bijgewerkt.", "ID.AM-3.2", 0, new Guid("e27de27d-3caa-4ec5-9ed6-b5fc0ecf2a29"), null },
                    { new Guid("6bb43bd6-1994-41b3-b485-c6bbbcf88c35"), null, null, null, "De organisatie moet controleren en scannen op kwetsbaarheden in haar kritieke systemen en gehoste applicaties en ervoor zorgen dat de systeemfuncties niet negatief worden beïnvloed door het scanproces.", "DE.CM-8.1", 0, new Guid("b5f16d89-0c08-4d97-848a-d93df20a73b7"), null },
                    { new Guid("759cfaf3-c3f1-40fc-bc6f-8ce409d20de2"), null, null, null, "De functionaliteit voor activiteitenregistratie van beveiligings-/detectiehardware of -software (bijv. firewalls, antivirus) worden ingeschakeld, back-ups worden gemaakt en herzien.", "DE.AE-3.1", 0, new Guid("66ac4acc-78f5-43e7-90fd-81f3bf302988"), null },
                    { new Guid("766cf4a1-10cb-4d40-8235-694af2ab87a3"), null, null, null, "Firewalls moeten worden geïnstalleerd en gebruikt op de netwerkgrenzen en worden aangevuld met firewallbescherming op de eindpunten.", "DE.CM-1.1", 0, new Guid("9cb33945-5d3b-42f5-9afb-2b867da7a96d"), null },
                    { new Guid("76edcf60-00ad-4bdf-9cc5-d9e360f9d2a6"), null, null, null, "De organisatie moet de bedrijfskritische systemen zo configureren dat ze alleen essentiële mogelijkheden bieden.", "PR.PT-3.1", 0, new Guid("0844488b-dd64-4391-8639-915364440548"), null },
                    { new Guid("79493440-1f3f-40c9-a8c1-cf94c3fe2698"), null, null, null, "Niemand heeft beheerdersrechten voor dagelijkse taken.", "PR.AC-4.4", 0, new Guid("f4ad5b18-d5b6-4ebb-ae8a-769c79aa7947"), null },
                    { new Guid("796f629b-3851-4e97-80f2-605ebc5971ec"), null, null, null, "Een cyberrisicobeheerproces dat de belangrijkste interne en externe belanghebbenden identificeert en het aanpakken van risicogerelateerde kwesties en informatie vergemakkelijkt, moet worden gecreëerd, gedocumenteerd, herzien, goedgekeurd en bijgewerkt wanneer zich wijzigingen voordoen.", "ID.RM-1.1", 0, new Guid("43c21f64-cdb3-4029-86f2-89c6fb3ce6e5"), null },
                    { new Guid("7ab75ed1-b3f6-4aa9-9422-a82bf53eb68f"), null, null, null, "Patches en beveiligingsupdates voor besturingssystemen en kritieke systeemonderdelen moeten worden geïnstalleerd.", "PR.MA-1.1", 0, new Guid("caf1fa04-f1af-4d13-822e-b90985227fd0"), null },
                    { new Guid("7b0f2316-05bd-485c-aa51-910fa79dd766"), null, null, null, "Er moet een proces worden vastgesteld om kwetsbaarheden van de bedrijfskritische systemen van de organisatie continu te bewaken, te identificeren en te documenteren.", "ID.RA-1.2", 0, new Guid("326bc5e6-d058-47ce-b095-3e9edf66645d"), null },
                    { new Guid("7d570c75-7f8a-4329-a3cb-504759e23d94"), null, null, null, "Logboeken moeten worden bijgehouden, gedocumenteerd en herzien.", "PR.PT-1.1", 0, new Guid("ee422e01-c4e1-4cf0-a78a-f5647928d767"), null },
                    { new Guid("7e430e7e-ce09-46e4-a3bc-b31cec13803a"), null, null, null, "De organisatie moet de respons- en herstelplannen bijwerken om veranderingen in de context aan te pakken.", "RS.IM-2.1", 0, new Guid("b30237ac-9af6-4094-86b5-491d002967a0"), null },
                    { new Guid("808b99d3-c71f-472d-bbd2-e28326b569ad"), null, null, null, "Softwaregebruik en -installatiebeperkingen moeten worden afgedwongen.", "DE.CM-3.3", 0, new Guid("0b724057-dbb0-4128-9ce4-d4d8d9ea9a5b"), null },
                    { new Guid("80a36e96-73fe-4610-84ae-a25d8c1f873d"), null, null, null, "De organisatie moet ervoor zorgen dat de nodige maatregelen worden genomen om verlies, misbruik, schade of diefstal van bedrijfsmiddelen tegen te gaan.", "PR.DS-3.3", 0, new Guid("3ce5b82f-a3e5-4f8c-9197-74ed354628d7"), null },
                    { new Guid("80b061ae-0cac-485b-a6c7-ab5a9ac1c68b"), null, null, null, "De organisatie moet centraliseren en coördineren hoe informatie wordt verspreid en beheren hoe de organisatie aan het publiek wordt gepresenteerd.", "RC.CO-1.1", 0, new Guid("66d3eaae-ca38-4f2e-9ea3-063bdc24177a"), null },
                    { new Guid("83874e59-4a43-4a80-86d8-d4566e49fd4d"), null, null, null, "Wijzigingen moeten worden getest en gevalideerd voordat ze worden geïmplementeerd in operationele systemen.", "PR.IP-3.1", 0, new Guid("d8c91a0e-75e2-4993-89c6-8864e4b84c51"), null },
                    { new Guid("84ecc859-3941-46db-8863-2ce8d0240459"), null, null, null, "Capaciteitsplanning moet ervoor zorgen dat er voldoende middelen zijn voor de kritische systeeminformatieverwerking, netwerken, telecommunicatie en gegevensopslag van de organisatie.", "PR.DS-4.1", 0, new Guid("1862fcd7-12a3-4891-90f5-4dfcf0969950"), null },
                    { new Guid("87dba439-3072-4aec-bed0-cac62755b6eb"), null, null, null, "De organisatie moet geautomatiseerde mechanismen en door het systeem gegenereerde waarschuwingen implementeren om eventdetectie te ondersteunen en te helpen bij het vaststellen van drempelwaarden voor beveiligingswaarschuwingen.", "DE.AE-5.1", 0, new Guid("27318d56-fb6a-4fbc-8730-7b797bea5f69"), null },
                    { new Guid("882a7820-6a3e-4c87-9419-1b96d360508c"), null, null, null, "Web- en e-mailfilters moeten worden geïnstalleerd en gebruikt.", "PR.PT-4.1", 0, new Guid("3ba0913c-157d-4c00-9a01-3d67e50fc63c"), null },
                    { new Guid("88b3367f-79f1-490f-a8b3-8c23f416a26e"), null, null, null, "Prioriteiten voor de missie, doelstellingen en activiteiten van de organisatie worden vastgesteld en gecommuniceerd.", "ID.BE-3.1", 0, new Guid("a5fde2ed-106a-4b2c-85d1-60d5ee5080ca"), null },
                    { new Guid("8bc9bb11-c6f3-48ab-bcc4-62487ec15853"), null, null, null, "Eindpunt- en netwerkbeschermingstools om het gedrag van eindgebruikers te controleren op gevaarlijke activiteiten moeten worden geïmplementeerd.", "DE.CM-3.1", 0, new Guid("0b724057-dbb0-4128-9ce4-d4d8d9ea9a5b"), null },
                    { new Guid("8c64cc64-100b-4a48-8ad6-8a9338d72c1d"), null, null, null, "De organisatie deelt informatie/informatie over cyberbeveiligingsincidenten met relevante belanghebbenden zoals voorzien in het incidentbestrijdingsplan.", "RS.CO-3.2", 0, new Guid("f764d524-c037-4dca-8103-58b1875caf33"), null },
                    { new Guid("926bb478-97ef-4315-a450-54822caa2e32"), null, null, null, "Incidentbestrijdingsplannen (Incident Response en Business Continuity) en herstelplannen (Incident Recovery en Disaster Recovery) moeten worden opgesteld, onderhouden, goedgekeurd en getest om de effectiviteit van de plannen en de gereedheid om de plannen uit te voeren te bepalen.", "PR.IP-9.1", 0, new Guid("5e12f636-163c-4781-99a1-c2efd008c7cc"), null },
                    { new Guid("93d64234-58c1-491c-95ea-beff622d0aaa"), null, null, null, "Waar nodig moet de netwerkintegriteit van de kritieke systemen van de organisatie worden beschermd door netwerksegmentatie en -segregatie.", "PR.AC-5.2", 0, new Guid("2cde404a-7546-4c6a-8e21-354e8cdc9d51"), null },
                    { new Guid("9652880c-9288-4551-a853-fd9dbe970d18"), null, null, null, "Wanneer niet-geautoriseerde software wordt gedetecteerd, wordt deze in quarantaine geplaatst voor mogelijke uitzonderingsbehandeling, verwijderd of vervangen en wordt de inventaris dienovereenkomstig bijgewerkt.", "ID.AM-2.4", 0, new Guid("62b42d7a-45ed-473d-a9b8-a195131a518c"), null },
                    { new Guid("96c417e1-6ef1-4c2c-bd24-5e901558668c"), null, null, null, "Firewalls moeten worden geïnstalleerd en geactiveerd op alle netwerken van de organisatie.", "PR.AC-5.1", 0, new Guid("2cde404a-7546-4c6a-8e21-354e8cdc9d51"), null },
                    { new Guid("9807d40a-a5ca-46cc-a533-dac518b99102"), null, null, null, "De organisatie moet herstelactiviteiten communiceren aan vooraf gedefinieerde belanghebbenden, uitvoerende en managementteams.", "RC.CO-3.1", 0, new Guid("683cf835-1ff6-42db-8b57-6be000b243f9"), null },
                    { new Guid("98d4071f-c638-4b81-9f1e-4deac33aefcc"), null, null, null, "Als onderdeel van het algehele risicobeheer van het bedrijf moet een alomvattende strategie voor het beheer van informatiebeveiliging en cyberbeveiligingsrisico's worden ontwikkeld en bijgewerkt wanneer zich veranderingen voordoen.", "ID.GV-4.1", 0, new Guid("da13781d-bb4b-4fbc-83c8-4a3929e5c3c3"), null },
                    { new Guid("9a04c25a-e54e-48bd-91da-a2db462cea69"), null, null, null, "De organisatie onderzoekt informatie-/cyberbeveiligingsmeldingen van detectiesystemen.", "RS.AN-1.1", 0, new Guid("bd45c860-c928-4711-9a97-47a4b47d1c2c"), null },
                    { new Guid("9bc4f089-5fe8-4d89-89a7-21ed8c17dcf0"), null, null, null, "Op basis van de resultaten van de risicobeoordeling van de cybertoeleveringsketen wordt een contractueel kader voor leveranciers en externe partners opgesteld om het delen van gevoelige informatie en gedistribueerde en onderling verbonden ICT/OT-producten en -diensten aan te pakken.", "ID.SC-3.1", 0, new Guid("96ff9f50-7168-44a4-9265-e7c8adbcd31e"), null },
                    { new Guid("9d247ffc-870f-4ef2-8392-41683ebf71e5"), null, null, null, "De organisatie moet herstelactiviteiten communiceren aan vooraf gedefinieerde belanghebbenden, uitvoerende en managementteams.", "RC.CO-3.1", 0, new Guid("abe79008-12a4-4b75-a901-e29e958415fd"), null },
                    { new Guid("9d52d53b-fd5e-4156-af85-e83e9cb4cc93"), null, null, null, "De organisatie moet beleid en procedures definiëren, implementeren en handhaven met betrekking tot nood- en veiligheidssystemen, brandbeveiligingssystemen en omgevingscontroles voor haar kritieke systemen.", "PR.IP-5.1", 0, new Guid("35716ca1-54f4-4da1-9f4c-549b864fbd7f"), null },
                    { new Guid("9e4b6f68-4dbf-44d1-b798-12e9a2aeba27"), null, null, null, "De organisatie moet evaluaties uitvoeren na een incident om de lessen te analyseren die zijn geleerd uit de reactie op een incident en het herstel, en vervolgens processen / procedures / technologieën verbeteren om de cyberweerbaarheid te vergroten.", "RS.IM-1.1", 0, new Guid("c1af763e-8934-4a88-9f17-6e2483499cc9"), null },
                    { new Guid("a1f16179-0c59-499b-ae7a-2c5562b50bfb"), null, null, null, "Om de cyberweerbaarheid te ondersteunen en de levering van kritieke diensten te beveiligen, worden de nodige vereisten geïdentificeerd, gedocumenteerd en hun implementatie getest en goedgekeurd.", "ID.BE-5.1", 0, new Guid("9a94b93d-029e-42d6-866f-0c24c5af6729"), null },
                    { new Guid("a5f89632-0b30-4d29-8ea8-e4d11ffb16ae"), null, null, null, "De organisatie werkt samen en deelt informatie over haar kritieke systeemgerelateerde beveiligingsincidenten en risicobeperkende maatregelen met aangewezen partners.", "PR.IP-8.1", 0, new Guid("5e7d5a1c-5030-4084-a1af-4708325c3d74"), null },
                    { new Guid("ae5c9032-a954-4d2b-a8a1-e3e5486f2762"), null, null, null, "Externe leveranciers zijn verplicht om elke overplaatsing, beëindiging of overgang van personeel met fysieke of logische toegang tot bedrijfskritische systeemonderdelen van de organisatie te melden.", "PR.AT-3.2", 0, new Guid("7efe7130-a8d9-40f8-a058-bbb7752ffb90"), null },
                    { new Guid("afbda759-0a50-4b4e-b5ae-2fc663cccd15"), null, null, null, "De organisatie dient acceptabele en onacceptabele mobiele code en mobiele code technologieën te definiëren; en het gebruik van mobiele code binnen het systeem te autoriseren, monitoren en controleren.", "DE.CM-5.1", 0, new Guid("e15c1640-1562-4428-976f-2cd8968293a7"), null },
                    { new Guid("b2dd876c-765a-452b-acb9-6edbdb60643c"), null, null, null, "De personen die verantwoordelijk en aansprakelijk zijn voor het beheer van softwareplatforms en applicaties binnen de organisatie moeten worden geïdentificeerd.", "ID.AM-2.3", 0, new Guid("62b42d7a-45ed-473d-a9b8-a195131a518c"), null },
                    { new Guid("b32bdde8-709a-4059-bb08-d68c07ce6d35"), null, null, null, "Bij het beheer van toegangsrechten moet scheiding van taken (SoD) worden gewaarborgd.", "PR.AC-4.6", 0, new Guid("f4ad5b18-d5b6-4ebb-ae8a-769c79aa7947"), null },
                    { new Guid("b388ea1b-71bb-41b9-a8bf-04c66d00c708"), null, null, null, "Auditgegevens van de kritische systemen van de organisatie moeten worden verplaatst naar een alternatief systeem.", "PR.DS-4.2", 0, new Guid("1862fcd7-12a3-4891-90f5-4dfcf0969950"), null },
                    { new Guid("b5c83be0-e623-4b3e-9698-45aed1e7eb3d"), null, null, null, "Beleid en procedures voor informatiebeveiliging en cyberveiligheid worden opgesteld, gedocumenteerd, beoordeeld, goedgekeurd en bijgewerkt wanneer zich wijzigingen voordoen.", "ID.GV-1.1", 0, new Guid("23d6735c-e53a-4d13-943d-193d26fa5ccd"), null },
                    { new Guid("b87e5d78-3342-4bad-97ba-e126547b04be"), null, null, null, "Waar nodig moet de netwerkintegriteit van de kritieke systemen van de organisatie worden beschermd door (1) Verbindingen tussen systeemcomponenten identificeren, documenteren en controleren. (2) Externe verbindingen naar kritieke systemen van de organisatie beperken. ", "PR.AC-5.3", 0, new Guid("2cde404a-7546-4c6a-8e21-354e8cdc9d51"), null },
                    { new Guid("b8c06ce6-82c3-4096-8542-0255127ecd20"), null, null, null, "De organisatie moet een basisconfiguratie voor de bedrijfskritische systemen ontwikkelen, documenteren en onderhouden.", "PR.IP-1.1", 0, new Guid("5bed0913-70b5-42e1-bbb9-24478ad9dca3"), null },
                    { new Guid("b92941fe-155b-4ec7-b032-d340bc0deeb9"), null, null, null, "De organisatie moet een gedocumenteerd proces opstellen en bijhouden dat een voortdurende evaluatie van kwetsbaarheden en strategieën om deze te verminderen mogelijk maakt.", "PR.IP-12.1", 0, new Guid("05b68187-2321-4265-8a7d-785ee89bfd0a"), null },
                    { new Guid("b9770b46-355f-48dc-aa1c-7134fd39423e"), null, null, null, "Werknemers moeten de juiste training krijgen.", "PR.AT-1.1", 0, new Guid("00b0546a-188c-46e7-b7ff-8170d44d91e1"), null },
                    { new Guid("bd153087-140f-4871-91ca-62000f5c9f8d"), null, null, null, "De naleving door externe dienstverleners van het beleid en de procedures voor de beveiliging van het personeel en de beveiligingseisen van het contract worden gecontroleerd met betrekking tot hun risico's op het gebied van cyberbeveiliging.", "DE.CM-6.2", 0, new Guid("99b739ae-770a-4777-8176-6014ce82cf4f"), null },
                    { new Guid("bfbd939b-e5ef-4a1b-b3dd-b999ebb6058f"), null, null, null, "De organisatie moet software-, firmware- en informatie-integriteitscontroles implementeren om ongeautoriseerde wijzigingen in de kritieke systeemcomponenten tijdens opslag, transport en opstarten te detecteren en wanneer dit nodig is.", "PR.DS-6.1", 0, new Guid("a27a9dcd-2763-41a2-90f8-6882a8f76863"), null },
                    { new Guid("c00dfe44-f9e8-4bbf-9044-37315da30351"), null, null, null, "De organisatie moet ervoor zorgen dat gebeurtenisgegevens worden verzameld en gecorreleerd over de kritieke systemen met behulp van verschillende bronnen, zoals gebeurtenisrapporten, auditmonitoring, netwerkmonitoring, fysieke toegangsmonitoring en gebruikers-/beheerdersrapporten.", "DE.AE-3.2", 0, new Guid("66ac4acc-78f5-43e7-90fd-81f3bf302988"), null },
                    { new Guid("c27fdf1f-f56b-4d4a-86bc-f20a65b14ced"), null, null, null, "Personeel dat toegang heeft tot de meest kritieke informatie of technologie van de organisatie moet worden geverifieerd.", "PR.IP-11.1", 0, new Guid("47185c82-5e80-4978-8ee8-8286780b8eb7"), null },
                    { new Guid("c9e8be0a-803a-4723-99d7-73d13294a417"), null, null, null, "De rol van de organisatie in kritieke infrastructuur en de sector bepalen de risicobereidheid van de organisatie.", "ID.RM-3.1", 0, new Guid("dbccbcb1-c12d-4614-8188-9859724da993"), null },
                    { new Guid("caab0350-79c1-4410-aefd-9497d288a019"), null, null, null, "De organisatie moet centraliseren en coördineren hoe informatie wordt verspreid en beheren hoe de organisatie aan het publiek wordt gepresenteerd.", "RC.CO-1.1", 0, new Guid("3d101931-d5e0-4526-8b10-2a7b0e8bc1c8"), null },
                    { new Guid("cea9a9be-6d4b-4967-98c5-23b516cb5a02"), null, null, null, "De rol van de organisatie in de toeleveringsketen moet worden vastgesteld, gedocumenteerd en gecommuniceerd.", "ID.BE-1.1", 0, new Guid("428d2230-4839-4f52-88d6-3793f86346e8"), null },
                    { new Guid("cfb37085-51d8-4827-b32e-19243f407fbc"), null, null, null, "De inventaris van bedrijfsmiddelen die verband houden met informatie en informatieverwerkingsfaciliteiten moet veranderingen in de  context van de organisatie weerspiegelen  en alle informatie bevatten die nodig is voor effectieve verantwoording.", "ID.AM-1.2", 0, new Guid("f31e0f28-89c7-4b31-8487-bc2b5985694e"), null },
                    { new Guid("cfc7aba7-d815-4ea0-8e51-2a27a70dd1e6"), null, null, null, "Wanneer ongeautoriseerde hardware wordt gedetecteerd, wordt deze in quarantaine geplaatst voor mogelijke uitzonderingsbehandeling, verwijderd of vervangen en wordt de inventaris bijgewerkt.", "ID.AM-1.3", 0, new Guid("f31e0f28-89c7-4b31-8487-bc2b5985694e"), null },
                    { new Guid("d0c2785c-b3b2-4fd3-b592-4e5350ed2a98"), null, null, null, "Er moet een bewustwordingsprogramma voor bedreigingen en kwetsbaarheden worden geïmplementeerd dat de mogelijkheid omvat om informatie uit te wisselen tussen organisaties.", "ID.RA-2.1", 0, new Guid("755060fa-c759-46d6-a29e-c32ac8b33485"), null },
                    { new Guid("d10122d2-f14d-49bc-92a9-a9d061d4c34a"), null, null, null, "Informatie-/cyberbeveiligingsincidenten worden gecategoriseerd op basis van de ernst en impact overeenkomstig de evaluatiecriteria in het incidentbestrijdingsplan.", "RS.AN-4.1", 0, new Guid("196af6aa-b118-4e73-9bb8-cc142218249d"), null },
                    { new Guid("d18d1cbd-7aff-4b6d-8ff9-d929ab905250"), null, null, null, "De organisatie controleert beoordelingen van de naleving van contractuele verplichtingen door leveranciers en externe partners door routinematig audits, testresultaten en andere evaluaties te controleren.", "ID.SC-4.1", 0, new Guid("829b5f0e-c4c0-420d-8fce-1bb0dd92df00"), null },
                    { new Guid("d47645ee-9a2b-4871-8b7d-303b83b256b7"), null, null, null, "Informatie/informatie over cyberbeveiligingsincidenten moet worden gecommuniceerd en gedeeld met de werknemers van de organisatie in een formaat dat zij kunnen begrijpen.", "RS.CO-3.1", 0, new Guid("f764d524-c037-4dca-8103-58b1875caf33"), null },
                    { new Guid("d9886e54-b630-49ff-9acc-f1d17507221b"), null, null, null, "Antivirus-, -spyware- en andere -malwareprogramma's moeten worden geïnstalleerd en bijgewerkt.", "DE.CM-4.1", 0, new Guid("0a6f698d-69f4-4096-829e-d718e718ead1"), null },
                    { new Guid("d9a38a98-3c21-49dc-aaef-27f99a97000e"), null, null, null, "Wettelijke en regelgevende vereisten met betrekking tot informatie-/cyberbeveiliging, waaronder privacyverplichtingen, worden begrepen en geïmplementeerd.", "ID.GV-3.1", 0, new Guid("5fe22d16-eba1-4c3b-aa0e-d769d3178ba6"), null },
                    { new Guid("dc23965f-dc1b-419b-8a57-2576583baea0"), null, null, null, "Onderhoud op afstand mag alleen plaatsvinden na voorafgaande goedkeuring, toezicht om onbevoegde toegang te voorkomen en goedkeuring van het resultaat van de onderhoudsactiviteiten zoals beschreven in goedgekeurde processen of procedures.", "PR.MA-2.1", 0, new Guid("a486436b-c608-4fca-bd20-e3de96e14c04"), null },
                    { new Guid("dd282080-3c09-44fa-9d06-bf8955624cd9"), null, null, null, "De gebruiksbeperking van draagbare opslagmedia moet worden gewaarborgd door middel van een geschikt gedocumenteerd beleid en ondersteunende waarborgen.", "PR.PT-2.1", 0, new Guid("597a3eea-258b-431e-a5ba-e057b88257bd"), null },
                    { new Guid("e1166e4b-3d89-47a8-9dc0-fc112d26d463"), null, null, null, "De organisatie dient beveiligingscontroles te verifiëren na hardwareonderhoud of -reparaties en indien nodig actie te ondernemen.", "PR.MA-1.4", 0, new Guid("caf1fa04-f1af-4d13-822e-b90985227fd0"), null },
                    { new Guid("e17c30d8-d3b9-4afb-974f-ae9e510de7e8"), null, null, null, "De organisatie moet de lessen die zijn geleerd uit herstelactiviteiten bij incidenten verwerken in bijgewerkte of nieuwe herstelprocedures voor systemen en dit, na het testen, omlijsten met de juiste training.", "RC.IM-1.1", 0, new Guid("877ff2fe-327b-4e39-8284-078f745f902f"), null },
                    { new Guid("e35e4fb8-a50d-4e4a-8f1f-ea0c5d2539d3"), null, null, null, "De organisatie moet goedkeuringsvereisten, controle en toezicht afdwingen voor onderhoudsgereedschappen voor gebruik op de kritieke systemen.", "PR.MA-1.3", 0, new Guid("caf1fa04-f1af-4d13-822e-b90985227fd0"), null },
                    { new Guid("e4e4d3e4-436e-4892-aadc-5485379c3808"), null, null, null, "De organisatie moet rapportages implementeren over informatie-/cyberbeveiligingsincidenten op haar kritieke systemen binnen een door de organisatie gedefinieerd tijdsbestek aan door de organisatie gedefinieerd personeel of door de organisatie gedefinieerde rollen.", "RS.CO-2.1", 0, new Guid("4f7a5503-ea4c-4930-955c-e7a796186f8e"), null },
                    { new Guid("e59bf860-6e4e-49ad-b65f-bf2377a523d1"), null, null, null, "De organisatie moet alle externe services en de verbindingen die ermee zijn gemaakt in kaart brengen, documenteren, autoriseren en bij wijzigingen bijwerken.", "ID.AM-4.1", 0, new Guid("76127fb4-96d6-4756-a9ba-cde96ce6d8bd"), null },
                    { new Guid("e9515c9c-97d1-4730-81a2-3a7b03aac7ee"), null, null, null, "De organisatie moet gedocumenteerde procedures implementeren voor het verifiëren van de identiteit van personen voordat referenties worden uitgegeven die toegang geven tot de systemen van de organisatie.", "PR.AC-7.1", 0, new Guid("248e1d27-5e8a-40be-bf6f-2c0350cc9940"), null },
                    { new Guid("f0812001-74c2-4c5a-85fc-d2cfa6c7f758"), null, null, null, "Het beheer van fysieke toegang omvat maatregelen met betrekking tot toegang in noodsituaties.", "PR.AC-2.2", 0, new Guid("ddb5aef4-1f11-4d69-9205-d3c77b82f762"), null },
                    { new Guid("f3409c8c-e943-4d7e-968c-1b95ae82f145"), null, null, null, "De organisatie moet de belangrijkste medewerkers van leveranciers en externe partners identificeren en documenteren om hen als belanghebbenden te betrekken bij de reactie- en herstelplanningsactiviteiten.", "ID.SC-5.1", 0, new Guid("08814892-1f8a-42cf-8fbc-4703a878dd89"), null },
                    { new Guid("f4983a26-5a20-4446-bfc8-262563fa448b"), null, null, null, "De organisatie coördineert de respons op informatie-/cyberbeveiligingsincidenten met alle vooraf gedefinieerde belanghebbenden.", "RS.CO-4.1", 0, new Guid("52648ebd-a57b-4b63-9783-46e273fe8f88"), null },
                    { new Guid("f4ee2ff6-12f6-4af7-88ed-a4cd58d5cce1"), null, null, null, "Grondig onderzoek en analyse van de resultaten vormen de basis voor een volledig begrip van de gevolgen van het informatie-/cyberbeveiligingsincident.", "RS.AN-2.1", 0, new Guid("897fb6e3-0a01-42be-801a-fd75e353dd5c"), null },
                    { new Guid("f5bddf15-6b44-4af8-9547-4eace6324ed9"), null, null, null, "De inventarisatie van softwareplatforms en applicaties die verband houden met informatie en informatieverwerking moet veranderingen in de  context van de organisatie weerspiegelen  en alle informatie bevatten die nodig is voor effectieve verantwoording.", "ID.AM-2.2", 0, new Guid("62b42d7a-45ed-473d-a9b8-a195131a518c"), null },
                    { new Guid("f66ad1b0-d27a-4757-b1dd-e85ef8764ee1"), null, null, null, "De organisatie moet passende acties ondernemen die resulteren in de bewaking van haar kritieke systemen aan de buitengrenzen en kritieke interne punten wanneer ongeautoriseerde toegang en activiteiten, inclusief gegevenslekken, worden gedetecteerd.", "PR.DS-5.1", 0, new Guid("cd443392-46ee-4cfd-9a3a-8295ff49cb88"), null },
                    { new Guid("f6b5278f-7b71-4590-a4d9-9a1f651bf552"), null, null, null, "Er moet worden vastgesteld wie toegang moet hebben tot de bedrijfskritische informatie en technologie van de organisatie en de middelen om toegang te krijgen.", "PR.AC-4.2", 0, new Guid("f4ad5b18-d5b6-4ebb-ae8a-769c79aa7947"), null },
                    { new Guid("f7753bf1-567b-44d4-9bf0-45d882e6a9df"), null, null, null, "Alle externe verbindingen door leveranciers die IT/OT-toepassingen of -infrastructuur ondersteunen, moeten worden beveiligd en actief worden bewaakt om ervoor te zorgen dat tijdens de verbinding alleen toegestane acties plaatsvinden.", "DE.CM-6.1", 0, new Guid("99b739ae-770a-4777-8176-6014ce82cf4f"), null },
                    { new Guid("fc5f576b-1e32-4536-a337-44a98003eaaf"), null, null, null, "GEEN VEREISTEN / Te overwegen richtlijnen", "", 0, new Guid("a97f9ba0-c00f-4136-ba1a-17043173ac36"), null },
                    { new Guid("fd717d19-c366-4789-8b00-d6684362c09a"), null, null, null, "Er wordt een aparte alternatieve opslaglocatie voor back-ups van het systeem gebruikt en dezelfde veiligheidswaarborgen als de primaire opslaglocatie worden toegepast", "PR.IP-4.3", 0, new Guid("f0b125a3-4cee-4236-888a-71fbb081be62"), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assessments_AssessorId",
                table: "Assessments",
                column: "AssessorId");

            migrationBuilder.CreateIndex(
                name: "IX_Assessments_MaturityId",
                table: "Assessments",
                column: "MaturityId");

            migrationBuilder.CreateIndex(
                name: "IX_Assessments_MunicipalityId",
                table: "Assessments",
                column: "MunicipalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Assessments_UserId",
                table: "Assessments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_FunctionId",
                table: "Categories",
                column: "FunctionId");

            migrationBuilder.CreateIndex(
                name: "IX_Guidances_RequirementId",
                table: "Guidances",
                column: "RequirementId");

            migrationBuilder.CreateIndex(
                name: "IX_MaturityLevels_MaturityId",
                table: "MaturityLevels",
                column: "MaturityId");

            migrationBuilder.CreateIndex(
                name: "IX_Requirements_SubCategoryId",
                table: "Requirements",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_AssessmentId",
                table: "Scores",
                column: "AssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Guidances");

            migrationBuilder.DropTable(
                name: "MaturityLevels");

            migrationBuilder.DropTable(
                name: "Scores");

            migrationBuilder.DropTable(
                name: "Assessments");

            migrationBuilder.DropTable(
                name: "Requirements");

            migrationBuilder.DropTable(
                name: "Maturities");

            migrationBuilder.DropTable(
                name: "Municipalities");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Functions");
        }
    }
}
