using PlayerBase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    public class Program
    {
        private static readonly string defaultFilePath = Environment.CurrentDirectory + "\\PlayerData.dat";

        public static void SerializePlayerObjects(string path, List<Player> list)
        {
            try
            {
                using FileStream fs = new(path, FileMode.Create);
                BinaryFormatter formatter = new();
                formatter.Serialize(fs, list);
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void Main()
        {
            //Program 1
            {
                List<Player> playerList = new();
                Console.Write("\nPlease insert player count : ");
                int playerCount = 0;
                try
                {
                    //Initialization
                    playerCount = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < playerCount; i++)
                    {
                        var temp = new Player();
                        Console.Write("Please insert the name for player - " + (i + 1) + "\t: ");
                        temp.Name = Console.ReadLine();
                        Console.Write("Please insert the class for player-" + (i + 1) + "\t: ");
                        temp.SwitchClass(Console.ReadLine());
                        temp.SetScore(new Random().Next(0, 100));
                        Console.WriteLine(temp.Name + " played a non-existent game and gained " + temp.Score + " points!");
                        playerList.Add(temp);
                        Console.WriteLine();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                //Serialization
                SerializePlayerObjects(defaultFilePath, playerList);
                Console.WriteLine("Player list has been serialized");
            }
        }
    }
}