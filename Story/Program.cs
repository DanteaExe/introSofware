using System.Runtime.CompilerServices;
using static System.Console;

WriteLine("Antes de empezar: coloca A,B,C. dependiendo del camino que desea seguir.");

string? option;
TextStory story = new();

WriteLine("De enter para continuar");
WriteLine("Diviertete :D");
ReadLine();

Clear();

story.Tittle();
story.Introduction();

story.FirstChoice();
option = ReadLine();

switch(option)
{
    case "A":
    {
        Clear();
        story.PathA1();
        story.SecondChoiceA();
        option = ReadLine();
        switch(option)
        {
            case "A":
            {
                Clear();
                story.Armería();
                story.thirdCoiceA();
                option = ReadLine();
                switch(option)
                {
                    case "A":
                    {
                        Clear();
                        story.AcercarseDialogar();
                    break;
                    }        
                    
                    case "B":
                    {
                        Clear();
                        story.EpserarJefe();
                    break;
                    }
                    
                    case "C":
                    {
                        Clear();
                        story.ExplorarArmería();
                    break;
                    }
                    
                    default:
                        WriteLine("Esa no es una opcion, intente denuevo");
                    break;
                }
            break;
            }

            case "B":
            {
                Clear();
                story.Enfermería();
                story.ThirdChoiceB();
                option = ReadLine();

                switch(option)
                {
                    case "A":
                    {
                        Clear();
                        story.DispararCompañero();
                    break;
                    }        
                        
                    case "B":
                    {
                        Clear();
                        story.PedirAyuda();
                    break;
                    }
                        
                    case "C":
                    {
                        Clear();
                        story.EncerrarCompañero();
                    break;
                    }
                        
                    default:
                        WriteLine("Esa no es una opcion, intente denuevo");
                    break;
                    }
            break;
            }
            case "C":
            {
                Clear();
                story.DefenderNave();
                story.ThirdChoiceC();
                option = ReadLine();
                switch(option)
                {
                    case "A":
                    {
                        Clear();
                        story.AvisarCapitan();
                    break;
                    }        
                    
                    case "B":
                    {
                        Clear();
                        story.IgnorarLoVisto();
                    break;
                    }
                    
                    case "C":
                    {
                        Clear();
                        story.PisarCbeza();
                    break;
                    }
                    
                    default:
                        WriteLine("Esa no es una opcion, intente denuevo");
                    break;
                }
            break;
            }
            
            default:
                WriteLine("Esa no es una opcion, intente denuevo");
            break;
        }
    break;
    }

    case "B":
    {
    
    break;
    }

    case "C":
    {

    break;
    }

    default:
        WriteLine("Esa no es una opcion, intente denuevo");
    break;
    }

