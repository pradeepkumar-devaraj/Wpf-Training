using System.Collections.Generic;

namespace WpfAppTraining
{

    public interface ITree
    {
        string Name { get; set; }
    }

    public class Leaf : ITree
    {
        public string Name { get; set; }
    }

    public class Parent : ITree
    {
        public string Name { get; set; }

        public List<ITree> Children { get; set; } = new List<ITree>();
    }

    public class TreeViewData
    {
        public List<ITree> Data { get; set; } = new List<ITree>();

        private Leaf l1 = new Leaf { Name = "L1" };
        private Leaf l2 = new Leaf { Name = "L2" };
        private Leaf l3 = new Leaf { Name = "L3" };
        private Leaf l4 = new Leaf { Name = "L4" };
        private Leaf l5 = new Leaf { Name = "L5" };
        private Leaf l6 = new Leaf { Name = "L6" };
        private Leaf l7 = new Leaf { Name = "L7" };
        private Leaf l8 = new Leaf { Name = "L8" };



        private Parent p1 = new Parent { Name = "P1" };
        private Parent p2 = new Parent { Name = "P2" };
        private Parent p3 = new Parent { Name = "P3" };
        private Parent p4 = new Parent { Name = "P4" };

        public TreeViewData()
        {
            p1.Children.Add(l1);
            p1.Children.Add(l2);
            p2.Children.Add(l3);
            p2.Children.Add(l4);
            p3.Children.Add(l5);
            p3.Children.Add(l6);
            p2.Children.Add(p3);
            p3.Children.Add(p4);
            p4.Children.Add(l7);
            p4.Children.Add(l8);

            Data.Add(p1);
            Data.Add(p2);

        }
    }
}
