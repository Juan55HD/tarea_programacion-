using System;
using System.Security.Cryptography.X509Certificates;

class program
{

    static void Main(string[] args)
    {
        string nombre, clave;
        double billetes50, billetes20, billetes10, billetes5, saldo, retiro, billetes50to, billetes20to, billetes10to, billetes5to, suma, sumatotal;

        billetes50 = 0;
        billetes20 = 0;
        billetes10 = 0;
        billetes5 = 0;
        suma = 0;
        sumatotal = 0;
        int i = 0;

        while (i == 0)
        {
            Console.WriteLine("bienvenido, por favor dijite su nombre y clave");
            Console.Write("porfavor dijite su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("porfavor dijite su clave: ");
            clave = Console.ReadLine();
            if (nombre != "" && clave != "" )
            {



                Console.WriteLine("bienvenido, dijite la cantidad de dinero que desea retirar ");
                retiro = Convert.ToDouble(Console.ReadLine());
                saldo = 600000;

                if (retiro < saldo)
                {
                    while (suma < retiro && (suma + 50000) <= retiro)
                    {
                        billetes50++;
                        billetes50to = billetes50 * 50000;
                        suma = billetes50to;
                        



                    }
                    sumatotal = suma;


                    if (suma < retiro)
                    {

                        while (suma < retiro && (suma + 20000) <= retiro)
                        {
                            
                            billetes20++;
                            billetes20to = billetes20 * 20000;
                            suma = billetes20to + sumatotal;
                            
                        }
                        sumatotal = suma;


                    }
                    if (suma < retiro)
                    {


                        while (suma < retiro && (suma + 10000) <= retiro)
                        {
                           
                            billetes10++;
                            billetes10to = billetes10 * 10000;
                            suma = billetes10to + sumatotal;
                           
                        }
                        sumatotal = suma;

                    }
                    if (suma < retiro)
                    {


                        while (suma < retiro && (suma + 5000) <= retiro)
                        {
                            
                            billetes5++;
                            billetes5to = billetes5 * 5000;
                            suma = billetes5to + sumatotal;
                           
                        }
                        sumatotal = suma;

                    }
                    if (suma < retiro)
                    {
                        
                        Console.WriteLine(" no tenemos cambio para entregrale el dinero total que solicito, entonces vamos a comprobar si redondeamos hacia arriba o hacia abajo ");
                        if ((retiro - suma) >= 2500 && (retiro - suma) <= 4999)
                        {
                            billetes5++;
                            billetes5to = billetes5 * 5000;
                            suma = billetes5to + sumatotal;
                           

                        }
                        sumatotal = suma;



                        //if ((suma + 4.999) == retiro )

                    }
                    else
                    {
                        Console.WriteLine(" no tenemos cambio para entregrale el dinero total que solicito, entonces vamos a redondear la cifra hacia abajo, serian " + suma);
                    }


                    Console.WriteLine("aqui tiene su retiro: " + sumatotal + " y la cantidad de billetes que recibio es de 50000: " + billetes50 + ", de 20000: " + billetes20 + ", de 10000: " + billetes10 + ", de 5000 " + billetes5);

                }
                else
                {
                    Console.WriteLine("no podemos entregarte ese dinero , es demasiado ");
                }

            }
            

            else
            {
                Console.WriteLine("datos incompletlos");
            }

        i++;
        }
        


















    }


  

}
