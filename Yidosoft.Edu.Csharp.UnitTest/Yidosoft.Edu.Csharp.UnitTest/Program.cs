using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yidosoft.Edu.Csharp.UnitTest
{
    public class Program
    {
        public static void Main()
        {
            //Console.WriteLine("你好，小花。");
        }

        public string GetData(string name)
        {
            return $"我的名字叫{name}";
        }

        public int GetLength(string str)
        {
            return str.Length;
        }

        public int[] MP_Order(int [] arr)
        {
            if(arr==null || arr.Length == 0)
            {
                arr = new int[10] { 32, 12, 50, 7, 9, 25, 42, 100, -9, -20 };
            }
            int temp = 0;
            for(int i=0;i< arr.Length-1; i++)
            {
                for(int j=i+1; j< arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }

        //求以下表达式的值，写出您想到的一种或几种实现方法：1-2+3-4+……+m
        public int GetSum(int num)
        {
            int sum = 0;
            for(int i=0;i< num + 1; i++)
            {
                if (i % 2 == 1)
                {
                    sum += i;
                }
                else
                {
                    sum -= i;
                }
            }
            return sum;
        }

        public string GetPercent(double a, double all)
        {
            return (a / all).ToString("0.0%");
        }

        public double IntToDouble(int a)
        {
            return Convert.ToDouble(a);
        }

        public DayOfWeek GetWeek(int a)
        {
            DayOfWeek week = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), a.ToString());
            return week;
        }

        public int GetCardCount(DateTime beginTime, DateTime endTime, string cycle, bool isAll = false)
        {
            int count = 0;
            if (!isAll && beginTime.Date > DateTime.Now.Date)
            {
                return count;//任务未开始
            }
            TimeSpan vTimeSpan = new TimeSpan(endTime.AddDays(1).Ticks - beginTime.Ticks);
            int weekCount = (int)vTimeSpan.TotalDays / 7;
            if (!string.IsNullOrEmpty(cycle))
            {
                string[] weekDayArr = cycle.Replace('，', ',').Split(',');
                foreach (string weekDay in weekDayArr)
                {
                    string day = weekDay == "7" ? "0" : weekDay;
                    DayOfWeek week = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), day);
                    for (int i = 0; i < vTimeSpan.TotalDays % 7; i++)
                    {
                        if (beginTime.AddDays(i).DayOfWeek == week)
                        {
                            count += 1;
                        }
                    }
                }
                return weekCount > 0 ? weekCount * weekDayArr.Length + count : count;
            }
            return 0;
        }

        public List<string> GetUnionList(List<string> list1, List<string> list2)
        {
            List<string> list = new List<string>();
            list = list1.Union(list2).ToList();
            return list;
        }
    }
}
