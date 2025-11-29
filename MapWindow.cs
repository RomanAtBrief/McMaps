// Import Eto UI framework namespaces
using Eto.Forms;
using Eto.Drawing;

// Import system namespaces for file and resource handling
using System.IO;
using System.Reflection;

namespace McMaps.UI
{
    // Main map window that displays a MapBox map in a WebView
    public class MapWindow : Form
    {
        // Private field to hold the WebView control
        private WebView _webView;

        // Constructor - initializes the map window
        public MapWindow()
        {
            // Set window title
            Title = "Map Viewer";
            
            // Set window size (width, height)
            ClientSize = new Size(1200, 800);
            
            // Create a new WebView control to display HTML content
            _webView = new WebView();
            
            // Set the WebView as the main content of the window
            Content = _webView;
            
            // Load the MapBox map into the WebView
            LoadMapBox();
        }

        // Loads the MapBox HTML content into the WebView
        private void LoadMapBox()
        {
            // Load the HTML file from embedded resources
            string html = LoadEmbeddedResource("McMaps.map.html");
            
            // Display the HTML content in the WebView
            _webView.LoadHtml(html);
        }

        // Loads an embedded resource file as a string
        // Parameter: resourceName - Full resource name (namespace.folder.filename)
        // Returns: The content of the embedded resource as a string
        private string LoadEmbeddedResource(string resourceName)
        {
            // Get a reference to the current assembly (the compiled DLL)
            var assembly = Assembly.GetExecutingAssembly();
            
            // Open the embedded resource as a stream and read it as text
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                // Read all content and return as string
                return reader.ReadToEnd();
            }
        }
    }
}