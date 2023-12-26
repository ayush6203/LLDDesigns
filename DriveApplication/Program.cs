// See https://aka.ms/new-console-template for more information
using SnakeAndLadderImplementation.Interfaces;
using SnakeAndLadderImplementation.Models;

Console.WriteLine("Snake and ladder game");
List<IJump> snakes = new List<IJump>() { new Snake() { Start = 99, End = 9}, new Snake() { Start = 45, End = 15 }, new Snake() { Start = 17, End = 3 }, new Snake() { Start = 63, End = 40 } };
List<IJump> ladder = new List<IJump>() { new Ladder() { Start = 7, End = 54 }, new Ladder() { Start = 66, End = 83 }, new Ladder() { Start = 27, End = 33 }, new Ladder() { Start = 69, End = 91 } };
List<Player> players = new List<Player>() { new Player("Ayush"), new Player("Piyush") };
Board board = new Board(10, snakes, ladder, players);
board.BeginGamePlay();


Console.ReadKey();

