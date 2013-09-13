using System;
using System.Collections.Generic;
using System.Linq;
using System.Monads;

namespace HotelReservations.Models {

  public class Hotel {

    //private readonly IList<Room> _rooms = null;
    public IList<Room> Rooms { get; set; }

    public Hotel(Room[] rooms) {
      Rooms = rooms;
    }

    //TODO: Refactor room into class private property to use in BookRoom, IsRoomAvailable:
    public bool BookRoom(int roomNumber, DateTime bookDate) {
      return IsRoomAvailable(roomNumber, bookDate) && Rooms.FirstOrDefault(r => r.Number == roomNumber).Do(r => r.Reservations.Add(bookDate)) != null;
    }

    public bool IsRoomAvailable(int roomNumber, DateTime bookDate) {
      return !Rooms.FirstOrDefault(r => r.Number == roomNumber).Reservations.Any(r => r == bookDate);
    }

    public Room Room(int roomNumber) {
      return Rooms.FirstOrDefault(r => r.Number == roomNumber);
    }

  }
}
