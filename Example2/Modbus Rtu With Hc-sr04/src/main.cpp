#include <Arduino.h>
#include <ModbusRtu.h>
#include <HCSR04.h>
#define TXEN  4


int delay_time_interval=60;
unsigned long previousMillis = 0;
Modbus slave(1,Serial,TXEN); //Slave ID-ja 1
HCSR04 hc(5,18); // (trig,echo)


uint16_t au16data[16] = {0, 0,0, 0, 0, 0,0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

void setup() {
Serial.begin( 115200 ); 
slave.start();
}

void loop() {
    slave.poll( au16data, 16 );
unsigned long currentMillis = millis();

  if (currentMillis - previousMillis >= delay_time_interval) { //don't use delay functions with Modbus Rtu Update the readings using millis()
    previousMillis = currentMillis; 
    
    au16data[0]=hc.dist();

    }
    
   
    


}