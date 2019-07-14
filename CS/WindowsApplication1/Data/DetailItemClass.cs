using System;

namespace WindowsApplication1 {
    public class DetailItemClass {
        public DetailItemClass(TimeSpan val1, int val2, int pID) {
            this.ParentID = pID;
            this.TimeStamp = val1;
            this.Value = val2;
        }
        public int ParentID { get; set; }
        public TimeSpan TimeStamp { get; set; }
        public int Value { get; set; }

    }
}
