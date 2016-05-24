﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphLibrary
{
    public class GraphNode<T>
    {
        public T Value { get; set; }
        public int Id { get; internal set; }

        public List<Connection<T>> OutConnections { get; internal set; }
        public List<Connection<T>> InConnections { get; internal set; }

        public float CoordX { get; set; }
        public float CoordY { get; set; }
        public float CenterCoordX { get; set; }
        public float CenterCoordY { get; set; }

        public bool Visisted { get; set; }
        public bool Highlighted { get; set; }
        public bool Blocked { get; set; }


        

        public GraphNode(int id, T value)
        {
            Id = id;
            Value = value;
            OutConnections = new List<Connection<T>>();
            InConnections = new List<Connection<T>>();
            CoordX = 0;
            CoordY = 0;
            Visisted = false;
            Highlighted = false;
            Blocked = false;
        }

        public List<Connection<T>> FindLongeststWay(Graph<T> graph, GraphNode<T> to)
        {
            if (this == to) return new List<Connection<T>>();
            else
            {
                Visisted = true;    //mark node as visited to avoid loop
                List<Connection<T>> temp;
                List<Connection<T>> maxWay = new List<Connection<T>>(); //result
                int max = int.MinValue;

                foreach (Connection<T> connection in OutConnections)
                {
                    if (!connection.Blocked)
                    {
                        temp = new List<Connection<T>>();
                        temp.Add(connection);   //include current connection

                        if (connection.Destination != to)   //we're not at destination, go recursively
                        {
                            if (!connection.Destination.Visisted && !connection.Destination.Blocked)
                            {
                                List<Connection<T>> foo = connection.Destination.FindLongeststWay(graph, to);
                                if (foo != null)
                                    temp.AddRange(foo);
                            }
                        }
                        if (temp.Count != 0 && temp.Last().Destination == to)
                        {
                            if (max <= graph.CountWayNodes(temp))
                            {
                                maxWay = temp;
                                max = graph.CountWayNodes(maxWay);
                            }

                        }

                    }
                }
                Visisted = false;
                if (maxWay.Count != 0 && maxWay.Last().Destination != to) return null;
                else return maxWay;
            }
        }


        

    }
}
