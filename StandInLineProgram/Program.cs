using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandInLineProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 6, 1, 1, 1, 2, 0, 0 };
            StandInLine standInLine = new StandInLine();
            int[] res=standInLine.Reconstruct(arr);
            for(int i=0; i<res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
                
        }
    }
    class StandInLine
    {
        public int[] Reconstruct(int[] left)
        {
            int[] final = new int[left.Length];
            int persons = 0;
          
            
            for(int leftIndex=0; leftIndex<left.Length; leftIndex++)
            {
                persons = left[leftIndex];
               for(int finalIndex = 0; finalIndex<final.Length; finalIndex++)
               {
                    if(persons  == 0 && final[finalIndex] == 0)
                    {
                        final[finalIndex] = leftIndex + 1;
                        break;
                    }
                    else if(persons !=0 && final[finalIndex] ==0)
                    {
                        persons--;
                    }
                }
            }
            
            return final;
        }

       
    }
}
