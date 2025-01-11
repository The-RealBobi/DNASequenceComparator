using System;

class Program {
  private static string oSequence, nSequence;
  private static char[] oSeqChar, nSeqChar;
  private static float changes = 0;
  
  public static void Main (string[] args) {
    
    if(args[0] == null){
      Console.WriteLine("Falta por poner la secuencia 1.");
      Console.WriteLine("USO:");
      Console.WriteLine("sequence.exe '[SECUENCIA 1]' [SECUENCIA 2]'");
      return;
    }

    if(args[1] == null){
      Console.WriteLine("Falta por poner la secuencia 2.");
      Console.WriteLine("USO");
      Console.WriteLine("sequence '[SECUENCIA 1]' [SECUENCIA 2]'");
      return;
    }
    
    oSequence = args[0];
    oSeqChar = oSequence.ToCharArray();

    nSequence = args[1];
    nSeqChar = nSequence.ToCharArray();
    if(oSequence.Length != nSequence.Length){
      Console.WriteLine("Las dos secuencias no tienen la misma longitud.");
      return;
    }
    for(int i = 0; i < oSeqChar.Length; i++){
      if(oSeqChar[i] != nSeqChar[i]){
        changes++;
      }
    }
    Console.WriteLine($"{changes} diferencias.");
    Console.WriteLine($"{(changes / oSeqChar.Length) * 100}% diferenciado sobre la secuencia original. ({changes} / {oSeqChar.Length})");
  }
}
