namespace Modul11
{
    class Program
{
    static void Main()
    {
        using (var film = new Film
        {
            Title = "Inception",
            Studio = "Warner Bros.",
            Genre = "Sci-Fi",
            Duration = 148,
            Year = 2010
        })
        {
            Console.WriteLine($"Фільм: {film.Title}, Студія: {film.Studio}, Жанр: {film.Genre}, Тривалість: {film.Duration} хвилин, Рік: {film.Year}");
        }

            using (var play = new Play
            {
                Title = "Hamlet",
                Theater = "Royal Shakespeare Company",
                Genre = "Tragedy",
                Duration = 180,
                Actors = new List<string> { "Actor 1", "Actor 2", "Actor 3" }
            })
            {
                Console.WriteLine($"Вистава: {play.Title}, Театр: {play.Theater}, Жанр: {play.Genre}, Тривалість: {play.Duration} хвилин, Актори: {string.Join(", ", play.Actors)}");
            }
        }
}
}
