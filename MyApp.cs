using System;
// comment
class MyApp {

// 変数の宣言と代入

 static void Main(){
    const string msg = "Hello World!";
  //  Console.WriteLine("Hello World!");
    // Console.WriteLine(msg);
    // 論理値
    // bool flag = true;
    // var x = 5;

    //   var score = int.Parse(Console.ReadLine());

    //   if(score > 80){
    //     Console.WriteLine("Great");
    //   } else if (score > 60) {
    //     Console.WriteLine("Good");
    //  } else {
    //     Console.WriteLine("so so ...!");
    //   }
    // }

    //   Console.WriteLine((score > 80)? "Great" : "so so ...");

    var signal = Console.ReadLine();
      switch(signal){
        case "red":
        Console.WriteLin("Stop");
        break;

      case "blue":
        Console.WriteLin("GO!");
        break;

        case "yellow":
        Console.WriteLin("Caution");
        break;

        default:
          Console.WriteLine("wrong signal.");
          break;
    }
  }
}