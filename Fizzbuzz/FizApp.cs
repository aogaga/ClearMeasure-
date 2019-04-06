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

          
            List<string> result = new List<string>();

            try
            {
                for (int i = 1; i <= num; i++)
                {
                    var itemNotAddedToList = true;
                    string totalOutput = null;
                    foreach (var x in intputValues)
                    {
                        if (i % x.Value == 0)
                        {
                          
                            totalOutput = $"{totalOutput} {x.Word}";

                            itemNotAddedToList = false;
                        }


                    }

                    result.Add(itemNotAddedToList ? i.ToString() : totalOutput);
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
