using System.Linq;
using HotelReservations.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

//Airline / Hotel Reservation System
//Create a reservation system which books airline seats or hotel rooms.
//It charges various rates for particular sections of the plane or hotel.
//Example, first class is going to cost more than coach.
//Hotel rooms have penthouse suites which cost more.
//Keep track of when rooms will be available and can be scheduled.

namespace HotelReservations {

  [TestClass]
  public class HotelTest {

    private readonly Room[] _rooms = new Room[50];
    private readonly Hotel _hotel;

    public HotelTest() {
      //Init hotel rooms. Numbers 1-10 are suites, 11-50 are regular rooms
      for (int i = 0; i < 50; _rooms[i] = new Room { Number = i + 1, RoomType = i++ < 10 ? RoomType.Suite : RoomType.Regular }) { }
      _hotel = new Hotel(_rooms);
    }

    [TestMethod]
    public void BookingRoomResultsInRoomNotAvailableSameDay() {
      var bookDate = DateTime.Today + TimeSpan.FromDays(1);
      const short roomNumber = 10;

      //Check availability
      Assert.IsTrue(_hotel.IsRoomAvailable(roomNumber, bookDate));
      //Book room
      _hotel.BookRoom(roomNumber, bookDate);
      //Available no more
      Assert.IsFalse(_hotel.IsRoomAvailable(roomNumber, bookDate));
    }

    [TestMethod]
    public void SuiteCostsMoreThanRegularRoom() {
      var regular = _hotel.Rooms.FirstOrDefault(r => r.RoomType == RoomType.Regular);
      var suite = _hotel.Rooms.FirstOrDefault(r => r.RoomType == RoomType.Suite);

      Assert.IsTrue(suite.Price>regular.Price);
    }

  }
}