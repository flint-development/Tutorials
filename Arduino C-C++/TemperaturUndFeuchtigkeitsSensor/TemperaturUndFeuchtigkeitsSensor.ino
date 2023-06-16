/*
Arduino MEGA2560:
  GND - Power GND
  10kOhm - XXX
  Signal - PWM2
  +5V - Power 5V
*/
#include "DHT.h"

#define DHTPIN 2     
#define DHTTYPE DHT22

DHT dht(DHTPIN, DHTTYPE);

void setup() {
  Serial.begin(9600);
  Serial.print("DHT22 example!\n");

  dht.begin();
}

void loop() {
  float temperature = dht.readTemperature();
  float humidity = dht.readHumidity();

  // Check if any reads failed and exit early (to try again).
  if (isnan(temperature) || isnan(humidity)) {
    Serial.print("Failed to read from DHT sensor!\n");
    return;
  }
  for(int i = 0; i <= 20; i++){
    Serial.println(" ");
  }
  Serial.print("Humidity: ");
  Serial.print(humidity);
  Serial.println("%");

  Serial.print("Temperature: ");
  Serial.print(temperature);
  Serial.println("°C");
  delay(500);
}