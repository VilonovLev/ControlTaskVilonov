/* Задача: Написать программу которая из имеющегося массива строк формирует массив строк, 
длинна которых меньше или равна 3 символа. Первоначальный массив можно вести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется использовать коллекции,
лучше обойтись исключительно массивами.*/

string[] stringArray = {"afaf", "003", "lolol", "-2", " ", "234"}; // согласно условию
int maxLengthSring = 3; // согласно условию
string[] cutArray = CutLongStr(stringArray,maxLengthSring); 

//Метод 

string[] CutLongStr(string[] array, int maxChars)
{
    // подсчет кол-ва эллементов соответствующих заданному условию
    int countShortStr = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= maxChars)
        {
            countShortStr++;
        }
    }
    // создание нового массива и его возвращение
    string[] newArray = new string[countShortStr];
    if(countShortStr == 0)
    {
        return newArray;
    }
    else
    {
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i].Length <= maxChars)
            {
                countShortStr--;
                newArray[countShortStr] = array[i];
            }
        }
        return newArray;
    }
}
