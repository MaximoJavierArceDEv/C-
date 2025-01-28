//Creacion de blackcjack, Juntar 21 pidiendo cartas o en caso de tener menors 21 igual tener mayor puntuacion que el dealer

//int totaljugador = 25;
//int totaldealer = 15;

using System.Threading.Tasks.Dataflow;
 System.Random random = new System.Random();
var totaljugador = 0;
var totaldealer = 0;
int num=0;
string controlOtraCarta = "";
string switchControl = "menu";
string message = "";
int PugaCoin = 0;

while (true)//Siempre esta prendido  While:Mientras 
{
    Console.WriteLine("Welcom al Pugasino");
    Console.WriteLine("Cuantos PugaCoin deseas? Recuerda que necesitas una por juego");
    Console.WriteLine("Ingresa un numero entero");
    PugaCoin = int.Parse(Console.ReadLine());
    for(int i = 0; i < PugaCoin; i++){
      switch(switchControl)
    {

        case "menu":
           
            
            Console.WriteLine("Escribe '21' para jugar al 21");
            switchControl = Console.ReadLine();
            i = i - 1;
            break;

        case "21":
          totaljugador = 0;
         totaldealer = 0;

        
       do {
      
       num = random.Next(1,12);
       int num1= random.Next(1,12);
       totaldealer = totaldealer + num1;
       totaljugador = totaljugador + num;

       Console.WriteLine("Toma tu carta jugador,");
       Console.WriteLine($"Te salio la carta {num} en total tenes: {totaljugador}");
       Console.WriteLine("Deseas otra carta? ");
       controlOtraCarta = Console.ReadLine();
       }while(controlOtraCarta == "Si" || controlOtraCarta == "si");
       

       totaldealer = random.Next(12,23);
       Console.WriteLine($"El dealer tiene {totaldealer}");
        
        
   
        
        //Lo vamos a usar con nuestro condicional IF
        if(totaljugador > totaldealer && totaljugador < 22 )
        {
            message = "Venciste al dealer, felicidades";
            switchControl = Console.ReadLine();

        }
        else if(totaljugador > 22)
        {
        message = "Perdiste vs el dealer, te pasaste de 21";
        switchControl = Console.ReadLine();

        }
        else if (totaljugador <= totaldealer){
            if(totaldealer >= 22){
            message = "El dealer se paso de 21 y vos no asi que ganaste";
            }else{
             message = "Perdiste vs el dealer, lo siento1";
            switchControl = Console.ReadLine(); 
            }  
        }
        else if(totaljugador>totaldealer){
            if(totaljugador>=22){
                message = "Perdiste te pasaste de 21";
            }
        }
        else{
        message = "Condicion no valida";  
        switchControl = Console.ReadLine();  
        }



        Console.WriteLine("El jugador saco: "+totaljugador+" El dealer: "+totaldealer+" "+message);
        Console.WriteLine("Queres Seguir Jugando? deci seguir para seguir o salir para salir :) ");
        
       
        switchControl = Console.ReadLine().ToLower();



        
        if (switchControl == "salir") Environment.Exit(0);
        if (switchControl == "seguir") switchControl = "menu";
        break;

        default:
        Console.WriteLine("No estas re mal flaco");
        switchControl = "menu";
        break;
      }
    }    
}




