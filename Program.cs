Console.WriteLine("Enter your age in years to find out your age on Earth: ");
int ageOfPerson = int.Parse(Console.ReadLine());

int i = 86400; // 24 * 60 * 60 // hours in one day * minutes in one hour * seconds in one minute
double EarthDaysInOneYear = 365.25;
double EarthYearInSec = EarthDaysInOneYear * i;
double ageOfPersonInSec = ageOfPerson * EarthDaysInOneYear * i;
double ageOfPersonInDays = ageOfPerson * EarthDaysInOneYear;

double[] OrbitalPeriods = new double[7] { 0.2408467, 0.61519726, 1.8808158, 11.862615, 29.447498, 84.016846, 164.79132};
// 0 - Mercury | 1 - Venera | 2 - Mars | 3 - Jupiter | 4 - Saturn | 5 - Uranus | 6 - Neptune



void Earth()
{
    Console.WriteLine($"\t\t\t\t\t\tEarth Details\nOne year on Earth in Earth Days: {EarthDaysInOneYear}\nOne year on Earth in Earth Seconds: {EarthYearInSec}\nAge on Earth In Earth years: {ageOfPerson}\nAge on Earth in Earth Seconds: {ageOfPersonInSec}");
}
Earth();


Console.WriteLine("Enter your age in years to find out your age on Mercury: ");
ageOfPerson = int.Parse(Console.ReadLine());
void Mercury()
{

    double MercuryDays = OrbitalPeriods[0] * EarthDaysInOneYear; // Convert from Mercury Orbital Period to Earth Days
    double MercurySeconds = MercuryDays * i; // Convert to Earth Seconds

    double ageOfPerson_Mercury = ageOfPersonInDays / MercuryDays; // Age of person on Earth considering Mercury Orbital Period
    double ageOfPerson_Mecury_InSeconds = ageOfPerson_Mercury * MercuryDays * i; // Age of person on Earth cosidering Mercury Orbital Period

    Console.WriteLine($"\t\t\t\t\t\tMercury Details\nOne year on Mercury in Earth Days: {MercuryDays}\nOne year on Mercury in Earth Seconds: {MercurySeconds}\nAge on Mercury in Earth years: {ageOfPerson_Mercury}\nAge on Mercury in Earth seconds: {ageOfPerson_Mecury_InSeconds}");

}
Mercury();

Console.WriteLine("Enter your age in years to find out your age on Venus: ");
ageOfPerson = int.Parse(Console.ReadLine());
void Venus()

{
    double VenusDays = OrbitalPeriods[1] * EarthDaysInOneYear; // Convert from Venus Orbital Period to Earth Days
    double VenusSeconds = VenusDays * i; // Convert to Earth Seconds

    double ageOfPerson_Venus = ageOfPersonInDays / VenusDays; // Age of person on Earth considering Venus Orbital Period
    double ageOfPerson_Venus_InSeconds = ageOfPerson_Venus * VenusDays * i; // Age of person on Earth considering Venus Orbital Period

    Console.WriteLine($"\t\t\t\t\t\tVenus Details\nOne year on Venus in Earth Days: {VenusDays}\nOne year on Venus in Earth Seconds: {VenusSeconds}\nAge on Venus in Earth years: {ageOfPerson_Venus}\nAge on Mercury in Earth seconds: {ageOfPerson_Venus_InSeconds}");

}
Venus();

Console.WriteLine("Enter your age in years to find out your age on Mars: ");
ageOfPerson = int.Parse(Console.ReadLine());
void Mars()
{

    double MarsDays = OrbitalPeriods[2] * EarthDaysInOneYear; // Convert from Mars Orbital Period to Earth Days
    double MarsSeconds = MarsDays * i; // Convert to Earth Seconds

    double ageOfPerson_Mars = ageOfPersonInDays / MarsDays;
    double ageOfPerson_Mars_InSeconds = ageOfPerson_Mars * MarsDays * i; // Age of person on Earth considering Mars Orbital Period

    Console.WriteLine($"\t\t\t\t\t\tMars Details\nOne year on Mars in Earth Days: {MarsDays}\nOne year on Mars in Earth Seconds: {MarsSeconds}\nAge on Mars in Earth years: {ageOfPerson_Mars}\nAge on Mars in Earth seconds: {ageOfPerson_Mars_InSeconds}");

}
Mars();

Console.WriteLine("Enter your age in years to find out your age on Jupiter: ");
ageOfPerson = int.Parse(Console.ReadLine());
void Jupiter()
{
    double JupiterDays = OrbitalPeriods[3] * EarthDaysInOneYear; // Convert from Jupiter Orbital Period to Earth Days
    double JupiterSeconds = JupiterDays * i; // Convert to Earth Seconds

    double ageOfPerson_Jupiter = ageOfPersonInDays / JupiterDays;
    double ageOfPerson_Jupiter_InSeconds = ageOfPerson_Jupiter * JupiterDays * i; // Age of person on Earth considering Mars Orbital Period

    Console.WriteLine($"\t\t\t\t\t\tJupiter Details\nOne year on Jupiter in Earth Days: {JupiterDays}\nOne year on Jupiter in Earth Seconds: {JupiterSeconds}\nAge on Jupiter in Earth years: {ageOfPerson_Jupiter}\nAge on Jupiter in Earth seconds: {ageOfPerson_Jupiter_InSeconds}");

}
Jupiter();

Console.WriteLine("Enter your age in years to find out your age on Saturn: ");
ageOfPerson = int.Parse(Console.ReadLine());
void Saturn()
{
    double SaturnDays = OrbitalPeriods[4] * EarthDaysInOneYear; // Convert from Saturn Orbital Period to Earth Days
    double SaturnSeconds = SaturnDays * i; // Convert to Earth Seconds

    double ageOfPerson_Saturn = ageOfPersonInDays / SaturnDays;
    double ageOfPerson_Saturn_InSeconds = ageOfPerson_Saturn * SaturnDays * i; // Age of person on Earth cosidering Saturn Orbital Period

    Console.WriteLine($"\t\t\t\t\t\tSaturn Details\nOne year on Saturn in Earth Days: {SaturnDays}\nOne year on Saturn in Earth Seconds: {SaturnSeconds}\nAge on Jupiter in Earth years: {ageOfPerson_Saturn}\nAge on Jupiter in Earth seconds: {ageOfPerson_Saturn_InSeconds}");

}
Saturn();

Console.WriteLine("Enter your age in years to find out your age on Uranus: ");
ageOfPerson = int.Parse(Console.ReadLine());
void Uranus()
{
    double UranusDays = OrbitalPeriods[5] * EarthDaysInOneYear; // Convert from Uranus Orbital Period to Earth Days
    double UranusSeconds = UranusDays * i; // Convert to Earth Seconds

    double ageOfPerson_Uranus = ageOfPersonInDays / UranusDays;
    double ageOfPerson_Uranus_InSeconds = ageOfPerson_Uranus * i; // Age of person on Earth cosidering Uranus Orbital Period

    Console.WriteLine($"\t\t\t\t\t\tUranus Details\nOne year on Saturn in Earth Days: {UranusDays}\nOne year on Uranus in Earth Seconds: {UranusSeconds}\nAge on Uranus in Earth years: {ageOfPerson_Uranus}\nAge on Uranus in Earth seconds: {ageOfPerson_Uranus_InSeconds}");


}
Uranus();

Console.WriteLine("Enter your age in years to find out your age on Neptune: ");
ageOfPerson = int.Parse(Console.ReadLine());
void Neptune()
{
    double NeptuneDays = OrbitalPeriods[6] * EarthDaysInOneYear; // Convert from Neptune Orbital Period to Earth Days
    double NeptuneSeconds = NeptuneDays * i; // Convert to Earth Seconds
    
    double ageOfPerson_Neptune = ageOfPersonInDays / NeptuneDays;
    double ageOfPerson_Neptune_InSeconds = ageOfPerson_Neptune * i; // Age of person on Earth considering Neptune Orbital Period

    Console.WriteLine($"\t\t\t\t\t\tNeptune Details\nOne year on Neptune in Earth Days: {NeptuneDays}\nOne year on Neptune in Earth Seconds: {NeptuneSeconds}\nAge on Neptune in Earth years: {ageOfPerson_Neptune}\nAge on Neptune in Earth seconds: {ageOfPerson_Neptune_InSeconds}");

}
Neptune();