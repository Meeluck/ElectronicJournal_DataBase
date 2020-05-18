using Microsoft.EntityFrameworkCore.Migrations;

namespace ElectronicJournal_DataBase.Migrations
{
    public partial class UserIdToGroupDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Users_StarostaId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_StarostaId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "StarostaId",
                table: "Groups");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "FCCEC4D0214AAFA6C8E844F1EE694759A6EAB8B0BE6770486DFCAEC00757B8CFD51C8ECB353DD62F47B8315E7D64901FD2FD5F9A19648777AC2F4FFCF7295A60", "K0DgnqT1jFrVAVytmJqu/g7KDepxoBOMk+DgvgAl0JqIsej5C7WW4Q4UTBqpJIDrBL5eUYeHCRVOPSrwy94Ajw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "559452CFD25EB577FCD09F67F72F065030B9E9BD659CD1F3D0628AA47E4EEC636589A3ABD55498EE010F61728FA722947AE659F0E2CD96934EC4F356F504A878", "Zpw1hI6F8oq1o02LHH9hTTPSRrZlppp2m8Sx8tO4M59fLDqkth1kY0oGuLkVNa4LJG6lewTg5eQJaJ/5+9afiA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "C1E2C71C72ABCE7D232737AEBDE213E3643676ECFB098D286862B96136E2D1FCC474E36B6EB4753FB8FBD13228F7BD37B6A55853F32F51CD69FD9F233FFD2166", "17LmkYS53TWcYStihET9nEKkh9EdkIXyfWLMJKPfsmR8iSJzW7ncxtjhzU/AmAcKyNpLjmfRn4pVteNxV/soZw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "B84DF1455A1B98A2F3B6A88D88FA616BF5954001D3860420C8ADC32CCCB0F9BA6CF8B5730AF6A43F591332C34B8D935576C6A0C0ADA5ADDDCF819016433BDDCF", "D0KSSfgo1Chqx6SDdgV2uCd9LE0Wdcsp2byp8/V2NzdcMD7mv4pedGVPuLXNjA8mp+sJgePjtBdUBVaPvf+bAA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "5D0FEA283ADD1D60C309ADFA3D15C99D528E28D74A4D9B717C6DB4DAA2BFDD442A330F56CBF9F86EAEB7EA05F466DCCEC8D28D8DFFCA4D4FBCF840D0E5BE95D2", "OCsc2X4vh1zcb5URmC7EvxfnWfLd0Jmtuqryr3+9MOM8+OVvRHeJc/KL5waW/9Qt3DbT+pUlhq3unVimpK6mrA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "F9034FA4374424D84691F4EE18EA93E2682D50FA1F7655416F2317DA096EC817932C7C8C54F0E280E77662269EFD4A6EE57060721D0D0ADD8845DA99F3915FE0", "qAP6AlMhiXedNaVHlBlEkWw5+jAHzPo8e0oglUcAj53ZCXOHmu2rTgA4hrvDy1bziMQTJekr6NUQmdiWSatpbA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "E63A42AFA26922D71EF0FCC8BED916D1CDFA02D7F2023C314C80BDCB3CB7F9DEFE09DD7DB31AA712A1A7F62DA0EAD79B0EF8F6469E58AE17C12B14AC66761462", "YyDria0WR5DktUmXzigBi26ExD+5dPhD4vFtR1HIo191hmZLNCJIRY6h0+LKyQxlR2wvRcsgjBMLqkDnwoJxyQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "E3906A1301DC0EB0EE68F42A03AB16F931917CD862235142E295A12B88A37FBCF6B20BCCE4090481150C9D8FF3E49BE667E1741477AB5090F8488C8A8597087C", "UzjuiZmg0A+fGV7wQ/lK1MTJS+1HZIbWjrd+xgiVKZtzyKvIoyLpmbSFyV+mjY2kdtnMTr1NkGVgF5LgZY23RQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "64EB7E2B0EE25BC1D20D6646A022AEE858FAC6E30336BF94FF39C054D1D6AAFDC126A79C6B8FEEF58C6EADDB59C92984911D32DAE336517EF3738CE742786C30", "9EqlephOdyHgmCCkxtFIrQ0TayXlni/x/a1k0cEKymg7cbX/t46cekVxuwqjD7cvTDJWwyi1BW2AGV4MX0I8JQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "93F5CADB9EE248F24F7F3E3F0636CC27DC729CB75C204876CDBA500A4DF27D681F20713FA8916076AD06F309FC1717E1B4F506D11BB404D392E1BB245DBE0E3B", "1b2mPo3jwntzd89bBCV+EcWOZOncUm5jv2yKaXIW7kSWhDlqC7ONtEc9hbeFODrlaKvAwggOaNwRFdT3DaBzuQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "DF784E710D0DFC14890A26EC0091E3D7CCB0E0D843C6CE239E47D0B1904F6A62845D3E8E8BDCD3307BD622E24E44FA1BBF489ACC34EE04C6D51FEDA6896E2D5C", "IE52HJybs3QPuAEeI69LRHEtDjQ5HuhyDqjrmYbnGh1UdziTdgiqYqYvzlu3t8LxLNm0T8lS2ODy9ALkV28cZA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "EE3A908A7066BCAF6206761D4635972B97BB375B6F0E831AC2C69DB88650764C2E8370694E8D1F3266C7FB241CA48A419FF1DC528C28448C125F647A1EEC0155", "CMs6WRpBUAZ9Q6cSmH+r4+2u6wdS9ZlGlX8aesyPXnSWdEBYFq41N5ZUCgQ5M+bqP+jRx1D0l20T4Bm8NdlYaA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "DEB9796E0DC0FB8A7004343238C720C2DD21534B871A5587E6BD5A9319E87387F483F60529938466E8C957B737EBFAC7C508B9B4976F1DD58D1687196A18081A", "kI8RCGuS0i6FXLK4tB/UnKgUwd2UAgUx/XZW2w0kuBDZc02TWIAtGLkaBDWYpVGj4rQHzHLO3LHvwwu8bZTCFg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "CC49E8C1C6899126F9D53A1B9B25D15F62993D38C658319417F90CC58C0E0A8C20E5F7B9A0253818BE55811229823729E5E7ACF59874E12C43A07AB43A32A089", "lmoN7G2yUudTjYLgqJTl5Ux5F6a6iVAIl8Kbx4P1890B6Adx3s3OwUJ30sPjcCtcUUUkrTw2IT6qYO5LM/HvjA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "02229062BD80BF7F0077858ADE959ABDFDC90DE9C632B47289271B64998D51A19462597CCFD56E1644C3D38380BFC9D6C6C6DABB8F1BED3706588F674E51E3C5", "Epi5c3TmNqxXTxABES0U4FBSKVwuvXWCROMJNqjENuJ48HfI2ZtcLPknnk48wdyMLdOLzMVF6WpZ5gkI4ZSyaQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StarostaId",
                table: "Groups",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "976BCA75A7B6265880DBEBCAB262F009ADFCF25FEAE7050E347A6449F7E23FAC61DC6DBA2F753FE9CE31817D4C67FD3BFFD27BCA9E61FDD47954036741F3B608", "lqU9irXr/QP2GweWaDuStsiYn9i5oYWCdFWizD+qReoJsgoyvPU4jQjBWfIgS6eJM+kLewksNB72eTeWMfxMMw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "712D7F5B86765C784F3A4626087F160EA2C08B0A4FCEE6ECCD84075D03F64BCFDB5EC680A3303BC84A4C13DE59C460E5CCB4FB08D0567DF5FE2B81C64479E631", "gy55/06Y6SwXaRWZe26xCEcIXYvV9Zc9jeqiSU35zDhHB+Iqwe0W6Zpyj2B+amZl6QN6UZll6M3Y1erBSk7yqw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "9E20B43B77E003FC8A38CF0FFAF208E67B6F366519F4925EE75346AC0DACB92CA1BAF8538709A9E619F0A25ED29F1DEFB7952B6B7ECD552A7CBF37CD610F078E", "3h6Am61Cla2IYlCA5SgtSrbdSM8QpjxVrf80PacXl1mekurBuq6x1bzo6Zh+eIP+//RC7pKfNILccEKvUIGM1A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "0BA7212AF571F1FEA6180842357AA7676BAAF3E0294F41CF9ABDC9B03C679AED9BAF79FAE7EFA7EEB39A73236286F10480B7CB4039A132C807F5B8CAD19D03A8", "DFS/pRGdT0pRwuk4iUr9GzMRgmxln79Twzr/3gL8a90SCM7wjTVlV7y9TCwioparc75kS72Hivs5dIcJ22jBuA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "B93B4D70B06BA07CD6C3AD2EAF988BE0CA2CB5A7D637549AA8CB84666C2275259C0D56788C2E58FDE69BCD153662716E24A749857D93CADF82199EBF6100A767", "1kghpqv1BrSqELoluHJqUcLQJvhQVlku8B2yvyIL/bTwBV9NdjlfndZH8xF0115l840b+pg5aR6yZXStdOIB5A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "0AFD708E3B706C6B174CA488CB052C31A196C2D6137361C5F4A1ECC54E7C90ADAA8CFC85776A9360B7F80D6CE6C72B3164975319AB2654EAF3158E707B690D7A", "ClN090LUmSShW72v2iMse+lxFe/j+/kE59vBIPQn3ajBZgeUq8GLcqXDbaby9afX033T93ZN8LJvZE+hcALP7Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "9D464916569CE287DBC292129946EF986207FBB052802C1AC802965F51A30658D5676607EC4C9B01FE0348A6DC40637EDE6E0EF64D85AEB820D0491643E64EEF", "you2hVgiLF+WozjeAdax2Hl4BObiS4Ji3VAhRskqf1MUHdywB6KV4QtqanbBnyHAM3oI4qPybJuMKfqNlZMFlQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "8254F989405AB0E598919689DE6D279238FFED37339F3BD7D2FA1445330840DFCAD19D6B77F4BBAB97250271410B8A8E9C7566720139B8379DCFB905CF082E16", "VrEXIDWXpFtAch+T7s1pCIp0hJBd0hnRzogFUmWoxRcwrO8/lKgL41BwzzHLFsZHVdJXDRwsJwl0OqD9n9mQlw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "E9B2E6D6CDC890F721B353975AB5E49AAE1FBC95A37CC05C92E7FC8E7923A039590401EB44929663EA520558F8D68124A20BE37FE9D13634571A8DEB3B98730C", "BdAEwcbu7N6CUotVR4GHTrjOibo6DUU7g8ZbJpQlTnoa7i4qpn2C7uP9erWYnE6AfgA0paV/CN6Ld29DVXUMVQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "812EDCC1525AF0EA2BA0FF686B468A87FF855951236E05778C90363919DA2F29D3915A353FB89AF29356481AB0B581606DC5E7F5DEF5E600D41CB04A2ACBD6EA", "ST33Zxq5yhpFLQw8nToe8FqHgTLPKMKF8G1QtSqPMOX+gKORkOciC4X2MZlLpTcHKPVIjPejciJC7tcn1ooOKQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "6EF6C951CF6C3D91D07A68B350E1264B5C19C10D0F72F697C963635FE751E4609B7E2C08870118F4AD5904924A84DE10887A69BCD8B088DF10A850F58DD50A93", "z+lmgdF8FacOTgZgRIHT2QUiT7oBrMErRwmGk+KRFxL14oa4oICZkBQbTxaHapEiuKAk9qi5D+BfCHe7zQsu/A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "58797ABB37CCC2178C927A95325E2F8C1D747AECBC69B4D1099350B9B97113864E5659C8B3E0411B780E927D07216CF7145F7847E5FD6985DD25A5B6E1E2408C", "xz0Ktrg98tmHqGumGEBHeoLuGUq2UCKY6iGPBh5jnG0+lVBJoqZLCdU69WBokvmTMFs89N1LDIbsTr9IRiURgg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "EA24316D2E5830EC9C560E8EF8ABA67D3677E7A5B67A93B1B390ED6E66599A791FD9178F3A52712302E86E3D051D24ECF7676FA9AC331D1B188B8127ED48883B", "/b9gBtldMPEEsl+3Xl3jiPZgEBFOq+dnHuH4Co3sGkkveWCQAMdCvzapQJ6QAjzwxoXN2rCV1I7577uPyymirA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "114D812E6829E72248F600F2D1DFDE25D073D8457D8D28C2CFD503DDF1C59E6966D2197BF445A83585A366B72468F5AE97036F7F56C63734A0E3E6F0F9C91378", "UhNPhd77UwYiQbWz8toeuF99A1xJQC9SAs4AC57JeyYPjDVx6H/09aEVvtK4djDTqqtetjRwTdsFtAaK3Abrsw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "16171BB58ABC014271058C4919C8827B2CA9879BCC1D65B1C20021630D4071CC0189CDFC17A5D55FE33503353A8A32B215918EEDB6F6AECD02DF1CA860C8F45D", "BKQXsnXCFkIEmb8nKtO0kxEZcYjwjLV1BKliBpSzFE1wSYl7fpPfNiUpYrRNup/V3UzkmVXE6yQzQ+bg390EXQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_Groups_StarostaId",
                table: "Groups",
                column: "StarostaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Users_StarostaId",
                table: "Groups",
                column: "StarostaId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
