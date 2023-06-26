using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Abstract
{
    public class Letter
    {
        public Sprite letterSprite { get; private set; }
        public string name { get; private set; }
        public string[] pages { get; private set; }
        public Letter(Sprite letterSprite, string name, string[] pages) 
        {
            this.letterSprite = letterSprite;
            this.name = name;
            this.pages = pages;
        }
    }
}
