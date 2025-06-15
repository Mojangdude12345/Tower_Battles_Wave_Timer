using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Battles_Wave_Timer
{
    static class WaveInfo
    {
        // This is an abomination... 
        public static readonly string[] WaveZombies =
        [
            "",
                "6-7 Normal",
                "11-12 Normal",
                "7-8 Speedy",
                "6 Normal" + Environment.NewLine + "12 Speedy",
                "7-8 Slow",
                "15 Normal" + Environment.NewLine + "5 Speedy",
                "5 Normal" + Environment.NewLine + "5 Speedy" + Environment.NewLine + "8 Slow",
                "5 Normal" + Environment.NewLine + "6 Speedy" + Environment.NewLine + "5 Slow" + Environment.NewLine + "1 Boss1",
                "20 Slow",
                "7-8 Hidden",
                "8 Slow" + Environment.NewLine + "2 Boss1",
                "10 Hidden",
                "10 Mystery",
                "5 Slow" + Environment.NewLine + "2 Boss1" + Environment.NewLine + "8 Speedy" + Environment.NewLine + "1 Necromancer",
                "20 Mystery",
                "20 Slow",
                "4 Mystery" + Environment.NewLine + "2 Speedy" + Environment.NewLine + "2 Hidden" + Environment.NewLine + "2 Normal" + Environment.NewLine + "2 Slow" + Environment.NewLine + "9 Mystery" + Environment.NewLine + "2 Boss1" + Environment.NewLine + "1 Necromancer" + Environment.NewLine + "1 Boss2",
                "4 Boss1" + Environment.NewLine + "1 Necromancer" + Environment.NewLine + "6 Mystery",
                "4 Slow" + Environment.NewLine + "10 Lava" + Environment.NewLine + "1 Boss1",
                "15 Mystery" + Environment.NewLine + "4 Hidden" + Environment.NewLine + "2 Boss1" + Environment.NewLine + "5 Lava",
                "6 Hidden" + Environment.NewLine + "5 Lava" + Environment.NewLine + "8 Mystery" + Environment.NewLine + "8 Boss1" + Environment.NewLine + "1 Boss2",
                "6 Hidden" + Environment.NewLine + "1 Boss2" + Environment.NewLine + "1 Hidden Boss" + Environment.NewLine + "12 Lava",
                "6 Toxic" + Environment.NewLine + "2 Boss1" + Environment.NewLine + "4 Toxic" + Environment.NewLine + "1 Boss2" + Environment.NewLine + "4 Mystery" + Environment.NewLine + "2 Hidden Boss" + Environment.NewLine + "1 Necromancer",
                "4 Boss1" + Environment.NewLine + "1 Hidden Boss" + Environment.NewLine + "6 Lava" + Environment.NewLine + "2 Hidden Boss" + Environment.NewLine + "1 Boss2",
                "10 Lava" + Environment.NewLine + "5 Toxic" + Environment.NewLine + "3 Boss1" + Environment.NewLine + "1 Boss2" + Environment.NewLine + "8 Lightning" + Environment.NewLine + "2 Necromancer",
                "6 Slime",
                "2 Boss2" + Environment.NewLine + "10 Lightning" + Environment.NewLine + "1 Boss2" + Environment.NewLine + "6 Toxic" + Environment.NewLine + "1 Boss1" + Environment.NewLine + "9 Lightning",
                "3 Slime" + Environment.NewLine + "1 Boss2" + Environment.NewLine + "1 Hidden Boss" + Environment.NewLine + "8 Lightning" + Environment.NewLine + "1 Hidden Boss" + Environment.NewLine + "4 Lightning" + Environment.NewLine + "1 Hidden Boss" + Environment.NewLine + "1 Necromancer",
                "4 Lightning" + Environment.NewLine + "1 Boss2" + Environment.NewLine + "1 Slime" + Environment.NewLine + "4 Lightning" + Environment.NewLine + "2 Toxic" + Environment.NewLine + "15 Mystery" + Environment.NewLine + "1 Boss2" + Environment.NewLine + "2 Toxic" + Environment.NewLine + "4 Slime" + Environment.NewLine + "16 Mystery2" + Environment.NewLine + "3 Necromancer" + Environment.NewLine + "2 Hidden Boss",
                "1 Boss2" + Environment.NewLine + "12 Lightning" + Environment.NewLine + "6 Mystery2" + Environment.NewLine + "3 Boss1" + Environment.NewLine + "9 Slime" + Environment.NewLine + "2 Boss1" + Environment.NewLine + "6 Mystery2",
                "2 Normal" + Environment.NewLine + "2 Speedy" + Environment.NewLine + "3 Slow" + Environment.NewLine + "3 Hidden Boss" + Environment.NewLine + "8 Mystery" + Environment.NewLine + "10 Lightning" + Environment.NewLine + "5 Lava" + Environment.NewLine + "2 Boss1" + Environment.NewLine + "1 Necromancer" + Environment.NewLine + "5 Toxic" + Environment.NewLine + "2 Boss2" + Environment.NewLine + "2 Hidden Boss" + Environment.NewLine + "2 Slime" + Environment.NewLine + "10 Mystery2",
                "6 Boss2" + Environment.NewLine + "2 Boss3" + Environment.NewLine + "8 Lightning" + Environment.NewLine + "12 Mystery2" + Environment.NewLine + "2 Necromancer" + Environment.NewLine + "5 Hidden Boss",
                "1 Boss3" + Environment.NewLine + "2 Hidden Boss" + Environment.NewLine + "10 Mystery" + Environment.NewLine + "4 Boss3" + Environment.NewLine + "14 Mystery2",
                "1 Boss2" + Environment.NewLine + "5 Boss3" + Environment.NewLine + "12 Lightning" + Environment.NewLine + "12 Mystery2" + Environment.NewLine + "3 Necromancer" + Environment.NewLine + "3 Boss1" + Environment.NewLine + "5 Boss3" + Environment.NewLine + "9 Hidden Boss",
                "2 Boss1" + Environment.NewLine + "4 Boss2" + Environment.NewLine + "3 Boss3" + Environment.NewLine + "10 Lightning" + Environment.NewLine + "8 Slime" + Environment.NewLine + "10 Mystery2" + Environment.NewLine + "1 Necromancer" + Environment.NewLine + "3 Boss3" + Environment.NewLine + "1 Boss4" + Environment.NewLine + "1 Necromancer" + Environment.NewLine + "8 Mystery2",
                "7 Lightning" + Environment.NewLine + "10 Mystery2" + Environment.NewLine + "2 Boss3" + Environment.NewLine + "5 Lava" + Environment.NewLine + "2 Boss3" + Environment.NewLine + "5 Lava" + Environment.NewLine + "2 Boss3" + Environment.NewLine + "8 Lightning" + Environment.NewLine + "10 Mystery2" + Environment.NewLine + "2 Necromancer" + Environment.NewLine + "1 Boss4" + Environment.NewLine + "4 Lightning" + Environment.NewLine + "1 Boss4" + Environment.NewLine + "5 Lightning" + Environment.NewLine + "2 Boss4" + Environment.NewLine + "5 Lightning" + Environment.NewLine + "2 Boss3",
                "4 Boss3" + Environment.NewLine + "12 Lightning" + Environment.NewLine + "2 Hidden Boss" + Environment.NewLine + "3 Boss4" + Environment.NewLine + "6 Lightning" + Environment.NewLine + "1 Boss4" + Environment.NewLine + "4 Necromancer" + Environment.NewLine + "1 Necromancer Boss" + Environment.NewLine + "2 Boss3",
                "6 Hidden Boss" + Environment.NewLine + "5 Boss3" + Environment.NewLine + "5 Mystery2" + Environment.NewLine + "1 Boss4" + Environment.NewLine + "5 Mystery2" + Environment.NewLine + "1 Boss4" + Environment.NewLine + "5 Mystery2" + Environment.NewLine + "1 Boss4" + Environment.NewLine + "10 Mystery2" + Environment.NewLine + "4 Boss3" + Environment.NewLine + "1 Necromancer Boss" + Environment.NewLine + "2 Boss3",
                "10 Mystery2" + Environment.NewLine + "5 Boss4" + Environment.NewLine + "12 Hidden Boss" + Environment.NewLine + "3 Boss4" + Environment.NewLine + "6 Boss3" + Environment.NewLine + "1 Boss4" + Environment.NewLine + "10 Mystery2" + Environment.NewLine + "3 Necromancer Boss",
                "3 Boss3" + Environment.NewLine + "4 Boss2" + Environment.NewLine + "2 Boss3" + Environment.NewLine + "6 Boss4" + Environment.NewLine + "10 Mystery2" + Environment.NewLine + "1 Boss4" + Environment.NewLine + "2 Hidden Boss" + Environment.NewLine + "2 Boss4" + Environment.NewLine + "6 Mystery2" + Environment.NewLine + "6 Boss3" + Environment.NewLine + "2 Guardian" + Environment.NewLine + "1 Void" + Environment.NewLine + "2 Boss3" + Environment.NewLine + "15 Mystery2" + Environment.NewLine + "1 Boss4" + Environment.NewLine + "Necromancer Boss" + Environment.NewLine + "5 Hidden Boss" + Environment.NewLine + "8 Boss3" + Environment.NewLine + "20 Lightning" + Environment.NewLine + "24 Mystery2" + Environment.NewLine + "3 Boss3" + Environment.NewLine + "∞ Endbringer"
        ];
    }
}
