#include <Arduino.h>
#include <MD_Parola.h>
#include <MD_MAX72xx.h>
#include <SPI.h>
#include <ModbusRtu.h>
#define TXEN  4
#define HARDWARE_TYPE MD_MAX72XX::GENERIC_HW
#define MAX_DEVICES 1 // 1 block
#define CLK_PIN   18 // or SCK
#define DATA_PIN  19 // or MOSI
#define CS_PIN    5 // or SS

Modbus slave(1,Serial,TXEN); //Slave ID 1
uint16_t au16data[16] = {129,0,0,24,24,0,0,129, 0, 0, 0, 0, 0, 0, 0, 0 };
// create an instance of the MD_Parola class
MD_MAX72XX  ledMatrix = MD_MAX72XX(HARDWARE_TYPE, DATA_PIN, CLK_PIN, CS_PIN, MAX_DEVICES);

void setup() {
  ledMatrix.begin();
  ledMatrix.control(MD_MAX72XX::INTENSITY, 15);
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