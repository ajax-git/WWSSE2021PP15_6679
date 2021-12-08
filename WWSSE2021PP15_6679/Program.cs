/*
    Napisz program, który wczytuje ze standardowego wejścia kolejne znaki i zamienia małe litery na duże i zapisuje na standardowe wyjście.
*/

// https://docs.microsoft.com/pl-pl/dotnet/standard/base-types/changing-case
// ToUpper - na wielkie litery
// ToLower - na małe litery

Console.WriteLine("Wpisz jakiś tekst: ");
string text = Console.ReadLine();

Console.WriteLine(text.ToUpper());