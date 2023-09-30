# Examen NO 2
De la Materia Scriting De la Universidad Pontificia Bolivariana.

# TallerMotos 
El examen consiste en un juego de carreras de motos que se centrará en la personalización de los componentes para mejorar los parámetros del vehículo Como:

- FrontWheel: Llanta delantera.
- BackWheel: Llanta trasera.
- Chassis: Chasis.
- Engine: Motor.
- Muffler: Mofle.

Las motos deben tener todas estas partes para poder ser usadas en una carrera.

## Parámetros de las Motos

Las motos deben tener los siguientes parámetros:

- Speed: Velocidad máxima de la moto.
- Acceleration: Factor de aceleración de la moto.
- Handling: Facilidad para maniobrar la moto.
- Grip: Agarre del vehículo en superficies.

Cada parámetro se encuentra en una escala de 0.0 a 10.0, donde 0.0 representa el valor mínimo y 10.0 el valor máximo.

## Reglas para la Completitud de las Motos

- En ningún caso, una moto puede no tener chasis.
- No puede existir ningún chasis fuera de una moto.
- Los valores iniciales de los parámetros de una moto completa son 1.0.
- En caso de faltar algún componente, se aplican las siguientes reglas:
  - Falta motor: Speed será 0.0.
  - Falta cualquiera de las llantas: Acceleration será 0.0.
  - Faltan ambas llantas: Handling será 0.0, Grip será 0.0.
  - Falta mofle: Acceleration se divide a la mitad.

## Modificaciones de Parámetros por Partes

- Las partes pueden modificar uno o más parámetros de la moto, excluyendo algunos según la parte.
- El motor nunca modificará Grip.
- El mofle nunca modificará Speed, Handling, o Grip.
- El chasis no modifica ningún parámetro.
- Las llantas pueden modificar todos los parámetros.
- Los valores que agrega cada parte a cada parámetro no pueden ser superiores a 5.0.
- El total de modificaciones por parte no puede superar 10.0 puntos, sumando todos los parámetros modificados.

## Equipamiento de Partes

- Una vez que la moto esté completa, al equipar una parte nueva, la parte nueva debe reemplazar a la anterior.
- El total de cada parámetro será la suma del valor que cada parte agregue a dicho parámetro más el valor inicial por estar completa (ej. Speed = 1.0 + frontWheelSpeed + backWheelSpeed + engineSpeed).


# ID
- [Cristian Usuga 000467982](https://github.com/Cristian171)
- [Jhonier Mosquera](https://github.com/quertuy)
 
