/*
Button:
  VCC - Power 3,3V
  GND - Power GND
  I/O - PWM 7
LED:
  VCC - PWM 6
  GND - Power GND
*/

void setup() {
  pinMode(7, INPUT);
  pinMode(6, OUTPUT);
}

void loop() {
  if(digitalRead(7))
  {
    analogWrite(6, 40);
  }
  else
  {
    analogWrite(6, 0);
  }
}
