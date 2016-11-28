using System;

// Programa que suma números bien escritos hasta 12 en ingles y retorna el resultado de la suma en caso de haber sido bien escritos, caso contrario retornará el valor de "Zero".

namespace Prueba_ViveLab
{
    public class Program
    {
        public static void Main(string[] args)
        {
        string num, Resultado;
        int aux=0, cont=0, flag=0, ArabNumber;
        
            do
            {
              Console.Write("Por favor ingrese un número en inglés (máx 12):");
              num = Console.ReadLine(); // Lee el número ingresado en inglés
              ArabNumber = Convert2ArabNumbers(num); // Convierte el número a su correspondiente arábigo
                
              if (ArabNumber == 0)
                flag= 1;
              else 
                aux = aux + ArabNumber;
                
              cont++;
            } 
            
            while(cont<2);
            
            
            // Cálculo Final
            if (flag==1) // Caso en que un sumando esté mal escrito
              Resultado = "zero";
            else  // Caso ambos sumandos hayan sido escritos correctamente
              Resultado = Convert2WriteNum(aux);
        
        
        Console.Write(" \n - La suma de los números ingresados es : {0} ", Resultado);
        
        Console.Write("\n \n * Presione cualquier tecla para salir . . . ");
			Console.ReadKey(true);

        }
        
       
        public static int Convert2ArabNumbers(string num) // Método que convierte a números arábigos los números ingresados en inglés.
        {
          int ArabNumber; 
          
                if (num == "one")
                ArabNumber = 1;
                else if (num == "two")
                ArabNumber = 2;
                else if (num == "three")
                ArabNumber = 3;
                else if (num == "four")
                ArabNumber = 4;
                else if (num == "five")
                ArabNumber = 5;
                else if (num == "six")
                ArabNumber = 6;
                else if (num == "seven")
                ArabNumber = 7;
                else if (num == "eight")
                ArabNumber = 8;
                else if (num == "nine")
                ArabNumber = 9;
                else if (num == "ten")
                ArabNumber = 10;
                else if (num == "eleven")
                ArabNumber = 11;
                else if (num == "twelve")
                ArabNumber = 12;
                else 
                ArabNumber = 0;
                
                return ArabNumber;
        }
        
        public static string Convert2WriteNum(int num) // Método que convierte a números en ingles los números en representación arábiga.
        {
          string WriteNumber= ""; 
         
                if (num == 1)
                WriteNumber = "one";
                else if (num == 2)
                WriteNumber = "two";
                else if (num == 3)
                WriteNumber = "three";
                else if (num == 4)
                WriteNumber = "four";
                else if (num == 5)
                WriteNumber = "five";
                else if (num == 6)
                WriteNumber = "six";
                else if (num == 7)
                WriteNumber = "seven";
                else if (num == 8)
                WriteNumber = "eight";
                else if (num == 9)
                WriteNumber = "nine";
                else if (num == 10)
                WriteNumber = "ten";
                else if (num == 11)
                WriteNumber = "eleven";
                else if (num == 12)
                WriteNumber = "twelve";
                else if (num == 13)
                WriteNumber = "thirteen";
                else if (num == 14)
                WriteNumber = "fourteen";
                else if (num == 15)
                WriteNumber = "fiveteen";
                else if (num == 16)
                WriteNumber = "sixteen";
                else if (num == 17)
                WriteNumber = "seventeen";
                else if (num == 18)
                WriteNumber = "eighteen";
                else if (num == 19)
                WriteNumber = "nineteen";
                else if (num == 20)
                WriteNumber = "twenty";
                else if (num == 21)
                WriteNumber = "twenty-one";
                else if (num == 22)
                WriteNumber = "twenty-two";
                else if (num == 23)
                WriteNumber = "twenty-three";
                else if (num == 24)
                WriteNumber = "twenty-four";
                
                return WriteNumber;
        }
    }
}
