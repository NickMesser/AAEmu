﻿namespace AAEmu.Game.Models.Game.Units
{
    public class Transfer : Unit
    {
        public new ushort TlId { get; set; }
        public uint TemplateId { get; set; }

        public override UnitCustomModelParams ModelParams { get; set; }
    }
}
