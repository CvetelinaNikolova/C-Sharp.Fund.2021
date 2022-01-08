using System;
using System
    .Collections.Generic;
using System.Text;

namespace _3._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfSong = int.Parse(Console.ReadLine());
            List<Songs> songs = new List<Songs>();
            for (int i = 0; i < numOfSong; i++)
            {
                string[] data = Console.ReadLine().Split("_");

                Songs song = new Songs();

                song.TypeOfList = data[0];
                song.Name = data[1];
                song.Time = data[2];

                songs.Add(song);
            }
            string input = Console.ReadLine();
            if (input=="all")
            {
                foreach ( Songs song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Songs song in songs)
                {
                    if (input ==song.TypeOfList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}
