using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YourGameOfTheYear.Migrations
{
    public partial class addUserReviewdetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_Message_MessageID",
                table: "Game");

            migrationBuilder.DropForeignKey(
                name: "FK_GameReview_Game_GameId",
                table: "GameReview");

            migrationBuilder.DropForeignKey(
                name: "FK_Genre_Game_GameID",
                table: "Genre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserReview",
                table: "UserReview");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Game",
                table: "Game");

            migrationBuilder.DropIndex(
                name: "IX_Game_MessageID",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "Comments",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MessageID",
                table: "Game");

            migrationBuilder.RenameTable(
                name: "UserReview",
                newName: "UserReviews");

            migrationBuilder.RenameTable(
                name: "Game",
                newName: "Games");

            migrationBuilder.RenameColumn(
                name: "UserFK",
                table: "AspNetUsers",
                newName: "CommentsCount");

            migrationBuilder.AddColumn<DateTime>(
                name: "MessageDate",
                table: "Message",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Message",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserReviewID",
                table: "Message",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "UserReviews",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserReviews",
                table: "UserReviews",
                column: "ID")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Games",
                table: "Games",
                column: "ID")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Message_UserReviewID",
                table: "Message",
                column: "UserReviewID");

            migrationBuilder.CreateIndex(
                name: "IX_UserReviews_GameId",
                table: "UserReviews",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_GameReview_Games_GameId",
                table: "GameReview",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Genre_Games_GameID",
                table: "Genre",
                column: "GameID",
                principalTable: "Games",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Message_UserReviews_UserReviewID",
                table: "Message",
                column: "UserReviewID",
                principalTable: "UserReviews",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserReviews_Games_GameId",
                table: "UserReviews",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameReview_Games_GameId",
                table: "GameReview");

            migrationBuilder.DropForeignKey(
                name: "FK_Genre_Games_GameID",
                table: "Genre");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_UserReviews_UserReviewID",
                table: "Message");

            migrationBuilder.DropForeignKey(
                name: "FK_UserReviews_Games_GameId",
                table: "UserReviews");

            migrationBuilder.DropIndex(
                name: "IX_Message_UserReviewID",
                table: "Message");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserReviews",
                table: "UserReviews");

            migrationBuilder.DropIndex(
                name: "IX_UserReviews_GameId",
                table: "UserReviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Games",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "MessageDate",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "UserReviewID",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "UserReviews");

            migrationBuilder.RenameTable(
                name: "UserReviews",
                newName: "UserReview");

            migrationBuilder.RenameTable(
                name: "Games",
                newName: "Game");

            migrationBuilder.RenameColumn(
                name: "CommentsCount",
                table: "AspNetUsers",
                newName: "UserFK");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "Comments",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "MessageID",
                table: "Game",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserReview",
                table: "UserReview",
                column: "ID")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Game",
                table: "Game",
                column: "ID")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Game_MessageID",
                table: "Game",
                column: "MessageID");

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Message_MessageID",
                table: "Game",
                column: "MessageID",
                principalTable: "Message",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GameReview_Game_GameId",
                table: "GameReview",
                column: "GameId",
                principalTable: "Game",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Genre_Game_GameID",
                table: "Genre",
                column: "GameID",
                principalTable: "Game",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
