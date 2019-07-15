using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsApplication1 {
    public class ParentItemClass {
        public ParentItemClass(string name, int id) {
            ItemName = name;
            ItemID = id;
        }
        public string ItemName { get; set; }
        public int ItemID { get; set; }
        public List<DetailItemClass> DetailItems { get; set; } = new List<DetailItemClass>();
    }
}
