//Найти сумму элементов массива, лежащих между максимальныи и минимальным по значению элементами
//Console.Write("Введите число");
//int numbers = Console.ReadLine();
//int numbers = new Random().Next(1, 10);

//int[] arrey_numbers = new int[new Random().Next(1, 10)];
//Console.Write(arrey_numbers);
//int index = 0;

//if (index < arrey_numbers.Length)
//{
//    arrey_numbers[index] = index++;
//    index++;
//}

int[] arrey_numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };
Console.WriteLine(arrey_numbers);
int index = 0;
int max = arrey_numbers[0];
int min = arrey_numbers[0];
int max_i = 0;
int min_i = 0;
int Summ = 0;

while (index < arrey_numbers.Lenght)
{
    if (arrey_numbers[index] < max)
    {
        if (arrey_numbers[index] > min)
        {
            index++;                           // index+1 нужно как-то вытащить,чтобы не писать его 3 раза
        }
        else
        {
            min = arrey_numbers[index];
            min_i = index;
            index++;
        }

    }
    else
    {
        max = arrey_numbers[index];
        max_i = index;
        index++;
    }

}
else
{
    if (max_i < min_i)
    {
        int max_i_step = max_i + 1;
        if (max_i_step < min_i)
        {
            Summ += arrey_numbers[max_i_step];
            max_i_step++;
        }
             
    }
    else
    {
        int min_i_step=min_i+1;
        if(min_i_step<max_i)
        {
            Summ+=arrey_numbers[min_i_step];
        }
 
    }
Console.Write("Сумма элементов массива лежащих между max и min по значению элементов, ")
Console.WriteLine(Summ); //
}



