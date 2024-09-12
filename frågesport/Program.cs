﻿int points = 0;

string name = "Alex-Ovidiu";

bool isAlive = name == "Alex-Ovidiu"; 

Console.WriteLine("välkommen till mitt frågesport om gymmet!");

Console.WriteLine("1: Vilken muskel tränas av RDLS?");

Console.WriteLine("a)Hamstrings   b)Bröst   c)Axlar ");

string answer1 = Console.ReadLine();
if (answer1 == "a")
{
  points++;
  Console.WriteLine("CORRECT");
}
else
{
  Console.WriteLine("INCORRECT");
}

Console.WriteLine("2: Vilka muskler arbetas när man bench pressar?");

Console.WriteLine("a) Biceps, Triceps och Forearms b) Ben och Rygg c) Bröst, Axlar och Triceps");

string answer2 = Console.ReadLine();
if (answer2 == "c")
{
  points++;
  Console.WriteLine("CORRECT");
}
else
{
  Console.WriteLine("INCORRECT");
}

Console.WriteLine("3: Vilka muskler tränas av Romanian Deadlift ?");

Console.WriteLine("a) Biceps och axlar  b) ryggen och benen  c) Triceps och traps");

string answer3 = Console.ReadLine();
if (answer3 == "b")
{
  points++;
  Console.WriteLine("CORRECT");
}
else
{
  Console.WriteLine("INCORRECT");
}

Console.WriteLine($"Du fick {points} poäng.");
if (points == 0)
{
  Console.WriteLine("Du är inte bra på de här alls.");
}
else if (points < 3)
{
  Console.WriteLine("OK, du har lite koll - eller gissade rätt en eller ett par gånger.");
}
else 
{
  Console.WriteLine("Grattis! Du hade alla rätt!");
}

Console.WriteLine("Tryck på valfri tangent för att avsluta.");
Console.ReadKey();