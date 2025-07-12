using System;

class Zork
{
    static void Main(string[] args)
    {
        //1. Room class 2. Make a 2d array filled with rooms 3. Code the ability To move through the rooms
        //bool south, bool north, bool west, bool east, string description
        Room r01 = new Room(true, false, false, true, "");
        Room r02 = new Room(true, false, true, true, "");
        Room r03 = new Room(true, false, true, true, "");
        Room r04 = new Room(true, false, true, false, "");
        Room r11 = new Room(true, true, false, true, "");
        Room r12 = new Room(true, true, true, true, "");
        Room r13 = new Room(true, true, true, true, "");
        Room r14 = new Room(true, true, true, false, "");
        Room r21 = new Room(true, true, false, true, "");
        Room r22 = new Room(true, true, true, true, "");
        Room r23 = new Room(true, true, true, true, "");
        Room r24 = new Room(true, true, true, false, "");
        Room r31 = new Room(false, true, false, true, "");
        Room r32 = new Room(false, true, true, true, "");
        Room r33 = new Room(false, true, true, true, "");
        Room r34 = new Room(false, true, true, false, "");
        List<List<Room>> map = new List<List<Room>>();
        map.Add(new List<Room>() { r01, r02, r03, r04});
        map.Add(new List<Room>() { r11, r12, r13, r14});
        map.Add(new List<Room>() { r21, r22, r23, r24});
        map.Add(new List<Room>() { r31, r32, r33, r34});
        bool running = true;
        int col = 0;
        int row = 0;
        Room currentRoom;
        while (running)
        {
            currentRoom = map[row][col];
            Console.WriteLine($"You are in room {row} {col}");
            Console.WriteLine("What direction would you like to go? south/north/west/east");
            string dir = Console.ReadLine();
            if (dir == "north")
            {
                if (currentRoom.MoveRoom(dir))
                {
                    row -= 1;
                }
                else
                {
                    Console.WriteLine("Sorry you can't go that way.");
                }
            }
            else if (dir == "south")
            {
                if (currentRoom.MoveRoom(dir))
                {
                    row += 1;
                }
                else
                {
                    Console.WriteLine("Sorry you can't go that way.");
                }
            }
            else if (dir == "west")
            {
                if (currentRoom.MoveRoom(dir))
                {
                    col -= 1;
                }
                else
                {
                    Console.WriteLine("Sorry you can't go that way.");
                }
            }
            else if (dir == "east")
            {
                if (currentRoom.MoveRoom(dir))
                {
                    col += 1;
                }
                else
                {
                    Console.WriteLine("Sorry you can't go that way.");
                }
            }
            else
            {
                Console.WriteLine("Sorry that is not a command");
            }
        }

    }
}