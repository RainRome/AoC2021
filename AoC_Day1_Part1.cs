int timesDepthIncreases = 0;
int? lastInput = null;
string? inputString;

while ((inputString = Console.ReadLine()) != null)
{
    int input = int.Parse(inputString);
    if (lastInput != null)
    {
        if (input > lastInput.Value)
        {
        timesDepthIncreases++;
        }
    }
    lastInput = input;
}

Console.WriteLine($"Amount of times depth increased: {timesDepthIncreases}");
