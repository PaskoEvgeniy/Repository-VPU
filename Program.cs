using System.Linq;


var zadaniya = new List<DomaZadaniya>()
{
new DomaZadaniya {ID_Student = 12345, ID_Prepod = 4321, Predmet = "Matematika", Opisaniya = "Rechit" ,Ocenka = 5},
new DomaZadaniya {ID_Student = 14345, ID_Prepod = 4321, Predmet = "Trudi", Opisaniya = "Zdelati" ,Ocenka = 8},
new DomaZadaniya {ID_Student = 12765, ID_Prepod = 4321, Predmet = "Mova", Opisaniya = "Napisat" ,Ocenka = 9},

};

foreach (var DomaZadaniya in zadaniya )
Console.WriteLine($"ID_Student: {DomaZadaniya.ID_Student}, ID_Prepod: {DomaZadaniya.ID_Prepod}, Predmet:{DomaZadaniya.Predmet}, Opisaniya: {DomaZadaniya.Opisaniya}");
















