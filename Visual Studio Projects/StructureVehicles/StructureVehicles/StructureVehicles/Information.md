#Information

For at få lav kobling skal vores metoder og klasser være 
uafghængige af hinanden, og ved ændringer i metoder og klasser, påvirke andet kode så lidt som muligt.

 


Samhørighed er når klasser og interfaces er håndterbare, forståelige samt skaber sammenhæng imellem ansvar, data og metoder.
Vi vil gerne have høj samhørighed da det gør det nemmere for os at forstå, genbruge og vedligeholde samt ændre kode.


V2

Høj samhørighed betyder at f.eks. en klasse kun har at gøre med en enkel ting, f.eks. bil og ikke bil samt højhus. 
Høj kobling betyder f.eks. en klasse har brug for viden om hvordan en anden klasse er og en ændring i den anden klasse kan påvirke den første klasse. 
Så at forstå den første klasse skal man også forstå den anden klasse.

 


Så jeg lige havde skrevet at lav kobling betyder at en klasse kan blive påvirket af en anden klasse, jeg mente en høj kobling.
Lav kobling betyder at den første klasse ikke burde blive påvirket af ændringer i den anden klasse



1(Lav Kobling). Vores "Program" er vores lave kobling, da hvad end vi ændre deri vil det ikke ændre andre klasser.

2(Høj Kobling. Vi har høj kobling mellem, vehicle og underklasserne (Bus, Truck og PersonalCar) da, hvis der bliver ændret noget i enten eller af dem, ændres det begge steder.

3(Høj Samhørighed). Vores Vehicle klasse samt "IBuyer" og "ISeller" interfaces, er høj samhørighed, da de skaber sammenhængen mellem f.eks. Users, og Bus, Truck, PassengerCar.
