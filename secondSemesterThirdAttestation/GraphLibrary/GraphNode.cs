using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphLibrary
{
    public class GraphNode
    {
        public string Value { get; set; }
        public int Id { get; internal set; }

        public List<Connection> OutConnections { get; internal set; }
        public List<Connection> InConnections { get; internal set; }

        public float CoordX { get; set; }
        public float CoordY { get; set; }
        public float CenterCoordX { get; set; }
        public float CenterCoordY { get; set; }

        public bool Visisted { get; set; }
        public bool Highlighted { get; set; }
        public bool Blocked { get; set; }

        public static int LEFstring = 0;
        public static int RIGHstring = 1;
        public static int UP = 2;
        public static int DOWN = 3;


        

        public GraphNode(int id, string value)
        {
            Id = id;
            Value = value;
            OutConnections = new List<Connection>();
            InConnections = new List<Connection>();
            CoordX = 0;
            CoordY = 0;
            Visisted = false;
            Highlighted = false;
            Blocked = false;
        }

        public GraphNode(int id, string value, int X, int Y)
        {
            Id = id;
            Value = value;
            OutConnections = new List<Connection>();
            InConnections = new List<Connection>();
            CoordX = X;
            CoordY = Y;
            Visisted = false;
            Highlighted = false;
            Blocked = false;
        }

        public int FindDirection(GraphNode end)
        {
            if (CoordX == end.CoordX)
            {
                if (CoordY > end.CoordY) return GraphNode.UP;
                else return GraphNode.DOWN;
            }
            else if (CoordY == end.CoordY)
            {
                if (CoordX > end.CoordX) return GraphNode.LEFstring;
                else return GraphNode.RIGHstring;
            }
            else return -1;
        }

        public List<Connection> FindShortestWay(Graph graph, GraphNode to, int prevDirection)
        {
            if (this == to) return new List<Connection>();
            else
            {
                Visisted = true;    //mark node as visited to avoid loop
                List<Connection> temp;
                List<Connection> minWay = new List<Connection>(); //result
                int min = int.MaxValue;

                foreach (Connection connection in OutConnections)
                {
                    if (!connection.Blocked && prevDirection != FindDirection(connection.Destination))
                    {
                        temp = new List<Connection>();
                        temp.Add(connection);   //include current connection

                        if (connection.Destination != to)   //we're not at destination, go recursively
                        {
                            if (!connection.Destination.Visisted && !connection.Destination.Blocked)
                            {
                                List<Connection> foo = connection.Destination.FindShortestWay(graph, to, FindDirection(connection.Destination));
                                if (foo != null)
                                    temp.AddRange(foo);
                            }
                        }
                        if (temp.Count != 0 && temp.Last().Destination == to)
                        {
                            if (min >= graph.FindWayLength(temp))
                            {
                                minWay = temp;
                                min = graph.FindWayLength(minWay);
                            }

                        }

                    }
                }
                Visisted = false;
                if (minWay.Count != 0 && minWay.Last().Destination != to) return null;
                else return minWay;
            }
        }


        

    }
}
