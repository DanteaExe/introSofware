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
                story.ThirdChoiceA();
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
        Clear();
        story.PathB1();
        story.SecondChoiceB();
        option = ReadLine();
        switch(option)
        {
            case "A":
            {
                Clear();
                story.CocinaComedor();
                story.ThirdChoiceAP2();
                option = ReadLine();
                switch(option)
                {
                    case "A":
                    {
                        Clear();
                        story.AvisarGrieta();
                    break;
                    }        
                    
                    case "B":
                    {
                        Clear();
                        story.PorTuCuenta();
                    break;
                    }
                    
                    case "C":
                    {
                        Clear();
                        story.IgnorarGrieta();
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
                story.SalaReuniones();
                story.ThirdChoiceBP2();
                option = ReadLine();
                switch(option)
                {
                    case "A":
                    {
                        Clear();
                        story.QudarteAtacar();
                    break;
                    }        
                    
                    case "B":
                    {
                        Clear();
                        story.Escapar();
                    break;
                    }
                    
                    case "C":
                    {
                        Clear();
                        story.AbrirPuerta();
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
                story.CuartoCamaras();
                story.ThirdChoiceCP2();
                option = ReadLine();
                switch(option)
                {
                    case "A":
                    {
                        Clear();
                        story.ApoyarEquipo();
                    break;
                    }        
                    
                    case "B":
                    {
                        Clear();
                        story.QudarteInvestigar();
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

    case "C":
    {
        Clear();
        story.PathC1();
        story.SecondChoiceC();
        option = ReadLine();
        switch(option)
        {
            case "A":
            {
                Clear();
                story.PasilloLuz();
                story.ThirdChoiceAP3();
                option = ReadLine();
                switch(option)
                {
                    case "A":
                    {
                        Clear();
                        story.DestruirInstalacion();
                        story.forthChoiceAP3();
                        option = ReadLine();
                        switch(option)
                        {
                            case "A":
                            {
                                Clear();
                                story.AvisarDestruccion();
                            break;
                            }        
                            
                            case "B":
                            {
                                Clear();
                                story.PresionarBoton();
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
                        story.abandonarInstalacion();
                    break;
                    }
                    
                    case "C":
                    {
                        Clear();
                        story.DiscutirIA();
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
                story.RegresarEquipo();
                story.ThirdChoiceBP3();
                option = ReadLine();
                switch(option)
                {
                    case "A":
                    {
                        Clear();
                        story.EsperarOrdenJefe();
                    break;
                    }        
                    
                    case "B":
                    {
                        Clear();
                        story.LanzarGranada();
                    break;
                    }
                    
                    case "C":
                    {
                        Clear();
                        story.Analizar();
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
                story.AvisarLuz();
                story.ThirdChoiceCP3();
                option = ReadLine();
                switch(option)
                {
                    case "A":
                    {
                        Clear();
                        story.EsperarIA();
                    break;
                    }        
                    
                    case "B":
                    {
                        Clear();
                        story.AvisarJefe();
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

    default:
        WriteLine("Esa no es una opcion, intente denuevo");
    break;
    }

