using DndDice.Die;

D4 d4 = new();
D6 d6 = new();

for (int i = 0; i < 10; i++)
{
  Console.WriteLine(d4.Roll());
}
for (int i = 0;i < 10; i++)
{
  Console.WriteLine(d6.Roll());
}
