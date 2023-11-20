
using Скоропечатание;

Console.WriteLine("Введите имя");
string name = Console.ReadLine();
Console.WriteLine("Нажмите Enter для начало");
ConsoleKeyInfo key = Console.ReadKey();
float z = 100;
if (key.Key == ConsoleKey.Enter)
{

    Console.Clear();
    Textik();
}


void Textik()
{
    Console.Write("Когда человек сознательно или интуитивно выбирает себе в жизни какую-то цель, жизненную задачу, он невольно дает себе оценку. По тому, ради чего человек живет, можно судить и о его самооценке - низкой или высокой. Если человек живет, чтобы приносить людям добро, облегчать их страдания, давать людям радость, то он оценивает себя на уровне этой своей человечности. Он ставит себе цель, достойную человека.");

}
Thread thread = new Thread(new ThreadStart(Method));
thread.Start();
Text txt = new Text();
txt.Textik();
Watch watch = new Watch();


void Method()
{
    int ch = 60;
    Console.WriteLine("");
    while (true)
    {
        ch--;

        Console.SetCursorPosition(7, 7);
        Console.Write(ch);
        Thread.Sleep(1000);
        if (ch == 0)
        {
            Console.SetCursorPosition(7, 8);
            Console.WriteLine("Стоп");
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Символы в мин: " + 100 );
            Console.WriteLine("Символы в сек: " + z/60);
            break;

        }
    }
}


