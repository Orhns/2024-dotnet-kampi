


using intro.Business;
using intro.DataAccess.Concretes;
using intro.Entities;

string message1 = "Krediler";
int term = 12;
double amount = 100000;

bool isAuthenticated = true;
Console.WriteLine(message1);

if (isAuthenticated)
{
    Console.WriteLine("Button-->Hoşgeldin Orhun");
}
else
{
    Console.WriteLine("Button-->Sisteme giriş yap");
}

string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5" };
//string[] loans2 = new string[6];
//loans2[0] = "Kredi 1";

    //start    condition    increment
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

//Course course1 = new Course();
//course1.Id = 1;
//course1.Name = "C#";
//course1.Description = ".Net 8";
//course1.Price = 0;

//Course course2 = new Course();
//course2.Id = 2;
//course2.Name = "JAVA";
//course2.Description = "JAVA 17";
//course2.Price = 10;

//Course course3 = new Course();
//course3.Id = 3;
//course3.Name = "PYTHON";
//course3.Description = "Python 3.12";
//course3.Price = 0;

//Course[] courses = { course1, course2, course3 };

//for (int i = 0; i < courses.Length; i++)
//{
//    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
//}

CourseManager courseManager = new(new EfCourseDal());
List<Course> courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}


Console.WriteLine("Kod bitti");


IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678922";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "12345678922";
customer2.FirstName = "Ozgur";
customer2.LastName = "Calıskan";
customer2.CustomerNumber = "123457";

CoorporateCustomer customer3 = new CoorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "6554656";
customer3.TaxNumber = "1234567997975454";

CoorporateCustomer customer4 = new CoorporateCustomer();
customer4.Id = 4;
customer4.Name = "ABC";
customer4.CustomerNumber = "6554699";
customer4.TaxNumber = "123456799797878";

string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
string[] cities2 = { "Bursa", "Bolu", "Diyarbakır" };

cities2 = cities1;
cities1[0] = "Adana";

Console.WriteLine(cities2[2]);

BaseCustomer[] customers = {customer1, customer2, customer3, customer4};

foreach (BaseCustomer customer in customers)
{
   
    Console.WriteLine(customer.CustomerNumber);
}