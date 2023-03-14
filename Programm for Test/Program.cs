string[] array = {"hi", "Vhagar", "pam-param-pam", ":-)", "etc", "5", "~+_%<"};
Console.WriteLine($"Первоначальный массив: {"hi"}, {"Vhagar"}, {"pam-param-pam"}, {":-)"}, {"etc"}, {"5"}, {"~+_%<"}");
FindThreeCharactersElement(array);

void FindThreeCharactersElement(string[] array)
{
    Console.Write($"Массив после выборки: ");
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index].Length <= 3)
        {
           Console.Write($"{array[index]} "); 
        }
    }
}