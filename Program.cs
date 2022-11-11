ConsoleKeyInfo key = Console.ReadKey();

int p = 3;
Console.Clear();

while (true)
{
    Menu();
    Console.SetCursorPosition(0, p);
    Console.WriteLine("->");

    key = Console.ReadKey();

    if (key.Key == ConsoleKey.UpArrow)
    {
        p--;
    }

    if (key.Key == ConsoleKey.DownArrow)
    {
        p++;
    }

    if (p < 3)
    {
        p = 3;
    }
    if (p > 9)
    {
        p = 9;
    }
    Console.SetCursorPosition(0, p);
    Console.WriteLine("->");
    Console.Clear();
    int pos = 3;
    if ((key.Key == ConsoleKey.Enter) & (p == 3))
    {

        ConsoleKeyInfo key1 = Console.ReadKey();
        Console.Clear();
        while (key1.Key == ConsoleKey.UpArrow || key1.Key == ConsoleKey.DownArrow)
        {
            Menu2();
            форма();
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");

            key1 = Console.ReadKey();

            if (key1.Key == ConsoleKey.UpArrow)
            {
                pos--;
            }

            if (key1.Key == ConsoleKey.DownArrow)
            {
                pos++;
            }

            if (pos < 3)
            {
                pos = 3;
            }
            if (pos > 5)
            {
                pos = 5;
            }
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");
            Console.Clear();
            if (key1.Key == ConsoleKey.Escape)
            {
                break;
            }
            if (key1.Key == ConsoleKey.Escape && p == 3)
            {

            }
        }

    }
    if ((key.Key == ConsoleKey.Enter) & (p == 4))
    {

        ConsoleKeyInfo key1 = Console.ReadKey();
        Console.Clear();
        while (key1.Key == ConsoleKey.UpArrow || key1.Key == ConsoleKey.DownArrow)
        {
            Menu2();
            размер();
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");

            key1 = Console.ReadKey();

            if (key1.Key == ConsoleKey.UpArrow)
            {
                pos--;
            }

            if (key1.Key == ConsoleKey.DownArrow)
            {
                pos++;
            }

            if (pos < 3)
            {
                pos = 3;
            }
            if (pos > 5)
            {
                pos = 5;
            }
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");
            Console.Clear();
            if (key1.Key == ConsoleKey.Escape)
            {
                break;
            }
            if (key1.Key == ConsoleKey.Escape && p == 3)
            {

            }
        }

    }

    if ((key.Key == ConsoleKey.Enter) & (p == 5))
    {

        ConsoleKeyInfo key1 = Console.ReadKey();
        Console.Clear();
        while (key1.Key == ConsoleKey.UpArrow || key1.Key == ConsoleKey.DownArrow)
        {
            Menu2();
            вкус();
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");

            key1 = Console.ReadKey();

            if (key1.Key == ConsoleKey.UpArrow)
            {
                pos--;
            }

            if (key1.Key == ConsoleKey.DownArrow)
            {
                pos++;
            }

            if (pos < 3)
            {
                pos = 3;
            }
            if (pos > 5)
            {
                pos = 5;
            }
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");
            Console.Clear();
            if (key1.Key == ConsoleKey.Escape)
            {
                break;
            }
            if (key1.Key == ConsoleKey.Escape && p == 3)
            {

            }
        }

    }

    if ((key.Key == ConsoleKey.Enter) & (p == 6))
    {

        ConsoleKeyInfo key1 = Console.ReadKey();
        Console.Clear();
        while (key1.Key == ConsoleKey.UpArrow || key1.Key == ConsoleKey.DownArrow)
        {
            Menu2();
            количество();
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");

            key1 = Console.ReadKey();

            if (key1.Key == ConsoleKey.UpArrow)
            {
                pos--;
            }

            if (key1.Key == ConsoleKey.DownArrow)
            {
                pos++;
            }

            if (pos < 3)
            {
                pos = 3;
            }
            if (pos > 5)
            {
                pos = 5;
            }
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");
            Console.Clear();
            if (key1.Key == ConsoleKey.Escape)
            {
                break;
            }
            if (key1.Key == ConsoleKey.Escape && p == 3)
            {

            }
        }

    }

    if ((key.Key == ConsoleKey.Enter) & (p == 7))
    {

        ConsoleKeyInfo key1 = Console.ReadKey();
        Console.Clear();
        while (key1.Key == ConsoleKey.UpArrow || key1.Key == ConsoleKey.DownArrow)
        {
            Menu2();
            глазурь();
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");

            key1 = Console.ReadKey();

            if (key1.Key == ConsoleKey.UpArrow)
            {
                pos--;
            }

            if (key1.Key == ConsoleKey.DownArrow)
            {
                pos++;
            }

            if (pos < 3)
            {
                pos = 3;
            }
            if (pos > 5)
            {
                pos = 5;
            }
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");
            Console.Clear();
            if (key1.Key == ConsoleKey.Escape)
            {
                break;
            }
            if (key1.Key == ConsoleKey.Escape && p == 3)
            {

            }
        }

    }

    if ((key.Key == ConsoleKey.Enter) & (p == 8))
    {

        ConsoleKeyInfo key1 = Console.ReadKey();
        Console.Clear();
        while (key1.Key == ConsoleKey.UpArrow || key1.Key == ConsoleKey.DownArrow)
        {
            Menu2();
            декор();
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");

            key1 = Console.ReadKey();

            if (key1.Key == ConsoleKey.UpArrow)
            {
                pos--;
            }

            if (key1.Key == ConsoleKey.DownArrow)
            {
                pos++;
            }

            if (pos < 3)
            {
                pos = 3;
            }
            if (pos > 5)
            {
                pos = 5;
            }
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");
            Console.Clear();
            if (key1.Key == ConsoleKey.Escape)
            {
                break;
            }
            if (key1.Key == ConsoleKey.Escape && p == 3)
            {

            }
        }

    }



    static void Menu()
    {
        Console.WriteLine("Заказ тортов");
        Console.WriteLine("Выберите параметр торта");
        Console.WriteLine("- - - - - - - - - - - - - - ");
        Console.WriteLine("   Форма торта");
        Console.WriteLine("   Размер торта");
        Console.WriteLine("   Вкус коржей");
        Console.WriteLine("   Количество коржей");
        Console.WriteLine("   Глазурь");
        Console.WriteLine("   Декор");
        Console.WriteLine("   Конец заказа");
    }

    static void Menu2()
    {
        Console.WriteLine("Для выхода нажмите Escape");
        Console.WriteLine("Выберите пункт из меню: ");
        Console.WriteLine("- - - - - - - - - - - - - - ");
    }

    static void форма()
    {
        форма krug = new форма();
        {
            krug.form = "   Круг - ";
            krug.money = 0;
        }
        Console.WriteLine(krug.form + krug.money);

        форма kvadrat = new форма();
        {
            kvadrat.form = "   Квадрат - ";
            kvadrat.money = 0;
        }
        Console.WriteLine(kvadrat.form + kvadrat.money);

        форма pryamoyg = new форма();
        {
            pryamoyg.form = "   Прямоугольник - ";
            pryamoyg.money = 0;
        }
        Console.WriteLine(pryamoyg.form + pryamoyg.money);
    }


    static void размер()
    {
        размер small = new размер();
        {
            small.raz = "   Маленький - ";
            small.money = 0;
        }
        Console.WriteLine(small.raz + small.money);

        размер obich = new размер();
        {
            obich.raz = "   Обычный - ";
            obich.money = 0;
        }
        Console.WriteLine(obich.raz + obich.money);

        размер big = new размер();
        {
            big.raz = "   Большой  - ";
            big.money = 0;
        }
        Console.WriteLine(big.raz + big.money);
    }


    static void вкус()
    {
        вкус malina = new вкус();
        {
            malina.vk = "   Малина - ";
            malina.money = 0;
        }
        Console.WriteLine(malina.vk + malina.money);

        вкус chokolate = new вкус();
        {
            chokolate.vk = "   Шоколад - ";
            chokolate.money = 0;
        }
        Console.WriteLine(chokolate.vk + chokolate.money);

        вкус vanil = new вкус();
        {
            vanil.vk = "   Ваниль - ";
            vanil.money = 0;
        }
        Console.WriteLine(vanil.vk + vanil.money);
    }


    static void количество()
    {
        количество onekorsh = new количество();
        {
            onekorsh.korj = "   1 корж - ";
            onekorsh.money = 0;
        }
        Console.WriteLine(onekorsh.korj + onekorsh.money);

        количество twokorsh = new количество();
        {
            twokorsh.korj = "   2 коржа - ";
            twokorsh.money = 0;
        }
        Console.WriteLine(twokorsh.korj + twokorsh.money);

        количество threekorsh = new количество();
        {
            threekorsh.korj = "   3 коржа - ";
            threekorsh.money = 0;
        }
        Console.WriteLine(threekorsh.korj + threekorsh.money);
    }


    static void глазурь()
    {
        глазурь pinkglazyr = new глазурь();
        {
            pinkglazyr.glaz = "   розовая - ";
            pinkglazyr.money = 0;
        }
        Console.WriteLine(pinkglazyr.glaz + pinkglazyr.money);

        глазурь whiteglazyr = new глазурь();
        {
            whiteglazyr.glaz = "   белая - ";
            whiteglazyr.money = 0;
        }
        Console.WriteLine(whiteglazyr.glaz + whiteglazyr.money);

        глазурь blackglazyr = new глазурь();
        {
            blackglazyr.glaz = "   черная - ";
            blackglazyr.money = 0;
        }
        Console.WriteLine(blackglazyr.glaz + blackglazyr.money);
    }


    static void декор()
    {
        декор businki = new декор();
        {
            businki.dek = "   что-то с бусинками - ";
            businki.money = 0;
        }
        Console.WriteLine(businki.dek + businki.money);

        декор poterki = new декор();
        {
            poterki.dek = "   что-то с поттеками - ";
            poterki.money = 0;
        }
        Console.WriteLine(poterki.dek + poterki.money);

        декор risunok = new декор();
        {
            risunok.dek = "   что-то с рисунком - ";
            risunok.money = 0;
        }
        Console.WriteLine(risunok.dek + risunok.money);
    }

    if ((key.Key == ConsoleKey.Enter) & (p == 9))
    {
        Console.Clear();
        Console.WriteLine("вы закончили. Итоговая цена - 0 (чек вам не нужен, мы боимся за экологию)");
    }
}

