using System.Security.Cryptography.X509Certificates;
using Raylib_cs;


namespace Generetor{
    internal class Program{
        public static void Main (string[] args){
            geraBola bola = new geraBola();
            Raylib.InitWindow(800,800,"Gerador de Bola"); 
            Raylib.SetTargetFPS(30);
            while (!Raylib.WindowShouldClose()){
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.Black);
                bola.verificaClick();
                bola.desenhaBola();
                Raylib.EndDrawing();
            }
        }
    }
}