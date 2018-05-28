using System;
class StringsAndObjects
    {
        static void Main()
        {
        //Declare two string variables and assign them with “Hello” and “World”.
        //Declare an object variable and assign it with the concatenation
        //of the first two variables (mind adding an interval between).
        string h = "Hello";
        string w = "World";
        object hw = ("Hello" + " " + "World");
        string sentence = (string)hw;
        Console.WriteLine(sentence);
    }
    }
