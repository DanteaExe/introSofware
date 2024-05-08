#include <SFML/Graphics.hpp>

int main()
{
    sf::RenderWindow window(sf::VideoMode(600, 600), "Pollo");

    // Crear objetos
    sf::CircleShape HeadChicken(100.f);
    sf::CircleShape Eye1(15);
    sf::CircleShape Eye2(15);
    sf::ConvexShape triangle(3);

    // Dar colores
    HeadChicken.setFillColor(sf::Color::Yellow);
    Eye1.setFillColor(sf::Color::Blue);
    Eye2.setFillColor(sf::Color::Blue);
    triangle.setFillColor(sf::Color::Red);

    // Obtener tamaño de la ventana
    sf::Vector2u windowSize = window.getSize();

    // Calcular posición para centrar HeadChicken
    float xPos = (windowSize.x - HeadChicken.getRadius() * 2) / 2;
    float yPos = (windowSize.y - HeadChicken.getRadius() * 2) / 2;

    // Calcular posición para Eye1
    float xEyePos = xPos - Eye1.getRadius() * -3;
    float yEyePos = yPos - Eye1.getRadius() * -3;

    // Calcular posición para Eye2
    float xEye2Pos = xPos - Eye2.getRadius() * -8;
    float yEye2Pos = yPos - Eye2.getRadius() * -3;

    // Definir vértices del triángulo invertido
    float triangleWidth = 40.f;
    float triangleHeight = 30.f;
    triangle.setPoint(0, sf::Vector2f(xPos, yPos + 90)); // Vértice inferior
    triangle.setPoint(1, sf::Vector2f(xPos - triangleWidth / 2, yPos + 40)); // Vértice izquierdo
    triangle.setPoint(2, sf::Vector2f(xPos + triangleWidth / 2, yPos + 40)); // Vértice derecho

    // Posicionar objetos
    HeadChicken.setPosition(xPos, yPos);
    Eye1.setPosition(xEyePos, yEyePos);
    Eye2.setPosition(xEye2Pos, yEye2Pos);

    while (window.isOpen())
    {
        sf::Event event;
        while (window.pollEvent(event))
        {
            if (event.type == sf::Event::Closed)
                window.close();
        }

        window.clear();
        window.draw(HeadChicken);
        window.draw(Eye1);
        window.draw(Eye2);
        window.draw(triangle);
        window.display();
    }

    return 0;
}
