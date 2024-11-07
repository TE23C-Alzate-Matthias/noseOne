string name;
string correctName = "kalleanka";
string answer;
int code;
int correctCode = 12345;
int i;

if (6 >= 3 ) {
    Console.WriteLine("Hello World!\n");
}

Console.WriteLine("Skriv in ditt användarnamn: ");

name = Console.ReadLine();

Console.WriteLine("Skriv in kod: ");

answer = Console.ReadLine();

int.TryParse(answer, out code);

if (name.ToLower() == correctName && code == correctCode) {
    Console.WriteLine("Välkommen!");
}
else {
    Console.WriteLine("Fel användarnamn eller kod\n");
}

for (i = 0; i < 32; i++) {
    Console.WriteLine("Hello World!");
}



Console.ReadLine();