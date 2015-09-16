/*
	Κωνσταντινος Γκοτζαμανιδης Τμημα Ηλεκτρονικης στο Τει Στεραιας Ελλαδας
	Ο παρον κωδικας ειναι ενα απο τα παραδειγματα που δινονται μεσα στις
	Βιβλιοθηκες του αισθητηρα, παρολο αυτα μελετηθηκαν και τροποποιθηκαν
	απο μενα.
	CopyLeft 2015 ;)

	ΥΓ(1)
	Το IDE οπου χρησημοποιηθεκε για το ανεβασμα του κωδικα ηταν η
	Visual Studio 2013 Ultimate με την χρηση Visual Micro Arduino 1.6,
	αν δοκιμασετe να ανεβασετe τον κωδικα με το IDE του Arduino θα 
	πρεπει να αλλαξετe την διαδρομη των βιβλιοθηκων.
*/

#include <DallasTemperature/DallasTemperature.h> //Δηλωση βιβλιοθηκων
#include <OneWire/OneWire.h> //Δηλωση βιβλιοθηκων

#define ONE_WIRE_BUS 3 //Απο δω οριζουμε απο που θα περνουμε τα data απο τον αισθητηρα μας

OneWire oneWire(ONE_WIRE_BUS); //Οριζουμε το προτοκολο επικοινωνιας
DallasTemperature sensors(&oneWire); //Οριζουμε τον αισθητηρα μας βαση του προτοκολου μας
DeviceAddress BoardThermometer; //Οριζουμε που ειναι ο αισθητηρας μας (Εικονικο Ονομα)

int ledGreen = 4; //Οριζουμε μια μεταβλητη για το Πρασινο Led στην θυρα 4
int ledRed = 5; //Οριζουμε μια μεταβλητη για το Κοκκινο Led στην θυρα 5

void setup(void) //Setup
{
	Serial.begin(9600); //BitRate Συνδεσης
	Serial.print("Serial Bit Rate is 9600bps\n"); //Εμφανιση μηνυματος για την ταχυτητα μας
	Serial.print("Locating Devices\n"); //Εμφανιση μηνυματος για το Scanaρισμα αισθητηρων
	sensors.begin(); //Εναρξη λειτουργειας αισθητηρων
	Serial.print("Found "); //Εμφανιση μηνυματος οτι βρηθηκαν αισθητηρες
	Serial.print(sensors.getDeviceCount(), DEC); //Εμφανιση πορισματος για το ποσοι βρεθηκαν
	Serial.print(" device.\n"); //Εμφανιση καταληξεις

	if (sensors.isParasitePowerMode()) //Ελεγχος για επι προσθετες λειτουργιες του αισθητηρα μας
	{
		Serial.print("Sensor Temperature Parasite Power Mode is ON\n"); //Εμφανιση της καταστασης του για της επι προσθετες λειτουργεις
	}
	else
	{
		Serial.print("Sensor Temperature Parasite Power Mode is OFF\n"); //Εμφανιση της καταστασης του για της επι προσθετες λειτουργεις
	}

	if (!sensors.getAddress(BoardThermometer, 0))
	{
		Serial.print("Unable to find address for Device 0\n"); //Ελεγχος αν δεν βρεθουν καθολου αισθητηρες
	}

	Serial.print("Device 0 Address:\n"); //Εμφανιση μηνυματος για τον Πρωτο αισθητηρα
	printAddress(BoardThermometer); //Εμφανιση διεθνυσης για τον εικονικο μας αισθητηρα
	sensors.setResolution(BoardThermometer, 8); //Οριζουμε τα bit του αισθητηρα μας (5 min~9 max)
	Serial.print("Device 0 Resolution: "); //Εμφανιση για την αρχηκη διεθνυση
	Serial.print(sensors.getResolution(BoardThermometer), DEC); //Εμφανιση πορισματος για την αρχηκη διεθνυση

	pinMode(ledGreen, OUTPUT); //Εναρξη καταστασεις για το Πρασινο Led
	pinMode(ledRed, OUTPUT); //Εναρξη καταστασεις για το Κοκκινο Led
}

void printTemperature(DeviceAddress deviceAddress) //Εμφανιση Θερμοκρασιας για καθε εικονικο αισθητιρα που δηλωσαμε στην αρχη
{
	float TempC = sensors.getTempC(deviceAddress); //Οριζουμε σαν μεταβλητη TempC την τρεχων θερμοκρασια για καθε εικονικο αισθητηρα που θα ζητησουμε σε Celsius
	int SerialRead = Serial.read() - '0'; //Οριζουμε σαν μεταβλητη SerialRead και την βαζουμε αναλογη του μηδεν για να ζηταμε αργοτερα την θερμοκρασια απο την Visual basic!
	String TempetureLevels = ""; //Οριζουμε σαν μεταβλητη TempetureLevels για να μας το εμφανιζει μετα στην εκτυπωση

	while (Serial.available() == 0) //Ελεγχουμε αν η σειριακη επικοινωνια ειναι ανοιχτη
	{
		digitalWrite(ledGreen, LOW); //Κλεισιμο του πρασινου led
		digitalWrite(ledRed, LOW); //Κλεισιμο του κοκκινου led
	}

	if (SerialRead == 1) //Αν η Visual Basic μας στειλει 1 τοτε :
	{
		for (int HighTempC = TempC; HighTempC > 30; HighTempC++) //Για καθε τιμες της θερμοκρασιας που θα ξεπερνανε το 30 θα:
		{
			digitalWrite(ledGreen, LOW); //Κλεινει το πρασινο led
			digitalWrite(ledRed, HIGH); //Αναβει το κοκκινο led

			if (HighTempC >= 30) //Ελεγχος αν η θερμοκρασιας μας ειναι ακομα πανω απο τους 30
			{
				TempetureLevels = "High"; //Η μεταβλητη μας θα παρει την φραση High
			}
		}

		for (int LowTempC = TempC; LowTempC < 30; LowTempC++) //Για καθε τιμες της Θερμοκρασιας που θα ειναι κατω απο 30 θα:
		{
			digitalWrite(ledGreen, HIGH); //Κλεινει το κοκκινο led
			digitalWrite(ledRed, LOW); //Αναβει το πρασινο led

			if (LowTempC <= 30) //Ελεγχος αν η θερμοκρασια ειναι ακομα κατω απο τους 30
			{
				TempetureLevels = "Low"; //Η μεταβλητη μας θα παρει την φραση Low
			}
		}

		Serial.print(TempetureLevels + " TempC:"); //Εμφανιση της μεταβλητης συν το TempC:
		Serial.print(TempC); //Εμφανιση των βαθμων απο τον αισθητηρα μας
		Serial.print("\n"); //Αλλαγη γραμμης
	}
	else
	{
		SerialRead = SerialRead; //Η μεταβλητη που δηλωσαμε θα παρει καποια αλλη τιμη που θα στειλει η Visual Basic!
	}
}


void printAddress(DeviceAddress deviceAddress) //Εμφανιση διεθνυσης για καθε εικονικο αισθητηρα
{
	for (uint8_t i = 0; i < 8; i++) //Για καθε εικονικο αισθητηρα απο 0 εως 8
	{

		if (deviceAddress[i] < 16)
		{
			Serial.print(0); //Εμφανιση του πρωτου
			Serial.print(deviceAddress[i], HEX); //Εμφανιση διεθνυσεις για καθε αισθητηρα σε μηχανικη μορφη
		}
	}
}

void loop() //Λουπα!
{
	sensors.requestTemperatures(); //Ο αισθητηρας ζηταει θερμοκρασια
	printTemperature(BoardThermometer); //Εμφανιση Θερμοκρασιας για τον Εικονικο Αισθητηρα BoardThermometer
}