#include <Arduino.h>
#include <MD_Parola.h>
#include <MD_MAX72xx.h>
#include <SPI.h>
#include <ModbusRtu.h>
#define TXEN  4
#define HARDWARE_TYPE MD_MAX72XX::GENERIC_HW
#define MAX_DEVICES 1 // 1 block
#define CS_PIN 21
int delay_time_interval=1000;
Modbus slave(1,Serial,TXEN); //Slave ID-ja 1
uint16_t au16data[16] = {0, 0,0, 0, 0, 0,0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
// create an instance of the MD_Parola class
MD_MAX72XX  ledMatrix = MD_MAX72XX(HARDWARE_TYPE, CS_PIN, MAX_DEVICES);

void setup() {
  ledMatrix.begin();
  ledMatrix.control(MD_MAX72XX::INTENSITY, 8);
  ledMatrix.clear();
  Serial.begin( 115200 ); 
slave.start();
}

void loop() {
    slave.poll( au16data, 16 );
    for (size_t i = 0; i < 8; i++)
    {
        ledMatrix.setRow(0, 0, i, au16data[i]);
    }
    


}