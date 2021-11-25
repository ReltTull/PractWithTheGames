void GameMove(int count)
{
    int GenerateNumber(int LeftBound, int RightBound)
    {
        int FinalNumber = new Random().Next(LeftBound, RightBound);
        return FinalNumber;
    }
    int HiddenNumb = GenerateNumber(1, 10);
    for (int i = 0; i <= count; i++)
    {
        int RequestNumb()
        {
            Console.Write("Введите число: ");
            int Numb = Convert.ToInt32(Console.ReadLine());
            return Numb;
        }
        int CurrentNumb = RequestNumb();
        bool CheckAnswer(int HidNumb, int CurNumb)
        {
            if (HidNumb == CurNumb)
            {
                Console.WriteLine($"Hooray! Вы отгадали число за следующее количество попыток: {i + 1}.");
                return true;
            }
            else
            {
                if (CurrentNumb > HiddenNumb)
                { Console.WriteLine("Загаданное число меньше введенного"); }
                else { Console.WriteLine("Загаданное число больше введенного"); }
            }
            return false;
        }
        if (true == CheckAnswer(HiddenNumb, CurrentNumb))
        {
            break;
        }
        Console.WriteLine($"Осталось {count - i} попыток");
        CheckAnswer(HiddenNumb, CurrentNumb);
        if (i == count)
        {
            Console.WriteLine("Game over, man! Game over...");
        }
    }
}
GameMove(7);
System.Console.WriteLine();