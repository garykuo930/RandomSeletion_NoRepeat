using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽籤
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Lunch = new string[5] { "咖哩", "牛肉麵", "漢堡", "牛丼", "鍋貼" }; // 以陣列Lunch儲存目標字串
            int AssumeLength = Lunch.Length; // 為一假設之陣列長度，用作陣列內資料的儲存位置更換

            // foreach (string i in Lunch)
            for (int i = 0; i <= Lunch.Length; i += 1)
            {
                Random k = new Random(); // 內建隨機方法，與以下的.NextDouble()方法搭配
                double RandomNumber = k.NextDouble(); // 將變數RandomNumber置於for迴圈內，第二次執行迴圈才會是不同的值
                int index = (int)(RandomNumber * AssumeLength); // 將引數設定為會隨著假設之陣列長度的縮減而縮小
                Console.Write(Lunch[index]);
                Console.WriteLine(" 引數為: " + index);
                Console.WriteLine();
                {
                    string cache = Lunch[index]; // 備份已叫出的陣列資料儲存到cache變數中
                    Lunch[index] = Lunch[AssumeLength - 1]; // 將陣列中最後一個位置的資料取代已被叫出的資料
                    Lunch[AssumeLength - 1] = cache; // 把儲存在cache變數中的備份資料還原至陣列中的最後一個位置
                }
                AssumeLength -= 1; //縮減假設陣列之長度
            }
        }
    }
}
