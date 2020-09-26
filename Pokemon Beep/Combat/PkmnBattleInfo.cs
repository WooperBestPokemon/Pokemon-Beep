using Pokemon_Beep.Pokemon;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Combat
{
    class PkmnBattleInfo
    {
        public PkmnBattleInfo(PocketMonster pokemon)
        { 
            Pokemon = pokemon; 
        }
        public PocketMonster Pokemon { get; }
        public bool Tormented { get; set; }
        public int Taunted { get; set; }
        public bool Blocked { get; set; }
        public bool Stunned { get; set; }
        public bool Leeched { get; set; }
        public bool Protected { get; set; }
        public bool Endure { get; set; }
        public bool Attracted { get; set; }
        public bool MustRecharge { get; set; }
        public bool Airborne { get; set; }
        public bool Underground { get; set; }
        public int Confused { get; set; }
        public int Sleepy { get; set; }
        public int Encore { get; set; }
        public int Stormed { get; set; }
        public int Trapped { get; set; }
        //Other Info
        public bool tookDamage { get; set; }
    }
}
