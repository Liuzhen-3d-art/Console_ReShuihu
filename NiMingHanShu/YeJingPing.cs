using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NiMingHanShu
{
    class YeJingPing
    {
        public string TiSHiCi = null;
        public void YeJingXianShi()
        {
            LZpaiReShuiQi lZpaiReShuiQi = new LZpaiReShuiQi();
            int XuanZeGongNeng=0;
            int baowenjishu = 0;

            if (Program.TongDian == true)
            {


                while (true)
                {
                    
                    Console.WriteLine("欢迎使用LZ热水器");
                    Thread.Sleep(2000);
                    Console.WriteLine("1.热水 2.取消烧水 3.保温 4.开关机 ");
                    if (lZpaiReShuiQi.ShuiWen < 99)
                    {
                        XuanZeGongNeng = int.Parse(Console.ReadLine());
                    }
                    if(lZpaiReShuiQi.ShuiWen == 100)
                    {
                        XuanZeGongNeng = 3;
                    }
                    try
                    {
                        if ( XuanZeGongNeng == 1 && Program.ShuRuJianCe != true)
                        {
                            Console.WriteLine("开始烧水");
                            lZpaiReShuiQi.shaoshui();
                            continue;
                        }
                        if (XuanZeGongNeng == 2 && Program.ShuRuJianCe != true)
                        {
                            Console.WriteLine("取消烧水");
                        }
                        if (XuanZeGongNeng == 3 && Program.ShuRuJianCe != true)
                        {
                            if (baowenjishu == 0)
                            {
                                Console.WriteLine("开始保温");
                            }
                            else
                            {
                                Console.WriteLine("正在保温");
                            }
                            
                          
                            lZpaiReShuiQi.Baowen();
                            baowenjishu++;
                            continue;
                        }
                        if (XuanZeGongNeng == 4 && Program.ShuRuJianCe != true)
                        {
                            Console.WriteLine("开关机");
                            break;
                        }

                    }
                    catch (Exception)
                    {

                        Console.WriteLine("输入错误！");
                    }
                }

                }
            }
        }
    }

