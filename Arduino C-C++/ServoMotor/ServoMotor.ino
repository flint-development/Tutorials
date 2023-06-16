/*
Orange - PWM8
Red - Power 5V
Brown - Power GND
*/

#include <Servo.h>
Servo servo;

void setup() {
  servo.attach(8);
}

void loop() {
  servo.write(0);
  delay(3000);
  servo.write(90);
  delay(3000);
  servo.write(180);
  delay(3000);
  servo.write(20);
  delay(3000);
}
