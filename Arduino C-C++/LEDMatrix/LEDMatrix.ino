/*
VCC - Power 5V
GND - Power GND
DIN - PWM12
SC - PWM10
CLK - PWM11
*/

#include "LedControl.h"

LedControl lc=LedControl(12,11,10,1);

byte figure[8]={B00111100,B01000010,B10011001,B10110101,B10111101,B10011001,B01000010,B00111100};

void setup() {
  lc.shutdown(0,false);
  lc.setIntensity(0,8);
  lc.clearDisplay(0);
}
void loop() { 
  for (int i=0; i<8; i++){
    lc.setRow(0,i,figure[i]);
  }
  delay(20);
}  