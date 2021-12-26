using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_patika_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();
            Introduction();

            // switch&case
            var userInput = Option();
            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        phoneBook.newContactAdd();
                        Introduction();
                        userInput = Option();
                        break;
                    case "2":
                        phoneBook.ContactDelete();
                        Introduction();
                        userInput = Option();
                        break;
                    case "3":
                        phoneBook.ContactUpdate();
                        Introduction();
                        userInput = Option();
                        break;
                    case "4":
                        phoneBook.DisplayAllContact();
                        Introduction();
                        userInput = Option();
                        break;
                    case "5":
                        phoneBook.DisplayMatchingContacts();
                        Introduction(); 
                        userInput = Option();
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Lütfen Geçerli Bir İşlem Seçiniz!");
                        break;
                }
            }
        }
        private static string Option()
        {
            return Console.ReadLine();
        }
        private static void Introduction()
        {
            Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçin!");
            Console.WriteLine("****************************************");
            Console.WriteLine("1-) Yeni Numara Kaydet");
            Console.WriteLine("2-) Numara Sil");
            Console.WriteLine("3-) Numara Güncelle");
            Console.WriteLine("4-) Rehberi Listele");
            Console.WriteLine("5-) Rehberde Arama Yap");
            Console.WriteLine("Çıkmak için 'x' bas!");
        }
    }
}