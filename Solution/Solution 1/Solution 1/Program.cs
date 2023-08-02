// See https://aka.ms/new-console-template for more information
int num = int.Parse(Console.ReadLine());
for (int i = 0; i < num; i++)
{
    Console.WriteLine(("A" + " " + i) + "Hello world");
    Console.WriteLine(i++);
}
