Start:
Console.WriteLine("Seciminizi Girin: \n(1) - Manati Cevirmek \n(2) - Dollari Cevirmek \n(3) - Euroyu Cevirmek\n(4) - Cixmaq Isteyirsinizse");
int secim;
secim = Convert.ToInt32(Console.ReadLine());
while (secim != 4)
{
    try
    {
        switch (secim)
        {
            case 1:
            Baqir:
                Console.WriteLine("(1) - Dollari secin \n(2) - Euroyu Secin");
                int secimiki = Convert.ToInt32(Console.ReadLine());
                if (secimiki == 1)
                {
                    Console.WriteLine("Hal Hazirda Manati Dollara Cevirirsiniz");
                    double dollar = 0.59;
                    Console.Write("Meblegi Girin: ");
                    int mebleg = Convert.ToInt32(Console.ReadLine());
                    double result = mebleg * dollar;
                    Console.WriteLine(result);
                    goto Start;
                }
                else if (secimiki == 2)
                {
                    Console.WriteLine("Hal Hazirda Manati Euroya Cevirirsiniz");
                    double euro = 0.55;
                    Console.Write("Meblegi Girin: ");
                    int mebleg = Convert.ToInt32(Console.ReadLine());
                    double result = mebleg * euro;
                    Console.WriteLine(result);
                    goto Start;
                }
                else
                {
                    Console.WriteLine("Siz Dogru Emeliyyati Secmediniz");
                    goto Baqir;
                }
            case 2:
            Baqirbir:
                Console.WriteLine("(1) - Manati Secin \n(2) - Euroyu Secin");
                int secimuc = Convert.ToInt32(Console.ReadLine());
                if (secimuc == 1)
                {
                    Console.WriteLine("Hal Hazirda Dollari Manata Cevirirsiniz");
                    double manat = 1.70;
                    Console.Write("Meblegi Girin: ");
                    int mebleg = Convert.ToInt32(Console.ReadLine());
                    double result = mebleg * manat;
                    Console.WriteLine(result);
                    goto Start;
                }
                else if (secimuc == 2)
                {
                    Console.WriteLine("Hal Hazirda Dollari Euroya Cevirirsiniz");
                    double euro = 0.94;
                    Console.Write("Meblegi Girin: ");
                    int mebleg = Convert.ToInt32(Console.ReadLine());
                    double result = mebleg * euro;
                    Console.WriteLine(result);
                    goto Start;
                }
                else
                {
                    Console.WriteLine("Siz Dogru Emeliyyati Secmediniz");
                    goto Baqirbir;
                }
            case 3:
            Baqiriki:
                Console.WriteLine("(1) - Manati Secin \n(2) - Dollari Secin");
                int secimdort = Convert.ToInt32(Console.ReadLine());
                if (secimdort == 1)
                {
                    Console.WriteLine("Hal Hazirda Euroyu Manata Cevirirsiniz");
                    double manat = 1.80;
                    Console.Write("Meblegi Girin: ");
                    int mebleg = Convert.ToInt32(Console.ReadLine());
                    double result = mebleg * manat;
                    Console.WriteLine(result);
                    goto Start;
                }
                else if (secimdort == 2)
                {
                    Console.WriteLine("Hal Hazirda Euroyu Dollara Cevirirsiniz");
                    double euro = 1.06;
                    Console.Write("Meblegi Girin: ");
                    int mebleg = Convert.ToInt32(Console.ReadLine());
                    double result = mebleg * euro;
                    Console.WriteLine(result);
                    goto Start;
                }
                else
                {
                    Console.WriteLine("Siz Dogru Emeliyyati Secmediniz");
                    goto Baqiriki;
                }
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        goto Start;
    }
}