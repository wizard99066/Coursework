using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    public class Booking
    {
        DateTime DateOfIssue { get; set; } // дата выдачи
        DateTime ReturnDate { get; set; }//дата возврата
        string City { get; set; }
        string FullName { get; set; }
        long Phone { get; set; }
        Auto Auto { get; set; }


        public Booking(DateTime dateOfIssue, DateTime returnDate, string city, string fullName, long phone, Auto auto)
        {
            DateOfIssue = dateOfIssue;
            ReturnDate = returnDate;
            City = city;
            FullName = fullName;
            Phone = phone;
            Auto = auto;

            //Auto.ToBook();
        }

        public void GetInfo()
        {
            Console.WriteLine($"дата выдачи: {DateOfIssue} дата возврата: {ReturnDate} город: {City} ФИО: {FullName} Машина: {Auto.Name}, {Auto.Year}");
        }

        public void ToBook(Booking booking, List<Booking> bookingList)
        {
            if (bookingList.Any(r => r.Auto.Name == booking.Auto.Name && ((r.DateOfIssue <= booking.DateOfIssue && r.ReturnDate >= booking.DateOfIssue) || (r.DateOfIssue <= booking.ReturnDate && r.ReturnDate >= booking.ReturnDate))))
                throw new Exception("данная машина была ранее забронирована на эту дату");

            Auto.ToBook();
            Console.WriteLine($"вы забронировали автомобиль {Auto.Name}");
        }

    }
}