using _03_ExtensionMethods;

namespace ExtensionMethods;

internal class Program
{
    static void Main(string[] args)
    {
        //Task 3.
        //Extension methods yaradın:
        //ToCapitalize() - stringin 1 - ci hərfini böyük etsin
        //CountWords() - söz sayını hesablasın(loop ilə)
        //Main() methodunda:
        //Istifadechiden cümlə alın.Hər iki methodu tətbiq edin və nəticəni çıxarın.

        Console.WriteLine("Cumleni daxil edin:");
        string word = Console.ReadLine();
        Console.WriteLine(word.ToCapitalize());


        Console.WriteLine("Cumleni daxil edin:");
        string sentence = Console.ReadLine();
        Console.WriteLine(sentence.CountWords());

    }
}