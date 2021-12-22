//Making a list of inputs
var inputList = new List<string>();
string? input;

while ((input = Console.ReadLine()) is not null)
{
    inputList.Add(input);
}

//Frequency Checks
var frequencyOfOne = new List<int>();
var frequencyOfZero = new List<int>();
for (int i = 0; i < inputList[0].Length; i++)
{
    frequencyOfOne.Add(0);
    frequencyOfZero.Add(0);
}

foreach (string s in inputList)
{
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == '1')
        {
            frequencyOfOne[i]++;
        }
        else
        {
            frequencyOfZero[i]++;
        }
    }
}

//PRINT
foreach (int c in frequencyOfOne)
{
    Console.Write(c);
    Console.Write(", ");
}
Console.WriteLine();
foreach (int c in frequencyOfZero)
{
    Console.Write(c);
    Console.Write(", ");
}
Console.WriteLine();

//Lists
var possibleOxygen = new List<string>(inputList);
var possibleCO2 = new List<string>(inputList);

//Bit Criteria
char BitCriteriaO2(int index)
{
    char result = '0';
    if (frequencyOfOne[index] > frequencyOfZero[index])
    {
        result = '1';
    }
    return result;
}

char BitCriteriaCO2(int index)
{
    char result = '0';
    if (frequencyOfOne[index] < frequencyOfZero[index])
    {
        result = '1';
    }
    return result;
}

Console.WriteLine("Current possibleCO2 list:");
foreach (string s in possibleCO2)
{
    Console.WriteLine(s);
}
Console.WriteLine("//");

//Check if meet bit criteria - NEEDS TO BE BIT BY BIT
for (int i = 0; i < inputList[0].Length; i++)
{
    foreach (string s in inputList)
    {
        if (possibleOxygen.Count > 1 && s[i] != BitCriteriaO2(i))
        {
            possibleOxygen.Remove(s);
        }
        if (possibleCO2.Count > 1 && s[i] != BitCriteriaCO2(i))
        {
            possibleCO2.Remove(s);
        }
    }
    Console.WriteLine($"Checking bit #{i}. Current possibleCO2 list:");
    foreach (string s in possibleCO2)
    {
        Console.WriteLine(s);
    }
    Console.WriteLine("//");
}

//Print
foreach (string s in possibleOxygen)
{
    Console.WriteLine(s);
}
foreach (string s in possibleCO2)
{
    Console.WriteLine(s);
}

int result = (Convert.ToInt32(possibleOxygen[0], 2)) * (Convert.ToInt32(possibleCO2[0], 2));

Console.WriteLine(result);
