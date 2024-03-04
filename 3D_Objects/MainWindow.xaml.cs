using HelixToolkit.Wpf;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Media3D;

namespace _3D_Objects
{
    public partial class MainWindow : Window
    {

        private const string MODEL_PATH = "C:\\Users\\oouazzanitouhami\\source\\repos\\3D_Objects\\3D_Objects\\Objects\\BMW Manifold.ply";

        public MainWindow()
        {
            InitializeComponent();

            ModelVisual3D device3D = new ModelVisual3D();
            device3D.Content = Display3d(MODEL_PATH);
            viewPort3d.Children.Add(device3D);
        }


        private Model3D Display3d(string model)
        {
            Model3D device = null;

            try
            {
                viewPort3d.RotateGesture = new MouseGesture(MouseAction.LeftClick);
                ModelImporter import = new ModelImporter();
                device = import.Load(model);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return device;
        }
    }
}