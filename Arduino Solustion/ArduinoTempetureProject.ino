/*
	������������ ������������� ����� ������������ ��� ��� �������� �������
	� ����� ������� ����� ��� ��� �� ������������ ��� �������� ���� ����
	����������� ��� ���������, ������ ���� ����������� ��� �������������
	��� ����.
	CopyLeft 2015 ;)

	��(1)
	�� IDE ���� ��������������� ��� �� �������� ��� ������ ���� �
	Visual Studio 2013 Ultimate �� ��� ����� Visual Micro Arduino 1.6,
	�� ���������e �� ��������e ��� ������ �� �� IDE ��� Arduino �� 
	������ �� �������e ��� �������� ��� �����������.
*/

#include <DallasTemperature/DallasTemperature.h> //������ �����������
#include <OneWire/OneWire.h> //������ �����������

#define ONE_WIRE_BUS 3 //��� �� �������� ��� ��� �� �������� �� data ��� ��� ��������� ���

OneWire oneWire(ONE_WIRE_BUS); //�������� �� ��������� ������������
DallasTemperature sensors(&oneWire); //�������� ��� ��������� ��� ���� ��� ���������� ���
DeviceAddress BoardThermometer; //�������� ��� ����� � ���������� ��� (�������� �����)

int ledGreen = 4; //�������� ��� ��������� ��� �� ������� Led ���� ���� 4
int ledRed = 5; //�������� ��� ��������� ��� �� ������� Led ���� ���� 5

void setup(void) //Setup
{
	Serial.begin(9600); //BitRate ��������
	Serial.print("Serial Bit Rate is 9600bps\n"); //�������� ��������� ��� ��� �������� ���
	Serial.print("Locating Devices\n"); //�������� ��������� ��� �� Scana����� ����������
	sensors.begin(); //������ ������������ ����������
	Serial.print("Found "); //�������� ��������� ��� �������� ����������
	Serial.print(sensors.getDeviceCount(), DEC); //�������� ���������� ��� �� ����� ��������
	Serial.print(" device.\n"); //�������� ����������

	if (sensors.isParasitePowerMode()) //������� ��� ��� ��������� ����������� ��� ��������� ���
	{
		Serial.print("Sensor Temperature Parasite Power Mode is ON\n"); //�������� ��� ���������� ��� ��� ��� ��� ��������� �����������
	}
	else
	{
		Serial.print("Sensor Temperature Parasite Power Mode is OFF\n"); //�������� ��� ���������� ��� ��� ��� ��� ��������� �����������
	}

	if (!sensors.getAddress(BoardThermometer, 0))
	{
		Serial.print("Unable to find address for Device 0\n"); //������� �� ��� ������� ������� ����������
	}

	Serial.print("Device 0 Address:\n"); //�������� ��������� ��� ��� ����� ���������
	printAddress(BoardThermometer); //�������� ��������� ��� ��� �������� ��� ���������
	sensors.setResolution(BoardThermometer, 8); //�������� �� bit ��� ��������� ��� (5 min~9 max)
	Serial.print("Device 0 Resolution: "); //�������� ��� ��� ������ ��������
	Serial.print(sensors.getResolution(BoardThermometer), DEC); //�������� ���������� ��� ��� ������ ��������

	pinMode(ledGreen, OUTPUT); //������ ����������� ��� �� ������� Led
	pinMode(ledRed, OUTPUT); //������ ����������� ��� �� ������� Led
}

void printTemperature(DeviceAddress deviceAddress) //�������� ������������ ��� ���� �������� ��������� ��� �������� ���� ����
{
	float TempC = sensors.getTempC(deviceAddress); //�������� ��� ��������� TempC ��� ������ ����������� ��� ���� �������� ��������� ��� �� ��������� �� Celsius
	int SerialRead = Serial.read() - '0'; //�������� ��� ��������� SerialRead ��� ��� ������� ������� ��� ����� ��� �� ������ �������� ��� ����������� ��� ��� Visual basic!
	String TempetureLevels = ""; //�������� ��� ��������� TempetureLevels ��� �� ��� �� ��������� ���� ���� ��������

	while (Serial.available() == 0) //��������� �� � �������� ����������� ����� �������
	{
		digitalWrite(ledGreen, LOW); //�������� ��� �������� led
		digitalWrite(ledRed, LOW); //�������� ��� �������� led
	}

	if (SerialRead == 1) //�� � Visual Basic ��� ������� 1 ���� :
	{
		for (int HighTempC = TempC; HighTempC > 30; HighTempC++) //��� ���� ����� ��� ������������ ��� �� ��������� �� 30 ��:
		{
			digitalWrite(ledGreen, LOW); //������� �� ������� led
			digitalWrite(ledRed, HIGH); //������ �� ������� led

			if (HighTempC >= 30) //������� �� � ������������ ��� ����� ����� ���� ��� ���� 30
			{
				TempetureLevels = "High"; //� ��������� ��� �� ����� ��� ����� High
			}
		}

		for (int LowTempC = TempC; LowTempC < 30; LowTempC++) //��� ���� ����� ��� ������������ ��� �� ����� ���� ��� 30 ��:
		{
			digitalWrite(ledGreen, HIGH); //������� �� ������� led
			digitalWrite(ledRed, LOW); //������ �� ������� led

			if (LowTempC <= 30) //������� �� � ����������� ����� ����� ���� ��� ���� 30
			{
				TempetureLevels = "Low"; //� ��������� ��� �� ����� ��� ����� Low
			}
		}

		Serial.print(TempetureLevels + " TempC:"); //�������� ��� ���������� ��� �� TempC:
		Serial.print(TempC); //�������� ��� ������ ��� ��� ��������� ���
		Serial.print("\n"); //������ �������
	}
	else
	{
		SerialRead = SerialRead; //� ��������� ��� �������� �� ����� ������ ���� ���� ��� �� ������� � Visual Basic!
	}
}


void printAddress(DeviceAddress deviceAddress) //�������� ��������� ��� ���� �������� ���������
{
	for (uint8_t i = 0; i < 8; i++) //��� ���� �������� ��������� ��� 0 ��� 8
	{

		if (deviceAddress[i] < 16)
		{
			Serial.print(0); //�������� ��� ������
			Serial.print(deviceAddress[i], HEX); //�������� ���������� ��� ���� ��������� �� �������� �����
		}
	}
}

void loop() //�����!
{
	sensors.requestTemperatures(); //� ���������� ������ �����������
	printTemperature(BoardThermometer); //�������� ������������ ��� ��� �������� ��������� BoardThermometer
}