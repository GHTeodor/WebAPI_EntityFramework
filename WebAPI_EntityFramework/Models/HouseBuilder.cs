namespace WebAPI_EntityFramework.Models;

public class HouseBuilder
{
    public House House = new House();

    public HouseBuilder addRoom(int quantity = 1)
    {
        this.House.Rooms += quantity;
        return this;
    }

    public HouseBuilder addFloor(int quantity = 1)
    {
        this.House.Floor += quantity;
        return this;
    }

    public House build()
    {
        return this.House;
    }
}