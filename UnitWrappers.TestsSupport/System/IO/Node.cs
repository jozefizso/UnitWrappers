using System.Collections.Generic;
using System.IO;

namespace UnitWrappers.TestsSupport.System.IO
{
    internal class Node
    {


        public Node(string name, FileAttributes attrs)
        {
            Attributes = attrs;
            Name = name;
            Parents = new HashSet<Node>();
            Contains = new HashSet<Node>();
        }

        public string Name { get; set; }
        public FileAttributes Attributes { get; set; }
        public HashSet<Node> Parents { get; set; }
        public HashSet<Node> Contains { get; set; }

        public void AddContent(Node node)
        {
            Contains.Add(node);
        }



        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }
    }
}