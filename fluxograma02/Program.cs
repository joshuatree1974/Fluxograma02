

namespace Fluxograma02
{
    class Program
    {
        static void Main(string[] args)
        {

           Console.WriteLine("1. INICIO");
           Console.WriteLine("2. COMECEI A TRABALHAR");
           Console.WriteLine("3. RECEBI 10 DOCUMENTOS");
           int documentos =2;
           int contador =0;


           Console.WriteLine("4.AINDA TEM DOCUMENTOS PARA ASSINAR E AUDITAR?");



           while (contador < documentos)
           {


                 Console.WriteLine(" SIM - > AUDITANDO E ASSINANDO ");
                 Console.WriteLine($"DOCUMENTOS {contador + 1} CONCLUINDO");

                 

                 contador++;

           }    


             Console.WriteLine("TODOS OS DOCUMENTOS FORAM CONCLUÍDOS!");

             Console.WriteLine(" JA NAO TEM DOCUMENTOS ");
             Console.WriteLine("AINDA TEM ATIVIDADE");


             bool temAtividade = true;



             if (temAtividade == true)
             {
                Console.WriteLine("SIM TEM ATIVIDADE");  
             }
             else 
             {
                Console.WriteLine("NAO TEM ATIVIDADE");     
             }     
     
               
             Console.WriteLine("6. FIM"); 

             Console.WriteLine("\n*******FIM DO PROGRAMA********"); 
        }

    }    

}







           






        
    


