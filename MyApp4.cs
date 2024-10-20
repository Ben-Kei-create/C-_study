using System;

class MyApp4 {
    static void SayHi(string name){
        Console.WriteLine("Hi!");
        // return "hi!";
    }

    // static string SayHi() => "hi!";

    static void Main() {
        //method
        SayHi("Tom");
        Console.WriteLine(SayHi());
    }

}