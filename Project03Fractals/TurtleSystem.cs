﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Animation;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project03Fractals
{
    class TurtleSystem
    {
        private Stack<Turtle> state;
        private MeshGeometry3D mesh;

        public TurtleSystem(MeshGeometry3D theMesh)
        {
            mesh = theMesh;
        }


    }
}
