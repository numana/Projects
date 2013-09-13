using System;
using System.Collections.Generic;

namespace HotelReservations.Models {
  //TODO: Move helper classes (RoomType, PriceList) to own files
  public enum RoomType : short {
    Regular, Suite
  }

  public static class PriceList {
    internal static decimal RoomPrice(RoomType roomType) {
      return roomType == RoomType.Regular ? 10 : 15;
    }
  }

  public class Room {
    public int Number { get; set; }
    public RoomType RoomType { get; set; }
    public Decimal Price { get { return PriceList.RoomPrice(RoomType); } }

    public List<DateTime> Reservations { get; set; }

    public Room() {
      Reservations = new List<DateTime>();
      RoomType = RoomType.Regular;
    }

  }
}
