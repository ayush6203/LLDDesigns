// See https://aka.ms/new-console-template for more information
using SnakeAndLadderImplementation.Models;

#region SnakeandLadder Game
Console.WriteLine("Snake and ladder game");
List<Player> players = new List<Player>() { new Player("Ayush"), new Player("Piyush"), new Player("Arsh") };
Board board = new Board(10, 5, 5, players);
board.BeginGamePlay();
#endregion


Console.ReadKey();

