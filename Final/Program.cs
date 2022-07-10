using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Unit04.Game.Casting;
using Unit04.Game.Directing;
using Unit04.Game.Services;


namespace Unit04
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        private static int FRAME_RATE = 12;
        private static int MAX_X = 600;
        private static int MAX_Y = 900;
        private static int CELL_SIZE = 20;
        private static int FONT_SIZE = 30;

        private static string CAPTION = "Air Hockey";
        private static Color BLACK = new Color(0, 0, 0);
        private static Color RED = new Color(255, 0, 0);
        private static Color WHITE = new Color(255, 255, 255);
        private static Color BLUE = new Color(0, 0, 255);


        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            Cast cast = new Cast();

            Actor centerLine = new Actor();
            cast.AddActor("centerLine", centerLine);
            centerLine.SetWidthHeight(MAX_X, 8);
            Point centerLinePoint = new Point(0, MAX_Y / 2 - 4);
            centerLine.SetPosition(centerLinePoint);
            centerLine.SetColor(BLUE);

            Actor actorTopEndZone = new Puck();
            cast.AddActor("topEndzone", actorTopEndZone);
            Puck topEndZone = (Puck)actorTopEndZone;
            topEndZone.radius = 150;
            Point topEndZonePoint = new Point(MAX_X / 2, 0);
            topEndZone.SetPosition(topEndZonePoint);
            topEndZone.SetColor(BLUE);

            Actor actorTopEndZoneFill = new Puck();
            cast.AddActor("topEndzoneFill", actorTopEndZoneFill);
            Puck topEndZoneFill = (Puck)actorTopEndZoneFill;
            topEndZoneFill.radius = 142;
            Point topEndZonePointFill = new Point(MAX_X / 2, 0);
            topEndZoneFill.SetPosition(topEndZonePointFill);
            topEndZoneFill.SetColor(WHITE);

            Actor actorBottomEndZone = new Puck();
            cast.AddActor("bottomEndzone", actorBottomEndZone);
            Puck bottomEndZone = (Puck)actorBottomEndZone;
            bottomEndZone.radius = 150;
            Point bottomEndZonePoint = new Point(MAX_X / 2, MAX_Y);
            bottomEndZone.SetPosition(bottomEndZonePoint);
            bottomEndZone.SetColor(BLUE);

            Actor actorBottomEndZoneFill = new Puck();
            cast.AddActor("bottomEndzoneFill", actorBottomEndZoneFill);
            Puck bottomEndZoneFill = (Puck)actorBottomEndZoneFill;
            bottomEndZoneFill.radius = 142;
            Point bottomEndZonePointFill = new Point(MAX_X / 2, MAX_Y);
            bottomEndZoneFill.SetPosition(bottomEndZonePointFill);
            bottomEndZoneFill.SetColor(WHITE);

            Actor startMessage = new Actor();
            cast.AddActor("startMessage", startMessage);
            startMessage.SetText("Press Spacebar to Start");
            startMessage.SetPosition(new Point(120, MAX_Y / 2 - 80));
            startMessage.SetColor(BLACK);
            startMessage.SetFontSize(FONT_SIZE);

            Actor topWallRight = new Actor();
            cast.AddActor("walls", topWallRight);
            topWallRight.SetWidthHeight(MAX_X / 4, 16);
            Point topWallRightPoint = new Point(MAX_X - topWallRight.GetWidth(), 0);
            topWallRight.SetPosition(topWallRightPoint);
            topWallRight.SetColor(BLACK);

            Actor topWallLeft = new Actor();
            cast.AddActor("walls", topWallLeft);
            topWallLeft.SetWidthHeight(MAX_X / 4, 16);
            Point topWallLeftPoint = new Point(0, 0);
            topWallLeft.SetPosition(topWallLeftPoint);
            topWallLeft.SetColor(BLACK);

            Actor bottomWallRight = new Actor();
            cast.AddActor("walls", bottomWallRight);
            bottomWallRight.SetWidthHeight(MAX_X / 4, 16);
            Point bottomWallRightPoint = new Point(MAX_X - bottomWallRight.GetWidth(), MAX_Y - 16);
            bottomWallRight.SetPosition(bottomWallRightPoint);
            bottomWallRight.SetColor(BLACK);

            Actor bottomWallLeft = new Actor();
            cast.AddActor("walls", bottomWallLeft);
            bottomWallLeft.SetWidthHeight(MAX_X / 4, 16);
            Point bottomWallLeftPoint = new Point(0, MAX_Y - 16);
            bottomWallLeft.SetPosition(bottomWallLeftPoint);
            bottomWallLeft.SetColor(BLACK);

            Actor leftWall = new Actor();
            cast.AddActor("leftWall", leftWall);
            leftWall.SetWidthHeight(16, MAX_Y);
            Point leftWallPoint = new Point(0, 0);
            leftWall.SetPosition(leftWallPoint);
            leftWall.SetColor(BLACK);

            Actor rightWall = new Actor();
            cast.AddActor("rightWall", rightWall);
            rightWall.SetWidthHeight(16, MAX_Y);
            Point rightWallPoint = new Point(MAX_X - 16, 0);
            rightWall.SetPosition(rightWallPoint);
            rightWall.SetColor(BLACK);

            Actor actorPlayer1 = new Puck();
            cast.AddActor("player1", actorPlayer1);
            Puck player1 = (Puck)actorPlayer1;
            Point player1Point = new Point(MAX_X / 2, player1.radius * 2);
            player1.SetPosition(player1Point);
            player1.SetColor(RED);
            player1.SetText("P1");
            player1.SetFontSize(FONT_SIZE);

            Actor score1Cap = new Actor();
            cast.AddActor("score1Cap", score1Cap);
            Point score1CapPoint = new Point(40, MAX_Y / 2 - 100);
            score1Cap.SetPosition(score1CapPoint);
            score1Cap.SetText("Player 1:");
            score1Cap.SetColor(BLACK);
            score1Cap.SetFontSize(18);

            Actor score1 = new Actor();
            cast.AddActor("score1", score1);
            Point score1Point = new Point(50, MAX_Y / 2 - 75);
            score1.SetPosition(score1Point);
            score1.SetText(player1.score.ToString());
            score1.SetColor(BLACK);
            score1.SetFontSize(50);

            Actor actorPlayer2 = new Puck();
            cast.AddActor("player2", actorPlayer2);
            Puck player2 = (Puck)actorPlayer2;
            Point player2Point = new Point(MAX_X / 2, MAX_Y - player2.radius * 2);
            player2.SetPosition(player2Point);
            player2.SetColor(RED);
            player2.SetText("P2");
            player2.SetFontSize(FONT_SIZE);

            Actor score2Cap = new Actor();
            cast.AddActor("score2Cap", score2Cap);
            Point score2CapPoint = new Point(MAX_X - 85, MAX_Y / 2 - 100);
            score2Cap.SetPosition(score2CapPoint);
            score2Cap.SetText("Player 2:");
            score2Cap.SetColor(BLACK);
            score2Cap.SetFontSize(18);

            Actor score2 = new Actor();
            cast.AddActor("score2", score2);
            Point score2Point = new Point(MAX_X - 50, MAX_Y / 2  - 75);
            score2.SetPosition(score2Point);
            score2.SetText(player2.score.ToString());
            score2.SetColor(BLACK);
            score2.SetFontSize(50);


            Actor actorPuck = new Puck();
            cast.AddActor("puck", actorPuck);
            Puck puck = (Puck)actorPuck;
            Point puckPoint = new Point(MAX_X / 2, MAX_Y / 2);
            puck.SetPosition(puckPoint);
            puck.SetColor(BLACK);

            // start the game
            KeyboardService keyboardService = new KeyboardService(CELL_SIZE);
            VideoService videoService = new VideoService(CAPTION, MAX_X, MAX_Y, CELL_SIZE, FRAME_RATE, false);

            Director director = new Director(keyboardService, videoService);
            director.StartGame(cast);
        }
    }
}