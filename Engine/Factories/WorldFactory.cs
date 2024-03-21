using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld() 
        {
            World newWorld = new World();

            newWorld.AddLocation(0, 2, "Utopia Corp", "Center of the City", "pack://application:,,,/Engine;component/Images/Locations/Utopia.jpg");
            newWorld.AddLocation(-1, 2, "Sun Park", "A Serene Green Park", "pack://application:,,,/Engine;component/Images/Locations/Park.jpg");
            newWorld.AddLocation(0, 3, "Highways", "Fast Lanes", "pack://application:,,,/Engine;component/Images/Locations/Highways.jpg");
            newWorld.AddLocation(0, 1, "Nexus", "The Heart of Quantum", "pack://application:,,,/Engine;component/Images/Locations/Nexus.jpg");
            newWorld.AddLocation(1, 2, "Cyber District", "The Augmented Skylines", "pack://application:,,,/Engine;component/Images/Locations/Cyberdistrict.jpg");
            newWorld.AddLocation(-1, 1, "Labyrinths", "Tunnels and Alleys", "pack://application:,,,/Engine;component/Images/Locations/Labyrinth.jpg");
            newWorld.AddLocation(-1, 0, "Nexopolis", "Urban Center", "pack://application:,,,/Engine;component/Images/Locations/851ca8423ebf587b1630d80e9f73c5e9.png");
            newWorld.AddLocation(0, 0, "Safehouse", "Refugee of the Mercenaries", "pack://application:,,,/Engine;component/Images/Locations/851ca8423ebf587b1630d80e9f73c5e9.png");
            newWorld.AddLocation(0, 4, "Pulse Hub", "The Market", "pack://application:,,,/Engine;component/Images/Locations/Pulse Hub.jpg");

            return newWorld;
        }
    }
}
