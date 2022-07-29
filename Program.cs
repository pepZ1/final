string[] arr1 = new string[3] { "hello", "2", ";-)" };
string[] arr2 = new string[arr1.Length];
int count = 0;
void CheckMass(string[] mass1, string[] mass2)
{
    for (int i = 0; i < mass1.Length; i++)
    {
        if (mass1[i].Length <= 3)
        {
            mass2[count] = mass1[i];
            count++;
        }
    }
}

CheckMass(arr1, arr2);

void PrintMass(string[] mass)
{
    for (int i = 0; i < arr2.Length; i++)
    {
        Console.Write($"{arr2[i]} ");
    }
}
PrintMass(arr2);