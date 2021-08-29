using PlayerBase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Deserializtion
{
    public class Program2
    {
        private static readonly string defaultFilePath = Environment.CurrentDirectory + "\\PlayerData.dat";

        public static void DeSerializePlayerObjects(string path, out List<Player> players)
        {
            try
            {
                using FileStream fs = new(path, FileMode.Open);
                BinaryFormatter formatter = new();
                players = (List<Player>)formatter.Deserialize(fs);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                players = null;
            }
        }

        private static void Main()
        {
            List<Player> playerList = new();

            //Deserialization
            DeSerializePlayerObjects(defaultFilePath, out playerList);

            if (playerList != null)
            {
                for (int i = 0; i < playerList.Count; i++)
                {
                    Console.WriteLine("--- Player " + (i + 1) + " ---");
                    Console.WriteLine("Name\t: " + playerList[i].Name);
                    Console.WriteLine("Class\t: " + playerList[i].PlayerClass);
                    Console.WriteLine("Score\t: " + playerList[i].Score);
                    Console.WriteLine();
                }
            }
        }
    }
}