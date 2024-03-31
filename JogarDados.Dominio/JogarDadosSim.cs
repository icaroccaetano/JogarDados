namespace JogarDados.Dominio
{
    public class JogarDadosSim
    {
        public int SimularDados (String jog1, String jog2, int nrodadas)
        {
            int pont1 = 0, pont2 = 0;
            int dado1 = 0, dado2 = 0;
            int rodada = 1;
            
            Random r = new Random ();

            //Rodadas iniciais 

            for (; nrodadas > 0; nrodadas--)
            {
                dado1 = r.Next(1, 6);
                dado2 = r.Next(1, 6);

                if (dado1 > dado2)
                {
                    pont1++;
                    Console.WriteLine(jog1 + " tirou o numero " + dado1 + " e " + jog2 + " o numero " + dado2 + ". " + jog1 + " venceu a rodada" + rodada + ".");
                }
                else if (dado1 < dado2)
                {
                    pont2++;
                    Console.WriteLine(jog1 + " tirou o numero " + dado1 + " e " + jog2 + " o numero " + dado2 + ". " + jog2 + " venceu a rodada" + rodada + ".");
                }
                else
                {
                    Console.WriteLine(jog1 + " tirou o numero " + dado1 + " e " + jog2 + " o numero " + dado2 + ". Empate");
                }

                Console.WriteLine("Pontos do jogador " + jog1 + ": " + pont1 + ". Pontos do jogador " + jog2 + ": " + pont2);
                rodada++;
                Console.WriteLine();
            }
            // Desempate -> CASO NECESSARIO
            while (pont1 == pont2)
            {
                for (; nrodadas > 0; nrodadas--)
                    dado1 = r.Next(1, 6);
                    dado2 = r.Next(1, 6);

                    if (dado1 > dado2)
                    {
                        pont1++; 
                        Console.WriteLine(jog1 + " tirou o numero " + dado1 + " e " + jog2 + " o numero " + dado2 + ". " + jog1 + " venceu a rodada" + rodada + ".");
                    }
                    else if (dado1 < dado2)
                    {
                        pont2++;
                        Console.WriteLine(jog1 + " tirou o numero " + dado1 + " e " + jog2 + " o numero " + dado2 + ". " + jog2 + " venceu a rodada" + rodada + ".");
                    }
                    else
                    {
                        Console.WriteLine(jog1 + " tirou o numero " + dado1 + " e " + jog2 + " o numero " + dado2 + ". Empate");
                    }
                
                Console.WriteLine("Pontos do jogador " + jog1 + ": " + pont1 + ". Pontos do jogador " + jog2 + ": " + pont2);
                rodada++;
                Console.WriteLine();
            }

            if (pont1 > pont2) return 1;
            else return 2;  
        }
    }
}
