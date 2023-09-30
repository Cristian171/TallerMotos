# Examen #2
de la Materia Scriting De la Universidad Pontificia Bolivariana
# TallerMotos 
El examen consiste en un juego de carreras de motos que se centrará en la personalización de los componentes para mejorar los parámetros del vehículo Como:
- Muffler
- BackWheel
- FrontWheel
- Chassis

# Parametros a seguir
Cada moto Bike tiene una serie de componentes que se pueden personalizar:
FrontWheel - Llanta delantera.
BackWheel - Llanta trasera.
Chassis - Chasis
Engine - Motor
Muffler - Mofle
Las motos deben tener todas esas partes para poder ser usadas en una carrera.
Las motos tienen los siguientes parámetros:
Speed: Velocidad máxima de la moto
Acceleration: Factor de aceleración de la moto
Handling: Facilidad para maniobrar la moto.
Grip: Agarre del vehículo en superficies.
En ningún caso, una moto puede no tener chasis. Al tiempo, no puede existir ningún chasis fuera de una moto.
Los valores de cada parámetro estarán dados en una escala análoga de 0.0 a 10.0, donde 0.0 representa el menor valor y 10.0 el máximo.
En ningún caso, una moto completa puede tener ninguno de sus parámetros en 0.0.
Cuando una moto está completa, el valor inicial de todos sus parámetros es 1.0
En caso de faltar algún componente, se deben satisfacer las siguientes reglas:
Falta motor: Speed será 0.0
Falta cualquiera de las llantas: Acceleration será 0.0
Faltan ambas llantas: Handling será 0.0, Grip será 0.0
Falta mofle: Acceleration se divide a la mitad.
Las partes pueden modificar uno o más parámetros de la moto, pero se excluyen algunos según la parte - esto es, las partes no modifican parámetros según sigue:
El motor no modificará nunca Grip.
El mofle no modificará nunca Speed, Handling, Grip
El chasis no modifica ningún parámetro.
Las llantas pueden modificar todos los parámetros.
Los valores que agrega cada parte a cada parámetro no pueden ser superiores a 5.0, y, en total no puede agregar más de 10.0 puntos sumando todos los parámetros que modifique.
Durante la construcción de cada parte se debe garantizar que la regla anterior se satisfaga.
Una vez que la moto esté completa, al equipar una parte nueva, la parte nueva debe reemplazar a la anterior.
El total de cada parámetro será la suma del valor que cada parte agregue a dicho parámetro más el valor inicial por estar completa (ej. Speed = 1.0 + frontWheelSpeed + backWheelSpeed + engineSpeed).
Se le ha pedido implementar el entorno de pruebas unitarias para diversas funcionalidades del juego De momento, nos centraremos en las características de las motos.


# ID
- [Cristian Usuga](https://github.com/Cristian171)
- [Jhonier Mosquera](https://github.com/quertuy)
 
