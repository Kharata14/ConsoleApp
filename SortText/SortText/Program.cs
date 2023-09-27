

using System.Collections;

string input = @"C:\Users\User\Desktop\Numbers.txt";

string text = File.ReadAllText(input);
string[] lines = text.Split(',');

int[] a = lines.Select(int.Parse).ToArray();
int t;

foreach (int aa in a)
    Console.Write(aa + " ");
Console.Write("\n");

for (int i = 0; i < lines.Length; i++)
{
    if (int.TryParse(lines[i], out int number))
    {
        a[i] = number;
    }
}

for (int p = 0; p < a.Length - 1; p++)
{
    for (int i = 0; i < a.Length - 1; i++)
    {
        if (a[i] > a[i + 1])
        {
            t = a[i + 1];
            a[i + 1] = a[i];
            a[i] = t;
        }
    }
}
foreach (int aa in a)
    Console.Write(aa + " ");
Console.Write("\n");

string output = @"C:\Users\User\Desktop\Passed.txt";

using (StreamWriter writer = new StreamWriter(output))
{
    foreach (int num in a)
    {
        writer.Write(num);
        writer.Write(" ");
    }
}

