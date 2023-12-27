class Program
{
    static void Main()
    {
        char[] arr = new char[23] { 'А', ' ', 'Р', 'О', 'З', 'А', ' ', 'У', 'П', 'А', 'Л', 'А', ' ', 'Н', 'А', ' ', 'Л', 'А', 'П', 'У', ' ', 'А', 'З' };
        
        bool isPalindrome = true;
        
        for (int i = 0, j = arr.Length - 1; i < j; i++, j--)
        {
            // Пропускаем пробелы
            while (arr[i] == ' ')
                i++;
            while (arr[j] == ' ')
                j--;
            
            // Проверяем символы на равенство
            if (char.ToLower(arr[i]) != char.ToLower(arr[j]))
            {
                isPalindrome = false;
                break;
            }
        }
        
        if (isPalindrome)
            Console.WriteLine("Массив является палиндромом.");
        else
            Console.WriteLine("Массив не является палиндромом.");
    }
}