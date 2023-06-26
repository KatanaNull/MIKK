using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Abstract
{
    public class Item
    {
        public Sprite ItemSprite { get; private set; }
        public string Name { get; private set; }
        public string description { get; private set; }
        public string fullDescription { get; private set; }

        public Item(Sprite itemSprite, string name, string description, string fullDescription) 
        {
            this.ItemSprite = itemSprite;
            this.Name = name;
            this.description = description;
            this.fullDescription = fullDescription;
        }
    }
}
