using System;
using R2000_Library;



class Calculations
{
/********************************************

    Useful Data:

        int[]   Var.measurementdata
        int []  Var.angulardata
        int []  Var.background
        int     Var.numscanpoints

    *******************************************/
    
    
    


    public void Width()
    {
        int backgroundbuffer = 50;
        int[] objectdistance = new int[2];
        decimal[] objectangle = new decimal[2];
        bool leadingedge = false;
        bool trailingedge = false;
        Console.WriteLine("Calculating Width");
        int i;

        for (i = 0; i < Var.numscanpoints; i++)
        {
            if (Var.measurmentdata[i] <= Var.background[i] - backgroundbuffer)
            {
                Console.WriteLine("Object Found0");
                objectdistance[0] = Var.measurmentdata[i];
                objectangle[0] = Var.angulardata[i];
                leadingedge = true;
                break;
            }
            else
            {
                //Console.WriteLine("Nothing Detected0");
                if (i == Var.numscanpoints)
                {
                    Console.WriteLine("No Object Found0");
                    objectdistance[0] = 'n';
                    objectangle[0] = 'n';
                    leadingedge = false;
                    break;                    
                }
            }
        }

        Console.WriteLine("i = " + i);

        
        if (leadingedge == true)
        {
            Console.WriteLine("Object was found!");
            for (i = i; i < Var.numscanpoints; i++)
            {
                if (Var.measurmentdata[i] >= Var.background[i] - backgroundbuffer)
                {
                    Console.WriteLine("Object Found1");
                    objectdistance[1] = Var.measurmentdata[i];
                    objectangle[1] = Var.angulardata[i];
                    trailingedge = true;
                    break;
                }
                else
                {
                    //Console.WriteLine("Nothing Dectected1");
                    if (i == Var.numscanpoints)
                    {
                        Console.WriteLine("No Object Found1");
                        objectdistance[1] = 'n';
                        objectangle[1] = 'n';
                        trailingedge = false;
                    }
                }
            }
        }

        Console.WriteLine("i = " + i);





    }







}

