using System;

namespace C_
{
  class bot
  {
    public string hi = "hi , I'm C# :)";
    public int speed = 200 ;
    public string name = "A3IPC";
    public string model ;

    public bot(string modelName = "Bot"){
      model = modelName ; // Set the initial value for model
    }
    public void fullThrottle(){
      Console.WriteLine("The car is going as fast as it can!"); 
    }
  }
}