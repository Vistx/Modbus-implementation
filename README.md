# Modbus RTU implementation
Read more about the **Modbus RTU** [here](https://ozeki.hu/p_5854-modbus-rtu.html).

# Get things up and running

## Needed Tools

- ESP-Wroom-32 (or Arduino Uno)
- USB to Micro USB  cable


**Optional**

- Max 485 Module
- USB to RS-485 converter
- Max7219 LED matrix
- HCSR-04 Ultra Sonic Sensor

## Programming languages
- C# with Visual Studio 2019
-  C++ with Visual Studio Code  and PlatformIO extension installed [[**tutorial here**]](https://randomnerdtutorials.com/vs-code-platformio-ide-esp32-esp8266-arduino/) 

## Libraries 
- NModbus4 from NuGet ( [**tutorial** ](https://www.youtube.com/watch?v=ohaz_sPLp4Y)) in C# WinForms
- Modbus Master Slave for Arduino [**github repo**](https://github.com/smarmengol/Modbus-Master-Slave-for-Arduino) [**(setup in VScode tutorial)**](https://www.youtube.com/watch?v=EBlHNBNHESQ)
- **Example 1** uses  [this](https://github.com/MajicDesigns/MD_MAX72XX) library with Platform  IO for max7219 module
- **Example 2** uses  [this](https://github.com/gamegine/HCSR04-ultrasonic-sensor-lib) library with Platform  IO for HCSR 04 module


##  Hardware Setup Method #1 
Connect your USB to USB micro With the Esp32 and plug in to one of your PC Ports  (done). Simple yet limited by the USB cable length.

##  Hardware Setup Method #2 
> Important Note:  **Upload the code** before   **connecting the      RX0 and TX0 pins**

Connect  the max 485 module to the ESP 32 like so :
- Bridge the **RE** and **DE** connections in the breadboard

- Connect that bridge to the **GPIO Pin 4**  of the ESP32

- **RX0** (ESP32  ) --> **R0** (Max485 Module)

- **TX0**  (ESP32 ) -->  **DI**  (Max485 Module)

- Connect **A** and **B** pins from the **Max485** module to the 
**A**(D+) and **B**(D-) of the USB to RS485 module
  
![Connection1](https://github.com/Vistx/Modbus-implementation/assets/123487221/49164148-40c9-432c-93fd-67ecf91ee66f)





## Software Setup 

- **Open Project :**  Modbus-implementation / Simple_Example /[Simple Modbus Slave Esp32](https://github.com/Vistx/Modbus-implementation/tree/main/Simple_Example/Simple%20Modbus%20Slave%20Esp32)  **With PlatformIO**

![Open project](https://github.com/Vistx/Modbus-implementation/assets/123487221/4c54aed1-d1e6-4610-91e6-3c2a24059353)


- **Upload the code to your ESP32**

![Upload to ESP32](https://github.com/Vistx/Modbus-implementation/assets/123487221/a6d447b1-fde5-4d70-a42d-aa768d30496c)

- **Open GUI:** Modbus-implementation / Simple_Example /
[SimpleFunctionGui](https://github.com/Vistx/Modbus-implementation/tree/main/Simple_Example/SimpleFunctionGui) with **Visual Studio 2019**
   
![VS GUI](https://github.com/Vistx/Modbus-implementation/assets/123487221/5d0fecc4-8345-4c1b-8732-4036c656d786)

- **Connect** and do **Read and Write Holding Registers** operations

![Gui in action](https://github.com/Vistx/Modbus-implementation/assets/123487221/041a78f2-7641-451b-b8db-684827c5f5fd)


# Code Explanation and Important Details 
`On the ESP32 side of the code, the serial begin baudrate must match  the selected baudrate  in the GUI application. `

`Also, the slave ID in the ESP32  must match the ID of the called function in C# .  `

![Untitled1](https://github.com/Vistx/Modbus-implementation/assets/123487221/4d8b92f5-e57a-4f2f-a696-cc858aa7fa39)

 `Technically, you can connect over 240 slave devices on the same serial connection, all you have to do is change the slave ID for each one and call the specific device by that unique ID from the GUI.`

# Example 1

**Wiring**

![Example 1 Pinoutres](https://github.com/Vistx/Modbus-implementation/assets/123487221/5b3c8281-07c9-421c-b0d4-0dc0064464ef)


**Module-->ESP32**

- Vcc --> +5v
- Gnd --> GND
- DIN --> GPIO 23
- CS --> GPIO 5
- CLK --> GPIO 18


## Details <br />
Each of the numbers in the Modbus rtu message represents the bit position of the matrix but expressed in decimal form. {[source](https://randomnerdtutorials.com/guide-for-8x8-dot-matrix-max7219-with-arduino-pong-game/)}

How are the bit values placed?
Take a look at Column 0 and Rows from 0 to 7. The first 2 LED-s are OFF thus 00 , next 4 LED-s are ON so 1111, and lastly 2 LEDs are OFF thus 00

img here

So the entire message is **00111100** in binary, or **60** in decimal form, which in terms represents our first RTU message, audata16[0]=60 next  Column 0 is **01000010** in binary, or **66** in decimal form and so on .


# Example 2
 [Timers](https://www.youtube.com/watch?v=98c200lL-OY) from Winforms are used to request a register from a slave device (ESP32 in our case), we can see the **update interval** in which these registers are requested from the slave device, and the response is used to update the user interface.    


 
 As stated earlier it's not recommended to use the delay function when using the Modbus slave library so instead we used millis()([how to](https://circuitdigest.com/microcontroller-projects/arduino-multitasking-using-millis-in-arduino#:~:text=To%20use%20the%20millis%28%29,unsigned%20long%20currentMillis%20=%20millis%28%29;)) , to update Modbus registers and the HCSR 04 readings.

 img here

