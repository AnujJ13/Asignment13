using System;
using System.Collections.Generic;
using System.Text;

namespace Asignment13.oops
{
    class prime
    {
        int prime(int n)
        {
            bool isprime = true;
            {
                for (int i =2; i< n; i++)
                {
                    if (n % i ==0)
                    {
                        isprime = true;
                        break;
                    }
                }

                {
                    isprime = false;
                }

                return isprime;


            }
            
        }


    }
}
