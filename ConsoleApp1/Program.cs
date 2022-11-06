


using System.Text.RegularExpressions;

//string number = "+994-55-555-55-55";
//Regex regex = new Regex(@"^\+994\-[0-9]{2}\-[0-9]{3}\-[0-9]{2}\-[0-9]{2}");
//Match regexMatch = regex.Match(number);
//Console.WriteLine(regexMatch.Success);



//string name = "Ali";
//string surname = "Akbarov";
//Regex regex = new Regex(@"^[A-Z]{1}[a-z]{1,15}$");
//Match regexMatch = regex.Match(name);
//Console.WriteLine(regexMatch.Success);

//Regex regexx = new Regex(@"^[A-Z]{1}[a-z]{1,15}$");
//Match regexxMatch = regexx.Match(surname);
//Console.WriteLine(regexxMatch.Success);



object Users = new object[0];
string username;
string name;
string surname;
string age;
string email;
string password;
string phonenumber;

Console.WriteLine("Operation daxil edin.");
Console.WriteLine("1.Register");
int operation = Convert.ToInt32(Console.ReadLine());
//----------------------------------------------------------------------------------------------------------------------
if (operation == 1)
{
    Console.WriteLine("\nAd daxil edin.");
tryName:
    name = Console.ReadLine();
    Regex regexName = new Regex(@"^[A-Z]{1}[a-z]{1,13}$");
    Match regexNameMatch = regexName.Match(name);
    if (regexNameMatch.Success == true)
    {
        Console.WriteLine("Ad daxiletme ugurludur!");
    }
    else
    {
        Console.WriteLine("Duzgun ad daxil edin.(Simvol sayi 15den az olmalidir ve ilk herf boyuk yazilmalidir!");
        goto tryName;
    }
    //----------------------------------------------------------------------------------------------------------------------
    Console.WriteLine("\nSoyad daxil edin.");
trySurname:
    surname = Console.ReadLine();
    Regex regexSurname = new Regex(@"^[A-Z]{1}[a-z]{1,13}$");
    Match regexSurnameMatch = regexSurname.Match(surname);
    if (regexSurnameMatch.Success == true)
    {
        Console.WriteLine("Soyad daxiletme ugurludur!");
    }
    else
    {
        Console.WriteLine("Duzgun soyad daxil edin.(Simvol sayi 15den az olmalidir ve ilk herf boyuk yazilmalidir!");
        goto trySurname;
    }
    //----------------------------------------------------------------------------------------------------------------------
    Console.WriteLine("\nIstifadeci adi daxil edin.");
tryUsername:
    username = Console.ReadLine();
    Regex regexUsername = new Regex(@"^[A-Z]{1}\w{7}");
    Match regexUsernameMatch = regexUsername.Match(username);
    if (regexUsernameMatch.Success == true)
    {
        Console.WriteLine("Istifadeci adi daxiletme ugurludur!");
    }
    else
    {
        Console.WriteLine("Duzgun istifadeci adi daxil edin.(Istifadeci adinda bosluq ola bilmez!)");
        goto tryUsername;
    }
    //----------------------------------------------------------------------------------------------------------------------
    Console.WriteLine("\nYasinizi daxil edin.");
tryAge:
    age = Console.ReadLine();
    Regex regexAge = new Regex(@"\d{2}");
    Match regexAgeMatch = regexAge.Match(age);
    if (regexAgeMatch.Success == true)
    {
        Console.WriteLine("Yas daxiletme ugurludur!");
    }
    else
    {
        Console.WriteLine("Duzgun yas daxil edin.(Yasda sadece reqem olmalidir!)");
        goto tryAge;
    }
    //----------------------------------------------------------------------------------------------------------------------
    Console.WriteLine("\nEmailinizi daxil edin.");
tryEmail:
    email = Console.ReadLine();
    Regex regexEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
    Match regexEmailMatch = regexEmail.Match(email);
    if (regexEmailMatch.Success == true)
    {
        Console.WriteLine("Email daxiletme ugurludur!");
    }
    else
    {
        Console.WriteLine("Duzgun email daxil edin.");
        goto tryEmail;
    }
    //----------------------------------------------------------------------------------------------------------------------
    Console.WriteLine("\nSifre daxil edin.");
tryPassword:
    password = Console.ReadLine();
    Regex regexPassword = new Regex(@".+");
    Match regexPasswordMatch = regexEmail.Match(password);
    if (regexPasswordMatch.Success == true)
    {
        Console.WriteLine("Sifre daxiletme ugurludur!");
    }
    else
    {
        Console.WriteLine("Duzgun sifre daxil edin.");
        goto tryPassword;
    }
    //----------------------------------------------------------------------------------------------------------------------
    Console.WriteLine("\nTelefon nomresi daxil edin.");
tryPhonenumber:
    phonenumber = Console.ReadLine();
    Regex regexPhonenumber = new Regex(@"^\+994\-[0-9]{2}\-[0-9]{3}\-[0-9]{2}\-[0-9]{2}");
    Match regexPhonenumberMatch = regexEmail.Match(phonenumber);
    if (regexPhonenumberMatch.Success == true)
    {
        Console.WriteLine("Telefon nomresi daxiletme ugurludur!");
    }
    else
    {
        Console.WriteLine("Duzgun telefon nomresi daxil edin.");
        goto tryPhonenumber;
    }

}

