using System;

namespace FunWithMusic
{
    class Program
    {
        enum Genre
        {
            Rock,
            Pop,
            HipHop,
            Jazz,
            Classical
        }

        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private int Length;
            private Genre Genre;

            public void setTitle(string title)
            {
                Title = title;
            }

            public void setArtist(string artist)
            {
                Artist = artist;
            }

            public void setAlbum(string album)
            {
                Album = album;
            }

            public void setGenre(Genre genre)
            {
                Genre = genre;
            }

            public void setLength(int length)
            {
                Length = length;
            }

            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist + "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How many songs would you like to enter?");
                int size = int.Parse(Console.ReadLine());
                Music[] collection = new Music[size];

                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"Enter details for song {i + 1}:");
                    Console.WriteLine("What is the title of your song?");
                    collection[i].setTitle(Console.ReadLine());

                    Console.WriteLine("Who is the artist of the song?");
                    collection[i].setArtist(Console.ReadLine());

                    Console.WriteLine("What is the name of the album the song is on?");
                    collection[i].setAlbum(Console.ReadLine());

                    Console.WriteLine("Enter the length of the song (in seconds): ");
                    collection[i].setLength(int.Parse(Console.ReadLine()));

                    Console.WriteLine("What is the genre of the song?");
                    Console.WriteLine("R - Rock\nP - Pop\nH - HipHop\nJ - Jazz\nC - Classical");
                    Genre tempGenre = Genre.Rock;
                    char g = char.Parse(Console.ReadLine());
                    switch (g)
                    {
                        case 'R':
                            tempGenre = Genre.Rock;
                            break;
                        case 'P':
                            tempGenre = Genre.Pop;
                            break;
                        case 'H':
                            tempGenre = Genre.HipHop;
                            break;
                        case 'J':
                            tempGenre = Genre.Jazz;
                            break;
                        case 'C':
                            tempGenre = Genre.Classical;
                            break;
                    }
                    collection[i].setGenre(tempGenre);
                }

                Console.WriteLine("\nSongs Entered:");
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"Song {i + 1}:\n{collection[i].Display()}\n");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}