using System.Runtime.CompilerServices;
using static System.Console;

public class TextStory
{
    public void Tittle()
    {
        WriteLine("Realmente solos?");
    }
    public void Introduction()
    {
        WriteLine("Estás en una nave que se dirige hacia Marte. Fuiste asignado a una misión de exploración y reconocimiento, ya que una de las estaciones importantes no ha mandado señales ni reportes a las otras bases. Despiertas a media hora de aterrizar en el planeta rojo, y observas a algunos de tus compañeros dormir, otros están en otras partes de la nave.");
    }

    public void FirstChoice()
    {
        WriteLine("A.-Esperar en el dormitorio");
        WriteLine("B.- Ir a la cabina");
        WriteLine("C.- Ir al comedor");
    }

    // Path A
    public void PathA1()
    {
        WriteLine("Descansas un rato más, abres la cortina y te toca la vista hacia Marte, empiezas a extrañar la tierra y te sientes fuera de lugar, pero aun así sigues observando durante un buen rato, cuando empieza a sonar un mensaje de uno de tus compañeros, diciendo que en unos minutos aterrizarán y deben ponerse los cinturones de seguridad.Después de casi más de una hora descienden al planeta y llegan a la estación, tuvieron que forzar las puertas y los puentes para poder entrar, llegan al hangar, todos listos con su equipo y sus herramientas de exploración. El hangar está solo, no hay un solo ruido y está todo oscuro, cuando prenden las luces de las armas se encuentran los cuerpos de las personas de la estación, están descuartizados y hay un mar de sangre. No huele ya que todos tienen los trajes para oxígeno, pero pueden imaginarse el olor, algunas personas empiezan a vomitar dentro del casco. Se reúnen entre los 5 equipos que fueron mandados, tu jefe te da la libertad de elegir a donde dirigirse primero.");
    }

    public void SecondChoiceA()
    {
        WriteLine("A.- Ir a la armería");
        WriteLine("B.- Ir a la enfermería");
        WriteLine("C.- Qudarse a vigilar la nave en el hangar");
    }

    // segundo A.- ir a la armería
    public void Armería()
    {
        WriteLine("Tú equipo y tú van hacia la armería, tu jefe va adelante y vas detrás el, le preguntas que pudo haber sido el causante de todo esto, pero no se le ocurre algo, tal vez algo así como un parásito o algo similar. Mientras se dirigen a la armería ven muy poco, pues las instalaciones están sin luz, pero las linternas son de mucha ayuda. Algunos cuartos por los que pasan están vacíos y otros llenos de sangre, otros de plano cerrados. Llegan a la armería y fuerzan la puerta para abrirla, cuando alguien empieza a disparar desde dentro y a gritar cosas, pero no se alcanza a apreciar lo que dice. Le gritan entre disparos que pare, que no le harán daño, ve las luces y ve que son humanos y empieza a llorar desesperadamente.");
    }

    public void thirdCoiceA()
    {
        WriteLine("A.- Acercarse y tratar de dialogar con el sobreviviente");
        WriteLine("B.- Esperar a órdenes del jefe");
        WriteLine("C.- Explorar la armería");
    }

    //A.- dialogar con soberviviente
    public void AcercarseDialogar()
    {
        WriteLine("Te acercar lentamente al sobreviviente, pero este decide atacarte con un chuchillo que tenía guardado y te asesina :( )");
    }

    //B.- Esperar ordenes del jefe
    public void EpserarJefe()
    {
        WriteLine("Te quedas viendo como el soldado llora, y el jefe ordena a dos de tu compañero que le disparen un tranquilizante, este se duerme y lo amarran con sogas para que no haga movimientos bruscos. Continuará");
    }

    //C.- Explorar armería
    public void ExplorarArmería()
    {
        WriteLine("Lentamente tus compañeros y tu entran a la armería a explorar, 3 de tus compañeros se acercan al soldado llorando y uno de tus compañeros le dispara, pues este estaba a punto de atacarles. El jefe solo se queda mirando y les dice que sigan explorando. Continuará");
    }
    // segundo B.- Ir a la enfermería
    public void Enfermería()
    {
        WriteLine("Tú equipo y tú van a la enfermería, los pasillos para llegar allá están llenos de sangre y de cuerpos destripados. Todos están alertas de cualquier cosa que pueda suceder o de algún superviviente que puedan encontrar.  Llegas a la enfermería y se ven las camas por cualquier lado, unas volteadas y otras con cuerpos. En el lugar se ven señales que hubo peleas contra las cosas raras que mataron al personal. Todos deciden explorar, alumbrando a todos lados y haciendo lo posible para no perder la compostura. Uno de los soldados se acerca a una habitación para explorar dentro, cuando fue atacado por una de esas cosas raras, empezó a gritar de dolor y a disparar dentro de toda la habitación. Tú siendo el más cerca de distancia, corres para averiguar qué es lo que puedes hacer. ");
    }

    public void ThirdChoiceB()
    {
        WriteLine("A.- Disparar al compañero junto al ¿zombi?");
        WriteLine("B.- Pedir ayuda a tus compañeros");
        WriteLine("C.- Encerrar al compañero en la habitación");
    }

    //A.- disparar al compañero
    public void DispararCompañero()
    {
        WriteLine("Cuando reaccionas que lo atacan, empiezas a dispararle a lo que era tu compañero y la cosa rara. Lo acabas y ves como tus demás compañeros también están siendo atacados. Decides ir a apoyar a tu equipo y solo sobrevivir. Continuará");
    }

    //B.- pedir ayuda a compañero
    public void PedirAyuda()
    {
        WriteLine("Dos de tus compañeros corren donde estás, y le disparan al compañero, pero es tarde, ya había sido consumido y los ataca a los 3, te muerde a ti y también empiezas a atacar, pero compañeros atrás, lanza una granada y terminas muerto.");
    }

    //C.- Encerrar compañero
    public void EncerrarCompañero()
    {
        WriteLine("Reaccionas rápido y cierras la puerta donde esta el compañero. Tu corazón se acelera pues empieza a golpear fuerte la puerta para intentar salir. Tú te alejas y sigues apuntando a la puerta por si logra romperla. Continuará");
    }

    //segundo C.- Qudarse a vigilar la nave en el hangar
    public void DefenderNave()
    {
        WriteLine("Tú equipo y tú se quedan a vigilar la nave, patrullan alrededor de la nave y están atentos a cualquier movimiento extraño que pueda haber. Algunos platican por la radio, hablando sobre que esto es imposible, que como una cosa así puede existir. Están preocupados pues no saben si pueden pasar a las otras bases por lo que, desde la nave, deciden advertir a las otras bases, pero puede durar el tiempo de envío de la señal. Mueres de la curiosidad y te acercas a uno de los cuerpos, está todo destrozado y sangrado, pero te percatas de algo, en la parte de la cabeza, observas que el parasito es donde se mete para controlar a los humanos.");
    }

    public void ThirdChoiceC()
    {
        WriteLine("A.- Avisar al capitán del equipo");
        WriteLine("B.- ignorar lo que viste y seguir vigilando");
        WriteLine("C.- Pisar la cabeza y buscar otro cuerpo");
    }

    //A.- Avisar capi del equipo
    public void AvisarCapitan()
    {
        WriteLine("El capitán se acerca y le comentas tu teoría sobre como estos monstruos pueden controlar humanos de forma en que entran a la cabeza, el jefe se queda pensando y te dice que investigues los demás cuerpos. Continuará");
    }

    //B.- ignorar lo que vite
    public void IgnorarLoVisto()
    {
        WriteLine("Ignoras el cuerpo y sigues vigilando la nave, cuando uno de tus compañeros grita por la radio que se acercan de esos monstruos, todos deciden defender y tú no eres la excepción. Continuará");
    }

    //C.- pisar cabeza
    public void PisarCbeza()
    {
        WriteLine("Pisas la cabeza del cuerpo y buscas otro, observas como también hay una de esas cosas dentro del cuerpo y empiezas a preocuparte. Continuará");
    }
    //Path B

    //Path C
}
