// Import C# namespaces
using System;
using System.Collections.Generic;

// Import RhinoCommon namespaces
using Rhino;
using Rhino.Geometry;
using Rhino.Commands;
using Rhino.Input.Custom;

// Namespace
namespace McMaps
{
    // 1. Create New class that inherits from Rhino Command
    public class McMap : Command
    {
        // 2. Create command constractor
        public McMap()
        {
            Instance = this;
        }

        // 3. Create the only instance of this command
        public static McMap Instance { get; private set; }

        // 4. The command name as it appears on the Rhino command line
        public override string EnglishName => "McMap";

        // 5. Actual command code
        protected override Result RunCommand(RhinoDoc doc, RunMode mode)
        {
            // Write to Rhino Console
            // RhinoApp.WriteLine("Hello Map");

            // Create and show the window
            var mapWindow = new UI.MapWindow();
            mapWindow.Show();
            
            // Return success
            return Result.Success;
        }
    }
}