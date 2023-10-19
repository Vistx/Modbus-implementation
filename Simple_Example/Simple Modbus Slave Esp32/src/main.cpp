#include <Arduino.h>
#include <ModbusRtu.h>
#define TXEN  4 //DEFINE TRANSMIT ENABLE PIN

Modbus slave(1,Serial,TXEN); //(Slave,Hardware serial,Transmit enable pin)



uint16_t au16data[16] = {0, 0,0, 0, 0, 0,0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; //16 REGISTERS FROM 0 TO 15

void setup() {
Serial.begin( 115200 ); //BAUDRATE 
slave.start(); 

}

void loop() {
  

    slave.poll( au16data, 16 ); //REGISTER QUERRY
    //!!!!DO NOT USE DELAY FUNCTION ,IT CAUSES ERRORS WHEN THE MASTER DEVICE REQUESTS AN REGISTER
    //!!!ALSO DO NOT USE SERIAL PRINT OR OPEN SERIAL MONITOR WHILE YOU ARE RUNNING THE DEVICE IN SLAVE MODE

}