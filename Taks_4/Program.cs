using System.Diagnostics.CodeAnalysis;

namespace Taks_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
        #region task1
        //l1:
        //    Console.Write("Eded daxil edin:");
        //    string strvalue= Console.ReadLine();

        //    if (!int.TryParse(strvalue, out int value)) 
        //    {
        //        goto l1;
        //    }
        //    if ( value% 2==0)
        //    {
        //        Console.WriteLine($"{value}-Cut ededdir");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{value}-Tek ededdir");
        //    }
        #endregion

        #region task2
        // l1:
        //   Console.WriteLine("1-ci ededi daxil edin");
        //   string strvalue1=Console.ReadLine();
        //   if (!int.TryParse(strvalue1,out int value1))
        //   {
        //       goto l1;
        //   }
        //l2:
        //   Console.WriteLine("2-ci ededi daxil edin");
        //   string strvalue2 = Console.ReadLine();
        //   if (!int.TryParse(strvalue2, out int value2))
        //   {
        //       goto l2;
        //   }
        //   if (value1%value2==0)
        //   {
        //       Console.WriteLine($"{value1}/{value2}={value1/value2}");
        //   }
        //   else
        //   {
        //       Console.WriteLine($"{value1}/{value2}=Tam Bolunmur");
        //   }
        #endregion

        #region task3
        //l1:
        // Console.Write("Eded daxil edin");
        // string strvalue=Console.ReadLine();
        // if (!int.TryParse(strvalue ,out int value))
        // {
        //     goto l1;
        // }
        // if (value%10==7)
        // {
        //     Console.WriteLine("Beli");
        // }
        // else
        // {
        //     Console.WriteLine("Xeyir");
        // }
        #endregion

        #region task4
        //l1:
        //    Console.Write("2 reqemli Eded daxil edin");
        //    string strvalue = Console.ReadLine();
        //    bool yoxla = int.TryParse(strvalue, out int value);

        //    if (!yoxla)
        //    {
        //        goto l1;
        //    }
        //    if ((int)Math.Log10(value) + 1 != 2)
        //    {
        //        Console.WriteLine("2 reqemli eded!!!!");
        //        goto l1;
        //    }

        //    if (value % 10 == value / 10)
        //    {
        //        Console.WriteLine("Eynidir");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Eyni deyil ");
        //    }
        #endregion

        #region task5
        //l1:
        //    Console.Write("2 reqemli Eded daxil edin");
        //    string strvalue = Console.ReadLine();
        //    bool yoxla = int.TryParse(strvalue, out int value);

        //    if (!yoxla)
        //    {
        //        goto l1;
        //    }
        //    if ((int)Math.Log10(value) + 1 != 2)
        //    {
        //        Console.WriteLine("2 reqemli eded!!!!");
        //        goto l1;
        //    }
        //    int sum = 0;
        //    int temp = value;
        //    while (temp > 0)
        //    {
        //        int interest = temp % 10;
        //        temp /= 10;
        //        sum += interest;

        //    }
        //    if (sum % 2 == 0)
        //    {
        //        int sum2 = 1;

        //        while (value > 0)
        //        {
        //            int interest = value% 10;
        //            value /= 10;
        //            sum2 = sum2 * interest;

        //        }
        //        Console.WriteLine(sum2);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Reqemleri cemi cut deyil");

        //    }
        #endregion

        #region taks6
        //l1:
        //    Console.Write("3 reqemli Eded daxil edin");
        //    string strvalue = Console.ReadLine();
        //    bool yoxla = int.TryParse(strvalue, out int value);

        //    if (!yoxla)
        //    {
        //        goto l1;
        //    }
        //    if ((int)Math.Log10(value) + 1 != 3)
        //    {
        //        Console.WriteLine("3 reqemli eded!!!!");
        //        goto l1;
        //    }
        //    int ilkvalue = value / 100;
        //    int sonvalue=value% 10;
        //    int ortavalue=value/ 10;
        //    int ortavalue1=ortavalue% 10;
        //    if (ilkvalue+sonvalue==ortavalue1)
        //    {
        //        Console.WriteLine("eynidir");
        //    }
        //    else
        //    {
        //        Console.WriteLine("eyni deyil");
        //    }

        #endregion

        #region task7
        //l1:
        //Console.Write("3 reqemli Eded daxil edin");
        //string strvalue = Console.ReadLine();
        //bool yoxla = int.TryParse(strvalue, out int value);

        //if (!yoxla)
        //{
        //    goto l1;
        //}
        //if ((int)Math.Log10(value) + 1 != 3)
        //{
        //    Console.WriteLine("3 reqemli eded!!!!");
        //    goto l1;
        //}
        //int sum = 0;
        //int temp = value;
        //while (temp>0)
        //{
        //    int interest = temp % 10;
        //    temp/= 10;
        //    sum+= interest; 
        //}
        //int ilkvalue = value / 100;
        //int square = ilkvalue * ilkvalue;
        //if (sum==square)
        //{
        //    Console.WriteLine("Beli");
        //}
        //else 
        //{
        //    Console.WriteLine("Deyil");
        //}


        #endregion

        #region task8
        //l1:
        // Console.Write("Eded daxil edin:");
        // string strvalue=Console.ReadLine();
        // bool yoxla = int.TryParse(strvalue, out int value);

        // if (!yoxla)
        // {
        //     goto l1;
        // }
        // switch (value%10)
        // {
        //     case 1:
        //         Console.WriteLine("I-gun");
        //         break;

        //     case 2:
        //         Console.WriteLine("II-gun");
        //         break;

        //     case 3:
        //         Console.WriteLine("III-gun");
        //         break; 

        //     case 4:
        //         Console.WriteLine("IV-gun");
        //         break;

        //     case 5:
        //         Console.WriteLine("V-gun");
        //         break;

        //     case 6:

        //         Console.WriteLine("VI-gun");
        //         break;

        //     case 7:
        //         Console.WriteLine("VII-gun");
        //         break;
        // }
        #endregion

        #region task9
        //l1:
        //    Console.Write("Eded daxil edin:");
        //    string strvalue = Console.ReadLine();
        //    bool yoxla = int.TryParse(strvalue, out int value);

        //    if (!yoxla)
        //    {
        //        goto l1;
        //    }

        //    if (value>=1 && value<=12) 
        //    {
        //        switch (value)
        //        {
        //            case 1:
        //                Console.WriteLine("Yanvar");
        //                break;

        //            case 2:
        //                Console.WriteLine("Fevral");
        //                break;

        //            case 3:
        //                Console.WriteLine("Mart");
        //                break;

        //            case 4:
        //                Console.WriteLine("Aprel");
        //                break;

        //            case 5:
        //                Console.WriteLine("May");
        //                break;

        //            case 6:

        //                Console.WriteLine("Iyun");
        //                break;

        //            case 7:
        //                Console.WriteLine("Iyul");
        //                break;

        //            case 8:
        //                Console.WriteLine("Avqust");
        //                break;

        //            case 9:
        //                Console.WriteLine("Sentyabr");
        //                break;

        //            case 10:
        //                Console.WriteLine("Oktaybr");
        //                break;

        //            case 11:
        //                Console.WriteLine("Noyabr");
        //                break;

        //            case 12:
        //                Console.WriteLine("Dekabr");
        //                break;



        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("1-ile 12 arasinda reqem secin");

        //        goto l1;
        //    }
        #endregion

        #region task10
        //    l1:
        //    Console.Write("1-ci ededi daxil edin:");
        //    string strvalue1=Console.ReadLine();
        //    if (!int.TryParse(strvalue1 ,out int value1))
        //    {
        //        goto l1;
        //    }
        //l2:
        //    Console.Write("2-ci ededi daxil edin:");
        //    string strvalue2 = Console.ReadLine();
        //    if (!int.TryParse(strvalue2, out int value2))
        //    {
        //        goto l2;
        //    }
        //l3:
        //    Console.Write("3-cu ededi daxil edin:");
        //    string strvalue3 = Console.ReadLine();
        //    if (!int.TryParse(strvalue3, out int value3))
        //    {
        //        goto l3;
        //    }
        //l4:
        //    Console.Write("4-cuededi daxil edin:");
        //    string strvalue4 = Console.ReadLine();
        //    if (!int.TryParse(strvalue4, out int value4))
        //    {
        //        goto l4;
        //    }
        //l5:
        //    Console.Write("5-ci ededi daxil edin:");
        //    string strvalue5 = Console.ReadLine();
        //    if (!int.TryParse(strvalue5, out int value5))
        //    {
        //        goto l5;
        //    }
        //l6:
        //    Console.Write("6-ci ededi daxil edin:");
        //    string strvalue6= Console.ReadLine();
        //    if (!int.TryParse(strvalue6, out int value6))
        //    {
        //        goto l6;
        //    }
        //    int max_value = value1;
        //    if (value2>max_value)
        //    {
        //        Console.WriteLine($"en boyuk eded {value2}");
        //        max_value= value2;
        //    }
        //    if (value3 > max_value)
        //    {
        //        Console.WriteLine($"en boyuk eded {value3}");
        //        max_value = value3;
        //    }
        //     if (value4>max_value)
        //    {
        //        Console.WriteLine($"en boyuk eded {value4}");
        //        max_value= value4;
        //    }

        //    if (value5 > max_value)
        //    {
        //        Console.WriteLine($"en boyuk eded {value5}");
        //        max_value = value5;
        //    }
        //    if (value6 > max_value)
        //    {
        //        Console.WriteLine($"en boyuk eded {value6}");
        //        max_value = value6;
        //    }






        #endregion

        #region task11
        //l1:
        //    Console.Write("6 reqemli Eded daxil edin");
        //    string strvalue = Console.ReadLine();
        //    bool yoxla = int.TryParse(strvalue, out int value);

        //    if (!yoxla)
        //    {
        //        goto l1;
        //    }
        //    if ((int)Math.Log10(value) + 1 != 6)
        //    {
        //        Console.WriteLine("6 reqemli eded!!!!");
        //        goto l1;
        //    }
        //    int ilk3value = value / 1000;
        //    int sum = 0;
        //    while (ilk3value>0)
        //    {
        //        int faiz = ilk3value % 10;
        //        ilk3value /= 10;
        //        sum+= faiz;
        //    }
        //    int son3value = value % 1000;
        //    int sum2 = 0;
        //    while (son3value > 0)
        //    {
        //        int faiz2 = son3value % 10;
        //        son3value /= 10;
        //        sum2 += faiz2;
        //    }
        //    if (sum==sum2)
        //    {
        //       int ilk2value = value / 10000;
        //        int son2value = value % 100;
        //        int birlesdir = ilk2value * 100 + son2value;
        //        int son4value = value % 10000;
        //        int orta2value = son4value / 100;
        //        int final = birlesdir + orta2value;
        //        Console.WriteLine(final);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Reqemleri cemi eyni deyil:");
        //    }
        #endregion

        #region taks12 
        //l1:
        //    Console.Write("6 reqemli Eded daxil edin");
        //    string strvalue = Console.ReadLine();
        //    bool yoxla = int.TryParse(strvalue, out int value);

        //    if (!yoxla)
        //    {
        //        goto l1;
        //    }
        //    if ((int)Math.Log10(value) + 1 != 6)
        //    {
        //        Console.WriteLine("6 reqemli eded!!!!");
        //        goto l1;
        //    }
        //    int value8add = (value + 8000000) * 10 + 8;
        //    int valueilk4 = value8add / 10000;
        //    int valueson4 = value8add % 10000;
        //    int ters = valueson4 * 10000 + valueilk4;

        //    int sum = 0;
        //    int sum2 = 0;

        //    Console.WriteLine(ters);
        //    while (ters > 0)
        //    {
        //        int faiz = ters % 10;
        //        ters /= 100;


        //        sum = sum * 100 + faiz*10;




        //    }

        //    while (sum >0)
        //    {
        //        int faiz = sum % 10;
        //        sum/= 10;
        //        sum2 = sum2 * 10 + faiz;

        //    }
        //    Console.WriteLine(sum2);
        #endregion

        #region task13
        //l1:
        //    Console.Write("7 reqemli Eded daxil edin:");
        //    string strvalue = Console.ReadLine();
        //    bool yoxla = int.TryParse(strvalue, out int value);

        //    if (!yoxla)
        //    {
        //        goto l1;
        //    }
        //    if ((int)Math.Log10(value) + 1 != 7)
        //    {
        //        Console.WriteLine("7 reqemli eded polindromd deyil");
        //        goto l1;
        //    }
        //    int sum = 0;
        //    int temp = value;
        //    while (temp > 0)
        //    {
        //        int faiz = temp % 10;
        //        temp /= 10;
        //        sum = sum * 10 + faiz;

        //    }

        //    if (value == sum)
        //    {
        //        int sum2 = 0;
        //        while (value > 0)
        //        {
        //            int faiz1 = value % 10;
        //            value /= 10;
        //            if (faiz1 == 0)
        //            {


        //                sum2++;
        //            }

        //        }

        //        Console.WriteLine(sum2);
        //    }
        #endregion

        #region task14
        //l1:
        // Console.Write("Max 8 reqemli bir eded daxil edin:");
        // string strvalue = Console.ReadLine();
        // bool yoxla = int.TryParse(strvalue, out int value);

        // if (!yoxla)
        // {
        //     goto l1;
        // }
        // if ((int)Math.Log10(value) + 1  <=8)
        // {
        //     int say=(int)Math.Log10(value)+1;
        //     int value1artir = value + 1 * (int)Math.Pow(10, say);
        //     Console.WriteLine(value1artir);
        // }
        #endregion

        #region task15
        //l1:
        //    Console.Write("1-ile 365 arasinda eded daxil edin:");
        //    string strvalue = Console.ReadLine();
        //    bool yoxla = int.TryParse(strvalue, out int value);

        //    if (!yoxla)
        //    {
        //        goto l1;
        //    }
        //    if (value < 1 || value > 365)
        //    {
        //        goto l1;
        //    }
        //    if (value > 0 && value < 32 )
        //    {
        //        Console.WriteLine("Yanvar");

        //    }
        //    else if (value > 31 && value < 61)
        //    { Console.WriteLine("Fevral"); }

        //    else if (value > 60 && value < 93)
        //    { Console.WriteLine("Mart"); }

        //    else if (value > 92 && value < 122)
        //    { Console.WriteLine("Aprel"); }

        //    else if (value > 121 && value < 153)
        //    { Console.WriteLine("May"); }

        //    else if (value > 152 && value < 183)
        //    { Console.WriteLine("Iyun"); }

        //    else if (value > 182 && value < 214)
        //    { Console.WriteLine("Iyul"); }

        //    else if (value > 213 && value < 245)
        //    { Console.WriteLine("Avqust"); }

        //    else if (value > 244 && value < 275)
        //    { Console.WriteLine("Sentyabr"); }

        //    else if (value > 274 && value < 304)
        //    { Console.WriteLine("Oktyabr"); }

        //    else if (value > 303 && value < 334)
        //    { Console.Write("Noyabr"); }

        //    else if (value > 333 && value < 366)
        //    { Console.Write("Dekbar"); }

        //    if (value > 19 && value < 50)
        //    {
        //       Console.Write("Dolca");
        //    }
        //    else if (value>49 && value<80)
        //    {
        //        Console.Write( "Baliq");
        //    }
        //    else if (value>79 && value < 110)
        //    {
        //       Console.Write ("Qoc");

        //    }
        //    else if (value>109 && value>141)
        //    {
        //      Console.Write( "Buga");
        //    }



        #endregion

        #region task16
        //l1:
        //    Console.Write("6 reqemli eded daxil edin :");
        //    string strvalue = Console.ReadLine();
        //    bool yoxla = int.TryParse(strvalue, out int value);

        //    if (!yoxla)
        //    {
        //        goto l1;
        //    }
        //    if ((int)Math.Log10(value) + 1 != 6)
        //    {
        //        goto l1;
        //    }
        //    int sum;
        //    while (value > 0)


        #endregion
        l1:
            Console.Write("6 reqemli eded daxil edin :");
            string strvalue = Console.ReadLine();
            bool yoxla = int.TryParse(strvalue, out int say);

            if (!yoxla)
            {
                goto l1;
            }
            if ((int)Math.Log10(say) + 1 != 6)
            {
                goto l1;
            }
          ;
            int[] tekrar = new int[10];

            while (say > 0)
            {
                int faiz = say % 10;
                if (tekrar[faiz] > 0)
                {
                    tekrar[faiz]++;
                }
                else
                {
                    tekrar[faiz] = 1;
                }
                say /= 10;
            }

            for (int i = 0; i < 10; i++)
            {
                if (tekrar[i] > 0)
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}