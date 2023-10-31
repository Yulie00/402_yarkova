﻿using BERTTokenizers;
//using Microsoft.ML.Data;
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;
using System;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using System;
using static System.Net.Mime.MediaTypeNames;
namespace NugPack
{
    class Programm
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello");
            string inputText =
                """
            This  hobbit  was  a  very  well-to-do  hobbit,  and  his  name  was  Baggins.  The 
            Bagginses  had  lived  in  the  neighbourhood  of  The  Hill  for  time  out  of mind,  and 
            people considered them very respectable, not only because most of them were rich, 
            but  also  because  they  never had  any  adventures or did  anything unexpected: you 
            could tell what a Baggins would say on any question without the bother of asking 
            him. This  is a story of how a Baggins had an adventure,  found himself doing and 
            saying things altogether unexpected. He may have lost the neighbours' respect, but 
            he gained-well, you will see whether he gained anything in the end.
            The  mother  of  our  particular  hobbit  …  what  is  a  hobbit?  I  suppose  hobbits 
            need  some description nowadays,  since  they have become  rare  and  shy of the Big 
            People,  as  they  call  us.  They  are  (or  were)  a  little  people,  about  half  our  height, 
            and  smaller  than  the  bearded Dwarves. Hobbits  have  no  beards. There  is  little  or 
            no  magic  about  them,  except  the  ordinary  everyday  sort  which  helps  them  to 
            disappear  quietly  and  quickly  when  large  stupid  folk  like  you  and  me  come 
            blundering  along,  making  a  noise  like  elephants  which  they  can  hear  a  mile  off. 
            They  are  inclined  to  be    at  in  the  stomach;  they  dress  in  bright  colours  (chiefly 
            green  and  yellow);  wear  no  shoes,  because  their  feet  grow  natural  leathery  soles 
            and thick warm brown hair like the stuff on their heads (which is curly); have long 
            clever brown fingers, good-natured faces, and laugh deep fruity laughs (especially 
            after  dinner,  which  they  have  twice  a  day when  they  can  get  it). Now  you  know 
            enough  to  go  on  with.  
            """;
            string question1 = "Where did baggins live?";
            string question2 = "What this text is about?";


            NugPack.Class1.Download_Network();
            foreach (string str in NugPack.Class1.Answer_Generate(inputText, question1, question2))
            {
                Console.WriteLine(str);
            }
            //Answer_Generate(inputText, question1);
        }
    }
}
