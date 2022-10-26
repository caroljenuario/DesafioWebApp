using System;

class Program {
  
  int total = 0; 
  public void sum(int num){   
    for (int i=1; i <= num;  i++) {
      total = total + i;
    }
    Console.WriteLine ("Soma->" +total);
    Console.ReadKey();  
  }

  public string Duplicates (string characters) { 
    if (characters.Length <= 1)
      return characters;
    if (characters[0] == characters[1])
      return Duplicates (characters.Substring(1));
    else
      return characters[0] + Duplicates(characters.Substring (1));
  }
  
  public void callMethods(){
    int num;
    Console.WriteLine ("Digite um numero");
    num = Convert.ToInt32(Console.ReadLine());
    sum(num); 

    Console.WriteLine ("Removedor de caracteres duplicados:");
    string nome;
    for (int i = 0; i< 3; i++) {
      Console.WriteLine("Digite uma string->"+i);
      nome = Console.ReadLine();
      Console.WriteLine ("Sem caracteres duplos: " +Duplicates(nome));
    }
  }
  
  public static void Main (string[] args) {
    Program program = new Program(); 
    program.callMethods();
  }
}