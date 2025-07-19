using System;
using System.Data;
using System.Reflection;
using System.Xml.Linq;

class Zork
{
    static void Main(string[] args)
    {
        //1. search rooms, inventory
        //bool south, bool north, bool west, bool east, string description

        //bool south, bool north, bool west, bool east
        // string description, string key, string locked
        Room r01 = new Room(true, false, false, true, "The room is small, lit only by a candle. There is a cabinet in the corner.",
        "", "", new POI("cabinet", "You slowly open the cabinet. Inside you find a note!", new Item("note", "letter", "The note reads: Great job! Continue to search rooms as such to find useful items.")));

        Room r02 = new Room(true, false, true, false, "The room is barren. Containing only the sound of water dripping onto the cobblestone floor.",
        "", "");

        Room r03 = new Room(false, false, false, true, "The walls are lined with torches, on the far wall you see a chest!",
        "", "", new POI("chest", "As you open the chest a golden light bathes the dark cobblestone walls. Inside you see the source is a beautiful Golden Key."
        , new Key("key", "GoldenKey", "The key shines with a golden light.", "s")));

        Room r04 = new Room(true, false, true, false, "You are at the end of a long hallway, you see a golden light shinning on the west end.", "", "");

        Room r11 = new Room(true, true, false, false, "The room is filled skeltons of unknown beings.", "", "");

        Room r12 = new Room(false, true, false, true, "In the corner of the room you see an Orc!", "", "", new Enemy("Orc", 2, 2,
        "The Orc lays motionless on the ground in a puddle of green blood.", new Weapon("weapon", "Dagger", "Its steel blade shines a dangerous glow.", 3)));

        Room r13 = new Room(true, false, true, false, "You are at the north end of a long hallway. In the corner you see a basket shining with a red glow.",
        "", "", new POI("basket", "As you peer in the basket you see a glass bottle filled with a mysterious red liquid!",
        new Potion("potion", "potion", "A glass bottle filled with a mysterious red liquid. Use to restore your health.")));
        Room r14 = new Room(true, false, false, false, "The room is filled with rats! They nibble at your feet. Perhaps cute?", "RustedKey", "n");

        Room r21 = new Room(false, true, false, false, "The room is bathed in the light of a red exit sign about the south door.\nYou wonder what kind of witchcraft is used to illuminate it.", "GoldenKey", "s");

        Room r22 = new Room(true, false, false, false, "At the center of the room stands a dangerous looking orc in makeshift armor.", "", "",
        new Enemy("Armored Orc", 2, 10, "At the center of the dark room lays the corpse of the armored orc. \nDespite being dead, its presence still fills you with fear.", new Key("key", "RustedKey", "A rusted iron key.", "n")));

        Room r23 = new Room(true, true, false, true, "There is nothing in this room but options to go.", "", "");

        Room r24 = new Room(false, true, true, false, "You are in the south end of a long hallway. You hear the faint sound pattering.", "", "");

        Room r31 = new Room(false, true, false, false, "", "", "");

        Room r32 = new Room(false, true, false, true, "The room is dark and gloomy. You see nothing but desk in the center of the room.", "", "",
        new POI("desk", "As you slowly open one of the drawers in the desk a fowl stench assualts you. Inside you find a pile of poop!",
        new Item("item", "Poop", "After your many battles, you can't tell if the smell is coming from this or your own pants.")));

        Room r33 = new Room(false, true, true, true, "The room is filled with makeshift beds. A small fire in the corner fills the room with a smoky smell.",
        "", "");

        Room r34 = new Room(false, false, true, false, "The room echoes with a deep growl. As you look around you spot a large Warg!", "", "",
        new Enemy("Warg", 2, 6, "The room is empty, decorated only by the corpse of the slain beast."
        , new Potion("potion", "potion", "A glass bottle filled with a mysterious red liquid. Use to restore your health.")));


        List<List<Room>> map = new List<List<Room>>();
        map.Add(new List<Room>() { r01, r02, r03, r04 });
        map.Add(new List<Room>() { r11, r12, r13, r14 });
        map.Add(new List<Room>() { r21, r22, r23, r24 });
        map.Add(new List<Room>() { r31, r32, r33, r34 });
        bool running = true;
        int col = 0;
        int row = 0;
        Room currentRoom;

        Character player = new Character();

        List<Item> inventoryList = new List<Item>();
        Inventory inventory = new Inventory(inventoryList);

        List<Room> visited = new List<Room>();

        // and an inspect for room directions
        //add help for command list
        Animations.Type("Welcome to ZORK! Kill your enemys, find the hidden keys, and escape to win!");
        Animations.Type("Type \"help\" for a list of commands.");
        while (running)
        {
            currentRoom = map[row][col];
            if (visited.IndexOf(currentRoom) == -1)
            {
                visited.Add(currentRoom);
                Animations.Type(currentRoom.GetDescription());
            }
            if (currentRoom == r31)
            {
                Animations.Type("Congratulations adventurer! You have escaped!");
                running = false;
            }
            string command = Console.ReadLine();
            if (command == "north")
            {
                if (currentRoom.MoveRoom(command))
                {
                    row -= 1;
                    Animations.Type("You have moved north!");
                }
                else
                {
                    Animations.Type("Sorry you can't go that way.");
                }
            }
            else if (command == "south")
            {
                if (currentRoom.MoveRoom(command))
                {
                    row += 1;
                    Animations.Type("You have moved south!");
                }
                else
                {
                    Animations.Type("Sorry you can't go that way.");
                }
            }
            else if (command == "west")
            {
                if (currentRoom.MoveRoom(command))
                {
                    col -= 1;
                    Animations.Type("You have moved west!");
                }
                else
                {
                    Animations.Type("Sorry you can't go that way.");
                }
            }
            else if (command == "east")
            {
                if (currentRoom.MoveRoom(command))
                {
                    col += 1;
                    Animations.Type("You have moved east!");
                }
                else
                {
                    Animations.Type("Sorry you can't go that way.");
                }
            }
            else if (command == "quit")
            {
                running = false;
            }
            else if (command == "search" || command.IndexOf(" ") != -1 && command.Substring(0, command.IndexOf(" ")) == "search")
            {
                Item check = map[row][col].Search(command);
                if (check != null)
                {
                    inventory.AddItem(check, player);
                    Animations.Type($"You have picked up, {check.GetName()}!");
                    currentRoom.GivePOI().Empty();
                }
            }
            else if (command == "display")
            {
                player.Display();
                inventory.Display();
            }
            else if (command.IndexOf(" ") != -1 && command.Substring(0, command.IndexOf(" ")) == "use")
            {
                string itemUse = command.Substring(command.IndexOf(" ") + 1);
                Console.WriteLine(itemUse);
                Item i = inventory.UseWhat(itemUse);
                if (i != null)
                {
                    i.UseItem(currentRoom, player);
                    if (i.GetItemType() == "potion")
                    {
                        inventory.RemoveItem(i);
                    }
                }
            }
            else if (command == "attack")
            {
                if (currentRoom.GetEnemy() == false)
                {
                    Animations.Type("There is no enemy for you to fight.");
                }
                else
                {
                    Animations.Type($"You attack for {player.GetDamage()} damage!");
                    currentRoom.GiveEnemy().TakeDamage(player.GetDamage());
                    Animations.Type($"The {currentRoom.GiveEnemy().GetName()} deals you {currentRoom.GiveEnemy().GetDamage()} damage!");
                    player.TakeDamage(currentRoom.GiveEnemy().GetDamage());
                    if (player.GetHealth() <= 0)
                    {
                        running = false;
                    }
                    else if (currentRoom.GiveEnemy().GetHealth() <= 0)
                    {
                        Animations.Type("You have slain your foe!");
                        if (currentRoom.GiveEnemy().Death() != null)
                        {
                            inventory.AddItem(currentRoom.GiveEnemy().Death(), player);
                            Animations.Type($"You have picked up, {currentRoom.GiveEnemy().Death().GetName()}!");
                        }
                        currentRoom.ChangeDes(currentRoom.GiveEnemy().GetDescription());
                        currentRoom.KillEnemy();
                    }
                    else
                    {
                        Animations.Type("What will you do next?");
                    }

                }
            }
            else if (command == "inspect")
            {
                currentRoom.Inspect();
            }
            else if (command == "help")
            {
                Animations.Type("Command List: ");
                Console.WriteLine("\"south\": Moves you south.");
                Thread.Sleep(35);
                Console.WriteLine("\"north\": Moves you north.");
                Thread.Sleep(35);
                Console.WriteLine("\"west\": Moves you west.");
                Thread.Sleep(35);
                Console.WriteLine("\"east\": Moves you east");
                Thread.Sleep(35);
                Console.WriteLine("\"search\": Searches the room.");
                Thread.Sleep(35);
                Console.WriteLine("\"search (object name)\": Search a specific area of the room you are in.");
                Thread.Sleep(35);
                Console.WriteLine("\"attack\": Attack enemy(Careful! They'll hit back!)");
                Thread.Sleep(35);
                Console.WriteLine("\"use (item name)\": Use item located in your inventory.");
                Thread.Sleep(35);
                Console.WriteLine("\"display\": Displays your stats and inventory.");
                Thread.Sleep(35);
                Console.WriteLine("\"inspect\": See what directions you can go.");
                Thread.Sleep(35);
                Console.WriteLine("\"quit\": Exits game. Careful! Your progress will not be saved.");
                Thread.Sleep(35);
            }
            else
            {
                Animations.Type("Sorry that is not a proper command.");
            }
        }

    }
}






// ideas: add enemys, dice based fighting system with GUI, make a function the prints sentence letter by letter