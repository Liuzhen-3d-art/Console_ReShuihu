using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiMingHanShu
{
  public  static class  Program
    {
        public static bool TongDian = false;
        public static int XuanZeGongNeng;
        public static bool ShuRuJianCe;
        static void Main(string[] args)
        {
            YeJingPing yeJingPing = new YeJingPing();
            
         

                Console.WriteLine("请给热水壶通上电？0：否认   1:确认");
                int shurujieguo = int.Parse(Console.ReadLine());
              
                    if (shurujieguo == 1)
                    {
                        TongDian = true;
                        yeJingPing.YeJingXianShi();
                       
                    } 
                    else if (shurujieguo == 0)
                    {
                        TongDian = false;
                    }

           
        }
        
    }
}
