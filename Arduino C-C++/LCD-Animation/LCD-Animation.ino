#include <LiquidCrystal_I2C.h>

LiquidCrystal_I2C lcd(0x27,16,2);

void setup()
{
  lcd.init();
  lcd.init();
  lcd.backlight();


  /* ----{ 000% }----
  for (int i = 0; i < 101; i++) {
    lcd.setCursor(0,1);
    lcd.print("----{ " + String(i) + "% }----");
    delay(200);
  }
  */
  for (int i = 0; i < 10; i++) {
    lcd.clear();
    lcd.setCursor(0,0);
    lcd.print("[***   ] " + String(i) + "%");
    delay(100);
    lcd.clear();
    lcd.print("[ ***  ] " + String(i) + "%");
    delay(100);
    lcd.clear();
    lcd.print("[  *** ] " + String(i) + "%");
    delay(100);
    lcd.clear();
    lcd.print("[   ***] " + String(i) + "%");
    delay(100);
    lcd.clear();
    lcd.print("[  *** ] " + String(i) + "%");
    delay(100);
    lcd.clear();
    lcd.print("[ ***  ] " + String(i) + "%");
    delay(100);
  }
}


void loop()
{
  delay(1500);
  lcd.clear();
  lcd.setCursor(0,0);
  lcd.print("Hello, world!");
  delay(1000);
}
