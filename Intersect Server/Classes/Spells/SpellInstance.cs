﻿using Intersect;

namespace Intersect_Server.Classes.Spells
{
    public class SpellInstance
    {
        public long SpellCD = 0;
        public int SpellNum = -1;

        public SpellInstance()
        {
        }

        public SpellInstance(int num)
        {
            SpellNum = num;
        }

        public SpellInstance Clone()
        {
            SpellInstance newSpell = new SpellInstance()
            {
                SpellNum = SpellNum,
                SpellCD = SpellCD
            };
            return newSpell;
        }

        public void Load(ByteBuffer bf)
        {
            SpellNum = bf.ReadInteger();
        }

        public byte[] Data()
        {
            var bf = new ByteBuffer();
            bf.WriteInteger(SpellNum);
            return bf.ToArray();
        }
    }
}