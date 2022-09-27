using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;


namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList
            {
                2,"food",4.5f,null
            };
          //  arr.AddRange(arr);
            arr.Add("added");
            arr.Add(2345);
            arr.Remove(2);
            arr.RemoveAt(1);
            Console.WriteLine(arr.Contains("hfhfjjj"));
            // Generic
            //list<T>
            //arrays
            //sorted list
            //hash code
            SortedList slt = new SortedList
            {
                {1,"Hello" },
                {4, "Olajide" },
                {3, "Abdul Qahar" },

            };
            
           // if(slt.TryGetValue(4, out result)
            for (int i = 0; i < slt.Count; i++)
            {
                Console.WriteLine($"{slt.GetKey(i)}  {slt.GetByIndex(i)}");
               

            }
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
               // Console.WriteLine(arr[1]);
            }
            string str = "aaabbcbbaacc";
            SortedList slt2 = new SortedList();
            
                for(int i = 0; i < str.Length; i++)
            {
                if (slt2.ContainsKey(str[i]))
                {
                    var index = slt2.IndexOfKey(str[i]);
                    var value = (int) slt2.GetByIndex(index);
                    slt2.SetByIndex(index ,value+1);
                }
                else
                {
                    slt2.Add(str[i], 1);
                    
                }
            }
            for (int i = 0; i < slt2.Count; i++)
            {
                Console.WriteLine($"{slt2.GetKey(i)}  {slt2.GetByIndex(i)}");
            }
            // List<string>students = new List<string>students(){
            //     string a ="Olajide";
            //     string b="Tunde";
            //     string c="folake";

            // };
            // var d = students;
            // foreach (var e in d)
            // {
            //     Console.WriteLine(e);
            // }
            
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeGenerator.QRCode qrCode = qrGenerator.CreateQrCode(textBoxQRCode.Text, QRCodeGenerator.ECCLevel.Q);
            pictureBoxQRCode.BackgroundImage = qrCode.GetGraphic(20);
                
            
            
        }
    }
}
