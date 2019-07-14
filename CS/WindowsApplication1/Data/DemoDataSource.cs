using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApplication1 {
    public class DemoDataSource {
        public List<ParentItemClass> GetData() {
            List<ParentItemClass> masterItems = new List<ParentItemClass>();
            masterItems.Add(new ParentItemClass("Row1", 1));
            masterItems.Add(new ParentItemClass("Row2", 2));
            masterItems.Add(new ParentItemClass("Row3", 3));
            masterItems.Add(new ParentItemClass("Row4", 4));
            masterItems.Add(new ParentItemClass("Row5", 5));
            masterItems[0].DetailItems.Add(new DetailItemClass(TimeSpan.FromHours(8), 10, 1));
            masterItems[0].DetailItems.Add(new DetailItemClass(TimeSpan.FromHours(8.5),11,1));
            masterItems[0].DetailItems.Add(new DetailItemClass(TimeSpan.FromHours(9),12,1));
            masterItems[1].DetailItems.Add(new DetailItemClass(TimeSpan.FromHours(8),10,2));
            masterItems[1].DetailItems.Add(new DetailItemClass(TimeSpan.FromHours(8.5),11,2));
            masterItems[1].DetailItems.Add(new DetailItemClass(TimeSpan.FromHours(9),12,2));
            masterItems[1].DetailItems.Add(new DetailItemClass(TimeSpan.FromHours(9.5),13,2));
            masterItems[2].DetailItems.Add(new DetailItemClass(TimeSpan.FromHours(8),10,3));
            masterItems[2].DetailItems.Add(new DetailItemClass(TimeSpan.FromHours(8.5),11,3));
            masterItems[2].DetailItems.Add(new DetailItemClass(TimeSpan.FromHours(9),12,3));
            masterItems[2].DetailItems.Add(new DetailItemClass(TimeSpan.FromHours(9.5),13,3));
            masterItems[2].DetailItems.Add(new DetailItemClass(TimeSpan.FromHours(10),13,3));            
            masterItems[3].DetailItems.Add(new DetailItemClass(TimeSpan.FromHours(8),10,4));
            masterItems[3].DetailItems.Add(new DetailItemClass(TimeSpan.FromHours(8.5),11,4));
            masterItems[3].DetailItems.Add(new DetailItemClass(TimeSpan.FromHours(9),12,4));
            masterItems[3].DetailItems.Add(new DetailItemClass(TimeSpan.FromHours(9.5),13,4));
            masterItems[3].DetailItems.Add(new DetailItemClass(TimeSpan.FromHours(10),13,4));
            masterItems[3].DetailItems.Add(new DetailItemClass(TimeSpan.FromHours(10.5),13,4));
            masterItems[4].DetailItems.Add(new DetailItemClass(TimeSpan.FromHours(8),10,5));
            masterItems[4].DetailItems.Add(new DetailItemClass(TimeSpan.FromHours(8.5),11,5));
            masterItems[4].DetailItems.Add(new DetailItemClass(TimeSpan.FromHours(9),12,5));
            masterItems[4].DetailItems.Add(new DetailItemClass(TimeSpan.FromHours(9.5),13,5));
            masterItems[4].DetailItems.Add(new DetailItemClass(TimeSpan.FromHours(10),13,5));
            masterItems[4].DetailItems.Add(new DetailItemClass(TimeSpan.FromHours(10.5),13,5));
            masterItems[4].DetailItems.Add(new DetailItemClass(TimeSpan.FromHours(11),13,5));
            return masterItems;
        }
    }
}
