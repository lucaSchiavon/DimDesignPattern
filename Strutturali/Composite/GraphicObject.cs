using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Strutturali.Composite
{
    public class GraphicObject
    {
        private Lazy<List<GraphicObject>> children = new Lazy<List<GraphicObject>>();
        //viene creata una istanza dell'oggetto lazy...:(children.Value)
        
        //public List<GraphicObject> Children => children.Value;
 
        public List<GraphicObject> Children
        {
            get { return children.Value; }
            
        }

        public virtual string Name { get; set; } = "Group";



        ////equivalente?
        //private string _name2="Group";
        //public virtual string Name2
        //{
        //    get
        //    { return _name2; }
        //    set
        //    { _name2 = value; }
        //}


        ////Equivalente?
        //private string _name3 = "Group";
        //public string Name3
        //{ get => _name3;
        //  set => _name3 = value;
        //}



        public string Color;
        //todo: members...:

        private void Print(StringBuilder sb, int depth)
        {
            //qui vengono realmente istanziati gli oggetti lazy
            sb.Append(new string('*', depth))
                .Append(string.IsNullOrWhiteSpace(Color) ? string.Empty : $"{Color}")
                .AppendLine($"{Name}");

            foreach (var child in Children)
            {
                child.Print(sb, depth + 1);
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            Print(sb, 0);
            return sb.ToString();
        }
    }
}
