using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ElectronicJournal_DataBase.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccessLevels",
                columns: table => new
                {
                    AccessLevelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccessLevelName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessLevels", x => x.AccessLevelId);
                });

            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    BuildingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.BuildingId);
                    table.UniqueConstraint("AK_Buildings_BuildingName", x => x.BuildingName);
                });

            migrationBuilder.CreateTable(
                name: "LessonTypes",
                columns: table => new
                {
                    LessonTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LessonTypeName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonTypes", x => x.LessonTypeId);
                    table.UniqueConstraint("AK_LessonTypes_LessonTypeName", x => x.LessonTypeName);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    PositionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.PositionId);
                    table.UniqueConstraint("AK_Positions_PositionName", x => x.PositionName);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    SubjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.SubjectId);
                    table.UniqueConstraint("AK_Subjects_SubjectName", x => x.SubjectName);
                });

            migrationBuilder.CreateTable(
                name: "TimeSchedules",
                columns: table => new
                {
                    TimeScheduleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeInterval = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSchedules", x => x.TimeScheduleId);
                    table.UniqueConstraint("AK_TimeSchedules_TimeInterval", x => x.TimeInterval);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Login = table.Column<string>(maxLength: 30, nullable: false),
                    PasswordHash = table.Column<string>(nullable: false),
                    PasswordSalt = table.Column<string>(nullable: false),
                    AccessLevelId = table.Column<int>(nullable: true),
                    Phone = table.Column<string>(maxLength: 12, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.UniqueConstraint("AK_Users_Login", x => x.Login);
                    table.ForeignKey(
                        name: "FK_Users_AccessLevels_AccessLevelId",
                        column: x => x.AccessLevelId,
                        principalTable: "AccessLevels",
                        principalColumn: "AccessLevelId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Classrooms",
                columns: table => new
                {
                    ClassroomId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassroomName = table.Column<string>(nullable: true),
                    BuildingId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classrooms", x => x.ClassroomId);
                    table.ForeignKey(
                        name: "FK_Classrooms_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "BuildingId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    GroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(nullable: false),
                    YearFormationGroup = table.Column<DateTime>(nullable: false),
                    StarostaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.GroupId);
                    table.UniqueConstraint("AK_Groups_GroupName", x => x.GroupName);
                    table.ForeignKey(
                        name: "FK_Groups_Users_StarostaId",
                        column: x => x.StarostaId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    PositionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherId);
                    table.UniqueConstraint("AK_Teachers_UserId", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Teachers_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "PositionId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Teachers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    LessonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    TimeScheduleId = table.Column<int>(nullable: true),
                    SubjectId = table.Column<int>(nullable: false),
                    LessonTypeId = table.Column<int>(nullable: true),
                    ClassroomId = table.Column<int>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.LessonId);
                    table.ForeignKey(
                        name: "FK_Lessons_Classrooms_ClassroomId",
                        column: x => x.ClassroomId,
                        principalTable: "Classrooms",
                        principalColumn: "ClassroomId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Lessons_LessonTypes_LessonTypeId",
                        column: x => x.LessonTypeId,
                        principalTable: "LessonTypes",
                        principalColumn: "LessonTypeId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Lessons_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lessons_TimeSchedules_TimeScheduleId",
                        column: x => x.TimeScheduleId,
                        principalTable: "TimeSchedules",
                        principalColumn: "TimeScheduleId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "StudentGroups",
                columns: table => new
                {
                    StudentGroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    GroupId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentGroups", x => x.StudentGroupId);
                    table.UniqueConstraint("AK_StudentGroups_UserId", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_StudentGroups_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentGroups_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AcademicPerformances",
                columns: table => new
                {
                    AcademicPerformanceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    LessonId = table.Column<int>(nullable: false),
                    Mark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicPerformances", x => x.AcademicPerformanceId);
                    table.ForeignKey(
                        name: "FK_AcademicPerformances_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "LessonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcademicPerformances_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupLessons",
                columns: table => new
                {
                    GroupLessonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LessonId = table.Column<int>(nullable: false),
                    GroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupLessons", x => x.GroupLessonId);
                    table.ForeignKey(
                        name: "FK_GroupLessons_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupLessons_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "LessonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherLessons",
                columns: table => new
                {
                    TeacherLessonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherId = table.Column<int>(nullable: false),
                    LessonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherLessons", x => x.TeacherLessonId);
                    table.ForeignKey(
                        name: "FK_TeacherLessons_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "LessonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherLessons_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AccessLevels",
                columns: new[] { "AccessLevelId", "AccessLevelName" },
                values: new object[,]
                {
                    { 1, "Студент" },
                    { 2, "Староста" },
                    { 3, "Преподаватель" },
                    { 4, "Деканат" },
                    { 5, "Админ" }
                });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "BuildingId", "BuildingName" },
                values: new object[,]
                {
                    { 1, "Оршанская" },
                    { 2, "ИНЖЭКИН" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "GroupName", "StarostaId", "YearFormationGroup" },
                values: new object[,]
                {
                    { 1, "М3О-335Б-17", null, new DateTime(2017, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "М3О-333Б-17", null, new DateTime(2017, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LessonTypes",
                columns: new[] { "LessonTypeId", "LessonTypeName" },
                values: new object[,]
                {
                    { 1, "Лекция" },
                    { 2, "Практическое занятие" },
                    { 3, "Лабораторная работа" },
                    { 4, "Экзамен" },
                    { 5, "Зачет" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "PositionId", "PositionName" },
                values: new object[,]
                {
                    { 5, "Профессор" },
                    { 4, "Доцент" },
                    { 1, "Лаборант" },
                    { 2, "Преподаватель" },
                    { 3, "Старший преподаватель" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "SubjectName" },
                values: new object[,]
                {
                    { 1, "Web-программирование" },
                    { 2, "Программирование в информационных системах" },
                    { 3, "Машинно-ориентированное программирование" },
                    { 4, "Операционные системы" }
                });

            migrationBuilder.InsertData(
                table: "TimeSchedules",
                columns: new[] { "TimeScheduleId", "TimeInterval" },
                values: new object[,]
                {
                    { 6, "18:15 – 19:45" },
                    { 1, "09:00 – 10:30" },
                    { 2, "10:45 – 12:15" },
                    { 3, "13:00 – 14:30" },
                    { 4, "14:45 – 16:15" },
                    { 5, "16:30 – 18:00" },
                    { 7, "20:00 – 21:30" }
                });

            migrationBuilder.InsertData(
                table: "Classrooms",
                columns: new[] { "ClassroomId", "BuildingId", "ClassroomName" },
                values: new object[,]
                {
                    { 6, 1, "722Б" },
                    { 5, 1, "606Б" },
                    { 4, 1, "608Б" },
                    { 3, 1, "423B" },
                    { 2, 1, "404B" },
                    { 1, 1, "403B" }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "ClassroomId", "Date", "LessonTypeId", "Notes", "SubjectId", "TimeScheduleId" },
                values: new object[,]
                {
                    { 5, null, new DateTime(2020, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, 1, 5 },
                    { 4, null, new DateTime(2020, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, 1, 4 },
                    { 7, null, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 2, 3 },
                    { 3, null, new DateTime(2020, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 1, 3 },
                    { 6, null, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 2, 2 },
                    { 2, null, new DateTime(2020, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 4, 2 },
                    { 1, null, new DateTime(2020, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 4, 1 },
                    { 8, null, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "AccessLevelId", "Email", "FirstName", "LastName", "Login", "MiddleName", "PasswordHash", "PasswordSalt", "Phone" },
                values: new object[,]
                {
                    { 12, 5, null, "Alexander", "Milakov", "Meeluck", null, "58797ABB37CCC2178C927A95325E2F8C1D747AECBC69B4D1099350B9B97113864E5659C8B3E0411B780E927D07216CF7145F7847E5FD6985DD25A5B6E1E2408C", "xz0Ktrg98tmHqGumGEBHeoLuGUq2UCKY6iGPBh5jnG0+lVBJoqZLCdU69WBokvmTMFs89N1LDIbsTr9IRiURgg==", null },
                    { 11, 4, null, "Декана", "Заместитель", "Zam_Dekan", null, "6EF6C951CF6C3D91D07A68B350E1264B5C19C10D0F72F697C963635FE751E4609B7E2C08870118F4AD5904924A84DE10887A69BCD8B088DF10A850F58DD50A93", "z+lmgdF8FacOTgZgRIHT2QUiT7oBrMErRwmGk+KRFxL14oa4oICZkBQbTxaHapEiuKAk9qi5D+BfCHe7zQsu/A==", null },
                    { 4, 4, "dekanat@mail.ru", "Dekanat", "Dekanat", "Dekanat_1", null, "0BA7212AF571F1FEA6180842357AA7676BAAF3E0294F41CF9ABDC9B03C679AED9BAF79FAE7EFA7EEB39A73236286F10480B7CB4039A132C807F5B8CAD19D03A8", "DFS/pRGdT0pRwuk4iUr9GzMRgmxln79Twzr/3gL8a90SCM7wjTVlV7y9TCwioparc75kS72Hivs5dIcJ22jBuA==", "44444444444" },
                    { 15, 3, null, "Григорий", "Семёнов", "Semenov_Grigory", "Евгеньевич", "16171BB58ABC014271058C4919C8827B2CA9879BCC1D65B1C20021630D4071CC0189CDFC17A5D55FE33503353A8A32B215918EEDB6F6AECD02DF1CA860C8F45D", "BKQXsnXCFkIEmb8nKtO0kxEZcYjwjLV1BKliBpSzFE1wSYl7fpPfNiUpYrRNup/V3UzkmVXE6yQzQ+bg390EXQ==", null },
                    { 10, 3, null, "Николай", "Балакирев", "Balakirev_N_E", "Евгеньевич", "812EDCC1525AF0EA2BA0FF686B468A87FF855951236E05778C90363919DA2F29D3915A353FB89AF29356481AB0B581606DC5E7F5DEF5E600D41CB04A2ACBD6EA", "ST33Zxq5yhpFLQw8nToe8FqHgTLPKMKF8G1QtSqPMOX+gKORkOciC4X2MZlLpTcHKPVIjPejciJC7tcn1ooOKQ==", null },
                    { 9, 3, null, "Кирилл", "Коновалов", "Konovalov_K_A", "Андреевич", "E9B2E6D6CDC890F721B353975AB5E49AAE1FBC95A37CC05C92E7FC8E7923A039590401EB44929663EA520558F8D68124A20BE37FE9D13634571A8DEB3B98730C", "BdAEwcbu7N6CUotVR4GHTrjOibo6DUU7g8ZbJpQlTnoa7i4qpn2C7uP9erWYnE6AfgA0paV/CN6Ld29DVXUMVQ==", null },
                    { 3, 3, "prepod@mail.ru", "Prepod", "Prepodovich", "Prepod_1", null, "9E20B43B77E003FC8A38CF0FFAF208E67B6F366519F4925EE75346AC0DACB92CA1BAF8538709A9E619F0A25ED29F1DEFB7952B6B7ECD552A7CBF37CD610F078E", "3h6Am61Cla2IYlCA5SgtSrbdSM8QpjxVrf80PacXl1mekurBuq6x1bzo6Zh+eIP+//RC7pKfNILccEKvUIGM1A==", "33333333333" },
                    { 13, 2, null, "Никита", "Майер", "Mayer", null, "EA24316D2E5830EC9C560E8EF8ABA67D3677E7A5B67A93B1B390ED6E66599A791FD9178F3A52712302E86E3D051D24ECF7676FA9AC331D1B188B8127ED48883B", "/b9gBtldMPEEsl+3Xl3jiPZgEBFOq+dnHuH4Co3sGkkveWCQAMdCvzapQJ6QAjzwxoXN2rCV1I7577uPyymirA==", null },
                    { 8, 2, null, "Александр", "Милаков", "Milakov_Alex", "Владимирович", "8254F989405AB0E598919689DE6D279238FFED37339F3BD7D2FA1445330840DFCAD19D6B77F4BBAB97250271410B8A8E9C7566720139B8379DCFB905CF082E16", "VrEXIDWXpFtAch+T7s1pCIp0hJBd0hnRzogFUmWoxRcwrO8/lKgL41BwzzHLFsZHVdJXDRwsJwl0OqD9n9mQlw==", null },
                    { 2, 2, "starosta@mail.ru", "Starosta", "Starostovich", "Starosta_1", null, "712D7F5B86765C784F3A4626087F160EA2C08B0A4FCEE6ECCD84075D03F64BCFDB5EC680A3303BC84A4C13DE59C460E5CCB4FB08D0567DF5FE2B81C64479E631", "gy55/06Y6SwXaRWZe26xCEcIXYvV9Zc9jeqiSU35zDhHB+Iqwe0W6Zpyj2B+amZl6QN6UZll6M3Y1erBSk7yqw==", "22222222222" },
                    { 14, 1, null, "Иван", "Волков", "Volkov", null, "114D812E6829E72248F600F2D1DFDE25D073D8457D8D28C2CFD503DDF1C59E6966D2197BF445A83585A366B72468F5AE97036F7F56C63734A0E3E6F0F9C91378", "UhNPhd77UwYiQbWz8toeuF99A1xJQC9SAs4AC57JeyYPjDVx6H/09aEVvtK4djDTqqtetjRwTdsFtAaK3Abrsw==", null },
                    { 7, 1, null, "Артем", "Корнилов", "Kornilov_Artem", null, "9D464916569CE287DBC292129946EF986207FBB052802C1AC802965F51A30658D5676607EC4C9B01FE0348A6DC40637EDE6E0EF64D85AEB820D0491643E64EEF", "you2hVgiLF+WozjeAdax2Hl4BObiS4Ji3VAhRskqf1MUHdywB6KV4QtqanbBnyHAM3oI4qPybJuMKfqNlZMFlQ==", null },
                    { 6, 1, null, "Михаил", "Аншуков", "Anshukov_Mikhail", null, "0AFD708E3B706C6B174CA488CB052C31A196C2D6137361C5F4A1ECC54E7C90ADAA8CFC85776A9360B7F80D6CE6C72B3164975319AB2654EAF3158E707B690D7A", "ClN090LUmSShW72v2iMse+lxFe/j+/kE59vBIPQn3ajBZgeUq8GLcqXDbaby9afX033T93ZN8LJvZE+hcALP7Q==", null },
                    { 5, 5, "admin@mail.ru", "Admin", "Admin", "Admin_1", null, "B93B4D70B06BA07CD6C3AD2EAF988BE0CA2CB5A7D637549AA8CB84666C2275259C0D56788C2E58FDE69BCD153662716E24A749857D93CADF82199EBF6100A767", "1kghpqv1BrSqELoluHJqUcLQJvhQVlku8B2yvyIL/bTwBV9NdjlfndZH8xF0115l840b+pg5aR6yZXStdOIB5A==", "55555555555" },
                    { 1, 1, "student@mail.ru", "Student", "Studentovich", "Student_1", null, "976BCA75A7B6265880DBEBCAB262F009ADFCF25FEAE7050E347A6449F7E23FAC61DC6DBA2F753FE9CE31817D4C67FD3BFFD27BCA9E61FDD47954036741F3B608", "lqU9irXr/QP2GweWaDuStsiYn9i5oYWCdFWizD+qReoJsgoyvPU4jQjBWfIgS6eJM+kLewksNB72eTeWMfxMMw==", "11111111111" }
                });

            migrationBuilder.InsertData(
                table: "GroupLessons",
                columns: new[] { "GroupLessonId", "GroupId", "LessonId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 6, 1, 4 },
                    { 9, 1, 7 },
                    { 5, 1, 3 },
                    { 8, 1, 6 },
                    { 4, 2, 2 },
                    { 3, 1, 2 },
                    { 2, 2, 1 },
                    { 7, 1, 5 },
                    { 10, 1, 8 }
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "StudentGroupId", "GroupId", "UserId" },
                values: new object[,]
                {
                    { 4, 2, 13 },
                    { 3, 1, 8 },
                    { 5, 2, 14 },
                    { 2, 1, 7 },
                    { 1, 1, 6 }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "PositionId", "UserId" },
                values: new object[,]
                {
                    { 3, 4, 15 },
                    { 2, 4, 10 },
                    { 1, 3, 9 }
                });

            migrationBuilder.InsertData(
                table: "TeacherLessons",
                columns: new[] { "TeacherLessonId", "LessonId", "TeacherId" },
                values: new object[,]
                {
                    { 3, 3, 1 },
                    { 4, 4, 1 },
                    { 5, 5, 1 },
                    { 6, 6, 1 },
                    { 7, 7, 1 },
                    { 9, 8, 1 },
                    { 1, 1, 3 },
                    { 2, 2, 3 },
                    { 8, 7, 3 },
                    { 10, 8, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcademicPerformances_LessonId",
                table: "AcademicPerformances",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_AcademicPerformances_UserId",
                table: "AcademicPerformances",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Classrooms_BuildingId",
                table: "Classrooms",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupLessons_GroupId",
                table: "GroupLessons",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupLessons_LessonId",
                table: "GroupLessons",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_StarostaId",
                table: "Groups",
                column: "StarostaId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_ClassroomId",
                table: "Lessons",
                column: "ClassroomId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_LessonTypeId",
                table: "Lessons",
                column: "LessonTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_SubjectId",
                table: "Lessons",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_TimeScheduleId",
                table: "Lessons",
                column: "TimeScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentGroups_GroupId",
                table: "StudentGroups",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherLessons_LessonId",
                table: "TeacherLessons",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherLessons_TeacherId",
                table: "TeacherLessons",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_PositionId",
                table: "Teachers",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AccessLevelId",
                table: "Users",
                column: "AccessLevelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcademicPerformances");

            migrationBuilder.DropTable(
                name: "GroupLessons");

            migrationBuilder.DropTable(
                name: "StudentGroups");

            migrationBuilder.DropTable(
                name: "TeacherLessons");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Classrooms");

            migrationBuilder.DropTable(
                name: "LessonTypes");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "TimeSchedules");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "AccessLevels");
        }
    }
}
