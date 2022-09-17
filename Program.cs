string[] M = {"house", "234", "Hospital", "cup", "2^3", "M", "geekbrains", "%", "C#"}; // Создание массива М из различных строк
List<string> newList = new List<string>();  // Создание пустого списка

for (int i=0; i<M.Length; i++)  // Поиск и добавление в список строк с количеством символов 3 и менее
{
    if (M[i].Length <= 3)
    {
        newList.Add(M[i]);
    }
}

string[] newM = newList.ToArray(); // Конвертация списка в новый массив

Console.WriteLine($"[{string.Join(", ", newM)}]"); // Вывод нового массива