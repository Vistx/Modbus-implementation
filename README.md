# Modbus RTU implementation
Read more about the **Modbus RTU** [here](https://ozeki.hu/p_5854-modbus-rtu.html).

# 🏃 Get things up and running

## 🔧 Needed Tools

- ESP-Wroom-32 (or Arduino Uno)
- USB to Micro USB  cable


😏**Optional**

- Max 485 Module
- USB to RS-485 converter
- Max7219 LED matrix
- HCSR-04 Ultra Sonic Sensor

## 👨‍💻 Programming languages
- C# with Visual Studio 2019
-  C++ with Visual Studio Code  and PlatformIO extension installed [[**tutorial here**]](https://randomnerdtutorials.com/vs-code-platformio-ide-esp32-esp8266-arduino/) 

## 📖 Libraries used in this project 
- NModbus4 from NuGet ( [**tutorial** ](https://www.youtube.com/watch?v=ohaz_sPLp4Y)) in C# WinForms
- Modbus Master Slave for Arduino [**github repo**](https://github.com/smarmengol/Modbus-Master-Slave-for-Arduino) [**(setup in VScode tutorial)**](https://www.youtube.com/watch?v=EBlHNBNHESQ)
- **Example 1** uses  [this](https://github.com/MajicDesigns/MD_MAX72XX) library with Platform  IO for max7219 module
- **Example 2** uses  [this](https://github.com/gamegine/HCSR04-ultrasonic-sensor-lib) library with Platform  IO for HCSR 04 module


## ⚙️ Hardware Setup Method #1 
Connect your USB to USB micro With the Esp32 and plug in to one of your PC Ports  (done). Simple yet limited by the USB cable length.

## ⚙️ Hardware Setup Method #2 
> Important Note:  **Upload the code** before   **connecting the      RX0 and TX0 pins**

Connect  the max 485 module to the ESP 32 like so :
- Bridge the **RE** and **DE** connections in the breadboard

- Connect that bridge to the **GPIO Pin 4**  of the ESP32

- **RX0** (ESP32  ) --> **R0** (Max485 Module)

- **TX0**  (ESP32 ) -->  **DI**  (Max485 Module)

- Connect **A** and **B** pins from the **Max485** module to the 
**A**(D+) and **B**(D-) of the USB to RS485 module
  
![1](https://github.com/Vistx/Modbus-implementation/assets/123487221/85f57011-20ac-40f1-90e6-9c032bfc66f0)




## 🧑‍💻 Software Setup 

- **Open Project :**  Modbus-implementation / Simple_Example /[Simple Modbus Slave Esp32](https://github.com/Vistx/Modbus-implementation/tree/main/Simple_Example/Simple%20Modbus%20Slave%20Esp32)  **With PlatformIO**

![2](https://github.com/Vistx/Modbus-implementation/assets/123487221/56377312-3af0-402e-8b53-d0bbd5b95c5d)


- **Upload the code to your ESP32**

![3](https://github.com/Vistx/Modbus-implementation/assets/123487221/7b472964-d032-4bdb-a2b1-38461929dccf)

- **Open GUI:** Modbus-implementation / Simple_Example /
  
![4](https://github.com/Vistx/Modbus-implementation/assets/123487221/e38ac4a1-360c-4e29-ade4-a37a06e3633d)
   


- **Connect** and do **Read and Write Holding Registers** operations
  
![5](https://github.com/Vistx/Modbus-implementation/assets/123487221/86fbf0ba-6f60-4993-ac28-219f110f89db)



# 👨‍🏫 Code Explanation and Important Details 
`On the ESP32 side of the code, the serial begin baudrate must match  the selected baudrate  in the GUI application. Also the COMport must not be in use by other software `

`Also, the slave ID in the ESP32  must match the ID of the called function in C# .  `

![6](https://github.com/Vistx/Modbus-implementation/assets/123487221/98ac7a25-4b0f-4e4b-9faf-67f876d6d29c)


 `Technically, you can connect over 240 slave devices on the same serial connection, all you have to do is change the slave ID for each one and call the specific device by that unique ID from the GUI.`






# Example 1

## 🔌 Wiring

![7](https://github.com/Vistx/Modbus-implementation/assets/123487221/2d882bd6-441d-4bcc-bee1-c2590ac118e1)



**Module-->ESP32**

- Vcc --> +5v
- Gnd --> GND
- DIN --> GPIO 23
- CS --> GPIO 5
- CLK --> GPIO 18


## 🔎 Details
Each of the numbers in the Modbus RTU message represents the bit position of the matrix but expressed in decimal form.

![8](https://github.com/Vistx/Modbus-implementation/assets/123487221/9350f605-493b-4b5a-8a62-1cbd16fb396b)

{[img source](https://randomnerdtutorials.com/guide-for-8x8-dot-matrix-max7219-with-arduino-pong-game/)}



**How are the bit values placed?** <br />
Take a look at Column 0 and Rows from 0 to 7. The first 2 LED-s are OFF thus 00 , next 4 LED-s are ON so 1111, and lastly 2 LEDs are OFF thus 00.
So the entire message is **00111100** in binary, or **60** in decimal form, which in terms represents our first RTU message, audata16[0]=60 next  Column 0 is **01000010** in binary, or **66** in decimal form and so on .

Upload the code from **Example1/ESP32 Code With VScode/** to the ESP32


## 💻 Gui 

- Open the programm located here:  **Example1/GUI Led matrix/WindowsFormsApp1/**  with Visual studio 2019 </br>
- or directly : **Example1/GUI Led matrix/WindowsFormsApp1//bin/Debug/WindowsFormsApp1.exe**
- Connect with your settings tuch the interactive LEDs  and **Send(Message)**

![9](https://github.com/Vistx/Modbus-implementation/assets/123487221/1703cf07-0235-4f30-8785-c20a3554e83b)



# Example 2

## 🔌 Wiring

![10](https://github.com/Vistx/Modbus-implementation/assets/123487221/37496fca-ecdc-4b10-b0d4-5d3340fc3271)


- Vcc --> +5v
- Gnd --> GND
- Trig --> GPIO 5
- Echo --> GPIO 18

## 🔎 Details 
 [Timers](https://www.youtube.com/watch?v=98c200lL-OY) from Winforms are used to request a register from a slave device (ESP32 in our case), we can see the **update interval** in which these registers are requested from the slave device, and the response is used to update the user interface.    

As stated earlier it's not recommended to use the delay function when using the Modbus slave library so instead we used millis()([how to](https://circuitdigest.com/microcontroller-projects/arduino-multitasking-using-millis-in-arduino#:~:text=To%20use%20the%20millis%28%29,unsigned%20long%20currentMillis%20=%20millis%28%29;)) , to update Modbus registers and the HCSR 04 readings.

![11](https://github.com/Vistx/Modbus-implementation/assets/123487221/3a42715a-2cd2-4c78-97a7-437a953c600c)


Upload the code from **Example2/Modbus Rtu With Hc-sr04** to the ESP32

## 💻 GUI
- Open the programm located here:  **Example2/HCSR04DisplayReadings**  with Visual studio 2019 </br>
- or directly : **Example2/HCSR04DisplayReadings/bin/Debug/HCSR04DisplayReadings.exe**
- Connect with your settings and dont forget to set the request interval the unit is miliseconds

![12](https://github.com/Vistx/Modbus-implementation/assets/123487221/8d2276f6-0aa4-427a-aea6-e064755be413)

# Multiple ESP-32 Slave devices

![13](https://github.com/Vistx/Modbus-implementation/assets/123487221/3cbc9467-56b8-4d83-b0ab-49f0ec257e42)

- To call the firts (ID 1) device change the parameters to the the shown function
  
![1 l](https://github.com/Vistx/Modbus-implementation/assets/123487221/f2ddfe25-a26b-4910-b4b7-9075b40c612a)

- To call the second (ID 2) device change the parameters to the the shown function

![2 l](https://github.com/Vistx/Modbus-implementation/assets/123487221/dd2da17c-2064-43bf-9051-7651f57f635a)

- To call the third (ID 3) device change the parameters to the the shown function

![3 l](https://github.com/Vistx/Modbus-implementation/assets/123487221/941e9ce2-39ac-49dd-8aa3-85235522f8e6)





