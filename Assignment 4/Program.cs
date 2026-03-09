namespace Assignment_4
{
    #region Part 02
    //enum TicketType
    //{
    //    Standard,
    //    VIP,
    //    IMAX

    //}
    //struct Seat
    //{
    //    public char Row;
    //    public int Number;

    //    public Seat(char row, int number)
    //    {
    //        Row = row;
    //        Number = number;
    //    }

    //    public override string ToString() => $"{Row}{Number}";

    //}
    ////1
    //class Ticket

    //{
    //    public static int counter = 0;
    //    public string MovieName { get; set; }
    //    public int Ticketid { get; }


    //    private decimal _price;

    //    public decimal Price
    //    {
    //        get
    //        {
    //            return _price;

    //        }
    //        set
    //        {
    //            if (value > 0)
    //                _price = value;
    //        }
    //    }
    //    public decimal PriceAfterTax => _price + (_price * 14m / 100);

    //    public Ticket(string moviename, decimal price)
    //    {
    //        MovieName = moviename;
    //        Price = price;
    //        counter++;
    //        Ticketid = counter;


    //    }
    //    //1.a
    //    public virtual void PrintTicket()
    //    {
    //        Console.WriteLine($"Ticket #{Ticketid} | {MovieName} | Price :{Price} EGP | After Tax :{PriceAfterTax} EGP ");
           

    //    }
    //    //1.b
    //    public void SetPrice(decimal price)
    //    { Price = price; }
    //    public void SetPrice(decimal basePrice , decimal multiplier)
    //    { Price = basePrice*multiplier; }

    //    //public override string ToString()
    //    //    => $"[{Ticketid}] {MovieName} | Price : {Price} EGP | Price After Tax : {PriceAfterTax} EGP";
    //    public static int GetTotalTickets() => counter;

    //}
    ////2
    ////2.a
    //class StandardTicket : Ticket
    //{
    //    public string SeatNumber { get; set; }

    //    public StandardTicket(string moviename, decimal price, string seatnumber) : base(moviename, price)
    //    {
    //        SeatNumber = seatnumber;
    //    }

    //    //public override string ToString()
    //    //{
    //    //    return base.ToString() + $"| Seat :{SeatNumber}";
    //    //}
    //    public override void PrintTicket()
    //    {
    //        base.PrintTicket();
    //        Console.WriteLine($"Seat : {SeatNumber}");
    //    }

    //}
    //class VIPTicket : Ticket
    //{
    //    public bool LoungeAccess { get; set; }
    //    public decimal ServiceFee { get; } = 50;

    //    public VIPTicket(string moviename, decimal price, bool loungeAccess) : base(moviename, price)
    //    {
    //        loungeAccess = loungeAccess;
    //    }
    //    //public override string ToString()
    //    //{
    //    //    return base.ToString() + $"|  Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee : {ServiceFee} EGP";

    //    //}
    //    //2.b
    //    public override void PrintTicket()
    //    {
    //        base.PrintTicket();
    //        Console.WriteLine($"Lounge : {(LoungeAccess ? "Yes" : "No")} | Service Fee : {ServiceFee} EGP");
    //    }
    //}
    //class IMAXTicket : Ticket
    //{
    //    private bool _is3D;

    //    public bool Is3D
    //    {
    //        get { return _is3D; }
    //        set
    //        {
    //            if (value && !_is3D)
    //                Price += 30;
    //            if (!value && _is3D)
    //                Price -= 30;
    //            value = _is3D;

    //        }
    //    }
    //    public IMAXTicket(string moviename, decimal price, bool is3D) : base(moviename, price)
    //    {
    //        if (is3D) Price += 30;
    //        _is3D = is3D;
    //    }

    //    //public override string ToString()
    //    //{
    //    //    return base.ToString() + $" | IMAX 3D: {(Is3D ? "Yes" : "No")}";
    //    //}

    //    //2.c
    //    public override void PrintTicket()
    //    {
    //        base.PrintTicket();
    //        Console.WriteLine($"IMAX 3D : {(Is3D ? "Yes":"No")}");
    //    }

    //}
    //class Projector
    //{
    //    public bool IsRunning { get; private set; }

    //    public void Start()
    //    {
    //        IsRunning = true;
    //        Console.WriteLine("Projector started.");
    //    }
    //    public void Stop()
    //    {
    //        IsRunning = false;
    //        Console.WriteLine("Projector stopped.");
    //    }

    //}
    //class Cinema
    //{
    //    public string CinemaName { get; set; }
    //    private Projector _projector = new Projector();
    //    private Ticket[] tickets = new Ticket[20];

    //    public Cinema(string cinemaname)
    //    {
    //        CinemaName = cinemaname;
    //    }
    //    public Ticket this[int index]
    //    {
    //        get
    //        {
    //            if (index < 0 || index >= tickets.Length)
    //                return null;
    //            return tickets[index];

    //        }
    //        set
    //        {

    //            if (index < 0 || index >= tickets.Length)
    //                return;
    //            tickets[index] = value;


    //        }

    //    }
    //    public Ticket this[string movieName]
    //    {
    //        get
    //        {
    //            foreach (Ticket t in tickets)
    //            {
    //                if (t != null && t.MovieName == movieName)
    //                    return t;

    //            }
    //            return null;
    //        }

    //    }

    //    public bool AddTicket(Ticket t)
    //    {
    //        for (int i = 0; i < tickets.Length; i++)
    //        {
    //            if (tickets[i] == null)
    //            {
    //                tickets[i] = t;
    //                return true;
    //            }
    //        }
    //        Console.WriteLine("Cinema is full.");
    //        return false;
    //        {

    //        }
    //    }
    //    //3
    //    public void PrintAllTickets()
    //    {
    //        Console.WriteLine($"\n=== {CinemaName} Tickets ===");
    //        bool any = false;
    //        foreach (Ticket t in tickets)
    //        {
    //            if (t != null)
    //            { 
    //                t.PrintTicket();
    //                Console.WriteLine("--------------------------------------");
    //                any = true;
    //            }
    //            if (!any) Console.WriteLine("No tickets yet.");
    //        }

    //    }

    //    public void OpenCinema()
    //    {
    //        Console.WriteLine("========== Cinema Opened ==========");
    //        _projector.Start();
    //    }
    //    public void CloseCinema()
    //    {
    //        Console.WriteLine("========== Cinema Closed ==========");
    //        _projector.Stop();
    //    }
    //}

    //static class BookingHelper
    //{
    //    private static int counter = 0;
    //    public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
    //    {
    //        double total = numberOfTickets * pricePerTicket;
    //        if (numberOfTickets > 5)
    //        {
    //            return total - (total * 10.0 / 100);
    //        }
    //        return total;
    //    }
    //    public static string GenerateBookingReference()
    //    {
    //        counter++;
    //        return $"BK-{counter}";
    //    }
    //    //4
    //    public static void ProcessTicket(Ticket t)
    //    {
    //        Console.WriteLine("========== Process Single Ticket ==========");
    //        t.PrintTicket();
    //    }


    //}
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01
            #region Question01
            //Static Binding >>Resolved at compile time 
            //Happens with: Method Overloading , Operator Overloading , Method Hiding
            //Dynamic Binding >> Resolved at runtime
            //Happens with: Method Overriding , Abstract Methods , Interface Implementation.
            #endregion
            #region Question02
            //Method Overloading >> Same method name, different parameter lists — within the same class. Resolved at compile time.
            // Method Overriding >> Derived class overrides a virtual method from the base class using the override keyword.
            #endregion
            #region Question03
            //virtual  >> Placed in the parent class. Marks the method as overridable.
            //override >> Placed in the child class. Actually performs the override.
            //sealed >> Placed in a child class to prevent grandchildren from overriding again.
            #endregion
            #endregion
            #region Part 02
            ////5
            ////5.a
            //Cinema cinema01 = new Cinema("Galaxy Cinema");
            //cinema01.OpenCinema();

            ////5.b
            //StandardTicket t1 = new StandardTicket("Inception",150,"A-5");
            //VIPTicket t2 = new VIPTicket("Avengers", 200, true);
            //IMAXTicket t3 = new IMAXTicket("Dune", 180, false);
            //Console.WriteLine();
            ////5.c
            //Console.WriteLine("========== SetPrice Test ==========");
            //t1.SetPrice(150);
            //Console.WriteLine($"Setting price directly : {t1.Price}");
            //t1.SetPrice(100, 1.5m);
            //Console.WriteLine($"Setting price with multiplier  : 100 x 1.5 = {t1.Price}");

            ////5.d
            //cinema01.AddTicket(t1);
            //cinema01.AddTicket(t2); 
            //cinema01.AddTicket(t3);
            //cinema01.PrintAllTickets();

            ////5.e
            //BookingHelper.ProcessTicket(t2);
            ////5.f
            //cinema01.CloseCinema();


            #endregion

        }
    }
}
