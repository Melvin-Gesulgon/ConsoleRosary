using System;

//To God be the Glory!

//I created this console app to serve as a dynamic guide for praying the Rosary daily.

namespace ConsoleRosary;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("THE HOLY ROSARY PRAYER GUIDE");
        Console.WriteLine("------------------------------");
        Console.Write("A Minimalist Guide to Praying the Rosary");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Press ENTER to go through the guide's prompt.");
        Console.ReadLine();
        Console.Clear();

        string HailMary = "Hail Mary full of grace, the Lord is with you,\nblessed are you amongst women,\nand blessed is the fruit of thy womb, Jesus.";
        string HolyMary = "Holy Mary, mother of God,\npray for us sinners now,\nand at the hour of our death.";

        ApostlesCreed();
        Console.Clear();
        LordsPrayer();

        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"{i}/3");
            Console.ReadLine();
            Console.WriteLine(HailMary);
            Console.ReadLine();
            Console.WriteLine(HolyMary);
            Console.ReadLine();
            Console.WriteLine("AMEN");
            Console.ReadLine();
            Console.Clear();
        }

        Mystery();
        HailHolyQueen();

    }

    static void LordsPrayer()
    {
        string firstPart = "Our Father who art in heaven,\nHallowed be your name,\nYour kingdom come,\nYour will be done on Earth,\nas it is in heaven.";
        string secondPart = "Give us this day our daily bread, \nand forgive us our sins,\nas we forgive those who sinned us.\nDo not bring us to the test,\nbut deliver us from evil.";

        Console.WriteLine(firstPart);
        Console.ReadLine();
        Console.WriteLine(secondPart);
        Console.ReadLine();
        Console.WriteLine("AMEN");
        Console.ReadLine();
        Console.Clear();
    }

    public static  void Mystery()
    {
        
         var mysteryDate = DateTime.Now;
        

        var dateNow = DateTime.Now;
        string day = Convert.ToString(dateNow.DayOfWeek);
        string dayMystery = "";

        string[] JoyfulMystery = {  "The Annunciation",
                                    "The Visitation",
                                    "The Nativity",
                                    "The Presentation",
                                    "The Finding of the Child Jesus in the Temple"
                                 };

        string[] SorrowfulMystery = { "The Agony of Jesus in the Garden",
                                      "The Scourging at the Pillar",
                                      "The Crowning with Thorns",
                                      "The Carrying of the Cross",
                                      "The Crucifixion"
                                    };

        string[] GloriousMystery = { "The Resurrection",
                                     "The Ascension",
                                     "The Descent of the Holy Spirit",
                                     "The Assumption of Mary, Mother of God, into Heaven",
                                     "The Coronation of Mary in Heaven"
                                    };

        string[] LuminousMystery = { "The Baptism in Jordan River",
                                     "The Wedding Feast in Cana",
                                     "The Preaching of the Coming of the Kingdom of God",
                                     "The Transfiguration",
                                     "The Institution of the Eucharist"
                                    };

        if ((day == "Monday") || (day == "Saturday"))
        {
            dayMystery = "Joyful";
        }
        else if ((day == "Tuesday") || (day == "Friday"))
        {
            dayMystery = "Sorrowful";
        }
        else if ((day == "Wednesday") || (day == "Sunday"))
        {
            dayMystery = "Glorious";
        }
        else
        {
            dayMystery = "Luminous";
        }

        dayMystery = "Glorious";

        Console.WriteLine($"Today is {day}.\nSo, let's pray the five {dayMystery} Mysteries of our Faith.\n");
        Console.ReadLine();
        Console.Clear();
        
        for (int i = 1; i <= 5; i++)
        {
            string MysteryOrder = "";
            if (i == 1)
                MysteryOrder = "1st";
            else if (i == 2)
                MysteryOrder = "2nd";
            else if (i == 3)
                MysteryOrder = "3rd";
            else
                MysteryOrder = $"{i}th";


            if (dayMystery == "Joyful")
            {
                Console.WriteLine($"The {MysteryOrder} {dayMystery} Mystery\n" +
                                "\n-------------------------");
                Console.ReadLine();
                Console.WriteLine($"{JoyfulMystery[i - 1]}");
            }
            else if (dayMystery == "Sorrowful")
            {
                Console.WriteLine($"The {MysteryOrder} {dayMystery} Mystery\n" +
                                "\n-------------------------");
                Console.ReadLine();
                Console.WriteLine($"{SorrowfulMystery[i - 1]}");
            }
            else if (dayMystery == "Glorious")
            {
                Console.WriteLine($"The {MysteryOrder} {dayMystery} Mystery\n" +
                                "\n-------------------------");
                Console.ReadLine();
                Console.WriteLine($"{GloriousMystery[i - 1]}");
            }
            else
            {
                Console.WriteLine($"The {MysteryOrder} {dayMystery} Mystery" +
                                "\n-------------------------");
                Console.ReadLine();
                Console.WriteLine($"{LuminousMystery[i - 1]}");
            }

            Console.ReadLine(); 
            Decade();
        }

    }

    static void ApostlesCreed() 
    { 
        Console.WriteLine("I believe in God, \nthe Father almighty,\nCreator of heaven and earth,\nand in Jesus Christ,\nHis only Son, our Lord,\nwho was conceived by the Holy Spirit,\nborn of the Virgin Mary,\nsuffered under Pontius Pilate,\nwas crucified, died and was buried;");
        Console.ReadLine();
        Console.WriteLine("He descended into hell;\non the third day He rose again from the dead;\nHe ascended into heaven,\nand is seated at the right hand of God the Father Almighty;\nfrom there He will come to judge the living and the dead.");
        Console.ReadLine();
        Console.WriteLine("I believe in the Holy Spirit,\nthe Holy Catholic Church,\nthe communion of saints, \nthe forgiveness of sins,\nthe resurrection of the body,\nand life everlasting.");
        Console.ReadLine();
        Console.WriteLine("AMEN");
        Console.ReadLine();
        Console.Clear();
    }

    static void Decade()
    {
        LordsPrayer();
        
        for (int i = 1; i <= 10; i++)
        {
            string HailMary = "Hail Mary full of grace, the Lord is with you,\nblessed are you amongst women,\nand blessed is the fruit of thy womb, Jesus.";
            string HolyMary = "Holy Mary, mother of God,\npray for us sinners now,\nand at the hour of our death.";

            Console.WriteLine($"{i}/10");
            Console.ReadLine();
            Console.WriteLine(HailMary);
            Console.ReadLine();
            Console.WriteLine(HolyMary);
            Console.ReadLine();
            Console.WriteLine("AMEN");
            Console.ReadLine();
            Console.Clear();
        }

        Console.Clear();
        Console.WriteLine("Glory be to the Father,\nthe Son, and the Holy Spirit;\nas it was in the beginning,\nis now, and ever shall be,\nworld without end.");
        Console.ReadLine();
        Console.WriteLine("AMEN");
        Console.ReadLine();
        Console.WriteLine("O my Jesus, forgive us our sins,\nsave us from the fires of hell;\nlead all souls to Heaven,\nespecially those who have most need of your mercy.");
        Console.ReadLine();
        Console.WriteLine("AMEN");
        Console.ReadLine();
        Console.Clear();

    }

    static void HailHolyQueen()
    {
        Console.WriteLine("Hail, holy Queen, mother of mercy,\nOur life, our sweetness, and our hope.\nTo you we cry, poor banished children of Eve;\nTo you we send up our sighs,\nmourning and weeping in this valley of tears.");
        Console.ReadLine();
        Console.WriteLine("Turn, then, most gracious advocate,\nyour eyes of mercy toward us;\nand after this, our exile,\nshow unto us the blessed fruit of your womb, Jesus.\nO clement, O loving, O sweet Virgin Mary.");
        Console.ReadLine();
        Console.WriteLine("Pray for us, O holy Mother of God.\nThat we may be made worthy of the promises of Christ.\n");
        Console.ReadLine();
        Console.Clear();
        //
        Console.WriteLine("Oh God, whose Only Begotten Son,\nby His Life, Death, and Resurrection,\nhas purchased for us the rewards of eternal life,\ngrant, we beseech Thee,");
        Console.ReadLine();
        Console.WriteLine("that while meditating on these mysteries\nof the most holy Rosary of the Blessed Virgin Mary,\nwe may imitate what they contain\nand obtain what they promise,\nthrough the same Christ our Lord.");
        Console.ReadLine();
        Console.WriteLine("AMEN");
        Console.ReadLine();
        Console.WriteLine("To God be the glory!");
        Console.ReadLine();

    }
}