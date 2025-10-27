using movie;
using System;

namespace MovieTheater
{
    internal class Program
    {
        static Theater[] theaters = new Theater[0];
        static Genre[] genres = new Genre[0];
        static Movie[] movies = new Movie[0];

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("MENYU");
                Console.WriteLine("1. Yeni teatr yarat");
                Console.WriteLine("2. Yeni janr yarat");
                Console.WriteLine("3. Yeni film yarat");
                Console.WriteLine("4. Teatra daxil ol");
                Console.WriteLine("5. Proqramdan çıx");
                Console.Write("Seçiminiz: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateTheater();
                        break;
                    case "2":
                        CreateGenre();
                        break;
                    case "3":
                        CreateMovie();
                        break;
                    case "4":
                        EnterTheater();
                        break;
                    case "5":
                        Console.WriteLine("Proqram dayandırıldı.");
                        return;
                    default:
                        Console.WriteLine("Yanlış seçim etdiniz! Yeniden cehd edin!");
                        break;
                }
            }
        }

        
        static void CreateTheater()
        {
            Console.Write("Teatrın adını daxil edin: ");
            string name = Console.ReadLine();

            Theater theater = new Theater(name);
            Array.Resize(ref theaters, theaters.Length + 1);
            theaters[theaters.Length - 1] = theater;

            
        }

       
        static void CreateGenre()
        {
            Console.Write("Janrın adını daxil edin: ");
            string name = Console.ReadLine();

            Genre genre = new Genre(name);
            Array.Resize(ref genres, genres.Length + 1);
            genres[genres.Length - 1] = genre;

    
        }

        
        static void CreateMovie()
        {
            if (genres.Length == 0)
            {
                Console.WriteLine("Əvvəlcə janr yaradın!");
                return;
            }

            Console.Write("Filmin adını daxil edin: ");
            string name = Console.ReadLine();

            Console.Write("Rejissorun adını daxil edin: ");
            string director = Console.ReadLine();

            Console.WriteLine("Janr daxil et");
            string genre = Console.ReadLine();

            Console.Write("Filmin yaş məhdudiyyətini daxil edin (13, 16, 18): ");
            int ageLimit = Convert.ToInt32(Console.ReadLine());

            Movie movie = new Movie(name, director, genre, ageLimit);
            Array.Resize(ref movies, movies.Length + 1);
            movies[movies.Length - 1] = movie;

            Console.WriteLine($"'{movie.Name}' filmi yaradıldı.");
        }

        
        static void EnterTheater()
        {
            if (theaters.Length == 0)
            {
                Console.WriteLine("Heç bir teatr yoxdur!");
                return;
            }

            Console.WriteLine("Mövcud teatrlar:");
            for (int i = 0; i < theaters.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {theaters[i].Name}");
            }

            Console.Write("Seçiminiz (nömrə ilə): ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            Theater selected = theaters[index];
            TheaterMenu(selected);
        }

       
        static void TheaterMenu(Theater theater)
        {
            while (true)
            {
                Console.WriteLine($" {theater.Name} Teatr Menyusu");
                Console.WriteLine("1. Film əlavə et");
                Console.WriteLine("2. Filmləri göstər");
                Console.WriteLine("3. Film sil");
                Console.WriteLine("4. Teatrdan çıx");
                Console.Write("Seçiminiz: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddMovieToTheater(theater);
                        break;
                    case "2":
                        theater.ListAllMovies();
                        break;
                    case "3":
                        RemoveMovieFromTheater(theater);
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Yanlış seçim!");
                        break;
                }
            }
        }

        
        static void AddMovieToTheater(Theater theater)
        {
            if (movies.Length == 0)
            {
                Console.WriteLine("Əvvəlcə film yaradın!");
                return;
            }

            Console.WriteLine("Mövcud filmlər:");
            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {movies[i].Name}");
            }

            Console.Write("Əlavə etmək istədiyiniz filmi seçin: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            theater.AddMovie(movies[index]);
        }

       
        static void RemoveMovieFromTheater(Theater theater)
        {
            if (theater._movies.Length == 0)
            {
                Console.WriteLine("Teatrda film yoxdur!");
                return;
            }

            Console.WriteLine("Teatr repertuarındakı filmlər:");
            for (int i = 0; i < theater._movies.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {theater._movies[i].Name}");
            }

            Console.Write("Silinəcək filmi seçin: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            theater.RemoveMovie(theater._movies[index]);
        }
    }
}
