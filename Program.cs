using DesignPatternDimitri.Creazionali.Builder;
using DesignPatternDimitri.Creazionali.Singleton;
using DesignPatternDimitri.DepInvPrinciple;
using DesignPatternDimitri.OPC;
using DesignPatternDimitri.Strutturali.Adapter;
using DesignPatternDimitri.Strutturali.Bridge;
using DesignPatternDimitri.Strutturali.Composite;
using DesignPatternDimitri.Strutturali.Composite.NeuronExample;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;

namespace DesignPatternDimitri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Builder 

            ////first example
            //string[] Words =  { "hello", "World" };
            //HtmlElement Tag = new HtmlElement("ul", null);

            //foreach (string word in Words)
            //{
            //    Tag.Elements.Add(new HtmlElement("li", word));
            //}
            //Console.WriteLine(Tag);

            ////second example
            //var Builder = new HtmlBuilder("ul");
            //Builder.AddChild("li", "hello");
            //Builder.AddChild("li", "world");
            //Console.WriteLine(Builder.ToString());

            ////tird example (builder fluent)
            //var Builder3 = new HtmlBuilder("ul");
            //Builder3.AddChild("li", "hello").AddChild("li", "world");
            //Console.WriteLine(Builder3.ToString());

            ////fourth example
            //var Builder4 = HtmlElement.Create("ul");
            //Builder4.AddChild("li", "hello").AddChild("li", "world");
            //Console.WriteLine(Builder4.ToString());

            // //FIFTH EXAMPLE
            // HtmlElement root = HtmlElement
            //     .Create("ul")
            //     .AddChild("li", "hello")
            //     .AddChild("li", "world");
            // Console.WriteLine(root);

            // //sixth example with build
            // HtmlElement root2 = new HtmlBuilder("ul") 
            //    .AddChild("li", "hello")
            //    .AddChild("li", "world").Build();
            // Console.WriteLine(root2);

            // //composite builder
            // var pb = new PersonBuilder();
            //DesignPatternDimitri.Creazionali.Builder.Person person = pb
            //     .Lives
            //     .At("123 London Road")
            //     .In("London")
            //     .WithPostcode("sw2452");
            //.Works
            //.At("Fabrikan")
            //.(.....)

            //builder as a parameter
            var ms = new MailService();
            ms.SendEmail(BuildEmail);
            //qui passa un builder sottoforma di delegate che costruisce la mail
            //la vera costruzione dell'email avverrà però quando il delegate verrà invocato
            //dentro send mail
             ms.SendEmail(email => email.From("foo@bar.com"));

            //var apple = new Product("Apple", Color.Green, Size.Small);
            //var tree = new Product("Tree", Color.Green, Size.Large);
            //var tomato = new Product("Tomato", Color.Red, Size.Medium);
            //Product[] products = { apple, tree , tomato };
            //var bf = new BetterFilter();
            //IEnumerable<Product> Prods = bf.Filter(products, new ColorSpecification(Color.Green));
            //IEnumerable<Product> Prods2 = bf.Filter(products, 
            //    new AndSpecification<Product>
            //    (new ColorSpecification(Color.Green), new SizeSpecification(Size.Large)));

            //qui viene definito un operatore & custom nella classe astratta IFilter
            //che restituisce un AndSpecificationFilter
            //IEnumerable<Product> Prods2 = bf.Filter(products,
            //  new ColorSpecification(Color.Green) & new SizeSpecification(Size.Large));

            //Prods.ToList().ForEach(x=>Console.WriteLine(x.Name));
            //Prods2.ToList().ForEach(x => Console.WriteLine(x.Name));


            //DepInvPrinciple
            //var relationship = new Relationships();
            //var john = new DepInvPrinciple.Person("John");
            //relationship.AddParentAndChild(john, new DepInvPrinciple.Person("Mark"));
            //relationship.AddParentAndChild(john, new DepInvPrinciple.Person("Sue"));
            //relationship.AddParentAndChild(new DepInvPrinciple.Person("Carl"), new DepInvPrinciple.Person("Peggy"));
            //Research research = new Research(relationship);

            //DrawPoints();
            //DrawPointLazy();

            //property adapter
            //PropertyAdapter propertyAdapter = new PropertyAdapter();
            //propertyAdapter.CapitalsSerializable=new (string, string)[] { ("a", "test1"), ("b", "test2"), ("c", "test3") };
            //propertyAdapter.Capitals.Add("b", "test2");
            //propertyAdapter.Capitals.Add("c", "test3");

            //(string,string)[] a = propertyAdapter.CapitalsSerializable;
            //string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            //var directory = System.IO.Path.GetDirectoryName(path);
            //Program.SerializeToXml(propertyAdapter.CapitalsSerializable, directory + "CapitalsSerializable.XML");
            //Program.SerializeToXml(propertyAdapter.Capitals, directory + "Capitals.XML");


            //Bridge
            //var vector  = new VectorRender();
            //var circle = new Circle(vector, 5);
            //circle.Draw();
            //circle.Resize(2);
            //circle.Draw();

            //Composite
            //var drawing = new GraphicObject { Name = "My Drawing" };
            //drawing.Children.Add(new Square { Color = "red" });
            //drawing.Children.Add(new DesignPatternDimitri.Strutturali.Composite.Circle { Color = "yellow" });

            //var group = new GraphicObject();
            //group.Children.Add(new Square { Color = "blue" });
            //group.Children.Add(new DesignPatternDimitri.Strutturali.Composite.Circle { Color = "blue" });
            //drawing.Children.Add(group);

            ////gli oggetti aggiunti vengono realmente creati quando vengono scorsi per essere letti
            ////stiamo usando un approccio lazy
            //Console.WriteLine(drawing);

            //var neuron1 = new Neuron();
            //var neuron2 = new Neuron();
            //var layer1 = new NeuronLayer(3);
            //var layer2 = new NeuronLayer(4);

            //neuron1.ConnectTo(neuron2);
            //neuron1.ConnectTo(layer1);
            //layer2.ConnectTo(neuron1);
            //layer1.ConnectTo(layer2);

            //var neuron1 = new  Neuron();
            //var neuron2 = new Neuron();
            ////Ienumerable è una interfaccia e va istanziata con un tipo concreto
            //IEnumerable<Neuron> layer1 = new List<Neuron>() { new Neuron() , new Neuron()};
            //IEnumerable<Neuron> layer2 = new List<Neuron>() { new Neuron(), new Neuron() };

            //neuron1.ConnectTo(neuron2);
            //neuron1.ConnectTo(layer1);
            //layer2.ConnectTo(neuron1);
            //layer1.ConnectTo(layer2);

            //singleton
            //Database db = Database.Instance;



            // Type type = typeof(Addition);
            // ConstructorInfo ctor = type.GetConstructor(new[] { typeof(int) });
            // object instance = ctor.Invoke(new object[] { 10 });

            //var e= ((Addition)instance).Add(3 ,5);

            //Type type = typeof(Cache);

            //ConstructorInfo ctor = type.GetConstructor()
            //object instance = ctor.Invoke(new object[] { 10 });

            //var e = ((Addition)instance).Add(3, 5);

            //Cache instance = Activator.CreateInstance<Cache>();

            Type type = typeof(Cache);
            Cache instance =(Cache) Activator.CreateInstance(type, true);


            //Addition instance2 = Activator.CreateInstance<Addition>();

            //Assembly assem1 = typeof(Addition).Assembly;
            //Addition p1 = (Addition)assem1.CreateInstance("DesignPatternDimitri.Creazionali.Singleton.Addition");

            //Assembly assem = typeof(Cache).Assembly;
            //Cache p = (Cache)assem.CreateInstance("DesignPatternDimitri.Creazionali.Singleton.Cache");

            //var singleton = typeof(Cache).GetProperty("Instance").GetValue(null);

            //var a = 3;
            //var c = Globals.Cache;
            //var c1 = Globals.Cache;
            //var c2 = Globals.Cache2;
            //int a = 3;
            //Db db = Db.Instance;
            //Db db2 = Db.Instance;

            Console.ReadLine();
        }
        public static T DeserializeToObject<T>(string filepath) where T : class
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(T));

            using (StreamReader sr = new StreamReader(filepath))
            {
                return (T)ser.Deserialize(sr);
            }
        }
        public static void SerializeToXml<T>(T anyobject, string xmlFilePath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(anyobject.GetType());

            using (StreamWriter writer = new StreamWriter(xmlFilePath))
            {
                xmlSerializer.Serialize(writer, anyobject);
            }
        }

        private static readonly List<VectorObject> vectorObjects = new List<VectorObject>
            {
                new VectorRectangle(1,1,10,10),
                 new VectorRectangle(3,3,6,6)
            };
        private static void DrawPoints()
        {
            foreach (VectorObject vo in vectorObjects)
            {
                foreach (Line Line in vo)
                {
                    var adapter = new LineToPointAdapter(Line);
                    foreach (Point p in adapter)
                    {
                        DrawPoint(p);
                       
                    }
                }
            }
        }

        private static List<Point> points = new List<Point>();
        private static bool prepared = false;

        private static void Prepare()
        {
            if (prepared) return;

            foreach (var vo in vectorObjects)
            {
                foreach (Line line in vo)
                {
                    var adapter = new LineToPointAdapter(line);
                    foreach (Point p in adapter)
                    {
                        points.Add(p);
                    }
                }
            }
            prepared = true;
        }
        public static void DrawPointLazy()
        {
            Prepare();
            foreach (Point p in points)
            {
                DrawPoint(p);

            }
        }
        public static void DrawPoint(Point p)
        {
            Console.WriteLine("set x=" + p.X + " y=" + p.Y);
            //Bitmap.setpixel(p.X, p.Y, Color.Black);
        }
        private static void BuildEmail(MailService.EmailBuilder builder)
        {
            builder.From("foo@bar.com");
                //.("...");
        }
    }
}
