using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiMingHanShu
{
    class NiFun//学习委托的类，与烧水无关
    {
        //事件   事件就是委托的示例
        public event Action shijian;//这样就声明了一个事件
        //声明一个空的匿名方法,它与普通方法的区别是在返回值的前面加上关键字delegate；声明了以后这个方法名就是匿名的类名，可以用这个类直接声明一个变量然后赋值一个关键字delega带括号的方法（如果前面声明匿名方法的时候就带了参数，那实现的时候也要带一样的参数,最后可以再不同的地方实现这个方法)
        //
        public delegate void NiMingWeiTuo();
        
        public delegate string NiMingWeiTuoCan(int a);//声明一个有参有返回值的委托
        public NiMingWeiTuoCan nimingdaican = delegate (int a)
      {

          while (true)
          {
              if (a == 1)
              {
                  string jieguo = "我会说话";
                  Console.WriteLine(jieguo);
                  return jieguo;
              }
              if (a == 2)
              {

                  string jieguo = "我在向你说话";
                  Console.WriteLine(jieguo);
                  return jieguo;
              }
              if (a == 3)
              {

                  string jieguo = "我正在向你说话";
                  Console.WriteLine(jieguo);
                  return jieguo;
              }
              if (a == 4)
              {

                  string jieguo = "我说完了";
                  Console.WriteLine(jieguo);
                  return jieguo;
              }
          }
      };//实现这个有参有返回值的委托的匿名方法；
        
        public NiMingWeiTuoCan niMingWeiTuoCan = a =>
       {

           return "我使用了Lambda表达式";

       };
        private void abcd()
        {
            Console.WriteLine("委托1");
        }
        public void NImingFun()
        {
            NiMingWeiTuo niMingWeiTuo = delegate//在一个方法中定义一个匿名方法，可以在一个方法中不限数量声明匿名方法。
            {
                Console.WriteLine("这是匿名方法");
            };
            niMingWeiTuo();//使用方法相同

            //匿名方法可以用Lambda表达式来代替






        }

        //匿名对象  语法格式 var obj = new { id = "匿名对象1", ppp = "匿名对象2", nickname = "匿名对象3" };






        //Lambda表达式    Lambda也是一种匿名函数，看看就行操作反人类

        public void LambdaBiaoDaShi()
        {
            NiMingWeiTuo dell = () =>
            {
                Console.WriteLine("我使用了Lambda表达式");
            };
            dell();

            var obj = new { id = "匿名对象1", ppp = "匿名对象2", nickname = "匿名对象3" };
            while (true)
            {
                Console.WriteLine(obj.id);
                Console.WriteLine(obj.ppp);
                Console.WriteLine(obj.nickname);
                break;
            }
        }

        public void TestAction()//内置的委托的三种写法
        {

            Action action = () => { Console.WriteLine("我是内置的无参无返回值委托"); };//Action是一个有参无返回值的内置匿名方法，它可以从无参变成16个参数。
            Action<int> action1 = (int a) => { Console.WriteLine(a + "我是一个参数的内置的无返回值委托"); };
            Action<int, string> action2 = delegate (int a, string b)
            {
                Console.WriteLine($"我是{b},我的第一个参数是{a},我是两个有参无返回值的委托");
            };



        }
        public void TestFunc()
        {

            Func<string> func = delegate ()//Func是一个有返回值有参的内置匿名方法，它的最后一个参数代表返回值，他必须包含一个参数，只有一个参数的时候代表返回值。
            {
                return "我是内置无参有返回值的委托";
            };
            var e = func();
            Console.WriteLine(e);
        }

        //事件
        private void ShiJianJianCe()
        {
            Console.WriteLine("事件的指定驱动方法2");
        }
        public void TestEventOne()//绑定方法多播委托差不多，调用方式一样
        {
            //+=是绑定方法；
            shijian += delegate
            {
                Console.WriteLine("事件的匿名驱动方法");
            };
     
            shijian += NiFun_shijian;
            shijian += ShiJianJianCe;

           

        }

        private void NiFun_shijian()
        {
            Console.WriteLine("事件指定驱动方法");
        }

        public void ShiJian()//在这里类里用一个方法封装一下这个事件的调用方式。这样就是可以在外部类中直接调用了
        {
            shijian.Invoke();//在这里调用了之前在其他方法里实现的方法了
        }



    }
}
