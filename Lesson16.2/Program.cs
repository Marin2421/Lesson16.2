
        char[,] mas1 = new char[11, 6]
        {
            {' ', ' ', 'X', 'X', ' ', ' '},
            {' ', 'X', ' ', ' ', 'X', ' '},
            {'X', ' ', ' ', ' ', ' ', 'X'},
            {' ', 'X', 'X', 'X', 'X', ' '},
            {' ', ' ', 'X', 'X', ' ', ' '},
            {' ', ' ', 'X', 'X', ' ', ' '},
            {' ', ' ', 'X', 'X', ' ', ' '},
            {' ', ' ', 'X', 'X', ' ', ' '},
            {' ', ' ', 'X', 'X', ' ', ' '},
            {' ', ' ', 'X', 'X', ' ', ' '},
            {' ', 'X', 'X', 'X', 'X', ' '}
        };

        char[,] mas2 = new char[11, 6]
        {
            {' ', ' ', 'X', 'X', ' ', ' '},
            {' ', 'X', 'X', 'X', 'X', ' '},
            {'X', 'X', 'X', 'X', 'X', 'X'},
            {' ', 'X', 'X', 'X', 'X', ' '},
            {' ', ' ', 'X', 'X', ' ', ' '},
            {' ', ' ', 'X', 'X', ' ', ' '},
            {' ', ' ', 'X', 'X', ' ', ' '},
            {' ', ' ', 'X', 'X', ' ', ' '},
            {' ', ' ', 'X', 'X', ' ', ' '},
            {' ', ' ', 'X', 'X', ' ', ' '},
            {' ', 'X', 'X', 'X', 'X', ' '}
        };

        bool isMas1 = true;

        while (true)
        {
            char[,] currentArray = isMas1 ? mas1 : mas2; // Выбор текущего массива в зависимости от состояния

            for (int i = 0; i < currentArray.GetLength(0); i++)
            {
                for (int j = 0; j < currentArray.GetLength(1); j++)
                {
                    Console.Write(currentArray[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.Write("Включить/Выключить (да/нет)? ");
            string str = Console.ReadLine();

            if (str.ToLower() == "да")
            {
                isMas1 = !isMas1; // Переключение между массивами
            }
            else if (str.ToLower() == "нет")
            {
                break; // Выход из цикла при вводе "нет"
            }
            else
            {
                Console.WriteLine("Неверный ввод. Повторите попытку.");
            }
        }
    
