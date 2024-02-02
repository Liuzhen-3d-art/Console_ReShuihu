using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NiMingHanShu
{
    class LZpaiReShuiQi
    {
        public int ShuiWen = 0;

 

        
        public void shaoshui()
        {
            int i = ShuiWen;
            for (ShuiWen = i; ShuiWen < 100; ShuiWen++)
            {

                Console.WriteLine(ShuiWen);
                Thread.Sleep(500);
                

            }
            Console.WriteLine("水开了");
        }

        public void Baowen()
        {
            int baowen = 0;
            if (ShuiWen == 100)
            {
                baowen = 50;
            }
            if (ShuiWen < 99 && ShuiWen > 0)
            {
                Console.WriteLine("0-85请时输入一个保温温度");
                baowen = int.Parse(Console.ReadLine());
            }

            if ((baowen > 0 && baowen <= 85)&&ShuiWen>1)
            {
                int i = ShuiWen;
                for (ShuiWen= i; ShuiWen >= baowen; ShuiWen--)
                {
                    Console.WriteLine(ShuiWen);
                    Thread.Sleep(500);
                }
                Console.WriteLine("正在保温");
            }
            if ((baowen > 0 && baowen <= 85) && ShuiWen == 0)
            {
                int i = ShuiWen;
                for (ShuiWen = i; ShuiWen <= baowen; ShuiWen++)
                {
                    Console.WriteLine(ShuiWen);
                    Thread.Sleep(500);
                }
                Console.WriteLine("正在保温");
            }
        }
    }
}
