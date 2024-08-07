using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinif
{
    public class Person
    {
        public string ad;
        public string soyad;
        




        public string Ad
        {
            get { return ad; }
            set { ad = value; }

        }





        public void Goster()
        {
            Console.WriteLine($" bu ogrencinin adı{ad} soyadı {soyad} ve dogum tarihi");



        }







}
}
