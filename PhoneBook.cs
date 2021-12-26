using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_patika_Task_2
{
    class PhoneBook                                             // 3. adım
    {
        List<Contact> _contacts = new List<Contact>();          // 4. adım

        // istemler arasında → 5 Kişilik Rehber
        public PhoneBook()                                      // 5. adım
        {
            _contacts.Add(new Contact("Ali", "Yılmaz", "05051111111"));
            _contacts.Add(new Contact("Ahmet", "Ozmus", "05052222222"));
            _contacts.Add(new Contact("Zuhal", "Ceylin", "05053333333"));
            _contacts.Add(new Contact("Ebrar", "Kuzik", "05054444444"));
            _contacts.Add(new Contact("Betül", "Yenilmez", "05054444444"));
        }

        // istemler arasında → Rehbere Numara Ekleme
        public void newContactAdd()                             // 6. adım
        {
            string name, lastname, number;

            Console.Write("Lütfen isim giriniz             :");
            name = Console.ReadLine();

            Console.Write("Lütfen soyisim giriniz          :");
            lastname = Console.ReadLine();

            Console.Write("Lütfen telefon numarası giriniz :");
            number = Console.ReadLine();

            _contacts.Add(new Contact(name, lastname, number));
            Console.WriteLine("\nKayıt işlemi gerçekleştirildi.");
        }

        // istemler arasında → Rehberden Numara Silme
        public void ContactDelete()                             // 7. adım
        {
            Console.WriteLine("\nLütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:   ");
            string _input = Console.ReadLine();

            foreach (var contact in _contacts)
            {
                if (contact.FirstName == _input || contact.LastName == _input)
                {
                    Console.Write("{0} isimli kişinin rehberden silinmesini onaylıyor musun?(E/H) : ", _input);
                    string _choice1 = Console.ReadLine();

                    if (_choice1 == "e" || _choice1 == "E")
                    {
                        _contacts.Remove(contact);
                        Console.WriteLine("Kişi silindi.");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.ReadLine();
                        break;
                    }
                }
            }
        }

        // istemler arasında → Rehberdeki Numaraları Güncelleme
        public void ContactUpdate()                             // 8. adım
        {
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:   ");
            string _input = Console.ReadLine();
            int _choice = 1;
            bool IsThere = false;
            foreach (var contact in _contacts)
            {
                if (contact.FirstName == _input || contact.LastName == _input)
                {
                    Console.WriteLine("Lütfen yeni numarayı giriniz :   ");
                    string newNumber = Console.ReadLine();
                    contact.Number = newNumber;
                    Console.WriteLine("Numara güncellendi!");
                    Console.ReadLine();
                    IsThere = true;
                    break;
                }
            }
            if (!IsThere)
            {
                Console.WriteLine("Aradığınız kişi bulunamadı! Lutfen bir secim yapiniz     : ");
                Console.WriteLine(" *Yeniden denemek icin  :(1)");
                Console.WriteLine(" *İşlemi sonlandırmak için: (2)");
                _choice = int.Parse(Console.ReadLine());

                if (_choice == 1)
                {
                    ContactUpdate();
                }
                else if (_choice == 2)
                {
                    Environment.Exit(0);
                }
            }
        }

        // istemler arasında → Rehberde Listele
        public void DisplayAllContact()                         // 9. adım
        {
            _contacts.Sort(delegate (Contact a1, Contact a2) { return a1.FirstName.CompareTo(a2.FirstName); });

            Console.WriteLine("A-Z -> (1)");
            Console.WriteLine("Z-A -> (2)");
            int _input = int.Parse(Console.ReadLine());

            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("*********************************");

            if (_input == 2)
                _contacts.Reverse();

            foreach (var contact in _contacts)
            {
                Console.WriteLine("isim: {0}", contact.FirstName);
                Console.WriteLine("Soyisim: {0}", contact.LastName);
                Console.WriteLine("Telefon Numarasi: {0}", contact.Number);
                Console.WriteLine("-");
            }
            Console.ReadLine();
        }


        // istemler arasında → Rehberde Arama Yap
        public void DisplayMatchingContacts()                   // 10. adım
        {
            Console.WriteLine("Lütfen aramak istediğiniz kişinin adını veya soyadını giriniz   : ");
            string nameandlastname = Console.ReadLine();
            bool IsThere = false;

            foreach (var contact in _contacts)
            {
                if (contact.FirstName == nameandlastname || contact.LastName == nameandlastname)
                {
                    Console.WriteLine("Isim :   {0}", contact.FirstName);
                    Console.WriteLine("Soyisim :   {0}", contact.LastName);
                    Console.WriteLine("Telefon Numarasi :   {0}", contact.Number);
                    Console.WriteLine("-");
                    IsThere = true;
                }
            }
            if (!IsThere)
            {
                Console.WriteLine("Aradığınız kişi bulunamadı!");
                Console.WriteLine(" *Yeniden denemek icin  :(1)");
                Console.WriteLine(" *İşlemi sonlandırmak için: (2)");

                int _choice2 = int.Parse(Console.ReadLine());

                if (_choice2 == 1)
                {
                    DisplayMatchingContacts();
                }
                else if (_choice2 == 2)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}