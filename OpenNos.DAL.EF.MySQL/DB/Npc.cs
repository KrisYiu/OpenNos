//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenNos.DAL.EF.MySQL.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Npc
    {
        public short NpcId { get; set; }
        public string Name { get; set; }
        public short Vnum { get; set; }
        public short Dialog { get; set; }
        public short MapId { get; set; }
        public short MapX { get; set; }
        public short MapY { get; set; }
        public short Position { get; set; }
        public short Level { get; set; }
    
        public virtual Map map { get; set; }
    }
}