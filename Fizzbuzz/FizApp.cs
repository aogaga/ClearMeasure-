using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz
{
    public class FizApp
    {
        

        public List<string> GetFizzBuzz(int num, List<FizBuzInputValues> intputValues)
        {

          
            Console.WriteLine(num.ToString());
            List<string> result = new List<string>();

            try
            {
                for (int i = 1; i <= num; i++)
                {
                    var itemNotAddedToList = true;
                    foreach (var x in intputValues)
                    {
                        if (i % x.Value == 0)
                        {
                            result.Add(x.Word);

                            itemNotAddedToList = false;
                        }


                    }

                    if (itemNotAddedToList == true)
                    {
                        result.Add(i.ToString());

                    }

                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            return result;
        }
    }
}
