using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class Room
    {
        public string RoomNumber { get; set; }
        public bool IsBooked { get; private set; }

        //public Room(bool isBooked)
        //{
        //    IsBooked = isBooked;
        //}

        public void BookRoom()
        {
            if (!IsBooked)
            {
                IsBooked = true;
                Console.WriteLine($"Room {RoomNumber} is booked");
            }
            else
            {
                Console.WriteLine($"Room {RoomNumber} is already booked");
            }
        }

        public void UnBookRoom()
        {
            if (IsBooked)
            {
                IsBooked = false;
                Console.WriteLine($"Room {RoomNumber} has been unbooked");
            }
            else
            {
                Console.WriteLine($"Room {RoomNumber} is not booked yet");
            }
        }


        private readonly ConcurrentDictionary<string, string> _store = new();
        public string GenerateOtp(string phoneNumber)
        {
            var otp = new Random().Next(100000, 999999).ToString();
            _store[phoneNumber] = otp;
            Console.WriteLine($"[Mock OTP] {otp} -> {phoneNumber}");
            return otp;
        }


        public bool VerifyOtp(string phoneNumber, string otp)
        {
            if (!_store.TryGetValue(phoneNumber, out var current)) return false;
            if (current == otp) { _store.TryRemove(phoneNumber, out _); return true; }
            return false;
        }
    }
}
