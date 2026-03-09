using generetor;
using Raylib_cs;

namespace Generetor{
    public class geraBola{
        List<Bola> bola = new List<Bola>(); //Sera feito um sistema que apagara todas as bolas
        public int xBola,yBola;
        public int qtBolas = 0;

        public void verificaClick(){
            xBola = Raylib.GetMouseX();
            yBola = Raylib.GetMouseY();

            if (Raylib.IsMouseButtonDown(MouseButton.Left)){
                Bola b = new Bola();
                
                Console.WriteLine($"{qtBolas}");
                b.x = xBola;
                b.y = yBola;
                qtBolas ++;
                if(qtBolas <= 10){
                    bola.Insert(0,b);
                }
                
            }
        }

        public void desenhaBola()
        {
            foreach(Bola b in bola){
                Raylib.DrawCircle(b.x,b.y,50,Color.Blue);
            }

            if (Raylib.IsKeyPressed(KeyboardKey.R)){
                bola.Clear();
                qtBolas = 0;
            }
        }

    }
}