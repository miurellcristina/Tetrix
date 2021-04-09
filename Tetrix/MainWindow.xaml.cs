using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Tetris
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //Lista para agregar dos sonitos (wav)
        List<System.Media.SoundPlayer> soundList = new List<System.Media.SoundPlayer>();

        //DispatcherTime
        DispatcherTimer Timer;

        //Figuras Random
        Random shapeRandom;
        //Colores de las figuras
        private static Color O_TetrominoColor = Colors.GreenYellow;
        private static Color I_TetrominoColor = Colors.Red;
        private static Color T_TetrominoColor = Colors.Gold;
        private static Color S_TetrominoColor = Colors.Purple;
        private static Color Z_TetrominoColor = Colors.Blue;
        private static Color J_TetrominoColor = Colors.Yellow;
        private static Color L_TetrominoColor = Colors.Pink;


        //Lista de posiciones actuales
        //Row
        List<int> currentTetrominoRow = null;

        //Columna
        List<int> currentTetrominoColumn = null;

        //Variable de nivel
        private int gameLevel = 1;

        //Variable del score
        private int gameScppre = 0;

        //Variable para contar la velocidad
        private int gameSpeed = 0;

        //Variable para game over
        private bool isgameover = false;

        //Variable para verificar choques con limites
        private bool bottomCollided = false;
        private bool leftCollided = false;
        private bool rightCollided = false;

        // Variable  para saber si giro
        private bool risRotated = false;
        private int rotation = 0;

        // reproducir el sonido. Index =0 ->collides.wav e Index =1 -> delete line
        private void playSound(int index)
        {
            soundList[index].Play();

        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}