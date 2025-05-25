#include <Wire.h> 
#include <LiquidCrystal_I2C.h>

// Set the LCD address to 0x27 or 0x3F according to your LCD module
LiquidCrystal_I2C lcd(0x27, 16, 2);

// Define the analog pin connected to the MQ-5 sensor
const int mq5Pin = A0;
const int buzzerPin = 13;
const int GreenLED = 8;
const int RedLED = 9;

void setup() {
  // Initialize the LCD
  lcd.init();
  lcd.backlight();
  lcd.setCursor(0, 0);

  Serial.begin(9600); 
  pinMode(buzzerPin, OUTPUT);
  pinMode(GreenLED, OUTPUT);
  pinMode(RedLED,OUTPUT);
  pinMode(7,OUTPUT);
}

void loop() {
  // Read the analog value from the MQ-5 sensor
  int sensorValue = analogRead(mq5Pin);
  
  // Convert the analog value to a gas concentration level (you may need to calibrate this value)
  float gasConcentration = map(sensorValue, 0, 1023, 0, 100); // Assuming 0-100% range, adjust according to your sensor's specifications
  Serial.print(sensorValue);
  Serial.print(",");
  Serial.println(gasConcentration);
  // Print the gas concentration level on the LCD
  lcd.setCursor(0, 0);
  lcd.print("Gas: ");
  lcd.print(gasConcentration);
  lcd.print("%       "); // Clear any remaining characters

  // Check if gas concentration is above 20%
  if (gasConcentration > 30.0) {

    digitalWrite(GreenLED,LOW);
    digitalWrite(RedLED,HIGH);
    // Turn on the buzzer
    //digitalWrite(buzzerPin, HIGH);
    tone(buzzerPin,1000);
    delay(2000);
    tone(buzzerPin,2000);
    delay(2000);
    digitalWrite(7, HIGH);
    // Update LCD display
    lcd.setCursor(0, 1);
    lcd.print("level: High!!");
  } else {
    // Turn off the buzzer
    digitalWrite(GreenLED,HIGH);
    digitalWrite(RedLED,LOW);
    //digitalWrite(buzzerPin, LOW);
    noTone(buzzerPin);
    digitalWrite(7, LOW);
    // Update LCD display
    lcd.setCursor(0, 1);
    lcd.print("level: Normal");
  }
  
  // Delay for stability
  delay(1000);
}
