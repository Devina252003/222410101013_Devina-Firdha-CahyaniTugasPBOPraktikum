using System;
using System.Runtime.ConstrainedExecution;

class Processor
{
    public string Merk { get; set; }
    public string Tipe { get; set; }
    public  Processor(string merk, string tipe) 
    { 
        Merk = merk;
        Tipe = tipe;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Merk: {Merk}");
        Console.WriteLine($"Tipe: {Tipe}");
    }

}

class AMD : Processor 
{ 
    public AMD(string tipe) : base("AMD", tipe)
    {
        if (string.IsNullOrEmpty(tipe))
        {
            throw new ArgumentException("Tipe harus diisi");
        }
    }
}

class Ryzen : AMD
{
    public Ryzen() : base("Ryzen")
    {}
}

class Athlon : AMD
{
    public Athlon() : base("Athlon")
    {}
}

class Intel : Processor
{
    public Intel(string tipe) : base("Intel", tipe)
    {
        if (string.IsNullOrEmpty(tipe))
        {
            throw new ArgumentException("Tipe harus diisi");
        }
    }
}

class Corei3 : Intel
{
    public Corei3() : base("Corei3")
    {}
}

class Corei5 : Intel
{
    public Corei5() : base("Corei5")
    {}
}

class Corei7 : Intel
{
    public Corei7() : base("Corei7")
    {}
}

class Vga
{
    public string Merk { get; set; }   
    public Vga (string merk)
    {
    Merk = merk;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Merk: {Merk}");
    }

}

class Nvidia : Vga
{
    public Nvidia() : base("Nvidia")
    {}
}

class AMD_VGA : Vga
{
    public AMD_VGA() : base("AMDVGA")
    {}
}

class Laptop
{
    public string Merk { get; set; }
    public string Tipe { get; set; }
    public Vga Vga { get; set; }
    public Processor Processor { get; set; }
    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} menyala");
    }
    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} mati");
    }
     public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
    public void BermainGame()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} sedang memainkan game");
    }
}

class ASUS : Laptop
{
    public ASUS()
    {Merk = "Asus";}
}
class ROG : ASUS
{
    public ROG()
    { Tipe = "ROG"; }
}
class Vivobook : ASUS
{
    public Vivobook()
    { Tipe = "Vivobook"; }
    public void Ngoding() {}
}

class ACER : Laptop
{
    public ACER()
    { Merk = "Acer"; }

}
class Swift : ACER
{
    public Swift()
    { Tipe = "Swift"; }
}
class Predator : ACER
{
    public Predator()
    { Tipe = "Predator"; }
    
}

class Lenovo : Laptop
{
    public Lenovo()
    { Merk = "Lenovo"; }
}
class Ideapad : Lenovo
{
    public Ideapad()
    { Tipe = "Ideapad"; }
}
class Legion : Lenovo
{
    public Legion()
    { Tipe = "Legion"; }
}

class Program
{
    public static void Main(string[] args)
    {
        // No 2.
        Laptop laptop1 = new Vivobook { Vga = new Nvidia(), Processor = new Corei5() };
        laptop1.Ngoding();

        // No 1.
        Laptop laptop2 = new Ideapad { Vga = new AMD_VGA(), Processor = new Ryzen()};
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();

        // No 4.
        Predator predator = new Predator { Vga = new AMD_VGA(), Processor = new Corei7() };
        predator.BermainGame();

        // No 5.
        ACER acer = predator; 
        acer.BermainGame();

        // No 3.
        Console.WriteLine("\nSpesifikasi Laptop1:");
        Console.WriteLine($"Merk VGA: {laptop1.Vga.Merk}");
        Console.WriteLine($"Merk Processor: {laptop1.Processor.Merk}");
        Console.WriteLine($"Tipe Processor: {laptop1.Processor.Tipe}");
    }
}