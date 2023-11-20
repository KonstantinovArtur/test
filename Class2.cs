

namespace Скоропечатание
{
     public class Text
     {
        public int Textik()
        {
            {

                string txt = "Когда человек сознательно или интуитивно выбирает себе в жизни какую-то цель, жизненную задачу, он невольно дает себе оценку. По тому, ради чего человек живет, можно судить и о его самооценке - низкой или высокой. Если человек живет, чтобы приносить людям добро, облегчать их страдания, давать людям радость, то он оценивает себя на уровне этой своей человечности.";
                int pos = -1;
                int poss = 0;
                
                ConsoleKeyInfo key = Console.ReadKey(true);


                while (key.Key != ConsoleKey.Enter)

                {




                    if (txt[pos+1] == key.KeyChar || pos == 0 || pos == 100)
                    {

                        pos++;
                       
                        Console.ForegroundColor = ConsoleColor.Green;

                    }

                    if (pos == 405)
                    {
                        Console.Clear();
                        float r = pos;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Имя ");
                        Console.WriteLine("Символы в мин: " + r);
                        Console.WriteLine("Символы в сек: " + r/60);
                        break;


                    }







                    else if (key.Key == ConsoleKey.Escape)
                    {
                        return -1;
                    }

                    Console.SetCursorPosition(pos, poss);
                    Console.Write(key.KeyChar);

                    key = Console.ReadKey(true);
                }

                return pos;


            }
        }

     }
}
