using System;

class Program
{
    private static List<string> jokes = new List<string>()
    {
        "- Официант, у меня в супе муха! - Вот и попалась, наконец!",
        "Новинка книжного рынка \"Мемуары Кота Ученого\", песни и сказки для тех, кто ходит налево и направо...",
        "Новый \"Фейри\" с ароматом конопли - мой посуду весело!",
        "Начальник отдела входит в кабинет и орёт на сотрудников: - Я же сказал: во время работы курить запрещается! На что получает ответ: - А кто работает?"
    };
    private static List<string> badWordPhrases = new List<string>() { "ты гений?",  "Ты лучший!", "Зачем ты это сделал?", "ээээ... ват э Sigma?", "ты пупс", "нет, я не пупс" };
    private static List<string> badWords = new List<string>() { "кек", "лол" };

    private static void Main(string[] args)
    {
        string name = Console.ReadLine();
        Console.WriteLine($"Привет {name}");

        while (true)
        {
            string cmd = Console.ReadLine();

            string[] words = cmd.Split(' ');

            foreach (var i in words)
            {
                if (badWords.Contains(i))
                {
                    Console.WriteLine(badWordPhrases[new Random().Next(0, badWordPhrases.Count)]);
                    continue;
                }
            }

            string response = cmd switch
            {
                "расскажи шутку" => jokes[new Random().Next(0, jokes.Count)],
                "пока" => $"До свидания, {name}"
            };

            Console.WriteLine(response);

            if (cmd == "пока")
                break;
        }
    }
}
