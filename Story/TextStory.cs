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

    public void ThirdChoiceA()
    {
        WriteLine("A.- Acercarse y tratar de dialogar con el sobreviviente");
        WriteLine("B.- Esperar a órdenes del jefe");
        WriteLine("C.- Explorar la armería");
    }

    //tercero A.- dialogar con soberviviente
    public void AcercarseDialogar()
    {
        WriteLine("Te acercar lentamente al sobreviviente, pero este decide atacarte con un chuchillo que tenía guardado y te asesina :( )");
    }

    //tercero B.- Esperar ordenes del jefe
    public void EpserarJefe()
    {
        WriteLine("Te quedas viendo como el soldado llora, y el jefe ordena a dos de tu compañero que le disparen un tranquilizante, este se duerme y lo amarran con sogas para que no haga movimientos bruscos. Continuará");
    }

    //tercero C.- Explorar armería
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

    //tercero A.- disparar al compañero
    public void DispararCompañero()
    {
        WriteLine("Cuando reaccionas que lo atacan, empiezas a dispararle a lo que era tu compañero y la cosa rara. Lo acabas y ves como tus demás compañeros también están siendo atacados. Decides ir a apoyar a tu equipo y solo sobrevivir. Continuará");
    }

    //tercero B.- pedir ayuda a compañero
    public void PedirAyuda()
    {
        WriteLine("Dos de tus compañeros corren donde estás, y le disparan al compañero, pero es tarde, ya había sido consumido y los ataca a los 3, te muerde a ti y también empiezas a atacar, pero compañeros atrás, lanza una granada y terminas muerto.");
    }

    //tercero C.- Encerrar compañero
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
    public void PathB1()
    {
        WriteLine("Te levantas de la cama y flotas hacia la cabina, ves a 4 de tus compañeros descansando pues están a unos minutos de aterrizar, ves la ventana de enfrente y se puede apreciar el planeta rojo, es grande y te sorprendes. Te quedas platicando unos minutos y dan el aviso de que se abrochen los cinturones para poder aterrizar, sales de la sala de cabina a buscar el cinturón más cercano para colocártelo.Después de una hora descienden a la estación, tus compañeros y tú se preparan con los trajes y armas. Llegan al puente para llegar al hangar, cuando se abre la puerta una cosa pequeña y rara ataca al compañero y otro le dispara varias veces, matando al compañero y a la cosa rara, cuando la ven de cerca parece una araña café con muchos dientes, unos gritan y otro compañero la aplasta. El jefe de la operación que estaba atrás arreglando unas cosas, observa lo acontecido, pero ordena seguir y separarse. Le pregunta al jefe de tu escuadrón a donde decide ir");
    }

    public void SecondChoiceB()
    {
        WriteLine("A.- Cocina y comedor");
        WriteLine("B.- Sala de reuniones");
        WriteLine("C.- Cuarto de cámaras");
    }

    //segundo A.- cocina y comedor
    public void CocinaComedor()
    {
        WriteLine("Se dirigen hacia la cocina, los pasillos son una escena horrible de terror, todos están alerta de que otra de esas cosas no vuelva a aparecer, pero están seguros que hay muchos más de esos. Llegan a la cocina y comedor, es inmenso, ya que solo hay uno para toda la base. Todos entran con cautela y tratan de iluminar lo más posible. Parece que hubo una masacre y nadie sobrevivió. Ven en el suelo que hay más de esos monstruos dientudos por el suelo. El jefe dice que de alguna u otra forma deben saber cómo es que pasó esto. Se adentran aún más en la cocina y comedor, cuando te das cuenta que en uno de los costados, la pared está rota completamente y llena de algo que parece ser lo mismo que esos zombis o lo que sean están hechos.");
    }

    //third choice A, path B
    public void ThirdChoiceAP2()
    {
        WriteLine("A.- Avisar a tu equipo sobre la grieta en la pared");
        WriteLine("B.- Entrar por tu cuenta");
        WriteLine("C.- Ignorar la grieta y seguir explorando la cocina y comedor");
    }

    //tercero A.- Avisar a tu equipo sobre la grieta en la pared
    public void AvisarGrieta()
    {
        WriteLine("Avisas a tu equipo sobre la grieta y el jefe ordena separarse, para que la mitad siga explorando la cocina y otro entre a la grieta. Continuará");
    }

    //tercero B.- entrar por tu cuenta
    public void PorTuCuenta()
    {
        WriteLine("Decides entrar por tu cuenta sin avisar a nadie, observas como está lleno de lo que parece ser el material de lo que están hechos esas cosas raras que viste antes. Continuará");
    }

    //tercero C.- ignorar grieta y bla bla bla
    public void IgnorarGrieta()
    {
        WriteLine("Patrullas por la cocina y comedor, parece que hubo un inmenso ataque y nadie sobrevivió. Continuará ");
    }

    //segundo B.- Sala de reuniones 
    public void SalaReuniones()
    {
        WriteLine("La sala de reuniones era el lugar más lejano, pero aun así deciden ir. Los pasillos parecen una escena de terror, la oscuridad de estos mismos y la sangre hacía que todos quisieran regresar, pero la única forma de averiguar qué pasó era explorando. Después de una larga caminata logran llegar a la sal de reuniones, pero la sala estaba cerrada, alguien trató de abrirla, pero era imposible. De repente, del techo caen varios de los ¿zombi? Con muchos dientes, y empiezan a atacar.");
    }

    //third choice B, path B
    public void ThirdChoiceBP2()
    {
        WriteLine("A.- Qudarte y atacar");
        WriteLine("B.- Escapar");
        WriteLine("C.- Tratar de abrir otra puerta");
    }

    //tercero A.- quedarte y atacar
    public void QudarteAtacar()
    {
        WriteLine("Te quedas a atacar, pero es imposible, son demediados y terminas siendo mordido por uno y termina asesinándote, convirtiéndote en uno de ellos y atacando a tus compañeros. ");
    }

    //tercero B.- escapara
    public void Escapar()
    {
        WriteLine("Decides escapar a la nave de regreso, y te encierras, escuchas como los otros equipos también están siendo atacados. Avisas por la radio que en 5 minutos encendras la nave y escaparás de ahí, solo pocos llegan y logran salvarse y escapar de la instalación.");
    }

    //tercero C.- tratar de abrir puerta
    public void AbrirPuerta()
    {
        WriteLine("Mientras atacan, abres una puerta que abre a un pasillo, avisas a tus compañeros restantes y corres con ellos, mientras que los zombis los sigues. Continuará.");
    }

    //segundo C.- cuarto de cámaras
    public void CuartoCamaras()
    {
        WriteLine("Llegan al cuarto de cámaras, fuerzan la puerta para poder entrar, dentro no hay nadie. Pero el cuarto está intacto, no hay nadie, las teles por alguna razón muestran imagen, más sin embargo es curioso, ya que no hay electricidad en toda la base. El jefe te ordena que inspecciones y trates de retroceder el video para que de esa forma puedan ver si averiguan que fue lo que pasó. Decides atrasar el video por 3 días. Hace tres días parece que todo estaba bien. Adelantas un día y justo le atinas al momento donde empieza el ataque, no se alcanza a escuchar nada, pero todos en el grupo pueden imaginarse los gritos de desesperación. Ven todos como poco a poco son asesinados por los zombis o lo que sea que sean esas cosas. La masacre dura 15 minutos y se puede apreciar un gran silencio en el grupo, por la radio, se escucha a otro capitán que necesitan ayuda, pues han encontrado lo que creen que es el nido de estos monstruos, el capitán ordena que la mitad de grupo vaya y la otra se quede. ");
    }

    //third choice path c
    public void ThirdChoiceCP2()
    {
        WriteLine("A.- Ir a apoyar al otro equipo");
        WriteLine("B.- Quedarte y seguir investigando");
    }

    //tercero A.- ir a apoyar al otro equipo
    public void ApoyarEquipo()
    {
        WriteLine("Decides ir a apoyar, el nido es grande y hay muchas de esas cosas, siguen disparando cuando varios de tus compañeros agarran lanzallamas, lo que parece funcionar y tratan de quemar el nido juntos con los miles de esas cosas. Continuará");
    }

    //tercero B.- quedarte a investigar
    public void QudarteInvestigar()
    {
        WriteLine("Decides seguir explorando las cámaras y observas la masacre que pasó hace dos días, luego ves como todo se queda sin luz y solo quedan los cuerpos y algunos de esos zombis patrullando. Continuará");
    }
    //Path C
    public void PathC1()
    {
        WriteLine("Te levantas de la cama y flotas hacia el comedor, ves a la mayoría de tus compañeros ahí, algunos comiendo otros jugando cartas, te acercas con los que juegan cartas y empiezas a jugar con ellos. Empiezan a hablar sobre las posibles razones por las que la estación dejó de mandar señales, unos dicen que probablemente perdieron electricidad, otros que pudo haber pasado un accidente y pudo haber explotado, etc. pero se ven muy tranquilos. Empiezas a preocuparte, ya que muchos tienen familias y probablemente los hayan perdido todo. Después de un rato de juego, suena un mensaje de la cabina, avisando que pronto aterrizarán y deben colocarse los cinturones. Las sillas del comedor tienen incorporadas cinturonespor lo que no debes moverte. Después de casi una hora descienden a la estación con los trajes y las armas. Llegan al hangar y empiezan a explorar, está todo lleno de sangre y hay muchos cuerpos descuartizados. Mientras veías eso, una puerta se abre y una luz se ve al fondo del pasillo.");
    }

    public void SecondChoiceC()
    {
        WriteLine("A.- Ir a por el pasillo solo y seguir esa luz");
        WriteLine("B.- Regresar con el equipo");
        WriteLine("C.- Avisar a tu equipo de la luz y solicitar ir con ellos");
    }

    //Segundo A.- ir por el pasillo
    public void PasilloLuz()
    {
        WriteLine("Decides seguir la luz por tu cuenta, a medida que te acercas a la luz, esta se aleja. Perece que te está guiando a algún lugar. Llegan a lo que parece un salón de reuniones, y la luz, aparece en la mesa en forma de una mujer, parece ser una IA o algo así. Preguntas que es lo que ella hace aquí, y que pasó con la base. Ella te mira de forma triste. Y empieza a contarse lo que pasó. Te cuenta que esta base, fue creada por encima de una de las grandes colmenas de los seres que viven aquí, los humanos solo vinimos a invadirlos y es por eso que ellos atacaron. Dice que ella fue creada por los humanos para ayudar, pero ella ya les había advertido sobre el terreno y nadie la escuchó. Dijo que solo hay dos cosas que se pueden hacer para acabar con esto, pero ninguna termina bien para nadie, te explica que esto es culpa de los humanos, y ahora tú debes solucionar lo que ellos hicieron. Dice que no seas como los otros humanos y la escuches, que si quieres llegar una solución, ella sabe qué hacer y te de la opción de decidir que hacer ");
    }

    public void ThirdChoiceAP3()
    {
        WriteLine("A.- Auto destruir la instalación");
        WriteLine("B.- Decir a su tripulación que deben abandonar la instalación");
        WriteLine("C.- Discutir con la IA ");
    }

    //tercero A.- destruir instalación
    public void DestruirInstalacion()
    {
        WriteLine("La IA te dirige al cuarto de control donde estaba muy protegido, pero ella te guía por donde es seguro. Llegas al cuarto donde se maneja todo lo de la base. Y te presenta el botón de destrucción dice que ella y solo ella sabe cuál es la contraseña.");
    }

    public void forthChoiceAP3()
    {
        WriteLine("A.- Avisar a todos que destruirás la base");
        WriteLine("B.- presionar el botón");
    }

    //cuarto A.- avisar destruccion
    public void AvisarDestruccion()
    {
        WriteLine("Avisas a la radio que darás 10 minutos para que todos regresen a la nave y se salven, pues piensas destruir la base y no necesitas órdenes para hacer eso, pues es algo que ayudará a todos.  Tu jefe dice que serás recordado. Pasan 7 minutos y el jefe te dice que ya han salido de la base y están a salvo, cierras los ojos los minutos que quedan y la IA. Te dice que hiciste lo correcto. Es entonces cuando la base estalla y destruye la colmena de monstruos y todo lo que estaba ahí.");
    }

    //Cuarto B.- jaja valieron madres
    public void PresionarBoton()
    {
        WriteLine("Sin pensar mucho, activas el botón y destruye todo lo que estaba ahí, incluyendo a tus compañeros y los zombis dentro, dejando solo escombros de la base, claro que nadie sobrevivió. ");
    }

    //tercero B.- abandonar instalación
    public void abandonarInstalacion()
    {
        WriteLine("Avisas a todos que deben abandonar la base, pero tu jefe dice que estás loco, que vinieron aquí con una misión, te ordena que regreses. Continuará");
    }

    //tercero c.- discutir con la IA
    public void DiscutirIA()
    {
        WriteLine("Discutes con la IA sobre porque no pudo avisar antes que esto había pasado, que como es posible que haya ocurrido todo esto, ella empieza a molestarse y sigue discutiendo contigo. Continuará");
    }

    //segundo B.- regresar con el equipo
    public void RegresarEquipo()
    {
        WriteLine("Decides ignorar la luz y regresas con el equipo, tu mente empieza a divagar sobre lo que pudo haber pasado. Los equipos se separan y tu líder decide ir al sótano. Mientras se dirigen allá, notan como cada vez las paredes empiezan a ser más… de las materias de los ¿zombi? Pareciera que ellos vinieron de ahí. Cuando bajan, observan como lo que está ahí, parece un pulmón o una colmena, donde muchos de esos zombis aparecen, sus grandes dientes afilados y llenos de sangre hacen dar a entender que fueron los que hicieron la masacre. ");
    }

    public void ThirdChoiceBP3()
    {
        WriteLine("A.- Esperar ordenes del jefe");
        WriteLine("B.- Lanzar una granada de la manera menos impulsiva");
        WriteLine("C.- Analizar y tratar de razonar lo que ha pasado");
    }

    //tercero A.- esperar al jefe
    public void EsperarOrdenJefe()
    {
        WriteLine("El jefe ordena que se coloquen en fila y empiecen a abrir fuego. Continuará");
    }

    //Tercero B.- LanzarGranada
    public void LanzarGranada()
    {
        WriteLine("Lanzas una granada y la colmena empieza a acercarse a atacarlos, son muchos y no pueden contra todos, por lo que terminan muriendo.");
    }

    //tercero C.- Analizar
    public void Analizar()
    {
        WriteLine("Llegas a la conclusión que los humanos invadieron esta colmena y ellos solo se están defendiendo de los invasores, desdices contarle al jefe tu conclusión. Continuará");
    }

    //Segundo C.- Avisar a tu equipo de la luz y solicitar ir con ellos
    public void AvisarLuz()
    {
        WriteLine("Te quedas en la puerta y le hablas a tus compañeros por la radio, les comentas lo que viste, tu jefe le dice a 5 de tus compañeros que te acompañen, e informen de cualquier cosa que vean. Tú y tú equipo se adentran por los pasillos siguiendo la luz. Los guía a lo que parece ser un bunker dentro de la instalación. Al llegar, se presenta como la IA que ayuda a los humanos de la base, dice que hablará con los pocos supervivientes dentro del bunker para que vean que han sido salvados.");
    }

    public void ThirdChoiceCP3()
    {
        WriteLine("A.- Esperar a respuesta de la IA");
        WriteLine("B.- Avisar al jefe lo que vieron");
    }

    //tercero A.- esperar IA
    public void EsperarIA()
    {
        WriteLine("La IA abre el bunker y salen 11 sobrevivientes, ustedes los guían a la nave pasar escapar de ahí, pues ellos dicen que no hay nada que se pueda hacer para salvar la base. Mientras regresan a la base, ellos cuentan lo que pasó y que están agradecidos que hayan llegado a salvarlos. Llegan a la nave y salen del planeta rojo, mientras que en la nave empiezan a hacer entrevistas sobre todo lo que pasó. FIN");
    }

    //tercero C.- avisar jefe lo visto
    public void AvisarJefe()
    {
        WriteLine("El jefe les ordena que les disparen, pues no son de fiar, pero dudas de lo que dice. Las personas salen del bunker y todos les disparan menos tu. Continuará ");
    }

}