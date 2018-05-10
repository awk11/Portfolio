using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class Project
    {
        public List<string> MediaRefs { get; set; }

        public string TileRef { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<string> SkillList { get; set; }

        public Project(string name, string tileRef ,string description)
        {
            Name = name;
            Description = description;
            TileRef = tileRef;
            SkillList = new List<string>();
            MediaRefs = new List<string>();
        }
    }
}