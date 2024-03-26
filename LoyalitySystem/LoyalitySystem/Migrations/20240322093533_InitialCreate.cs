using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoyalitySystem.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SSN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HomeStreet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeState = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    HomeZip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeStreet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeState = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    OfficeZip = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "HomeCity", "HomeState", "HomeStreet", "HomeZip", "Name", "OfficeCity", "OfficeState", "OfficeStreet", "OfficeZip", "SSN" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Newton,Dave R.", null, null, null, null, "384-10-6538" },
                    { 2, new DateTime(1997, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Waterman,Danielle C.", null, null, null, null, "944-39-5991" },
                    { 3, new DateTime(1928, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "DeSantis,Christen N.", null, null, null, null, "336-13-6311" },
                    { 4, new DateTime(1960, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Baker,Marvin Z.", null, null, null, null, "198-22-7709" },
                    { 5, new DateTime(1934, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Diavolo,Ralph A.", null, null, null, null, "586-13-9662" },
                    { 6, new DateTime(1976, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Russell,Paul S.", null, null, null, null, "572-40-8824" },
                    { 7, new DateTime(1981, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Pascal,John X.", null, null, null, null, "468-82-7179" },
                    { 8, new DateTime(1941, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Townsend,Lola E.", null, null, null, null, "141-48-5979" },
                    { 9, new DateTime(1995, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Paraskiv,Ted W.", null, null, null, null, "102-45-9284" },
                    { 10, new DateTime(2013, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Xavier,Joe I.", null, null, null, null, "640-94-6892" },
                    { 11, new DateTime(1944, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Quigley,Brian X.", null, null, null, null, "623-29-7359" },
                    { 12, new DateTime(1925, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Kovalev,Emily L.", null, null, null, null, "926-47-1200" },
                    { 13, new DateTime(1970, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Quigley,Wolfgang C.", null, null, null, null, "219-83-3119" },
                    { 14, new DateTime(1939, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Yoders,Michael Q.", null, null, null, null, "653-43-8799" },
                    { 15, new DateTime(1987, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Ulman,Nataliya F.", null, null, null, null, "333-30-2912" },
                    { 16, new DateTime(1944, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Ironhorse,Nataliya S.", null, null, null, null, "194-19-8843" },
                    { 17, new DateTime(1974, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Edwards,Imelda Z.", null, null, null, null, "830-80-6464" },
                    { 18, new DateTime(1945, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Finn,Orson R.", null, null, null, null, "907-77-7993" },
                    { 19, new DateTime(1953, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Ahmed,Patrick O.", null, null, null, null, "900-49-7613" },
                    { 20, new DateTime(1967, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Brown,Yan N.", null, null, null, null, "702-51-2515" },
                    { 21, new DateTime(1926, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Eagleman,Chris F.", null, null, null, null, "607-85-1150" },
                    { 22, new DateTime(1946, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Finn,Xavier L.", null, null, null, null, "840-32-9764" },
                    { 23, new DateTime(1956, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Zubik,Dave C.", null, null, null, null, "446-82-1065" },
                    { 24, new DateTime(1973, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Quine,Maureen R.", null, null, null, null, "638-45-7799" },
                    { 25, new DateTime(1980, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Nagel,Emma N.", null, null, null, null, "546-17-2376" },
                    { 26, new DateTime(1990, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Winters,Zeke J.", null, null, null, null, "841-42-2877" },
                    { 27, new DateTime(1968, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Cerri,Emilio X.", null, null, null, null, "493-92-9451" },
                    { 28, new DateTime(2003, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Schultz,Alfred S.", null, null, null, null, "555-36-1636" },
                    { 29, new DateTime(2004, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Newton,Mario B.", null, null, null, null, "538-68-5047" },
                    { 30, new DateTime(1996, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Tesla,Usha H.", null, null, null, null, "942-54-9905" },
                    { 31, new DateTime(1969, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Waal,Barb C.", null, null, null, null, "138-63-7967" },
                    { 32, new DateTime(1987, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Bush,Joshua S.", null, null, null, null, "448-48-9614" },
                    { 33, new DateTime(1924, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Schaefer,Terry U.", null, null, null, null, "499-34-2715" },
                    { 34, new DateTime(1964, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Connors,Neil N.", null, null, null, null, "357-48-1709" },
                    { 35, new DateTime(1992, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Feynman,Michelle I.", null, null, null, null, "632-78-6285" },
                    { 36, new DateTime(1942, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Cunningham,Stuart B.", null, null, null, null, "580-19-7926" },
                    { 37, new DateTime(1940, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Bach,Buzz E.", null, null, null, null, "203-50-9025" },
                    { 38, new DateTime(1990, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Klingman,Thelma J.", null, null, null, null, "696-42-1848" },
                    { 39, new DateTime(1988, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Sato,Ashley D.", null, null, null, null, "199-28-9762" },
                    { 40, new DateTime(2011, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Isaksen,Terry V.", null, null, null, null, "506-35-9757" },
                    { 41, new DateTime(1929, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Xavier,Jose V.", null, null, null, null, "611-16-6306" },
                    { 42, new DateTime(1963, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Lubbar,Elmo Y.", null, null, null, null, "964-81-8795" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "HomeCity", "HomeState", "HomeStreet", "HomeZip", "Name", "OfficeCity", "OfficeState", "OfficeStreet", "OfficeZip", "SSN" },
                values: new object[,]
                {
                    { 43, new DateTime(1993, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Hernandez,Christine D.", null, null, null, null, "298-57-6900" },
                    { 44, new DateTime(1934, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Ubertini,Natasha G.", null, null, null, null, "986-47-7645" },
                    { 45, new DateTime(2001, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Van De Griek,Wilma P.", null, null, null, null, "528-40-2665" },
                    { 46, new DateTime(1929, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Gomez,Emma T.", null, null, null, null, "301-59-4196" },
                    { 47, new DateTime(2011, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Huff,Clint K.", null, null, null, null, "841-63-2349" },
                    { 48, new DateTime(1975, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Novello,Elmo B.", null, null, null, null, "628-15-1684" },
                    { 49, new DateTime(2015, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Zemaitis,Barb E.", null, null, null, null, "295-83-5207" },
                    { 50, new DateTime(2010, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Eno,Sophia D.", null, null, null, null, "376-30-7760" },
                    { 51, new DateTime(2009, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Humby,Bart O.", null, null, null, null, "240-52-9420" },
                    { 52, new DateTime(1962, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Taylor,Roger V.", null, null, null, null, "346-21-1411" },
                    { 53, new DateTime(1961, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Winters,Buzz K.", null, null, null, null, "973-67-6018" },
                    { 54, new DateTime(1935, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "DeLillo,Jeff S.", null, null, null, null, "797-54-5950" },
                    { 55, new DateTime(1926, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Lubbar,Andrew Y.", null, null, null, null, "923-72-3795" },
                    { 56, new DateTime(1986, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Fripp,Juanita W.", null, null, null, null, "356-13-3072" },
                    { 57, new DateTime(1941, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Zemaitis,William R.", null, null, null, null, "701-71-5156" },
                    { 58, new DateTime(1945, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Vonnegut,Thelma W.", null, null, null, null, "145-56-2984" },
                    { 59, new DateTime(1957, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Gibbs,Ed X.", null, null, null, null, "523-37-7523" },
                    { 60, new DateTime(1930, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Diavolo,Christen U.", null, null, null, null, "807-41-2939" },
                    { 61, new DateTime(1978, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Willeke,Dick X.", null, null, null, null, "551-94-2310" },
                    { 62, new DateTime(2012, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Umansky,Nataliya S.", null, null, null, null, "422-29-9545" },
                    { 63, new DateTime(1982, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Presley,Josephine K.", null, null, null, null, "333-27-3465" },
                    { 64, new DateTime(1943, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Jackson,Aviel R.", null, null, null, null, "835-83-9458" },
                    { 65, new DateTime(1957, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Massias,Emma F.", null, null, null, null, "404-63-6879" },
                    { 66, new DateTime(1980, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Koivu,Janice U.", null, null, null, null, "715-94-7605" },
                    { 67, new DateTime(1938, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Zampitello,Josephine T.", null, null, null, null, "213-50-2379" },
                    { 68, new DateTime(1943, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Ipsen,Samantha G.", null, null, null, null, "798-33-5800" },
                    { 69, new DateTime(1991, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "LaRocca,Gertrude B.", null, null, null, null, "978-23-5838" },
                    { 70, new DateTime(1992, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Tesla,Elvira A.", null, null, null, null, "225-29-2766" },
                    { 71, new DateTime(1936, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Browning,Zelda Q.", null, null, null, null, "214-97-7357" },
                    { 72, new DateTime(2000, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Chesire,Mo V.", null, null, null, null, "659-19-2190" },
                    { 73, new DateTime(1953, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Nathanson,Mary V.", null, null, null, null, "328-91-6191" },
                    { 74, new DateTime(1943, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Yeats,Rhonda P.", null, null, null, null, "128-81-7649" },
                    { 75, new DateTime(1932, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Allen,Zelda P.", null, null, null, null, "140-77-4981" },
                    { 76, new DateTime(1973, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Bach,Patrick Y.", null, null, null, null, "315-26-7158" },
                    { 77, new DateTime(1965, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Goldman,Peter F.", null, null, null, null, "705-88-9677" },
                    { 78, new DateTime(1948, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Hernandez,Mario T.", null, null, null, null, "987-24-7906" },
                    { 79, new DateTime(1946, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Ueckert,Linda N.", null, null, null, null, "701-24-2834" },
                    { 80, new DateTime(1939, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Tillem,Elvira W.", null, null, null, null, "381-53-4883" },
                    { 81, new DateTime(1981, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Zemaitis,Brenda M.", null, null, null, null, "448-71-4790" },
                    { 82, new DateTime(1949, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Tesla,Mario T.", null, null, null, null, "513-31-1804" },
                    { 83, new DateTime(1948, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Quine,Rhonda N.", null, null, null, null, "364-53-6954" },
                    { 84, new DateTime(1988, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Ahmed,Edward V.", null, null, null, null, "769-88-2265" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "HomeCity", "HomeState", "HomeStreet", "HomeZip", "Name", "OfficeCity", "OfficeState", "OfficeStreet", "OfficeZip", "SSN" },
                values: new object[,]
                {
                    { 85, new DateTime(1952, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Quince,Brenda E.", null, null, null, null, "743-37-2766" },
                    { 86, new DateTime(1954, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Zweifelhofer,Clint Q.", null, null, null, null, "304-44-1385" },
                    { 87, new DateTime(1933, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Donaldson,Violet D.", null, null, null, null, "604-58-6242" },
                    { 88, new DateTime(1977, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "McCormick,Ted T.", null, null, null, null, "492-59-4597" },
                    { 89, new DateTime(1966, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Xavier,Bob D.", null, null, null, null, "708-96-6126" },
                    { 90, new DateTime(1978, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Zampitello,Brian B.", null, null, null, null, "399-27-7057" },
                    { 91, new DateTime(1985, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "DeLillo,Jules F.", null, null, null, null, "907-67-6719" },
                    { 92, new DateTime(1969, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Houseman,Quentin A.", null, null, null, null, "596-17-6866" },
                    { 93, new DateTime(1968, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Frost,Alvin Q.", null, null, null, null, "479-78-7627" },
                    { 94, new DateTime(1959, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Quixote,Laura S.", null, null, null, null, "283-60-9981" },
                    { 95, new DateTime(1973, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Xander,Gertrude D.", null, null, null, null, "713-61-7737" },
                    { 96, new DateTime(1991, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Adam,Wolfgang F.", null, null, null, null, "850-53-6279" },
                    { 97, new DateTime(1961, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Fives,Umberto L.", null, null, null, null, "894-54-7545" },
                    { 98, new DateTime(1945, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Alton,Samantha F.", null, null, null, null, "316-64-7558" },
                    { 99, new DateTime(1932, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Bach,Fred X.", null, null, null, null, "700-84-5268" },
                    { 100, new DateTime(2008, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Donaldson,Peter X.", null, null, null, null, "412-47-9386" },
                    { 101, new DateTime(1941, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Wilson,Rob X.", null, null, null, null, "735-10-3297" },
                    { 102, new DateTime(1993, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Love,Wolfgang O.", null, null, null, null, "785-19-5765" },
                    { 103, new DateTime(1940, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Li,Bill F.", null, null, null, null, "284-15-5423" },
                    { 104, new DateTime(1924, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Munt,Roberta Q.", null, null, null, null, "350-97-5236" },
                    { 105, new DateTime(1951, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Sato,Brendan E.", null, null, null, null, "441-79-7354" },
                    { 106, new DateTime(1943, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Hanson,Danielle L.", null, null, null, null, "187-37-5009" },
                    { 107, new DateTime(1950, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Vanzetti,Emily L.", null, null, null, null, "434-82-7142" },
                    { 108, new DateTime(1949, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Sorenson,Angelo D.", null, null, null, null, "791-62-4405" },
                    { 109, new DateTime(1971, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Pybus,Kevin V.", null, null, null, null, "432-27-2982" },
                    { 110, new DateTime(1965, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Jackson,Dmitry U.", null, null, null, null, "138-63-2738" },
                    { 111, new DateTime(1986, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Tesla,Bill T.", null, null, null, null, "608-60-7469" },
                    { 112, new DateTime(1960, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Salm,Fred I.", null, null, null, null, "344-43-3955" },
                    { 113, new DateTime(1995, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Presley,Zeke Q.", null, null, null, null, "677-58-1319" },
                    { 114, new DateTime(1998, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Yezek,Barb Z.", null, null, null, null, "846-14-6484" },
                    { 115, new DateTime(1965, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Frost,Liza X.", null, null, null, null, "786-41-9033" },
                    { 116, new DateTime(1966, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Xavier,Orson Q.", null, null, null, null, "261-54-9130" },
                    { 117, new DateTime(1966, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Vanzetti,Debby N.", null, null, null, null, "648-32-9795" },
                    { 118, new DateTime(1929, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Iacobelli,Umberto S.", null, null, null, null, "592-65-2076" },
                    { 119, new DateTime(1924, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Ragon,Buzz S.", null, null, null, null, "489-17-2100" },
                    { 120, new DateTime(1930, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "O'Brien,Aviel E.", null, null, null, null, "772-97-9878" },
                    { 121, new DateTime(2011, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Smith,Brenda P.", null, null, null, null, "363-94-9360" },
                    { 122, new DateTime(1980, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Quilty,Peter F.", null, null, null, null, "659-46-4809" },
                    { 123, new DateTime(1945, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Gibbs,Patrick N.", null, null, null, null, "295-50-6545" },
                    { 124, new DateTime(1945, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Ott,Lola S.", null, null, null, null, "384-39-2633" },
                    { 125, new DateTime(1983, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Cannon,Debby S.", null, null, null, null, "933-49-6405" },
                    { 126, new DateTime(1932, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Sato,Orson N.", null, null, null, null, "755-68-7822" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "HomeCity", "HomeState", "HomeStreet", "HomeZip", "Name", "OfficeCity", "OfficeState", "OfficeStreet", "OfficeZip", "SSN" },
                values: new object[,]
                {
                    { 127, new DateTime(1970, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Vivaldi,Sally K.", null, null, null, null, "627-21-6678" },
                    { 128, new DateTime(1967, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Van De Griek,Josephine R.", null, null, null, null, "446-67-3032" },
                    { 129, new DateTime(1978, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Yu,George E.", null, null, null, null, "795-56-2227" },
                    { 130, new DateTime(1987, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Kovalev,Orson N.", null, null, null, null, "583-72-4206" },
                    { 131, new DateTime(1938, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Tweed,Kristen W.", null, null, null, null, "851-44-9527" },
                    { 132, new DateTime(1942, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Xiang,Mark W.", null, null, null, null, "332-29-2935" },
                    { 133, new DateTime(2015, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Clay,Joe B.", null, null, null, null, "837-37-8134" },
                    { 134, new DateTime(2014, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Gold,Maria W.", null, null, null, null, "861-73-5617" },
                    { 135, new DateTime(1941, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Djakovic,Quentin Y.", null, null, null, null, "297-55-5766" },
                    { 136, new DateTime(1981, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Hernandez,Norbert E.", null, null, null, null, "511-37-9268" },
                    { 137, new DateTime(1963, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "DeLillo,Olga K.", null, null, null, null, "485-79-3320" },
                    { 138, new DateTime(1997, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Djakovic,Terry U.", null, null, null, null, "816-57-2013" },
                    { 139, new DateTime(1982, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "O'Rielly,Dmitry L.", null, null, null, null, "393-16-7381" },
                    { 140, new DateTime(1996, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Ximines,Emily W.", null, null, null, null, "226-21-9656" },
                    { 141, new DateTime(1954, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Fripp,Kenny W.", null, null, null, null, "393-79-9401" },
                    { 142, new DateTime(1958, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Isaksen,Belinda I.", null, null, null, null, "358-91-7790" },
                    { 143, new DateTime(1939, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Sato,Stuart D.", null, null, null, null, "742-67-7011" },
                    { 144, new DateTime(1963, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Macrakis,Phil V.", null, null, null, null, "222-62-2251" },
                    { 145, new DateTime(1939, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Ramsay,Angelo O.", null, null, null, null, "469-60-7740" },
                    { 146, new DateTime(2005, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Ramsay,Dave I.", null, null, null, null, "769-87-4742" },
                    { 147, new DateTime(1952, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Edwards,Edward Z.", null, null, null, null, "945-42-9727" },
                    { 148, new DateTime(1953, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Faust,Kyra S.", null, null, null, null, "226-14-9155" },
                    { 149, new DateTime(1999, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Wijnschenk,Brian V.", null, null, null, null, "482-85-9983" },
                    { 150, new DateTime(1948, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Petersburg,Gertrude Q.", null, null, null, null, "419-88-9846" },
                    { 151, new DateTime(2003, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Isaksen,Imelda E.", null, null, null, null, "911-79-8957" },
                    { 152, new DateTime(1941, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Sorenson,Kevin U.", null, null, null, null, "857-64-4301" },
                    { 153, new DateTime(2000, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Salm,Charlotte P.", null, null, null, null, "110-97-6267" },
                    { 154, new DateTime(1925, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Eagleman,Julie W.", null, null, null, null, "858-49-1993" },
                    { 155, new DateTime(1925, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Edwards,Brian J.", null, null, null, null, "610-47-8440" },
                    { 156, new DateTime(1970, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Uberoth,Milhouse G.", null, null, null, null, "805-15-5092" },
                    { 157, new DateTime(1967, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Ahmed,Michael O.", null, null, null, null, "484-78-3467" },
                    { 158, new DateTime(1975, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Zimmerman,Julie E.", null, null, null, null, "767-74-6307" },
                    { 159, new DateTime(1948, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Jenkins,Elmo M.", null, null, null, null, "147-36-7651" },
                    { 160, new DateTime(1958, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Faust,Heloisa I.", null, null, null, null, "303-27-6282" },
                    { 161, new DateTime(1940, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Schaefer,Xavier U.", null, null, null, null, "961-20-1436" },
                    { 162, new DateTime(1967, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Long,Kyra U.", null, null, null, null, "173-54-9625" },
                    { 163, new DateTime(1999, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Orlin,Natasha P.", null, null, null, null, "102-94-8801" },
                    { 164, new DateTime(1957, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Lepon,Richard L.", null, null, null, null, "864-40-8890" },
                    { 165, new DateTime(2014, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Ragon,Stavros F.", null, null, null, null, "578-45-2622" },
                    { 166, new DateTime(1936, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "O'Donnell,Dave C.", null, null, null, null, "286-90-8265" },
                    { 167, new DateTime(1998, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Smith,Amanda M.", null, null, null, null, "403-90-3253" },
                    { 168, new DateTime(1998, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "King,Violet P.", null, null, null, null, "340-33-1832" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "HomeCity", "HomeState", "HomeStreet", "HomeZip", "Name", "OfficeCity", "OfficeState", "OfficeStreet", "OfficeZip", "SSN" },
                values: new object[,]
                {
                    { 169, new DateTime(1998, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Vonnegut,Olga B.", null, null, null, null, "562-58-5876" },
                    { 170, new DateTime(1948, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Djakovic,Sam X.", null, null, null, null, "209-39-6166" },
                    { 171, new DateTime(1999, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Humby,Richard Q.", null, null, null, null, "559-80-9635" },
                    { 172, new DateTime(1999, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Isaksen,Patrick C.", null, null, null, null, "184-75-9811" },
                    { 173, new DateTime(1956, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Press,Michael I.", null, null, null, null, "932-24-4308" },
                    { 174, new DateTime(1934, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Johnson,Brian T.", null, null, null, null, "751-82-3888" },
                    { 175, new DateTime(1950, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Gold,Barbara M.", null, null, null, null, "561-12-6330" },
                    { 176, new DateTime(1965, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Underman,Ed B.", null, null, null, null, "657-71-3463" },
                    { 177, new DateTime(1973, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Chang,Ted B.", null, null, null, null, "960-82-7867" },
                    { 178, new DateTime(1976, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Uberoth,Barb F.", null, null, null, null, "482-48-8124" },
                    { 179, new DateTime(1969, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Novello,Elvis F.", null, null, null, null, "614-42-4992" },
                    { 180, new DateTime(2002, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Kovalev,Yan M.", null, null, null, null, "884-34-4723" },
                    { 181, new DateTime(1955, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Smyth,Terry N.", null, null, null, null, "120-60-1168" },
                    { 182, new DateTime(1943, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Macrakis,Pat I.", null, null, null, null, "102-22-8938" },
                    { 183, new DateTime(1924, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Lubbar,Terry M.", null, null, null, null, "773-77-8586" },
                    { 184, new DateTime(1984, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Chadbourne,Zeke L.", null, null, null, null, "351-96-7026" },
                    { 185, new DateTime(1957, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Djakovic,Pat D.", null, null, null, null, "621-12-3618" },
                    { 186, new DateTime(2006, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Ramsay,Kenny M.", null, null, null, null, "557-23-4448" },
                    { 187, new DateTime(1929, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Hernandez,Charlotte R.", null, null, null, null, "931-12-4744" },
                    { 188, new DateTime(1972, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Adams,Phil H.", null, null, null, null, "729-18-4435" },
                    { 189, new DateTime(1944, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Jackson,Elvis U.", null, null, null, null, "618-90-2037" },
                    { 190, new DateTime(1982, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Ueckert,George Q.", null, null, null, null, "319-66-4389" },
                    { 191, new DateTime(1970, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Xerxes,Kristen V.", null, null, null, null, "812-39-4255" },
                    { 192, new DateTime(1961, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Solomon,Thelma J.", null, null, null, null, "193-37-1156" },
                    { 193, new DateTime(1944, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Ingleman,Sophia N.", null, null, null, null, "976-97-3796" },
                    { 194, new DateTime(2004, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Ingrahm,Chelsea P.", null, null, null, null, "964-87-9444" },
                    { 195, new DateTime(2014, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Sands,Mario F.", null, null, null, null, "954-47-9881" },
                    { 196, new DateTime(1949, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Quincy,Terry Y.", null, null, null, null, "258-21-2920" },
                    { 197, new DateTime(1945, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Finn,Jane W.", null, null, null, null, "795-95-3462" },
                    { 198, new DateTime(1982, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Hanson,Josephine R.", null, null, null, null, "450-54-2543" },
                    { 199, new DateTime(1990, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Kelvin,Sam C.", null, null, null, null, "960-84-8130" },
                    { 200, new DateTime(1947, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Van De Griek,Emily S.", null, null, null, null, "901-82-4890" },
                    { 204, new DateTime(1990, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "sf", null, null, null, null, "123-12-1234" },
                    { 205, new DateTime(1962, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Nichols,Mark S.", null, null, null, null, "806-59-6936" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
