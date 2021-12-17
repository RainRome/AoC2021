int timesDepthIncreases = 0;
int? lastInput = null;
int input = 0;
string? inputString;

while ((inputString = Console.ReadLine()) != null)
{
    input = int.Parse(inputString);
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
